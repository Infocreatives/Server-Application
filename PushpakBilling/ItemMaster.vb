Imports System.Data.SqlClient
Public Class ItemMaster
    Dim con As New SqlConnection(ServerDetails)
    Dim Result As String = ""
    Dim ds As New DataSet
    Private Status As String = ""
    Private Param(4) As String
    Private IsPumpChk As Boolean = False
    Private Sub GetParam()
        If Status = "S" Then
            Param(0) = txtName.Text.Trim
            Param(1) = cmbType.SelectedItem.ItemValue.ToString
            IsPumpChk = chkIsPump.Checked
        ElseIf Status = "U" Then
            Param(1) = txtName.Text.Trim
            IsPumpChk = chkIsPump.Checked
        End If
    End Sub
    Private Sub DisableEnable(ByVal Flag As Boolean)
        pnlBase.Enabled = Flag
    End Sub
    Private Sub LoadData()
        If CheckInternetConnection() = True Then
            DisableEnable(False)
            Status = "L"
            bgWorker.RunWorkerAsync()
        Else
            InterNetError()
        End If
    End Sub
    Private Sub ItemMaster_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddItemtypes()
        LoadData()
        ClearForm()
    End Sub
    Private Sub AddItemtypes()
        cmbType.Items.Add(New TextAndValueInCombo(1, "Invoice"))
        cmbType.Items.Add(New TextAndValueInCombo(2, "Challan"))
        cmbType.Items.Add(New TextAndValueInCombo(3, "Tax"))
    End Sub
    Private Sub ItemMaster_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        pnlBase.Left = Me.Width / 2 - pnlBase.Width / 2
        pnlBase.Top = Me.Height / 2 - pnlBase.Height / 2
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub
    Private Sub ClearForm()
        txtName.Clear()
        cmbType.SelectedIndex = -1
        chkIsPump.Checked = False
        cmbType.Enabled = True
        btnSave.Text = "Save"
        txtName.Focus()
    End Sub

    Private Sub bgWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        If Status = "L" Then
            Try
                con.Open()
                Dim da As New SqlDataAdapter("Select [ID],[ItemName],Case When [ItemType]=1 Then 'Invoice' When [ItemType]=2 Then 'Challan' When [ItemType]=3 Then 'Tax' END AS [ItemType],[IsPump] from PUSItem", con)
                ds.Tables.Clear()
                da.Fill(ds, "Data")
                Result = "True"
            Catch ex As Exception
                Result = ex.Message
            Finally
                con.Close()
            End Try
        ElseIf Status = "S" Then
            Try
                con.Open()
                Dim cmd As New SqlCommand("Insert Into PUSItem Values('" & Param(0) & "','" & Param(1) & "','" & IsPumpChk & "')", con)
                cmd.ExecuteNonQuery()
                Result = "True"
            Catch ex As Exception
                Result = ex.Message
            Finally
                con.Close()
            End Try
        ElseIf Status = "D" Then
            Dim transaction As SqlTransaction = Nothing
            Try
                con.Open()
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted)
                Dim cmd As New SqlCommand()
                cmd.Connection = con
                cmd.Transaction = transaction
                cmd.CommandText = "Delete from PUSItem where ID='" + Param(0) + "'"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete from PUSChallanDetails where ChallanID = '" + Param(0) + "'"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete from PUSInvoiceDetails where InvoiceID = '" + Param(0) + "'"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete from PUSTaxDetails where TaxID = '" + Param(0) + "'"
                cmd.ExecuteNonQuery()
                transaction.Commit()
                Result = "True"
            Catch ex As Exception
                If Not transaction Is Nothing Then
                    transaction.Rollback()
                End If
                Result = ex.Message
            Finally
                con.Close()
            End Try
        ElseIf Status = "U" Then
            Dim transaction As SqlTransaction = Nothing
            Try
                con.Open()
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted)
                Dim cmd As New SqlCommand()
                cmd.Connection = con
                cmd.Transaction = transaction
                cmd.CommandText = "UPDATE PUSItem SET ItemName='" & Param(1) & "',IsPump='" & IsPumpChk & "' where ID='" & Param(0) & "'"
                cmd.ExecuteNonQuery()
                transaction.Commit()
                Result = "True"
            Catch ex As Exception
                If Not transaction Is Nothing Then
                    transaction.Rollback()
                End If
                Result = ex.Message
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub LoadDataToGrid()
        Dim dsEmpty As DataSet = Nothing
        dgvItem.DataSource = dsEmpty
        dgvItem.Rows.Clear()
        For Each dr As DataRow In ds.Tables("Data").Rows
            Dim IsPump As String = ""
            If dr.Item("IsPump").ToString = "True" Then
                IsPump = "Yes"
            Else
                IsPump = "No"
            End If
            dgvItem.Rows.Add(dr.Item("ItemName").ToString, dr.Item("ItemType").ToString, IsPump, "Edit", "Delete", dr.Item("ID").ToString)
        Next
    End Sub
    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        DisableEnable(True)
        If Result = "True" Then
            If Status = "L" Then
                LoadDataToGrid()
                ClearForm()
            ElseIf Status = "S" Then
                LoadData()
                ClearForm()
            ElseIf Status = "D" Then
                LoadData()
                ClearForm()
            ElseIf Status = "U" Then
                LoadData()
                ClearForm()
            End If
        ElseIf Result.Contains("UX_UniqueName") Then
            MsgBox("Item Name already exists")
            txtName.Focus()
        Else
            MsgBox(Result)
        End If
    End Sub
    Private Function ValidateData() As Boolean
        If txtName.Text.Trim = "" Then
            MsgBox("Enter Item Name")
            txtName.Focus()
            Return False
        ElseIf cmbType.SelectedIndex = -1 Then
            MsgBox("Select Item Type")
            cmbType.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If ValidateData() = True Then
            If CheckInternetConnection() = True Then
                If btnSave.Text = "Save" Then
                    ReDim Param(4)
                    Status = "S"
                Else
                    Status = "U"
                End If
                DisableEnable(False)
                GetParam()
                bgWorker.RunWorkerAsync()
            Else
                InterNetError()
            End If
        End If
    End Sub

    Private Sub dgvItem_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItem.CellContentClick
        If e.RowIndex <> -1 Then
            If e.ColumnIndex = 3 Then
                ReDim Param(4)
                Param(0) = dgvItem.Rows(e.RowIndex).Cells(5).Value.ToString
                txtName.Text = dgvItem.Rows(e.RowIndex).Cells(0).Value.ToString
                If dgvItem.Rows(e.RowIndex).Cells(1).Value.ToString = "Invoice" Then
                    cmbType.SelectedIndex = 0
                ElseIf dgvItem.Rows(e.RowIndex).Cells(1).Value.ToString = "Challan" Then
                    cmbType.SelectedIndex = 1
                Else
                    cmbType.SelectedIndex = 2
                End If
                If dgvItem.Rows(e.RowIndex).Cells(2).Value.ToString = "Yes" Then
                    chkIsPump.Checked = True
                Else
                    chkIsPump.Checked = False
                End If
                btnSave.Text = "Update"
                cmbType.Enabled = False
            ElseIf e.ColumnIndex = 4 Then
                If MessageBox.Show("Are you sure you want to delete the product ?", "Admin", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    ReDim Param(4)
                    Param(0) = dgvItem.Rows(e.RowIndex).Cells(5).Value.ToString
                    If CheckInternetConnection() = True Then
                        DisableEnable(False)
                        Status = "D"
                        bgWorker.RunWorkerAsync()
                    Else
                        InterNetError()
                    End If
                End If
            End If
        End If
    End Sub
End Class