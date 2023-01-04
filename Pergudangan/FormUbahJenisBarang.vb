Public Class FormUbahJenisBarang
    Dim satuan As New List(Of String) From {"pcs", "buah", "kg", "gram", "bungkus", "kardus"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxSatuan.DataSource = satuan
        Dim JenisBarang = FormLogin.FormJenisBarang.JenisBarang
        TextBoxJenisBarang.Text = FormLogin.FormJenisBarang.JenisBarang.GSJenis_Barang
        ComboBoxSatuan.SelectedItem() = FormLogin.FormJenisBarang.JenisBarang.GSSatuan
    End Sub

    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        FormLogin.FormJenisBarang.JenisBarang.GSJenis_Barang = TextBoxJenisBarang.Text
        FormLogin.FormJenisBarang.JenisBarang.GSSatuan = ComboBoxSatuan.SelectedItem()

        FormLogin.FormJenisBarang.JenisBarang.UpdateDataJenisBarangByIDDatabase(FormLogin.FormJenisBarang.SelectedTableJenis,
                                                                      FormLogin.FormJenisBarang.JenisBarang.GSJenis_Barang,
                                                                      FormLogin.FormJenisBarang.JenisBarang.GSSatuan)

        Me.Close()
    End Sub
End Class