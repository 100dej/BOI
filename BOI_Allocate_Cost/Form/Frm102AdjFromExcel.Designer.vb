<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm102AdjFromExcel
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdSave = New BOI_Allocate_Cost.NPIButton
        Me.cmdImport = New BOI_Allocate_Cost.NPIButton
        Me.dtgDetail = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.dtgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Controls.Add(Me.cmdImport)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 64)
        Me.Panel1.TabIndex = 0
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.ForeColor = System.Drawing.Color.Blue
        Me.cmdSave.Location = New System.Drawing.Point(257, 12)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdImport
        '
        Me.cmdImport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdImport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdImport.ForeColor = System.Drawing.Color.Blue
        Me.cmdImport.Location = New System.Drawing.Point(114, 12)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(111, 23)
        Me.cmdImport.TabIndex = 0
        Me.cmdImport.Text = "&Import Excel"
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'dtgDetail
        '
        Me.dtgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDetail.Location = New System.Drawing.Point(0, 64)
        Me.dtgDetail.Name = "dtgDetail"
        Me.dtgDetail.Size = New System.Drawing.Size(557, 376)
        Me.dtgDetail.TabIndex = 1
        '
        'FrmAdjFromExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 440)
        Me.Controls.Add(Me.dtgDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmAdjFromExcel"
        Me.TabText = "FrmAdjFromExcel"
        Me.Text = "FrmAdjFromExcel"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdSave As BOI_Allocate_Cost.NPIButton
    Friend WithEvents cmdImport As BOI_Allocate_Cost.NPIButton
    Friend WithEvents dtgDetail As System.Windows.Forms.DataGridView
End Class
