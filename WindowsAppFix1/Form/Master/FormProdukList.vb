Public Class FormProdukList

    Dim _repositoryProduk As ProdukRepository = New ProdukRepository
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm = New frmAddProduk
        frm.Show()
    End Sub
    Private Async Sub LoadData()
        Dim listView = Await _repositoryProduk.GetList()
        GridControl1.DataSource = listView
    End Sub



    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

    End Sub
End Class