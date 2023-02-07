Imports DevExpress.XtraNavBar

Public Class MainForm
    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.Show()
    End Sub



    Private Sub BarItemPegawai_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles BarItemPegawai.LinkClicked
        easyAccess(Me, "P002")
    End Sub

    Private Sub BarItemJabatan_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles BarItemJabatan.LinkClicked
        easyAccess(Me, "P001")
    End Sub
End Class