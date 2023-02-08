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

    'Dim sumJumlah As New GridColumnSummaryItem()
    'Dim sumSubTotal As New GridColumnSummaryItem()
    'Dim exp As DateTime

    'Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
    '    clearDtPenjualan()
    '    setColumnDTPenjualan()
    '    getPenjualan()
    '    GridControl1.DataSource = Nothing
    '    GridControl1.DataSource = dtPenjualan
    '    Me.Close()
    'End Sub

    'Private Sub txtCustomer_Click(sender As Object, e As EventArgs) Handles txtCustomer.Click
    '    Dim frm As New FrmFindCustomer
    '    Dim i : i = frm.ShowDialog()
    '    If CType(i, DialogResult) = 2 Then
    '        Me.txtCustomer.EditValue = nama
    '        txtSales.EditValue = sales_name
    '    End If
    'End Sub

    'Private Sub txtTempo_LostFocus(sender As Object, e As EventArgs) Handles txtTempo.LostFocus

    'End Sub

    'Private Sub txtTempo_Leave(sender As Object, e As EventArgs) Handles txtTempo.Leave
    '    If txtTempo.EditValue = 0 Then
    '        MsgBox("Tempo harus lebih dari 0!", MsgBoxStyle.Exclamation, "Informasi")
    '    Else
    '        tglTempo.EditValue = Format(DateAdd("d", txtTempo.EditValue, Date.Now), "dd-MM-yyyy")
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

    '    'GridControl1.RepositoryItems.Add(RepositoryItemDateEdit1)
    '    'GridView1.Columns("exp").ColumnEdit = RepositoryItemDateEdit1()

    '    GridView1.Columns("jumlah").Summary.Add(sumJumlah)
    '    GridView1.Columns("sub_total").Summary.Add(sumSubTotal)
    'End Sub

    'Private Function RepositoryItemDateEdit1() As String
    '    Throw New NotImplementedException()
    'End Function

    'Private Sub frmAddPenjualan_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Dim itemValues As Object() = New Object() {1, 2}
    '    Dim itemDescriptions As String() = New String() {"True", "False"}
    '    Dim i As Integer = 0
    '    Do While i < itemValues.Length
    '        rbgDraft.Properties.Items.Add(New RadioGroupItem(itemValues(i), itemDescriptions(i)))
    '        i += 1
    '    Loop
    '    'Select the Rectangle item.
    '    rbgDraft.EditValue = 1

    '    tglPenjualan.EditValue = Date.Now

    '    clearDTPerhitunganPenjualan()
    '    setColumnDTPerhitunganPenjualan()
    '    GridControl1.DataSource = dtPerhitunganPenjualan
    '    'setGridviewColumn(GetRepositoryItemDateEdit1())


    '    GridView1.Columns.ColumnByFieldName("nama").OptionsColumn.AllowEdit = False
    '    GridView1.Columns.ColumnByFieldName("sub_total").OptionsColumn.AllowEdit = False
    '    btnSimpan.Text = "Simpan"
    'End Sub

    'Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

    '    Dim frm As New FrmFindProduk
    '    Dim i : i = frm.ShowDialog()
    '    If CType(i, DialogResult) = 2 Then

    '        If id_produk <> 0 Then
    '            Dim dr As DataRow
    '            dr = dtPerhitunganPenjualan.NewRow
    '            dr("id") = id_produk
    '            dr("nama") = nama_produk
    '            dr("harga") = harga_produk
    '            dr("jumlah") = 0
    '            dr("exp") = Format(Date.Now, "yyyy-MM-dd")
    '            dr("batch") = ""
    '            dr("diskon") = 0
    '            dr("sub_total") = 0
    '            dtPerhitunganPenjualan.Rows.Add(dr)

    '            GridControl1.DataSource = dtPerhitunganPenjualan
    '        End If

    '    End If

    '    For i = 0 To dtPerhitunganPenjualan.Rows.Count - 1
    '        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id") = id_produk Then
    '            dtPerhitunganPenjualan.Rows(i)("batch") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "batch").ToString
    '            dtPerhitunganPenjualan.Rows(i)("jumlah") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "jumlah").ToString
    '            dtPerhitunganPenjualan.Rows(i)("sub_total") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sub_total").ToString
    '        End If
    '    Next
    'End Sub

    'Private Sub GridView1_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
    '    'If GridView1.FocusedColumn.FieldName = "exp" Then
    '    '    Dim hitung As Integer = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "harga") * GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "jumlah")
    '    '    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "sub_total", hitung)

    '    '    sumJumlah.SummaryType = SummaryItemType.Sum
    '    '    sumJumlah.FieldName = "jumlah"
    '    '    sumJumlah.DisplayFormat = "{0:#.#}"


    '    '    sumSubTotal.SummaryType = SummaryItemType.Sum
    '    '    sumSubTotal.FieldName = "sub_total"
    '    '    sumSubTotal.DisplayFormat = "{0:#.#}"
    '    'End If

    '    'If GridView1.FocusedColumn.FieldName = "batch" Then
    '    '    RepositoryItemDateEdit1.Mask.EditMask = "yyyy-MM-dd"
    '    '    RepositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = True

    '    '    exp = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "exp")
    '    'End If
    'End Sub

    'Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
    '    GridView1.DeleteRow(GridView1.FocusedRowHandle)
    'End Sub

    'Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

    '    Dim _penjualan = New PenjualanModel
    '    _penjualan.penjualan_penawaran_id = vbNull
    '    _penjualan.draft = draf
    '    _penjualan.status = status
    '    _penjualan.tipe_penjualan = "belum bayar"
    '    _penjualan.tgl_penjualan = tglPenjualan.EditValue
    '    _penjualan.tempo = txtTempo.EditValue
    '    _penjualan.tgl_tempo = tglTempo.EditValue
    '    _penjualan.customer_id = txtCustomer.EditValue
    '    _penjualan.sales_id = txtSales.EditValue
    '    _penjualan.total_barang = ""
    '    _penjualan.ppn = txtPpn.EditValue
    '    _penjualan.biaya_lain = txtBiayaLain.EditValue
    '    _penjualan.total_bayar = txtTotalBayar.EditValue
    '    _penjualan.keterangan = txtKeterangan.EditValue

    '    Dim _penjualanDetail = New List(Of PenjualanDataDetail)
    '    For row As Integer = 0 To GridView1.DataRowCount - 1
    '        Dim _detail As New PenjualanDataDetail With {
    '            .persediaan_id = CInt(GridView1.GetRowCellValue(row, "id")),
    '            .harga_jual = CStr(GridView1.GetRowCellValue(row, "batch")),
    '            .jumlah = CStr(GridView1.GetRowCellValue(row, "exp")),
    '            .satuan_jual = CInt(GridView1.GetRowCellValue(row, "harga")),
    '            .diskon = CInt(GridView1.GetRowCellValue(row, "jumlah")),
    '            .sub_total = CInt(GridView1.GetRowCellValue(row, "sub_total"))
    '        }
    '        _penjualan.data_detail.Add(_detail)
    '    Next
    '    If btnSimpan.Text = "Simpan" Then
    '        Try

    '            insertDatapenjualan(_penjualan)
    '            statusInsert = obj.Item("status")
    '            If statusInsert = True Then
    '                MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
    '                Dim frm As New frmPenjualan
    '                frm.GridControl1.DataSource = Nothing
    '                clearTablePenjualan()
    '                setColumnTablePenjualan()
    '                getDataPenjualan()
    '                frm.GridControl1.DataSource = datatablePenjualan
    '                Close()
    '            Else
    '                MsgBox("Terjadi kesalahan proses simpan data!", MsgBoxStyle.Critical, "Perhatian")
    '                Exit Sub
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    Else

    '    End If

    'End Sub

    'Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging
    '    If GridView1.FocusedColumn.FieldName = "jumlah" Then
    '        Dim edit As TextEdit = CType(GridView1.ActiveEditor, TextEdit)

    '        If e.Value <= 0 Then
    '            edit.ErrorText = "Jumlah harus > 0"
    '        Else
    '            edit.ErrorText = String.Empty
    '            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "jumlah", e.Value)
    '            Dim hitung As Integer = (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "harga") * e.Value)
    '            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "sub_total", hitung)

    '            sumJumlah.SummaryType = SummaryItemType.Sum
    '            sumJumlah.FieldName = "jumlah"
    '            sumJumlah.DisplayFormat = "{0:#.#}"


    '            sumSubTotal.SummaryType = SummaryItemType.Sum
    '            sumSubTotal.FieldName = "sub_total"
    '            sumSubTotal.DisplayFormat = "{0:#.#}"
    '        End If
    '    End If
    'End Sub

    'Private Sub rbgDraft_EditValueChanged(sender As Object, e As EventArgs) Handles rbgDraft.EditValueChanged
    '    MsgBox(rbgDraft.Properties.Items(rbgDraft.SelectedIndex).Description)
    'End Sub
End Class