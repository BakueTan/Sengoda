


Public Class csSiblings
        Public Property StudentId As String
    Public Property Sibling As String
    Public Property SiblingName As String
    Public Sub New()

        End Sub

    End Class

Public Class csDocs
    Public Property StudentId As String
    Public Property Doc As Byte()
    Public Property Filename As String
    Public Property FileType As String
    Public Property filesize As Double
    Public Property dateuploaded As Date
    Public Property fileref As String
    Public Property deleted As Boolean

    Public Sub New()

    End Sub

End Class

Public Class csSubjects
    Public Property SubjectID As String
    Public Property Exam As String
    Public Property ExamRef As String

End Class
