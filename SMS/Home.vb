Imports Miscelleneous
Imports System.Data.SqlClient
Imports SchoolParameters
Imports StudentDetails
Imports Reports
Imports SystemAdministration
Imports StaffDetails

Imports SchoolLibrary


Public Class frmMain
    Public loginForm As Form
    Public mngroup As String
    Public mnuser As String
    Public sql1 As String

    Public gouser As clsUser
    Public logon As Boolean


    Public Sub Logout()

        sql1 = "update Loginhistory set loginstate = 'false' ,dateloggedout = '" & changedate(Now.Date) & "' ,timelogout = '" & Now.TimeOfDay.ToString & "'  where [user] = '" & mnuser & "' and terminal = '" & SystemInformation.ComputerName & "'"
        ExecuteNonQuery(sql1,, True)
    End Sub
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mnuLogIn.Text = "Log Out" Then
            If MsgBox("Are you sure you want to exit", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxResult)) = MsgBoxResult.Yes Then
                e.Cancel = False

                Logout()

                loginForm.Close()
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = False

        End If

    End Sub





    Public Sub New()
        InitializeComponent()


        '   login.Close()
        '  login.Dispose()
        ' Me.Visible = True
        '    SystemBoot(username, group)

    End Sub


    Public Sub SystemBoot(fullname As String, group As String)
        gstrUserName = fullname
        Dim strVersion As String = "1.0.0.0"
        If My.Application.IsNetworkDeployed Then
            Dim AD As Deployment.Application.ApplicationDeployment = Deployment.Application.ApplicationDeployment.CurrentDeployment
            strVersion = AD.CurrentVersion.ToString
        End If

        gdteSystemDate = Now

        Try
            With ssMain
                .Items(0).Text = "Logged User : " & UCase(fullname) & "  Group :  " &
                                  group & " - " & UCase(GetTableValue("UserGroups", "Ugp_UserGroup", "Ugp_GroupName", group, False).ToString)
                .Items(1).Text = "  Today : " & FormatDateTime(gdteSystemDate, DateFormat.ShortDate)
                .Items(2).Text = " Version : " & strVersion
                'If gintDebtorsCount > 0 Then
                '    .Items(2).Text = "   Last Aged : " & FormatDateTime(gdteLastAgedDate, DateFormat.ShortDate)
                'Else
                '    .Items(2).Text = " [no active debtors] "
                'End If
                '.Items(3).Text = "Depot : " & UCase(gstrCompanyDepoID)
                '.Items(4).Text = "  " & UCase(gstrDepoName)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub userLogged(ByVal logOn As Boolean, ByVal Group As String, ByVal username As String)
        '   Dim frmMain As New frmMain

        Dim ctrl, ctrlsub, ctrlsub2 As ToolStripMenuItem
        Dim lbl As Control
        lbl = Nothing
        ctrl = Nothing : ctrlsub = Nothing : ctrlsub2 = Nothing
        Dim isVisible As Boolean = False
        Dim childFrm As Form = Nothing
        Dim ts As ToolStripItem = Nothing
        Try
            ssMain.Visible = logOn
            '  frmMain.tsMain.Visible = logOn
        Catch ex As Exception
        End Try
        If logOn Then
            SystemBoot(username, Group)
            mnuLogIn.Text = "Log Out"

            isVisible = True
            ' frmMain.BackgroundImage = My.Resources.
            BackColor = Color.White
            For Each ctrl In MenuStrip1.Items
                Try
                    If Not IsNothing(ctrl.Tag) Then
                        If ctrl.Tag.ToString = "-1" Then
                            ctrl.Enabled = False
                        Else
                            If ctrl.Tag.ToString <> "0" Then
                                Dim ctrls As New ToolStripMenuItem
                                Dim dr As SqlDataReader = Nothing
                                Dim sql As String = ""
                                sql = "Select Auth_HasAccess from " &
                                      "dbo.UserAuthorisations where Auth_Group = '" & Group &
                                      "' and Auth_AccComp = '" & ctrl.Tag.ToString & "'"
                                dr = ExecuteReader(sql, Nothing)
                                While dr.Read
                                    ctrl.Enabled = CBool(dr.Item(0))
                                End While
                            Else
                                ctrl.Enabled = True
                            End If
                        End If
                    Else
                        ctrl.Enabled = logOn
                    End If
                Catch ex As Exception
                End Try
                For Each ctrlsub In ctrl.DropDownItems
                    Try
                        If Not IsNothing(ctrlsub.Tag) Then
                            If ctrlsub.Tag.ToString = "-1" Then
                                ctrlsub.Enabled = False
                            Else
                                If ctrlsub.Tag.ToString <> "0" Then
                                    Dim ctrlsubs As New ToolStripMenuItem
                                    Dim dr As SqlDataReader = Nothing
                                    Dim sql As String = ""
                                    sql = "Select Auth_HasAccess from " &
                                          "dbo.UserAuthorisations where Auth_Group = '" & Group &
                                          "' and Auth_AccComp = '" & ctrlsub.Tag.ToString & "'"
                                    dr = ExecuteReader(sql, Nothing)
                                    While dr.Read
                                        ctrlsub.Enabled = CBool(dr.Item(0))
                                    End While
                                Else
                                    ctrlsub.Enabled = True
                                End If
                            End If
                        Else
                            ctrlsub.Enabled = logOn
                        End If
                    Catch ex As Exception
                    End Try
                    For Each ctrlsub2 In ctrlsub.DropDownItems
                        Try
                            If Not IsNothing(ctrlsub2.Tag) Then
                                If ctrlsub2.Tag.ToString = "-1" Then
                                    ctrlsub2.Enabled = False
                                Else
                                    If ctrlsub2.Tag.ToString <> "0" Then
                                        Dim ctrlsub2s As New ToolStripMenuItem
                                        Dim dr As SqlDataReader = Nothing
                                        Dim sql As String = ""
                                        sql = "Select Auth_HasAccess from " &
                                              "dbo.UserAuthorisations where Auth_Group = '" & Group &
                                              "' and Auth_AccComp = '" & ctrlsub2.Tag.ToString & "'"
                                        dr = ExecuteReader(sql, Nothing)
                                        While dr.Read
                                            ctrlsub2.Enabled = CBool(dr.Item(0))
                                        End While
                                    Else
                                        ctrlsub2.Enabled = True
                                    End If
                                End If
                            Else
                                ctrlsub2.Enabled = logOn
                            End If
                        Catch ex As Exception
                        End Try
                    Next
                Next
            Next
            'For Each ts In frmMain.tsMain.Items
            '    Try
            '        If Not IsNothing(ts.Tag) Then
            '            If ts.Tag.ToString = "-1" Then
            '                ts.Enabled = False
            '            Else
            '                If ts.Tag.ToString <> "0" Then
            '                    Dim tss As New ToolStripMenuItem
            '                    Dim dr As SqlDataReader = Nothing
            '                    Dim sql As String = ""
            '                    sql = "Select Auth_HasAccess from " & _
            '                          "dbo.UserAuthorisations where Auth_Group = '" & Group & _
            '                          "' and Auth_AccComp = '" & ts.Tag.ToString & "'"
            '                    dr = ExecuteReader(sql, Nothing)
            '                    While dr.Read
            '                        ts.Enabled = CBool(dr.Item(0))
            '                        ts.Visible = ts.Enabled
            '                    End While
            '                Else
            '                    ts.Enabled = True
            '                    ts.Visible = True
            '                End If
            '            End If
            '        Else
            '            ts.Enabled = logOn
            '        End If
            '    Catch ex As Exception
            '    End Try
            'Next
            'frmMain.tsMain.Visible = True
            'frmMain.Panel1.Visible = True
            'frmMain.Panel1.Dock = DockStyle.Fill
        Else
            Logout()
            Try
                For Each childFrm In MdiChildren
                    childFrm.Close()
                Next
                For Each ctrl In MenuStrip1.Items
                    If Not IsNothing(ctrl.Tag) Then
                        If CInt(ctrl.Tag) > 3 Then
                            ctrl.Enabled = False
                        End If
                    End If
                Next
                'frmMain.tsMain.Visible = False
                'For Each ts In frmMain.tsMain.Items
                '    Try
                '        If Not IsNothing(ts.Tag) Then
                '            ts.Visible = False
                '        End If
                '    Catch ex As Exception
                '    End Try
                'Next
                mnuLogIn.Text = "Log In"






                '  frmLogin()

                isVisible = False
                BackColor = Color.White
            Catch
            End Try
        End If
        ' Try




    End Sub


    Private Sub reporrts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    Rports.Show()

    End Sub


    Private Sub ServicesProvidedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)
        MsgBox(e.ToString)
    End Sub





    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As String = MsgBox("Are you sure you want to exit", MsgBoxStyle.YesNo)
        If s = vbYes Then
            Me.Close()
        End If
    End Sub







    Private Sub StaffTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' staffTypes.Show(Me)
    End Sub

    Private Sub reports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    Rports.Show()

    End Sub

    Private Sub studinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '    Student.Show()

    End Sub

    Private Sub staffinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '    StaffDetails.Show()

    End Sub

    Private Sub AdministrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub UserDefinedInputsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserDefinedInputsToolStripMenuItem.Click

        Dim frmSchoolParameters As New frmSchoolParameters
        With frmSchoolParameters
            .frmMain = Me
            .Show()
        End With

        '  frmSchoolParameters.Show()

    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userLogged(logon, gouser.Group, gouser.userName)

        mngroup = gouser.Group
        mnuser = gouser.userName
        showNotification()

    End Sub


    Private Sub showNotification()

        Try


            Dim currentupdateNumber As Integer = 0

            If Not Trim(GetSetting("Imela", "RevoEdu\", "RevoUpdateNumber")).Length > 0 Then
                SaveSetting("Imela", "RevoEdu\", "RevoUpdateNumber", RevoUpdateNumber)

            Else
                currentupdateNumber = GetSetting("Imela", "RevoEdu\", "RevoUpdateNumber")
            End If




            If (RevoUpdateNumber > currentupdateNumber) Then
                Dim frmupdatenotification As New dgUpdateNotification
                With frmupdatenotification
                    .Writetextbox()
                    .ShowDialog()
                End With

            End If


        Catch ex As Exception
            MessageBox.Show("Unable to load Software Update Screen: " & ex.Message)
        End Try




    End Sub
    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim sql$ = "update [UserActivityLog] set sessionstate = 0,logoutdate = getdate() where usr = '" & goUser.userName & "' and session in ( select session from  [UserActivityLog] where usr = '" & goUser.userName & "' and sessionstate = 1 ) "
        '    ExecuteNonQuery(sql)
        Close()
    End Sub

    Private Sub UserAdministationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAdministationToolStripMenuItem.Click
        Dim frmusercontrol As New frmUserControl
        With frmUserControl
            .frmMain = Me
            .Show
        End With
    End Sub

    Private Sub StudentDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentDetailsToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Dim stdscren As New FrmStudent
        With stdscren
            .mainform = Me
            .gouser = gouser
            .Show()
        End With


        Cursor = Cursors.Default
    End Sub

    Private Sub mnuLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogIn.Click
        If mnuLogIn.Text = "Log In" Then
            Dim lgn As New frmLogin
            lgn.Show()
            Close()
        Else
            userLogged(False, gouser.Group, mnuser)

        End If
    End Sub

    Private Sub ReportsPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsPageToolStripMenuItem.Click
        Dim rpts As New Rports
        With rpts
            .frmMain = Me
            .Show()
        End With
    End Sub


    Private Sub LibraryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   frmLibrary.Show()
    End Sub

    Private Sub BackUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmSystemControl.Show()
    End Sub

    Private Sub StaffDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffDetailsToolStripMenuItem.Click
        Dim StaffDet As New frmStaffDetails
        With StaffDet
            .frmmain = Me
            .Show()
        End With


        '     StaffDetails.Show()
    End Sub

    Private Sub StaffAssessmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffAssessmentToolStripMenuItem.Click


    End Sub

    Private Sub DepartmentAssessmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentAssessmentToolStripMenuItem.Click


    End Sub

    Private Sub CaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptureToolStripMenuItem.Click
        gblnDepartmentalAssessment = False
        gblnDepartmentAssessmentDel = False
        gblnLectureAssessmentDel = False
        '   capturequestionnaire.Show()
    End Sub

    Private Sub CaptureToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptureToolStripMenuItem1.Click
        gblnDepartmentalAssessment = True
        gblnDepartmentAssessmentDel = False
        gblnLectureAssessmentDel = False
        '       capturequestionnaire.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        gblnDepartmentalAssessment = False
        gblnDepartmentAssessmentDel = False
        gblnLectureAssessmentDel = True
        '    capturequestionnaire.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        gblnDepartmentalAssessment = True
        gblnDepartmentAssessmentDel = True
        gblnLectureAssessmentDel = False
        ' dbQuestionnaire.Show()
        '   capturequestionnaire.Show()
    End Sub

    Private Sub ReportsPageToolStripMenuItem_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ReportsPageToolStripMenuItem.MouseUp

    End Sub

    Private Sub UserManualToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserManualToolStripMenuItem1.Click
        Cursor = Cursors.WaitCursor
        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\Utilities\UserManual.PDF")
        Cursor = Cursors.Default

    End Sub

    Private Sub EnterPassRatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '     frmBoardPassRates.Show()
    End Sub

    Private Sub TransferLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferLetterToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Try
            Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\Utilities\Transfer.DOC")
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Form not Found")
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub TestimonialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestimonialToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Try
            Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\Utilities\Testimonial.PDF")
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Form not found")
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub REPORTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem1.Click
        Cursor = Cursors.WaitCursor
        Try
            Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\Utilities\REPORTOLEVEL.PDF")
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Form not found")
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MARKSHCEDULEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MARKSHCEDULEToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Try
            Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\Utilities\Marksheet.doc")
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Form not found")
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub REPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Try
            Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\Utilities\REPORTALEVEL.PDF")
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Form not found")
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub REPORTToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem2.Click
        Cursor = Cursors.WaitCursor
        Try
            Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\Utilities\REPORTZJC.PDF")
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Form not found")
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MARKSCHEDULEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MARKSCHEDULEToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        Try
            Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\Utilities\MARKSCHEDULE.DOC")
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Form not found")
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CaptureToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptureToolStripMenuItem2.Click
        '     frmNonStud.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Dim frmlib As New frmLibrary

        With frmlib
            .frmMain = Me
            .Show()
        End With


    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '      frmStaffLogin.Show()
    End Sub

    Private Sub BiometricLoginLogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiometricLoginLogoutToolStripMenuItem.Click
        '     frmStaffLogin.Show()
    End Sub

    Private Sub CheckFeesBalancesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckFeesBalancesToolStripMenuItem.Click
        '      frmStudBalances.Show()
    End Sub

    Private Sub BoardingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        '      frmBoarding.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        '      frmInventory.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click



    End Sub

    Private Sub VersionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionHistoryToolStripMenuItem.Click
        Dim frmupdatenotification As New dgUpdateNotification
        With frmupdatenotification
            .Writetextbox()
            .ShowDialog()
        End With
    End Sub
End Class