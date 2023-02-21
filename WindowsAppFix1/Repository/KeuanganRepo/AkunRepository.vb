Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class AkunRepository
    Inherits RepositoryWithBearer

    Public Sub New()
        MyBase.New()
        _getUrl = "akun"
    End Sub

    Public Async Function GetList() As Task(Of List(Of Akun))

        Dim hasil As JObject = Await GetData()

        If hasil Is Nothing Then
            Return Nothing
        End If

        Return hasil("data").ToObject(Of List(Of Akun))

    End Function

    Public Async Function Edit(ByVal id As Long) As Task(Of Akun)

        Dim hasil As JObject = Await MyBase.GetById(id)

        If hasil Is Nothing Then
            Return Nothing
        End If

        Return hasil.ToObject(Of Akun)

    End Function

    Public Async Function Store(_object As Akun) As Task(Of Boolean)
        Return Await Create(_object)
    End Function

End Class
