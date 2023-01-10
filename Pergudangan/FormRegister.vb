Public Class FormRegister
    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        If (validateRegister()) Then
            FormLogin.Users.AddUsersDatabase(TextBoxUsername.Text, TextBoxEmail.Text, TextBoxPassword.Text)
            MessageBox.Show("Berhasil Register")
        Else
            MessageBox.Show("Validasi Gagal")
        End If
    End Sub


    Public Function validateRegister() As Boolean
        If (TextBoxUsername.Text <> "") Then
            If TextBoxPassword.Text = TextBoxConfirmPassword.Text And TextBoxPassword.Text <> "" Then
                Return True
            End If
            Return False
        End If
        Return False
    End Function

End Class