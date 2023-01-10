Public Class FormHapusBarang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelHapus.Text() = FormBarang.selectedBarang

    End Sub

    Private Sub ButtonFormHapus_Click(sender As Object, e As EventArgs) Handles ButtonFormHapus.Click
        FormBarang.DataBarang.DeleteDataBarangByIdDatabase(FormBarang.selectedIdBarang)
        Close()
    End Sub
End Class