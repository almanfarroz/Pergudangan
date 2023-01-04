Public Class FormUbahJenisBarang
    Dim satuan As New List(Of String) From {"pcs", "buah", "kg", "gram", "bungkus", "kardus"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxSatuan.DataSource = satuan
        Dim JenisBarang = FormJenisBarang.JenisBarang
        TextBoxJenisBarang.Text = FormJenisBarang.JenisBarang.GSJenis_Barang
        ComboBoxSatuan.SelectedItem() = FormJenisBarang.JenisBarang.GSSatuan
    End Sub

    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        FormJenisBarang.JenisBarang.GSJenis_Barang = TextBoxJenisBarang.Text
        FormJenisBarang.JenisBarang.GSSatuan = ComboBoxSatuan.SelectedItem()

        FormJenisBarang.JenisBarang.UpdateDataJenisBarangByIdDatabase(FormJenisBarang.SelectedTableJenis,
                                                                      FormJenisBarang.JenisBarang.GSJenis_Barang,
                                                                      FormJenisBarang.JenisBarang.GSSatuan)

        Me.Close()
    End Sub
End Class