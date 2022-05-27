Imports System.Data
Imports System.Data.SqlClient
Imports Miscelleneous
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmUserControl
    Private mblnGpChanged, mblnLoading, mblnAdd As Boolean
    Private mintNextID%, mintUserGp%, mintUserID%
    Private mdcLockedStyle As New DataGridViewCellStyle
    Dim mblnPassHelpShown, mblnUserChange, mblnAddingUser, mblnChangeGroup As Boolean
    Dim mblnIsUpdate, mblnDelErr, mblnResetingPassword As Boolean
    Public frmMain As Form

    Private Sub UserEditSate(ByVal State As Boolean)
        UserNameTextBox.Enabled = State
        FullNameTextBox.Enabled = State
        PasswordTextBox.Enabled = State
        UserGroupTextBox.Enabled = State
        'save.Enabled = False
        'btnResetPass.Enabled = State
        Dim ctrl As Control
        For Each ctrl In gbAuth.Controls
            If TypeOf (ctrl) Is Label Then ctrl.Enabled = State
        Next
        Try
            bnUsers.Items("AddNew").Enabled = State
        Catch
        End Try
        Try
            bnUsers.Items("save").Enabled = State
        Catch
        End Try
        'Try
        '    txtSupportPass.Visible = Not State
        'Catch
        'End Try

        'Try
        '    lblSupportPass.Visible = Not State
        'Catch
        'End Try
        'Try
        '    btnSupportPass.Visible = Not State
        'Catch
        'End Try
    End Sub

    Private Sub frmUserControl_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmUserIndex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSecurity.UserGroups1' table. You can move, or remove it, as needed.
        Me.UserGroups1TableAdapter.Fill(Me.DsSecurity.UserGroups1)
        'TODO: This line of code loads data into the 'DsSecurity.UserGroups' table. You can move, or remove it, as needed.
        Prepareform(Me, frmMain, False)
        Show()
        Me.UserGroupsTableAdapter.Fill(Me.DsSecurity.UserGroups)
        'TODO: This line of code loads data into the 'DsSecurity.UserAuthorisations' table. You can move, or remove it, as needed.
        Me.UserAuthorisationsTableAdapter.Fill(Me.DsSecurity.UserAuthorisations)
        'TODO: This line of code loads data into the 'DsSecurity.UserAuthorisations' table. You can move, or remove it, as needed.
        'Me.UserAuthorisationsTableAdapter.Fill(Me.DsSecurity.UserAuthorisations)
        'TODO: This line of code loads data into the 'DsComponents.Components' table. You can move, or remove it, as needed.
        Me.ComponentsTableAdapter.Fill(Me.DsComponents.Components)
        Me.UsersTableAdapter.FillBy(DsSecurity.Users)

        Try
            MdiParent = frmMain

            mblnGpChanged = False
            mblnUserChange = False
            mblnDelErr = False
            mblnLoading = True
            mblnAddingUser = False
            mblnIsUpdate = True
            'btnReset.Enabled = True
            mintNextID = -1
            mintUserID = 0
            ''If gintTheGroup <> 1 Then tbOne.TabPages(3).Dispose()
            Try
                UserGroupsTableAdapter.Connection.ConnectionString = ConnectionString()
                UsersTableAdapter.Connection.ConnectionString = ConnectionString()
                UserGroupsTableAdapter.Fill(Me.DsSecurity.UserGroups)
                Me.UserAuthorisationsTableAdapter.Fill(Me.DsSecurity.UserAuthorisations)
                Me.ComponentsTableAdapter.Fill(Me.DsComponents.Components)
                Me.ComponentsTableAdapter.Fill(Me.DsComponents.Components)
            Catch
            End Try

            DontShowPassHelp()
            With mdcLockedStyle
                .BackColor = Color.Beige
                .ForeColor = Color.Black
                .SelectionBackColor = Color.Beige
                .SelectionForeColor = Color.Gold
            End With
            SetGpAppear()
            'With goKernel
            '    .CurrentPc = "."
            '    .LoadParents()
            '    .LoadTrueParents()
            '    .LoadAllNodes()
            'End With
            mblnLoading = False
            tmr.Enabled = True
            Cursor = Cursors.Default
        Catch
            Cursor = Cursors.Default
        End Try
        clstAuth.Items.Clear()
        Dim dr As SqlDataReader = Nothing
        Dim sql As String = ""
        sql = "select Comp_CompName from dbo.components"
        dr = ExecuteReader(sql, Nothing)
        Try
            While dr.Read
                clstAuth.Items.Add(dr(0).ToString)
            End While
        Catch ex As Exception

        End Try
        cboGp_SelectedIndexChanged(Me, Nothing)

        'Dim row As DataGridViewRow
        'For Each row In DataGridView2.Rows
        '    If row.Cells(0).Value = 2 Or 3 Then
        '        row.ReadOnly = True
        '    End If
        'Next
    End Sub
    Private Sub DontShowPassHelp()
        'mblnPassHelpShown = False
        'With spltHelp
        '    .Width = 128 : .Height = 38
        '    .Left = 400 : .Top = 173
        '    .SplitterDistance = 99
        '    rtbHelp.Text = "Password Help"
        '    rtbHelp.ForeColor = Color.LemonChiffon
        'End With
    End Sub
    Private Sub SetGpAppear()
        Dim i%
        For i = 0 To dgvUserGps.Rows.Count - 1
            If i < 4 Then
                dgvUserGps.Item(0, i).Style = mdcLockedStyle
                dgvUserGps.Item(0, i).ReadOnly = True
                dgvUserGps.Item(1, i).Style = mdcLockedStyle
                dgvUserGps.Item(1, i).ReadOnly = True
            End If
        Next
    End Sub


    Private Function GetNextGpID%()
        Dim sql$
        Dim NewID% = 0
        Dim oResult As Object = Nothing
        If mintNextID <> -1 Then Return mintNextID + 1
        Try
            sql = "SELECT ISNULL(MAX(Ugp_UserGroup),0) FROM dbo.UserGroups"

            oResult = ExecuteScalar(sql)
            If Not IsNothing(oResult) Then
                If Not TypeOf (oResult) Is DBNull Then
                    NewID = CInt(oResult)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error retrieving group id")
        Finally
        End Try
        NewID += 1
        mintNextID = NewID
        Return NewID
    End Function
    Private Function GetNextUserID%()
        Dim sql$
        Dim NewID% = 0
        Dim oResult As Object = Nothing
        Try

            sql = "SELECT ISNULL(MAX(Usr_EntryID),0) FROM dbo.Users"

            oResult = ExecuteScalar(sql)
            If Not IsNothing(oResult) Then
                If Not TypeOf (oResult) Is DBNull Then
                    NewID = CInt(oResult)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error retrieving group id")
        Finally
        End Try
        NewID += 1
        mintNextID = NewID
        Return NewID
    End Function
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnCo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
        'frmSystemControl.Show()
    End Sub

    Private Sub btnEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub frmUserControl_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
    End Sub

    Private Sub UserGroupsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savegp.Click
        GrpSave()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GrpChange()
    End Sub

    Private Sub dgvUserGps_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvUserGps.CellBeginEdit
        If IsNothing(dgvUserGps.Item(0, e.RowIndex)) Then Exit Sub
        If TypeOf (dgvUserGps.Item(0, e.RowIndex).Value) Is DBNull Then dgvUserGps.Item(0, e.RowIndex).Value = GetNextGpID()

    End Sub

    Private Sub dgvUserGps_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUserGps.CellContentClick

    End Sub

    Private Sub dgvUserGps_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUserGps.CellEndEdit
        If Not mblnLoading Then GrpChange()
    End Sub

    Private Sub dgvUserGps_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvUserGps.CellMouseDoubleClick

    End Sub
    Private Sub GrpChange()
        bnUserGp.Items("savegp").Enabled = True
        mblnGpChanged = True
    End Sub
    Private Sub GrpSave()
        mintNextID = -1
        Try
            If mblnDelErr Then
                MsgBox("db error: system defined groups cannot be modified or deleted",
                MsgBoxStyle.Exclamation, "error saving user groups")
            Else
                Validate()
                UserGroups1BindingSource1.EndEdit()
                Me.UserGroups1TableAdapter.Update(DsSecurity.UserGroups1)
                bnUserGp.Items("savegp").Enabled = False
                mblnGpChanged = False
                MsgBox("user groups saved successfully", MsgBoxStyle.Information, "success")
            End If
        Catch ex As Exception
            If InStr(LCase(ex.Message), "fk_users") > 0 Then
                MsgBox("can not delete groups if they have users.", MsgBoxStyle.Exclamation, "error saving user groups")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error saving user groups")
            End If
        End Try
        mblnDelErr = False
        Try
            UserGroupsTableAdapter.Fill(Me.DsSecurity.UserGroups)
            SetGpAppear()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CmpSve()
        Try
            Validate()
            ComponentsBindingSource.EndEdit()
            ComponentsTableAdapter.Update(DsComponents.Components)
            ' bnUserGp.Items("savegp").Enabled = False
            'mblnGpChanged = False
            MsgBox("Components Successfully Added", MsgBoxStyle.Information, "success")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub usrsve()

        If Trim(UserNameTextBox.Text) = "" Then
            MsgBox("enter username", MsgBoxStyle.Exclamation, "incomplete data.")
            UserNameTextBox.Focus()
            Exit Sub
        End If

        If Trim(FullNameTextBox.Text) = "" Then
            MsgBox("enter fullname", MsgBoxStyle.Exclamation, "incomplete data.")
            FullNameTextBox.Focus()
            Exit Sub
        End If
        If PasswordTextBox.Text <> UserGroupTextBox.Text Then
            MsgBox("Passwords do not match", MsgBoxStyle.Exclamation, "confirm password")
            UserGroupTextBox.Text = ""
            UserGroupTextBox.Focus()
            Exit Sub
        End If

        If UserExisting(Trim(UserNameTextBox.Text)) And mblnAddingUser Then
            MsgBox("there is already another user with this name.", MsgBoxStyle.Exclamation, "existing user.")
            UserNameTextBox.Text = ""
            UserNameTextBox.Focus()
            Exit Sub
        ElseIf UserExisting(Trim(UserNameTextBox.Text)) = False And mblnAddingUser Then

            Try

                Dim userRow As dsSecurity.UsersRow
                Dim val As String = GetTableValue("users", "usr_user", "usr_EntryId", UserNameTextBox.Text, 0)
                userRow = DsSecurity.Users.NewUsersRow
                userRow.Usr_UserGroup = cboGp_for_Users.SelectedValue
                userRow.Usr_User = UserNameTextBox.Text
                userRow.Usr_FullName = FullNameTextBox.Text
                '  userRow.Usr_EntryID = val
                userRow.Usr_Password = PasswordTextBox.Text
                ' MsgBox(PasswordTextBox.Text)
                userRow.Usr_Active = 1
                DsSecurity.Users.Rows.Add(userRow)
                UsersTableAdapter.Update(DsSecurity.Users)
                MsgBox("User successfully Created", MsgBoxStyle.Information, "success!")
                mblnAddingUser = False
                Try
                    UserGroupsTableAdapter.Connection.ConnectionString = ConnectionString()
                    UsersTableAdapter.Connection.ConnectionString = ConnectionString()
                    UserGroupsTableAdapter.Fill(Me.DsSecurity.UserGroups)
                    Me.UserAuthorisationsTableAdapter.Fill(Me.DsSecurity.UserAuthorisations)
                    Me.ComponentsTableAdapter.Fill(Me.DsComponents.Components)
                    Me.ComponentsTableAdapter.Fill(Me.DsComponents.Components)
                Catch
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf mblnAddingUser = False Then
            Try
                Dim userRow As dsSecurity.UsersRow
                Dim val As String = GetTableValue("users", "usr_user", "usr_EntryId", UserNameTextBox.Text, 0)
                Dim pos As Integer = UsersBindingSource.Find("Usr_user", UserNameTextBox.Text)
                userRow = DsSecurity.Users.Rows.Item(pos)
                userRow.Usr_UserGroup = cboGp_for_Users.SelectedValue
                userRow.Usr_User = UserNameTextBox.Text
                userRow.Usr_FullName = FullNameTextBox.Text
                '  userRow.Usr_EntryID = val
                If mblnResetingPassword Then
                    userRow.Usr_Password = "Password1"
                Else
                    userRow.Usr_Password = PasswordTextBox.Text
                End If
                userRow.Usr_Active = 0
                Validate()
                UsersBindingSource.EndEdit()
                UsersTableAdapter.Update(DsSecurity.Users)
                MsgBox("User successfully Updated")
                mblnResetingPassword = False
                mblnAddingUser = False
                mblnChangeGroup = False
                Try
                    UserGroupsTableAdapter.Connection.ConnectionString = ConnectionString()
                    UsersTableAdapter.Connection.ConnectionString = ConnectionString()
                    UserGroupsTableAdapter.Fill(Me.DsSecurity.UserGroups)
                    Me.UserAuthorisationsTableAdapter.Fill(Me.DsSecurity.UserAuthorisations)
                    Me.ComponentsTableAdapter.Fill(Me.DsComponents.Components)
                    Me.ComponentsTableAdapter.Fill(Me.DsComponents.Components)
                Catch
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub dgvUserGps_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvUserGps.DataError
        MsgBox(e.Exception.Message, MsgBoxStyle.Exclamation, "error saving user groups")
    End Sub

    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick

    End Sub
    Private Sub AuthSave()

        Dim a As Integer = clstAuth.Items.Count
        Dim authrow As dsSecurity.UserAuthorisationsDataTable
        authrow = DsSecurity.UserAuthorisations
        Dim comprow As dsComponents.ComponentsRow
        Dim row As dsSecurity.UserAuthorisationsRow
        Try
            For Each row In authrow.Rows
                If row.Auth_Group = cboGp.SelectedValue Then
                    UserAuthorisationsTableAdapter.Delete(row.Auth_Group, row.Auth_AccComp, row.Auth_HasAccess)
                End If

            Next
            Me.UserAuthorisationsTableAdapter.Update(DsSecurity.UserAuthorisations)
            UserAuthorisationsTableAdapter.Fill(DsSecurity.UserAuthorisations)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        For c1 = 0 To a - 1
            row = DsSecurity.UserAuthorisations.NewUserAuthorisationsRow
            Dim d As Integer = ComponentsBindingSource.Find("Comp_CompName", clstAuth.Items(c1).ToString)
            comprow = DsComponents.Components.Rows(d)
            row.Auth_Group = cboGp.SelectedValue.ToString
            row.Auth_AccComp = comprow.Comp_AccessId
            row.Auth_HasAccess = clstAuth.GetItemChecked(c1)
            Try
                DsSecurity.UserAuthorisations.Rows.Add(row)
            Catch ex As Exception

            End Try

        Next

        'Me.UserAuthorisationsTableAdapter.Update(DsSecurity.UserAuthorisations)
        UserAuthorisationsBindingSource.EndEdit()
        UserAuthorisationsTableAdapter.Update(DsSecurity.UserAuthorisations)
        MsgBox("UserAuthorisations Saved")




        'Dim sql As String = ""
        'Dim x, y, z As Integer
        'Dim i, j, k As Integer
        'x = 0 : y = 0 : z = 0
        'i = 0 : j = 0 : k = 0
        'Dim IsChecked As Boolean
        'Try
        '    i = clstAuth.Items.Count - 1
        '    For j = 0 To i
        '        IsChecked = clstAuth.GetItemChecked(j)
        '        sql = "UPDATE dbo.UserAuthorisations SET Auth_HasAccess = " & CInt(IIf(IsChecked, 1, 0)) & _
        '            " WHERE Auth_Group ='" & cboGp.SelectedValue & "' And Auth_AccComp = '" & _
        '        GetTableValue("Components", "Comp_CompName", "Comp_AccessID", clstAuth.Items(j).ToString, False) & "'"
        '        ExecuteNonQuery(sql)
        '    Next
        '    cboGp_SelectedIndexChanged(Me, Nothing)
        '    MsgBox("Authorisation saved successfully", MsgBoxStyle.Information, "success!")
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error saving data")
        'End Try

    End Sub


    Private Sub delgp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delgp.Click
        Try
            Dim i% = dgvUserGps.SelectedRows.Count
            Dim j% = 0
            If i > 0 Then
                For j = 0 To i
                    If Not IsNothing(dgvUserGps.SelectedRows.Item(j).Cells(1).Value) Then
                        If CInt(dgvUserGps.SelectedRows.Item(j).Cells(1).Value) < 4 Then mblnDelErr = True
                    End If
                Next
            End If
        Catch
        End Try
        GrpChange()
    End Sub

    Private Sub tbOne_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOne.Click


        If tbOne.TabIndex >= 0 Then LoadUserGroups()
        If tbOne.TabIndex = 2 Then
            UsersTableAdapter.Fill(Me.DsSecurity.Users, mintUserGp)
        End If

    End Sub
    Private Sub LoadUserGroups()
        'Dim sql$
        'Dim firstOne$ = ""
        'Dim i% = 0
        'Dim drR As SqlDataReader = Nothing
        'Cursor = Cursors.WaitCursor
        'Try
        '    cboGp.Items.Clear()
        '    cboGp_for_Users.Items.Clear()
        '    cboGp_for_Users.Text = ""
        '    cboGp.Text = ""

        '    sql = "SELECT CAST(Ugp_UserGroup AS nvarchar(50)) + ' - ' + Ugp_GroupName FROM UserGroups ORDER BY Ugp_UserGroup"

        '    drR = ExecuteReader(sql)
        '    While drR.Read
        '        cboGp.Items.Add(drR(0).ToString)
        '        cboGp_for_Users.Items.Add(drR(0).ToString)
        '        If i = 0 Then firstOne = cboGp.Items(i).ToString
        '        i += 1
        '    End While
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error loading usergroups")
        'Finally

        'End Try
        'cboGp.Text = firstOne
        'cboGp_for_Users.Text = firstOne
        'Cursor = Cursors.Default
    End Sub

    ''Public Sub ShrinkSplitter(ByVal spltCont As SplitContainer, ByVal lbl As Label, ByVal blnDropAnchor As Boolean)
    ''    goKernel.ShrinkSplitter(spltCont, lbl, blnDropAnchor)
    ''End Sub



    Private Sub cboGp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGp.TextChanged
        'Dim Gp$ = ""
        'If cboGp.Text = "" Then Exit Sub
        'Gp = CleanComboVal(cboGp.Text)
        'mintUserGp = CInt(Gp)
        'goKernel.UserGroup = mintUserGp
        ' mintUserGp = mintUserGp
        'RefreshLists()
    End Sub
    'Private Sub RefreshLists()
    '    Cursor = Cursors.WaitCursor
    '    'With goKernel
    '    '    .ShowTreeNodes(tvAvailable, True)
    '    '    .ShowTreeNodes(tvAccessible, False)
    '    'End With
    '    If mintUserGp < 4 Then
    '        tvAvailable.Enabled = False
    '        tvAccessible.Enabled = False
    '        Button1.Enabled = False
    '        Button2.Enabled = False
    '        btnReset.Enabled = False
    '    Else
    '        tvAvailable.Enabled = True
    '        tvAccessible.Enabled = True
    '        Button1.Enabled = True
    '        Button2.Enabled = True
    '        btnReset.Enabled = True
    '    End If
    '    Cursor = Cursors.Default
    'End Sub


    Private Sub cboGp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGp.SelectedIndexChanged
        Dim grp As String = ""
        Try
            grp = cboGp.SelectedValue
        Catch ex As Exception
            Exit Sub
        End Try

        Dim sql As String = ""
        Dim Dr As SqlDataReader = Nothing
        ' Dim item As CheckedListBox.CheckedItemCollection
        sql = "select Auth_AccComp ,Auth_HasAccess, Comp_CompName from " &
              "dbo.UserAuthorisations INNER JOIN Components ON Auth_AccComp = Comp_AccessID " &
              "where Auth_Group =" & grp
        Dr = ExecuteReader(sql, Nothing)
        Try
            If Dr.HasRows = False Then
                Dim itmcount As Integer = clstAuth.Items.Count
                For a1 = 0 To itmcount - 1
                    'Dim compid As String = GetTableValue("components", "Comp_CompName", "Comp_Accessid", clstAuth.Items.Item(a).ToString, False)
                    clstAuth.SetItemChecked(a1, False)
                Next
            End If
            Try

                While Dr.Read
                    Dim itmcount As Integer = clstAuth.Items.Count
                    For a1 = 0 To itmcount - 1
                        If LCase(Dr(2).ToString) = LCase(clstAuth.Items(a1).ToString) Then
                            clstAuth.SetItemChecked(a1, CBool(Dr.Item(1)))
                            Exit For
                        End If
                    Next
                End While
                Refresh()
            Catch ex As Exception
                ''Dim itmcount As Integer = clstAuth.Items.Count
                ''For a = 0 To itmcount - 1
                ''    'Dim compid As String = GetTableValue("components", "Comp_CompName", "Comp_Accessid", clstAuth.Items.Item(a).ToString, False)
                ''    clstAuth.SetItemChecked(a, False)
                ''Next
            End Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tvAvailable_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)

    End Sub

    'Private Sub tvAvailable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Not IsNothing(lsbAvailableComponents.SelectedItem) Then
    '        Dim index As Integer = lsbAvailableComponents.SelectedIndex
    '        lsbAccessibleComps.Items.Add(lsbAvailableComponents.SelectedItem)
    '        lsbAvailableComponents.Items.RemoveAt(index)
    '        Try
    '            If index = 0 Then
    '            Else
    '                index -= 1
    '            End If

    '            lsbAvailableComponents.SetSelected(index, True)

    '        Catch ex As Exception

    '        End Try

    '    End If
    'End Sub

    'Private Sub tvAccessible_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Not IsNothing(lsbAccessibleComps.SelectedItem) Then
    '        Dim index As Integer = lsbAccessibleComps.SelectedIndex
    '        lsbAvailableComponents.Items.Add(lsbAccessibleComps.SelectedItem)
    '        lsbAccessibleComps.Items.RemoveAt(index)
    '        Try
    '            If index = 0 Then
    '            Else
    '                index -= 1
    '            End If

    '            lsbAccessibleComps.SetSelected(index, True)

    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    Private Sub tvAccessible_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'goKernel.ResetAuthor()
        'RefreshLists()
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    tvAvailable_DoubleClick(Me, e)
    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    tvAccessible_DoubleClick(Me, e)
    'End Sub



    Private Sub cboGp_for_Users_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGp_for_Users.TextChanged
        If Not mblnChangeGroup Then
            mblnLoading = True
            btnLockUser.Enabled = True
            Try
                mintUserGp = cboGp_for_Users.SelectedValue
                UsersTableAdapter.Fill(Me.DsSecurity.Users, mintUserGp)
                ' txtSupportPass.Text = ""
                If mintUserGp = 0 Then
                    UserEditSate(False)
                    'txtSupportPass.Focus()
                Else
                    UserEditSate(True)
                End If
                '    If Trim(txtUid.Text) = "" Then
                '        mintUserID = -1
                '    Else
                '        mintUserID = CInt(Val(txtUid.Text))
                '    End If
                '    UserNameTextBox.Enabled = False
            Catch
            End Try
            mblnLoading = False

        Else
            Exit Sub

        End If



    End Sub



    Private Sub UserNameTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserNameTextBox.Click
        UserNameTextBox.SelectAll()
    End Sub

    Private Sub UserNameTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserNameTextBox.GotFocus
        UserNameTextBox.SelectAll()
    End Sub

    Private Sub UserNameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UserNameTextBox.KeyPress
        mblnLoading = False
    End Sub

    Private Sub UserNameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserNameTextBox.LostFocus
        If UserExisting(Trim(UserNameTextBox.Text)) And mblnAddingUser Then
            MsgBox("there is already another user with this name.", MsgBoxStyle.Exclamation, "existing user.")
            UserNameTextBox.Text = ""
            UserNameTextBox.Focus()
        End If
    End Sub

    Private Sub UserNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserNameTextBox.TextChanged
        If Not mblnLoading Then mblnUserChange = True
    End Sub

    Private Sub FullNameTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FullNameTextBox.Click
        FullNameTextBox.SelectAll()
    End Sub

    Private Sub FullNameTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FullNameTextBox.GotFocus
        FullNameTextBox.SelectAll()
    End Sub

    Private Sub FullNameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FullNameTextBox.KeyPress
        mblnLoading = False
    End Sub

    Private Sub FullNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullNameTextBox.TextChanged
        If Not mblnLoading Then mblnUserChange = True
    End Sub

    Private Sub PasswordTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasswordTextBox.Click
        PasswordTextBox.SelectAll()
    End Sub

    Private Sub PasswordTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasswordTextBox.GotFocus
        PasswordTextBox.SelectAll()
        '  rtbHelp.ForeColor = Color.Goldenrod
    End Sub

    Private Sub PasswordTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        mblnLoading = False
        mblnIsUpdate = False
    End Sub

    Private Sub PasswordTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasswordTextBox.LostFocus
        'rtbHelp.ForeColor = Color.LemonChiffon
    End Sub

    Private Sub PasswordTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged
        If Not mblnLoading Then mblnUserChange = True
    End Sub

    Private Sub UserGroupTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserGroupTextBox.Click
        UserGroupTextBox.SelectAll()
    End Sub

    Private Sub UserGroupTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserGroupTextBox.GotFocus
        UserGroupTextBox.SelectAll()
        'rtbHelp.ForeColor = Color.Goldenrod
    End Sub

    Private Sub UserGroupTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UserGroupTextBox.KeyPress
        mblnLoading = False
        mblnIsUpdate = False
    End Sub

    Private Sub UserGroupTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserGroupTextBox.LostFocus
        ' rtbHelp.ForeColor = Color.LemonChiffon
    End Sub

    Private Sub UserGroupTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserGroupTextBox.TextChanged
        If Not mblnLoading Then mblnUserChange = True
    End Sub

    Private Sub txtSupportPass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        '    txtSupportPass.SelectAll()
    End Sub

    Private Sub txtSupportPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnSupportPass_Click(Me, e)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSupportPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If goMajorDomo.IsSupport(txtSupportPass.Text) Then
        '    UserEditSate(True)
        '    UserNameTextBox.Focus()
        'Else
        '    UserEditSate(False)
        '    cboGp_for_Users.Focus()
        'End If
    End Sub
    Private Function UserExisting(ByVal Nm$) As Boolean
        Dim Exists As Boolean = False
        Dim sql$ = ""
        Dim oResult As Object = Nothing
        Try

            sql = "SELECT Usr_User FROM Users WHERE Usr_User ='" & Nm & "'"

            oResult = ExecuteScalar(sql)
            If Not IsNothing(oResult) Then
                If Not TypeOf (oResult) Is DBNull Then
                    Exists = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error retrieving user information")
        Finally

        End Try
        Return Exists
    End Function
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Trim(UserNameTextBox.Text) = "" Then
            MsgBox("enter username", MsgBoxStyle.Exclamation, "incomplete data.")
            UserNameTextBox.Focus()
            Exit Sub
        End If
        If UserExisting(Trim(UserNameTextBox.Text)) And mblnAddingUser Then
            MsgBox("there is already another user with this name.", MsgBoxStyle.Exclamation, "existing user.")
            UserNameTextBox.Text = ""
            UserNameTextBox.Focus()
            Exit Sub
        End If
        If Trim(FullNameTextBox.Text) = "" Then
            MsgBox("enter fullname", MsgBoxStyle.Exclamation, "incomplete data.")
            FullNameTextBox.Focus()
            Exit Sub
        End If
        If PasswordTextBox.Text <> UserGroupTextBox.Text Then
            MsgBox("Passwords do not match", MsgBoxStyle.Exclamation, "confirm password")
            UserGroupTextBox.Text = ""
            UserGroupTextBox.Focus()
            Exit Sub
        End If

        Try
            Dim entryid As String
            entryid = GetNextUserID()
            Dim userRow As dsSecurity.UsersRow
            userRow = DsSecurity.Users.NewUsersRow
            userRow.Usr_UserGroup = cboGp_for_Users.SelectedValue
            userRow.Usr_User = UserNameTextBox.Text
            userRow.Usr_FullName = FullNameTextBox.Text
            userRow.Usr_EntryID = entryid
            userRow.Usr_Password = PasswordTextBox.Text
            userRow.Usr_Active = 0
            DsSecurity.Users.Rows.Add(userRow)
            UsersTableAdapter.Update(DsSecurity.Users)
            MsgBox("User successfully Created")
            btnSave.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub ShowPassHelp()
        'mblnPassHelpShown = True
        'With spltHelp
        '    .Width = 459
        '    .Height = 64
        '    .SplitterDistance = 430
        '    .Top = 185
        '    .Left = 36
        'End With
        ''rtbHelp.Text = goMajorDomo.PasswordCriteria
        'rtbHelp.ForeColor = Color.Goldenrod
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not mblnPassHelpShown Then
            ShowPassHelp()
        Else
            DontShowPassHelp()
        End If

    End Sub
    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UserGroupsBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UserGroupsBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Trim(txtUid.Text) = "" Then
            mintUserID = -1
        Else
            mintUserID = CInt(Val(txtUid.Text))
        End If
    End Sub

    Private Sub UserGroupsBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mblnLoading = True
        UserNameTextBox.Enabled = False
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mblnLoading = True
        UserNameTextBox.Enabled = False
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mblnLoading = True
        UserNameTextBox.Enabled = False
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mblnLoading = True
        UserNameTextBox.Enabled = False
    End Sub

    Private Sub btnResetPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetPass.Click
        mblnAddingUser = False
        mblnChangeGroup = False
        mblnResetingPassword = True
        If MsgBox("this will reset the password for this user to 'Password1'" & vbCr & vbCr &
        "do you want yo continue", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxResult)) = MsgBoxResult.Yes Then
            PasswordTextBox.Text = "Password1"
            UserGroupTextBox.Text = "Password1"
            mblnIsUpdate = False
            '  MsgBox(PasswordTextBox.Text)
            btnSave_Click(Me, e)
        End If
    End Sub

    Private Sub AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew.Click
        Try
            cboGp_for_Users.Text = ""
            mblnLoading = True
            mblnAddingUser = True
            mblnResetingPassword = False
            mblnChangeGroup = False
            UserNameTextBox.Enabled = True
            mblnIsUpdate = False
            'save.Enabled = True
            'btnSave.Enabled = False
            btnResetPass.Enabled = False
            btnLockUser.Enabled = False
            btnChangGroup.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvUserGps_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvUserGps.KeyDown
        If e.KeyCode = Keys.Delete Then
            Try
                Dim i% = dgvUserGps.SelectedRows.Count
                Dim j% = 0
                If i > 0 Then
                    For j = 0 To i
                        If Not IsNothing(dgvUserGps.SelectedRows.Item(j).Cells(1).Value) Then
                            If CInt(dgvUserGps.SelectedRows.Item(j).Cells(1).Value) < 4 Then mblnDelErr = True
                        End If
                    Next
                End If
            Catch
            End Try
            GrpChange()
        End If
    End Sub

    Private Sub txtUid_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUid.TextChanged
        If Trim(txtUid.Text) = "" Then
            mintUserID = -1
        Else
            mintUserID = CInt(Val(txtUid.Text))
        End If
    End Sub

    Private Sub btnCo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        ttOne.Show("go to system control.", Me, 25, 65, 5000)
    End Sub

    Private Sub btnCo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        ttOne.Hide(Me)
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Select Case tbOne.SelectedIndex
            Case 0
                GrpSave()
            Case 1
                AuthSave()
            Case 2
                usrsve()
            Case 3
                CmpSve()
        End Select
    End Sub

    'Private Sub lsbAvailableComponents_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Right Then
    '        tvAvailable_DoubleClick(Me, e)

    '    End If
    'End Sub

    'Private Sub lsbAvailableComponents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub lsbAccessibleComps_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Left Then
    '        tvAccessible_DoubleClick(Me, e)
    '    End If
    'End Sub




    Private Sub spltHelp_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub gbGD_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbGD.Enter

    End Sub

    Private Sub BindingNavigatorMoveNextItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveNextItem1.Click
        ' save.Enabled = False
    End Sub

    Private Sub tbOne_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOne.SelectedIndexChanged


        ''If tbOne.SelectedIndex = 2 Then
        ''    btnSave.Text = "Edit User"
        ''    ' save.Enabled = False
        ''Else
        ''    btnSave.Enabled = True
        ''    btnSave.Text = "Save"
        ''End If
    End Sub

    Private Sub BindingNavigatorMoveFirstItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveFirstItem1.Click
        ' save.Enabled = False
    End Sub

    Private Sub BindingNavigatorMovePreviousItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMovePreviousItem1.Click
        ' save.Enabled = False
    End Sub

    Private Sub BindingNavigatorMoveLastItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveLastItem1.Click
        ' save.Enabled = False
    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.UsersTableAdapter.Fill(Me.DsSecurity.Users, CType(GroupToolStripTextBox.Text, Integer))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub cboGp_for_Users_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGp_for_Users.SelectedIndexChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLockUser.Click

        If mblnAddingUser = False Then

            Dim sql As String
            Dim active As Boolean

            sql = "select usr_active from users where usr_user = '" & UserNameTextBox.Text & "'"
            active = ExecuteScalar(sql)

            If active = False Then

                sql = "update  users set usr_active = 1 where usr_user = '" & UserNameTextBox.Text & "'"

                ExecuteNonQuery(sql)

                If era = False Then

                    MsgBox("User has been succefully locked")
                End If
            Else
                '  If MsgBox("User is already locked do you want to unlock ", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                sql = "update  users set usr_active = 0 where usr_user = '" & UserNameTextBox.Text & "'"
                ExecuteNonQuery(sql)
                If era = False Then
                    sql = " update userlogin set failedattempts = '0' where [user] = '" & UserNameTextBox.Text & "'"
                    ExecuteNonQuery(sql)
                    If era = False Then
                        MsgBox("User has been succefully Unlocked ")
                    End If
                End If
                'End If


            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserSearch.TextChanged
        Dim serchtext As String = Trim(txtUserSearch.Text)
        lbusers.Items.Clear()
        Dim drr As SqlDataReader

        lbusers.Visible = True
        Dim sql As String = " select usr_user,usr_fullname from users where usr_user + ' ' + usr_fullname  like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lbusers.Items.Add(drr(0))
        End While
    End Sub

    Private Sub lbusers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbusers.DoubleClick
        Try
            '   Me.UsersTableAdapter.FillBy(DsSecurity.Users)


            txtUserSearch.Text = lbusers.SelectedItem.ToString
            lbusers.Items.Clear()
            '   search()
            lbusers.Visible = False


            Dim sql As String = " select usr_usergroup from users where usr_user = '" & txtUserSearch.Text & "'"
            Dim grp$ = ExecuteScalar(sql)


            Me.UsersTableAdapter.Fill(DsSecurity.Users, grp)
            cboGp_for_Users.SelectedValue = grp



            Dim a As Integer = Me.UsersBindingSource.Find("Usr_User", Trim(txtUserSearch.Text))

            If a >= 0 Then

                Me.UsersBindingSource.Position = a
            Else
                MsgBox("User cannot be found in the current group")
            End If






        Catch ex As Exception

        End Try
    End Sub


    Private Sub lbusers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbusers.SelectedIndexChanged

    End Sub

    Private Sub btnChangGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangGroup.Click
        mblnChangeGroup = True
        mblnAddingUser = False
        mblnResetingPassword = False
        MsgBox("Select the new group for the user and Save")

    End Sub
End Class