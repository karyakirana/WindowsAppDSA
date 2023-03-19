Imports System.ComponentModel
Imports System.Net
Imports DevExpress.Data
Imports DevExpress.Data.ChartDataSources
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
    Private _produkRepo As New ProdukRepository
    Private _persediaanAwalRepo As New PersediaanAwalRepo
    Private _update As Boolean = False
    Public dtProduk As New DataTable
    Dim exp As DateTime
    Dim draft, awal_id As Integer
    Public listlokasi As New List(Of Lokasi)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadDatatable()

    End Sub

    Public Async Sub LoadData()
        listlokasi = Await _lokasiRepository.GetList()
        cbLokasi.Properties.DataSource = listlokasi
        If purpose = "EDIT" Then
            _update = True
        End If
        'txtTotal.EditValue = 0
    End Sub

    Private Sub LoadDatatable()
        'initiate column
        dtProduk.Columns.Add("persediaan_id", GetType(String))
        dtProduk.Columns.Add("produk_id", GetType(Integer))
        dtProduk.Columns.Add("produk_nama", GetType(String))
        dtProduk.Columns.Add("batch", GetType(String))
        dtProduk.Columns.Add("expired", GetType(String))
        dtProduk.Columns.Add("serial_number", GetType(String))
        dtProduk.Columns.Add("harga", GetType(Integer))
        dtProduk.Columns.Add("jumlah", GetType(Integer))
        dtProduk.Columns.Add("sub_total", GetType(Integer))
        GridControl1.DataSource = dtProduk

        GridView1.Columns.ColumnByFieldName("persediaan_id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("produk_id").VisibleIndex = -1
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
        GridView1.Columns.ColumnByFieldName("jumlah").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
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
        Dim getData As Produk = Await _produkRepo.Edit(id)
        'set to row
        If Not getData Is Nothing Then

            Dim produk As New Produk
            produk = getData

            Dim row As DataRow
            row = dtProduk.NewRow()
            row("persediaan_id") = 0
            row("produk_id") = produk.id
            row("produk_nama") = produk.nama
            row("batch") = ""
            row("expired") = Format(Date.Now, "yyyy-MM-dd")
            row("serial_number") = ""
            row("harga") = produk.harga
            row("jumlah") = 0
            row("sub_total") = 0 

            dtProduk.Rows.Add(row)
            GridControl1.DataSource = dtProduk

            GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatString = "n0"

            GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatString = "n0"
            'Console.WriteLine(getData)
        End If
    End Sub

    Public Async Sub Edit(id As Long)
        'load data
        Dim total As Integer = 0
        Dim persediaan_awal As PersediaanAwal = Await _persediaanAwalRepo.Edit(id)

        'set form
        cbKondisi.EditValue = persediaan_awal.kondisi

        For lok = 0 To listlokasi.Count - 1
            If listlokasi(lok).id = persediaan_awal.lokasi_id Then
                cbLokasi.EditValue = listlokasi(lok).id
            End If
        Next

        dtTanggal.EditValue = persediaan_awal.tgl_persediaan_awal
        If persediaan_awal.draft = 0 Then
            cbDraft.EditValue = "False"
        Else
            cbDraft.EditValue = "True"
        End If
        txtKeterangan.EditValue = persediaan_awal.keterangan


        'set detail
        For i = 0 To persediaan_awal.persediaan_awal_detail.Count - 1
            awal_id = persediaan_awal.persediaan_awal_detail(i).persediaan_awal_id
            Dim dr = dtProduk.NewRow
            dr("persediaan_id") = persediaan_awal.persediaan_awal_detail(i).persediaan_id
            dr("produk_id") = persediaan_awal.persediaan_awal_detail(i).persediaan.produk.id
            dr("produk_nama") = persediaan_awal.persediaan_awal_detail(i).persediaan.produk.nama
            dr("batch") = persediaan_awal.persediaan_awal_detail(i).persediaan.batch
            dr("expired") = persediaan_awal.persediaan_awal_detail(i).persediaan.expired
            dr("serial_number") = persediaan_awal.persediaan_awal_detail(i).persediaan.serial_number
            dr("harga") = persediaan_awal.persediaan_awal_detail(i).harga_beli
            dr("jumlah") = persediaan_awal.persediaan_awal_detail(i).jumlah
            dr("sub_total") = persediaan_awal.persediaan_awal_detail(i).sub_total
            total += persediaan_awal.persediaan_awal_detail(i).sub_total
            dtProduk.Rows.Add(dr)
        Next
        GridControl1.DataSource = dtProduk
        txtTotal.EditValue = total
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
        refreshPersediaanAwalList()
    End Sub

    Private Sub GridControl1_KeyUp(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyUp

        Dim edit As TextEdit = CType(GridView1.ActiveEditor, TextEdit)
        Dim colHarga = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "harga")
        Dim colJumlah = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "jumlah")
        Dim hitung
        ' handle jika yang ditekan bukan angka
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            hitung = colHarga * colJumlah
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "sub_total", hitung)
            If GridView1.FocusedColumn.FieldName = "sub_total" Then
                txtTotal.EditValue = 0
                For i = 0 To GridView1.DataRowCount - 1
                    txtTotal.EditValue += GridView1.GetRowCellValue(i, "sub_total")
                Next
            End If
        End If

        'End If
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

            'exp = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "expired")
            Dim expired = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "expired")
            exp = IIf(expired Is DBNull.Value, String.Empty, CStr(expired))
            If expired Is DBNull.Value Then
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "expired", "")
            Else
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "expired", Format(exp, "yyyy-MM-dd"))
            End If
        End If

        'If GridView1.FocusedColumn.FieldName = "sub_total" Then
        '    txtTotal.EditValue = 0
        '    For i = 0 To GridView1.DataRowCount - 1
        '        txtTotal.EditValue += GridView1.GetRowCellValue(i, "sub_total")
        '    Next
        'End If
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        'If GridView1.FocusedColumn.FieldName = "jumlah" Then

        'End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        GridView1.DeleteRow(GridView1.FocusedRowHandle)
        txtTotal.EditValue = 0
        For i = 0 To GridView1.DataRowCount - 1
            txtTotal.EditValue += GridView1.GetRowCellValue(i, "sub_total")
        Next
    End Sub

    Private Sub refreshPersediaanAwalList()
        'form jabatan list reload
        Dim form As FormPersediaanAwalList = CType(Application.OpenForms("FormPersediaanAwalList"), FormPersediaanAwalList)
        form.LoadData()
    End Sub

    Private Async Sub store()
        Dim _awal As New PersediaanAwal
        _awal.draft = draft
        _awal.kondisi = cbKondisi.EditValue
        _awal.lokasi_id = CType(cbLokasi.EditValue, Int64)
        _awal.tgl_persediaan_awal = dtTanggal.Text
        _awal.total_nominal = txtTotal.EditValue
        _awal.keterangan = txtKeterangan.EditValue

        'list detail
        Dim persediaan_awal_list As New List(Of PersediaanAwalDetailStore)
        For i As Integer = 0 To GridView1.RowCount - 1
            _awal.total_barang += GridView1.GetRowCellValue(i, "jumlah")
            Dim detail As New PersediaanAwalDetailStore
            Dim expired = GridView1.GetRowCellValue(i, "expired")
            detail.produk_id = GridView1.GetRowCellValue(i, "produk_id")
            detail.jumlah = GridView1.GetRowCellValue(i, "jumlah")
            detail.batch = GridView1.GetRowCellValue(i, "batch")
            detail.expired = If(expired Is DBNull.Value, String.Empty, CStr(expired))
            detail.batch = GridView1.GetRowCellValue(i, "batch")
            detail.serial_number = GridView1.GetRowCellValue(i, "serial_number")
            detail.harga = GridView1.GetRowCellValue(i, "harga")
            detail.sub_total = GridView1.GetRowCellValue(i, "sub_total")
            persediaan_awal_list.Add(detail)
        Next

        _awal.persediaan_awal_detail_store = persediaan_awal_list

        Dim hasil = Await _persediaanAwalRepo.Store(_awal)
        If hasil Then
            DialogResult = DialogResult.OK
            purpose = Nothing
            Close()
            refreshPersediaanAwalList()
        End If
    End Sub

    Public Async Sub put()
        Dim _awal As New PersediaanAwal
        _awal.persediaan_awal_id = awal_id
        _awal.draft = draft
        _awal.kondisi = cbKondisi.EditValue
        _awal.lokasi_id = CType(cbLokasi.EditValue, Int64)
        _awal.tgl_persediaan_awal = dtTanggal.Text
        _awal.total_nominal = txtTotal.EditValue
        _awal.keterangan = txtKeterangan.EditValue

        'list detail
        Dim persediaan_awal_list As New List(Of PersediaanAwalDetailStore)
        For i As Integer = 0 To GridView1.RowCount - 1
            _awal.total_barang += GridView1.GetRowCellValue(i, "jumlah")
            Dim detail As New PersediaanAwalDetailStore
            Dim expired = GridView1.GetRowCellValue(i, "expired")
            detail.produk_id = GridView1.GetRowCellValue(i, "produk_id")
            detail.jumlah = GridView1.GetRowCellValue(i, "jumlah")
            detail.batch = GridView1.GetRowCellValue(i, "batch")
            detail.expired = If(expired Is DBNull.Value, String.Empty, CStr(expired))
            detail.batch = GridView1.GetRowCellValue(i, "batch")
            detail.serial_number = GridView1.GetRowCellValue(i, "serial_number")
            detail.harga = GridView1.GetRowCellValue(i, "harga")
            detail.sub_total = GridView1.GetRowCellValue(i, "sub_total")
            persediaan_awal_list.Add(detail)
        Next

        _awal.persediaan_awal_detail_store = persediaan_awal_list

        Dim hasil = Await _persediaanAwalRepo.Update(_awal)
        If hasil Then
            DialogResult = DialogResult.OK
            purpose = Nothing
            Close()
            refreshPersediaanAwalList()
        End If
    End Sub

    Private Async Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If _update Then
            put()
        Else
            store()
        End If
    End Sub
End Class