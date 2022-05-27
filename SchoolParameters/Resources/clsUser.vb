
Public Class clsUser

    Private mstrUsername, mstrPassWord, mstrFullName, mstrGroup As String

    Public Property userName() As String

        Get
            Return mstrUsername
        End Get

        Set(ByVal value As String)
            mstrUsername = value
        End Set

    End Property
    Public ReadOnly Property UserIsValid() As Boolean

        Get
            Dim sql As String = ""
            Dim Valid As Boolean = False
            '   Dim locked As Boolean = False

            Dim oResult As Object = Nothing
            Try
                sql = "SELECT COUNT(Usr_User) FROM dbo.Users WHERE Usr_User ='" & mstrUsername & _
                "' AND Usr_Password ='" & mstrPassWord & "' and usr_active = 'False' "
                oResult = ExecuteScalar(sql)
                If Not IsNothing(oResult) Then
                    If CInt(oResult) > 0 Then
                        Valid = True
                    End If

                End If
            Catch ex As Exception
            End Try
            'Test Harness
            'Valid = True

            Return Valid
        End Get

    End Property



    Public Sub New(ByVal userNme As String, ByVal passWd As String)
        userName = userNme
        passWord = passWd
        Try
            mstrFullName = ""
            mstrFullName = GetTableValue("Users", "Usr_User", "Usr_FullName", userName, False).ToString
            If mstrFullName = "No Data" Then
                mstrFullName = ""
            End If
        Catch ex As Exception

        End Try

        Try
            mstrGroup = ""
            mstrGroup = GetTableValue("Users", "Usr_User", "Usr_UserGroup", userName, False).ToString
            If mstrGroup = "No Data" Then
                mstrGroup = ""
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Property passWord() As String
        Get
            Return mstrPassWord
        End Get
        Set(ByVal value As String)
            mstrPassWord = value

        End Set
    End Property
    Public ReadOnly Property FullName() As String
        Get
            Return mstrFullName
        End Get
    End Property
    Public ReadOnly Property Group() As String
        Get
            Return mstrGroup
        End Get
    End Property
End Class
