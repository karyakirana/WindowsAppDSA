Public Class FormPegawaiList

    Dim _repository As PegawaiRepository = New PegawaiRepository
    Dim pegawai As New Pegawai

    Private Sub FormPegawaiList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        GridView1.Columns.ColumnByFieldName("kode").VisibleIndex = -1
    End Sub

    Private Async Sub LoadData()
        'dataObject
        Dim listView = Await _repository.GetList
        GridControl1.DataSource = listView
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm = New frmAddPegawai
        frm.Show()
    End Sub
End Class