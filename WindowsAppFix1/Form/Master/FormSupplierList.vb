Public Class FormSupplierList

    Public _repositorySupplier = New SupplierRepository
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm = New frmAddSupplier
        frm.Show()
    End Sub
    Private Async Sub LoadData()
        'dataObject
        Dim listView = Await _repositorySupplier.GetList()
        GridControl1.DataSource = listView
    End Sub

    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()


    End Sub
End Class