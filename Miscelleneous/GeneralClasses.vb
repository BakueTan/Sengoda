Imports System.Data.SqlClient

Public Class CSmtp
    Private drr As SqlDataReader
    Public Property Server As String
    Public Property MailFrom As String
    Public Property Port As Integer
    Public Property Password As String

    Public Sub New()
        Dim sql As String = "select * from smtp "
        drr = ExecuteReader(sql,, True)

        While drr.Read
            Server = drr("Server")
            MailFrom = drr("MailFrom")
            Port = drr("Port")
            Password = drr("Password")




        End While
    End Sub

End Class
