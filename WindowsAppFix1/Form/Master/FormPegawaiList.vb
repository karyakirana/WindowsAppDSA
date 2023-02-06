Public Class FormPegawaiList

    Dim _repository As PegawaiRepository = New PegawaiRepository

    Private Sub FormPegawaiList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Async Sub LoadData()
        Dim listView = Await _repository.GetList
        GridControl1.DataSource = listView
    End Sub
End Class