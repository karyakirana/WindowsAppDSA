
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class CustomerRepository
    Inherits RepositoryWithBearer

    Public Sub New()
        MyBase.New()
        _getUrl = "master/customer"
    End Sub

    Public Async Function GetList() As Task(Of List(Of Customer))

        Dim hasil As JObject = Await GetData()

        If hasil Is Nothing Then
            Return Nothing
        End If

        Return hasil("data").ToObject(Of List(Of Customer))

    End Function

    Public Async Function Edit(ByVal id As Long) As Task(Of Customer)

        Dim hasil As JObject = Await MyBase.GetById(id)

        If hasil Is Nothing Then
            Return Nothing
        End If

        Return hasil("data").ToObject(Of Customer)

    End Function

    Public Async Function Store(_object As Customer) As Task(Of Boolean)
        Return Await Create(_object)
    End Function

End Class
