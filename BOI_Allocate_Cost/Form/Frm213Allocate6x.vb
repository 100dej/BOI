Public Class Frm213Allocate6x
    Private cx As New NPIData(NPIConnect.NPIRYSV62BOI)
    Private xYear As String
    Private xMonth As String
    Private dv As DataView

    Private Sub Frm301StockBalanceEnding_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler cmdExec.Click, AddressOf cmdExec_Click
        AddHandler txtMonth.TextChanged, AddressOf Clear_List
        AddHandler txtYear.TextChanged, AddressOf Clear_List
        AddHandler cmdExport2.Click, AddressOf cmdExport2_Click
        cmdExport2.Enabled = False
    End Sub
    Private Sub Clear_List()
        cx.ClearButton(pnCondition)
        cmdExport2.Enabled = False
    End Sub
    Private Sub cmdExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo GetError

        Clear_List()
        xYear = txtYear.Text
        xMonth = String.Format("{0:N0}", txtMonth.Text).ToString().PadLeft(2, "0")

        Me.Cursor = Cursors.WaitCursor
        Dim x As String = String.Format("exec boi.dbo.Allocate6xx_for_program '{0}','{1}'", xMonth, xYear)

        Dim dt1 As DataTable = cx.GetdataTable(x)
        dv = dt1.DefaultView
        'Dim ds As DataSet = cx.GetdataSet(x)
        'dv = ds.Tables(0).DefaultView
        dtgDetails.DataSource = dv
        cx.GridToList(dtgDetails)
        cmdExport2.Enabled = True
        Me.Cursor = Cursors.Default
        Exit Sub

GetError:
        MsgBox("Network อาจจะมีปัญหา" & Chr(13) & "ลองกด Excute ดูอีกสักครั้ง")
        Me.Cursor = Cursors.Default
        Exit Sub
    End Sub
    Private Sub cmdExport2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Clear_List()
        Dim cdl As New SaveFileDialog
        cdl.FileName = String.Format("Report 6x month {0} year {1}", xMonth, xYear)
        cdl.Filter = "XLS File|*.xls"
        If cdl.ShowDialog = Windows.Forms.DialogResult.OK Then
            cx.ExportToTextFileFormGrid(dtgDetails, cdl.FileName, Chr(9))
        End If
    End Sub
End Class