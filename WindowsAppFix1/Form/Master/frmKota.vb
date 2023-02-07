Public Class frmKota

    Private Sub frmKota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearDtKota()
        setColumnDTKota()
        getKota()
        GridControl1.DataSource = dtKota
        GridView1.Columns.ColumnByFieldName("id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("nama_provinsi").VisibleIndex = 0
        GridView1.Columns.ColumnByFieldName("nama_provinsi").Caption = "Provinsi"
        'GridView1.Columns.ColumnByFieldName("nama_provinsi").Width = 75
        GridView1.Columns.ColumnByFieldName("nama_provinsi").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("nama_provinsi").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView1.Columns.ColumnByFieldName("nama_kota").VisibleIndex = 1
        GridView1.Columns.ColumnByFieldName("nama_kota").Caption = "Kota"
        'GridView1.Columns.ColumnByFieldName("nama_kota").Width = 75
        GridView1.Columns.ColumnByFieldName("nama_kota").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("nama_kota").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.BestFitColumns()
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        id_kota = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id").ToString
        Province = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nama_provinsi").ToString
        Kota = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nama_kota").ToString
        Me.Close()
        'MsgBox("Provinsi : " & province & " | Kota : " & kota)
    End Sub
End Class