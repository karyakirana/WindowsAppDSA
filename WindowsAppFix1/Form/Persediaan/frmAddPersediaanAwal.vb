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



Public Class frmAddPersediaanAwal

    Private _lokasiRepository As New LokasiRepository
    Private _persediaanRepo As New PersediaanRepo
    Private _persediaanAwalRepo As New PersediaanAwalRepo
    Public dtPersediaan As New DataTable
    Dim exp As DateTime
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

        GridView1.Columns.ColumnByFieldName("persediaan_id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("produk_nama").VisibleIndex = 0
        GridView1.Columns.ColumnByFieldName("produk_nama").Caption = "Nama Produk"
        GridView1.Columns.ColumnByFieldName("produk_nama").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("produk_nama").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns.ColumnByFieldName("produk_nama").OptionsColumn.AllowEdit = False
        GridView1.Columns.ColumnByFieldName("batch").VisibleIndex = 1
        GridView1.Columns.ColumnByFieldName("batch").Caption = "Batch"
        GridView1.Columns.ColumnByFieldName("batch").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("batch").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("expired").VisibleIndex = 2
        GridView1.Columns.ColumnByFieldName("expired").Caption = "Kadaluarsa"
        GridView1.Columns.ColumnByFieldName("expired").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("expired").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("serial_number").VisibleIndex = 3
        GridView1.Columns.ColumnByFieldName("serial_number").Caption = "Serial Number"
        GridView1.Columns.ColumnByFieldName("serial_number").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("serial_number").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("harga").VisibleIndex = 4
        GridView1.Columns.ColumnByFieldName("harga").Caption = "Harga"
        GridView1.Columns.ColumnByFieldName("harga").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("harga").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns.ColumnByFieldName("jumlah").VisibleIndex = 5
        GridView1.Columns.ColumnByFieldName("jumlah").Caption = "Jumlah"
        GridView1.Columns.ColumnByFieldName("jumlah").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("jumlah").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns.ColumnByFieldName("sub_total").VisibleIndex = 6
        GridView1.Columns.ColumnByFieldName("sub_total").Caption = "Sub Total"
        GridView1.Columns.ColumnByFieldName("sub_total").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("sub_total").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns.ColumnByFieldName("sub_total").OptionsColumn.AllowEdit = False

        GridControl1.RepositoryItems.Add(RepositoryItemDateEdit1)
        GridView1.Columns("expired").ColumnEdit = RepositoryItemDateEdit1
        dtTanggal.EditValue = Date.Now

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
            row("expired") = Format(Date.Now, "yyyy-MM-dd")
            row("serial_number") = ""
            row("harga") = persediaan.harga_beli
            row("jumlah") = 0
            row("sub_total") = 0

            dtPersediaan.Rows.Add(row)
            GridControl1.DataSource = dtPersediaan

            GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatString = "n0"
            'Console.WriteLine(getData)
        End If
    End Sub

    Public Async Sub Edit(id As Long)
        'load data
        Dim persediaan_awal As PersediaanAwal = Await _persediaanAwalRepo.Edit(id)

        'set form
        cbKondisi.EditValue = persediaan_awal.kondisi
        cbLokasi.EditValue = persediaan_awal.lokasi_id
        dtTanggal.EditValue = persediaan_awal.tgl_persediaan_awal
        cbDraft.EditValue = persediaan_awal.draft
        txtKeterangan.EditValue = persediaan_awal.keterangan

        'set detail
        'Dim detail_list As List(Of PersediaanAwalDetail)

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
    End Sub

    Private Sub GridControl1_KeyUp(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyUp

    End Sub

    'helper
    Private Function hitungSubTotal(harga As Integer, jumlah As Integer) As Integer
        Return harga * jumlah
    End Function

    Private Sub cbDraft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDraft.SelectedIndexChanged
        If cbDraft.EditValue = True Then
            draft = 1
        Else
            draft = 0
        End If
    End Sub

    Private Sub GridView1_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        If GridView1.FocusedColumn.FieldName = "serial_number" Then
            RepositoryItemDateEdit1.Mask.EditMask = "yyyy-MM-dd"
            RepositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = True

            exp = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "expired")
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "expired", Format(exp, "yyyy-MM-dd"))
        End If

        If GridView1.FocusedColumn.FieldName = "sub_total" Then
            txtTotal.EditValue = 0
            For i = 0 To GridView1.DataRowCount - 1
                txtTotal.EditValue += GridView1.GetRowCellValue(i, "sub_total")
            Next
        End If
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        If GridView1.FocusedColumn.FieldName = "jumlah" Then
            Dim edit As TextEdit = CType(GridView1.ActiveEditor, TextEdit)

            If e.Value = "" Then
                txtTotal.EditValue = ""
                Exit Sub
            End If

            If e.Value <= 0 Then
                edit.ErrorText = "Jumlah harus > 0"
            Else
                edit.ErrorText = String.Empty
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "jumlah", e.Value)
                Dim hitung As Integer = (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "harga") * e.Value)
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "sub_total", hitung)
                GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatString = "n0"

            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        GridView1.DeleteRow(GridView1.FocusedRowHandle)
        txtTotal.EditValue = 0
        For i = 0 To GridView1.DataRowCount - 1
            txtTotal.EditValue += GridView1.GetRowCellValue(i, "sub_total")
        Next
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If purpose = "NEW" Then
            Dim _awal As New PersediaanAwal
            _awal.draft = draft
            _awal.kondisi = cbKondisi.EditValue
            _awal.lokasi = cbLokasi.EditValue
            _awal.tgl_persediaan_awal = dtTanggal.Text

        End If
    End Sub
End Class