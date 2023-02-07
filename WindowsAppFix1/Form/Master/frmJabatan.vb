Public Class frmJabatan
    Private Sub GridControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmJabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearDtJabatan()
        setColumnDTJabatan()
        getJabatan()
        GridControl1.DataSource = dtJabatan
        GridView1.Columns.ColumnByFieldName("nama").VisibleIndex = 0
        GridView1.Columns.ColumnByFieldName("nama").Caption = "Jabatan"
        GridView1.Columns.ColumnByFieldName("nama").Width = 75
        GridView1.Columns.ColumnByFieldName("nama").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("nama").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("keterangan").VisibleIndex = 1
        GridView1.Columns.ColumnByFieldName("keterangan").Caption = "Keterangan"
        GridView1.Columns.ColumnByFieldName("keterangan").Width = 75
        GridView1.Columns.ColumnByFieldName("keterangan").AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByFieldName("keterangan").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

        GridView1.Columns.ColumnByFieldName("id").VisibleIndex = -1
        GridView1.Columns.ColumnByFieldName("kode").VisibleIndex = -1
    End Sub


    Private Sub btnNew_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNew.ItemClick
        purpose = "New"
        If purpose = "New" Then
            Dim frm As New frmAddJabatan
            frm.Show()
        End If
    End Sub

    Private Sub mainRibbonControl_Click(sender As Object, e As EventArgs) Handles mainRibbonControl.Click

    End Sub

    'Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
    '    id_jabatan = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
    '    If MessageBox.Show("Konfirmasi hapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No Then
    '        deleteData(IPAddress & "/api/master/jabatan/" & id_pegawai)
    '        statusDelete = obj.Item("status")
    '        If statusDelete = True Then
    '            MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information, "Informasi")

    '            GridControl1.DataSource = Nothing
    '            clearDtJabatan()
    '            setColumnDTJabatan()
    '            getJabatanById(id_jabatan)
    '            GridControl1.DataSource = dtJabatan
    '        Else
    '            MsgBox("Terjadi kesalahan proses hapus data!", MsgBoxStyle.Critical, "Perhatian")
    '            Exit Sub
    '        End If
    '    Else
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub bbiClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        id_jabatan = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
        If MessageBox.Show("Konfirmasi hapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No Then
            deleteData(IPAddress & "/api/master/jabatan/" & id_jabatan)
            statusDelete = obj.Item("status")
            If statusDelete = True Then
                MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information, "Informasi")

                GridControl1.DataSource = Nothing
                clearDtJabatan()
                setColumnDTJabatan()
                getJabatan()
                GridControl1.DataSource = dtJabatan
            Else
                MsgBox("Terjadi kesalahan proses hapus data!", MsgBoxStyle.Critical, "Perhatian")
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        purpose = "Edit"
        If purpose = "Edit" Then
            id_jabatan = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
            kode_jabatan = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "kode").ToString.TrimEnd

            clearDtJabatan()
            setColumnDTJabatan()
            getJabatanById(id_jabatan)
            Dim frm As New frmAddJabatan
            frm.XtraTabPage2.Text = "Form Edit Data Jabatan"
            frm.Show()
        End If
    End Sub



    'Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
    '    purpose = "Edit"
    '    If purpose = "Edit" Then
    '        id_jabatan = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
    '        kode_jabatan = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "kode").ToString.TrimEnd

    '        clearDtJabatan()
    '        setColumnDTJabatan()
    '        getJabatanById(id_jabatan)
    '        Dim frm As New frmAddJabatan
    '        frm.XtraTabPage2.Text = "Form Edit Data Jabatan"
    '        frm.Show()
    '    End If
    'End Sub
End Class