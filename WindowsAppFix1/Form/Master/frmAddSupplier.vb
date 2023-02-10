Public Class frmAddSupplier

    Public _supplierRepo As New SupplierRepository
    Public _kotaRepo As New KotaRepository
    Public _update As Boolean = False
    Public _id As Long?

    Private Async Sub LoadData()
        txtKota.Properties.DataSource = Await _kotaRepo.GetList
    End Sub

    Private Async Sub store()
        Dim supplier As New Supplier With {
            .nama = txtNama.EditValue,
            .telepon = txtTelepon.EditValue,
            .email = txtEmail.EditValue,
            .npwp = txtNpwp.EditValue,
            .alamat = txtAlamat.EditValue,
            .kota_id = txtKota.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _supplierRepo.Store(supplier)
        If hasil Then
            'form close
            MsgBox("data tersimpan")
            DialogResult = DialogResult.OK
        End If
    End Sub

    Public Async Sub Edit(id As Long)
        Dim supplier As Supplier = Await _supplierRepo.Edit(id)

        If Not supplier Is Nothing Then
            _id = supplier.id
            txtNama.EditValue = supplier.nama
            txtTelepon.EditValue = supplier.telepon
            txtEmail.EditValue = supplier.email
            txtNpwp.EditValue = supplier.npwp
            txtAlamat.EditValue = supplier.alamat
            txtKota.EditValue = supplier.kota_id
            txtKeterangan.EditValue = supplier.keterangan
            _update = True
        End If
    End Sub

    Private Async Sub put()
        Dim supplier As New Supplier With {
            .supplier_id = _id,
            .nama = txtNama.EditValue,
            .telepon = txtTelepon.EditValue,
            .email = txtEmail.EditValue,
            .npwp = txtNpwp.EditValue,
            .alamat = txtAlamat.EditValue,
            .kota_id = txtKota.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _supplierRepo.Update(supplier)
        If hasil Then
            'form close
            MsgBox("data tersimpan")
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub frmAddSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If _update Then
            put()
        Else
            store()
        End If
    End Sub
End Class