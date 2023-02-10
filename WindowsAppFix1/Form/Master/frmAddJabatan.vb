Public Class frmAddJabatan
    Private _jabatanRepo As JabatanRepository = New JabatanRepository()
    Private _jabatanId As Long?
    Private _update As Boolean = False

    Private Async Sub store()

        Dim jabatan As Jabatan = New Jabatan With {
            .nama = CStr(txtNama.EditValue),
            .keterangan = CStr(txtKeterangan.EditValue)
        }

        Dim hasil = Await _jabatanRepo.Store(jabatan)

        If hasil Then
            'form close
            Me.Close()
            refreshJabatanList()
        End If

    End Sub

    Private Async Sub put()
        Dim jabatan As Jabatan = New Jabatan With {
            .jabatan_id = _jabatanId,
            .nama = CStr(txtNama.EditValue),
            .keterangan = CStr(txtKeterangan.EditValue)
        }

        Dim hasil = Await _jabatanRepo.Update(jabatan)

        If hasil Then
            'form close
            Close()
            refreshJabatanList()
        End If
    End Sub

    Public Async Sub edit(ByVal id As Long)
        Dim getData As Jabatan = Await _jabatanRepo.Edit(id)

        If Not getData Is Nothing Then
            Dim jabatan As Jabatan = getData
            _jabatanId = jabatan.id
            txtNama.EditValue = jabatan.nama
            txtKeterangan.EditValue = jabatan.keterangan
            _update = True
        End If
    End Sub

    Private Sub refreshJabatanList()
        'form jabatan list reload
        Dim form As FormJabatanList = CType(Application.OpenForms("FormJabatanList"), FormJabatanList)
        form.LoadData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If _update Then
            put()
        Else
            store()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class