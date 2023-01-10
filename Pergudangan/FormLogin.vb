Public Class FormLogin
    Public Shared Users As New Users()
    Public Shared FormJenisBarang As FormJenisBarang
    Public Shared MenuUtama As MenuUtama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Users = New Users()
        FormJenisBarang = New FormJenisBarang()
        MenuUtama = New MenuUtama()
    End Sub
    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim Register = New FormRegister()
        Register.Show()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim username = TextBoxUsername.Text
        Dim password = TextBoxPassword.Text

        Dim authData = Users.CheckAuthDatabase(username, password)

        If authData.Count() > 0 Then
            Users.GSUsernameProperty = authData(1)
            MenuUtama.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Password")
        End If
    End Sub
End Class
