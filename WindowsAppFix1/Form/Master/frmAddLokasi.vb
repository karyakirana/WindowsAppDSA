Public Class frmAddLokasi

    Private _lokasiRepo As New LokasiRepository
    Private _update As Boolean = False
    Private _id As Long?

    Private Async Sub Store()

        Dim lokasi As New Lokasi With {
            .nama = txtGudang.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _lokasiRepo.Store(lokasi)

        If hasil Then
            DialogResult = DialogResult.OK
        End If

    End Sub

    Public Async Sub Edit(id As Long)

        Dim lokasi As Lokasi = Await _lokasiRepo.Edit(id)

        If lokasi IsNot Nothing Then
            _id = lokasi.id
            txtGudang.EditValue = lokasi.nama
            txtKeterangan.EditValue = lokasi.keterangan
            _update = True
        End If

    End Sub

    Private Async Sub Put()

        Dim lokasi As New Lokasi With {
            .lokasi_id = _id,
            .nama = txtGudang.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _lokasiRepo.Update(lokasi)

        If hasil Then
            DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If _update Then
            Put()
        Else
            Store()
        End If
    End Sub
End Class