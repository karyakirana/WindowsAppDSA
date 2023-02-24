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

    Private _supplierRepo As New SupplierRepository
    Private _persediaanRepo As New PersediaanRepo
    Public dtPembelian As New DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadData()
        tglPembelian.EditValue = Date.Now
    End Sub

    Public Async Sub LoadData()
        LoadDataTable()
        Dim _listsupplier = Await _supplierRepo.GetList()
    End Sub

    Private Sub LoadDataTable()

    End Sub

    Public Async Sub SetRow()
        'get data
        Dim getData As Persediaan = Await _persediaanRepo.edit(id)
        'set to row
        If Not getData Is Nothing Then

            Dim persediaan As New Persediaan
            persediaan = getData

            Dim row As DataRow
            row = dtPembelian.NewRow
            row("persediaan_id") = persediaan.id
            row("produk_nama") = persediaan.produk.nama
            row("batch") = ""
            row("expired") = Format(Date.Now, "yyyy-MM-dd")
            row("serial_number") = ""
            row("harga") = persediaan.produk.harga
            row("diskon") = 0
            row("jumlah") = 0
            row("sub_total") = 0

            dtPembelian.Rows.Add(row)
            GridControl1.DataSource = dtPembelian

        End If
    End Sub

    Private Sub txtSupplier_Click(sender As Object, e As EventArgs) Handles txtSupplier.Click
        Dim frm As New FrmFindSupplier
        Dim i : i = frm.ShowDialog()
        txtSupplier.EditValue = _Supplier.nama
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Using frm As FrmFindProduk = New FrmFindProduk
            If frm.ShowDialog = DialogResult.OK Then
                SetRow(frm.GetValue)
                Console.WriteLine(frm.GetValue)
            End If
        End Using
    End Sub

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