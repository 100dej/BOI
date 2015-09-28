Public Class Frm801ReportData
    Private cx As New NPIData(NPIConnect.NPIRYSV62BOI)
    Private Sub FrmReportPreAdjust_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As DataTable = cx.GetdataTable("select * from BOI.dbo.t_IB301_AdjustRecipientHeader_pre")
        dtgPreDetail.DataSource = dt
        cx.GridToList(dtgPreDetail)

        Dim dt1 As DataTable = cx.GetdataTable("select * from BOI.dbo.t_IB301_AdjustRecipientHeader")
        dtgProDetail.DataSource = dt1
        cx.GridToList(dtgProDetail)


        Dim dt2 As DataTable = cx.GetdataTable("select * from BOI.dbo.t_IB301_AdjustRecipientHeader_delete")
        dtgDeleteDetail.DataSource = dt2
        cx.GridToList(dtgDeleteDetail)


    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        FrmReportPreAdjust_Load(sender:=Nothing, e:=Nothing)
    End Sub
End Class