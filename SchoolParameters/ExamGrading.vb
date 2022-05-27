Public Class cExamGrading

    Public Program As String
    Public Session As String
    Public Grade As String
    Public Credits As Integer
    Public LowerLimit As Double
    Public UpperLimit As Double
    Public Comment As String
    Public MultipleAutoComments As Boolean
    Public RefId As String
    Public AutoComents As New List(Of cAutoComment)

End Class

Public Class cAutoComment
    Public Comment As String
    Public GradeRef As String
    Public Refid As String
End Class
