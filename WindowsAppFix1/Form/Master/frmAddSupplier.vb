Public Class frmAddSupplier

    Public _supplierRepo As New SupplierRepository
    Public _update As Boolean = False
    Public _id As Long?

    Private Async Sub store()
        Dim supplier As New Supplier With {
            .nama = txtNama.EditValue,
            .telepon = txtTelepon.EditValue,
            .email = txtEmail.EditValue,
            .npwp = txtNpwp.EditValue,
            .alamat = txtAlamat.EditValue,
            .kota_id = txtAlamat.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _supplierRepo.Store(supplier)
        If hasil Then
            'form close
            DialogResult = DialogResult.OK
            Close()
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
            .kota_id = txtAlamat.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _supplierRepo.Update(supplier)
        If hasil Then
            'form close
            Close()
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class