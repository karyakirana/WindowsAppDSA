﻿Public Class Customer
	Public Property id As Long
	Public Property customer_id As Long
	Public Property kode As String
	Public Property jenis_instansi As String
	Public Property nama As String
	Public Property telepon As String
	Public Property email As String
	Public Property npwp As String
	Public Property alamat As String
	Public Property kota_id As String
	Public Property sales_id As Long
	Public Property diskon As Short?
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String
	Public Property deleted_at As String

	Public Property sales As Pegawai
	Public Property kota As Kota
End Class
