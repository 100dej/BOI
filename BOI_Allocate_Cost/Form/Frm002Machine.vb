Public Class Frm002Machine
    Private cx As New NPIData(NPIConnect.NPIRYSV62BOI)
    Private x As String
    Private cmd As OleDbCommand

    Private Sub Frm002Machine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            dtgMaster.Columns.Clear()
        Catch ex As Exception

        End Try

        x = String.Format("select * from boi.dbo.t_IB102_MachineList ORDER BY xDate DESC")
        DT = cx.GetdataTable(x)
        dtgMaster.DataSource = DT.DefaultView
        cx.GridToList(dtgMaster)

        AddHandler cmdExport.Click, AddressOf cmdExport_Click
        AddHandler cmdSave.Click, AddressOf cmdSave_Click
        AddHandler cmdNew.Click, AddressOf cmdNew_Click

        cmdExport.Enabled = True
        cmdSave.Enabled = False
        cmdNew.Enabled = True
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(Panel1)
    
        For i As Integer = 0 To dtgMaster.Rows.Count - 1
            Dim product As String
            Dim mcno As String
            Dim boino As String
            Try
                product = dtgMaster.Item("product", i).Value.ToString
                mcno = dtgMaster.Item("mcno", i).Value.ToString
                boino = dtgMaster.Item("boino", i).Value.ToString

            Catch ex As Exception

            End Try


            Try
                x = String.Format("insert into boi.dbo.t_IB102_MachineList (product,mcno,boino,userdefine)" & _
                              "select '{0}','{1}','{2}','{3}'", product, mcno, boino, Uname)
                cmd = cx.CommandCreate(x)
                cx.Execute(cmd)
            Catch ex As Exception
                MsgBox("คุณใส่ข้อมูลไม่ครบ หรือ MC no =  " & mcno & "  ที่คุณใส่มีอยู่แล้วในระบบ ")
            End Try
        Next

        MsgBox(String.Format("บันทึก Machine BOI ใหม่เข้าในระบบเรียบร้อย"))
        Call Frm002Machine_Load(sender:=Nothing, e:=Nothing)


    End Sub
    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(Panel1)
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Machine list for BOI")
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgMaster, cdl.FileName, Chr(9))
        End If
        cmdExport.Enabled = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cx.ClearButton(Panel1)
        cmdSave.Enabled = True
        cmdExport.Enabled = False
        cmdNew.Enabled = False

        With dtgMaster
            .DataSource = Nothing
            .Columns.Add("product", "product")
            .Columns.Add("mcno", "mcno")
            .Columns.Add("boino", "boino")
            .AllowUserToAddRows = True
            .AllowUserToDeleteRows = True
            .ReadOnly = False
        End With

    End Sub
End Class