<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm207AllocateFOHServiceNull
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
        Me.cmdExec = New BOI_Allocate_Cost.NPIButton
        Me.txtYear = New BOI_Allocate_Cost.NPIText
        Me.Label2 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMonth = New BOI_Allocate_Cost.NPIText
        Me.pnCondition = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtgSummary = New System.Windows.Forms.DataGridView
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdExport1 = New BOI_Allocate_Cost.NPIButton
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dtgDetails = New System.Windows.Forms.DataGridView
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblFilter = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.Splitter4 = New System.Windows.Forms.Splitter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdExport2 = New BOI_Allocate_Cost.NPIButton
        Me.pnCondition.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdExec
        '
        Me.cmdExec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExec.ForeColor = System.Drawing.Color.Blue
        Me.cmdExec.Location = New System.Drawing.Point(264, 6)
        Me.cmdExec.Name = "cmdExec"
        Me.cmdExec.Size = New System.Drawing.Size(75, 23)
        Me.cmdExec.TabIndex = 2
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
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 43)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(845, 3)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
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
        'pnCondition
        '
        Me.pnCondition.BackColor = System.Drawing.Color.Gainsboro
        Me.pnCondition.Controls.Add(Me.cmdExec)
        Me.pnCondition.Controls.Add(Me.Label2)
        Me.pnCondition.Controls.Add(Me.Label1)
        Me.pnCondition.Controls.Add(Me.txtYear)
        Me.pnCondition.Controls.Add(Me.txtMonth)
        Me.pnCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnCondition.Location = New System.Drawing.Point(0, 0)
        Me.pnCondition.Name = "pnCondition"
        Me.pnCondition.Size = New System.Drawing.Size(845, 43)
        Me.pnCondition.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtgSummary)
        Me.Panel1.Controls.Add(Me.Splitter3)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 502)
        Me.Panel1.TabIndex = 9
        '
        'dtgSummary
        '
        Me.dtgSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgSummary.Location = New System.Drawing.Point(0, 33)
        Me.dtgSummary.Name = "dtgSummary"
        Me.dtgSummary.Size = New System.Drawing.Size(357, 469)
        Me.dtgSummary.TabIndex = 3
        '
        'Splitter3
        '
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter3.Location = New System.Drawing.Point(0, 30)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(357, 3)
        Me.Splitter3.TabIndex = 1
        Me.Splitter3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cmdExport1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(357, 30)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(121, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'cmdExport1
        '
        Me.cmdExport1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExport1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExport1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExport1.ForeColor = System.Drawing.Color.Blue
        Me.cmdExport1.Location = New System.Drawing.Point(3, 3)
        Me.cmdExport1.Name = "cmdExport1"
        Me.cmdExport1.Size = New System.Drawing.Size(94, 23)
        Me.cmdExport1.TabIndex = 4
        Me.cmdExport1.Text = "E&xport Excel"
        Me.cmdExport1.UseVisualStyleBackColor = True
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(357, 46)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 502)
        Me.Splitter2.TabIndex = 10
        Me.Splitter2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtgDetails)
        Me.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Panel2.Controls.Add(Me.Splitter4)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(360, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(485, 502)
        Me.Panel2.TabIndex = 11
        '
        'dtgDetails
        '
        Me.dtgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDetails.Location = New System.Drawing.Point(0, 33)
        Me.dtgDetails.Name = "dtgDetails"
        Me.dtgDetails.Size = New System.Drawing.Size(485, 447)
        Me.dtgDetails.TabIndex = 21
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFilter, Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 480)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(485, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblFilter
        '
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(55, 17)
        Me.lblFilter.Text = "Filter By :"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.IsLink = True
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(53, 17)
        Me.lblStatus.Text = "Show &All"
        '
        'Splitter4
        '
        Me.Splitter4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter4.Location = New System.Drawing.Point(0, 30)
        Me.Splitter4.Name = "Splitter4"
        Me.Splitter4.Size = New System.Drawing.Size(485, 3)
        Me.Splitter4.TabIndex = 1
        Me.Splitter4.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cmdExport2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(485, 30)
        Me.Panel4.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cyan
        Me.Label4.Location = New System.Drawing.Point(121, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'cmdExport2
        '
        Me.cmdExport2.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExport2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExport2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExport2.ForeColor = System.Drawing.Color.Blue
        Me.cmdExport2.Location = New System.Drawing.Point(3, 3)
        Me.cmdExport2.Name = "cmdExport2"
        Me.cmdExport2.Size = New System.Drawing.Size(94, 23)
        Me.cmdExport2.TabIndex = 4
        Me.cmdExport2.Text = "E&xport Excel"
        Me.cmdExport2.UseVisualStyleBackColor = True
        '
        'Frm207AllocateServiceNull
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 548)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnCondition)
        Me.Name = "Frm207AllocateServiceNull"
        Me.TabText = "Frm207AllocateServiceNull"
        Me.Text = "Frm207AllocateServiceNull"
        Me.pnCondition.ResumeLayout(False)
        Me.pnCondition.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdExec As BOI_Allocate_Cost.NPIButton
    Friend WithEvents txtYear As BOI_Allocate_Cost.NPIText
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMonth As BOI_Allocate_Cost.NPIText
    Friend WithEvents pnCondition As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtgSummary As System.Windows.Forms.DataGridView
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdExport1 As BOI_Allocate_Cost.NPIButton
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtgDetails As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblFilter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Splitter4 As System.Windows.Forms.Splitter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdExport2 As BOI_Allocate_Cost.NPIButton
End Class
