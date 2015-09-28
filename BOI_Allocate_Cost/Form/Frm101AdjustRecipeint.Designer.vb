<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm101AdjustRecipeint
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
        Me.pnHeader = New System.Windows.Forms.Panel
        Me.cmdAdjustAuto = New BOI_Allocate_Cost.NPIButton
        Me.cmdSave = New BOI_Allocate_Cost.NPIButton
        Me.cmdAdjustManual = New BOI_Allocate_Cost.NPIButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.pnCondition = New System.Windows.Forms.Panel
        Me.cmdExport = New BOI_Allocate_Cost.NPIButton
        Me.cmdExec = New BOI_Allocate_Cost.NPIButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtYear = New BOI_Allocate_Cost.NPIText
        Me.txtMonth = New BOI_Allocate_Cost.NPIText
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.dtgDetail = New System.Windows.Forms.DataGridView
        Me.pnHeader.SuspendLayout()
        Me.pnCondition.SuspendLayout()
        CType(Me.dtgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnHeader
        '
        Me.pnHeader.BackColor = System.Drawing.Color.Gainsboro
        Me.pnHeader.Controls.Add(Me.pnCondition)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(1020, 87)
        Me.pnHeader.TabIndex = 0
        '
        'cmdAdjustAuto
        '
        Me.cmdAdjustAuto.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAdjustAuto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdjustAuto.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAdjustAuto.ForeColor = System.Drawing.Color.Blue
        Me.cmdAdjustAuto.Location = New System.Drawing.Point(715, 19)
        Me.cmdAdjustAuto.Name = "cmdAdjustAuto"
        Me.cmdAdjustAuto.Size = New System.Drawing.Size(88, 23)
        Me.cmdAdjustAuto.TabIndex = 7
        Me.cmdAdjustAuto.Text = "Adjust &Auto"
        Me.cmdAdjustAuto.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.ForeColor = System.Drawing.Color.Blue
        Me.cmdSave.Location = New System.Drawing.Point(914, 19)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdAdjustManual
        '
        Me.cmdAdjustManual.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAdjustManual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdjustManual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAdjustManual.ForeColor = System.Drawing.Color.Blue
        Me.cmdAdjustManual.Location = New System.Drawing.Point(811, 19)
        Me.cmdAdjustManual.Name = "cmdAdjustManual"
        Me.cmdAdjustManual.Size = New System.Drawing.Size(95, 23)
        Me.cmdAdjustManual.TabIndex = 5
        Me.cmdAdjustManual.Text = "Adjust &Manual"
        Me.cmdAdjustManual.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'pnCondition
        '
        Me.pnCondition.Controls.Add(Me.cmdAdjustAuto)
        Me.pnCondition.Controls.Add(Me.cmdSave)
        Me.pnCondition.Controls.Add(Me.cmdExport)
        Me.pnCondition.Controls.Add(Me.cmdAdjustManual)
        Me.pnCondition.Controls.Add(Me.cmdExec)
        Me.pnCondition.Controls.Add(Me.Label2)
        Me.pnCondition.Controls.Add(Me.Label3)
        Me.pnCondition.Controls.Add(Me.Label1)
        Me.pnCondition.Controls.Add(Me.txtYear)
        Me.pnCondition.Controls.Add(Me.txtMonth)
        Me.pnCondition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCondition.Location = New System.Drawing.Point(0, 0)
        Me.pnCondition.Name = "pnCondition"
        Me.pnCondition.Size = New System.Drawing.Size(1020, 87)
        Me.pnCondition.TabIndex = 0
        '
        'cmdExport
        '
        Me.cmdExport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExport.ForeColor = System.Drawing.Color.Blue
        Me.cmdExport.Location = New System.Drawing.Point(355, 16)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(94, 23)
        Me.cmdExport.TabIndex = 20
        Me.cmdExport.Text = "E&xport Excel"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdExec
        '
        Me.cmdExec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExec.ForeColor = System.Drawing.Color.Blue
        Me.cmdExec.Location = New System.Drawing.Point(264, 15)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(75, 23)
        Me.cmdExec.TabIndex = 19
        Me.cmdExec.Text = "&Execute"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Year :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Month :"
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtYear.Location = New System.Drawing.Point(186, 16)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.NumberOnly = True
        Me.txtYear.Showcomma = False
        Me.txtYear.Size = New System.Drawing.Size(66, 22)
        Me.txtYear.TabIndex = 1
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonth
        '
        Me.txtMonth.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMonth.Location = New System.Drawing.Point(80, 16)
        Me.txtMonth.MaxLength = 2
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.NumberOnly = True
        Me.txtMonth.Showcomma = False
        Me.txtMonth.Size = New System.Drawing.Size(43, 22)
        Me.txtMonth.TabIndex = 0
        Me.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 87)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1020, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'dtgDetail
        '
        Me.dtgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDetail.Location = New System.Drawing.Point(0, 90)
        Me.dtgDetail.Name = "dtgDetail"
        Me.dtgDetail.Size = New System.Drawing.Size(1020, 445)
        Me.dtgDetail.TabIndex = 2
        '
        'Frm101AdjustRecipeint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 535)
        Me.Controls.Add(Me.dtgDetail)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnHeader)
        Me.Name = "Frm101AdjustRecipeint"
        Me.TabText = "FrmAdjustRecipeint"
        Me.Text = "FrmAdjustRecipeint"
        Me.pnHeader.ResumeLayout(False)
        Me.pnCondition.ResumeLayout(False)
        Me.pnCondition.PerformLayout()
        CType(Me.dtgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnHeader As System.Windows.Forms.Panel
    Friend WithEvents pnCondition As System.Windows.Forms.Panel
    Friend WithEvents txtYear As BOI_Allocate_Cost.NPIText
    Friend WithEvents txtMonth As BOI_Allocate_Cost.NPIText
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdExec As BOI_Allocate_Cost.NPIButton
    Friend WithEvents cmdExport As BOI_Allocate_Cost.NPIButton
    Friend WithEvents dtgDetail As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSave As BOI_Allocate_Cost.NPIButton
    Friend WithEvents cmdAdjustManual As BOI_Allocate_Cost.NPIButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAdjustAuto As BOI_Allocate_Cost.NPIButton
End Class
