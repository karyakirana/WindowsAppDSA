Public Class FormPembelianList

    Public _repositoryPembelian = New PembelianRepository
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm = New frmAddPembelian
        frm.Show()
    End Sub
    Private Async Sub LoadData()
        'dataObject

        Dim listView = Await _repositoryPembelian.GetList()
        GridControl1.DataSource = listView
    End Sub

    Private Async Sub destroy(id As Long)
        Dim hasil = Await _repositoryPembelian.delete(id)
        If hasil Then
            LoadData()
        End If
    End Sub

    Private Sub FormPembelianList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Using frm As New frmAddPembelian()
            Dim id = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid)
            'frm.Edit(id)
        End Using
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        'delete
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