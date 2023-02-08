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
End Class