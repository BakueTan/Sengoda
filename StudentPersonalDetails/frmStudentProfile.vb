Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Miscelleneous
Public Class frmStudentProfile

    Private stud As csStudent
    Public StudentFullName As String
    Public StudentID As String

    Public StudDetails As List(Of String)
    Private drr As SqlDataReader
    Private drr2 As SqlDataReader
    Private cmd As SqlCommand
    Private cnn As SqlConnection
    Private cnn2 As SqlConnection
    Private sql As String
    Private exam As String = ""
    Private program As String = ""
    Private level As Integer
    Private Period As String = ""


    Private Sub frmStudentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stud = New csStudent(StudentID)

        StudDetails = New List(Of String)

        With StudDetails


            .Add("PERSONAL DETAILS")
            .Add("Class: " & stud.Level & "." & stud.Session & " - " & stud.ClassDesc)
            .Add("Gender: " & stud.Gender)
            .Add("Age: " & DateDiff(DateInterval.Year, stud.Dob, Now.Date) & " Years")
            .Add("Address:" & stud.Address1)
            .Add("Phone Number:" & stud.ContactNumber)
            .Add("Email:" & stud.EmailAddress)

            If Not IsNothing(stud.Image) Then
                Dim imagestream As MemoryStream = New MemoryStream(stud.Image)
                imgStudDetails.Image = Image.FromStream(imagestream)
            End If

            lbStudName.Text = stud.StudentSurname & " " & stud.StudentName

        End With

        lbStudDetails.DataSource = StudDetails



        loadExams()
        LoadPrograms()
        LoadBehaviorClasses()
        LoadEnrollments()
        TcStudProfile.SelectedIndex = 1

        '   Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub LoadEnrollments()
        cnn = New SqlConnection(ConnectionString)
        Dim studclass As cClasses
        Dim studprogs As New List(Of cEnrollments)

        tvEnrollemtHistory.Nodes.Clear()



        sql = "select distinct program from enrollment where studentid = '" & StudentID & "'"

        Try
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            drr = cmd.ExecuteReader
            While drr.Read
                Dim enrolHistory As New cEnrollments
                cnn2 = New SqlConnection(ConnectionString)
                With enrolHistory
                    .Program = drr(0)
                    sql = "select e.classdesc ,e.year,e.session from enrollment E " &
                    " inner join classes C on c.description = e.classdesc " &
" where e.studentid = '" & StudentID & "' and e.program = '" & drr(0) & "'" &
" order by c.clas desc,c.sem desc"


                    cmd = New SqlCommand(sql, cnn2)
                    cnn2.Open()

                    drr2 = cmd.ExecuteReader
                    While drr2.Read
                        studclass = New cClasses
                        studclass.ClassDesc = drr2(0)
                        studclass.Lvl = drr2(1)
                        studclass.Session = drr2(2)
                        .Classes.Add(studclass)
                    End While




                End With

                studprogs.add(enrolHistory)

            End While



            For Each enrol In studprogs
                Dim prognode As New TreeNode
                prognode.Text = enrol.Program
                For Each _clas In enrol.Classes
                    prognode.Nodes.Add(_clas.Lvl & "." & _clas.Session & " " & _clas.ClassDesc)
                Next

                tvEnrollemtHistory.Nodes.Add(prognode)

            Next

            tvEnrollemtHistory.ExpandAll()


        Catch ex As Exception
        Finally
            cnn.Close()
            cnn2.Close()

        End Try



    End Sub
    Private Sub LoadBehaviorClasses()
        Dim periodcount As Integer = 0
        dgStudBehaviorClasses.Rows.Clear()
        sql = "Select distinct Behaviorclass from studbehavior where Student = '" & StudentID & "'"
        cnn = New SqlConnection(ConnectionString)
        Try
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            drr = cmd.ExecuteReader

            While drr.Read
                If periodcount = 0 Then
                    Period = drr(0)
                    LoadBehaviorReport()
                End If
                dgStudBehaviorClasses.Rows.Add(drr(0))
                periodcount += 1
            End While

        Catch ex As Exception

        End Try




    End Sub

    Private Sub LoadPrograms()

        cnn = New SqlConnection(ConnectionString)

        Dim studprogs As New List(Of cEnrollments)

        tvSubAnalysis.Nodes.Clear()
        sql = "select distinct program from enrollment where studentid = '" & StudentID & "'"

        Try


            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            drr = cmd.ExecuteReader
            While drr.Read
                Dim enrolHistory As New cEnrollments
                With enrolHistory
                    .Program = drr(0)
                    .Levels = getProgramLevels(drr(0))






                End With

                studprogs.add(enrolHistory)

            End While


            Dim progcount As Integer = 0
            For Each enrol In studprogs
                Dim prognode As New TreeNode
                prognode.Text = enrol.Program
                program = enrol.Program
                prognode.Tag = "Program"

                Dim levelcount As Integer = 0
                For Each _clas In enrol.Levels
                    level = _clas

                    Dim levelnode As New TreeNode
                    levelnode.Text = " Level " & _clas
                    levelnode.Tag = "Level"
                    levelnode.ToolTipText = _clas

                    prognode.Nodes.Add(levelnode)
                    If levelcount = 0 And progcount = 0 Then
                        tvSubAnalysis.SelectedNode = levelnode

                        '   loadSubAnalysisReport()


                    End If
                    levelcount += 1
                Next

                tvSubAnalysis.Nodes.Add(prognode)
                progcount += 1
            Next


            tvSubAnalysis.ExpandAll()
        Catch ex As Exception
        Finally
            cnn.Close()
            '        cnn2.Close()
        End Try


    End Sub



    Public Sub loadExams()
        dgProfileExams.Rows.Clear()
        '   combo.Items.Clear()
        Dim cnn As New SqlConnection(ConnectionString)

        Dim cmd As SqlCommand

        Dim sql As String
        Dim exams As SqlDataReader

        sql = "sploadProfileExams"

        Dim exmcounter As Integer = 0
        Try


            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@stud", StudentID)



            exams = cmd.ExecuteReader()

            While exams.Read
                If exmcounter = 0 Then
                    program = exams("program")
                    exam = exams("Exam")
                    LoadAcademicReport()
                End If


                dgProfileExams.Rows.Add(exams("Exam"), exams("Year") & "." & exams("Session") & " - " & exams("ClassDesc"), exams("program"))
                exmcounter += 1
            End While


        Catch ex As Exception
        Finally
            cnn.Close()

        End Try





    End Sub

    Private Sub dgProfileExams_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgProfileExams.CellContentClick
        Dim indx As Integer = e.RowIndex


        Try
            Cursor = Cursors.WaitCursor
            With dgProfileExams.Rows(indx)

                exam = .Cells("colexam").Value
                program = .Cells("colProgram").Value
                LoadAcademicReport()

            End With

        Catch ex As Exception
        Finally
            Cursor = Cursors.Default
        End Try



    End Sub

    Private Sub LoadAcademicReport()
        Me.StudentAcademicReportTableAdapter.FillByStudent(DsSchool.StudentAcademicReport, exam, StudentID)
        If program.ToUpper = "O_LEVEL" Then
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "StudentDetails.rptHsReport_Sengoda.rdlc"
        ElseIf program.ToUpper = "A_LEVEL" Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "StudentDetails.rptHsReport_Sengoda_Alevel.rdlc"
        End If

        ReportViewer1.RefreshReport()
    End Sub

    Private Sub tvSubAnalysis_AterSelect(sender As Object, e As TreeViewEventArgs) Handles tvSubAnalysis.AfterSelect
        Try
            Cursor = Cursors.WaitCursor
            If e.Node.Tag = "Level" Then



                program = e.Node.Parent.Text
                level = e.Node.ToolTipText

                loadSubAnalysisReport()


            End If

        Catch ex As Exception
        Finally
            Cursor = Cursors.Default
        End Try


    End Sub


    Private Sub loadSubAnalysisReport()
        Try



            StudentAcademicReportTableAdapter.FillByStudentProfileSubAnalysis(DsSchool.StudentAcademicReport, StudentID, program, level)
            ReportViewer2.RefreshReport()
        Catch ex As Exception

        End Try

    End Sub

    Private Function getProgramLevels(prog As String) As List(Of Integer)
        Dim Lvls As New List(Of Integer)
        Dim cnn As SqlConnection
        cnn = New SqlConnection(ConnectionString)
        Dim drr As SqlDataReader

        Try
            sql = "Select distinct [Year] from enrollment where program = '" & prog & "' and studentid = '" & StudentID & "' order by year desc"
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            drr = cmd.ExecuteReader
            While drr.Read
                Lvls.Add(drr(0))

            End While
        Catch ex As Exception
        Finally
            cnn.Close()
        End Try




        Return Lvls

    End Function

    Private Sub dgStudBehaviorClasses_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgStudBehaviorClasses.CellContentClick
        Dim indx As Integer
        indx = e.RowIndex
        Try
            Cursor = Cursors.WaitCursor
            Period = dgStudBehaviorClasses.Rows(indx).Cells(0).Value
            LoadBehaviorReport()
        Catch ex As Exception
        Finally
            Cursor = Cursors.Default
        End Try



    End Sub

    Private Sub LoadBehaviorReport()
        Try
            StudBehaviorReportTableAdapter.Fill(DsSchool.StudBehaviorReport, StudentID, "", Period, "PerTerm", "")
            ReportViewer3.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class


Public Class cEnrollments

    Public Program As String
    Public Classes As New List(Of cClasses)
    Public Levels As New List(Of Integer)


End Class

Public Class cClasses
    Public ClassDesc As String
    Public Lvl As Integer
    Public Session As String

End Class