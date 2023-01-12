Public Class FormEditBarang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim DatabaseJenisBarang = FormBarang.DataBarang.GetDataJenisBarangDatabase
        ComboBoxIdJenisBarang.DataSource = DatabaseJenisBarang
        ComboBoxIdJenisBarang.ValueMember = "id Jenis Barang"
        ComboBoxIdJenisBarang.DisplayMember = "Jenis Barang"

        ComboBoxIdJenisBarang.SelectedValue = FormBarang.DataBarang.GSidJenisBarang
        TextBoxBarang.Text = FormBarang.DataBarang.GSbarang
        TextBoxStock.Text = FormBarang.DataBarang.GSstock
    End Sub

    Private Sub ButtonTambahBarang_Click(sender As Object, e As EventArgs) Handles ButtonTambahBarang.Click
        FormBarang.DataBarang.GSidJenisBarang = CInt(ComboBoxIdJenisBarang.SelectedItem()(0))
        FormBarang.DataBarang.GSbarang = TextBoxBarang.Text
        FormBarang.DataBarang.GSstock = TextBoxStock.Text

        FormBarang.DataBarang.UpdateDataBarangByIdDatabase(
            FormBarang.DataBarang.GSidBarang,
            FormBarang.DataBarang.GSidJenisBarang,
            FormBarang.DataBarang.GSbarang,
            FormBarang.DataBarang.GSstock)

        Close()

    End Sub

    Private Sub TextBoxStock_TextChanged(sender As Object, e As EventArgs) Handles TextBoxStock.TextChanged

    End Sub

    Private Sub TextBoxStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStock.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Masukkan Angka!")
        End If
    End Sub
End Class