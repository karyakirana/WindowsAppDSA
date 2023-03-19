Public Class Penjualan
	Public Property id As Long
	Public Property penjualan_id As Long
	Public Property active_cash As String
	Public Property kode As String
	Public Property penjualan_penawaran_id As Long
	Public Property draft As Byte
	Public Property status As String
	Public Property tipe_penjualan As String
	Public Property tgl_penjualan As String
	Public Property tempo As Integer
	Public Property tgl_tempo As String
	Public Property customer_id As Long
	Public Property sales_id As Long
	Public Property user_id As Long
	Public Property total_barang As Integer
	Public Property ppn As Integer
	Public Property biaya_lain As Integer
	Public Property total_bayar As Integer
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String
	Public Property deleted_at As String

	Public Property customer As Customer
	Public Property sales As Pegawai
	Public Property users As Users
	Public Property penjualan_detail As List(Of PenjualanDetail)
	Public Property penjualan_detail_store As List(Of PenjualanDetailStore)

End Class

Public Class PenjualanDetail
	Public Property id As Long
	Public Property penjualan_id As Long
	Public Property persediaan_id As Long
	Public Property produk_id As Long?
	Public Property harga_jual As Integer
	Public Property jumlah As Integer
	Public Property satuan_jual As String
	Public Property diskon As Integer
	Public Property sub_total As Integer
	Public Property created_at As String
	Public Property updated_at As String

	Public Property persediaan As Persediaan
End Class

Public Class PenjualanDetailStore
	Public Property persediaan_id As Long
	Public Property jumlah As Long
	Public Property diskon As Integer
	Public Property batch As String
	Public Property expired As String
	Public Property serial_number As String
	Public Property satuan_jual As String
	Public Property harga_jual As Long
	Public Property sub_total As Long
End Class