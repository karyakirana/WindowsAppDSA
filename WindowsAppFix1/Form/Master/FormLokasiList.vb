Public Class FormLokasiList

    Public _repositoryLokasi = New LokasiRepository
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm = New frmAddLokasi
        frm.Show()
    End Sub

    Private Async Sub LoadData()
        'dataObject
        Dim listView = Await _repositoryLokasi.GetList()
        GridControl1.DataSource = listView
    End Sub

    Private Sub FormLokasiList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        GridControl1.DataSource = _repositoryLokasi
        GridView1.Columns.ColumnByFieldName("nama").VisibleIndex = 0
        GridView1.Columns.ColumnByFieldName("nama").Caption = "Gudang"
        GridView1.Columns.ColumnByFieldName("nama").Width = 75
        GridView1.Columns.ColumnByFieldName("nama").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("nama").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("keterangan").VisibleIndex = 1
        GridView1.Columns.ColumnByFieldName("keterangan").Caption = "Keterangan"
        GridView1.Columns.ColumnByFieldName("keterangan").Width = 100
        GridView1.Columns.ColumnByFieldName("keterangan").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("keterangan").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("kode").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("created_at").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("updated_at").VisibleIndex = -1
        GridView1.BestFitColumns()
    End Sub
End Class