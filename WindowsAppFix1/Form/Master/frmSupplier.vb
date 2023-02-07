Public Class frmSupplier
    Private Sub btnNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim frm As New frmAddSupplier
        frm.Show()
    End Sub

    Private Sub btnNew_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNew.ItemClick
        purpose = "New"
        If purpose = "New" Then
            Dim frm As New frmAddSupplier
            frm.Show()
        End If
    End Sub

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        clearDtSupplier()
        setColumnDTSupplier()
        getSupplier()
        GridControl1.DataSource = dtSupplier
        GridView1.Columns.ColumnByFieldName("kode").VisibleIndex = 0
        GridView1.Columns.ColumnByFieldName("kode").Caption = "Kode"
        GridView1.Columns.ColumnByFieldName("kode").Width = 75
        GridView1.Columns.ColumnByFieldName("kode").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("kode").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView1.Columns.ColumnByFieldName("nama").VisibleIndex = 1
        GridView1.Columns.ColumnByFieldName("nama").Caption = "Nama"
        GridView1.Columns.ColumnByFieldName("nama").Width = 100
        GridView1.Columns.ColumnByFieldName("nama").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("nama").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("telepon").VisibleIndex = 2
        GridView1.Columns.ColumnByFieldName("telepon").Caption = "Telepon"
        GridView1.Columns.ColumnByFieldName("telepon").Width = 75
        GridView1.Columns.ColumnByFieldName("telepon").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("telepon").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("alamat").VisibleIndex = 3
        GridView1.Columns.ColumnByFieldName("alamat").Caption = "Alamat"
        GridView1.Columns.ColumnByFieldName("alamat").Width = 200
        GridView1.Columns.ColumnByFieldName("alamat").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("alamat").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("nama_kota").VisibleIndex = 3
        GridView1.Columns.ColumnByFieldName("nama_kota").Caption = "Kota / Kabupaten"
        GridView1.Columns.ColumnByFieldName("nama_kota").Width = 100
        GridView1.Columns.ColumnByFieldName("nama_kota").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("nama_kota").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("email").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("npwp").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("kota_id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("keterangan").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("id").VisibleIndex = -1
        'GridView1.BestFitColumns()
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        purpose = "Edit"
        If purpose = "Edit" Then
            id_supplier = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
            kode_supplier = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "kode").ToString.TrimEnd

            clearDtSupplier()
            setColumnDTSupplier()
            getSupplierById(id_supplier)
            Dim frm As New frmAddSupplier
            frm.XtraTabPage2.Text = "Form Edit Data Supplier"
            frm.Show()
        End If
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        id_supplier = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
        If MessageBox.Show("Konfirmasi hapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No Then
            deleteData(IPAddress & "/api/master/supplier/" & id_supplier)
            statusDelete = obj.Item("status")
            If statusDelete = True Then
                MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information, "Informasi")

                GridControl1.DataSource = Nothing
                clearDtSupplier()
                setColumnDTSupplier()
                getSupplier()
                GridControl1.DataSource = dtSupplier
            Else
                MsgBox("Terjadi kesalahan proses hapus data!", MsgBoxStyle.Critical, "Perhatian")
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Me.Close()
    End Sub
End Class