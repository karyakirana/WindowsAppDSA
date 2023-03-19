Imports DevExpress.XtraGrid

Public Class FrmFindPersediaan
    Dim _repositoryPersediaan As New PersediaanRepo
    Public Function GetValue() As Long
        Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid)
    End Function

    Private Async Sub LoadData()
        'dataObject
        Dim listView = Await _repositoryPersediaan.GetList
        PersediaanGridControl.DataSource = listView
    End Sub

    Private Sub FrmFindPersediaan_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub PersediaanGridControl_DoubleClick(sender As Object, e As EventArgs) Handles PersediaanGridControl.DoubleClick
        DialogResult = DialogResult.OK
    End Sub

    'Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles PersediaanGridControl.DoubleClick
    '    'Dim id = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid)
    '    'frmAddPersediaanAwal.setRow(id)
    '    'Close()
    '    DialogResult = DialogResult.OK
    'End Sub
End Class