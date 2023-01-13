Public Class FormHapusJenisBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelNama.Text = FormLogin.MenuUtama.FormJenisBarang.SelectedTableJenisBarang
    End Sub
    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        FormLogin.MenuUtama.FormJenisBarang.JenisBarang.DeleteDataJenisBarangByIDDatabase(FormLogin.MenuUtama.FormJenisBarang.SelectedTableJenis)
        Me.Close()
    End Sub

    Private Sub ButtonTutup_Click(sender As Object, e As EventArgs) Handles ButtonTutup.Click
        Me.Close()
    End Sub
End Class