﻿Public Class Supplier
	Public Property id As Long
	Public Property supplier_id As Long
	Public Property kode As String
	Public Property nama As String
	Public Property telepon As String
	Public Property email As String
	Public Property npwp As String
	Public Property alamat As String
	Public Property kota_id As String
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String
	Public Property deleted_at As String

	Public Property kota As Kota

End Class
