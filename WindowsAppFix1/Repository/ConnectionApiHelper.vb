Imports System.Net.Http
Imports System.Text
Imports Newtonsoft
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ConnectionApiHelper

    'Shared ReadOnly _httpClient As New HttpClient
    Public Shared Function PostRequest(_object As Object, url As String) As Boolean

        Dim _response As HttpResponseMessage

        Using _client As New HttpClient

            _client.BaseAddress = New Uri(BaseURl)
            _client.DefaultRequestHeaders.Add("Accept", "application/json")
            TokenCheck()
            _client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Bearer", Token)

            Dim _json = JsonConvert.SerializeObject(_object)
            Dim _content = New StringContent(_json, Encoding.UTF8, "application/json")
            _response = _client.PostAsync(url, _content).Result
            Dim jsonString As String = _response.Content.ReadAsStringAsync().Result

            If _response.IsSuccessStatusCode Then
                _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
                'set token
                Token = _jObject("token")
                Return True
            End If

            If Not _response.IsSuccessStatusCode Then
                ResponseException(_response.StatusCode, _response.Content.ReadAsStringAsync())
                Return False
            End If

            Return False

        End Using

    End Function

End Class
