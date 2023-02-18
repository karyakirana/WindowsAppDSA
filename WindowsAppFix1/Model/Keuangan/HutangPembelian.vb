Public Class HutangPembelian
	Public Property id As Long
	Public Property hutang_pembelian_id As Long
	Public Property saldo_hutang_id As Long
	Public Property hutangable_pembelian_id As Long
	Public Property hutangable_pembelian_type As String
	Public Property status As String
	Public Property tgl_hutang As String
	Public Property tgl_pelunasan As String
	Public Property kurang_bayar As Long
	Public Property keterangan As String
	Public Property created_at As String
	Public Property updated_at As String

	Public Property saldo_hutang As SaldoHutangPembelian
End Class

Public Class SaldoHutangPembelian
	Public Property supplier_id As Long
	Public Property saldo As Long
	Public Property created_at As String
	Public Property updated_at As String

	Public Property supplier As Supplier

End Class