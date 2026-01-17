Imports System.Text

Imports MySql.Data.MySqlClient
Public Class DataOrder
    Private idOrder As Integer
    Private idBarang As Integer
    Private tanggal_order As Date
    Private jumlah_order As Integer
    Private status As Boolean


    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"

    Public Property GSidBarang() As Integer
        Get
            Return idBarang
        End Get
        Set(value As Integer)
            idBarang = value
        End Set
    End Property

    Public Property GSidOrder() As Integer
        Get
            Return idOrder
        End Get
        Set(value As Integer)
            idOrder = value
        End Set
    End Property

    Public Property GStanggal_order() As Date
        Get
            Return tanggal_order
        End Get
        Set(value As Date)
            tanggal_order = value
        End Set
    End Property

    Public Property GSjumlah_order() As Integer
        Get
            Return jumlah_order
        End Get
        Set(value As Integer)
            jumlah_order = value
        End Set
    End Property

    Public Property GSstatus() As Integer
        Get
            Return status
        End Get
        Set(value As Integer)
            status = value
        End Set
    End Property

    Public Function GetDataOrderDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT 
                                  id_order AS 'id Order',
                                  id_barang AS 'ID Barang',
                                  tanggal_order AS 'Tanggal Order',
                                  jumlah_order AS 'Jumlah Order',
                                  status AS 'STATUS' FROM `order`"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataBarangDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_barang AS 'ID Barang',
                                  id_jenis_barang AS 'ID Jenis Barang',
                                  barang AS 'Barang',
                                  stock AS 'Stock' FROM barang"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataOrderDatabase(idBarang As Integer,
                                          tanggal_order As Date,
                                          jumlah_order As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO `order`(id_barang, tanggal_order, jumlah_order, status) VALUE('" _
                            & idBarang & "','" _
                            & tanggal_order.ToString("yyyy-MM-dd") & "','" _
                            & jumlah_order & "','" _
                            & 1 & "')"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Function UpdateDataOrderByIdDatabase(idOrder As Integer,
                                          idBarang As Integer,
                                          tanggal_order As Date,
                                          jumlah_order As Integer,
                                          status As Boolean)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE order SET " &
                        "idbarang= '" & idBarang & "',  " &
                        "tanggal_order= '" & tanggal_order & "',  " &
                        "jumlah_order= '" & jumlah_order & "',  " &
                        "status= '" & status & "' " &
                        "WHERE id_Order = '" & idOrder & "'"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()


        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataOrderByIdDatabase(IdOrder As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM `order` WHERE id_order = '" & IdOrder & "' "
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

End Class
