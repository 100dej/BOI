<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm802ReportAdjust
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
        Me.cmdExport = New BOI_Allocate_Cost.NPIButton
        Me.cmdExec = New BOI_Allocate_Cost.NPIButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtYear = New BOI_Allocate_Cost.NPIText
        Me.txtMonth = New BOI_Allocate_Cost.NPIText
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.dtgDetail = New System.Windows.Forms.DataGridView
        Me.pnCondition.SuspendLayout()
        CType(Me.dtgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnCondition
        '
        Me.pnCondition.BackColor = System.Drawing.Color.Gainsboro
        Me.pnCondition.Controls.Add(Me.cmdExport)
        Me.pnCondition.Controls.Add(Me.cmdExec)
        Me.pnCondition.Controls.Add(Me.Label2)
        Me.pnCondition.Controls.Add(Me.Label1)
        Me.pnCondition.Controls.Add(Me.txtYear)
        Me.pnCondition.Controls.Add(Me.txtMonth)
        Me.pnCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnCondition.Location = New System.Drawing.Point(0, 0)
        Me.pnCondition.Name = "pnCondition"
        Me.pnCondition.Size = New System.Drawing.Size(729, 43)
        Me.pnCondition.TabIndex = 0
        '
        'cmdExport
        '
        Me.cmdExport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmdExport.ForeColor = System.Drawing.Color.Blue
        Me.cmdExport.Location = New System.Drawing.Point(355, 7)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(94, 23)
        Me.cmdExport.TabIndex = 3
        Me.cmdExport.Text = "E&xport Excel"
        Me.cmdExport.UseVisualStyleBackColor = True
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
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 43)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(729, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'dtgDetail
        '
        Me.dtgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDetail.Location = New System.Drawing.Point(0, 46)
        Me.dtgDetail.Name = "dtgDetail"
        Me.dtgDetail.Size = New System.Drawing.Size(729, 448)
        Me.dtgDetail.TabIndex = 2
        '
        'Frm802ReportAdjust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 494)
        Me.Controls.Add(Me.dtgDetail)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnCondition)
        Me.Name = "Frm802ReportAdjust"
        Me.TabText = "FrmReportAdjust"
        Me.Text = "FrmReportAdjust"
        Me.pnCondition.ResumeLayout(False)
        Me.pnCondition.PerformLayout()
        CType(Me.dtgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnCondition As System.Windows.Forms.Panel
    Friend WithEvents cmdExport As BOI_Allocate_Cost.NPIButton
    Friend WithEvents cmdExec As BOI_Allocate_Cost.NPIButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtYear As BOI_Allocate_Cost.NPIText
    Friend WithEvents txtMonth As BOI_Allocate_Cost.NPIText
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents dtgDetail As System.Windows.Forms.DataGridView
End Class
