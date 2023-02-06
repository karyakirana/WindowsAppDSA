Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed

Module MainModule

#Region "Global Variable"
    ' Every process using global variable

    Public Token As String
    Public BaseURl As String = "http://erpbsa.test/api/"

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

#End Region

End Module
