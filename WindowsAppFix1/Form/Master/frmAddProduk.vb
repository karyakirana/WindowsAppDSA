Imports DevExpress.Utils

Public Class frmAddProduk

    Public _produkRepo As New ProdukRepository
    Public _produkKategoriRepo As New ProdukKategoriRepository
    Private _update As Boolean = False
    Public _id As Long?
    Public dtKemasan As New DataTable
    Public dtImage As New DataTable

    Private Async Sub Store()

        Dim produk As New Produk With {
            .produk_kategori_id = cbKategori.EditValue,
            .nama = txtNama.EditValue,
            .tipe = txtTipe.EditValue,
            .merk = txtMerk.EditValue,
            .satuan_jual = txtSatuan.EditValue,
            .harga = txtHarga.EditValue,
            .max_diskon = txtDiskon.EditValue,
            .buffer_stock = txtBufferStock.EditValue,
            .minimum_stock = txtMinStock.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        'list image
        Dim produk_image_list As New List(Of ProdukImage)
        For i As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRowView = GridView1.GetRow(i)
            If row IsNot Nothing Then
                Dim produk_image As New ProdukImage With {
                    .deskripsi = GridView1.GetRowCellValue(i, "deskripsi"),
                    .url = GridView1.GetRowCellValue(i, "url")
                }
                produk_image_list.Add(produk_image)
            End If
        Next

        'list satuan beli
        Dim produk_kemasan_list As New List(Of ProdukKemasanBeli)
        For i As Integer = 0 To GridView2.RowCount - 1
            Dim row As DataRowView = GridView2.GetRow(i)
            If row IsNot Nothing Then
                Dim produk_kemasan As New ProdukKemasanBeli With {
                    .satuan_beli = GridView2.GetRowCellValue(i, "satuan_beli"),
                    .isi = GridView2.GetRowCellValue(i, "isi")
                }
                produk_kemasan_list.Add(produk_kemasan)
            End If
        Next

        If produk_image_list IsNot Nothing Then
            produk.produk_image = produk_image_list
        End If

        If produk_kemasan_list IsNot Nothing Then
            produk.produk_kemasan_beli = produk_kemasan_list
        End If

        Dim hasil = Await _produkRepo.Store(produk)
        If hasil Then
            'form close
            DialogResult = DialogResult.OK
            Close()
        End If

    End Sub

    Public Async Sub Edit(id As Long)

        Dim produk As Produk = Await _produkRepo.Edit(id)

        If Not produk Is Nothing Then

            'load produk
            _id = produk.id
            cbKategori.EditValue = produk.produk_kategori_id
            txtNama.EditValue = produk.nama
            txtTipe.EditValue = produk.tipe
            txtMerk.EditValue = produk.merk
            txtSatuan.EditValue = produk.satuan_jual
            txtHarga.EditValue = produk.harga
            txtDiskon.EditValue = produk.max_diskon
            txtBufferStock.EditValue = produk.buffer_stock
            txtMinStock.EditValue = produk.minimum_stock
            txtKeterangan.EditValue = produk.keterangan

            'list image
            'list kemasan 

        End If

    End Sub

    Private Async Sub Put()

        Dim produk As New Produk With {
            .produk_kategori_id = cbKategori.EditValue,
            .nama = txtNama.EditValue,
            .tipe = txtTipe.EditValue,
            .merk = txtMerk.EditValue,
            .satuan_jual = txtSatuan.EditValue,
            .harga = txtHarga.EditValue,
            .max_diskon = txtDiskon.EditValue,
            .buffer_stock = txtBufferStock.EditValue,
            .minimum_stock = txtMinStock.EditValue,
            .keterangan = txtKeterangan.EditValue
        }

        'list image
        Dim produk_image_list As New List(Of ProdukImage)
        For i As Integer = 0 To GridView1.RowCount - 1
            Dim row As DataRowView = GridView1.GetRow(i)
            If row IsNot Nothing Then
                Dim produk_image As New ProdukImage With {
                    .deskripsi = GridView1.GetRowCellValue(i, "deskripsi"),
                    .url = GridView1.GetRowCellValue(i, "url")
                }
                produk_image_list.Add(produk_image)
            End If
        Next

        'list satuan beli
        Dim produk_kemasan_list As New List(Of ProdukKemasanBeli)
        For i As Integer = 0 To GridView2.RowCount - 1
            Dim row As DataRowView = GridView2.GetRow(i)
            If row IsNot Nothing Then
                Dim produk_kemasan As New ProdukKemasanBeli With {
                    .satuan_beli = GridView2.GetRowCellValue(i, "satuan_beli"),
                    .isi = GridView2.GetRowCellValue(i, "isi")
                }
                produk_kemasan_list.Add(produk_kemasan)
            End If
        Next

        If produk_image_list IsNot Nothing Then
            produk.produk_image = produk_image_list
        End If

        If produk_kemasan_list IsNot Nothing Then
            produk.produk_kemasan_beli = produk_kemasan_list
        End If

        Dim hasil = Await _produkRepo.Store(produk)
        If hasil Then
            'form close
            DialogResult = DialogResult.OK
            Close()
        End If

    End Sub

    Private Async Sub storeKategori()
        Dim produk_kategori As New ProdukKategori With {
            .nama = txtKategori.EditValue,
            .keterangan = txtKeteranganKategori.EditValue
        }

        Dim hasil = Await _produkKategoriRepo.Store(produk_kategori)
        If hasil Then
            txtKategori.EditValue = ""
            txtKeteranganKategori.EditValue = ""
            MsgBox("Data Kategori Disimpan")
        End If
    End Sub

    Private Sub setDataTableKemasan()
        dtKemasan.Columns.Add("satuan_beli", GetType(String))
        dtKemasan.Columns.Add("isi", GetType(Integer))
        GridKemasan.DataSource = dtKemasan
    End Sub

    Private Sub setDataTableImage()
        dtImage.Columns.Add("deskripsi", GetType(String))
        dtImage.Columns.Add("url", GetType(String))
        GridImage.DataSource = dtImage
    End Sub

    Public Sub addKemasanRow()
        Dim row As DataRow = dtKemasan.NewRow
        row("satuan_beli") = ""
        row("isi") = 0
        dtKemasan.Rows.Add(row)
        GridKemasan.DataSource = dtKemasan
    End Sub

    Public Sub addImageRow()
        Dim row As DataRow = dtImage.NewRow
        row("deskripsi") = ""
        row("url") = 0
        dtKemasan.Rows.Add(row)
        GridKemasan.DataSource = dtImage
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class