Imports System
Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO
Imports System.Configuration
Imports Miscelleneous


Public Class frmLogin
    Public loggedIn As Boolean
    Private usercount As Integer
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    ' Dim goUser As clsUser
    '   Dim frmMain As New frmMain

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        'Dim ind As New IndustrialSilencer
        'ind.ConnectionHeight = 16


        'ind.CalcCasingThickness()


        goUser = New clsUser(UsernameTextBox.Text, PasswordTextBox.Text)

        If goUser.passWord = "Password1" And goUser.UserIsValid And pnlChangePaswed.Visible = False Then
            MsgBox("Your Password was reset to the Default (Password1) you need to provide your own Password")
            btnChangePaswed_Click(Me, e)
            Exit Sub
        End If
        If goUser.UserIsValid Then
            ' UsernameTextBox.Clear()
            '  PasswordTextBox.Clear()
            If pnlChangePaswed.Visible = True Then
                Dim sql$
                ' lnkUpdateFiles.Visible = True
                '  PictureBox1.Visible = True
                If txtChangPaswed.Text <> "" And txtNewPasswed.Text = txtChangPaswed.Text Then
                    Try
                        sql = "update dbo.users set Usr_Password = '" & txtChangPaswed.Text & "'" & " where Usr_User = '" & goUser.userName & "'"
                        ExecuteNonQuery(sql)
                        MsgBox("Password successfully Changed ,Login with new Password to continue", MsgBoxStyle.Information)
                        Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MsgBox("Password confirmation failed or the new Password is illegible", MsgBoxStyle.Information)
                End If
            Else


                If goUser.updateLoginHistory() Then

                    Dim main As New frmMain()
                    main.gouser = goUser
                    main.loginForm = Me
                    main.logon = True
                    main.Show()
                    Close()

                Else

                    '  MsgBox("User Already logged in on this Terminal z\")
                End If




                '  main.userLogged(True, goUser.Group)
                '  main.Visible = True

                'Close()
            End If
        Else
            loggedIn = False
            MsgBox("Incorrect User name or Password", MsgBoxStyle.Exclamation, "Failed Login")

        End If




    End Sub
    Private Sub updateLoginHistory()
        Dim sql As String
        sql = "insert into loginhistory( " &
            "va"
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Dim sql$ = ""
        'Dim oResult As Object = Nothing
        'Try
        '    '  sql = "SELECT COUNT(Sst_EntryID) FROM dbo.SystemState"
        '    ' oResult = ExecuteScalar(sql)
        '    If Not IsNothing(oResult) Then
        '        If CInt(oResult) = 0 Then
        '            sql = "INSERT dbo.SystemState(Sst_Machine, Sst_LastUser) VALUES ('', '" & UsernameTextBox.Text & "')"
        '        Else
        '            sql = "UPDATE dbo.SystemState SET Sst_LastUser ='" & UsernameTextBox.Text & "'"
        '        End If
        '    Else
        '        sql = "INSERT dbo.SystemState(Sst_Machine, Sst_LastUser) VALUES ('', '" & UsernameTextBox.Text & "')"
        '    End If
        '    ExecuteNonQuery(sql)
        'Catch ex As Exception

        'End Try
    End Sub


    Public Sub Countusers()



        Dim sql As String = " select count (distinct [user]) from loginhistory where loginstate = 'true'"



        usercount = ExecuteScalar(sql,, True)


    End Sub



    Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sql$ = ""
        Dim oResult As Object = Nothing
        '    Dim main As New frmMain
        '   main.Prepareform(Me, False)
        '   Me.Show()
        'Try
        '    sql = "SELECT Sst_LastUser FROM dbo.SystemState"
        '    oResult = ExecuteScalar(sql)
        '    If Not IsNothing(oResult) Then
        '        UsernameTextBox.Text = oResult.ToString
        '    End If
        'Catch ex As Exception

        'End Try
        LogLastUser()
        UsernameTextBox.Focus()
        Countusers()
        Label2.Text = Label2.Text & "(" & usercount & ")"

    End Sub

    Private Sub LogLastUser()
        Dim sql = "select top 1 [user] from loginhistory where terminal = '" & SystemInformation.ComputerName & "' order by dateloggedout desc, timelogout desc"
        Dim user As String = ExecuteScalar(sql,, True)
        UsernameTextBox.Text = user
    End Sub

    Private Sub UsernameTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsernameTextBox.Click
        UsernameTextBox.SelectAll()
    End Sub

    Private Sub UsernameTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsernameTextBox.GotFocus
        UsernameTextBox.SelectAll()
    End Sub


    Private Sub btnChangePaswed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePaswed.Click
        PasswordLabel.Text = "Old Password"
        UsernameTextBox.Enabled = False
        With Me
            .Width = 426
            .Height = 420
        End With
        With pnlChangePaswed
            .Width = 225
            .Height = 120
            .Top = 163
            .Left = UsernameTextBox.Left - 2 '109
            .Visible = True

        End With
        PictureBox1.Visible = False
        '    lnkUpdateFiles.Visible = False

    End Sub

    Private Sub lnkUpdateFiles_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim path As String
        Dim updatedate As String

        '   Dim reader As XmlReader = New XmlTextReader()

        Dim cAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(Application.StartupPath & "\TMS.exe")
        Dim asSettings As AppSettingsSection = cAppConfig.AppSettings



        Try
            path = asSettings.Settings.Item("path").Value
            updatedate = asSettings.Settings.Item("UpdateDate").Value
        Catch ex As Exception
            MsgBox("Appsetings section could not be found in the Config file")
        End Try
        'Save Modified Value
        '  cAppConfig.Save(ConfigurationSaveMode.Modified)
        'Dim reader As XmlReader = New XmlTextReader("SMS.exe.config")

        'While reader.Read
        '    If reader.NodeType = System.Xml.XmlNodeType.Element Then
        '        Select Case reader.Name.ToUpper()
        '            Case "PATH"
        '                path = reader.GetAttribute("path")

        '                'If IsNothing(path) Then
        '                '    ' MsgBox("Server path not configured contact system Admin")
        '                '    Exit Select
        '                'Else

        '                'End If

        '                updatedate = reader.GetAttribute("updatedate")
        '                Exit Select
        '        End Select
        '    End If
        'End While

        CopyFiles(path, updatedate)


    End Sub
    Public Function CopyFiles(ByVal path As String, ByVal clientdate As String) As Boolean
        Dim fullpath As String = path & "\TMS.exe"
        Dim reader As XmlReader
        Dim filescopied As Integer = 0
        Dim serverdate As String
        Dim date1, date2 As Date

        Dim cAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(fullpath)
        Dim asSettings As AppSettingsSection = cAppConfig.AppSettings
        ' cAppConfig = cAppConfig.ToString.Substring(1, cAppConfig.ToString.Length - 7)
        serverdate = asSettings.Settings.Item("UpdateDate").Value

        date1 = Date.Parse(clientdate)
        date2 = Date.Parse(serverdate)




        If date2 > date1 Then

            For Each file1 As String In Directory.GetFiles(path)
                If file1.Contains(".exe") Then
                Else
                    File.Copy(file1, "./" & System.IO.Path.GetFileName(file1), True)
                    filescopied += 1
                End If

            Next

            If filescopied >= 1 Then
                MsgBox("Update Files successfully copied")
                updateConfigfile(serverdate, fullpath & ".config")

            Else
                MsgBox("No files copied")
            End If
        Else
            MsgBox("Files are up to date")
        End If

        Return False
    End Function

    Public Sub updateConfigfile(ByVal serverdate As Date, ByVal serverpath As String)
        Dim reader As XmlReader = New XmlTextReader(serverpath)
        Try
            Dim cAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(Application.StartupPath & "\TMS.exe")
            Dim asSettings As AppSettingsSection = cAppConfig.AppSettings
            asSettings.Settings.Item("UpdateDate").Value = Now() 'Save Modified Value
            cAppConfig.Save(ConfigurationSaveMode.Modified)
            MsgBox("Run application again to Login")
            Close()
        Catch ex As Exception
            MsgBox("Config file date could not be updated")
        End Try


        'Dim doc As XmlDocument = New XmlDocument()
        'doc.Load(serverpath)
        'Dim attr As XmlAttribute
        'For Each node In doc.SelectSingleNode("serverpath")
        '    node.
        'Next
        'Dim attr As XmlAttribute
        'While reader.Read
        '    If reader.NodeType = System.Xml.XmlNodeType.Element Then
        '        Select Case reader.Name.ToUpper()
        '            Case "SERVER"
        '                if reader.NodeType .Attribute .


        '                    Exit Select
        '        End Select
        '    End If
        'End While

    End Sub



End Class
