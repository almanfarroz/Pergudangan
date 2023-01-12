Public Class FormDeleteOrder
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelOrder.Text = FormOrder.selectedOrder
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub ButtonHapusOrder_Click(sender As Object, e As EventArgs) Handles ButtonHapusOrder.Click
        FormOrder.DataOrder.DeleteDataOrderByIdDatabase(FormOrder.selectedIdOrder)
        MessageBox.Show("Berhasil dihapus!")
        Close()
    End Sub


End Class