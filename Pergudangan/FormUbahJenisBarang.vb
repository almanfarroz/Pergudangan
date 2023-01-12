Public Class FormUbahJenisBarang
    Dim satuan As New List(Of String) From {"pcs", "buah", "kg", "gram", "bungkus", "kardus"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxSatuan.DataSource = satuan
        Dim JenisBarang = FormLogin.MenuUtama.FormJenisBarang.JenisBarang
        TextBoxJenisBarang.Text = FormLogin.MenuUtama.FormJenisBarang.JenisBarang.GSJenis_Barang
        ComboBoxSatuan.SelectedItem() = FormLogin.MenuUtama.FormJenisBarang.JenisBarang.GSSatuan
    End Sub

    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        FormLogin.MenuUtama.FormJenisBarang.JenisBarang.GSJenis_Barang = TextBoxJenisBarang.Text
        FormLogin.MenuUtama.FormJenisBarang.JenisBarang.GSSatuan = ComboBoxSatuan.SelectedItem()

        FormLogin.MenuUtama.FormJenisBarang.JenisBarang.UpdateDataJenisBarangByIDDatabase(FormLogin.MenuUtama.FormJenisBarang.SelectedTableJenis,
                                                                      FormLogin.MenuUtama.FormJenisBarang.JenisBarang.GSJenis_Barang,
                                                                      FormLogin.MenuUtama.FormJenisBarang.JenisBarang.GSSatuan)

        Me.Close()
    End Sub

    Private Sub FormUbahJenisBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class