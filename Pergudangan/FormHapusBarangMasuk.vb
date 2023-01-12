Public Class FormHapusBarangMasuk

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelHapus.Text() = FormLogin.MenuUtama.FormMasukBarang.selectedIdBarangMasuk
    End Sub
    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        FormLogin.MenuUtama.FormMasukBarang.ClassMasukBarang.DeleteBarangMasukByIdDatabase(FormLogin.MenuUtama.FormMasukBarang.selectedIdBarangMasuk)

        Close()
    End Sub
End Class