Imports MySql.Data.MySqlClient



Public Class ClassMasukBarang

    Private idOrder As Integer
    Private idBarangMasuk As Integer
    Private jumlahMasuk As Integer

    Private BarangMasukTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"

    Public Property GSidOrder() As Integer
        Get
            Return idOrder
        End Get
        Set(value As Integer)
            idOrder = value
        End Set
    End Property

    Public Property GSidBarangMasuk() As Integer
        Get
            Return idBarangMasuk
        End Get
        Set(value As Integer)
            idBarangMasuk = value
        End Set
    End Property

    Public Property GSjumlahMasuk() As Integer
        Get
            Return jumlahMasuk
        End Get
        Set(value As Integer)
            jumlahMasuk = value
        End Set
    End Property

    Public Function AddBarangMasukTable(idOrder As Integer,
                                        jumlahMasuk As Integer)
        BarangMasukTable.Add({idOrder,
                             jumlahMasuk})
    End Function

    Public Function RemoveBarangMasukTable(index As Integer)
        BarangMasukTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getBarangMasukTable() As ArrayList
        Get
            Return BarangMasukTable
        End Get
    End Property

    Public Function GetBarangMasukDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero DateTime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_barang_masuk AS 'ID Barang Masuk',
                                         `order`.id_order AS 'ID Order',
                                         jumlah_order AS 'Jumlah Order',
                                         jumlah_masuk AS 'Barang Masuk',
                                         `order`.status AS 'Status' FROM `barang_masuk` INNER JOIN `order` ON `barang_masuk`.id_order = `order`.id_order"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetBarangMasukDatabaseByIdOrder(idOrder As Integer) As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero DateTime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_barang_masuk AS 'ID Barang Masuk',
                                         `order`.id_order AS 'ID Order',
                                         jumlah_order AS 'Jumlah Order',
                                         jumlah_masuk AS 'Barang Masuk',
                                         `order`.status AS 'Status' FROM `barang_masuk` INNER JOIN `order` ON `barang_masuk`.id_order = `order`.id_order WHERE `order`.id_order = '" & idOrder & "'"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetOrderDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero DateTime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_order AS 'ID Order', jumlah_order AS 'Jumlah Order', status AS 'Status' FROM `order` WHERE status = '1'"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetOrderDatabaseById(idOrder As Integer) As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero DateTime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_order AS 'ID Order', jumlah_order AS 'Jumlah Order' FROM `order` WHERE id_order = '" & idOrder & "'"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddBarangMasukDatabase(idOrder As Integer,
                                           jumlahMasuk As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO barang_masuk(id_order, jumlah_masuk) VALUE ('" _
                        & idOrder & "','" _
                        & jumlahMasuk & "')"
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

        Dim dataMasuk = GetBarangMasukDatabaseByIdOrder(idOrder).Rows
        Dim totalMasuk As Integer = 0
        Dim orderMasuk As Integer = Int(dataMasuk(0)(2))
        For Each row In dataMasuk
            totalMasuk += Int(row(3))
            If (totalMasuk >= orderMasuk) Then
                dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
                Try
                    dbConn.Open()
                    sqlCommand.Connection = dbConn
                    sqlQuery = "UPDATE `order` SET status = '0' WHERE id_order = '" & idOrder & "'"
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
            End If
        Next

    End Function

    Public Function GetBarangMasukByIdDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime = " + "True" + ";" + "Allow Zero Datetime = " + "True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_order,
                                         jumlah_masuk FROM barang_masuk WHERE id_barang_masuk = '" & ID & "'"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function DeleteBarangMasukByIdDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM barang_masuk WHERE id_barang_masuk = '" & ID.ToString & "'"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
