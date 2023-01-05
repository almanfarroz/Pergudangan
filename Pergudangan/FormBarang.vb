Public Class FormBarang
    Public Shared DataBarang = New DataBarang
    Public Shared selectedDataBarang
    Public Shared selectedTableBarang
    Public Shared selectedTableBarangNama
    Public Shared selectedIdBarang

    Private barangDataTable As New ArrayList()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub UpdateDataTableArrayList()
        For Each rowBarang In DataBarang.getBarangDataTable()
            Dim dataTable As String() = {
                rowBarang(1),
                rowBarang(2),
                rowBarang(3)
            }
            DataGridViewBarang.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewBarang.DataSource = DataBarang.GetDataBarangDatabase()
    End Sub

    Private Sub DataGridViewBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewBarang.Rows(index)

        selectedIdBarang = Int(selectedRow.Cells(0).Value)
        selectedTableBarangNama = selectedRow.Cells(1).Value
    End Sub


    Private Sub ButtonTambahBarang_Click(sender As Object, e As EventArgs) Handles ButtonTambahBarang.Click
        FormTambahBarang.Show()
    End Sub

    Private Sub ButtonEditBarang_Click(sender As Object, e As EventArgs) Handles ButtonEditBarang.Click
        Dim selectedBarang As List(Of String) = DataBarang.GetDataBarangByIdDatabase(selectedIdBarang)
        DataBarang.GSidBarang = selectedIdBarang
        DataBarang.GSidJenisBarang = selectedBarang(0)
        DataBarang.GSbarang = selectedBarang(1)
        DataBarang.GSstock = selectedBarang(2)

        Dim FormEdit = New FormEditBarang()
        FormEdit.Show()
    End Sub

    Private Sub ButtonHapusBarang_Click(sender As Object, e As EventArgs) Handles ButtonHapusBarang.Click
        Dim FormHapus = New FormHapusBarang()
        FormHapus.show()

    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class