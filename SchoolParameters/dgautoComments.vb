Imports System.Windows.Forms
Imports Miscelleneous
Imports System.Data.SqlClient
Public Class dgautoComments
    Public GradeRef As String
    Public GradeString As String
    Public Grade As String
    Private comments As SqlDataReader
    Public exmgrades As List(Of cExamGrading)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub GetComments()
        Label1.Text = GradeString
        dgGeadeComments.Rows.Clear()
        Dim row As Integer = 0
        Dim gradecomments As New List(Of cAutoComment)

        'If GradeRef <> "" Then
        '    cnn = New SqlConnection(ConnectionString)
        '    Try
        '        cnn.Open()


        '        sqltext = "spGetGradeComments"
        '        cmd = New SqlCommand(sqltext, cnn)
        '        cmd.CommandType = CommandType.StoredProcedure
        '        cmd.Parameters.AddWithValue("@ref", GradeRef)
        '        comments = cmd.ExecuteReader

        '        While comments.Read
        '            dgGeadeComments.Rows.Add()
        '            dgGeadeComments.Rows(row).Cells("GradeComment").Value = comments(0)
        '            row += 1
        '        End While

        '    Catch ex As Exception
        '    Finally
        '        cnn.Close()
        '    End Try

        'Else
        Try
            gradecomments = exmgrades.Where(Function(x) x.Grade = Grade).Single.AutoComents
        Catch ex As Exception
            gradecomments = New List(Of cAutoComment)
        End Try

        If gradecomments.Any Then
            For Each cmnt As cAutoComment In gradecomments
                dgGeadeComments.Rows.Add()
                dgGeadeComments.Rows(row).Cells("GradeComment").Value = cmnt.Comment
                row += 1

            Next
            '
        End If

        '  End If



    End Sub


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
