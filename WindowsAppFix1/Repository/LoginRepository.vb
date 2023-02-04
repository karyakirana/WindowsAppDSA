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
        _client = New HttpClient()
        _client.BaseAddress = New Uri(BaseURl)
        _client.DefaultRequestHeaders.Accept.Add(
            New Headers.MediaTypeHeaderValue("application/json")
        )
    End Sub

    Public Async Sub Login(email As String, password As String)
        Dim objectLogin As Object = New ExpandoObject()
        objectLogin.username = email
        objectLogin.password = password
        'serialize
        Dim json As String = JsonConvert.SerializeObject(objectLogin)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PostAsync("login", content)

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            'set token
            Token = _jObject("token")
            'call main menu
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response)
        End If

    End Sub

End Class
