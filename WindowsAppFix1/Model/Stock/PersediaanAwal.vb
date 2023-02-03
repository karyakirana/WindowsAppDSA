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
	Public Property persediaan_awal_input_detail As List(Of Object)
	Public Property persediaan_awal_detail As List(Of PersediaanAwalDetail)
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

	Public Property persediaan As Persediaan
End Class