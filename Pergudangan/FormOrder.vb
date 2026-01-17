Public Class FormOrder
    Public Shared DataOrder As New DataOrder

    Public selectedIdOrder As Integer
    Public selectedOrder As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataOrder = New DataOrder()
    End Sub

    Private Sub FormOrder_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        Dim dataOrderDb = DataOrder.GetDataOrderDatabase()
        DataGridViewOrder.DataSource = dataOrderDb
    End Sub

    Private Sub DataGridViewOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOrder.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewOrder.Rows(index)

        selectedIdOrder = selectedRow.Cells(0).Value
        selectedOrder = selectedRow.Cells(2).Value
    End Sub


    Private Sub ButtonTambahBarang_Click(sender As Object, e As EventArgs) Handles ButtonAddOrder.Click
        Dim FormTambah = New FormTambahOrder()
        FormTambahOrder.Show()
    End Sub

    Private Sub ButtonHapusBarang_Click(sender As Object, e As EventArgs) Handles ButtonDeleteOrder.Click
        Dim FormHapus = New FormDeleteOrder()
        FormHapus.Show()
    End Sub
End Class
