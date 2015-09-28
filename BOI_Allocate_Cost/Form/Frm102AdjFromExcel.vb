Public Class Frm102AdjFromExcel
    Dim cx As New NPIData(NPIConnect.NPIRYSV62PlanningS)
    Private idxID As Integer
    Private idmrecipient As Integer
    Private Sub cmdImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImport.Click
        cx.ClearButton(Panel1)
        Dim dv As DataView
        dtgDetail.DataSource = Nothing
        Try
            dtgDetail.Columns.Remove("Check")
        Catch ex As Exception

        End Try

        Dim cdl As New OpenFileDialog
        cdl.Filter = "File (*.xls)|*.xls"

        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim ds As DataSet
                ds = cx.GetdataExcel(cdl.FileName)
                dv = ds.Tables(0).DefaultView
                dtgDetail.DataSource = dv
                cx.GridToList(dtgDetail)
            Catch ex As Exception

            End Try
        End If

        Dim i As Integer = 0
        For c As Integer = 0 To dtgDetail.Columns.Count - 1
            If dtgDetail.Columns.Item(c).Name.ToString = "xID" Or dtgDetail.Columns.Item(c).Name.ToString = "mrecipient" Then
                i += 1
            End If
            If dtgDetail.Columns.Item(c).Name.ToString = "xID" Then
                idxID = c
            End If
            If dtgDetail.Columns.Item(c).Name.ToString = "mrecipient" Then
                idmrecipient = c
            End If
        Next

        If i <> 2 Then
            MsgBox("ต้องมี ชื่อ column xID และ mrecipient สำหรับการแก้ไข ")
            cmdSave.Enabled = False
            Exit Sub
        End If

        cmdSave.Enabled = True

    End Sub
    Private Sub FrmAdjFromExcel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmdSave.Enabled = False
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim respond
        Dim cmd As OleDbCommand
        respond = MsgBox("คุณต้องการบันทึกการแก้ไข Recipient?", MsgBoxStyle.YesNo, "บันทึกการแก้ไข")
        If respond = MsgBoxResult.Yes Then
            For i As Integer = 0 To dtgDetail.Rows.Count - 1
                cmd = cx.CommandCreate("update BOI.dbo.t_IB302_AdjustRecipientDetail_pre set mrecipient = ? where xID = ? ", "TT")
                cmd.Parameters(0).Value = dtgDetail.Item(idmrecipient, i).Value.ToString
                cmd.Parameters(1).Value = dtgDetail.Item(idxID, i).Value.ToString
                cx.Execute(cmd)

                Dim x As String = String.Format("update BOI.dbo.t_IB302_AdjustRecipientDetail_adjust set mrecipient = '{0}',Uname = '{1}', " & _
                                                "Cname ='{2}', IPname = '{3}', xDate = '{4}' where xID = '{5}' ", dtgDetail.Item(idmrecipient, i).Value.ToString, Uname, hostname, ipaddress, Now(), dtgDetail.Item(idxID, i).Value.ToString)
                cmd = cx.CommandCreate(x)
                cx.Execute(cmd)

            Next
            MsgBox("บันทึกการแก้ไขเสร็จสิ้น")
            dtgDetail.DataSource = Nothing
            cmdSave.Enabled = False
            cx.ClearButton(Panel1)
        Else
            cx.ClearButton(Panel1)
            Exit Sub
        End If
    End Sub
End Class