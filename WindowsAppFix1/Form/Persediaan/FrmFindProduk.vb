Public Class FrmFindProduk
    Dim _repositoryProduk As ProdukRepository = New ProdukRepository

    Private Async Sub LoadData()
        'dataObject
        Dim listView = Await _repositoryProduk.GetList
        GridControl1.DataSource = listView
    End Sub

    Private Sub FrmFindProduk_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Dim id = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid)
        frmAddPersediaanAwal.setRow(id)
        Close()
    End Sub
End Class