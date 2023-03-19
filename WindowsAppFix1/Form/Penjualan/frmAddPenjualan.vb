Imports DevExpress.CodeParser
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI

Public Class frmAddPenjualan

    'Private _penjualanRepo As PenjualanRepository = New PenjualanRepository()
    Private _penjualanRepo As New PenjualanRepository
    Private _persediaanRepo As New PersediaanRepo
    Private _customerRepo As New CustomerRepository
    Private _pegawaiRepo As New PegawaiRepository
    Public dtPenjualan As New DataTable
    Private _update As Boolean = False
    Dim exp As DateTime
    Dim hitung, diskon, subtotal, totalbayar As Integer
    Dim ppn As Integer
    Dim draft, customer, pegawai As Integer
    Dim listcustomer As List(Of Customer)
    Public _repositoryPenjualan As PenjualanRepository = New PenjualanRepository()
    Dim rpt As New rptInvoicePenjualan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadData()
        tglPenjualan.EditValue = Date.Now

        Dim itemValues As Object() = New Object() {1, 2}
        Dim itemDescriptions As String() = New String() {"True", "False"}
        Dim i As Integer = 0
        Do While i < itemValues.Length
            rbgDraft.Properties.Items.Add(New RadioGroupItem(itemValues(i), itemDescriptions(i)))
            i += 1
        Loop
        'Select the Rectangle item.
        rbgDraft.EditValue = 1
    End Sub

    Public Async Sub LoadData()
        LoadDatatable()
        Dim _listcustomer = Await _customerRepo.GetList()
        Dim _listpegawai = Await _pegawaiRepo.GetList()
    End Sub


    Private Sub LoadDatatable()
        'initate Coloumn
        dtPenjualan.Columns.Add("persediaan_id", GetType(Long))
        dtPenjualan.Columns.Add("produk_nama", GetType(String))
        dtPenjualan.Columns.Add("batch", GetType(String))
        dtPenjualan.Columns.Add("expired", GetType(String))
        dtPenjualan.Columns.Add("serial_number", GetType(String))
        dtPenjualan.Columns.Add("satuan_jual", GetType(String))
        dtPenjualan.Columns.Add("harga", GetType(Integer))
        dtPenjualan.Columns.Add("diskon", GetType(Integer))
        dtPenjualan.Columns.Add("jumlah", GetType(Integer))
        dtPenjualan.Columns.Add("sub_total", GetType(Integer))
        GridControl1.DataSource = dtPenjualan
        GridControl1.RepositoryItems.Add(RepositoryItemDateEdit1)
        GridView1.Columns("expired").ColumnEdit = RepositoryItemDateEdit1


        GridView1.Columns.ColumnByFieldName("persediaan_id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("produk_nama").VisibleIndex = 0
        GridView1.Columns.ColumnByFieldName("produk_nama").Caption = "Nama Produk"
        GridView1.Columns.ColumnByFieldName("produk_nama").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("produk_nama").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns.ColumnByFieldName("produk_nama").OptionsColumn.AllowEdit = False
        GridView1.Columns.ColumnByFieldName("satuan_jual").VisibleIndex = 1
        GridView1.Columns.ColumnByFieldName("satuan_jual").Caption = "Satuan Jual"
        GridView1.Columns.ColumnByFieldName("satuan_jual").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("satuan_jual").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns.ColumnByFieldName("satuan_jual").OptionsColumn.AllowEdit = False
        GridView1.Columns.ColumnByFieldName("batch").VisibleIndex = 2
        GridView1.Columns.ColumnByFieldName("batch").Caption = "Batch"
        GridView1.Columns.ColumnByFieldName("batch").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("batch").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("expired").VisibleIndex = 3
        GridView1.Columns.ColumnByFieldName("expired").Caption = "Kadaluarsa"
        GridView1.Columns.ColumnByFieldName("expired").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("expired").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("serial_number").VisibleIndex = 4
        GridView1.Columns.ColumnByFieldName("serial_number").Caption = "Serial Number"
        GridView1.Columns.ColumnByFieldName("serial_number").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("serial_number").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("harga").VisibleIndex = 5
        GridView1.Columns.ColumnByFieldName("harga").Caption = "Harga"
        GridView1.Columns.ColumnByFieldName("harga").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("harga").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatString = "n0"
        GridView1.Columns.ColumnByFieldName("diskon").VisibleIndex = 6
        GridView1.Columns.ColumnByFieldName("diskon").Caption = "Diskon"
        GridView1.Columns.ColumnByFieldName("diskon").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("diskon").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns.ColumnByFieldName("jumlah").VisibleIndex = 7
        GridView1.Columns.ColumnByFieldName("jumlah").Caption = "Jumlah"
        GridView1.Columns.ColumnByFieldName("jumlah").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("jumlah").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        GridView1.Columns.ColumnByFieldName("sub_total").VisibleIndex = 8
        GridView1.Columns.ColumnByFieldName("sub_total").Caption = "Sub Total"
        GridView1.Columns.ColumnByFieldName("sub_total").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("sub_total").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns.ColumnByFieldName("sub_total").OptionsColumn.AllowEdit = False
        GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatString = "n0"


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
            row("persediaan_id") = persediaan.produk.id
            row("produk_nama") = persediaan.produk.nama
            row("satuan_jual") = persediaan.produk.satuan_jual
            row("batch") = persediaan.batch
            row("expired") = Format(Date.Now, "yyyy-MM-dd")
            row("serial_number") = persediaan.serial_number
            row("harga") = persediaan.produk.harga
            row("diskon") = 0
            row("jumlah") = 0
            row("sub_total") = 0

            dtPenjualan.Rows.Add(row)
            GridControl1.DataSource = dtPenjualan

            GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatString = "n0"

            GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatString = "n0"

        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Using frm As FrmFindPersediaan = New FrmFindPersediaan
            If frm.ShowDialog = DialogResult.OK Then
                SetRow(frm.GetValue)
                Console.WriteLine(frm.GetValue)
            End If
        End Using

    End Sub

    Public Sub Edit(id As Long)

    End Sub

    Private Sub txtCustomer_Click(sender As Object, e As EventArgs) Handles txtCustomer.Click
        Dim frm As New FrmFindCustomer
        Dim i : i = frm.ShowDialog()
        If CType(i, DialogResult) = 2 Then
            txtCustomer.EditValue = _Customer.nama
            txtSales.EditValue = _Customer.sales.nama
        End If
    End Sub

    Private Sub txtTempo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTempo.KeyPress
        If e.KeyChar = Chr(13) Then
            tglTempo.EditValue = DateAdd("d", (txtTempo.EditValue), tglPenjualan.EditValue)
            cbTipe.Select()
        End If
    End Sub

    Private Sub txtTempo_Leave(sender As Object, e As EventArgs) Handles txtTempo.Leave
        tglTempo.EditValue = DateAdd("d", (txtTempo.EditValue), tglPenjualan.EditValue)
        cbTipe.Select()
    End Sub

    Private Sub GridView1_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        If GridView1.FocusedColumn.FieldName = "serial_number" Then
            RepositoryItemDateEdit1.Mask.EditMask = "yyyy-MM-dd"
            RepositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = True

            exp = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "expired")
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "expired", Format(exp, "yyyy-MM-dd"))
        End If

        If GridView1.FocusedColumn.FieldName = "sub_total" Then
            ppn = 0
            totalbayar = 0
            For dgv = 0 To GridView1.DataRowCount - 1
                'ppn += (GridView1.GetRowCellValue(dgv, "sub_total") * 0.11)
                totalbayar += GridView1.GetRowCellValue(dgv, "sub_total")
            Next
            ppn = totalbayar * 0.11
        End If
        txtPpn.EditValue = ppn
        txtTotalBayar.EditValue = totalbayar + ppn
    End Sub

    Private Sub txtBiayaLain_TextChanged(sender As Object, e As EventArgs) Handles txtBiayaLain.TextChanged
        Dim newTotal = 0
        For dgv = 0 To GridView1.DataRowCount - 1
            newTotal += GridView1.GetRowCellValue(dgv, "sub_total")
        Next
        txtTotalBayar.EditValue = txtPpn.EditValue + newTotal + txtBiayaLain.EditValue
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        GridView1.DeleteRow(GridView1.FocusedRowHandle)

        Dim hapusPPN = 0
        Dim hapusTotal = 0
        txtPpn.EditValue = 0
        txtTotalBayar.EditValue = 0

        For dgv = 0 To GridView1.DataRowCount - 1
            'ppn += (GridView1.GetRowCellValue(dgv, "sub_total") * 0.11)
            hapusTotal += GridView1.GetRowCellValue(dgv, "sub_total")
        Next

        hapusPPN = hapusTotal * 0.11
        txtPpn.EditValue += hapusPPN
        txtTotalBayar.EditValue += hapusTotal + hapusPPN

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Store()
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        If GridView1.FocusedColumn.FieldName = "jumlah" Then
            Dim edit As TextEdit = CType(GridView1.ActiveEditor, TextEdit)

            If e.Value = "" Then
                txtTotalBayar.EditValue = ""
                edit.ErrorText = "Jumlah tidak boleh"
                Exit Sub
            End If

            If e.Value <= 0 Then
                edit.ErrorText = "Jumlah harus > 0"
            Else
                edit.ErrorText = String.Empty
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "jumlah", e.Value)
                subtotal = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "harga") * e.Value
                diskon = (subtotal * GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "diskon")) / 100
                hitung = subtotal - diskon
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "sub_total", hitung)
                GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatString = "n0"

            End If
        End If
    End Sub

    Private Sub refreshPenjualanList()
        'form jabatan list reload
        Dim form As FormPenjualanList = CType(Application.OpenForms("FormPenjualanList"), FormPenjualanList)
        form.LoadData()
    End Sub

    Public Async Sub LoadDataByID()
        'dataObject
        totalbayar = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "total_bayar")
        Dim listview1 = Await _repositoryPenjualan.Edit(printID)
        rpt.DataSource = listview1
        rpt.CreateDocument()
    End Sub

    'Private Sub txtBiayaLain_Leave(sender As Object, e As EventArgs) Handles txtBiayaLain.Leave
    '    For i = 0 To GridView1.DataRowCount - 1
    '        subtotal += GridView1.GetRowCellValue(i, "sub_total")
    '        txtTotalBayar.EditValue = txtPpn.EditValue + txtBiayaLain.EditValue + subtotal
    '    Next
    'End Sub
    Private Async Sub store()
        Dim _penjualan As New Penjualan
        Dim hasil As Boolean = False
        _penjualan.penjualan_penawaran_id = txtPOPenjualan.EditValue
        _penjualan.tgl_penjualan = tglPenjualan.Text
        _penjualan.tempo = CType(txtTempo.EditValue, Int64)
        _penjualan.tgl_tempo = tglTempo.Text
        _penjualan.tipe_penjualan = cbTipe.EditValue
        _penjualan.draft = draft
        _penjualan.customer_id = _Customer.id
        _penjualan.sales_id = _Customer.sales_id
        _penjualan.keterangan = txtKeterangan.EditValue
        _penjualan.total_bayar = txtTotalBayar.EditValue
        _penjualan.ppn = txtPpn.EditValue
        _penjualan.biaya_lain = txtBiayaLain.EditValue

        'list detail
        Dim penjualan_list As New List(Of PenjualanDetailStore)
        For i As Integer = 0 To GridView1.RowCount - 1
            _penjualan.total_barang += GridView1.GetRowCellValue(i, "jumlah")
            Dim detail As New PenjualanDetailStore
            Dim expired = GridView1.GetRowCellValue(i, "expired")
            detail.persediaan_id = GridView1.GetRowCellValue(i, "persediaan_id")
            detail.diskon = GridView1.GetRowCellValue(i, "diskon")
            detail.jumlah = GridView1.GetRowCellValue(i, "jumlah")
            detail.batch = GridView1.GetRowCellValue(i, "batch")
            detail.expired = If(expired Is DBNull.Value, String.Empty, CStr(expired))
            detail.batch = GridView1.GetRowCellValue(i, "batch")
            detail.serial_number = GridView1.GetRowCellValue(i, "serial_number")
            detail.satuan_jual = GridView1.GetRowCellValue(i, "satuan_jual")
            detail.harga_jual = GridView1.GetRowCellValue(i, "harga")
            detail.sub_total = GridView1.GetRowCellValue(i, "sub_total")
            penjualan_list.Add(detail)
        Next
        _penjualan.penjualan_detail_store = penjualan_list
        'Dim json = JsonConvert.SerializeObject(_penjualan)
        hasil = Await _penjualanRepo.store(_penjualan)
        If hasil Then
            DialogResult = DialogResult.OK
            purpose = Nothing
            Close()
            LoadDataByID()
            Dim printTool As New ReportPrintTool(rpt)
            printTool.ShowPreview()
            refreshPenjualanList()
        End If
    End Sub
End Class