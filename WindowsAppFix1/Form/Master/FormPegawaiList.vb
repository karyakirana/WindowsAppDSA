Public Class FormPegawaiList

    Dim _repository As PegawaiRepository = New PegawaiRepository
    Dim pegawai As New Pegawai

    Private Sub FormPegawaiList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Public Async Sub LoadData()
        'dataObject
        Dim listView = Await _repository.GetList
        GridControl1.DataSource = listView
    End Sub

    Public Async Sub Destroy(id As Long)
        Dim hasil = Await _repository.delete(id)
        If hasil Then
            LoadData()
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm = New frmAddPegawai
        frm.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim id = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid)
        Dim form As New frmAddPegawai
        'form.edit(id)
        form.Show()
    End Sub
End Class