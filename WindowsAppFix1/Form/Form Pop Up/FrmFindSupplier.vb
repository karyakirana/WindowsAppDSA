Public Class FrmFindSupplier
    Private _supplierRepo As New SupplierRepository
    Dim _listsupplier As List(Of Supplier)

    Public Async Sub LoadData()
        _listsupplier = Await _supplierRepo.GetList()
        GridControl1.DataSource = _listsupplier
    End Sub

    Private Sub FrmFindSupplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick


        For i = 0 To _listsupplier.Count - 1
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id") = _listsupplier(i).id Then
                _Supplier.nama = _listsupplier(i).nama
            End If
        Next
        Me.Close()
    End Sub


End Class