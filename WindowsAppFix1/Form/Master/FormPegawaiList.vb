Public Class FormPegawaiList

    Dim _repository As PegawaiRepository = New PegawaiRepository
    Dim pegawai As New Pegawai

    Private Sub FormPegawaiList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Public Async Sub LoadData()
        'dataObject
        Dim listView = Await _repository.GetList
        GridControl1.DataSource = listView
    End Sub

    Public Async Sub Destroy(id As Long)
        Dim hasil = Await _repository.delete(id)
        If hasil Then
            LoadData()
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'Dim frm = New frmAddPegawai
        'frm.Show()
        Using frm As New frmAddPegawai
            If frm.ShowDialog = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick

        Using frm As New frmAddPegawai
            frm.edit(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid))
            If frm.ShowDialog = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        'delete
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            ' Code to execute if OK is clicked
            Destroy(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid))
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Close()
    End Sub
End Class