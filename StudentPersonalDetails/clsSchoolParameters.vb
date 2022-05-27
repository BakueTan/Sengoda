Imports System.Data.SqlClient
Imports Miscelleneous
Public Class ClsSchoolParameters

    Private _autoid As Boolean
    Private _StudIDlength As Integer
    Private _yearformat As String
    Private _studidprefix As String


    Public ReadOnly Property StudIdLenghth() As Integer
        Get
            Return _StudIDlength
        End Get
    End Property
    Public ReadOnly Property YearFormat() As String
        Get
            Return _yearformat
        End Get
    End Property

    Public ReadOnly Property AutoId() As Boolean
        Get
            Return _autoid
        End Get
    End Property

    Public ReadOnly Property StudIDrefix() As String
        Get
            Return _studidprefix
        End Get
    End Property


    Public Sub New()
        Dim reader As SqlDataReader
        Dim sql As String = "select autostudid,studidlength,studidprefix from schoolinfo "
        reader = ExecuteReader(sql,, True)
        While reader.Read
            _autoid = reader(0)
            '  _yearformat = reader(1)
            _StudIDlength = reader(1)
            _studidprefix = reader(2)
        End While

    End Sub

End Class
