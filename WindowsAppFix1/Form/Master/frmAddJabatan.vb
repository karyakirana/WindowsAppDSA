Public Class frmAddJabatan
    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If btnSimpan.Text = "Simpan" Then
            If insertJabatan(txtNama.EditValue, txtKeterangan.EditValue) = True Then
                statusInsert = obj.Item("status")
                If statusInsert = True Then
                    If statusInsert = True Then
                        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
                        Dim frm As New frmCustomer
                        frm.GridControl1.DataSource = Nothing
                        clearDtJabatan()
                        setColumnDTJabatan()
                        getJabatan()
                        frm.GridControl1.DataSource = dtJabatan
                        Me.Close()
                    Else
                        MsgBox("Terjadi kesalahan proses simpan data!", MsgBoxStyle.Critical, "Perhatian")
                        Exit Sub
                    End If
                End If
            End If
        Else
            updateJabatan(id_jabatan, kode_jabatan, txtNama.EditValue, txtKeterangan.EditValue)
            statusUpdate = obj.Item("status")
            If statusUpdate = True Then
                MsgBox("Data berhasil diupdate!", MsgBoxStyle.Information, "Informasi")
                Dim frm As New frmCustomer
                frm.GridControl1.DataSource = Nothing
                clearDtJabatan()
                setColumnDTJabatan()
                getJabatan()
                frm.GridControl1.DataSource = dtJabatan
                Me.Close()
            Else
                MsgBox("Terjadi kesalahan proses update data!", MsgBoxStyle.Critical, "Perhatian")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnBatal_Click_1(sender As Object, e As EventArgs) Handles btnBatal.Click
        If purpose = "Edit" Then
            Me.Close()
            Dim frm As New frmJabatan
            frm.GridControl1.DataSource = Nothing
            clearDtJabatan()
            setColumnDTJabatan()
            getJabatan()
            frm.GridControl1.DataSource = dtJabatan
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmAddJabatan_Load(sender As Object, e As EventArgs) Handles Me.Load
        If purpose = "New" Then
            btnSimpan.Text = "Simpan"
        Else
            txtNama.EditValue = dtJabatan.Rows(0)("nama").ToString
            txtKeterangan.EditValue = dtJabatan.Rows(0)("keterangan").ToString
            btnSimpan.Text = "Update"
        End If
    End Sub
End Class