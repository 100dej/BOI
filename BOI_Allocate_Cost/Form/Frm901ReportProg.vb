Public Class Frm901ReportProg
    Private cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private xProg As String = My.Application.ToString
    Private Sub FrmReportProg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler lbUser.SelectedIndexChanged, AddressOf lbUser_SelectedIndexChanged
        DT = cx.GetdataTable(String.Format("select Uname from plannings.dbo.tbl_100userLoginMyProg where Pname ='{0}' group by Uname order by Uname", xProg))
        lbUser.DisplayMember = "Uname"
        lbUser.ValueMember = "Uname"
        lbUser.DataSource = DT
    End Sub
    Private Sub lbUser_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim xUser As String = lbUser.SelectedValue
        Dim DT1 As DataTable = cx.GetdataTable(String.Format("select * from plannings.dbo.tbl_100userLoginMyProg where Uname = '{0}' and Pname = '{1}' order by xid desc", xUser, xProg))
        dtgExcute.DataSource = DT1.DefaultView
        cx.GridToList(dtgExcute)
    End Sub
End Class