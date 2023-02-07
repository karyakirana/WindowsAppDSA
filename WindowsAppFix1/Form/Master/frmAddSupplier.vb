Public Class frmAddSupplier

    Private Sub frmAddSupplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        clearDtKota()
        setColumnDTKota()
        getKota()

        If purpose = "New" Then
            btnSimpan.Text = "Simpan"
        Else
            txtNama.EditValue = dtSupplier.Rows(0)("nama").ToString
            txtTelepon.EditValue = dtSupplier.Rows(0)("telepon").ToString
            txtEmail.EditValue = dtSupplier.Rows(0)("email").ToString
            txtNpwp.EditValue = dtSupplier.Rows(0)("npwp").ToString
            txtAlamat.EditValue = dtSupplier.Rows(0)("alamat").ToString
            txtKota.EditValue = dtSupplier.Rows(0)("nama_kota").ToString
            txtKeterangan.EditValue = dtSupplier.Rows(0)("keterangan").ToString
            btnSimpan.Text = "Update"
        End If
    End Sub

    Private Sub txtKota_Click(sender As Object, e As EventArgs) Handles txtKota.Click
        Dim frm As New frmKota
        Dim i : i = frm.ShowDialog()
        If CType(i, DialogResult) = 2 Then
            Me.txtKota.EditValue = Kota
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "Simpan" Then
            Try
                For i = 0 To dtKota.Rows.Count - 1
                    If txtKota.EditValue = dtKota.Rows(i)("nama_kota").ToString.TrimEnd Then
                        id_kota = dtKota.Rows(i)("id")
                    End If
                Next

                insertSupplier(txtNama.EditValue, txtTelepon.EditValue, txtAlamat.EditValue, id_kota, txtEmail.EditValue, txtNpwp.EditValue, txtKeterangan.EditValue)
                statusInsert = obj.Item("status")
                If statusInsert = True Then
                    MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
                    Dim frm As New frmSupplier
                    frm.GridControl1.DataSource = Nothing
                    clearDtSupplier()
                    setColumnDTSupplier()
                    getSupplier()
                    frm.GridControl1.DataSource = dtSupplier
                    Me.Close()
                Else
                    MsgBox("Terjadi kesalahan proses simpan data!", MsgBoxStyle.Critical, "Perhatian")
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For i = 0 To dtKota.Rows.Count - 1
                    If txtKota.EditValue = dtKota.Rows(i)("nama_kota").ToString.TrimEnd Then
                        id_kota = dtKota.Rows(i)("id")
                    End If
                Next

                updateSupplier(id_supplier, kode_supplier, txtNama.EditValue, txtTelepon.EditValue, txtAlamat.EditValue, id_kota, txtEmail.EditValue, txtNpwp.EditValue, txtKeterangan.EditValue)
                statusUpdate = obj.Item("status")
                If statusUpdate = True Then
                    MsgBox("Data berhasil diupdate!", MsgBoxStyle.Information, "Informasi")
                    Dim frm As New frmSupplier
                    frm.GridControl1.DataSource = Nothing
                    clearDtSupplier()
                    setColumnDTSupplier()
                    getSupplier()
                    frm.GridControl1.DataSource = dtSupplier
                    Me.Close()
                Else
                    MsgBox("Terjadi kesalahan proses update data!", MsgBoxStyle.Critical, "Perhatian")
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        clearDtSupplier()
        setColumnDTSupplier()
        getSupplier()
    End Sub
End Class