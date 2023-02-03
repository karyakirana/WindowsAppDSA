Public Class Users
	Public Property id As Long
	Public Property pegawai_id As Long?
	Public Property username As String
	Public Property role As String
	Public Property name As String
	Public Property email As String
	Public Property email_verified_at As String
	Public Property password As String
	Public Property remember_token As String
	Public Property created_at As String
	Public Property updated_at As String

	Public Property pegawai As Pegawai
End Class
