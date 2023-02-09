Public Class FormPenjualanList

    Private _penjualanRepository As New PenjualanRepository

    Public Async Sub LoadData()
        'dataObject
        Dim listView = Await _penjualanRepository.GetList()
        GridControl1.DataSource = listView
    End Sub

    Public Async Sub destroy(ByVal id As Long)
        Dim hasil = Await _penjualanRepository.delete(id)
        If hasil Then
            LoadData()
        End If
    End Sub

    Private Sub FormPenjualanList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'dialog add
        Using frm As New frmAddPenjualan()
            If frm.ShowDialog = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Using frm As New frmAddPenjualan()
            Dim id = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid)
            frm.edit(id)
        End Using
    End Sub
End Class