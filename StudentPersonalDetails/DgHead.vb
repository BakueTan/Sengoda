Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Miscelleneous

Public Class DgHead

    Public isloaded As Boolean = False
    Public studid, studname, studsurname, Exam As String

    Public classstuds As DataSet



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cnn As SqlConnection = New SqlConnection(ConnectionString)
        Dim formatedcomment As String

        Dim trans As SqlTransaction
        If rbOneChild.Checked Then

            If Trim(studid) = "" Then
                MsgBox("Select Student")
                Exit Sub
            End If

            If cboHeadmaster.Text = "" Then
                MsgBox("Select Boardingmaster")
                Exit Sub
            End If

            formatedcomment = Trim(txtComment.Text)

            Dim sql As String = "spInsertHeadMasterExamComment"

            Try

                Dim cmd As New SqlCommand
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@comment", formatedcomment)
                cmd.Parameters.AddWithValue("@stud", studid)
                cmd.Parameters.AddWithValue("@head", cboHeadmaster.SelectedValue)
                cmd.Parameters.AddWithValue("@exam", Exam)
                cmd.Parameters.AddWithValue("@user", goUser.userName)
                cmd.Connection = cnn
                cnn.Open()

                cmd.ExecuteNonQuery()

                MsgBox("Head's Comment Successfully added")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try




        End If

        '      Me.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub








    Private Sub DgHead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsReports.HsExamMarks' table. You can move, or remove it, as needed.





        LoadMarkStudents()

        With cboHeadmaster
            .DataSource = Headmasters()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


        isloaded = True
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub populateHeadComments()

        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)
        Try

            cmd.CommandText = "spLoadHeadComment"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@stud", studid)
            cmd.Parameters.AddWithValue("@exam", Exam)
            cmd.Connection = cnn
            cnn.Open()

            Dim program As SqlDataReader = cmd.ExecuteReader
            If program.HasRows Then
                While program.Read
                    ' studname = student.gdStudents.SelectedRows(0).Cells(1).Value
                    '  studsurname = student.gdStudents.SelectedRows(0).Cells(2).Value
                    '  exam = student.cboExam.Text
                    ' txtTeacher.Text = program(2)
                    Try
                        txtComment.Text = program("Comment")
                    Catch ex As Exception
                        txtComment.Text = ""
                    End Try

                    cboHeadmaster.SelectedValue = program("headmaster")

                    lbStud.Text = studname & "'s Comment"
                    Me.StudentAcademicReportTableAdapter.FillByStudent(Me.dsSchool.StudentAcademicReport, Exam, studid)
                    Me.ReportViewer1.RefreshReport()
                End While

                ' gdHeadStudents = Student.gdStudents

                '   LoadMarkStudents()
            Else
                txtComment.Text = ""
                lbStud.Text = ""
                Me.StudentAcademicReportTableAdapter.FillByStudent(Me.dsSchool.StudentAcademicReport, Exam, studid)
                Me.ReportViewer1.RefreshReport()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try


    End Sub



    Private Sub LoadMarkStudents()
        gdHeadStudents.DataSource = Nothing

        gdHeadStudents.DataSource = classstuds.Tables(0)

        For Each row As DataGridViewRow In gdHeadStudents.Rows
            If row.Cells(0).Value = studid Then
                row.Selected = True
                Exit Sub
            End If

        Next






    End Sub




    Private Sub gdHeadStudents_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gdHeadStudents.SelectionChanged
       

        Try
            studid = gdHeadStudents.SelectedRows(0).Cells(0).Value
            studname = gdHeadStudents.SelectedRows(0).Cells(1).Value
            populateHeadComments()
        Catch ex As Exception

        End Try
    End Sub
End Class
