Imports Newtonsoft.Json.Linq

Public Class AkunKategoriRepository
    Inherits RepositoryWithBearer

    Public Sub New()
        MyBase.New()
        _getUrl = "akun/kategori"
    End Sub

    Public Async Function GetList() As Task(Of List(Of AkunKategori))

        Dim hasil As JObject = Await GetData()

        If hasil Is Nothing Then
            Return Nothing
        End If

        Return hasil("data").ToObject(Of List(Of AkunKategori))

    End Function

    Public Async Function Edit(ByVal id As Long) As Task(Of AkunKategori)

        Dim hasil As JObject = Await MyBase.GetById(id)

        If hasil Is Nothing Then
            Return Nothing
        End If

        Return hasil.ToObject(Of AkunKategori)

    End Function

    Public Async Function Store(_object As AkunKategori) As Task(Of Boolean)
        Return Await Create(_object)
    End Function
End Class
