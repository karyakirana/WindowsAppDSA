Public Class FormPegawai
    Public _jabatanRepo As JabatanRepository = New JabatanRepository
    Public _pegawaiRepo As New PegawaiRepository
    Private _pegawaiId As Long?
    Private _update As Boolean = False
    Private Sub FormPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        cbJabatan.DataSource = _jabatanRepo.GetList()
    End Sub

    Private Async Sub store()

        Dim pegawai As New Pegawai With {
            .status = statusComboBoxEdit.EditValue,
            .nama = namaTextEdit.EditValue,
            .gender = genderTextEdit.EditValue,
            .telepon = teleponTextEdit.EditValue,
            .email = emailTextEdit.EditValue,
            .npwp = npwpTextEdit.EditValue,
            .jabatan_id = jabatan_idTextEdit.EditValue,
            .alamat = alamatTextEdit.EditValue,
            .kota_id = kota_idTextEdit.EditValue,
            .keterangan = keteranganTextEdit.EditValue
        }

        Dim hasil = Await _pegawaiRepo.Store(pegawai)

        If hasil Then
            'form close
            DialogResult = DialogResult.OK
            Close()
        End If

    End Sub

    Public Async Sub edit(id As Long)
        Dim getData As Pegawai = Await _pegawaiRepo.Edit(id)

        If Not getData Is Nothing Then
            Dim pegawai As Pegawai = getData
            _pegawaiId = pegawai.id
            namaTextEdit.EditValue = pegawai.nama
            keteranganTextEdit.EditValue = pegawai.keterangan
            _update = True
        End If
    End Sub

    Private Async Sub put()

        Dim pegawai As New Pegawai With {
            .pegawai_id = _pegawaiId,
            .status = statusComboBoxEdit.EditValue,
            .nama = namaTextEdit.EditValue,
            .gender = genderTextEdit.EditValue,
            .telepon = teleponTextEdit.EditValue,
            .email = emailTextEdit.EditValue,
            .npwp = npwpTextEdit.EditValue,
            .jabatan_id = jabatan_idTextEdit.EditValue,
            .alamat = alamatTextEdit.EditValue,
            .kota_id = kota_idTextEdit.EditValue,
            .keterangan = keteranganTextEdit.EditValue
        }

        Dim hasil = Await _pegawaiRepo.Update(pegawai)

        If hasil Then
            'form close
            DialogResult = DialogResult.OK
            Close()
        End If

    End Sub

End Class