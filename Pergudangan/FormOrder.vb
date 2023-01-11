Public Class FormOrder
    Public Shared DataOrder = New DataOrder

    Public selectedIdOrder As Integer
    Public selectedJenisBarang As Integer
    Public selectedOrder As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormOrder_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        Dim dataOrderDb = DataOrder.GetDataOrderDatabase()
        DataGridViewOrder.DataSource = DataOrder.GetDataBarangDatabase()
    End Sub

    Private Sub DataGridViewOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOrder.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewOrder.Rows(index)

        selectedIdOrder = selectedRow.Cells(0).Value
        selectedJenisOrder = selectedRow.Cells(1).Value
        selectedOrder = selectedRow.Cells(2).Value
    End Sub


    Private Sub ButtonTambahBarang_Click(sender As Object, e As EventArgs) Handles ButtonTambahBarang.Click
        FormTambahOrder.Show()
    End Sub

    Private Sub ButtonUpdateOrder_Click(sender As Object, e As EventArgs) Handles ButtonUpdateOrder.Click
        Dim selectedBarang As List(Of String) = DataOrder.GetDataOrderByIdDatabase(selectedIdOrder)
        DataOrder.GSidBarang = selectedIdOrder
        DataOrder.GSidJenisBarang = selectedBarang(1)
        DataOrder.GSbarang = selectedBarang(2)
        DataOrder.GSstock = selectedBarang(3)

        Dim FormUpdate = New FormUpdateOrder()
        FormEdit.Show()
    End Sub

    Private Sub ButtonHapusBarang_Click(sender As Object, e As EventArgs) Handles ButtonHapusBarang.Click
        Dim FormHapus = New FormHapusBarang()
        FormHapus.Show()

    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
End Class