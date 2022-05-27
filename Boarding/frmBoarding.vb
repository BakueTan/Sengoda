Imports System.Data
Imports System.Data.SqlClient

Public Class frmBoarding

    Private Sub frmBoarding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsBoarding.HostelRooms' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsBoarding.Hostel' table. You can move, or remove it, as needed.
        Me.HostelTableAdapter.Fill(Me.DsBoarding.Hostel)
        'TODO: This line of code loads data into the 'DsBoarding.BoardingCheckList' table. You can move, or remove it, as needed.
        Me.BoardingCheckListTableAdapter.Fill(Me.DsBoarding.BoardingCheckList)

        Prepareform(Me, True)
        Show()
        MdiParent = frmMain

    End Sub

    Private Sub BoardingCheckListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoardingCheckListBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.BoardingCheckListBindingSource.EndEdit()
            Me.BoardingCheckListTableAdapter.Update(Me.DsBoarding.BoardingCheckList)
            MsgBox("Save Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.HostelBindingSource.EndEdit()
            Me.HostelTableAdapter.Update(Me.DsBoarding.Hostel)
            MsgBox("Save Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Dim items As ListViewItem
        Dim subitems As ListViewItem.ListViewSubItem

        Dim item, uom, comment As String
        Dim qty As Decimal

        item = cboItem.Text
        qty = txtQty.Text
        comment = txtComment.Text

        Dim sql As String = "Select uom from boardingchecklist where item = '" & item & "'"
        uom = ExecuteScalar(sql, , True)

        items = lvStudCheckList.Items.Add("")
        items.Text = item

        subitems = items.SubItems.Add("")
        subitems.Text = qty


        subitems = items.SubItems.Add("")
        subitems.Text = uom
        subitems = items.SubItems.Add("")
        subitems.Text = comment

        txtQty.Clear()
        cboItem.Text = ""
        txtComment.Clear()

    End Sub

    Private Sub txtStud_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStud.TextChanged
        Dim serchtext As String = Trim(txtStud.Text)
        lstResult.Items.Clear()
        Dim drr As SqlDataReader

        lstResult.Visible = True
        Dim sql As String = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
        drr = ExecuteReader(sql)
        Try
            While drr.Read
                lstResult.Items.Add(drr(0) & " " & drr(1) & " " & drr(2))
            End While
            ' End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lstResult_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstResult.DoubleClick
        Try
            txtStud.Text = lstResult.SelectedItem.ToString
            lstResult.Items.Clear()
            Dim a, b As Integer
            Dim searchstring As String
            b = InStr(Trim(txtStud.Text), " ")
            searchstring = Mid(Trim(txtStud.Text), 1, b - 1)
            txtStud.Text = searchstring
            Dim sql As String
            Dim drr As SqlDataReader
            sql = " select year,semester,[year joined  joined] from studentpersonaldetails where studentid = '" & searchstring & "'"
            drr = ExecuteReader(sql, , True)
            While drr.Read
                cboClass.Text = drr(2).ToString
                cboLevel.Text = drr(0).ToString
                cboTerm.Text = drr(1).ToString
            End While

            lstResult.Visible = False
        Catch ex As Exception

        End Try

    End Sub

   
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If lvStudCheckList.Items.Count = 0 Then
            MsgBox("No Items Present")
        Else
            Dim trans As SqlTransaction = Nothing
            Dim sql, sql2 As String
            Dim itm, uom As String
            Dim qty As Double
            Dim a As Integer
            Dim comment As String
            Dim id As Integer

            If txtRefID.Text = "" And cboRef.Text = "In" Then
                sql2 = "select max(id) from studentchecklist_header  "
                Try
                    id = ExecuteScalar(sql2, True)
                Catch ex As Exception
                    id = 0
                End Try
                id += 1


                sql = " insert into studentchecklist_header(id,student,level,term,year,cartegory,datecreated,checkedinby,checkinpostdate) " & _
                    " values ( '" & id & "','" & txtStud.Text & "','" & cboLevel.Text & "','" & cboTerm.Text & "','" & cboClass.Text & "','" & cboRef.Text & "' ,'" & changedate(mskDate.Text) & "','" & goUser.FullName & "','" & changedate(Now.Date) & "')"
                ExecuteNonQuery(sql, , True, , trans, True, True)
                If era Then
                    trans.Rollback()
                    MsgBox(eramsg)
                    Exit Sub
                End If
                For a = 0 To lvStudCheckList.Items.Count - 1
                    itm = lvStudCheckList.Items(a).Text
                    qty = lvStudCheckList.Items(a).SubItems(1).Text
                    uom = lvStudCheckList.Items(a).SubItems(2).Text
                    comment = lvStudCheckList.Items(a).SubItems(3).Text

                   

                    sql = " insert into studentchecklist_details(id,item,qtyin,uom,commentin) " & _
                    " values ( '" & id & "','" & itm & "','" & qty & "','" & uom & "','" & comment & "' )"
                    ' ExecuteNonQuery(sql, , True, , trans, True)


                    If a = lvStudCheckList.Items.Count - 1 Then
                        ExecuteNonQuery(sql, , True, , trans, True)
                        If era Then
                            trans.Rollback()
                            MsgBox(eramsg)
                            Exit Sub
                        Else
                            trans.Commit()
                            MsgBox("Save Successful")
                            lvStudCheckList.Items.Clear()
                            Dim res As String = MsgBox("Do you want to print Check List", MsgBoxStyle.YesNo)
                            If res = "6" Then
                                studcheckList = True
                                '   frmReportPreview.Show()

                            End If
                        End If
                    Else
                        ExecuteNonQuery(sql, , True, , trans, True)
                        If era Then
                            trans.Rollback()
                            MsgBox(eramsg)
                            Exit Sub

                        End If
                    End If

                Next
            ElseIf txtRefID.Text <> "" And cboRef.Text = "Out" Then

                sql = "update studentchecklist_header set checkedoutby = '" & goUser.FullName & "',datecheckedout = '" & changedate(mskDate.Text) & "',checkoutpostdate = '" & changedate(Now.Date) & "',cartegory = 'Out'  where id = '" & txtRefID.Text & "'"
                ExecuteNonQuery(sql, , True, , trans, True, True)
                If era Then
                    MsgBox(eramsg)
                    trans.Rollback()
                    Exit Sub

                End If
                For a = 0 To lvStudCheckList.Items.Count - 1
                    itm = lvStudCheckList.Items(a).Text
                    qty = lvStudCheckList.Items(a).SubItems(1).Text
                    uom = lvStudCheckList.Items(a).SubItems(2).Text
                    comment = lvStudCheckList.Items(a).SubItems(3).Text

             
                    sql = "Update studentchecklist_details set qtyout = '" & qty & "',commentout = '" & comment & "' where item = '" & itm & "' and id = '" & txtRefID.Text & "'"
                    ExecuteNonQuery(sql, , True, , trans, True)

                    If era Then
                        MsgBox(eramsg)
                        trans.Rollback()
                        Exit Sub
                    End If

                    If a = lvStudCheckList.Items.Count - 1 Then
                        trans.Commit()
                        MsgBox("CheckOut successful")
                    End If

                Next


            End If


            End If
    End Sub

    Private Sub lstResult_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstResult.SelectedIndexChanged

    End Sub

    Private Sub lvStudCheckList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvStudCheckList.DoubleClick

        Dim itm, qty, comment As String
        Dim item As ListViewItem
        item = lvStudCheckList.SelectedItems(0)
        cboItem.Text = lvStudCheckList.SelectedItems(0).Text
        txtComment.Text = lvStudCheckList.SelectedItems(0).SubItems(3).Text
        txtQty.Text = lvStudCheckList.SelectedItems(0).SubItems(1).Text

        lvStudCheckList.Items.Remove(item)

        '  lbissued.Text = lvBooks.Items.Count & " books to be issued"
    End Sub

    Private Sub lvStudCheckList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvStudCheckList.SelectedIndexChanged

    End Sub

    Private Sub txtSearchCheckList_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchCheckList.TextChanged
        Dim sql As String
        Dim drr As SqlDataReader
        lbSearchCheckList.Items.Clear()
        lbSearchCheckList.Visible = True

        sql = "select id,student,studentname,studentsurname,studentchecklist_header.year,studentchecklist_header.level,studentchecklist_header.term,studentchecklist_header.cartegory,studentchecklist_header.datecreated from studentchecklist_header inner join " & _
        " studentpersonaldetails on student = studentid where studentid + ' ' + studentname + ' ' + studentsurname like  '%" & txtSearchCheckList.Text & "%' and studentchecklist_header.status =  1"

        drr = ExecuteReader(sql, , True)
        While drr.Read
            lbSearchCheckList.Items.Add(drr(0) & "-" & drr(1) & "-" & drr(2) & "-" & drr(3) & "-" & drr(4) & "-" & drr(5) & "-" & drr(6) & "-" & drr(7) & "-" & drr(8))
        End While



    End Sub

    Private Sub lbSearchCheckList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbSearchCheckList.DoubleClick
        Dim data() As String
        data = Split(lbSearchCheckList.SelectedItem.ToString, "-")
        txtSearchCheckList.Text = data(0) + "-" + data(1) + "-" + data(2) + "-" + data(3)
        txtRefID.Text = data(0)
        txtStud.Text = data(1)
        cboClass.Text = data(4)
        cboLevel.Text = data(5)
        cboTerm.Text = data(6)
        cboRef.Text = data(7)
        mskDate.Text = data(8)



        lbSearchCheckList.Visible = False

    End Sub

    Private Sub lbSearchCheckList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSearchCheckList.SelectedIndexChanged

    End Sub

    Private Sub TabPage5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        Try
            Me.HostelRoomsTableAdapter.Fill(DsBoarding.HostelRooms, ComboBox1.SelectedValue)
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer = HostelRoomsDataGridView.RowCount
        Dim sql As String
        Dim trans As SqlTransaction


        sql = "Delete hostelrooms where hostel = '" & ComboBox1.SelectedValue & "'"
        ExecuteNonQuery(sql, , True, , trans, True, True)


        For B1 = 0 To a - 2
            sql = "Insert into hostelrooms (hostel,room,NoOfBeds) values ('" & ComboBox1.SelectedValue & "','" & HostelRoomsDataGridView.Rows(B1).Cells(0).Value & "','" & HostelRoomsDataGridView.Rows(B1).Cells(1).Value & "')"
            ExecuteNonQuery(sql, , True, , trans, True)
            If era Then
                MsgBox(eramsg)
                trans.Rollback()
                Exit Sub
            Else
                If B1 = a - 2 Then
                    Try
                        trans.Commit()
                        MsgBox("Save successful")
                    Catch ex As Exception

                    End Try
                End If

            End If

        
        Next

       


    End Sub

    Private Sub ToolStripButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Try
            Me.Validate()
            Me.HostelBindingSource.EndEdit()
            Me.HostelTableAdapter.Update(Me.DsBoarding.Hostel)
            MsgBox("Save Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   

    Private Sub HostelRoomsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles HostelRoomsDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabPage6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim sql, sql2 As String
        Dim drr, drr2 As SqlDataReader
        Label13.Text = ComboBox2.Text & " Rooms "
        tvRooms.Nodes.Clear()
        chkStudents.Items.Clear()
        Dim node As TreeNode

        sql = "select room from hostelrooms where hostel = '" & ComboBox2.SelectedValue & "'"
        drr = ExecuteReader(sql, , True)

        While drr.Read


            tvRooms.Nodes.Add(drr(0))

            sql2 = "select student,studentname,studentsurname,studenthostels.year,studenthostels.form,studenthostels.term from studenthostels " & _
            " inner join studentpersonaldetails on studenthostels.student = studentpersonaldetails.studentid " & _
            " where hostel = '" & ComboBox2.SelectedValue & "' and room = '" & drr(0) & "' and studenthostels.status = 1 "
            drr2 = ExecuteReader(sql2, True)
            While drr2.Read

                For Each node In tvRooms.Nodes
                    If node.Text = drr(0) Then
                        node.Nodes.Add(drr2(0) & "-" & drr2(1) & "-" & drr2(2) & "-" & drr2(3) & "-" & drr2(4) & "-" & drr2(5))
                    End If
                Next
                ' tvRooms.Nodes(drr(0).ToString).Nodes.Add(drr2(0) & "-" & drr2(1) & "-" & drr2(2) & "-" & drr2(3) & "-" & drr2(4) & "-" & drr2(5))
                ' CloseConnection(True)
            End While



            '  CloseConnection(, True)

        End While

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If chkCheckState.Checked Then
            Dim sql, sql2, type As String
            Dim drr As SqlDataReader
            chkStudents.Items.Clear()
            Dim student As Object = Nothing
            sql = " select type from hostel where name = '" & ComboBox2.SelectedValue & "'"
            type = ExecuteScalar(sql, True)



            If type = "Boys" Then
                sql = "select enrollment.studentid,studentname ,studentsurname,[date joined] ,enrollment.year,enrollment.semester from enrollment inner join studentpersonaldetails on enrollment.studentid = studentpersonaldetails.studentid " & _
                " where enrollment.year = '" & ComboBox5.Text & "' and enrollment.[date joined] = '" & ComboBox3.Text & "' and enrollment.semester = '" & ComboBox4.Text & "' AND enrollment.gender = 'M'"
                drr = ExecuteReader(sql, True)
            ElseIf type = "Girls" Then
                sql = "select enrollment.studentid,studentname ,studentsurname,[date joined] ,enrollment.year,enrollment.semester from enrollment inner join studentpersonaldetails on enrollment.studentid = studentpersonaldetails.studentid " & _
             " where enrollment.year = '" & ComboBox5.Text & "' and enrollment.[date joined] = '" & ComboBox3.Text & "' and enrollment.semester = '" & ComboBox4.Text & "' and enrollment.gender = 'F'"
                drr = ExecuteReader(sql, True)
            Else
                sql = "select enrollment.studentid,studentname ,studentsurname,[date joined] ,enrollment.year,enrollment.semester from enrollment inner join studentpersonaldetails on enrollment.studentid = studentpersonaldetails.studentid " & _
             " where enrollment.year = '" & ComboBox5.Text & "' and enrollment.[date joined] = '" & ComboBox3.Text & "' and enrollment.semester = '" & ComboBox4.Text & "'"
                drr = ExecuteReader(sql, True)
            End If

            While drr.Read
                sql2 = "select student from studenthostels where student = '" & drr(0) & "' and status = 1"

                student = ExecuteScalar(sql2, True)

                If IsNothing(student) Then
                    chkStudents.Items.Add(drr(0) & "-" & drr(1) & "-" & drr(2) & "-" & drr(3) & "-" & drr(4) & "-" & drr(5))
                End If


            End While
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If chkCheckState.Checked Then
            Dim sql, sql2, type As String
            Dim drr As SqlDataReader
            chkStudents.Items.Clear()
            Dim student As Object = Nothing
            sql = " select type from hostel where name = '" & ComboBox2.SelectedValue & "'"
            type = ExecuteScalar(sql, True)



            If type = "Boys" Then
                sql = "select enrollment.studentid,studentname ,studentsurname,[date joined] ,enrollment.year,enrollment.semester from enrollment inner join studentpersonaldetails on enrollment.studentid = studentpersonaldetails.studentid " & _
                " where enrollment.year = '" & ComboBox5.Text & "' and enrollment.[date joined] = '" & ComboBox3.Text & "' and enrollment.semester = '" & ComboBox4.Text & "' AND enrollment.gender = 'M'"
                drr = ExecuteReader(sql, True)
            ElseIf type = "Girls" Then
                sql = "select enrollment.studentid,studentname ,studentsurname,[date joined] ,enrollment.year,enrollment.semester from enrollment inner join studentpersonaldetails on enrollment.studentid = studentpersonaldetails.studentid " & _
             " where enrollment.year = '" & ComboBox5.Text & "' and enrollment.[date joined] = '" & ComboBox3.Text & "' and enrollment.semester = '" & ComboBox4.Text & "' and enrollment.gender = 'F'"
                drr = ExecuteReader(sql, True)
            Else
                sql = "select enrollment.studentid,studentname ,studentsurname,[date joined] ,enrollment.year,enrollment.semester from enrollment inner join studentpersonaldetails on enrollment.studentid = studentpersonaldetails.studentid " & _
             " where enrollment.year = '" & ComboBox5.Text & "' and enrollment.[date joined] = '" & ComboBox3.Text & "' and enrollment.semester = '" & ComboBox4.Text & "'"
                drr = ExecuteReader(sql, True)
            End If

            While drr.Read
                sql2 = "select student from studenthostels where student = '" & drr(0) & "' and status = 1"

                student = ExecuteScalar(sql2, True)

                If IsNothing(student) Then
                    chkStudents.Items.Add(drr(0) & "-" & drr(1) & "-" & drr(2) & "-" & drr(3) & "-" & drr(4) & "-" & drr(5))
                End If


            End While
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If chkCheckState.Checked Then
            Dim sql, sql2, type As String
            Dim drr As SqlDataReader
            chkStudents.Items.Clear()
            Dim student As Object = Nothing
            sql = " select type from hostel where name = '" & ComboBox2.SelectedValue & "'"
            type = ExecuteScalar(sql, True)



            If type = "Boys" Then
                sql = "select enrollment.studentid,studentname ,studentsurname,[date joined] ,enrollment.year,enrollment.semester from enrollment inner join studentpersonaldetails on enrollment.studentid = studentpersonaldetails.studentid " & _
                " where enrollment.year = '" & ComboBox5.Text & "' and enrollment.[date joined] = '" & ComboBox3.Text & "' and enrollment.semester = '" & ComboBox4.Text & "' AND enrollment.gender = 'M'"
                drr = ExecuteReader(sql, True)
            ElseIf type = "Girls" Then
                sql = "select enrollment.studentid,studentname ,studentsurname,[date joined] ,enrollment.year,enrollment.semester from enrollment inner join studentpersonaldetails on enrollment.studentid = studentpersonaldetails.studentid " & _
             " where enrollment.year = '" & ComboBox5.Text & "' and enrollment.[date joined] = '" & ComboBox3.Text & "' and enrollment.semester = '" & ComboBox4.Text & "' and enrollment.gender = 'F'"
                drr = ExecuteReader(sql, True)
            Else
                sql = "select enrollment.studentid,studentname ,studentsurname,[date joined] ,enrollment.year,enrollment.semester from enrollment inner join studentpersonaldetails on enrollment.studentid = studentpersonaldetails.studentid " & _
             " where enrollment.year = '" & ComboBox5.Text & "' and enrollment.[date joined] = '" & ComboBox3.Text & "' and enrollment.semester = '" & ComboBox4.Text & "'"
                drr = ExecuteReader(sql, True)
            End If

            While drr.Read
                sql2 = "select student from studenthostels where student = '" & drr(0) & "' and status = 1"

                student = ExecuteScalar(sql2, True)

                If IsNothing(student) Then
                    chkStudents.Items.Add(drr(0) & "-" & drr(1) & "-" & drr(2) & "-" & drr(3) & "-" & drr(4) & "-" & drr(5))
                End If


            End While
        End If
    End Sub

    Private Sub tvRooms_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvRooms.AfterSelect
        'tvRooms.SelectedNode.Nodes.Clear()
        


    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim sql As String

        Dim data() As String
        Dim pos As Integer
        Dim student, year, form As String
        Dim node, subnode As TreeNode
        If chkCheckState.Checked Then

            For Each node In tvRooms.Nodes
                Dim trans As SqlTransaction
                sql = "delete studenthostels where hostel = '" & ComboBox2.SelectedValue & "' and room = '" & node.Text & "' and status = 1 "
                ExecuteNonQuery(sql, , True, , trans, True, True)
                If era Then
                    MsgBox(eramsg)
                    trans.Rollback()

                    Exit Sub
                End If
                For Each subnode In node.Nodes


                    data = Split(subnode.Text, "-")
                    If subnode.Text = node.FirstNode.Text Then



                        If subnode.Text = node.LastNode.Text Then
                            sql = " insert into studenthostels (student,hostel,room,year,form,term,datecheckedin,checkedinby,checkinpostdate ) " & _
                    " values('" & data(0) & "','" & ComboBox2.SelectedValue & "','" & node.Text & "','" & data(3) & "','" & data(4) & "','" & data(5) & "','" & changedate(mskCheckDate.Text) & "','" & goUser.FullName & "','" & changedate(Now().Date) & "' ) "
                            ExecuteNonQuery(sql, , True, , trans, True)
                            If era = False Then
                                trans.Commit()
                                MsgBox("Room " & node.Text & " save  succesful")
                            Else
                                trans.Rollback()
                                MsgBox(eramsg)
                            End If
                        Else
                            sql = " insert into studenthostels (student,hostel,room,year,form,term,datecheckedin,checkedinby,checkinpostdate ) " & _
                     " values('" & data(0) & "','" & ComboBox2.SelectedValue & "','" & node.Text & "','" & data(3) & "','" & data(4) & "','" & data(5) & "','" & changedate(mskCheckDate.Text) & "','" & goUser.FullName & "','" & changedate(Now().Date) & "' ) "
                            ExecuteNonQuery(sql, , True, , trans, True)
                            If era Then
                                trans.Rollback()
                                MsgBox(eramsg)
                                Exit Sub
                            End If
                        End If

                    ElseIf subnode.Text = node.LastNode.Text Then
                        sql = " insert into studenthostels (student,hostel,room,year,form,term,datecheckedin,checkedinby,checkinpostdate ) " & _
                     " values('" & data(0) & "','" & ComboBox2.SelectedValue & "','" & node.Text & "','" & data(3) & "','" & data(4) & "','" & data(5) & "','" & changedate(mskCheckDate.Text) & "','" & goUser.FullName & "','" & changedate(Now().Date) & "' ) "
                        ExecuteNonQuery(sql, , True, , trans, True)
                        If era = False Then
                            trans.Commit()
                            MsgBox("Room " & node.Text & " save  succesful")
                        Else
                            trans.Rollback()
                            MsgBox(eramsg)
                        End If



                    Else
                        sql = " insert into studenthostels (student,hostel,room,year,form,term,datecheckedin,checkedinby,checkinpostdate ) " & _
                    " values('" & data(0) & "','" & ComboBox2.SelectedValue & "','" & node.Text & "','" & data(3) & "','" & data(4) & "','" & data(5) & "','" & changedate(mskCheckDate.Text) & "','" & goUser.FullName & "','" & changedate(Now().Date) & "' ) "
                        ExecuteNonQuery(sql, , True, , trans, True)
                        If era Then
                            trans.Rollback()
                            MsgBox(eramsg)
                            Exit Sub
                        End If
                    End If



                Next
                Try
                    trans.Commit()
                Catch ex As Exception

                End Try
            Next
        Else


            If chkStudents.Items.Count < 1 Then
                MsgBox("No Students to check out")
                Exit Sub
            End If

            For item = 0 To chkStudents.Items.Count - 1
                
                data = Split(Trim(chkStudents.Items(item).ToString), "-")
                sql = "update studenthostels set status = 0 ,checkedoutby = '" & goUser.FullName & "',datecheckedout = '" & changedate(mskCheckDate.Text) & "',checkoutpostdate = '" & changedate(Now.Date) & "' where student = '" & data(0) & "' and status = 1 "

                ExecuteNonQuery(sql, , True)
                If era Then
                    MsgBox(eramsg)
                Else
                    If item = chkStudents.Items.Count - 1 Then
                        MsgBox("CheckOut successfull")
                    End If
                End If



            Next
        End If

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub tvRooms_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvRooms.DoubleClick
        Dim node, subnode As TreeNode
        Dim data() As String
        If chkCheckState.Checked Then
            For Each node In tvRooms.Nodes
                For Each subnode In node.Nodes
                    If tvRooms.SelectedNode.Text = subnode.Text Then
                        data = Split(subnode.Text, "-")
                        If data(3).ToString = ComboBox3.Text And data(4).ToString = ComboBox5.Text And data(5).ToString = ComboBox4.Text Then
                            chkStudents.Items.Add(subnode.Text)

                        End If
                        subnode.Remove()
                        Exit Sub
                    End If
                Next
            Next
        Else
            For Each node In tvRooms.Nodes
                For Each subnode In node.Nodes
                    If tvRooms.SelectedNode.Text = subnode.Text Then
                        ' data = Split(subnode.Text, "-")
                        'If data(3).ToString = ComboBox3.Text And data(4).ToString = ComboBox5.Text And data(5).ToString = ComboBox4.Text Then
                        chkStudents.Items.Add(subnode.Text)

                        'End If
                        subnode.Remove()
                        Exit Sub
                    End If
                Next
            Next
        End If

    End Sub

 

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkStudents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStudents.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckState.CheckedChanged
        If chkCheckState.Checked Then
            chkCheckState.Text = "CheckIn"
            ComboBox3.Enabled = True
            ComboBox4.Enabled = True
            ComboBox5.Enabled = True
        Else
            chkCheckState.Text = "CheckOut"
            ComboBox3.Enabled = False
            ComboBox4.Enabled = False
            ComboBox5.Enabled = False
        End If
    End Sub

    
    Private Sub tvRooms_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tvRooms.KeyDown
        If e.KeyCode = Keys.Enter Then


            Dim sql As String
            Dim beds, initbed As Integer
            Try
                initbed = tvRooms.SelectedNode.Nodes.Count
            Catch ex As Exception
                MsgBox("No Room was selected")
                Exit Sub
            End Try

            'If chkStudents.CheckedItems.Count = 0 And chkStudents.Items.Count > 0 Then
            '    MsgBox("No student selected")
            '    Exit Sub
            'End If
            For Each node In chkStudents.CheckedItems


                sql = "select NoOfBeds from hostelrooms where hostel = '" & ComboBox2.SelectedValue & "' and room = '" & tvRooms.SelectedNode.Text & "'"
                Try
                    beds = ExecuteScalar(sql, , True)
                Catch ex As Exception
                    beds = 0
                End Try

                If beds < initbed + chkStudents.CheckedItems.Count Then
                    MsgBox("No of students will not fit in room ,the room only has a capacity of " & beds & " beds ")
                    Exit Sub
                Else
                    tvRooms.SelectedNode.Nodes.Add(node.ToString)
                End If


                ' chkStudents.Items.Remove(node)
            Next
            With chkStudents
                If .CheckedItems.Count > 0 Then
                    For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                        .Items.Remove(.CheckedItems(checked))
                    Next
                End If
            End With
        End If
    End Sub

    Private Sub txtRefID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefID.TextChanged
        Dim sql As String
        Dim drr As SqlDataReader
        lvStudCheckList.Items.Clear()

        sql = "select item,qtyin,uom,commentin from studentchecklist_details where id = '" & txtRefID.Text & "'"

        drr = ExecuteReader(sql, , True)
        While drr.Read
            Dim items As ListViewItem
            Dim subitems As ListViewItem.ListViewSubItem

            Dim item, uom, comment As String
            Dim qty As Decimal

            item = drr(0)
            qty = drr(1)
            comment = drr(3)
            uom = drr(2)

            items = lvStudCheckList.Items.Add("")
            items.Text = item

            subitems = items.SubItems.Add("")
            subitems.Text = qty

            subitems = items.SubItems.Add("")
            subitems.Text = uom

            subitems = items.SubItems.Add("")
            subitems.Text = comment

        End While


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtSearchCheckList.Clear()
        lvStudCheckList.Items.Clear()
        lbSearchCheckList.Visible = False
        txtRefID.Clear()
        txtStud.Clear()
        cboClass.Text = ""
        cboTerm.Text = ""
        cboLevel.Text = ""
        cboRef.Text = ""
        mskDate.Clear()
        lstResult.Visible = False

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txtRefID.Text <> "" Then
            Dim sql As String

            sql = "update studentchecklist_header set status = 0,cancelledby = '" & goUser.FullName & "' ,datecancelled = '" & changedate(Now.Date) & "' where id = '" & txtRefID.Text & "'"
            ExecuteNonQuery(sql, , True)
            If era Then
                MsgBox(eramsg)
            Else
                MsgBox("Delete successfull")
            End If
        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class