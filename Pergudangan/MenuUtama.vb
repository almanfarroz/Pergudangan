Public Class MenuUtama
    Public Shared FormJenisBarang As FormJenisBarang
    Public Shared FormBarang As FormBarang
    Public Shared FormMasukBarang As FormMasukBarang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FormJenisBarang = New FormJenisBarang()
        FormBarang = New FormBarang()
        FormMasukBarang = New FormMasukBarang()
    End Sub
    Private Sub ButtonJenisBarang_Click(sender As Object, e As EventArgs) Handles ButtonJenisBarang.Click
        FormJenisBarang.Show()
    End Sub

    Private Sub ButtonBarang_Click(sender As Object, e As EventArgs) Handles ButtonBarang.Click
        FormBarang.Show()
    End Sub

    Private Sub ButtonBarangMasuk_Click(sender As Object, e As EventArgs) Handles ButtonBarangMasuk.Click
        FormMasukBarang.Show()
    End Sub
End Class