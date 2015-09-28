Public Class Frm004Costcenter
    Private cx As New NPIData(NPIConnect.NPIRYSV62BOI)
    Private x As String
    Private cmd As OleDbCommand
    Private Sub Frm004Costcenter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For i As Integer = 0 To dtgMaster.Columns.Count - 1
            If dtgMaster.Columns.Item(i).Name.ToString <> "mcostcenter" Then
                dtgMaster.Columns.RemoveAt(i)
            End If
        Next

        AddHandler cmdExport.Click, AddressOf cmdExport_Click

        x = String.Format("select * from boi.dbo.Check_Costcenter()")
        DT = cx.GetdataTable(x)
        If DT.Rows.Count > 0 Then
            dtgMaster.DataSource = DT.DefaultView
            dtgMaster.Columns.Add("mCctrType", "mCctrType")
            dtgMaster.Columns.Add("mCctrBOINo", "mCctrBOINo")
            dtgMaster.Columns.Add("mCctrType_Allocate", "mCctrType_Allocate")
            dtgMaster.AllowUserToAddRows = False
            For i As Integer = 0 To dtgMaster.Columns.Count - 1
                If dtgMaster.Columns.Item(i).Name.ToString <> "mcostcenter" Then
                    dtgMaster.Columns.Item(i).ReadOnly = False
                Else
                    dtgMaster.Columns.Item(i).ReadOnly = True
                End If
            Next
            cmdSave.Enabled = True
            AddHandler cmdSave.Click, AddressOf cmdSave_Click
        Else
            x = String.Format("select * from boi.dbo.t_PF101_CostCenter")
            DT = cx.GetdataTable(x)
            dtgMaster.DataSource = DT.DefaultView
            cx.GridToList(dtgMaster)
            cmdSave.Enabled = False
        End If
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo Err_Nothing

        For i As Integer = 0 To dtgMaster.Rows.Count - 1
            Dim mcostcenter As String = dtgMaster.Item("mcostcenter", i).Value.ToString
            Dim mCctrType As String = dtgMaster.Item("mCctrType", i).Value.ToString
            Dim mCctrBOINo As String
            If dtgMaster.Item("mCctrBOINo", i).Value = Nothing Then
                mCctrBOINo = ""
            Else
                mCctrBOINo = dtgMaster.Item("mCctrBOINo", i).Value.ToString
            End If
            Dim mCctrType_Allocate As String = dtgMaster.Item("mCctrType_Allocate", i).Value.ToString
            x = String.Format("insert into boi.dbo.t_PF101_CostCenter (mcostcenter,mCctrType,mCctrBOINo,mCctrType_Allocate,userdefine)" & _
                              "select '{0}','{1}','{2}','{3}','{4}'", mcostcenter, mCctrType, mCctrBOINo, mCctrType_Allocate, Uname)
            cmd = cx.CommandCreate(x)
            cx.Execute(cmd)
        Next
        MsgBox(String.Format("บันทึก Cost center ใหม่เข้าในระบบเรียบร้อย"))
        Call Frm004Costcenter_Load(sender:=Nothing, e:=Nothing)
Err_Nothing:
        MsgBox("คุณใส่ข้อมูลไม่ครบ")
        Exit Sub

    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Cost center for BOI")
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgMaster, cdl.FileName, Chr(9))
        End If
        cmdExport.Enabled = False
        Me.Cursor = Cursors.Default
    End Sub
End Class