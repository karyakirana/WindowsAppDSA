Public Class frmAddLokasi
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "Simpan" Then
            If insertLokasi(txtGudang.EditValue, txtKeterangan.EditValue) = True Then
                statusInsert = obj.Item("status")
                If statusInsert = True Then
                    If statusInsert = True Then
                        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
                        Dim frm As New frmCustomer
                        frm.GridControl1.DataSource = Nothing
                        clearDTLokasi()
                        setColumnDTLokasi()
                        getLokasi()
                        frm.GridControl1.DataSource = dtLokasi
                        Me.Close()
                    Else
                        MsgBox("Terjadi kesalahan proses simpan data!", MsgBoxStyle.Critical, "Perhatian")
                        Exit Sub
                    End If
                End If
            End If
        Else
            updateLokasi(id_lokasi, txtGudang.EditValue, txtKeterangan.EditValue)
            statusUpdate = obj.Item("status")
            If statusUpdate = True Then
                MsgBox("Data berhasil diupdate!", MsgBoxStyle.Information, "Informasi")
                Dim frm As New frmCustomer
                frm.GridControl1.DataSource = Nothing
                clearDTLokasi()
                setColumnDTLokasi()
                getLokasi()
                frm.GridControl1.DataSource = dtLokasi
                Me.Close()
            Else
                MsgBox("Terjadi kesalahan proses update data!", MsgBoxStyle.Critical, "Perhatian")
                Exit Sub
            End If
        End If
    End Sub



    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        clearDTLokasi()
        setColumnDTLokasi()
        getLokasi()
        Me.Close()
    End Sub

    Private Sub frmAddLokasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        If purpose = "New" Then
            btnSimpan.Text = "Simpan"
        Else
            txtGudang.EditValue = dtLokasi.Rows(0)("nama").ToString
            txtKeterangan.EditValue = dtLokasi.Rows(0)("keterangan").ToString
            btnSimpan.Text = "Update"
        End If
    End Sub
End Class