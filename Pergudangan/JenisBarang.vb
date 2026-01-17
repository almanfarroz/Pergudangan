Imports System.Text
Imports MySql.Data.MySqlClient
Public Class JenisBarang
    Private satuan As String
    Private jenis_barang As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"

    Public Property GSSatuan As String
        Get
            Return satuan
        End Get
        Set(ByVal value As String)
            satuan = value
        End Set
    End Property

    Public Property GSJenis_Barang As String
        Get
            Return jenis_barang
        End Get
        Set(ByVal value As String)
            jenis_barang = value
        End Set
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        ' Convert to string
        Dim res = builder.ToString()
        Return res
    End Function

    Public Sub ClearData()
        jenis_barang = ""
        satuan = ""
    End Sub

    Public Function AddDataJenisBarangDatabase(jenis_barang As String,
                                        satuan As String)
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO jenisbarang(jenis_barang, satuan) VALUE('" _
            & jenis_barang & "', '" & satuan & "')"

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

    Public Function UpdateDataJenisBarangByIDDatabase(ID As Integer,
                                        jenis_barang As String,
                                        satuan As String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE jenisbarang SET " &
                    "jenis_barang='" & jenis_barang & "', " &
                    "satuan='" & satuan & "' " &
                    "WHERE id_jenis_barang='" & ID & "'"
            Debug.Print(sqlQuery)

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

    Public Function GetDataJenisBarangByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_barang, jenis_barang, satuan
                                 FROM jenisbarang WHERE id_jenis_barang = '" + ID.ToString + "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataJenisBarangDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_barang AS 'ID',
                                jenis_barang AS 'Jenis Barang',
                                satuan AS 'Satuan'
                                FROM jenisbarang"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function DeleteDataJenisBarangByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM jenisbarang WHERE id_jenis_barang='" & ID.ToString & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        End Try
        dbConn.Dispose()
    End Function
End Class
