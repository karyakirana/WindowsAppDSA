Imports DevExpress.XtraGrid.Views.Base.ViewInfo

Public Class frmAddTipeAkun
    Private _repositoryAkunTipe As New AkunTipeRepository
    Private _update As Boolean = False
    Private _id As Long?

    Private Async Sub Store()

        Dim akunTipe As New AkunTipe With {
            .default_field = txtDefaultSaldo.EditValue,
            .nama = txtDeskripsi.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _repositoryAkunTipe.Store(akunTipe)

        If hasil Then
            DialogResult = DialogResult.OK
        End If

    End Sub

    Public Async Sub Edit(id As Long)

        Dim akunTipe As AkunTipe = Await _repositoryAkunTipe.Edit(id)

        If akunTipe IsNot Nothing Then
            _id = akunTipe.id
            txtDefaultSaldo.EditValue = akunTipe.default_field
            txtDeskripsi.EditValue = akunTipe.nama
            txtKeterangan.EditValue = akunTipe.keterangan
            _update = True
        End If

    End Sub

    Private Async Sub Put()

        Dim akunTipe As New AkunTipe With {
            .akun_tipe_id = _id,
            .default_field = txtDefaultSaldo.EditValue,
            .nama = txtDeskripsi.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _repositoryAkunTipe.Update(akunTipe)

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