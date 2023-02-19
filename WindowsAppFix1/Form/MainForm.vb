Imports DevExpress.XtraNavBar

Public Class MainForm
    'Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    '    LoginForm.Show()
    'End Sub


    'MASTER DATA
    Private Sub NavBarJabatan_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarJabatan.LinkClicked
        easyAccess(Me, "P001")
    End Sub

    Private Sub NavBarPegawai_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarPegawai.LinkClicked
        easyAccess(Me, "P002")
    End Sub

    Private Sub NavBarLokasi_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarLokasi.LinkClicked
        easyAccess(Me, "P003")
    End Sub

    Private Sub NavBarProduk_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarProduk.LinkClicked
        easyAccess(Me, "P004")
    End Sub
    Private Sub NavBarCustomer_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarCustomer.LinkClicked
        easyAccess(Me, "P005")
    End Sub

    Private Sub NavBarSupplier_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarSupplier.LinkClicked
        easyAccess(Me, "P006")
    End Sub


    'PERSEDIAAN DATA
    Private Sub NavBarPersediaan_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarPersediaan.LinkClicked
        easyAccess(Me, "P007")
    End Sub
    Private Sub NavBarPersediaanAwal_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarPersediaanAwal.LinkClicked
        easyAccess(Me, "P008")
    End Sub

    'PENJUALAN DATA
    Private Sub NavBarPenjualan_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarPenjualan.LinkClicked
        easyAccess(Me, "P010")
    End Sub
    Private Sub NavBarPOPenjualan_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarPOPenjualan.LinkClicked
        easyAccess(Me, "P009")
    End Sub

    'PEMBELIAN DATA
    Private Sub NavBarPembelian_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarPembelian.LinkClicked
        easyAccess(Me, "P012")
    End Sub
    Private Sub NavBarPOPembelian_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarPOPembelian.LinkClicked
        easyAccess(Me, "P011")
    End Sub

    'KEUANGAN
    Private Sub NavBarItemAkun_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemAkun.LinkClicked
        easyAccess(Me, "P013")
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.Show()
    End Sub

    Private Sub NavBarControl1_Click(sender As Object, e As EventArgs) Handles NavBarControl1.Click

    End Sub




End Class