Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class RepositoryWithBearer
    Public _client As HttpClient
    Public _response As HttpResponseMessage
    Public _jObject As JObject
    Protected _getUrl As String

    Public Sub New()
        _client = New HttpClient With {
            .BaseAddress = New Uri(BaseURl)
        }
        _client.DefaultRequestHeaders.Add("Accept", "application/json")
        TokenCheck()
        _client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Bearer", Token)
    End Sub

    Public Async Function GetData() As Task(Of JObject)
        _response = Await _client.GetAsync(_getUrl)

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            Dim _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString, New JsonSerializerSettings With {
                    .MissingMemberHandling = MissingMemberHandling.Ignore
            })
            'Console.WriteLine(_jObject)
            If _jObject("data").ToString = "{}" Then
                Return Nothing
            End If

            Return _jObject
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return Nothing
        End If

        Return Nothing

    End Function

    Public Overridable Async Function GetById(ByVal id As Long) As Task(Of Object)

        _response = Await _client.GetAsync(_getUrl & "/" & id)

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            Return JsonConvert.DeserializeObject(Of JObject)(jsonString)
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return Nothing
        End If

        Return Nothing

    End Function

    Public Async Function Create(_object As Object) As Task(Of Boolean)

        Dim json = JsonConvert.SerializeObject(_object)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PostAsync(_getUrl, content)

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            Return True
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return False
        End If

        Return False

    End Function

    Public Async Function Update(_object As Object) As Task(Of Boolean)

        Dim json = JsonConvert.SerializeObject(_object)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PutAsync(_getUrl, content)

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            Return True
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return False
        End If

        Return False

    End Function

    Public Async Function delete(ByVal id As Long) As Task(Of Boolean)

        _response = Await _client.DeleteAsync(_getUrl & "/" & id)

        If _response.IsSuccessStatusCode Then
            Return True
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return False
        End If

        Return False

    End Function

End Class
