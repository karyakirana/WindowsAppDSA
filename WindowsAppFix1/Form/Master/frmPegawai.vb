Public Class frmPegawai
    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim frm As New frmAddPegawai
        frm.Show()
    End Sub

    'Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    '    purpose = "New"
    '    If purpose = "New" Then
    '        Dim frm As New frmAddPegawai
    '        frm.Show()
    '    End If
    'End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'purpose = "New"
        'If purpose = "New" Then
        '    Dim frm As New frmAddPegawai
        '    frm.Show()
        'End If
        purpose = "New"
        Dim frm As New frmAddPegawai
        frm.Show()
    End Sub

    Private Sub frmPegawai_Load(sender As Object, e As EventArgs) Handles Me.Load
        clearDtPegawai()
        setColumnDTPegawai()
        getPegawai()
        GridControl1.DataSource = dtPegawai
        GridView1.Columns.ColumnByFieldName("kode").VisibleIndex = 0
        GridView1.Columns.ColumnByFieldName("kode").Caption = "Kode"
        GridView1.Columns.ColumnByFieldName("kode").Width = 75
        GridView1.Columns.ColumnByFieldName("kode").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("kode").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView1.Columns.ColumnByFieldName("nama").VisibleIndex = 1
        GridView1.Columns.ColumnByFieldName("nama").Caption = "Nama"
        GridView1.Columns.ColumnByFieldName("nama").Width = 200
        GridView1.Columns.ColumnByFieldName("nama").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("nama").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("nama_jabatan").VisibleIndex = 2
        GridView1.Columns.ColumnByFieldName("nama_jabatan").Caption = "Jabatan"
        GridView1.Columns.ColumnByFieldName("nama_jabatan").Width = 100
        GridView1.Columns.ColumnByFieldName("nama_jabatan").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("nama_jabatan").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView1.Columns.ColumnByFieldName("telepon").VisibleIndex = 3
        GridView1.Columns.ColumnByFieldName("telepon").Caption = "Telepon"
        GridView1.Columns.ColumnByFieldName("telepon").Width = 100
        GridView1.Columns.ColumnByFieldName("telepon").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("telepon").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        GridView1.Columns.ColumnByFieldName("status").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("gender").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("jabatan_id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("email").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("npwp").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("alamat").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("kota_id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("keterangan").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("nama_kota").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("id").VisibleIndex = -1
        'GridView1.BestFitColumns()
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        purpose = "Edit"
        If purpose = "Edit" Then
            id_pegawai = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
            kode_pegawai = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "kode").ToString.TrimEnd

            clearDtPegawai()
            setColumnDTPegawai()
            getPegawaiById(id_pegawai)
            Dim frm As New frmAddPegawai
            frm.XtraTabPage1.Text = "Form Edit Data Pegawai"
            frm.Show()
        End If
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        id_pegawai = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
        If MessageBox.Show("Konfirmasi hapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No Then
            deleteData(IPAddress & "/api/master/pegawai/" & id_pegawai)
            statusDelete = obj.Item("status")
            If statusDelete = True Then
                MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information, "Informasi")

                GridControl1.DataSource = Nothing
                clearDtPegawai()
                setColumnDTPegawai()
                getPegawai()
                GridControl1.DataSource = dtPegawai
            Else
                MsgBox("Terjadi kesalahan proses hapus data!", MsgBoxStyle.Critical, "Perhatian")
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub bbiClose_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Me.Close()
    End Sub
End Class