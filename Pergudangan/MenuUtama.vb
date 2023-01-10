Public Class MenuUtama
    Public Shared FormJenisBarang As FormJenisBarang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FormJenisBarang = New FormJenisBarang()
    End Sub
    Private Sub ButtonJenisBarang_Click(sender As Object, e As EventArgs) Handles ButtonJenisBarang.Click
        FormJenisBarang.Show()
    End Sub
End Class