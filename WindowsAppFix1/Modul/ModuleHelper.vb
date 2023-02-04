Imports System.Net
Imports System.Net.Http
Imports DevExpress.XtraBars.Ribbon
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module ModuleHelper

#Region "exception by status code"

    Public Sub ResponseException(response As HttpResponseMessage)
        Dim StatusCode As HttpStatusCode = response.StatusCode
        Dim resultObject = JsonConvert.DeserializeObject(Of JObject)(response.Content.ToString)
        Dim validationMessage As String = resultObject("message").ToString
        MsgBox(validationMessage, "Status Code " + StatusCode)
    End Sub

#End Region

End Module
