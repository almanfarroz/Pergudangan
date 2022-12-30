Public Class FormJenisBarang
    Public Shared JenisBarang As JenisBarang
    Public SelectedTableJenis As Integer = -1
    Public SelectedTableJenisBarang As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JenisBarang = New JenisBarang()
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridViewJenisBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJenisBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJenisBarang.Rows(index)

        SelectedTableJenis = selectedRow.Cells(0).Value
        SelectedTableJenisBarang = selectedRow.Cells(1).Value
    End Sub
    Public Sub ReloadDataTableDatabase()
        DataGridViewJenisBarang.DataSource = JenisBarang.GetDataJenisBarangDatabase()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim tambah = New FormTambahJenisBarang()
        tambah.Show()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Dim hapus = New FormHapusJenisBarang()
        hapus.Show()
    End Sub

    Private Sub FormJenisBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        Dim selectedJenis As List(Of String) = JenisBarang.GetDataJenisBarangByIDDatabase(SelectedTableJenis)
        JenisBarang.GSJenis_Barang = selectedJenis(1)
        JenisBarang.GSSatuan = selectedJenis(2)

        FormUbahJenisBarang.Show()

    End Sub
End Class