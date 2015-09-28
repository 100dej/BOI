<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits WeifenLuo.WinFormsUI.DockContent

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("001 Product")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("002 Machine")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("003 BOI")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("004 Cost center")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("000 Master data", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("101 Adjust recipient")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("102 Adjust recipient from Excel")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("111 Divide into BOI group")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("100 Manage movement stock", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("211 Allocate FOH")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("212 Allocate 58x")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("213 Allocate 6x")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("221 Net Sales")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("231 Production")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("241 Stock Balance Ending")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("200 Report BOI", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Report log prepare production data")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Report details adjust receipient")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Report User", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Check user used program")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Report Admin", New System.Windows.Forms.TreeNode() {TreeNode20})
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "nd001"
        TreeNode1.Text = "001 Product"
        TreeNode2.Name = "nd002"
        TreeNode2.Text = "002 Machine"
        TreeNode3.Name = "nd003"
        TreeNode3.Text = "003 BOI"
        TreeNode4.Name = "nd004"
        TreeNode4.Text = "004 Cost center"
        TreeNode5.Name = "nd000"
        TreeNode5.Text = "000 Master data"
        TreeNode6.Name = "nd101"
        TreeNode6.Text = "101 Adjust recipient"
        TreeNode7.Name = "nd102"
        TreeNode7.Text = "102 Adjust recipient from Excel"
        TreeNode8.Name = "nd111"
        TreeNode8.Text = "111 Divide into BOI group"
        TreeNode9.Name = "nd100"
        TreeNode9.Text = "100 Manage movement stock"
        TreeNode10.Name = "nd211"
        TreeNode10.Text = "211 Allocate FOH"
        TreeNode11.Name = "nd212"
        TreeNode11.Text = "212 Allocate 58x"
        TreeNode12.Name = "nd213"
        TreeNode12.Text = "213 Allocate 6x"
        TreeNode13.Name = "nd221"
        TreeNode13.Text = "221 Net Sales"
        TreeNode14.Name = "nd231"
        TreeNode14.Text = "231 Production"
        TreeNode15.Name = "nd241"
        TreeNode15.Text = "241 Stock Balance Ending"
        TreeNode16.Name = "nd200"
        TreeNode16.Text = "200 Report BOI"
        TreeNode17.Name = "nd801"
        TreeNode17.Text = "Report log prepare production data"
        TreeNode18.Name = "nd802"
        TreeNode18.Text = "Report details adjust receipient"
        TreeNode19.Name = "nd800"
        TreeNode19.Text = "Report User"
        TreeNode20.Name = "nd901"
        TreeNode20.Text = "Check user used program"
        TreeNode21.Name = "nd900"
        TreeNode21.Text = "Report Admin"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode9, TreeNode16, TreeNode19, TreeNode21})
        Me.TreeView1.Size = New System.Drawing.Size(247, 523)
        Me.TreeView1.TabIndex = 1
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 523)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "FrmMenu"
        Me.TabText = "BOI Menu"
        Me.Text = "BOI Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
End Class
