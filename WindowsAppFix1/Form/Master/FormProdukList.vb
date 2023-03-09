Public Class FormProdukList

    Dim _repositoryProduk As ProdukRepository = New ProdukRepository
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Using frm As New frmAddProduk
            If frm.ShowDialog = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub
    Public Async Sub LoadData()
        Dim listView = Await _repositoryProduk.GetList()
        GridControl1.DataSource = listView
    End Sub

    Private Async Sub Destroy(id As Long)
        Dim hasil = Await _repositoryProduk.delete(id)
        If hasil Then
            LoadData()
        End If
    End Sub

    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Using frm As New frmAddProduk
            'edit
            frm.Edit(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid))
            If frm.ShowDialog = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        'delete
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            ' Code to execute if OK is clicked
            Destroy(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid))
        End If
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Close()
    End Sub
End Class