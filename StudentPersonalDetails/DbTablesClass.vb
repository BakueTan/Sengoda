Imports System.Data.SqlClient
Imports Miscelleneous
Public Class cEnrol
    Private stud As String
    Private prog As String
    Private lvl As Integer
    Private sem As Integer
    Private intk As String
    Private sess As String
    Private _clas As String


    Public Sub New(ref As String, studid As String)

        Dim enrol As SqlDataReader = Nothing
        Dim sql As String = "select enrollment.Studentid,enrollment.Program,enrollment.Year,enrollment.Session,enrollment.Enrolref,classes.ref as Ref from enrollment " &
        "inner join classes on classes.description = enrollment.classdesc " &
" where classdesc = '" & ref & "'  and studentid = '" & studid & "'"
        enrol = ExecuteReader(sql, True)

        While enrol.Read
            Student = enrol("Studentid")
            Program = enrol("Program")
            Level = enrol("Year")


            Session = enrol("Session")

            '        Exam = enrol("Exam")
            EnrolRef = enrol("EnrolRef").ToString

            classref = enrol("Ref").ToString


        End While

        enrol.Close()
    End Sub
    Public Property Student As String
        Get
            Student = stud
        End Get
        Set(value As String)
            stud = value
        End Set

    End Property


    Public Property Program As String
        Get
            Program = prog
        End Get
        Set(value As String)
            prog = value
        End Set

    End Property

    Public Property Level As String
        Get
            Level = lvl
        End Get
        Set(value As String)
            lvl = value
        End Set

    End Property

    Public Property Semester As String
        Get
            Semester = sem
        End Get
        Set(value As String)
            sem = value
        End Set

    End Property

    Public Property Session As String
        Get
            Session = sess
        End Get
        Set(value As String)
            sess = value
        End Set

    End Property

    Public Property Intake As String
        Get
            Intake = intk
        End Get
        Set(value As String)
            intk = value
        End Set

    End Property

    Public Property Clas As String
        Get
            Clas = _clas
        End Get
        Set(value As String)
            _clas = value
        End Set

    End Property

    Public Property Email As String
    Public Property FullName As String
    Public Property EnrolRef As String
    Public Property classref As String

End Class
Public Class cSubjects
    Public Property SubjectID As String
    Public Property Subject As String

End Class

Public Class CFeesLines
    Public Property Receipt As String
    Public Property Amnt As Double
    Public Property Cartegory As String
    Public Property Period As Integer
    Public Property Linenumber As Integer
    Public Property LineRef As String
    Public Property TransType As String
    Public Property Currency As String
    Public Property Comment As String
    Public Property User As String
    Public Property Ref As String
    Public Property RecDate As Date
End Class


Public Class cFeesHeader
    Public Property StudentID As String
    Public Property Receipt As String
    Public Property Transtype As String
    Public Property RecDate As String
    Public Property TransDate As String
    Public Property FeeEnrolRef As String
    Public Property FeesRef As String
End Class

