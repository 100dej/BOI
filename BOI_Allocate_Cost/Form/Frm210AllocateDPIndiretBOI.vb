﻿Public Class Frm210AllocateDPIndirectBOI
    Private cx As New NPIData(NPIConnect.NPIRYSV62BOI)
    Private xYear As String
    Private xMonth As String
    Private dv As DataView
    Private Sub FrmDetailsCost_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler cmdExec.Click, AddressOf cmdExec_Click
        AddHandler txtMonth.TextChanged, AddressOf Clear_List
        AddHandler txtYear.TextChanged, AddressOf Clear_List
        AddHandler dtgSummary.DoubleClick, AddressOf dtgSummary_DoubleClick
        AddHandler lblStatus.Click, AddressOf lblStatus_Click
        AddHandler cmdExport1.Click, AddressOf cmdExport1_Click
        AddHandler cmdExport2.Click, AddressOf cmdExport2_Click
        Label3.Text = String.Empty
        Label4.Text = String.Empty
    End Sub
    Private Sub Clear_List()
        cx.ClearButton(pnCondition)
        cx.ClearButton(Panel4)
        cx.ClearButton(Panel3)
        cmdExport1.Enabled = False
        cmdExport2.Enabled = False
        Label3.Text = String.Empty
        Label4.Text = String.Empty
    End Sub
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clear_List()
        xYear = txtYear.Text
        xMonth = String.Format("{0:N0}", txtMonth.Text).ToString().PadLeft(2, "0")

        Me.Cursor = Cursors.WaitCursor
        Dim dt As DataTable = cx.GetdataTable(String.Format("select *	from boi.dbo.FT_GroupDepre('{0}','{1}')	where Depre != 0 and mCctrType_Allocate='Service' and  mroom !=''", xMonth, xYear))
        dtgSummary.DataSource = dt.DefaultView
        cx.GridToList(dtgSummary)
        Label3.Text = String.Format("{0:N2}", dt.Compute("sum(depre)", ""))
        cmdExport1.Enabled = True
        Dim dt1 As DataTable = cx.GetdataTable(String.Format("select * from boi.dbo.FT_AllocateBOIService('{0}','{1}')", xMonth, xYear))
        dv = dt1.DefaultView
        dtgDetails.DataSource = dv
        cx.GridToList(dtgDetails)
        Label4.Text = String.Format("{0:N2}", dt1.Compute("sum([Allocate_depre])", ""))
        cmdExport2.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub dtgSummary_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim x As DataGridView = sender
        Dim y As String = x.CurrentCell.Value.ToString
        Try
            dv.RowFilter = String.Format("mcostelement = '{0}'", y)
        Catch ex As Exception
            lblStatus_Click(sender:=Nothing, e:=Nothing)
            Exit Sub
        End Try

        lblStatus.Visible = True
        lblFilter.Visible = True
        lblFilter.Text = String.Format("mcostelement : {0} / ", y)
    End Sub
    Private Sub lblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dv.RowFilter = Nothing
        lblFilter.Text = "Filter By ==> "
        lblStatus.Visible = False
        lblFilter.Visible = False
    End Sub
    Private Sub cmdExport1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clear_List()
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Report Depre Service fix BOI month {0} year {1}", xMonth, xYear)
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgSummary, cdl.FileName, Chr(9))
        End If
    End Sub
    Private Sub cmdExport2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clear_List()
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Report Depre Service fix BOI details month {0} year {1}", xMonth, xYear)
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgDetails, cdl.FileName, Chr(9))
        End If
    End Sub
End Class