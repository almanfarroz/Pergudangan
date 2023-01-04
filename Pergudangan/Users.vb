Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class Users
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "pergudangan"

    Private TripleDes As New TripleDESCryptoServiceProvider
    Public UsernameProperty As String

    Public Property GSUsernameProperty As String
        Set(value As String)
            UsernameProperty = value
        End Set
        Get
            Return UsernameProperty
        End Get
    End Property

    Public Function AddUsersDatabase(username As String, email As String, password As String)
        Try
            Dim today = Date.Now()
            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username_db + ";" + "password= " + password_db + ";" + "database=" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO  user( username, email, password) VALUE('" &
                    username & "', '" & email & "', '" & EncryptMD5(password) & "')"

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

    Public Function EncryptMD5(ByVal password As String)
        Using x As New MD5CryptoServiceProvider()
            Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            bs = x.ComputeHash(bs)
            Dim s As New System.Text.StringBuilder()
            For Each b As Byte In bs
                s.Append(b.ToString("x2").ToLower())
            Next
            Return s.ToString()
        End Using
    End Function

    Public Function CheckAuthDatabase(username As String, password As String) As List(Of String)
        Try
            Dim result As New List(Of String)
            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username_db + ";" + "password= " + password_db + ";" + "database=" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username FROM user WHERE username='" & username & "' AND password='" & EncryptMD5(password) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
