Public Class frmAddPegawai

    Private Sub frmAddPegawai_Load(sender As Object, e As EventArgs) Handles Me.Load
        clearDtJabatan()
        setColumnDTJabatan()
        getJabatan()
        For i = 0 To dtJabatan.Rows.Count - 1
            cbJabatan.Properties.Items.Add(dtJabatan.Rows(i)("nama").ToString)
        Next

        XtraTabPage2.PageVisible = False

        clearDtKota()
        setColumnDTKota()
        getKota()

        If purpose = "New" Then
            btnSimpan.Text = "Simpan"
        Else
            txtNama.EditValue = dtPegawai.Rows(0)("nama").ToString
            cbGender.EditValue = dtPegawai.Rows(0)("gender").ToString
            cbJabatan.EditValue = dtPegawai.Rows(0)("nama_jabatan").ToString
            txtEmail.EditValue = dtPegawai.Rows(0)("email").ToString
            txtTelepon.EditValue = dtPegawai.Rows(0)("telepon").ToString
            txtNpwp.EditValue = dtPegawai.Rows(0)("npwp").ToString
            txtTelepon.EditValue = dtPegawai.Rows(0)("telepon").ToString
            txtNpwp.EditValue = dtPegawai.Rows(0)("npwp").ToString
            txtAlamat.EditValue = dtPegawai.Rows(0)("alamat").ToString
            txtKota.EditValue = dtPegawai.Rows(0)("nama_kota").ToString
            txtKeterangan.EditValue = dtPegawai.Rows(0)("keterangan").ToString
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

                insertPegawai(txtNama.EditValue, cbGender.EditValue, txtTelepon.EditValue, txtEmail.EditValue, txtNpwp.EditValue, id_jabatan, txtAlamat.EditValue, id_kota, txtKeterangan.EditValue)
                statusInsert = obj.Item("status")
                If statusInsert = True Then
                    MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
                    Dim frm As New frmCustomer
                    frm.GridControl1.DataSource = Nothing
                    clearDtPegawai()
                    setColumnDTPegawai()
                    getPegawai()
                    frm.GridControl1.DataSource = dtPegawai
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

                For j = 0 To dtJabatan.Rows.Count - 1
                    If txtKota.EditValue = dtJabatan.Rows(j)("nama").ToString.TrimEnd Then
                        id_jabatan = dtJabatan.Rows(j)("id")
                    End If
                Next

                updatePegawai(id_pegawai, kode_pegawai, txtNama.EditValue, cbGender.EditValue, txtTelepon.EditValue, txtEmail.EditValue, txtNpwp.EditValue,
                              id_jabatan, txtAlamat.EditValue, id_kota, txtKeterangan.EditValue)
                statusUpdate = obj.Item("status")
                If statusUpdate = True Then
                    MsgBox("Data berhasil diupdate!", MsgBoxStyle.Information, "Informasi")
                    Dim frm As New frmCustomer
                    frm.GridControl1.DataSource = Nothing
                    clearDtPegawai()
                    setColumnDTPegawai()
                    getPegawai()
                    frm.GridControl1.DataSource = dtPegawai
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

    Private Sub btnBatal_Click_1(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        clearDtPegawai()
        setColumnDTPegawai()
        getPegawai()
    End Sub

    Private Sub cbJabatan_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbJabatan.SelectedIndexChanged
        'For i = 0 To dtJabatan.Rows.Count - 1
        '    If cbJabatan.EditValue = dtJabatan.Rows(i)("nama").ToString.TrimEnd Then
        '        id_jabatan = dtJabatan.Rows(i)("id")
        '    End If
        'Next
        For i = 0 To dtJabatan.Rows.Count - 1
            If cbJabatan.EditValue = dtJabatan.Rows(i)("nama").ToString.TrimEnd Then
                id_jabatan = dtJabatan.Rows(i)("id")
            End If
        Next
    End Sub

    Private Sub btnTambahJabatan_Click(sender As Object, e As EventArgs) Handles btnTambahJabatan.Click
        XtraTabPage2.PageVisible = True
        XtraTabControl1.SelectedTabPage = XtraTabPage2
    End Sub

    Private Sub btnSimpanJabatan_Click(sender As Object, e As EventArgs) Handles btnSimpanJabatan.Click
        If insertJabatan(txtAddJabatan.EditValue, txtAddKeterangan.EditValue) = True Then
            statusInsert = obj.Item("status")
            If statusInsert = True Then
                MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.Information, "Informasi")
                txtAddJabatan.EditValue = ""
                txtAddKeterangan.EditValue = ""

                clearDtJabatan()
                setColumnDTJabatan()
                getJabatan()

                cbJabatan.Properties.Items.Clear()

                For i = 0 To dtJabatan.Rows.Count - 1
                    cbJabatan.Properties.Items.Add(dtJabatan.Rows(i)("nama").ToString)
                Next

                XtraTabPage2.PageVisible = False
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Else
                MsgBox("Terjadi kesalahan saat proses simpan data!", MsgBoxStyle.Critical, "Perhatian!")
            End If
        End If
    End Sub

    Private Sub btnBatalJabatan_Click(sender As Object, e As EventArgs) Handles btnBatalJabatan.Click
        XtraTabPage2.PageVisible = False
        XtraTabControl1.SelectedTabPage = XtraTabPage1
    End Sub

End Class