Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Text

Public Class PersediaanAwalRepo
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

    Public Async Function GetList() As Task(Of List(Of PersediaanAwal))
        _response = Await _client.GetAsync("persediaan/awal")

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            Return _jObject("data").ToObject(Of List(Of PersediaanAwal))
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return Nothing
        End If

        Return Nothing

    End Function

    Public Async Function Store(persediaanAwal As PersediaanAwal) As Task(Of Boolean)

        Dim json = JsonConvert.SerializeObject(persediaanAwal)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PostAsync("persediaan/awal", content)

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

    Public Async Function Edit(ByVal id As Long) As Task(Of PersediaanAwal)

        _response = Await _client.GetAsync("persediaan/awal/" & id)

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            Return _jObject("data").ToObject(Of PersediaanAwal)
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return Nothing
        End If

        Return Nothing

    End Function

    Public Async Function Update(persediaanAwal As PersediaanAwal) As Task(Of Boolean)

        Dim json = JsonConvert.SerializeObject(persediaanAwal)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PutAsync("persediaan/awal", content)

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

        _response = Await _client.DeleteAsync("persediaan/awal/" & id)

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
