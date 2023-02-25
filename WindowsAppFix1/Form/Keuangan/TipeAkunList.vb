﻿Public Class TipeAkunList

    Public _repositoryAkunTipe = New AkunTipeRepository
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Using frm As New frmAddTipeAkun
            If frm.ShowDialog = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    Public Async Sub LoadData()
        'dataObject
        Dim listView = Await _repositoryAkunTipe.GetList()
        AkunTipeGridControl.DataSource = listView

    End Sub

    Public Async Sub destroy(ByVal id As Long)
        Dim hasil = Await _repositoryAkunTipe.delete(id)
        If hasil Then
            LoadData()
        End If
    End Sub

    Private Sub TipeAkunList_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Using frm As New frmAddTipeAkun
            frm.Edit(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid))
            If frm.ShowDialog = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            ' Code to execute if OK is clicked
            destroy(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid))
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Close()
    End Sub
End Class