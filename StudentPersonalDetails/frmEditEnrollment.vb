Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net
Imports System.Data
Imports Miscelleneous
Imports System.Windows.Forms

Public Class frmEditEnrollment
    Public frmmain As Form
    Private sql As String = ""
    Private blnaddingenrol As Boolean = False
    Public loadspec As Boolean = False
    Public Copy As Boolean = False
    Public mdiPrnt As Form

    Private Sub loadPrograms()
        With ProgramComboBox
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub loadSessions()
        With SessionComboBox
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub loadClasses()
        With ClassComboBox
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub EnrollmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollmentBindingNavigatorSaveItem.Click
        Dim cnn As New SqlConnection(ConnectionString)
        sql = "spInsertEnrollment"

        Dim cmd As New SqlCommand(sql, cnn)
        Try
            If Copy Then
                EnrolRefTextBox.Text = ""
            End If

            cnn.Open()
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@stud", StudentIDTextBox.Text)
                .Parameters.AddWithValue("@gender", GenderComboBox.Text)
                .Parameters.AddWithValue("@det", Date_EnrolledDateTimePicker.Value)
                .Parameters.AddWithValue("@prog", ProgramComboBox.SelectedValue.ToString)
                .Parameters.AddWithValue("@lvl", YearComboBox.Text)
                .Parameters.AddWithValue("@sess", SessionComboBox.Text)
                .Parameters.AddWithValue("@classdesc", ClassComboBox.Text)
                .Parameters.AddWithValue("@status", StatusComboBox.Text)
                .Parameters.AddWithValue("@enrolref", IIf(EnrolRefTextBox.Text = "", Guid.NewGuid, EnrolRefTextBox.Text))
                .Parameters.AddWithValue("@enroltype", StatusComboBox.Text)
                .ExecuteNonQuery()
                MsgBox("Enrollment Saved")
                blnaddingenrol = False

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            blnaddingenrol = True
        Finally
            cnn.Close()
        End Try


    End Sub

    Private Sub frmEditEnrollment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'TODO: This line of code loads data into the 'DsSchool.forms' table. You can move, or remove it, as needed.
            MdiParent = frmmain
            loadPrograms()
            loadSessions()
            loadClasses()

            If loadspec Then
                Try
                    Me.LoadEnrollmentsTableAdapter.FillByStud(Me.DsSchool.LoadEnrollments, enrollment.Student, enrollment.enrolref)
                Catch ex As Exception

                End Try
            ElseIf Copy Then
                LoadEnrollmentsBindingSource.AddNew()

                With enrollment
                    StudentIDTextBox.Text = .Student
                    ProgramComboBox.Text = .Program
                    GenderComboBox.Text = .gender
                    YearComboBox.Text = .Level

                    ClassComboBox.Text = .Clas

                    SessionComboBox.Text = .Session

                    StatusComboBox.Text = .Status
                    Date_EnrolledDateTimePicker.Value = Now.Date
                    EnrolRefTextBox.Text = .enrolref

                End With

            End If


        Catch ex As Exception

        End Try


        'TODO: This line of code loads data into the 'DsSchool.schoolsessions' table. You can move, or remove it, as needed.


    End Sub





    Private Sub lstResult_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstResult.DoubleClick
        Try

            Dim searchstring As String
            searchstring = lstResult.SelectedValue
            lstResult.DataSource = Nothing
            lstResult.Visible = False
            Try
                LoadEnrollmentsTableAdapter.FillByStud(DsSchool.LoadEnrollments, searchstring, "")
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub





    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        blnaddingenrol = True
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim serchtext As String = Trim(txtStudSearch.Text)
        lstResult.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Try


            cnn.Open()

            Dim filter As String = " where concat(s.studentid , ' ' , studentname , ' ' , studentsurname) like '%" & serchtext & "%'"

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
    End Sub

    Private Sub ToolStripButtonDelete_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDelete.Click

        If Not blnaddingenrol Then
            Dim cnn As New SqlConnection(ConnectionString)
            sql = "spDeleteEnrollment"
            Dim cmd As New SqlCommand(sql, cnn)
            Try
                cnn.Open()
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@stud", StudentIDTextBox.Text)
                    .Parameters.AddWithValue("@enrolref", EnrolRefTextBox.Text)
                    .ExecuteNonQuery()
                    MsgBox("Record Deleted")
                    LoadEnrollmentsTableAdapter.FillByStud(DsSchool.LoadEnrollments, StudentIDTextBox.Text, "")
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        Else
            MsgBox("Operation can not be carried out")
        End If

    End Sub
End Class