<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm001Product
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
        Me.components = New System.ComponentModel.Container
        Me.pnHeader = New System.Windows.Forms.Panel
        Me.pnMattype = New System.Windows.Forms.Panel
        Me.rb33 = New System.Windows.Forms.RadioButton
        Me.rb32 = New System.Windows.Forms.RadioButton
        Me.rb31 = New System.Windows.Forms.RadioButton
        Me.pnBOI = New System.Windows.Forms.Panel
        Me.rb23 = New System.Windows.Forms.RadioButton
        Me.rb22 = New System.Windows.Forms.RadioButton
        Me.rb21 = New System.Windows.Forms.RadioButton
        Me.pnCondition = New System.Windows.Forms.Panel
        Me.cmdSQL = New BOI_Allocate_Cost.NPIButton
        Me.cmdExport = New BOI_Allocate_Cost.NPIButton
        Me.cmdExec = New BOI_Allocate_Cost.NPIButton
        Me.txtMat = New BOI_Allocate_Cost.NPIText
        Me.Label1 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.dtgProduct = New System.Windows.Forms.DataGridView
        Me.lblSQL = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopylblSQL = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdSave = New BOI_Allocate_Cost.NPIButton
        Me.pnHeader.SuspendLayout()
        Me.pnMattype.SuspendLayout()
        Me.pnBOI.SuspendLayout()
        Me.pnCondition.SuspendLayout()
        CType(Me.dtgProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnHeader
        '
        Me.pnHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnHeader.Controls.Add(Me.pnMattype)
        Me.pnHeader.Controls.Add(Me.pnBOI)
        Me.pnHeader.Controls.Add(Me.pnCondition)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(976, 113)
        Me.pnHeader.TabIndex = 0
        '
        'pnMattype
        '
        Me.pnMattype.Controls.Add(Me.rb33)
        Me.pnMattype.Controls.Add(Me.rb32)
        Me.pnMattype.Controls.Add(Me.rb31)
        Me.pnMattype.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMattype.Location = New System.Drawing.Point(610, 0)
        Me.pnMattype.Name = "pnMattype"
        Me.pnMattype.Size = New System.Drawing.Size(366, 113)
        Me.pnMattype.TabIndex = 2
        '
        'rb33
        '
        Me.rb33.AutoSize = True
        Me.rb33.Location = New System.Drawing.Point(15, 58)
        Me.rb33.Name = "rb33"
        Me.rb33.Size = New System.Drawing.Size(55, 17)
        Me.rb33.TabIndex = 5
        Me.rb33.TabStop = True
        Me.rb33.Tag = "3"
        Me.rb33.Text = "not 81"
        Me.rb33.UseVisualStyleBackColor = True
        '
        'rb32
        '
        Me.rb32.AutoSize = True
        Me.rb32.Location = New System.Drawing.Point(15, 38)
        Me.rb32.Name = "rb32"
        Me.rb32.Size = New System.Drawing.Size(37, 17)
        Me.rb32.TabIndex = 4
        Me.rb32.TabStop = True
        Me.rb32.Tag = "2"
        Me.rb32.Text = "81"
        Me.rb32.UseVisualStyleBackColor = True
        '
        'rb31
        '
        Me.rb31.AutoSize = True
        Me.rb31.Location = New System.Drawing.Point(15, 18)
        Me.rb31.Name = "rb31"
        Me.rb31.Size = New System.Drawing.Size(36, 17)
        Me.rb31.TabIndex = 3
        Me.rb31.TabStop = True
        Me.rb31.Tag = "1"
        Me.rb31.Text = "All"
        Me.rb31.UseVisualStyleBackColor = True
        '
        'pnBOI
        '
        Me.pnBOI.Controls.Add(Me.rb23)
        Me.pnBOI.Controls.Add(Me.rb22)
        Me.pnBOI.Controls.Add(Me.rb21)
        Me.pnBOI.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnBOI.Location = New System.Drawing.Point(410, 0)
        Me.pnBOI.Name = "pnBOI"
        Me.pnBOI.Size = New System.Drawing.Size(200, 113)
        Me.pnBOI.TabIndex = 1
        '
        'rb23
        '
        Me.rb23.AutoSize = True
        Me.rb23.Location = New System.Drawing.Point(15, 58)
        Me.rb23.Name = "rb23"
        Me.rb23.Size = New System.Drawing.Size(66, 17)
        Me.rb23.TabIndex = 2
        Me.rb23.TabStop = True
        Me.rb23.Tag = "3"
        Me.rb23.Text = "Non BOI"
        Me.rb23.UseVisualStyleBackColor = True
        '
        'rb22
        '
        Me.rb22.AutoSize = True
        Me.rb22.Location = New System.Drawing.Point(15, 38)
        Me.rb22.Name = "rb22"
        Me.rb22.Size = New System.Drawing.Size(43, 17)
        Me.rb22.TabIndex = 1
        Me.rb22.TabStop = True
        Me.rb22.Tag = "2"
        Me.rb22.Text = "BOI"
        Me.rb22.UseVisualStyleBackColor = True
        '
        'rb21
        '
        Me.rb21.AutoSize = True
        Me.rb21.Location = New System.Drawing.Point(15, 18)
        Me.rb21.Name = "rb21"
        Me.rb21.Size = New System.Drawing.Size(36, 17)
        Me.rb21.TabIndex = 0
        Me.rb21.TabStop = True
        Me.rb21.Tag = "1"
        Me.rb21.Text = "All"
        Me.rb21.UseVisualStyleBackColor = True
        '
        'pnCondition
        '
        Me.pnCondition.Controls.Add(Me.cmdSave)
        Me.pnCondition.Controls.Add(Me.cmdSQL)
        Me.pnCondition.Controls.Add(Me.cmdExport)
        Me.pnCondition.Controls.Add(Me.cmdExec)
        Me.pnCondition.Controls.Add(Me.txtMat)
        Me.pnCondition.Controls.Add(Me.Label1)
        Me.pnCondition.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnCondition.Location = New System.Drawing.Point(0, 0)
        Me.pnCondition.Name = "pnCondition"
        Me.pnCondition.Size = New System.Drawing.Size(410, 113)
        Me.pnCondition.TabIndex = 0
        '
        'cmdSQL
        '
        Me.cmdSQL.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSQL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSQL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSQL.ForeColor = System.Drawing.Color.Blue
        Me.cmdSQL.Location = New System.Drawing.Point(138, 78)
        Me.cmdSQL.Name = "cmdSQL"
        Me.cmdSQL.Size = New System.Drawing.Size(75, 23)
        Me.cmdSQL.TabIndex = 20
        Me.cmdSQL.Text = "&SQL"
        Me.cmdSQL.UseVisualStyleBackColor = True
        '
        'cmdExport
        '
        Me.cmdExport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExport.ForeColor = System.Drawing.Color.Blue
        Me.cmdExport.Location = New System.Drawing.Point(302, 78)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(94, 23)
        Me.cmdExport.TabIndex = 19
        Me.cmdExport.Text = "E&xport Excel"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdExec
        '
        Me.cmdExec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExec.ForeColor = System.Drawing.Color.Blue
        Me.cmdExec.Location = New System.Drawing.Point(220, 78)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(75, 23)
        Me.cmdExec.TabIndex = 18
        Me.cmdExec.Text = "&Execute"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'txtMat
        '
        Me.txtMat.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMat.Location = New System.Drawing.Point(149, 27)
        Me.txtMat.MaxLength = 18
        Me.txtMat.Name = "txtMat"
        Me.txtMat.Size = New System.Drawing.Size(171, 22)
        Me.txtMat.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Material number :"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 113)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(976, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'dtgProduct
        '
        Me.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProduct.Location = New System.Drawing.Point(56, 163)
        Me.dtgProduct.Name = "dtgProduct"
        Me.dtgProduct.Size = New System.Drawing.Size(509, 296)
        Me.dtgProduct.TabIndex = 17
        '
        'lblSQL
        '
        Me.lblSQL.AutoSize = True
        Me.lblSQL.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSQL.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSQL.ForeColor = System.Drawing.Color.Yellow
        Me.lblSQL.Location = New System.Drawing.Point(767, 193)
        Me.lblSQL.Name = "lblSQL"
        Me.lblSQL.Size = New System.Drawing.Size(45, 13)
        Me.lblSQL.TabIndex = 18
        Me.lblSQL.Text = "Label19"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopylblSQL})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(124, 26)
        '
        'CopylblSQL
        '
        Me.CopylblSQL.Name = "CopylblSQL"
        Me.CopylblSQL.Size = New System.Drawing.Size(123, 22)
        Me.CopylblSQL.Text = "CopySQL"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.ForeColor = System.Drawing.Color.Blue
        Me.cmdSave.Location = New System.Drawing.Point(56, 78)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 21
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Frm001Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 516)
        Me.Controls.Add(Me.lblSQL)
        Me.Controls.Add(Me.dtgProduct)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnHeader)
        Me.Name = "Frm001Product"
        Me.TabText = "Product"
        Me.Text = "Product"
        Me.pnHeader.ResumeLayout(False)
        Me.pnMattype.ResumeLayout(False)
        Me.pnMattype.PerformLayout()
        Me.pnBOI.ResumeLayout(False)
        Me.pnBOI.PerformLayout()
        Me.pnCondition.ResumeLayout(False)
        Me.pnCondition.PerformLayout()
        CType(Me.dtgProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents pnMattype As System.Windows.Forms.Panel
    Friend WithEvents pnBOI As System.Windows.Forms.Panel
    Friend WithEvents pnCondition As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMat As BOI_Allocate_Cost.NPIText
    Friend WithEvents rb23 As System.Windows.Forms.RadioButton
    Friend WithEvents rb22 As System.Windows.Forms.RadioButton
    Friend WithEvents rb21 As System.Windows.Forms.RadioButton
    Friend WithEvents rb33 As System.Windows.Forms.RadioButton
    Friend WithEvents rb32 As System.Windows.Forms.RadioButton
    Friend WithEvents rb31 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdExport As BOI_Allocate_Cost.NPIButton
    Friend WithEvents cmdExec As BOI_Allocate_Cost.NPIButton
    Friend WithEvents cmdSQL As BOI_Allocate_Cost.NPIButton
    Friend WithEvents dtgProduct As System.Windows.Forms.DataGridView
    Friend WithEvents lblSQL As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopylblSQL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSave As BOI_Allocate_Cost.NPIButton
End Class
