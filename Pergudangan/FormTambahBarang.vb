Public Class FormTambahBarang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim DatabaseJenisBarang = FormBarang.DataBarang.GetDataJenisBarangDatabase
        ComboBoxIdJenisBarang.DataSource = DatabaseJenisBarang
        ComboBoxIdJenisBarang.ValueMember = "id Jenis Barang"
        ComboBoxIdJenisBarang.DisplayMember = "Jenis Barang"
    End Sub

    Private Sub ButtonTambahBarang_Click(sender As Object, e As EventArgs) Handles ButtonTambahBarang.Click
        Try
            FormBarang.DataBarang.GSidJenisBarang = CInt(ComboBoxIdJenisBarang.SelectedItem()(0))
            FormBarang.DataBarang.GSbarang = TextBoxBarang.Text
            FormBarang.DataBarang.GSstock = TextBoxStock.Text

            FormBarang.DataBarang.AddDataBarangDatabase(
                FormBarang.DataBarang.GSidJenisBarang,
                FormBarang.DataBarang.GSbarang,
                FormBarang.DataBarang.GSstock)

            Close()
        Catch ex As Exception

        End Try
    End Sub
End Class