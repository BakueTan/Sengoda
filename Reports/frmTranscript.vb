'
Imports System
Imports System.Data.SqlClient
'Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Mail

Imports System.Data
Imports Miscelleneous
Imports System.Windows.Forms

Public Class frmTranscript
    Public frmmain As Form
    Private prgbar As dgProgressBar

    Public Sub New()

        ' This call is required by the Windows Form Designer

        InitializeComponent()
        MdiParent = frmMain
        hidereports()
        selectreports()
        Dock = DockStyle.Fill
        'dgLoadProgressBar.Close()


        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub hidereports()


        For Each ctrl As Control In Panel1.Controls

            ctrl.Visible = False



        Next



    End Sub
    Public Sub frmTranscript_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsRevoReports.SchoolFeesPayments' table. You can move, or remove it, as needed.
        '      Me.SchoolFeesPaymentsTableAdapter.Fill(Me.dsRevoReports.SchoolFeesPayments)
        'TODO: This line of code loads data into the 'dsRevoReports.AcademicReport' table. You can move, or remove it, as needed.
        '   Me.AcademicReportTableAdapter.Fill(Me.dsRevoReports.AcademicReport)
        'TODO: This line of code loads data into the 'dsRevoReports.AcademicReport' table. You can move, or remove it, as needed.
        '  Me.AcademicReportTableAdapter.Fill(Me.dsRevoReports.AcademicReport)
        'TODO: This line of code loads data into the 'dsRevoReports.EnrollmentAnalysis' table. You can move, or remove it, as needed.
        '   Me.EnrollmentAnalysisTableAdapter.Fill(Me.dsRevoReports.EnrollmentAnalysis)
        'TODO: This line of code loads data into the 'dsRevoReports.EnrollmentAnalysis' table. You can move, or remove it, as needed.
        '     Me.EnrollmentAnalysisTableAdapter.Fill(Me.dsRevoReports.EnrollmentAnalysis)
        'TODO: This line of code loads data into the 'dsRevoReports.ClassList' table. You can move, or remove it, as needed.
        'Me.ClassListTableAdapter.Fill(Me.dsRevoReports.ClassList)
        'TODO: This line of code loads data into the 'dsRevoReports.EnrollmentAnalysis' table. You can move, or remove it, as needed.
        '   Me.EnrollmentAnalysisTableAdapter.Fill(Me.dsRevoReports.EnrollmentAnalysis)
        'TODO: This line of code loads data into the 'dsRevoReports.EnrollmentAnalysis' table. You can move, or remove it, as needed.
        '  Me.EnrollmentAnalysisTableAdapter.Fill(Me.dsRevoReports.EnrollmentAnalysis)
        'TODO: This line of code loads data into the 'dsRevoReports.EnrollmentAnalysis' table. You can move, or remove it, as needed.
        '     Me.EnrollmentAnalysisTableAdapter.Fill(Me.dsRevoReports.EnrollmentAnalysis)
        'TODO: This line of code loads data into the 'dsRevoReports.EnrollmentAnalysis' table. You can move, or remove it, as needed.
        ' Me.EnrollmentAnalysisTableAdapter.Fill(Me.dsRevoReports.EnrollmentAnalysis)
        'TODO: This line of code loads data into the 'dsRevoReports.EnrollmentAnalysis' table. You can move, or remove it, as needed.
        '   Me.EnrollmentAnalysisTableAdapter.Fill(Me.dsRevoReports.EnrollmentAnalysis)
        'TODO: This line of code loads data into the 'dsRevoReports.AcademicReport' table. You can move, or remove it, as needed.
        '   Me.AcademicReportTableAdapter.Fill(Me.dsRevoReports.AcademicReport)
        'TODO: This line of code loads data into the 'dsRevoReports.AcademicReport' table. You can move, or remove it, as needed.
        '    Me.AcademicReportTableAdapter.Fill(Me.dsRevoReports.AcademicReport)
        'TODO: This line of code loads data into the 'dsRevoReports.FeesLedgerTransactions' table. You can move, or remove it, as needed.
        '   Me.FeesLedgerTransactionsTableAdapter.FillByTransactions(Me.dsRevoReports.FeesLedgerTransactions)
        'TODO: This line of code loads data into the 'dsRevoReports.FeesLedgerTransactions' table. You can move, or remove it, as needed.
        '  Me.FeesLedgerTransactionsTableAdapter.FillByTransactions(Me.dsRevoReports.FeesLedgerTransactions)
        'TODO: This line of code loads data into the 'dsRevoReports.FeesLedgerTransactions' table. You can move, or remove it, as needed.
        '     Me.FeesLedgerTransactionsTableAdapter.FillByTransactions(Me.dsRevoReports.FeesLedgerTransactions)
        'TODO: This line of code loads data into the 'dsRevoReports.SchoolFeesDebtors' table. You can move, or remove it, as needed.
        '  Me.SchoolFeesDebtorsTableAdapter.FillbyDebtors(Me.dsRevoReports.SchoolFeesDebtors)

        MdiParent = frmmain
        Dock = DockStyle.Fill



    End Sub
    Public Sub selectreports()

        Select Case gstrTvSelNod
            Case "StudentProfile"
                Try
                    Me.LedgerTransactionsTableAdapter.FillBystudall(Me.dsReports.LedgerTransactions, 0, gstrprofileperiod, goUser.FullName, "", gstrprofilestud)
                Catch ex As Exception

                End Try
                Try
                    Me.StudentPersonalDetailsTableAdapter.FillByStud(Me.dsReports.StudentPersonalDetails, gstrprofilestud)
                Catch ex As Exception

                End Try

                Try
                    Me.HsExamMarksTableAdapter.FillByStud(Me.dsReports.HsExamMarks, "", "", gstrprofileexam, gstrprofilestud)
                Catch ex As Exception

                End Try
                Try
                    Me.CurrentIssuesTableAdapter.FillByBorrower(Me.dsLibraryReports.CurrentIssues, gstrprofilestud)
                Catch ex As Exception

                End Try
                Try
                    Me.StudbehaviorTableAdapter.FillByStud(Me.dsReports.Studbehavior, gstrprofilestud)
                Catch ex As Exception

                End Try



            Case "Knowhow Analysis"
                Me.KnowhowAnalysisTableAdapterTableAdapter.Fill(Me.dsReports.KnowhowAnalysisTableAdapter, gstrknwhowanalprog, gstrknwhowanalintak, gstrknwhowanalsess, gstrknwhowanalclass)
                rvKnowhwanalysis.Visible = True
                rvKnowhwanalysis.Dock = DockStyle.Fill
                Me.rvKnowhwanalysis.RefreshReport()


            Case "Cumulative Payments"
                'If gblnAccPerClass Then

                '    rvAccCumPay.Visible = True
                '    rvAccCumPay.Dock = DockStyle.Fill
                '    Me.rvAccCumPay.RefreshReport()
                'ElseIf gblnAccPerSub Then
                '    Me.PaymentsPerSubjectTableAdapter.FillbySubject(Me.dsReports.PaymentsPerSubject, gstrAccPrdFrom, gstrAccPrdTo, gstrAccSub, gstrAccIntk, gstrAccSess, gstrAccClass, gstrPayType)
                '    rvAccPayPerSub.Visible = True
                '    rvAccPayPerSub.Dock = DockStyle.Fill
                '    Me.rvAccPayPerSub.RefreshReport()
                If gblnAccDebtors Then




                    Me.SchoolFeesDebtorsTableAdapter.FillbyDebtors(Me.dsRevoReports.SchoolFeesDebtors, gstrPayType, goUser.FullName, "", gstrAccPrdFrom, gstrAccPrdTo, gstrAccLvl, gstrAccSess, gstrAccClass, gstrAccSection, True)

                    rvDebtorsContacts.Dock = DockStyle.Fill
                    rvDebtorsContacts.RefreshReport()
                    rvDebtorsContacts.Visible = True


                ElseIf gblnSectDebts Then





                    If gstrAccSection <> "NonStudent" Then
                            Me.DebtorsContactsTableAdapter.FillBysectall(Me.dsReports.DebtorsContacts, goUser.FullName, gstrAccSection, gstrAccStatus, gstrAccPrdTo, gstrAccClass, gstrAccClass2)

                            rvDebtorsBySection.Dock = DockStyle.Fill
                            rvDebtorsBySection.RefreshReport()
                            rvDebtorsBySection.Visible = True
                        Else
                            Me.OtherDebtorsTableAdapter.Fill(Me.dsReports.OtherDebtors, goUser.FullName, gstrAccPrdTo)

                            rvOtherDebtors.Dock = DockStyle.Fill
                            rvOtherDebtors.RefreshReport()
                            rvOtherDebtors.Visible = True
                        End If

                ElseIf gblnAccPerStud Then




                    '  End If
                    Try
                        Me.SchoolFeesStatementTableAdapter.FillByStudent(dsRevoReports.SchoolFeesStatement, gstrPayType, gstrAccStud, goUser.FullName, gstraccAddinfo, gstrAccPrdFrom, gstrAccPrdTo, gstrAccBBFCutOffPeriod, gblnShowInvoices, gblnShowReceipts)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Close()
                    End Try

                    rvClassStat.Dock = DockStyle.Fill
                    Me.rvClassStat.RefreshReport()
                    rvClassStat.Visible = True

                ElseIf gblnClassStat Then


                    Try
                        Me.SchoolFeesStatementTableAdapter.FillByClass(dsRevoReports.SchoolFeesStatement, gstrPayType, goUser.FullName, gstraccAddinfo, gstrAccPrdFrom, gstrAccPrdTo, gstrAccLvl, gstrAccSess, gstrAccClass, gstrAccSection, gblnDebtorsOnly, gstrAccBBFCutOffPeriod)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Close()
                    End Try

                    rvClassStat.Dock = DockStyle.Fill
                    Me.rvClassStat.RefreshReport()
                    rvClassStat.Visible = True

                ElseIf gblnAccPerForm Then


                    Me.SchoolFeesPaymentsTableAdapter.Fill(Me.dsRevoReports.SchoolFeesPayments, gstrPayType, goUser.FullName, "", gstrAccPrdFrom, gstrAccPrdTo, gstrAccLvl, gstrAccSess, gstrAccClass, gstrAccSection, gblnShowInvoices, gblnShowReceipts)

                    rvPymntsPerForm.Dock = DockStyle.Fill
                    Me.rvPymntsPerForm.RefreshReport()
                    rvPymntsPerForm.Visible = True
                    '     End If

                ElseIf gblnOtherDebtors Then
                    If Trim(gstrPayType.ToUpper) = "ALL" Then
                        Me.DebtorsTransactionsTableAdapter.FillByOnScreenAll(Me.dsReports.DebtorsTransactions, gstrAccPrdFrom, gstrAccPrdTo, goUser.FullName, gstraccAddinfo, gstrAccStud)

                        rvDebtorsStatements.Dock = DockStyle.Fill
                        Me.rvDebtorsStatements.RefreshReport()
                        rvDebtorsStatements.Visible = True
                    End If
                End If


            Case "Class Students"

                Dim where As String = ""
                If gblnclsAgeAnalysis Then
                    where = " and DATEDIFF(YYYY,DateOfBirth,getdate()) between '" & gstrClassStudAgeFrom & "' and '" & gstrClassStudAgeto & "' "
                End If


                If gstrClassStudsSex <> "All" Then
                    where = where & " and e.gender = '" & gstrClassStudsSex & "'"

                End If

                'If clsperiodanalysis Then
                '    where = where & " and e.date_enrolled between '" & gdtenrolPeriodAnalysisDatefrom & "' and '" & gdtenrolPeriodAnalysisDatefrom & "'"
                'End If



                Me.ClassListTableAdapter.FillByClass(Me.dsRevoReports.ClassList, gstrClassStudsSlctProg, gstrClassYr, gstrClassStudsSess, gstrClassStudClass, where, clsperiodanalysis, gdtenrolPeriodAnalysisDatefrom, gdtenrolPeriodAnalysisDateTo)

                rvStudentClasses.Dock = DockStyle.Fill
                        Me.rvStudentClasses.RefreshReport()
                        rvStudentClasses.Visible = True





                'Try
                '    Show()
                'Catch ex As Exception
                '    System.Windows.Forms.MessageBox.Show(ex.Message)
                'End Try

            Case "School Enrollment"


                Dim classcollection As String = "('"




                Dim i As Integer = 0


                Dim wherefilter As String = ""
                '= " where program = '" & gstrSchoolEnrolProgram & "' "


                If classList.Any Then
                    For Each cls As Enrol In classList

                        If i = 0 Then
                            If cls.Clas = "ALL" Then
                                wherefilter = " where (( section = '" & cls.Program & "')"
                            Else
                                wherefilter = " where (( classdesc = '" & cls.Clas & "' and section= '" & cls.Program & "')"
                            End If
                            '      wherefilter = " where ((program = '" & cls.Program & "' and yearenrolled = '" & cls.Clas & "' and intake = '" & cls.Intake & "')"
                        Else
                            If cls.Clas = "ALL" Then
                                wherefilter = wherefilter & " or ( section = '" & cls.Program & "' )"
                            Else
                                wherefilter = wherefilter & " or ( classdesc = '" & cls.Clas & "' and section = '" & cls.Program & "')"
                            End If

                        End If


                        i += 1

                    Next

                    wherefilter = wherefilter & ")"


                Else
                    MsgBox("Enrollment List is Empty")
                    Exit Sub
                End If

                i = 0



                Me.EnrollmentAnalysisTableAdapter.FillByEnrollment(Me.dsRevoReports.EnrollmentAnalysis, wherefilter, gdtenrolPeriodAnalysisDatefrom, gdtenrolPeriodAnalysisDateTo, enrolPeriodAnalysis)

                If gblnGraphical Then
                    rvEnrolAnalysis.Dock = DockStyle.Fill
                    rvEnrolAnalysis.RefreshReport()
                    rvEnrolAnalysis.Visible = True
                Else
                    rvSchoolEnrollment.Dock = DockStyle.Fill
                    rvSchoolEnrollment.RefreshReport()
                    rvSchoolEnrollment.Visible = True
                End If




            Case "Student Personal Details"

                ' Me.StudentPersonalDetailsTableAdapter.Fill(Me.dsReports.StudentPersonalDetails, gstrStudPersStatus)

                ' rvStudDetails.Show()
                ' rvStudDetails.Dock = DockStyle.Fill
            Case "FeesPayments"
                '  Me.StudPaymentsTableAdapter.Fill(Me.pastelDataSet.StudPayments)

                rvStudPayments.Dock = DockStyle.Fill
                Me.rvStudPayments.RefreshReport()
                rvStudPayments.Visible = True

            Case "Exam Marks"
                '        prgbar = New dgProgressBar

                '     prgbar.Show()
                
If gblnHsMarksPerClass Then
                    '
                    Try
                        Me.AcademicReportTableAdapter.Fill(Me.dsRevoReports.AcademicReport, gstrHsMarksRef, "0", gstrHsMarksLev, gstrHsMarkSess, gstrMarkSection)


                        '   prgbar.Timer1_Tick(Me, Nothing)
                    Catch ex As Exception

                        '  prgbar.Timer1_Tick(Me, Nothing)
                    End Try


                    If gblnGraphical Then
                        rvExamStudGraphAnalysis.Dock = DockStyle.Fill
                        rvExamStudGraphAnalysis.RefreshReport()
                        rvExamStudGraphAnalysis.Visible = True
                    Else
                        rvHsMarksPerClass.Dock = DockStyle.Fill
                        '
                        Me.rvHsMarksPerClass.RefreshReport()
                        rvHsMarksPerClass.Visible = True

                    End If







                ElseIf gblnHsMarksPerSub Then

                    pos = 1
                    '
                    Try
                        Me.AcademicReportTableAdapter.Fill(Me.dsRevoReports.AcademicReport, gstrHsMarksRef, "0", gstrHsMarksLev, gstrHsMarkSess, gstrMarkSection)

                        pos += 2
                        '   prgbar.Timer1_Tick(Me, Nothing)
                    Catch ex As Exception

                        pos += 1
                        '  prgbar.Timer1_Tick(Me, Nothing)
                    End Try

                    If gblnGraphical Then
                        rvExamSubGrapAnalysis.Dock = DockStyle.Fill
                        rvExamSubGrapAnalysis.RefreshReport()
                        rvExamSubGrapAnalysis.Visible = True
                    Else
                        rvHsMarksPerSub.Dock = DockStyle.Fill
                        Me.rvHsMarksPerSub.RefreshReport()
                        rvHsMarksPerSub.Visible = True
                    End If

                ElseIf gblnreportPerClass Then



                    If gblnmailperclass Then
                        triggerMail(True)
                    End If



                    Me.AcademicReportTableAdapter.Fill(Me.dsRevoReports.AcademicReport, gstrHsMarksRef, "0", gstrHsMarksLev, gstrHsMarkSess, gstrMarkSection)

                    '
                    If gstrHsMarksLev >= 5 Then
                        rvHsReport_Alevel.Dock = DockStyle.Fill
                        Me.rvHsReport_Alevel.RefreshReport()
                        rvHsReport_Alevel.Visible = True
                    Else

                        rvHsStudReport.Dock = DockStyle.Fill
                        Me.rvHsStudReport.RefreshReport()
                        rvHsStudReport.Visible = True
                    End If

                    '


                ElseIf gblnReportPerstud Then

                    Dim cnn As New SqlConnection(ConnectionString)
                    Dim studs As SqlDataReader = Nothing
                    Dim prog As String = ""
                    If gblnmailperclass Then
                        triggerMail(False)
                    End If
                    Try
                        sqltext = "spGetClassEmails"
                        cnn.Open()
                        cmd = New SqlCommand(sqltext, cnn)
                        With cmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@exam", gstrHsMarksRef)
                            .Parameters.AddWithValue("@lvl", "")
                            .Parameters.AddWithValue("@session", "")
                            .Parameters.AddWithValue("@sect", "")
                            .Parameters.AddWithValue("@stud", gstrHsMarksStud)
                            studs = .ExecuteReader()
                        End With
                    Catch ex As Exception
                    Finally
                        '      cnn.Close()


                    End Try



                    If studs.HasRows Then
                        While studs.Read
                            prog = studs("forms")
                        End While
                    End If




                    Me.AcademicReportTableAdapter.FillByStudent(Me.dsRevoReports.AcademicReport, gstrHsMarksRef, gstrHsMarksStud)



                    If prog.ToUpper = "O_LEVEL" Then
                        rvHsStudReport.Dock = DockStyle.Fill
                        Me.rvHsStudReport.RefreshReport()
                        rvHsStudReport.Visible = True
                    Else
                        rvHsReport_Alevel.Dock = DockStyle.Fill
                        Me.rvHsReport_Alevel.RefreshReport()
                        rvHsReport_Alevel.Visible = True
                    End If





                ElseIf gblnHsPublish Then
                    Dim sql As String
                    cnn = New SqlConnection(ConnectionString)

                    If gblnPublishPerClass Then

                        Try

                            Dim cnt As Integer = 0
                            cnn.Open()
                            sql = "spPublishPerClass"
                            cmd = New SqlCommand(sql, cnn)
                            With cmd
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.AddWithValue("@sect", gstrMarkSection)
                                .Parameters.AddWithValue("@exam", gstrHsMarksRef)
                                .Parameters.AddWithValue("@lvl", gstrHsMarksLev)
                                .Parameters.AddWithValue("@user", goUser.FullName)
                                .Parameters.AddWithValue("@session", gstrHsMarkSess)
                                .Parameters.AddWithValue("@publish", gblnPublish)
                                param = New SqlParameter()
                                param.ParameterName = "@pubcount"
                                param.DbType = DbType.Int16
                                param.Direction = ParameterDirection.Output
                                .Parameters.Add(param)
                                .ExecuteNonQuery()
                                cnt = .Parameters("@pubcount").Value
                                MsgBox(cnt & " Students' Results published for the selected Class")

                            End With
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            cnn.Close()
                            Close()
                        End Try
                    ElseIf gblnPublishPerExam Then

                        Try

                            Dim cnt As Integer = 0
                            cnn.Open()
                            sql = "spPublishPerExam"
                            cmd = New SqlCommand(sql, cnn)
                            With cmd
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.AddWithValue("@sect", gstrMarkSection)
                                .Parameters.AddWithValue("@exam", gstrHsMarksRef)
                                .Parameters.AddWithValue("@user", goUser.FullName)
                                .Parameters.AddWithValue("@publish", gblnPublish)
                                param = New SqlParameter()
                                param.ParameterName = "@pubcount"
                                param.DbType = DbType.Int16
                                param.Direction = ParameterDirection.Output
                                .Parameters.Add(param)
                                .ExecuteNonQuery()
                                cnt = .Parameters("@pubcount").Value
                                MsgBox(cnt & " Students' Results published for the selected Exam")

                            End With
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            cnn.Close()
                            Close()
                        End Try

                    End If
                ElseIf gblnconsolmarks Then

                    Try
                        Me.AcademicReportTableAdapter.Fill(Me.dsRevoReports.AcademicReport, gstrHsMarksRef, "0", gstrHsMarksLev, gstrHsMarkSess, gstrMarkSection)

                    Catch ex As Exception

                    End Try


                    rvConsolMarkSheet.Dock = DockStyle.Fill
                    Me.rvConsolMarkSheet.RefreshReport()
                    rvConsolMarkSheet.Visible = True

                End If

            Case "GraphicalAnalysis"
                If gblnHsMarksPerStud Then
                    pos = 0
                    studs = 3
                    prgbar = New dgProgressBar
                    prgbar.Show()
                    prgbar.Visible = True
                    Try
                        Me.HsExamMarksTableAdapter.FillByAllExams(Me.dsReports.HsExamMarks, gstrHsMarkSessto, gstrHsMarksLev, gstrHsMarkSess, gstrHsMarksRef, gstrMarkSection)
                    Catch ex As Exception

                    End Try

                    pos += 2
                    prgbar.Timer1_Tick(Me, Nothing)
                    'rvGraphPerStud.Dock = DockStyle.Fill
                    'rvGraphPerStud.RefreshReport()
                    pos += 1
                    prgbar.Timer1_Tick(Me, Nothing)

                    prgbar.Close()
                    Me.Visible = True
                ElseIf gblnHsMarksPerSub Then
                    pos = 0
                    studs = 3
                    prgbar = New dgProgressBar
                    prgbar.Show()
                    prgbar.Visible = True
                    Try
                        Me.HsExamMarksTableAdapter.FillByAllExams(Me.dsReports.HsExamMarks, gstrHsMarkSessto, gstrHsMarksLev, gstrHsMarkSess, gstrHsMarksRef, gstrMarkSection)
                    Catch ex As Exception

                    End Try
                    pos += 2
                    prgbar.Timer1_Tick(Me, Nothing)
                    'rvGraphPerSub.Dock = DockStyle.Fill
                    'rvGraphPerSub.RefreshReport()
                    Me.Visible = True
                    prgbar.Close()
                End If


            Case "ExamAttendance"
                Me.ExamAttendanceTableAdapter.FillByExam(Me.dsReports.ExamAttendance, gstrExamAttExam, gstrExamAttSub)
                rvExamAttendance.Visible = True
                rvExamAttendance.Dock = DockStyle.Fill
                Me.rvExamAttendance.RefreshReport()
            Case "PaymentsPerDate"

                If gblnFeesDetail Then


                    Me.FeesLedgerTransactionsTableAdapter.FillByTransactions(Me.dsRevoReports.FeesLedgerTransactions, gdatefrom, gdateTo, gstrfizpaypfrom, gstrfizpaypto, gpdatefrom, gpdateto, gstruser, gstrPayType, gstrcashtype, gstrCurrency)

                    rvPaymentsByDate.Dock = DockStyle.Fill

                                rvPaymentsByDate.RefreshReport()
                                rvPaymentsByDate.Visible = True

                Else
                    Me.FeesLedgerTransactionsTableAdapter.FillByTransactions(Me.dsRevoReports.FeesLedgerTransactions, gdatefrom, gdateTo, gstrfizpaypfrom, gstrfizpaypto, gpdatefrom, gpdateto, gstruser, gstrPayType, gstrcashtype, gstrCurrency)

                    rvFeesAnalysis.Dock = DockStyle.Fill
                    Me.rvFeesAnalysis.RefreshReport()
                    rvFeesAnalysis.Visible = True
                End If
                'Else
                'Me.FeesPaymentsByDateTableAdapter.FillByPeriod(Me.dsReports.FeesPaymentsByDate, gstrfizpaypfrom, gstrfizpaypto)
                'rvFeesAnalysisPerPeriod.RefreshReport()
                'rvFeesAnalysisPerPeriod.Visible = True
                'rvFeesAnalysisPerPeriod.Dock = DockStyle.Fill

                ' End If




            Case "Register3"
                'If gstrSubRegSect <> "High School" Then
                '    Me.StudentRegisterTableAdapter.FillBySub(Me.dsReports.StudentRegister, gstrSubRegSect, gstrSubRegSub, gstrSubRegCls, gstrSubRegIntk, gstrSubRegSess)
                '    If Me.dsReports.StudentRegister.Count > 0 Then
                '        rvSubReg.Visible = True
                '        rvSubReg.Dock = DockStyle.Fill
                '        rvSubReg.RefreshReport()
                '    Else
                '        MsgBox("Selected Class does not have any Students check the Class and try again")
                '        Exit Sub
                '    End If
                'Else

                '    Me.StudentRegisterTableAdapter.FillByHighSchool(Me.dsReports.StudentRegister, gstrSubRegSect, gstrSubRegSub, gstrSubRegCls, gstrSubRegIntk, gstrSubRegSess, gstrSubRegLvl, gstrSubRegSem, gstrSubRegProg)
                '    If Me.dsReports.StudentRegister.Count > 0 Then
                '        rvSubReg.Visible = True
                '        rvSubReg.Dock = DockStyle.Fill
                '        rvSubReg.RefreshReport()
                '    Else
                '        MsgBox("Selected Class does not have any Students check the Class and try again")
                '        Exit Sub
                '    End If
                '    ' Else

                'End If





                'Me.StudentRegisterTableAdapter.Fill(dsReports.StudentRegister, gstrreg3section, gstrreg3subject, gstrreg3class, gstrreg3intake, gstrreg3session)
                'rvRegister3.Visible = True
                'rvRegister3.Dock = DockStyle.Fill
                'rvRegister3.RefreshReport()


            Case "UserLoginHistory"

                If gblnlogdin Then
                    Me.UserLoginHstryTableAdapter.FillByLogdin(dsReports.UserLoginHstry, "", "")
                    '  UserLoginHstryBindingSource .
                    rvUserLoginHistory.Visible = True
                    rvUserLoginHistory.Dock = DockStyle.Fill
                    rvUserLoginHistory.RefreshReport()
                ElseIf gblnbyUser Then
                    Me.UserLoginHstryTableAdapter.FillByusr(dsReports.UserLoginHstry, gdatelogfrm, gdatelogTo, gstruser)
                    rvUserLoginHistory.Visible = True
                    rvUserLoginHistory.Dock = DockStyle.Fill
                    rvUserLoginHistory.RefreshReport()

                ElseIf gblnbydate Then

                    Me.UserLoginHstryTableAdapter.FillByDate(dsReports.UserLoginHstry, gdatelogfrm, gdatelogTo)
                    rvUserLoginHistory.Visible = True
                    rvUserLoginHistory.Dock = DockStyle.Fill
                    rvUserLoginHistory.RefreshReport()



                End If
            Case "IDcards"
                If gblnidbyClass Then
                    Me.GroupCardsTableAdapter.FillByGroup(Me.dsReports.GroupCards, gstridclass, gstridterm, gstridgroup)

                    rvGroupCards.Dock = DockStyle.Fill
                    rvGroupCards.RefreshReport()
                    rvGroupCards.Visible = True
                Else
                    Me.StudentPersonalDetailsTableAdapter.FillByclass(dsReports.StudentPersonalDetails, gstridclass, gstridyr1, gstridyr2, gstridterm, gstridsess1, gstridsess2)

                    rvClassCards.Dock = DockStyle.Fill
                    rvClassCards.Dock = DockStyle.Fill
                    rvClassCards.RefreshReport()
                    rvClassCards.Visible = True
                End If



            Case "StaffQualifications"
                If gblnstaffqualbyqual Then
                    Me.StaffQualificationTableAdapter.Fill(dsReports.StaffQualification)

                    rvStaffByQual.Dock = DockStyle.Fill
                    rvStaffByQual.RefreshReport()
                    rvStaffByQual.Visible = True
                ElseIf gblnstaffQualByStaff Then
                    Me.StaffQualificationTableAdapter.Fill(dsReports.StaffQualification)

                    rvStaffByQualification.Dock = DockStyle.Fill
                    rvStaffByQualification.RefreshReport()
                    rvStaffByQualification.Visible = True
                End If

            Case "ClassRegister"
                If gblnClsRegPerDay Then

                    Me.ClassRegisterTableAdapter.FillByClass(dsReports.ClassRegister, gstrclsregatefrom, gstrClsRegDateto, gstrClsRegForm, gstrClsRegTerm, gstrClsRegCls, gstrClsRegSess)
                    rvClassRegister.Visible = True
                    rvClassRegister.Dock = DockStyle.Fill
                    rvClassRegister.RefreshReport()
                End If

            Case "BookDetails"
                If rbBookmasterPerbook Then
                    Me.BookMasterTableAdapter.Fill(dsLibraryReports.BookMaster)

                    rvBookInfo.Dock = DockStyle.Fill
                    rvBookInfo.RefreshReport()
                    rvBookInfo.Visible = True
                ElseIf rbBookmasterPerLvl Then
                    Me.BookMasterTableAdapter.Fill(dsLibraryReports.BookMaster)

                    rvBookMaster.Dock = DockStyle.Fill
                    rvBookMaster.RefreshReport()
                    rvBookMaster.Visible = True
                ElseIf rbBookmasterSummary Then
                    Me.BookMasterTableAdapter.Fill(dsLibraryReports.BookMaster)
                    rvBookSummary.Dock = DockStyle.Fill
                    rvBookSummary.RefreshReport()
                    rvBookSummary.Visible = True
                ElseIf rbBookmasterSummaryPerProg Then
                    Me.BookMasterTableAdapter.Fill(dsLibraryReports.BookMaster)
                    'rvSummaryPerProg.Dock = DockStyle.Fill
                    'rvSummaryPerProg.RefreshReport()
                    'rvSummaryPerProg.Visible = True
                End If
            Case "StaffRegister"
                If gblnstaffregbydate Then
                    Me.StaffRegisterTableAdapter.FillByDate(dsReports.StaffRegister, gstrstaffregdatefrm, gstrstaffregdateto)

                    rvStaffregisterByDate.Dock = DockStyle.Fill
                    rvStaffregisterByDate.RefreshReport()
                    rvStaffregisterByDate.Visible = True
                ElseIf gblnstaffregbystaff Then
                    Me.StaffRegisterTableAdapter.FillByDate(dsReports.StaffRegister, gstrstaffregdatefrm, gstrstaffregdateto)

                    'rvStaffRegisterByStaff.Dock = DockStyle.Fill
                    'rvStaffRegisterByStaff.RefreshReport()
                    'rvStaffRegisterByStaff.Visible = True
                End If

            Case "IncomeExpenditure"
                'TODO: This line of code loads data into the 'dsLibraryReports.BookMaster' table. You can move, or remove it, as needed.
                ' If gstrIncExpCrt.ToUpper = "ALL" Then
                If gstrIncExpCrt = "" Then
                    MsgBox("Invalid Cartegory")
                    Exit Sub
                End If
                If gstrIncExpCrt = "ALL" Then
                    If gblnIncExpSummary Then

                        Me.IncomeExpenditureTableAdapter.FillByDate(dsIncomeExpenditureReports.IncomeExpenditure, gstrIncExpdatefrm, gstrIncExpdateTo)
                        Me.rvIncomeExpenditure.Visible = True
                        rvIncomeExpenditure.Dock = DockStyle.Fill
                        rvIncomeExpenditure.RefreshReport()
                    ElseIf gblnIncExpDetailed Then
                        Me.IncomeExpenditureTableAdapter.FillByDate(dsIncomeExpenditureReports.IncomeExpenditure, gstrIncExpdatefrm, gstrIncExpdateTo)
                        rvIncExpDetailed.Visible = True
                        rvIncExpDetailed.Dock = DockStyle.Fill
                        rvIncExpDetailed.RefreshReport()
                    End If

                Else
                    If gblnIncExpSummary Then
                        Me.IncomeExpenditureTableAdapter.FillByCart(dsIncomeExpenditureReports.IncomeExpenditure, gstrIncExpdatefrm, gstrIncExpdateTo, gstrIncExpCrt)
                        Me.rvIncomeExpenditure.Visible = True
                        rvIncomeExpenditure.Dock = DockStyle.Fill
                        rvIncomeExpenditure.RefreshReport()
                    Else
                        Me.IncomeExpenditureTableAdapter.FillByCart(dsIncomeExpenditureReports.IncomeExpenditure, gstrIncExpdatefrm, gstrIncExpdateTo, gstrIncExpCrt)
                        Me.rvIncomeExpenditure.Visible = True
                        rvIncExpDetailed.Dock = DockStyle.Fill
                        rvIncExpDetailed.RefreshReport()
                    End If
                End If

            Case "BookIssues"
                If rbissuesbyStud Then
                    Try
                        Me.CurrentIssuesTableAdapter.FillByDate(Me.dsLibraryReports.CurrentIssues, gstrbookissuefrm, gstrbookissueTo)
                    Catch ex As Exception

                    End Try

                    rvBookIssuesPerStud.Visible = True
                    rvBookIssuesPerStud.Dock = DockStyle.Fill
                    rvBookIssuesPerStud.RefreshReport()
                ElseIf rbissuesbyDate Then
                    Try
                        Me.CurrentIssuesTableAdapter.FillByDate(Me.dsLibraryReports.CurrentIssues, gstrbookissuefrm, gstrbookissueTo)
                    Catch ex As Exception

                    End Try

                    rvBookIssuesPerDate.Visible = True
                    rvBookIssuesPerDate.Dock = DockStyle.Fill
                    rvBookIssuesPerDate.RefreshReport()
                ElseIf rbissuesbybook Then
                    Try
                        Me.CurrentIssuesTableAdapter.FillByDate(Me.dsLibraryReports.CurrentIssues, gstrbookissuefrm, gstrbookissueTo)
                    Catch ex As Exception

                    End Try

                    rvBookIssuesByBook.Visible = True
                    rvBookIssuesByBook.Dock = DockStyle.Fill
                    rvBookIssuesByBook.RefreshReport()
                End If
            Case "BorrowingHistory"

                If gblnborrowhisPerBook Then
                    Try
                        Me.CurrentIssuesTableAdapter.FillByBookHist(Me.dsLibraryReports.CurrentIssues, gstrborrowhist)
                    Catch ex As Exception

                    End Try

                    rvBookIssuesByBook.Visible = True
                    rvBookIssuesByBook.Dock = DockStyle.Fill
                    rvBookIssuesByBook.RefreshReport()
                Else
                    Try
                        Me.CurrentIssuesTableAdapter.FillByBorrower(Me.dsLibraryReports.CurrentIssues, gstrborrowhist)
                    Catch ex As Exception

                    End Try

                    rvBookIssuesPerStud.Visible = True
                    rvBookIssuesPerStud.Dock = DockStyle.Fill
                    rvBookIssuesPerStud.RefreshReport()
                End If

            Case "DueBy"
                Try
                    Me.CurrentIssuesTableAdapter.FillByDueDate(Me.dsLibraryReports.CurrentIssues, gstrdueby)
                Catch ex As Exception

                End Try

                rvDueBy.Visible = True
                rvDueBy.Dock = DockStyle.Fill
                rvDueBy.RefreshReport()

            Case "Creditors"

                'If gblncreditorstatement Then
                '    Me.CreditorsStatementTableAdapter.FillByStud(Me.dsIncomeExpenditureReports.CreditorsStatement, goUser.FullName, gstrcreditorsPrdTo, gstrcreditorsCreditor)
                '    rvCreditorStatement.Visible = True
                '    rvCreditorStatement.Dock = DockStyle.Fill
                '    rvCreditorStatement.RefreshReport()
                'Else
                '    Me.CreditorsContactsTableAdapter.Fill(Me.dsIncomeExpenditureReports.CreditorsContacts, goUser.FullName, gstrcreditorsPrdTo)
                '    rvAllCreditors.Visible = True
                '    rvAllCreditors.Dock = DockStyle.Fill
                '    rvAllCreditors.RefreshReport()
                'End If

        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub



    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub rvTransND_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rvISOASummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Function GradeCalc(ByVal avg As Decimal) As String
        Dim decison As String = ""
        If avg <= 49 Then
            decison = "F"
        ElseIf avg <= 59 Then
            decison = "3"
        ElseIf avg <= 64 Then
            decison = "2.2"
        ElseIf avg <= 74 Then
            decison = "2.1"
        ElseIf avg <= 100 Then
            decison = "1"
        End If
        Return decison
    End Function






    Private Sub rvAcdemicReport_Olevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rvHsReport_Alevel.Load

    End Sub

    Private Sub rvResultStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Function sendmail(ByVal recipient As String, ByVal report As MemoryStream, ByVal student As String) As Boolean
        Dim repname As String = student & ".pdf"
        Dim a As Attachment = New Attachment(report, repname)
        Try



            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()

            Dim osmtpclient As New CSmtp

            'Net.NetworkCredential("tangaiwasb@gmail.com", "bothwell")
            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Credentials = New _
                Net.NetworkCredential(osmtpclient.MailFrom, osmtpclient.Password)
            SmtpServer.Port = osmtpclient.Port
            SmtpServer.EnableSsl = False
            '  SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.Host = osmtpclient.Server
            mail = New MailMessage()
            mail.From = New MailAddress(osmtpclient.MailFrom)
            mail.To.Add(recipient)



            mail.Attachments.Add(a)


            mail.Subject = "Academic Report"
            mail.Body = "Please find Attached Academic Report for " & student & ". " & vbNewLine & gstrMarkEmailMsg

            SmtpServer.Send(mail)
            Return True
            ' MsgBox("mail send")
        Catch ex As Exception
              MsgBox(ex.ToString)
            Return False

        End Try




    End Function

    Private Function triggerMail(ByRef clas As Boolean) As String
        Dim sql As String
        Dim cnt As Integer = 0
        Dim studs As SqlDataReader = Nothing

        Dim pdffile() As Byte = Nothing
        Dim cnn As New SqlConnection(ConnectionString)

        Dim sentemails, nonsentemails As List(Of String)


        sentemails = New List(Of String)
        nonsentemails = New List(Of String)

        If clas Then


            Try
                sql = "spGetClassEmails"
                cnn.Open()
                cmd = New SqlCommand(sql, cnn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@exam", gstrHsMarksRef)
                    .Parameters.AddWithValue("@lvl", gstrHsMarksLev)
                    .Parameters.AddWithValue("@session", gstrHsMarkSess)
                    .Parameters.AddWithValue("@sect", gstrMarkSection)
                    .Parameters.AddWithValue("@stud", "0")
                    studs = .ExecuteReader()
                End With
            Catch ex As Exception

            End Try

            If studs.HasRows Then
                While studs.Read
                    Me.AcademicReportTableAdapter.FillByStudent(Me.dsRevoReports.AcademicReport, gstrHsMarksRef, studs(0))
                    If studs("forms").ToString.ToUpper = "O_LEVEL" Then
                        rvHsStudReport.RefreshReport()
                        pdffile = rvHsStudReport.LocalReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    Else
                        rvHsReport_Alevel.RefreshReport()
                        pdffile = rvHsReport_Alevel.LocalReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    End If

                    Dim s As MemoryStream = New MemoryStream(pdffile)
                    s.Seek(0, SeekOrigin.Begin)
                    If InStr(studs("EmailAddress").ToString, "@") > 1 Then
                        If sendmail(studs("EmailAddress"), s, studs("StudName")) Then

                            cnt += 1
                            sentemails.Add(studs("StudName"))
                        Else
                            nonsentemails.Add(studs("StudName"))

                        End If
                    Else
                        MsgBox("Invalid Email adrress for " & studs(0).ToString)
                        nonsentemails.Add(studs("StudName"))
                    End If

                End While
            Else
                MsgBox("Selected Class Empty")
            End If


            'If cnt >= 1 Then
            '    MsgBox(cnt & " email(s) successfully sent")

            'End If

            If sentemails.Any Then

                Dim file_name2 As String = ""
                MsgBox(sentemails.Count & " emails sent successfully, choose location to save the Students")


                OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
                OpenFileDialog1.FilterIndex = 2
                OpenFileDialog1.RestoreDirectory = True

                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    file_name2 = SaveFileDialog1.FileName
                    Using objwriter As New StreamWriter(file_name2)
                        For Each record In sentemails
                            objwriter.WriteLine(record)
                        Next
                        MsgBox("Save Successful")
                    End Using
                End If

            End If

            If nonsentemails.Any Then
                Dim file_name2 As String = ""
                MsgBox(sentemails.Count & " emails could not be sent , choose location to save the Students")


                OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
                OpenFileDialog1.FilterIndex = 2
                OpenFileDialog1.RestoreDirectory = True

                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    file_name2 = SaveFileDialog1.FileName
                    Using objwriter As New StreamWriter(file_name2)
                        For Each record In nonsentemails
                            objwriter.WriteLine(record)
                        Next
                        MsgBox("Save Successful")
                    End Using
                End If
            End If
        Else

            Try
                sql = "spGetClassEmails"
                cnn.Open()
                cmd = New SqlCommand(sql, cnn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@exam", gstrHsMarksRef)
                    .Parameters.AddWithValue("@lvl", gstrHsMarksLev)
                    .Parameters.AddWithValue("@session", gstrHsMarkSess)
                    .Parameters.AddWithValue("@sect", gstrMarkSection)
                    .Parameters.AddWithValue("@stud", gstrHsMarksStud)
                    studs = .ExecuteReader()
                End With
            Catch ex As Exception
            Finally
          '      cnn.Close()


            End Try

            If studs.HasRows Then
                While (studs.Read)
                    Me.AcademicReportTableAdapter.FillByStudent(Me.dsRevoReports.AcademicReport, gstrHsMarksRef, studs(0))
                    If studs("forms").ToString.ToUpper = "O_LEVEL" Then
                        rvHsStudReport.RefreshReport()
                        pdffile = rvHsStudReport.LocalReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    Else
                        rvHsReport_Alevel.RefreshReport()
                        pdffile = rvHsReport_Alevel.LocalReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    End If

                    Dim s As MemoryStream = New MemoryStream(pdffile)
                    s.Seek(0, SeekOrigin.Begin)
                    If InStr(studs("emailaddress").ToString, "@") > 1 Then
                        If sendmail(studs("emailaddress"), s, studs("StudName")) Then
                            cnt += 1
                        End If
                    Else
                        MsgBox("Invalid Email adrress for " & studs("StudName").ToString)
                    End If
                End While

            End If

            If cnt >= 1 Then
                MsgBox(cnt & " email(s) successfully sent")
            Else
                MsgBox("Email sending failed ")
            End If
        End If

    End Function

    Private Sub rvKnowhwanalysis_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub rvEnrollmentAnalysis_Load(sender As Object, e As EventArgs)

    End Sub
End Class