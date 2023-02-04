Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module ModuleHelper

#Region "exception by status code"

    Public Sub ResponseException(response As HttpResponseMessage)
        Dim StatusCode As HttpStatusCode = response.StatusCode
        Dim resultObject = JsonConvert.DeserializeObject(Of JObject)(response.Content.ToString)
        If StatusCode = 422 Then
            'exception failed

        End If
    End Sub

#End Region

End Module
