Imports System.Net.Http
Imports System.Text
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module MainModule

#Region "Global Variable"
    ' Every process using global variable
    '
    '--IP VPS = http://103.157.97.253/api/
    '--> PC = http://192.168.18.65/erpbsa/public/api/
    '--> Laptop = http://192.168.0.108/erpbsa/public/api/

    '--> PC = http://192.168.0.11/erpbsa/public/api/


    Public Token As String
    Public BaseURl As String = "http://192.168.18.65/erpbsa/public/api/"
    Public _client As HttpClient
    Public _response As HttpResponseMessage
    Public _jObject As JObject
    Public purpose As String
    Public _Customer As New Customer
    Public _Pegawai As New Pegawai
    Public _Supplier As New Supplier
    Public totalBayar As Integer
    Public printID As Integer

    Public Sub TokenCheck()
        If Token Is Nothing Then
            LoginForm.Show()
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
            'MASTER
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

            Case "P003"
                addDocumentManager()
                Dim form As New FormLokasiList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Master Data Lokasi"
                    .Show()
                End With

            Case "P004"
                addDocumentManager()
                Dim form As New FormProdukList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Master Data Produk"
                    .Show()
                End With

            Case "P005"
                addDocumentManager()
                Dim form As New FormCustomerList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Master Data Customer"
                    .Show()
                End With

            Case "P006"
                addDocumentManager()
                Dim form As New FormSupplierList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Master Data Supplier"
                    .Show()
                End With

                'PERSEDIAAN
            Case "P007"
                addDocumentManager()
                Dim form As New FormPersediaanList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Data Persediaan"
                    .Show()
                End With
            Case "P008"
                addDocumentManager()
                Dim form As New FormPersediaanAwalList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Data Persediaan Awal"
                    .Show()
                End With

                'PENJUALAN
            Case "P009"
                addDocumentManager()
                Dim form As New FormPOPenjualanList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form PO Penjualan"
                    .Show()
                End With
            Case "P010"
                addDocumentManager()
                Dim form As New FormPenjualanList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Penjualan"
                    .Show()
                End With

                'PEMBELIAN
            Case "P011"
                addDocumentManager()
                Dim form As New FormPOPembelianList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form PO Pembelian"
                    .Show()
                End With
            Case "P012"
                addDocumentManager()
                Dim form As New FormPembelianList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Pembelian"
                    .Show()
                End With
            Case "P013"
                addDocumentManager()
                Dim form As New AkunList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Akun"
                    .Show()
                End With
            Case "P014"
                addDocumentManager()
                Dim form As New TipeAkunList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Tipe Akun"
                    .Show()
                End With
            Case "P015"
                addDocumentManager()
                Dim form As New KategoriAkunList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Kategori Akun"
                    .Show()
                End With

            'STOCK
            Case "P016"
                addDocumentManager()
                Dim form As New StockMasukList
                With parent

                End With
                With form
                    .MdiParent = parent
                    .Text = "Form Add Stock Masuk"
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
