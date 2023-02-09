Imports DevExpress.CodeParser
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting.Export.Pdf
Imports Newtonsoft.Json

Public Class frmAddPenjualan

    Private _penjualanRepo As PenjualanRepository
    Private _lokasiRepository As New LokasiRepository
    Private _persediaanRepo As New PersediaanRepo
    Public dtPenjualan As New DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadData()

    End Sub

    Public Sub LoadData()
        LoadDatatable()
    End Sub


    Private Sub LoadDatatable()
        'initate Coloumn
        dtPenjualan.Columns.Add("persediaan_id", GetType(Long))
        dtPenjualan.Columns.Add("produk_nama", GetType(String))
        dtPenjualan.Columns.Add("batch", GetType(String))
        dtPenjualan.Columns.Add("expired", GetType(String))
        dtPenjualan.Columns.Add("serial_number", GetType(String))
        dtPenjualan.Columns.Add("harga", GetType(Integer))
        dtPenjualan.Columns.Add("diskon", GetType(Integer))
        dtPenjualan.Columns.Add("jumlah", GetType(Integer))
        dtPenjualan.Columns.Add("sub_total", GetType(Integer))
        GridControl1.DataSource = dtPenjualan

    End Sub

    Public Async Sub SetRow(id As Long)
        'get data
        Dim getData As Persediaan = Await _persediaanRepo.edit(id)
        'set to row
        If Not getData Is Nothing Then

            Dim persediaan As New Persediaan
            persediaan = getData

            Dim row As DataRow
            row = dtPenjualan.NewRow
            row("persediaan_id") = persediaan.id
            row("produk_nama") = persediaan.produk.nama
            row("batch") = ""
            row("expired") = ""
            row("serial_number") = ""
            row("harga") = persediaan.produk.harga
            row("diskon") = 0
            row("jumlah") = 0
            row("sub_total") = 0

            dtPenjualan.Rows.Add(row)
            GridControl1.DataSource = dtPenjualan

        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Using frm As FrmFindProduk = New FrmFindProduk
            If frm.ShowDialog = DialogResult.OK Then
                SetRow(frm.GetValue)
                Console.WriteLine(frm.GetValue)
            End If
        End Using

    End Sub

    Public Sub Edit(id As Long)

    End Sub

End Class