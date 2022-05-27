Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Miscelleneous
Public Class frmReportPreview
    Public stud As FrmStudent
    Public printout As String = ""
    Public recprint As Boolean = False
    Public recCopy As Boolean = False
    Public RecNumber As String = ""
    Public isReceipt As Boolean = False
    Public stmtprint As Boolean = False
    Public enrolformprint As Boolean = False
    Public studprint As Boolean = False
    Public classprint As Boolean = False
    Public frmMain As Form
    Public issueform As Boolean
    Public program As String
    Public lvl As Integer
    Public clas As String
    Public session As String
    Public blnbookreturn As Boolean
    Public returnref As String
    Public BehaviorReport As Boolean = False
    Public BehaviorReference As String = ""



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()

    End Sub
    Public Sub New()


        InitializeComponent()


    End Sub

    Private Sub frmReportPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MdiParent = frmMain

        'TODO: This line of code loads data into the 'dsReports.FeesReceipt' table. You can move, or remove it, as needed.
        rvFeesInoice.Visible = False
        rvFeesReceipt.Visible = False
        rvStudDetails.Visible = False
        rvEnrolForm.Visible = False
        rvStudFeesStatement.Visible = False
        rvClassStudents.Visible = False
        rvStaffProfile.Visible = False
        rvIssueForm.Visible = False
        rvBookInfo.Visible = False
        rvStudCheckList.Visible = False
        rvBehaviorReport.Visible = False

        If recprint Then
            Me.PrintFeesReceiptTableAdapter.FillByReceipt(dsSchool.PrintFeesReceipt, RecNumber, goUser.FullName, recCopy)
            rvFeesInoice.Visible = False
            rvFeesReceipt.Visible = False


            Select Case isReceipt
                Case True
                    Me.rvFeesReceipt.RefreshReport()
                    rvFeesReceipt.Visible = True
                    rvFeesReceipt.Dock = DockStyle.Fill
                Case Else
                    Me.rvFeesInoice.RefreshReport()
                    rvFeesInoice.Visible = True
                    rvFeesInoice.Dock = DockStyle.Fill
            End Select
        ElseIf studprint Then
            '      Me.StudentPersonalDetailsTableAdapter.FillByStud(Me.dsReports.StudentPersonalDetails, gstrstud2)

            MdiParent = frmMain
            Dock = DockStyle.Fill
            Me.rvStudDetails.RefreshReport()
            rvStudDetails.Visible = True
            rvStudDetails.Dock = DockStyle.Fill
        ElseIf enrolformprint Then
            '    Me.EnrollmentFormTableAdapter.FillbyProg(Me.SchoolDataSet.EnrollmentForm, gstrstud2)

            MdiParent = frmMain
            Dock = DockStyle.Fill
            Me.rvEnrolForm.RefreshReport()
            rvEnrolForm.Visible = True
            rvEnrolForm.Dock = DockStyle.Fill
        ElseIf stmntprnt Then
            '    Me.LedgerTransactionsTableAdapter.Fillbystat(Me.dsReports.LedgerTransactions, "ALL", "ALL", goUser.FullName, "", "SchoolFees", gstrstud2)
            MdiParent = frmMain
            Dock = DockStyle.Fill
            Me.rvStudFeesStatement.RefreshReport()
            rvStudFeesStatement.Visible = True
            rvStudFeesStatement.Dock = DockStyle.Fill
        ElseIf classprint Then
            ClassListTableAdapter.FillByClass(Me.dsSchool.ClassList, program, lvl, session, clas, "", False, Now.Date, Now.Date)

            Dock = DockStyle.Fill
            Me.rvClassStudents.RefreshReport()
            rvClassStudents.Visible = True
            rvClassStudents.Dock = DockStyle.Fill
        ElseIf issueform Then
            If blnbookreturn Then
                Try
                    Me.BookIssueFormTableAdapter.Fill(Me.dsSchool.BookIssueForm, goUser.FullName, gstrissueno, "All", blnbookreturn, returnref)
                Catch ex As Exception

                End Try
                rvBokkReturnForm.Dock = DockStyle.Fill
                rvBokkReturnForm.RefreshReport()
                Me.rvBokkReturnForm.Visible = True
            Else
                Try
                    Me.BookIssueFormTableAdapter.Fill(Me.dsSchool.BookIssueForm, goUser.FullName, gstrissueno, "All", False, "")
                Catch ex As Exception

                End Try
                rvIssueForm.Dock = DockStyle.Fill
                rvIssueForm.RefreshReport()
                Me.rvIssueForm.Visible = True
            End If


        ElseIf BehaviorReport Then

            Try
                Me.StudBehaviorReportTableAdapter.Fill(dsSchool.StudBehaviorReport, "", BehaviorReference, "", "Specific", "")
                rvBehaviorReport.Dock = DockStyle.Fill
                rvBehaviorReport.RefreshReport()
                rvBehaviorReport.Visible = True
            Catch ex As Exception

            End Try



        End If

        '    Case "StaffProfile"
        '        Me.StaffQualificationTableAdapter.FillByStaffProfile(dsReports.StaffQualification, gstrstaffid)
        '        MdiParent = frmMain
        '        Dock = DockStyle.Fill
        '        Me.rvStaffProfile.Visible = True
        '        rvStaffProfile.Dock = DockStyle.Fill
        '        rvStaffProfile.RefreshReport()

        'Case "BookIssueForm"
        'Try
        '    Me.IssueFormTableAdapter.FillByIssue(Me.dsLibraryReports.IssueForm, goUser.FullName, gstrissueno)
        'Catch ex As Exception

        'End Try


        'MdiParent = frmMain
        'rvIssueForm.Dock = DockStyle.Fill
        'Me.rvIssueForm.Visible = True
        'rvIssueForm.Dock = DockStyle.Fill
        'rvIssueForm.RefreshReport()
        'Case "BookInfo"
        'Try
        '    Me.BookMasterTableAdapter.FillByBook(Me.dsLibraryReports.BookMaster, gstrbookref)
        'Catch ex As Exception

        'End Try

        'MdiParent = frmMain
        'rvBookInfo.Dock = DockStyle.Fill
        'Me.rvBookInfo.Visible = True
        'rvBookInfo.RefreshReport()


        '    Case "Statement"
        '        Dim sql As String
        '        Dim drr, ddr2 As SqlDataReader

        '        sql = " select * from studentpersonaldetails where studentid = '" & gstrstudid & "'"
        '        drr = ExecuteReader(sql, , True)

        '        If drr.HasRows Then
        '            'sql = "select * from   feespayments_header  where studentid = '" & gstrstudid & "' and pperiod >= '1'"
        '            'ddr2 = ExecuteReader(sql, True)
        '            'If ddr2.HasRows Then
        '            'Else
        '            '    MsgBox("No Fees records found")
        '            '    Close()
        '            '    Exit Sub
        '            'End If

        '        Else
        '            MsgBox("Student not registered in database")
        '            Close()
        '            Exit Sub
        '        End If
        '        Try
        '            Me.EndOfTermTableAdapter.FillBystudall(Me.dsReports.EndOfTerm, gstrcuttoff, goUser.FullName, "", "ALL", gstrstudid)
        '        Catch ex As Exception

        '        End Try

        '        '   MdiParent = frmMain
        '        rvFeesStatement.Dock = DockStyle.Fill
        '        rvFeesStatement.Visible = True
        '        rvFeesStatement.RefreshReport()
        '    Case "CheckList"
        '        MsgBox("CheckList not yet customised")
        'End Select
    End Sub


End Class