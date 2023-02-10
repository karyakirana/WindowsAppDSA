Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Text

Public Class LokasiRepository
    Public _client As HttpClient
    Public _response As HttpResponseMessage
    Public _jObject As JObject

    Public Sub New()
        _client = New HttpClient With {
            .BaseAddress = New Uri(BaseURl)
        }
        _client.DefaultRequestHeaders.Add("Accept", "application/json")
        TokenCheck()
        _client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Bearer", Token)
    End Sub

    Public Async Function GetList() As Task(Of List(Of Lokasi))
        _response = Await _client.GetAsync("master/lokasi")

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            Return _jObject("data").ToObject(Of List(Of Lokasi))
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return Nothing
        End If

        Return Nothing

    End Function

    Public Async Function Store(lokasi As Lokasi) As Task(Of Boolean)

        Dim json = JsonConvert.SerializeObject(lokasi)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PostAsync("master/lokasi", content)

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

    Public Async Function Edit(ByVal id As Long) As Task(Of Lokasi)

        _response = Await _client.GetAsync("master/lokasi/" & id)

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            Return _jObject("data").ToObject(Of Lokasi)
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return Nothing
        End If

        Return Nothing

    End Function

    Public Async Function Update(lokasi As Lokasi) As Task(Of Boolean)

        Dim json = JsonConvert.SerializeObject(lokasi)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PutAsync("master/lokasi", content)

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

        _response = Await _client.DeleteAsync("master/lokasi/" & id)

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
