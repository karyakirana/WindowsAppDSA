Imports DevExpress.XtraGrid

Public Class StockMasukList
    Public _repositoryStockMasuk = New StockMasukRepository

    Private Sub StockMasukList_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Async Sub LoadData()
        Dim listView = Await _repositoryStockMasuk.GetList()
        StockMasukGridControl.DataSource = listView
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm = New frmAddStockMasuk
        frm.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Using frm As New frmAddStockMasuk
            'load edit
            If frm.DialogResult = DialogResult.OK Then
                MsgBox("data berhasil diupdate")
                LoadData()
            End If
        End Using
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Close()
    End Sub
End Class