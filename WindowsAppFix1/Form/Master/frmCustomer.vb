Imports DevExpress.XtraEditors

Public Class frmCustomer
    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Me.Close()
    End Sub

    Private Sub bbiDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearDtCustomer()
        setColumnDTCustomer()
        getCustomer()
        GridControl1.DataSource = dtCustomer
        GridView1.Columns.ColumnByFieldName("kode").VisibleIndex = 0
        GridView1.Columns.ColumnByFieldName("kode").Caption = "Kode Customer"
        GridView1.Columns.ColumnByFieldName("kode").Width = 75
        GridView1.Columns.ColumnByFieldName("kode").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("kode").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView1.Columns.ColumnByFieldName("jenis_instansi").VisibleIndex = 1
        GridView1.Columns.ColumnByFieldName("jenis_instansi").Caption = "Instansi"
        GridView1.Columns.ColumnByFieldName("jenis_instansi").Width = 100
        GridView1.Columns.ColumnByFieldName("jenis_instansi").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("jenis_instansi").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("nama").VisibleIndex = 2
        GridView1.Columns.ColumnByFieldName("nama").Caption = "Nama Customer"
        GridView1.Columns.ColumnByFieldName("nama").Width = 200
        GridView1.Columns.ColumnByFieldName("nama").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("nama").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("kota_name").VisibleIndex = 3
        GridView1.Columns.ColumnByFieldName("kota_name").Caption = "Kota"
        GridView1.Columns.ColumnByFieldName("kota_name").Width = 100
        GridView1.Columns.ColumnByFieldName("kota_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("kota_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("sales_name").VisibleIndex = 4
        GridView1.Columns.ColumnByFieldName("sales_name").Caption = "Sales"
        GridView1.Columns.ColumnByFieldName("sales_name").Width = 100
        GridView1.Columns.ColumnByFieldName("sales_name").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("sales_name").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("kota_id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("sales_id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("email").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("npwp").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("alamat").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("telepon").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("diskon").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("keterangan").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("id").VisibleIndex = -1
        'GridView1.BestFitColumns()

    End Sub

    Private Sub btnNew_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNew.ItemClick
        purpose = "New"
        If purpose = "New" Then
            Dim frm As New frmAddCustomer
            frm.Show()
        End If
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        purpose = "Edit"
        If purpose = "Edit" Then
            id_cust = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
            kode_cust = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "kode").ToString.TrimEnd

            clearDtCustomer()
            setColumnDTCustomer()
            getCustomerById(id_cust)
            Dim frm As New frmAddCustomer
            frm.XtraTabPage1.Text = "Form Edit Data Customer"
            frm.Show()
        End If
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        id_cust = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
        If MessageBox.Show("Konfirmasi hapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No Then
            deleteData(IPAddress & "/api/master/customer/" & id_cust)
            statusDelete = obj.Item("status")
            If statusDelete = True Then
                MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information, "Informasi")

                GridControl1.DataSource = Nothing
                clearDtCustomer()
                setColumnDTCustomer()
                getCustomer()
                GridControl1.DataSource = dtCustomer
            Else
                MsgBox("Terjadi kesalahan proses hapus data!", MsgBoxStyle.Critical, "Perhatian")
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub
End Class