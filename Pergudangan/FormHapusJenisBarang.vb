Public Class FormHapusJenisBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelNama.Text = FormLogin.FormJenisBarang.SelectedTableJenisBarang
    End Sub
    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        FormLogin.FormJenisBarang.JenisBarang.DeleteDataJenisBarangByIDDatabase(FormLogin.FormJenisBarang.SelectedTableJenis)
        Me.Close()
    End Sub
End Class