Imports Newtonsoft.Json.Linq

Public Class AkunTipeRepository
    Inherits RepositoryWithBearer

    Public Sub New()
        MyBase.New()
        _getUrl = "akun/tipe"
    End Sub

    Public Async Function GetList() As Task(Of List(Of AkunTipe))

        Dim hasil As JObject = Await GetData()

        If hasil Is Nothing Then
            Return Nothing
        End If

        Return hasil("data").ToObject(Of List(Of AkunTipe))

    End Function

    Public Async Function Edit(ByVal id As Long) As Task(Of AkunTipe)

        Dim hasil As JObject = Await MyBase.GetById(id)

        If hasil Is Nothing Then
            Return Nothing
        End If

        Return hasil.ToObject(Of AkunTipe)

    End Function

    Public Async Function Store(_object As AkunTipe) As Task(Of Boolean)
        Return Await Create(_object)
    End Function

End Class
