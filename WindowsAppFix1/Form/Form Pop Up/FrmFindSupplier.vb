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
        _Supplier.id = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id")
        _Supplier.nama = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nama").ToString
        Me.Close()
    End Sub


End Class