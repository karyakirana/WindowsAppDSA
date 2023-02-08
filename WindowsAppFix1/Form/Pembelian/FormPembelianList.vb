Public Class FormPembelianList

    Public _repositoryPembelian = New PembelianRepository
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm = New frmAddPembelian
        frm.Show()
    End Sub
    Private Async Sub LoadData()
        'dataObject

        Dim listView = Await _repositoryPembelian.GetList()
        GridControl1.DataSource = listView
    End Sub

    Private Sub FormPembelianList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class