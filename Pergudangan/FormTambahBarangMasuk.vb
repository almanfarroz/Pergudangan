Public Class FormTambahBarangMasuk

    Public Shared ClassMasukBarang As ClassMasukBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim DatabaseOrder = FormMasukBarang.ClassMasukBarang.GetOrderDatabase
        ComboBoxIdOrder.DataSource = DatabaseOrder
        ComboBoxIdOrder.ValueMember = "ID Order"
        ComboBoxIdOrder.DisplayMember = "Jumlah Order"
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Try
            FormMasukBarang.ClassMasukBarang.GSidOrder = CInt(ComboBoxIdOrder.SelectedItem()(0))
            FormMasukBarang.ClassMasukBarang.GSjumlahMasuk = TextBoxJumlahMasuk.Text

            FormMasukBarang.ClassMasukBarang.AddBarangMasukDatabase(
                 FormMasukBarang.ClassMasukBarang.GSidOrder,
                 FormMasukBarang.ClassMasukBarang.GSjumlahMasuk)

            Close()
        Catch ex As Exception

        End Try
    End Sub


End Class