Public Class FrmFindCustomer
    Private _customerRepo As New CustomerRepository
    Dim _listcustomer As List(Of Customer)

    Public Async Sub LoadData()
        _listcustomer = Await _customerRepo.GetList()
        GridControl1.DataSource = _listcustomer
    End Sub

    Private Sub FrmFindCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        For i = 0 To _listcustomer.Count - 1
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id") = _listcustomer(i).id Then
                _Customer.nama = _listcustomer(i).nama
                _Customer.id = _listcustomer(i).id
                _Customer.sales() = _listcustomer(i).sales()
                _Customer.sales_id() = _listcustomer(i).sales_id()
            End If
        Next
        Me.Close()
    End Sub
End Class