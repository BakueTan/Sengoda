Public Class clsDbConn

    Public ReadOnly Property CnnString() As String
        Get
            Dim connection As String = ""
            connection = "Data Source= .\sqlexpress;Initial Catalog=Sengoda;User ID=sa;Password=$0thwe11"
            '  connection = "Data Source=DBSERVER\DBSERVER;Initial Catalog=TRUSTACADEMY;User ID=sa;Password=$0thwe11"
            Return connection
        End Get


    End Property

End Class
