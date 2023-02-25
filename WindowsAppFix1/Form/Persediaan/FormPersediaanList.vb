﻿Public Class FormPersediaanList

    Public _persediaanRepo As PersediaanRepo = New PersediaanRepo()

    Private Sub FormPersediaanList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Async Sub LoadData()
        Dim listData = Await _persediaanRepo.GetList()
        GridControl1.DataSource = listData
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Close()
    End Sub
End Class