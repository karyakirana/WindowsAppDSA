Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Text

Public Class CustomerRepository

    Public Sub New()
        initialNew()
    End Sub

    Public Async Function GetList() As Task(Of List(Of Customer))
        _response = Await _client.GetAsync("master/jabatan")

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            Return _jObject("data").ToObject(Of List(Of Customer))
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return Nothing
        End If

        Return Nothing

    End Function

    Public Async Function Store(customer As Customer) As Task(Of Boolean)

        Dim json = JsonConvert.SerializeObject(customer)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PostAsync("master/customer", content)

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

    Public Async Function Edit(ByVal id As Long) As Task(Of Customer)

        _response = Await _client.GetAsync("master/customer/" & id)

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            Return _jObject("data").ToObject(Of Customer)
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return Nothing
        End If

        Return Nothing

    End Function

    Public Async Function Update(customer As Customer) As Task(Of Boolean)

        Dim json = JsonConvert.SerializeObject(customer)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PutAsync("master/customer", content)

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

    Public Async Function delete(ByVal id As Long) As Task(Of Boolean)

        _response = Await _client.DeleteAsync("master/customer/" & id)

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
