Public Class Frm111DivideIntoBOI
    Private cx As New NPIData(NPIConnect.NPIRYSV62BOI)
    Private S As String
    Private xYear As String
    Private xMonth As String
    Private xYear1 As String
    Private xMonth1 As String
    Private respond
    Private x As String
    Private cmd As OleDbCommand
    Dim DV1 As DataView
    Dim DV2 As DataView
    Dim DV3 As DataView
    Private Sub Frm111DivideIntoBOI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler cmdExec.Click, AddressOf cmdExec_Click
        AddHandler dtgBalanceDiff.DoubleClick, AddressOf dtgBalanceDiff_DoubleClick
        AddHandler cmdExportMovementDaily.Click, AddressOf cmdExportMovementDaily_Click
        AddHandler cmdExportMovementBOI.Click, AddressOf cmdExportMovementBOI_Click
        AddHandler dtgMovementDaily.DoubleClick, AddressOf dtgMovementDaily_DoubleClick
        AddHandler cmdDisplay.Click, AddressOf cmdDisplay_Click
        AddHandler cmdSave.Click, AddressOf cmdSave_Click
        AddHandler dtgMovementBOI.DoubleClick, AddressOf dtgMovementBOI_DoubleClick
        AddHandler dtgMovementDaily.CellValueChanged, AddressOf dtgMovementDaily_CellValueChanged
        AddHandler cmdSaveSalesReturn.Click, AddressOf cmdSaveSalesReturn_Click
        cx.GetUserUsedProg(My.Application.ToString, Me.Name.ToString)
        Label3.Visible = False
        cmdSave.Enabled = False
        cmdSaveSalesReturn.Enabled = False
    End Sub
    Private Sub Clear_List()
        cx.ClearButton(pnCondition)
        cx.ClearButton(Panel3)
        dtgBalanace.DataSource = Nothing
        dtgBalanceDiff.DataSource = Nothing
        dtgMovementBOI.DataSource = Nothing
        dtgMovementDaily.DataSource = Nothing
        cmdSave.Enabled = False
        S = String.Empty
        Try
            dtgMovementDaily.Columns.Remove("Check")
        Catch ex As Exception

        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clear_List()
        xYear = txtYear.Text
        xMonth = String.Format("{0:N0}", txtMonth.Text).ToString().PadLeft(2, "0")

        Me.Cursor = Cursors.WaitCursor

Check_Padata:
        x = String.Format("select top 1 * from boi.dbo.padata where month(mpostdate) = '{0}' and year(mpostdate) = '{1}' ", xMonth, xYear)
        DT = cx.GetdataTable(x)
        If DT.Rows.Count > 0 Then
            GoTo Check_Begin_Stock
        Else
            x = String.Format("ข้อมูล v_bft010_billing_padata ของเดือน {0} ปี {1} ยังไม่มีในระบบ BOI", xMonth, xYear)
            MsgBox(x, MsgBoxStyle.Critical, "ข้อมูลยังไม่พร้อม")
            GoTo End_Process
        End If

Check_Begin_Stock:
        x = String.Format("select top 1 * from boi.dbo.t_IB303_MovementStock where month(mdate) = '{0}' and year(mdate) = '{1}' and mtype = '00Balance'", xMonth, xYear)
        DT = cx.GetdataTable(x)
        If DT.Rows.Count > 0 Then
            GoTo Check_Pro_data
        Else
            x = String.Format("ยังไม่มี stock ต้นงวดของเดือน {0} ปี {1} คุณต้องไปทำ menu 111 ของเดือนก่อนหน้าให้เสร็จสิ้นก่อน", xMonth, xYear)
            MsgBox(x, MsgBoxStyle.Critical, "ข้อมูลยังไม่พร้อม")
            GoTo End_Process
        End If

Check_Pro_data:
        x = String.Format("select top 1 * from boi.dbo.t_IB303_MovementStock where month(mdate) = '{0}' and year(mdate) = '{1}' and mtype = '10Production'", xMonth, xYear)
        DT = cx.GetdataTable(x)
        If DT.Rows.Count > 0 Then
            GoTo Check_Sales_Return
        Else
            Label3.Visible = True
            Label3.Text = String.Format("ข้อมูลเดือน {0} ปี {1} ยังไม่ได้ทำการ adjust receipient ให้เรียบร้อย", xMonth, xYear)
            Label3.ForeColor = Color.Red
            MsgBox(String.Format("ยังไม่มีข้อมูลเดือน {0} ปี {1}", xMonth, xYear), MsgBoxStyle.Information, "ข้อมูลไม่พร้อม")
            GoTo End_Process
        End If

Check_Sales_Return:
        x = String.Format("exec boi.dbo.check_sales_return '{0}','{1}'", xMonth, xYear)
        DT = cx.GetdataTable(x)
        If DT.Rows.Count > 0 Then
            Label3.Visible = True
            Label3.Text = String.Format("ตรวจพบ Sales return เดือน {0} ปี {1} มี assignment ไม่ถูกต้อง", xMonth, xYear)
            Label3.ForeColor = Color.Red
            S = "Adjust"
            With dtgMovementDaily
                .DataSource = DT
                .ReadOnly = False
                .AllowUserToAddRows = False
                .Columns.Add("Check", "Check")
                For i As Integer = 0 To .Columns.Count - 1
                    If .Columns.Item(i).Name.ToString <> "massignmentno" Then
                        .Columns.Item(i).ReadOnly = True
                    Else
                        .Columns.Item(i).ReadOnly = False
                    End If
                Next
            End With
            cmdSaveSalesReturn.Enabled = True
            GoTo End_Process
        Else
            GoTo Check_Movement
        End If

Check_Movement:
        x = String.Format("exec boi.dbo.PD_CheckMovement '{0}','{1}'", xMonth, xYear)
        DT = cx.GetdataTable(x)
        If DT.Rows.Count > 0 Then
            Label3.Visible = True
            Label3.Text = String.Format("คำเตือน ข้อมูลเดือน {0} ปี {1} ได้มีการแจกแจงบัตร BOI เรียบร้อยแล้ว ตอบ Yes ต้องทำใหม่ทั้งหมด", xMonth, xYear)
            Label3.ForeColor = Color.Red
            GoTo New_Movement
        Else
            GoTo Run_Cursor
        End If

New_Movement:
        respond = MsgBox(String.Format("ข้อมูลเดือน {0} ปี {1} ได้มีการแจกแจงเรียบร้อยแล้ว", xMonth, xYear) + Chr(13) + _
                             "ต้องการจะทำใหม่หรือไม่?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical, "ตรวจพบข้อมูลซ้ำ")
        If respond = MsgBoxResult.Yes Then
            Dim xKeyConfirm As String = "Yes!!!"
            Dim xUserKey As String = InputBox("Really?", "ยืนยันการลบข้อมูล Production Data")
            If xKeyConfirm <> xUserKey Then
                MsgBox("มั่นใจหน่อย", MsgBoxStyle.Critical, "ไม่แน่ใจใช่ไหม")
                GoTo End_Process
            Else
                x = String.Format("exec P_Delete_Movement '{0}','{1}','{2}','{3}','{4}'", xMonth, xYear, Uname, hostname, ipaddress)
                cmd = cx.CommandCreate(x)
                cx.Execute(cmd)
                GoTo Run_Cursor
            End If
        Else
            GoTo End_Process
        End If

Run_Cursor:
        Label3.Visible = True
        Label3.Text = String.Format("เริ่มต้นการ Run แจกแจงข้อมูลเดือน {0} ปี {1} ใช้เวลาประมาณ 20 นาทีสิ้นสุดประมาณ {2} ", xMonth, xYear, Now().AddMinutes(20))
        Label3.ForeColor = Color.Blue

        MsgBox("ใช้เวลาประมาณ 20 นาที", MsgBoxStyle.Information, "รอหน่อยนะ")

        x = String.Format("exec boi.dbo.PD_MovementBOI '{0}','{1}',''", xMonth, xYear)
        cmd = cx.CommandCreate(x)
        Try
            cx.Execute(cmd)
            GoTo Check_Balance
        Catch ex As Exception
            MsgBox("Store PD_MovementBOI น่าจะหลุด ")
            Exit Sub
        End Try

Check_Balance:
        Call Check_Balance()

End_Process:
        Me.Cursor = Cursors.Default
    End Sub
    Sub Check_Balance()
        Clear_List()
        Me.Cursor = Cursors.WaitCursor
        xYear = txtYear.Text
        xMonth = String.Format("{0:N0}", txtMonth.Text).ToString().PadLeft(2, "0")
        If xMonth = "12" Then xMonth1 = "01" Else xMonth1 = xMonth
        If xMonth = "12" Then xYear1 = xYear + 1 Else xYear1 = xYear


        x = String.Format("exec boi.dbo.PD_MovementCheckBalance '{0}','{1}'", xMonth, xYear)
        DT = cx.GetdataTable(x)

        If DT.Rows.Count > 0 Then
            Label3.Visible = True
            Label3.Text = String.Format("Stock Balance เดือน {0} ปี {1} ไม่ถูกต้อง ", xMonth, xYear)
            Label3.ForeColor = Color.Red
            dtgBalanceDiff.DataSource = DT
            cx.GridToList(dtgBalanceDiff)
            dtgMovementBOI.Enabled = True
            dtgMovementDaily.Enabled = True
            cmdSave.Enabled = False
        Else
            x = String.Format("exec boi.dbo.PD_CheckBalance_before_transfer '{0}','{1}'", xMonth, xYear)
            DT = cx.GetdataTable(x)
            If DT.Rows.Count > 0 Then
                Label3.Visible = True
                Label3.Text = String.Format("ได้ทำการโอน Stock Balance ไปตั้งต้นเดือน {0} ปี {1} เรียบร้อยแล้ว", xMonth1, xYear1)
                Label3.ForeColor = Color.Green
                cmdSave.Enabled = False
            Else
                Label3.Visible = True
                Label3.Text = String.Format("สามารถโอนข้อมูล Stock Balance เดือน {0} ปี {1} ได้ ", xMonth, xYear)
                Label3.ForeColor = Color.Green
                cmdSave.Enabled = True
            End If
            dtgMovementBOI.Enabled = False
            dtgMovementDaily.Enabled = False
        End If

        x = String.Format("exec boi.dbo.PD_MovementBalance '{0}','{1}'", xMonth, xYear)
        Dim DT1 As DataTable = cx.GetdataTable(x)
        DV1 = DT1.DefaultView
        dtgBalanace.DataSource = DV1
        cx.GridToList(dtgBalanace)

        x = String.Format("exec boi.dbo.PD_MovementDaily '{0}','{1}'", xMonth, xYear)
        Dim DT2 As DataTable = cx.GetdataTable(x)
        DV2 = DT2.DefaultView
        dtgMovementDaily.DataSource = DV2
        cx.GridToList(dtgMovementDaily)

        x = String.Format("exec boi.dbo.PD_MovementDetailBOI '{0}','{1}'", xMonth, xYear)
        Dim DT3 As DataTable = cx.GetdataTable(x)
        DV3 = DT3.DefaultView
        dtgMovementBOI.DataSource = DV3
        cx.GridToList(dtgMovementBOI)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cmdDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clear_List()
        Me.Cursor = Cursors.WaitCursor
        Call Check_Balance()
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub dtgBalanceDiff_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim x As DataGridView = sender
        Dim y As String = x.CurrentCell.Value.ToString
        Try
            DV1.RowFilter = String.Format("mmatno = '{0}'", y)
            DV2.RowFilter = String.Format("mmatno = '{0}'", y)
            DV3.RowFilter = String.Format("mmatno = '{0}'", y)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub cmdExportMovementDaily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Movement daily month {0} year {1}", xMonth, xYear)
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgMovementDaily, cdl.FileName, Chr(9))
        End If
    End Sub
    Private Sub cmdExportMovementBOI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Movement BOI month {0} year {1}", xMonth, xYear)
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgMovementBOI, cdl.FileName, Chr(9))
        End If
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Label3.Visible = True
        Label3.Text = String.Format("กำลังโอนข้อมูล Stock Balance เดือน {0} ปี {1} ", xMonth, xYear)
        Label3.ForeColor = Color.Green
        x = String.Format("exec boi.dbo.PD_MovementTransferBalance '{0}','{1}'", xMonth, xYear)
        cmd = cx.CommandCreate(x)
        cx.Execute(cmd)

        Label3.Text = String.Format("โอนข้อมูล Stock Balance เดือน {0} ปี {1} เรียบร้อย ", xMonth1, xYear1)
        Label3.ForeColor = Color.Green

        Call Check_Balance()

    End Sub
    Private Sub dtgMovementDaily_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If S = "Adjust" Then Exit Sub
        Dim refdocno As String
        Dim Xgrid As DataGridView = sender

        refdocno = Xgrid.Item("mmatdocno", Xgrid.CurrentRow.Index).Value.ToString

        x = String.Format("select * from BOI.dbo.t_IB303_MovementStock where mrefdocno = '{0}' " & _
                                  "and month(mdate) = '{1}' and year(mdate) = '{2}' and mtype ='80MovmentAdjust'", refdocno, xMonth, xYear)
        Dim dtx As DataTable = cx.GetdataTable(x)
        If dtx.Rows.Count > 0 Then
            MsgBox(String.Format("matdoc {0} ได้ทำการปรับปรุงไปแล้ว", refdocno), MsgBoxStyle.Critical, "ลองตรวจสอบดู")
            Exit Sub
        Else
            x = String.Format("Exec Adjust_Movement_from_MovementDaily '{0}','{1}','{2}'", refdocno, xMonth, xYear)
            respond = MsgBox(String.Format("ต้องการปรับปรุง matdoc {0}?", refdocno), MsgBoxStyle.YesNo, "ปรับปุรง QTY อย่างเดียว")
        End If

        If respond = MsgBoxResult.Yes Then
            cmd = cx.CommandCreate(x)
            cx.Execute(cmd)
            Clear_List()
            Call Check_Balance()
        End If
    End Sub
    Private Sub dtgMovementBOI_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim mtype, refdocno As String
        Dim Xgrid As DataGridView = sender
        Dim r As Integer = Xgrid.CurrentRow.Index

        mtype = Xgrid.Item("mtype", r).Value.ToString
        refdocno = Xgrid.Item("mrefdocno", r).Value.ToString

        Select Case mtype
            Case "80MovmentAdjust"
                x = String.Format("delete from BOI.dbo.t_IB303_MovementStock where mrefdocno = '{0}' " & _
                                  " and month(mdate) = '{1}' and year(mdate) = '{2}' and mtype = '80MovmentAdjust'" _
                            , refdocno, xMonth, xYear)
                respond = MsgBox(String.Format("ต้องการลบ matdoc {0}?", refdocno), MsgBoxStyle.YesNo, "ลบข้อมูลการปรับปรุง")
            Case "81BOIAdjust"
                x = String.Format("delete from BOI.dbo.t_IB303_MovementStock where mrefdocno = '{0}' " & _
                               " and month(mdate) = '{1}' and year(mdate) = '{2}' and mtype = '81BOIAdjust'" _
                         , refdocno, xMonth, xYear)
                respond = MsgBox(String.Format("ต้องการลบ matdoc {0}?", refdocno), MsgBoxStyle.YesNo, "ลบข้อมูลการปรับปรุง")
            Case "82RevertMonth"
                x = String.Format("delete from BOI.dbo.t_IB303_MovementStock where mrefdocno = '{0}' " & _
                               " and month(mdate) = '{1}' and year(mdate) = '{2}' and mtype = '82RevertMonth'" _
                         , refdocno, xMonth, xYear)
                respond = MsgBox(String.Format("ต้องการลบ matdoc {0}?", refdocno), MsgBoxStyle.YesNo, "ลบข้อมูลการปรับปรุง")
            Case Else
                x = String.Format("select * from BOI.dbo.t_IB303_MovementStock where mrefdocno = '{0}' " & _
                                  "and month(mdate) = '{1}' and year(mdate) = '{2}' and mtype ='81BOIAdjust'", refdocno, xMonth, xYear)
                Dim dtx As DataTable = cx.GetdataTable(x)
                If dtx.Rows.Count > 0 Then
                    MsgBox(String.Format("matdoc {0} ได้ทำการปรับปรุงไปแล้ว", refdocno), MsgBoxStyle.Critical, "ลองตรวจสอบดู")
                    Exit Sub
                Else
                    x = String.Format("Exec Adjust_Movement_from_MovementBOI '{0}','{1}','{2}'", refdocno, xMonth, xYear)
                    respond = MsgBox(String.Format("ต้องการปรับปรุง matdoc {0}?", refdocno), MsgBoxStyle.YesNo, "ปรับปุรง QTY อย่างเดียว")
                End If
        End Select
        
        If respond = MsgBoxResult.Yes Then
            cmd = cx.CommandCreate(x)
            cx.Execute(cmd)
            Clear_List()
            Call Check_Balance()
        End If
    End Sub
    Private Sub dtgMovementDaily_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim o As DataGridView = sender
        Dim y As Integer = o.CurrentCell.RowIndex
        Dim z As String = o.Columns.Item(o.CurrentCell.ColumnIndex).Name.ToString
        If z = "massignmentno" Then
            dtgMovementDaily.Item("Check", y).Value = "Yes"
        End If
    End Sub
    Private Sub cmdSaveSalesReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        respond = MsgBox("คุณต้องการบันทึกการแก้ไข assignmentno?", MsgBoxStyle.YesNo, "บันทึกการแก้ไข")
        If respond = MsgBoxResult.Yes Then
            For i As Integer = 0 To dtgMovementDaily.Rows.Count - 1
                If Me.dtgMovementDaily.Item("Check", i).Value = "Yes" Then
                    x = String.Format("update BOI.dbo.padata set massignmentno = '{0}' where mrefdocno = '{1}' ", _
                                      dtgMovementDaily.Item("massignmentno", i).Value, dtgMovementDaily.Item("mrefdocno", i).Value)
                    cmd = cx.CommandCreate(x)
                    cx.Execute(cmd)
                End If
            Next
            MsgBox("บันทึกการแก้ไขเสร็จสิ้น")
            cmdSaveSalesReturn.Enabled = False
            cmdExec_Click(sender:=Nothing, e:=Nothing)
        End If
    End Sub
End Class