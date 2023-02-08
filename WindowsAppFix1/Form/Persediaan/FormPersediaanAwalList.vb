Public Class FormPersediaanAwalList

    Private _persediaanAwalRepo As PersediaanAwalRepo = New PersediaanAwalRepo()
    Private Sub FormPersediaanAwalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Async Sub LoadData()
        Dim listView = Await _persediaanAwalRepo.GetList()
        GridControl1.DataSource = listView
    End Sub
End Class