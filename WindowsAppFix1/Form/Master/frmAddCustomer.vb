Imports System.Text.RegularExpressions

Public Class frmAddCustomer

    Private _customerRepo As New CustomerRepository
    Private _salesRepo As New PegawaiRepository
    Private _kotaRepo As New KotaRepository
    Private _customerId As Long?
    Private _update As Boolean = False

    Public Async Sub LoadData()
        Dim _listSales = Await _salesRepo.GetList()
        txtSales.Properties.DataSource = _listSales
        Dim _listKota = Await _kotaRepo.GetList
        txtKota.Properties.DataSource = _listKota
    End Sub

    Private Sub refreshCustomerList()
        Dim form As FormCustomerList = CType(Application.OpenForms("FormCustomerList"), FormCustomerList)
        form.LoadData()
    End Sub

    Private Async Sub store()

        Dim customer As New Customer With {
            .nama = txtNama.EditValue,
            .jenis_instansi = cbJenisInstansi.EditValue,
            .telepon = txtTelepon.EditValue,
            .email = txtEmail.EditValue,
            .npwp = txtNPWP.EditValue,
            .alamat = txtAlamat.EditValue,
            .kota_id = CChar(txtKota.EditValue),
            .sales_id = CLng(txtSales.EditValue),
            .diskon = CLng(txtDiskon.EditValue),
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _customerRepo.Store(customer)

        If hasil Then
            'form close
            Me.Close()
            refreshCustomerList()
        End If

    End Sub

    Private Async Sub put()
        Dim customer As New Customer With {
            .customer_id = _customerId,
            .nama = txtNama.EditValue,
            .jenis_instansi = cbJenisInstansi.EditValue,
            .telepon = txtTelepon.EditValue,
            .email = txtEmail.EditValue,
            .npwp = txtNPWP.EditValue,
            .alamat = txtAlamat.EditValue,
            .kota_id = CChar(txtKota.EditValue),
            .sales_id = CLng(txtSales.EditValue),
            .diskon = CLng(txtDiskon.EditValue),
            .keterangan = txtKeterangan.EditValue
        }

        Dim hasil = Await _customerRepo.Update(customer)

        If hasil Then
            'form close
            Me.Close()
            refreshCustomerList()
        End If
    End Sub

    Public Async Sub edit(ByVal id As Long)
        Dim getData As Customer = Await _customerRepo.Edit(id)

        If Not getData Is Nothing Then
            Dim customer As Customer = getData
            _customerId = customer.id
            cbJenisInstansi.EditValue = customer.jenis_instansi
            txtNama.EditValue = customer.nama
            txtTelepon.EditValue = customer.telepon
            txtEmail.EditValue = customer.email
            txtNPWP.EditValue = customer.npwp
            txtAlamat.EditValue = customer.alamat
            txtKota.EditValue = customer.kota_id
            txtSales.EditValue = customer.sales_id
            txtDiskon.EditValue = customer.diskon
            txtKeterangan.EditValue = customer.keterangan
            _update = True
        End If

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If _update Then
            put()
        Else
            store()
        End If
    End Sub

    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class