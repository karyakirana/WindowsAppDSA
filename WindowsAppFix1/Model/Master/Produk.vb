Public Class Produk
	Public Property id As Long
	Public Property produk_kategori_id As Long
	Public Property kode As String
	Public Property status As String
	Public Property nama As String
	Public Property tipe As String
	Public Property merk As String
	Public Property satuan_jual As String
	Public Property harga As Integer
	Public Property max_diskon As Short?
	Public Property buffer_stock As Integer?
	Public Property minimum_stock As Integer?
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String
	Public Property deleted_at As String

	Public Property produk_image As ProdukImage
	Public Property produk_kategori As ProdukKategori
	Public Property produk_kemasan_beli As ProdukKemasanBeli
End Class

Public Class ProdukKategori
	Public Property id As Long
	Public Property kode As String
	Public Property nama As String
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String
End Class

Public Class ProdukImage
	Public Property id As Long
	Public Property produk_id As Long
	Public Property deskripsi As String
	Public Property url As String
	Public Property created_at As String
	Public Property updated_at As String
End Class

Public Class ProdukKemasanBeli
	Public Property id As Long
	Public Property produk_id As Long
	Public Property satuan_beli As String
	Public Property isi As Short
	Public Property created_at As String
	Public Property updated_at As String
End Class