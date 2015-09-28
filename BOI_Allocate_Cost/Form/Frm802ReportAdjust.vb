Public Class Frm802ReportAdjust
    Private cx As New NPIData(NPIConnect.NPIRYSV62BOI)
    Private xYear As String
    Private xMonth As String
    Private Sub FrmReportAdjust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cmdExec.Click, AddressOf cmdExec_Click
        AddHandler cmdExport.Click, AddressOf cmdExport_Click
        AddHandler txtMonth.TextChanged, AddressOf Clear_List
        AddHandler txtYear.TextChanged, AddressOf Clear_List
    End Sub
    Private Sub Clear_List()
        cx.ClearButton(pnCondition)
        cmdExport.Enabled = False
    End Sub
    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clear_List()
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Report Adjust recipient details month {0} year {1}", xMonth, xYear)
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgDetail, cdl.FileName, Chr(9))
        End If
    End Sub
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clear_List()
        xYear = txtYear.Text
        xMonth = String.Format("{0:N0}", txtMonth.Text).ToString().PadLeft(2, "0")

        Me.Cursor = Cursors.WaitCursor
        Dim dt As DataTable = cx.GetdataTable(String.Format("select ROW_NUMBER () over (order by mmatdocno) as itemNo,* from BOI.dbo.t_IB302_AdjustRecipientDetail_adjust where mmonth = '{0}' and myear = '{1}'", xMonth, xYear))
        dtgDetail.DataSource = dt.DefaultView
        cx.GridToList(dtgDetail)
        cmdExport.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

End Class