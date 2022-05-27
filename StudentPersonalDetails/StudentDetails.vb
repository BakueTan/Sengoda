Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net
'Imports System.Web.UI.Page
Imports System.Data
Imports Miscelleneous
Imports System.Windows.Forms
Imports System.Drawing

Public Class FrmStudent
    Private mblnaddingUser As Boolean
    Private mblnaddingFess As Boolean = False
    Private mblnaddingBehav As Boolean = False
    Private mblnEdtFess As Boolean = False
    Private mblnDltFess As Boolean = False

    Public usergroup As String
    Public mainform As Form
    Public username As String
    Public isloading As Boolean = True
    Public screenenabled As Boolean = False


    Private stud As csStudent
    Private Sibs = New List(Of csSiblings)
    Private Docs = New List(Of csDocs)
    Private NokS = New List(Of StudNok)
    Private sql As String

    Private bsFeesClass As BindingSource
    Private cnn As SqlConnection
    Private sesscollection As String
    Private sessions As List(Of String)
    Private schoolinfo As ClsSchoolParameters = New ClsSchoolParameters

    Public gouser As clsUser

    Private feesstud As cEnrol


    Public Property blnMultiComment As Boolean
    'Public ReadOnly Property CurrentPaymentPeriod() As String
    '    Get
    '        Dim period As String = ""
    '        cnn = New SqlConnection(ConnectionString)
    '        sql = "select [period] from paymentperiods where [current] = 1"
    '        Try
    '            cnn.Open()
    '            cmd = New SqlCommand(sql, cnn)
    '            period = cmd.ExecuteScalar
    '            Return period
    '        Catch ex As Exception
    '        Finally
    '            cnn.Close()
    '        End Try



    '        Return period
    '    End Get
    'End Property

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()


        '    Show()

    End Sub

    Private Sub loadcombos()
        LoadSessions()
        loadprograms()
        loadclassses()
        loadExams()
        loadSubjects()
        loadStudents()
        LoadCashtypes()
        loadFeesCartegory()
        loadPaymentPeriods()
    End Sub
    Private Sub LoadPaymentTypes()
        With cboFeesCartegory
            .DataSource = PaymentTypes("schoolfees")
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With
    End Sub
    Private Sub LoadSessions()
        With CboEnrSessSearch
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboOldClassSess
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cbonewclassSess
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


        With SessionComboBox
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboSubSess
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboBillingSess
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboMarkSession
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With



        With cbofeessessSearch
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With


    End Sub

    Private Sub loadExams()

        With cboMarkExam
            .DataSource = ChildExams(cboMarkClass.Text)
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboBehaviorPeriod
            .DataSource = ChildExams(cboBehaviorClass.Text)
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub loadFeesCartegory()
        With cboFeesCartegory
            .DataSource = PaymentTypes("SchoolFees")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub loadPaymentPeriods()
        With cboBBFCutOffPeriod
            .DataSource = FeesPaymentPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With

        For Each itm As ComboItem In cboBBFCutOffPeriod.Items
            If itm.Value = CurrentPaymentPeriod Then
                cboBBFCutOffPeriod.SelectedItem = itm
                Exit For
            End If

        Next
    End Sub

    Private Sub loadprograms()
        With cboOldClassprog
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cbonewclassprog
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboEnrlProgSearch
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


        With ProgramComboBox
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboSubProg
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboBillingProg
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboMarkProg
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


        With cboFeesProgSearch
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

    End Sub

    Private Sub loadclassses()

        With cboOldClassCls
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cbonewClassCls
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboClass
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboEnrolClassSearch
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboSubClass
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboBillingClass
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


        With cboMarkClass
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


        With cbofeesClassSearch
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboBehaviorClass
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

    End Sub

    Private Sub loadSubjects()
        With cboMarkSubject
            .DataSource = Subjects()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub


    Private Sub loadStudents()
        With cboSibling
            .DataSource = Students()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub


    Private Sub LoadCashtypes()
        With cboCashType
            .DataSource = CashTypes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

    End Sub


    Private Sub Student_Load() Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSchool.FeesPaymentType' table. You can move, or remove it, as needed.
        Me.FeesPaymentTypeTableAdapter.Fill(Me.DsSchool.FeesPaymentType)
        'TODO: This line of code loads data into the 'DsSchool.StudentFeesTranscations' table. You can move, or remove it, as needed.
        '    Me.StudentFeesTranscationsTableAdapter.Fill(Me.DsSchool.StudentFeesTranscations)
        ''TODO: This line of code loads data into the 'DsSchool.ClassList' table. You can move, or remove it, as needed.
        ''  Me.ClassListTableAdapter.Fill(Me.DsSchool.ClassList)
        ''TODO: This line of code loads data into the 'DsSchool.Currencies' table. You can move, or remove it, as needed.
        'Me.CurrenciesTableAdapter.Fill(Me.DsSchool.Currencies)
        ''TODO: This line of code loads data into the 'DsSchool.FeesPayments_Header' table. You can move, or remove it, as needed.
        'Me.FeesPayments_HeaderTableAdapter.Fill(Me.DsSchool.FeesPayments_Header)
        ''TODO: This line of code loads data into the 'DsSchool.feespayments_details' table. You can move, or remove it, as needed.
        'Me.Feespayments_detailsTableAdapter.Fill(Me.DsSchool.feespayments_details)
        ''TODO: This line of code loads data into the 'DsSchool.PaymentPeriods' table. You can move, or remove it, as needed.
        'Me.PaymentPeriodsTableAdapter.Fill(Me.DsSchool.PaymentPeriods)
        ''TODO: This line of code loads data into the 'DsSchool.StudentFeesTranscations' table. You can move, or remove it, as needed.
        ''  Me.StudentFeesTranscationsTableAdapter.Fill(Me.DsSchool.StudentFeesTranscations)
        ''TODO: This line of code loads data into the 'DsSchool.PaymentPeriods' table. You can move, or remove it, as needed.


        Prepareform(Me, mainform, False)
        MdiParent = mainform
        ' Add any initialization after the InitializeComponent() call.
        LoadRights()

        isloading = True

        loadcombos()

        LoadDatasets()


        enablestudscreen(False)
        PersonalDetails.TabPages("tbSMS").Visible = False
        PersonalDetails.TabPages("tbStudBehavior").Visible = False

    End Sub

    Private Sub LoadRights()
        Dim lbl As TreeView
        Dim Nd, NdSub, NdSubSub, NdSubSubSub As TreeNode
        Nd = Nothing : NdSub = Nothing : NdSubSub = Nothing
        NdSubSubSub = Nothing
        lbl = tvEnrol

        If goUser.Group <= 1 Or goUser.Group = 13 Then
            BindingNavigator2.Items("Delete").Enabled = True
        Else

            BindingNavigator2.Items("Delete").Enabled = False
        End If


        If goUser.Group <= 2 Or goUser.Group = 7 Or goUser.Group = 13 Then
            BindingNavigator2.Items("Reprint").Enabled = True
        Else

            BindingNavigator2.Items("Reprint").Enabled = False
        End If






        For Each Nd In lbl.Nodes
            For Each NdSub In Nd.Nodes
                Try
                    If Not IsNothing(NdSub.Tag) Then
                        If NdSub.Tag.ToString = "-1" Then
                            NdSub.Text = ""
                        Else
                            If NdSub.Tag.ToString <> "0" Then
                                Dim dr As SqlDataReader = Nothing
                                Dim sql As String = ""
                                sql = "Select Auth_HasAccess from " &
                                      "dbo.UserAuthorisations where Auth_Group = '" & goUser.Group &
                                      "' and Auth_AccComp = '" & NdSub.Tag.ToString & "'"
                                dr = ExecuteReader(sql, Nothing)
                                While dr.Read
                                    If Not CBool(dr.Item(0)) Then NdSub.Text = ""
                                End While
                            End If
                        End If
                        For Each NdSubSub In NdSub.Nodes
                            Try
                                If Not IsNothing(NdSubSub.Tag) Then
                                    If NdSubSub.Tag.ToString = "-1" Then
                                        NdSubSub.Text = ""
                                    Else
                                        If NdSubSub.Tag.ToString <> "0" Then
                                            Dim dr As SqlDataReader = Nothing
                                            Dim sql As String = ""
                                            sql = "Select Auth_HasAccess from " &
                                                  "dbo.UserAuthorisations where Auth_Group = '" & goUser.Group &
                                                  "' and Auth_AccComp = '" & NdSubSub.Tag.ToString & "'"
                                            dr = ExecuteReader(sql, Nothing)
                                            While dr.Read
                                                If Not CBool(dr.Item(0)) Then NdSubSub.Text = ""
                                            End While
                                        End If
                                    End If
                                End If
                            Catch ex As Exception
                            End Try
                            For Each NdSubSubSub In NdSubSub.Nodes
                                Try
                                    If Not IsNothing(NdSubSubSub.Tag) Then
                                        If NdSubSubSub.Tag.ToString = "-1" Then
                                            NdSubSubSub.Text = ""
                                        Else
                                            If NdSubSubSub.Tag.ToString <> "0" Then
                                                Dim dr As SqlDataReader = Nothing
                                                Dim sql As String = ""
                                                sql = "Select Auth_HasAccess from " &
                                                      "dbo.UserAuthorisations where Auth_Group = '" & goUser.Group &
                                                      "' and Auth_AccComp = '" & NdSubSubSub.Tag.ToString & "'"
                                                dr = ExecuteReader(sql, Nothing)
                                                While dr.Read
                                                    If Not CBool(dr.Item(0)) Then NdSubSubSub.Text = ""
                                                End While
                                            End If
                                        End If
                                    End If
                                Catch ex As Exception
                                End Try
                            Next
                        Next
                    End If
                Catch ex As Exception
                End Try
            Next
        Next

        Dim cont As TabPage
        For Each cont In PersonalDetails.TabPages
            If Not IsNothing(cont.Tag) Then
                If cont.Tag.ToString = "-1" Then
                    cont.Enabled = False
                Else
                    If cont.Tag.ToString <> "0" Then
                        Dim dr As SqlDataReader = Nothing
                        Dim sql As String = ""
                        sql = "Select Auth_HasAccess from " &
                              "dbo.UserAuthorisations where Auth_Group = '" & goUser.Group &
                              "' and Auth_AccComp = '" & cont.Tag.ToString & "'"
                        dr = ExecuteReader(sql, Nothing)
                        While dr.Read
                            If Not CBool(dr.Item(0)) Then
                                cont.Enabled = False
                            Else
                                cont.Enabled = True
                            End If

                        End While
                    End If
                End If
            End If

        Next
    End Sub



    Private Sub LoadDatasets()
        Me.PaymentPeriodsTableAdapter.Fill(Me.DsSchool.PaymentPeriods)
        'TODO: This line of code loads data into the 'DsSchool.FeesPaymentType' table. You can move, or remove it, as needed.
        Me.FeesPaymentTypeTableAdapter.Fill(Me.DsSchool.FeesPaymentType)
        'TODO: This line of code loads data into the 'DsSchool.Currencies' table. You can move, or remove it, as needed.
        Me.CurrenciesTableAdapter.Fill(Me.DsSchool.Currencies)

        Try
            mblnaddingUser = False
            mblnaddingFess = False
            blnschoolsections = False
            cboSchoolSections.Enabled = False





        Catch ex As Exception
            '   MsgBox(ex.Message)
        End Try
    End Sub






    Private Sub saveSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        academicSave()
    End Sub
    Private Sub academicSave()

        Dim program As String
        Dim subject As String = ""
        Dim trans As SqlTransaction = Nothing
        Dim subs As Integer = 0

        Dim cnn As New SqlConnection(ConnectionString)


        Dim a, b, subcount, subbase, selstudscount As Integer
        Dim sql As String

        ' Dim studsub, newstudb As dsschool.StudentSubjectsRow
        subcount = Available_Subjects.Items.Count
        selstudscount = dgSubStuds.SelectedRows.Count

        Dim blnregstatus As Boolean
        Dim regstatus As String = ""


        If subcount = 0 Or selstudscount = 0 Then
            MsgBox("No subjects or selected students available")
            Exit Sub
        End If

        If cboSubExam.Text = "" Then
            MsgBox("No Exam Selected")
            Exit Sub
        End If



        If Not chkAllStuds.Checked Then
            Try


                cnn.Open()
                trans = cnn.BeginTransaction
                subs = 0

                For subbase = 0 To subcount - 1
                    blnregstatus = Available_Subjects.GetItemChecked(subbase)
                    If blnregstatus = True Then
                        regstatus = "Registered"
                    Else
                        regstatus = "Dropped"
                    End If

                    subs += 1
                    params = New List(Of SqlParameter)

                    subject = CleanComboVal(Available_Subjects.Items(subbase))
                    sql = "spregisterSubjects"

                    Dim cmd As New SqlCommand(sql, cnn, trans)
                    cmd.CommandType = CommandType.StoredProcedure
                    param = New SqlParameter("@sub", subject)
                    params.Add(param)

                    param = New SqlParameter("@stud", dgSubStuds.SelectedRows(0).Cells("SubjectsStudentID").Value)
                    params.Add(param)


                    param = New SqlParameter("@regstatus", regstatus)
                    params.Add(param)

                    param = New SqlParameter("@regtype", "Normal")
                    params.Add(param)

                    param = New SqlParameter("@user", gouser.userName)
                    params.Add(param)

                    param = New SqlParameter("@exam", cboSubExam.Text)
                    params.Add(param)

                    param = New SqlParameter("@subExamRef", cboSubExam.SelectedValue)
                    params.Add(param)

                    param = New SqlParameter("@subEnrolRef", dgSubStuds.SelectedRows(0).Cells("EnrolRef").Value)
                    params.Add(param)

                    For Each par In params
                        cmd.Parameters.Add(par)
                    Next

                    cmd.ExecuteNonQuery()


                Next

                trans.Commit()
                MsgBox("Subjects Updated")

            Catch ex As Exception
                MsgBox(ex.Message)
                trans.Rollback()
            Finally
                cnn.Close()

            End Try

        Else 'Selected Students 

            cnn = New SqlConnection(ConnectionString)
            Try


                cnn.Open()
                trans = cnn.BeginTransaction

                For i = 0 To dgSubStuds.Rows.Count - 1



                    If dgSubStuds.Rows(i).Selected Then


                        subs = 0



                        For subbase = 0 To subcount - 1
                            sql = "spregisterSubjects"
                            cmd = New SqlCommand(sql, cnn, trans)
                            cmd.CommandType = CommandType.StoredProcedure
                            subs += 1
                            params = New List(Of SqlParameter)

                            subject = CleanComboVal(Available_Subjects.Items(subbase))



                            param = New SqlParameter("@sub", subject)
                            params.Add(param)

                            param = New SqlParameter("@stud", dgSubStuds.Rows(i).Cells("SubjectsStudentID").Value)
                            params.Add(param)


                            param = New SqlParameter("@regstatus", IIf(Available_Subjects.GetItemChecked(subbase) = True, "Registered", "Dropped"))
                            params.Add(param)

                            param = New SqlParameter("@regtype", "Normal")
                            params.Add(param)

                            param = New SqlParameter("@user", gouser.userName)
                            params.Add(param)

                            param = New SqlParameter("@exam", cboSubExam.Text)
                            params.Add(param)

                            param = New SqlParameter("@subExamRef", cboSubExam.SelectedValue)
                            params.Add(param)

                            param = New SqlParameter("@subEnrolRef", dgSubStuds.Rows(i).Cells("EnrolRef").Value)
                            params.Add(param)
                            For Each par In params
                                cmd.Parameters.Add(par)

                            Next

                            cmd.ExecuteNonQuery()




                        Next



                    End If


                Next

                trans.Commit()


                MsgBox("Subjects Updated for the selected Students")


            Catch ex As Exception
                MsgBox(ex.Message)
                trans.Rollback()
            Finally
                cnn.Close()
            End Try
        End If




    End Sub
















    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If gdStudents.SelectedRows.Count = 0 Then
            MsgBox("No Student has Been selected", MsgBoxStyle.Information)
        Else

            addMarks()
        End If


    End Sub


    Private Sub addMarks()
        Dim program As String
        Dim subs As Integer = 0
        Dim subpoints As Integer = 0
        Dim username As String = goUser.FullName
        Dim markError As Boolean = False
        Dim chkd As Integer = 0
        Dim subref As Guid = Guid.NewGuid
        Dim Coursemark, ExamMark As String
        Dim studcount, studbase, b, subcount As Integer
        Dim cnn As SqlConnection = New SqlConnection(ConnectionString)
        Dim trans As SqlTransaction
        Dim enrolref As String
        Dim stud As cEnrol


        subcount = 0 : b = 0
        studcount = gvMarks.Rows.Count
        Dim gstrBillenrolref As String
        Dim effort As String = ""

        Dim markref As String

        gstrstudid = gdStudents.SelectedRows(0).Cells("MarksStudentID").Value
        gstrBillenrolref = gdStudents.SelectedRows(0).Cells("MarksEnrolRef").Value.ToString

        For i = 0 To gvMarks.Rows.Count - 2
            If gvMarks.Rows(i).Cells("Check").Value = True Then
                b += 1
                Exit For
            End If
        Next
        '  b = chkRegSubs.CheckedItems.Count
        Coursemark = 0
        ExamMark = 0

        If studcount = 0 Or b = 0 Then
            MsgBox("No Subject is available to record Marks")

            Exit Sub
        Else
            program = cboMarkProg.SelectedValue


            cnn.Open()
            trans = cnn.BeginTransaction

            Try


                stud = New cEnrol(cboMarkClass.Text, gstrstudid)
                enrolref = stud.EnrolRef
                For studbase = 0 To studcount - 2

                    If gvMarks.Rows(studbase).Cells("Check").Value = True Then
                        Dim comment As String = ""
                        If blnMultiComment Then
                            comment = gvMarks.Rows(studbase).Cells("MultiComment").Value
                        Else
                            comment = gvMarks.Rows(studbase).Cells("Comment").Value
                        End If

                        If comment = "" Then
                            Throw New Exception("Missing comment on line " & studbase + 1)


                        End If
                        If gvMarks.Rows(studbase).Cells("Remarks").Value = "Present" Then

                            Coursemark = gvMarks.Rows(studbase).Cells("CourseMark").Value
                            ExamMark = gvMarks.Rows(studbase).Cells("ExamMark").Value

                            Coursemark = FormatNumber(CDec(Coursemark), 2)
                            ExamMark = FormatNumber(CDec(ExamMark), 2)
                        ElseIf gvMarks.Rows(studbase).Cells("Remarks").Value <> "" Then
                            Coursemark = 0
                            ExamMark = 0
                        Else
                            Throw New Exception("Missing exam remark  on line " & studbase + 1)


                        End If

                        effort = gvMarks.Rows(studbase).Cells("effort").Value
                        If effort = "" Then
                            Throw New EvaluateException("Missing Effort on Line  " & studbase + 1)
                        End If

                        markref = gvMarks.Rows(studbase).Cells("markref").Value.ToString

                        Dim subj As String = CleanComboVal(gvMarks.Rows(studbase).Cells("Subject").Value)


                        '     If markref <> "" Then ' Mark Already exist
                        '    If MsgBox("Marks already exist for " & subj & " this will update the existing marks,do you wish to continue ", vbYesNo) = vbYes Then
                        Dim cmd As New SqlCommand

                                sql = "sp_EnterMarks"
                                cmd.CommandText = sql
                                cmd.Connection = cnn
                                cmd.Transaction = trans
                                cmd.CommandType = CommandType.StoredProcedure
                                cmd.Parameters.AddWithValue("@Student", gstrstudid)
                                cmd.Parameters.AddWithValue("@coursemark", Coursemark)
                                cmd.Parameters.AddWithValue("@exammark", ExamMark)
                                cmd.Parameters.AddWithValue("@subject", subj)
                                cmd.Parameters.AddWithValue("@examsession", cboMarkExam.Text)
                                cmd.Parameters.AddWithValue("@user", username)
                                cmd.Parameters.AddWithValue("@examstatus", gvMarks.Rows(studbase).Cells("Remarks").Value)
                        cmd.Parameters.AddWithValue("@ref", IIf(markref = "", Guid.NewGuid, markref))
                        cmd.Parameters.AddWithValue("@comment", comment)
                                cmd.Parameters.AddWithValue("@enrolref", enrolref)
                                cmd.Parameters.AddWithValue("@effort", effort)
                                cmd.ExecuteNonQuery()





                        'End If
                    End If

                Next

                If Not markError Then
                    trans.Commit()
                    MsgBox("Marks Successfully saved", MsgBoxStyle.Information)
                End If


            Catch ex As Exception
                MsgBox("Error Saving Marks" & ex.Message)
                trans.Rollback()
            Finally
                cnn.Close()

            End Try


        End If




    End Sub




















    Private Sub markyearComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        gdStudents.DataSource = fillAllMarks().Tables(0)


    End Sub
    Private Function fillAllMarks(Optional filter As String = "All") As DataSet
        '       FormatSessions()

        Dim adapter As New SqlDataAdapter()
        Dim cnn As New SqlConnection(ConnectionString)

        Try
            '    gdStudents.DataSource = Nothing
            cnn.Open()

            Dim dsClass As New DataSet()

            Dim cmd As New SqlCommand
            cmd.CommandText = "spFillStudentsList"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            param = New SqlParameter("@prog", cboMarkProg.SelectedValue)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@year", cboMarkLevel.Text)
            cmd.Parameters.Add(param)


            param = New SqlParameter("@sess", cboMarkSession.Text)
            cmd.Parameters.Add(param)


            param = New SqlParameter("@subject", cboMarkSubject.SelectedValue)
            cmd.Parameters.Add(param)


            param = New SqlParameter("@exam", cboMarkExam.Text)
            cmd.Parameters.Add(param)


            param = New SqlParameter("@class", cboMarkClass.Text)
            cmd.Parameters.Add(param)


            param = New SqlParameter("@filter", filter)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@offset", 0)
            cmd.Parameters.Add(param)


            adapter.SelectCommand = cmd
            adapter.Fill(dsClass)

            '   gdStudents.DataSource = dsClass.Tables(0)

            Return dsClass

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try








    End Function












    Private Sub ToolStripButton35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Student_Load()
    End Sub




    'Public Sub persedit()
    '    Dim status, status1 As dsSchool.StudentStatusRow
    '    status = dsschool.StudentStatus.NewStudentStatusRow
    '    Dim statrow As dsSchool.statusRow
    '    statrow = dsschool.status.Rows.Item(0)
    '    Dim studliv As dsSchool.StudentLeavingRow
    '    Dim statcount, a, b As Integer
    '    statcount = StudentStatusBindingSource.Count
    '    a = StudentStatusBindingSource.Find("studentID", StudentIDTextBox.Text)
    '    Try
    '        status.studentID = StudentIDTextBox.Text
    '        status.Status = statrow.Stats.ToUpper
    '        dsschool.StudentStatus.Rows.Add(status)
    '        Me.TableAdapterManager.UpdateAll(Me.dsschool)
    '        MsgBox("Status updated", MsgBoxStyle.Information, "SMS")
    '    Catch ex As Exception
    '        'MsgBox("Status update error")
    '        a = StudentLeavingBindingSource.Find("StudentID", StudentIDTextBox.Text)
    '        b = StudentStatusBindingSource.Find("studentID", StudentIDTextBox.Text)
    '        status1 = dsschool.StudentStatus.Rows.Item(b)
    '        If a >= 0 Then
    '            studliv = dsschool.StudentLeaving.Rows.Item(a1)
    '            ' status1 = dsschool.StudentStatus.Rows.Item(a1)
    '            Dim s As String
    '            s = MsgBox("Student no longer part of the school,is he/she a returning student", MsgBoxStyle.YesNo)
    '            If s = vbYes Then
    '                MsgBox("Did you update the new enrollment details for the student", MsgBoxStyle.YesNo)
    '                If vbYes Then
    '                    status1.Status = "Available"
    '                    'StudentLeavingTableAdapter.Delete(studliv.StudentID, studliv.DateLeft, studliv.Reason)
    '                    Me.Validate()
    '                    Me.StudentStatusBindingSource.EndEdit()
    '                    Me.StudentLeavingBindingSource.EndEdit()
    '                    Me.TableAdapterManager.UpdateAll(Me.dsschool)
    '                    MsgBox("Status changed")
    '                ElseIf s = vbNo Then
    '                    MsgBox("Update The enrollment details and try again later")
    '                    Exit Sub
    '                End If
    '            Else
    '                Exit Sub
    '            End If
    '        End If

    '    End Try





    '    Dim enrol As dsSchool.enrollmentRow

    '    Dim enrolcount, enbase As Integer
    '    enrolcount = EnrollmentBindingSource.Count
    '    For enbase = 0 To enbase - 1
    '        enrol = dsschool.enrollment.Rows.Item(enbase)
    '        If enrol.Year = yearComboBox.Text And enrol.StudentID = StudentIDTextBox.Text And enrol.Program <> cboProgramSearch.Text Then
    '            MsgBox("Student already enrolled for another form in the specified year")
    '            Exit Sub
    '        ElseIf enbase = enrolcount - 1 And (enrol.Year <> cboEnrYearSearch.Text Or enrol.StudentID <> StudentIDTextBox.Text Or enrol.Program = cboProgramSearch.Text) Then
    '            Exit For
    '        End If
    '    Next


    '    Try
    '        Me.Validate()
    '        Me.StudentPersonalDetailsBindingSource.EndEdit()
    '        Me.TableAdapterManager.UpdateAll(Me.dsschool)
    '        MsgBox("Student's Personal Details saved", MsgBoxStyle.Information, "SMS")
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "SMS")
    '        Exit Sub
    '    End Try

    '    If enrolcount = 0 Then
    '        enrol = dsschool.enrollment.NewenrollmentRow
    '        enrol.StudentID = StudentIDTextBox.Text
    '        enrol.Year = yearComboBox.Text
    '        enrol.Program = ProgramComboBox.Text
    '        enrol.Semester = SemesterComboBox.Text
    '        enrol.Session = SessionComboBox.Text
    '        enrol.Date_Joined = Year_JoinedComboBox.Text
    '        enrol.Gender = GenderComboBox.Text
    '        enrol.Intake = StatusComboBox.Text
    '        dsschool.enrollment.Rows.Add(enrol)
    '        Me.TableAdapterManager.UpdateAll(Me.dsschool)
    '    Else
    '        Try
    '            For enbase = 0 To enrolcount - 1
    '                enrol = dsschool.enrollment.Rows.Item(enbase)
    '                If enrol.Year = yearComboBox.Text And enrol.StudentID = StudentIDTextBox.Text And enrol.Semester = SemesterComboBox.Text And enrol.Program = ProgramComboBox.Text Then
    '                    ' MsgBox("Enrollment details have not changed,update the enrollment details for the returning student")
    '                    Exit For
    '                ElseIf enbase = enrolcount - 1 And (enrol.Year <> yearComboBox.Text Or enrol.StudentID <> StudentIDTextBox.Text Or enrol.Semester <> SemesterComboBox.Text Or enrol.Program <> ProgramComboBox.Text) Then
    '                    enrol = dsschool.enrollment.NewenrollmentRow
    '                    enrol.StudentID = StudentIDTextBox.Text
    '                    enrol.Year = yearComboBox.Text
    '                    enrol.Program = ProgramComboBox.Text
    '                    enrol.Semester = SemesterComboBox.Text
    '                    enrol.Date_Joined = Year_JoinedComboBox.Text
    '                    enrol.Gender = GenderComboBox.Text
    '                    enrol.Session = SessionComboBox.Text
    '                    enrol.Intake = StatusComboBox.Text
    '                    dsschool.enrollment.Rows.Add(enrol)
    '                    Me.TableAdapterManager.UpdateAll(Me.dsschool)
    '                End If
    '            Next
    '        Catch ex As Exception

    '        End Try

    '    End If


    'End Sub



    Private Sub persdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub



    Private Sub persref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Student_Load()
    End Sub



    Private Sub yearComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    StudentFeesTableAdapter.FillByYear(dsschool.StudentFees, IdComboBox.Text, yearComboBox.Text, fiztermComboBox.Text)
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Student_Load()
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Student_Load()
    End Sub




    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Student_Load()
    End Sub



    'Private Sub ComboBox3_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.StudentPersonalDetailsTableAdapter.FillByClass(Me.dsschool.StudentPersonalDetails, persForm.Text, persclas.Text, persyear.Text)
    '    Catch ex As Exception

    '    End Try


    '







    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub ImagePictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        'Form1.Show(Me)
    End Sub

    Private Sub FormTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub ToolStripButton9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim z As Integer
    '    z = StudentPersonalDetailsBindingSource.Find("StudentID", StudentIDTextBox.Text)
    '    If z >= 0 Then
    '        MsgBox("Save error , student ID already registered")
    '    Else
    '        Dim status, status1 As dsSchool.StudentStatusRow
    '        status = dsschool.StudentStatus.NewStudentStatusRow
    '        Dim statrow As dsSchool.statusRow
    '        statrow = dsschool.status.Rows.Item(0)
    '        Dim studliv As dsSchool.StudentLeavingRow
    '        Dim statcount, a, b As Integer
    '        statcount = StudentStatusBindingSource.Count
    '        a = StudentStatusBindingSource.Find("studentID", StudentIDTextBox.Text)
    '        Try
    '            status.studentID = StudentIDTextBox.Text
    '            status.Status = statrow.Stats
    '            dsschool.StudentStatus.Rows.Add(status)
    '            Me.TableAdapterManager.UpdateAll(Me.dsschool)
    '            MsgBox("Status updated", MsgBoxStyle.Information, "SMS")
    '        Catch ex As Exception
    '            'MsgBox("Status update error")
    '            a = StudentLeavingBindingSource.Find("StudentID", StudentIDTextBox.Text)
    '            b = StudentStatusBindingSource.Find("studentID", StudentIDTextBox.Text)
    '            status1 = dsschool.StudentStatus.Rows.Item(b)
    '            If a >= 0 Then
    '                studliv = dsschool.StudentLeaving.Rows.Item(a1)
    '                ' status1 = dsschool.StudentStatus.Rows.Item(a1)
    '                Dim s As String
    '                s = MsgBox("Student no longer part of the school,is he/she a returning student", MsgBoxStyle.YesNo)
    '                If s = vbYes Then
    '                    MsgBox("Did you update the new enrollment details for the student", MsgBoxStyle.YesNo)
    '                    If vbYes Then
    '                        status1.Status = "Available"
    '                        ' StudentLeavingTableAdapter.Delete(studliv.StudentID, studliv.DateLeft, studliv.Reason)
    '                        Me.Validate()
    '                        Me.StudentStatusBindingSource.EndEdit()
    '                        Me.StudentLeavingBindingSource.EndEdit()
    '                        Me.TableAdapterManager.UpdateAll(Me.dsschool)
    '                        MsgBox("Status changed")
    '                    ElseIf s = vbNo Then
    '                        MsgBox("Update The enrollment details and try again later")
    '                        Exit Sub
    '                    End If
    '                Else
    '                    Exit Sub
    '                End If
    '            End If

    '        End Try

    '        Dim enrol As dsSchool.enrollmentRow
    '        Dim fees As dsSchool.StudentFeesRow
    '        Dim persrow As dsSchool.StudentPersonalDetailsRow
    '        Dim enrolcount, enbase As Integer
    '        enrolcount = EnrollmentBindingSource.Count
    '        For enbase = 0 To enbase - 1
    '            enrol = dsschool.enrollment.Rows.Item(enbase)
    '            If enrol.Year = yearComboBox.Text And enrol.StudentID = StudentIDTextBox.Text And enrol.Program <> ProgramComboBox.Text Then
    '                MsgBox("Student already enrolled for another Program in the specified year")
    '                Exit Sub
    '            ElseIf enbase = enrolcount - 1 And (enrol.Year <> yearComboBox.Text Or enrol.StudentID <> StudentIDTextBox.Text Or enrol.Program = ProgramComboBox.Text) Then
    '                Exit For
    '            End If
    '        Next


    '        Try
    '            Me.Validate()
    '            Me.StudentPersonalDetailsBindingSource.EndEdit()
    '            Me.TableAdapterManager.UpdateAll(Me.dsschool)
    '            MsgBox("Student's Personal Details saved", MsgBoxStyle.Information, "SMS")
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Information, "SMS")
    '            Exit Sub
    '        End Try

    '        If enrolcount = 0 Then
    '            enrol = dsschool.enrollment.NewenrollmentRow
    '            enrol.StudentID = StudentIDTextBox.Text
    '            enrol.Year = yearComboBox.Text
    '            enrol.Program = ProgramComboBox.Text
    '            enrol.Semester = SemesterComboBox.Text
    '            enrol.Date_Joined = Year_JoinedComboBox.Text
    '            enrol.Gender = GenderComboBox.Text
    '            enrol.Session = SessionComboBox.Text
    '            dsschool.enrollment.Rows.Add(enrol)
    '            Me.TableAdapterManager.UpdateAll(Me.dsschool)
    '        Else
    '            Try
    '                For enbase = 0 To enrolcount - 1
    '                    enrol = dsschool.enrollment.Rows.Item(enbase)
    '                    If enrol.Year = yearComboBox.Text And enrol.StudentID = StudentIDTextBox.Text And enrol.Semester = SemesterComboBox.Text And enrol.Program = ProgramComboBox.Text Then
    '                        ' MsgBox("Enrollment details have not changed,update the enrollment details for the returning student")
    '                        Exit For
    '                    ElseIf enbase = enrolcount - 1 And (enrol.Year <> yearComboBox.Text Or enrol.StudentID <> StudentIDTextBox.Text Or enrol.Semester <> SemesterComboBox.Text Or enrol.Program <> ProgramComboBox.Text) Then
    '                        enrol = dsschool.enrollment.NewenrollmentRow
    '                        enrol.StudentID = StudentIDTextBox.Text
    '                        enrol.Year = yearComboBox.Text
    '                        enrol.Program = ProgramComboBox.Text
    '                        enrol.Semester = SemesterComboBox.Text
    '                        enrol.Gender = GenderComboBox.Text
    '                        enrol.Date_Joined = Year_JoinedComboBox.Text
    '                        enrol.Session = SessionComboBox.Text
    '                        dsschool.enrollment.Rows.Add(enrol)
    '                        Me.TableAdapterManager.UpdateAll(Me.dsschool)
    '                        MsgBox("Enrollment details Successfully Updated")
    '                    End If
    '                Next
    '            Catch ex As Exception

    '            End Try

    '        End If




    '    End If
    'End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub





    Private Sub ToolStripButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Student_Load()
    End Sub



    Private Sub fiztermComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    StudentFeesTableAdapter.FillByYear(dsschool.StudentFees, IdComboBox.Text, yearComboBox.Text, fiztermComboBox.Text)
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub IdComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    StudentFeesTableAdapter.FillByYear(dsschool.StudentFees, IdComboBox.Text, yearComboBox.Text, fiztermComboBox.Text)
        'Catch ex As Exception

        'End Try
    End Sub




    Private Sub leavetermComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Try
        '    Me.StudentPersonalDetailsTableAdapter1.FillByClasSub(Me.DsStudentSearches.StudentPersonalDetails, cboLeaveProg.Text, cboLeaveClass.Text, cboLeaveLevel.Text, cboLeaveSem.Text)

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Classlist.Items.Clear()
        'regname.Text = ""
        'regsurname.Text = ""

        'Dim classstuds As dsSchool.enrollmentRow
        ''Dim studrow As dsSchool.studen
        'Dim subcount, subbase As Integer
        'subcount = EnrollmentBindingSource.Count
        ''MsgBox(subcount)
        'Try
        '    For subbase = 0 To subcount - 1
        '        classstuds = dsschool.enrollment.Rows.Item(subbase)
        '        If classstuds.Date_Joined = regyearComboBox.Text And classstuds.Program = regformComboBox.Text And classstuds.Semester = regtermComboBox.Text And classstuds.Year = cboRegisterLevel.Text Then ''And classstuds.Session = cboRegSession.Text Then
        '            ' StudentFeesBindingSource.Find("StudentID", classstuds.StudentID)
        '            Classlist.Items.Add(classstuds.StudentID)
        '        End If

        '    Next

        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim studreg As dsSchool.StudentRegisterRow
        'Dim regcount, regbase As Integer
        'regcount = Classlist.Items.Count
        'For regbase = 0 To regcount - 1
        '    studreg = dsschool.StudentRegister.NewStudentRegisterRow
        '    Try
        '        If Classlist.GetItemChecked(regbase) = True Then
        '            studreg.studentID = Classlist.Items.Item(regbase)
        '            studreg._Date = DateTimePicker3.Value.Date
        '            studreg.Status = "Present"
        '            '  studreg.Year = regyearComboBox.Text
        '            ' studreg.Semester = regtermComboBox.Text
        '            '  studreg.Program = regformComboBox.Text
        '            ' studreg.Level = cboRegisterLevel.Text
        '        ElseIf Classlist.GetItemChecked(regbase) = False Then
        '            studreg.studentID = Classlist.Items.Item(regbase)
        '            studreg._Date = DateTimePicker3.Value.Date
        '            studreg.Status = "Absent"
        '            'studreg.Year = regyearComboBox.Text
        '            ' studreg.Semester = regtermComboBox.Text
        '            'studreg.Program = regformComboBox.Text
        '            ' studreg.Level = cboRegisterLevel.Text
        '        End If
        '        dsschool.StudentRegister.Rows.Add(studreg)
        '        Me.TableAdapterManager.UpdateAll(dsschool)
        '        If regbase = regcount - 1 Then
        '            MsgBox("Daily Register successfully created")
        '        End If
        '    Catch ex As Exception
        '        MsgBox(Classlist.GetItemChecked(regbase) & " details cannot be saved")
        '    End Try

        ' Next

    End Sub

    Private Sub Classlist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub LinkLabel6_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        'If Home.user.Enabled = False Then
        '    MsgBox("This action requires that you provide an account with Administrative rights")
        '    editRegLoginForm.Show(Me)
        'Else
        '    StudentRegister.Show(Me)

        'End If


    End Sub

    Private Sub purposeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub





    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim z As Integer = StudentPersonalDetailsBindingSource.Find("StudentID", TextBox1.Text)

    '    Try
    '        If z >= 0 Then
    '            Dim persrow As dsSchool.StudentPersonalDetailsRow
    '            persrow = dsschool.StudentPersonalDetails.Rows.Item(z)
    '            YearTextBox.Text = persrow.Year
    '            TermTextBox.Text = persrow.Semester
    '            FormComboBox.Text = persrow.Program
    '        Else
    '            MsgBox("Invalid student ID")
    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub TextBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub StudentIDComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim z As Integer = StudentPersonalDetailsBindingSource.Find("StudentID", StudentIDComboBox1.Text)

        'Try
        '    If z >= 0 Then
        '        Dim persrow As dsSchool.StudentPersonalDetailsRow
        '        persrow = dsschool.StudentPersonalDetails.Rows.Item(z)
        '        YearComboBox1.Text = persrow.Year
        '        TermComboBox.Text = persrow.Semester
        '        FormComboBox.Text = persrow.Program
        '    Else
        '        MsgBox("Invalid student ID")
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub



    Private Sub typeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub









    Private Sub classComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Me.StudentPersonalDetailsTableAdapter1.FillByClasSub(Me.DsStudentSearches.StudentPersonalDetails, markformComboBox.Text, markyearComboBox.Text, cboLevel.Text, cboSemsubsSearch.Text)

        'Catch ex As Exception

        'End Try



    End Sub

    Private Sub leaveclassComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Try
        '    Me.StudentPersonalDetailsTableAdapter1.FillByClasSub(Me.DsStudentSearches.StudentPersonalDetails, cboLeaveProg.Text, cboLeaveClass.Text, cboLeaveLevel.Text, cboLeaveSem.Text)

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub leaveformcombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Me.StudentPersonalDetailsTableAdapter1.FillByClasSub(Me.DsStudentSearches.StudentPersonalDetails, cboLeaveProg.Text, cboLeaveClass.Text, cboLeaveLevel.Text, cboLeaveSem.Text)

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub regyearComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Classlist.Items.Clear()
        'regname.Text = ""
        'regsurname.Text = ""

        'Dim classstuds As dsSchool.enrollmentRow
        ''Dim studrow As dsSchool.studen
        'Dim subcount, subbase As Integer
        'subcount = EnrollmentBindingSource.Count
        ''MsgBox(subcount)
        'Try
        '    For subbase = 0 To subcount - 1
        '        classstuds = dsschool.enrollment.Rows.Item(subbase)
        '        If classstuds.Date_Joined = regyearComboBox.Text And classstuds.Program = regformComboBox.Text And classstuds.Semester = regtermComboBox.Text And classstuds.Year = cboRegisterLevel.Text Then ''And classstuds.Session = cboRegSession.Text Then
        '            ' StudentFeesBindingSource.Find("StudentID", classstuds.StudentID)
        '            Classlist.Items.Add(classstuds.StudentID)
        '        End If

        '    Next

        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub regclasComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Classlist.Items.Clear()
        'regname.Text = ""
        'regsurname.Text = ""

        'Dim classstuds As dsSchool.enrollmentRow
        'Dim subcount, subbase As Integer
        'subcount = EnrollmentBindingSource.Count
        ''MsgBox(subcount)
        'Try
        '    For subbase = 0 To subcount - 1
        '        classstuds = dsschool.enrollment.Rows.Item(subbase)
        '        If classstuds.Year = regyearComboBox.Text And classstuds.Program = regformComboBox.Text Then ''And classstuds.Semester = regtermComboBox.Text Then
        '            Classlist.Items.Add(classstuds.StudentID)
        '        End If

        '    Next

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub regformComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Classlist.Items.Clear()
        'regname.Text = ""
        'regsurname.Text = ""

        'Dim classstuds As dsSchool.enrollmentRow
        ''Dim studrow As dsSchool.studen
        'Dim subcount, subbase As Integer
        'subcount = EnrollmentBindingSource.Count
        ''MsgBox(subcount)
        'Try
        '    For subbase = 0 To subcount - 1
        '        classstuds = dsschool.enrollment.Rows.Item(subbase)
        '        If classstuds.Date_Joined = regyearComboBox.Text And classstuds.Program = regformComboBox.Text And classstuds.Semester = regtermComboBox.Text And classstuds.Year = cboRegisterLevel.Text Then  ''And classstuds.Session = cboRegSession.Text Then
        '            ' StudentFeesBindingSource.Find("StudentID", classstuds.StudentID)
        '            Classlist.Items.Add(classstuds.StudentID)
        '        End If

        '    Next

        'Catch ex As Exception
        'End Try

    End Sub

    'Private Sub persclas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.StudentPersonalDetailsTableAdapter.FillByClass(Me.dsschool.StudentPersonalDetails, persForm.Text, persclas.Text, persyear.Text)
    '    Catch ex As Exception

    '    End Try
    'End Sub






    Private Sub ToolStripButton28_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Student_Load()
    End Sub

    'Private Sub idsearch_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.StudentPersonalDetailsTableAdapter.FillByClass(Me.dsschool.StudentPersonalDetails, persForm.Text, persclas.Text, persyear.Text)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub idsearch2_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            ' Me.StudentPersonalDetailsTableAdapter.FillByID(Me.dsschool.StudentPersonalDetails, idsearch2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim num() As String
        'Dim sendcount As Integer = 0
        'Dim file_name2 As String
        'Dim accrow As dsSchool.SMSAccRow
        'Try
        '    accrow = Me.dsschool.SMSAcc.Rows.Item(0)
        'Catch ex As Exception
        '    MsgBox("No SMS Account details found contact the systems Administrator")
        '    Exit Sub
        'End Try
        'Dim oHttp As New Object
        'Dim studrow As dsSchool.StudentPersonalDetailsRow
        'Dim a, b As Integer
        'a = StudentPersonalDetailsBindingSource.Count
        'If a = 0 Then
        '    MsgBox("No student Details Found")
        'End If
        'Dim senderid As String = InputBox("Enter prefered Sender ID", "Sender ID", "Our School")


        'Try
        '    For b = 0 To a - 1
        '        studrow = dsschool.StudentPersonalDetails.Rows.Item(b)
        '        Dim c As Integer = StudentLeavingBindingSource.Find("StudentID", studrow.StudentID)
        '        If c < 0 Then
        '            Dim strPassword, strUrl, strUsername, strMessage As Object
        '            Dim strMobileNumber As String
        '            'Dim senderid As String
        '            strUsername = accrow.UserName
        '            strPassword = accrow.Password
        '            senderid = senderid
        '            Try
        '                strMobileNumber = studrow.Contact_Number
        '            Catch ex As Exception
        '                strMobileNumber = "+263772846598"
        '            End Try

        '            strMessage = RichTextBox.Text
        '            oHttp = CreateObject("Microsoft.XMLHTTP")
        '            strUrl = "http://www.mymobileapi.com/api5/http5.aspx?Type=sendparam&username=" + strUsername + "&password=" + strPassword + "&numto=" + strMobileNumber + "&data1=" + strMessage + "&senderid=" + senderid
        '            oHttp.open("POST", strUrl, False)
        '            oHttp.send()
        '            oHttp = Nothing

        '            ReDim Preserve num(sendcount)
        '            num(sendcount) = strMobileNumber & ", "
        '            ' MsgBox(num)
        '            oHttp = Nothing
        '            If a - 1 = b Then
        '                Try
        '                    MsgBox(num.Length & " messages successfully sent,choose location below to save the delivery report ")
        '                Catch ex As Exception
        '                    MsgBox("No message has been sent")
        '                    Exit Sub
        '                End Try

        '                OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
        '                OpenFileDialog1.FilterIndex = 2
        '                OpenFileDialog1.RestoreDirectory = True
        '                SaveFileDialog1.ShowDialog()
        '                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '                    file_name2 = SaveFileDialog1.FileName
        '                    Using objwriter As New StreamWriter(file_name2)
        '                        For D1 = 0 To num.Length - 1
        '                            objwriter.Write(num(D1))
        '                        Next
        '                    End Using
        '                End If
        '            End If
        '            sendcount += 1
        '        Else

        '        End If

        '    Next

        'Catch ex As Exception
        '    MsgBox("No internet connection detected")

        '    Try
        '        MsgBox(num.Length & " messages successfully sent,choose location below to save the delivery report ")
        '    Catch ex1 As Exception
        '        MsgBox("No message could be sent")
        '        Exit Sub
        '    End Try

        '    OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
        '    OpenFileDialog1.FilterIndex = 2
        '    OpenFileDialog1.RestoreDirectory = True
        '    SaveFileDialog1.ShowDialog()
        '    If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        file_name2 = SaveFileDialog1.FileName
        '        Using objwriter As New StreamWriter(file_name2)
        '            For D1 = 0 To num.Length - 1
        '                objwriter.Write(num(D1))
        '            Next

        '        End Using
        '    End If

        'End Try

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        specific.Enabled = True
        'MsgBox("Search Students on the Panel Below")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '        Dim accrow As dsSchool.SMSAccRow
        '        Dim file_name2 As String
        '        Dim sendcount As Integer = 0
        '        Dim num() As String
        '        Dim webrequest As Net.WebRequest

        '        Dim webresponse As Net.WebResponse
        '        Dim webresponsestring As String = ""
        '        Dim number, send As String
        '        Dim strPassword, strUsername, strMessage As Object
        '        Dim strurl As String
        '        Dim strMobileNumber, strStudMobilenumber, strNOKMobileNumber As String
        '        Dim type As Integer = 0
        '        Dim dlr As Integer = 1
        '        Try
        '            accrow = Me.dsschool.SMSAcc.Rows.Item(0)
        '        Catch ex As Exception
        '            MsgBox("No SMS Account details found contact the systems Administrator")
        '            Exit Sub
        '        End Try
        '5:

        '        If Panel Then
        '            If dgClassList.SelectedRows.Count = 0 Then
        '                MsgBox("No Student Selected")
        '            Else
        '                Dim a As Integer = dgClassList.Rows.Count
        '                Dim b, d As Integer
        '                Dim senderid As String = InputBox("Enter Prefered Sender ID", "Sender ID", "Our School")
        '                Try
        '                    For b = 0 To a - 1
        '                        If dgClassList.Rows(b).Selected Then

        '                            strUsername = accrow.UserName
        '                            strPassword = accrow.Password
        '                            senderid = senderid
        '                            Try
        '                                If rbStudOnly.Checked Then
        '                                    Try
        '                                        strStudMobilenumber = dgClassList.Rows(b).Cells(5).Value
        '                                    Catch ex As Exception
        '                                        strStudMobilenumber = ""
        '                                    End Try

        '                                    d = InStr(strStudMobilenumber, "+")
        '                                    strMobileNumber = Mid(strStudMobilenumber, d + 1)
        '                                ElseIf rbNextOfKinOnly.Checked Then
        '                                    Try
        '                                        strNOKMobileNumber = dgClassList.Rows(b).Cells(6).Value
        '                                    Catch ex As Exception
        '                                        strNOKMobileNumber = ""
        '                                    End Try

        '                                    d = InStr(strNOKMobileNumber, "+")
        '                                    strMobileNumber = Mid(strNOKMobileNumber, d + 1)
        '                                Else
        '                                    Try
        '                                        strStudMobilenumber = dgClassList.Rows(b).Cells(5).Value
        '                                    Catch ex As Exception
        '                                        strStudMobilenumber = ""
        '                                    End Try
        '                                    d = InStr(strStudMobilenumber, "+")
        '                                    strStudMobilenumber = Mid(strStudMobilenumber, d + 1)
        '                                    Try
        '                                        strNOKMobileNumber = dgClassList.Rows(b).Cells(6).Value
        '                                    Catch ex As Exception
        '                                        strNOKMobileNumber = ""
        '                                    End Try

        '                                    d = InStr(strNOKMobileNumber, "+")
        '                                    strNOKMobileNumber = Mid(strNOKMobileNumber, d + 1)
        '                                    strMobileNumber = strStudMobilenumber + "," + strNOKMobileNumber

        '                                End If
        '                                If strMobileNumber = "" Then
        '                                    GoTo nunum1
        '                                End If
        '                            Catch ex As Exception
        '                                strMobileNumber = "263772846598"
        '                            End Try
        '                            strMessage = "Dear " & dgClassList.Rows(b).Cells(1).Value & " " & dgClassList.Rows(b).Cells(2).Value & " " & RichTextBox.Text
        '                            strurl = "http://121.241.242.114:8080/bulksms/bulksms?username=" & strUsername & "&password=" & strPassword & "&type=" & type & "&dlr=" & dlr & "&destination=" & strMobileNumber & "&source=" & senderid & "&message=" & strMessage & ""
        '                            Try
        '                                webrequest = Net.HttpWebRequest.Create(Trim(strurl))
        '                                webrequest.Timeout = 25000
        '                            Catch ex As Exception
        '                                MsgBox(ex.Message)
        '                                Exit Sub
        '                            End Try

        '                            Try
        '                                webresponse = webrequest.GetResponse
        '                                Dim reader As IO.StreamReader = New IO.StreamReader(webresponse.GetResponseStream)
        '                                webresponsestring = reader.ReadToEnd
        '                                webresponse.Close()
        '                            Catch ex As Exception
        '                                MsgBox(ex.Message)
        '                                schoolsections = False
        '                                cboSchoolSections.Enabled = False
        '                                Exit Sub
        '                            End Try
        '                            gblnsinglemsg = False
        '                            ReDim Preserve num(sendcount)
        '                            num(sendcount) = strMobileNumber & ", "
        '                            If b = a - 1 Then
        '                                Try
        '                                    MsgBox(num.Length & " messages successfully sent")
        '                                Catch ex As Exception
        '                                    MsgBox("No message has been sent")
        '                                    Exit Sub
        '                                End Try

        '                            End If

        '                            sendcount += 1

        '                        Else
        '                            If b = a - 1 Then
        '                                Try
        '                                    MsgBox(num.Length & " messages successfully sent")
        '                                Catch ex As Exception
        '                                    MsgBox("No message has been sent")
        '                                    Exit Sub
        '                                End Try


        '                            End If
        '                        End If
        '                        gblnsinglemsg = False
        'nunum1:             Next
        '                Catch ex As Exception
        '                    MsgBox("No internet connection detected")
        '                    Try
        '                        MsgBox(num.Length & " messages successfully sent,choose location below to save the delivery report ")
        '                    Catch ex1 As Exception
        '                        MsgBox("No message could be sent")
        '                        schoolsections = False
        '                        cboSchoolSections.Enabled = False
        '                        Exit Sub
        '                    End Try

        '                End Try

        '            End If

        '        ElseIf schoolsections Then
        '            Dim drr As SqlDataReader
        '            Dim sql As String = " select [Contact Number],studentname,studentsurname,nokcontactnumber from studentpersonaldetails inner join forms on studentpersonaldetails.program = forms.Forms" &
        '  " where Section = '" & Trim(cboSchoolSections.Text) & "' and studentpersonaldetails.StudentID not in (select StudentID from StudentLeaving ) and [session] not in ( 'OutGoing','transferred') "
        '            drr = ExecuteReader(sql)
        '            Dim senderid As String = InputBox("Enter Prefered Sender ID", "Sender ID", "Our School")
        '            Try
        '                While drr.Read
        '                    Dim d As Integer
        '                    strUsername = accrow.UserName
        '                    strPassword = accrow.Password
        '                    senderid = senderid
        '                    Try

        '                        If rbStudOnly.Checked Then
        '                            Try
        '                                strStudMobilenumber = drr(0).ToString
        '                            Catch ex As Exception
        '                                strStudMobilenumber = ""
        '                            End Try

        '                            d = InStr(strStudMobilenumber, "+")
        '                            strMobileNumber = Mid(strStudMobilenumber, d + 1)

        '                        ElseIf rbNextOfKinOnly.Checked Then

        '                            Try
        '                                strNOKMobileNumber = drr(3).ToString
        '                            Catch ex As Exception
        '                                strNOKMobileNumber = ""
        '                            End Try

        '                            d = InStr(strNOKMobileNumber, "+")
        '                            strMobileNumber = Mid(strNOKMobileNumber, d + 1)
        '                        ElseIf rbBoth.Checked Then
        '                            Try
        '                                strStudMobilenumber = drr(0).ToString
        '                            Catch ex As Exception
        '                                strStudMobilenumber = ""
        '                            End Try
        '                            d = InStr(strStudMobilenumber, "+")
        '                            Try
        '                                strNOKMobileNumber = drr(3).ToString
        '                            Catch ex As Exception
        '                                strNOKMobileNumber = ""
        '                            End Try
        '                            d = InStr(strNOKMobileNumber, "+")

        '                            strMobileNumber = strStudMobilenumber + "," + strNOKMobileNumber

        '                        End If
        '                        If strMobileNumber = "" Then
        '                            GoTo nonum
        '                        End If
        '                    Catch ex As Exception
        '                        GoTo nonum
        '                    End Try
        '                    strMessage = "Dear " & drr(1).ToString & " " & drr(2).ToString & " " & RichTextBox.Text
        '                    strurl = "http://121.241.242.114:8080/bulksms/bulksms?username=" & strUsername & "&password=" & strPassword & "&type=" & type & "&dlr=" & dlr & "&destination=" & strMobileNumber & "&source=" & senderid & "&message=" & strMessage & ""
        '                    Try
        '                        webrequest = Net.HttpWebRequest.Create(Trim(strurl))
        '                        webrequest.Timeout = 25000
        '                    Catch ex As Exception
        '                        MsgBox(ex.Message)
        '                        Exit Sub
        '                    End Try
        '                    webresponse = webrequest.GetResponse
        '                    Dim reader As IO.StreamReader = New IO.StreamReader(webresponse.GetResponseStream)
        '                    webresponsestring = reader.ReadToEnd
        '                    webresponse.Close()
        '                    ' MsgBox(webresponsestring)
        '                    '' strUrl = "http://122.241.242.144:8080/sms/sms? username =" & strUsername & " &password =" & strPassword & "&type = 6 " & " &dlr = 0 " & "&destination = " & strMobileNumber & " & source = " & senderid & "&message =  " & strMessage
        '                    ReDim Preserve num(sendcount)
        '                    num(sendcount) = strMobileNumber & "(" & drr(1).ToString & " " & drr(2).ToString & "| "
        '                    sendcount += 1
        'nonum:          End While
        '                schoolsections = False
        '                cboSchoolSections.Enabled = False

        '                MsgBox(IIf(sendcount > 0, sendcount & "  messages succesfully sent choose location to save delivery report", "no message sent"))
        '                OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
        '                OpenFileDialog1.FilterIndex = 2
        '                OpenFileDialog1.RestoreDirectory = True
        '                SaveFileDialog1.ShowDialog()
        '                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '                    file_name2 = SaveFileDialog1.FileName
        '                    Using objwriter As New StreamWriter(file_name2)
        '                        For D1 = 0 To num.Length - 1
        '                            objwriter.Write(num(D1))
        '                            If D1 = num.Length - 1 Then
        '                                MsgBox("Save Successful")
        '                            End If
        '                        Next
        '                    End Using
        '                End If
        '            Catch ex As Exception
        '                MsgBox(ex.Message)
        '                MsgBox(sendcount & " messages succesfully sent")
        '                schoolsections = False
        '                cboSchoolSections.Enabled = False
        '                Exit Sub
        '            End Try

        '        ElseIf groups Then
        '            'Group code here 
        '        End If
    End Sub

    Private Sub studs_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ExamMarkNotifications.Show(Me)
    End Sub



    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim webrequest As Net.WebRequest
        'Dim webresponse As Net.WebResponse
        'Dim webresponsestring As String = ""

        'Dim accrow As dsSchool.SMSAccRow
        'Try
        '    accrow = dsschool.SMSAcc.Rows.Item(0)
        'Catch ex As Exception
        '    MsgBox("No SMS Account details found contact the systems Administrator")
        '    Exit Sub
        'End Try

        'Dim oHttp As New Object
        'Dim number, send As String
        'Dim quantity, q As Integer
        'quantity = InputBox("Quantity", "People", "0")
        'send = InputBox("Enter Sender Id", "Sender", "Myself")
        'For q = 1 To quantity
        '    number = InputBox("Enter Phone Number", "Phone Number", "+263772846598")
        '    Dim strPassword, strUsername, strMessage As Object
        '    Dim strurl As String
        '    Dim strMobileNumber As String
        '    Dim d As Integer
        '    d = InStr(number, "+")
        '    strMobileNumber = Mid(number, d + 1)
        '    Dim senderid As String
        '    strUsername = accrow.UserName
        '    strPassword = accrow.Password
        '    senderid = send
        '    'strMobileNumber = number
        '    strMessage = RichTextBox.Text
        '    Dim type As Integer = 0
        '    Dim dlr As Integer = 1
        '    ' oHttp = CreateObject("Microsoft.XMLHTTP")
        '    'strUrl = "http://121.241.242.120:8080/bulksms/bulksms? username = " & strUsername & " & password =" & strPassword & "& type =" & type = 0 & dlr = " & dlr & " & destination = " & strMobileNumber & " & source = " & senderid & " & Message = " & strMessage"
        '    strurl = "http://121.241.242.114:8080/bulksms/bulksms?username=" & strUsername & "&password=" & strPassword & "&type=" & type & "&dlr=" & dlr & "&destination=" & strMobileNumber & "&source=" & senderid & "&message=" & strMessage & ""


        '    Try
        '        webrequest = Net.HttpWebRequest.Create(Trim(strurl))
        '        webrequest.Timeout = 25000

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        Exit Sub
        '    End Try
        '    Try
        '        webresponse = webrequest.GetResponse
        '        Dim reader As IO.StreamReader = New IO.StreamReader(webresponse.GetResponseStream)
        '        webresponsestring = reader.ReadToEnd
        '        webresponse.Close()
        '        MsgBox(webresponsestring)
        '        MsgBox("Message successfully sent")
        '    Catch ex As Exception
        '        Exit Sub
        '    End Try



        '    If q = quantity Then
        '        MsgBox("messages successully sent")
        '    End If

        'Next

    End Sub

    Private Sub GenderLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim webrequest As Net.WebRequest
        'Dim webresponse As Net.WebResponse
        'Dim webresponsestring As String = ""
        'Dim accrow As dsSchool.SMSAccRow
        'Try
        '    accrow = dsschool.SMSAcc.Rows.Item(0)
        'Catch ex As Exception
        '    MsgBox("No SMS Account details found contact the systems Administrator")
        '    Exit Sub
        'End Try

        'Dim oHttp As Object
        'Dim strPassword, strUrl, strUsername As Object
        'oHttp = CreateObject("Microsoft.XMLHTTP")
        'strUsername = accrow.UserName
        'strPassword = accrow.Password

        'strUrl = "http://121.241.242.114:8080/CreditCheck/checkcredits?username=" & strUsername & "&password=" & strPassword & ""
        'Try
        '    webrequest = Net.HttpWebRequest.Create(Trim(strUrl))
        '    webrequest.Timeout = 25000
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Exit Sub
        'End Try
        'Try
        '    webresponse = webrequest.GetResponse
        '    Dim reader As IO.StreamReader = New IO.StreamReader(webresponse.GetResponseStream)
        '    webresponsestring = reader.ReadToEnd
        '    webresponse.Close()
        '    MsgBox(webresponsestring)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Exit Sub
        'End Try







    End Sub
    Public Function URLEncode(ByVal StringToEncode As String, Optional ByRef UsePlusRatherThanHexForSpace As Boolean = False) As String

        Dim TempAns As String
        Dim CurChr As Short
        CurChr = 1
        Do Until CurChr - 1 = Len(StringToEncode)
            Select Case Asc(Mid(StringToEncode, CurChr, 1))
                Case 48 To 57, 65 To 90, 97 To 122
                    TempAns = TempAns & Mid(StringToEncode, CurChr, 1)
                Case 32
                    If UsePlusRatherThanHexForSpace = True Then
                        TempAns = TempAns & "+"
                    Else
                        TempAns = TempAns & "%" & Hex(32)
                    End If
                Case Else
                    TempAns = TempAns & "%" & Microsoft.VisualBasic.Format(Hex(Asc(Mid(StringToEncode, CurChr, 1))), "00")
            End Select

            CurChr = CurChr + 1
        Loop

        URLEncode = TempAns
    End Function

    'Private Sub RichTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim a As String
    '    Dim b() As String
    '    a = (Len(RichTextBox.Text) / 160)


    '    b = Split(a, ".")
    '    If Len(RichTextBox.Text) Mod 160 = 0 And a >= 1 Then

    '        characters.Text = b(0) & " / " & Len(RichTextBox.Text)

    '    Else
    '        characters.Text = b(0) + 1 & " / " & Len(RichTextBox.Text)
    '    End If
    'End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        Dim sql As String
        Dim drr As SqlDataReader

        Try
            ' Dim studsubrow As dsSchool.StudentSubjectsRow
            ' Dim subrow As dsSchool.SubjectsRow
            Dim name As String
            Dim a, b, c, d As Integer



            a = Available_Subjects.Items.Count

            For b = 0 To a - 1
                Available_Subjects.SetItemChecked(b, False)
            Next
            name = dgSubStuds.SelectedRows(0).Cells(1).Value

            lbSubs.Text = name & " 's Subjects"

            Dim params As New List(Of SqlParameter)
            Dim param As SqlParameter

            param = New SqlParameter("@stud", dgSubStuds.SelectedRows(0).Cells(0).Value)
            params.Add(param)
            Try
                param = New SqlParameter("@exam", cboSubExam.SelectedValue)
                params.Add(param)

            Catch ex As Exception
                param = New SqlParameter("@exam", "No Exam")
                params.Add(param)
            End Try

            param = New SqlParameter("@enrolref", dgSubStuds.SelectedRows(0).Cells(2).Value)
            params.Add(param)


            sql = "spRetrieveStudentSubjects"

            drr = ExecuteReader(sql,, True,, params, False)
            Try

                While drr.Read
                    For i = 0 To Available_Subjects.Items.Count - 1
                        If drr(0) = CleanComboVal(Available_Subjects.Items(i).text) Then
                            Available_Subjects.SetItemChecked(i, True)
                        End If
                    Next
                End While
            Catch ex As Exception

            End Try




        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        'frmStudentStatus.Show(Me)
    End Sub


    Private Sub cboSemesterSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Me.StudentPersonalDetailsTableAdapter1.FillByClasSub(Me.DsStudentSearches.StudentPersonalDetails, markformComboBox.Text, acayearComboBox.Text, cboLevel.Text, cboSemsubsSearch.Text, cboIntekSubsSearch.Text, cboSubSess.Text)
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub cboSemsubsSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Me.StudentPersonalDetailsTableAdapter1.FillByClasSub(Me.DsStudentSearches.StudentPersonalDetails, acaformComboBox.Text, acayearComboBox.Text, cboLevel.Text, cboSemsubsSearch.Text)
        'Catch ex As Exception

        'End Try
    End Sub




    Private Sub cboEnrYearSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Try
        '    StudentPersonalDetailsTableAdapter.FillBy(dsschool.StudentPersonalDetails, cboProgramSearch.Text, cbolevelSearch.Text, cboEnrYearSearch.Text)
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub StudentPersonalDetailsBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()


    End Sub
    Private Sub persnew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ImagePictureBox_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ImagePictureBox.ImageLocation = OpenFileDialog1.FileName
            lnkRemoveImage.Visible = True
        End If
    End Sub

    Private Sub TreeView2_AfterSelect_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)

    End Sub





    Private Sub BindingNavigatorAddNewItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mblnaddingUser = True
        lbAddingStudent.Visible = True
        btnStudProfile.Visible = False
        '      BindingNavigator1.Items("BindingNavigatorAddNewItem").Visible = False
        If StudentIDTextBox.Enabled = True Then
            StudentIDTextBox.Focus()
        Else
            StudentSurnameTextBox.Focus()
        End If

        loadStudInfo("")



        enablestudscreen(True)
    End Sub
    Private Sub GetSiblings(ByVal stud As String)
        Sibs = New List(Of csSiblings)
        For i = 0 To dgSiblings.Rows.Count - 1
            Dim sibling As New csSiblings
            sibling.StudentId = stud
            sibling.Sibling = dgSiblings.Rows(i).Cells(0).Value
            Sibs.Add(sibling)

        Next
    End Sub

    Private Function GetSiblingGroup(stud As String) As String
        Dim param As SqlParameter
        Dim params As List(Of SqlParameter)

        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Dim sibgrp As Object
        Dim strsibgrp As String = ""

        Try


            params = New List(Of SqlParameter)
            Dim sql As String = "spGetSiblingGroup"

            param = New SqlParameter("@stud", stud)
            cmd.Parameters.Add(param)

            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sql
            cnn.Open()

            sibgrp = cmd.ExecuteScalar()

            '      strsibgrp = IIf(IsNothing(sibgrp), "", sibgrp.ToString)

            If IsNothing(sibgrp) Then
                strsibgrp = ""
            Else
                strsibgrp = sibgrp.ToString
            End If
            Return strsibgrp


        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            cnn.Close()

        End Try




    End Function
    Private Sub loadStudInfo(searchstud As String)

        btnStudProfile.Visible = False
        If searchstud <> "" Then


            stud = New csStudent(searchstud)

            If Not IsNothing(stud) Then



                With stud
                    mblnaddingUser = False
                    lbAddingStudent.Visible = False
                    btnStudProfile.Visible = True

                    StudentIDTextBox.Text = .StudentID
                    StudentNameTextBox.Text = .StudentName
                    StudentSurnameTextBox.Text = stud.StudentSurname
                    If Trim(stud.Gender) <> "" Then
                        GenderComboBox.Text = Trim(stud.Gender)
                    End If
                    DateOfBirthMaskedTextBox.Text = .Dob.ToShortDateString
                    PlaceOfBirthTextBox.Text = .Pob

                    FeesSourceComboBox.Text = .feessource
                    Try
                        ProgramComboBox.SelectedValue = stud.Program
                    Catch ex As Exception

                    End Try


                    'Enrollment
                    SessionComboBox.Text = stud.Session
                    'ddlIntake.Text = stud.Intake

                    YearComboBox.Text = .Level
                    Date_EnrolledMaskedTextBox.Text = stud.Dateenrollment.ToShortDateString

                    cboEnrolType.Text = stud.EnrolType

                    'Contact Details
                    StreetTextBox.Text = stud.Address1
                    LocationTextBox.Text = stud.Address2
                    CityTextBox.Text = stud.Address3
                    EmailAddressTextBox.Text = stud.EmailAddress
                    Contact_NumberTextBox.Text = stud.ContactNumber


                    'Prev School
                    txtprevSchool.Text = stud.PrevSchool
                    txtPrevSchoolContact.Text = stud.PrevSchoolContact
                    txtPrevSchoolCommnt.Text = stud.PrevSchoolComments



                    'Sponsor Details
                    'TxtNokContact.Text = stud.SponsorContact
                    'txtNokName.Text = stud.Sponsorname
                    'txtNokAddress.Text = stud.SponsorAddres
                    'txtNokRelation.Text = stud.SponsorRelation
                    NationalIDTextBox.Text = stud.NatId

                    'Medicals
                    txtFamilyDoc.Text = stud.Med_Doctor
                    txtDocContNumber.Text = stud.Med_DocContact
                    txtAllergies.Text = stud.Med_Allergies

                    txtMedComments.Text = stud.Med_Comments


                    'Xtra Curricula

                    txtSports.Text = stud.Xcur_Activities
                    txtHouse.Text = stud.Xcur_House

                    'Banking



                    '  Dim clas As [Class] = dbcontext.Classes.Where(Function(x) x.Description = .ClassDesc).ToList().SingleOrDefault
                    cboClass.Text = .ClassDesc
                    txtStudRef.Text = .enrolref


                    loadSiblings(stud.StudentID)

                    '  LoadFiles(stud.StudentID)

                    LoadStudNok(stud.StudentID)
                    Try
                        Dim imagestream As MemoryStream = New MemoryStream(stud.Image)
                        ImagePictureBox.Image = Image.FromStream(imagestream)
                        lnkRemoveImage.Visible = True
                    Catch ex As Exception
                        ImagePictureBox.Image = Nothing
                        lnkRemoveImage.Visible = False
                    End Try

                    '   LoadImage()


                End With
            End If
        Else



            StudentIDTextBox.Text = ""
            StudentNameTextBox.Text = ""
            StudentSurnameTextBox.Text = ""

            DateOfBirthMaskedTextBox.Text = ""
            PlaceOfBirthTextBox.Text = ""


            FeesSourceComboBox.SelectedIndex = 2
            ProgramComboBox.SelectedIndex = 0
            GenderComboBox.Text = ""
            YearComboBox.Text = 1
            SessionComboBox.SelectedIndex = 0
            cboEnrolType.SelectedIndex = 0
            cboClass.SelectedIndex = 0

            Date_EnrolledMaskedTextBox.Text = Now.Date
            '   DateOfBirthMaskedTextBox.Text = Now.Date



            'Contact Details
            StreetTextBox.Text = ""
            LocationTextBox.Text = ""
            CityTextBox.Text = ""
            EmailAddressTextBox.Text = ""
            Contact_NumberTextBox.Text = ""

            'Prev School
            txtprevSchool.Text = ""
            txtPrevSchoolContact.Text = ""
            txtPrevSchoolCommnt.Text = ""

            ImagePictureBox.Image = Nothing

            'Sponsor Details

            NationalIDTextBox.Text = ""

            'Medicals
            txtFamilyDoc.Text = ""
            txtDocContNumber.Text = ""
            txtAllergies.Text = ""

            txtMedComments.Text = ""


            'Xtra Curricula

            txtSports.Text = ""
            txtHouse.Text = ""

            'Banking



            '  Dim clas As [Class] = dbcontext.Classes.Where(Function(x) x.Description = .ClassDesc).ToList().SingleOrDefault
            cboClass.Text = ""
            txtStudRef.Text = ""


            dgSiblings.DataSource = Nothing
            Sibs = New List(Of csSiblings)

            '  LoadFiles(stud.StudentID)

            dgStudNok.DataSource = Nothing
            NokS = New List(Of StudNok)

            Docs = New List(Of csDocs)

            txtHiddenStudID.Text = "0"

            '   LoadImage()




        End If
    End Sub

    Private Sub loadStudClass()
        Dim dob, dateenrolled, deductiondate As Date
        Date.TryParse(DateOfBirthMaskedTextBox.Text, dob)
        Date.TryParse(Date_EnrolledMaskedTextBox.Text, dateenrolled)

        Date.TryParse(Date_EnrolledMaskedTextBox.Text, deductiondate)


        With stud
            .StudentID = StudentIDTextBox.Text
            .StudentName = StudentNameTextBox.Text
            .StudentSurname = StudentSurnameTextBox.Text
            .Gender = GenderComboBox.Text

            .Pob = PlaceOfBirthTextBox.Text
            .NatId = NationalIDTextBox.Text
            .feessource = FeesSourceComboBox.Text
            .Program = ProgramComboBox.SelectedValue

            '    .Intake = ddlIntake.Text
            .Level = YearComboBox.Text

            .Session = SessionComboBox.Text
            .EnrolType = cboEnrolType.Text
            .Dateenrollment = dateenrolled
            .Address1 = StreetTextBox.Text
            .Address2 = LocationTextBox.Text
            .Address3 = CityTextBox.Text
            .ContactNumber = Contact_NumberTextBox.Text
            .EmailAddress = EmailAddressTextBox.Text
            .PrevSchool = txtprevSchool.Text
            .PrevSchoolContact = txtPrevSchoolContact.Text
            .PrevSchoolComments = txtPrevSchoolCommnt.Text
            .Dob = dob
            .StudImageUrl = ""
            .ImageBytes = getimage(ImagePictureBox)
            '    .imagesize = imagesize
            '    .PostedStudImage = ImageUpload.PostedFile
            '    .StudImageUrl = StudImage.ImageUrl
            .NatId = NationalIDTextBox.Text

            GetSiblings(StudentIDTextBox.Text)
            .Siblings = Sibs
            '   getDocs(Session("SearchStud"))
            .Docs = Docs
            .noks = NokS
            .Med_Doctor = txtFamilyDoc.Text
            .Med_DocContact = txtDocContNumber.Text
            .Med_Allergies = txtAllergies.Text
            .Med_BloodGroup = ""
            .Med_Comments = txtMedComments.Text
            .Xcur_Activities = txtSports.Text
            .Xcur_House = txtHouse.Text

            .BankName = ""
            .BankAccName = ""
            .BankAccNumber = ""
            .BankBranch = ""
            '    .StudSubs = GetStudSubs()
            .ClassDesc = cboClass.Text
            .enrolref = txtStudRef.Text











        End With
    End Sub

    Public Function validateEntry() As String

        Dim errormsg As String = ""
        Dim promptmsg As String = "The following mandatory fields were left blank or have invalid Input : " & vbNewLine




        If Trim(StudentSurnameTextBox.Text) = "" Then
            If errormsg <> "" Then
                errormsg += "Student LastName " & vbNewLine
            Else
                errormsg = promptmsg & "Student LastName " & vbNewLine
            End If


        End If

        If Trim(StudentNameTextBox.Text) = "" Then
            If errormsg <> "" Then
                errormsg += "Student FirstName " & vbNewLine
            Else
                errormsg = promptmsg & "Student FirstName" & vbNewLine
            End If
        End If

        If GenderComboBox.Text = "" Then
            If errormsg <> "" Then
                errormsg += "Gender" & vbNewLine
            Else
                errormsg = promptmsg & "Gender"
            End If
        End If

        If cboClass.Text = "" Then
            If errormsg <> "" Then
                errormsg += "Class" & vbNewLine
            Else
                errormsg = promptmsg & "Class" & vbNewLine
            End If
        End If

        If ProgramComboBox.Text = "" Then
            If errormsg <> "" Then
                errormsg += "Program" & vbNewLine
            Else
                errormsg = promptmsg & "Program" & vbNewLine
            End If
        End If

        If YearComboBox.Text = "" Then
            If errormsg <> "" Then
                errormsg += "Level" & vbNewLine
            Else
                errormsg = promptmsg & "Level" & vbNewLine
            End If
        End If

        If SessionComboBox.Text = "" Then
            If errormsg <> "" Then
                errormsg += "Session" & vbNewLine
            Else
                errormsg = promptmsg & "Session" & vbNewLine
            End If
        End If

        If Contact_NumberTextBox.Text = "" Then
            If errormsg <> "" Then
                errormsg += "Contact Number" & vbNewLine
            Else
                errormsg = promptmsg & "Contact Number" & vbNewLine
            End If
        Else
            'Dim list() As String = Contact_NumberTextBox.Text.Split(",")
            'Dim a As Integer = list.Length
            'For i = 0 To a - 1
            '    If Mid(list(i).ToString, 1, 4).Contains("263") Then
            '    Else
            '        If errormsg <> "" Then
            '            errormsg += "Contact Number" & vbNewLine
            '        Else
            '            errormsg = promptmsg & "Contact Number" & vbNewLine
            '            Exit For
            '        End If
            '    End If
            'Next

        End If




        If Not IsDate(DateOfBirthMaskedTextBox.Text) Then
            If errormsg <> "" Then
                errormsg += "Date Of Birth" & vbNewLine
            Else
                errormsg = promptmsg & "Date Of Birth" & vbNewLine
            End If
        End If

        If Not IsDate(Date_EnrolledMaskedTextBox.Text) Then
            If errormsg <> "" Then
                errormsg += "Date Enrolled" & vbNewLine
            Else
                errormsg = promptmsg & "Date Enrolled" & vbNewLine
            End If
        End If



        If Not IsDate(Date_EnrolledMaskedTextBox.Text) Then
            If errormsg <> "" Then
                errormsg += "Date Enrolled" & vbNewLine
            Else
                errormsg = promptmsg & "Date Enrolled" & vbNewLine
            End If
        End If


        Return errormsg

    End Function
    Private Sub enablestudscreen(enable As Boolean)

        If enable Then
            isloading = False
            screenenabled = True
            SchoolInfoBindingNavigatorSaveItem.Enabled = True

        Else
            screenenabled = False
            isloading = True
            SchoolInfoBindingNavigatorSaveItem.Enabled = False
        End If
        gbStudPersonalDetails.Enabled = enable
        gbEnrollmentDetails.Enabled = enable
        gbContactDetails.Enabled = enable
        gbPic.Enabled = enable
        gbXtraCurricular.Enabled = enable
        gbSiblings.Enabled = enable
        gbNok.Enabled = enable
        gbMedicalDetails.Enabled = enable


        '     BindingNavigatorAddNewItem.Visible = Not enable


        StudentIDTextBox.Enabled = Not schoolinfo.AutoId
        '    StudentIDTextBox.Enabled = Not schoolinfo.AutoId


    End Sub
    Private Sub LastEdited(Stud As String)
        Try

            Dim sql As String = " select dbo.GetEditDetails( '" & Stud & "')"
            Dim usr As String = ExecuteScalar(sql, True)




            lbEditDetails.Text = usr
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SchoolInfoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolInfoBindingNavigatorSaveItem.Click
        Dim s As String = ""
        Dim errors As String = validateEntry()


        If errors = "" Then
        Else
            MsgBox(errors)
            Exit Sub
        End If

        If Not mblnaddingUser Then
            ' a = StudentLeavingBindingSource.Find("StudentID", StudentIDTextBox.Text)
            stud = New csStudent(Trim(StudentIDTextBox.Text))

            loadStudClass()

            stud.isnew = False





            If Not stud.Available Then


                If gblnconfirmUpdate = False Then
                    s = MsgBox("Student no longer part of the school would you like to re-register the student", MsgBoxStyle.YesNo)
                    If s = vbYes Then
                        MsgBox("Edit the Student Details to continue")
                        gblnconfirmUpdate = True
                    Else
                        gblnconfirmUpdate = False
                    End If
                Else
                    s = MsgBox("Did you update the new enrollment details for the student", MsgBoxStyle.YesNo)

                    If s = vbYes Then
                        Dim reason As String = ""

                        If stud.Save() Then

                            MsgBox("Status Updated")
                            '    enrolstud()
                            enablestudscreen(False)
                            mblnaddingUser = False
                            gblnconfirmUpdate = False
                            LastEdited(stud.StudentID)
                        Else
                            MsgBox(stud.erramsg)
                            enablestudscreen(True)
                            mblnaddingUser = False
                            gblnconfirmUpdate = True
                        End If
                    ElseIf s = vbNo Then
                        MsgBox("Update The enrollment details and try again later")

                        Exit Sub
                    End If
                End If
            Else


                If stud.Save Then
                    MsgBox("Edit Successful")
                    enablestudscreen(False)
                    mblnaddingUser = False
                    LastEdited(stud.StudentID)
                Else
                    MsgBox(stud.erramsg)
                    enablestudscreen(True)
                    mblnaddingUser = False
                End If





            End If


        Else  ' adding user 

            stud = New csStudent()

            loadStudClass()

            If stud.Save Then

                BindingNavigator1.Items("BindingNavigatorAddNewItem").Visible = True
                MsgBox("Student Details Successfully Added")


                If Not StudentIDTextBox.Enabled Then
                    stud.StudentID = stud.SavedStud
                    stud.SearchStud()
                    loadStudInfo(stud.StudentID)
                    StudentIDTextBox.Text = stud.StudentID
                End If



                mblnaddingUser = False
                LastEdited(stud.StudentID)

            Else
                mblnaddingUser = True
                MsgBox(stud.erramsg)
                BindingNavigator1.Items("BindingNavigatorAddNewItem").Visible = False
                MsgBox("Student could not be succefully created")
                Exit Sub
            End If







        End If

    End Sub








    Private Sub cboRegisterLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Classlist.Items.Clear()
        'regname.Text = ""
        'regsurname.Text = ""

        'Dim classstuds As dsSchool.enrollmentRow
        ''Dim studrow As dsSchool.studen
        'Dim subcount, subbase As Integer
        'subcount = EnrollmentBindingSource.Count
        ''MsgBox(subcount)
        'Try
        '    For subbase = 0 To subcount - 1
        '        classstuds = dsschool.enrollment.Rows.Item(subbase)
        '        If classstuds.Date_Joined = regyearComboBox.Text And classstuds.Program = regformComboBox.Text And classstuds.Semester = regtermComboBox.Text And classstuds.Year = cboRegisterLevel.Text Then ''And classstuds.Session = cboRegSession.Text Then
        '            ' StudentFeesBindingSource.Find("StudentID", classstuds.StudentID)
        '            Classlist.Items.Add(classstuds.StudentID)
        '        End If

        '    Next

        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub cboRegSession_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Classlist.Items.Clear()
        'regname.Text = ""
        'regsurname.Text = ""

        'Dim classstuds As dsSchool.enrollmentRow
        ''Dim studrow As dsSchool.studen
        'Dim subcount, subbase As Integer
        'subcount = EnrollmentBindingSource.Count
        ''MsgBox(subcount)
        'Try
        '    For subbase = 0 To subcount - 1
        '        classstuds = dsschool.enrollment.Rows.Item(subbase)
        '        If classstuds.Date_Joined = regyearComboBox.Text And classstuds.Program = regformComboBox.Text And classstuds.Semester = regtermComboBox.Text And classstuds.Year = cboRegisterLevel.Text Then ''And classstuds.Session = cboRegSession.Text Then
        '            ' StudentFeesBindingSource.Find("StudentID", classstuds.StudentID)
        '            Classlist.Items.Add(classstuds.StudentID)
        '        End If

        '    Next

        'Catch ex As Exception
        'End Try

    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub





    Private Sub TreeView1_AfterSelect_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)

    End Sub


















    Private Sub ProgramComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            YearComboBox.Focus()
        End If
    End Sub





    Private Sub SemesterComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SessionComboBox.Focus()
        End If
    End Sub

    Private Sub SessionComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            StreetTextBox.Focus()
        End If
    End Sub


    Private Sub SessionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Residential_AdressTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Contact_NumberTextBox.Focus()
        End If
    End Sub

    Private Sub Residential_AdressTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Contact_NumberTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            EmailAddressTextBox.Focus()
        End If
    End Sub

    Private Sub Contact_NumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EmailAddressTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            NokNameTextBox.Focus()
        End If
    End Sub

    Private Sub EmailAddressTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NokNameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            NOKRelationTextBox.Focus()
        End If
    End Sub

    Private Sub NokNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NOKSurnameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            NOKOccupationTextBox.Focus()
        End If
    End Sub

    Private Sub NOKSurnameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NOKAddressTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            NOKContactNumberTextBox.Focus()
        End If
    End Sub

    Private Sub NOKAddressTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NOKContactNumberTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub



    Private Sub SemesterComboBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SessionComboBox.Focus()
        End If
    End Sub

    Private Sub SemesterComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadDatasets()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub StudentIDTextBox_KeyDown_1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles StudentIDTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            StudentSurnameTextBox.Focus()
        End If
    End Sub

    Private Sub GenderComboBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GenderComboBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateOfBirthMaskedTextBox.Focus()
        End If
    End Sub




    Private Sub GenderComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenderComboBox.SelectedIndexChanged

    End Sub

    Private Sub StudentNameTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles StudentNameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboEnrolType.Focus()
        End If
    End Sub

    Private Sub StudentNameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles StudentNameTextBox.LostFocus
        Dim sql As String
        sql = " select studentid from studentpersonaldetails where rtrim(ltrim(studentname))  + rtrim(ltrim(studentsurname)) = '" & Trim(StudentNameTextBox.Text) + Trim(StudentSurnameTextBox.Text) & "'"
        Dim id As String = ExecuteScalar(sql)
        If id <> "" And mblnaddingUser Then
            Dim res As String = MsgBox(StudentNameTextBox.Text + " " & StudentSurnameTextBox.Text & " is already present in database do you wish to continue", MsgBoxStyle.YesNo)

            If res = 6 Then

            Else
                LoadDatasets()
            End If
        End If

    End Sub





    Private Sub AccountNumberTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            GenderComboBox.Focus()
        End If
    End Sub

    Private Sub AccountNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReligionTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            GenderComboBox.Focus()
        End If
    End Sub

    Private Sub ReligionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateOfBirthDateTimePicker_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            NationalIDTextBox.Focus()
        End If
    End Sub



    Private Sub Year_JoinedComboBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ProgramComboBox.Focus()
        End If
    End Sub

    Private Sub ProgramComboBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProgramComboBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            YearComboBox.Focus()
        End If
    End Sub

    Private Sub YearComboBox2_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles YearComboBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SessionComboBox.Focus()
        End If
    End Sub

    Private Sub YearComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearComboBox.SelectedIndexChanged

    End Sub



    Private Sub SessionComboBox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SessionComboBox.SelectedIndexChanged

    End Sub

    Private Sub Residential_AdressTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles StreetTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Contact_NumberTextBox.Focus()

        End If
    End Sub

    Private Sub Residential_AdressTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StreetTextBox.TextChanged

    End Sub

    Private Sub Contact_NumberTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Contact_NumberTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            EmailAddressTextBox.Focus()
        End If
    End Sub

    Private Sub Contact_NumberTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contact_NumberTextBox.TextChanged

    End Sub

    Private Sub EmailAddressTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EmailAddressTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            NokNameTextBox.Focus()
        End If
    End Sub

    Private Sub EmailAddressTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailAddressTextBox.TextChanged

    End Sub

    Private Sub NokNameTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NokNameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            NOKRelationTextBox.Focus()
        End If
    End Sub

    Private Sub NokNameTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NokNameTextBox.TextChanged

    End Sub

    Private Sub NOKSurnameTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NOKRelationTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            NOKOccupationTextBox.Focus()
        End If
    End Sub



    Private Sub NOKAddressTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NOKOccupationTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            NOKContactNumberTextBox.Focus()

        End If
    End Sub



    Private Sub NOKContactNumberTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NOKContactNumberTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ImagePictureBox.Focus()
        ElseIf e.KeyCode = Keys.End Then
            SchoolInfoBindingNavigatorSaveItem_Click(Me, Nothing)
        End If
    End Sub


    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        LoadDatasets()
    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try
            Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ttxSearchtext_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ttxSearchtext.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button31_Click(Me, Nothing)
        ElseIf e.KeyCode = Keys.Down Then
            If lstResult.Items.Count > 0 Then
                lstResult.SetSelected(0, True)
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            lstResult.Visible = False
        End If
        '    ElseIf rbID.Checked Then




        '    ElseIf rbName.Checked Then
        '        ' MsgBox("Search not Active")
        '        Dim a As Integer
        '        ' Dim b As Integer = InStr(ttxSearchtext.Text, " ")
        '        Dim c As Integer
        '        Dim Sname, Fname, rev, FullName As String
        '        FullName = ttxSearchtext.Text
        '        c = FullName.Length
        '        rev = StrReverse(FullName)
        '        a = InStr(rev, " ")
        '        Sname = Trim(Mid(FullName, (c - a) + 2))
        '        Fname = Trim(Mid(FullName, 1, (c - a) + 1))

        '        a = StudentFullNameBindingSource.Find("FullName", ttxSearchtext.Text)
        '        Dim d As Integer = StudentFullNameBindingSource.Find("FullName", Trim(Sname) + " " + Trim(Fname))
        '        If a < 0 And d < 0 Then
        '            MsgBox("Student Name could not be found")
        '        Else
        '    If d >= 0 And a < 0 Then
        '        a = d
        '    End If
        '    StudentPersonalDetailsBindingSource.Position = a
        'End If
        '        Else
        'MsgBox("Select Search Criterion")
        '        End If
        '    End If
        '  End If
    End Sub
    Public Sub search()


    End Sub


    Private Sub RepSearch(ByVal lst As ListBox, ByVal hyt As Double, ByVal width As Double)
        With lst
            .Width = width
            .Height = Height
            '.Top = 321
            '.Left = 4
            .Visible = True
        End With

    End Sub
    Private Sub tvStudsEdt_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)

        If e.Node.Text = "EnrollmentDetails" Then
            Dim frmenroledit As New frmEditEnrollment()
            frmenroledit.frmmain = mainform

            frmenroledit.Show()
        End If
    End Sub





    Private Sub BindingNavigatorAddNewItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If goUser.Group > 2 Then
        '    MsgBox("User not Authorised to add or save Students")
        '    LoadDatasets()
        'Else


        'End If

    End Sub





    Private Sub getProgramsubjects()

        Available_Subjects.Items.Clear()


        params = New List(Of SqlParameter)

        Dim subs As SqlDataReader
        sql = "spGetProgramSubjects"
        param = New SqlParameter("@prog", cboSubProg.SelectedValue.ToString)
        params.Add(param)

        subs = ExecuteReader(sql, True,,, params, False)

        While subs.Read
            Available_Subjects.Items.Add(subs(0))

        End While

    End Sub



















    Private Sub regformComboBox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        regformComboBox_SelectedIndexChanged(Me, Nothing)
    End Sub

    'Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If Not gblnsinglemsg Then
    '        Try
    '            StudentPersonalDetailsTableAdapter1.FillByClasSub(DsStudentSearches.StudentPersonalDetails, cboSmsProg.Text, cboSmdClass.Text, cboSmslevel.Text, cboSmsSem.Text, cboSmsIntake.Text, cboSmsSess.Text)
    '        Catch ex As Exception

    '        End Try
    '    End If

    'End Sub

    Private Sub saveSub_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveSub.Click
        saveSub_Click(Me, Nothing)
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button11_Click(Me, Nothing)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterMarks.Click
        Button1_Click(Me, Nothing)
    End Sub

    Private Sub Button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        blnschoolsections = False
        cboSchoolSections.Enabled = False
        Button4_Click_1(Me, Nothing)
    End Sub



    'Private Sub cboSmdClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSmdClass.SelectedIndexChanged
    '    Dim sql As String
    '    Dim drr As SqlDataReader
    '    If Not gblnsinglemsg Then

    '        sql = " select distinct program,[status] from studentpersonaldetails where [year] = '" & cboSmslevel.Text & "' and session = '" & cboSmsSess.Text & "'"
    '        drr = ExecuteReader(sql)
    '        Try
    '            While drr.Read


    '                StudentPersonalDetailsTableAdapter1.FillByClasSub(dsStudentSearches.StudentPersonalDetails, drr(0), cboSmdClass.Text, cboSmslevel.Text, cboSmsSem.Text, drr(1), cboSmsSess.Text)

    '            End While
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    'Private Sub cboSmslevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSmslevel.SelectedIndexChanged
    '    Dim sql As String
    '    Dim drr As SqlDataReader
    '    If Not gblnsinglemsg Then

    '        sql = " select distinct program,[status] from studentpersonaldetails where [year] = '" & cboSmslevel.Text & "' and session = '" & cboSmsSess.Text & "'"
    '        drr = ExecuteReader(sql)
    '        Try
    '            While drr.Read


    '                StudentPersonalDetailsTableAdapter1.FillByClasSub(dsStudentSearches.StudentPersonalDetails, drr(0), cboSmdClass.Text, cboSmslevel.Text, cboSmsSem.Text, drr(1), cboSmsSess.Text)

    '            End While
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    'Private Sub cboSmsSem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSmsSem.SelectedIndexChanged
    '    Dim sql As String
    '    Dim drr As SqlDataReader
    '    If Not gblnsinglemsg Then

    '        sql = " select distinct program,[status] from studentpersonaldetails where [year] = '" & cboSmslevel.Text & "' and session = '" & cboSmsSess.Text & "'"
    '        drr = ExecuteReader(sql)
    '        Try
    '            While drr.Read


    '                StudentPersonalDetailsTableAdapter1.FillByClasSub(dsStudentSearches.StudentPersonalDetails, drr(0), cboSmdClass.Text, cboSmslevel.Text, cboSmsSem.Text, drr(1), cboSmsSess.Text)

    '            End While
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    'Private Sub cboSmsIntake_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not gblnsinglemsg Then
    '        Try
    '            StudentPersonalDetailsTableAdapter1.FillByClasSub(DsStudentSearches.StudentPersonalDetails, cboSmsProg.Text, cboSmdClass.Text, cboSmslevel.Text, cboSmsSem.Text, cboSmsIntake.Text, cboSmsSess.Text)
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    Private Sub dgSubStuds_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSubStuds.CellClick

    End Sub

    Private Sub dgSubStuds_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSubStuds.CellContentClick

    End Sub



    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6_Click(Me, Nothing)
    End Sub



    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim FILE_NAME As String = ""
        Dim nums() As String = Nothing
        Dim a As Integer = 0



        '  OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True


        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FILE_NAME = OpenFileDialog1.FileName
        End If
        Try
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            Do While objReader.EndOfStream = False
                Try
                    RichTextBox.Text = RichTextBox.Text & objReader.ReadLine & vbNewLine

                Catch ex As Exception
                    Exit Sub
                End Try
                ' RichTextBox1.Text = objReader.ReadLine
            Loop
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If RichTextBox.Text = "" Then
            MsgBox("Text Box Empty")
            Exit Sub
        End If
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        Dim file As String = ""
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = SaveFileDialog1.FileName
        End If
        Try
            Using sw As StreamWriter = New StreamWriter(file)
                sw.Write(RichTextBox.Text)
                ' Add some text to the file.

                MsgBox("save Successful")
                'sw.WriteLine("header for the file.")
                'sw.WriteLine("-------------------")
                '' Arbitrary objects can also be written to the file.
                'sw.Write("The date is: ")
                'sw.WriteLine(DateTime.Now)
                'sw.Close()
            End Using

        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        RichTextBox.Clear()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSMS.Click

    End Sub

    Private Sub TabPage1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPersonalDetails.Click

    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button10_Click(Me, Nothing)
    End Sub

    Private Sub lbStudEnrollment_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub ImagePictureBox_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagePictureBox.Click
        ImagePictureBox_Click_1(Me, Nothing)
    End Sub

    Private Sub StudentIDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentIDTextBox.TextChanged


        Dim reader As SqlDataReader = Nothing
        Dim cnt As Integer = 0
        lbEditDetails.Text = ""
        If mblnaddingUser = False Then
            tvEnrol.Nodes.Clear()
            tvEnrol.Nodes.Add(StudentIDTextBox.Text)


            Dim sql As String = "select distinct program from enrollment where studentid = '" & StudentIDTextBox.Text & "'"
            reader = ExecuteReader(sql, , True)

            While reader.Read
                tvEnrol.Nodes(0).Nodes.Add(reader(0).ToString)
                tvEnrol.Nodes(0).Nodes(cnt).Tag = "Program"
                cnt += 1

            End While

            LastEdited(StudentIDTextBox.Text)
            gblnconfirmUpdate = False
        End If
        tvEnrol.ExpandAll()





    End Sub









    Private Sub txtStudMarksSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tvEditMarks_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvEditMarks.AfterSelect
        If e.Node.Text = "EditMarks" Then
            Dim editmarks As New frmEditMarks()
            editmarks.ShowDialog()


        End If
    End Sub

    Private Sub PersonalDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PersonalDetails.Click
        If PersonalDetails.SelectedTab.Text = "Student Marks" Then
            Dim lbl As TreeView
            Dim Nd, NdSub, NdSubSub, NdSubSubSub As TreeNode
            Nd = Nothing : NdSub = Nothing : NdSubSub = Nothing
            NdSubSubSub = Nothing
            lbl = tvEditMarks
            For Each Nd In lbl.Nodes
                For Each NdSub In Nd.Nodes
                    Try
                        If Not IsNothing(NdSub.Tag) Then
                            If NdSub.Tag.ToString = "-1" Then
                                NdSub.Text = ""
                            Else
                                If NdSub.Tag.ToString <> "0" Then
                                    Dim dr As SqlDataReader = Nothing
                                    Dim sql As String = ""
                                    sql = "Select Auth_HasAccess from " &
                                          "dbo.UserAuthorisations where Auth_Group = '" & goUser.Group &
                                          "' and Auth_AccComp = '" & NdSub.Tag.ToString & "'"
                                    dr = ExecuteReader(sql, Nothing)
                                    While dr.Read
                                        If Not CBool(dr.Item(0)) Then NdSub.Text = ""
                                    End While
                                End If
                            End If
                            For Each NdSubSub In NdSub.Nodes
                                Try
                                    If Not IsNothing(NdSubSub.Tag) Then
                                        If NdSubSub.Tag.ToString = "-1" Then
                                            NdSubSub.Text = ""
                                        Else
                                            If NdSubSub.Tag.ToString <> "0" Then
                                                Dim dr As SqlDataReader = Nothing
                                                Dim sql As String = ""
                                                sql = "Select Auth_HasAccess from " &
                                                      "dbo.UserAuthorisations where Auth_Group = '" & goUser.Group &
                                                      "' and Auth_AccComp = '" & NdSubSub.Tag.ToString & "'"
                                                dr = ExecuteReader(sql, Nothing)
                                                While dr.Read
                                                    If Not CBool(dr.Item(0)) Then NdSubSub.Text = ""
                                                End While
                                            End If
                                        End If
                                    End If
                                Catch ex As Exception
                                End Try
                                For Each NdSubSubSub In NdSubSub.Nodes
                                    Try
                                        If Not IsNothing(NdSubSubSub.Tag) Then
                                            If NdSubSubSub.Tag.ToString = "-1" Then
                                                NdSubSubSub.Text = ""
                                            Else
                                                If NdSubSubSub.Tag.ToString <> "0" Then
                                                    Dim dr As SqlDataReader = Nothing
                                                    Dim sql As String = ""
                                                    sql = "Select Auth_HasAccess from " &
                                                          "dbo.UserAuthorisations where Auth_Group = '" & goUser.Group &
                                                          "' and Auth_AccComp = '" & NdSubSubSub.Tag.ToString & "'"
                                                    dr = ExecuteReader(sql, Nothing)
                                                    While dr.Read
                                                        If Not CBool(dr.Item(0)) Then NdSubSubSub.Text = ""
                                                    End While
                                                End If
                                            End If
                                        End If
                                    Catch ex As Exception
                                    End Try
                                Next
                            Next
                        End If
                    Catch ex As Exception
                    End Try
                Next
            Next
        ElseIf PersonalDetails.SelectedTab.Text = "StudentReceipts" Then

            cboReceiptSearch.Text = "Student"
            txtReceiptSearch.Text = StudentIDTextBox.Text
            lbSeacrhFees.Visible = False

        ElseIf PersonalDetails.SelectedTab.Text = "Student SMS  Notification" Then
            rbsmsClass.Checked = True
            'Next
        ElseIf PersonalDetails.SelectedTab.Text = "Register" Then
            'rbClassRegister.Checked = True
        End If
    End Sub






    Private Sub lstResult_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstResult.DoubleClick
        Try

            ttxSearchtext.Text = lstResult.SelectedValue
            lstResult.DataSource = Nothing

            lstResult.Visible = False


            loadStudInfo(Trim(ttxSearchtext.Text))

        Catch ex As Exception

        End Try

        ' ttxSearchtext_KeyDown(Me, Nothing)
    End Sub





    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim studrow As dsSchool.StudentPersonalDetailsRow

        'Dim studlivrow As dsSchool.StudentLeavingRow
        'Dim sql As String
        'Dim drr As SqlDataReader
        'Dim enrol, enrol1 As dsSchool.enrollmentRow
        'Dim a, b, c, d, g As Integer
        'a = EnrollmentBindingSource.Count
        'c = chkPrograms.Items.Count

        'For d = 0 To c - 1
        '    If chkPrograms.GetItemCheckState(d) = CheckState.Checked Then
        '        sql = " select studentid ,status  from enrollment where   program = '" & Trim(CleanComboVal(chkPrograms.Items(d))) & _
        '        "' and [date joined] =  " & Trim(cboActPerClenrol.Text) & " and intake = '" & cboActPerClIntk.Text & "' and year = " & cboActPerClLvl.Text & "  and semester = " & cboActPerClSem.Text & " and studentid  in ( select studentid from studentleaving )"
        '        drr = ExecuteReader(sql)
        '        '  For b = 0 To a - 1
        '        While drr.Read
        '            sql = " delete from studentleaving where studentid = '" & drr(0).ToString & "'"
        '            ExecuteNonQuery(sql, , True)
        '            sql = " update enrollment set status =  'Available' where studentid = '" & drr(0).ToString & "' and program = '" & Trim(CleanComboVal(chkPrograms.Items(d))) & _
        '        "' and [date joined] =  " & Trim(cboActPerClenrol.Text) & " and intake = '" & cboActPerClIntk.Text & "' and year = " & cboActPerClLvl.Text & "  and semester = " & cboActPerClSem.Text & ""
        '            ExecuteNonQuery(sql, , True)
        '            '
        '            If drr(1).ToString = "Completed" Then
        '                sql = " update enrollment set status =  'Available' where studentid = '" & drr(0).ToString & "' and program = '" & Trim(CleanComboVal(chkPrograms.Items(d))) & _
        '                                "' and [date joined] =  " & Trim(cboActPerClenrol.Text) & " and intake = '" & cboActPerClIntk.Text & "' and year = " & cboActPerClLvl.Text & "  and semester = " & cboActPerClSem.Text & ""
        '                ExecuteNonQuery(sql, , True)
        '                '
        '            End If
        '        End While



        '    End If


        '    If d = c - 1 Then
        '        MsgBox("Selected Program students have been successfully activated")
        '    End If


        'Next




    End Sub













    Private Sub txtstudsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtstudsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchStuds(txtstudsearch.Text, gdStudents, "MarksStudentID")
        ElseIf e.KeyCode = Keys.Down Then
            If lbstuds.Items.Count > 0 Then
                lbstuds.SetSelected(0, True)
            Else
                lbstuds.Visible = False
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstudsearch.TextChanged


    End Sub

    Private Sub lbstuds_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbstuds.DoubleClick
        txtstudsearch.Text = lbstuds.SelectedValue
        lbstuds.DataSource = Nothing
        searchStuds(txtstudsearch.Text, gdStudents, "MarksStudentID")
        lbstuds.Visible = False
    End Sub
    Private Sub searchStuds(ByVal searhtxt As String, ByVal dg As DataGridView, studfieldname As String)
        Try


            Dim studcounts As Integer = dg.Rows.Count

            For d = 0 To studcounts - 1
                dg.Rows(d).Selected = False
            Next


            For d = 0 To studcounts - 1
                dg.Rows(d).Selected = False
                If searhtxt = dg.Rows(d).Cells(studfieldname).Value Then
                    dg.Rows(d).Selected = True
                    Exit Sub
                End If
            Next
        Catch ex As Exception

        End Try


        'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
        'If a < 0 Then
        '    MsgBox("Student ID could Not be found")
        'Else
        '    StudentPersonalDetailsBindingSource.Position = a
        'End If
    End Sub

    Private Sub searchStudsSpec(ByVal searhtxt As String, ByVal dg As DataGridView, cellname As String)
        Try
            Dim a, b, d As Integer
            Dim searchstring As String

            searchstring = searhtxt


            Dim studcounts As Integer = dg.Rows.Count

            For d = 0 To studcounts - 1

                dg.Rows(d).Selected = False

            Next

            For d = 0 To studcounts - 1
                If searchstring = dg.Rows(d).Cells(cellname).Value Then
                    dg.Rows(d).Selected = True
                    Exit Sub
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub gdStudents_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gdStudents.SelectionChanged



        gvMarks.Rows.Clear()
        Dim row As Integer = 0
        lbstuds.Items.Clear()
        Dim cnn As New SqlConnection(ConnectionString)

        Dim drr As SqlDataReader = Nothing

        Try
            cnn.Open()

            Dim studid, name As String

            ' subcount = Me.StudentSubjectsBindingSource.Count
            studid = gdStudents.SelectedRows(0).Cells("MarksStudentID").Value
            name = gdStudents.SelectedRows(0).Cells("MarksStudName").Value

            'Try
            lbDetails.Text = name & " 's Subjects"


            Dim cmd As New SqlCommand

            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "spGetSubMarks"



            params = New List(Of SqlParameter)


            param = New SqlParameter("@stud", studid)
            params.Add(param)

            param = New SqlParameter("@exam", cboMarkExam.Text)
            params.Add(param)

            param = New SqlParameter("@sub", cboMarkSubject.SelectedValue)
            params.Add(param)

            For Each par As SqlParameter In params
                cmd.Parameters.Add(par)
            Next
            drr = cmd.ExecuteReader()
            While drr.Read
                Dim marks As SqlDataReader = Nothing
                gvMarks.Rows.Add()
                gvMarks.Columns("Comment").Visible = Not CBool(drr("MultiComment").ToString)
                gvMarks.Columns("MultiComment").Visible = CBool(drr("MultiComment").ToString)
                blnMultiComment = CBool(drr("MultiComment").ToString)
                gvMarks.Rows(row).Cells("Check").Value = True


                Dim txtItem As DataGridViewTextBoxCell = CType(gvMarks.Rows(row).Cells("item"), DataGridViewTextBoxCell)
                txtItem.Value = row + 1
                txtItem.Tag = "Item"
                txtItem.ReadOnly = True

                Dim txtSubjects As DataGridViewTextBoxCell = CType(gvMarks.Rows(row).Cells("Subject"), DataGridViewTextBoxCell)
                txtSubjects.Value = drr("Subdesc").ToString
                txtSubjects.Tag = "Subject"
                txtSubjects.ReadOnly = True

                Dim txtExam As DataGridViewTextBoxCell = CType(gvMarks.Rows(row).Cells("ExamMark"), DataGridViewTextBoxCell)
                txtExam.Value = drr("ExamMark").ToString
                txtExam.Tag = "ExamMark"



                If blnMultiComment Then
                    Dim cbocomm As DataGridViewComboBoxCell = CType(gvMarks.Rows(row).Cells("MultiComment"), DataGridViewComboBoxCell)


                    cbocomm.Items.Clear()

                    For Each cmnt In GetGradeComments(cboMarkProg.Text, gvMarks.Rows(row).Cells("ExamMark").Value)
                        cbocomm.Items.Add(cmnt)
                    Next

                    cbocomm.Value = drr("Comment").ToString
                    cbocomm.Tag = "Comment"
                Else
                    Dim txtcomm As DataGridViewTextBoxCell = CType(gvMarks.Rows(row).Cells("Comment"), DataGridViewTextBoxCell)
                    txtcomm.Value = drr("Comment").ToString
                    txtcomm.Tag = "Comment"
                    '      txtcomm.ReadOnly = Not CBool(drr("CommentVisible").ToString
                End If



                Dim cboremarksgrid As DataGridViewComboBoxCell = CType(gvMarks.Rows(row).Cells("Remarks"), DataGridViewComboBoxCell)
                cboremarksgrid.Value = drr("ExamStatus").ToString
                cboremarksgrid.Tag = "Remarks"


                gvMarks.Rows(row).Cells("Effort").Value = drr("effort").ToString

                gvMarks.Rows(row).Cells("MarkRef").Value = drr("MarkRef").ToString

                gvMarks.Rows(row).Cells("CourseMark").Value = drr("CourseMark").ToString

                row += 1
            End While







        Catch ex As Exception
            '        MsgBox(ex.Message)
        Finally

            cnn.Close()

        End Try






    End Sub

    Private Function fillmarks(ByVal stud As String, ByVal exam As String, ByVal subject As String, Optional ByVal filtersub As String = "") As SqlDataReader
        Dim drr As SqlDataReader
        Dim sql As String = "select  coursemark,exammark ,examstatus,comment from studentmarks where rerefencename = '" & exam & "' and studentid = '" & stud & "' and subjectid = '" & CleanComboVal(subject) & "' and status = 1"
        drr = ExecuteReader(sql, , True)
        Return drr
    End Function

    Private Sub chkRegSubs_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'If chkRegSubs.CheckedItems.Count > 0 Then
        '    btnEnterMarks.Enabled = True
        'Else
        '    btnEnterMarks.Enabled = False
        'End If
    End Sub




    Private Sub lbstuds_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbstuds.LostFocus
        lbstuds.Visible = False
    End Sub

    Private Sub lbstuds_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbstuds.SelectedIndexChanged

    End Sub



    Private Sub txtSubSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSubSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchStuds(txtSubSearch.Text, dgSubStuds, "SubjectsStudentID")
        ElseIf e.KeyCode = Keys.Down Then
            If lsbSubStud.Items.Count > 0 Then
                lsbSubStud.SetSelected(0, True)
            Else
                lsbSubStud.Visible = False
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            lsbSubStud.Visible = False
        End If
    End Sub

    Private Sub txtSubSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txtSubSearch.Text = "" Then
            lsbSubStud.Visible = False
        Else
            lsbSubStud.Visible = True
        End If

        Dim serchtext As String = Trim(txtSubSearch.Text)
        lsbSubStud.DataSource = Nothing

        lbstuds.Visible = True


        Dim filter As String = " and studentpersonaldetails.studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%' "

        Dim cmd As New SqlCommand
        Dim cnn As SqlConnection = New SqlConnection(ConnectionString())

        cmd.CommandText = "FillAllStuds"

        cmd.Connection = cnn
        cmd.CommandType = CommandType.StoredProcedure

        params = New List(Of SqlParameter)


        param = New SqlParameter("@prog", cboSubProg.SelectedValue)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@year", cboSubLvl.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@sess", cboSubSess.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@classdesc", cboSubClass.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@filter", filter)
        cmd.Parameters.Add(param)


        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing



        cnn.Open()

        ' Dim sql As String = "Select FirstName + '' + LastName as Student ,AppReference , DateSubmitted,Class,Intake,program,campus,email,level,sem,session from studentapplication where email = '" & email & "' and appstatus = 'Approved'  and apllicationAccepted = 1 and StudentIDAssigned =  0  "

        Try


            taApps = New SqlDataAdapter(cmd)



            taApps.Fill(dsApps)


            lsbSubStud.DataSource = dsApps.Tables(0)
            lsbSubStud.DisplayMember = "StudName"
            lbSubStudSearch.ValueMember = "StudentID"





        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try

    End Sub

    Private Sub lsbSubStud_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsbSubStud.DoubleClick
        txtSubSearch.Text = lsbSubStud.SelectedValue
        lsbSubStud.DataSource = Nothing
        searchStuds(txtSubSearch.Text, dgSubStuds, "SubjectsStudentID")
        lsbSubStud.Visible = False
    End Sub

    Private Sub lsbSubStud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsbSubStud.SelectedIndexChanged

    End Sub

    Private Sub StudentMarks_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentMarks.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim sql As String = ""

        'If changedate(mskstudRegDate.Text) = "-  -  " Then
        '    MsgBox("Invalid Date")
        '    Exit Sub
        'End If

        'If rbSubjectRegister.Checked Then

        '    sql = "delete from studentregister where subject = '" & cboExamAttendaceSub.SelectedValue & "' " & _
        '    "and class = '" & cboExamAttendaceClass.Text & "' and level = " & cmbregLvl.Text & " and sem = " & cmbregSem.Text & _
        '    " and session = '" & cmbregSess.Text & "' and date = '" & changedate(mskstudRegDate.Text) & "' and [type] = 'Subject'"
        '    ExecuteNonQuery(sql, , True)
        '    Dim examregisterow As dsSchool.StudentRegisterRow

        '    If Classlist.CheckedItems.Count = 0 Then
        '        Dim res As String = MsgBox("No student present on particular day ,do you want to continue ", vbYesNo)

        '        If res = "6" Then


        '            For i = 0 To Classlist.Items.Count - 1
        '                examregisterow = dsschool.StudentRegister.NewStudentRegisterRow
        '                Try
        '                    If Classlist.GetItemChecked(i) = True Then
        '                        sql = "INSERT INTO studentregister ([studentID] ,[Date],[Subject] ,[Status] ,[Level] ,[Sem] ,[Class] ,[Session],[type])" & _
        '    " VALUES ( '" & CleanComboVal(Classlist.Items(i).ToString) & "' , '" & changedate(mskstudRegDate.Text) & "' ,'" & cboExamAttendaceSub.SelectedValue.ToString & "','Present'," & _
        '    " " & cmbregLvl.Text & " , " & cmbregSem.Text & "," & cboExamAttendaceClass.Text & " ,'" & cmbregSess.Text & "','Subject')"
        '                        ExecuteNonQuery(sql, , True)

        '                    Else
        '                        sql = "INSERT INTO studentregister ([studentID] ,[Date],[Subject] ,[Status] ,[Level] ,[Sem] ,[Class] ,[Session],[type])" & _
        '        " VALUES ( '" & CleanComboVal(Classlist.Items(i).ToString) & "' , '" & changedate(mskstudRegDate.Text) & "' ,'" & cboExamAttendaceSub.SelectedValue.ToString & "','Absent'," & _
        '        " " & cmbregLvl.Text & " , " & cmbregSem.Text & "," & cboExamAttendaceClass.Text & " ,'" & cmbregSess.Text & "','Subject')"
        '                        ExecuteNonQuery(sql, , True)
        '                    End If

        '                    If i = Classlist.Items.Count - 1 Then
        '                        MsgBox("Subject Attendance Register Successfully Created")
        '                    End If
        '                Catch ex As Exception
        '                    MsgBox(ex.Message)
        '                    If i = Classlist.Items.Count - 1 Then
        '                        MsgBox("Subject Attendace Register Successfully Created")
        '                    End If
        '                End Try




        '            Next
        '        End If
        '    Else
        '        For i = 0 To Classlist.Items.Count - 1
        '            examregisterow = dsschool.StudentRegister.NewStudentRegisterRow
        '            Try
        '                If Classlist.GetItemChecked(i) = True Then
        '                    sql = "INSERT INTO studentregister ([studentID] ,[Date],[Subject] ,[Status] ,[Level] ,[Sem] ,[Class] ,[Session],[type])" & _
        '" VALUES ( '" & CleanComboVal(Classlist.Items(i).ToString) & "' , '" & changedate(mskstudRegDate.Text) & "' ,'" & cboExamAttendaceSub.SelectedValue.ToString & "','Present'," & _
        '" " & cmbregLvl.Text & " , " & cmbregSem.Text & "," & cboExamAttendaceClass.Text & " ,'" & cmbregSess.Text & "','Subject')"
        '                    ExecuteNonQuery(sql, , True)

        '                Else
        '                    sql = "INSERT INTO studentregister ([studentID] ,[Date],[Subject] ,[Status] ,[Level] ,[Sem] ,[Class], [Session],[type])" & _
        '    " VALUES ( '" & CleanComboVal(Classlist.Items(i).ToString) & "' , '" & changedate(mskstudRegDate.Text) & "' ,'" & cboExamAttendaceSub.SelectedValue.ToString & "','Absent'," & _
        '    " " & cmbregLvl.Text & " , " & cmbregSem.Text & "," & cboExamAttendaceClass.Text & " ,'" & cmbregSess.Text & "','Subject')"
        '                    ExecuteNonQuery(sql, , True)
        '                End If

        '                If i = Classlist.Items.Count - 1 Then
        '                    MsgBox("Subject Attendance Register Successfully Created")
        '                End If
        '            Catch ex As Exception
        '                MsgBox(ex.Message)
        '                If i = Classlist.Items.Count - 1 Then
        '                    MsgBox("Subject Attendace Register Successfully Created")
        '                End If
        '            End Try




        '        Next
        '    End If
        'ElseIf rbClassRegister.Checked Then

        '    sql = "delete from studentregister where [type] = 'Class' " & _
        '    "and class = '" & cboExamAttendaceClass.Text & "' and level = " & cmbregLvl.Text & " and sem = " & cmbregSem.Text & _
        '    " and session = '" & cmbregSess.Text & "' and date = '" & changedate(mskstudRegDate.Text) & "'"
        '    ExecuteNonQuery(sql, , True)
        '    If era Then

        '    End If
        '    Dim examregisterow As dsSchool.StudentRegisterRow

        '    If Classlist.CheckedItems.Count = 0 Then
        '        Dim res As String = MsgBox("No student marked present on particular day ,do you want to continue ", vbYesNo)

        '        If res = "6" Then


        '            For i = 0 To Classlist.Items.Count - 1
        '                examregisterow = dsschool.StudentRegister.NewStudentRegisterRow
        '                Try
        '                    If Classlist.GetItemChecked(i) = True Then
        '                        sql = "INSERT INTO studentregister ([studentID] ,[Date],[Status] ,[Level] ,[Sem] ,[Class] ,[Session],[type],[subject])" & _
        '    " VALUES ( '" & CleanComboVal(Classlist.Items(i).ToString) & "' , '" & changedate(mskstudRegDate.Text) & "' ,'Present'," & _
        '    " " & cmbregLvl.Text & " , " & cmbregSem.Text & "," & cboExamAttendaceClass.Text & " ,'" & cmbregSess.Text & "','Class','NoSub')"
        '                        ExecuteNonQuery(sql, , True)
        '                        If era Then
        '                            MsgBox("studentid " & CleanComboVal(Classlist.Items(i).ToString) & " could not be saved")
        '                        End If
        '                    Else
        '                        sql = "INSERT INTO studentregister ([studentID] ,[Date],[Status] ,[Level] ,[Sem] ,[Class], [Session],[type],[subject)" & _
        '        " VALUES ( '" & CleanComboVal(Classlist.Items(i).ToString) & "' , '" & changedate(mskstudRegDate.Text) & "' ,'Absent'," & _
        '        " " & cmbregLvl.Text & " , " & cmbregSem.Text & "," & cboExamAttendaceClass.Text & " ,'" & cmbregSess.Text & "','Class','NoSub')"
        '                        ExecuteNonQuery(sql, , True)
        '                        If era Then
        '                            MsgBox("studentid " & CleanComboVal(Classlist.Items(i).ToString) & " could not be saved")
        '                        End If
        '                    End If

        '                    If i = Classlist.Items.Count - 1 Then
        '                        MsgBox("Class Attendance Register Successfully Created")
        '                    End If
        '                Catch ex As Exception
        '                    MsgBox(ex.Message)
        '                    If i = Classlist.Items.Count - 1 Then
        '                        MsgBox("Class Attendace Register Successfully Created")
        '                    End If
        '                End Try




        '            Next
        '        End If
        '    Else
        '        For i = 0 To Classlist.Items.Count - 1
        '            examregisterow = dsschool.StudentRegister.NewStudentRegisterRow
        '            Try
        '                If Classlist.GetItemChecked(i) = True Then
        '                    sql = "INSERT INTO studentregister ([studentID] ,[Date] ,[Status] ,[Level] ,[Sem] ,[Class] ,[Session],[type],[subject])" & _
        '" VALUES ( '" & CleanComboVal(Classlist.Items(i).ToString) & "' , '" & changedate(mskstudRegDate.Text) & "' ,'Present'," & _
        '" " & cmbregLvl.Text & " , " & cmbregSem.Text & "," & cboExamAttendaceClass.Text & " ,'" & cmbregSess.Text & "','Class','NoSub')"
        '                    ExecuteNonQuery(sql, , True)
        '                    If era Then
        '                        MsgBox("studentid " & CleanComboVal(Classlist.Items(i).ToString) & " could not be saved")
        '                    End If
        '                Else
        '                    sql = "INSERT INTO studentregister ([studentID] ,[Date],[Status] ,[Level] ,[Sem] ,[Class], [Session],[type],[Subject])" & _
        '    " VALUES ( '" & CleanComboVal(Classlist.Items(i).ToString) & "' , '" & changedate(mskstudRegDate.Text) & "' ,'Absent'," & _
        '    " " & cmbregLvl.Text & " , " & cmbregSem.Text & "," & cboExamAttendaceClass.Text & " ,'" & cmbregSess.Text & "','Class','NoSub')"
        '                    ExecuteNonQuery(sql, , True)
        '                    If era Then
        '                        MsgBox("studentid " & CleanComboVal(Classlist.Items(i).ToString) & " could not be saved")
        '                    End If
        '                End If

        '                If i = Classlist.Items.Count - 1 Then
        '                    MsgBox("Class Attendance Register Successfully Created")
        '                End If
        '            Catch ex As Exception
        '                MsgBox(ex.Message)
        '                If i = Classlist.Items.Count - 1 Then
        '                    MsgBox("Class Attendace Register Successfully Created")
        '                End If
        '            End Try




        '        Next
        '    End If

        'End If

    End Sub

    Private Sub cboExamAttendanceExam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub regyearComboBox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        regclasComboBox_SelectedIndexChanged(Me, Nothing)
    End Sub

    Private Sub cboRegisterLevel_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cboRegisterLevel_SelectedIndexChanged(Me, Nothing)
    End Sub

    'Private Sub regtermComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Classlist.Items.Clear()
    '    regname.Text = ""
    '    regsurname.Text = ""

    '    Dim classstuds As dsSchool.enrollmentRow
    '    'Dim studrow As dsSchool.studen
    '    Dim subcount, subbase As Integer
    '    subcount = EnrollmentBindingSource.Count
    '    'MsgBox(subcount)
    '    Try
    '        For subbase = 0 To subcount - 1
    '            classstuds = dsschool.enrollment.Rows.Item(subbase)
    '            If classstuds.Date_Joined = regyearComboBox.Text And classstuds.Program = regformComboBox.Text And classstuds.Semester = regtermComboBox.Text And classstuds.Year = cboRegisterLevel.Text Then ''And classstuds.Session = cboRegSession.Text Then
    '                ' StudentFeesBindingSource.Find("StudentID", classstuds.StudentID)
    '                Classlist.Items.Add(classstuds.StudentID)
    '            End If

    '        Next

    '    Catch ex As Exception
    '    End Try

    'End Sub

    Private Sub LinkLabel6_LinkClicked_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        '    frmEditExamAttendance.Show()
    End Sub

    'Private Sub cboExamAttendaceSub_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try

    '        Classlist.Items.Clear()
    '        Dim studentsubrow As dsReports.StudentSubjectsRow
    '        Dim a As Integer = StudentSubjectsBindingSource1.Count
    '        For B1 = 0 To a - 1
    '            studentsubrow = DsReports.StudentSubjects.Rows(B1)
    '            If Trim(studentsubrow.SubjectID).ToUpper = Trim(cboExamAttendaceSub.SelectedValue.ToString).ToUpper And Trim(studentsubrow.Year_Joined__joined) = Trim(cboExamAttendaceClass.Text) Then
    '                Classlist.Items.Add(studentsubrow.StudentID)
    '            End If
    '        Next
    '    Catch ex As Exception

    '    End Try

    'End Sub







    'Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim a As Integer

    '    a = Classlist.Items.Count
    '    If ChkExamAtt.Checked Then
    '        For B1 = 0 To a - 1
    '            Classlist.SetItemChecked(B1, True)
    '        Next
    '        ChkExamAtt.Text = "UncheckAll"
    '    Else
    '        For B1 = 0 To a - 1
    '            Classlist.SetItemChecked(B1, False)
    '        Next
    '        ChkExamAtt.Text = "CheckAll"
    '    End If
    'End Sub

    Private Sub cboActPerClenrol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboActPerClIntk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub cboExamAttendaceClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim b As Integer
        '    Classlist.Items.Clear()
        '    Dim studentsubrow As dsReports.StudentSubjectsRow
        '    Dim a As Integer = StudentSubjectsBindingSource1.Count
        '    For B = 0 To a - 1
        '        studentsubrow = DsReports.StudentSubjects.Rows(B)
        '        If Trim(studentsubrow.SubjectID).ToUpper = Trim(cboExamAttendaceSub.SelectedValue.ToString).ToUpper And Trim(studentsubrow.Year_Joined__joined) = Trim(cboExamAttendaceClass.Text) Then
        '            Classlist.Items.Add(studentsubrow.StudentID)
        '        End If
        '    Next
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click

        '        Dim file_name2 As String = ""
        '        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
        '        OpenFileDialog1.FilterIndex = 2
        '        OpenFileDialog1.RestoreDirectory = True
        '        OpenFileDialog1.ShowDialog()
        '        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '            file_name2 = OpenFileDialog1.FileName
        '        End If
        '        ' Dim oReader As New StreamReader()
        '        Dim theLine As String = ""
        '        Dim arrSplt() As String
        '        Dim Name, Mobile, Amount As String
        '        Dim oReader As New System.IO.StreamReader(file_name2)
        '        Dim accrow As dsSchool.SMSAccRow
        '        Dim webrequest As Net.WebRequest
        '        Dim webresponse As Net.WebResponse
        '        Dim webresponsestring As String = ""

        '        Try
        '            accrow = DsSchool.SMSAcc.Rows.Item(0)
        '        Catch ex As Exception
        '            MsgBox("No SMS Account details found contact the systems Administrator")
        '            Exit Sub
        '        End Try

        '        Dim send As String
        '        Dim quantity As Integer = 0
        '        Dim strPassword, strUsername, strMessage As Object
        '        Dim strurl As String
        '        Dim strMobileNumber As String
        '        send = InputBox("Enter Sender Id", "Sender", "Myself")
        '        Dim d As Integer
        '        Dim senderid As String

        '        Try
        '            While oReader.Peek <> -1
        '                theLine = oReader.ReadLine()
        '                arrSplt = theLine.Split("|")
        '                Name = Trim(arrSplt(0))
        '                strMobileNumber = Trim(arrSplt(1))
        '                Amount = Trim(arrSplt(2))
        '                ' d = InStr(Mobile, "+")
        '                ' strMobileNumber = Mid(Mobile, d + 1)
        '                If strMobileNumber = "" Then
        '                    GoTo nonum3
        '                End If
        '                strUsername = accrow.UserName
        '                strPassword = accrow.Password
        '                senderid = send
        '                'strMobileNumber = number
        '                strMessage = "Dear " & Name & " your account balance is " & Amount & " " & RichTextBox.Text
        '                Dim type As Integer = 0
        '                Dim dlr As Integer = 1
        '                ' oHttp = CreateObject("Microsoft.XMLHTTP")
        '                'strUrl = "http://121.241.242.120:8080/bulksms/bulksms? username = " & strUsername & " & password =" & strPassword & "& type =" & type = 0 & dlr = " & dlr & " & destination = " & strMobileNumber & " & source = " & senderid & " & Message = " & strMessage"
        '                strurl = "http://121.241.242.114:8080/bulksms/bulksms?username=" & strUsername & "&password=" & strPassword & "&type=" & type & "&dlr=" & dlr & "&destination=" & strMobileNumber & "&source=" & senderid & "&message=" & strMessage & ""
        '                webrequest = Net.HttpWebRequest.Create(Trim(strurl))
        '                webrequest.Timeout = 25000
        '                Try
        '                    webresponse = webrequest.GetResponse
        '                    Dim reader As IO.StreamReader = New IO.StreamReader(webresponse.GetResponseStream)
        '                    webresponsestring = reader.ReadToEnd
        '                    webresponse.Close()
        '                Catch ex As Exception
        '                    Exit Sub
        '                End Try
        '                quantity += 1
        'nonum3:     End While
        '            MsgBox(quantity & " messages successfully sent")
        '        Catch
        '            MsgBox(quantity & " messages successfully sent")
        '        End Try
    End Sub




    Private Sub chkRegSubs_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If chkRegSubs.CheckedItems.Count > 0 Then
        '    btnEnterMarks.Enabled = True
        'Else
        '    btnEnterMarks.Enabled = False
        'End If
    End Sub

    'Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.FeesPaymentsBindingSource.EndEdit()
    '        Me.FeesPaymentsTableAdapter.Update(Me.dsschool.FeesPayments)
    '        MsgBox("Save Successful")
    '        gstrReceipt = ReceiptTextBox.Text
    '        frmReportPreview.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Sub ClassComboBox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub txtSubStudsSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSubStudsSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbSubStudSearch.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            Button3_Click_3(Me, Nothing)

        End If
    End Sub









    Private Sub TextBox4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubStudsSearch.TextChanged



    End Sub


    Private Sub StudEnrollmentSearch(lstbox As ListBox, searchtext As String, Optional blnmarkscreen As Boolean = False)

        lstbox.DataSource = Nothing
        lstbox.Visible = True

        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)


        Try
            cnn.Open()

            Dim filter As String = " where concat( studentname, studentsurname, s.studentID ) like '%" & searchtext & "%' and s.active = 1 "
            Dim sql As String
            If blnmarkscreen Then
                sql = "spStudentSearchMarks"
            Else
                sql = "spStudentSearch"
            End If
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
            param = New SqlParameter("@filter", filter)
            cmd.Parameters.Add(param)

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lstbox.DataSource = dsApps.Tables(0)
            lstbox.DisplayMember = "StudName"
            lstbox.ValueMember = "StudentID"



            lstbox.DataSource = dsApps.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub lbSubStudSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbSubStudSearch.DoubleClick
        Dim search As String
        Dim searchtext As String

        Try
            txtSubStudsSearch.Text = lbSubStudSearch.SelectedValue.ToString
            searchtext = lbSubStudSearch.GetItemText(lbSubStudSearch.SelectedItem)
            search = lbSubStudSearch.SelectedValue
            lbSubStudSearch.DataSource = Nothing
            lbSubStudSearch.Visible = False


            Dim arraysplit() As String
            arraysplit = Split(searchtext, "-")
            cboSubProg.SelectedValue = arraysplit(5).ToString
            cboSubLvl.Text = arraysplit(3).ToString
            cboSubSess.Text = arraysplit(4).ToString
            cboSubClass.Text = arraysplit(2).ToString
            '   Available_Subjects.Items.Clear()
            btnSubClassList_Click(Me, Nothing)


            searchStudsSpec(search, dgSubStuds, "SubjectsStudentID")


        Catch ex As Exception

        End Try




    End Sub





    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        LoadDatasets()
    End Sub


    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Close()
    End Sub










    Private Sub Button20_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        '    dgPeriod.Show()

    End Sub

    Private Sub txtStudNotif_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStudNotif.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbStudNotif.Visible = False
        End If
    End Sub

    Private Sub txtStudNotif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudNotif.TextChanged
        Dim serchtext As String = Trim(txtStudNotif.Text)
        lbStudNotif.Items.Clear()
        Dim drr As SqlDataReader
        lbStudNotif.Visible = True
        Dim sql As String = " Select studentid,studentname,studentsurname,program,year,semester,Session,Status,[Year Joined  joined] from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lbStudNotif.Items.Add(drr(0) & "-" & drr(1) & "-" & drr(2) & "-" & drr(3) & "-" & drr(4) & "-" & drr(5) & "-" & drr(6) & "-" & drr(7) & "-" & drr(8))
        End While
    End Sub

    Private Sub lbStudNotif_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbStudNotif.DoubleClick

        'Dim stud As String
        'Try
        '    txtStudNotif.Text = lbStudNotif.SelectedItem.ToString
        '    stud = CleanComboVal(txtStudNotif.Text)
        '    lbStudNotif.Items.Clear()
        '    lbStudNotif.Visible = False
        'Catch ex As Exception

        'End Try

        'Dim arraysplit() As String
        'arraysplit = Split(txtStudNotif.Text, "-")
        ''cboSmsProg.Text = arraysplit(3).ToString
        'cboSmdClass.Text = arraysplit(8).ToString
        'cboSmslevel.Text = arraysplit(4).ToString
        'cboSmsSem.Text = arraysplit(5).ToString
        '' cboSmsIntake.Text = arraysplit(7).ToString
        'cboSmsSess.Text = arraysplit(6).ToString
        'Try
        '    StudentPersonalDetailsTableAdapter1.FillByStud(dsStudentSearches.StudentPersonalDetails, stud)
        'Catch ex As Exception

        'End Try
        'searchStudsSpec(txtStudNotif.Text, dgClassList)
        'gblnsinglemsg = True


    End Sub

    Private Sub lbStudNotif_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbStudNotif.SelectedIndexChanged

    End Sub

    Private Sub RichTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox.TextChanged
        Dim a As String
        Dim b() As String
        a = (Len(RichTextBox.Text) / 160)


        b = Split(a, ".")
        If Len(RichTextBox.Text) Mod 160 = 0 And a >= 1 Then

            characters.Text = b(0) & " / " & Len(RichTextBox.Text)

        Else
            characters.Text = b(0) + 1 & " / " & Len(RichTextBox.Text)
        End If
    End Sub








    Private Sub Button4_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLink.Click
        BindingNavigator2.Items("Delete").Visible = True
        BindingNavigator1.Items("BindingNavigatorAddNewItem").Visible = True
        mblnaddingFess = False
        gblnsinglemark = False
        gblnsinglemsg = False
        LoadDatasets()
        lbAddingStudent.Visible = False
        btnStudProfile.Visible = False

        FeesloadingMode()
        '     lbpos.Text = StudentPersonalDetailsBindingSource.Position + 1 & "of " & StudentPersonalDetailsBindingSource.Count

    End Sub

    Private Sub Button4_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Select Case PersonalDetails.SelectedIndex
            Case 0
                SchoolInfoBindingNavigatorSaveItem_Click(Me, Nothing)
            Case 1
                saveSub_Click(Me, Nothing)
            Case 2

                ToolStripButton13_Click(Me, Nothing)
            Case 3
                ToolStripButton13_Click(Me, Nothing)
            Case 5


        End Select


    End Sub

    Private Sub lbdrpngstuds_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgClassList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgClassList.CellContentClick

    End Sub

    Private Sub dgClassList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgClassList.SelectionChanged

    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        txtSubStudsSearch.Clear()
    End Sub




    Private Sub lbStudFees_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbStudFees.DoubleClick
        Dim studid As String
        Dim studtext As String


        Try
            studtext = lbStudFees.GetItemText(lbStudFees.SelectedItem)
            studid = lbStudFees.SelectedValue
            lbStudFees.DataSource = Nothing
            lbStudFees.Visible = False
        Catch ex As Exception

        End Try

        Dim arraysplit() As String
        arraysplit = Split(studtext, "-")
        feesstud = New cEnrol(arraysplit(2).ToString, studid)
        lblfullname.Visible = True
        lblfullname.Text = arraysplit(1).ToString & "-"
        Try
            lbStudRef.Text = feesstud.EnrolRef
        Catch ex As Exception
            lbStudRef.Text = ""
        End Try

        txtFeesStudID.Text = studid
        '    FeesStudSearch()



    End Sub





    Private Sub ToolStripButton8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        FeesInsertMode()
        If mblnaddingFess And txtReceiptSearch.Text <> "" And cboReceiptSearch.Text = "Student" Then
            txtFeesStudID.Text = txtReceiptSearch.Text
            FeesStudSearch()
        End If
    End Sub

    Private Sub FeesInsertMode()

        mblnaddingFess = True
        mblnEdtFess = False
        dgFessDetails.Enabled = True
        gbFeesPay.Enabled = True
        PostDateDateTimePicker.Value = Now.Date
        mskpaydate.Text = Now.Date.ToShortDateString

        BindingNavigator2.Items("Insert").Visible = False
        BindingNavigator2.Items("Delete").Visible = False
        BindingNavigator2.Items("Save").Visible = True

        dgFessDetails.Columns("btnUpdate").Visible = False
        dgFessDetails.Columns("btnDelete").Visible = False
        btnUpdateAllLines.Visible = False
        btnCancelAllLines.Visible = False
    End Sub
    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Dim sql As String
        Dim trans As SqlTransaction = Nothing
        Dim curr As String
        Dim cnn As New SqlConnection(ConnectionString)

        receiptprnt = True
        stmntprnt = False
        enrolform = False
        studprnt = False
        clsprint = False

        Dim amount, recid, recprefix, receipt, reference, period, cart, lineref As String
        Dim det As Date

        Dim rows As Integer

        receipt = ""


        If Not ValidStud(txtFeesStudID.Text) Then
            MsgBox("Invalid Student")
            Exit Sub
        End If

        If mblnaddingFess = True Then
            Try


                cnn.Open()
                trans = cnn.BeginTransaction
                gblnreceipt = True


                recprefix = "Rec_"



                If Date.TryParse(mskpaydate.Text, det) Then
                Else
                    Throw New Exception("Invalid Receipt Date")

                End If


                sql = "spInsertFeesHeader"

                Dim cmd As New SqlCommand(sql, cnn, trans)
                cmd.CommandType = CommandType.StoredProcedure

                params = New List(Of SqlParameter)

                param = New SqlParameter("@stud", txtFeesStudID.Text)
                params.Add(param)

                param = New SqlParameter("@recdate", det)
                params.Add(param)

                param = New SqlParameter("@recnumber", receipt)
                params.Add(param)

                param = New SqlParameter("@user", goUser.userName)
                params.Add(param)


                param = New SqlParameter("@TransType", "R")
                params.Add(param)


                param = New SqlParameter("@cashtype", cboCashType.Text)
                params.Add(param)


                param = New SqlParameter("@enrolref", feesstud.EnrolRef)
                params.Add(param)



                For Each par As SqlParameter In params
                    cmd.Parameters.Add(par)
                Next

                param = New SqlParameter()
                param.ParameterName = "@SavedReceipt"
                param.DbType = DbType.String
                param.Size = 50
                param.Direction = ParameterDirection.Output

                cmd.Parameters.Add(param)

                cmd.ExecuteNonQuery()

                receipt = cmd.Parameters("@SavedReceipt").Value




                rows = dgFessDetails.Rows.Count - 1


                For A1 = 0 To rows - 1
                    Dim dblAmount As Decimal
                    Dim intPeriod As Integer

                    amount = dgFessDetails.Rows(A1).Cells("Amnt").Value
                    Try
                        dblAmount = CDec(amount)
                    Catch ex As Exception
                        Throw New Exception("Invalid amount on line " & A1 + 1)
                    End Try




                    Try
                        reference = dgFessDetails.Rows(A1).Cells("Ref").Value
                    Catch ex As Exception
                        reference = "ref"
                    End Try


                    period = dgFessDetails.Rows(A1).Cells("Perd").Value
                    Try
                        intPeriod = CInt(period)
                    Catch ex As Exception
                        Throw New Exception("Invalid period on line " & A1 + 1)
                    End Try





                    cart = dgFessDetails.Rows(A1).Cells("Cart").Value
                    If cart = "" Then
                        Throw New Exception("Invalid cartegory on line " & A1 + 1)
                    End If




                    curr = dgFessDetails.Rows(A1).Cells("currency").Value

                    If curr = "" Then
                        Throw New Exception("Invalid Currency on line " & A1 + 1)
                    End If

                    sql = "spInsertFeesDetails"

                    cmd = New SqlCommand(sql, cnn, trans)
                    cmd.CommandType = CommandType.StoredProcedure


                    params = New List(Of SqlParameter)

                    param = New SqlParameter("@recnumber", receipt)
                    params.Add(param)

                    param = New SqlParameter("@Amount", amount)
                    params.Add(param)

                    param = New SqlParameter("@currency", curr)
                    params.Add(param)

                    param = New SqlParameter("@cart", cart)
                    params.Add(param)

                    param = New SqlParameter("@period", period)
                    params.Add(param)

                    param = New SqlParameter("@ref", reference)
                    params.Add(param)

                    param = New SqlParameter("@line", A1 + 1)
                    params.Add(param)

                    param = New SqlParameter("@lineref", Guid.NewGuid)
                    params.Add(param)
                    param = New SqlParameter("@user", gouser.userName)
                    params.Add(param)

                    param = New SqlParameter("@TransType", "R")
                    params.Add(param)


                    param = New SqlParameter("@comment", "")
                    params.Add(param)

                    param = New SqlParameter("@recdate", det)
                    params.Add(param)

                    For Each par As SqlParameter In params
                        cmd.Parameters.Add(par)
                    Next

                    cmd.ExecuteNonQuery()



                Next

                trans.Commit()


                MsgBox("Receipt " & receipt & " successfully saved ")
                ReceiptTextBox.Text = receipt

                FeesloadingMode()
                RefreshFeesStatement()

                Dim rec$ = MsgBox("Do you want to Print Receipt", MsgBoxStyle.YesNo)
                If rec <> "6" Then
                    receiptprnt = False
                Else
                    Try
                        Dim rptviwer As New frmReportPreview

                        With rptviwer
                            .recprint = True
                            .RecNumber = ReceiptTextBox.Text
                            .recCopy = True

                            If Trim(Mid(ReceiptTextBox.Text, 1, 4)) <> "inv_" Then
                                .isReceipt = True


                                ' frmReportPreview.Show()

                            Else
                                .isReceipt = False

                            End If
                            .ShowDialog()
                        End With
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                End If



            Catch ex As Exception
                trans.Rollback()
                MsgBox("Error in creating receipt " & ex.Message)
                FeesInsertMode()
            Finally
                cnn.Close()

            End Try










        ElseIf mblnEdtFess Then

            Try
                cnn = New SqlConnection(ConnectionString)
                cnn.Open()
                trans = cnn.BeginTransaction


                receipt = ReceiptTextBox.Text
                Date.TryParse(mskpaydate.Text, det)


                sql = "spInsertFeesHeader"

                cmd = New SqlCommand(sql, cnn, trans)
                cmd.CommandType = CommandType.StoredProcedure

                params = New List(Of SqlParameter)

                param = New SqlParameter("@stud", txtFeesStudID.Text)
                params.Add(param)

                param = New SqlParameter("@recdate", det)
                params.Add(param)

                param = New SqlParameter("@recnumber", receipt)
                params.Add(param)

                param = New SqlParameter("@user", goUser.userName)
                params.Add(param)


                param = New SqlParameter("@TransType", IIf(Mid(Trim(ReceiptTextBox.Text), 1, 3) = "Rec", "R", "I"))
                params.Add(param)


                param = New SqlParameter("@cashtype", cboCashType.Text)
                params.Add(param)


                param = New SqlParameter("@enrolref", lbStudRef.Text)
                params.Add(param)

                For Each par In params
                    cmd.Parameters.Add(par)
                Next

                cmd.ExecuteNonQuery()








                For A1 = 0 To dgFessDetails.Rows.Count - 2


                    Dim dblAmnt As Decimal
                    Dim intPeriod As Integer

                    amount = dgFessDetails.Rows(A1).Cells("Amnt").Value

                    Try
                        dblAmnt = CDec(amount)
                    Catch ex As Exception
                        Throw New Exception("Invalid amount on line " & A1 + 1)
                    End Try





                    Try
                        reference = dgFessDetails.Rows(A1).Cells("Ref").Value
                    Catch ex As Exception
                        reference = "ref"
                    End Try


                    period = dgFessDetails.Rows(A1).Cells("Perd").Value
                    Try

                        intPeriod = CInt(period)
                    Catch ex As Exception
                        Throw New Exception("Invalid Period on line " & A1 + 1)
                        ' Exit Sub
                    End Try


                    cart = dgFessDetails.Rows(A1).Cells("Cart").Value
                    If cart = "" Then
                        Throw New Exception("Invalid Cartegory on line " & A1 + 1)
                    End If



                    curr = dgFessDetails.Rows(A1).Cells("currency").Value
                    If curr = "" Then
                        Throw New Exception("Invalid Currency on line " & A1 + 1)
                    End If

                    lineref = dgFessDetails.Rows(A1).Cells("lineref").Value.ToString

                    If lineref <> "" Then

                        If (Mid(Trim(ReceiptTextBox.Text), 1, 3) = "Rec") Then
                            amount = -1 * dgFessDetails.Rows(A1).Cells("amount").Value
                        End If
                    Else
                        If (Mid(Trim(ReceiptTextBox.Text), 1, 3) = "Rec") Then
                            amount = dgFessDetails.Rows(A1).Cells("amount").Value
                        End If
                    End If


                    sql = "spInsertFeesDetails"

                    cmd = New SqlCommand(sql, cnn, trans)
                    cmd.CommandType = CommandType.StoredProcedure

                    params = New List(Of SqlParameter)

                    param = New SqlParameter("@recnumber", receipt)
                    params.Add(param)

                    param = New SqlParameter("@Amount", amount)
                    params.Add(param)

                    param = New SqlParameter("@currency", curr)
                    params.Add(param)

                    param = New SqlParameter("@cart", cart)
                    params.Add(param)

                    param = New SqlParameter("@period", period)
                    params.Add(param)

                    param = New SqlParameter("@ref", reference)
                    params.Add(param)

                    param = New SqlParameter("@line", A1 + 1)
                    params.Add(param)


                    param = New SqlParameter("@comment", "")
                    params.Add(param)

                    param = New SqlParameter("@lineref", IIf(lineref = "", Guid.NewGuid, lineref))
                    params.Add(param)
                    param = New SqlParameter("@user", goUser.userName)
                    params.Add(param)
                    param = New SqlParameter("@TransType", IIf(Mid(Trim(ReceiptTextBox.Text), 1, 3) = "Rec", "R", "I"))
                    params.Add(param)

                    param = New SqlParameter("@recdate", det)
                    params.Add(param)

                    For Each par In params
                        cmd.Parameters.Add(par)
                    Next

                    cmd.ExecuteNonQuery()


                Next

                trans.Commit()
                FeesloadingMode()
                Feespayments_detailsTableAdapter.FillByReceipt(DsSchool.feespayments_details, ReceiptTextBox.Text, cboFeesCartegory.Text)
                RefreshFeesStatement()

                Dim rec$ = MsgBox("Receipt " & ReceiptTextBox.Text & " successfully edited, do you want to print receipt?", MsgBoxStyle.YesNo)

                If rec <> "6" Then
                    receiptprnt = False
                Else
                    Try
                        Dim rptviwer As New frmReportPreview

                        With rptviwer
                            .recprint = True
                            .RecNumber = ReceiptTextBox.Text
                            .recCopy = True

                            If Trim(Mid(ReceiptTextBox.Text, 1, 4)) <> "inv_" Then
                                .isReceipt = True


                                ' frmReportPreview.Show()

                            Else
                                .isReceipt = False

                            End If
                            .ShowDialog()
                        End With
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If



            Catch ex As Exception
                MsgBox(ex.Message)
                trans.Rollback()
                FeesEditMode()
                cnn.Close()
            End Try



        ElseIf mblnDltFess Then

            If ReasonForReversalComboBox.Text = "" Then

                mblnDltFess = True
                MsgBox("Please select reason for payment deletion and press delete/cancel again")
                gbFeesPay.Enabled = True

            Else
                Try
                    Dim cmd As New SqlCommand
                    cnn = New SqlConnection(ConnectionString)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "spDeleteFeesReceipt"
                    cmd.Connection = cnn
                    param = New SqlParameter("@recnumber", ReceiptTextBox.Text)
                    cmd.Parameters.Add(param)
                    param = New SqlParameter("@user", gouser.userName)
                    cmd.Parameters.Add(param)
                    param = New SqlParameter("@reason", ReasonForReversalComboBox.Text)
                    cmd.Parameters.Add(param)
                    cnn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Payment successfully cancelled")
                    FeesloadingMode()
                    RefreshFeesStatement()
                    FeesPayments_HeaderTableAdapter.FillByReceipt(DsSchool.FeesPayments_Header, ReceiptTextBox.Text, cboFeesCartegory.Text, chkTransScreenShowInvoices.Checked, chkTransScreenShowReceipts.Checked)


                Catch ex As Exception
                    MsgBox("Error in deleting payment " & ex.Message)
                    FeesloadingMode()
                Finally
                    cnn.Close()
                End Try
            End If




        End If
    End Sub
    Private Sub RefreshFeesStatement()
        Try

            Me.StudentFeesTranscationsTableAdapter.Fill(Me.DsSchool.StudentFeesTranscations, cboFeesCartegory.Text, txtFeesStudID.Text, gouser.userName, "", -1, -1, cboBBFCutOffPeriod.SelectedValue.ToString, chkTransScreenShowInvoices.Checked, chkTransScreenShowReceipts.Checked)
            rvOnScreenStat.Dock = DockStyle.Fill
            rvOnScreenStat.Visible = True
            rvOnScreenStat.RefreshReport()


        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnPerfomBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerfomBilling.Click
        Dim studscount As Integer = dgBilling.Rows.Count
        Dim slctdcount As Integer = dgBilling.SelectedRows.Count

        Dim sql, recprefix, recid, amount As String
        Dim drr As SqlDataReader = Nothing
        Dim period As String = ""
        Dim bilcart As String = ""

        Dim ref As String
        Dim invoice As String = ""

        Dim cmd As New SqlCommand
        Dim trans As SqlTransaction

        cnn = New SqlConnection(ConnectionString)

        Me.Cursor = Cursors.WaitCursor

        If cboBillType.Text = "Normal" Then
            If slctdcount = 0 Then
                MsgBox("No Student Selected for Billing")
                Exit Sub
            End If
            recprefix = "inv_"






            If chkBilPeriods.CheckedItems.Count = 0 Then
                'If cboBillPeriod.Text = "" Then
                MsgBox("Select at leat one  billing Period")
                Exit Sub
            End If

            If dgPayType.SelectedRows.Count = 0 Then
                'If cboBillPeriod.Text = "" Then
                MsgBox("Select at least one  billing Cartegory")
                Exit Sub
            End If



            cnn.Open()
            trans = cnn.BeginTransaction()
            Try

                '    ref = period & "-" & bilcart & "-" & amount & "-" & cboBillingClass.Text & "-" & cboBillingLevel.Text & "" & cboBillingSess.Text & "-" & Now.Date.ToShortDateString & "-" & Now.ToShortTimeString


                For A1 = 0 To studscount - 1



                    If dgBilling.Rows(A1).Selected = True Then



                        For Each cv In chkBilPeriods.CheckedItems()

                            period = CleanComboVal(cv)
                            ref = period & "-" & cboBillingClass.Text & "-" & cboBillingLevel.Text & "" & cboBillingSess.Text & "-" & Now.Date.ToShortDateString & "-" & Now.ToShortTimeString

                            For item2 = 0 To dgPayType.Rows.Count - 1
                                cmd = New SqlCommand
                                cmd.CommandText = "spInsertFeesHeader"
                                cmd.Connection = cnn

                                cmd.Transaction = trans
                                cmd.CommandType = CommandType.StoredProcedure

                                If dgPayType.Rows(item2).Selected = True Then
                                    bilcart = dgPayType.Rows(item2).Cells("Payment").Value
                                    amount = dgPayType.Rows(item2).Cells("BillingAmount").Value.ToString

                                    If amount = "" Then
                                        Throw New Exception("Invalid Amount for " & bilcart)

                                    End If







                                    param = New SqlParameter("@stud", dgBilling.Rows(A1).Cells("BillingStudentID").Value)
                                    cmd.Parameters.Add(param)

                                    param = New SqlParameter("@recdate", Now.Date())
                                    cmd.Parameters.Add(param)

                                    param = New SqlParameter("@recnumber", "")
                                    cmd.Parameters.Add(param)

                                    param = New SqlParameter("@user", gouser.userName)
                                    cmd.Parameters.Add(param)


                                    param = New SqlParameter("@TransType", "I")
                                    cmd.Parameters.Add(param)


                                    param = New SqlParameter("@cashtype", "")
                                    cmd.Parameters.Add(param)


                                    param = New SqlParameter("@enrolref", dgBilling.Rows(A1).Cells("BillingEnrolRef").Value.ToString)
                                    cmd.Parameters.Add(param)

                                    param = New SqlParameter()
                                    param.ParameterName = "@SavedReceipt"
                                    param.DbType = DbType.String
                                    param.Size = 50
                                    param.Direction = ParameterDirection.Output
                                    cmd.Parameters.Add(param)


                                    cmd.ExecuteNonQuery()
                                    invoice = cmd.Parameters("@SavedReceipt").Value


                                    params = New List(Of SqlParameter)
                                    cmd = New SqlCommand
                                    cmd.CommandText = "spInsertFeesDetails"
                                    cmd.Connection = cnn
                                    cmd.CommandType = CommandType.StoredProcedure
                                    cmd.Transaction = trans





                                    params = New List(Of SqlParameter)

                                    param = New SqlParameter("@recnumber", invoice)
                                    params.Add(param)

                                    param = New SqlParameter("@Amount", amount)
                                    params.Add(param)

                                    param = New SqlParameter("@currency", "")
                                    params.Add(param)

                                    param = New SqlParameter("@cart", bilcart)
                                    params.Add(param)

                                    param = New SqlParameter("@period", period)
                                    params.Add(param)

                                    param = New SqlParameter("@ref", ref)
                                    params.Add(param)

                                    param = New SqlParameter("@line", 1)
                                    params.Add(param)

                                    param = New SqlParameter("@lineref", Guid.NewGuid)
                                    params.Add(param)
                                    param = New SqlParameter("@user", gouser.userName)
                                    params.Add(param)

                                    param = New SqlParameter("@TransType", "I")
                                    params.Add(param)


                                    param = New SqlParameter("@comment", "")
                                    params.Add(param)

                                    param = New SqlParameter("@recdate", Now.Date)
                                    params.Add(param)

                                    For Each par As SqlParameter In params
                                        cmd.Parameters.Add(par)
                                    Next

                                    cmd.ExecuteNonQuery()






                                End If





                            Next



                        Next




                    End If

                Next

                trans.Commit()
                MsgBox("Billing Successful")

            Catch ex As Exception

                MsgBox(ex.Message)
                trans.Rollback()
            Finally
                cnn.Close()

            End Try

        ElseIf cboBillType.Text = "Reversal" Then

            For Each cv In chkBilPeriods.CheckedItems
                sql = "update feespayments_header set [status] = 0 where receipt in (select receipt from feespayments_details where reference = '" & cv & "')"
                ExecuteNonQuery(sql)
                If era = False Then
                    MsgBox("Reference " & cv & " ,successfully reversed")
                Else
                    MsgBox("Error in reversing reference " & cv & "")
                End If
            Next
        End If
        Me.Cursor = Cursors.Default
    End Sub
















    Private Sub ReceiptTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptTextBox.TextChanged

        Feespayments_detailsTableAdapter.FillByReceipt(DsSchool.feespayments_details, ReceiptTextBox.Text, cboFeesCartegory.Text)


    End Sub



    Private Sub dgFessDetails_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgFessDetails.DataError
        ' MsgBox("trest")
    End Sub

    'Private Sub cboExamAttendaceSub_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Classlist.Items.Clear()
    '        Dim sql As String = ""
    '        Dim drr As SqlDataReader

    '        sql = "Select distinct studentsubjects.studentid ,studentname,studentsurname ,studentpersonaldetails.gender from studentsubjects inner join enrollment on studentsubjects.studentid = enrollment.studentid " & _
    '       " inner join studentpersonaldetails on studentpersonaldetails.studentid = studentsubjects.studentid    " & _
    '        " where studentsubjects.subjectid = '" & cboExamAttendaceSub.SelectedValue.ToString & "' and  " & _
    '       " enrollment.[Date joined] = '" & Trim(cboExamAttendaceClass.Text) & "' and  studentsubjects.Year = " & cmbregLvl.Text & "  And studentsubjects.Semester =  " & cmbregSem.Text & _
    '       "  and enrollment.session = '" & cmbregSess.Text & "' and enrollment.status = 'Available' order by studentpersonaldetails.gender,studentsurname asc"

    '        drr = ExecuteReader(sql, , True)

    '        While drr.Read

    '            Classlist.Items.Add(drr(0) & "-" & drr(1) & " " & drr(2))

    '        End While
    '    Catch ex As Exception

    '    End Try



    '    Dim a As Integer

    '    a = Classlist.Items.Count

    '    For item = 0 To a - 1
    '        Dim sql As String = ""
    '        Dim status As String
    '        sql = "select Status  from studentregister where studentid = '" & CleanComboVal(Classlist.Items(item).ToString) & "' " & _
    '        " and date = '" & mskstudRegDate.Text & "' and Subject = '" & cboExamAttendaceSub.SelectedValue.ToString & "'  "
    '        status = ExecuteScalar(sql, , True)

    '        If Trim(status) = "Present" Then
    '            Classlist.SetItemChecked(item, True)
    '        Else
    '            Classlist.SetItemChecked(item, False)
    '        End If
    '    Next
    'End Sub

    'Private Sub cmbRegIntk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Classlist.Items.Clear()
    '        Dim sql As String = ""
    '        Dim drr As SqlDataReader

    '        sql = "Select distinct studentsubjects.studentid ,studentname,studentsurname  from studentsubjects inner join enrollment on studentsubjects.studentid = enrollment.studentid " & _
    '      " inner join studentpersonaldetails on studentpersonaldetails.studentid = studentsubjects.studentid    " & _
    '       " where studentsubjects.subjectid = '" & cboExamAttendaceSub.SelectedValue.ToString & "' and  " & _
    '      " enrollment.[Date joined] = '" & Trim(cboExamAttendaceClass.Text) & "' and  studentsubjects.Year = " & cmbregLvl.Text & "  And studentsubjects.Semester =  " & cmbregSem.Text & _
    '      "  and enrollment.session = '" & cmbregSess.Text & "' and enrollment.intake = '" & cmbRegIntk.Text & "'"
    '        drr = ExecuteReader(sql, , True)

    '        While drr.Read

    '            Classlist.Items.Add(drr(0) & "-" & drr(1) & " " & drr(2))

    '        End While
    '    Catch ex As Exception

    '    End Try



    '    Dim a As Integer

    '    a = Classlist.Items.Count

    '    For item = 0 To a - 1
    '        Dim sql As String = ""
    '        Dim status As String
    '        sql = "select Status  from studentregister where studentid = '" & CleanComboVal(Classlist.Items(item).ToString) & "' " & _
    '        " and date = '" & mskstudRegDate.Text & "' and Subject = '" & cboExamAttendaceSub.SelectedValue.ToString & "'  "
    '        status = ExecuteScalar(sql, , True)

    '        If Trim(status) = "Present" Then
    '            Classlist.SetItemChecked(item, True)
    '        Else
    '            Classlist.SetItemChecked(item, False)
    '        End If
    '    Next
    ' End Sub

    'Private Sub cboExamAttendaceClass_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If rbSubjectRegister.Checked Then

    '        Try
    '            Classlist.Items.Clear()
    '            Dim sql As String = ""
    '            Dim drr As SqlDataReader

    '            sql = "Select distinct  studentsubjects.studentid ,studentsurname,studentname ,studentpersonaldetails.gender  from studentsubjects inner join enrollment on studentsubjects.studentid = enrollment.studentid " & _
    '          " inner join studentpersonaldetails on studentpersonaldetails.studentid = studentsubjects.studentid    " & _
    '           " where studentsubjects.subjectid = '" & cboExamAttendaceSub.SelectedValue.ToString & "' and  " & _
    '          " enrollment.[Date joined] = '" & Trim(cboExamAttendaceClass.Text) & "' and  studentsubjects.Year = " & cmbregLvl.Text & "  And studentsubjects.Semester =  " & cmbregSem.Text & _
    '          "  and enrollment.session = '" & cmbregSess.Text & "' and enrollment.status = 'Available' order by studentpersonaldetails.gender, studentsurname asc "
    '            drr = ExecuteReader(sql, , True)

    '            While drr.Read

    '                Classlist.Items.Add(drr(0) & "-" & drr(1) & " " & drr(2))

    '            End While
    '        Catch ex As Exception

    '        End Try



    '        Dim a As Integer

    '        a = Classlist.Items.Count

    '        For item = 0 To a - 1
    '            Dim sql As String = ""
    '            Dim status As String
    '            sql = "select [Status]  from studentregister where studentid = '" & CleanComboVal(Classlist.Items(item).ToString) & "' " & _
    '            " and date = '" & mskstudRegDate.Text & "' and Subject = '" & cboExamAttendaceSub.SelectedValue.ToString & "' and [type] = 'Subject' "
    '            status = ExecuteScalar(sql, , True)

    '            If Trim(status) = "Present" Then
    '                Classlist.SetItemChecked(item, True)
    '            Else
    '                Classlist.SetItemChecked(item, False)
    '            End If
    '        Next
    '    ElseIf rbClassRegister.Checked Then
    '        Try
    '            Classlist.Items.Clear()
    '            Dim sql As String = ""
    '            Dim drr As SqlDataReader

    '            sql = "Select distinct studentpersonaldetails.studentid ,studentsurname,studentname,studentpersonaldetails.gender  from studentpersonaldetails inner join enrollment on studentpersonaldetails.studentid = enrollment.studentid " & _
    '      " where  enrollment.[Date joined] = '" & Trim(cboExamAttendaceClass.Text) & "' and  enrollment.Year = " & cmbregLvl.Text & "  And enrollment.Semester =  " & cmbregSem.Text & _
    '          "  and enrollment.session = '" & cmbregSess.Text & "' and enrollment.status = 'Available' order by studentpersonaldetails.gender,studentsurname asc "
    '            drr = ExecuteReader(sql, , True)

    '            While drr.Read

    '                Classlist.Items.Add(drr(0) & "-" & drr(1) & " " & drr(2))

    '            End While
    '        Catch ex As Exception

    '        End Try



    '        Dim a As Integer

    '        a = Classlist.Items.Count

    '        For item = 0 To a - 1
    '            Dim sql As String = ""
    '            Dim status As String
    '            sql = "select [Status]  from studentregister where studentid = '" & CleanComboVal(Classlist.Items(item).ToString) & "' " & _
    '            " and date = '" & mskstudRegDate.Text & "' and [type]  = 'Class'  "
    '            status = ExecuteScalar(sql, , True)

    '            If Trim(status) = "Present" Then
    '                Classlist.SetItemChecked(item, True)
    '            Else
    '                Classlist.SetItemChecked(item, False)
    '            End If
    '        Next
    '    End If
    'End Sub

    'Private Sub cmbregLvl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If rbSubjectRegister.Checked Then

    '        Try
    '            Classlist.Items.Clear()
    '            Dim sql As String = ""
    '            Dim drr As SqlDataReader

    '            sql = "Select distinct  studentsubjects.studentid ,studentsurname,studentname ,studentpersonaldetails.gender  from studentsubjects inner join enrollment on studentsubjects.studentid = enrollment.studentid " & _
    '          " inner join studentpersonaldetails on studentpersonaldetails.studentid = studentsubjects.studentid    " & _
    '           " where studentsubjects.subjectid = '" & cboExamAttendaceSub.SelectedValue.ToString & "' and  " & _
    '          " enrollment.[Date joined] = '" & Trim(cboExamAttendaceClass.Text) & "' and  studentsubjects.Year = " & cmbregLvl.Text & "  And studentsubjects.Semester =  " & cmbregSem.Text & _
    '          "  and enrollment.session = '" & cmbregSess.Text & "' and enrollment.status = 'Available' order by studentpersonaldetails.gender, studentsurname asc "
    '            drr = ExecuteReader(sql, , True)

    '            While drr.Read

    '                Classlist.Items.Add(drr(0) & "-" & drr(1) & " " & drr(2))

    '            End While
    '        Catch ex As Exception

    '        End Try



    '        Dim a As Integer

    '        a = Classlist.Items.Count

    '        For item = 0 To a - 1
    '            Dim sql As String = ""
    '            Dim status As String
    '            sql = "select [Status]  from studentregister where studentid = '" & CleanComboVal(Classlist.Items(item).ToString) & "' " & _
    '            " and date = '" & mskstudRegDate.Text & "' and Subject = '" & cboExamAttendaceSub.SelectedValue.ToString & "' and [type] = 'Subject' "
    '            status = ExecuteScalar(sql, , True)

    '            If Trim(status) = "Present" Then
    '                Classlist.SetItemChecked(item, True)
    '            Else
    '                Classlist.SetItemChecked(item, False)
    '            End If
    '        Next
    '    ElseIf rbClassRegister.Checked Then
    '        Try
    '            Classlist.Items.Clear()
    '            Dim sql As String = ""
    '            Dim drr As SqlDataReader

    '            sql = "Select distinct studentpersonaldetails.studentid ,studentsurname,studentname,studentpersonaldetails.gender  from studentpersonaldetails inner join enrollment on studentpersonaldetails.studentid = enrollment.studentid " & _
    '      " where  enrollment.[Date joined] = '" & Trim(cboExamAttendaceClass.Text) & "' and  enrollment.Year = " & cmbregLvl.Text & "  And enrollment.Semester =  " & cmbregSem.Text & _
    '          "  and enrollment.session = '" & cmbregSess.Text & "' and enrollment.status = 'Available' order by studentpersonaldetails.gender,studentsurname asc "
    '            drr = ExecuteReader(sql, , True)

    '            While drr.Read

    '                Classlist.Items.Add(drr(0) & "-" & drr(1) & " " & drr(2))

    '            End While
    '        Catch ex As Exception

    '        End Try



    '        Dim a As Integer

    '        a = Classlist.Items.Count

    '        For item = 0 To a - 1
    '            Dim sql As String = ""
    '            Dim status As String
    '            sql = "select [Status]  from studentregister where studentid = '" & CleanComboVal(Classlist.Items(item).ToString) & "' " & _
    '            " and date = '" & mskstudRegDate.Text & "' and [type]  = 'Class'  "
    '            status = ExecuteScalar(sql, , True)

    '            If Trim(status) = "Present" Then
    '                Classlist.SetItemChecked(item, True)
    '            Else
    '                Classlist.SetItemChecked(item, False)
    '            End If
    '        Next
    '    End If
    'End Sub

    'Private Sub cmbregSem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If rbSubjectRegister.Checked Then

    '        Try
    '            Classlist.Items.Clear()
    '            Dim sql As String = ""
    '            Dim drr As SqlDataReader

    '            sql = "Select distinct  studentsubjects.studentid ,studentsurname,studentname ,studentpersonaldetails.gender  from studentsubjects inner join enrollment on studentsubjects.studentid = enrollment.studentid " & _
    '          " inner join studentpersonaldetails on studentpersonaldetails.studentid = studentsubjects.studentid    " & _
    '           " where studentsubjects.subjectid = '" & cboExamAttendaceSub.SelectedValue.ToString & "' and  " & _
    '          " enrollment.[Date joined] = '" & Trim(cboExamAttendaceClass.Text) & "' and  studentsubjects.Year = " & cmbregLvl.Text & "  And studentsubjects.Semester =  " & cmbregSem.Text & _
    '          "  and enrollment.session = '" & cmbregSess.Text & "' and enrollment.status = 'Available' order by studentpersonaldetails.gender, studentsurname asc "
    '            drr = ExecuteReader(sql, , True)

    '            While drr.Read

    '                Classlist.Items.Add(drr(0) & "-" & drr(1) & " " & drr(2))

    '            End While
    '        Catch ex As Exception

    '        End Try



    '        Dim a As Integer

    '        a = Classlist.Items.Count

    '        For item = 0 To a - 1
    '            Dim sql As String = ""
    '            Dim status As String
    '            sql = "select [Status]  from studentregister where studentid = '" & CleanComboVal(Classlist.Items(item).ToString) & "' " & _
    '            " and date = '" & mskstudRegDate.Text & "' and Subject = '" & cboExamAttendaceSub.SelectedValue.ToString & "' and [type] = 'Subject' "
    '            status = ExecuteScalar(sql, , True)

    '            If Trim(status) = "Present" Then
    '                Classlist.SetItemChecked(item, True)
    '            Else
    '                Classlist.SetItemChecked(item, False)
    '            End If
    '        Next
    '    ElseIf rbClassRegister.Checked Then
    '        Try
    '            Classlist.Items.Clear()
    '            Dim sql As String = ""
    '            Dim drr As SqlDataReader

    '            sql = "Select distinct studentpersonaldetails.studentid ,studentsurname,studentname,studentpersonaldetails.gender  from studentpersonaldetails inner join enrollment on studentpersonaldetails.studentid = enrollment.studentid " & _
    '      " where  enrollment.[Date joined] = '" & Trim(cboExamAttendaceClass.Text) & "' and  enrollment.Year = " & cmbregLvl.Text & "  And enrollment.Semester =  " & cmbregSem.Text & _
    '          "  and enrollment.session = '" & cmbregSess.Text & "' and enrollment.status = 'Available' order by studentpersonaldetails.gender,studentsurname asc "
    '            drr = ExecuteReader(sql, , True)

    '            While drr.Read

    '                Classlist.Items.Add(drr(0) & "-" & drr(1) & " " & drr(2))

    '            End While
    '        Catch ex As Exception

    '        End Try



    '        Dim a As Integer

    '        a = Classlist.Items.Count

    '        For item = 0 To a - 1
    '            Dim sql As String = ""
    '            Dim status As String
    '            sql = "select [Status]  from studentregister where studentid = '" & CleanComboVal(Classlist.Items(item).ToString) & "' " & _
    '            " and date = '" & mskstudRegDate.Text & "' and [type]  = 'Class'  "
    '            status = ExecuteScalar(sql, , True)

    '            If Trim(status) = "Present" Then
    '                Classlist.SetItemChecked(item, True)
    '            Else
    '                Classlist.SetItemChecked(item, False)
    '            End If
    '        Next
    '    End If
    'End Sub

    'Private Sub cmbregSess_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If rbSubjectRegister.Checked Then

    '        Try
    '            Classlist.Items.Clear()
    '            Dim sql As String = ""
    '            Dim drr As SqlDataReader

    '            sql = "Select distinct  studentsubjects.studentid ,studentsurname,studentname ,studentpersonaldetails.gender  from studentsubjects inner join enrollment on studentsubjects.studentid = enrollment.studentid " & _
    '          " inner join studentpersonaldetails on studentpersonaldetails.studentid = studentsubjects.studentid    " & _
    '           " where studentsubjects.subjectid = '" & cboExamAttendaceSub.SelectedValue.ToString & "' and  " & _
    '          " enrollment.[Date joined] = '" & Trim(cboExamAttendaceClass.Text) & "' and  studentsubjects.Year = " & cmbregLvl.Text & "  And studentsubjects.Semester =  " & cmbregSem.Text & _
    '          "  and enrollment.session = '" & cmbregSess.Text & "' and enrollment.status = 'Available' order by studentpersonaldetails.gender, studentsurname asc "
    '            drr = ExecuteReader(sql, , True)

    '            While drr.Read

    '                Classlist.Items.Add(drr(0) & "-" & drr(1) & " " & drr(2))

    '            End While
    '        Catch ex As Exception

    '        End Try



    '        Dim a As Integer

    '        a = Classlist.Items.Count

    '        For item = 0 To a - 1
    '            Dim sql As String = ""
    '            Dim status As String
    '            sql = "select [Status]  from studentregister where studentid = '" & CleanComboVal(Classlist.Items(item).ToString) & "' " & _
    '            " and date = '" & mskstudRegDate.Text & "' and Subject = '" & cboExamAttendaceSub.SelectedValue.ToString & "' and [type] = 'Subject' "
    '            status = ExecuteScalar(sql, , True)

    '            If Trim(status) = "Present" Then
    '                Classlist.SetItemChecked(item, True)
    '            Else
    '                Classlist.SetItemChecked(item, False)
    '            End If
    '        Next
    '    ElseIf rbClassRegister.Checked Then
    '        Try
    '            Classlist.Items.Clear()
    '            Dim sql As String = ""
    '            Dim drr As SqlDataReader

    '            sql = "Select distinct studentpersonaldetails.studentid ,studentsurname,studentname,studentpersonaldetails.gender  from studentpersonaldetails inner join enrollment on studentpersonaldetails.studentid = enrollment.studentid " & _
    '      " where  enrollment.[Date joined] = '" & Trim(cboExamAttendaceClass.Text) & "' and  enrollment.Year = " & cmbregLvl.Text & "  And enrollment.Semester =  " & cmbregSem.Text & _
    '          "  and enrollment.session = '" & cmbregSess.Text & "' and enrollment.status = 'Available' order by studentpersonaldetails.gender,studentsurname asc "
    '            drr = ExecuteReader(sql, , True)

    '            While drr.Read

    '                Classlist.Items.Add(drr(0) & "-" & drr(1) & " " & drr(2))

    '            End While
    '        Catch ex As Exception

    '        End Try



    '        Dim a As Integer

    '        a = Classlist.Items.Count

    '        For item = 0 To a - 1
    '            Dim sql As String = ""
    '            Dim status As String
    '            sql = "select [Status]  from studentregister where studentid = '" & CleanComboVal(Classlist.Items(item).ToString) & "' " & _
    '            " and date = '" & mskstudRegDate.Text & "' and [type]  = 'Class'  "
    '            status = ExecuteScalar(sql, , True)

    '            If Trim(status) = "Present" Then
    '                Classlist.SetItemChecked(item, True)
    '            Else
    '                Classlist.SetItemChecked(item, False)
    '            End If
    '        Next
    '    End If
    'End Sub

    Private Sub txtReceiptSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReceiptSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbSeacrhFees.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            cnn = New SqlConnection(ConnectionString)
            If mblnaddingFess Then
                MsgBox("Plese complete current transaction or press refresh to start another one")
                Exit Sub
            End If


            If cboReceiptSearch.Text = "Receipt" Then
                Try


                    Dim serchtext As String = Trim(txtReceiptSearch.Text)
                    lbSeacrhFees.DataSource = Nothing
                    lbSeacrhFees.DisplayMember = "ReceiptDesc"
                    lbSeacrhFees.ValueMember = "Receipt"

                    Dim filter As String = " where receipt  like '%" & serchtext & "%'  and status = '1'"
                    lbSeacrhFees.Visible = True

                    Dim cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandText = "spReceiptSearch"
                    cmd.CommandType = CommandType.StoredProcedure
                    param = New SqlParameter("@filter", filter)
                    cmd.Parameters.Add(param)
                    Dim dsApps As New DataSet()
                    Dim taApps As SqlDataAdapter = Nothing
                    cnn.Open()




                    taApps = New SqlDataAdapter(cmd)



                    taApps.Fill(dsApps)





                    lbSeacrhFees.DataSource = dsApps.Tables(0)
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try

            ElseIf cboReceiptSearch.Text = "Student" Then

                Try


                    Dim serchtext As String = Trim(txtReceiptSearch.Text)
                    lbSeacrhFees.DataSource = Nothing
                    lbSeacrhFees.DisplayMember = "StudName"
                    lbSeacrhFees.ValueMember = "StudentID"
                    lbSeacrhFees.Visible = True
                    Dim cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandText = "spMainScreenStudentSearch"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim filter As String = " where s.studentid + ' ' + studentname + ' ' + studentsurname + ' '  like '%" & serchtext & "%'"
                    param = New SqlParameter("@filter", filter)
                    cmd.Parameters.Add(param)
                    Dim dsApps As New DataSet()
                    Dim taApps As SqlDataAdapter = Nothing
                    cnn.Open()

                    ' Dim sql As String = "Select FirstName + '' + LastName as Student ,AppReference , DateSubmitted,Class,Intake,program,campus,email,level,sem,session from studentapplication where email = '" & email & "' and appstatus = 'Approved'  and apllicationAccepted = 1 and StudentIDAssigned =  0  "




                    taApps = New SqlDataAdapter(cmd)



                    taApps.Fill(dsApps)





                    lbSeacrhFees.DataSource = dsApps.Tables(0)

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try



            End If
        End If
    End Sub



    Private Sub txtReceiptSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceiptSearch.TextChanged


    End Sub

    Private Sub lbSeacrhFees_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbSeacrhFees.DoubleClick

        Dim a, b As Integer
        If cboReceiptSearch.Text = "Receipt" Then

            Try

                Dim searchstring As String

                searchstring = lbSeacrhFees.SelectedValue
                txtReceiptSearch.Text = searchstring
                Me.FeesPayments_HeaderTableAdapter.FillByReceipt(DsSchool.FeesPayments_Header, searchstring, cboFeesCartegory.Text, chkTransScreenShowInvoices.Checked, chkTransScreenShowReceipts.Checked)
                lbSeacrhFees.Visible = False
                RefreshFeesStatement()




            Catch ex As Exception

            End Try
        ElseIf cboReceiptSearch.Text = "Student" Then


            Dim Studname() As String

            Studname = lbSeacrhFees.GetItemText(lbSeacrhFees.SelectedItem).Split("-")





            '           Dim stud As New cEnrol(Studname(2), Studname(0))
            Try

                Dim searchstring As String

                searchstring = lbSeacrhFees.SelectedValue
                txtReceiptSearch.Text = searchstring
                Loadstudent(searchstring)

                'a = ClassListBindingSource.Find("StudentID", searchstring)
                'If a < 0 Then
                '    '  MsgBox("Student ID could not be found")
                'Else
                '    ClassListBindingSource.Position = a
                'End If
            Catch ex As Exception

            End Try


        End If

    End Sub

    Private Sub Loadstudent(stud As String)
        Try
            Me.FeesPayments_HeaderTableAdapter.FillByStudent(DsSchool.FeesPayments_Header, stud, cboFeesCartegory.Text, chkTransScreenShowInvoices.Checked, chkTransScreenShowReceipts.Checked)
            lbSeacrhFees.Visible = False

            RefreshFeesStatement()
            FeesloadingMode()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboReceiptSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReceiptSearch.SelectedIndexChanged, cboFeesCartegory.SelectedIndexChanged
        '    txtReceiptSearch.Clear()
        If cboReceiptSearch.Text = "Date" Then
            txtReceiptSearch.Visible = False
            FeesDateSearch.Visible = True

            '   btnViewStatement.Enabled = False
            Dim recdate As Date
            Date.TryParse(FeesDateSearch.Text, recdate)
            Try
                Me.FeesPayments_HeaderTableAdapter.FillByDate(DsSchool.FeesPayments_Header, recdate, cboFeesCartegory.Text, chkTransScreenShowInvoices.CheckState, chkTransScreenShowReceipts.Checked)
            Catch ex As Exception

            End Try





        End If

        'Try filing

        If cboReceiptSearch.Text = "Receipt" Then
            txtReceiptSearch.Visible = True
            FeesDateSearch.Visible = False


            Try



                Me.FeesPayments_HeaderTableAdapter.FillByReceipt(DsSchool.FeesPayments_Header, txtReceiptSearch.Text, cboFeesCartegory.Text, chkTransScreenShowInvoices.CheckState, chkTransScreenShowReceipts.Checked)
                lbSeacrhFees.Visible = False



                'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
                'If a < 0 Then
                '    MsgBox("Student ID could not be found")
                'Else
                '    StudentPersonalDetailsBindingSource.Position = a
                'End If
            Catch ex As Exception

            End Try
        ElseIf cboReceiptSearch.Text = "Student" Then

            txtReceiptSearch.Visible = True
            FeesDateSearch.Visible = False
            Try


                Me.FeesPayments_HeaderTableAdapter.FillByStudent(DsSchool.FeesPayments_Header, txtReceiptSearch.Text, cboFeesCartegory.Text, chkTransScreenShowInvoices.CheckState, chkTransScreenShowReceipts.Checked)


            Catch ex As Exception

            End Try
            FeesloadingMode()
            RefreshFeesStatement()

        End If




    End Sub

    Private Sub FeesDateSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FeesDateSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cboReceiptSearch.Text = "Date" Then
                Dim serchtext As String = Trim(FeesDateSearch.Text)
                Dim recdate As Date


                Dim a, b As Integer
                Dim searchstring As String

                searchstring = FeesDateSearch.Text
                txtReceiptSearch.Text = searchstring
                Date.TryParse(searchstring, recdate)
                Me.FeesPayments_HeaderTableAdapter.FillByDate(DsSchool.FeesPayments_Header, recdate, cboFeesCartegory.Text, chkTransScreenShowInvoices.Checked, chkTransScreenShowReceipts.Checked)


                lbSeacrhFees.Visible = False



                'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
                'If a < 0 Then
                '    MsgBox("Student ID could not be found")
                'Else
                '    StudentPersonalDetailsBindingSource.Position = a
                'End If

            End If
        End If
    End Sub


    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox7.Enter

    End Sub

    'Private Sub ToolStripButton14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
    '    Dim a As String = BindingNavigator2.Items(5).Text
    'End Sub

    Private Sub ToolStripButton14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim sql, usr As String

        'If usr = goUser.FullName Then
        '    MsgBox("User not allowed to cancel own documnet")
        '    Exit Sub
        'End If





        Dim res As String = MsgBox("Are you sure you want to cancel the current Receipt ", MsgBoxStyle.YesNoCancel)

        If res = "6" Then
            pnlReversal.Visible = True
            mblnDltFess = True
            mblnEdtFess = False
            mblnaddingFess = False
            If ReasonForReversalComboBox.Text = "" Then


                MsgBox("Please select reason for Receipt deletion and press delete/cancel again")

                gbFeesPay.Enabled = True

            Else
                Try
                    Dim cmd As New SqlCommand
                    cnn = New SqlConnection(ConnectionString)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "spDeleteFeesReceipt"
                    cmd.Connection = cnn
                    param = New SqlParameter("@recnumber", ReceiptTextBox.Text)
                    cmd.Parameters.Add(param)
                    param = New SqlParameter("@user", goUser.userName)
                    cmd.Parameters.Add(param)
                    param = New SqlParameter("@reason", ReasonForReversalComboBox.Text)
                    cmd.Parameters.Add(param)
                    cnn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Payment successfully cancelled")
                    FeesloadingMode()
                    RefreshFeesStatement()
                    FeesPayments_HeaderTableAdapter.FillByReceipt(DsSchool.FeesPayments_Header, ReceiptTextBox.Text, cboFeesCartegory.Text, chkTransScreenShowInvoices.Checked, chkTransScreenShowReceipts.Checked)


                Catch ex As Exception
                    MsgBox("Error in deleting payment " & ex.Message)
                    FeesloadingMode()
                Finally
                    cnn.Close()
                End Try



            End If
        Else
            FeesloadingMode()
        End If


        'For Each item In BindingNavigator2.Items
        '    MsgBox(item.ToString & )
        'Next
    End Sub

    Private Sub Reprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reprint.Click



        Try

            Dim rptvwer As New frmReportPreview()
            With rptvwer
                .recprint = True
                .RecNumber = ReceiptTextBox.Text
                .recCopy = True

                If Trim(Mid(ReceiptTextBox.Text, 1, 4)) <> "inv_" Then
                    .isReceipt = True
                    .RecNumber = ReceiptTextBox.Text

                    '    frmReportPreview.Show()

                Else
                    .isReceipt = False

                End If
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub lbSeacrhFees_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSeacrhFees.SelectedIndexChanged

    End Sub

    Private Sub Edt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edt.Click
        FeesEditMode()
    End Sub
    Private Sub FeesEditMode()
        mblnEdtFess = True
        gbFeesPay.Enabled = True
        dgFessDetails.Enabled = True
        mblnaddingFess = False
        BindingNavigator2.Items("Delete").Visible = True
        BindingNavigator2.Items("Insert").Visible = True
        BindingNavigator2.Items("Save").Visible = True
        dgFessDetails.Columns("btnUpdate").Visible = True
        dgFessDetails.Columns("btnDelete").Visible = True
        btnUpdateAllLines.Visible = True
        btnCancelAllLines.Visible = True
    End Sub

    Private Sub FeesloadingMode()
        mblnEdtFess = False
        gbFeesPay.Enabled = False
        dgFessDetails.Enabled = False
        mblnDltFess = False
        mblnaddingFess = False
        BindingNavigator2.Items("Delete").Visible = True
        BindingNavigator2.Items("Insert").Visible = True
        BindingNavigator2.Items("Save").Visible = False
        dgFessDetails.Columns("btnUpdate").Visible = False
        dgFessDetails.Columns("btnDelete").Visible = False
        btnUpdateAllLines.Visible = False
        btnCancelAllLines.Visible = False
    End Sub
    Private Sub CheckBox2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            dgBilling.SelectAll()
        Else
            For A1 = 0 To dgBilling.Rows.Count - 1
                dgBilling.Rows(A1).Selected = False


            Next
        End If
    End Sub

    Private Sub cboBillType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBillType.SelectedIndexChanged


        Dim sql As String
        Dim drr As SqlDataReader
        If cboBillType.Text = "Normal" Or cboBillType.Text = "Combined" Then
            chkBilPeriods.Items.Clear()

            sql = "spLoadFeesPeriods"

            drr = ExecuteReader(sql, , True,,, False)
            While drr.Read

                chkBilPeriods.Items.Add(drr("Period") & "-" & drr("Description"))



            End While
            dgPayType.Visible = True
            Try
                FillBillingPaymentCartegories()
            Catch ex As Exception

            End Try
        ElseIf cboBillType.Text = "Reversal" Then
            chkBilPeriods.Items.Clear()
            sql = " select distinct reference from feespayments_details inner join feespayments_header on feespayments_header.receipt = feespayments_details.receipt " &
           "  where feespayments_header.type = 'I' and [status] = 1  "


            drr = ExecuteReader(sql, , True)
            While drr.Read

                chkBilPeriods.Items.Add(drr(0))

            End While
            'Try
            '    Me.PaymentTypeTableAdapter.Fill(SchoolDataSet.PaymentType)
            'Catch ex As Exception

            'End Try
            dgPayType.Visible = False

            ' txtBillAmount.Enabled = False
        End If








    End Sub

    Private Sub FillBillingPaymentCartegories()
        Dim cmd As New SqlCommand
        Dim cnn As SqlConnection = New SqlConnection(ConnectionString())

        cmd.CommandText = "spGetBillingCartegories"

        cmd.Connection = cnn
        cmd.CommandType = CommandType.StoredProcedure




        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing



        cnn.Open()

        ' Dim sql As String = "Select FirstName + '' + LastName as Student ,AppReference , DateSubmitted,Class,Intake,program,campus,email,level,sem,session from studentapplication where email = '" & email & "' and appstatus = 'Approved'  and apllicationAccepted = 1 and StudentIDAssigned =  0  "

        Try


            taApps = New SqlDataAdapter(cmd)



            taApps.Fill(dsApps)



            If dsApps.Tables(0).Rows.Count > 0 Then
                dgPayType.DataSource = dsApps.Tables(0)

            Else
                dgPayType.DataSource = dsApps.Tables(0)
                MsgBox("No Payment Cartegories found .")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub btnClearBillStuds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearBillStuds.Click
        txtBillStud.Clear()
    End Sub

    Private Sub txtBillStud_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBillStud.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbBillStud.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            Button9_Click_1(Me, Nothing)
        End If
    End Sub

    Private Sub txtBillStud_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBillStud.TextChanged

    End Sub

    Private Sub lbBillStud_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbBillStud.DoubleClick
        Dim stud As String = ""
        Dim searchstud As String

        Try
            searchstud = lbBillStud.GetItemText(lbBillStud.SelectedItem)
            stud = lbBillStud.SelectedValue
            lbBillStud.DataSource = Nothing
            lbBillStud.Visible = False
            txtBillStud.Text = stud

            Dim arraysplit() As String
            arraysplit = Split(searchstud, "-")
            'cboBillingProgram.Text = arraysplit(3).ToString
            cboBillingProg.SelectedValue = arraysplit(5).ToString
            cboBillingLevel.Text = arraysplit(3).ToString
            cboBillingClass.Text = arraysplit(2).ToString
            cboBillingSess.Text = arraysplit(4).ToString


            Button3_Click_2(Me, Nothing)




            searchStudsSpec(stud, dgBilling, "BillingStudentID")
        Catch ex As Exception

        End Try

    End Sub





    Private Sub ToolStripButton14_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        studprnt = True
        enrolform = False
        receiptprnt = False
        gstrstud2 = StudentIDTextBox.Text

        '     frmReportPreview.Show()
    End Sub



    Private Sub DateOfBirthMaskedTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateOfBirthMaskedTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PlaceOfBirthTextBox.Focus()

        End If
    End Sub


    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        ttxSearchtext.Clear()
    End Sub



    Private Sub dgFessDetails_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFessDetails.Enter

    End Sub

    Private Sub btnViewStatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gstrstud2 = txtFeesStudID.Text
        receiptprnt = False
        stmntprnt = True
        enrolform = False
        studprnt = False
        clsprint = False

        '      frmReportPreview.Show()


    End Sub

    Private Sub FeesDateSearch_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles FeesDateSearch.MaskInputRejected

    End Sub





    Private Sub btnClassReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClassReport.Click
        'If cboe Then


        If cboEnrlProgSearch.Text = "" Then
            MsgBox("Invalid Program")
            Exit Sub
        End If

        If cboEnrolClassSearch.Text = "" Then
            MsgBox("Invalid Class")
            Exit Sub
        End If
        If cboEnrLevSearch.Text = "" Then
            MsgBox("Invalid Level")
            Exit Sub
        End If


        If CboEnrSessSearch.Text = "" Then
            MsgBox("Invalid Session")
            Exit Sub
        End If



        Dim rptPrvw As New frmReportPreview()

        With rptPrvw
            .classprint = True
            .program = cboEnrlProgSearch.SelectedValue
            .lvl = cboEnrLevSearch.Text
            .session = CboEnrSessSearch.Text
            .clas = cboEnrolClassSearch.Text
            .ShowDialog()
        End With
    End Sub





    Private Sub lbBillSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbBillSearch.DoubleClick
        txtStudBillSearch.Text = lbBillSearch.SelectedValue
        lbBillSearch.Items.Clear()
        searchStuds(txtStudBillSearch.Text, dgBilling, "BillingStudentID")
        lbBillSearch.Visible = False
    End Sub

    Private Sub lbBillSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbBillSearch.SelectedIndexChanged

    End Sub

    Private Sub txtStudBillSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudBillSearch.TextChanged

    End Sub

    Private Sub dgBilling_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgBilling.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgBilling_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBilling.SelectionChanged
        If dgBilling.Rows.Count = dgBilling.SelectedRows.Count Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub txtBirth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            FeesSourceComboBox.Focus()
        End If
    End Sub

    Private Sub PlaceOfBirthTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PlaceOfBirthTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            NationalIDTextBox.Focus()
        End If
    End Sub



    Private Sub ToolStripButton14_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        MsgBox("This is the recommended format for student uploads: StudentId|surname|name|gender|address|mobilenumber|email|dob")

        Dim frmstudUload As New frmReceiptUpload_1()

        frmstudUload.Show()



    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked Then
            dgClassList.SelectAll()
            CheckBox4.Text = "SelectAllStudents"
        Else
            For A1 = 0 To dgClassList.Rows.Count - 1
                dgClassList.Rows(A1).Selected = False
                CheckBox4.Text = "UnSelectAllStudents"

            Next
        End If
    End Sub

    Private Sub GroupBox12_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox12.Enter

    End Sub

    Private Sub dgFessDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFessDetails.CellContentClick

    End Sub


    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub







    Private Sub chkSelectOldClassStuds_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectOldClassStuds.CheckedChanged
        Dim a As Integer
        a = chkoldclass.Items.Count
        If chkSelectOldClassStuds.Checked Then
            For B1 = 0 To a - 1
                chkoldclass.SetItemChecked(B1, True)
            Next
            chkSelectOldClassStuds.Text = "UnSelect All Students"
        Else
            For B1 = 0 To a - 1
                chkoldclass.SetItemChecked(B1, False)
            Next
            chkSelectOldClassStuds.Text = "Select All Students"
        End If
    End Sub

    Private Sub Button19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Dim sql, sql2 As String




        If cbonewclassprog.Text = "" Then
            MsgBox("Select new class program")
            Exit Sub
        End If
        If cbonewclassform.Text = "" Then
            MsgBox("Select new class form")
            Exit Sub
        End If



        If cbonewclassSess.Text = "" Then
            MsgBox("Select new class session")
            Exit Sub
        End If


        If cbonewClassCls.Text = "" Then
            MsgBox("Select new class")
            Exit Sub
        End If

        Dim a As Integer = chknewclass.Items.Count

        If a = 0 Then
            MsgBox("New class empty")
        End If

        For Each itm In chknewclass.Items
            Dim cnn As New SqlConnection(ConnectionString)
            Try



                Dim cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spMigrateStudent"
                cnn.Open()



                params = New List(Of SqlParameter)



                param = New SqlParameter("@stud", CleanComboVal(itm.ToString))
                params.Add(param)

                param = New SqlParameter("@oldprogram", cboOldClassprog.Text)
                params.Add(param)

                param = New SqlParameter("@newprogram", cbonewclassprog.Text)
                params.Add(param)

                param = New SqlParameter("@newclass", cbonewClassCls.Text)
                params.Add(param)

                param = New SqlParameter("@oldclass", cboOldClassCls.Text)
                params.Add(param)

                param = New SqlParameter("@oldlevel", cboOldclassForm.Text)
                params.Add(param)

                param = New SqlParameter("@newlevel", cbonewclassform.Text)
                params.Add(param)

                param = New SqlParameter("@oldsession", cboOldClassSess.Text)
                params.Add(param)

                param = New SqlParameter("@session", cbonewclassSess.Text)
                params.Add(param)



                param = New SqlParameter("@keepoldclass", Chkmitype.Checked)
                params.Add(param)

                param = New SqlParameter("@user", goUser.FullName)
                params.Add(param)

                param = New SqlParameter("@maintainPrevSubjects", chkMaintainPrevSubjects.Checked)
                params.Add(param)


                For Each par In params
                    cmd.Parameters.Add(par)
                Next

                cmd.ExecuteNonQuery()




            Catch ex As Exception
                MsgBox(itm & ": Student migration failed " & vbNewLine & ex.Message)
            Finally
                cnn.Close()
            End Try


        Next


        MsgBox("Student migration completed")







    End Sub





    Private Sub cboOldclassForm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOldclassForm.SelectedIndexChanged,
             cboOldClassprog.SelectedIndexChanged,
        cboOldClassSess.SelectedIndexChanged, cboOldClassCls.SelectedIndexChanged

        chkoldclass.Items.Clear()
        chknewclass.Items.Clear()

        Dim cmd As New SqlCommand
        Dim cnn As SqlConnection = New SqlConnection(ConnectionString())

        Dim students As SqlDataReader
        Try
            cnn.Open()
            cmd.CommandText = "FillAllStuds"

            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure

            params = New List(Of SqlParameter)


            param = New SqlParameter("@prog", cboOldClassprog.SelectedValue)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@year", cboOldclassForm.Text)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@sess", cboOldClassSess.Text)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@classdesc", cboOldClassCls.Text)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@filter", " and enrollment.status = 'Available'")
            cmd.Parameters.Add(param)


            students = cmd.ExecuteReader()

            If students.HasRows Then
                While students.Read
                    chkoldclass.Items.Add(students("StudentID") & "-" & students("StudName"))
                End While
            Else

            End If

            'Dim dsApps As New DataSet()
            'Dim taApps As SqlDataAdapter = Nothing





            '' Dim sql As String = "Select FirstName + '' + LastName as Student ,AppReference , DateSubmitted,Class,Intake,program,campus,email,level,sem,session from studentapplication where email = '" & email & "' and appstatus = 'Approved'  and apllicationAccepted = 1 and StudentIDAssigned =  0  "




            'taApps = New SqlDataAdapter(cmd)



            'taApps.Fill(dsApps)



            'If dsApps.Tables(0).Rows.Count > 0 Then
            '    chkoldclass.DataSource = dsApps.Tables(0)
            '    chkoldclass.DisplayMember = "StudName"
            '    chkoldclass.ValueMember = "StudentID"

            'Else
            '    chkoldclass.DataSource = dsApps.Tables(0)
            '    '     MsgBox("No Students in the Selected Class")

            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try
    End Sub





    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click


        For Each cv In chkoldclass.CheckedItems()
            chknewclass.Items.Add(cv)
        Next

        With chkoldclass
            If .CheckedItems.Count > 0 Then
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    .Items.Remove(.CheckedItems(checked))
                Next
            End If
        End With

        MsgBox("Select the new class details")

        'chknewclass.Items.Add(chkoldclass.CheckedItems(0)



        'chkoldclass.Items.Remove(chkoldclass.CheckedItems())













    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        For Each cv In chknewclass.CheckedItems()
            chkoldclass.Items.Add(cv)
        Next

        With chknewclass
            If .CheckedItems.Count > 0 Then
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    .Items.Remove(.CheckedItems(checked))
                Next
            End If
        End With
    End Sub





    Private Sub CheckBox1_CheckedChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        chknewclass.Items.Clear()
    End Sub

    Private Sub GroupBox11_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox11.Enter

    End Sub

    Private Sub cboBillCurrency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBilPeriods.SelectedIndexChanged

    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Dim frmUploadInv As New frmInvUpload()


        frmUploadInv.Show()



    End Sub



    Private Sub rec_import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rec_import.Click
        Dim recup As New frmRecup_2()
        recup.ShowDialog()










    End Sub

    Private Sub ToolStripButton8_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Insert.VisibleChanged

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        txtStudNotif.Clear()
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbPic.Enter

    End Sub

    Private Sub lbBillStud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbBillStud.SelectedIndexChanged

    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub cboCashType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCashType.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtStudMarksSearch.Clear()
    End Sub

    Private Sub txtStudMarksSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStudMarksSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbStudMarks.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            Button11_Click_2(Me, Nothing)
        End If
    End Sub

    Private Sub txtStudMarksSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudMarksSearch.TextChanged

    End Sub


    Private Sub lbSubStudSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSubStudSearch.SelectedIndexChanged

    End Sub

    Private Sub lbStudMarks_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbStudMarks.DoubleClick



        Dim stud As String
        Dim studsearch As String = ""
        Try
            studsearch = lbStudMarks.GetItemText(lbStudMarks.SelectedItem)
            stud = lbStudMarks.SelectedValue
            lbStudMarks.DataSource = Nothing
            lbStudMarks.Visible = False
        Catch ex As Exception

        End Try

        Dim arraysplit() As String
        arraysplit = Split(studsearch, "-")
        txtStudMarksSearch.Text = stud

        cboMarkLevel.Text = arraysplit(3).ToString
        cboMarkClass.Text = arraysplit(2).ToString

        cboMarkSession.Text = arraysplit(4).ToString
        cboMarkProg.SelectedValue = arraysplit(5).ToString
        cboMarkExam.Text = arraysplit(6).ToString
        Try
            gdStudents.DataSource = fillAllMarks().Tables(0)
        Catch ex As Exception

        End Try
        searchStudsSpec(stud, gdStudents, "MarksStudentID")
        ' gblnsinglemark = True

    End Sub















    Private Sub rbsmsSection_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbsmsSection.CheckedChanged
        'If rbsmsSection.Checked = True Then
        '    schoolsections = True
        '    groups = False
        '    Panel = False
        '    gbSendingOptions.Enabled = True
        '    gbFeesSms.Enabled = True
        '    ' specific.Enabled = False
        '    MsgBox("Select School Section and click send to send  all members in the respective section")
        'End If
        'cboSchoolSections.Enabled = rbsmsSection.Checked
    End Sub

    Private Sub rbSmsNotAtDb_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSmsNotAtDb.CheckedChanged
        'If rbSmsNotAtDb.Checked Then
        '    schoolsections = False
        '    groups = False
        '    cboSchoolSections.Enabled = False
        '    Panel = False
        '    gbSendingOptions.Enabled = False
        '    gbFeesSms.Enabled = False
        '    'specific.Enabled = False
        '    Button9_Click(Me, Nothing)
        'End If
    End Sub

    Private Sub rbsmsClass_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbsmsClass.CheckedChanged
        'If rbsmsClass.Checked Then
        '    schoolsections = False
        '    cboSchoolSections.Enabled = False
        '    Panel = True
        '    groups = False
        '    gbSendingOptions.Enabled = True
        '    gbFeesSms.Enabled = True
        '    ' specific.Enabled = True
        '    Button5_Click(Me, Nothing)
        'End If
    End Sub


    Private Sub rbSmsGroups_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSmsGroups.CheckedChanged
        'If rbSmsGroups.Checked Then
        '    schoolsections = False
        '    cboSchoolSections.Enabled = False
        '    Panel = False
        '    groups = True
        '    gbSendingOptions.Enabled = True
        '    gbFeesSms.Enabled = False
        'End If
        'cboSmsClubs.Enabled = rbSmsGroups.Checked
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeesClassMoveNext.Click, btnFeesClassMovePrev.Click

        Dim btn As Button = sender
        Select Case btn.Name
            Case btnFeesClassMoveNext.Name
                ClassListBindingSource.MoveNext()
            Case btnFeesClassMovePrev.Name
                ClassListBindingSource.MovePrevious()
        End Select


        txtPos.Text = ClassListBindingSource.Position + 1 & "of " & ClassListBindingSource.Count
        '      cboReceiptSearch.Text = "Student"



        'txtReceiptSearch.Text = lbFeesHidedStudID.Text
        'lbSeacrhFees.Visible = False
        'FeesPayments_HeaderTableAdapter.FillByStudent(DsSchool.FeesPayments_Header, txtReceiptSearch.Text, cboFeesCartegory.Text)

    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMovePreviousItem.Click

    End Sub














    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        Dim sql As String
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)



        If txtStudRef.Text <> "" Then
            Dim res As String = MsgBox("Are you sure you want to delete the current student ", MsgBoxStyle.YesNo)
            Try
                If res = "6" Then
                    cnn.Open()
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "spDeleteStudent"
                    cmd.Parameters.AddWithValue("@student", StudentIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@user", gouser.userName)
                    cmd.ExecuteNonQuery()
                    MsgBox("Student Successfully Deleted")
                    loadStudInfo("")
                End If
            Catch ex As Exception
                MsgBox("Student could not be deleted")
            Finally
                cnn.Close()
            End Try

        Else
            MsgBox("No student available for deletion")
        End If

    End Sub

    Private Sub PersonalDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PersonalDetails.KeyDown
        If e.KeyCode = Keys.Control + Keys.S Then

            Select Case PersonalDetails.SelectedIndex
                Case 0
                    SchoolInfoBindingNavigatorSaveItem_Click(Me, Nothing)
                Case 1
                    saveSub_Click(Me, Nothing)
                Case 2

                    ToolStripButton13_Click(Me, Nothing)
                Case 3
                    ToolStripButton13_Click(Me, Nothing)


            End Select



        End If
    End Sub









    Private Sub dgBilling_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBilling.CellContentClick

    End Sub

    Private Sub ToolStripButton13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        If Trim(StudentIDTextBox.Text) = "" Then
            MsgBox("Select Student to register Finger Print")
            studreg = False
        Else

            Dim sql As String
            Dim drr As SqlDataReader

            sql = "select *  from studentpersonaldetails where studentid = '" & StudentIDTextBox.Text & "' and fingerprint is not null "
            drr = ExecuteReader(sql, , True)

            If drr.HasRows Then
                Dim res As String = MsgBox("Student Print already registered do you want to continue", MsgBoxStyle.YesNo)
                If res = "6" Then

                    studreg = True
                    '      FrmRegisterPrintsStudsvb.Show()
                End If

            Else
                studreg = True
                '     FrmRegisterPrintsStudsvb.Show()
            End If

        End If
    End Sub


    Private Sub Button28_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If gdStudents.SelectedRows.Count = 0 Then
            MsgBox("No Student has Been selected for Form Teacher's Comments", MsgBoxStyle.Information)
        Else

            '  dgFormTeacher.Show()
        End If

    End Sub

    Private Sub gdStudents_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gdStudents.CellContentClick

    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        If Headmasters.Count > 0 Then



            If gdStudents.SelectedRows.Count > 0 Then

                Dim headscreen As New DgHead
                headscreen.classstuds = fillAllMarks()
                headscreen.Exam = cboMarkExam.Text
                headscreen.studid = gdStudents.SelectedRows(0).Cells(0).Value


                headscreen.Show()

            Else
                MsgBox("Select Student")
            End If
        Else
            MsgBox("No Headmaster's maintained in the System")
        End If


    End Sub



    Private Sub dgPayType_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgPayType.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox4_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevSchoolContact.TextChanged

    End Sub

    Private Sub btnCancelMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim student As String = ""
        Dim BehaviorClass As String = ""
        Dim behaviorType As String = ""
        Dim behaviorDate As Date
        Dim behaviorSeverity As String = ""
        Dim BehaviorDetails As String = ""
        Dim behaviorReference As String = ""
        Dim Behaviorperiod As String = ""

        cnn = New SqlConnection(ConnectionString)
        Dim trans As SqlTransaction
        Dim cmd As SqlCommand
        If dgStudBehavior.Rows.Count = 0 Then
            MsgBox("No behavior Record available,add behavior records.")
            Exit Sub
        End If



        Try
            cnn.Open()

            trans = cnn.BeginTransaction
            For i = 0 To dgStudBehavior.Rows.Count - 1



                With dgStudBehavior.Rows(i)

                    If .Visible Then
                        sql = "spInsertStudentBehavior"
                        student = .Cells("BehaviorStudent").Value
                        BehaviorClass = .Cells("BehaviorClass").Value
                        behaviorType = .Cells("BehaviorType").Value
                        behaviorDate = .Cells("BehaviorDate").Value
                        behaviorSeverity = .Cells("BehaviorSeverity").Value
                        BehaviorDetails = .Cells("BehaviorDetails").Value
                        If Not IsNothing(.Cells("BehaviorRef").Value) Then
                            behaviorReference = IIf(.Cells("BehaviorRef").Value.ToString = "", Guid.NewGuid.ToString, .Cells("BehaviorRef").Value.ToString)
                        Else
                            behaviorReference = Guid.NewGuid.ToString
                        End If

                        Behaviorperiod = .Cells("BehaviorPeriod").Value

                        cmd = New SqlCommand(sql, cnn, trans)
                        cmd.CommandType = CommandType.StoredProcedure

                        With cmd.Parameters
                            .AddWithValue("@stud", student)
                            .AddWithValue("@date", behaviorDate)
                            .AddWithValue("@class", BehaviorClass)
                            .AddWithValue("@type", behaviorType)
                            .AddWithValue("@severity", behaviorSeverity)
                            .AddWithValue("@details", BehaviorDetails)
                            .AddWithValue("@ref", behaviorReference)
                            .AddWithValue("@period", Behaviorperiod)

                        End With
                        cmd.ExecuteNonQuery()

                    Else
                        If Not IsNothing(.Cells("BehaviorRef").Value) Then
                            behaviorReference = IIf(.Cells("BehaviorRef").Value.ToString = "", Guid.NewGuid.ToString, .Cells("BehaviorRef").Value.ToString)

                            sql = "delete studbehavior where behaviorReference = '" & behaviorReference & "'"
                            cmd = New SqlCommand(sql, cnn, trans)
                            cmd.ExecuteNonQuery()
                        End If

                    End If

                End With




            Next

            trans.Commit()


            MsgBox("Student Behavior Successfully updated")
            dgStudBehavior.Rows.Clear()

            LoadStudBehavior(student)

        Catch ex As Exception

            MsgBox("Failed to Update Student Behavior - " & ex.Message)

            trans.Rollback()

        Finally
            cnn.Close()

        End Try

    End Sub

    Private Sub txtStudent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBehaviorStud.TextChanged

    End Sub

    Private Sub lbStudBehavior_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim res() As String


        res = lbStudBehavior.SelectedItem.ToString.Split("-")
        txtBehaviorStud.Text = res(0)

        lbStudBehavior.Visible = False


    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        dgStudBehavior.Rows.Clear()
        lbStudBehavior.Visible = False

        LoadStudBehavior(Trim(txtBehaviorStud.Text))
        'mskbedate.Clear()
        'txtbedesc.Clear()
        'cbobetype.Text = ""

    End Sub

    Private Sub chkdef_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdef.CheckedChanged
        For i = 0 To gvMarks.Rows.Count - 2
            gvMarks.Rows(i).Cells(0).Value = chkdef.Checked
        Next
    End Sub

    Private Sub cboRemarks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRemarks.SelectedIndexChanged
        For i = 0 To gvMarks.Rows.Count - 2
            gvMarks.Rows(i).Cells(7).Value = cboRemarks.Text
        Next
    End Sub

    Private Sub gvMarks_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvMarks.CellContentClick

    End Sub

    Private Sub gvMarks_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles gvMarks.CellValidating
        If gvMarks.Columns(e.ColumnIndex).HeaderText = "TM" Then
            If gvMarks.CurrentRow.Cells("CourseMark").Value > 100 Or gvMarks.CurrentRow.Cells("CourseMark").Value < 0 Then
                MsgBox("Invalid Course mark")
                e.Cancel = True
                gvMarks.CurrentRow.Cells("CourseMark").Value = 0
            Else
                e.Cancel = False
            End If
        ElseIf gvMarks.Columns(e.ColumnIndex).HeaderText = "EM" Then
            If gvMarks.CurrentRow.Cells("ExamMark").Value > 100 Or gvMarks.CurrentRow.Cells("ExamMark").Value < 0 Then
                MsgBox("Invalid Exam Mark")
                e.Cancel = True
                gvMarks.CurrentRow.Cells("ExamMark").Value = 0
            Else
                e.Cancel = False
            End If
        ElseIf gvMarks.Columns(e.ColumnIndex).HeaderText = "Remarks" Then
            If gvMarks.CurrentRow.Cells("Remarks").Value = "" Then
                'MsgBox("Invalid Remark")
                'e.Cancel = True
            Else
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub cboExam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMarkExam.SelectedIndexChanged

    End Sub



    Private Sub gvMarks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles gvMarks.KeyPress

    End Sub



    Private Sub chkExmSessions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gdStudents.DataSource = fillAllMarks().Tables(0)
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            '   lbSubjects.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            gdStudents.DataSource = fillAllMarks().Tables(0)
        End If
    End Sub












    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged

        Dim a As Integer
        a = Available_Subjects.Items.Count

        For b As Integer = 0 To a - 1
            Available_Subjects.SetItemChecked(b, chkAll.Checked)
        Next
    End Sub

    Private Sub EnrollmentDetails_Enter(sender As Object, e As EventArgs) Handles gbEnrollmentDetails.Enter

    End Sub

    Private Sub btnAddSibling_Click(sender As Object, e As EventArgs) Handles btnAddSibling.Click
        Dim studs As SqlDataReader = Nothing
        Dim parameters As New List(Of SqlParameter)
        Dim sql As String
        Dim param As SqlParameter

        Dim sib As New csSiblings

        Dim sibgroup As String = ""

        If IsNothing(Sibs) Then
            Sibs = New List(Of csSiblings)
        End If


        If Not mblnaddingUser Then




            sql = "spInsertSibling"

            param = New SqlParameter("@stud", StudentIDTextBox.Text)
            parameters.Add(param)
            param = New SqlParameter("@sibling", cboSibling.SelectedValue)
            parameters.Add(param)
            param = New SqlParameter("@New", 0)
            parameters.Add(param)
            ExecuteNonQuery(sql,, True,,,,, parameters, False)


            If Not era Then

                loadSiblings(stud.StudentID)
                MsgBox("Sibling Added")
            Else
                MsgBox(eramsg)

            End If

        Else
            sibgroup = GetSiblingGroup(cboSibling.SelectedValue)

            If sibgroup <> "" Then
                Sibs = New List(Of csSiblings)
                Sibs = loadSiblingGroup(cboSibling.SelectedValue)

                sib.Sibling = cboSibling.SelectedItem.Value
                sib.SiblingName = cboSibling.SelectedItem.Text
                Sibs.Add(sib)
            Else
                sib.Sibling = cboSibling.SelectedItem.Value
                sib.SiblingName = cboSibling.SelectedItem.Text
                Sibs.Add(sib)

            End If





            dgSiblings.DataSource = Sibs


            '     dgSiblings.DataBind()


        End If
    End Sub

    Private Function loadSiblingGroup(stud As String) As List(Of csSiblings)
        Dim reader As SqlDataReader
        Dim param As SqlParameter
        Dim params As List(Of SqlParameter)
        Dim sib As csSiblings
        Dim sibs As List(Of csSiblings)
        sibs = New List(Of csSiblings)


        params = New List(Of SqlParameter)
        sql = "[sploadSiblings]"


        param = New SqlParameter("@stud", stud)
        params.Add(param)

        reader = ExecuteReader(sql, True,,, params, False)
        While reader.Read
            sib = New csSiblings
            sib.Sibling = reader(0).ToString
            sib.SiblingName = reader(1).ToString
            sibs.Add(sib)
        End While

        Return sibs

    End Function

    Private Sub loadSiblings(Stud As String)
        Dim cnn As New SqlConnection(ConnectionString)
        Try


            Dim param As SqlParameter
            Dim dsApps As New DataSet()
            Dim taApps As SqlDataAdapter = Nothing
            Dim sql As String

            sql = "sploadSiblings"

            Dim cmd As New SqlCommand(sql, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cnn.Open()
            param = New SqlParameter("@stud", Stud)
            cmd.Parameters.Add(param)

            taApps = New SqlDataAdapter(cmd)

            taApps.Fill(dsApps)
            dgSiblings.DataSource = dsApps.Tables(0)

        Catch ex As Exception
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub LoadStudNok(Stud As String)

        Dim param As SqlParameter
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim sql As String
        Dim cnn As New SqlConnection(ConnectionString)
        sql = " select * from fnLoadStudNok(@stud)"

        Try
            Dim cmd As New SqlCommand(sql, cnn)
            cnn.Open()
            param = New SqlParameter("@stud", Stud)
            cmd.Parameters.Add(param)
            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)
            dgStudNok.DataSource = dsApps.Tables(0)
        Catch ex As Exception
        Finally
            cnn.Close()
        End Try




    End Sub
    Private Sub btnAddNok_Click(sender As Object, e As EventArgs) Handles btnAddNok.Click
        Dim parameter As SqlParameter = Nothing
        Dim parameters As List(Of SqlParameter) = Nothing
        Dim studnok As New StudNok
        Dim nokCols As SqlDataReader
        Dim errormsg As String = ""

        '     errormsg = CheckInputs(const_sponsordetails)


        If errormsg = "" Then


            If IsNothing(NokS) Then
                NokS = New List(Of StudNok)
            End If

            With studnok
                .StudentID = StudentIDTextBox.Text
                .Nok_Name = NokNameTextBox.Text
                .Nok_Surname = txtNokSurname.Text
                .Nok_RelationShip = NOKRelationTextBox.Text
                .Nok_Contact = NOKContactNumber.HeaderText
                .Nok_Address = ""
                .Nok_Email = ""
                .Nok_Employer = ""
                .Nok_EmployerAddress = ""
                .Nok_EmployerContact = ""
                .Nok_EmployerEmail = ""
                .Nok_Employment = NOKOccupationTextBox.Text
                .Nok_refid = Guid.NewGuid


                If .Nok_Name = "" Or .Nok_RelationShip = "" Then
                    MsgBox("Fill out missing information")
                    Exit Sub
                End If

            End With



            If Not mblnaddingUser Then
                sql = "spInsertStudNok"
                parameters = New List(Of SqlParameter)
                With studnok

                    parameter = New SqlParameter("@stud", .StudentID)
                    parameters.Add(parameter)
                    parameter = New SqlParameter("@nokname", .Nok_Name)
                    parameters.Add(parameter)
                    parameter = New SqlParameter("@noksurname", .Nok_Surname)
                    parameters.Add(parameter)
                    parameter = New SqlParameter("@nokrelation", .Nok_RelationShip)
                    parameters.Add(parameter)
                    parameter = New SqlParameter("@nokaddress", .Nok_Address)
                    parameters.Add(parameter)
                    parameter = New SqlParameter("@nokcontact", .Nok_Contact)
                    parameters.Add(parameter)
                    parameter = New SqlParameter("@nokemail", .Nok_Email)
                    parameters.Add(parameter)
                    parameter = New SqlParameter("@nokjobtitle", .Nok_Employment)
                    parameters.Add(parameter)
                    parameter = New SqlParameter("@nokemployer", .Nok_Employer)
                    parameters.Add(parameter)
                    parameter = New SqlParameter("@nokemployercontact", .Nok_EmployerContact)
                    parameters.Add(parameter)
                    parameter = New SqlParameter("@nokemployerAddress", .Nok_EmployerAddress)
                    parameters.Add(parameter)
                    parameter = New SqlParameter("@nokEmployerEmail", .Nok_EmployerEmail)
                    parameters.Add(parameter)

                    parameter = New SqlParameter("@refid", .Nok_refid.ToString)
                    parameters.Add(parameter)


                    ExecuteNonQuery(sql,, True,,,,, parameters, False)

                    If era Then

                        MsgBox(eramsg)
                        '     ModalPopupExtender_SponsorDetails.Show()
                    Else

                        MsgBox("Parent/Guardian Successfully Saved")

                    End If

                    LoadStudNok(StudentIDTextBox.Text)

                End With


            Else 'Add to grid

                NokS.Add(studnok)

                dgStudNok.DataSource = NokS



                ' dsSiblings.SelectCommand = sql

                Try
                    '     gdStudNok.DataBind()
                    MsgBox("Parent/Guardian Successfully added")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try








            End If

            'clearnok()

            'ModalPopupExtender_SponsorDetails.Show()

        Else
            MsgBox(errormsg)
        End If

    End Sub



    Private Sub btnSubClassList_Click(sender As Object, e As EventArgs) Handles btnSubClassList.Click, cboSubClass.SelectedIndexChanged, cboSubLvl.SelectedIndexChanged, cboSubSess.SelectedIndexChanged

        '      dgSubStuds.DataSource = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As SqlConnection = New SqlConnection(ConnectionString())

        cmd.CommandText = "FillAllStuds"

        cmd.Connection = cnn
        cmd.CommandType = CommandType.StoredProcedure

        params = New List(Of SqlParameter)


        param = New SqlParameter("@prog", cboSubProg.SelectedValue.ToString)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@year", cboSubLvl.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@sess", cboSubSess.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@classdesc", cboSubClass.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@filter", "")
        cmd.Parameters.Add(param)


        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing



        cnn.Open()

        ' Dim sql As String = "Select FirstName + '' + LastName as Student ,AppReference , DateSubmitted,Class,Intake,program,campus,email,level,sem,session from studentapplication where email = '" & email & "' and appstatus = 'Approved'  and apllicationAccepted = 1 and StudentIDAssigned =  0  "

        Try


            taApps = New SqlDataAdapter(cmd)



            taApps.Fill(dsApps)



            If dsApps.Tables(0).Rows.Count > 0 Then
                dgSubStuds.DataSource = dsApps.Tables(0)

            Else
                dgSubStuds.DataSource = dsApps.Tables(0)
                '     MsgBox("No Students in the Selected Class")

            End If
        Catch ex As Exception
            '     MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try
        '      getProgramsubjects()

    End Sub

    Private Sub cboSubProg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubProg.SelectedIndexChanged
        getProgramsubjects()
        btnSubClassList_Click(Me, Nothing)

    End Sub

    Private Sub btnFessClass_Click(sender As Object, e As EventArgs) Handles btnFessClass.Click


        Try
            ClassListTableAdapter.FillByClass(DsSchool.ClassList, cboFeesProgSearch.SelectedValue, cbofeesLvlsearch.Text, cbofeessessSearch.Text, cbofeesClassSearch.Text, "", False, Now.Date, Now.Date)
            txtPos.Text = ClassListBindingSource.Position + 1 & "of " & ClassListBindingSource.Count
            '   cboReceiptSearch.Text = "Student"
            txtReceiptSearch.Text = lbFeesHidedStudID.Text
            '       FeesPayments_HeaderTableAdapter.FillByStudent(DsSchool.FeesPayments_Header, txtReceiptSearch.Text, cboFeesCartegory.Text)

            lbSeacrhFees.Visible = False
        Catch ex As Exception

        End Try
    End Sub



    Private Sub dgFessDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFessDetails.CellClick
        If e.ColumnIndex = 6 Then
            If MsgBox("This will delete line " & e.RowIndex + 1 & ", do you want to continue?", vbYesNoCancel) = vbYes Then

                With dgFessDetails.Rows(e.RowIndex)
                    deleteFeesLine(.Cells("lineref").Value.ToString, ReceiptTextBox.Text, e.RowIndex + 1)
                End With
                Feespayments_detailsTableAdapter.FillByReceipt(DsSchool.feespayments_details, ReceiptTextBox.Text, cboFeesCartegory.Text)
            End If
            FeesloadingMode()
            RefreshFeesStatement()
        ElseIf e.ColumnIndex = 5 Then
            Dim recline As New CFeesLines()



            With dgFessDetails.Rows(e.RowIndex)
                recline.LineRef = IIf(.Cells("lineref").Value.ToString = "", Guid.NewGuid.ToString, .Cells("lineref").Value.ToString)
                recline.Receipt = ReceiptTextBox.Text
                recline.Amnt = .Cells("Amnt").Value
                recline.Currency = .Cells("currency").Value
                recline.Cartegory = .Cells("Cart").Value
                recline.Ref = .Cells("Ref").Value
                recline.Period = .Cells("Perd").Value
                recline.Linenumber = e.RowIndex + 1
                recline.TransType = IIf(Mid(recline.Receipt, 1, 3) = "Rec", "R", "I")
                recline.Comment = ""
                Date.TryParse(mskpaydate.Text, recline.RecDate)
                UpdateFeesLines(recline)

                Feespayments_detailsTableAdapter.FillByReceipt(DsSchool.feespayments_details, ReceiptTextBox.Text, cboFeesCartegory.Text)

            End With

            FeesloadingMode()
            RefreshFeesStatement()

        End If
    End Sub
    Private Sub deleteFeesLine(lineref As String, receipt As String, linenumber As String)
        Dim cmd As New SqlCommand
        cnn = New SqlConnection(ConnectionString)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.CommandText = "spDeletePaymentDetailsline"
        cmd.Connection = cnn


        param = New SqlParameter("@receipt", receipt)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@user", gouser.userName)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@lineref", lineref)
        cmd.Parameters.Add(param)

        Try
            cnn.Open()

            cmd.ExecuteNonQuery()
            MsgBox("Receipt line " & linenumber & " successfully cancelled")

            '   Feespayments_detailsTableAdapter.FillByReceipt(DsSchool.feespayments_details, receipt)
        Catch ex As Exception
            MsgBox("Error Cacelling receipt line " & linenumber & vbNewLine & ex.Message)


        Finally
            cnn.Close()
        End Try





    End Sub

    Private Sub UpdateFeesLines(recline As CFeesLines)
        Dim cmd As New SqlCommand
        cnn = New SqlConnection(ConnectionString)
        With recline


            cmd.CommandType = CommandType.StoredProcedure

            cmd.CommandText = "spInsertFeesDetails"
            cmd.Connection = cnn


            param = New SqlParameter("@recnumber", .Receipt)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@amount", .Amnt)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@currency", .Currency)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@cart", .Cartegory)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@period", .Period)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@ref", .Ref)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@line", .Linenumber)
            cmd.Parameters.Add(param)



            param = New SqlParameter("@comment", .Comment)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@transtype", .TransType)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@lineref", .LineRef)
            cmd.Parameters.Add(param)


            param = New SqlParameter("@user", gouser.userName)
            cmd.Parameters.Add(param)

            param = New SqlParameter("@recdate", .RecDate)
            cmd.Parameters.Add(param)


            Try
                cnn.Open()

                cmd.ExecuteNonQuery()
                MsgBox("Receipt line " & .Linenumber & " successfully updated")

            Catch ex As Exception
                MsgBox("Error updating receipt line " & .Linenumber & vbNewLine & ex.Message)
            Finally
                cnn.Close()
            End Try
        End With
    End Sub

    Private Sub btnUpdateAllLines_Click(sender As Object, e As EventArgs) Handles btnUpdateAllLines.Click

        For Each row As DataGridViewRow In dgFessDetails.Rows
            With row
                If .Selected Then
                    Dim recline As New CFeesLines
                    recline.LineRef = IIf(.Cells("lineref").Value = "", Guid.NewGuid, .Cells("lineref").Value)
                    recline.Receipt = ReceiptTextBox.Text
                    recline.Amnt = .Cells("Amount").Value
                    recline.Currency = .Cells("currency").Value
                    recline.Cartegory = .Cells("cartegory").Value
                    recline.Ref = .Cells("reference").Value
                    recline.Period = .Cells("Period").Value
                    recline.Linenumber = .Index + 1
                    recline.TransType = IIf(Mid(recline.Receipt, 1, 3) = "Rec", "R", "I")

                    UpdateFeesLines(recline)
                End If
            End With
            '     Feespayments_detailsTableAdapter.FillByReceipt(DsSchool.feespayments_details, ReceiptTextBox.Text)




        Next

        Feespayments_detailsTableAdapter.FillByReceipt(DsSchool.feespayments_details, ReceiptTextBox.Text, cboFeesCartegory.Text)
        FeesloadingMode()
        RefreshFeesStatement()
    End Sub

    Private Sub btnCancelAllLines_Click(sender As Object, e As EventArgs) Handles btnCancelAllLines.Click
        If mblnEdtFess Then

            If MsgBox("This will delete all the highlighted lines, do you want to continue?", vbYesNo) = vbYes Then

                For Each row As DataGridViewRow In dgFessDetails.Rows()

                    With row
                        If .Selected Then
                            deleteFeesLine(.Cells("lineref").Value.ToString, ReceiptTextBox.Text, .Index + 1)
                        End If
                    End With

                Next

                Feespayments_detailsTableAdapter.FillByReceipt(DsSchool.feespayments_details, ReceiptTextBox.Text, "All")
                FeesloadingMode()
                RefreshFeesStatement()
            End If
        End If
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles btnBillingClass.Click
        Dim cmd As New SqlCommand
        Dim cnn As SqlConnection = New SqlConnection(ConnectionString())

        cmd.CommandText = "FillAllStuds"

        cmd.Connection = cnn
        cmd.CommandType = CommandType.StoredProcedure

        params = New List(Of SqlParameter)


        param = New SqlParameter("@prog", cboBillingProg.SelectedValue)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@year", cboBillingLevel.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@sess", cboBillingSess.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@classdesc", cboBillingClass.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@filter", "")
        cmd.Parameters.Add(param)


        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing



        cnn.Open()

        ' Dim sql As String = "Select FirstName + '' + LastName as Student ,AppReference , DateSubmitted,Class,Intake,program,campus,email,level,sem,session from studentapplication where email = '" & email & "' and appstatus = 'Approved'  and apllicationAccepted = 1 and StudentIDAssigned =  0  "

        Try


            taApps = New SqlDataAdapter(cmd)



            taApps.Fill(dsApps)



            If dsApps.Tables(0).Rows.Count > 0 Then
                dgBilling.DataSource = dsApps.Tables(0)

            Else
                dgBilling.DataSource = dsApps.Tables(0)
                MsgBox("No Students in the Selected Class")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try

    End Sub

    Private Sub btnMarkClass_Click(sender As Object, e As EventArgs) Handles btnMarkClass.Click
        gdStudents.DataSource = fillAllMarks().Tables(0)
    End Sub

    Private Sub btnLeavingStudent_Click(sender As Object, e As EventArgs) Handles btnLeavingStudent.Click

        Dim reason, comment As String

        Dim dateleft As Date
        Dim enrolref As String


        Dim cnn As SqlConnection

        If chkoldclass.CheckedItems.Count > 0 Then
            Dim dgLeavingStud As New dgLeavingStudent()
            With dgLeavingStud
                .mskDateLeft.Text = Now.Date.ToShortDateString
                .ShowDialog()
            End With


            If dgLeavingStud.DialogResult = DialogResult.OK Then

                With dgLeavingStud
                    reason = .cboReason.Text
                    Date.TryParse(.mskDateLeft.Text, dateleft)
                    comment = .txtLeavingComment.Text
                End With

                For Each itm In chkoldclass.CheckedItems
                    Try


                        Dim stud = New cEnrol(cboOldClassCls.Text, CleanComboVal(itm.ToString))
                        enrolref = stud.EnrolRef
                        Dim cmd As New SqlCommand
                        cnn = New SqlConnection(ConnectionString)
                        cnn.Open()
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnn
                        cmd.CommandText = "spInsertLeavingStudent"
                        cmd.Parameters.AddWithValue("@stud", CleanComboVal(itm.ToString))
                        cmd.Parameters.AddWithValue("@reason", reason)
                        cmd.Parameters.AddWithValue("@dateleft", dateleft)
                        cmd.Parameters.AddWithValue("@comment", comment)
                        cmd.Parameters.AddWithValue("@enrolref", enrolref)

                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error saving information for " & itm.ToString & vbNewLine & ex.Message)
                    Finally
                        cnn.Close()

                    End Try
                Next

                MsgBox("Leaving Student Data succeffully saved for the selected Students")


            End If

        Else
            MsgBox("Select at least one student who is leaving the institution")
        End If




    End Sub

    Private Sub cboMarkClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarkClass.SelectedIndexChanged
        loadExams()

    End Sub

    Private Sub cboOldClassprog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOldClassprog.SelectedIndexChanged

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs)

        lbStudDeactivationSearch.DataSource = Nothing


        Dim cmd As New SqlCommand
        Dim cnn As SqlConnection = New SqlConnection(ConnectionString())

        cmd.CommandText = "FillAllStuds"

        cmd.Connection = cnn
        cmd.CommandType = CommandType.StoredProcedure

        params = New List(Of SqlParameter)

        Dim filter As String = " and concat(studentpersonaldetails.studentid,studentname,studentsurname) like '%" & txtDeactivationStudSearch.Text & "%' and enrollment.status = 'available'"


        param = New SqlParameter("@prog", cboOldClassprog.SelectedValue)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@year", cboOldclassForm.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@sess", cboOldClassSess.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@classdesc", cboOldClassCls.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@filter", filter)
        cmd.Parameters.Add(param)


        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing


        Try
            cnn.Open()

            ' Dim sql As String = "Select FirstName + '' + LastName as Student ,AppReference , DateSubmitted,Class,Intake,program,campus,email,level,sem,session from studentapplication where email = '" & email & "' and appstatus = 'Approved'  and apllicationAccepted = 1 and StudentIDAssigned =  0  "




            taApps = New SqlDataAdapter(cmd)



            taApps.Fill(dsApps)



            If dsApps.Tables(0).Rows.Count > 0 Then
                lbStudDeactivationSearch.Visible = True
                lbStudDeactivationSearch.DataSource = dsApps.Tables(0)
                lbStudDeactivationSearch.DisplayMember = "StudName"
                lbStudDeactivationSearch.ValueMember = "StudentID"

            Else
                lbStudDeactivationSearch.DataSource = dsApps.Tables(0)
                '     MsgBox("No Students in the Selected Class")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        txtDeactivationStudSearch.Text = ""
        cboOldclassForm_SelectedIndexChanged(cboOldClassprog, Nothing)
        'lbStudDeactivationSearch.Items.Clear()
        'searchStuds(txtSubSearch.Text, dgSubStuds)
        lbStudDeactivationSearch.Visible = False
    End Sub

    Private Sub cboOldClassCls_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOldClassCls.SelectedIndexChanged

    End Sub

    Private Sub cboOldClassSess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOldClassSess.SelectedIndexChanged

    End Sub

    Private Sub cboEnrlProgSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEnrlProgSearch.SelectedIndexChanged, cboEnrLevSearch.SelectedIndexChanged, CboEnrSessSearch.SelectedIndexChanged,
            cboEnrolClassSearch.SelectedIndexChanged

        If Not mblnaddingUser Then

            Try
                ClassListTableAdapter.FillByClass(dsSchool.ClassList, cboEnrlProgSearch.SelectedValue, cboEnrLevSearch.Text, CboEnrSessSearch.Text, cboEnrolClassSearch.Text, "", False, Now.Date, Now.Date)
            Catch ex As Exception

            End Try


        End If
    End Sub

    Private Sub cboSubClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubClass.SelectedIndexChanged


        With cboSubExam
            .DataSource = SchoolExams(cboSubClass.Text)
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim serchtext As String = Trim(ttxSearchtext.Text)
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

    Private Sub txtHiddenStudID_TextChanged(sender As Object, e As EventArgs) Handles txtHiddenStudID.TextChanged
        If Not mblnaddingUser And txtHiddenStudID.Text <> "" Then
            loadStudInfo(Trim(txtHiddenStudID.Text))
        End If
    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        enablestudscreen(True)
    End Sub

    Private Sub ttxSearchtext_TextChanged(sender As Object, e As EventArgs) Handles ttxSearchtext.TextChanged

    End Sub

    Private Sub Button3_Click_3(sender As Object, e As EventArgs) Handles Button3.Click
        Dim serchtext As String = Trim(txtSubStudsSearch.Text)
        StudEnrollmentSearch(lbSubStudSearch, serchtext)
    End Sub

    Private Sub txtSubSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSubSearch.TextChanged

    End Sub

    Private Sub cboSubExam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubExam.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton16_Click_1(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem_Click_1(Me, Nothing)
    End Sub

    Private Sub btnDeleteParent_Click(sender As Object, e As EventArgs) Handles btnDeleteParent.Click
        If Not mblnaddingUser Then

            If dgStudNok.SelectedRows.Count = 0 Then
                MsgBox("Select at least One Record")
                Exit Sub

            End If
            Dim cnn As New SqlConnection(ConnectionString)
            Dim sql As String = "spDelStudNok"
            Dim ref As String = dgStudNok.SelectedRows(0).Cells("NokRef").Value.ToString


            Try
                cnn.Open()
                Dim cmd As New SqlCommand(sql, cnn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@ref", ref)
                    .ExecuteNonQuery()
                    LoadStudNok(StudentIDTextBox.Text)
                    MsgBox("Record Deleted")
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()

            End Try
        Else
            If NokS.count > 0 Then

                NokS.removeat(dgStudNok.SelectedRows(0).Index)

                dgStudNok.DataSource = NokS

                MsgBox("Record Deleted")
            Else
                MsgBox("Select at least One Record")

            End If
        End If



    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Not mblnaddingUser Then

            If dgSiblings.SelectedRows.Count = 0 Then
                MsgBox("Select at least One Record")
                Exit Sub

            End If
            Dim cnn As New SqlConnection(ConnectionString)
            Dim sql As String = "spDeleteSibling"
            Dim ref As String = dgSiblings.SelectedRows(0).Cells("SiblingID").Value.ToString


            Try
                cnn.Open()
                Dim cmd As New SqlCommand(sql, cnn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@stud", ref)
                    .ExecuteNonQuery()
                    loadSiblings(StudentIDTextBox.Text)
                    MsgBox("Record Deleted")
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()

            End Try
        Else
            If Sibs.count > 0 Then

                Sibs.removeat(dgSiblings.SelectedRows(0).Index)

                dgSiblings.DataSource = Sibs

                MsgBox("Record Deleted")
            Else
                MsgBox("Select at least One Record")

            End If
        End If


    End Sub

    Private Sub dgSubStuds_SelectionChanged(sender As Object, e As EventArgs) Handles dgSubStuds.SelectionChanged
        Dim sql As String
        Dim drr As SqlDataReader

        For i = 0 To Available_Subjects.Items.Count - 1
            Available_Subjects.SetItemChecked(i, False)

        Next


        Dim params As New List(Of SqlParameter)
        Dim param As SqlParameter

        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)
        Try

            lbSubs.Text = dgSubStuds.SelectedRows(0).Cells("StudentName").Value & " 'Subjects"
            cnn.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "spRetrieveStudentSubjects"
            cmd.Connection = cnn


            param = New SqlParameter("@stud", dgSubStuds.SelectedRows(0).Cells("SubjectsStudentID").Value)
            params.Add(param)
            Try
                param = New SqlParameter("@exam", cboSubExam.Text)
                params.Add(param)

            Catch ex As Exception
                param = New SqlParameter("@exam", "No Exam")
                params.Add(param)
            End Try

            param = New SqlParameter("@enrolref", dgSubStuds.SelectedRows(0).Cells("EnrolRef").Value)
            params.Add(param)

            For Each par As SqlParameter In params
                cmd.Parameters.Add(par)
            Next


            drr = cmd.ExecuteReader


            While drr.Read
                For i = 0 To Available_Subjects.Items.Count - 1
                    If drr(0) = CleanComboVal(Available_Subjects.Items(i).ToString) Then
                        Available_Subjects.SetItemChecked(i, True)
                    End If
                Next
            End While
        Catch ex As Exception
            '   MsgBox(ex.Message)

        Finally
            cnn.Close()


        End Try
    End Sub

    Private Sub dgFessDetails_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgFessDetails.RowsAdded
        'Try
        '    Dim paycartcombo As DataGridViewComboBoxCell = dgFessDetails.Rows(e.RowIndex).Cells("Cartegory")
        '    With paycartcombo
        '        .DataSource = PaymentTypes("SchoolFees")
        '        .DisplayMember = "Text"
        '        .ValueMember = "Value"
        '    End With
        'Catch ex As Exception

        'End Try

        'Try
        '    Dim payperiodcombo As DataGridViewComboBoxCell = dgFessDetails.Rows(e.RowIndex).Cells("Period")
        '    With payperiodcombo
        '        .DataSource = FeesPaymentPeriods()
        '        .DisplayMember = "Text"
        '        .ValueMember = "Value"
        '    End With
        'Catch ex As Exception

        'End Try

        'Try
        '    Dim currencycombo As DataGridViewComboBoxCell = dgFessDetails.Rows(e.RowIndex).Cells("Currency")
        '    With currencycombo
        '        .DataSource = Currencies()
        '        .DisplayMember = "Text"
        '        .ValueMember = "Value"
        '    End With
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txtFeesStudID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFeesStudID.KeyDown
        If e.KeyCode = Keys.Enter Then

            Button11_Click_3(Me, Nothing)

        End If
    End Sub

    Private Sub FeesStudSearch()
        cnn = New SqlConnection(ConnectionString)
        Try


            If mblnaddingFess Then
                cnn.Open()
                Dim serchtext As String = Trim(txtFeesStudID.Text)
                lbStudFees.DataSource = Nothing
                lbStudFees.DisplayMember = "StudName"
                lbStudFees.ValueMember = "StudentID"
                lbStudFees.Visible = True
                Dim cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandText = "spStudentSearch"
                cmd.CommandType = CommandType.StoredProcedure
                Dim filter As String = " where concat(s.studentid, studentname , studentsurname ) like '%" & serchtext & "%'"
                param = New SqlParameter("@filter", filter)
                cmd.Parameters.Add(param)
                Dim dsApps As New DataSet()
                Dim taApps As SqlDataAdapter = Nothing


                ' Dim sql As String = "Select FirstName + '' + LastName as Student ,AppReference , DateSubmitted,Class,Intake,program,campus,email,level,sem,session from studentapplication where email = '" & email & "' and appstatus = 'Approved'  and apllicationAccepted = 1 and StudentIDAssigned =  0  "




                taApps = New SqlDataAdapter(cmd)



                taApps.Fill(dsApps)





                lbStudFees.DataSource = dsApps.Tables(0)
                lbStudFees.DisplayMember = "StudName"
                lbStudFees.ValueMember = "StudentID"

            Else
                RefreshFeesStatement()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub lbFeesHidedStudID_TextChanged(sender As Object, e As EventArgs) Handles lbFeesHidedStudID.TextChanged
        txtReceiptSearch.Text = lbFeesHidedStudID.Text
        Loadstudent(lbFeesHidedStudID.Text)
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles btnStudBillingStudentSearch.Click
        Dim serchtext As String = Trim(txtBillStud.Text)
        StudEnrollmentSearch(lbBillStud, serchtext)
    End Sub

    Private Sub Button11_Click_2(sender As Object, e As EventArgs) Handles btnStudentMarksSearch.Click
        Dim serchtext As String = Trim(txtStudMarksSearch.Text)
        StudEnrollmentSearch(lbStudMarks, serchtext, True)
    End Sub

    Private Sub cboMarkSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarkSession.SelectedIndexChanged

    End Sub

    Private Sub cboMarkSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarkSubject.SelectedIndexChanged
        gdStudents_SelectionChanged(Me, Nothing)
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs)
        If txtstudsearch.Text = "" Then
            lbstuds.Visible = False
        Else
            lbstuds.Visible = True
        End If


        'Try


        '    Dim serchtext As String = Trim(txtstudsearch.Text)
        '    lbstuds.DataSource = Nothing


        '    Dim filter As String = " and concat(studentpersonaldetails.studentid ,studentname , studentsurname) like '%" & serchtext & "%'"



        '    lbstuds.DataSource = fillAllMarks(filter).Tables(0)
        '    lbstuds.DisplayMember = "StudName"
        '    lbstuds.ValueMember = "StudentID"





        'Catch ex As Exception
        '    MsgBox(ex.Message)


        'End Try

    End Sub

    Private Sub lbStudDeactivationSearch_DoubleClick(sender As Object, e As EventArgs) Handles lbStudDeactivationSearch.DoubleClick
        Dim searchtext As String = lbStudDeactivationSearch.GetItemText(lbStudDeactivationSearch.SelectedItem)
        chkoldclass.Items.Clear()
        Dim stud As String
        stud = lbStudDeactivationSearch.SelectedValue
        txtDeactivationStudSearch.Text = stud

        chkoldclass.Items.Add(stud & "-" & searchtext)
        lbStudDeactivationSearch.Visible = False
        lbStudDeactivationSearch.DataSource = Nothing

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs)
        If txtStudBillSearch.Text = "" Then
            lbBillSearch.Visible = False
        Else
            lbBillSearch.Visible = True
        End If

        Dim filter As String = " and studentpersonaldetails.studentid + ' ' + studentname + ' ' + studentsurname like '%" & txtStudBillSearch.Text & "%'"

        Dim cmd As New SqlCommand
        Dim cnn As SqlConnection = New SqlConnection(ConnectionString())

        cmd.CommandText = "FillAllStuds"

        cmd.Connection = cnn

        params = New List(Of SqlParameter)


        param = New SqlParameter("@prog", cboSubProg.SelectedValue)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@year", cboSubLvl.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@sess", cboSubSess.Text)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@classdesc", cboSubClass.SelectedValue)
        cmd.Parameters.Add(param)

        param = New SqlParameter("@filter", filter)
        cmd.Parameters.Add(param)


        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing



        cnn.Open()

        ' Dim sql As String = "Select FirstName + '' + LastName as Student ,AppReference , DateSubmitted,Class,Intake,program,campus,email,level,sem,session from studentapplication where email = '" & email & "' and appstatus = 'Approved'  and apllicationAccepted = 1 and StudentIDAssigned =  0  "

        Try


            taApps = New SqlDataAdapter(cmd)



            taApps.Fill(dsApps)


            lbBillSearch.DataSource = dsApps.Tables(0)





        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub txtStudBillSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudBillSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbBillSearch.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            Button33_Click(Me, Nothing)
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles btnStudSearchPanel.Click
        SetSearchPanelVisibility(sender, SplitContainer1)
    End Sub

    Private Sub SetSearchPanelVisibility(btn As Button, pnl As SplitContainer)
        If pnl.Panel1.Visible Then
            pnl.Panel1.Visible = False
            pnl.Panel2.Dock = DockStyle.Fill
            btn.Text = "View Search Panel"
        Else
            pnl.Panel1.Visible = True
            pnl.Panel2.Dock = DockStyle.None
            btn.Text = "Hide Search Panel"
        End If
    End Sub

    Private Sub btnSubSearchPanel_Click(sender As Object, e As EventArgs) Handles btnSubSearchPanel.Click
        SetSearchPanelVisibility(sender, SplitContainer2)
    End Sub

    Private Sub Button34_Click_1(sender As Object, e As EventArgs) Handles Button34.Click
        SetSearchPanelVisibility(sender, SplitContainer5)
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        SetSearchPanelVisibility(sender, SplitContainer8)
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        SetSearchPanelVisibility(sender, SplitContainer4)
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        SetSearchPanelVisibility(sender, SplitContainer10)
    End Sub

    Private Sub lnkRemoveImage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRemoveImage.LinkClicked
        ImagePictureBox.Image = Nothing
        lnkRemoveImage.Visible = False
    End Sub

    Private Sub gvMarks_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles gvMarks.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        If Boardingmasters.Count > 0 Then



            If gdStudents.SelectedRows.Count > 0 Then

                Dim headscreen As New DgBoardingMaster
                headscreen.classstuds = fillAllMarks()
                headscreen.Exam = cboMarkExam.Text
                headscreen.studid = gdStudents.SelectedRows(0).Cells(0).Value


                headscreen.Show()

            Else
                MsgBox("Select Student")
            End If
        Else
            MsgBox("No BoardingMaster's maintained in the System")
        End If

    End Sub

    Private Sub gvMarks_KeyDown(sender As Object, e As KeyEventArgs) Handles gvMarks.KeyDown
        'If gvMarks.CurrentCell.Tag = "Comment" Or gvMarks.CurrentCell.Tag = "ExamMark" Then



        '    If e.KeyCode = Keys.Tab Then
        '        If gvMarks.CurrentRow.Index = gvMarks.Rows.Count - 2 And gvMarks.CurrentCell.Tag = "Remarks" Then
        '            gvMarks.CurrentCell = gvMarks.Rows(0).Cells("Subject")

        '        Else

        '            If gvMarks.CurrentCell.Tag = "Remarks" Then

        '                If gvMarks.Rows(gvMarks.CurrentRow.Index + 1).Cells(0).Value = "True" Then
        '                    gvMarks.CurrentCell = gvMarks.Rows(gvMarks.CurrentRow.Index + 1).Cells("Subject")
        '                End If

        '            End If
        '        End If
            If e.KeyCode = Keys.F2 Then
            If gvMarks.CurrentCell.Tag = "Comment" And gvMarks.CurrentRow.Cells("Check").Value = "True" Then
                Dim dgsubcomment As New dgSubjectComment()
                With dgsubcomment

                    If blnMultiComment Then

                        .txtComment.Text = gvMarks.CurrentRow.Cells("MultiComment").Value


                    Else

                        .txtComment.Text = gvMarks.CurrentRow.Cells("Comment").Value

                    End If
                    .lbComment.Text = gvMarks.CurrentRow.Cells("Subject").Value & "'s Comment"
                    .txtComment.ReadOnly = blnMultiComment


                    .ShowDialog()

                    If .DialogResult = DialogResult.OK Then
                        If Not blnMultiComment Then
                            gvMarks.CurrentRow.Cells("Comment").Value = .txtComment.Text
                        End If
                    End If
                End With

            End If
        End If



    End Sub

    Private Sub gvMarks_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles gvMarks.CellValidated
        Dim comments As New List(Of String)
        Dim EM As Double
        Dim program As String = ""
        program = cboMarkProg.Text

        If blnMultiComment Then

            If gvMarks.Columns(e.ColumnIndex).HeaderText = "EM" Then
                EM = gvMarks.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                Dim cbocmnts As DataGridViewComboBoxCell

                cbocmnts = CType(gvMarks.Rows(e.RowIndex).Cells("MultiComment"), DataGridViewComboBoxCell)
                cbocmnts.Items.Clear()
                comments = GetGradeComments(program, EM)

                For Each cmm In comments
                    With cbocmnts
                        .Items.Add(cmm)
                    End With

                Next


            End If
        End If
    End Sub

    Private Function GetGradeComments(prog As String, EM As Double) As List(Of String)
        Dim comments As SqlDataReader

        Dim gradecomments As New List(Of String)
        sqltext = "sgGetGradeComment_screen"
        cnn = New SqlConnection(ConnectionString)
        Try
            cnn.Open()

            cmd = New SqlCommand(sqltext, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@mark", EM)
            cmd.Parameters.AddWithValue("@program", prog)
            comments = cmd.ExecuteReader

            While comments.Read
                gradecomments.Add(comments(0))
            End While

        Catch ex As Exception
        Finally
            cnn.Close()
        End Try

        Return gradecomments
    End Function

    Private Sub lbStudBehavior_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBehaviorClass.SelectedIndexChanged
        cboBehaviorPeriod.DataSource = Nothing
        loadExams()
    End Sub

    Private Sub btnAddBehavior_Click(sender As Object, e As EventArgs) Handles btnAddBehavior.Click
        Dim rows As Integer = dgStudBehavior.Rows.Count - 1

        Dim dtbehaviordate As Date

        Date.TryParse(mskBehaviorDate.Text, dtbehaviordate)
        If txtBehaviorRef.Text = "" Then

            dgStudBehavior.Rows.Add()
            rows += 1
            lbBehaviorRecourCount.Text = CInt(lbBehaviorRecourCount.Text) + 1
        Else
            rows = txtBehaviorRef.Text
        End If


        With dgStudBehavior.Rows(rows)

                .Cells("BehaviorStudent").Value = Trim(txtBehaviorStud.Text)
                .Cells("BehaviorClass").Value = cboBehaviorClass.Text
                .Cells("BehaviorType").Value = cboBehaviorType.Text
                .Cells("BehaviorSeverity").Value = cboBehaviorSeverity.Text
                .Cells("BehaviorDate").Value = dtbehaviordate
                .Cells("BehaviorDetails").Value = txtBehaviorDetails.Text
                .Cells("BehaviorPeriod").Value = cboBehaviorPeriod.Text
                .Cells("BehaviorEdit").Value = "Edit"
            .Cells("BehaviorView").Value = "Report"
            .Cells("BehaviorDelete").Value = "Delete"
            .DefaultCellStyle.BackColor = Color.Yellow

            Dim rptbutton As DataGridViewButtonCell = CType(.Cells("BehaviorView"), DataGridViewButtonCell)


        End With



        txtBehaviorRef.Text = ""




    End Sub

    Private Sub cboBehaviorType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBehaviorType.SelectedIndexChanged
        cboBehaviorSeverity.Items.Clear()
        If cboBehaviorType.Text = "Offence" Then
            cboBehaviorSeverity.Items.Add("Minor")
            cboBehaviorSeverity.Items.Add("Medium")
            cboBehaviorSeverity.Items.Add("Serious")
            cboBehaviorSeverity.Items.Add("Dismissable")
            cboBehaviorSeverity.SelectedIndex = 0
        ElseIf cboBehaviorType.Text = "Merit" Then
            cboBehaviorSeverity.Items.Add("Academic")
            cboBehaviorSeverity.Items.Add("Sport")
            cboBehaviorSeverity.Items.Add("Others")
            cboBehaviorSeverity.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnStudBeaviorSearch_Click(sender As Object, e As EventArgs) Handles btnStudBeaviorSearch.Click
        Dim serchtext As String = Trim(txtBehaviorStud.Text)
        lbStudBehavior.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)
        lbStudBehaviorName.Visible = False
        Try


            cnn.Open()

            Dim filter As String = " where concat(s.studentid , ' ' , studentname , ' ' , studentsurname) like '%" & serchtext & "%'"

            cmd.CommandText = "spMainScreenStudentSearch"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)



            lbStudBehavior.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lbStudBehavior.DataSource = dsApps.Tables(0)
            lbStudBehavior.DisplayMember = "StudName"
            lbStudBehavior.ValueMember = "StudentID"

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub lbStudBehavior_DoubleClick_1(sender As Object, e As EventArgs) Handles lbStudBehavior.DoubleClick
        Try

            txtBehaviorStud.Text = lbStudBehavior.SelectedValue
      '      lbStudBehaviorName.Text = lbStudBehavior.GetItemText(lbStudBehavior.SelectedItem)
            lbStudBehavior.DataSource = Nothing

            lbStudBehavior.Visible = False
            '     dgStudBehavior.Rows.Clear()
            '        LoadStudBehavior(Trim(txtBehaviorStud.Text))
            '     txtBehaviorRef.Text = ""

            txtBehaviorStud_Validated(txtBehaviorStud, Nothing)



        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadStudBehavior(stud As String)
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)
        Dim rows As Integer = 0

        sql = "spLoadStudBavior"

        Dim drr As SqlDataReader

        Dim behaviorRecords As Integer = 0


        Try


            cnn.Open()

            cmd = New SqlCommand(sql, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@stud", stud)
            drr = cmd.ExecuteReader
            While drr.Read
                dgStudBehavior.Rows.Add()
                behaviorRecords += 1
                With dgStudBehavior.Rows(rows)
                    .Cells("BehaviorStudent").Value = drr("Student")
                    .Cells("BehaviorClass").Value = drr("BehaviorClass")
                    .Cells("BehaviorType").Value = drr("BehaviorType")
                    .Cells("BehaviorSeverity").Value = drr("BehaviorSeverity")
                    .Cells("BehaviorDate").Value = drr("BehaviorDate")
                    .Cells("BehaviorDetails").Value = drr("BehaviorDetails")
                    .Cells("BehaviorRef").Value = drr("BehaviorReference")
                    .Cells("BehaviorPeriod").Value = drr("BehaviorPeriod")
                    .Cells("BehaviorEdit").Value = "Edit"
                    .Cells("BehaviorView").Value = "Report"
                    .Cells("BehaviorDelete").Value = "Delete"
                End With
                rows += 1
            End While



        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            lbBehaviorRecourCount.Text = behaviorRecords
            cnn.Close()

        End Try

    End Sub

    Private Sub txtBehaviorStud_Validated(sender As Object, e As EventArgs) Handles txtBehaviorStud.Validated, mskBehaviorDate.Validated, txtBehaviorDetails.TextChanged, cboBehaviorClass.SelectedIndexChanged, cboBehaviorSeverity.SelectedIndexChanged, cboBehaviorType.SelectedIndexChanged
        Dim behaviordate As Date

        Dim datepassed As Boolean = False
        datepassed = Date.TryParse(mskBehaviorDate.Text, behaviordate)

        If sender.GetType = GetType(TextBox) Then
            Dim ctrl As TextBox = sender
            Select Case ctrl.Name
                Case txtBehaviorStud.Name
                    dgStudBehavior.Rows.Clear()
                    LoadStudBehavior(Trim(txtBehaviorStud.Text))
                    txtBehaviorRef.Text = ""
                    lbStudBehaviorName.Visible = True
            End Select
        End If



        If Trim(txtBehaviorStud.Text) <> "" And datepassed And Trim(txtBehaviorDetails.Text) <> "" And cboBehaviorSeverity.Text <> "" And cboBehaviorType.Text <> "" And cboBehaviorClass.Text <> "" And cboBehaviorPeriod.Text <> "" And ValidStud(Trim(txtBehaviorStud.Text)) Then
            btnAddBehavior.Enabled = True
            btnAddBehavior.BackColor = Color.Green
            btnAddBehavior.ForeColor = Color.White
        Else
            btnAddBehavior.Enabled = False
            btnAddBehavior.BackColor = Color.Transparent
            btnAddBehavior.ForeColor = Color.Black
        End If
    End Sub

    Private Function ValidStud(id As String) As Boolean
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Dim Studname As String = ""

        sql = "ValidID"

        Try


            cnn.Open()

            cmd = New SqlCommand(sql, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@type", "Student")
            Studname = cmd.ExecuteScalar

            Return True
        Catch ex As Exception
            Return False

        Finally
            lbStudBehaviorName.Text = Studname
            cnn.Close()

        End Try



    End Function

    Private Sub dgStudBehavior_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgStudBehavior.CellClick

    End Sub

    Private Sub dgStudBehavior_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgStudBehavior.CellContentClick
        Dim indx As Integer = dgStudBehavior.CurrentRow.Index

        Try
            Cursor = Cursors.WaitCursor
            If dgStudBehavior.CurrentCell.Value = "Edit" Then

                If txtBehaviorRef.Text <> "" Then
                    If txtBehaviorRef.Text <> indx Then

                        If MsgBox("Another Record is currently being edited,Yes to Abort Editing of that row and Load Current Row", vbYesNo) = vbYes Then
                            dgStudBehavior.Rows(txtBehaviorRef.Text).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
                            RemoveBehaviorRow(indx)
                        Else

                        End If
                    Else


                        RemoveBehaviorRow(indx)
                    End If
                Else
                    RemoveBehaviorRow(indx)

                End If


            ElseIf dgStudBehavior.CurrentCell.Value = "Delete" Then
                If MsgBox("Delete Record?", vbYesNo) = vbYes Then
                    DeleteBehaviorRow(indx)
                End If

            ElseIf dgStudBehavior.CurrentCell.Value = "Report" Then
                If IsNothing(dgStudBehavior.CurrentRow.Cells("BehaviorRef").Value) Then
                    MsgBox("Behavior Report cannot be viewed,Record has not yet been commited to the database.")
                Else

                    Dim rptviewer As New frmReportPreview
                    With rptviewer
                        .BehaviorReport = True
                        .BehaviorReference = dgStudBehavior.CurrentRow.Cells("BehaviorRef").Value.ToString
                        .ShowDialog()
                    End With
                End If


            End If
        Catch ex As Exception
        Finally
            Cursor = Cursors.Default

        End Try


    End Sub


    Private Sub DeleteBehaviorRow(indx As Integer)
        With dgStudBehavior.Rows(indx)
            .Visible = False
            MsgBox("Row Deleted, save to commit changes.")
            lbBehaviorRecourCount.Text = CInt(lbBehaviorRecourCount.Text) - 1

        End With

    End Sub
    Private Sub RemoveBehaviorRow(indx As Integer)

        With dgStudBehavior.Rows(indx)
            txtBehaviorStud.Text = .Cells("BehaviorStudent").Value
            cboBehaviorClass.Text = .Cells("BehaviorClass").Value

            cboBehaviorPeriod.Text = .Cells("BehaviorPeriod").Value
            cboBehaviorType.Text = .Cells("BehaviorType").Value
            cboBehaviorSeverity.Text = .Cells("BehaviorSeverity").Value
            mskBehaviorDate.Text = .Cells("BehaviorDate").Value
            txtBehaviorDetails.Text = .Cells("BehaviorDetails").Value
            If Not IsNothing(.Cells("BehaviorRef").Value) Then
                txtBehaviorRef.Text = indx
                .DefaultCellStyle.BackColor = Color.Yellow
            Else
                txtBehaviorRef.Text = ""
                dgStudBehavior.Rows.RemoveAt(indx)
                lbBehaviorRecourCount.Text = CInt(lbBehaviorRecourCount.Text) - 1
            End If

        End With

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBehaviorRef.TextChanged
        If Trim(txtBehaviorRef.Text <> "") Then
            btnAddBehavior.Text = "Update Behavior"
        Else
            btnAddBehavior.Text = "Add Behavior"
        End If
    End Sub

    Private Sub txtBehaviorStud_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBehaviorStud.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbStudBehavior.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            btnStudBeaviorSearch_Click(Me, Nothing)
        End If
    End Sub

    Private Sub txtStudRef_TextChanged(sender As Object, e As EventArgs) Handles txtStudRef.TextChanged

    End Sub

    Private Sub Button11_Click_3(sender As Object, e As EventArgs) Handles Button11.Click
        Dim serchtext As String = Trim(txtFeesStudID.Text)
        StudEnrollmentSearch(lbStudFees, serchtext)
    End Sub

    Private Sub txtFeesStudID_TextChanged(sender As Object, e As EventArgs) Handles txtFeesStudID.TextChanged

    End Sub

    Private Sub tvEnrol_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvEnrol.AfterSelect
        Dim drr As SqlDataReader = Nothing
        If e.Node.Tag = "Program" Then
            e.Node.Nodes.Clear()
            Dim sql As String = "select e.program,e.year,e.session,e.classdesc,e.enrolref from enrollment E  " &
                " inner join classes  C on c.Description = e.classdesc " &
" where e.program = '" & e.Node.Text & "' and e.studentid = '" & StudentIDTextBox.Text & "' order by c.clas desc ,e.year desc,c.sem desc "
            drr = ExecuteReader(sql, True)
            Dim cnt As Integer = 0
            While drr.Read
                tvEnrol.SelectedNode.Nodes.Add(drr(1) & "." & drr(2) & "-" & drr(3))
                tvEnrol.SelectedNode.Nodes(cnt).Tag = drr(4).ToString
                tvEnrol.SelectedNode.Nodes(cnt).ContextMenuStrip = ctxEnrollment
                cnt += 1
            End While
        Else




        End If
        tvEnrol.ExpandAll()
    End Sub

    Private Sub tvEnrol_DoubleClick(sender As Object, e As EventArgs) Handles tvEnrol.DoubleClick, cxtToolEditEnrollment.Click
        Dim studentid
        Dim enrolref As String
        Try
            If tvEnrol.SelectedNode.Text <> "" Then

                studentid = StudentIDTextBox.Text
                enrolref = tvEnrol.SelectedNode.Tag
                '   Dim enrol As New Enrol()

                With enrollment
                    .Student = studentid
                    .enrolref = enrolref
                End With


                Dim enrolform As New frmEditEnrollment()

                With enrolform
                    .mdiPrnt = mainform
                    .loadspec = True
                    .ShowDialog()
                End With

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cxtToolDeleteEnrollment_Click(sender As Object, e As EventArgs) Handles cxtToolDeleteEnrollment.Click
        If MsgBox("Delete Enrollment?", vbYesNo) = vbYes Then

            Dim sql As String = "delete enrollment where enrolref = '" & tvEnrol.SelectedNode.Tag & "'"
            ExecuteNonQuery(sql,, True)
            If era Then
                MsgBox(eramsg)
                Exit Sub
            End If

            StudentIDTextBox_TextChanged(Me, Nothing)
        End If
    End Sub

    Private Sub cxtToolCopyEnrollment_Click(sender As Object, e As EventArgs) Handles cxtToolCopyEnrollment.Click
        Dim items(2) As String

        Dim classdetails(2)
        Dim studentid
        Dim enrolref As String

        Dim reader As SqlDataReader

        Dim cnn As New SqlConnection(ConnectionString)
        Try
            If tvEnrol.SelectedNode.Text <> "" Then

                studentid = StudentIDTextBox.Text
                enrolref = tvEnrol.SelectedNode.Tag

                Dim sql As String = "Select * from enrollment where studentid = '" & studentid & "' and enrolref = '" & enrolref & "'"

                Try
                    Dim cmd As New SqlCommand(sql, cnn)
                    cnn.Open()
                    With cmd
                        .CommandType = CommandType.Text
                        reader = .ExecuteReader()

                        While reader.Read
                            enrollment = New Enrol()
                            With enrollment
                                .Student = reader("StudentID")
                                .Program = reader("Program")
                                .Session = reader("Session")
                                .Level = reader("Year")
                                '            .Intake = reader("Intake")
                                '     .Clas = reader("YearEnrolled")

                                'Try
                                '    .Center = reader("Center")
                                'Catch ex As Exception
                                '    .Center = "Harare"
                                'End Try
                                Try
                                    .enrolref = reader("EnrolRef").ToString
                                Catch ex As Exception
                                    .enrolref = ""
                                End Try

                                Try
                                    .gender = reader("Gender")
                                Catch ex As Exception
                                    .gender = "M"
                                End Try

                                Try
                                    .Status = reader("Status")
                                Catch ex As Exception
                                    .Status = "Available"
                                End Try

                                .Clas = reader("Classdesc")
                                .Session = reader("session")

                            End With

                        End While

                    End With
                Catch ex As Exception

                End Try



                '   Dim enrol As New Enrol()



                Dim enrolform As New frmEditEnrollment()
                With enrolform
                    .mdiPrnt = mainform
                    .Copy = True
                    .Show()
                End With

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStudProfile_Click(sender As Object, e As EventArgs) Handles btnStudProfile.Click

        Dim frmStudprof As New frmStudentProfile
        Try
            Cursor = Cursors.WaitCursor
            With frmStudprof
                .StudentID = StudentIDTextBox.Text
                .StudentFullName = StudentSurnameTextBox.Text & " " & StudentNameTextBox.Text & " ( " & StudentIDTextBox.Text & " ) "
                .Text = .StudentFullName.ToUpper
                .ShowDialog()
            End With
        Catch ex As Exception
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub cboBBFCutOffPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBBFCutOffPeriod.SelectedIndexChanged
        RefreshFeesStatement()
    End Sub
    Private Sub cboBBFCutOffPeriotrad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkTransScreenShowInvoices.CheckedChanged, chkTransScreenShowReceipts.CheckedChanged
        RefreshFeesStatement()
        cboReceiptSearch_SelectedIndexChanged(Me, Nothing)

    End Sub
End Class
