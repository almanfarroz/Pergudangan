
Imports System.Text

Imports MySql.Data.MySqlClient
Public Class DataBarang
    Private idBarang As Integer
    Private idJenisBarang As Integer
    Private barang As String
    Private stock As Integer

    Private BarangDataTable As New ArrayList()

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
    Public Property GSidJenisBarang() As Integer
        Get
            Return idJenisBarang
        End Get
        Set(value As Integer)
            idJenisBarang = value
        End Set
    End Property

    Public Property GSbarang() As String
        Get
            Return barang
        End Get
        Set(value As String)
            barang = value
        End Set
    End Property

    Public Property GSstock() As Integer
        Get
            Return stock
        End Get
        Set(value As Integer)
            stock = value
        End Set
    End Property




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

    Public Function GetDataJenisBarangDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_barang AS 'id Jenis Barang', jenis_barang AS 'Jenis Barang' FROM jenisbarang"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataBarangDatabase(idJenisBarang As Integer,
                                          barang As String,
                                          stock As String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO barang(id_jenis_barang, barang, stock) VALUE('" _
                        & idJenisBarang & "','" _
                        & barang & "','" _
                        & stock & "')"
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

    Public Function GetDataBarangByIdDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime = " + "True" + ";" + "Allow Zero Datetime = " + "True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT
                                  id_barang,id_jenis_barang, 
                                  barang, stock FROM barang WHERE id_barang = '" & ID & "'"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Function UpdateDataBarangByIdDatabase(idBarang As Integer,
                                        idJenisBarang As Integer,
                                        barang As String,
                                        stock As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE barang SET " &
                        "id_jenis_barang= '" & idJenisBarang & "',  " &
                        "barang= '" & barang & "',  " &
                        "stock= '" & stock & "' " &
                        "WHERE id_barang = '" & idBarang & "'"
            Debug.Print(sqlQuery)
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

    Public Function DeleteDataBarangByIdDatabase(Idbarang As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM barang WHERE id_barang = '" & Idbarang & "' "
            Debug.WriteLine(sqlQuery)

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
