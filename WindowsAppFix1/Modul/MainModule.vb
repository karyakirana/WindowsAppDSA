Imports System.Net.Http
Imports System.Text
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module MainModule

#Region "Global Variable"
    ' Every process using global variable

    Public Token As String
    Public BaseURl As String = "http://erpbsa.test/api/"
    Public _client As HttpClient
    Public _response As HttpResponseMessage
    Public _jObject As JObject

    Public Sub TokenCheck()
        If Token Is Nothing Then
            MainForm.Show()
        End If
    End Sub

#End Region

#Region "ui main menu helper"

    Public manager As New DocumentManager()

    Public Sub addDocumentManager()
        manager.View = New TabbedView()
    End Sub

    Public Sub easyAccess(parent As MainForm, ctcode As String)

        Select Case ctcode

            Case "P001"
                addDocumentManager()
                Dim form As New FormJabatanList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Master Data Jabatan"
                    .Show()
                End With

            Case "P002"
                addDocumentManager()
                Dim form As New FormPegawaiList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Master Data Pegawai"
                    .Show()
                End With

        End Select

    End Sub

    Public Sub initialNew()
        _client = New HttpClient With {
          .BaseAddress = New Uri(BaseURl)
      }
        _client.DefaultRequestHeaders.Add("Accept", "application/json")
        TokenCheck()
        _client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Bearer", Token)
    End Sub

    Public Async Function GetPublicList(ByVal url As String) As Task(Of List(Of Object))
        _response = Await _client.GetAsync("master/jabatan")

        If _response.IsSuccessStatusCode Then
            Dim jsonString As String = Await _response.Content.ReadAsStringAsync
            _jObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
            Return _jObject("data").ToObject(Of List(Of Object))
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return Nothing
        End If

        Return Nothing

    End Function

    Public Async Function PublicStore(ByVal url As String, ByVal customer As Object) As Task(Of Boolean)

        Dim json = JsonConvert.SerializeObject(customer)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PostAsync(url, content)

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

    Public Async Function PublicEdit(ByVal url As String, ByVal id As Long) As Task(Of Customer)

        _response = Await _client.GetAsync(url & id)

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

    Public Async Function PublicUpdate(ByVal url As String, ByVal customer As Object) As Task(Of Boolean)

        Dim json = JsonConvert.SerializeObject(customer)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        _response = Await _client.PutAsync(url, content)

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

    Public Async Function PublicDelete(ByVal url As String, ByVal id As Long) As Task(Of Boolean)

        _response = Await _client.DeleteAsync(url & id)

        If _response.IsSuccessStatusCode Then
            Return True
        End If

        If Not _response.IsSuccessStatusCode Then
            ResponseException(_response.StatusCode, Await _response.Content.ReadAsStringAsync)
            Return False
        End If

        Return False

    End Function

#End Region

End Module
