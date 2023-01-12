Public Class FormHapusBarang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelHapus.Text() = FormLogin.MenuUtama.FormBarang.selectedBarang

    End Sub

    Private Sub ButtonFormHapus_Click(sender As Object, e As EventArgs) Handles ButtonFormHapus.Click
        FormLogin.MenuUtama.FormBarang.DataBarang.DeleteDataBarangByIdDatabase(FormLogin.MenuUtama.FormBarang.selectedIdBarang)
        Close()
    End Sub
End Class