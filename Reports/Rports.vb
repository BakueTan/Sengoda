Imports System
Imports System.Data.SqlClient
Imports System.Windows.Forms

Imports Miscelleneous

Public Class Rports
    Public frmMain As Form
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LoadExams()
        With cboHsMarksRef
            .DataSource = Exams()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadSessions()
        With cboHsMarksSess
            .DataSource = SchoolSessions(True)
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With cboAccSession
            .DataSource = SchoolSessions(True)
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With
        With cboStudClassSession
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With
    End Sub

    Private Sub LoadSections()
        With cboHsMarksSect
            .DataSource = SchoolSections()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With cboAccSection
            .DataSource = SchoolSections()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboSchoolEnrolSection
            .DataSource = SchoolSections()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub loadPrograms()
        With cboStudClasProgram
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub loadPaymentPeriods()
        With cboBBFCutOff
            .DataSource = FeesPaymentPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        For Each itm As ComboItem In cboBBFCutOff.Items
            If itm.Value = CurrentPaymentPeriod Then
                cboBBFCutOff.SelectedItem = itm
                Exit For
            End If

        Next


        With cboAccPerFrm
            .DataSource = FeesPaymentPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With cboAccPerTo
            .DataSource = FeesPaymentPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboFeesPayPfrpm
            .DataSource = FeesPaymentPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cbofeesPayPto
            .DataSource = FeesPaymentPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadPaymentCartegories()
        With cboAccPayType
            .DataSource = PaymentTypes("SchoolFees")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With cboPayperDateType
            .DataSource = PaymentTypes("SchoolFees")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadCashtypes()
        With cboPayPerDateMode
            .DataSource = CashTypes(True)
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

    End Sub

    Private Sub LoadUsers()
        With cboPayPerDaterUser
            .DataSource = UserLogins(True, True)
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadCurrencies()
        With cboFeesPayCurrency
            .DataSource = Currencies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadCombos()
        LoadExams()
        LoadSessions()
        LoadSections()
        loadPaymentPeriods()
        LoadPaymentCartegories()
        LoadClasses()
        LoadCashtypes()
        LoadUsers()
        LoadCurrencies()
        loadPrograms()
    End Sub

    Private Sub LoadClasses()
        With cboAccClass
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With cboSchoolEnrolClass
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With cboStudClassCls
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub


    Private Sub Rports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ValiantDataSet.schoolsections' table. You can move, or remove it, as needed.
        'Me.SchoolsectionsTableAdapter.Fill(Me.ValiantDataSet.schoolsections)


        Prepareform(Me, frmMain)
        InitReports()
        tvRpts.ExpandAll()
        SetNodes()
        LoadCombos()

        Dim lbl As TreeView
        Dim Nd, NdSub, NdSubSub, NdSubSubSub, ndsubsubsubsub, ndsubsubsubsubsub As TreeNode
        Nd = Nothing : NdSub = Nothing : NdSubSub = Nothing
        NdSubSubSub = Nothing
        lbl = tvRpts
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
                                For Each ndsubsubsubsub In NdSubSubSub.Nodes
                                    Try
                                        If Not IsNothing(ndsubsubsubsub.Tag) Then
                                            If ndsubsubsubsub.Tag.ToString = "-1" Then
                                                ndsubsubsubsub.Text = ""
                                            Else
                                                If ndsubsubsubsub.Tag.ToString <> "0" Then
                                                    Dim dr As SqlDataReader = Nothing
                                                    Dim sql As String = ""
                                                    sql = "Select Auth_HasAccess from " &
                                                          "dbo.UserAuthorisations where Auth_Group = '" & goUser.Group &
                                                          "' and Auth_AccComp = '" & ndsubsubsubsub.Tag.ToString & "'"
                                                    dr = ExecuteReader(sql, Nothing)
                                                    While dr.Read
                                                        If Not CBool(dr.Item(0)) Then ndsubsubsubsub.Text = ""
                                                    End While
                                                End If
                                            End If
                                        End If
                                    Catch ex As Exception
                                    End Try
                                    For Each ndsubsubsubsubsub In ndsubsubsubsub.Nodes
                                        Try
                                            If Not IsNothing(ndsubsubsubsubsub.Tag) Then
                                                If ndsubsubsubsubsub.Tag.ToString = "-1" Then
                                                    NdSubSubSub.Text = ""
                                                Else
                                                    If ndsubsubsubsubsub.Tag.ToString <> "0" Then
                                                        Dim dr As SqlDataReader = Nothing
                                                        Dim sql As String = ""
                                                        sql = "Select Auth_HasAccess from " &
                                                              "dbo.UserAuthorisations where Auth_Group = '" & goUser.Group &
                                                              "' and Auth_AccComp = '" & ndsubsubsubsubsub.Tag.ToString & "'"
                                                        dr = ExecuteReader(sql, Nothing)
                                                        While dr.Read
                                                            If Not CBool(dr.Item(0)) Then ndsubsubsubsubsub.Text = ""
                                                        End While
                                                    End If
                                                End If
                                            End If
                                        Catch ex As Exception
                                        End Try
                                    Next
                                Next
                            Next
                        Next
                    End If
                Catch ex As Exception
                End Try
            Next
        Next



    End Sub
    Private Sub loadsets()
        Try



            'TODO: This line of code loads data into the 'SchoolDataSet.PaymentType' table. You can move, or remove it, as needed.
            Me.PaymentTypeTableAdapter.Fill(Me.SchoolDataSet.PaymentType)
            'TODO: This line of code loads data into the 'SchoolDataSet.clubs' table. You can move, or remove it, as needed.
            Me.ClubsTableAdapter.Fill(Me.SchoolDataSet.clubs)
            'TODO: This line of code loads data into the 'DsStudentSearches.schoolsessions1' table. You can move, or remove it, as needed.
            Me.Schoolsessions1TableAdapter.Fill(Me.DsStudentSearches.schoolsessions1)
            'TODO: This line of code loads data into the 'SchoolDataSet.StudentMarks' table. You can move, or remove it, as needed.
            ' Me.StudentMarksTableAdapter.Fill(Me.SchoolDataSet.StudentMarks)
            'TODO: This line of code loads data into the 'SchoolDataSet.users' table. You can move, or remove it, as needed.
            Me.UsersTableAdapter.Fill(Me.SchoolDataSet.users)
            'TODO: This line of code loads data into the 'SchoolDataSet.CashType' table. You can move, or remove it, as needed.
            Me.CashTypeTableAdapter.Fill(Me.SchoolDataSet.CashType)






            Me.PaymentType1TableAdapter.Fill(Me.SchoolDataSet.PaymentType1)

            Me.ExamSessionsTableAdapter.Fill(Me.dsschool.ExamSessions)
            'TODO: This line of code loads data into the 'dsschool.schoolsessions' table. You can move, or remove it, as needed.
            Me.SchoolsessionsTableAdapter.Fill(Me.dsschool.schoolsessions)
            Me.PaymentPeriodsTableAdapter.Fill(Me.DsStudentSearches.PaymentPeriods)
            Me.SubjectsTableAdapter1.Fill(Me.DsStudentSearches.Subjects)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub chkAllYears_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllYears.CheckedChanged
        cboTransStudID.Enabled = Not chkAllYears.Checked
        cbTransSem.Enabled = False
        cbTransYear.Enabled = False
        'cbTransSem.Enabled = Not chkAllYears.Checked

        ' cboTransReg.Enabled = chkAllYears.Checked

    End Sub
    Private Sub InitReports()
        Try
            ' Me.StudentPersonalDetailsTableAdapter.Fill(Me.DsStudentSearches.StudentPersonalDetails)
            Me.SubjectsTableAdapter.Fill(Me.dsschool.Subjects)
            Me.FormsTableAdapter.Fill(Me.dsschool.forms)
            Me.SubjectsTableAdapter1.Fill(Me.DsStudentSearches.Subjects)
            '  Me.StudentFullNameTableAdapter.Fill(Me.DsStudentSearches.StudentFullName)
            Me.PaymentPeriods1TableAdapter.Fill(Me.DsStudentSearches.PaymentPeriods1)
            Me.PaymentPeriodsTableAdapter.Fill(Me.DsStudentSearches.PaymentPeriods)
            '  Me.StudentPersonalDetailsTableAdapter2.Fill(Me.dsschool.StudentPersonalDetails)
        Catch ex As Exception

        End Try


    End Sub
    Private Sub SetNodes()
        Dim Nd, NdSub, NdSubSub, NdSubSubSub, NdSubSubSubsub As TreeNode
        Nd = Nothing : NdSub = Nothing : NdSubSub = Nothing
        NdSubSubSub = Nothing
        For Each Nd In tvRpts.Nodes

            For Each NdSub In Nd.Nodes
                '  If Nd.Text = "Assessments" Then
                '  MsgBox(NdSub.Text)
                '  End If
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
    End Sub

    Private Sub tvRpts_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvRpts.AfterSelect
        gbStudProfile.Visible = False
        gbTrans.Visible = False
        gbBookIssues.Visible = False
        gbBookMaster.Visible = False
        'gbStudPersonalDetails.Visible = False
        gbStudSub.Visible = False
        gbExamBoardPassRates.Visible = False
        gbSubStuds.Visible = False
        gbStudClasses.Visible = False
        gbSchoolEnrollment.Visible = False
        gbSubjectPoints.Visible = False
        gbPersDetails.Visible = False
        gbDetailedMarks.Visible = False
        gbContactDetails.Visible = False
        gbHsStudMarks.Visible = False
        gbExamAttendance.Visible = False
        gbAccounts.Visible = False
        gbPaymentsPerDate.Visible = False
        gbLeftStudents.Visible = False
        gbSubjectsDropped.Visible = False
        'gbFeesPayments.Visible = False
        gbKnowHow.Visible = False
        gbStaffAssessment.Visible = False
        gbDepartmentalAssessment.Visible = False
        gbStaffRatings.Visible = False
        gbCollegeAssessment.Visible = False
        gbSubStuds.Visible = False
        gbSubjectsTaught.Visible = False
        gbGeneralanalysis.Visible = False
        gbSubjectRegister.Visible = False
        gbstudentregister2.Visible = False
        gbRegister3.Visible = False
        gbKnowhowAnalysis.Visible = False
        gbUserHistory.Visible = False
        gbIDcards.Visible = False
        gbStaffPersonalDetails.Visible = False
        gbStaffQualifictions.Visible = False
        gbSchoolProfile.Visible = False
        gbClassRegister.Visible = False
        gbStaffRegister.Visible = False
        gbIncomeExpenditure.Visible = False
        gbCreditors.Visible = False
        gbBorrowHistory.Visible = False
        gbDueBy.Visible = False
        gbExamGraphicalAnalysis.Visible = False
        gbSubjectsTaught.Visible = False
        Select Case tvRpts.SelectedNode.Text
            Case "StudentProfile"
                InitGroupBox(gbStudProfile, 526, 150)
            Case "Knowhow Analysis"
                InitGroupBox(gbKnowhowAnalysis, 492, 342)
            Case "Transcript"
                InitGroupBox(gbTrans, 600, 319)
                chkAllYears.CheckState = CheckState.Checked
            Case "Student Personal Details"
                ' InitGroupBox(gbPersDetails, 420, 162)
            Case "Student Subjects"
                InitGroupBox(gbStudSub, 435, 287)
                rbStudsubAll.Checked = CheckState.Checked
            Case "Subject Students"
                InitGroupBox(gbSubStuds, 644, 273)
                rbAllSubStuds.Checked = True
            Case "Class Students"
                InitGroupBox(gbStudClasses, 500, 251)
                cboClassStudsSex.Text = "All"
                'chkSex.CheckState = CheckState.Checked
            Case "School Enrollment"
                InitGroupBox(gbSchoolEnrollment, 556, 278)
                classList = New List(Of Enrol)
                lbAnalysisEnrols.Items.Clear()
                ' chkStatus.CheckState = CheckState.Checked
            Case "Subject Points"
                InitGroupBox(gbSubjectPoints, 297, 198)
            Case "FeesPayments"
                ' InitGroupBox(gbFeesPayments, 484, 121)
            Case "DetailedStudentMarks"
                InitGroupBox(gbDetailedMarks, 675, 326)
            Case "Contact Details"
                InitGroupBox(gbContactDetails, 476, 314)
                rbContactsPerStud.Checked = True
            Case "Exam Marks"
                InitGroupBox(gbHsStudMarks, 609, 209)
                rbHsReportPerClass.Checked = True
                gbGraphicalView.Visible = False
                Panel2.Enabled = True

            Case "GraphicalAnalysis"
                InitGroupBox(gbExamGraphicalAnalysis, 410, 154)
                rbHsMarksPerClass.Checked = True
            Case "ExamAttendance"
                InitGroupBox(gbExamAttendance, 397, 125)
            Case "Cumulative Payments"
                InitGroupBox(gbAccounts, 746, 331)
                rbClassStatement.Checked = True
            Case "PaymentsPerDate"
                InitGroupBox(gbPaymentsPerDate, 598, 224)
                rbFeesPayWithStudents.Checked = True


                ' cbDateAnalysis.CheckState = CheckState.Checked
            Case "LeftStudents"
                InitGroupBox(gbLeftStudents, 323, 137)
            Case "DroppedSubjects"
                InitGroupBox(gbSubjectsDropped, 473, 80)
            Case "KnowHow"
                InitGroupBox(gbKnowHow, 239, 82)
            Case "StaffAssessment"
                InitGroupBox(gbStaffAssessment, 417, 314)
                rbStaffAssPerClass.Checked = True
            Case "DepartmentalAssessment"
                InitGroupBox(gbDepartmentalAssessment, 368, 193)
            Case "Ratings"
                InitGroupBox(gbStaffRatings, 395, 199)
                chkBySection.Checked = True
            Case "CollegeAverage"
                InitGroupBox(gbCollegeAssessment, 315, 156)
            Case "StaffSubjectsTaught"
                InitGroupBox(gbSubjectsTaught, 348, 188)
            Case "CollegeGeneralAnalysis"
                InitGroupBox(gbGeneralanalysis, 348, 143)
            Case "LectureGeneralAnalysis"
                InitGroupBox(gbGeneralanalysis, 348, 143)
            Case "LecturerAllRatings"
                InitGroupBox(gbStaffRatings, 395, 199)
                chkBySection.Checked = True
            Case "SubjectRegister"
                InitGroupBox(gbSubjectRegister, 418, 264)
                rbSubRegPerStud.Checked = True
            Case "any report"
                InitGroupBox(gbstudentregister2, 317, 315)
            Case "Register3"
                InitGroupBox(gbRegister3, 350, 302)
            Case "UserLoginHistory"
                InitGroupBox(gbUserHistory, 347, 184)
                rbUserHisByUser.Checked = True

            Case "IDcards"
                InitGroupBox(gbIDcards, 431, 228)
                rbCardsPerClas.Checked = True
            Case "PassRatesAnalysis"
                InitGroupBox(gbExamBoardPassRates, 323, 129)
            Case "StaffPersonalDetails"
                InitGroupBox(gbStaffPersonalDetails, 362, 129)
                rbStaffContract.Checked = True
            Case "StaffQualifications"
                InitGroupBox(gbStaffQualifictions, 257, 96)
                rbQualByStaff.Checked = True
            Case "Profile"
                InitGroupBox(gbSchoolProfile, 257, 96)
                rbSchoolParticulars.Checked = True
            Case "ClassRegister"
                InitGroupBox(gbClassRegister, 387, 264)
                'rbSchoolParticulars.Checked = True
            Case "StaffRegister"
                InitGroupBox(gbStaffRegister, 394, 139)
            Case "BookDetails"

                InitGroupBox(gbBookMaster, 412, 111)
            Case "IncomeExpenditure"

                InitGroupBox(gbIncomeExpenditure, 441, 176)
            Case "BookIssues"
                InitGroupBox(gbBookIssues, 410, 105)
            Case "Creditors"
                InitGroupBox(gbCreditors, 382, 163)

            Case "DueBy"
                InitGroupBox(gbDueBy, 412, 111)
            Case "BorrowingHistory"
                InitGroupBox(gbBorrowHistory, 324, 171)
            Case "SubjectsTaught"
                InitGroupBox(gbSubjectsTaught, 432, 187)

        End Select

    End Sub
    Private Sub InitGroupBox(ByVal gB As GroupBox, Optional ByVal Wth! = 495,
                           Optional ByVal Hth! = 276, Optional ByVal cboExpand As ComboBox = Nothing)
        Try
            With gB
                .Width = Wth
                .Height = Hth
                .Left = (SplitContainer1.Panel2.Width - gB.Width) / 2
                .Top = (SplitContainer1.Panel2.Height - gB.Height) / 2
                .Visible = True
                btnPreview.Visible = True
            End With
        Catch
        End Try
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Cursor = Cursors.WaitCursor
        Try
            gstrTvSelNod = tvRpts.SelectedNode.Text

            Select Case gstrTvSelNod
                Case "StudentProfile"
                    gstrprofilestud = txtProfileStud.Text
                    gstrprofileperiod = cboProfilePeriod.SelectedValue
                '   gstrprofileexam = cboProfileExam.Text

                Case "Knowhow Analysis"
                    gstrknwhowanalprog = cboKhaprog.SelectedValue.ToString
                    gstrknwhowanalclass = cboKhaclass.Text
                    gstrknwhowanallevl = cboKhalev.Text
                    gstrknwhowanalsem = cboKhaclass.Text

                    gstrknwhowanalintak = cboKhaintak.Text
                    gstrknwhowanalsess = cboKhasess.Text




                Case "Transcript"
                    gstrSlectedprog = cbTransProg.SelectedValue.ToString
                    gstrSelectedYear = cbTransYear.Text
                    gstrSelectedSem = cbTransSem.Text
                    transyears = chkAllYears.Checked
                    gstrTransRef = cboTransReg.Text
                    gstrTrsnsClass = cboTransClass.Text
                    gstrtransintake = cboTransIntk.Text
                    gstrSlectedStudID = cboTransStudID.Text

                Case "Student Subjects"
                    gstrSubSlctedStud = cbostudsubStudid.Text
                    gstrSubSlctdSem = cboStudSubSem.Text
                    gstrSubSlctdYear = cboStudSubLvl.Text
                    gstrSubSlctdProg = cboStudSubProg.SelectedValue.ToString
                    gstrsubSlctdClass = cboStudSubCls.Text
                    gstrSubSlctdSess = cboStudSubSess.Text
                    gstrstudsubSect = cboSubStudSection.Text
                    subyears = rbStudsubAll.Checked
                    rbClassSubs = rbStudSubPerClass.Checked
                    rbSubSpec = rbStubSubPerSem.Checked
                '  gstrSubStudsSection = Trim(cboSubStudsSection.Text)


                Case "Cumulative Payments"
                    If cboAccPayType.Text = "" Then
                        MsgBox("Select Payment type ")
                        Exit Sub
                    End If



                    gstrAccClass = cboAccClass.Text
                    gstrAccLvl = cboAccLvl.Text
                    gstrAccPrdFrom = cboAccPerFrm.SelectedValue
                    gstrAccPrdTo = cboAccPerTo.SelectedValue
                    gblnAccPerSub = rbAccPerForm.Checked
                    'gblnAccPerClass = rbAccPerClass.Checked
                    gblnAccPerForm = rbAccPerForm.Checked
                    gblnAccDebtors = rbAccDebtors.Checked
                    gstrAccSection = cboAccSection.Text
                    gstrAccStud = txtAccStud.Text
                    'gblnAccPerStud = rbAccPerStud.Checked
                    gblnAccPerStud = rbStudStatement.Checked
                    gstrPayType = cboAccPayType.Text
                    gblnClassStat = rbClassStatement.Checked
                    gstraccAddinfo = rtxtAccAddinfo.Text

                    gstrAccSess = cboAccSession.Text
                    gblnDebtorsOnly = chkDebtorsOnly.Checked
                    gstrAccBBFCutOffPeriod = cboBBFCutOff.SelectedValue
                    gblnShowInvoices = chkAccShowInv.Checked
                    gblnShowReceipts = chkAccShoRec.Checked



                Case "Subject Students"
                    gstrSubStudsSlctdYear = cboSubStudsYera.Text
                    gstrSubStudsSlctID = cboSubStudsID.SelectedValue.ToString
                    gblnExamAtt = rbExamAttendance.Checked
                    gblnMarkSheet = RbMarkSheet.Checked
                    gstrmarksheetExam = cboMarkSheetExam.Text
                    gstrmarksheetProg = cboSubStudsProgram.SelectedValue.ToString
                    gstrmatrksheetintk = cboSubStudsIntake.Text
                    gblnCourseWek = rbCoursewek.Checked
                    gblnPerSubject = rbAllSubStuds.Checked
                    gblnPerProgram = rbSubByProg.Checked
                    gstrSubStudsSection = cboSubStudSection.Text
                    gstrsubstudlvl = cboSubStudsLvl.Text
                    gstrsubstudsem = cboSubStudsSem.Text
                    gstrsubstudsess = cboSubStudsSession.Text
                    gstrSubStudsProg = cboSubStudsProgram.SelectedValue




                Case "Class Students"
                    gstrClassStudsSlctProg = cboStudClasProgram.SelectedValue.ToString
                    gstrClassYr = cboStudClasYr.Text
                    gstrClassStudsSess = cboStudClassSession.Text
                    gstrClassStudClass = cboStudClassCls.Text
                    gstrClassStudsSex = cboClassStudsSex.Text
                    clsperiodanalysis = chkperiodAnalysis1.Checked
                    gdtenrolPeriodAnalysisDatefrom = dtpclassstudentdatefrom.Value.Date
                    gdtenrolPeriodAnalysisDateTo = dtpclassstudentdateTo.Value.Date
                    gblnclsAgeAnalysis = chkClssAge.Checked
                    gstrClassStudAgeFrom = txtStudClassAgeFrom.Text
                    gstrClassStudAgeto = txtStudClassAgeto.Text


                Case "School Enrollment"
                    gstrSchoolEnrolCls = cboSchoolEnrolClass.Text



                    gstrschoolsection = cboSchoolEnrolSection.Text
                    enrolPeriodAnalysis = chkPeriodAnalysis.Checked
                    gdtenrolPeriodAnalysisDatefrom = dtpEnrolPerAnalDateFrom.Value.Date
                    gdtenrolPeriodAnalysisDateTo = dtpEnrolPerAnalDateTo.Value.Date
                    gblnGraphical = chkGraphicalenrol.Checked

                ' Try
                ' If gstrSchoolEnrolStatus = "High School" Then
                ' Me.SchoolEnrollment1TableAdapter.Fill(Me.DsReports.SchoolEnrollment1, gstrSchoolEnrolCls)
                'RptPreview(Me, btnClose, btnPreview, "rptSchoolEnrollment.rpt", True, DsReports, _
                '               "SchoolEnrollment", , , , , , , "SchoolEnrollment")

                ' ElseIf gstrSchoolEnrolStatus = "IT and BS" Then
                ' Me.SchoolEnrollmentTableAdapter.Fill(Me.DsReports.SchoolEnrollment, gstrSchoolEnrolCls)
                'RptPreview(Me, btnClose, btnPreview, "rptSchoolEnrollment.rpt", True, DsReports, _
                '                "SchoolEnrollment1", , , , , , , "SchoolEnrollment")

                ' End If


                '  Catch ex As Exception

                '  End Try

                Case "Subject Points"
                    gstrSubPntEnrol = cboSubPntClass.Text
                    ' gstrSubPntSub = cboSubPntSect.SelectedValue.ToString
                    gstrSubPntIntake = cboSubPntIntk.Text
                    gstrSubPntSect = cboSubPntSect.Text
                    gstrSubPntSess = cboSubPntSess.Text


                Case "Student Personal Details"
                'gstrStudPersStatus = cboPersDetStatus.Text
                'Try
                '    frmTranscript.Show()
                'Catch ex As Exception
                '    System.Windows.Forms.MessageBox.Show(ex.Message)
                'End Try
                Case "FeesPayments"

                Case "DetailedStudentMarks"

                    gstrDetailedMarksProg = cboDetailedMarksProg.SelectedValue.ToString
                    gstrDetailedMarksClass = cboDetailedMarksClass.Text
                    gstrDetailedMarksLevel = cboDetailedMarksLevel.Text
                    gstrDetailedMarksIntake = cboDetailedMarksIntake.Text
                    gstrTransSumStud = cboDetailedMarksStud.Text
                    '  gstrDetailedMarksSem = cboDetailedMarksSem.Text
                    '  gstrDetailedMarkRef = cboDetailedResRef.Text
                    gstrDetailedMarkSect = cboDetailedMarksSect.Text
                    gblDetRes = rbResDetail.Checked
                    gblSumRes = rbResSummary.Checked
                    gblDispRes = rbResDisplay.Checked
                    gblnTransSum = rbTansSum.Checked
                    gblnResltStat = rbResStat.Checked
                    gblnResPublish = rbPublish.Checked

                Case "Contact Details"
                    Try
                        gstrStudContactsSession = cboContsSession.Text
                        gstrcontactsProgram = cboContactsProgra.SelectedValue.ToString
                        gstrContactsLevel = cboContsLevel.Text
                        gstrContactsSemester = cboContactsSem.Text
                        gstrContactsClass = cboContactsClass.Text
                        gstrContactsIntk = cboContsIntk.Text
                        gstrContClassChecked = rbContsPerClass.Checked
                        gstrContactsSubject = cboContactsStud.Text
                        gstrContSubChecked = rbContactsPerStud.Checked
                        gstrAllContacts = rbAllConts.Checked
                        gstrcontactssect = cboContactsSect.Text

                    Catch ex As Exception

                    End Try


                Case "Exam Marks"
                    '    gstrHsMarksProg = cboHsMarksProg.SelectedValue.ToString
                    ' gstrHsMarksClass = cboHsMarksClass.Text
                    gstrHsMarkSess = cboHsMarksSess.Text
                    gstrHsMarksLev = cboHsMarksLev.Text
                    gstrHsMarksRef = cboHsMarksRef.Text
                    ' gstrHsMarksSem = cboHsMarksSem.Text
                    gstrHsMarksStud = cboHsMarksStud.Text
                    gstrMarkSection = cboHsMarksSect.Text
                    gblnPublish = chkPublish.Checked
                    ' gstrHsMarksSub = cboHsMarksSub.SelectedValue.ToString
                    gblnHsMarksPerClass = rbHsMarksPerClass.Checked
                    '   gblnHsMarksPerLev = rbHsMarksPerLevel.Checked
                    gblnReportPerstud = rbReportPerStud.Checked
                    gblnreportPerClass = rbHsReportPerClass.Checked
                    gblnconsolmarks = rbConsolMarkSheet.Checked
                    gblnmailperclass = chkEmail.Checked
                    gblna4Reports = rbA4.Checked
                    gblnBookletReports = rbBooklet.Checked
                    gblnGraphical = chkGraphical.Checked
                    gstrMarkEmailMsg = txtCustomEmailmsg.Text

                    gblnHsMarksPerSub = rbHsMarksPerSubject.Checked
                    gblnHsPublish = rbpub.Checked

                    If gblnmailperclass Then
                        If MsgBox("You chose to Send generated Academic Report(s) via Emails , do you wish to Continue?", MsgBoxStyle.YesNo) = vbYes Then
                        Else
                            Cursor = Cursors.Default
                            Exit Sub
                        End If
                    End If


                Case "ExamAttendance"
                    gstrExamAttExam = cboExamAttExam.Text
                    gstrExamAttSub = cboExamAttSub.SelectedValue.ToString

                Case "PaymentsPerDate"




                    gblnFeesAnalysis = rbFeesPaymentsAnalysis.Checked
                    gblnFeesDetail = rbFeesPayWithStudents.Checked
                    gdatefrom = dtpPayDateFrom.Value.Date
                    gpdatefrom = dtpPostDateFrom.Value.Date
                    gpdateto = dtpPostDateTo.Value.Date
                    gdateTo = dtpPayDateTo.Value.Date
                    gstrfizpaypfrom = cboFeesPayPfrpm.SelectedValue
                    gstrfizpaypto = cbofeesPayPto.SelectedValue
                    gstrPayType = cboPayperDateType.SelectedValue
                    gstrcashtype = cboPayPerDateMode.Text
                    gstruser = cboPayPerDaterUser.Text

                    gstrCurrency = cboFeesPayCurrency.Text



                Case "LeftStudents"
                    gstrYearLeft = cboYearLeft.Text
                    gstrtermleftfrom = cboTermLeftFrom.Text
                    gstrtermleftTo = cboTermLeftTo.Text
                    gstrReasonLeft = cboReasonLeft.Text


                Case "DroppedSubjects"
                    gdtdropdSubFrom = dtpSudDropdFrom.Value.Date
                    gdtdrpsubTo = dtpSubDrpdTo.Value.Date

                Case "KnowHow"

                    gstrKnowHowYear = CInt(cboKnowHowYear.Text)

                Case "StaffAssessment"
                    gstrLectAssLect = cboStaffAssStaff.Text
                    gstrLectAssProg = cboStaffAssProg.SelectedValue
                    gstrLectAssCls = cboStaffAssCls.Text
                    gstrLectAssIntk = cboStaffAssIntk.Text
                    gstrLectAssSem = cboStaffAssSem.Text
                    gstrLectAssYr = cboStaffAssYear.Text
                    gblnStaffAssPerClass = rbStaffAssPerClass.Checked
                    gblnStaffAssPerLect = rbStaffAssPerIndv.Checked
                    gblnStaffAssPerSub = rbAssessmentPerSub.Checked
                    gblnStaffAssPerSect = rbStaffAssPerSection.Checked
                    gstrLectAssSect = cboStaffAssSect.Text
                    gstrLectAssSub = cboStaffAssSub.SelectedValue
                ' gstrLectAssSess = cbostaffas

                Case "DepartmentalAssessment"
                    'gstrDeptAssSchool = cboDepAnalSection.Text
                    gstrDeptAssCls = cboDeptAnalClass.Text
                    gstrDeptAssIntk = cboDeptAnalIntk.Text
                    gstrDeptAssSchool = cboDptAnlSchool.Text
                    gblnAllDeptAnal = chkDeptAnaly.Checked
                ' gstrDeptAssSem = cboDeptAssSem.Text

                Case "Ratings"
                    gstrLectRatingSect = cboStaffRatingSection.Text
                    gstrLectRatingCls = cboStaffRatingCls.Text
                    gstrLectRatingIntk = cboStaffRatingIntk.Text
                    gblnBysection = chkBySection.Checked

                Case "CollegeAverage"
                    gstrColAvgClas = CboColAssCls.Text
                    gstrColAvgIntk = cboColAssIntk.Text

                Case "SubjectsTaught"
                    gstrSubtotClas = cboSubTotCls.Text
                    gstrSubtotTerm = cboSubTaughtTerm.Text
                    gstrSubtotSub = cboSubTaughtSubject.Text
                    gstrSubtotteacher = txtsubtaughtteachers.Text
                    gblnsubtaughtperteacher = rbSubTaughtPerTeacher.Checked
                    gblnsubtaughtpersubject = rbSubTaughtPerSubject.Checked

                Case "CollegeGeneralAnalysis"

                    gstrGeneralAnalClass = cboGeneralAnalClass.Text
                    gstrGeneralAnalIntk = cboGeneralAnalIntk.Text
                    gstrGeneralAnalSect = cboGeneralAnalSect.Text


                Case "LectureGeneralAnalysis"

                    gstrGeneralAnalClass = cboGeneralAnalClass.Text
                    gstrGeneralAnalIntk = cboGeneralAnalIntk.Text
                    gstrGeneralAnalSect = cboGeneralAnalSect.Text


                Case "LecturerAllRatings"
                    gstrLectRatingSect = cboStaffRatingSection.Text
                ' gstrLectRatingCls = cboStaffRatingCls.Text
                ' gstrLectRatingIntk = cboStaffRatingIntk.Text
                'gblnBysection = chkBySection.Checked

                Case "SubjectRegister"

                    gstrSubRegCls = cboSubRegCls.Text
                    gstrSubRegDateFrom = subRegDateFrom.Text
                    gstrSubRegDateTo = SubRegDateTo.Text
                    '   gstrSubRegIntk = cboSubRegIntk.Text
                    gstrSubRegLvl = cboStudRegLvl.Text
                    gstrSubRegSem = cboSubRegSem.Text
                    gstrSubRegSess = cboSubRegSess.Text
                    gstrSubRegStud = cboSubRegStud.Text
                    '  gstrSubRegProg = cbosubre


                    gblnSubRegPerStud = rbSubRegPerStud.Checked
                    gblnsubregpersub = rbSubRegPerSub.Checked
                    gblnhardcopy = rbHardCopy.Checked



                Case "Register3"
                    'MsgBox("Under Construction")
                    gstrreg3class = cboReg3Class.Text
                    gstrreg3intake = cboReg3Intake.Text
                    gstrreg3prog = cboReg3Prog.Text
                    gstrreg3section = cboReg3Sec.Text
                    gstrreg3session = cboReg3Session.Text
                    gstrreg3subject = cboReg3Sub.Text


                Case "UserLoginHistory"

                    gstruser = cbUserHisUser.Text
                    Try
                        gdatelogfrm = mskLognHisFrm.Text
                        gdatelogTo = mskLognHisTo.Text
                    Catch ex As Exception

                    End Try

                    gblnlogdin = rbLoggedInUser.Checked
                    gblnbydate = rbUserHisByDate.Checked
                    gblnbyUser = rbUserHisByUser.Checked


                Case "IDcards"
                    gstridgroup = cboCardsGrp.Text
                    gstridclass = cboCardsYr.Text
                    gstridterm = cboCardsTerm.Text
                    gblnidbyClass = rbCardsPerClas.Checked
                    gblnidbyGroup = rbCardsPerGroup.Checked
                    gstridyr1 = cboCardsForm1.Text
                    gstridyr2 = cboCardsForm2.Text
                    gstridsess1 = cboCardsSess1.Text
                    gstridsess2 = cboCardsSess2.Text


                Case "PassRatesAnalysis"
                    gstrpassrateboard = cboPassRatesBoard.Text
                    gstrpassrateprog = cboPassRatesProg.SelectedValue
                    gblnpassrateperboard = rbPassRatePerBoard.Checked
                    gblnpassrateperpro = rbPassRatePerProgram.Checked


                Case "StaffPersonalDetails"
                    gstrStaffstatus = cboStaffPersStaus.Text
                    gblnstaffbycontract = rbStaffContract.Checked
                    gblnstaffbydesignation = rbStaffTeaching.Checked
                    gblnstaffbyType = RbStaffGvt.Checked


                Case "StaffQualifications"
                    gblnstaffqualbyqual = rbQualByQual.Checked
                    gblnstaffQualByStaff = rbQualByStaff.Checked


                Case "Profile"

                    gblnSchoolCurricula = rbSchoolCurricula.Checked
                    gblnSchoolParticulars = rbSchoolParticulars.Checked


                Case "ClassRegister"
                    gstrClsRegStud = cboClsRegStud.Text
                    gstrClsRegCls = cboClsRegCls.Text
                    gstrClsRegForm = cboClsRegForm.Text
                    gstrClsRegTerm = cboClsRegTern.Text
                    gstrClsRegSess = cboClsRegSess.Text
                    gstrClsRegDateto = cboClsRegDetTo.Text
                    gstrclsregatefrom = cboClsRegDetFrm.Text
                    gblnClsRegPerDay = rbClsRegByDay.Checked
                    gblnClsRegPerCls = rbClsRegByCls.Checked
                    gblnClsRegPerStud = rbClsRegPerStud.Checked
                    gblnhardcopy = rbClsRegHardCopy.Checked
                ' gblnClsRegPerStud = rbClsRegPerStud 


                Case "StaffRegister"
                    gstrstaffregdatefrm = staffregdatefrom.Text
                    gstrstaffregdateto = StaffRegDateTo.Text

                    gblnstaffregbydate = rbStaffRegByDay.Checked
                    gblnstaffregbystaff = rbStaffRegByStaff.Checked



                Case "BookDetails"

                    rbBookmasterPerbook = rbPerBook.Checked
                    rbBookmasterPerLvl = rbPerProgram.Checked
                    rbBookmasterSummary = rbBookSummary.Checked
                    rbBookmasterSummaryPerProg = rbSummaryPerprog.Checked


                Case "IncomeExpenditure"

                    gstrIncExpdatefrm = dtpIncExpDatefrom.Text
                    gstrIncExpdateTo = dtpIncExpDateTo.Text
                    gstrIncExpCrt = cboIncomeExpenditureCart.Text
                    gblnIncExpDetailed = rbIncExpDetailed.Checked
                    gblnIncExpSummary = rbIncExpSummary.Checked
                ' gstrIncExpCrt = cboExpenseCartegory.Text


                Case "BookIssues"
                    rbissuesbybook = rbIssuesPerBook.Checked
                    rbissuesbyStud = rbIssuesPerStud.Checked
                    rbissuesbyDate = rbBookIssuesPerDate.Checked

                    gstrbookissuefrm = dtpBookIssuesFrom.Text
                    gstrbookissueTo = dtpBookIssuesTo.Text


                Case "Creditors"
                    gstrcreditorsCreditor = txtCrCreditor.Text
                    gstrcreditorsPrdfrom = cboCrPrdFrm.SelectedValue
                    gstrcreditorsPrdTo = cboCrPrdTo.SelectedValue
                    gblncreditorstatement = rbCreditorStat.Checked
                    gblnAllCreditors = rbAllCreditors.Checked


                Case "DueBy"
                    gstrdueby = dtpDueDate.Text

                Case "BorrowingHistory"
                    gblnborrowhisPerBook = rbHistoryPerBook.Checked
                    gblnBorrowhisPerStud = rbHistoryPerStud.Checked
                    gstrborrowhist = txtHistSearch.Text


                Case "GraphicalAnalysis"
                    gstrHsMarkSess = cboExamGraphSessFrom.Text
                    gstrHsMarksLev = cboExamGraphForm.Text
                    gstrHsMarksRef = cboExamGraphClass.Text
                    gstrMarkSection = cboExamGraphSection.Text
                    ' gstrHsMarksSem = cboHsMarksSem.Text
                    ' gstrHsMarksStud = cbHsMarksStud.Text
                    gstrHsMarkSessto = cboExamGraphSessTo.Text

                    ' gstrHsMarksSub = cboHsMarksSub.SelectedValue.ToString
                    ' gblnHsMarksPerClass = rbg
                    '   gblnHsMarksPerLev = rbHsMarksPerLevel.Checked
                    gblnHsMarksPerStud = rbgraphperstud.Checked
                    gblnHsMarksPerSub = rbGraphPerSub.Checked



            End Select

            Dim trans As frmTranscript = New frmTranscript()
            trans.frmmain = frmMain
            'Me.TranscriptTableAdapter.FillbyStud(Me.DsReports.Transcript, cbTransStudID.Text, cbTransYear.Text, cbTransSem.Text, gstrTransRef)
            trans.Show()

        Catch ex As System.Exception
            '  System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Cursor = Cursors.Default
    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub








    Private Sub rbAllSubStuds_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAllSubStuds.CheckedChanged
        If rbAllSubStuds.Checked Then
            cboSubStudsYera.Enabled = True
            cboSubStudsIntake.Enabled = False
            cboSubStudsProgram.Enabled = True
            cboSubStudsID.Enabled = True
            cboSubStudSection.Enabled = False
            cboSubStudsSem.Enabled = True
            cboSubStudsSession.Enabled = False
            cboMarkSheetExam.Enabled = False
            cboSubStudsLvl.Enabled = True
        End If
    End Sub

    Private Sub rbSubByProg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSubByProg.CheckedChanged
        If rbSubByProg.Checked Then

            cboSubStudsYera.Enabled = True
            cboSubStudsIntake.Enabled = False
            cboSubStudsProgram.Enabled = True
            cboSubStudsID.Enabled = False
            cboSubStudSection.Enabled = False
            cboSubStudsSem.Enabled = True
            cboSubStudsSession.Enabled = False
            cboMarkSheetExam.Enabled = False
            cboSubStudsLvl.Enabled = True

        End If
    End Sub

    Private Sub rbSubByIntakes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If rbSubByIntakes.Checked Then
        '    cboSubStudsYera.Enabled = True
        '    cboSubStudsIntake.Enabled = True
        '    cboSubStudsProgram.Enabled = False
        'End If
    End Sub

    Private Sub rbContsPerClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContsPerClass.CheckedChanged
        If rbContsPerClass.Checked Then
            cboContsLevel.Enabled = True
            cboContactsClass.Enabled = True
            cboContactsProgra.Enabled = True
            cboContactsSem.Enabled = True
            cboContsIntk.Enabled = False
            cboContsSession.Enabled = True
            cboContactsStud.Enabled = False
            cboContactsSect.Enabled = False

        End If
    End Sub












    Private Sub rbHsMarksPerClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHsMarksPerClass.CheckedChanged, rbHsMarksPerSubject.CheckedChanged,
        rbHsReportPerClass.CheckedChanged, rbpub.CheckedChanged, rbReportPerStud.CheckedChanged, rbConsolMarkSheet.CheckedChanged
        Dim ctrl As RadioButton = sender

        If ctrl.Checked Then

            Select Case ctrl.Name
                Case rbHsMarksPerClass.Name
                    cboHsMarksLev.Enabled = True
                    cboHsMarksRef.Enabled = True
                    cboHsMarksSess.Enabled = True
                    cboHsMarksStud.Enabled = False
                    gbPublishOptions.Visible = False
                    cboHsMarksSect.Enabled = True
                    Panel2.Enabled = False
                    gbGraphicalView.Visible = True
                Case rbConsolMarkSheet.Name
                    cboHsMarksLev.Enabled = True
                    cboHsMarksRef.Enabled = True
                    cboHsMarksSess.Enabled = True
                    cboHsMarksStud.Enabled = False
                    gbPublishOptions.Visible = False
                    cboHsMarksSect.Enabled = True
                    Panel2.Enabled = False
                    gbGraphicalView.Visible = True
                Case rbHsMarksPerSubject.Name
                    cboHsMarksLev.Enabled = True
                    cboHsMarksRef.Enabled = True
                    cboHsMarksSess.Enabled = True
                    cboHsMarksStud.Enabled = False
                    gbPublishOptions.Visible = False
                    cboHsMarksSect.Enabled = True
                    Panel2.Enabled = False
                    gbGraphicalView.Visible = True
                Case rbHsReportPerClass.Name
                    cboHsMarksLev.Enabled = True
                    cboHsMarksRef.Enabled = True
                    cboHsMarksSess.Enabled = True
                    cboHsMarksStud.Enabled = False
                    gbPublishOptions.Visible = False
                    cboHsMarksSect.Enabled = True
                    Panel2.Enabled = True
                    gbGraphicalView.Visible = False
                Case rbReportPerStud.Name
                    cboHsMarksLev.Enabled = False
                    cboHsMarksRef.Enabled = True
                    cboHsMarksSess.Enabled = False
                    cboHsMarksStud.Enabled = True
                    gbPublishOptions.Visible = False
                    cboHsMarksSect.Enabled = False
                    Panel2.Enabled = True
                    gbGraphicalView.Visible = False
                Case rbpub.Name

                    gbPublishOptions.Visible = True

                    RbPublishPerClass.Checked = True
                    Panel2.Enabled = False
                    RbPublishPerClass_CheckedChanged(Me, Nothing)

                    gbGraphicalView.Visible = False
                Case rbPublishPerExam.Checked
                    cboHsMarksLev.Enabled = False
                    cboHsMarksRef.Enabled = True
                    cboHsMarksSess.Enabled = False
                    cboHsMarksStud.Enabled = False
                    cboHsMarksSect.Enabled = True
                    gbGraphicalView.Visible = False

            End Select
        End If

    End Sub







    Private Sub rbResDisplay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbResDisplay.CheckedChanged
        If rbHsReportPerClass.Checked Then
            '  cboHsMarksProg.Enabled = True
            '  cbHsMarksStud.Enabled = False
            cboHsMarksLev.Enabled = True
            ' cboHsMarksSem.Enabled = False
            cboHsMarksRef.Enabled = True
            cboHsMarksSess.Enabled = True

            '  cboHsMarksSub.Enabled = False
            ' cboHsMarksClass.Enabled = True
            cboDetailedMarksStud.Enabled = False
        End If
    End Sub

    Private Sub rbExamAttendance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExamAttendance.CheckedChanged
        If rbExamAttendance.Checked Then


            cboSubStudsYera.Enabled = True
            cboSubStudsIntake.Enabled = False
            cboSubStudsProgram.Enabled = False
            cboSubStudsID.Enabled = True
            cboSubStudSection.Enabled = False
            cboSubStudsSem.Enabled = True
            cboSubStudsSession.Enabled = False
            cboMarkSheetExam.Enabled = True
            cboSubStudsLvl.Enabled = True

        End If
    End Sub

    Private Sub RbMarkSheet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbMarkSheet.CheckedChanged
        If RbMarkSheet.Checked Then


            cboSubStudsYera.Enabled = True
            cboSubStudsIntake.Enabled = False
            cboSubStudsProgram.Enabled = False
            cboSubStudsID.Enabled = True
            cboSubStudSection.Enabled = False
            cboSubStudsSem.Enabled = True
            cboSubStudsSession.Enabled = True
            cboMarkSheetExam.Enabled = True
            cboSubStudsLvl.Enabled = True


        End If
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub rbResDetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbResDetail.CheckedChanged
        rbResDisplay_CheckedChanged(Me, Nothing)
    End Sub



    Private Sub rbAccPerClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cboAccClass.Enabled = rbAccPerClass.Checked
        'cboAccIntk.Enabled = rbAccPerClass.Checked
        'If rbAccPerClass.Checked Then
        '    cboAccLvl.Enabled = True
        '    cboAccSem.Enabled = True
        '    cboAccProg.Enabled = True
        '    cboAccSubject.Enabled = False
        '    cboAccSection.Enabled = False
        '    cboAccStud.Enabled = False
        '    cboAccPerFrm.Enabled = True
        '    cboAccPerTo.Enabled = True
        '    cboAccClass.Enabled = True
        '    cboAccIntk.Enabled = False
        '    cboAccSession.Enabled = True
        'End If


    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPayDateTo.ValueChanged

    End Sub

    Private Sub cbofeesPayPto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbofeesPayPto.SelectedIndexChanged

    End Sub

    Private Sub rbFeesPaymentsAnalysis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFeesPaymentsAnalysis.CheckedChanged
        'cboFeesPayPfrpm.Enabled = rbFeesPaymentsAnalysis.Checked
        'cbofeesPayPto.Enabled = rbFeesPaymentsAnalysis.Checked
        'dtpPayDateFrom.Enabled = Not rbFeesPaymentsAnalysis.Checked
        'dtpPayDateTo.Enabled = Not rbFeesPaymentsAnalysis.Checked
    End Sub

    Private Sub gbPaymentsPerDate_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbPaymentsPerDate.Enter

    End Sub

    Private Sub rbCoursewek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCoursewek.CheckedChanged
        If rbCoursewek.Checked Then
            cboSubStudsYera.Enabled = True
            cboSubStudsIntake.Enabled = False
            cboSubStudsProgram.Enabled = False
            cboSubStudsID.Enabled = True
            cboSubStudSection.Enabled = False
            cboSubStudsSem.Enabled = True
            cboSubStudsSession.Enabled = True
            cboMarkSheetExam.Enabled = True
            cboSubStudsLvl.Enabled = True
        End If
    End Sub

    Private Sub cboContactsStud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboContactsStud.SelectedIndexChanged

    End Sub

    Private Sub cboContactsStud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboContactsStud.TextChanged
        Dim serchtext As String = Trim(cboContactsStud.Text)
        lbStudContsSearch.Items.Clear()
        Dim drr As SqlDataReader
        lbStudContsSearch.Visible = True
        Dim sql As String = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lbStudContsSearch.Items.Add(drr(0) & " " & drr(1) & " " & drr(2))
        End While
    End Sub

    Private Sub lbStudContsSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbStudContsSearch.DoubleClick
        Dim fullname As String
        Try
            fullname = lbStudContsSearch.SelectedItem.ToString
            lbStudContsSearch.Items.Clear()
            search2(fullname, cboContactsStud)
            lbStudContsSearch.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbStudContsSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbStudContsSearch.SelectedIndexChanged

    End Sub

    Public Sub search2(ByVal fullname As String, ByVal targetComb As ComboBox)
        Try
            Dim a, b As Integer
            Dim searchstring As String
            b = InStr(Trim(fullname), " ")
            searchstring = Mid(Trim(fullname), 1, b - 1)
            targetComb.Text = searchstring


            'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
            'If a < 0 Then
            '    MsgBox("Student ID could not be found")
            'Else
            '    StudentPersonalDetailsBindingSource.Position = a
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbContactsPerStud_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContactsPerStud.CheckedChanged
        If rbContactsPerStud.Checked Then
            cboContsLevel.Enabled = False
            cboContactsClass.Enabled = False
            cboContactsProgra.Enabled = False
            cboContactsSem.Enabled = False
            cboContsIntk.Enabled = False
            cboContsSession.Enabled = False
            cboContactsStud.Enabled = True
            cboContactsSect.Enabled = False
        End If
    End Sub

    Private Sub cbSubStudentsID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbSubStudentsID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbStudSubSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbStudSubSearch.DoubleClick
        Dim fullname As String
        Try
            fullname = lbStudSubSearch.SelectedItem.ToString
            lbStudSubSearch.Items.Clear()
            search2(fullname, cbostudsubStudid)
            lbStudSubSearch.Visible = False
        Catch ex As Exception

        End Try
    End Sub


    Private Sub chkPeriodAnalysis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPeriodAnalysis.CheckedChanged
        pnlDateAnalysis.Enabled = chkPeriodAnalysis.Checked
    End Sub







    Private Sub rbAllConts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAllConts.CheckedChanged
        If rbAllConts.Checked Then
            cboContsLevel.Enabled = False
            cboContactsClass.Enabled = True
            cboContactsProgra.Enabled = False
            cboContactsSem.Enabled = False
            cboContsIntk.Enabled = False
            cboContsSession.Enabled = False
            cboContactsStud.Enabled = False
            cboContactsSect.Enabled = True
            rtxtAccAddinfo.Enabled = False
        End If
    End Sub

    Private Sub cboSubStudsIntake_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubStudsIntake.SelectedIndexChanged

    End Sub

    Private Sub gbSubStuds_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbSubStuds.Enter

    End Sub

    Private Sub rbAccPerStud_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If rbAccPerStud.Checked Then
        '    cboAccLvl.Enabled = False
        '    cboAccSem.Enabled = False
        '    cboAccProg.Enabled = True
        '    cboAccSubject.Enabled = False
        '    cboAccSection.Enabled = False
        '    cboAccPerFrm.Enabled = False
        '    cboAccPerTo.Enabled = False
        '    cboAccStud.Enabled = True
        'End If
    End Sub

    Private Sub txtAccStud_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub





    Private Sub cboAccStud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub gbStudSubs_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gbContactDetails_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbContactDetails.Enter

    End Sub

    Private Sub cbDateAnalysis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbFeesPayWithStudents_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFeesPayWithStudents.CheckedChanged, rbFeesPaymentsAnalysis.CheckedChanged
        Dim ctrl As RadioButton = sender
        If ctrl.Checked Then
            Select Case ctrl.Name
                Case rbFeesPayWithStudents.Name
                    GroupBox1.Enabled = rbFeesPayWithStudents.Checked
                Case rbFeesPaymentsAnalysis.Name
                    GroupBox1.Enabled = False
                    cboPayPerDateMode.Text = "All"
                    cboPayPerDaterUser.Text = "All"
                    cboPayperDateType.Text = "All"
            End Select
        End If


    End Sub

    Private Sub rbStaffAssPerClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStaffAssPerClass.CheckedChanged
        If rbStaffAssPerClass.Checked Then
            cboStaffAssStaff.Enabled = False
            cboStaffAssSub.Enabled = False
            cboStaffAssSem.Enabled = True
            cboStaffAssProg.Enabled = True
            cboStaffAssYear.Enabled = True
            cboStaffAssIntk.Enabled = True
            cboStaffAssSect.Enabled = False
            cboStaffAssCls.Enabled = True
        End If

    End Sub

    Private Sub gbTrans_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbTrans.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbStaffRatings.Enter

    End Sub

    Private Sub rbStaffAssPerIndv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStaffAssPerIndv.CheckedChanged
        If rbStaffAssPerIndv.Checked Then
            cboStaffAssStaff.Enabled = True
            cboStaffAssSub.Enabled = False
            cboStaffAssSem.Enabled = False
            cboStaffAssProg.Enabled = False
            cboStaffAssYear.Enabled = False
            cboStaffAssIntk.Enabled = True
            cboStaffAssSect.Enabled = False
            cboStaffAssCls.Enabled = True
        End If
    End Sub

    Private Sub cboStaffAssStaff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStaffAssStaff.SelectedIndexChanged

    End Sub

    Private Sub cboStaffAssStaff_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboStaffAssStaff.TextChanged
        lblectures.Items.Clear()
        lblectures.Visible = True
        Dim sql As String
        Dim reader As SqlDataReader
        sql = "select * from staffpersonaldetails where  name + surname like '%" & cboStaffAssStaff.Text & "%'"
        reader = ExecuteReader(sql)
        While reader.Read
            lblectures.Items.Add(reader(0).ToString & " " & reader(1).ToString & " " & reader(2).ToString)
        End While
    End Sub

    Private Sub lblectures_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblectures.DoubleClick
        Try
            'cboStaffAssStaff.Text = lblectures.SelectedItem.ToString
            Dim b As Integer
            Dim searchstring As String

            b = InStr(Trim(lblectures.SelectedItem.ToString), " ")
            searchstring = Mid(Trim(lblectures.SelectedItem.ToString), 1, b - 1)
            cboStaffAssStaff.Text = searchstring
            lblectures.Items.Clear()
            lblectures.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblectures_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblectures.SelectedIndexChanged

    End Sub

    Private Sub rbAssessmentPerSub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAssessmentPerSub.CheckedChanged
        If rbAssessmentPerSub.Checked Then
            cboStaffAssStaff.Enabled = False
            cboStaffAssSub.Enabled = True
            cboStaffAssSem.Enabled = False
            cboStaffAssProg.Enabled = False
            cboStaffAssYear.Enabled = False
            cboStaffAssIntk.Enabled = True
            cboStaffAssSect.Enabled = True
            cboStaffAssCls.Enabled = True
        End If
    End Sub

    Private Sub cboTransStudID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTransStudID.SelectedIndexChanged

    End Sub

    Private Sub lstStudents_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstStudents.DoubleClick
        Dim fullname As String
        Try
            fullname = lstStudents.SelectedItem.ToString
            lstStudents.Items.Clear()
            search2(fullname, cboTransStudID)
            lstStudents.Visible = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lstStudents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstStudents.SelectedIndexChanged

    End Sub

    Private Sub lstStudents_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstStudents.TextChanged

    End Sub

    Private Sub cboTransStudID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTransStudID.TextChanged
        Dim serchtext As String = Trim(cboTransStudID.Text)
        lstStudents.Items.Clear()
        Dim drr As SqlDataReader
        lstStudents.Visible = True
        Dim sql As String = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lstStudents.Items.Add(drr(0) & " " & drr(1) & " " & drr(2))
        End While
    End Sub

    Private Sub cboDetailedMarksStud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDetailedMarksStud.SelectedIndexChanged

    End Sub

    Private Sub cboDetailedMarksStud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDetailedMarksStud.TextChanged
        Dim serchtext As String = Trim(cboDetailedMarksStud.Text)
        lbTransSumStud.Items.Clear()
        Dim drr As SqlDataReader
        lbTransSumStud.Visible = True
        Dim sql As String = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lbTransSumStud.Items.Add(drr(0) & " " & drr(1) & " " & drr(2))
        End While
    End Sub

    Private Sub lbTransSumStud_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbTransSumStud.DoubleClick
        Dim fullname As String
        Try
            fullname = lbTransSumStud.SelectedItem.ToString
            lbTransSumStud.Items.Clear()
            search2(fullname, cboDetailedMarksStud)
            lbTransSumStud.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbTransSumStud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbTransSumStud.SelectedIndexChanged

    End Sub

    Private Sub rbResSummary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbResSummary.CheckedChanged

    End Sub

    Private Sub rbTansSum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTansSum.CheckedChanged
        'cboDetailedMarksStud.Enabled = rbTansSum.Checked
        'cboDetailedMarksProg.Enabled = True
        'cboDetailedMarksClass.Enabled = Not rbTansSum.Checked
        'cboDetailedMarksIntake.Enabled = Not rbTansSum.Checked
        'cboDetailedMarksLevel.Enabled = Not rbTansSum.Checked
        'cboDetailedMarksSect.Enabled = Not rbTansSum.Checked
        '  cboHsMarksProg.Enabled = True
        ' cbHsMarksStud.Enabled = False
        cboHsMarksLev.Enabled = True
        ' cboHsMarksSem.Enabled = False
        cboHsMarksRef.Enabled = True
        cboHsMarksSess.Enabled = True
        ' cboHsMarksSub.Enabled = False
        ' cboHsMarksClass.Enabled = True
        cboDetailedMarksStud.Enabled = False
    End Sub

    Private Sub rbStaffAssPerSection_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStaffAssPerSection.CheckedChanged
        If rbStaffAssPerSection.Checked Then
            cboStaffAssStaff.Enabled = False
            cboStaffAssSub.Enabled = False
            cboStaffAssSem.Enabled = False
            cboStaffAssProg.Enabled = False
            cboStaffAssYear.Enabled = False
            cboStaffAssIntk.Enabled = True
            cboStaffAssSect.Enabled = True
            cboStaffAssCls.Enabled = True
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gbDetailedMarks_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbDetailedMarks.Enter

    End Sub

    Private Sub chkBySection_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBySection.CheckedChanged
        cboStaffRatingSection.Enabled = chkBySection.Checked
    End Sub

    Private Sub cboDetailedMarksProg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDetailedMarksProg.SelectedIndexChanged
        If Trim(cboDetailedMarksProg.SelectedValue) = "BMIS" Then
            cboDetailedMarksLevel.Enabled = False
        Else
            cboDetailedMarksLevel.Enabled = True
        End If
    End Sub

    Private Sub gbDepartmentalAssessment_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbDepartmentalAssessment.Enter

    End Sub

    Private Sub chkDeptAnaly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDeptAnaly.CheckedChanged
        cboDeptAnalClass.Enabled = Not chkDeptAnaly.Checked
        cboDeptAnalIntk.Enabled = Not chkDeptAnaly.Checked
    End Sub

    Private Sub rbResStat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbResStat.CheckedChanged
        cboDetailedMarksStud.Enabled = rbResStat.Checked
    End Sub

    Private Sub rbClassResStats_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbClassResStats.CheckedChanged
        '  cboHsMarksProg.Enabled = True
        '  cbHsMarksStud.Enabled = False
        cboHsMarksLev.Enabled = True
        ' cboHsMarksSem.Enabled = False
        cboHsMarksRef.Enabled = True
        cboHsMarksSess.Enabled = True
        ' cboHsMarksSub.Enabled = False
        ' cboHsMarksClass.Enabled = True
        cboDetailedMarksStud.Enabled = False
    End Sub


    Private Sub cboSubRegSub_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Escape Then
        '    lbsubjects.Items.Clear()
        '    lbsubjects.Visible = False
        'End If
    End Sub




    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboSubRegSub_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If gblnLectureAssessmentDel Or gblnDepartmentalAssessment Then
        'Else
        '   lbsubjects.Items.Clear()
        'lbsubjects.Visible = True
        'Dim sql As String
        'Dim drr As SqlDataReader
        'sql = "select subjectid ,subject from subjects  where subjectid + subject like '%" & cboSubRegSub.Text & "%'"
        'drr = ExecuteReader(sql)
        'Try
        '    While drr.Read
        '        lbsubjects.Items.Add(drr(0).ToString & "-" & drr(1).ToString)
        '    End While
        'Catch ex As Exception

        'End Try

        'End If
    End Sub

    Private Sub lbsubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim searchstring As String = ""
        'Dim b As Integer
        ''MsgBox(lbprogram.SelectedValue.ToString)
        'b = InStr(Trim(lbsubjects.SelectedItem.ToString), "-")
        'searchstring = Mid(Trim(lbsubjects.SelectedItem.ToString), 1, b - 1)
        'cboSubRegSub.Text = searchstring
        'lbsubjects.Visible = False
    End Sub




    Private Sub cboSubregProg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'lbPrograms.Items.Clear()
        'lbPrograms.Visible = True
        'Dim sql As String
        'Dim drr As SqlDataReader
        'sql = "select forms ,description from forms  where forms + description like '%" & cboSubregProg.Text & "%'"
        'drr = ExecuteReader(sql)
        'Try
        '    While drr.Read
        '        lbPrograms.Items.Add(drr(0).ToString & "-" & drr(1).ToString)
        '    End While
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub lbPrograms_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim searchstring As String = ""
        'Dim b As Integer
        ''MsgBox(lbprogram.SelectedValue.ToString)
        'b = InStr(Trim(lbPrograms.SelectedItem.ToString), "-")
        'searchstring = Mid(Trim(lbPrograms.SelectedItem.ToString), 1, b - 1)
        'cboSubregProg.Text = searchstring
        'lbPrograms.Visible = False
    End Sub

    Private Sub cboSubRegSect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cboSubRegSect.Text = "High School" Then
        '    cboSubregProg.Enabled = True
        '    ' cboSubRegIntk.Enabled = True
        '    cboSubRegLvl.Enabled = True
        '    cboSubRegSem.Enabled = True
        'Else
        '    cboSubregProg.Enabled = False
        '    'cboSubRegIntk.Enabled = False
        '    cboSubRegLvl.Enabled = False
        '    cboSubRegSem.Enabled = False
        'End If

    End Sub



    Private Sub cboReg3Prog_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboReg3Prog.TextChanged
        lbReg3Prog.Visible = True
        lbReg3Prog.Items.Clear()
        Dim sql As String
        Dim drr As SqlDataReader
        sql = "Select Forms + '-' + Description from forms where Forms + ' ' + Description like '%" & cboReg3Prog.Text & "%'"

        drr = ExecuteReader(sql)

        While drr.Read
            lbReg3Prog.Items.Add(drr(0))

        End While



    End Sub

    Private Sub lbReg3Prog_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbReg3Prog.DoubleClick
        Dim prog As String
        Dim res(1) As String
        prog = lbReg3Prog.SelectedItem().ToString
        res = prog.Split("-")
        cboReg3Prog.Text = res(0).ToString
        lbReg3Prog.Visible = False
    End Sub



    Private Sub lbReg3Sub_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbReg3Sub.DoubleClick
        Dim subj As String
        Dim res(1) As String
        subj = lbReg3Sub.SelectedItem().ToString
        res = subj.Split("-")
        cboReg3Sub.Text = res(0).ToString
        lbReg3Sub.Visible = False
    End Sub





    Private Sub cboReg3Sub_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboReg3Sub.TextChanged
        lbReg3Sub.Visible = True
        lbReg3Sub.Items.Clear()
        Dim sql As String
        Dim drr As SqlDataReader
        sql = "Select SubjectID + '-' + Subject from Subjects where SubjectID + ' ' + Subject like '%" & cboReg3Sub.Text & "%'"

        drr = ExecuteReader(sql)

        While drr.Read
            lbReg3Sub.Items.Add(drr(0))

        End While
    End Sub



    Private Sub dtpEnrolPerAnalDateFrom_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpEnrolPerAnalDateFrom.TextChanged
        'Dim serchtext As String = Trim(cboSubRegStud.Text)
        'lbSubRegStudSearch.Items.Clear()
        'Dim drr As SqlDataReader

        'lbSubRegStudSearch.Visible = True
        'Dim sql As String = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
        'drr = ExecuteReader(sql)
        'While drr.Read
        '    lbSubRegStudSearch.Items.Add(drr(0) & " " & drr(1) & " " & drr(2))
        'End While
    End Sub



    Private Sub rbPublish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPublish.CheckedChanged
        cboDetailedMarksStud.Enabled = False
    End Sub

    Private Sub cboSubRegStud_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSubRegStud.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbSubRegStudSearch.Items.Clear()
        End If
    End Sub




    Private Sub cboSubRegStud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSubRegStud.TextChanged
        Dim serchtext As String = Trim(cboSubRegStud.Text)
        lbSubRegStudSearch.Items.Clear()
        Dim drr As SqlDataReader

        lbSubRegStudSearch.Visible = True
        Dim sql As String = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lbSubRegStudSearch.Items.Add(drr(0) & " " & drr(1) & " " & drr(2))
        End While
    End Sub

    Private Sub lbSubRegStudSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbSubRegStudSearch.DoubleClick
        Dim fullstud As String = ""
        Try
            fullstud = lbSubRegStudSearch.SelectedItem.ToString
            lbSubRegStudSearch.Items.Clear()
            searchstuds(cboSubRegStud, fullstud)
            lbSubRegStudSearch.Visible = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub searchstuds(ByVal combo As ComboBox, ByVal fullstud As String)
        Try
            Dim a, b As Integer
            Dim searchstring As String
            b = InStr(Trim(fullstud), " ")
            searchstring = Mid(Trim(fullstud), 1, b - 1)

            combo.Text = searchstring
            '    If a < 0 Then
            '        MsgBox("Student ID could not be found")
            '    Else
            '        StudentPersonalDetailsBindingSource.Position = a
            '    End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cboSubRegStud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubRegStud.SelectedIndexChanged

    End Sub

    Private Sub SubRegPerStud_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSubRegPerStud.CheckedChanged
        If rbSubRegPerStud.Checked Then
            cboSubRegSub.Enabled = False
            subRegDateFrom.Enabled = True
            SubRegDateTo.Enabled = True
            cboSubRegStud.Enabled = True
        Else
            cboSubRegSub.Enabled = False
            subRegDateFrom.Enabled = True
            SubRegDateTo.Enabled = True

            cboSubRegStud.Enabled = False


        End If
    End Sub





    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbClassStatement.CheckedChanged, rbStudStatement.CheckedChanged, rbAccPerForm.CheckedChanged, rbAccDebtors.CheckedChanged
        Dim ctrl As RadioButton = sender
        pnlTranstype.Enabled = True
        If ctrl.Checked Then

            Select Case ctrl.Name
                Case rbClassStatement.Name
                    cboAccLvl.Enabled = True
                    cboAccSection.Enabled = True
                    txtAccStud.Enabled = False
                    cboAccPerFrm.Enabled = True
                    cboAccPerTo.Enabled = True
                    cboAccClass.Enabled = True
                    cboAccSession.Enabled = True
                    pnlTranstype.Enabled = False
                    rtxtAccAddinfo.Enabled = True
                    chkDebtorsOnly.Enabled = True
                    chkAccShoRec.Checked = True
                    chkAccShowInv.Checked = True
                Case rbStudStatement.Name
                    cboAccLvl.Enabled = False
                    cboAccSection.Enabled = False
                    txtAccStud.Enabled = True
                    cboAccPerFrm.Enabled = True
                    cboAccPerTo.Enabled = True
                    cboAccClass.Enabled = False
                    cboAccSession.Enabled = False
                    rtxtAccAddinfo.Enabled = True
                    chkDebtorsOnly.Enabled = False
                    chkAccShoRec.Checked = True
                    chkAccShowInv.Checked = True
                Case rbAccDebtors.Name
                    pnlTranstype.Enabled = False
                    cboAccLvl.Enabled = True
                    cboAccSection.Enabled = True
                    txtAccStud.Enabled = False
                    cboAccPerFrm.Enabled = True
                    cboAccPerTo.Enabled = True
                    cboAccClass.Enabled = True
                    cboAccSession.Enabled = True
                    rtxtAccAddinfo.Enabled = False
                    chkDebtorsOnly.Enabled = False
                    chkAccShoRec.Checked = True
                    chkAccShowInv.Checked = True
                Case rbAccPerForm.Name
                    chkAccShoRec.Checked = True
                    chkAccShowInv.Checked = False
                    cboAccLvl.Enabled = True
                    cboAccSection.Enabled = True
                    txtAccStud.Enabled = False
                    cboAccPerFrm.Enabled = True
                    cboAccPerTo.Enabled = True
                    cboAccClass.Enabled = True
                    cboAccSession.Enabled = True
                    rtxtAccAddinfo.Enabled = False
                    chkDebtorsOnly.Enabled = False


            End Select


        End If
    End Sub



    Private Sub rbHardCopy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHardCopy.CheckedChanged
        ' If rbHardCopy.Checked Then
        cboSubRegSub.Enabled = rbHardCopy.Checked
        subRegDateFrom.Enabled = Not rbHardCopy.Checked
        SubRegDateTo.Enabled = Not rbHardCopy.Checked
        '  cboSubRegIntk.Enabled = Not rbHardCopy.Checked
        ' End If




    End Sub










    Private Sub cboSubStudsStudid_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbostudsubStudid.TextChanged
        Dim serchtext As String = Trim(cbostudsubStudid.Text)
        lbStudSubSearch.Items.Clear()
        Dim drr As SqlDataReader
        lbStudSubSearch.Visible = True
        Dim sql As String = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lbStudSubSearch.Items.Add(drr(0) & " " & drr(1) & " " & drr(2))
        End While
    End Sub

    Private Sub cbostudsubStudid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbostudsubStudid.SelectedIndexChanged

    End Sub

    Private Sub rbStudSubPerClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStudSubPerClass.CheckedChanged
        If rbStudSubPerClass.Checked Then

            cbostudsubStudid.Enabled = False
            cboStudSubCls.Enabled = True
            cboStudSubLvl.Enabled = True
            cboStudSubSem.Enabled = True
            cboStudSubProg.Enabled = True
            cboStudSubSess.Enabled = True
        End If
    End Sub

    Private Sub rbStudsubAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStudsubAll.CheckedChanged
        If rbStudsubAll.Checked Then

            cbostudsubStudid.Enabled = True
            cboStudSubCls.Enabled = False
            cboStudSubLvl.Enabled = False
            cboStudSubSem.Enabled = False
            cboStudSubProg.Enabled = False
            cboStudSubSess.Enabled = False
        End If

    End Sub

    Private Sub rbStubSubPerSem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStubSubPerSem.CheckedChanged
        If rbStubSubPerSem.Checked Then

            cbostudsubStudid.Enabled = True
            cboStudSubCls.Enabled = False
            cboStudSubLvl.Enabled = True
            cboStudSubSem.Enabled = True
            cboStudSubProg.Enabled = True
            cboStudSubSess.Enabled = False
        End If
    End Sub

    Private Sub chkperiodAnalysis1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkperiodAnalysis1.CheckedChanged
        pnlclassstudent.Enabled = chkperiodAnalysis1.Checked
    End Sub

    Private Sub chkLgdUser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub cbUserHisUser_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbUserHisUser.TextChanged
        Dim serchtext As String = Trim(cbUserHisUser.Text)
        lbUsers.Items.Clear()
        Dim drr As SqlDataReader

        lbUsers.Visible = True
        Dim sql As String = " select usr_user,usr_fullname from users where usr_user + ' ' + usr_fullname  like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lbUsers.Items.Add(drr(0))
        End While
    End Sub

    Private Sub lbUsers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbUsers.DoubleClick
        Try
            cbUserHisUser.Text = lbUsers.SelectedItem.ToString
            lbUsers.Items.Clear()
            '   search()
            lbUsers.Visible = False


        Catch ex As Exception

        End Try
    End Sub


    Private Sub rbLoggedInUser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLoggedInUser.CheckedChanged
        If rbLoggedInUser.Checked Then
            cbUserHisUser.Enabled = False
            mskLognHisFrm.Enabled = False
            mskLognHisTo.Enabled = False
        End If
    End Sub

    Private Sub rbUserHisByUser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbUserHisByUser.CheckedChanged
        If rbUserHisByUser.Checked Then
            cbUserHisUser.Enabled = True
            mskLognHisFrm.Enabled = True
            mskLognHisTo.Enabled = True
        End If
    End Sub

    Private Sub rbUserHisByDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbUserHisByDate.CheckedChanged
        If rbUserHisByDate.Checked Then
            cbUserHisUser.Enabled = False
            mskLognHisFrm.Enabled = True
            mskLognHisTo.Enabled = True
        End If
    End Sub



    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCardsTerm.SelectedIndexChanged

    End Sub

    Private Sub rbCardsPerClas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCardsPerClas.CheckedChanged
        If rbCardsPerClas.Checked Then
            cboCardsForm1.Enabled = False
            cboCardsForm2.Enabled = False
            cboCardsYr.Enabled = True
            cboCardsSess1.Enabled = False
            cboCardsSess2.Enabled = False
            cboCardsTerm.Enabled = True
            cboCardsGrp.Enabled = True
        End If
    End Sub

    Private Sub rbCardsPerGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCardsPerGroup.CheckedChanged
        If rbCardsPerGroup.Checked Then
            cboCardsForm1.Enabled = True
            cboCardsForm2.Enabled = True
            cboCardsYr.Enabled = True
            cboCardsSess1.Enabled = True
            cboCardsSess2.Enabled = True
            cboCardsTerm.Enabled = True
            cboCardsGrp.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTermLeftFrom.SelectedIndexChanged

    End Sub

    Private Sub rbPassRatePerBoard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPassRatePerBoard.CheckedChanged
        If rbPassRatePerBoard.Checked Then
            cboPassRatesBoard.Enabled = True
            cboPassRatesProg.Enabled = False
        End If
    End Sub

    Private Sub rbPassRatePerProgram_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPassRatePerProgram.CheckedChanged
        If rbPassRatePerProgram.Checked Then
            cboPassRatesBoard.Enabled = True
            cboPassRatesProg.Enabled = True
        End If
    End Sub

    Private Sub cboSubRegSem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubRegSem.SelectedIndexChanged

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClsRegSess.SelectedIndexChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClsRegTern.SelectedIndexChanged

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles cboClsRegDetTo.MaskInputRejected

    End Sub

    Private Sub cboClsRegStud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClsRegStud.SelectedIndexChanged

    End Sub

    Private Sub cboClsRegStud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboClsRegStud.TextChanged
        Dim serchtext As String = Trim(cboClsRegStud.Text)
        lbClsRegStud.Items.Clear()
        Dim drr As SqlDataReader

        lbClsRegStud.Visible = True
        Dim sql As String = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lbClsRegStud.Items.Add(drr(0) & " " & drr(1) & " " & drr(2))
        End While
    End Sub

    Private Sub lbSubRegStudSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSubRegStudSearch.SelectedIndexChanged

    End Sub

    Private Sub lbClsRegStud_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbClsRegStud.DoubleClick
        Dim fullstud As String = ""
        Try
            fullstud = lbClsRegStud.SelectedItem.ToString
            lbClsRegStud.Items.Clear()
            searchstuds(cboClsRegStud, fullstud)
            lbClsRegStud.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbClsRegStud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbClsRegStud.SelectedIndexChanged

    End Sub

    Private Sub rbClsRegByStud_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbClsRegByCls.CheckedChanged
        'cboClsRegStud.Enabled = rbClsRegByStud.Checked
        'cboClsRegCls.Enabled = Not rbClsRegByStud.Checked
        'cboClsRegForm.Enabled = Not rbClsRegByStud.Checked
        'cboClsRegSess.Enabled = Not rbClsRegByStud.Checked
        'cboClsRegTern.Enabled = Not rbClsRegByStud.Checked
    End Sub


    Private Sub rbClsRegPerStud_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbClsRegPerStud.CheckedChanged
        cboClsRegStud.Enabled = rbClsRegPerStud.Checked
        cboClsRegCls.Enabled = Not rbClsRegPerStud.Checked
        cboClsRegForm.Enabled = Not rbClsRegPerStud.Checked
        cboClsRegSess.Enabled = Not rbClsRegPerStud.Checked
        cboClsRegTern.Enabled = Not rbClsRegPerStud.Checked
    End Sub



    Private Sub txtCrCreditor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrCreditor.TextChanged
        lbCreditors.Visible = True
        lbCreditors.Items.Clear()
        Dim sql As String = " select account,name from creditors where cast([account] as nvarchar) + ' ' + [name] like '%" & txtCrCreditor.Text & "%'"
        Dim drr As SqlDataReader = ExecuteReader(sql)
        If drr.HasRows Then
            While drr.Read
                lbCreditors.Items.Add(drr(0).ToString + "-" + drr(1).ToString)
            End While
        End If
    End Sub

    Private Sub lbCreditors_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbCreditors.DoubleClick
        Dim creditor$
        Try
            Dim a, b As Integer
            Dim sql2 As String
            Dim searchstring As String
            b = InStr(Trim(lbCreditors.SelectedItem), "-")
            searchstring = Mid(Trim(lbCreditors.SelectedItem), 1, b - 1)
            txtCrCreditor.Text = searchstring
            sql2 = " select [name] from creditors where account = '" & searchstring & "'"
            creditor = ExecuteScalar(sql2)
            '  Label24.Text = creditor
            '  If Not IsNothing(creditor) Then


            lbCreditors.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbCreditors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbCreditors.SelectedIndexChanged

    End Sub

    Private Sub rbCreditorStat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCreditorStat.CheckedChanged
        txtCrCreditor.Enabled = rbCreditorStat.Checked
    End Sub

    Private Sub txtHistSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHistSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbHistSearch.Visible = False
        End If
    End Sub

    Private Sub txtHistSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHistSearch.TextChanged
        Dim sql As String
        Dim drr As SqlDataReader
        lbHistSearch.Items.Clear()
        lbHistSearch.Visible = True

        If rbHistoryPerBook.Checked Then
            sql = "select serial,title,type from bookmaster where serial + ' ' + title like '%" & txtHistSearch.Text & "%'"

            drr = ExecuteReader(sql, , True)

            While drr.Read
                lbHistSearch.Items.Add(drr(0).ToString + "~" + drr(1).ToString + "~" + drr(2).ToString)
            End While
        Else
            sql = "select studentid,studentname,studentsurname  from vwusers where studentid + ' ' + studentname + ' ' + studentsurname like '%" & txtHistSearch.Text & "%'"

            drr = ExecuteReader(sql, , True)

            While drr.Read
                lbHistSearch.Items.Add(drr(0).ToString + "~" + drr(1).ToString + "~" + drr(2).ToString)
            End While
        End If
    End Sub

    Private Sub lbHistSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbHistSearch.DoubleClick

        Dim searchtext As String
        Dim trimsplit() As String

        trimsplit = Split(lbHistSearch.SelectedItem, "~")
        searchtext = trimsplit(0).ToString
        txtHistSearch.Text = searchtext
        lbHistSearch.Visible = False
    End Sub

    Private Sub lbHistSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbHistSearch.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubtaughtteachers.TextChanged
        Dim serchtext As String = Trim(txtsubtaughtteachers.Text)
        lbteachers.Items.Clear()
        Dim drr As SqlDataReader

        lbteachers.Visible = True
        Dim sql As String = " select staffID,name,surname,stafftype from staffpersonaldetails where  name + ' ' + surname like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lbteachers.Items.Add(drr(0).ToString & " " & drr(1).ToString & " " & drr(2).ToString)
        End While
        ' End If

    End Sub

    Private Sub lbteachers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbteachers.DoubleClick
        Try
            Dim a, b As Integer
            Dim searchstring As String
            b = InStr(Trim(lbteachers.SelectedItem.ToString), " ")
            searchstring = Mid(Trim(lbteachers.SelectedItem.ToString), 1, b - 1)
            txtsubtaughtteachers.Text = searchstring
            lbteachers.Items.Clear()
            lbteachers.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbteachers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbteachers.SelectedIndexChanged

    End Sub

    Private Sub cboSubTaughtSubject_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubTaughtSubject.TextChanged
        Dim serchtext As String = Trim(cboSubTaughtSubject.Text)
        lbSubjects.Items.Clear()
        Dim drr As SqlDataReader

        lbSubjects.Visible = True
        Dim sql As String = " select subjectid,subject from subjects  where  subjectid + ' ' + subject like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lbSubjects.Items.Add(drr(0).ToString & " " & drr(1).ToString)
        End While
    End Sub

    Private Sub lbSubjects_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbSubjects.DoubleClick
        Try
            Dim a, b As Integer
            Dim searchstring As String
            b = InStr(Trim(lbSubjects.SelectedItem.ToString), " ")
            searchstring = Mid(Trim(lbSubjects.SelectedItem.ToString), 1, b - 1)
            cboSubTaughtSubject.Text = searchstring
            lbSubjects.Items.Clear()
            lbSubjects.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbSubTaughtPerTeacher_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSubTaughtPerTeacher.CheckedChanged
        ' If rbSubTaughtPerTeacher.Checked Then
        txtsubtaughtteachers.Enabled = False
        cboSubTaughtSubject.Enabled = False
        ' End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboHsMarksStud_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHsMarksStud.TextChanged
        Dim serchtext As String = Trim(cboHsMarksStud.Text)
        lbMarksPerStud.Items.Clear()
        Dim drr As SqlDataReader

        lbMarksPerStud.Visible = True
        Dim sql As String = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        Try
            While drr.Read
                lbMarksPerStud.Items.Add(drr(0) & " " & drr(1) & " " & drr(2))
            End While
            ' End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbMarksPerStud_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbMarksPerStud.DoubleClick
        Try
            cboHsMarksStud.Text = lbMarksPerStud.SelectedItem.ToString
            lbMarksPerStud.Items.Clear()
            Dim stud$
            Try
                Dim a, b As Integer
                Dim sql2 As String
                Dim searchstring As String
                b = InStr(Trim(cboHsMarksStud.Text), " ")
                searchstring = Mid(Trim(cboHsMarksStud.Text), 1, b - 1)
                sql2 = " select studentid from studentpersonaldetails where studentid = '" & searchstring & "'"
                stud = ExecuteScalar(sql2)
                cboHsMarksStud.Text = stud
            Catch
            End Try
            lbMarksPerStud.Visible = False
        Catch ex As Exception

        End Try
    End Sub





    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProfileStud.TextChanged
        Dim serchtext As String = Trim(txtProfileStud.Text)
        lbstudprofile.Items.Clear()
        Dim drr As SqlDataReader

        lbstudprofile.Visible = True
        Dim sql As String = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        Try
            While drr.Read
                lbstudprofile.Items.Add(drr(0) & "-" & drr(1) & "-" & drr(2))
            End While
            ' End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbstudprofile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbstudprofile.DoubleClick

        Dim res() As String
        res = lbstudprofile.SelectedItem.ToString.Split("-")
        txtProfileStud.Text = res(0)
        lbstudprofile.Visible = False

    End Sub



    Private Sub rbEmailClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If rbEmailClass.Checked Then
        '    '  cboHsMarksProg.Enabled = True
        '    '; cbHsMarksStud.Enabled = False
        '    cboHsMarksLev.Enabled = True
        '    ' cboHsMarksSem.Enabled = True
        '    cboHsMarksRef.Enabled = True
        '    cboHsMarksSess.Enabled = True
        '    cboHsMarksSessto.Enabled = True
        '    cboHsMarksStud.Enabled = False
        '    ' cboHsMarksSub.Enabled = False
        '    ' cboHsMarksClass.Enabled = True
        'End If
    End Sub

    Private Sub RbPublishPerClass_CheckedChanged(sender As Object, e As EventArgs) Handles RbPublishPerClass.CheckedChanged
        gblnPublishPerClass = RbPublishPerClass.Checked

        If RbPublishPerClass.Checked Then
            cboHsMarksLev.Enabled = True
            cboHsMarksRef.Enabled = True
            cboHsMarksSess.Enabled = True
            cboHsMarksStud.Enabled = False
            cboHsMarksSect.Enabled = True
        End If
    End Sub

    Private Sub rbPublishPerExam_CheckedChanged(sender As Object, e As EventArgs) Handles rbPublishPerExam.CheckedChanged
        gblnPublishPerExam = rbPublishPerExam.Checked
        If rbPublishPerExam.Checked Then
            cboHsMarksLev.Enabled = False
            cboHsMarksRef.Enabled = True
            cboHsMarksSess.Enabled = False
            cboHsMarksStud.Enabled = False
            cboHsMarksSect.Enabled = True
        End If
    End Sub

    Private Sub chkPublish_CheckedChanged(sender As Object, e As EventArgs) Handles chkPublish.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles txtAccStud.TextChanged
        Dim serchtext As String = Trim(txtAccStud.Text)
        StudSearch(lbAccStud, serchtext)


    End Sub



    Private Sub lbAccStud_DoubleClick(sender As Object, e As EventArgs) Handles lbAccStud.DoubleClick
        Try
            txtAccStud.Text = lbAccStud.SelectedValue
            lbAccStud.DataSource = Nothing
            lbAccStud.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs) Handles Label50.Click

    End Sub

    Private Sub btnAddEnrol_Click(sender As Object, e As EventArgs) Handles btnAddEnrol.Click
        Dim enrol As New Enrol

        With enrol
            .Program = cboSchoolEnrolSection.SelectedValue
            .Clas = cboSchoolenrolClass.Text
        End With

        If classList.Exists(Function(x) x.Clas = enrol.Clas And x.Program = enrol.Program) Then
            MsgBox("Enrollment Already added")
            Exit Sub
        End If

        lbAnalysisEnrols.Items.Add(enrol.Program & "-" & enrol.Clas)

        classList.Add(enrol)

    End Sub

    Private Sub lbAnalysisEnrols_DoubleClick(sender As Object, e As EventArgs) Handles lbAnalysisEnrols.DoubleClick
        Dim i As Integer = lbAnalysisEnrols.SelectedIndex
        Try
            lbAnalysisEnrols.Items.RemoveAt(i)

            classList.RemoveAt(i)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkClssAge_CheckedChanged(sender As Object, e As EventArgs) Handles chkClssAge.CheckedChanged
        gbClassAgeRange.Enabled = chkClssAge.Checked
    End Sub

    Private Sub chkEmail_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmail.CheckedChanged
        gbCustomEmailmsg.Visible = chkEmail.Checked
    End Sub
End Class