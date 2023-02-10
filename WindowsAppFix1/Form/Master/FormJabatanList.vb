Public Class FormJabatanList

    Public _repositoryJabatan As JabatanRepository = New JabatanRepository
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm As New frmAddJabatan
        frm.Show()
    End Sub

    Public Async Sub LoadData()
        'dataObject
        Dim listView = Await _repositoryJabatan.GetList()
        GridControl1.DataSource = listView
    End Sub

    Private Sub FormJabatanList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        'GridView1.Columns.ColumnByFieldName("id").VisibleIndex = -1
        'GridView1.Columns.ColumnByFieldName("kode").VisibleIndex = -1
        'GridView1.Columns.ColumnByFieldName("created_at").VisibleIndex = -1
        'GridView1.Columns.ColumnByFieldName("updated_at").VisibleIndex = -1
    End Sub

    Public Async Sub destroy(ByVal id As Long)
        Dim hasil = Await _repositoryJabatan.delete(id)
        If hasil Then
            LoadData()
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim lokasiId = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid)
        Dim form As New frmAddJabatan
        form.edit(lokasiId)
        form.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            ' Code to execute if OK is clicked
            destroy(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid))
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Close()
    End Sub
End Class