<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm901ReportProg
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
        Me.lbUser = New System.Windows.Forms.ListBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.dtgExcute = New System.Windows.Forms.DataGridView
        CType(Me.dtgExcute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbUser
        '
        Me.lbUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbUser.FormattingEnabled = True
        Me.lbUser.Location = New System.Drawing.Point(0, 0)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(141, 394)
        Me.lbUser.TabIndex = 1
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(141, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 402)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'dtgExcute
        '
        Me.dtgExcute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgExcute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgExcute.Location = New System.Drawing.Point(144, 0)
        Me.dtgExcute.Name = "dtgExcute"
        Me.dtgExcute.Size = New System.Drawing.Size(460, 402)
        Me.dtgExcute.TabIndex = 3
        '
        'FrmReportProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 402)
        Me.Controls.Add(Me.dtgExcute)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.lbUser)
        Me.Name = "FrmReportProg"
        Me.TabText = "FrmReportProg"
        Me.Text = "FrmReportProg"
        CType(Me.dtgExcute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbUser As System.Windows.Forms.ListBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents dtgExcute As System.Windows.Forms.DataGridView
End Class
