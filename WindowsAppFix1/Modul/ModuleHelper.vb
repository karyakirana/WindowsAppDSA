Imports System.Net
Imports System.Net.Http
Imports DevExpress.XtraBars.Ribbon
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module ModuleHelper

#Region "httpclient"

#End Region

#Region "exception by status code"

    Public Sub ResponseException(StatusCode As HttpStatusCode, response As Object)
        Dim resultObject = JsonConvert.DeserializeObject(Of JObject)(response)
        Dim validationMessage As String = resultObject("message").ToString
        MsgBox(validationMessage, MsgBoxStyle.Critical, "Status Code " & CStr(StatusCode.ToString))
    End Sub

#End Region

#Region "dialog box delete"



#End Region

End Module
