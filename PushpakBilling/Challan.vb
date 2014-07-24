Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Public Class Challan

    Dim con As New SqlConnection(ServerDetails)
    Dim Status As String = ""
    Dim Result As String = ""
    Dim ds As New DataSet
    Dim Param(12) As String
    Dim str As String = ""

    Private Sub Challan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If CheckInternetConnection() = True Then
            EnDis(False)
            Status = "L"
            bgWorker.RunWorkerAsync()
        Else
            InterNetError()
        End If
    End Sub
    Private Sub ClearText()
        For Each ctrl As Control In pnlC0.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl As Control In pnlSlNo.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl As Control In pnlSP.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl As Control In pnlQ.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl As Control In pnlR.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl As Control In pnlA.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        pnlC0.Visible = False
    End Sub
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub SelectRecord()
        If CheckInternetConnection() = True Then
            EnDis(False)
            Status = "S"
            GetParam()
            bgWorker.RunWorkerAsync()
        Else
            InterNetError()
        End If
    End Sub
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearText()
    End Sub

    Private Sub bgWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        If Status = "S" Then
            Try
                con.Open()
                Dim da As New SqlDataAdapter("Select * from PUSChallanDetails where ChallanID='" & Param(0) & "'", con)
                ds.Tables.Clear()
                da.Fill(ds, "Data")
                Result = "True"
            Catch ex As Exception
                Result = ex.Message
            Finally
                con.Close()
            End Try
        ElseIf Status = "A" Then
            Dim trn As SqlTransaction
            Try
                con.Open()
                trn = con.BeginTransaction(IsolationLevel.ReadCommitted)
                Dim cmdCommand As SqlCommand = New SqlCommand("Delete from PUSChallanDetails where ChallanID='" & Param(0) & "'", con, trn)
                cmdCommand.ExecuteNonQuery()
                Dim cmd As SqlCommand
                cmd = New SqlCommand("Insert into PUSChallanDetails(ChallanID,ChallanData) values ('" & Param(0) & "','" & str & "')", con, trn)
                cmd.ExecuteNonQuery()
                trn.Commit()
                Result = "True"
            Catch ex As Exception
                trn.Rollback()
                Result = ex.Message
            Finally
                con.Close()
            End Try
        ElseIf Status = "L" Then
            Try
                con.Open()
                Dim da As New SqlDataAdapter("Select * from PUSItem where ItemType='2'", con)
                ds.Tables.Clear()
                da.Fill(ds, "Data")
                Result = "True"
            Catch ex As Exception
                Result = ex.Message
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        EnDis(True)
        If Result = "True" Then
            If Status = "S" Then
                Try
                    If ds.Tables.Count > 0 Then
                        For Each dr As DataRow In ds.Tables("Data").Rows
                            If dr.Item(1).ToString.Trim <> "" Then
                                Dim arr() As String
                                arr = dr.Item(1).ToString.Split("|")
                                Dim arrSlno() As String
                                arrSlno = arr(0).Split("$")
                                Dim int As Integer = 0
                                For Each cntrl As Control In pnlSlNo.Controls
                                    If TypeOf cntrl Is TextBox Then
                                        Dim arrSing() As String = arrSlno(int).Split("~")
                                        cntrl.Text = arrSing(2)
                                        int += 1
                                    End If
                                Next
                                Dim arrPerticular() As String
                                arrPerticular = arr(1).Split("$")
                                int = 0
                                For Each cntrl As Control In pnlSP.Controls
                                    If TypeOf cntrl Is TextBox Then
                                        Dim arrSing() As String = arrPerticular(int).Split("~")
                                        cntrl.Text = arrSing(2)
                                        int += 1
                                    End If
                                Next
                                Dim arrQuantity() As String
                                arrQuantity = arr(2).Split("$")
                                int = 0
                                For Each cntrl As Control In pnlQ.Controls
                                    If TypeOf cntrl Is TextBox Then
                                        Dim arrSing() As String = arrQuantity(int).Split("~")
                                        cntrl.Text = arrSing(2)
                                        int += 1
                                    End If
                                Next
                                Dim arrRate() As String
                                arrRate = arr(3).Split("$")
                                int = 0
                                For Each cntrl As Control In pnlR.Controls
                                    If TypeOf cntrl Is TextBox Then
                                        Dim arrSing() As String = arrRate(int).Split("~")
                                        cntrl.Text = arrSing(2)
                                        int += 1
                                    End If
                                Next
                                Dim arrAmount() As String
                                arrAmount = arr(4).Split("$")
                                int = 0
                                For Each cntrl As Control In pnlA.Controls
                                    If TypeOf cntrl Is TextBox Then
                                        Dim arrSing() As String = arrAmount(int).Split("~")
                                        cntrl.Text = arrSing(2)
                                        int += 1
                                    End If
                                Next
                                txtTotalAmount.Text = arr(5)
                                txtVat.Text = arr(6)
                                txtVatAmount.Text = arr(7)
                                txtNetAmount.Text = arr(8)
                                txtAmount.Text = arr(9)
                            End If
                        Next
                        pnlC0.Visible = True
                    Else
                        MsgBox("Error fetching data from remote server")
                        cmbSelectProduct.SelectedIndex = -1
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    cmbSelectProduct.SelectedIndex = -1
                End Try
            ElseIf Status = "A" Then
                MsgBox("Challan Saved Successfully")
                ClearText()
                cmbSelectProduct.SelectedIndex = -1
            ElseIf Status = "L" Then
                If ds.Tables.Count > 0 Then
                    If ds.Tables("Data").Rows.Count > 0 Then
                        For Each dr As DataRow In ds.Tables("Data").Rows
                            cmbSelectProduct.Items.Add(New TextAndValueInCombo(dr.Item("ID").ToString, dr.Item("ItemName").ToString))
                        Next
                    Else
                        MsgBox("Products not available")
                    End If
                Else
                    MsgBox("Products not available")
                End If
                ClearText()
                cmbSelectProduct.SelectedIndex = -1
            End If
        Else
            If Status = "S" Then
                cmbSelectProduct.SelectedIndex = -1
            End If
            MsgBox(Result)
        End If
    End Sub

    Private Sub GetParam()
        ReDim Param(12)
        If Status = "S" Then
            Param(0) = cmbSelectProduct.SelectedItem.ItemValue.ToString
        ElseIf Status = "A" Then
            Param(0) = cmbSelectProduct.SelectedItem.ItemValue.ToString
            str = ""
            Dim int As Integer = 400
            For Each ctrl As Control In pnlSlNo.Controls
                If TypeOf ctrl Is TextBox Then
                    str = str + "40~" + CStr(int) + "~" + ctrl.Text + "$"
                    int += 20
                End If
            Next
            str = str + "|"
            int = 400
            For Each ctrl As Control In pnlSP.Controls
                If TypeOf ctrl Is TextBox Then
                    str = str + "105~" + CStr(int) + "~" + ctrl.Text + "$"
                    int += 20
                End If
            Next
            str = str + "|"
            int = 400
            For Each ctrl As Control In pnlQ.Controls
                If TypeOf ctrl Is TextBox Then
                    str = str + "435~" + CStr(int) + "~" + ctrl.Text + "$"
                    int += 20
                End If
            Next
            str = str + "|"
            int = 400
            For Each ctrl As Control In pnlR.Controls
                If TypeOf ctrl Is TextBox Then
                    str = str + "515~" + CStr(int) + "~" + ctrl.Text + "$"
                    int += 20
                End If
            Next
            str = str + "|"
            int = 400
            For Each ctrl As Control In pnlA.Controls
                If TypeOf ctrl Is TextBox Then
                    str = str + "650~" + CStr(int) + "~" + ctrl.Text + "$"
                    int += 20
                End If
            Next
            str = str + "|" + txtTotalAmount.Text + "|" + txtVat.Text + "|" + txtVatAmount.Text + "|" + txtNetAmount.Text + "|" + txtAmount.Text
            str = str.Replace("'", "^")
        End If
    End Sub
    Private Sub EnDis(ByVal Bool As Boolean)
        pnlBottom.Enabled = Bool
        cmbSelectProduct.Enabled = Bool
        pnlMain.Enabled = Bool
        pnlImage.Visible = Not Bool
    End Sub
    Private Function ValidateData() As Boolean
        If txtTotalAmount.Text.Trim = "" Then
            MsgBox("Enter Total amount")
            txtTotalAmount.Focus()
            Return False
        ElseIf txtVat.Text.Trim = "" Then
            MsgBox("Enter vat percentage")
            txtVat.Focus()
            Return False
        ElseIf txtVatAmount.Text.Trim = "" Then
            MsgBox("Enter vat amount")
            txtVatAmount.Focus()
            Return False
        ElseIf txtNetAmount.Text.Trim = "" Then
            MsgBox("Enter net amount")
            txtNetAmount.Focus()
            Return False
        ElseIf txtAmount.Text = "" Then
            MsgBox("Enter amount in words")
            txtAmount.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub btnSave_Click(sender As Object, e As System.EventArgs) Handles btnSave.Click
        If ValidateData() = True Then
            If CheckInternetConnection() = True Then
                EnDis(False)
                Status = "A"
                GetParam()
                bgWorker.RunWorkerAsync()
            Else
                InterNetError()
            End If
        End If
    End Sub
    Private Sub cmbSelectProduct_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbSelectProduct.SelectedIndexChanged
        ClearText()
        If cmbSelectProduct.SelectedIndex <> -1 Then
            SelectRecord()
        End If
    End Sub

    Private Sub txtS1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtS21.KeyPress, txtS20.KeyPress _
          , txtS19.KeyPress, txtS18.KeyPress, txtS17.KeyPress, txtS16.KeyPress, txtS15.KeyPress, txtS14.KeyPress, txtS13.KeyPress, txtS12.KeyPress _
          , txtS11.KeyPress, txtS10.KeyPress, txtS9.KeyPress, txtS8.KeyPress, txtS7.KeyPress, txtS6.KeyPress, txtS5.KeyPress, txtS4.KeyPress _
          , txtS3.KeyPress, txtS2.KeyPress
        e.Handled = NumericKey(Asc(e.KeyChar))
    End Sub

    Private Sub txtP1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtP21.KeyPress, txtP20.KeyPress _
        , txtP19.KeyPress, txtP18.KeyPress, txtP17.KeyPress, txtP16.KeyPress, txtP15.KeyPress, txtP14.KeyPress, txtP13.KeyPress, txtP12.KeyPress _
        , txtP11.KeyPress, txtP10.KeyPress, txtP9.KeyPress, txtP8.KeyPress, txtP7.KeyPress, txtP6.KeyPress, txtP5.KeyPress, txtP4.KeyPress _
        , txtP3.KeyPress, txtP2.KeyPress, txtAmount.KeyPress
        e.Handled = RestrictKey(Asc(e.KeyChar))
    End Sub

    Private Sub txtQ1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQ21.KeyPress, txtQ20.KeyPress _
        , txtQ19.KeyPress, txtQ18.KeyPress, txtQ17.KeyPress, txtQ16.KeyPress, txtQ15.KeyPress, txtQ14.KeyPress, txtQ13.KeyPress, txtQ12.KeyPress _
        , txtQ11.KeyPress, txtQ10.KeyPress, txtQ9.KeyPress, txtQ8.KeyPress, txtQ7.KeyPress, txtQ6.KeyPress, txtQ5.KeyPress, txtQ4.KeyPress _
        , txtQ3.KeyPress, txtQ2.KeyPress
        e.Handled = NumericKey(Asc(e.KeyChar))
    End Sub

    Private Sub txtR1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtR17.KeyPress, txtR16.KeyPress _
        , txtR15.KeyPress, txtR14.KeyPress, tctR13.KeyPress, txtR12.KeyPress _
        , txtR11.KeyPress, txtR10.KeyPress, txtR9.KeyPress, txtR8.KeyPress, txtR7.KeyPress, txtR6.KeyPress, txtR5.KeyPress, txtR4.KeyPress
        e.Handled = FloatKey(Asc(e.KeyChar))
    End Sub

    Private Sub txtA1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtA17.KeyPress, txtA16.KeyPress _
        , txtA15.KeyPress, txtA14.KeyPress, txtA13.KeyPress, txtA12.KeyPress _
        , txtA11.KeyPress, txtA10.KeyPress, txtA9.KeyPress, txtA8.KeyPress, txtA7.KeyPress, txtA6.KeyPress, txtA5.KeyPress, txtA4.KeyPress _
        , txtTotalAmount.KeyPress, txtVatAmount.KeyPress, txtNetAmount.KeyPress, txtVat.KeyPress
        e.Handled = FloatKey(Asc(e.KeyChar))
    End Sub

    Private Sub Challan_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        pnlImage.Left = Width / 2 - pnlImage.Width / 2
        pnlMain.Left = Width / 2 - pnlMain.Width / 2
        pnlBottom.Left = pnlMain.Right - pnlBottom.Width
        pnlTop.Left = Width / 2 - pnlTop.Width / 2
        lblNote.Left = pnlMain.Left
    End Sub
End Class
