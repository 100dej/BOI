Imports VS2005Extender
Public Class FrmMain
    Dim cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        VS2005Style.Extender.SetSchema(DockPanel, VS2005Style.Extender.Schema.FromBase)
        FrmMenu.Show(DockPanel, WeifenLuo.WinFormsUI.DockState.DockLeft)

        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Me.Text = "Pongdej's Projects : BOI : V." & System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        Else
            Dim MeVersion As System.Version = System.Reflection.Assembly.GetExecutingAssembly.GetName.Version()
            Me.Text = String.Format("Pongdej's Projects : BOI : V.{0}.{1}.{2}.{3}", MeVersion.Major, MeVersion.Minor _
            , MeVersion.Build, MeVersion.Revision)
        End If
        
    End Sub
End Class
