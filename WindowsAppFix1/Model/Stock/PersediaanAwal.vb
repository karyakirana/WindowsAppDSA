Public Class PersediaanAwal
	Public Property id As Long
	Public Property active_cash As String
	Public Property kode As String
	Public Property draft As Byte
	Public Property kondisi As String
	Public Property lokasi_id As Long
	Public Property tgl_persediaan_awal As String
	Public Property user_id As Long
	Public Property total_barang As Integer
	Public Property total_nominal As Integer
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String
	Public Property deleted_at As String

	Public Property lokasi As Lokasi
	Public Property users As Users
	Public Property persediaan_awal_detail As List(Of PersediaanAwalDetail)
	Public Property persediaan_awal_detail_store As List(Of PersediaanAwalDetailStore)
End Class

Public Class PersediaanAwalDetail
	Public Property id As Long
	Public Property persediaan_awal_id As Long
	Public Property persediaan_id As Long
	Public Property harga_beli As Integer
	Public Property jumlah As Integer
	Public Property sub_total As Integer
	Public Property created_at As String
	Public Property updated_at As String

	'for manipulation
	Public Property produk_id As Long?
	Public Property batch As Long
	Public Property expired As String
	Public Property serial_number As String

	Public Property persediaan As Persediaan
End Class

Public Class PersediaanAwalDetailStore
	Public Property produk_id As Long
	Public Property jumlah As Long
	Public Property batch As String
	Public Property expired As String
	Public Property serial_number As String
	Public Property harga As Long
	Public Property sub_total As Long
End Class