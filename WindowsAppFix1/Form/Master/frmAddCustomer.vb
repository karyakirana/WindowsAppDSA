'lamaaaaaaaaaaaaaaa'

Imports System.Text.RegularExpressions

Public Class frmAddCustomer
    'by Adib

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "Simpan" Then
            Try
                For i = 0 To dtKota.Rows.Count - 1
                    If txtKota.EditValue = dtKota.Rows(i)("nama_kota").ToString.TrimEnd Then
                        id_kota = dtKota.Rows(i)("id")
                    End If
                Next

                insertCustomer(txtNama.EditValue, cbJenisInstansi.EditValue, txtSales.EditValue, txtAlamat.EditValue, id_kota, txtEmail.EditValue, txtTelepon.EditValue, txtNPWP.EditValue, txtDiskon.EditValue, txtKeterangan.EditValue)
                statusInsert = obj.Item("status")
                If statusInsert = True Then
                    MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
                    Dim frm As New frmCustomer
                    frm.GridControl1.DataSource = Nothing
                    clearDtCustomer()
                    setColumnDTCustomer()
                    getCustomer()
                    frm.GridControl1.DataSource = dtCustomer
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

                For j = 0 To dtPegawai.Rows.Count - 1
                    If txtSales.Text.TrimEnd = dtPegawai.Rows(j)("nama").ToString.TrimEnd Then
                        id_sales = dtPegawai.Rows(j)("id")
                    End If
                Next

                updateCustomer(id_cust, kode_cust, txtNama.EditValue, cbJenisInstansi.EditValue, id_sales, txtAlamat.EditValue, id_kota, txtEmail.EditValue, txtTelepon.EditValue, txtNPWP.EditValue, txtDiskon.EditValue, txtKeterangan.EditValue)
                statusUpdate = obj.Item("status")
                If statusUpdate = True Then
                    MsgBox("Data berhasil diupdate!", MsgBoxStyle.Information, "Informasi")
                    Dim frm As New frmCustomer
                    frm.GridControl1.DataSource = Nothing
                    clearDtCustomer()
                    setColumnDTCustomer()
                    getCustomer()
                    frm.GridControl1.DataSource = dtCustomer
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

    Private Sub txtKota_Click(sender As Object, e As EventArgs) Handles txtKota.Click
        Dim frm As New frmKota
        Dim i : i = frm.ShowDialog()
        If CType(i, DialogResult) = 2 Then
            Me.txtKota.EditValue = Kota
        End If
    End Sub

    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNama.Select()
        clearDtKota()
        setColumnDTKota()
        getKota()
        clearDtPegawai()
        setColumnDTPegawai()
        getPegawai()
        txtSales.Properties.DataSource = dtPegawai
        txtSales.Properties.DisplayMember = "nama"
        txtSales.Properties.ValueMember = "id"
        txtSales.Properties.PopulateColumns()
        txtSales.Properties.Columns("id").Visible = False
        txtSales.Properties.Columns("nama").Caption = "Sales"
        txtSales.Properties.Columns("kode").Visible = False
        txtSales.Properties.Columns("status").Visible = False
        txtSales.Properties.Columns("gender").Visible = False
        txtSales.Properties.Columns("telepon").Visible = False
        txtSales.Properties.Columns("email").Visible = False
        txtSales.Properties.Columns("npwp").Visible = False
        txtSales.Properties.Columns("jabatan_id").Visible = False
        txtSales.Properties.Columns("alamat").Visible = False
        txtSales.Properties.Columns("kota_id").Visible = False
        txtSales.Properties.Columns("keterangan").Visible = False
        txtSales.Properties.Columns("nama_kota").Visible = False
        txtSales.Properties.Columns("nama_jabatan").Caption = "Jabatan"

        If purpose = "New" Then
            btnSimpan.Text = "Simpan"
        Else
            txtNama.EditValue = dtCustomer.Rows(0)("nama").ToString
            cbJenisInstansi.EditValue = dtCustomer.Rows(0)("jenis_instansi").ToString
            txtSales.Text = dtCustomer.Rows(0)("sales_name").ToString
            txtAlamat.EditValue = dtCustomer.Rows(0)("alamat").ToString
            txtKota.EditValue = dtCustomer.Rows(0)("kota_name").ToString
            txtEmail.EditValue = dtCustomer.Rows(0)("email").ToString
            txtTelepon.EditValue = dtCustomer.Rows(0)("telepon").ToString
            txtNPWP.EditValue = dtCustomer.Rows(0)("npwp").ToString
            txtDiskon.EditValue = dtCustomer.Rows(0)("diskon").ToString
            txtKeterangan.EditValue = dtCustomer.Rows(0)("keterangan").ToString
            btnSimpan.Text = "Update"
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If purpose = "Edit" Then
            Me.Close()
            Dim frm As New frmCustomer
            frm.GridControl1.DataSource = Nothing
            clearDtCustomer()
            setColumnDTCustomer()
            getCustomer()
            frm.GridControl1.DataSource = dtCustomer
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        validasiEmail(txtEmail.EditValue, txtEmail, DxErrorProvider1)
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        validasiAngka(e, txtTelepon, DxErrorProvider1)
    End Sub

    Private Sub txtNama_LostFocus(sender As Object, e As EventArgs) Handles txtNama.LostFocus
        validasiDataKosong(txtNama.EditValue, txtNama, DxErrorProvider1)
    End Sub

    Private Sub txtNPWP_LostFocus(sender As Object, e As EventArgs) Handles txtNPWP.LostFocus
        validasiDataKosong(txtNPWP.EditValue, txtNPWP, DxErrorProvider1)
    End Sub

    Private Sub cbJenisInstansi_LostFocus(sender As Object, e As EventArgs) Handles cbJenisInstansi.LostFocus
        validasiDataKosong(cbJenisInstansi.Text, cbJenisInstansi, DxErrorProvider1)
    End Sub

    Private Sub txtSales_LostFocus(sender As Object, e As EventArgs) Handles txtSales.LostFocus
        validasiDataKosong(txtSales.Text, txtSales, DxErrorProvider1)
    End Sub

    Private Sub txtAlamat_LostFocus(sender As Object, e As EventArgs) Handles txtAlamat.LostFocus
        validasiDataKosong(txtAlamat.EditValue, txtAlamat, DxErrorProvider1)
    End Sub
    Private Sub txtKota_LostFocus(sender As Object, e As EventArgs) Handles txtKota.LostFocus
        validasiDataKosong(txtKota.EditValue, txtKota, DxErrorProvider1)
    End Sub

End Class