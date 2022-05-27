Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net
Imports System.Data

Imports Miscelleneous
Imports System.Windows.Forms

'Imports SGFPLIBXLib

Public Class frmStaffDetails
    Public frmmain As Form
    Private addinstaff As Boolean = False
    Dim secndcount As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub




    Private Sub StaffDetails_Load() Handles MyBase.Load

        'TODO: This line of code loads data into the 'DsSchool.StaffPersonalDetails' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsSchool.schoolsessions' table. You can move, or remove it, as needed.

        loadsets()
        'TODO: This line of code loads data into the 'DsSchool.StaffSubjectsTaught' table. You can move, or remove it, as needed.
        LoadCombos()

        Prepareform(Me, frmmain, False)
        MdiParent = frmmain






    End Sub

    Private Sub LoadLogins()
        With cboLoginID
            .DataSource = UserLogins(False)
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub loadPrograms()
        'With acaformComboBox
        '    .DataSource = Programs()
        '    .DisplayMember = "Text"
        '    .ValueMember = "Value"
        'End With
    End Sub

    Private Sub LoadClasses()
        With cboSubTeachersbyClass
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadSessions()
        'With accaSession
        '    .DataSource = SchoolSessions()
        '    .DisplayMember = "Text"
        '    .ValueMember = "Value"
        'End With
    End Sub

    Private Sub LoadCombos()
        LoadLogins()
        loadPrograms()
        LoadClasses()
        LoadSessions()
    End Sub

    Private Sub loadsets()
        Try
            Me.StaffPersonalDetailsTableAdapter.Fill(Me.DsSchool.StaffPersonalDetails)
            'TODO: This line of code loads data into the 'DsSchool.schoolsessions' table. You can move, or remove it, as needed.
            Me.SchoolsessionsTableAdapter.Fill(Me.DsSchool.schoolsessions)
            'TODO: This line of code loads data into the 'DsSchool.Classes' table. You can move, or remove it, as needed.
            Me.ClassesTableAdapter.Fill(Me.DsSchool.Classes)
            'TODO: This line of code loads data into the 'DsSchool.forms' table. You can move, or remove it, as needed.
            Me.FormsTableAdapter.Fill(Me.DsSchool.forms)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim sql As String
        Dim trans As SqlTransaction = Nothing
        a = dgSubsTaught.Rows.Count

        Dim subject, program, session, lvl, cls As String

        cnn = New SqlConnection(ConnectionString)
        Try


            cnn.Open()

            trans = cnn.BeginTransaction()

            sql = "delete staffsubjectstaught where staffid = '" & staffID.Text & "' "

            cmd = New SqlCommand(sql, cnn, trans)
            cmd.ExecuteNonQuery()
            For b1 = 0 To a - 2

                With dgSubsTaught
                    program = .Rows(b1).Cells("SubTaughtProgram").Value
                    cls = .Rows(b1).Cells("SubTaughtClass").Value
                    session = .Rows(b1).Cells("SubTaughtSession").Value
                    lvl = .Rows(b1).Cells("SubTaughtLevel").Value
                    subject = .Rows(b1).Cells("SubTaughtSubject").Value

                End With

                If subject = "" Or IsNothing(subject) Then
                    Throw New Exception("Inavlid Subject at Line " & b1 + 1)
                End If
                If program = "" Or IsNothing(program) Then
                    Throw New Exception("Inavlid Program at Line " & b1 + 1)
                End If
                If cls = "" Or IsNothing(cls) Then
                    Throw New Exception("Inavlid Class at Line " & b1 + 1)
                End If
                If lvl = "" Or IsNothing(lvl) Then
                    Throw New Exception("Inavlid Level at Line " & b1 + 1)
                End If



                sqltext = "spInsertStaffSubjectsTaught"
                cmd = New SqlCommand(sqltext, cnn, trans)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@staff", staffID.Text)
                    .Parameters.AddWithValue("@subjectid", subject)
                    .Parameters.AddWithValue("@lvl", lvl)
                    .Parameters.AddWithValue("@prog", program)
                    .Parameters.AddWithValue("@classdesc", cls  )
                    .Parameters.AddWithValue("@sess", session)
                    .ExecuteNonQuery()
                End With

            Next
            trans.Commit()
            MsgBox("Staff Classes Successfully updated")
            LoadStaffSubjects(staffID.Text, cls)
        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        Finally
            cnn.Close()


        End Try


    End Sub

    Private Sub staffID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles staffID.TextChanged

    End Sub








    Private Sub TreeView5_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        If e.Node.Text = "Home" Then
            frmmain.Show()
            Me.Close()
        ElseIf e.Node.Text = "Students Section" Then
            'Student.Show()
            Me.Close()
        End If
    End Sub

















    Private Sub ToolStripButton14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StaffDetails_Load()
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StaffDetails_Load()
    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StaffDetails_Load()
    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StaffDetails_Load()
    End Sub

    Private Sub ToolStripButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton18.Click
        StaffDetails_Load()
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        'OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox13.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




















    Private Sub StaffPersonalDetailsBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffPersonalDetailsBindingNavigatorSaveItem.Click
        Dim trans As SqlTransaction
        cnn = New SqlConnection(ConnectionString)
        Dim dob, DateEnrolled As Date
        If Not Date.TryParse(Date_EnrolledMaskedTextBox.Text, dob) Then
            MsgBox("Invalid Date Of Birth")
            Exit Sub
        End If
        If Not Date.TryParse(MaskedTextBox1.Text, DateEnrolled) Then
            MsgBox("Invalid Date Joined Institution")
            Exit Sub
        End If
        Dim imgiostream As New MemoryStream()
        Dim imgbytes() As Byte

        Dim SavedStaff As String
        Try

            cnn.Open()
            trans = cnn.BeginTransaction
            sqltext = "spInsertStaff"
            cmd = New SqlCommand(sqltext, cnn, trans)

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@StaffID", StaffIDTextBox.Text)
                .Parameters.AddWithValue("@title", ComboBox1.Text)
                .Parameters.AddWithValue("@staffname", NameTextBox.Text)
                .Parameters.AddWithValue("@staffsurname", SurnameTextBox.Text)
                .Parameters.AddWithValue("@gender", GenderComboBox.Text)
                .Parameters.AddWithValue("@stafftype", StaffTypeComboBox.Text)
                .Parameters.AddWithValue("@dob", dob)
                .Parameters.AddWithValue("@natid", IDNumberTextBox.Text)
                .Parameters.AddWithValue("@address1", Residential_AddressTextBox.Text)
                .Parameters.AddWithValue("@contnumber", ContactTextBox1.Text)
                .Parameters.AddWithValue("@emailadd", Email_adrressTextBox.Text)
                .Parameters.AddWithValue("@nokname", TextBox5.Text)
                .Parameters.AddWithValue("@nokaddress", TextBox8.Text)
                .Parameters.AddWithValue("@nokcontnumber", TextBox9.Text)
                .Parameters.AddWithValue("@relationship", TextBox7.Text)
                .Parameters.AddWithValue("@dateenrolled", DateEnrolled)
                .Parameters.AddWithValue("@bankname", "")
                .Parameters.AddWithValue("@bankAccName", "")
                .Parameters.AddWithValue("@bankAccNumber", "")
                .Parameters.AddWithValue("@bankBranch", "")
                .Parameters.AddWithValue("@staffimageurl", "")
                .Parameters.AddWithValue("@loginID", cboLoginID.Text)
                .Parameters.AddWithValue("@Department", DepartmentComboBox.Text)
                .Parameters.AddWithValue("@Contract", ContractComboBox.Text)
                .Parameters.AddWithValue("@ref", IIf(TextBox1.Text = "", Guid.NewGuid, TextBox1.Text))

                imgbytes = getimage(PictureBox13)

                If Not IsNothing(imgbytes) Then
                    .Parameters.AddWithValue("@img", imgbytes)
                Else
                    Dim par As New SqlParameter("@img", SqlDbType.Image)
                    With par
                        .Value = DBNull.Value

                    End With
                    .Parameters.Add(par)
                End If

                Dim param As New SqlParameter()
                With param
                    .ParameterName = "@SavedStaff"
                    .DbType = DbType.String
                    .Size = 50
                    .Direction = ParameterDirection.Output
                End With
                .Parameters.Add(param)

                .ExecuteNonQuery()

                SavedStaff = .Parameters("@savedstaff").Value

                trans.Commit()
                MsgBox("Staff ID " & SavedStaff & " Successfully Saved")

                Me.StaffPersonalDetailsTableAdapter.FillByStaffID(DsSchool.StaffPersonalDetails, SavedStaff)

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        Finally
            cnn.Close()

        End Try
    End Sub



    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        addinstaff = True

    End Sub




    Private Sub lstResult_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstResult.DoubleClick

        Dim staff As String
        Try
            staff = lstResult.SelectedValue
            lstResult.DataSource = Nothing
            lstResult.Visible = False
            ttxSearchtext.Text = staff
            Me.StaffPersonalDetailsTableAdapter.FillByStaffID(DsSchool.StaffPersonalDetails, staff)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub lbSubTaughtSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbSubTaughtSearch.DoubleClick
        Dim a, b As Integer
        Dim searchstring As String
        Try
            searchstring = lbSubTaughtSearch.SelectedValue
            lbStaffName.Text = lbSubTaughtSearch.GetItemText(lbSubTaughtSearch.SelectedItem)
            staffID.Text = searchstring
            lbSubTaughtSearch.DataSource = Nothing
            lbSubTaughtSearch.Visible = False
        Catch ex As Exception

        End Try

        '    getProgramsubjects()
        LoadStaffSubjects(staffID.Text, cboSubTeachersbyClass.Text)




    End Sub





    Private Sub Subjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            staffID.Text = lstResult.SelectedItem.ToString
            lbSubTaughtSearch.Items.Clear()
            'search()
            lstResult.Visible = False
        Catch ex As Exception

        End Try
    End Sub


    Private Sub acaformComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '     getProgramsubjects()


        '  LoadStaffSubjects(staffID.Text)

    End Sub

    Private Sub LoadStaffSubjects(staffid As String, clas As String)
        dgSubsTaught.Rows.Clear()

        Dim rows As Integer = 0
        cnn = New SqlConnection(ConnectionString)
        Try


            cnn.Open()
            sqltext = "spGetStaffSubjects"
            cmd = New SqlCommand(sqltext, cnn)
            Dim subs As SqlDataReader
            With cmd
                .CommandType = CommandType.StoredProcedure

                .Parameters.AddWithValue("@staff", staffid)
                .Parameters.AddWithValue("@clas", clas)
                subs = .ExecuteReader()
                If subs.HasRows Then
                    While subs.Read
                        With dgSubsTaught
                            .Rows.Add()
                            .Rows(rows).Cells("SubTaughtProgram").Value = subs("Form")

                            Dim cmblvl As DataGridViewComboBoxCell = CType(.Rows(rows).Cells("SubTaughtLevel"), DataGridViewComboBoxCell)
                            cmblvl.DataSource = Ints()
                            cmblvl.DisplayMember = "Text"
                            cmblvl.Value = "Value"
                            cmblvl.Value = subs("Year")
                            .Rows(rows).Cells("SubTaughtSession").Value = subs("Session")
                            .Rows(rows).Cells("SubTaughtClass").Value = subs("ClassDesc")
                            .Rows(rows).Cells("SubTaughtSubject").Value = subs("SubjectID")
                            rows += 1
                        End With

                    End While
                End If


            End With

        Catch ex As Exception
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub getProgramsubjects(prog As String)



        params = New List(Of SqlParameter)
        cnn = New SqlConnection(ConnectionString)

        Dim subs As SqlDataReader
        Try


            cnn.Open()
            sqltext = "spGetProgramSubjects"

            cmd = New SqlCommand(sqltext, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            param = New SqlParameter("@prog", program)
            cmd.Parameters.Add(param)

            subs = cmd.ExecuteReader

            While subs.Read


            End While
        Catch ex As Exception
        Finally
            cnn.Close()
        End Try
    End Sub






    Private Sub termComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    LoadStaffSubjects(staffID.Text)
    End Sub


    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffTabControl.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim sql As String
        Dim res As String = MsgBox("Are you sure you want to delete current record", MsgBoxStyle.YesNo)
        If res = "6" Then

            sql = "delete from staffpersonaldetails where staffid = '" & StaffIDTextBox.Text & "'"
            ExecuteNonQuery(sql)
            If era = False Then
                Me.StaffPersonalDetailsTableAdapter.Fill(Me.DsSchool.StaffPersonalDetails)
                MsgBox("Record successfully deleted")

            End If
        End If
    End Sub

    Private Sub ReligionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ttxSearchtext.Clear()
        lstResult.Visible = False
    End Sub

    Private Sub lstResult_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstResult.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim file_name2 As String = ""
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        ' OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file_name2 = OpenFileDialog1.FileName
        Else
            Exit Sub

        End If

        Dim theLine As String = ""
        Dim arrSplt() As String
        Dim Fullname, Mobile, adress, gender, studentid, guardian, name, surname, ecnumber, idnumber, staff_id, stafftype, designation, subtaught, TITLE As String
        Dim date_enrolled As Date

        Dim oReader As New System.IO.StreamReader(file_name2)
        Dim count As Integer = 0







        While oReader.Peek <> -1
            Try
                theLine = oReader.ReadLine()
                arrSplt = theLine.Split("|")
                Fullname = Trim(arrSplt(0)).ToUpper
                'name = Trim(arrSplt(1)).ToUpper
                ' surname = Trim(arrSplt(0)).ToUpper
                ' gender = arrSplt(1)
                ' ecnumber = arrSplt(2)
                ' idnumber = arrSplt(3)
                stafftype = "PRIVATE"
                designation = "TEACHER"

                'adress = Trim(arrSplt(2)).ToUpper
                '  Mobile = "263" & Trim(arrSplt(7))
                '  subtaught = arrSplt(6)
                'guardian = ""
                date_enrolled = changedate(Now.Date)
                Dim drr1, DRR3 As SqlDataReader
                Dim drr As String
                Dim sql4 As String = ""
                Dim SUFIX As String
                Dim prefix As String
                Dim LENGTH As Integer
                Dim sql As String



                sql = "select max(cast (staffid as int)) from staffpersonaldetails"
                'drr = ExecuteScalar(sql)
                Try
                    drr = ExecuteScalar(sql)
                    staff_id = drr + 1

                Catch ex As Exception
                    staff_id = 1
                End Try



                Dim POS As Integer = InStr(Fullname, " ")
                TITLE = Mid(Fullname, 1, POS)
                surname = Mid(Fullname, POS + 1)
                name = ""
                If Trim(TITLE.ToUpper) = "MR" Then
                    gender = "M"
                Else
                    gender = "F"
                End If
                Dim staffrow As dsSchool.StaffPersonalDetailsRow

                staffrow = DsSchool.StaffPersonalDetails.NewRow
                staffrow.staffID = staff_id
                staffrow.StaffType = stafftype
                staffrow.Department = designation
                staffrow.Gender = gender
                '  staffrow.Religion = ecnumber
                '  staffrow.IDNumber = idnumber
                staffrow.DateJoinedSchool = date_enrolled
                staffrow.Surname = surname
                staffrow.Name = name
                staffrow.Title = Trim(TITLE)
                ' staffrow.noksurname = subtaught



                Try
                    DsSchool.StaffPersonalDetails.Rows.Add(staffrow)
                    StaffPersonalDetailsTableAdapter.Update(DsSchool.StaffPersonalDetails)
                    count = count + 1
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try



            Catch

            End Try
        End While


        MsgBox(count & " staff successfully imported")
    End Sub







    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        studprnt = False
        enrolform = False
        receiptprnt = False
        lectprnt = True
        gstrstaffid = StaffIDTextBox.Text
        '  frmReportPreview.Show()
    End Sub

    Private Sub SurnameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SurnameTextBox.KeyDown
        If e.KeyCode = Keys.F1 Then


        End If
    End Sub

    Private Sub SurnameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SurnameTextBox.TextChanged

    End Sub

    'Private Sub PictureBox_v_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim temp_v(400) As Byte
    '    Dim iError As Int32
    '    Dim img_qlty As Int32
    '    Dim m_FPM As SGFingerPrintManager
    '    ' m_FPM = New SGFingerPrintManager
    '    '  Dim pinfo As SGFPMDeviceInfoParam

    '    ' Dim iError As Int32
    '    'pInfo = New SGFPMDeviceInfoParam
    '    'pInfo = New SGFPMDeviceInfoParam

    '    'Dim pInfo As SGFPMDeviceInfoParam
    '    'Dim iError As Int32
    '    ' m_FPM = New SGFingerPrintManager
    '    Dim scanfing As New scana


    '        scanfing.init()

    '        scanfing.open_device()

    '        If cnctera Then
    '            MsgBox("Initialisation error ")
    '    'Timer1.Enabled = False
    '            lbTimer.Text = "Timer Disabled"
    '            Exit Sub

    '        Else
    '    'Timer1.Enabled = True
    '        End If
    '    'scanfing.get_info()
    '        scanfing.DrawImage(scanfing.get_info(), PictureBox_v)
    '        If drawera Or getinfoera Then
    '    '    MsgBox("Failed to scan image")
    '            Exit Sub
    '        End If

    '    Dim sql As String
    '    Dim drr As SqlDataReader
    '    Dim staffid As String
    '        sql = " select fingerprint,staffid  from staffpersonaldetails  "
    '        drr = ExecuteReader(sql)
    '        If drr.HasRows Then
    '            Try
    'nextread:       While drr.Read
    '                    If Not IsNothing(drr(0)) Then
    '                        Try
    '                            temp_v = drr(0)
    '                        Catch ex As Exception
    '                            GoTo nextread
    '                        End Try

    '    ' Dim iError As Int32
    '    Dim matched1 As Boolean
    '    Dim matched2 As Boolean
    '    Dim secu_level As SGFPMSecurityLevel
    '    ' m_FPM = New SGFingerPrintManager
    '                        secu_level = SGFPMSecurityLevel.BELOW_NORMAL

    '                        iError = scanfing.m_FPM.MatchTemplate(temp_v, temp1, secu_level, matched1)

    '                        If (iError = SGFPMError.ERROR_NONE) Then
    '                            If (matched1) Then
    '    Dim student As String
    '                                staffid = drr(1).ToString

    '                                sql = "select name + ' ' + surname from staffpersonaldetails where staffid = '" & drr(1) & "'"
    '                                student = ExecuteScalar(sql)
    '                                If Not era Then
    '    ' MsgBox("Welcome " & student)
    '                                    register(staffid, student)
    '    '  PictureBox_v.Refresh()
    '                                    Exit Sub
    '                                End If
    '    ' Else
    '    '  MsgBox("no matching print please try again")
    '                            End If

    '                        Else
    '    ' DisplayError("MatchTemplate", iError)
    '                        End If

    '                    End If
    '                End While



    '            Catch ex As Exception
    '                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")
    '    ' MsgBox(ex.Message)

    '            End Try

    '            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")
    '        Else
    '            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")
    '        End If
    '    '  drr = ExecuteReader(sql, , , , True, temp1, "@finger")  'ExecuteNonQuery(sql, , , , , , , temp1, True, "@finger")





    '    'If cnctera Then
    '    '    MsgBox("Could not connect to scanner")
    '    '    Exit Sub
    '    'Else
    '    '    ' scanfing()
    '    'End If

    '    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        staffreg = True
        staffnumber = StaffIDTextBox.Text
        staffname = NameTextBox.Text
        staffsurname = SurnameTextBox.Text

        '    frmReigisterPrints2.Show()
    End Sub

    Private Sub Staff_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub StaffTabControl_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles StaffTabControl.TabIndexChanged
        If StaffTabControl.SelectedTab.Text = "Login/Logout" Then

        End If
    End Sub
    Private Sub register(ByVal staff As String, ByVal fullname As String)
        Dim sql As String
        Dim incomplete As Integer
        sql = "select count (staffid ) from staffregister where [date] = '" & changedate(Now.Date) & "' and staffid = '" & staff & "' and complete = '0'"
        incomplete = ExecuteScalar(sql)

        If incomplete > 0 Then
            sql = "update staffregister set time_out = '" & Mid(Now.TimeOfDay.ToString, 1, 8) & "', complete = '1',fulldate_out = '" & changefulldate(Now()) & "' where date = '" & changedate(Now.Date) & "' and staffid = '" & staff & "' and complete = '0'"
            ExecuteNonQuery(sql)
            If Not era Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\goodbye.wav")
                ' MsgBox("Logout successfull for " & fullname)
            Else
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")
            End If
        Else
            sql = "insert into staffregister (staffid,[date],time_in,time_out,complete,fulldate_in,fulldate_out ) values ('" & staff & "','" & changedate(Now.Date) & "','" & Mid(Now.TimeOfDay.ToString, 1, 8) & "','','0','" & changefulldate(Now()) & "','" & changefulldate(Now()) & "')"
            ExecuteNonQuery(sql)

            If Not era Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\confirm.wav")
                ' MsgBox(fullname & " successfully Logged in")
            Else
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")
            End If
        End If








    End Sub




    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        loadsets()
    End Sub

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lstResult_SystemColorsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstResult.SystemColorsChanged

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub lbSubTaughtSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSubTaughtSearch.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSubjectSearch_Click(sender As Object, e As EventArgs) Handles btnSubjectSearch.Click
        Dim serchtext As String = Trim(ttxSearchtext.Text)
        StafftSearch(lstResult, serchtext)
    End Sub



    Private Sub StafftSearch(lstbox As ListBox, searchtext As String)

        lstbox.DataSource = Nothing
        lstbox.Visible = True

        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)


        Try
            cnn.Open()

            Dim filter As String = "where  concat (name , surname,department,staffid) like '%" & searchtext & "%'"
            Dim sql As String

            sql = "spStaffSearch"

            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
            param = New SqlParameter("@filter", filter)
            cmd.Parameters.Add(param)

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lstbox.DataSource = dsApps.Tables(0)
            lstbox.DisplayMember = "StaffName"
            lstbox.ValueMember = "StaffID"



            lstbox.DataSource = dsApps.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim serchtext As String = Trim(staffID.Text)
        StafftSearch(lbSubTaughtSearch, serchtext)
    End Sub

    Private Sub ttxSearchtext_KeyDown(sender As Object, e As KeyEventArgs) Handles ttxSearchtext.KeyDown
        If e.KeyCode = Keys.Escape Then
            lstResult.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            btnSubjectSearch_Click(Me, Nothing)

        End If
    End Sub

    Private Sub staffID_KeyDown(sender As Object, e As KeyEventArgs) Handles staffID.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbSubTaughtSearch.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            Button4_Click(Me, Nothing)

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cnn = New SqlConnection(ConnectionString)
        Dim trans As SqlTransaction = Nothing

        Dim staff, program, lvl, cls, session As String
        staff = txtFormTeacher.Text

        Try



            cnn.Open()

            trans = cnn.BeginTransaction

            sqltext = "Delete formteachers where teacher = '" & staff & "'"
            cmd = New SqlCommand(sqltext, cnn, trans)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()

            sqltext = "spInsertFormTeacher"

            For i = 0 To dgFormTeacher.Rows.Count - 2
                program = dgFormTeacher.Rows(i).Cells("ftprog").Value
                lvl = dgFormTeacher.Rows(i).Cells("ftlevel").Value
                cls = dgFormTeacher.Rows(i).Cells("ftclass").Value
                session = dgFormTeacher.Rows(i).Cells("ftsession").Value


                cmd = New SqlCommand(sqltext, cnn, trans)

                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@teacher", staff)
                    .Parameters.AddWithValue("@lvl", lvl)
                    .Parameters.AddWithValue("@program", program)
                    .Parameters.AddWithValue("@class", cls)
                    .Parameters.AddWithValue("@session", session)
                    .Parameters.AddWithValue("@ref", Guid.NewGuid)
                    .ExecuteNonQuery()



                End With


            Next
            trans.Commit()
            MsgBox("Class Teachers updated")
            fillFormTeacher()
        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        Finally
            cnn.Close()

        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim serchtext As String = Trim(txtFormTeacher.Text)
        StafftSearch(lbFormTeacher, serchtext)
    End Sub

    Private Sub lbFormTeacher_DoubleClick(sender As Object, e As EventArgs) Handles lbFormTeacher.DoubleClick
        Try
            Dim searchstring As String = lbFormTeacher.SelectedValue
            txtFormTeacher.Text = searchstring
            lbFormTeacher.DataSource = Nothing
            lbFormTeacher.Visible = False

            fillFormTeacher()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFormTeacher_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFormTeacher.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button5_Click(Me, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            lbFormTeacher.Visible = False
        End If
    End Sub

    Private Sub fillFormTeacher()
        sqltext = "spFillFormTeacher"
        cnn = New SqlConnection(ConnectionString)
        Dim formteacher As SqlDataReader
        Dim rows As Integer = 0
        dgFormTeacher.Rows.Clear()

        Try
            cnn.Open()
            cmd = New SqlCommand(sqltext, cnn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@teacher", txtFormTeacher.Text)
                formteacher = .ExecuteReader
                If formteacher.HasRows Then
                    While formteacher.Read


                        With dgFormTeacher
                        .Rows.Add()
                        .Rows(rows).Cells("ftprog").Value = formteacher("program").ToString
                            Dim cmblvl As DataGridViewComboBoxCell = CType(.Rows(rows).Cells("ftlevel"), DataGridViewComboBoxCell)
                            cmblvl.DataSource = Ints()
                            cmblvl.DisplayMember = "Text"
                            cmblvl.Value = "Value"
                            cmblvl.Value = formteacher("lvl")
                            .Rows(rows).Cells("ftSession").Value = formteacher("session")
                        .Rows(rows).Cells("ftclass").Value = formteacher("classdesc")
                        rows += 1
                    End With

                    End While
                End If


            End With
        Catch ex As Exception
        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub dgFormTeacher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFormTeacher.CellContentClick

    End Sub

    Private Sub dgFormTeacher_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgFormTeacher.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim rows As Integer = dgFormTeacher.SelectedRows.Count
        Dim rowtot As Integer = dgFormTeacher.Rows.Count
        If rows > 0 Then
            For i = 0 To rowtot - 2
                If dgFormTeacher.Rows(i).Selected Then
                    dgFormTeacher.Rows.RemoveAt(i)
                    rowtot = dgFormTeacher.Rows.Count
                    i -= 1
                End If
                If i >= rowtot - 2 Then
                    Exit For
                End If
            Next
            MsgBox("Press Save to Effect Change")
        Else
            MsgBox("Select at least one class row")
        End If


    End Sub

    Private Sub dgSubsTaught_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgSubsTaught.CellValidated
        If e.ColumnIndex = 0 Then
            Dim program As String = dgSubsTaught.Rows(e.RowIndex).Cells("SubTaughtProgram").Value


            Dim cbosubs As DataGridViewComboBoxCell = CType(dgSubsTaught.Rows(e.RowIndex).Cells("subTaughtSubject"), DataGridViewComboBoxCell)
            cbosubs.DataSource = ProgramSubjects(program)
            cbosubs.DisplayMember = "Text"
            cbosubs.ValueMember = "Value"
        End If
    End Sub

    Private Sub dgSubsTaught_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSubsTaught.CellContentClick

    End Sub

    Private Sub dgSubsTaught_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgSubsTaught.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgSubsTaught_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgSubsTaught.RowsAdded
        Try
            Dim program As String = dgSubsTaught.Rows(e.RowIndex).Cells("SubTaughtProgram").Value


            Dim cbosubs As DataGridViewComboBoxCell = CType(dgSubsTaught.Rows(e.RowIndex).Cells("subTaughtSubject"), DataGridViewComboBoxCell)

            If IsNothing(program) Then
                program = "All"
            End If

            cbosubs.DataSource = ProgramSubjects(program)
            cbosubs.DisplayMember = "Text"
            cbosubs.ValueMember = "Value"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim rows As Integer = dgSubsTaught.SelectedRows.Count
        Dim rowtot As Integer = dgSubsTaught.Rows.Count

        If rows > 0 Then
            For i = 0 To rowtot - 2
                If dgSubsTaught.Rows(i).Selected Then
                    dgSubsTaught.Rows.RemoveAt(i)
                    i -= 1
                    rowtot = dgSubsTaught.Rows.Count
                End If

                If i >= rowtot - 2 Then
                    Exit For
                End If
            Next
            MsgBox("Press Save to Effect Change")
        Else
            MsgBox("Select at least one Subject row")
        End If

    End Sub

    Private Sub cboSubTeachersbyClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubTeachersbyClass.SelectedIndexChanged
               LoadStaffSubjects(staffID.Text, cboSubTeachersbyClass.Text)
    End Sub
End Class