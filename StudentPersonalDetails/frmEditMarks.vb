Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Imports System.Windows.Forms
Imports System.Linq
Imports Miscelleneous


Public Class frmEditMarks

    Public frmmain As Form
    Public usrgroup As String
    Public usr As String


    Public Sub New()


        InitializeComponent()



    End Sub





    Private Sub loadprograms()
        With cboEditMarksProg
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Public Sub loadExams(ByVal combo As ComboBox, stud As String)
        combo.DataSource = Nothing
        '   combo.Items.Clear()

        Dim sql As String
        Dim exams As SqlDataReader
        sql = " select distinct exam from studentmarks  where studentid = '" & stud & "'"

        exams = ExecuteReader(sql,, True)
        Dim state As New List(Of ComboItem)
        While exams.Read

            state.Add(New ComboItem(exams(0).ToString, exams(0).ToString))

        End While

        If state.Count > 0 Then

            combo.DataSource = state

            combo.ValueMember = "Value"
            combo.DisplayMember = "Text"
            combo.SelectedIndex = 0
        End If





    End Sub


    Public Function fillmarks(ByVal stud As String, ByVal exam As String, ByVal program As String)
        Dim sql As String
        Dim drr As SqlDataReader
        dgeditmarks.Rows.Clear()
        Dim cnt As Integer = 0

        Dim cnn As New SqlConnection(ConnectionString)
        Try

            Dim cmd As New SqlCommand
            cnn.Open()
            cmd.CommandText = "spGetStudMarksForEdit"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@program", program)
            cmd.Parameters.AddWithValue("@exam", exam)
            cmd.Parameters.AddWithValue("@stud", stud)

            drr = cmd.ExecuteReader
            If drr.HasRows Then
                While drr.Read


                    dgeditmarks.Rows.Add()
                    With dgeditmarks.Rows(cnt)
                        .Cells("Rownumber").Value = cnt + 1
                        .Cells("subject").Value = drr("Subject")
                        .Cells("SubType").Value = drr("Type")
                        .Cells("Level").Value = drr("Year")
                        .Cells("Sem").Value = drr("Sem")
                        .Cells("CourseMark").Value = drr("CourseMark")
                        .Cells("EM").Value = drr("ExamMark").ToString
                        .Cells("FinalMark").Value = drr("FinalMark").ToString
                        .Cells("SubPoints").Value = drr("Points").ToString
                        .Cells("Grade").Value = drr("Decision").ToString()
                        .Cells("Status").Value = drr("ExamStatus").ToString()


                        .Cells("exam").Value = drr("Exam").ToString


                        .Cells("Comment").Value = drr("Comment").ToString
                        .Cells("Effort").Value = drr("Effort").ToString
                        .Cells("Ref").Value = drr("MarkRef").ToString
                        .Cells("MarkEnrolRef").Value = drr("MarkEnrolRef").ToString
                        .Cells("Comment").ReadOnly = CBool(drr("MultiComment").ToString)
                        cnt += 1
                    End With
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try




    End Function



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try


            'TODO: This line of code loads data into the 'DsStudentSearches.StudentMarks' table. You can move, or remove it, as needed.
            ' Me.StudentMarksTableAdapter.Fill(Me.DsStudentSearches.StudentMarks)
            gblDelMarks = False
            ' MdiParent = Student

            dgeditmarks.Rows.Clear()

        Catch ex As Exception

        End Try

        'TODO: This line of code loads data into the 'DsStudentSearches.StudentMarks' table. You can move, or remove it, as needed.
        ' Me.StudentMarksTableAdapter.Fill(Me.DsStudentSearches.StudentMarks)

    End Sub



    Private Function getSubPoints(subj As String, finalmark As Double) As Integer
        Dim pnts As Integer = 0
        Dim sql As String

        If finalmark <= 49 Then
            Return pnts
        Else
            sql = "select credits from subjects where subjectid = '" & subj & "'"
            pnts = ExecuteScalar(sql, True)
            Return pnts

        End If

    End Function

    Private Sub editmarkrow(ByVal rownumber As Integer)

        Dim exammark, coursemark, finalmark As Double
        Dim Decision, Exam, ExamStatus, subject, program, comment, studentid, subtype, effort As String
        Dim ref, markenrolref As String
        Dim lvl, sem As Integer
        Dim Points As Integer
        Dim sql As String
        Dim a, b As Integer




        exammark = dgeditmarks.Rows(rownumber).Cells("EM").Value
        subject = CleanComboVal(dgeditmarks.Rows(rownumber).Cells("Subject").Value)
        program = cboEditmarksprog.SelectedValue
        ref = dgeditmarks.Rows(rownumber).Cells("Ref").Value
        markenrolref = dgeditmarks.Rows(rownumber).Cells("MarkEnrolRef").Value
        coursemark = dgeditmarks.Rows(rownumber).Cells("CourseMark").Value
        Exam = dgeditmarks.Rows(rownumber).Cells("Exam").Value
        comment = dgeditmarks.Rows(rownumber).Cells("Comment").Value
        lvl = dgeditmarks.Rows(rownumber).Cells("Level").Value
            sem = dgeditmarks.Rows(rownumber).Cells("Sem").Value
            ExamStatus = dgeditmarks.Rows(rownumber).Cells("Status").Value
            subtype = dgeditmarks.Rows(rownumber).Cells("SubType").Value
        effort = dgeditmarks.Rows(rownumber).Cells("Effort").Value
        studentid = txtStudEditMarks.Text


        sql = "sp_EnterMarks"

        params = New List(Of SqlParameter)
        param = New SqlParameter("@Student", studentid)
        params.Add(param)



        param = New SqlParameter("@coursemark", coursemark)
        params.Add(param)

        param = New SqlParameter("@exammark", exammark)
        params.Add(param)

        param = New SqlParameter("@subject", subject)
        params.Add(param)

        param = New SqlParameter("@examsession", Exam)
        params.Add(param)

        param = New SqlParameter("@user", goUser.FullName)
        params.Add(param)


        param = New SqlParameter("@examstatus", ExamStatus)
        params.Add(param)

        'param = New SqlParameter("@subtype", subtype)
        'params.Add(param)

        param = New SqlParameter("@ref", ref)
        params.Add(param)


        param = New SqlParameter("@comment", comment)
        params.Add(param)


        param = New SqlParameter("@enrolref", markenrolref)
        params.Add(param)

        param = New SqlParameter("@effort", effort)
        params.Add(param)

        ExecuteNonQuery(sql, , True, , , , , params, False)

        If era = False Then
            ' Me.StudentMarksTableAdapter.Update(DsStudentSearches.StudentMarks)
            MsgBox("Mark row " & rownumber + 1 & "  Successfully edited")
        Else
            MsgBox(eramsg)
            MsgBox("Error editing row " & rownumber + 1)
        End If











    End Sub


    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gblDelMarks = True
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub




    Private Sub lstResult_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim stud As String
        Try
            stud = lstResult.SelectedValue
            lstResult.DataSource = Nothing

            lstResult.Visible = False

            txtStudEditMarks.Text = stud
            loadExams(cboEditMarksRef, stud)
        Catch ex As Exception

        End Try
    End Sub










    Private Sub lstResult_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs)
        lstResult_DoubleClick(Me, Nothing)
    End Sub






    Private Sub deletemarkrow(ByVal rownumber As Integer)



        Dim student, ref As String
            Dim cmd As New SqlCommand
            Dim cnn As New SqlConnection(ConnectionString)
        Try
            student = txtStudEditMarks.Text
            ref = dgeditmarks.Rows(rownumber).Cells("Ref").Value


            cmd.CommandText = "spDeleteMarks"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@stud", student)
            cmd.Parameters.AddWithValue("@ref", ref)
            cmd.Parameters.AddWithValue("@user", goUser.userName)
            cnn.Open()






            cmd.ExecuteNonQuery()


            MsgBox("Mark row " & rownumber + 1 & " successfully deleted")
        Catch ex As Exception
            MsgBox("Failed to delete item " & ex.Message)
        Finally
            cnn.close()

        End Try


    End Sub

    Private Sub cboEditMarksStudId_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstResult_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstResult.SelectedIndexChanged

    End Sub

    Private Sub lstResult_DoubleClick_1(sender As Object, e As EventArgs) Handles lstResult.DoubleClick
        lstResult_DoubleClick(Me, Nothing)
    End Sub

    Private Sub cboEditmarksprog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEditMarksRef.SelectedIndexChanged
        Try
            Dim cnt As Integer = 0

            Dim combo As ComboBox = sender
            Dim searchstring As String

            Dim marks As SqlDataReader
            Dim a, b As Integer


            searchstring = txtStudEditMarks.Text


            fillmarks(searchstring, cboEditMarksRef.Text, cboEditMarksProg.SelectedValue)


            'For i = 0 To dgeditmarks.Rows.Count - 2 
            '    dgeditmarks.Rows(i).Cells("Exam").Value = cboEditMarksRef.SelectedValue
            'Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmEditMarks_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSchool.ExamSessions' table. You can move, or remove it, as needed.
        Me.ExamSessionsTableAdapter.Fill(Me.DsSchool.ExamSessions)
        'TODO: This line of code loads data into the 'DsSchool.ExamSessions' table. You can move, or remove it, as needed.
        Me.ExamSessionsTableAdapter.Fill(Me.DsSchool.ExamSessions)
        'TODO: This line of code loads data into the 'DsSchool.ExamSessions' table. You can move, or remove it, as needed.
        'Me.ExamSessionsTableAdapter.Fill(Me.DsSchool.ExamSessions)
        'TODO: This line of code loads data into the 'DsSchool1.ExamSessions' table. You can move, or remove it, as needed.
        '    Me.ExamSessionsTableAdapter.Fill(Me.DsSchool1.ExamSessions)
        'TODO: This line of code loads data into the 'DsSchool1.forms' table. You can move, or remove it, as needed.
        '       Me.FormsTableAdapter.Fill(Me.DsSchool1.forms)
        loadprograms()

    End Sub

    Private Sub dgeditmarks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgeditmarks.CellContentClick
        Try
            Dim indx As Integer = dgeditmarks.CurrentRow.Index
            If dgeditmarks.CurrentCell.Value.ToString = "Save" Then

                editmarkrow(indx)
                cboEditmarksprog_SelectedIndexChanged(cboEditMarksRef, Nothing)
                '   ChangeRowColor(indx, Drawing.Color.White)

            ElseIf dgeditmarks.CurrentCell.Value.ToString = "Delete" Then
                If MsgBox("This will delete marks for " & dgeditmarks.Rows(indx).Cells("Subject").Value & " , do you want to proceed", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    deletemarkrow(indx)
                    cboEditmarksprog_SelectedIndexChanged(cboEditMarksRef, Nothing)

                End If
                '    ChangeRowColor(indx, Drawing.Color.White)
            Else
                '   ChangeRowColor(indx, Drawing.Color.Yellow)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChangeRowColor(rownumber As Integer, bgcolor As Drawing.Color)
        dgeditmarks.Rows(rownumber).Cells("EM").Style.BackColor = bgcolor
        dgeditmarks.Rows(rownumber).Cells("CourseMark").Style.BackColor = bgcolor
        dgeditmarks.Rows(rownumber).Cells("Level").Style.BackColor = bgcolor
        dgeditmarks.Rows(rownumber).Cells("Sem").Style.BackColor = bgcolor
        dgeditmarks.Rows(rownumber).Cells("Subject").Style.BackColor = bgcolor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i = 0 To dgeditmarks.Rows.Count - 1
            editmarkrow(i)
        Next
        cboEditmarksprog_SelectedIndexChanged(cboEditMarksRef, Nothing)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgeditmarks.SelectedRows.Count > 0 Then
            If MsgBox("This will delete the selected rows ,Do you want to proceed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For i = 0 To dgeditmarks.Rows.Count - 2

                    If dgeditmarks.Rows(i).Selected Then
                        deletemarkrow(i)
                    End If
                Next
                cboEditmarksprog_SelectedIndexChanged(cboEditMarksRef, Nothing)
            End If
        Else
            MsgBox("No Row has been selected")
        End If


    End Sub



    Private Sub dgeditmarks_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgeditmarks.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtStudEditMarks_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudEditMarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim serchtext As String = Trim(txtStudEditMarks.Text)
            lstResult.DataSource = Nothing
            Dim dsApps As New DataSet()
            Dim taApps As SqlDataAdapter = Nothing
            Dim cmd As New SqlCommand
            Dim cnn As New SqlConnection(ConnectionString)

            Try


                cnn.Open()

                Dim filter As String = " where concat(s.studentid , ' ' , studentname , ' ' , studentsurname) like '%" & serchtext & "%' and s.program ='" & cboEditMarksProg.SelectedValue & "'"

                cmd.CommandText = "spMainScreenStudentSearch"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@filter", filter)



                lstResult.Visible = True

                taApps = New SqlDataAdapter(cmd)
                taApps.Fill(dsApps)

                lstResult.DataSource = dsApps.Tables(0)
                lstResult.DisplayMember = "StudName"
                lstResult.ValueMember = "StudentID"

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                cnn.Close()

            End Try
        End If
    End Sub

    Private Sub dgeditmarks_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgeditmarks.RowsAdded
        'Try
        '    Dim cboExam As DataGridViewComboBoxCell = CType(dgeditmarks.Rows(e.RowIndex).Cells("exam"), DataGridViewComboBoxCell)
        '    cboExam.DataSource = ChildExams()
        '    cboExam.DisplayMember = "Text"
        '    cboExam.ValueMember = "Value"
        'Catch ex As Exception

        'End Try
    End Sub
End Class



