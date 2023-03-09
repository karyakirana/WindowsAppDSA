Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI

Public Class FormPersediaanAwalList

    Private _persediaanAwalRepo As PersediaanAwalRepo = New PersediaanAwalRepo()
    Dim rpt As New rptPersediaan_Awal

    Private Sub FormPersediaanAwalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Public Async Sub LoadData()
        Dim listView = Await _persediaanAwalRepo.GetList()
        GridControl1.DataSource = listView
        rpt.DataSource = listView
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm = New frmAddPersediaanAwal
        frm.Show()
        purpose = "NEW"
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        'Using frm As New frmAddPersediaanAwal
        '    'load edit
        '    If frm.DialogResult = DialogResult.OK Then
        '        MsgBox("data berhasil diupdate")
        '        LoadData()
        '    End If
        'End Using
        purpose = "EDIT"
        Dim frm As New frmAddPersediaanAwal
        'edit
        frm.Show()
        frm.Edit(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid))
        frm.XtraTabPage2.Text = "Form Edit Data Persediaan Awal"

    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Close()
    End Sub

    Private Sub barBtnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnPrint.ItemClick

        If ckGlobal.Checked Then
        Else
            Dim printTool As New ReportPrintTool(rpt)

            printTool.ShowPreview()
        End If

    End Sub

    Public Async Sub destroy(ByVal id As Long)
        Dim hasil = Await _persediaanAwalRepo.delete(id)
        If hasil Then
            LoadData()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            ' Code to execute if OK is clicked
            destroy(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colid))
        End If
    End Sub
End Class