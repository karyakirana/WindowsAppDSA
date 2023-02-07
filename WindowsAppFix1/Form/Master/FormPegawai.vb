Public Class FormPegawai
    Public _jabatanRepo As JabatanRepository = New JabatanRepository
    Private Sub FormPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


    Private Sub LoadData()
        cbJabatan.DataSource = _jabatanRepo.GetList()
    End Sub
End Class