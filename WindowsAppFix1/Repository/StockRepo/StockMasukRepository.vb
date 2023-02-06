Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net.Http

Public Class StockMasukRepository

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

    Public Async Function GetList() As Task(Of List(Of StockMasuk))
        _response = Await _client.GetAsync("persediaan/masuk")

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            Return _jObject("data").ToObject(Of List(Of StockMasuk))
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return Nothing
        End If

        Return Nothing

    End Function

End Class
