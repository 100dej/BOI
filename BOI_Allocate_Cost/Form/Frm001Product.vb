Public Class Frm001Product
    Private cx As New NPIData(NPIConnect.NPIRYSV62BOI)
    Private mmatno As String
    Private BOI As Integer
    Private BOIT As String
    Private Mattype As Integer
    Private MattypeT As String
    Private ListOfControl As New List(Of Control)
    Private x As String
    Private cmd As OleDbCommand
    Private Sub FrmProduct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Application.ChangeCulture("en-US")

        AddHandler cmdSave.Click, AddressOf cmdSave_Click
        dtgProduct.Visible = False
        lblSQL.Visible = False

        x = String.Format("select * from boi.dbo.Check_Product() order by mmatno")
        DT = cx.GetdataTable(x)
        If DT.Rows.Count > 0 Then
            dtgProduct.DataSource = DT.DefaultView
            dtgProduct.AllowUserToAddRows = False
            For i As Integer = 0 To dtgProduct.Columns.Count - 1
                If dtgProduct.Columns.Item(i).Name.ToString <> "isBOI" Then
                    dtgProduct.Columns.Item(i).ReadOnly = True
                Else
                    dtgProduct.Columns.Item(i).ReadOnly = False
                End If
            Next
            cmdSave.Enabled = True
            dtgProduct.Visible = True
            dtgProduct.Dock = DockStyle.Fill
            Exit Sub
        Else
            cmdSave.Enabled = False
        End If

        For Each ctrl As RadioButton In Me.pnBOI.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf BOI_CheckedChanged
            ListOfControl.Add(ctrl)
        Next

        For Each ctrl As RadioButton In Me.pnMattype.Controls.OfType(Of RadioButton)()
            AddHandler ctrl.CheckedChanged, AddressOf ListChanged
            AddHandler ctrl.CheckedChanged, AddressOf Mattype_CheckedChanged
            ListOfControl.Add(ctrl)
        Next

        AddHandler cmdExec.Click, AddressOf cmdExec_Click
        AddHandler cmdSQL.Click, AddressOf cmdSQL_Click
        AddHandler cmdExport.Click, AddressOf cmdExport_Click
        AddHandler CopylblSQL.Click, AddressOf CopylblSQL_Click

        rb21.Checked = True
        rb31.Checked = True

        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)

    End Sub
    Private Sub ListChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(pnCondition)
        cmdExport.Enabled = False
    End Sub
    Private Sub BOI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        If R1.Checked = True Then
            BOI = R1.Tag
            BOIT = R1.Text
        End If
    End Sub
    Private Sub Mattype_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim R1 As RadioButton = sender
        If R1.Checked = True Then
            Mattype = R1.Tag
            MattypeT = R1.Text
        End If
    End Sub
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClearData()
        mmatno = txtMat.Text
        Dim DT As DataTable = cx.GetdataTable(String.Format("exec Exec_Product '{0}',{1},{2}", mmatno, BOI, Mattype))
        dtgProduct.DataSource = DT
        cx.GridToList(dtgProduct)
        dtgProduct.Visible = True
        dtgProduct.Dock = DockStyle.Fill
        cmdExport.Enabled = True
    End Sub
    Private Sub cmdSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClearData()
        mmatno = txtMat.Text
        lblSQL.Visible = True
        lblSQL.Dock = DockStyle.Fill
        Dim XSql As New System.Text.StringBuilder("")
        XSql.Append(cx.ExecuteScalar(String.Format("exec Select_Product '{0}',{1},{2}", mmatno, BOI, Mattype)))
        lblSQL.Text = XSql.ToString
    End Sub
    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(pnCondition)
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("{0} {1} {2}", mmatno, BOIT, MattypeT)

        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgProduct, cdl.FileName, Chr(9))
        End If
    End Sub
    Sub ClearData()
        cx.ClearButton(pnCondition)
        dtgProduct.DataSource = Nothing
        dtgProduct.Dock = DockStyle.None
        dtgProduct.Visible = False
        lblSQL.Text = Nothing
        lblSQL.Dock = DockStyle.None
        lblSQL.Visible = False
        cmdExport.Enabled = False
        cmdSave.Enabled = False
    End Sub
    Private Sub CopylblSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clipboard.SetDataObject(lblSQL.Text, False)
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo Err_Nothing

        For i As Integer = 0 To dtgProduct.Rows.Count - 1
            Dim mflagdel As String
            If dtgProduct.Item("mflagdel", i).Value = Nothing Then
                mflagdel = ""
            Else
                mflagdel = dtgProduct.Item("mflagdel", i).Value.ToString
            End If

            Dim mmattype As String = dtgProduct.Item("mmattype", i).Value.ToString
            Dim mmatno As String = dtgProduct.Item("mmatno", i).Value.ToString
            Dim isBOI As String = dtgProduct.Item("isBOI", i).Value

            x = String.Format("insert into boi.dbo.t_IB101_DefineProduct (mflagdel,mmattype,mmatno,isBOI,DefineByUser)" & _
                              "select '{0}','{1}','{2}',{3},'{4}'", mflagdel, mmattype, mmatno, isBOI, Uname)
            cmd = cx.CommandCreate(x)
            cx.Execute(cmd)
        Next
        MsgBox(String.Format("บันทึก Product ใหม่เข้าในระบบเรียบร้อย"))
        Call FrmProduct_Load(sender:=Nothing, e:=Nothing)
Err_Nothing:
        MsgBox("คุณใส่ข้อมูลไม่ครบ")
        Exit Sub

    End Sub
End Class