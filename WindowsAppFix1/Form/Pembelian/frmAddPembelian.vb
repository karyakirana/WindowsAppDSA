Imports DevExpress.CodeParser
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting.Export.Pdf
Imports Newtonsoft.Json

Public Class frmAddPembelian

    Private _pembelianRepo As PembelianRepository
    Private _supplierRepo As New SupplierRepository
    Private _persediaanRepo As New PersediaanRepo
    Private _produkRepo As New ProdukRepository
    Private _update As Boolean = False
    Public dtPembelian As New DataTable
    Dim exp As DateTime
    Dim hitung, diskon, subtotal, totalbayar As Integer
    Dim ppn As Integer
    Dim draft, supplier As Integer
    Dim listsupplier As List(Of Supplier)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadData()
        tglPembelian.EditValue = Date.Now

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
        LoadDataTable()
        listsupplier = Await _supplierRepo.GetList()
    End Sub

    Private Sub LoadDataTable()
        'initate Coloumn
        dtPembelian.Columns.Add("pembelian_id", GetType(Long))
        dtPembelian.Columns.Add("produk_id", GetType(String))
        dtPembelian.Columns.Add("produk_nama", GetType(String))
        dtPembelian.Columns.Add("batch", GetType(String))
        dtPembelian.Columns.Add("expired", GetType(String))
        dtPembelian.Columns.Add("serial_number", GetType(String))
        dtPembelian.Columns.Add("harga", GetType(Integer))
        dtPembelian.Columns.Add("diskon", GetType(Integer))
        dtPembelian.Columns.Add("jumlah", GetType(Integer))
        dtPembelian.Columns.Add("sub_total", GetType(Integer))
        GridControl1.DataSource = dtPembelian
        GridControl1.RepositoryItems.Add(RepositoryItemDateEdit1)
        GridView1.Columns("expired").ColumnEdit = RepositoryItemDateEdit1

        GridView1.Columns.ColumnByFieldName("pembelian_id").VisibleIndex = -1
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
        GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatString = "n0"
        GridView1.Columns.ColumnByFieldName("diskon").VisibleIndex = 5
        GridView1.Columns.ColumnByFieldName("diskon").Caption = "Diskon (%)"
        GridView1.Columns.ColumnByFieldName("diskon").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("diskon").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns.ColumnByFieldName("diskon").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns.ColumnByFieldName("diskon").DisplayFormat.FormatString = "n0"
        GridView1.Columns.ColumnByFieldName("jumlah").VisibleIndex = 6
        GridView1.Columns.ColumnByFieldName("jumlah").Caption = "Jumlah"
        GridView1.Columns.ColumnByFieldName("jumlah").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("jumlah").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns.ColumnByFieldName("sub_total").VisibleIndex = 7
        GridView1.Columns.ColumnByFieldName("sub_total").Caption = "Sub Total"
        GridView1.Columns.ColumnByFieldName("sub_total").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("sub_total").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatString = "n0"
        GridView1.Columns.ColumnByFieldName("sub_total").OptionsColumn.AllowEdit = False
    End Sub

    Public Async Sub SetRow(id As Long)
        'get data
        Dim getData As Produk = Await _produkRepo.Edit(id)
        'set to row
        If Not getData Is Nothing Then

            Dim produk As New Produk
            produk = getData

            Dim row As DataRow
            row = dtPembelian.NewRow()
            row("pembelian_id") = 0
            row("produk_id") = produk.id
            row("produk_nama") = produk.nama
            row("batch") = ""
            row("expired") = Format(Date.Now, "yyyy-MM-dd")
            row("serial_number") = ""
            row("harga") = produk.harga
            row("diskon") = 0
            row("jumlah") = 0
            row("sub_total") = 0

            dtPembelian.Rows.Add(row)
            GridControl1.DataSource = dtPembelian

            GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns.ColumnByFieldName("harga").DisplayFormat.FormatString = "n0"

            GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns.ColumnByFieldName("sub_total").DisplayFormat.FormatString = "n0"
            'Console.WriteLine(getData)
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Using frm As FrmFindProduk = New FrmFindProduk()
            If frm.ShowDialog = DialogResult.OK Then
                SetRow(frm.GetValue)
                Console.WriteLine(frm.GetValue)
            End If
        End Using

    End Sub

    Public Sub Edit(id As Long)

    End Sub

    Private Sub txtSupplier_Click(sender As Object, e As EventArgs) Handles txtSupplier.Click
        Dim frm As New FrmFindSupplier
        Dim i : i = frm.ShowDialog()
        If CType(i, DialogResult) = 2 Then
            txtSupplier.EditValue = _Supplier.nama
        End If
    End Sub

    Private Sub txtTempo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTempo.KeyPress
        If e.KeyChar = Chr(13) Then
            tglTempo.EditValue = DateAdd("d", (txtTempo.EditValue), tglPembelian.EditValue)
            cbTipe.Select()
        End If
    End Sub

    Private Sub txtTempo_Leave(sender As Object, e As EventArgs) Handles txtTempo.Leave
        tglTempo.EditValue = DateAdd("d", (txtTempo.EditValue), tglPembelian.EditValue)
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
        txtTotalbayar.EditValue = totalbayar + ppn
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        GridView1.DeleteRow(GridView1.FocusedRowHandle)

        Dim hapusPPN = 0
        Dim hapusTotal = 0
        txtPpn.EditValue = 0
        txtTotalbayar.EditValue = 0

        For dgv = 0 To GridView1.DataRowCount - 1
            'ppn += (GridView1.GetRowCellValue(dgv, "sub_total") * 0.11)
            hapusTotal += GridView1.GetRowCellValue(dgv, "sub_total")
        Next

        hapusPPN = hapusTotal * 0.11
        txtPpn.EditValue += hapusPPN
        txtTotalbayar.EditValue += hapusTotal + hapusPPN

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        store()
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        If GridView1.FocusedColumn.FieldName = "jumlah" Then
            Dim edit As TextEdit = CType(GridView1.ActiveEditor, TextEdit)

            If e.Value = "" Then
                txtTotalbayar.EditValue = ""
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

    'Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
    '    If GridView1.FocusedColumn.FieldName = "sub_total" Then
    '        If e.KeyCode = Keys.Enter Then

    '        End If
    '    End If
    'End Sub

    Private Sub txtBiayaLain_Leave(sender As Object, e As EventArgs) Handles txtBiayalain.Leave

    End Sub

    Private Sub refreshPembelianList()
        'form jabatan list reload
        Dim form As FormPembelianList = CType(Application.OpenForms("FormPembelianList"), FormPembelianList)
        form.LoadData()
    End Sub

    Private Async Sub store()
        Dim _pembelian As New Pembelian
        _pembelian.pembelian_po_id = txtPOPembelian.EditValue
        _pembelian.tgl_pembelian = tglPembelian.Text
        _pembelian.tempo = CType(txtTempo.EditValue, Int64)
        _pembelian.tgl_tempo = tglTempo.Text
        _pembelian.tipe_pembelian = cbTipe.EditValue
        _pembelian.draft = draft
        _pembelian.supplier_id = _Supplier.id
        _pembelian.keterangan = txtKeterangan.EditValue
        _pembelian.total_bayar = txtTotalbayar.EditValue
        _pembelian.ppn = txtPpn.EditValue
        _pembelian.biaya_lain = txtBiayalain.EditValue

        'list detail
        Dim pembelian_list As New List(Of PembelianDetailStore)
        For i As Integer = 0 To GridView1.RowCount - 1
            _pembelian.total_barang += GridView1.GetRowCellValue(i, "jumlah")
            Dim detail As New PembelianDetailStore
            Dim expired = GridView1.GetRowCellValue(i, "expired")
            detail.produk_id = GridView1.GetRowCellValue(i, "produk_id")
            detail.diskon = GridView1.GetRowCellValue(i, "diskon")
            detail.jumlah = GridView1.GetRowCellValue(i, "jumlah")
            detail.batch = GridView1.GetRowCellValue(i, "batch")
            detail.expired = If(expired Is DBNull.Value, String.Empty, CStr(expired))
            detail.batch = GridView1.GetRowCellValue(i, "batch")
            detail.serial_number = GridView1.GetRowCellValue(i, "serial_number")
            detail.harga = GridView1.GetRowCellValue(i, "harga")
            detail.sub_total = GridView1.GetRowCellValue(i, "sub_total")
            pembelian_list.Add(detail)
        Next
        _pembelian.pembelian_detail_store = pembelian_list
        Dim json = JsonConvert.SerializeObject(_pembelian)
        Dim hasil = Await _pembelianRepo.store(_pembelian)
        If hasil Then
            DialogResult = DialogResult.OK
            purpose = Nothing
            Close()
            refreshPembelianList()
        End If
    End Sub

    Private Sub txtBiayalain_TextChanged(sender As Object, e As EventArgs) Handles txtBiayalain.TextChanged
        Dim newTotal = 0
        For dgv = 0 To GridView1.DataRowCount - 1
            newTotal += GridView1.GetRowCellValue(dgv, "sub_total")
        Next
        txtTotalbayar.EditValue = txtPpn.EditValue + newTotal + txtBiayalain.EditValue
    End Sub


    'Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
    '    Using frm As FrmFindProduk = New FrmFindProduk
    '        If frm.ShowDialog = DialogResult.OK Then
    '            SetRow(frm.GetValue)
    '            Console.WriteLine(frm.GetValue)
    '        End If
    '    End Using
    'End Sub

    'Dim sumJumlah As New GridColumnSummaryItem()
    'Dim sumSubTotal As New GridColumnSummaryItem()
    'Dim exp As DateTime
    'Dim subTotal As Integer

    'Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
    '    clearDtPembelian()
    '    setColumnDTPembelian()
    '    getPembelian()
    '    GridControl1.DataSource = Nothing
    '    GridControl1.DataSource = dtPembelian
    '    Me.Close()
    'End Sub

    'Private Sub txtSupplier_Click(sender As Object, e As EventArgs) Handles txtSupplier.Click
    '    Dim frm As New FrmFindSupplier
    '    Dim i : i = frm.ShowDialog()
    '    If CType(i, DialogResult) = 2 Then
    '        Me.txtSupplier.EditValue = nama
    '    End If
    'End Sub

    'Private Sub txtTempo_LostFocus(sender As Object, e As EventArgs) Handles txtTempo.LostFocus

    'End Sub

    'Private Sub txtTempo_Leave(sender As Object, e As EventArgs) Handles txtTempo.Leave
    '    If txtTempo.EditValue = 0 Then
    '        MsgBox("Tempo harus lebih dari 0!", MsgBoxStyle.Exclamation, "Informasi")
    '    Else
    '        tglTempo.EditValue = Format(DateAdd("d", txtTempo.EditValue, Date.Now), "dd-MM-yyyy")
    '        cbTipe.Select()
    '    End If
    'End Sub

    'Private Sub setGridviewColumn()
    '    GridView1.Columns.ColumnByFieldName("id").VisibleIndex = -1
    '    GridView1.Columns.ColumnByFieldName("nama").VisibleIndex = 0
    '    GridView1.Columns.ColumnByFieldName("nama").Caption = "Nama Produk"
    '    'GridView1.Columns.ColumnByFieldName("nama").Width = 75
    '    GridView1.Columns.ColumnByFieldName("nama").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    '    GridView1.Columns.ColumnByFieldName("nama").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

    '    GridView1.Columns.ColumnByFieldName("harga").VisibleIndex = 1
    '    GridView1.Columns.ColumnByFieldName("harga").Caption = "Harga"
    '    'GridView1.Columns.ColumnByFieldName("harga").Width = 75
    '    GridView1.Columns.ColumnByFieldName("harga").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    '    GridView1.Columns.ColumnByFieldName("harga").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

    '    GridView1.Columns.ColumnByFieldName("jumlah").VisibleIndex = 2
    '    GridView1.Columns.ColumnByFieldName("jumlah").Caption = "Jumlah"
    '    'GridView1.Columns.ColumnByFieldName("jumlah").Width = 75
    '    GridView1.Columns.ColumnByFieldName("jumlah").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    '    GridView1.Columns.ColumnByFieldName("jumlah").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

    '    GridView1.Columns.ColumnByFieldName("exp").VisibleIndex = 3
    '    GridView1.Columns.ColumnByFieldName("exp").Caption = "Kadaluarsa"
    '    'GridView1.Columns.ColumnByFieldName("exp").Width = 75
    '    GridView1.Columns.ColumnByFieldName("exp").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    '    GridView1.Columns.ColumnByFieldName("exp").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    '    GridView1.Columns.ColumnByFieldName("batch").VisibleIndex = 4
    '    GridView1.Columns.ColumnByFieldName("batch").Caption = "Batch"
    '    'GridView1.Columns.ColumnByFieldName("batch").Width = 75
    '    GridView1.Columns.ColumnByFieldName("batch").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    '    GridView1.Columns.ColumnByFieldName("batch").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

    '    GridView1.Columns.ColumnByFieldName("diskon").VisibleIndex = 5
    '    GridView1.Columns.ColumnByFieldName("diskon").Caption = "Diskon (%)"
    '    'GridView1.Columns.ColumnByFieldName("batch").Width = 75
    '    GridView1.Columns.ColumnByFieldName("diskon").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    '    GridView1.Columns.ColumnByFieldName("diskon").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

    '    GridView1.Columns.ColumnByFieldName("sub_total").VisibleIndex = 6
    '    GridView1.Columns.ColumnByFieldName("sub_total").Caption = "Sub Total"
    '    'GridView1.Columns.ColumnByFieldName("sub_total").Width = 75
    '    GridView1.Columns.ColumnByFieldName("sub_total").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    '    GridView1.Columns.ColumnByFieldName("sub_total").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

    '    GridControl1.RepositoryItems.Add(RepositoryItemDateEdit1)
    '    GridView1.Columns("exp").ColumnEdit = RepositoryItemDateEdit1

    '    GridView1.Columns("jumlah").Summary.Add(sumJumlah)
    '    GridView1.Columns("sub_total").Summary.Add(sumSubTotal)
    'End Sub

    'Private Sub frmAddPembelian_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Dim itemValues As Object() = New Object() {1, 2}
    '    Dim itemDescriptions As String() = New String() {"True", "False"}
    '    Dim i As Integer = 0
    '    Do While i < itemValues.Length
    '        rbgDraft.Properties.Items.Add(New RadioGroupItem(itemValues(i), itemDescriptions(i)))
    '        i += 1
    '    Loop
    '    'Select the Rectangle item.
    '    rbgDraft.EditValue = 1

    '    tglPembelian.EditValue = Date.Now

    '    'clearDTPerhitunganPembelian()
    '    'setColumnDTPerhitunganPembelian()
    '    GridControl1.DataSource = dtPerhitunganPembelian
    '    setGridviewColumn()

    '    GridView1.Columns.ColumnByFieldName("nama").OptionsColumn.AllowEdit = False
    '    GridView1.Columns.ColumnByFieldName("sub_total").OptionsColumn.AllowEdit = False


    '    If purpose = "New" Then
    '        btnSimpan.Text = "Simpan"
    '    Else
    '        For i = 0 To dtPembelian.Rows.Count - 1
    '            If pembelian_id = dtPembelian.Rows(i)("id") Then
    '                txtPOPembelian.EditValue = dtPembelian.Rows(i)("pembelian_po_id")
    '                tglPembelian.EditValue = dtPembelian.Rows(i)("tgl_pembelian")
    '                txtTempo.EditValue = dtPembelian.Rows(i)("tempo")
    '                tglTempo.EditValue = dtPembelian.Rows(i)("tgl_tempo")
    '                cbTipe.EditValue = dtPembelian.Rows(i)("tipe_pembelian").ToString
    '                If dtPembelian.Rows(i)("draft").ToString = "True" Then
    '                    rbgDraft.EditValue = 1
    '                Else
    '                    rbgDraft.EditValue = 2
    '                End If
    '                txtSupplier.EditValue = dtPembelian.Rows(i)("supplier_nama").ToString
    '                txtKeterangan.EditValue = dtPembelian.Rows(i)("keterangan").ToString
    '                txtPpn.EditValue = dtPembelian.Rows(i)("ppn")
    '                txtBiayalain.EditValue = dtPembelian.Rows(i)("biaya_lain")
    '                txtTotalbayar.EditValue = dtPembelian.Rows(i)("total_bayar")
    '                id_supplier = dtPembelian.Rows(i)("supplier_id")
    '            End If
    '        Next
    '        btnSimpan.Text = "Update"
    '        sumJumlah.SummaryType = SummaryItemType.Sum
    '        sumJumlah.FieldName = "jumlah"
    '        sumJumlah.DisplayFormat = "{0:#.#}"


    '        sumSubTotal.SummaryType = SummaryItemType.Sum
    '        sumSubTotal.FieldName = "sub_total"
    '        sumSubTotal.DisplayFormat = "{0:#.#}"
    '    End If
    'End Sub

    'Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

    '    Dim frm As New FrmFindProduk
    '    Dim i : i = frm.ShowDialog()
    '    If CType(i, DialogResult) = 2 Then

    '        If id_produk <> 0 Then
    '            Dim dr As DataRow
    '            dr = dtPerhitunganPembelian.NewRow
    '            dr("id") = id_produk
    '            dr("nama") = nama_produk
    '            dr("harga") = harga_produk
    '            dr("jumlah") = 0
    '            dr("exp") = Format(Date.Now, "yyyy-MM-dd")
    '            dr("batch") = ""
    '            dr("diskon") = 0
    '            dr("sub_total") = 0
    '            dtPerhitunganPembelian.Rows.Add(dr)

    '            Dim row = -1
    '            GridControl1.DataSource = dtPerhitunganPembelian
    '            GridView1.FocusedColumn = GridView1.Columns.ColumnByFieldName("jumlah")
    '            GridView1.FocusedRowHandle = row + 1
    '            GridView1.Focus()
    '        End If

    '    End If

    '    For i = 0 To dtPerhitunganPembelian.Rows.Count - 1
    '        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id") = id_produk Then
    '            dtPerhitunganPembelian.Rows(i)("batch") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "batch").ToString
    '            dtPerhitunganPembelian.Rows(i)("jumlah") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "jumlah").ToString
    '            dtPerhitunganPembelian.Rows(i)("sub_total") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sub_total").ToString
    '        End If
    '    Next
    'End Sub

    'Private Sub GridView1_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
    '    If GridView1.FocusedColumn.FieldName = "sub_total" Then
    '        Dim totalDiskon As Integer = (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "harga") * GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "jumlah") * GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "diskon")) / 100
    '        Dim hitung As Integer = (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "harga") * GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "jumlah")) - totalDiskon
    '        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "sub_total", hitung)

    '        sumJumlah.SummaryType = SummaryItemType.Sum
    '        sumJumlah.FieldName = "jumlah"
    '        sumJumlah.DisplayFormat = "{0:#.#}"


    '        sumSubTotal.SummaryType = SummaryItemType.Sum
    '        sumSubTotal.FieldName = "sub_total"
    '        sumSubTotal.DisplayFormat = "{0:#.#}"
    '    End If

    '    If GridView1.FocusedColumn.FieldName = "batch" Then
    '        RepositoryItemDateEdit1.Mask.EditMask = "yyyy-MM-dd"
    '        RepositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = True


    '        exp = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "exp")


    '    End If
    'End Sub

    'Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
    '    GridView1.DeleteRow(GridView1.FocusedRowHandle)
    'End Sub

    'Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

    '    'Dim _pembelian As PembelianModel = New PembelianModel
    '    '_pembelian.draft = draf
    '    '_pembelian.tipe_pembelian = cbTipe.EditValue
    '    '_pembelian.tgl_pembelian = Format(tglPembelian.EditValue, "yyyy-MM-dd")
    '    '_pembelian.tempo = txtTempo.EditValue
    '    '_pembelian.tgl_tempo = Format(DateAdd("d", txtTempo.EditValue, Date.Now), "yyyy-MM-dd")
    '    '_pembelian.supplier_id = id_supplier
    '    '_pembelian.total_barang = GridView1.Columns("jumlah").SummaryItem.SummaryValue
    '    '_pembelian.ppn = CInt(txtPpn.EditValue)
    '    '_pembelian.biaya_lain = CInt(txtBiayalain.EditValue)
    '    '_pembelian.total_bayar = CInt(txtTotalbayar.EditValue)
    '    '_pembelian.keterangan = txtKeterangan.EditValue

    '    '_pembelian.data_detail = New List(Of PembelianDetail)
    '    'For row As Integer = 0 To GridView1.DataRowCount - 1
    '    '    Dim _detail As New PembelianDetail With {
    '    '        .produk_id = CInt(GridView1.GetRowCellValue(row, "id")),
    '    '        .batch = CStr(GridView1.GetRowCellValue(row, "batch")),
    '    '        .expired = CStr(GridView1.GetRowCellValue(row, "exp")),
    '    '        .harga_beli = CInt(GridView1.GetRowCellValue(row, "harga")),
    '    '        .jumlah = CInt(GridView1.GetRowCellValue(row, "jumlah")),
    '    '        .sub_total = CInt(GridView1.GetRowCellValue(row, "sub_total"))
    '    '    }
    '    '    _pembelian.data_detail.Add(_detail)
    '    'Next

    '    'Dim jsonString As String = JsonConvert.SerializeObject(_pembelian)

    '    ''store
    '    'Dim jObject = _pembelian.store(jsonString)

    '    'If statusInsert = True Then
    '    '    If statusInsert = True Then
    '    '        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
    '    '        clearDataPembelian()
    '    '        SetColumnPembelian()
    '    '        getDataPembelian()

    '    '        Dim _frm = New frmPembelian

    '    '        _frm.GridControl1.DataSource = datatablePembelian
    '    '        Me.Close()
    '    '    Else
    '    '        MsgBox("Terjadi kesalahan proses simpan data!", MsgBoxStyle.Critical, "Perhatian")
    '    '        Exit Sub
    '    '    End If
    '    'End If

    '    If btnSimpan.Text = "New" Then
    '        If insertPembelian(GridView1, txtPOPembelian.EditValue, draf, cbTipe.EditValue, Format(tglPembelian.EditValue, "yyyy-MM-dd"), txtTempo.EditValue, Format(DateAdd("d", txtTempo.EditValue, Date.Now), "yyyy-MM-dd"),
    '                      id_supplier, 1, GridView1.Columns("jumlah").SummaryItem.SummaryValue, txtPpn.EditValue, txtBiayalain.EditValue, txtTotalbayar.EditValue,
    '                      txtKeterangan.EditValue, exp.ToString("yyyy-MM-dd")) = True Then


    '            MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
    '            Me.Close()
    '            clearDtPembelian()
    '            setColumnDTPembelian()
    '            getPembelian()
    '            Dim frm As New frmPembelian
    '            frm.GridControl1.DataSource = Nothing
    '            frm.GridControl1.DataSource = dtPembelian
    '        Else
    '            MsgBox("Terjadi kesalahan proses simpan data!", MsgBoxStyle.Critical, "Perhatian")
    '            Exit Sub
    '        End If
    '    Else
    '        If updatePembelian(GridView1, pembelian_id, txtPOPembelian.EditValue, draf, cbTipe.EditValue, Format(tglPembelian.EditValue, "yyyy-MM-dd"), txtTempo.EditValue, Format(DateAdd("d", txtTempo.EditValue, Date.Now), "yyyy-MM-dd"),
    '                      id_supplier, 1, GridView1.Columns("jumlah").SummaryItem.SummaryValue, txtPpn.EditValue, txtBiayalain.EditValue, txtTotalbayar.EditValue,
    '                      txtKeterangan.EditValue, exp.ToString("yyyy-MM-dd")) = True Then


    '            MsgBox("Data berhasil diUpdate!", MsgBoxStyle.Information, "Informasi")
    '            Me.Close()
    '            clearDtPembelian()
    '            setColumnDTPembelian()
    '            getPembelian()
    '            Dim frm As New frmPembelian
    '            frm.GridControl1.DataSource = Nothing
    '            frm.GridControl1.RefreshDataSource()
    '            frm.GridControl1.DataSource = dtPembelian
    '        Else
    '            MsgBox("Terjadi kesalahan proses update data!", MsgBoxStyle.Critical, "Perhatian")
    '            Exit Sub
    '        End If
    '    End If

    'End Sub

    'Private Sub GridControl1_EmbeddedNavigator_ButtonClick(sender As Object, e As NavigatorButtonClickEventArgs) Handles GridControl1.EmbeddedNavigator.ButtonClick
    '    Select Case e.Button.ButtonType
    '        Case DevExpress.XtraEditors.NavigatorButtonType.EndEdit

    '    End Select
    'End Sub

    'Private Sub txtBiayalain_Leave(sender As Object, e As EventArgs) Handles txtBiayalain.Leave
    '    txtTotalbayar.EditValue = GridView1.Columns("sub_total").SummaryItem.SummaryValue + txtPpn.EditValue + txtBiayalain.EditValue
    'End Sub

    'Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
    '    subTotal += GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sub_total")
    '    txtPpn.EditValue = (subTotal * 11) / 100
    'End Sub

    'Private Sub rbgDraft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rbgDraft.SelectedIndexChanged
    '    If rbgDraft.EditValue = 1 Then
    '        draf = 1
    '    Else
    '        draf = 0
    '    End If
    'End Sub
End Class