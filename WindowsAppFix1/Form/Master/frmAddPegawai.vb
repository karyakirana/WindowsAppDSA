Public Class frmAddPegawai

    Private _pegawaiRepo As New PegawaiRepository
    Private id As Long?
    Private _update As Boolean = False

    Private Sub _refresh()
        FormPegawaiList.LoadData()
    End Sub

    Private Async Sub Store()
        Dim pegawai As New Pegawai With {
            .nama = txtNama.EditValue,
            .gender = cbGender.EditValue,
            .telepon = txtTelepon.EditValue,
            .email = txtEmail.EditValue,
            .npwp = txtNpwp.EditValue,
            .jabatan_id = cbJabatan.EditValue,
            .alamat = txtAlamat.EditValue,
            .kota_id = txtKota.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _pegawaiRepo.Store(pegawai)

        If hasil Then
            'form close
            Close()
            _refresh()
        End If

    End Sub

    Public Async Sub edit(ByVal id As Long)
        Dim getData As Pegawai = Await _pegawaiRepo.Edit(id)

        If Not getData Is Nothing Then
            id = getData.id
            txtNama.EditValue = getData.nama
            cbGender.EditValue = getData.gender
            txtTelepon.EditValue = getData.telepon
            txtEmail.EditValue = getData.email
            txtNpwp.EditValue = getData.npwp
            cbJabatan.EditValue = getData.jabatan_id
            txtAlamat.EditValue = getData.alamat
            txtKota.EditValue = getData.kota_id
            txtKeterangan.EditValue = getData.keterangan
            _update = True
        End If

    End Sub

    Private Async Sub Put()
        Dim pegawai As New Pegawai With {
            .pegawai_id = id,
            .nama = txtNama.EditValue,
            .gender = cbGender.EditValue,
            .telepon = txtTelepon.EditValue,
            .email = txtEmail.EditValue,
            .npwp = txtNpwp.EditValue,
            .jabatan_id = cbJabatan.EditValue,
            .alamat = txtAlamat.EditValue,
            .kota_id = txtKota.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _pegawaiRepo.Update(pegawai)

        If hasil Then
            'form close
            Close()
            _refresh()
        End If

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If _update Then
            Put()
        Else
            Store()
        End If
    End Sub
End Class