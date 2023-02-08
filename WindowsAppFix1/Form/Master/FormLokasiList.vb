Public Class FormLokasiList

    Public _repositoryLokasi = New LokasiRepository
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm = New frmAddLokasi
        frm.Show()
    End Sub

    Public Async Sub LoadData()
        'dataObject
        Dim listView = Await _repositoryLokasi.GetList()
        GridControl1.DataSource = listView
    End Sub

    Public Async Sub destroy(ByVal id As Long)
        Dim hasil = Await _repositoryLokasi.delete(id)
        If hasil Then
            LoadData()
        End If
    End Sub

    Private Sub FormLokasiList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim id = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid)
        Dim form As New FormLokasi
        form.edit(id)
        form.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            ' Code to execute if OK is clicked
            destroy(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid))
        End If
    End Sub
End Class