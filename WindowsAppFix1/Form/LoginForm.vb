Public Class LoginForm

    Dim loginRepository As LoginRepository = New LoginRepository

    Private Sub ShowMainForm()
        Me.Hide()
        Dim form = New MainForm
        form.Show()
    End Sub

    Private Async Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim login = New LoginClass With {
            .email = emailTextEdit.EditValue,
            .password = passwordTextEdit.EditValue
        }

        If Token Is Nothing Then
            Dim response As Boolean = Await loginRepository.Login(login)
            If response Then
                ShowMainForm()
            End If
        Else
            ShowMainForm()
        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class