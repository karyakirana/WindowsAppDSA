Public Class FormLokasi

    Private _lokasiRepo As New LokasiRepository
    Private _lokasiId As Long?
    Private _update As Boolean = False

    'refresh datatable
    Private Sub _refresh()
        FormLokasiList.LoadData()
    End Sub

    Private Async Sub store()

        Dim lokasi As New Lokasi With {
            .nama = namaTextEdit.EditValue,
            .keterangan = keteranganTextEdit.EditValue
        }

        Dim hasil = Await _lokasiRepo.Store(lokasi)

        If hasil Then
            Close()
            _refresh()
        End If

    End Sub

    Public Async Sub edit(id As Long)
        Dim getData As Lokasi = Await _lokasiRepo.Edit(id)

        If Not getData Is Nothing Then
            Dim lokasi As Lokasi = getData
            _lokasiId = lokasi.id
            namaTextEdit.EditValue = lokasi.nama
            keteranganTextEdit.EditValue = lokasi.keterangan
            _update = True
        End If
    End Sub

    Public Async Sub put()
        Dim lokasi As New Lokasi With {
            .lokasi_id = _lokasiId,
            .nama = namaTextEdit.EditValue,
            .keterangan = keteranganTextEdit.EditValue
        }

        Dim hasil = Await _lokasiRepo.Update(lokasi)

        If hasil Then
            Close()
            _refresh()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If _update Then
            put()
        Else
            store()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Close()
    End Sub
End Class