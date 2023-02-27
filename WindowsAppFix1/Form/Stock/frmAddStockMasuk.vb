Imports System.ComponentModel
Imports System.Net
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmAddStockMasuk
    Private _lokasiRepository As New LokasiRepository
    Private _produkRepo As New ProdukRepository
    Private _StockmasukRepo As New StockMasukRepository
    Public dtProduk As New DataTable
    Dim draft, lokasi_id As Integer
    Dim listlokasi As List(Of Lokasi)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadDatatable()

    End Sub

    Private Async Sub LoadData()
        listlokasi = Await _lokasiRepository.GetList()
        cbLokasi.Properties.DataSource = listlokasi
    End Sub

    Private Sub LoadDataTable()

    End Sub


End Class