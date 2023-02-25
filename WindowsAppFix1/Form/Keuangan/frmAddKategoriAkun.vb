Public Class frmAddKategoriAkun
    Private _repositoriAkunKategori As New AkunKategoriRepository
    Private _update As Boolean = False
    Private _id As Long?

    Private Async Sub Store()
        Dim akunKategori As New AkunKategori With {
          .nama = txtKategoriAkun.EditValue,
          .keterangan = txtKeterangan.EditValue
      }

        Dim hasil = Await _repositoriAkunKategori.Store(akunKategori)

        If hasil Then
            DialogResult = DialogResult.OK
        End If
    End Sub

    Public Async Sub Edit(id As Long)

        Dim akunKategori As AkunKategori = Await _repositoriAkunKategori.Edit(id)

        If akunKategori IsNot Nothing Then
            _id = akunKategori.id
            txtKategoriAkun.EditValue = akunKategori.nama
            txtKeterangan.EditValue = akunKategori.keterangan
            _update = True
        End If

    End Sub

    Private Async Sub Put()

        Dim akunKategori As New AkunKategori With {
            .akun_kategori_id = _id,
            .nama = txtKategoriAkun.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _repositoriAkunKategori.Update(akunKategori)

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