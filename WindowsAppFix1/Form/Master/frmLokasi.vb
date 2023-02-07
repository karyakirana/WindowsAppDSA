Imports DevExpress.XtraBars

Public Class frmLokasi

    Private Sub btnNew_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNew.ItemClick
        purpose = "New"
        If purpose = "New" Then
            Dim frm As New frmAddLokasi
            frm.Show()
        End If
    End Sub

    Private Sub frmLokasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        clearDTLokasi()
        setColumnDTLokasi()
        getLokasi()
        GridControl1.DataSource = dtLokasi
        GridView1.Columns.ColumnByFieldName("nama").VisibleIndex = 0
        GridView1.Columns.ColumnByFieldName("nama").Caption = "Gudang"
        GridView1.Columns.ColumnByFieldName("nama").Width = 75
        GridView1.Columns.ColumnByFieldName("nama").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("nama").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("keterangan").VisibleIndex = 1
        GridView1.Columns.ColumnByFieldName("keterangan").Caption = "Keterangan"
        GridView1.Columns.ColumnByFieldName("keterangan").Width = 100
        GridView1.Columns.ColumnByFieldName("keterangan").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("keterangan").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("kode").VisibleIndex = -1
        GridView1.BestFitColumns()
    End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Me.Close()
    End Sub



    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        purpose = "Edit"
        If purpose = "Edit" Then
            id_lokasi = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
            kode_lokasi = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "kode").ToString.TrimEnd

            clearDTLokasi()
            setColumnDTLokasi()
            getLokasiById(id_lokasi)
            Dim frm As New frmAddLokasi
            frm.Text = "Form Edit Data Lokasi"
            frm.Show()
        End If
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDelete.ItemClick
        id_lokasi = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
        If MessageBox.Show("Konfirmasi hapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No Then
            deleteData(IPAddress & "/api/master/lokasi/" & id_lokasi)
            statusDelete = obj.Item("status")
            If statusDelete = True Then
                MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information, "Informasi")

                GridControl1.DataSource = Nothing
                clearDTLokasi()
                setColumnDTLokasi()
                getLokasi()
                GridControl1.DataSource = dtLokasi
            Else
                MsgBox("Terjadi kesalahan proses hapus data!", MsgBoxStyle.Critical, "Perhatian")
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub
End Class