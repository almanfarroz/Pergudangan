Public Class FormTambahOrder
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim dsBarang = FormOrder.DataOrder.GetDataBarangDatabase
        ComboBoxBarang.DataSource = dsBarang
        ComboBoxBarang.ValueMember = "ID Barang"
        ComboBoxBarang.DisplayMember = "Barang"
    End Sub

    Private Sub ButtonTambahOrder_Click(sender As Object, e As EventArgs) Handles ButtonTambahOrder.Click
        Try
            FormOrder.DataOrder.GSidBarang = CInt(ComboBoxBarang.SelectedItem()(0))
            FormOrder.DataOrder.GSjumlah_order = TextBoxJumlahOrder.Text
            FormOrder.DataOrder.GStanggal_order = DateTimePickerTanggalOrder.Value.ToShortDateString()

            FormOrder.DataOrder.AddDataOrderDatabase(
                FormOrder.DataOrder.GSidBarang,
                FormOrder.DataOrder.GStanggal_order,
                FormOrder.DataOrder.GSjumlah_order
            )
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class