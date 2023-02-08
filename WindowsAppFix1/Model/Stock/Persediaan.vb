Public Class Persediaan
	Public Property id As Long
	Public Property active_cash As String
	Public Property produk_id As Long
	Public Property lokasi_id As Long
	Public Property kondisi As String
	Public Property batch As String
	Public Property serial_number As String
	Public Property expired As String
	Public Property harga_beli As Integer
	Public Property stock_awal As Integer?
	Public Property stock_masuk As Integer?
	Public Property stock_keluar As Integer?
	Public Property stock_lost As Integer?
	Public Property stock_saldo As Integer?
	Public Property created_at As String
	Public Property updated_at As String

	Public Property produk As Produk
	Public Property lokasi As Lokasi
End Class
