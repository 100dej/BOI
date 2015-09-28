Public Class FrmMenu
    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeView1.ExpandAll()
        AddHandler TreeView1.DoubleClick, AddressOf TreeView1_OpenForm
        AddHandler TreeView1.KeyPress, AddressOf TreeView1_KeyPress
    End Sub
    Private Sub TreeView1_OpenForm(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DockState = WeifenLuo.WinFormsUI.DockState.DockLeftAutoHide
        Dim Y As String = TreeView1.SelectedNode.Name
        Dim frm As Form
        Select Case Y
            Case "nd001"
                For Each frm In FrmMain.MdiChildren
                    If (TypeOf frm Is Frm001Product) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New Frm001Product
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd002"
                For Each frm In FrmMain.MdiChildren
                    If (TypeOf frm Is Frm002Machine) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New Frm002Machine
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd004"
                For Each frm In FrmMain.MdiChildren
                    If (TypeOf frm Is Frm004Costcenter) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New Frm004Costcenter
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd101"
                For Each frm In FrmMain.MdiChildren
                    If (TypeOf frm Is Frm101AdjustRecipeint) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New Frm101AdjustRecipeint
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd102"
                For Each frm In FrmMain.MdiChildren
                    If (TypeOf frm Is Frm102AdjFromExcel) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New Frm102AdjFromExcel
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd111"
                For Each frm In FrmMain.MdiChildren
                    If (TypeOf frm Is Frm111DivideIntoBOI) Then
                        frm.Activate()
                        Exit Sub
                    End If
                Next
                Dim cf As New Frm111DivideIntoBOI
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd211"
                Dim cf As New Frm201AllocateFOH
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd212"
                Dim cf As New Frm212Allocate58x
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd213"
                Dim cf As New Frm213Allocate6x
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd221"
                Dim cf As New Frm401NetSales
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd231"
                Dim cf As New Frm230Production
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd241"
                Dim cf As New Frm301StockBalanceEnding
                cf.Text = cf.TabText
                cf.Show(DockPanel)


                'Case "nd203"
                '    Dim cf As New Frm203AllocateFOHIndirect
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd204"
                '    Dim cf As New Frm204AllocateFOHDirectBOI
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd205"
                '    Dim cf As New Frm205AllocateFOHDirectNull
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd206"
                '    Dim cf As New Frm206AllocateFOHServiceBOI
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd207"
                '    Dim cf As New Frm207AllocateFOHServiceNull
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd208"
                '    Dim cf As New Frm208TotalAllocateFOH
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd209"
                '    Dim cf As New Frm209DetailsDepre
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd210"
                '    Dim cf As New Frm210AllocateDPIndirectBOI
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd211"
                '    Dim cf As New Frm211AllocateDPIndiretNull
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd212"
                '    Dim cf As New Frm212AllocateDPDirectBOI
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd213"
                '    Dim cf As New Frm213AllocateDPDirectNull
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd214"
                '    Dim cf As New Frm214AllocateDPServiceBOI
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
                'Case "nd215"
                '    Dim cf As New Frm215AllocateDPServiceNull
                '    cf.Text = cf.TabText
                '    cf.Show(DockPanel)
            Case "nd801"
                Dim cf As New Frm801ReportData
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd802"
                Dim cf As New Frm802ReportAdjust
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case "nd901"
                Dim cf As New Frm901ReportProg
                cf.Text = cf.TabText
                cf.Show(DockPanel)
            Case Else
                MsgBox("อยู่ระหว่างการจัดทำ")
                Me.DockState = WeifenLuo.WinFormsUI.DockState.DockLeft
        End Select
    End Sub
    Private Sub TreeView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            TreeView1_OpenForm(sender:=Nothing, e:=Nothing)
        Else : Exit Sub
        End If
    End Sub
End Class