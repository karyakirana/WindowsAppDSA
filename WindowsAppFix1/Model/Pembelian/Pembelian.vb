Public Class Pembelian
	Public Property id As Long
	Public Property pembelian_id As Long
	Public Property active_cash As String
	Public Property pembelian_po_id As Long
	Public Property kode As String
	Public Property draft As Byte
	Public Property status As String
	Public Property tipe_pembelian As String
	Public Property tgl_pembelian As String
	Public Property tempo As Integer
	Public Property tgl_tempo As String
	Public Property supplier_id As Long
	Public Property user_id As Long
	Public Property total_barang As Integer
	Public Property ppn As Integer
	Public Property biaya_lain As Integer
	Public Property total_bayar As Integer
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String
	Public Property deleted_at As String

	Public Property pembelian_detail As List(Of PembelianDetail)
	Public Property pembelian_detail_store As List(Of PembelianDetailStore)
	Public Property supplier As SupplierRepository
	Public Property users As Users
End Class

Public Class PembelianDetail
	Public Property id As Long
	Public Property pembelian_id As Long
	Public Property produk_id As Long
	Public Property batch As String
	Public Property serial_number As String
	Public Property expired As String
	Public Property harga_beli As Long
	Public Property jumlah As Integer
	Public Property diskon As Integer
	Public Property sub_total As Integer
	Public Property created_at As String
	Public Property updated_at As String

	Public Property produk As Produk
End Class

Public Class PembelianDetailStore
	Public Property produk_id As Long
	Public Property jumlah As Long
	Public Property diskon As Integer
	Public Property batch As String
	Public Property expired As String
	Public Property serial_number As String
	Public Property harga_beli As Long
	Public Property sub_total As Long
End Class