Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Miscelleneous
Imports System.Windows.Forms
Imports StudentDetails

Public Class frmLibrary
    Public frmMain As Form
    Private strReturnType As String = "Return"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub loaddefaults()
        DateIssuedMaskedTextBox.Text = Now.Date
        mskReturnDate.Text = Now.Date
        cboReturnType.Text = "Return"
    End Sub
    Private Sub LoadPrograms()
        With ProgramComboBox
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadDepartments()
        With SubjectComboBox
            .DataSource = Departments
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub loadLoanTypes()
        With cboLoanType
            .DataSource = BookLoanTypes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadCombos()
        LoadPrograms()
        LoadDepartments()
        loadLoanTypes()
    End Sub

    Private Sub frmLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSchoolLibrary.BookIssueForm' table. You can move, or remove it, as needed.
        '     Me.BookIssueFormTableAdapter.FillbyIssue(Me.DsSchoolLibrary.BookIssueForm)
        'TODO: This line of code loads data into the 'DsSchoolLibrary.BookLoanType' table. You can move, or remove it, as needed.
        Me.BookLoanTypeTableAdapter1.Fill(Me.DsSchoolLibrary.BookLoanType)
        'TODO: This line of code loads data into the 'DsSchoolLibrary.BookMaster' table. You can move, or remove it, as needed.
        Me.BookMasterTableAdapter1.Fill(Me.DsSchoolLibrary.BookMaster)
        'TODO: This line of code loads data into the 'DsSchoolLibrary.BookTitles' table. You can move, or remove it, as needed.
        '  Me.BookTitlesTableAdapter1.Fill(Me.DsSchoolLibrary.BookTitles)
        'TODO: This line of code loads data into the 'DsStudentSearches.PaymentPeriods' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsLibrary.Deps' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsLibrary.BookSearch' table. You can move, or remove it, as needed.
        '  Me.BookSearchTableAdapter.Fill(Me.DsLibrary.BookSearch)
        'TODO: This line of code loads data into the 'DsLibrary.BookSearch' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsLibrary.BookTitles' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsLibrary.BookMaster' table. You can move, or remove it, as needed.
        loadsets()
        'TODO: This line of code loads data into the 'DsLibrary.Books' table. You can move, or remove it, as needed.
        '    Me.BooksTableAdapter.Fill(Me.DsLibrary.Books)
        'TODO: This line of code loads data into the 'DsLibrary.LibMemReg' table. You can move, or remove it, as needed.
        '   Me.LibMemRegTableAdapter.Fill(Me.DsLibrary.LibMemReg)
        'TODO: This line of code loads data into the 'DsLibrary.LibMemReg' table. You can move, or remove it, as needed.
        Prepareform(Me, frmMain, False)
        MdiParent = frmMain
        ' Me.LibMemRegTableAdapter.Fill(Me.DsLibrary.LibMemReg)
        '  addLibMem = False
        '  Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()

        LoadCombos()
        loaddefaults()
        '   Me.ReportViewer2.RefreshReport()
    End Sub


    Private Sub loadsets()
        '      Me.BookMasterTableAdapter.Fill(Me.DsLibrary.BookMaster)
        'TODO: This line of code loads data into the 'DsLibrary.BookIssues' table. You can move, or remove it, as needed.
        '     Me.BookIssuesTableAdapter.Fill(Me.DsLibrary.BookIssues)
        '    Me.BookTitlesTableAdapter.Fill(Me.DsLibrary.BookTitles)
        '       Me.BookSearchTableAdapter.Fill(Me.DsLibrary.BookSearch)
        '     Me.DepsTableAdapter.Fill(Me.DsLibrary.Deps)
        'TODO: This line of code loads data into the 'dsLibraryReports.CurrentIssues' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsLibrary.BookLoanType' table. You can move, or remove it, as needed.
        '      Me.BookLoanTypeTableAdapter.Fill(Me.DsLibrary.BookLoanType)
        'TODO: This line of code loads data into the 'DsStudentSearches.Subjects' table. You can move, or remove it, as needed.
        '    Me.SubjectsTableAdapter.Fill(Me.DsStudentSearches.Subjects)
        'TODO: This line of code loads data into the 'DsStudentSearches.forms' table. You can move, or remove it, as needed.
'        Me.FormsTableAdapter.Fill(Me.DsStudentSearches.forms)
        'TODO: This line of code loads data into the 'DsLibrary.bookissiue_lines' table. You can move, or remove it, as needed.
        ' Me.Bookissiue_linesTableAdapter.Fill(Me.DsLibrary.bookissiue_lines)
    End Sub




    Public Sub search(ByVal feed As String, ByVal txtbox As TextBox)
        Try
            Dim a, b As Integer
            Dim searchstring As String
            b = InStr(Trim(feed), " ")
            searchstring = Mid(Trim(feed), 1, b - 1)
            txtbox.Text = searchstring

            'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
            'If a < 0 Then
            '    MsgBox("Student ID could not be found")
            'Else
            '    StudentPersonalDetailsBindingSource.Position = a
            'End If
        Catch ex As Exception

        End Try

    End Sub




    Private Sub MemidTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub lbLibStudSearch_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim fidtext As String
    '    Try
    '        fidtext = lbLibStudSearch.SelectedItem.ToString
    '        lbLibStudSearch.Items.Clear()
    '        search(fidtext, MemidTextBox)
    '        lbLibStudSearch.Visible = False
    '    Catch ex As Exception

    '    End Try
    'End Sub


    'Private Sub LibMemRegBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If addLibMem Then
    '        Try
    '            Me.Validate()
    '            Me.LibMemRegBindingSource.EndEdit()
    '            Me.TableAdapterManager.UpdateAll(Me.DsLibrary)
    '            MsgBox("MemberSuccefulllly Added")
    '            addLibMem = False

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '            addLibMem = True
    '        End Try

    '    Else
    '        Me.Validate()
    '        Me.LibMemRegBindingSource.EndEdit()
    '        Me.TableAdapterManager.UpdateAll(Me.DsLibrary)
    '        MsgBox("MemberSuccefulllly Saved")
    '        addLibMem = False

    '    End If






    'End Sub

    'Private Sub MemidTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If addLibMem = True Then
    '        Dim serchtext As String = Trim(MemidTextBox.Text)
    '        lbLibStudSearch.Items.Clear()
    '        Dim drr As SqlDataReader

    '        lbLibStudSearch.Visible = True
    '        Dim sql As String = " select studentid,studentname,studentsurname from studentpersonaldetails where studentid + ' ' + studentname + ' ' + studentsurname like '%" & serchtext & "%'"
    '        drr = ExecuteReader(sql)
    '        While drr.Read
    '            lbLibStudSearch.Items.Add(drr(0) & " " & drr(1) & " " & drr(2))
    '        End While
    '    End If
    'End Sub

    Private Sub BindingNavigatorAddNewItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        addLibMem = True
    End Sub


    Private Sub lbLibStudSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub





    Private Sub BookSerialTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim sql, sql1 As String
        'Dim a As Integer
        'Dim drr As SqlDataReader
        'Dim status As String
        'a = BookMasterBindingSource.Find("Serial", Trim(BookSerialTextBox.Text))
        'If a >= 0 Then
        '    sql = "select bookstate from bookmaster where serial = '" & Trim(BookSerialTextBox.Text) & "'"
        '    status = ExecuteScalar(sql)
        '    If status.ToUpper = "ISSUED" Then

        '        'sql1 = " select serial max(duedate ) as due from bookissues where bookserial = '" & BookSerialTextBox.Text & _
        '        '"' "
        '        'drr = ExecuteReader(sql1)
        '        'Try
        '        '    While drr.Read
        '        Dim res As String = MsgBox("Book already issued is it a group issue?", MsgBoxStyle.YesNo)
        '        If res = "6" Then
        '            MsgBox("Proceed with issue")
        '            nav_BookIssue.Items("bi_save").Enabled = True
        '        Else
        '            MsgBox("Please select another book")
        '            nav_BookIssue.Items("bi_save").Enabled = False
        '        End If


        '        '    End While
        '        'Catch ex As Exception

        '        'End Try

        '    ElseIf status.ToUpper = "DAMAGED" Or status.ToUpper = "LOST" Then
        '        MsgBox("Book has been damaged or lost")
        '        nav_BookIssue.Items("bi_save").Enabled = False
        '    ElseIf status.ToUpper = "AVAILABLE" Then
        '        nav_BookIssue.Items("bi_save").Enabled = True


        '    End If
        'End If
    End Sub






    'Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
    '    loadsets()
    '    nav_BookIssue.Items("bi_save").Enabled = True
    '    gblnaddbook = False
    '    gblnaddbookissue = False
    '    lbBorrower.Visible = False
    '    ' LbIssueBookSearch.Visible = False
    'End Sub



    Private Sub BorrowerTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles BorrowerTextBox.Validating
        'Dim sql1 As String
        'Dim tyms As Integer
        'sql1 = "select count(borrower) from bookissue where borrower = '" & BorrowerTextBox.Text & "' and Issuestatus <> 'Returned'"
        'tyms = ExecuteScalar(sql1)

        'If tyms >= 2 Then
        '    MsgBox("Borrower cannot be issued")

        'End If
    End Sub



    Private Sub lbBorrower_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbBorrower.DoubleClick
        Dim searchstring, sql As String
        Try
            searchstring = lbBorrower.SelectedItem.ToString
            lbBorrower.Items.Clear()
            lvBooks.Items.Clear()




        Catch ex As Exception

        End Try

        Dim arraysplit() As String
        arraysplit = Split(searchstring, "-")
        ' acaformComboBox.Text = arraysplit(3).ToString
        BorrowerTextBox.Text = arraysplit(0).ToString
        sql = "select studname  from vwlibraryuser where studentid = '" & Trim(BorrowerTextBox.Text) & "'"
        LabelBorrower.Text = ExecuteScalar(sql, , True)
        '   BorrowerTextBox.Enabled = False

        lbBorrower.Visible = False

        Try
            Me.BookIssueFormTableAdapter.FillbyIssue(Me.DsSchoolLibrary.BookIssueForm, goUser.FullName, "", Trim(BorrowerTextBox.Text), False, Guid.NewGuid)
            ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbBorrower_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbBorrower.SelectedIndexChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gblnaddbookissue = True
        lbBorrower.Visible = False
        'LbIssueBookSearch.Visible = False
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cnn = New SqlConnection(ConnectionString)

        Try
            cnn.Open()
            sqltext = "spDeleteBook"

            If txtBookMasterRef.Text <> "" Then
                If MsgBox("Delete Book?", vbYesNo) = vbYes Then
                    cmd = New SqlCommand(sqltext, cnn)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@serial", Trim(SerialTextBox.Text))
                        .ExecuteNonQuery()

                    End With
                    MsgBox("Book Deleted")
                    BookMasterTableAdapter1.Fill(DsSchoolLibrary.BookMaster)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try









    End Sub


    Private Sub BindingNavigatorAddNewItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gblnaddbook = True

        BindingNavigator1.Items("Add").Visible = False
    End Sub

    Private Sub txtReturnStud_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReturnStud.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbReturnsStud.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            btnReturnSearch_Click(Me, Nothing)
        End If
    End Sub

    Private Sub txtReturnStud_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReturnStud.LostFocus
        'chkIssues.Items.Clear()
        'Dim sql As String
        'Dim drr As SqlDataReader
        'sql = "select bookissues.serial,title,issueno from bookissues inner join  " & _
        '"bookmaster on bookmaster.serial = bookissues.serial where borrower = '" & Trim(txtReturnStud.Text) & "'"
        'drr = ExecuteReader(sql)

        'Try
        '    While drr.Read
        '        chkIssues.Items.Add(drr(0) + "-" + drr(1) + "-" + drr(2).ToString)
        '    End While
        'Catch ex As Exception
        '    '  MsgBox(ex.Message)
        'End Try


    End Sub




    Private Sub txtReturnStud_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReturnStud.TextChanged



    End Sub

    Private Sub lbReturnsStud_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbReturnsStud.DoubleClick
        Dim searchstring As String = ""
        Try
            searchstring = lbReturnsStud.SelectedValue
            lbReturnsStud.DataSource = Nothing

        Catch ex As Exception

        End Try


        Dim filter As String = ""

        Dim blnByBook, blnByBorrower, blnByIssue As Boolean
        blnByBook = False : blnByBorrower = False : blnByIssue = False

        ' acaformComboBox.Text = arraysplit(3).ToString
        txtReturnStud.Text = searchstring
        lbReturnsStud.Visible = False


        chkIssues.DataSource = Nothing

        If rbretbybook.Checked Then
            blnByBook = True


        ElseIf rbretbyborrower.Checked Then
            blnByBorrower = True
        ElseIf rbretByIssue.Checked Then
            blnByIssue = True
        End If


        Dim cnn As New SqlConnection(ConnectionString)
        Try

            '       lbReturnsStud.DataSource = Nothing
            Dim dsApps As New DataSet()
            Dim taApps As SqlDataAdapter = Nothing
            Dim cmd As New SqlCommand



            cnn.Open()



            cmd.CommandText = "spBookReturnsDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@txt", searchstring)
            cmd.Parameters.AddWithValue("@returntype", strReturnType)
            cmd.Parameters.AddWithValue("@bybook", blnByBook)
            cmd.Parameters.AddWithValue("@byBorrower", blnByBorrower)
            cmd.Parameters.AddWithValue("@byissue", blnByIssue)


            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            chkIssues.DataSource = dsApps.Tables(0)

            If blnByBook Then
                chkIssues.DisplayMember = "Title"
                chkIssues.ValueMember = "Title"
            ElseIf blnByBorrower Then
                chkIssues.DisplayMember = "Borrower"
                chkIssues.ValueMember = "Borrower"
            ElseIf blnByIssue Then
                chkIssues.DisplayMember = "issuecode"
                chkIssues.ValueMember = "issuecode"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try






    End Sub

    Private Sub lbReturnsStud_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbReturnsStud.LostFocus

    End Sub


    Private Sub lbReturnsStud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbReturnsStud.SelectedIndexChanged

    End Sub

    Private Sub btnReturnsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnsSave.Click
        Dim serial, issueno As String
        Dim arraysplit() As String
        Dim code128 As New BarcodeLib.Barcode.Linear

        serial = ""
        issueno = ""

        Dim returndate As Date
        cnn = New SqlConnection(ConnectionString)

        Dim returnref As String = ""
        Dim returnbarcode As Byte() = Nothing

        If strReturnType = "Return" Then
            If Not Date.TryParse(mskReturnDate.Text, returndate) Then
                MsgBox("Invalid Return date ")
                Exit Sub
            End If

            If cboBookState.Text = "" Then
                MsgBox("Invalid Book State")
                Exit Sub
            End If
        Else
            returndate = Now.Date

        End If




        Dim itms As Integer = chkIssues.CheckedItems.Count

        If itms = 0 Then
            MsgBox("Select Book(s) to be returned")
            Exit Sub
        End If

        '     If strReturnType = "Return" Then

        returnref = Guid.NewGuid.ToString
        returnref = returnref.Replace("-", "")

        code128.Type = BarcodeLib.Barcode.BarcodeType.CODE128
            code128.UOM = BarcodeLib.Barcode.UnitOfMeasure.PIXEL
            code128.Data = returnref
            code128.AddCheckSum = True
            code128.BarWidth = 2
            code128.BarHeight = 78
            code128.LeftMargin = 11
            code128.RightMargin = 11
            returnbarcode = code128.drawBarcodeAsBytes()
        '      End If

        For Each item In chkIssues.CheckedItems
            Try


                cnn.Open()
                arraysplit = Split(item.row(0).ToString, "-")
                If rbretbybook.Checked Then
                    serial = Trim(txtReturnStud.Text)
                    issueno = arraysplit(2).ToString
                ElseIf rbretbyborrower.Checked Then
                    serial = arraysplit(0).ToString
                    issueno = arraysplit(2).ToString
                ElseIf rbretByIssue.Checked Then
                    serial = arraysplit(0).ToString
                    issueno = Trim(txtReturnStud.Text)

                End If





                sqltext = "spReturnBook"
                cmd = New SqlCommand(sqltext, cnn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@book", serial)
                    .Parameters.AddWithValue("@issuecode", issueno)
                    .Parameters.AddWithValue("@returndate", returndate)
                    .Parameters.AddWithValue("@bookstate", cboBookState.Text)
                    .Parameters.AddWithValue("@returnref", returnref)
                    .Parameters.AddWithValue("@returntype", strReturnType)
                    .Parameters.AddWithValue("@user", goUser.FullName)
                    .Parameters.AddWithValue("@returnbacode", returnbarcode)
                    .ExecuteNonQuery()
                    MsgBox("Book " & serial & " successfully returned")

                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        Next

        If strReturnType = "Return" Then


            Dim rptvwer As New frmReportPreview
            With rptvwer
                .issueform = True
                .blnbookreturn = True
                .returnref = returnref
                gstrissueno = ""
                .Show()
            End With
        End If

    End Sub
    Private Function calculateFines(ByVal issue As String, ByVal returndate As Date, ByVal duedate As Date, ByVal serial As String, ByVal trans As SqlTransaction) As Boolean
        Dim lag As Integer
        Dim sql As String
        lag = DateDiff(DateInterval.Day, duedate, returndate)
        If lag > 0 Then
            sql = "update bookreturns set lag = '" & lag & "', cleared = 0 where issueno = '" & issue & "' and bookserial = '" & serial & "'"
        ElseIf lag <= 0 Then
            sql = "update bookreturns set lag = '" & lag & "' , cleared = 1 where issueno = '" & issue & "' and bookserial = '" & serial & "'"
        End If

        ExecuteNonQuery(sql, True, , , trans, True)
        If era = False Then

            Return True
        Else
            Return False
        End If
        ' Return 0

    End Function






    Private Sub TitleComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            lbIndTitleSearch.Visible = False
        End If
    End Sub

    Private Sub TitleComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub



    Private Sub TitleComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim sql As String
        Dim drr As SqlDataReader
        sql = "SELECt COUNT(Serial) AS books, Title FROM BookMaster WHERE BookState = 'Available' and title = '" & txtBookMasterTitle.Text & "'  GROUP BY Title "
        drr = ExecuteReader(sql)
        If drr.HasRows Then
            While drr.Read
                lbBookAvailability.Text = drr(0) & "  BOOK(S) AVAILABLE"
            End While

        Else
            lbBookAvailability.Text = "NO BOOKS AVAILABLE"
        End If
        If gblnaddbook Then
            sql = " select title from booktitles where title like '%" & Trim(txtBookMasterTitle.Text) & "%'"
            drr = ExecuteReader(sql, True)

            lbIndTitleSearch.Visible = True
            lbIndTitleSearch.Items.Clear()
            While drr.Read
                lbIndTitleSearch.Items.Add(drr(0))
            End While
        End If
    End Sub



    'Private Sub IssueNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ' If Not gblnaddbookissue Then
    '    Try
    '        Bookissiue_linesTableAdapter.FillByissue(DsLibrary.bookissiue_lines, IssueNoTextBox.Text)
    '    Catch ex As Exception

    '    End Try
    '    '  Else


    '    ' End If
    'End Sub

    Private Sub TabControl1_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.TabIndexChanged
        If TabControl1.SelectedTab.Text = "Issues" Then
            cboIssueSearch.Text = "Issue"
        End If
    End Sub

    Private Sub cboIssueSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIssueSearch.SelectedIndexChanged
        txtissueSearch.Clear()
        If cboIssueSearch.Text = "Date" Then
            txtissueSearch.Visible = False

            lbSearchIssue.Visible = False


        Else

            If cboIssueSearch.Text = "Student" Then

                txtissueSearch.Visible = True


            Else

                txtissueSearch.Visible = True
            End If




        End If



        If cboIssueSearch.Text = "Issue" Then

            Try
                Dim a, b As Integer
                Dim searchstring As String
                b = InStr(Trim(lbSearchIssue.SelectedItem), "-")
                Try
                    searchstring = Mid(Trim(lbSearchIssue.SelectedItem), 1, b - 1)
                Catch ex As Exception
                    searchstring = ""
                End Try

                txtissueSearch.Text = searchstring
                ' Me.FeesPaymentsTableAdapter.FillByReceipt(schoolDataSet.FeesPayments, searchstring)
                ' lbSeacrhFees.Visible = False



                'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
                'If a < 0 Then
                '    MsgBox("Student ID could not be found")
                'Else
                '    StudentPersonalDetailsBindingSource.Position = a
                'End If
            Catch ex As Exception

            End Try
        ElseIf cboIssueSearch.Text = "Student" Then
            Try
                Dim a, b As Integer
                Dim searchstring As String
                b = InStr(Trim(lbSearchIssue.SelectedItem), "-")
                Try
                    searchstring = Mid(Trim(lbSearchIssue.SelectedItem), 1, b - 1)
                Catch ex As Exception
                    searchstring = ""
                End Try

                txtissueSearch.Text = searchstring
                'Me.BookIssuesTableAdapter.FillByStudent(DsLibrary.BookIssues, searchstring)
                lbSearchIssue.Visible = False



                'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
                'If a < 0 Then
                '    ' MsgBox("Student ID could not be found")
                'Else
                '    StudentPersonalDetailsBindingSource.Position = a
                'End If
            Catch ex As Exception

            End Try


        End If

    End Sub




    Private Sub lbSearchIssue_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbSearchIssue.DoubleClick
        If cboIssueSearch.Text = "Issue" Then
            lvBooks.Items.Clear()

            Try
                Dim a, b As Integer
                Dim searchstring As String = ""
                searchstring = lbSearchIssue.SelectedValue
                txtissueSearch.Text = searchstring
                Dim sql As String
                Dim drr As SqlDataReader
                sql = "select borrower,dateissued,title,book,duedate from bookissiue_lines inner join bookissues " &
                " on bookissues.issuecode = bookissiue_lines.issuecode " &
                " inner join BookMaster on  serial = book " &
              "  where bookissues.issuecode = '" & searchstring & "' AND issuestate = 1 and Active = 1 "

                drr = ExecuteReader(sql, True)



                While drr.Read
                    Dim items As ListViewItem
                    Dim subitems As ListViewItem.ListViewSubItem
                    BorrowerTextBox.Text = drr(0)
                    DateIssuedMaskedTextBox.Text = drr(1)
                    items = lvBooks.Items.Add("")
                    items.Text = drr(3).ToString


                    subitems = items.SubItems.Add("")
                    subitems.Text = drr(2).ToString

                    subitems = items.SubItems.Add("")
                    subitems.Text = drr(4).ToString





                End While



                lbSearchIssue.Visible = False


                'sql = "select "
                'Me.BookIssuesTableAdapter.FillByIssueno(DsLibrary.BookIssues, searchstring)
                'lbSearchIssue.Visible = False

                'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
                'If a < 0 Then
                '    MsgBox("Student ID could not be found")
                'Else
                '    StudentPersonalDetailsBindingSource.Position = a
                'End If
            Catch ex As Exception

            End Try
        ElseIf cboIssueSearch.Text = "Student" Then

            Dim sql As String
            Dim drr As SqlDataReader
            Try
                Dim a, b As Integer
                Dim searchstring As String
                b = InStr(Trim(lbSearchIssue.SelectedItem), "-")
                searchstring = Mid(Trim(lbSearchIssue.SelectedItem), 1, b - 1)
                txtissueSearch.Text = searchstring
                'Me.BookIssuesTableAdapter.FillByStudent(DsLibrary.BookIssues, searchstring)
                lbSearchIssue.Visible = False

                ' sql = " select [year joined  joined],[year],semester,session from studentpersonaldetails where studentid = '" & searchstring & "'"
                ' drr = ExecuteReader(sql, , True)
                'Try
                '    While drr.Read
                '        cboFeesYrSearch.Text = drr(0).ToString
                '        cbofeesformsearch.Text = drr(1).ToString
                '        cbofeesTermSearch.Text = drr(2).ToString
                '        cbofeessessSearch.Text = drr(3).ToString
                '    End While
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                'End Try


                'Try
                '    StudentPersonalDetailsTableAdapter.FillByClass(dsSchool.StudentPersonalDetails, cboFeesYrSearch.Text, cbofeesformsearch.Text, cbofeesTermSearch.Text, cbofeessessSearch.Text)
                '    lbpos.Text = BindingNavigator1.PositionItem.Text & " of " & StudentPersonalDetailsBindingSource.Count
                '    cboReceiptSearch.Text = "Student"
                '    ' txtReceiptSearch.Text = StudentIDTextBox.Text
                '    lbSeacrhFees.Visible = False
                'Catch ex As Exception

                'End Try

                'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
                'If a < 0 Then
                '    '  MsgBox("Student ID could not be found")
                'Else
                '    StudentPersonalDetailsBindingSource.Position = a
                'End If
            Catch ex As Exception

            End Try


        End If
    End Sub







    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gstraddtitle = True
        BindingNavigator2.Items("Del").Visible = False

    End Sub



    Private Sub lbBook_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbBook.DoubleClick
        Dim searchstring As String
        searchstring = lbBook.GetItemText(lbBook.SelectedItem)

        txtBook.Text = searchstring
        lbBook.Visible = False

    End Sub






    Private Sub btnAddBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBook.Click


        Dim books() As String
        Dim duedate As Date
        Dim items As ListViewItem
        Dim subitems As ListViewItem.ListViewSubItem
        Dim ref, title, loan, sql As String
        Dim duration As Double
        Dim dateissued As Date
        Dim drr As SqlDataReader
        If rbSingleIssue.Checked Then
            If Trim(txtBook.Text) <> "" Then


                books = txtBook.Text.Split("-")
                ref = books(0).ToString
                title = books(1).ToString


                If searchBook(ref) Then

                    items = lvBooks.Items.Add("")
                    items.Text = ref

                    subitems = items.SubItems.Add("")
                    subitems.Text = books(1).ToString

                    loan = books(2)
                    sql = " select duration from bookloantype where loan = '" & loan & "'"

                    duration = ExecuteScalar(sql, , True)
                    dateissued = DateIssuedMaskedTextBox.Text

                    duedate = DateAdd(DateInterval.Day, duration, dateissued)
                    subitems = items.SubItems.Add("")
                    subitems.Text = duedate.ToString
                    txtBook.Text = ""
                    lbBook.Visible = False

                    lbissued.Text = lvBooks.Items.Count & " books to be issued"
                Else
                    MsgBox("Book pending Issue")
                End If

            Else
                MsgBox("Select a book to add")

            End If
        ElseIf rbPerTitle.Checked Then



            If Trim(txtBook.Text) <> "" Then

                Dim cmd As SqlCommand
                books = txtBook.Text.Split("-")
                '   ref = books(0).ToString
                title = books(0).ToString
                cnn = New SqlConnection(ConnectionString)
                Try
                    cnn.Open()

                    sql = " select serial ,title,loan from bookmaster where  title = @title and bookstate = 'Available' order by serial asc "

                    cmd = New SqlCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@title", title)
                    drr = cmd.ExecuteReader
                    While drr.Read
                        ref = drr(0).ToString
                        If searchBook(ref) Then

                            items = lvBooks.Items.Add("")
                            items.Text = ref

                            subitems = items.SubItems.Add("")
                            subitems.Text = drr(1).ToString

                            loan = books(2)
                            sql = " select duration from bookloantype where loan = '" & loan & "'"

                            duration = ExecuteScalar(sql, , True)
                            dateissued = DateIssuedMaskedTextBox.Text

                            duedate = DateAdd(DateInterval.Day, duration, dateissued)
                            subitems = items.SubItems.Add("")
                            subitems.Text = duedate.ToString
                            txtBook.Text = ""
                            lbBook.Visible = False
                            lbissued.Text = lvBooks.Items.Count & " books to be issued"
                        Else
                            MsgBox("Only one issue allowed at a time ")
                        End If
                    End While

                Catch ex As Exception
                Finally
                    cnn.Close()
                End Try

            Else
                MsgBox("Select a book Title to add")

            End If
        End If
    End Sub
    Private Function searchBook(ByVal ref As String) As Boolean

        'If lvBooks.Items.Count >= 1 Then
        '    Return False
        '    Exit Function
        'End If

        For i = 0 To lvBooks.Items.Count - 1
            If Trim(lvBooks.Items(i).Text.ToUpper) = ref.ToUpper Then
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql, sql2 As String
        Dim issueno As Integer
        Dim TRANS As SqlTransaction = Nothing
        Dim lines As Integer
        lines = lvBooks.Items.Count
        Dim code128 As New BarcodeLib.Barcode.Linear
        Dim code As String
        Dim dateissued As Date
        If lvBooks.Items.Count = 0 Then
            MsgBox("Please select a book to issue ")
            Exit Sub
        End If
        If Trim(txtissueSearch.Text) = "" Then

            sql = "Select max (cast(isnull(issueno,0)  as int )) + 1 from bookissues"

            Try
                issueno = ExecuteScalar(sql, True)
            Catch ex As Exception
                issueno = 1
            End Try


            code128.Type = BarcodeLib.Barcode.BarcodeType.CODE128
                code128.UOM = BarcodeLib.Barcode.UnitOfMeasure.PIXEL
                code = "LIBRARY" & StrDup(6 - Len(issueno.ToString), "0") & issueno.ToString
                code128.Data = code
                code128.AddCheckSum = True
                code128.BarWidth = 2
                code128.BarHeight = 78
                code128.LeftMargin = 11
                code128.RightMargin = 11
                temp1 = code128.drawBarcodeAsBytes()

                If Not Date.TryParse(DateIssuedMaskedTextBox.Text, dateissued) Then
                    MsgBox("Invalid Issue Date")
                    Exit Sub
                End If

            Try


                cnn = New SqlConnection(ConnectionString)
                cnn.Open()
                TRANS = cnn.BeginTransaction


                sql = "spInsertBookIssue_Header"

                cmd = New SqlCommand(sql, cnn, TRANS)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@borrower", Trim(BorrowerTextBox.Text))
                    .Parameters.AddWithValue("@dateissued", dateissued)
                    .Parameters.AddWithValue("@issueno", issueno)
                    .Parameters.AddWithValue("@barcode", temp1)
                    .Parameters.AddWithValue("@issuecode", code)
                    .Parameters.AddWithValue("@issueref", Guid.NewGuid)
                    .Parameters.AddWithValue("@user", goUser.FullName)

                    .ExecuteNonQuery()

                End With

                For a1 = 0 To lines - 1
                    Dim book As String = lvBooks.Items(a1).Text
                    Dim due As String = lvBooks.Items(a1).SubItems(2).Text
                    sql2 = "spInsertBookIssue_Lines"

                    cmd = New SqlCommand(sql2, cnn, TRANS)

                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@book", book)
                        .Parameters.AddWithValue("@issuecode", code)
                        .Parameters.AddWithValue("@dateissued", dateissued)
                        .ExecuteNonQuery()
                    End With

                Next
                TRANS.Commit()
                MsgBox("Msgbox book Issue Successful")
                Try
                    Dim frmReports As New frmReportPreview
                    With frmReports
                        .issueform = True
                        gstrissueno = code
                        .Show()

                    End With
                Catch ex As Exception

                End Try


                Try
                    Me.BookIssueFormTableAdapter.FillbyIssue(Me.DsSchoolLibrary.BookIssueForm, goUser.FullName, "", Trim(BorrowerTextBox.Text), False, Guid.NewGuid)
                    ReportViewer1.RefreshReport()
                Catch ex As Exception

                End Try

            Catch ex As Exception
                MsgBox(ex.Message)
                TRANS.Rollback()
            Finally
                cnn.Close()
            End Try
        Else
            MsgBox("Editing not posssible,Books have to be returned")

        End If


    End Sub
    Private Function checkissue(ByVal borower As String) As Boolean

        Dim sql As String
        Dim books As Integer
        '   sql = " select count(book) from bookissiue_lines inner join bookissues on bookissiue_lines.issueno = bookissues.issueno " & _
        '  " where borrower = '" & borower & "' and issuestate = 1 and active = 1  "
        ' books = ExecuteScalar(sql, True)

        ' If books >= 1 Then
        'Return False
        ' Exit Function
        ' ElseIf books = 0 Then
        sql = " select count(book) from bookissiue_lines inner join bookissues on bookissiue_lines.issueno = bookissues.issueno " &
    " where borrower = '" & borower & "' and  duedate <= '" & changedate(Now.Date) & "' and issuestate = 1 and active = 1"
        books = ExecuteScalar(sql, True)
        If books >= 1 Then
            Return False
            Exit Function
        ElseIf books = 0 Then
            sql = " select COUNT(bookreturns.bookserial) from  dbo.bookreturns inner join " &
"Bookissues on bookissues.issueno = bookreturns .issueno " &
" where Cleared = 0 and lag > 1 and active = 1 and borrower = '" & borower & "'"
            books = ExecuteScalar(sql, True)
            If books >= 1 Then
                Return False
                Exit Function
            Else
                Return True

            End If

        End If
        ' End If


    End Function
    Private Sub printIssue(ByVal issue As String)
        gstrissueno = issue
        lbryissue = True
        '    frmReportPreview.Show()

    End Sub

    Private Sub lbBook_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbBook.SelectedIndexChanged

    End Sub

    Private Sub lvBooks_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvBooks.DoubleClick
        Dim ref, title, due As String
        Dim item As ListViewItem
        item = lvBooks.SelectedItems(0)
        lvBooks.Items.Remove(item)
        lbissued.Text = lvBooks.Items.Count & " books to be issued"

    End Sub

    Private Sub lvBooks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvBooks.SelectedIndexChanged

    End Sub

    Private Sub lbSearchIssue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSearchIssue.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BorrowerTextBox.Text = ""
        BorrowerTextBox.Enabled = True
        txtissueSearch.Clear()
        LabelBorrower.Text = ""
        DateIssuedMaskedTextBox.Clear()
        lvBooks.Items.Clear()
        txtBook.Clear()
        lbBorrower.Visible = False
        lbBook.Visible = False
        lbissued.Text = ""

        loaddefaults()

    End Sub

    Private Sub txtBook_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBook.TextChanged

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        'Me.CurrentIssuesTableAdapter.FillByBorrower(Me.dsLibraryReports.CurrentIssues, "a")
        gblnaddbook = False
        BindingNavigator1.Items("Add").Visible = True
        gstraddtitle = False
        BindingNavigator2.Items("Del").Visible = True
        loadsets()
    End Sub








    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim file_name2 As String = ""
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        ' OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file_name2 = OpenFileDialog1.FileName
        Else
            Exit Sub
        End If

        Dim theLine As String = ""
        Dim arrSplt() As String
        Dim title, author, section As String
        Dim yearpublished As Integer

        Dim oReader As New System.IO.StreamReader(file_name2)
        Dim count As Integer = 0







StartPosition: While oReader.Peek <> -1
            Try
                theLine = oReader.ReadLine()
                arrSplt = theLine.Split("|")
                ' Fullname = Trim(arrSplt(0)).ToUpper
                author = Trim(arrSplt(1)).ToUpper()
                title = Trim(arrSplt(0)).ToUpper
                section = Trim(arrSplt(3)).ToUpper
                Try
                    yearpublished = arrSplt(2)

                Catch ex As Exception
                    yearpublished = 0

                End Try

                Dim sql As String

                sql = "insert into booktitles ([Title] ,[Author] ,[YearPublished],[subject]) " &
"values('" & title & "','" & author & "','" & yearpublished & "','" & section & "')"
                ExecuteNonQuery(sql, , True)
                If era = False Then
                    count = count + 1
                End If

            Catch ex1 As Exception
            End Try




        End While


        MsgBox(count & " numbers  successfully updated")
    End Sub





    Private Sub btnCancelIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelIssue.Click

        Dim sql As String
        cnn = New SqlConnection(ConnectionString)

        If txtissueSearch.Text = "" Then
            MsgBox("Please select issue to cancel")
            Exit Sub
        End If

        Dim res As String = MsgBox("Are you sure you want to cancel this issue?", vbYesNo) 
        If res = "6" Then

            Try


                cnn.Open()
                sql = "spCancelBookIssue"
                cmd = New SqlCommand(sql, cnn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@issuecode", Trim(txtissueSearch.Text))
                    .ExecuteNonQuery()
                    MsgBox("Issue successfully cancelled")

                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()
            End Try
        End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub btnLibraryBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLibraryBilling.Click
        Dim sql As String
        Dim drr As SqlDataReader
        Dim recid, receipt, sql2, recprefix, period As String
        Dim rows As Integer




        sql = "select lag,bookserial,dbo.bookreturns.issueno ,borrower ,fine ,period ,PROGRAM,YEAR,Semester,[Year Joined  joined],datereturned " &
"from bookreturns inner join bookissues on  bookreturns.issueno = bookissues.issuecode " &
" inner join bookmaster on bookserial = serial" &
" inner join bookloantype on bookmaster.loan = bookloantype.loan " &
" inner join studentpersonaldetails on studentid = borrower " &
" where lag > 0 and Cleared = 0 and active = 1 and  datereturned between '" & changedate(mskBillFrom.Text) & "' and  '" & changedate(mskBillTo.Text) & "'"



        period = cboLibraryBilling.SelectedValue

        drr = ExecuteReader(sql, , True)


        While drr.Read

            Dim trans As SqlTransaction
            Dim amnt As Double
            Dim ref As String
            amnt = drr(4) / drr(5) * drr(0)
            recprefix = "inv_"
            recid = GetNextTableID("FeesPayments_header", "invoice", False)
            receipt = Trim(recprefix) & StrDup(8 - Len(recid), "0") & recid
            ref = "LIB-" & drr(1).ToString & "-" & drr(2).ToString
            'Trim(recprefix) & StrDup(8 - Len(recid), "0") & recid
            If checkref(ref) Then

                sql = "select receipt from feespayments_details where reference = '" & ref & ""
                sql = "insert into feespayments_header(StudentID ,Program, Clas,Level,Semester,Date,Receipt,status,usr,type,cashtype,postdate) " &
           "values ('" & drr(3) & "','" & drr(6) & " ','" & drr(9) & "','" & drr(7) &
           "','" & drr(8) & "','" & changedate(drr(10).ToString) & "','" & receipt & "','1','" & goUser.FullName & "','I','','" & changedate(Now.Date) & "')"
                ExecuteNonQuery(sql, True)

                If Not era Then
                    sql2 = " insert into feespayments_details (Receipt,Amount,Currency,Cartegory,Period,Line_number,Reference,biltype )" &
                          " values( '" & receipt & "' ,'" & amnt & "','USD' ,'BILLING','" & period & "','1','" & ref & "','Library' )"
                    ExecuteNonQuery(sql2, True)
                    If era Then
                        sql2 = "delete from feespayments_header where receipt = '" & receipt & "'"
                        ExecuteNonQuery(sql2, , True)
                    Else
                        MsgBox("Billing successful for reference " & receipt)
                    End If
                Else
                    MsgBox(eramsg)
                End If
            End If
        End While


    End Sub

    Private Function checkref(ByVal ref As String) As Boolean

        Dim sql As String
        Dim reference As SqlDataReader
        sql = "select  * from feespayments_details where reference = '" & ref & "' and biltype = 'Library'"
        reference = ExecuteReader(sql, , True)

        If reference.HasRows Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sql As String
        Dim drr As SqlDataReader
        Dim NEWSERIAL As String
        Dim REMM As String
        Dim rows As Integer
        Dim trans As SqlTransaction
        sql = "select serial from bookmaster "

        drr = ExecuteReader(sql)

        rows = drr.FieldCount
        While drr.Read
            ' gcnnPos2.Close()
            Dim len As Integer = Trim(drr(0).ToString).Length
            If Mid(Trim(drr(0).ToString), 1, 3) = "BK_" Then
                REMM = Mid(drr(0), 4, len - 3)
                NEWSERIAL = "RDY_" & StrDup(6 - REMM.Length, "0") & REMM
                sql = "update bookmaster set serial = '" & NEWSERIAL & "' where serial = '" & drr(0).ToString & "'"
                Try
                    ExecuteNonQuery(sql, True)
                Catch ex As Exception
                    ExecuteNonQuery(sql, , True)
                End Try

                If era = False Then
                    'sql = " update bookissiue_lines set book = '" & NEWSERIAL & "' where book = '" & drr(0).ToString & "'"
                    'ExecuteNonQuery(sql, , True)
                    'If era = False Then
                    '    ' sql = " update bookreturns set bookserial = '" & NEWSERIAL & "' where bookserial = '" & drr(0).ToString & "'"
                    '    ' ExecuteNonQuery(sql)
                    'End If
                Else
                    MsgBox(eramsg)
                End If
            End If

        End While
    End Sub





    Private Sub rbretbyborrower_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbretbyborrower.CheckedChanged, rbretbybook.CheckedChanged, rbretByIssue.CheckedChanged
        Dim ctrl As RadioButton

        ctrl = sender

        If ctrl.Checked Then
            txtReturnStud.Clear()
            chkIssues.DataSource = Nothing

            Select Case ctrl.Name
                Case rbretbyborrower.Name
                    lbReturnText.Text = "Borrower"
                Case rbretbybook.Name
                    lbReturnText.Text = "Book"
                Case rbretByIssue.Name
                    If cboReturnType.Text = "Return" Then
                        lbReturnText.Text = "IssueCode"
                    Else
                        lbReturnText.Text = "ReturnCode"
                    End If
            End Select
        End If
    End Sub

    Private Sub btnUpdateIssues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sql As String
        Dim drr As SqlDataReader
        Dim newissueno As String
        Dim len As Integer



        sql = "select issueno from bookissues where issuecode is  null "
        drr = ExecuteReader(sql, , True)
        While drr.Read
            len = drr(0).ToString.Length
            newissueno = "LIBRARY" & StrDup(6 - len, "0") & drr(0).ToString
            sql = "update bookissues set issuecode = '" & newissueno & "' where issueno = '" & drr(0) & "'"
            ExecuteNonQuery(sql, , True)



        End While


    End Sub

    Private Sub btnGenerate_Click_1(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim code128 As New BarcodeLib.Barcode.Linear
        Dim sql As String
        Dim i As Integer
        Dim temp1(400) As Byte
        Dim code As String
        Dim intermed As String
        cnn = New SqlConnection(ConnectionString)
        Dim trans As SqlTransaction = Nothing

        cnn.Open()
        trans = cnn.BeginTransaction
        Try


            For i = Int(txtCodeFrom.Text) To Int(txtCodeTo.Text)

                code128.Type = BarcodeLib.Barcode.BarcodeType.CODE128
                code128.UOM = BarcodeLib.Barcode.UnitOfMeasure.PIXEL
                intermed = i
                If Trim(txtCodePrefix.Text <> "") Then
                    code = txtCodePrefix.Text & "" & StrDup(6 - Len(intermed), "0") & i
                Else
                    code = StrDup(6 - Len(intermed), "0") & i
                End If

                ' code = "RYDINGLIBRARY"
                code128.Data = code
                code128.AddCheckSum = True
                code128.BarWidth = 2
                code128.BarHeight = 78
                code128.LeftMargin = 11
                code128.RightMargin = 11
                temp1 = code128.drawBarcodeAsBytes()


                sqltext = "spGenerateBarcode"
                cmd = New SqlCommand(sqltext, cnn, trans)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    param = New SqlParameter("@barcode", SqlDbType.Image)
                    param.Value = temp1
                    .Parameters.Add(param)
                    .Parameters.AddWithValue("@raw", i)
                    .Parameters.AddWithValue("@code", code)
                    .ExecuteNonQuery()
                End With





            Next

            trans.Commit()
            MsgBox("Barcodes created")

        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub btnView_Click_1(sender As Object, e As EventArgs) Handles btnView.Click
        Dim frmbarcode As New frmBarcodes



        frmbarcode.Show()
    End Sub

    Private Sub ToolStripButton7_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        cnn = New SqlConnection(ConnectionString)

        Try
            cnn.Open()
            sqltext = "spInsertBookTitle"
            cmd = New SqlCommand(sqltext, cnn)

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@title", TitleTextBox.Text)
                .Parameters.AddWithValue("@author", AuthorTextBox1.Text)
                .Parameters.AddWithValue("@isbn", ISBNTextBox.Text)
                .Parameters.AddWithValue("@publisher", PublisherTextBox1.Text)
                .Parameters.AddWithValue("@yearpublished", YearPublishedTextBox.Text)
                .Parameters.AddWithValue("@program", ProgramComboBox.Text)
                .Parameters.AddWithValue("@dpt", SubjectComboBox.Text)
                .Parameters.AddWithValue("@ref", IIf(txtTilteRef.Text = "", Guid.NewGuid, txtTilteRef.Text))
                .ExecuteNonQuery()
                MsgBox("Book Title Saved.")

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub btnBokkTitleSearch_Click_1(sender As Object, e As EventArgs) Handles btnBokkTitleSearch.Click
        Dim serchtext As String = Trim(txtTitleSearch.Text)
        lbTitleSearch.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Try


            cnn.Open()

            Dim filter As String = " where concat(Title, author,publisher,yearpublished) like '%" & serchtext & "%'"

            cmd.CommandText = "spBookTitleSearch"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)



            lbTitleSearch.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lbTitleSearch.DataSource = dsApps.Tables(0)
            lbTitleSearch.DisplayMember = "TitleText"
            lbTitleSearch.ValueMember = "Title"

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub txtTitleSearch_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtTitleSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbTitleSearch.Visible = False
        End If
    End Sub

    Private Sub lbTitleSearch_DoubleClick_1(sender As Object, e As EventArgs) Handles lbTitleSearch.DoubleClick
        Dim title As String
        Try
            title = lbTitleSearch.SelectedValue
            lbTitleSearch.Visible = False
            lbTitleSearch.DataSource = Nothing

            Me.BookTitlesTableAdapter1.FillByBookTitle(DsSchoolLibrary.BookTitles, title)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton9_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Dim sql As String
        cnn = New SqlConnection
        If txtTilteRef.Text <> "" Then

            If MsgBox("Are you sure you want to delete selected book", vbYesNo) = vbYes Then
                Try
                    cnn.Open()
                    sql = "spDeleteBookTitle"
                    cmd = New SqlCommand(sql, cnn)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@ref", txtTilteRef.Text)
                        .ExecuteNonQuery()
                        MsgBox("Title deleted")
                        BookTitlesTableAdapter1.Fill(DsSchoolLibrary.BookTitles)
                    End With


                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()

                End Try


            End If
        End If
    End Sub

    Private Sub ToolStripButton14_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Try
            Me.Validate()
            BookLoanTypeBindingSource.EndEdit()
            BookLoanTypeTableAdapter1.Update(DsSchoolLibrary.BookLoanType)
            MsgBox("Save Successfull")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Dim arrsplit() As String
        Dim issueno As String = ""
        Dim chkdinfo As String
        Dim bookref As String
        Dim lostbook As String = ""
        cnn = New SqlConnection(ConnectionString)

        Dim dateacquired, datereplaced As Date

        If Not Date.TryParse(DateAcquiredMaskedTextBox.Text, dateacquired) Then
            MsgBox("Invalid Date acquired")
            Exit Sub
        End If

        If gbreplacement.Visible Then
            chkdinfo = chkDamagedBooks.CheckedItems(0)
            arrsplit = Split(chkdinfo, "-")
            lostbook = arrsplit(0)
            If Not Date.TryParse(mskReplacementDate.Text, datereplaced) Then
                MsgBox("Invalid Date replaced")
                Exit Sub
            End If
        Else
            datereplaced = Now.Date

        End If
        Try
            cnn.Open()
            sqltext = "spInsertBookMaster"

            cmd = New SqlCommand(sqltext, cnn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@serial", Trim(SerialTextBox.Text))
                .Parameters.AddWithValue("@title", Trim(txtBookMasterTitle.Text))
                .Parameters.AddWithValue("@type", TypeComboBox.Text)
                .Parameters.AddWithValue("@bookstate", StatusComboBox1.Text)
                .Parameters.AddWithValue("@dateacquired", dateacquired)
                .Parameters.AddWithValue("@loan", cboLoanType.Text)
                .Parameters.AddWithValue("@copy", CopyComboBox.Text)
                .Parameters.AddWithValue("@comment", txtBookMasterComment.Text)
                .Parameters.AddWithValue("@replacemt", gbreplacement.Visible)
                .Parameters.AddWithValue("@Lostserial", lostbook)
                .Parameters.AddWithValue("@bookref", IIf(txtBookMasterRef.Text = "", Guid.NewGuid, txtBookMasterRef.Text))
                .Parameters.AddWithValue("@cost", txtBookMasterCost.Text)
                .Parameters.AddWithValue("@replacementdate", datereplaced)
                .ExecuteNonQuery()
                MsgBox("Book Updated")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try







    End Sub

    Private Sub txtBookMasterTitle_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtBookMasterTitle.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4_Click(Me, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            lbIndTitleSearch.Visible = False

        End If
    End Sub

    Private Sub lbIndTitleSearch_DoubleClick_1(sender As Object, e As EventArgs) Handles lbIndTitleSearch.DoubleClick
        Try
            txtBookMasterTitle.Text = lbIndTitleSearch.SelectedValue
            lbIndTitleSearch.DataSource = Nothing
            lbIndTitleSearch.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TypeComboBox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles TypeComboBox.SelectedIndexChanged
        Try
            If TypeComboBox.SelectedItem.ToString = "Replacement" Then
                gbreplacement.Visible = True
                MsgBox("Complete book details and  fill in the replacement details in the right panel")
            Else
                gbreplacement.Visible = False

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim serchtext As String = Trim(txtBookSearch.Text)
        lbboooksearch.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Try


            cnn.Open()

            Dim filter As String = " where concat(Title, serial) like '%" & serchtext & "%'"

            cmd.CommandText = "spBookMasterSearch"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)



            lbboooksearch.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lbboooksearch.DataSource = dsApps.Tables(0)
            lbboooksearch.DisplayMember = "TitleText"
            lbboooksearch.ValueMember = "Serial"

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub txtBookSearch_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtBookSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbboooksearch.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            Button2_Click_1(Me, Nothing)
        End If
    End Sub

    Private Sub lbboooksearch_DoubleClick_1(sender As Object, e As EventArgs) Handles lbboooksearch.DoubleClick
        Dim book As String
        book = Trim(lbboooksearch.SelectedValue)
        txtBookSearch.Text = book
        lbboooksearch.Visible = False
        lbboooksearch.DataSource = Nothing
        Try
            BookMasterTableAdapter1.FillBySerial(DsSchoolLibrary.BookMaster, book)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBukreplaceStud_TextChanged_1(sender As Object, e As EventArgs) Handles txtBukreplaceStud.TextChanged
        lbStudent.Visible = True
        lbStudent.Items.Clear()
        Dim sql As String
        Dim drr As SqlDataReader = Nothing
        sql = " select studentid ,StudName from  vwLibraryusers " &
            "where studentid + ' ' + StudName like '%" & txtBukreplaceStud.Text & "%'"
        drr = ExecuteReader(sql)
        Try
            While drr.Read
                lbStudent.Items.Add(drr(0) + "-" + drr(1))
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbStudent_DoubleClick_1(sender As Object, e As EventArgs) Handles lbStudent.DoubleClick
        Dim searchstring As String
        Try
            searchstring = lbStudent.SelectedItem.ToString
            lbStudent.Items.Clear()

        Catch ex As Exception

        End Try

        Dim arraysplit() As String
        arraysplit = Split(searchstring, "-")
        ' acaformComboBox.Text = arraysplit(3).ToString
        txtBukreplaceStud.Text = arraysplit(0).ToString
        lbStudent.Visible = False


        chkDamagedBooks.Items.Clear()
        Dim sql As String
        Dim drr As SqlDataReader
        sql = "select bookissiue_lines.book,title,issuecode from bookissiue_lines inner join  " &
        "bookmaster on bookmaster.serial = bookissues.book where borrower = '" & Trim(txtBukreplaceStud.Text) & "' and issuestate = '1' and bookmaster.bookstate = 'Lost' and "

        drr = ExecuteReader(sql)

        Try
            While drr.Read
                chkDamagedBooks.Items.Add(drr(0) + "-" + drr(1) + "-" + drr(2))
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cboIssueSearch.Text = "Issue" Then
            Dim serchtext As String = Trim(txtissueSearch.Text)
            lbSearchIssue.DataSource = Nothing
            Dim dsApps As New DataSet()
            Dim taApps As SqlDataAdapter = Nothing
            Dim cmd As New SqlCommand
            Dim cnn As New SqlConnection(ConnectionString)

            Try


                cnn.Open()

                Dim filter As String = " where concat(Title, studname,bookissiue_lines.issuecode,book) like '%" & serchtext & "%' and Active = 1 "

                cmd.CommandText = "spBookIssueSearch"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@filter", filter)



                lbSearchIssue.Visible = True

                taApps = New SqlDataAdapter(cmd)
                taApps.Fill(dsApps)

                lbSearchIssue.DataSource = dsApps.Tables(0)
                lbSearchIssue.DisplayMember = "IssueDetails"
                lbSearchIssue.ValueMember = "IssueCode"

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                cnn.Close()

            End Try

        ElseIf cboIssueSearch.Text = "Member" Then

            Dim serchtext As String = Trim(txtissueSearch.Text)
            '      lbSearchIssue.Items.Clear()
            Dim drr As SqlDataReader

            lbSearchIssue.Visible = True
            Dim sql As String = " select studentid,StudName from  vwLibraryUsers " &
            "where  studentid + ' ' + StudName  like '%" & serchtext & "%'"
            drr = ExecuteReader(sql)
            Try
                While drr.Read
                    lbSearchIssue.Items.Add(drr(0) & "-" & drr(1) & "-" & drr(2))
                End While

            Catch ex As Exception

            End Try



        End If
    End Sub

    Private Sub BorrowerTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BorrowerTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button5_Click(Me, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            lbBorrower.Visible = False
        End If
    End Sub

    Private Sub txtBook_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBook.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtBook_TextChanged_1(Me, Nothing)

        ElseIf e.KeyCode = Keys.Escape Then
            lbBook.Visible = False
        End If
    End Sub

    Private Sub cboBookState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBookState.SelectedIndexChanged

    End Sub

    Private Sub BookLoanTypeDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles BookLoanTypeDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BookLoanTypeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookLoanTypeDataGridView.CellContentClick

    End Sub

    Private Sub ToolStripButton8_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        ToolStripButton8_Click(Me, Nothing)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim serchtext As String = Trim(txtBookMasterTitle.Text)
        lbIndTitleSearch.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Try


            cnn.Open()

            Dim filter As String = " where concat(Title, author,publisher,yearpublished) like '%" & serchtext & "%'"

            cmd.CommandText = "spBookTitleSearch"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)



            lbIndTitleSearch.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lbIndTitleSearch.DataSource = dsApps.Tables(0)
            lbIndTitleSearch.DisplayMember = "TitleText"
            lbIndTitleSearch.ValueMember = "Title"

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub BorrowerTextBox_TextChanged(sender As Object, e As EventArgs) Handles BorrowerTextBox.TextChanged

    End Sub

    Private Sub txtissueSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtissueSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3_Click(Me, Nothing)
        Else
            lbSearchIssue.Visible = False
        End If
    End Sub

    Private Sub BorrowerTextBox_ForeColorChanged(sender As Object, e As EventArgs) Handles BorrowerTextBox.ForeColorChanged

    End Sub

    Private Sub cboReturnType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReturnType.SelectedIndexChanged

        strReturnType = cboReturnType.Text

        chkIssues.DataSource = Nothing
        lbReturnsStud.DataSource = Nothing
        lbReturnsStud.Visible = False

        If cboReturnType.Text = "Reversal" Then
            mskReturnDate.Enabled = False
            cboBookState.Enabled = False
            rbretByIssue.Text = "ByReturnCode"
        Else
            rbretByIssue.Text = "ByIssueCode"
            mskReturnDate.Enabled = True
            cboBookState.Enabled = True
            rbretbybook.Checked = True

        End If
    End Sub

    Private Sub btnReturnSearch_Click(sender As Object, e As EventArgs) Handles btnReturnSearch.Click
        Dim sql As String
        Dim drr As SqlDataReader = Nothing
        Dim filter As String = ""
        Dim blnbybook, blnbyborrower, blnbyissue As Boolean
        blnbybook = False : blnbyborrower = False : blnbyissue = False

        If rbretbybook.Checked Then
            blnbybook = True

            If strReturnType = "Return" Then
                filter = " where serial + ' ' + title like '%" & txtReturnStud.Text & "%' and bookstate =  'Issued' "

            Else

                filter = " where serial + ' ' + title like '%" & txtReturnStud.Text & "%'   "
            End If



        ElseIf rbretbyborrower.Checked Then
            blnbyborrower = True

            filter = " where studentid + ' ' + studname like '%" & txtReturnStud.Text & "%' "





        ElseIf rbretByIssue.Checked Then
            blnbyissue = True



            If strReturnType = "Return" Then
                filter = " where bh.issuecode like '%" & txtReturnStud.Text & "%'"

            Else

                filter = " where returnref like '%" & txtReturnStud.Text & "%'  and returnactive = 1  "
            End If


            '           sql = "select bookissiue_lines.book ,bookmaster.title as Book,borrower   from bookissiue_lines inner join " &
            '"dbo.bookissues on bookissues.issuecode = dbo.bookissiue_lines.issuecode " &
            '"inner join vwlibraryusers on StudentID = bookissues.borrower " &
            '"inner join bookmaster on bookmaster.serial = bookissiue_lines.book  " &
            ' "where Bookissues.issuecode = '" & txtReturnStud.Text & "' and issuestate = '1' and active = 1  and returnstate = 0"



        End If
        Dim cnn As New SqlConnection(ConnectionString)
        Try

            lbReturnsStud.DataSource = Nothing
            Dim dsApps As New DataSet()
            Dim taApps As SqlDataAdapter = Nothing
            Dim cmd As New SqlCommand



            cnn.Open()



            cmd.CommandText = "spSearchReturnByBook"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)
            cmd.Parameters.AddWithValue("@returntype", strReturnType)
            cmd.Parameters.AddWithValue("@bybook", blnbybook)
            cmd.Parameters.AddWithValue("@byBorrower", blnbyborrower)
            cmd.Parameters.AddWithValue("@byissue", blnbyissue)
            lbReturnsStud.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lbReturnsStud.DataSource = dsApps.Tables(0)

            If blnbybook Then
                lbReturnsStud.DisplayMember = "Title"
                lbReturnsStud.ValueMember = "Serial"
            ElseIf blnbyborrower Then
                lbReturnsStud.DisplayMember = "StudName"
                lbReturnsStud.ValueMember = "StudentID"
            ElseIf blnbyissue Then
                       lbReturnsStud.DisplayMember = "issuecode"
                lbReturnsStud.ValueMember = "issuecode"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sql, name As String


        lbBorrower.Visible = True
        lbBorrower.Items.Clear()

        '  Dim sql As String
        Dim drr As SqlDataReader = Nothing
        sql = " select studentid ,StudNAme from  vwlibraryusers " &
            "where studentid + ' ' + StudNAme like '%" & Trim(BorrowerTextBox.Text) & "%'"
        drr = ExecuteReader(sql)
        While drr.Read
            lbBorrower.Items.Add(drr(0).ToString + "-" + drr(1).ToString)
        End While
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If rbSingleIssue.Checked Then
            Dim serchtext As String = Trim(txtBook.Text)
            lbBook.DataSource = Nothing
            Dim dsApps As New DataSet()
            Dim taApps As SqlDataAdapter = Nothing
            Dim cmd As New SqlCommand
            Dim cnn As New SqlConnection(ConnectionString)

            Try


                cnn.Open()

                Dim filter As String = " where concat(Title, serial) like '%" & serchtext & "%'"

                cmd.CommandText = "spSingleBookSearch"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@filter", filter)



                lbBook.Visible = True

                taApps = New SqlDataAdapter(cmd)
                taApps.Fill(dsApps)

                lbBook.DataSource = dsApps.Tables(0)
                lbBook.DisplayMember = "TitleText"
                lbBook.ValueMember = "Serial"

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                cnn.Close()

            End Try
        Else
            Dim serchtext As String = Trim(txtBook.Text)
            lbBook.DataSource = Nothing
            Dim dsApps As New DataSet()
            Dim taApps As SqlDataAdapter = Nothing
            Dim cmd As New SqlCommand
            Dim cnn As New SqlConnection(ConnectionString)

            Try


                cnn.Open()

                Dim filter As String = " where concat(Title, author) like '%" & serchtext & "%'"

                cmd.CommandText = "spgroupBookSearch"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@filter", filter)



                lbBook.Visible = True

                taApps = New SqlDataAdapter(cmd)
                taApps.Fill(dsApps)

                lbBook.DataSource = dsApps.Tables(0)
                lbBook.DisplayMember = "TitleText"
                lbBook.ValueMember = "Serial"

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                cnn.Close()

            End Try
        End If
    End Sub
End Class