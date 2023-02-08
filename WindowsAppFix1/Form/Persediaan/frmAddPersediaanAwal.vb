Imports System.Net
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmAddPersediaanAwal

    'Dim sumJumlah As New GridColumnSummaryItem()
    'Dim sumSubTotal As New GridColumnSummaryItem()
    'Dim edit As New RepositoryItemDateEdit
    'Dim del As New RepositoryItemButtonEdit
    'Dim gc As New GridColumn
    'Dim exp As DateTime

    'Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
    '    'If purpose = "Edit" Then
    '    '    Me.Close()
    '    '    Dim frm As New frmPersediaanAwal
    '    '    frm.GridControl1.DataSource = Nothing
    '    '    clearDtPersediaanAwal()
    '    '    setColumnDTPersediaanAwal()
    '    '    getPersediaanAwal()
    '    '    frm.GridControl1.DataSource = dtPersediaanAwal
    '    'Else
    '    Me.Close()
    '    'End If
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

    '    GridView1.Columns.ColumnByFieldName("sub_total").VisibleIndex = 5
    '    GridView1.Columns.ColumnByFieldName("sub_total").Caption = "Sub Total"
    '    'GridView1.Columns.ColumnByFieldName("sub_total").Width = 75
    '    GridView1.Columns.ColumnByFieldName("sub_total").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    '    GridView1.Columns.ColumnByFieldName("sub_total").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

    '    GridControl1.RepositoryItems.Add(RepositoryItemDateEdit1)
    '    GridView1.Columns("exp").ColumnEdit = RepositoryItemDateEdit1

    '    GridView1.Columns("jumlah").Summary.Add(sumJumlah)
    '    GridView1.Columns("sub_total").Summary.Add(sumSubTotal)
    'End Sub

    'Private Sub frmAddPersediaanAwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    If purpose = "New" Then
    '        clearDTLokasi()
    '        setColumnDTLokasi()
    '        getLokasi()

    '        For i = 0 To dtLokasi.Rows.Count - 1
    '            cbLokasi.Properties.Items.Add(dtLokasi.Rows(i)("nama").ToString)
    '        Next

    '        clearDTPerhitunganPersediaanAwal()
    '        setColumnDTPerhitunganPersediaanAwal()
    '        GridControl1.DataSource = dtPerhitunganPersedianAwal

    '        setGridviewColumn()
    '        GridView1.Columns.ColumnByFieldName("nama").OptionsColumn.AllowEdit = False
    '        GridView1.Columns.ColumnByFieldName("sub_total").OptionsColumn.AllowEdit = False
    '        btnSimpan.Text = "Simpan"
    '    Else
    '        clearDTLokasi()
    '        setColumnDTLokasi()
    '        getLokasi()

    '        For i = 0 To dtLokasi.Rows.Count - 1
    '            cbLokasi.Properties.Items.Add(dtLokasi.Rows(i)("nama").ToString)
    '        Next

    '        clearDTPerhitunganPersediaanAwal()
    '        setColumnDTPerhitunganPersediaanAwal()
    '        GridControl1.DataSource = dtPerhitunganPersedianAwal

    '        setGridviewColumn()
    '        GridView1.Columns.ColumnByFieldName("nama").OptionsColumn.AllowEdit = False
    '        GridView1.Columns.ColumnByFieldName("harga").OptionsColumn.AllowEdit = False
    '        GridView1.Columns.ColumnByFieldName("sub_total").OptionsColumn.AllowEdit = False

    '        For i = 0 To dtPersediaanAwal.Rows.Count - 1
    '            If id_persediaan_awal = dtPersediaanAwal.Rows(i)("id") Then
    '                cbKondisi.EditValue = dtPersediaanAwal.Rows(i)("kondisi").ToString
    '                cbLokasi.EditValue = dtPersediaanAwal.Rows(i)("lokasi_nama").ToString
    '                cbDraft.EditValue = dtPersediaanAwal.Rows(i)("draft").ToString
    '                dtTanggal.EditValue = dtPersediaanAwal.Rows(i)("tgl_persediaan_awal").ToString
    '                txtKeterangan.EditValue = dtPersediaanAwal.Rows(i)("keterangan").ToString

    '                Dim dr As DataRow
    '                dr = dtPerhitunganPersedianAwal.NewRow
    '                dr("id") = dtPersediaanAwal.Rows(i)("produk_id")
    '                dr("nama") = dtPersediaanAwal.Rows(i)("produk_nama").ToString
    '                dr("harga") = dtPersediaanAwal.Rows(i)("harga_beli")
    '                dr("jumlah") = dtPersediaanAwal.Rows(i)("jumlah")
    '                dr("exp") = dtPersediaanAwal.Rows(i)("expired").ToString
    '                dr("batch") = dtPersediaanAwal.Rows(i)("batch").ToString
    '                dr("sub_total") = dtPersediaanAwal.Rows(i)("sub_total")
    '                dtPerhitunganPersedianAwal.Rows.Add(dr)
    '                GridControl1.DataSource = dtPerhitunganPersedianAwal
    '            End If
    '        Next
    '        sumJumlah.SummaryType = SummaryItemType.Sum
    '        sumJumlah.FieldName = "jumlah"
    '        sumJumlah.DisplayFormat = "{0:#.#}"

    '        sumSubTotal.SummaryType = SummaryItemType.Sum
    '        sumSubTotal.FieldName = "sub_total"
    '        sumSubTotal.DisplayFormat = "{0:#.#}"

    '        btnSimpan.Text = "Update"
    '    End If

    'End Sub

    'Private Sub cbLokasi_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbLokasi.SelectedValueChanged
    '    For i = 0 To dtLokasi.Rows.Count - 1
    '        If cbLokasi.EditValue = dtLokasi.Rows(i)("nama").ToString Then
    '            id_lokasi = CInt(dtLokasi.Rows(i)("id"))
    '        End If
    '    Next
    'End Sub

    'Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

    '    Dim _controller As PersediaanAwalController = New PersediaanAwalController
    '    Dim storePersediaan = New PersediaanAwal
    '    storePersediaan.draft = draf
    '    storePersediaan.kondisi = cbKondisi.EditValue
    '    storePersediaan.lokasi_id = id_lokasi
    '    storePersediaan.tgl_persediaan_awal = dtTanggal.Text
    '    storePersediaan.total_barang = GridView1.Columns("jumlah").SummaryItem.SummaryValue
    '    storePersediaan.total_nominal = GridView1.Columns("sub_total").SummaryItem.SummaryValue
    '    storePersediaan.keterangan = txtKeterangan.EditValue
    '    Dim store = _controller.store(
    '        storePersediaan,
    '        GridView1
    '    )

    '    If store Then
    '        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
    '        Dim datatable = New DTPersediaanAwalHelper
    '        datatable.DatatablePersediaanAwal()

    '        If Not datatable._status Then
    '            MsgBox(datatable._status)
    '            Exit Sub
    '        End If

    '        Dim frm As New frmPersediaanAwal
    '        frm.GridControl1.DataSource = datatable.dtpa
    '        Me.Close()
    '    Else
    '        MsgBox("Terjadi kesalahan proses simpan data!", MsgBoxStyle.Critical, "Perhatian")
    '    End If

    '    'If insertPersediaanAwal(GridView1, draf, cbKondisi.EditValue, id_lokasi, 1, GridView1.Columns("jumlah").SummaryItem.SummaryValue,
    '    '                        GridView1.Columns("sub_total").SummaryItem.SummaryValue, txtKeterangan.EditValue, dtTanggal.Text, exp.ToString("yyyy-MM-dd")) = True Then

    '    '    statusInsert = obj.Item("data")("status")
    '    '    If statusInsert = True Then
    '    '        If statusInsert = True Then
    '    '            MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
    '    '            Dim frm As New frmCustomer
    '    '            frm.GridControl1.DataSource = Nothing
    '    '            clearDTLokasi()
    '    '            setColumnDTLokasi()
    '    '            getLokasi()
    '    '            frm.GridControl1.DataSource = dtLokasi
    '    '            Me.Close()
    '    '        Else
    '    '            MsgBox("Terjadi kesalahan proses simpan data!", MsgBoxStyle.Critical, "Perhatian")
    '    '            Exit Sub
    '    '        End If
    '    '    End If

    '    'End If
    'End Sub

    'Private Sub cbDraft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDraft.SelectedIndexChanged
    '    If cbDraft.EditValue = True Then
    '        draf = 1
    '    Else
    '        draf = 0
    '    End If
    'End Sub

    'Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

    '    Dim frm As New FrmFindProduk
    '    Dim i : i = frm.ShowDialog()
    '    If CType(i, DialogResult) = 2 Then

    '        If id_produk <> 0 Then
    '            Dim dr As DataRow
    '            dr = dtPerhitunganPersedianAwal.NewRow
    '            dr("id") = id_produk
    '            dr("nama") = nama_produk
    '            dr("harga") = harga_produk
    '            dr("jumlah") = 0
    '            dr("exp") = Format(Date.Now, "yyyy-MM-dd")
    '            dr("batch") = ""
    '            dr("sub_total") = 0
    '            dtPerhitunganPersedianAwal.Rows.Add(dr)

    '            GridControl1.DataSource = dtPerhitunganPersedianAwal
    '        End If

    '    End If

    '    For i = 0 To dtPerhitunganPersedianAwal.Rows.Count - 1
    '        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id") = id_produk Then
    '            dtPerhitunganPersedianAwal.Rows(i)("batch") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "batch").ToString
    '            dtPerhitunganPersedianAwal.Rows(i)("jumlah") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "jumlah").ToString
    '            dtPerhitunganPersedianAwal.Rows(i)("sub_total") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "sub_total").ToString
    '        End If
    '    Next
    'End Sub

    'Private Sub GridView1_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
    '    If GridView1.FocusedColumn.FieldName = "exp" Then
    '        Dim hitung As Integer = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "harga") * GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "jumlah")
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

End Class