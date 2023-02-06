Imports System.Dynamic
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class LoginRepository

    Public _client As HttpClient
    Public _response As HttpResponseMessage
    Public _jObject As JObject

    Private _username As String
    Private _password As String

    Public Sub New()
        _client = New HttpClient With {
            .BaseAddress = New Uri(BaseURl)
        }
        _client.DefaultRequestHeaders.Add("Accept", "application/json")
    End Sub

    Public Async Function Login(loginClass As LoginClass) As Task(Of Boolean)
        'serialize
        Dim json As String = JsonConvert.SerializeObject(loginClass)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PostAsync("login", content)

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            'set token
            Token = _jObject("token")
            Return True
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return False
        End If

        Return False
    End Function

End Class
