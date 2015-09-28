Public Class Frm101AdjustRecipeint
    Private cx As New NPIData(NPIConnect.NPIRYSV62BOI)
    Private xYear As String
    Private xMonth As String
    Private S As String
    Private respond, respond1
    Private cmd As OleDbCommand
    Private dt As DataTable
    Private xLable As String
    Private x As String
    Private xx As String
    Private Sub CloseIt()
        Me.Close()
    End Sub
    
    Private Sub FrmAdjustRecipeint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        x = String.Format("select * from boi.dbo.Check_Costcenter()")
        dt = cx.GetdataTable(x)
        If dt.Rows.Count > 0 Then
            MsgBox("เข้า Menu 004 เพื่อ update cost center ใหม่ก่อน", MsgBoxStyle.Critical, "มี Cost center ใหม่")
            Me.BeginInvoke(New MethodInvoker(AddressOf CloseIt))
        End If

        x = String.Format("select * from boi.dbo.Check_Product()")
        dt = cx.GetdataTable(x)
        If dt.Rows.Count > 0 Then
            MsgBox("เข้า Menu 001 เพื่อ update Product ใหม่ก่อน", MsgBoxStyle.Critical, "มี Product ใหม่")
            Me.BeginInvoke(New MethodInvoker(AddressOf CloseIt))
        End If

        AddHandler cmdExec.Click, AddressOf cmdExec_Click
        AddHandler cmdExport.Click, AddressOf cmdExport_Click
        AddHandler cmdAdjustManual.Click, AddressOf cmdAdjust_Click
        AddHandler cmdSave.Click, AddressOf cmdSave_Click
        AddHandler cmdAdjustAuto.Click, AddressOf cmdAdjustAuto_Click
        AddHandler txtMonth.TextChanged, AddressOf Clear_List
        AddHandler txtYear.TextChanged, AddressOf Clear_List
        AddHandler dtgDetail.CellValueChanged, AddressOf dtgDetail_CellValueChanged
        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)
        Clear_List()

    End Sub
    Private Sub Clear_List()
        If S = String.Empty Then dtgDetail.DataSource = Nothing
        cx.ClearButton(pnCondition)
        Label3.Visible = False
        Label3.Text = String.Empty
        Label3.Visible = False
        Label3.Text = String.Empty
        cmdAdjustManual.Enabled = False
        cmdSave.Enabled = False
        cmdExport.Enabled = False
        cmdAdjustAuto.Enabled = False
        Try
            dtgDetail.Columns.Remove("Check")
        Catch ex As Exception

        End Try

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Show_Recipeint()
        dt = cx.GetdataTable(String.Format("Exec Select_Recipeint_Incorrect '{0}','{1}'", xMonth, xYear))
        dtgDetail.DataSource = dt
        cx.GridToList(dtgDetail)
        Label3.Visible = True
        Select Case dt.Rows.Count
            Case 0
                xLable = String.Format("ข้อมูลเดือน {0} ปี {1} ถูกต้องทุกรายการสามารถโอนข้อมูลเข้า Database ได้", xMonth, xYear)
                Label3.ForeColor = Color.Green
                cmdSave.Enabled = True
                cmdSave.Focus()
            Case Else
                xLable = String.Format("ตรวจพบรายการที่ Recipient ไม่ถูกต้องจำนวน {0} รายการ", dt.Rows.Count)
                Label3.ForeColor = Color.Red
                cmdAdjustManual.Enabled = True
                cmdAdjustAuto.Enabled = True
                cmdAdjustManual.Focus()
        End Select
        Label3.Text = xLable
        cmdExport.Enabled = True

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clear_List()
        xYear = txtYear.Text
        xMonth = String.Format("{0:N0}", txtMonth.Text).ToString().PadLeft(2, "0")

        Me.Cursor = Cursors.WaitCursor
Check_Data:

        cmd = cx.CommandCreate(String.Format("Exec boi.dbo.AdminCheck101_1 '{0}','{1}'", xMonth, xYear))
        cx.Execute(cmd)

        cmd = cx.CommandCreate(String.Format("Exec boi.dbo.AdminCheck101 '{0}','{1}'", xMonth, xYear))
        cx.Execute(cmd)

        x = String.Format("select * from boi.dbo.Match_58100_from_Recipient('{0}','{1}') where mmovtype is null", xMonth, xYear)
        dt = cx.GetdataTable(x)
        If dt.Rows.Count > 0 Then
            MsgBox("ข้อมูลมีปัญหา ติดต่อ IT เพื่อทำการแก้ไขก่อน", MsgBoxStyle.Critical, "เสียใจด้วย คุณไม่ได้ไปต่อ")
            GoTo End_Process
        Else
            GoTo Check_Begin_Stock
        End If

Check_Begin_Stock:
        x = String.Format("select * from boi.dbo.t_IB303_MovementStock where month(mdate) = '{0}' and year(mdate) = '{1}' and mtype = '00Balance'", xMonth, xYear)
        dt = cx.GetdataTable(x)
        If dt.Rows.Count > 0 Then
            GoTo Check_Pro_data
        Else
            x = String.Format("ยังไม่มี stock ต้นงวดของเดือน {0} ปี {1} คุณต้องไปทำ menu 111 ของเดือนก่อนหน้าให้เสร็จสิ้นก่อน", xMonth, xYear)
            MsgBox(x, MsgBoxStyle.Critical, "ข้อมูลยังไม่พร้อม")
            GoTo End_Process
        End If

Check_Pro_data:
        x = String.Format("exec boi.dbo.PD_CheckProductionData '{0}','{1}'", xMonth, xYear)
        dt = cx.GetdataTable(x)
        If dt.Rows.Count > 0 Then
            Label3.Visible = True
            Label3.Text = String.Format("คำเตือน ข้อมูลเดือน {0} ปี {1} ได้ทำการแก้ไขเรียบร้อยแล้ว ตอบ Yes จะทำให้ต้องทำงานใหม่ทั้งหมด", xMonth, xYear)
            Label3.ForeColor = Color.Red
            Dim dr As DataRow = dt.Rows.Item(0)
            respond = MsgBox(String.Format("มีข้อมูลเดือน {0} ปี {1} อยู่ใน Production Data", xMonth, xYear) + Chr(13) + _
                             String.Format("จัดเตรียมโดย {0} เมื่อวันที่ {1}", dr.Item("Uname"), dr.Item("xDate")) + Chr(13) + _
                             "ต้องการจะทำใหม่หรือไม่?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "ตรวจพบข้อมูลซ้ำ")
            If respond = MsgBoxResult.Yes Then
                Dim xKeyConfirm As String = "I do It"
                Dim xUserKey As String = InputBox("คุณต้องทำการ Key 'I do It' เพื่อ Confirm การลบข้อมูล Production Data", "ยืนยันการลบข้อมูล Production Data")
                If xKeyConfirm <> xUserKey Then
                    MsgBox("คุณ Key Confirm ผิด", MsgBoxStyle.Critical, "ไม่แน่ใจใช่ไหม")
                    Exit Sub
                Else
                    xx = String.Format("exec P_Delete_ProductionData '{0}','{1}','{2}','{3}','{4}'", xMonth, xYear, Uname, hostname, ipaddress)
                    cmd = cx.CommandCreate(xx)
                    cx.Execute(cmd)
                    GoTo Check_SAP
                End If
            Else
                GoTo End_Process
            End If
        End If

Check_Pre_data:
        x = String.Format("exec boi.dbo.PD_CheckPreData '{0}','{1}'", xMonth, xYear)
        dt = cx.GetdataTable(x)
        If dt.Rows.Count > 0 Then
            Label3.Visible = True
            Label3.Text = String.Format("คำเตือน ข้อมูลเดือน {0} ปี {1} ได้จัดเตรียมไว้เรียบร้อยแล้ว ตอบ Yes อาจจะทำให้ต้องทำงานใหม่ทั้งหมด", xMonth, xYear)
            Label3.ForeColor = Color.Red
            Dim dr As DataRow = dt.Rows.Item(0)
            respond = MsgBox(String.Format("มีข้อมูลเดือน {0} ปี {1} อยู่ใน Prepare Data", xMonth, xYear) + Chr(13) + _
                             String.Format("จัดเตรียมโดย {0} เมื่อวันที่ {1}", dr.Item("Uname"), dr.Item("xDate")) + Chr(13) + _
                             "ต้องการจะทำใหม่หรือไม่?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation, "ตรวจพบข้อมูลซ้ำ")
            If respond = MsgBoxResult.Yes Then
                Label3.Text = String.Format("กำลังจัดเตรียม ข้อมูลเดือน {0} ปี {1}", xMonth, xYear)
                Label3.ForeColor = Color.Blue

                xx = String.Format("delete from BOI.dbo.t_IB301_AdjustRecipientHeader_pre where mmonth = '{0}' and myear = '{1}'", xMonth, xYear)
                cmd = cx.CommandCreate(xx)
                cx.Execute(cmd)

                xx = String.Format("delete from BOI.dbo.t_IB302_AdjustRecipientDetail_adjust where mmonth = '{0}' and myear = '{1}'", xMonth, xYear)
                cmd = cx.CommandCreate(xx)
                cx.Execute(cmd)

                xx = String.Format("insert into BOI.dbo.t_IB301_AdjustRecipientHeader_delete (mtable,myear,mmonth,Uname,Cname,IPname) values ('{0}','{1}','{2}','{3}','{4}','{5}')", "pre", xYear, xMonth, Uname, hostname, ipaddress)
                cmd = cx.CommandCreate(xx)
                cx.Execute(cmd)
                GoTo Check_SAP
            Else
                GoTo Check_Recipient
            End If
        End If

Check_SAP:
        Label3.Visible = True
        Label3.Text = String.Format("กำลังจัดเตรียม ข้อมูลเดือน {0} ปี {1}", xMonth, xYear)
        Label3.ForeColor = Color.Blue
        Dim xAmt = cx.ExecuteScalar(String.Format("select sum (mvaluecocurr) from plannings.dbo.vmsa740_costlineitem  where myear = '{0}' " & _
                                           "and mmonth = '{1}' and mcostelement = '0000581000' and mcompcode = '0870'", xYear, xMonth))
        If IsDBNull(xAmt) Then
            MsgBox(String.Format("แจ้ง IT เพื่อตรวจสอบข้อมูล plannings.dbo.vmsa740_costlineitem  เดือน {0} ปี {1}", xMonth, xYear) + Chr(13) + "เนื่องจากไม่มีข้อมูล" _
                   , MsgBoxStyle.Critical, "ไม่มีข้อมูลในระบบ")
            dtgDetail.DataSource = Nothing
            GoTo End_Process
        End If

        respond = MsgBox(String.Format("ยอด 581000 บน SAP เดือน {0} ปี {1} = {2:N} บาท หรือไม่?", xMonth, xYear, xAmt), _
                             MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "เช็คยอด 581000 กับ GL บน SAP")
        If respond = MsgBoxResult.Yes Then
            respond1 = MsgBox("ต้องการเริ่มต้นการ Adjust Recipient หรือไม่?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "เริ่มต้น Adjust Recipient")
            If respond1 = MsgBoxResult.Yes Then
                MsgBox("กด OK เพื่อเริ่มต้นทำการโอนข้อมูลเข้า BOI.dbo.t_IB302_AdjustRecipientDetail_pre", MsgBoxStyle.Information, "โอนข้อมูลเข้า Prepare Data")

                Dim T1 As Date = Now()

                cmd = cx.CommandCreate(String.Format("Exec Insert_t_IB302_AdjustRecipientHeader_pre '{0}','{1}','{2}','{3}','{4}','{5}'", xYear, xMonth, Uname, hostname, ipaddress, xAmt))
                cx.Execute(cmd)

                cmd = cx.CommandCreate(String.Format("Exec Insert_t_IB302_AdjustRecipientDetail_pre '{0}','{1}'", xMonth, xYear))
                cx.Execute(cmd)

                Dim X1 As String
                X1 = String.Format("update BOI.dbo.t_IB301_AdjustRecipientHeader_pre set xruntime = {0} where myear = '{1}' and mmonth = '{2}'", DateDiff(DateInterval.Second, T1, Now()), xYear, xMonth)
                cmd = cx.CommandCreate(X1)
                cx.Execute(cmd)

                GoTo Check_Recipient
            Else
                Label3.Visible = True
                Label3.Text = String.Format("คุณไม่ได้ทำการโอนข้อมูลเดือน {0} ปี {1} เข้า Prepare Data", xMonth, xYear)
                Label3.ForeColor = Color.Red
                MsgBox("คุณไม่ได้ทำการโอนข้อมูลเข้า Prepare Data", MsgBoxStyle.Critical, "โอนข้อมูล")
                GoTo End_Process
            End If
        ElseIf respond = MsgBoxResult.No Then
            Label3.Visible = True
            Label3.Text = String.Format("ยอด SAP เดือน {0} ปี {1} ไม่ถูกต้อง กรุณา copy หน้าจอเพื่อแจ้ง IT", xMonth, xYear)
            Label3.ForeColor = Color.Red
            MsgBox(String.Format("แจ้ง IT เพื่อตรวจสอบข้อมูล plannings.dbo.vmsa740_costlineitem  เดือน {0} ปี {1}", xMonth, xYear) + Chr(13) + _
                   String.Format("เนื่องจากยอด DWH {0:N} ไม่ตรงกับ SAP", xAmt), MsgBoxStyle.Critical, "ตรวจสอบข้อมูล")
            GoTo End_Process
        Else
            GoTo End_Process
        End If

Check_Recipient:
        Show_Recipeint()
        Exit Sub

End_Process:
        Clear_List()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Adjust recipient details month {0} year {1}", xMonth, xYear)
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgDetail, cdl.FileName, Chr(9))
        End If
        cmdExport.Enabled = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdAdjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        S = "Adjust"
        Clear_List()
        dtgDetail.ReadOnly = False
        For i As Integer = 0 To dtgDetail.Columns.Count - 1
            If dtgDetail.Columns.Item(i).Name.ToString <> "mrecipient" Then
                dtgDetail.Columns.Item(i).ReadOnly = True
            Else
                dtgDetail.Columns.Item(i).ReadOnly = False
            End If
        Next

        dtgDetail.Columns.Add("Check", "Check")

        cmdSave.Enabled = True
        Label3.Visible = True
        Label3.Text = "คุณกำลังแก้ไขข้อมูล Recipient"
        Label3.ForeColor = Color.Blue
        Label3.Font = New Font("Tahoma", 18)
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Select Case S
            Case "Adjust"
                respond = MsgBox("คุณต้องการบันทึกการแก้ไข Recipient?", MsgBoxStyle.YesNo, "บันทึกการแก้ไข")
                If respond = MsgBoxResult.Yes Then
                    For i As Integer = 0 To dtgDetail.Rows.Count - 1
                        If Me.dtgDetail.Item("Check", i).Value = "Yes" Then
                            cmd = cx.CommandCreate("update BOI.dbo.t_IB302_AdjustRecipientDetail_pre set mrecipient = ? where xID = ? ", "TT")
                            cmd.Parameters(0).Value = dtgDetail.Item("mrecipient", i).Value.ToString
                            cmd.Parameters(1).Value = dtgDetail.Item("xID", i).Value.ToString
                            cx.Execute(cmd)

                            x = String.Format("update BOI.dbo.t_IB302_AdjustRecipientDetail_adjust set mrecipient = '{0}',Uname = '{1}', " & _
                                "Cname ='{2}', IPname = '{3}', xDate = '{4}' where xID = '{5}' ", dtgDetail.Item("mrecipient", i).Value.ToString, _
                                Uname, hostname, ipaddress, Now(), dtgDetail.Item("xID", i).Value.ToString)
                            cmd = cx.CommandCreate(x)
                            cx.Execute(cmd)

                        End If
                    Next
                    S = String.Empty
                    Clear_List()
                    Label3.Visible = True
                    Label3.Text = "แก้ไขข้อมูลเรียบร้อย"
                    Label3.ForeColor = Color.Green
                    MsgBox("บันทึกการแก้ไขเสร็จสิ้น")
                    Show_Recipeint()
                Else
                    Exit Sub
                End If
            Case String.Empty
                Dim T1 As Date = Now()

                cmd = cx.CommandCreate(String.Format("Exec Insert_t_IB302_AdjustRecipientHeader '{0}','{1}','{2}','{3}','{4}'", xYear, xMonth, Uname, hostname, ipaddress))
                cx.Execute(cmd)

                cmd = cx.CommandCreate(String.Format("Exec Insert_t_IB302_AdjustRecipientDetail '{0}','{1}'", xMonth, xYear))
                cx.Execute(cmd)


                cmd = cx.CommandCreate(String.Format("Exec Insert_t_IB303_MovementStock '{0}','{1}'", xMonth, xYear))
                cx.Execute(cmd)


                cmd = cx.CommandCreate(String.Format("delete from BOI.dbo.t_IB301_AdjustRecipientHeader_pre where mmonth = '{0}' and myear = '{1}'", xMonth, xYear))
                cx.Execute(cmd)


                Dim X1 As String
                X1 = String.Format("update BOI.dbo.t_IB301_AdjustRecipientHeader set xruntime = {0} where myear = '{1}' and mmonth = '{2}'", DateDiff(DateInterval.Second, T1, Now()), xYear, xMonth)
                cmd = cx.CommandCreate(X1)
                cx.Execute(cmd)

                Clear_List()
                Label3.Visible = True
                Label3.Text = String.Format("โอนข้อมูลเดือน {0} ปี {1} เข้า Database เรียบร้อย ", xMonth, xYear)
                Label3.ForeColor = Color.Green
                MsgBox(String.Format("เสร็จสิ้นการปรับปรุง Recipient เดือน {0} ปี {1}", xMonth, xYear))
            Case Else

        End Select
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdAdjustAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        respond = MsgBox("คุณต้องการให้ระบบปรับ Recipeint ให้โดยอัตโนมัติ?", MsgBoxStyle.YesNo, "ปรับปรุง Auto")
        If respond = MsgBoxResult.Yes Then
            cmd = cx.CommandCreate(String.Format("Exec P_Update_Recipient_Auto '{0}','{1}','{2}','{3}','{4}'", xMonth, xYear, Uname, hostname, ipaddress))
            cx.Execute(cmd)
            Clear_List()
            Label3.Visible = True
            Label3.Text = "แก้ไขข้อมูลเรียบร้อย"
            Label3.ForeColor = Color.Green
            MsgBox("บันทึกการแก้ไขเสร็จสิ้น")
            Show_Recipeint()
        Else
            Exit Sub
        End If
        Me.Cursor = Cursors.Default
    End Sub
    'Private Sub cmdAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Cursor = Cursors.WaitCursor
    '    x = String.Format("update  BOI.dbo.t_IB302_AdjustRecipientDetail_pre set mrecipient = 'I1' from BOI.dbo.t_IB302_AdjustRecipientDetail_pre A " & _
    '                      "inner join(select * from dbo.F_Select_Recipeint_Incorrect('{0}','{1}')) B on a.xID = b.xID ", xMonth, xYear)
    '    cmd = cx.CommandCreate(x)
    '    cx.Execute(cmd)
    '    Show_Recipeint()
    'End Sub
    Private Sub dtgDetail_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim o As DataGridView = sender
        Dim y As Integer = o.CurrentCell.RowIndex
        Dim z As String = o.Columns.Item(o.CurrentCell.ColumnIndex).Name.ToString
        If S = "Adjust" And z = "mrecipient" Then
            dtgDetail.Item("Check", y).Value = "Yes"
        End If
    End Sub
    'Private Sub dtgDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgDetail.DoubleClick
    '    Dim a As DataGridView = sender
    '    MsgBox(a.Columns.Item(a.CurrentCell.ColumnIndex).Index.ToString)
    'End Sub


End Class