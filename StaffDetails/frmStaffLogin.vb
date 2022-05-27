Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net
Imports System.Web.UI.Page
Imports System.Data
Imports SecuGen.FDxSDKPro.Windows
Imports Miscelleneous
Imports System.Windows.Forms


Public Class frmStaffLogin
    Dim secndcount As Integer = 0
    Public frmmain As form
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
            Timer1.Enabled = False
            lbTimer.Text = "Timer Disabled"
            Exit Sub
        Else
        
            lbDevStatus.Text = ""
            If Not Timer1.Enabled Then
                Timer1.Enabled = True
            End If
        End If

        If cnctera Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")
            lbDevStatus.Text = "Scanner initialization error "
            Timer1.Enabled = False
            lbTimer.Text = "Timer Disabled"
            Exit Sub

        Else
            lbDevStatus.Text = ""
            lbCofirmName.Text = ""
            If Not Timer1.Enabled Then
                Timer1.Enabled = True
            End If

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
        sql = " select fingerprint,staffid from staffpersonaldetails  "
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
                                staffid = drr(1).ToString

                                sql = "select name + ' ' + surname from staffpersonaldetails where staffid = '" & drr(1) & "'"
                                student = ExecuteScalar(sql)
                                If Not era Then
                                    ' MsgBox("Welcome " & student)
                                    register(staffid, student)
                                    '  PictureBox_v.Refresh()
                                    Exit Sub
                                End If
                            Else
                                lbCofirmName.Text = "Fingerprint could not matched "
                            End If

                        Else
                            lbCofirmName.Text = "Fingerprint could not matched "    ' DisplayError("MatchTemplate", iError)
                        End If

                    End If
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
    Private Sub register(ByVal staff As String, ByVal fullname As String)
        Dim sql As String
        Dim incomplete As Integer
        Dim detout As String
        sql = "select count (staffid ) from staffregister where [date] = '" & changedate(Now.Date) & "' and staffid = '" & staff & "' and complete = '0'"
        incomplete = ExecuteScalar(sql)

        If incomplete > 0 Then
            detout = Now().ToString("dd/MM/yyyy HH:mm:ss")
            sql = "update staffregister set time_out = '" & Mid(Now.TimeOfDay.ToString, 1, 8) & "', complete = '1',fulldate_out = '" & changefulldate(detout) & "' where date = '" & changedate(Now.Date) & "' and staffid = '" & staff & "' and complete = '0'"
            ExecuteNonQuery(sql)
            If Not era Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\goodbye.wav")
                lbCofirmName.Text = "Good bye " & fullname
                ' MsgBox("Logout successfull for " & fullname)
            Else
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")
            End If
        Else
            sql = "insert into staffregister (staffid,[date],time_in,time_out,complete,fulldate_in,fulldate_out ) values ('" & staff & "','" & changedate(Now.Date) & "','" & Mid(Now.TimeOfDay.ToString, 1, 8) & "','','0','" & changefulldate(Now().ToString("dd/MM/yyyy HH:mm:ss")) & "','" & changefulldate(Now().ToString("dd/MM/yyyy HH:mm:ss")) & "')"
            ExecuteNonQuery(sql)

            If Not era Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\confirm.wav")
                lbCofirmName.Text = "Welcome " & fullname
            Else
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")
            End If
        End If








    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        secndcount = secndcount + 1
        lbTimer.Text = secndcount & "s"
        If secndcount = 2 Then
            lbTimer.Text = secndcount & "s"
            secndcount = 0
            PictureBox_V_Click(Me, Nothing)
        End If
    End Sub

    Private Sub frmStaffLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Prepareform(Me, frmmain, False)
        MdiParent = frmMain
        Timer1.Enabled = True

    End Sub
End Class