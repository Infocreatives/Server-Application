Imports System.Data.SqlClient

Public Class MainPage
    Dim con As New SqlConnection(ServerDetails)
    Dim ds As New DataSet
    Dim Result As String = ""
    Dim status As String = ""
    Dim Param As String = ""

    Private Sub OpenChallan()
        Dim ChldForm As New Challan
        ChldForm.MdiParent = Me
        AddHandler ChldForm.FormClosed, AddressOf CloseMain
        ChldForm.WindowState = FormWindowState.Maximized
        ChldForm.Show()
    End Sub
    Private Sub lnkChallan_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkChallan.LinkClicked
        Me.ExpandablePanel1.Enabled = False
        OpenChallan()
    End Sub
    Private Sub CloseMain()
        Me.ExpandablePanel1.Enabled = True
    End Sub
    Private Sub OpenInvoice()
        Dim ChldForm As New Invoice
        ChldForm.MdiParent = Me
        AddHandler ChldForm.FormClosed, AddressOf CloseMain
        ChldForm.WindowState = FormWindowState.Maximized
        ChldForm.Show()
    End Sub
    Private Sub lnkInvoice_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkInvoice.LinkClicked
        Me.ExpandablePanel1.Enabled = False
        OpenInvoice()
    End Sub
    Private Sub EnableDisable(ByVal bool As Boolean)
        ExpandablePanel1.Enabled = bool
        pnlImage.Visible = Not bool
    End Sub
    Private Sub MainPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim year As Integer = CStr(My.Computer.Clock.LocalTime.Year).Substring(2)
        cmbSet.Items.Add(CStr(year - 2) + "-" + CStr(year - 1))
        cmbSet.Items.Add(CStr(year - 1) + "-" + CStr(year))
        cmbSet.Items.Add(CStr(year) + "-" + CStr(year + 1))
        If CheckInternetConnection() = True Then
            EnableDisable(False)
            status = "L"
            bgWorker.RunWorkerAsync()
        Else
            InterNetError()
        End If
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        Try
            If status = "L" Then
                con.Open()
                ds.Tables.Clear()
                Dim da2 As SqlDataAdapter = New SqlDataAdapter("Select * from PUSFY", con)
                da2.Fill(ds, "FY")
                Result = "True"
            ElseIf status = "I" Then
                con.Open()
                Dim cmd As New SqlCommand("Update PUSFY set [FinancialYear]='" + Param + "'", con)
                cmd.ExecuteNonQuery()
                Result = "True"
            End If
        Catch ex As Exception
            Result = ex.Message
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        EnableDisable(True)
        If Result = "True" Then
            If status = "L" Then
                cmbSet.SelectedItem = ds.Tables("FY").Rows(0).Item(0).ToString
            ElseIf status = "I" Then
                MsgBox("Financial year saved successfully")
            End If
        Else
            MsgBox(Result)
        End If
    End Sub

    Private Sub btnSet_Click(sender As System.Object, e As System.EventArgs) Handles btnSet.Click
        If cmbSet.SelectedIndex = -1 Then
            MsgBox("Please select a financial year")
        Else
            If CheckInternetConnection() = True Then
                EnableDisable(False)
                status = "I"
                Param = cmbSet.SelectedItem.ToString
                bgWorker.RunWorkerAsync()
            Else
                InterNetError()
            End If
        End If
    End Sub

    Private Sub MainPage_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        pnlImage.Left = Width / 2 - pnlImage.Width / 2
    End Sub

    Private Sub lnkItemMaster_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkItemMaster.LinkClicked
        Me.ExpandablePanel1.Enabled = False
        OpenItemMaster()
    End Sub
    Private Sub OpenItemMaster()
        Dim ChldForm As New ItemMaster
        ChldForm.MdiParent = Me
        AddHandler ChldForm.FormClosed, AddressOf CloseMain
        ChldForm.WindowState = FormWindowState.Maximized
        ChldForm.Show()
    End Sub
    Private Sub OpenTax()
        Dim ChldForm As New Tax
        ChldForm.MdiParent = Me
        AddHandler ChldForm.FormClosed, AddressOf CloseMain
        ChldForm.WindowState = FormWindowState.Maximized
        ChldForm.Show()
    End Sub
    Private Sub lnkTax_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTax.LinkClicked
        Me.ExpandablePanel1.Enabled = False
        OpenTax()
    End Sub
End Class