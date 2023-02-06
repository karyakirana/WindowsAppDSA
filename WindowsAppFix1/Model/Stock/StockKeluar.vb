Public Class StockKeluar

	Public Property id As Long
	Public Property active_cash As String
	Public Property stockable_masuk_id As Long?
	Public Property stockable_masuk_type As String
	Public Property kode As String
	Public Property draft As Byte
	Public Property kondisi As String
	Public Property status As String
	Public Property surat_jalan As String
	Public Property tgl_masuk As String
	Public Property lokasi_id As Long
	Public Property supplier_id As Long?
	Public Property customer_id As Long?
	Public Property user_id As Long
	Public Property total_barang As Integer
	Public Property total_hpp As Integer
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String
	Public Property deleted_at As String

	Public Property lokasi As Lokasi
	Public Property supplier As Supplier
	Public Property customer As Customer
	Public Property stock_keluar_detail As List(Of StockKeluarDetail)

End Class

Public Class StockKeluarDetail

	Public Property id As Long
	Public Property stock_keluar_id As Long
	Public Property persediaan_id As Long
	Public Property harga_beli As Integer
	Public Property jumlah As Integer
	Public Property sub_total As Integer
	Public Property created_at As String
	Public Property updated_at As String

	Public Property persediaan As Persediaan

End Class