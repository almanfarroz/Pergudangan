Public Class FormJenisBarang
    Public Shared JenisBarang As JenisBarang
    Public SelectedTableJenis As Integer = -1
    Public SelectedTableJeniBarang As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JenisBarang = New JenisBarang()
        ReloadDataTableDatabase()
    End Sub
    Private Sub DataGridViewJenisBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'SelectedTableKoleksi = DataGridView1.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJenisBarang.Rows(index)

        SelectedTableJenis = selectedRow.Cells(0).Value
        SelectedTableJeniBarang = selectedRow.Cells(1).Value
    End Sub
    Public Sub ReloadDataTableDatabase()
        DataGridViewJenisBarang.DataSource = JenisBarang.GetDataKoleksiDatabase()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim tambah = New FormTambahJenisBarang()
        tambah.Show()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Dim hapus = New FormHapusJenisBarang()
        hapus.Show()
    End Sub
End Class