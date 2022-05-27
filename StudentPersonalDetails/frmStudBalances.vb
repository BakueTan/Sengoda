Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net
Imports System.Web.UI.Page
Imports System.Data
Imports SecuGen.FDxSDKPro.Windows
Imports Miscelleneous
Imports System.Windows.Forms

Public Class frmStudBalances
    Dim secndcount As Integer = 0
    Public frmMain As Form
    Private Sub PictureBox_V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox_V.Click
        Dim temp_v(400) As Byte
        Dim iError As Int32
        Dim img_qlty As Int32
        Dim m_FPM As SGFingerPrintManager
        ' m_FPM = New SGFingerPrintManager
        '  Dim pinfo As SGFPMDeviceInfoParam

        ' Dim iError As Int32
        'pInfo = New SGFPMDeviceInfoParam
        'pInfo = New SGFPMDeviceInfoParam

        'Dim pInfo As SGFPMDeviceInfoParam
        'Dim iError As Int32
        ' m_FPM = New SGFingerPrintManager
        Dim scanfing As New scana


        scanfing.init()

        scanfing.open_device()
        If nodev_era Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")
            lbDevStatus.Text = "Scanner not connected"

            Exit Sub
        Else

            lbDevStatus.Text = ""

        End If

        If cnctera Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")
            lbDevStatus.Text = "Scanner initialization error "

            Exit Sub

        Else
            lbDevStatus.Text = ""
            lbCofirmName.Text = ""


        End If
        'scanfing.get_info()
        scanfing.DrawImage(scanfing.get_info(), PictureBox_V)
        If drawera Or getinfoera Then
            '    MsgBox("Failed to scan image")
            Exit Sub
        End If

        Dim sql As String
        Dim drr As SqlDataReader
        Dim staffid As String

        sql = "select fingerprint,studentid from  studentpersonaldetails where fingerprint is not null "


        '  ExecuteNonQuery(sql, , , , , , , temp1, True, "@temp")


        drr = ExecuteReader(sql)
        If drr.HasRows Then
            Try
nextread:       While drr.Read
                    If Not IsNothing(drr(0)) Then
                        Try
                            temp_v = drr(0)
                        Catch ex As Exception
                            GoTo nextread
                        End Try

                        ' Dim iError As Int32
                        Dim matched1 As Boolean
                        Dim matched2 As Boolean
                        Dim secu_level As SGFPMSecurityLevel
                        ' m_FPM = New SGFingerPrintManager
                        secu_level = SGFPMSecurityLevel.BELOW_NORMAL

                        iError = scanfing.m_FPM.MatchTemplate(temp_v, temp1, secu_level, matched1)

                        If (iError = SGFPMError.ERROR_NONE) Then
                            If (matched1) Then
                                lbCofirmName.Text = ""
                                Dim student As String
                                gstrstudid = drr(1).ToString
                                gstrcuttoff = cboCutOffPeriod.SelectedValue

                                'sql = "select studentname + ' ' + studentsurname from studentpersonaldetails where studentid = '" & drr(1) & "'"
                                ' student = ExecuteScalar(sql)
                                studfeesstatement = True
                                '  frmReportPreview.Show()
                                Exit While
                            End If
                        Else
                            lbCofirmName.Text = "Fingerprint could not matched "
                        End If

                    Else
                        lbCofirmName.Text = "Fingerprint could not matched "    ' DisplayError("MatchTemplate", iError)
                    End If

                    ' End If
                End While



            Catch ex As Exception
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")

                ' MsgBox(ex.Message)

            End Try

            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")

        Else
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")

        End If
        '  drr = ExecuteReader(sql, , , , True, temp1, "@finger")  'ExecuteNonQuery(sql, , , , , , , temp1, True, "@finger")





        'If cnctera Then
        '    MsgBox("Could not connect to scanner")
        '    Exit Sub
        'Else
        '    ' scanfing()
        'End If
    End Sub
    Private Sub checkfeesbalance(ByVal studentid As String, ByVal fullname As String)









    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        secndcount = secndcount + 1
        lbTimer.Text = secndcount & "s"
        If secndcount = 2 Then
            lbTimer.Text = secndcount & "s"
            secndcount = 0
            PictureBox_V_Click(Me, Nothing)
        End If
    End Sub

    Private Sub frmStaffLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSchool.PaymentPeriods' table. You can move, or remove it, as needed.

        Dim period As String
        Dim sql As String = "select period from paymentperiods where [current] = 'true'"
        period = ExecuteScalar(sql, , True)
        Try
            cboCutOffPeriod.SelectedValue = period
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        Prepareform(Me, frmMain, False)
        MdiParent = frmMain
        ' Timer1.Enabled = True


    End Sub

    Private Sub btnScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScan.Click
        PictureBox_V_Click(Me, Nothing)
    End Sub

    Private Sub txtStudID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStudID.KeyDown
        If e.KeyCode = Keys.Enter Then
            gstrcuttoff = cboCutOffPeriod.SelectedValue
            gstrstudid = txtStudID.Text
            studfeesstatement = True
            '  frmReportPreview.Show()
            txtStudID.Clear()
        End If
    End Sub



    Private Sub txtStudID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStudID.KeyPress

    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudID.TextChanged
        'Dim sql As String
        'Dim drr As SqlDataReader
        'sql = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & txtStudID.Text & "%'"
        'drr = ExecuteReader(Sql)
        'While drr.Read
        '    lbScanStuds.Items.Add(drr(0) & " " & drr(1) & " " & drr(2))
        'End While


        If txtStudID.Text.Length = 6 Then
            gstrcuttoff = cboCutOffPeriod.SelectedValue
            gstrstudid = txtStudID.Text
            studfeesstatement = True
            '      frmReportPreview.Show()
            txtStudID.Clear()
            '   Exit Sub
        End If
    End Sub

    Private Sub rbBiometric_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBiometric.CheckedChanged
        PictureBox_V.Enabled = rbBiometric.Checked
        btnScan.Enabled = rbBiometric.Checked

    End Sub

    Private Sub rbIDScanner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIDScanner.CheckedChanged
        txtStudID.Enabled = rbIDScanner.Checked
        txtStudID.Focus()
    End Sub

    Private Sub lbScanStuds_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'Try


        '    Dim a, b As Integer

        '    Dim searchstring As String
        '    b = InStr(Trim(lbScanStuds.SelectedItem.ToString), " ")
        '    searchstring = Mid(Trim(lbStudPayPlan.SelectedItem), 1, b - 1)
        '    txtStudPayPlan.Text = searchstring

        '    lbStudPayPlan.Visible = False
        'Catch ex As Exception

        'End Try

    End Sub


    Private Sub cboCutOffPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCutOffPeriod.SelectedIndexChanged
        txtStudID.Focus()
    End Sub
End Class