Public Class FormBarang
    Public Shared DataBarang = New DataBarang

    Public selectedIdBarang As Integer
    Public selectedJenisBarang As Integer
    Public selectedBarang As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub FormBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        Dim dataBarangDb = DataBarang.GetDataBarangDatabase()
        DataGridViewBarang.DataSource = DataBarang.GetDataBarangDatabase()
    End Sub

    Private Sub DataGridViewBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewBarang.Rows(index)

        selectedIdBarang = selectedRow.Cells(0).Value
        selectedJenisBarang = selectedRow.Cells(1).Value
        selectedBarang = selectedRow.Cells(2).Value
    End Sub


    Private Sub ButtonTambahBarang_Click(sender As Object, e As EventArgs) Handles ButtonTambahBarang.Click
        FormTambahBarang.Show()
    End Sub

    Private Sub ButtonEditBarang_Click(sender As Object, e As EventArgs) Handles ButtonEditBarang.Click
        Dim selectedBarang As List(Of String) = DataBarang.GetDataBarangByIdDatabase(selectedIdBarang)
        DataBarang.GSidBarang = selectedIdBarang
        DataBarang.GSidJenisBarang = selectedBarang(1)
        DataBarang.GSbarang = selectedBarang(2)
        DataBarang.GSstock = selectedBarang(3)

        Dim FormEdit = New FormEditBarang()
        FormEdit.Show()
    End Sub

    Private Sub ButtonHapusBarang_Click(sender As Object, e As EventArgs) Handles ButtonHapusBarang.Click
        Dim FormHapus = New FormHapusBarang()
        FormHapus.Show()

    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class