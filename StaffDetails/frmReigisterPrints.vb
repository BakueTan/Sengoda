Imports System.Text
Imports SecuGen.FDxSDKPro.Windows
Imports Miscelleneous
Imports System.Data.SqlClient

Public Class frmReigisterPrints2
    Dim staff As String
    Dim m_FPM As SGFingerPrintManager
    Dim m_LedOn As Boolean
    Dim m_ImageWidth As Int32
    Dim m_ImageHeight As Int32
    Dim m_RegMin1(400) As Byte
    Dim m_RegMin2(400) As Byte
    Dim m_VrfMin(400) As Byte
    Dim m_DevList() As SGFPMDeviceList

    Private Sub frmReigisterPrints_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        staffreg = False
        '    StaffDetails.Show()
    End Sub
    ' Dim pInfo As SGFPMDeviceInfoParam
    'This is a change

    Private Sub frmReigisterPrints_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = "FingerPrint Registration for " & staffsurname & " " & staffname

        ' StaffDetails.Timer1.Enabled = False
        ' pInfo = New SGFPMDeviceInfoParam


        'm_ImageWidth = pInfo.ImageWidth
        'm_ImageHeight = pInfo.ImageHeight

        ' Prepareform(Me, False)
        ' MdiParent = frmMain

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaptuerPrint.Click
        Dim fp_image() As Byte
        Dim iError As Int32
        Dim img_qlty As Int32
        '  m_FPM = New SGFingerPrintManager
        '  Dim pinfo As SGFPMDeviceInfoParam

        ' Dim iError As Int32
        'pInfo = New SGFPMDeviceInfoParam
        'pInfo = New SGFPMDeviceInfoParam

        'Dim pInfo As SGFPMDeviceInfoParam
        'Dim iError As Int32
        Dim scanfing As New scana


        scanfing.init()
        scanfing.open_device()
        If cnctera = True Then
            lblImageQuality.Text = "Connection failed"

            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")

            btnRegisterPrint.Enabled = False
            Exit Sub
        Else
            lblImageQuality.Text = ""

            '   My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\confirm.wav")
            btnRegisterPrint.Enabled = True
        End If
        'scanfing.get_info()
        scanfing.DrawImage(scanfing.get_info(), PictureBoxR1)
        If drawera Or getinfoera Then
            lblImageQuality.Text = "Image Capture Failed"
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\beep.wav")
            btnRegisterPrint.Enabled = False
            Exit Sub
        Else
            lblImageQuality.Text = ""
            btnRegisterPrint.Enabled = True
        End If

        ' MsgBox("scan quality is " & scanfing.img_qlty)
        If scanfing.img_qlty < 90 Then

            lblImageQuality.Text = "SCAN QUALITY BELOW 90%"
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\confirm.wav")
            ' btnRegister.Enabled = False
        Else
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Utilities\confirm.wav")
            lblImageQuality.Text = ""
            btnRegisterPrint.Enabled = True
        End If


        'If cnctera Then
        '    MsgBox("Could not connect to scanner")
        '    Exit Sub
        'Else
        '    ' scanfing()
        'End If



    End Sub



    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim fp_image() As Byte
    '    Dim iError As Int32
    '    Dim img_qlty As Int32
    '    'm_FPM = New SGFingerPrintManager
    '    Dim pinfo As SGFPMDeviceInfoParam

    '    ' Dim iError As Int32
    '    'pInfo = New SGFPMDeviceInfoParam
    '    'pInfo = New SGFPMDeviceInfoParam

    '    'Dim pInfo As SGFPMDeviceInfoParam
    '    'Dim iError As Int32
    '    Dim scanfing As New scana


    '    scanfing.init()
    '    scanfing.open_device()
    '    'scanfing.get_info()
    '    scanfing.DrawImage(scanfing.get_info2(), PictureBoxR2)


    '    If cnctera Then
    '        MsgBox("Could not connect to scanner")
    '        Exit Sub
    '    Else
    '        ' scanfing()
    '    End If

    'End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegisterPrint.Click
        Dim iError As Int32
        Dim matched As Boolean
        Dim match_score As Int32
        Dim secu_level As SGFPMSecurityLevel
        'm()
        ' Dim scanfig As New scana
        matched = False
        match_score = 0
        m_FPM = New SGFingerPrintManager
        secu_level = SGFPMSecurityLevel.NONE

        'iError = m_FPM.MatchTemplate(temp1, temp2, secu_level, matched)
        'iError = m_FPM.GetMatchingScore(temp1, temp2, match_score)

        'If (iError = SGFPMError.ERROR_NONE) Then
        '    If (matched) Then
        '        MsgBox("matched prints")
        '        '  StatusBar.Text = "Registration Success, Matching Score: " + Convert.ToString(match_score)
        '    Else
        '        MsgBox("Prints did not match")
        '    End If

        'Else
        '    'DisplayError("GetMatchingScore", iError)
        'End If
        Dim sql As String
        Dim fingerprint As Byte() = Nothing

        sql = "select fingerprint from staffpersonaldetails where staffid = '" & staffnumber & "'"
        Try
            fingerprint = ExecuteScalar(sql)
        Catch ex As Exception

        End Try

        If IsNothing(fingerprint) Then
            sql = "update staffpersonaldetails set fingerprint = @temp where staffid = '" & staffnumber & "'"

            Dim param As New SqlParameter("@temp", temp1)
            params = New List(Of SqlParameter)
            params.Add(param)
            ExecuteNonQuery(sql,, True,,,,, params)




            If Not era Then
                MsgBox("fingerprint registration successul")
            End If
        Else
            Dim res As String = MsgBox("Fingerprint already captured for staff do you want to update existing", MsgBoxStyle.YesNo)
            If res = "6" Then
                sql = "update staffpersonaldetails set fingerprint = @temp where staffid = '" & staffnumber & "'"

                Dim param As New SqlParameter("@temp", temp1)
                params = New List(Of SqlParameter)
                params.Add(param)
                ExecuteNonQuery(sql,, True,,,,, params)
                If Not era Then
                    MsgBox("fingerprint update  successul")
                End If
            End If
        End If






    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Button1_Click(Me, Nothing)
    End Sub

    Private Sub PictureBoxR1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxR1.Click

    End Sub
End Class