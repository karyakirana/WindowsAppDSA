Public Class FormJabatanList

    Public _repositoryJabatan = New JabatanRepository
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm = New FormJabatan
        frm.Show()
    End Sub

    Private Async Sub LoadData()
        'dataObject
        Dim listView = Await _repositoryJabatan.GetList()
        GridControl1.DataSource = listView
    End Sub

    Private Sub FormJabatanList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class