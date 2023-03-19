Imports DevExpress.XtraReports.UI

Public Class FormPenjualanList

    Public _repositoryPenjualan As PenjualanRepository = New PenjualanRepository()
    Dim rpt As New rptInvoicePenjualan

    Public Async Sub LoadData()
        'dataObject
        Dim listView = Await _repositoryPenjualan.GetList()
        GridControl1.DataSource = listView
    End Sub

    Public Async Sub destroy(ByVal id As Long)
        Dim hasil = Await _repositoryPenjualan.delete(id)
        If hasil Then
            LoadData()
        End If
    End Sub

    Private Sub FormPenjualanList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'dialog add
        Using frm As New frmAddPenjualan()
            If frm.ShowDialog = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Using frm As New frmAddPenjualan()
            Dim id = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid)
            frm.Edit(id)
        End Using
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Close()
    End Sub

    Public Async Sub LoadDataByID()
        'dataObject
        totalBayar = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "total_bayar")
        Dim listview1 = Await _repositoryPenjualan.Edit(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id"))
        rpt.DataSource = listview1
        rpt.CreateDocument()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        'rpt.DataSource = Nothing
        LoadDataByID()
        Dim printTool As New ReportPrintTool(rpt)
        printTool.ShowPreview()
    End Sub
End Class