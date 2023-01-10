Imports System.ComponentModel

Public Class FormMasukBarang

    Public Shared ClassMasukBarang = New ClassMasukBarang
    Public Shared selectedClassBarangMasuk
    Public Shared selectedTableBarangMasuk
    Public Shared selectedTableJumlahBarangMasuk
    Public selectedIdBarangMasuk As Integer
    Public selectedOrder As Integer

    Private BarangMasukDataTable As New ArrayList()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub



    Private Sub DataGridViewBarangMasuk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBarangMasuk.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewBarangMasuk.Rows(index)

        selectedIdBarangMasuk = selectedRow.Cells(0).Value
        selectedOrder = selectedRow.Cells(1).Value
    End Sub

    Private Sub ButtonTambahBarang_Click(sender As Object, e As EventArgs) Handles ButtonTambahBarang.Click
        FormTambahBarangMasuk.Show()
    End Sub

    Private Sub ButtonHapusBarang_Click(sender As Object, e As EventArgs) Handles ButtonHapusBarang.Click
        Dim selectedBarang As List(Of String) = ClassMasukBarang.GetBarangMasukByIdDatabase(selectedIdBarangMasuk)
        selectedOrder = selectedBarang(1)
        Dim FormHapus = New FormHapusBarangMasuk()
        FormHapus.Show()
    End Sub

    Private Sub FormMasukBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub UpdateDataTableArrayList()
        For Each rowBarangMasuk In ClassMasukBarang.getBarangMasukTable()
            Dim dataTable As String() = {
                rowBarangMasuk(1),
                rowBarangMasuk(2)}
            DataGridViewBarangMasuk.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub ReloadDataTableDatabase()
        Dim dataBarangMasukDb = ClassMasukBarang.GetBarangMasukDatabase()
        DataGridViewBarangMasuk.DataSource = ClassMasukBarang.GetBarangMasukDatabase()

    End Sub

    Private Sub FormMasukBarang_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class