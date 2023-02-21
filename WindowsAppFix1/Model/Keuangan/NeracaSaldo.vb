Public Class NeracaSaldo
	Public Property id As Long
	Public Property active_cash As String
	Public Property akun_id As Long
	Public Property debet As Long?
	Public Property kredit As Long?
	Public Property created_at As String
	Public Property updated_at As String

	Public Property akun As Akun

End Class

Public Class NeracaSaldoAwal
	Public Property id As Long
	Public Property active_cash As String
	Public Property akun_id As Long
	Public Property debet As Long?
	Public Property kredit As Long?
	Public Property created_at As String
	Public Property updated_at As String

	Public Property akun As Akun
End Class