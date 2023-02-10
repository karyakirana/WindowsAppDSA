Public Class frmAddPegawai

    Private _pegawaiRepo As New PegawaiRepository
    Private jabatanRepo As New JabatanRepository
    Private kotaRepo As New KotaRepository
    Private _id As Long?
    Private _update As Boolean = False

    Private Async Sub LoadData()
        cbJabatan.Properties.DataSource = Await jabatanRepo.GetList()
        txtKota.Properties.DataSource = Await kotaRepo.GetList()
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
            DialogResult = DialogResult.OK
        End If

    End Sub

    Public Async Sub edit(ByVal id As Long)
        Dim getData As Pegawai = Await _pegawaiRepo.Edit(id)

        If Not getData Is Nothing Then
            _id = getData.id
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
            .pegawai_id = _id,
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
            DialogResult = DialogResult.OK
        End If

    End Sub

    Private Async Sub StoreJabatan()

        Dim jabatan As New Jabatan With {
            .nama = txtAddJabatan.EditValue,
            .keterangan = txtAddKeterangan.EditValue
        }
        Dim hasil = Await jabatanRepo.Store(jabatan)

        If hasil Then
            'reload cb jabatan
            LoadData()
            MsgBox("Jabatan Tersimpan")
            txtAddJabatan.EditValue = ""
            txtAddKeterangan.EditValue = ""
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

    Private Sub frmAddPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnSimpanJabatan_Click(sender As Object, e As EventArgs) Handles btnSimpanJabatan.Click
        StoreJabatan()
    End Sub
End Class