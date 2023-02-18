Public Class Akun
	Public Property id As Long
	Public Property akun_id As Long
	Public Property akun_tipe_id As Long
	Public Property kode As String
	Public Property nama As String
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String

	Public Property akun_tipe As AkunTipe
End Class

Public Class AkunKategori
	Public Property id As Long
	Public Property akun_kategori_id As Long
	Public Property kode As String
	Public Property nama As String
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String
End Class

Public Class AkunTipe
	Public Property id As Long
	Public Property akun_tipe_id As Long
	Public Property akun_kategori_id As Long
	Public Property kode As String
	Public Property nama As String
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String

	Public Property akun_kategori As AkunKategori
End Class