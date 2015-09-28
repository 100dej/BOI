<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm111DivideIntoBOI
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
        Me.pnCondition = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtgBalanace = New System.Windows.Forms.DataGridView
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.dtgBalanceDiff = New System.Windows.Forms.DataGridView
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dtgMovementBOI = New System.Windows.Forms.DataGridView
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Splitter4 = New System.Windows.Forms.Splitter
        Me.dtgMovementDaily = New System.Windows.Forms.DataGridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdExportMovementBOI = New BOI_Allocate_Cost.NPIButton
        Me.cmdSaveSalesReturn = New BOI_Allocate_Cost.NPIButton
        Me.cmdExportMovementDaily = New BOI_Allocate_Cost.NPIButton
        Me.cmdSave = New BOI_Allocate_Cost.NPIButton
        Me.cmdDisplay = New BOI_Allocate_Cost.NPIButton
        Me.cmdExec = New BOI_Allocate_Cost.NPIButton
        Me.txtYear = New BOI_Allocate_Cost.NPIText
        Me.txtMonth = New BOI_Allocate_Cost.NPIText
        Me.pnCondition.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgBalanace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgBalanceDiff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgMovementBOI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.dtgMovementDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnCondition
        '
        Me.pnCondition.BackColor = System.Drawing.Color.Gainsboro
        Me.pnCondition.Controls.Add(Me.Label3)
        Me.pnCondition.Controls.Add(Me.cmdSave)
        Me.pnCondition.Controls.Add(Me.cmdDisplay)
        Me.pnCondition.Controls.Add(Me.cmdExec)
        Me.pnCondition.Controls.Add(Me.Label2)
        Me.pnCondition.Controls.Add(Me.Label1)
        Me.pnCondition.Controls.Add(Me.txtYear)
        Me.pnCondition.Controls.Add(Me.txtMonth)
        Me.pnCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnCondition.Location = New System.Drawing.Point(0, 0)
        Me.pnCondition.Name = "pnCondition"
        Me.pnCondition.Size = New System.Drawing.Size(1241, 75)
        Me.pnCondition.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(22, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Year :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Month :"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 75)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1241, 3)
        Me.Splitter1.TabIndex = 4
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtgBalanace)
        Me.Panel1.Controls.Add(Me.Splitter3)
        Me.Panel1.Controls.Add(Me.dtgBalanceDiff)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 475)
        Me.Panel1.TabIndex = 5
        '
        'dtgBalanace
        '
        Me.dtgBalanace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBalanace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgBalanace.Location = New System.Drawing.Point(0, 397)
        Me.dtgBalanace.Name = "dtgBalanace"
        Me.dtgBalanace.Size = New System.Drawing.Size(339, 78)
        Me.dtgBalanace.TabIndex = 2
        '
        'Splitter3
        '
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter3.Location = New System.Drawing.Point(0, 394)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(339, 3)
        Me.Splitter3.TabIndex = 1
        Me.Splitter3.TabStop = False
        '
        'dtgBalanceDiff
        '
        Me.dtgBalanceDiff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBalanceDiff.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtgBalanceDiff.Location = New System.Drawing.Point(0, 0)
        Me.dtgBalanceDiff.Name = "dtgBalanceDiff"
        Me.dtgBalanceDiff.Size = New System.Drawing.Size(339, 394)
        Me.dtgBalanceDiff.TabIndex = 0
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(339, 78)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 475)
        Me.Splitter2.TabIndex = 6
        Me.Splitter2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtgMovementBOI)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Splitter4)
        Me.Panel2.Controls.Add(Me.dtgMovementDaily)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(342, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 475)
        Me.Panel2.TabIndex = 7
        '
        'dtgMovementBOI
        '
        Me.dtgMovementBOI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMovementBOI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgMovementBOI.Location = New System.Drawing.Point(0, 332)
        Me.dtgMovementBOI.Name = "dtgMovementBOI"
        Me.dtgMovementBOI.Size = New System.Drawing.Size(899, 143)
        Me.dtgMovementBOI.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cmdExportMovementBOI)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 297)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(899, 35)
        Me.Panel4.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(208, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(448, 24)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "ข้อมูลหลังจากแจกแจง BOI.dbo.t_IB303_MovementStock "
        '
        'Splitter4
        '
        Me.Splitter4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter4.Location = New System.Drawing.Point(0, 294)
        Me.Splitter4.Name = "Splitter4"
        Me.Splitter4.Size = New System.Drawing.Size(899, 3)
        Me.Splitter4.TabIndex = 2
        Me.Splitter4.TabStop = False
        '
        'dtgMovementDaily
        '
        Me.dtgMovementDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMovementDaily.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtgMovementDaily.Location = New System.Drawing.Point(0, 35)
        Me.dtgMovementDaily.Name = "dtgMovementDaily"
        Me.dtgMovementDaily.Size = New System.Drawing.Size(899, 259)
        Me.dtgMovementDaily.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdSaveSalesReturn)
        Me.Panel3.Controls.Add(Me.cmdExportMovementDaily)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(899, 35)
        Me.Panel3.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(292, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(426, 24)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ข้อมูลจาก dbwms.dbo.vmsa530_movement_daily01"
        '
        'cmdExportMovementBOI
        '
        Me.cmdExportMovementBOI.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExportMovementBOI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExportMovementBOI.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExportMovementBOI.ForeColor = System.Drawing.Color.Blue
        Me.cmdExportMovementBOI.Location = New System.Drawing.Point(29, 6)
        Me.cmdExportMovementBOI.Name = "cmdExportMovementBOI"
        Me.cmdExportMovementBOI.Size = New System.Drawing.Size(94, 23)
        Me.cmdExportMovementBOI.TabIndex = 0
        Me.cmdExportMovementBOI.Text = "Export Excel"
        Me.cmdExportMovementBOI.UseVisualStyleBackColor = True
        '
        'cmdSaveSalesReturn
        '
        Me.cmdSaveSalesReturn.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveSalesReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSaveSalesReturn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSaveSalesReturn.ForeColor = System.Drawing.Color.Blue
        Me.cmdSaveSalesReturn.Location = New System.Drawing.Point(129, 6)
        Me.cmdSaveSalesReturn.Name = "cmdSaveSalesReturn"
        Me.cmdSaveSalesReturn.Size = New System.Drawing.Size(75, 23)
        Me.cmdSaveSalesReturn.TabIndex = 26
        Me.cmdSaveSalesReturn.Text = "S&ave"
        Me.cmdSaveSalesReturn.UseVisualStyleBackColor = True
        '
        'cmdExportMovementDaily
        '
        Me.cmdExportMovementDaily.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExportMovementDaily.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExportMovementDaily.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExportMovementDaily.ForeColor = System.Drawing.Color.Blue
        Me.cmdExportMovementDaily.Location = New System.Drawing.Point(29, 6)
        Me.cmdExportMovementDaily.Name = "cmdExportMovementDaily"
        Me.cmdExportMovementDaily.Size = New System.Drawing.Size(94, 23)
        Me.cmdExportMovementDaily.TabIndex = 0
        Me.cmdExportMovementDaily.Text = "Export Excel"
        Me.cmdExportMovementDaily.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.ForeColor = System.Drawing.Color.Blue
        Me.cmdSave.Location = New System.Drawing.Point(470, 7)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDisplay
        '
        Me.cmdDisplay.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDisplay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdDisplay.ForeColor = System.Drawing.Color.Blue
        Me.cmdDisplay.Location = New System.Drawing.Point(258, 7)
        Me.cmdDisplay.Name = "cmdDisplay"
        Me.cmdDisplay.Size = New System.Drawing.Size(75, 23)
        Me.cmdDisplay.TabIndex = 2
        Me.cmdDisplay.Text = "&Display"
        Me.cmdDisplay.UseVisualStyleBackColor = True
        '
        'cmdExec
        '
        Me.cmdExec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExec.ForeColor = System.Drawing.Color.Blue
        Me.cmdExec.Location = New System.Drawing.Point(339, 7)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(75, 23)
        Me.cmdExec.TabIndex = 3
        Me.cmdExec.Text = "&Execute"
        Me.cmdExec.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtYear.Location = New System.Drawing.Point(186, 7)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.NumberOnly = True
        Me.txtYear.Showcomma = False
        Me.txtYear.Size = New System.Drawing.Size(66, 22)
        Me.txtYear.TabIndex = 1
        Me.txtYear.Text = "2013"
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonth
        '
        Me.txtMonth.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMonth.Location = New System.Drawing.Point(80, 7)
        Me.txtMonth.MaxLength = 2
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.NumberOnly = True
        Me.txtMonth.Showcomma = False
        Me.txtMonth.Size = New System.Drawing.Size(43, 22)
        Me.txtMonth.TabIndex = 0
        Me.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Frm111DivideIntoBOI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 553)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnCondition)
        Me.Name = "Frm111DivideIntoBOI"
        Me.TabText = "Frm111DivideIntoBOI"
        Me.Text = "Frm111DivideIntoBOI"
        Me.pnCondition.ResumeLayout(False)
        Me.pnCondition.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgBalanace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgBalanceDiff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtgMovementBOI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dtgMovementDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnCondition As System.Windows.Forms.Panel
    Friend WithEvents cmdExec As BOI_Allocate_Cost.NPIButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtYear As BOI_Allocate_Cost.NPIText
    Friend WithEvents txtMonth As BOI_Allocate_Cost.NPIText
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtgBalanceDiff As System.Windows.Forms.DataGridView
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents dtgBalanace As System.Windows.Forms.DataGridView
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtgMovementDaily As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtgMovementBOI As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Splitter4 As System.Windows.Forms.Splitter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdExportMovementBOI As BOI_Allocate_Cost.NPIButton
    Friend WithEvents cmdExportMovementDaily As BOI_Allocate_Cost.NPIButton
    Friend WithEvents cmdDisplay As BOI_Allocate_Cost.NPIButton
    Friend WithEvents cmdSave As BOI_Allocate_Cost.NPIButton
    Friend WithEvents cmdSaveSalesReturn As BOI_Allocate_Cost.NPIButton
End Class
