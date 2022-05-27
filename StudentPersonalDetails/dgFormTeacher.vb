Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System
Imports Miscelleneous

Public Class dgFormTeacher
    Public program As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Dim formatedcomment As String
        'Dim level, session, semester, clas As String
        'Dim cnn As SqlConnection = New SqlConnection(ConnectionString)
        'If rbOneChild.Checked Then
        '    If Trim(txtTeacher.Text) = "" Then
        '        MsgBox("Enter form teacher")
        '        Exit Sub
        '    End If

        '    formatedcomment = Trim(txtComment.Text)


        '    Dim sql As String = "Update studentmarks set formteacher = '" & txtTeacher.Text & "' , formteachercomment = @comment where studentid = '" & FrmStudent.gdStudents.SelectedRows(0).Cells(0).Value & "' and rerefencename = '" & FrmStudent.cboMarkExam.Text & "'"

        '    Dim cmd As New SqlCommand
        '    cmd.CommandText = sql
        '    cmd.Parameters.AddWithValue("@comment", formatedcomment)
        '    cmd.Connection = cnn
        '    cnn.Open()
        '    Try
        '        cmd.ExecuteNonQuery()
        '        cnn.Close()
        '        MsgBox("Form Teacher Comment Successfully added")
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        cnn.Close()
        '    End Try




        'Else
        '    If Trim(txtTeacher.Text) = "" Then
        '        MsgBox("Enter form teacher")
        '        Exit Sub
        '    End If
        '    formatedcomment = Trim(txtComment.Text)
        '    If InStr(formatedcomment, "'") > 0 Then
        '        MsgBox("The use of Single or double quotes is not allowed in comments ")
        '        Exit Sub
        '    End If
        '    Dim drr As SqlDataReader
        '    Dim sql As String = "select year ,session,semester,[Year Joined  joined] from studentpersonaldetails where studentid = '" & FrmStudent.gdStudents.SelectedRows(0).Cells(0).Value & "'"
        '    drr = ExecuteReader(sql, , True)

        '    While drr.Read

        '        level = drr(0)
        '        session = drr(1).ToString
        '        semester = drr(2).ToString
        '        clas = drr(3).ToString

        '    End While

        '    sql = "select studentid from studentpersonaldetails where year = '" & level & "' and session = '" & session & "' and semester = '" & semester & "' and [Year Joined  joined] = '" & clas & "'"
        '    drr = ExecuteReader(sql, , True)

        '    While drr.Read
        '        sql = "Update studentmarks set formteacher = '" & txtTeacher.Text & "' , formteachercomment = @comment where studentid = '" & drr(0).ToString & "' and rerefencename = '" & FrmStudent.cboMarkExam.Text & "'"
        '        Dim cmd As New SqlCommand
        '        cmd.CommandText = sql
        '        cmd.Parameters.AddWithValue("@comment", formatedcomment)
        '        cmd.Connection = cnn
        '        cnn.Open()
        '        Try
        '            cmd.ExecuteNonQuery()
        '            cnn.Close()
        '            '  MsgBox("Form Teacher Comment Successfully added")
        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '            cnn.Close()
        '        End Try
        '    End While
        '    MsgBox("Update successfull")

        'End If


        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dgFormTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsReports.HsExamMarks' table. You can move, or remove it, as needed.

        'Dim studid, name, surname, teacher, comment, exam As String

        'studid = FrmStudent.gdStudents.SelectedRows(0).Cells(0).Value
        'Dim sql As String = "select forms.section   from studentpersonaldetails " & _
        '" inner join forms on forms.forms = studentpersonaldetails.program and studentid = '" & studid & "' " & _
        ' " where studentid = '" & studid & "'"
        'program = ExecuteScalar(sql, True)

        'name = FrmStudent.gdStudents.SelectedRows(0).Cells(1).Value
        'surname = FrmStudent.gdStudents.SelectedRows(0).Cells(2).Value
        'exam = FrmStudent.cboMarkExam.Text

        'lbStud.Text = name & " " & surname & "'s Comment"
        'Me.HsExamMarksTableAdapter.FillByStud(Me.dsReports.HsExamMarks, "", program, exam, studid)

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub txtTeacher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeacher.TextChanged
        'Dim drr As SqlDataReader
        'lbTeacher.Visible = True
        'Dim sql As String = " select staffID,name,surname,stafftype from staffpersonaldetails where  name + ' ' + surname like '%" & txtTeacher.Text & "%'"
        'drr = ExecuteReader(sql)
        'While drr.Read
        '    lbTeacher.Items.Add(drr(0).ToString & " " & drr(1).ToString & " " & drr(2).ToString)
        'End While
    End Sub

    Private Sub lbTeacher_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'Try
        '    txtTeacher.Text = lbTeacher.SelectedItem.ToString
        '    lbTeacher.Items.Clear()
        '    Try
        '        Dim a, b As Integer
        '        Dim searchstring As String
        '        b = InStr(Trim(txtTeacher.Text), " ")
        '        searchstring = Mid(Trim(txtTeacher.Text), 1, b - 1)
        '        txtTeacher.Text = searchstring

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        '    lbTeacher.Visible = False
        'Catch ex As Exception

        'End Try
    End Sub


    Private Sub lbTeacher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
