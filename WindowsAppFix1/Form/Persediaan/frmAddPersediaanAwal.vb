Imports System.ComponentModel
Imports System.Net
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid



Public Class frmAddPersediaanAwal

    Private _lokasiRepository As New LokasiRepository
    Private _persediaanRepo As New PersediaanRepo
    Public dtPersediaan As New DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadDatatable()

    End Sub

    Private Async Sub LoadData()
        Dim listLokasi = Await _lokasiRepository.GetList()
        cbLokasi.Properties.DataSource = listLokasi

    End Sub

    Private Sub LoadDatatable()
        'initiate column
        dtPersediaan.Columns.Add("persediaan_id", GetType(Int64))
        dtPersediaan.Columns.Add("produk_nama", GetType(String))
        dtPersediaan.Columns.Add("batch", GetType(String))
        dtPersediaan.Columns.Add("expired", GetType(String))
        dtPersediaan.Columns.Add("serial_number", GetType(String))
        dtPersediaan.Columns.Add("harga", GetType(Integer))
        dtPersediaan.Columns.Add("jumlah", GetType(Integer))
        dtPersediaan.Columns.Add("sub_total", GetType(Integer))
        GridControl1.DataSource = dtPersediaan

        'GridView1.Columns.ColumnByFieldName("persediaan_id").VisibleIndex = 0
        'GridView1.Columns.ColumnByFieldName("produk_nama").VisibleIndex = 1
        'GridView1.Columns.ColumnByFieldName("batch").VisibleIndex = 2
        'GridView1.Columns.ColumnByFieldName("expired").VisibleIndex = 3
        'GridView1.Columns.ColumnByFieldName("serial_number").VisibleIndex = 4
        'GridView1.Columns.ColumnByFieldName("harga").VisibleIndex = 5
        'GridView1.Columns.ColumnByFieldName("jumlah").VisibleIndex = 6
        'GridView1.Columns.ColumnByFieldName("sub_total").VisibleIndex = 7

    End Sub

    Public Async Sub setRow(ByVal id As Long)
        'get data
        Dim getData As Persediaan = Await _persediaanRepo.edit(id)
        'set to row
        If Not getData Is Nothing Then

            Dim persediaan As New Persediaan
            persediaan = getData

            Dim row As DataRow
            row = dtPersediaan.NewRow()
            row("persediaan_id") = persediaan.id
            row("produk_nama") = persediaan.produk.nama
            row("batch") = ""
            row("expired") = ""
            row("serial_number") = ""
            row("harga") = 0
            row("jumlah") = 0
            row("sub_total") = 0

            dtPersediaan.Rows.Add(row)
            GridControl1.DataSource = dtPersediaan
            'Console.WriteLine(getData)
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Using frm As FrmFindProduk = New FrmFindProduk()
            If frm.ShowDialog = DialogResult.OK Then
                setRow(frm.GetValue)
                Console.WriteLine(frm.GetValue)
            End If
        End Using

    End Sub



    Private Sub frmAddPersediaanAwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        'load datatable
        'LoadDatatable()
    End Sub

    Private Sub GridControl1_KeyUp(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyUp

    End Sub

    'helper
    Private Function hitungSubTotal(harga As Integer, jumlah As Integer) As Integer
        Return harga * jumlah
    End Function

End Class