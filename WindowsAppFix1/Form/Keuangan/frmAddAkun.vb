Public Class frmAddAkun
    Private _repositoryAkun As New AkunRepository
    Private _update As Boolean = False
    Private _id As Long?

    Private Async Sub Store()

        Dim akun As New Akun With {
            .nama = txtAkun.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _repositoryAkun.Store(akun)

        If hasil Then
            DialogResult = DialogResult.OK
        End If

    End Sub

    Public Async Sub Edit(id As Long)

        Dim akun As Akun = Await _repositoryAkun.Edit(id)

        If akun IsNot Nothing Then
            _id = akun.id
            txtAkun.EditValue = akun.nama
            txtKeterangan.EditValue = akun.keterangan
            _update = True
        End If

    End Sub

    Private Async Sub Put()

        Dim akun As New Akun With {
            .akun_id = _id,
            .nama = txtAkun.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _repositoryAkun.Update(akun)

        If hasil Then
            DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If _update Then
            Put()
        Else
            Store()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class