Public Class FormTambahJenisBarang
    Public Shared JenisBarang As JenisBarang
    Dim satuan As New List(Of String) From {"pcs", "buah", "kg", "gram", "bungkus", "kardus"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxSatuan.DataSource = satuan
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        FormJenisBarang.JenisBarang.GSSatuan = ComboBoxSatuan.SelectedItem()
        FormJenisBarang.JenisBarang.GSJenis_Barang = TextBoxJenisBarang.Text

        FormJenisBarang.JenisBarang.AddDataJenisBarangDatabase(FormJenisBarang.JenisBarang.GSJenis_Barang,
                                                    FormJenisBarang.JenisBarang.GSSatuan)
        Me.Close()
    End Sub
End Class