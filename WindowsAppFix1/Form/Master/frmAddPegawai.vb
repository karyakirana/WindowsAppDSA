Public Class frmAddPegawai

    Private _pegawaiRepo As New PegawaiRepository
    Private id As Long?
    Private _update As Boolean = False

    Private Sub _refresh()
        FormPegawaiList.LoadData()
    End Sub

    Private Async Sub Store()

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class