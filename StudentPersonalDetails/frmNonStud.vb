Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net
Imports System.Data
Imports Miscelleneous
Imports System.Windows.Forms

Public Class frmNonStud
    Private mblnaddingUser As Boolean
    Private mblnaddingFess As Boolean = False
    Private mblnaddindexp As Boolean = False
    Private mblnaddingBehav As Boolean = False
    Private mblnEdtFess As Boolean = False
    Private mblnDltFess As Boolean = False
    Private mblnEdtExp As Boolean = False
    Private mblnDltExp As Boolean = False
    Private mblnaddinddebtor As Boolean = False
    Private mblnaddingcreditor As Boolean = False




    Private Sub frmNonStud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsIncomeExpenditureReports.CreditorsStatement' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsIncomeExpenditure.Creditors' table. You can move, or remove it, as needed.
        '     Me.CreditorsTableAdapter.Fill(Me.DsIncomeExpenditure.Creditors)
        'TODO: This line of code loads data into the 'DsFees.FeesPayments_Header1' table. You can move, or remove it, as needed.
        'Me.FeesPayments_Header1TableAdapter.Fill(Me.DsFees.FeesPayments_Header1)
        'TODO: This line of code loads data into the 'DsFees1.feespayments_details1' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'SchoolDataSet.PaymentType3' table. You can move, or remove it, as needed.
        ' Me.PaymentType3TableAdapter.Fill(Me.SchoolDataSet.PaymentType3)
        'TODO: This line of code loads data into the 'SchoolDataSet.PaymentType' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsStudentSearches.PaymentType' table. You can move, or remove it, as needed.
        ' Me.PaymentTypeTableAdapter1.Fill(Me.DsStudentSearches.PaymentType)
        'TODO: This line of code loads data into the 'DsFees.feespayments_details1' table. You can move, or remove it, as needed.
        '   Me.Feespayments_details1TableAdapter.Fill(Me.DsFees.feespayments_details1)
        'TODO: This line of code loads data into the 'dsReports.NeawYearStatement' table. You can move, or remove it, as needed.
        ' Me.NeawYearStatementTableAdapter.Fill(Me.dsReports.NeawYearStatement)
        'TODO: This line of code loads data into the 'dsReports.NeawYearStatement' table. You can move, or remove it, as needed.
        ' Me.NeawYearStatementTableAdapter.Fill(Me.dsReports.NeawYearStatement)
        'TODO: This line of code loads data into the 'dsReports.DebtorsTransactions' table. You can move, or remove it, as needed.
        '  Me.DebtorsTransactionsTableAdapter.Fill(Me.dsReports.DebtorsTransactions)
        'TODO: This line of code loads data into the 'DsIncomeExpenditure.Debtors' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsIncomeExpenditure.Debtors' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsSchool.PaymentPeriods' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsFees.feespayments_details' table. You can move, or remove it, as needed.
        Try

            loaddatasets()
        Catch ex As Exception

        End Try

        '    Prepareform(Me)
        '   MdiParent = frmMain

        Me.rvDebtStatement.RefreshReport()
        cboReceiptSearch.Text = "Debtor"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub loaddatasets()
        BindingNavigator2.Items("Del").Visible = True
        BindingNavigator3.Items("Add").Visible = True
        BindingNavigator1.Items("Delrt").Visible = True
        mblnaddinddebtor = False
        mblnaddindexp = False
        mblnaddingFess = False
        Try

        Catch ex As Exception

        End Try

    End Sub
    Private Sub ReceiptTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '     Me.Feespayments_detailsTableAdapter1.FillByReceipt(DsFees.feespayments_details, ReceiptTextBox.Text)
    End Sub

    '    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim sql, sql2 As String
    '        Dim trans As SqlTransaction = Nothing
    '        Dim comm As String


    '        receiptprnt = True
    '        stmntprnt = False
    '        enrolform = False
    '        studprnt = False
    '        clsprint = False
    '        Dim fizpayrow As dsSchool.FeesPaymentsRow
    '        Dim amount, recid, recprefix, sql1, receipt, cartegory, reference, det, period, cart, curr As String
    '        Dim drr As SqlDataReader
    '        Dim rows As Integer

    '        recprefix = "Rec_"



    '        recid = GetNextTableID2("FeesPayments_header", "receipt", True, recprefix.Length)
    '        receipt = Trim(recprefix) & StrDup(8 - Len(recid), "0") & recid


    '        det = changedate(mskpaydate.Text)
    '        If det = "-  -  " Then
    '            MsgBox("Invalid Receipt Date")
    '            Exit Sub
    '        End If

    '        If mblnaddingFess Then
    '            sql = "insert into feespayments_header(StudentID ,Date,Receipt,status,usr,type,cashtype,postdate) " & _
    '       "values ('" & TxtName.Text & "','" & det & "','" & receipt & "','1','" & goUser.FullName & "','R','" & cboCashType.Text & "','" & changedate(PostDateDateTimePicker.Value.Date) & "')"
    '            ExecuteNonQuery(sql, True, , , trans, True, True)

    '            rows = dgFessDetails.Rows.Count - 1
    '            If rows < 1 Then
    '                MsgBox("Receipt details not complete")
    '                trans.Rollback()
    '                Exit Sub

    '            End If
    '            If Not era Then
    '                For a1 = 0 To dgFessDetails.Rows.Count - 2
    '                    Try
    '                        amount = -1 * dgFessDetails.Rows(a1).Cells(1).Value
    '                    Catch ex As Exception
    '                        MsgBox("Invalid amount on line " & a1 + 1)
    '                        GoTo era
    '                    End Try
    '                    Try
    '                        cart = dgFessDetails.Rows(a1).Cells(0).Value
    '                    Catch ex As Exception
    '                        MsgBox("Invalid cartegory on line " & a1 + 1)
    '                        GoTo era
    '                    End Try
    '                    Try
    '                        reference = dgFessDetails.Rows(a1).Cells(2).Value
    '                    Catch ex As Exception
    '                        reference = "ref"
    '                    End Try

    '                    Try
    '                        period = dgFessDetails.Rows(a1).Cells(3).Value
    '                    Catch ex As Exception
    '                        reference = "ref"
    '                    End Try

    '                    Try
    '                        comm = dgFessDetails.Rows(a1).Cells(4).Value
    '                    Catch ex As Exception
    '                        '/reference = "ref"
    '                    End Try

    '                    sql2 = " insert into feespayments_details (Receipt,Amount,Currency,Cartegory,Period,Line_number,Reference,comment)" & _
    '                        " values( '" & receipt & "' ,'" & amount & "','USD' ,'" & cart & "','" & period & "','" & a1 + 1 & "','" & reference & "','" & comm & "')"
    '                    ExecuteNonQuery(sql2, True, , , trans, True)
    '                    If era Then
    'era:                    If Not IsNothing(trans) Then trans.Rollback()
    '                        BindingNavigator2.Items("Del").Visible = False
    '                        mblnaddingFess = True
    '                        Exit Sub
    '                    End If

    '                    If a1 = rows - 1 Then
    '                        Dim reducedbalance As Boolean = reducebalance(TxtName.Text, amount)
    '                        If reducedbalance Then
    '                            trans.Commit()
    '                            MsgBox("Receipt " & receipt & " successfully saved ")

    '                            ReceiptTextBox.Text = receipt
    '                            Dim rec$ = MsgBox("Do you want to Print Receipt", MsgBoxStyle.YesNo)
    '                            If rec <> "6" Then
    '                                receiptprnt = False
    '                            Else
    '                                Try

    '                                    If Trim(Mid(ReceiptTextBox.Text, 1, 4)) <> "inv_" Then
    '                                        gblnreceipt = True
    '                                        gstrReceipt = ReceiptTextBox.Text
    '                                        gblnReceiptCopy = False
    '                                        '   frmReportPreview.Show()

    '                                    Else
    '                                        gblnreceipt = False
    '                                        gstrReceipt = ReceiptTextBox.Text
    '                                        gblnReceiptCopy = False
    '                                        '    frmReportPreview.Show()
    '                                    End If

    '                                Catch ex As Exception
    '                                    MsgBox(ex.Message)
    '                                End Try


    '                            End If

    '                        Else
    '                            trans.Rollback()

    '                            MsgBox("Failed to perform debtors aging")
    '                            ' MsgBox("Error in creating receipt")

    '                            BindingNavigator2.Items("Del").Visible = False
    '                            Exit Sub
    '                        End If
    '                        ' sql2 = " select [balance] from 




    '                        BindingNavigator2.Items("Del").Visible = True
    '                        ReceiptTextBox.Text = receipt

    '                        dgFessDetails.Enabled = False
    '                        gbFeesPay.Enabled = False
    '                        mblnaddingFess = False




    '                    End If
    '                Next
    '            Else

    '                trans.Rollback()
    '                MsgBox("Error in creating receipt")

    '                BindingNavigator2.Items("Del").Visible = False
    '                Exit Sub
    '            End If

    '        ElseIf mblnEdtFess Then
    '            Dim sql3 As String
    '            sql3 = "select "





    '            Try
    '                Dim det1 As String
    '                det1 = changedate(mskpaydate.Text)
    '                'Me.Validate()
    '                'Me.FeesPaymentsBindingSource.EndEdit()
    '                'Me.FeesPaymentsTableAdapter.Update(dsschool.FeesPayments)
    '                sql3 = "  update feespayments_header set date = '" & det1 & "' , lastchangedby = '" & goUser.FullName & " ' ,lastchangedon = '" & changedate(Now.Date) & "' where receipt =  '" & ReceiptTextBox.Text & "'"
    '                ExecuteNonQuery(sql3, , True, , , , True)
    '                If era = False Then




    '                    For a1 = 0 To dgFessDetails.Rows.Count - 2
    '                        Try
    '                            If dgFessDetails.Rows(a1).Cells(1).Value < 0 And dgFessDetails.Rows(a1).Cells(0).Value <> "BILLING" Then
    '                                amount = dgFessDetails.Rows(a1).Cells(1).Value
    '                            ElseIf dgFessDetails.Rows(a1).Cells(1).Value > 0 And dgFessDetails.Rows(a1).Cells(0).Value <> "BILLING" Then
    '                                amount = -1 * dgFessDetails.Rows(a1).Cells(1).Value
    '                            ElseIf dgFessDetails.Rows(a1).Cells(1).Value < 0 And dgFessDetails.Rows(a1).Cells(0).Value = "BILLING" Then
    '                                amount = -1 * dgFessDetails.Rows(a1).Cells(1).Value
    '                            ElseIf dgFessDetails.Rows(a1).Cells(1).Value > 0 And dgFessDetails.Rows(a1).Cells(0).Value = "BILLING" Then
    '                                amount = dgFessDetails.Rows(a1).Cells(1).Value
    '                            End If

    '                        Catch ex As Exception
    '                            MsgBox("Invalid amount on line " & a1 + 1)
    '                            Exit Sub
    '                        End Try

    '                        Try
    '                            reference = dgFessDetails.Rows(a1).Cells(2).Value
    '                        Catch ex As Exception
    '                            reference = "ref"
    '                        End Try

    '                        Try
    '                            period = dgFessDetails.Rows(a1).Cells(3).Value
    '                        Catch ex As Exception
    '                            MsgBox("Invalid period on line " & a1 + 1)
    '                            Exit Sub
    '                        End Try

    '                        Try
    '                            cart = dgFessDetails.Rows(a1).Cells(0).Value
    '                        Catch ex As Exception
    '                            MsgBox("Invalid cartegory on line " & a1 + 1)
    '                            Exit Sub
    '                        End Try

    '                        'Try
    '                        '    curr = dgFessDetails.Rows(a1).Cells(2).Value

    '                        'Catch ex As Exception
    '                        '    MsgBox("Invalid currency on line " & a + 1)
    '                        '    Exit Sub
    '                        'End Try
    '                    Next
    '                    sql = "delete feespayments_details where receipt = '" & ReceiptTextBox.Text & "'"
    '                    ExecuteNonQuery(sql, , True)
    '                    If era = False Then
    '                        For A1 = 0 To dgFessDetails.Rows.Count - 2

    '                            If dgFessDetails.Rows(A1).Cells(1).Value < 0 And dgFessDetails.Rows(A1).Cells(0).Value <> "BILLING" Then
    '                                amount = dgFessDetails.Rows(A1).Cells(1).Value
    '                            ElseIf dgFessDetails.Rows(A1).Cells(1).Value > 0 And dgFessDetails.Rows(A1).Cells(0).Value <> "BILLING" Then
    '                                amount = -1 * dgFessDetails.Rows(A1).Cells(1).Value
    '                            ElseIf dgFessDetails.Rows(A1).Cells(1).Value < 0 And dgFessDetails.Rows(A1).Cells(0).Value = "BILLING" Then
    '                                amount = -1 * dgFessDetails.Rows(A1).Cells(1).Value
    '                            ElseIf dgFessDetails.Rows(A1).Cells(1).Value > 0 And dgFessDetails.Rows(A1).Cells(0).Value = "BILLING" Then
    '                                amount = dgFessDetails.Rows(A1).Cells(1).Value
    '                            End If
    '                            ' IIf(dgFessDetails.Rows(a1).Cells(1).Value < 0, amount = dgFessDetails.Rows(a1).Cells(1).Value, amount = -1 * dgFessDetails.Rows(a1).Cells(1).Value)
    '                            reference = dgFessDetails.Rows(A1).Cells(2).Value
    '                            curr = "USD"
    '                            cart = dgFessDetails.Rows(A1).Cells(0).Value
    '                            period = dgFessDetails.Rows(A1).Cells(3).Value

    '                            sql2 = " insert into feespayments_details (Receipt,Amount,Currency,Cartegory,Period,Line_number,Reference)" & _
    '                      " values( '" & ReceiptTextBox.Text & "' ,'" & amount & "','" & curr & _
    '                      "','" & cart & "','" & period & "','" & A1 + 1 & "','" & reference & "')"
    '                            ExecuteNonQuery(sql2, , True)
    '                            If era = False And A1 = dgFessDetails.Rows.Count - 2 Then

    '                                dgFessDetails.Enabled = False
    '                                gbFeesPay.Enabled = False
    '                                mblnEdtFess = False

    '                                Dim rec$ = MsgBox("Receipt " & ReceiptTextBox.Text & " successfully edited, do you want to print receipt?", MsgBoxStyle.YesNo)

    '                                If rec <> "6" Then
    '                                    receiptprnt = False
    '                                Else
    '                                    If Trim(Mid(ReceiptTextBox.Text, 1, 4)) <> "inv_" Then
    '                                        gblnreceipt = True
    '                                        gstrReceipt = ReceiptTextBox.Text
    '                                        gblnReceiptCopy = True
    '                                        '      frmReportPreview.Show()

    '                                    Else
    '                                        gblnreceipt = False
    '                                        gstrReceipt = ReceiptTextBox.Text
    '                                        gblnReceiptCopy = True
    '                                        '  frmReportPreview.Show()
    '                                    End If

    '                                End If



    '                            Else
    '                                If era Then
    'era2:                               'If Not IsNothing(trans) Then trans.Rollback()
    '                                    MsgBox("Failed to Edit Receipt")
    '                                    Exit Sub


    '                                ElseIf A1 < dgFessDetails.Rows.Count - 2 Then
    '                                    dgFessDetails.Enabled = True
    '                                    gbFeesPay.Enabled = True
    '                                    mblnEdtFess = True
    '                                End If
    '                            End If
    '                        Next
    '                    End If





    '                End If


    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try



    '        ElseIf mblnDltFess Then

    '            If ReasonForReversalComboBox.Text = "" Then

    '                mblnDltFess = True
    '                MsgBox("Please select reason for payment deletion and press delete/cancel again")
    '                gbFeesPay.Enabled = True
    '                ReasonForReversalComboBox.Enabled = True
    '            Else
    '                sql = " update feespayments_header set status = '0' , cancelledby = '" & goUser.FullName & "',datecancelled = '" & changedate(Now.Date) & "',reasonforreversal = '" & ReasonForReversalComboBox.Text & "'  where receipt = '" & ReceiptTextBox.Text & "'"
    '                ExecuteNonQuery(sql)
    '                If era = False Then
    '                    MsgBox("Payment successfully cancelled")
    '                    mblnDltFess = False



    '                    ReasonForReversalComboBox.Enabled = False
    '                    gbFeesPay.Enabled = False

    '                Else
    '                    MsgBox("Error in deleting payment")
    '                    ReasonForReversalComboBox.Enabled = False
    '                    gbFeesPay.Enabled = False
    '                End If
    '            End If




    '        End If




    '        '  End If


    '    End Sub

    'Private Function reducebalance(ByVal debtor As String, ByVal amnt As Double) As Boolean
    '    Dim sql, sql3 As String

    '    Dim mindate As String
    '    Dim mininv As String = "INV_00000000"
    '    Dim reader As SqlDataReader
    '    Dim minbal, newbal, overdraft As Double
    '    sql3 = " select min(invdate) from debtoraging where balance > 0 and debtor = '" & debtor & "' and status = 1"
    '    Dim count As Integer = 0

    '    Try
    '        mindate = ExecuteScalar(sql3, , True)
    '    Catch ex As Exception
    '        mindate = changedate(mindate)
    '        sql = "insert into debtoraging (debtor,invoice,balance,invdate,status,initialamount) values('" & debtor & "','excess','" & amnt & "','" & mindate & "','1','" & amnt & "' "
    '        ExecuteNonQuery(sql)

    '        Return True


    '        ' Exit Function
    '    End Try

    '    mindate = changedate(mindate)
    '    If Not IsNothing(mindate) Then



    '        sql3 = "select invoice,balance  from debtoraging where invdate = '" & mindate & "' and balance > 0 and debtor =  '" & debtor & "' order by invoice desc"
    '        reader = ExecuteReader(sql3, , True)
    '        If reader.HasRows Then
    '            While reader.Read
    '                If count = 0 Then
    '                    mininv = reader(0)
    '                    minbal = reader(1)
    '                Else
    '                    If Mid(reader(0).ToString, 4) < Mid(mininv.ToString, 4) Then
    '                        mininv = reader(0).ToString
    '                        minbal = reader(1)
    '                    End If
    '                End If

    '                count += 1
    '            End While

    '        End If

    '        newbal = minbal + amnt

    '        If newbal < 0 Then
    '            overdraft = newbal
    '            newbal = 0
    '            sql = "update debtoraging set balance = '" & newbal & "' where invoice = '" & mininv & "'"
    '            ExecuteNonQuery(sql)
    '            If era Then
    '                Return False
    '                'Exit Function
    '            Else
    '                reducebalance(debtor, overdraft)
    '            End If


    '        Else
    '            sql = "update debtoraging set balance = '" & newbal & "' where invoice = '" & mininv & "'"
    '            ExecuteNonQuery(sql)
    '            If era Then
    '                Return False
    '            Else


    '            End If

    '        End If

    '    Else
    '        Return True
    '    End If


    '    'reader

    '    Return True



    'End Function

    'Private Sub Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    mblnaddingFess = True
    '    dgFessDetails.Enabled = True
    '    gbFeesPay.Enabled = True
    '    PostDateDateTimePicker.Value = Now.Date

    '    Dim sql As String
    '    Dim drr As SqlDataReader

    '    BindingNavigator2.Items("Del").Visible = False


    '    If cboReceiptSearch.Text = "Debtor" Then
    '        Dim serchtext As String = Trim(txtReceiptSearch.Text)
    '        lbDebtors.Items.Clear()

    '        lbDebtors.Visible = True
    '        sql = "select acc,[name] from debtors where acc = '" & serchtext & "'"
    '        drr = ExecuteReader(sql)
    '        If drr.HasRows Then
    '            While drr.Read
    '                lbDebtors.Items.Add(drr(0).ToString + "-" + drr(1).ToString)
    '            End While
    '        End If

    '        If lbDebtors.Items.Count = 1 Then
    '            Dim sql2, debtor As String

    '            TxtName.Text = serchtext
    '            sql2 = " select [name] from debtors where acc = '" & serchtext & "'"
    '            debtor = ExecuteScalar(sql2)
    '            lbDebtorName.Text = debtor

    '            lbDebtors.SelectedIndex = 0
    '            lbDebtors_DoubleClick(Me, Nothing)

    '        End If

    '    End If
    'End Sub

    Private Sub dgFessDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dgFessDetails_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub Edt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mblnEdtFess = True
        gbFeesPay.Enabled = True
        dgFessDetails.Enabled = True
    End Sub

    'Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim sql, usr As String
    '    sql = " select usr from feespayments_header where receipt = '" & ReceiptTextBox.Text & "' "
    '    usr = ExecuteScalar(sql)

    '    'If usr = goUser.FullName Then
    '    '    MsgBox("User not allowed to cancel own documnet")
    '    '    Exit Sub
    '    'End If





    '    Dim res As String = MsgBox("Are you sure you want to cancel the current payment", MsgBoxStyle.YesNoCancel)

    '    If res = "6" Then
    '        If ReasonForReversalComboBox.Text = "" Then

    '            mblnDltFess = True
    '            MsgBox("Please select reason for payment deletion and press delete/cancel again")
    '            gbFeesPay.Enabled = True
    '            ReasonForReversalComboBox.Enabled = True
    '        Else
    '            sql = " update feespayments_header set status = '0' , cancelledby = '" & goUser.FullName & "',datecancelled = '" & changedate(Now.Date) & "',reasonforreversal = '" & ReasonForReversalComboBox.Text & "'  where receipt = '" & ReceiptTextBox.Text & "'"
    '            ExecuteNonQuery(sql)
    '            If era = False Then
    '                MsgBox("Payment successfully cancelled")
    '                mblnDltFess = False



    '                ReasonForReversalComboBox.Enabled = False
    '                gbFeesPay.Enabled = False

    '            Else
    '                MsgBox("Error in deleting payment")
    '                ReasonForReversalComboBox.Enabled = False
    '                gbFeesPay.Enabled = False
    '            End If
    '        End If
    '    Else
    '        gbFeesPay.Enabled = False
    '    End If
    'End Sub

    'Private Sub cboReceiptSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtReceiptSearch.Clear()
    '    If cboReceiptSearch.Text = "Date" Then
    '        txtReceiptSearch.Visible = False
    '        FeesDateSearch.Visible = True
    '        ' lbSeacrhFees.Visible = False
    '        '   btnViewStatement.Enabled = False

    '        Try
    '            Me.FeesPaymentsTableAdapter.FillByDate(SchoolDataSet.FeesPayments, "01/01/1900", cboFeesCartegory.Text)
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub




    Private Sub Reprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        receiptprnt = True
        stmntprnt = False
        enrolform = False
        studprnt = False
        clsprint = False

        Try

            If Trim(Mid(ReceiptTextBox.Text, 1, 4)) <> "inv_" Then
                gblnreceipt = True
                gstrReceipt = ReceiptTextBox.Text
                gblnReceiptCopy = True
                '   frmReportPreview.Show()

            Else
                gblnreceipt = False
                gstrReceipt = ReceiptTextBox.Text
                gblnReceiptCopy = True
                '   frmReportPreview.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    '    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pay_save.Click
    '        Dim sql, sql2 As String
    '        Dim trans As SqlTransaction = Nothing
    '        Dim comm As String


    '        receiptprnt = True
    '        stmntprnt = False
    '        enrolform = False
    '        studprnt = False
    '        clsprint = False
    '        Dim fizpayrow As dsSchool.FeesPaymentsRow
    '        Dim amount, invid, invprefix, sql1, invoice, cartegory, reference, det, period, cart, curr As String
    '        Dim drr As SqlDataReader
    '        Dim rows As Integer

    '        invprefix = "INV_"



    '        invid = GetNextTableID2("FeesPayments_header", "invoice", False, invprefix.Length)
    '        invoice = Trim(invprefix) & StrDup(8 - Len(invid), "0") & invid

    '        det = changedate(MaskedTextBox1.Text)
    '        If det = "-  -  " Then
    '            MsgBox("Invalid Expense Date")
    '            Exit Sub
    '        End If

    '        If txtExpCreditor.Text = "" Then
    '            MsgBox("Invalid Creditor")
    '            Exit Sub
    '        End If

    '        If mblnaddindexp Then
    '            sql = "insert into feespayments_header(Studentid ,Date,Receipt,status,usr,type,cashtype,postdate,invoice) " & _
    '       "values ('" & txtExpCreditor.Text & "','" & det & "','" & invoice & "','1','" & goUser.FullName & "','E','Cash','" & changedate(DateTimePicker1.Value.Date) & "' ,'" & invoice & "')"
    '            ExecuteNonQuery(sql, True, , , trans, True, True)

    '            rows = dgExpenses.Rows.Count - 1
    '            If Not era Then
    '                For A1 = 0 To dgExpenses.Rows.Count - 2
    '                    Try
    '                        amount = dgExpenses.Rows(A1).Cells(1).Value
    '                    Catch ex As Exception
    '                        MsgBox("Invalid amount on line " & A1 + 1)
    '                        GoTo era
    '                    End Try
    '                    Try
    '                        cart = dgExpenses.Rows(A1).Cells(0).Value
    '                    Catch ex As Exception
    '                        MsgBox("Invalid cartegory on line " & A1 + 1)
    '                        GoTo era
    '                    End Try
    '                    Try
    '                        reference = dgExpenses.Rows(A1).Cells(2).Value
    '                    Catch ex As Exception
    '                        reference = "ref"
    '                    End Try

    '                    Try
    '                        period = dgExpenses.Rows(A1).Cells(3).Value
    '                    Catch ex As Exception
    '                        reference = "ref"
    '                    End Try

    '                    Try
    '                        comm = dgExpenses.Rows(A1).Cells(4).Value
    '                    Catch ex As Exception
    '                        '/reference = "ref"
    '                    End Try

    '                    sql2 = " insert into feespayments_details (Receipt,Amount,Currency,Cartegory,Period,Line_number,Reference,comment)" & _
    '                        " values( '" & invoice & "' ,'" & amount & "','USD' ,'" & cart & "','" & period & "','" & A1 + 1 & "','" & reference & "','" & comm & "')"
    '                    ExecuteNonQuery(sql2, True, , , trans, True)
    '                    If era Then
    'era:                    If Not IsNothing(trans) Then trans.Rollback()
    '                        BindingNavigator1.Items("Delrt").Visible = False
    '                        mblnaddingFess = True
    '                        Exit Sub
    '                    End If

    '                    If A1 = rows - 1 Then
    '                        trans.Commit()
    '                        MsgBox("Expence " & invoice & " successfully saved ")
    '                        BindingNavigator1.Items("Delrt").Visible = False
    '                        TextBox2.Text = invoice

    '                        dgExpenses.Enabled = False
    '                        gbExpenses.Enabled = False
    '                        mblnaddindexp = False

    '                        If cboExpenditureSearchCart.Text <> "ALL" Then
    '                            Me.CreditorsStatementTableAdapter.FillByCartegory(Me.dsIncomeExpenditureReports.CreditorsStatement, goUser.FullName, txtExpCreditor.Text, cboExpenditureSearchCart.Text)
    '                        Else
    '                            Me.CreditorsStatementTableAdapter.FillByStudAll(Me.dsIncomeExpenditureReports.CreditorsStatement, goUser.FullName, txtExpCreditor.Text)
    '                        End If
    '                        Me.ReportViewer1.RefreshReport()

    '                        'Dim rec$ = MsgBox("Do you want to Print Receipt", MsgBoxStyle.YesNo)
    '                        'If rec <> "6" Then
    '                        '    receiptprnt = False
    '                        'Else
    '                        '    Try

    '                        '        If Trim(Mid(ReceiptTextBox.Text, 1, 4)) <> "inv_" Then
    '                        '            gblnreceipt = True
    '                        '            gstrReceipt = ReceiptTextBox.Text
    '                        '            gblnReceiptCopy = False
    '                        '            frmReportPreview.Show()

    '                        '        Else
    '                        '            gblnreceipt = False
    '                        '            gstrReceipt = ReceiptTextBox.Text
    '                        '            gblnReceiptCopy = False
    '                        '            frmReportPreview.Show()
    '                        '        End If

    '                        '    Catch ex As Exception
    '                        '        MsgBox(ex.Message)
    '                        '    End Try


    '                        'End If

    '                    End If
    '                Next
    '            Else

    '                trans.Rollback()
    '                MsgBox("Error in creating receipt")

    '                BindingNavigator2.Items("Del").Visible = False
    '                Exit Sub
    '            End If

    '        ElseIf mblnEdtExp Then
    '            Dim sql3 As String
    '            sql3 = "select "





    '            Try
    '                Dim det1 As String
    '                det1 = changedate(MaskedTextBox1.Text)
    '                'Me.Validate()
    '                'Me.FeesPaymentsBindingSource.EndEdit()
    '                'Me.FeesPaymentsTableAdapter.Update(dsschool.FeesPayments)
    '                sql3 = "  update feespayments_header set date = '" & det1 & "' , lastchangedby = '" & goUser.FullName & " ' ,lastchangedon = '" & changedate(Now.Date) & "' where receipt =  '" & TextBox2.Text & "'"
    '                ExecuteNonQuery(sql3, , True, , , , True)
    '                If era = False Then




    '                    For A1 = 0 To dgExpenses.Rows.Count - 2
    '                        Try
    '                            '  If dgExpenses.Rows(a1).Cells(1).Value < 0 And dgFessDetails.Rows(a1).Cells(0).Value <> "BILLING" Then
    '                            amount = dgFessDetails.Rows(A1).Cells(1).Value
    '                            'ElseIf dgFessDetails.Rows(a1).Cells(1).Value > 0 And dgFessDetails.Rows(a1).Cells(0).Value <> "BILLING" Then
    '                            'amount = -1 * dgFessDetails.Rows(a1).Cells(1).Value
    '                            'ElseIf dgFessDetails.Rows(a1).Cells(1).Value < 0 And dgFessDetails.Rows(a1).Cells(0).Value = "BILLING" Then
    '                            'amount = -1 * dgFessDetails.Rows(a1).Cells(1).Value
    '                            'ElseIf dgFessDetails.Rows(a1).Cells(1).Value > 0 And dgFessDetails.Rows(a1).Cells(0).Value = "BILLING" Then
    '                            'amount = dgFessDetails.Rows(a1).Cells(1).Value
    '                            'End If

    '                        Catch ex As Exception
    '                            MsgBox("Invalid amount on line " & A1 + 1)
    '                            Exit Sub
    '                        End Try

    '                        Try
    '                            reference = dgFessDetails.Rows(A1).Cells(2).Value
    '                        Catch ex As Exception
    '                            reference = "ref"
    '                        End Try

    '                        Try
    '                            period = dgFessDetails.Rows(A1).Cells(3).Value
    '                        Catch ex As Exception
    '                            MsgBox("Invalid period on line " & A1 + 1)
    '                            Exit Sub
    '                        End Try

    '                        Try
    '                            cart = dgFessDetails.Rows(A1).Cells(0).Value
    '                        Catch ex As Exception
    '                            MsgBox("Invalid cartegory on line " & A1 + 1)
    '                            Exit Sub
    '                        End Try

    '                        'Try
    '                        '    curr = dgFessDetails.Rows(a1).Cells(2).Value

    '                        'Catch ex As Exception
    '                        '    MsgBox("Invalid currency on line " & a + 1)
    '                        '    Exit Sub
    '                        'End Try
    '                    Next
    '                    sql = "delete feespayments_details where receipt = '" & TextBox2.Text & "'"
    '                    ExecuteNonQuery(sql, , True)
    '                    If era = False Then
    '                        For A1 = 0 To dgFessDetails.Rows.Count - 2

    '                            ' If dgFessDetails.Rows(a1).Cells(1).Value < 0 And dgFessDetails.Rows(a1).Cells(0).Value <> "BILLING" Then
    '                            amount = dgFessDetails.Rows(A1).Cells(1).Value
    '                            'ElseIf dgFessDetails.Rows(a1).Cells(1).Value > 0 And dgFessDetails.Rows(a1).Cells(0).Value <> "BILLING" Then
    '                            'amount = -1 * dgFessDetails.Rows(a1).Cells(1).Value
    '                            'ElseIf dgFessDetails.Rows(a1).Cells(1).Value < 0 And dgFessDetails.Rows(a1).Cells(0).Value = "BILLING" Then
    '                            'amount = -1 * dgFessDetails.Rows(a1).Cells(1).Value
    '                            'ElseIf dgFessDetails.Rows(a1).Cells(1).Value > 0 And dgFessDetails.Rows(a1).Cells(0).Value = "BILLING" Then
    '                            'amount = dgFessDetails.Rows(a1).Cells(1).Value
    '                            'End If
    '                            ' IIf(dgFessDetails.Rows(a1).Cells(1).Value < 0, amount = dgFessDetails.Rows(a1).Cells(1).Value, amount = -1 * dgFessDetails.Rows(a1).Cells(1).Value)
    '                            reference = dgFessDetails.Rows(A1).Cells(2).Value
    '                            curr = "USD"
    '                            cart = dgFessDetails.Rows(A1).Cells(0).Value
    '                            period = dgFessDetails.Rows(A1).Cells(3).Value

    '                            sql2 = " insert into feespayments_details (Receipt,Amount,Currency,Cartegory,Period,Line_number,Reference)" & _
    '                      " values( '" & TextBox2.Text & "' ,'" & amount & "','" & curr & _
    '                      "','" & cart & "','" & period & "','" & A1 + 1 & "','" & reference & "')"
    '                            ExecuteNonQuery(sql2, , True)
    '                            If era = False And A1 = dgFessDetails.Rows.Count - 2 Then

    '                                dgExpenses.Enabled = False
    '                                gbExpenses.Enabled = False
    '                                mblnEdtExp = False

    '                                Dim rec$ = MsgBox("Invoice " & TextBox2.Text & " successfully edited")
    '                                If cboExpenditureSearchCart.Text <> "ALL" Then
    '                                    Me.CreditorsStatementTableAdapter.FillByCartegory(Me.dsIncomeExpenditureReports.CreditorsStatement, goUser.FullName, txtExpCreditor.Text, cboExpenditureSearchCart.Text)
    '                                Else
    '                                    Me.CreditorsStatementTableAdapter.FillByStudAll(Me.dsIncomeExpenditureReports.CreditorsStatement, goUser.FullName, txtExpCreditor.Text)
    '                                End If
    '                                Me.ReportViewer1.RefreshReport()
    '                                ' do you want to print receipt?", MsgBoxStyle.YesNo)

    '                                'If rec <> "6" Then
    '                                '    receiptprnt = False
    '                                'Else
    '                                '    If Trim(Mid(ReceiptTextBox.Text, 1, 4)) <> "inv_" Then
    '                                '        gblnreceipt = True
    '                                '        gstrReceipt = ReceiptTextBox.Text
    '                                '        gblnReceiptCopy = True
    '                                '        frmReportPreview.Show()

    '                                '    Else
    '                                '        gblnreceipt = False
    '                                '        gstrReceipt = ReceiptTextBox.Text
    '                                '        gblnReceiptCopy = True
    '                                '        frmReportPreview.Show()
    '                                '    End If

    '                                'End If



    '                            Else
    '                                If era Then
    'era2:                               'If Not IsNothing(trans) Then trans.Rollback()
    '                                    MsgBox("Failed to Edit Invoice ")
    '                                    Exit Sub


    '                                ElseIf A1 < dgFessDetails.Rows.Count - 2 Then
    '                                    dgExpenses.Enabled = True
    '                                    gbExpenses.Enabled = True
    '                                    mblnEdtExp = True
    '                                End If
    '                            End If
    '                        Next
    '                    End If





    '                End If


    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try



    '        ElseIf mblnDltExp Then

    '            If ComboBox1.Text = "" Then

    '                mblnDltFess = True
    '                MsgBox("Please select reason for expense deletion and press delete/cancel again")
    '                gbFeesPay.Enabled = True
    '                ComboBox1.Enabled = True
    '            Else
    '                sql = " update feespayments_header set status = '0' , cancelledby = '" & goUser.FullName & "',datecancelled = '" & changedate(Now.Date) & "',reasonforreversal = '" & ComboBox1.Text & "'  where receipt = '" & TextBox2.Text & "'"
    '                ExecuteNonQuery(sql)
    '                If era = False Then
    '                    MsgBox("Expense successfully cancelled")
    '                    mblnDltFess = False



    '                    ReasonForReversalComboBox.Enabled = False
    '                    gbFeesPay.Enabled = False

    '                Else
    '                    MsgBox("Error in deleting expense")
    '                    ComboBox1.Enabled = False
    '                    gbExpenses.Enabled = False
    '                End If
    '            End If




    '        End If

    '    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    'Private Sub ToolStripButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton20.Click
    '    If mblnaddinddebtor Then
    '        Dim sql As String
    '        sql = "insert into debtors (name,address,mobilenumber,idnumber,emailaddress) values " & _
    '        " ('" & NameTextBox.Text & "','" & AddressTextBox.Text & "','" & MobileNumberTextBox.Text & "','" & IDnumberTextBox.Text & "', '" & EmailAddressTextBox.Text & "')"
    '        ExecuteNonQuery(sql, True)
    '        If era = False Then
    '            MsgBox("Debtor successfully added")
    '            mblnaddinddebtor = False
    '            BindingNavigator3.Items("Add").Visible = True
    '        Else
    '            MsgBox(eramsg)
    '        End If
    '    Else
    '        Try
    '            Me.Validate()
    '            Me.DebtorsBindingSource.EndEdit()
    '            Me.DebtorsTableAdapter.Update(Me.DsIncomeExpenditure.Debtors)
    '            MsgBox("Save successful")
    '            BindingNavigator3.Items("Add").Visible = True
    '            mblnaddinddebtor = False
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If

    'End Sub

    Private Sub lbDebtors_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        TxtName.Text = txtReceiptSearch.Text
        'search()
        lbDebtors.Visible = False
    End Sub

    Public Sub search()
        Dim debtor$
        Try
            Dim a, b As Integer
            Dim sql2 As String
            Dim searchstring As String
            b = InStr(Trim(TxtName.Text), "-")
            searchstring = Mid(Trim(TxtName.Text), 1, b - 1)
            'TxtName.Text = searchstring
            sql2 = " select [name] from debtors where acc = '" & searchstring & "'"
            debtor = ExecuteScalar(sql2)
            lbDebtorName.Text = debtor
            If Not IsNothing(debtor) Then

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub lbDebtors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        cboReceiptSearch.Text = "Debtor"

    End Sub

    Private Sub txtReceiptSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReceiptSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbDebtors2.Visible = False
        End If
    End Sub

    Private Sub txtReceiptSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReceiptSearch.KeyPress

    End Sub





    Private Sub txtReceiptSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceiptSearch.TextChanged
        If cboReceiptSearch.Text = "Debtor" Then
            lbDebtors2.Items.Clear()
            lbDebtors2.Visible = True
            Dim sql As String
            Dim drr As SqlDataReader
            sql = "select acc,[name] from debtors where cast([acc] as nvarchar) + ' ' +  [name] like '%" & txtReceiptSearch.Text & "%'"
            drr = ExecuteReader(sql)
            If drr.HasRows Then
                While drr.Read
                    lbDebtors2.Items.Add(drr(0).ToString + "-" + drr(1).ToString)
                End While
            End If

            'If lbDebtors2.Items.Count = 1 Then
            '    lbDebtors2.SelectedIndex = 0
            '    lbDebtors2_DoubleClick(Me, Nothing)
            'End If
        ElseIf cboReceiptSearch.Text = "Receipt" Then
            Dim serchtext As String = Trim(txtReceiptSearch.Text)
            lbDebtors2.Items.Clear()
            Dim drr As SqlDataReader

            lbDebtors2.Visible = True
            Dim sql As String = " select receipt,studentid,date from feespayments_header where receipt  like '%" & serchtext & "%'  and status = '1' "
            drr = ExecuteReader(sql)
            Try
                While drr.Read
                    lbDebtors2.Items.Add(drr(0) & "-" & drr(1) & "-" & drr(2))
                End While
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub lbDebtors2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbDebtors2.DoubleClick
        If cboReceiptSearch.Text = "Debtor" Then
            Dim searchstring As String
            Dim b As Integer
            b = InStr(Trim(lbDebtors2.SelectedItem), "-")

            searchstring = Mid(Trim(lbDebtors2.SelectedItem), 1, b - 1)
            txtReceiptSearch.Text = searchstring
            cmbDebtorType.Text = "Registered"

            If Not mblnaddingFess Then
                Try
                    '     Me.FeesPaymentsTableAdapter.FillByStudent(SchoolDataSet.FeesPayments, searchstring)
                Catch ex As Exception

                End Try
            End If

            lbDebtors2.Visible = False
        ElseIf cboReceiptSearch.Text = "Receipt" Then
            Try
                Dim a, b As Integer
                Dim searchstring As String
                b = InStr(Trim(lbDebtors2.SelectedItem), "-")
                searchstring = Mid(Trim(lbDebtors2.SelectedItem), 1, b - 1)
                txtReceiptSearch.Text = searchstring
                '    Me.FeesPaymentsTableAdapter.FillByReceipt(SchoolDataSet.FeesPayments, searchstring)
                lbDebtors2.Visible = False



                'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
                'If a < 0 Then
                '    MsgBox("Student ID could not be found")
                'Else
                '    StudentPersonalDetailsBindingSource.Position = a
                'End If
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub lbDebtors2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbDebtors2.SelectedIndexChanged

    End Sub

    Private Sub cboReceiptSearch_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReceiptSearch.SelectedIndexChanged
        txtReceiptSearch.Clear()
        If cboReceiptSearch.Text = "Date" Then
            txtReceiptSearch.Visible = False
            FeesDateSearch.Visible = True
            lbDebtors2.Visible = False
            '   btnViewStatement.Enabled = False

            Try
                '    Me.FeesPaymentsTableAdapter.FillByDate(SchoolDataSet.FeesPayments, "01/01/1900", cboFeesCartegory.Text)
            Catch ex As Exception

            End Try

        Else

            If cboReceiptSearch.Text = "Debtor" Then
                '  btnViewStatement.Enabled = True
                txtReceiptSearch.Visible = True
                FeesDateSearch.Visible = False

            Else
                '  btnViewStatement.Enabled = True
                txtReceiptSearch.Visible = True
                FeesDateSearch.Visible = False
            End If

        End If

        If cboReceiptSearch.Text = "Receipt" Then

            Try
                Dim a, b As Integer
                Dim searchstring As String
                b = InStr(Trim(lbDebtors2.SelectedItem), "-")
                Try
                    searchstring = Mid(Trim(lbDebtors2.SelectedItem), 1, b - 1)
                Catch ex As Exception
                    searchstring = ""
                End Try

                txtReceiptSearch.Text = searchstring
                '   Me.FeesPaymentsTableAdapter.FillByReceipt(SchoolDataSet.FeesPayments, searchstring)
                lbDebtors2.Visible = False



                'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
                'If a < 0 Then
                '    MsgBox("Student ID could not be found")
                'Else
                '    StudentPersonalDetailsBindingSource.Position = a
                'End If
            Catch ex As Exception

            End Try
        ElseIf cboReceiptSearch.Text = "Debtor" Then
            Try
                Dim a, b As Integer
                Dim searchstring As String
                b = InStr(Trim(lbDebtors2.SelectedItem), "-")
                Try
                    searchstring = Mid(Trim(lbDebtors2.SelectedItem), 1, b - 1)
                Catch ex As Exception
                    searchstring = ""
                End Try

                txtReceiptSearch.Text = searchstring
                '  Me.FeesPaymentsTableAdapter.FillByStudent(SchoolDataSet.FeesPayments, searchstring)
                lbDebtors2.Visible = False



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

    Private Sub TxtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtName.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbDebtors.Visible = False
        End If
    End Sub

    Private Sub TxtName_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged
        If mblnaddingFess Then
            If cmbDebtorType.Text = "Registered" Then




                ' lbDebtors.Visible = True
                ' lbDebtors.Items.Clear()
                '  Dim sql As String = " select cast(acc as nvarchar),name from debtors where [acc] + ' ' + [name] like '%" & TxtName.Text & "%'"
                '  Dim drr As SqlDataReader = ExecuteReader(sql)
                ' If drr.HasRows Then
                'While drr.Read
                'lbDebtors.Items.Add(drr(0).ToString + "-" + drr(1).ToString)
                'End While
                '  End If
            End If

            '''''''''''''''''
            rvDebtStatement.Visible = True



            If cboReceiptSearch.Text = "Debtor" Then
                ' TxtName.Text = txtReceiptSearch.Text

                If lbDebtors.Items.Count > 0 Then
                    lbDebtors.Visible = True
                End If

                If lbDebtors.Items.Count = 1 Then
                    lbDebtors.SelectedIndex = 0
                    lbDebtors_DoubleClick(Me, Nothing)
                End If

                ' SemesterComboBox1.Focus()
            End If



        ElseIf mblnaddingFess = False Then

            lbDebtors.Visible = False
            lbDebtorName.Text = ""

            Dim sql2 As String
            Dim debtor As String

            sql2 = " select [name] from debtors where acc = '" & txtReceiptSearch.Text & "'"
            debtor = ExecuteScalar(sql2)
            lbDebtorName.Text = debtor


            If mblnaddingFess Then
                If cboReceiptSearch.Text = "Debtor" Then
                    TxtName.Text = txtReceiptSearch.Text




                    lbDebtors2.Visible = True
                    ' SemesterComboBox1.Focus()
                End If

            Else
                lbDebtors2.Text = ""
                gbFeesPay.Enabled = False
                dgFessDetails.Enabled = False
                lbDebtors2.Visible = False
                If Trim(cboReceiptSearch.Text) <> "Date" Then
                    Try
                        If Trim(cboFeesCartegory.Text.ToUpper) <> "ALL" Then
                            '   Me.DebtorsTransactionsTableAdapter.FillByOnScreenStatement(Me.dsReports.DebtorsTransactions, "ALL", "ALL", goUser.FullName, "", Trim(TxtName.Text), cboFeesCartegory.Text)
                            rvDebtStatement.Dock = DockStyle.Fill
                            rvDebtStatement.Visible = True
                            rvDebtStatement.RefreshReport()
                        ElseIf Trim(cboFeesCartegory.Text.ToUpper) = "ALL" Then
                            '  Me.DebtorsTransactionsTableAdapter.FillByOnScreenAll(Me.dsReports.DebtorsTransactions, "ALL", "ALL", goUser.FullName, "", Trim(TxtName.Text))
                            rvDebtStatement.Dock = DockStyle.Fill
                            rvDebtStatement.Visible = True
                            rvDebtStatement.RefreshReport()
                        End If
                    Catch ex As Exception

                    End Try
                Else
                    'Me.FeesPaymentsByDateTableAdapter.FillByOnScreen(Me.DsReports.FeesPaymentsByDate, txtReceiptSearch.Text, txtReceiptSearch.Text, "ALL", "ALL", txtReceiptSearch.Text, txtReceiptSearch.Text)
                    'rvOnScreenDatPay.Visible = True
                    'rvOnScreenDatPay.Dock = DockStyle.Fill

                    'rvOnScreenDatPay.RefreshReport()
                End If

                ' rvStudFeesState.Visible = True




            End If



        End If
    End Sub

    Private Sub Del_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Del.Click
        '  Del_Click(Me, Nothing)

    End Sub

    Private Sub lbDebtors_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbDebtors.DoubleClick
        lbDebtors_DoubleClick(Me, Nothing)
    End Sub



    Private Sub ReceiptTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptTextBox.TextChanged
        ReceiptTextBox_TextChanged(Me, Nothing)
    End Sub

    Private Sub Delete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        '  Delete_Click(Me, Nothing)
    End Sub

    Private Sub Reprint_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reprint.Click
        Reprint_Click(Me, Nothing)
    End Sub

    Private Sub Edt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edt.Click
        Edt_Click(Me, Nothing)
    End Sub

    Private Sub rec_import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rec_import.Click
        rec_import_Click(Me, Nothing)
    End Sub



    Private Sub FeesDateSearch_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FeesDateSearch.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    If cboReceiptSearch.Text = "Date" Then
        '        Dim serchtext As String = Trim(FeesDateSearch.Text)
        '        Dim a, b As Integer
        '        Dim searchstring As String
        '        searchstring = FeesDateSearch.Text
        '        txtReceiptSearch.Text = searchstring
        '        Me.FeesPaymentsTableAdapter.FillByDate(SchoolDataSet.FeesPayments, searchstring, cboFeesCartegory.Text)
        '        If FeesPaymentsBindingSource.Count = 0 Then
        '            MsgBox("No receipts Found")
        '        End If



        '    End If
        'End If
    End Sub


    Private Sub Save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        '   Save_Click(Me, Nothing)
    End Sub



    Private Sub dgFessDetails_DataError1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgFessDetails.DataError
    End Sub

    Private Sub cboFeesCartegory_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFeesCartegory.SelectedIndexChanged
        If cboReceiptSearch.Text = "Debtor" Then
            Dim searchstring As String
            Dim b As Integer
            Try
                b = InStr(Trim(lbDebtors2.SelectedItem), "-")

                searchstring = Mid(Trim(lbDebtors2.SelectedItem), 1, b - 1)
                txtReceiptSearch.Text = searchstring
            Catch ex As Exception

            End Try

            If Not mblnaddingFess Then
                Try
                    '   Me.FeesPaymentsTableAdapter.FillByStudent(SchoolDataSet.FeesPayments, txtReceiptSearch.Text)
                Catch ex As Exception

                End Try
            End If

            lbDebtors2.Visible = False
        ElseIf cboReceiptSearch.Text = "Receipt" Then
            Try
                Dim a, b As Integer
                Dim searchstring As String
                b = InStr(Trim(lbDebtors2.SelectedItem), "-")
                searchstring = Mid(Trim(lbDebtors2.SelectedItem), 1, b - 1)
                txtReceiptSearch.Text = searchstring
                '    Me.FeesPaymentsTableAdapter.FillByReceipt(schoolDataSet.FeesPayments, searchstring)
                lbDebtors2.Visible = False



                'a = StudentPersonalDetailsBindingSource.Find("StudentID", searchstring)
                'If a < 0 Then
                '    MsgBox("Student ID could not be found")
                'Else
                '    StudentPersonalDetailsBindingSource.Position = a
                'End If
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Select Case TabControl1.SelectedIndex
            Case 0
                'Save_Click(Me, Nothing)

        End Select
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        loaddatasets()

        '  FeesPayments_Header1TableAdapter.FillByStud(DsFees.FeesPayments_Header1, "")
        'BindingNavigator2.Items("Del").Visible = True
        'BindingNavigator3.Items("Add").Visible = True
        'mblnaddinddebtor = False
        'mblnaddindexp = False
        'mblnaddingFess = False

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub ToolStripButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql, sql2 As String
        Dim recid As String
        Dim recprefix As String
        Dim period As String
        Dim amount As Double
        Dim ref, bilcart As String
        Dim trans As SqlTransaction
        Dim INVDATE As String
        period = cboInvPeriod.SelectedValue

        amount = txtInvAmount.Text
        bilcart = cboInvCart.Text

        recid = GetNextTableID("FeesPayments_header", "invoice", False)



        sql2 = "insert into feespayments_header(StudentID, Date,Receipt,invoice,status,usr,type,postdate) " &
                              "values ('" & txtDebtName.Text & "','" & changedate(mskInvDate.Text) & " ','" & "inv_" & Trim(recprefix) & StrDup(8 - Len(recid), "0") & recid & "','" & "inv_" & Trim(recprefix) & StrDup(8 - Len(recid), "0") & recid & "','1','" & goUser.FullName & "','I','" & changedate(Now.Date) & "')"
        ExecuteNonQuery(sql2, True, , , trans, True, True)




        If Not era Then

            ref = period & "-" & bilcart & "-" & amount & " - " & Now.Date().ToString

            sql2 = " insert into feespayments_details (Receipt,Amount,Currency,Cartegory,Period,Line_number,biltype,reference)" &
           " values( '" & "inv_" & Trim(recprefix) & StrDup(8 - Len(recid), "0") & recid & "' ,'" & amount & "','USD','BILLING ','" & period & "',1,'" & bilcart & "','" & ref & "')"

            ExecuteNonQuery(sql2, True, , , trans, True)
            If era Then
                MsgBox("Error in creating invoice " & eramsg)
                trans.Rollback()
                'sql2 = "delete from feespayments_header where receipt = '" & "inv_" & Trim(recprefix) & StrDup(8 - Len(recid), "0") & recid & "'"
                'ExecuteNonQuery(sql2)

            Else
                INVDATE = changedate(mskInvDate.Text)
                sql2 = "insert into debtorAging (debtor,invoice,balance,invdate,initialamount) values ('" & txtDebtName.Text & "','" & "inv_" & Trim(recprefix) & StrDup(8 - Len(recid), "0") & recid & "','" & amount & "','" & INVDATE & "','" & amount & "') "
                ExecuteNonQuery(sql2, True, , , trans, True)
                If era Then
                    MsgBox("Error in creating invoice " & eramsg)
                    trans.Rollback()

                Else

                    trans.Commit()

                    MsgBox("Invoice successfully created")
                    sql2 = " select balance from "



                End If

            End If
        Else
            MsgBox(eramsg)

        End If
    End Sub

    Private Sub txtDebtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebtName.TextChanged
        lbdebtors3.Visible = True
        lbdebtors3.Items.Clear()
        Dim sql As String = " select acc,name from debtors where cast([acc] as nvarchar) + ' ' + [name] like '%" & txtDebtName.Text & "%'"
        Dim drr As SqlDataReader = ExecuteReader(sql)
        If drr.HasRows Then
            While drr.Read
                lbdebtors3.Items.Add(drr(0).ToString + "-" + drr(1).ToString)
            End While
        End If
    End Sub

    Private Sub lbdebtors3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbdebtors3.DoubleClick
        Dim debtor$
        Try
            Dim a, b As Integer
            Dim sql2 As String
            Dim searchstring As String
            b = InStr(Trim(lbdebtors3.SelectedItem), "-")
            searchstring = Mid(Trim(lbdebtors3.SelectedItem), 1, b - 1)
            txtDebtName.Text = searchstring
            sql2 = " select [name] from debtors where acc = '" & searchstring & "'"
            debtor = ExecuteScalar(sql2)
            Label14.Text = debtor
            If Not IsNothing(debtor) Then

            End If
            lbdebtors3.Visible = False
        Catch ex As Exception

        End Try
    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtDebtName.Text = ""
        txtInvAmount.Text = ""
        lbdebtors3.Visible = False
        Label14.Text = ""

    End Sub




    Private Sub cmbDebtorType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDebtorType.SelectedIndexChanged
        If cmbDebtorType.Text = "OneTime" Then
            txtReceiptSearch.Text = ""

        End If
    End Sub



    Private Sub dgExpences_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub gbFeesPay_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbFeesPay.Enter

    End Sub

    Private Sub dgExpences_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    'Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
    '    Me.Feespayments_details1TableAdapter.FillByReceipt(Me.DsFees1.feespayments_details1, TextBox2.Text)
    'End Sub



    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedTab.Text = "Expenditure" Then
            cboExpSearch.Text = "Creditor"
            cboExpenditureSearchCart.Text = "ALL"
            ' Me.FeesPaymentsTableAdapter.FillByReceipt(SchoolDataSet.FeesPayments, "")
            '  Me.Feespayments_detailsTableAdapter1.FillByReceipt(DsFees.feespayments_details, "ab")


        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delrt.Click
        mblnaddindexp = True
        dgExpenses.Enabled = True
        gbExpenses.Enabled = True
        DateTimePicker1.Value = Now.Date
        BindingNavigator1.Items("Delrt").Visible = False

        If cboExpSearch.Text = "Creditor" Then
            txtExpCreditor.Text = txtExpenditureSearch.Text
            lbExpCreditors.Visible = False
        End If
        'dgExpences.Enabled = True
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub btnAddExpLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim items As ListViewItem
    '    Dim subitems As ListViewItem.ListViewSubItem


    '    If SearchCartegory(Trim(cboExpCart.Text.ToUpper)) Then


    '        items = lvExpenseItems.Items.Add("")
    '        items.Text = cboExpCart.Text
    '        cboExpCart.Text = ""

    '        subitems = items.SubItems.Add("")
    '        subitems.Text = txtExpAmount.Text
    '        txtExpAmount.Text = ""

    '        subitems = items.SubItems.Add("")
    '        subitems.Text = TxtExpRef.Text
    '        TxtExpRef.Text = ""


    '        subitems = items.SubItems.Add("")
    '        subitems.Text = cboExpPeri.SelectedValue
    '        cboExpPeri.Text = ""


    '        subitems = items.SubItems.Add("")
    '        subitems.Text = txtExpComment.Text
    '        txtExpComment.Text = ""


    '    Else
    '        MsgBox("Cartegory Already Present")
    '    End If

    'End Sub
    'Private Function SearchCartegory(ByVal cart As String)
    '    Dim i As Integer
    '    For i = 0 To lvExpenseItems.Items.Count - 1
    '        If lvExpenseItems.Items(i).Text.ToUpper = cart Then
    '            Return False
    '            Exit Function
    '        End If
    '    Next
    '    Return True
    'End Function

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        mblnDltExp = True
        mblnaddindexp = False
        mblnEdtExp = False
        Dim sql As String

        'mblnDlt = True
        Dim res As String = MsgBox("Are you sure you want to cancel the current payment", MsgBoxStyle.YesNoCancel)

        If res = "6" Then
            If ComboBox1.Text = "" Then

                mblnDltFess = True
                MsgBox("Please select reason for payment deletion and press delete/cancel again")
                gbExpenses.Enabled = True
                ComboBox1.Enabled = True


            Else
                sql = " update feespayments_header set status = '0' , cancelledby = '" & goUser.FullName & "',datecancelled = '" & changedate(Now.Date) & "',reasonforreversal = '" & ComboBox1.Text & "'  where receipt = '" & TextBox2.Text & "'"
                ExecuteNonQuery(sql)
                If era = False Then
                    MsgBox("Expense  successfully cancelled")
                    mblnDltExp = False
                    ComboBox1.Enabled = False
                    gbExpenses.Enabled = False


                Else
                    MsgBox("Error in deleting payment")
                    ComboBox1.Enabled = False
                    gbExpenses.Enabled = False
                End If
            End If
        Else
            gbFeesPay.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        mblnEdtExp = True
        mblnaddindexp = False
        mblnDltExp = False
        gbExpenses.Enabled = True
        dgExpenses.Enabled = True

    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FeesPayments_Header1TableAdapter.FillByDate(DsFees.FeesPayments_Header1, MaskedTextBox1.Text)
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    Me.FeesPayments_Header1TableAdapter.FillByDate(Me.DsFees.FeesPayments_Header1, mskExpenseDate.Text)

    End Sub

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        mblnaddinddebtor = True
        BindingNavigator3.Items("Add").Visible = False
    End Sub

    Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton21.Click
        Dim res As String = MsgBox("Are you sure you want to delete the current debtor", MsgBoxStyle.YesNo)
        If res = 6 Then
        Else
            Dim sql As String = "delete from debtors where acc = '" & AccTextBox.Text & "'"
            ExecuteNonQuery(sql, , True)
            If Not era Then
                MsgBox("Delete successfull")

            End If
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim sql As String
        Dim drr As SqlDataReader
        sql = "select acc,[name] from debtors where cast([acc] as nvarchar) + ' ' +  [name] like '%" & txtReceiptSearch.Text & "%'"
        drr = ExecuteReader(sql)
        lbCustomerSearch.Visible = True
        lbCustomerSearch.Items.Clear()
        If drr.HasRows Then
            While drr.Read
                lbCustomerSearch.Items.Add(drr(0).ToString + "-" + drr(1).ToString)
            End While
        End If
    End Sub

    'Private Sub lbCustomerSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbCustomerSearch.DoubleClick
    '    Dim searchstring As String
    '    Dim b As Integer
    '    b = InStr(Trim(lbCustomerSearch.SelectedItem), "-")

    '    searchstring = Mid(Trim(lbCustomerSearch.SelectedItem), 1, b - 1)
    '    TextBox1.Text = searchstring
    '    Try
    '        Me.DebtorsTableAdapter.FillByDebtor(DsIncomeExpenditure.Debtors, searchstring)
    '    Catch ex As Exception

    '    End Try
    '    lbCustomerSearch.Visible = False

    'End Sub


    Private Sub lbCustomerSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbCustomerSearch.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew.Click
        mblnaddingcreditor = True
        BindingNavigator4.Items("AddNew").Visible = False

    End Sub

    'Private Sub ToolStripButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton24.Click
    '    If mblnaddingcreditor Then
    '        Dim sql As String
    '        sql = "insert into creditors (name,address,mobilenumber,idnumber,EmaiAddress,bank,branch,bankaccnt) values " & _
    '        " ('" & NameTextBox1.Text & "','" & AddressTextBox1.Text & "','" & MobileNumberTextBox1.Text & "','" & IDnumberTextBox1.Text & "', '" & EmaiAddressTextBox.Text & "','" & BankTextBox.Text & "','" & BranchTextBox.Text & "','" & BankAccntTextBox.Text & "')"
    '        ExecuteNonQuery(sql, True)
    '        If era = False Then
    '            MsgBox("Creditor successfully added")
    '            mblnaddingcreditor = False
    '            BindingNavigator4.Items("AddNew").Visible = True
    '        Else
    '            MsgBox(eramsg)
    '        End If
    '    Else
    '        Try
    '            Me.Validate()
    '            Me.CreditorsBindingSource.EndEdit()
    '            Me.CreditorsTableAdapter.Update(Me.DsIncomeExpenditure.Creditors)
    '            MsgBox("Save successful")
    '            BindingNavigator4.Items("AddNew").Visible = True
    '            mblnaddingcreditor = False
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    'End Sub

    Private Sub ToolStripButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton25.Click
        Dim res As String = MsgBox("Are you sure you want to delete the current Creditor", MsgBoxStyle.YesNo)
        If res = 6 Then
        Else
            Dim sql As String = "delete from creditors  where acc = '" & AccountTextBox.Text & "'"
            ExecuteNonQuery(sql, , True)
            If Not era Then
                MsgBox("Delete successfull")

            End If
        End If
    End Sub

    Private Sub lbCreditors_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbCreditors.DoubleClick
        Dim creditor$
        Try
            Dim a, b As Integer
            Dim sql2 As String
            Dim searchstring As String
            b = InStr(Trim(lbCreditors.SelectedItem), "-")
            searchstring = Mid(Trim(lbCreditors.SelectedItem), 1, b - 1)
            txtCreditor.Text = searchstring
            sql2 = " select [name] from creditors where account = '" & searchstring & "'"
            creditor = ExecuteScalar(sql2)
            Label24.Text = creditor
            '  If Not IsNothing(creditor) Then


            lbCreditors.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbCreditors.SelectedIndexChanged

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtCreInvDate.MaskInputRejected

    End Sub

    Private Sub txtCreditor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCreditor.TextChanged
        lbCreditors.Visible = True
        lbCreditors.Items.Clear()
        Dim sql As String = " select account,name from creditors where cast([account] as nvarchar) + ' ' + [name] like '%" & txtCreditor.Text & "%'"
        Dim drr As SqlDataReader = ExecuteReader(sql)
        If drr.HasRows Then
            While drr.Read
                lbCreditors.Items.Add(drr(0).ToString + "-" + drr(1).ToString)
            End While
        End If
    End Sub

    Private Sub lbdebtors3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbdebtors3.SelectedIndexChanged

    End Sub

    Private Sub btnCrdInvSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrdInvSave.Click
        Dim sql, sql2 As String
        Dim recid As String
        Dim recprefix As String
        Dim period As String
        Dim amount As Double
        Dim ref, bilcart As String
        Dim trans As SqlTransaction
        Dim INVDATE As String
        Dim crinv As String
        Dim receipt As String



        period = cboCreditorPrd.SelectedValue

        amount = txtCredInvAmnt.Text * -1
        bilcart = cboCreInvCart.Text


        crinv = txtCreditorInv.Text

        recprefix = "CIN_"



        recid = GetNextTableID("FeesPayments_header", "receipt", True, recprefix.Length)
        receipt = Trim(recprefix) & StrDup(8 - Len(recid), "0") & recid



        sql2 = "insert into feespayments_header(StudentID, Date,Receipt,status,usr,type,postdate) " &
                              "values ('" & txtCreditor.Text & "','" & changedate(txtCreInvDate.Text) & " ','" & receipt & "','1','" & goUser.FullName & "','C','" & changedate(Now.Date) & "')"
        ExecuteNonQuery(sql2, True, , , trans, True, True)




        If Not era Then

            ref = txtCreditorInv.Text

            sql2 = " insert into feespayments_details (Receipt,Amount,Currency,Cartegory,Period,Line_number,biltype,reference)" &
           " values( '" & receipt & "' ,'" & amount & "','USD','BILLING ','" & period & "',1,'" & bilcart & "','" & ref & "')"

            ExecuteNonQuery(sql2, True, , , trans, True)
            If era Then
                MsgBox("Error in creating invoice " & eramsg)
                trans.Rollback()
                'sql2 = "delete from feespayments_header where receipt = '" & "inv_" & Trim(recprefix) & StrDup(8 - Len(recid), "0") & recid & "'"
                'ExecuteNonQuery(sql2)

            Else
                'INVDATE = changedate(mskInvDate.Text)
                'sql2 = "insert into debtorAging (debtor,invoice,balance,invdate,initialamount) values ('" & txtDebtName.Text & "','" & "inv_" & Trim(recprefix) & StrDup(8 - Len(recid), "0") & recid & "','" & amount & "','" & INVDATE & "','" & amount & "') "
                ''ExecuteNonQuery(sql2, True, , , trans, True)
                'If era Then
                '    MsgBox("Error in creating invoice " & eramsg)
                '    trans.Rollback()

                'Else

                trans.Commit()

                MsgBox("Invoice successfully created")
                sql2 = " select balance from "



                '  End If

            End If
        Else
            MsgBox(eramsg)

        End If
    End Sub

    'Private Sub txtExpCreditor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExpCreditor.TextChanged
    '    Dim sql As String
    '    Dim drr As SqlDataReader
    '    If mblnaddindexp And txtExpenditureSearch.Text <> "" Then
    '        txtExpCreditor.Text = txtExpenditureSearch.Text
    '        lbExpCreditors.Visible = True
    '        lbExpCreditors.Items.Clear()
    '        sql = " select account ,name from creditors where convert(nvarchar(50),account) + ' ' + name like '%" & txtExpCreditor.Text & "%'"
    '        drr = ExecuteReader(sql, , True)
    '        While drr.Read
    '            lbExpCreditors.Items.Add(drr(0).ToString + "-" + drr(1).ToString)
    '        End While
    '        If lbExpCreditors.Items.Count = 1 Then
    '            lbExpCreditors.SelectedIndex = 0
    '            lbExpCreditors_DoubleClick(Me, Nothing)
    '        End If
    '    End If
    '    If cboExpenditureSearchCart.Text <> "ALL" Then
    '        Me.CreditorsStatementTableAdapter.FillByCartegory(Me.dsIncomeExpenditureReports.CreditorsStatement, goUser.FullName, txtExpCreditor.Text, cboExpenditureSearchCart.Text)
    '    Else
    '        Me.CreditorsStatementTableAdapter.FillByStudAll(Me.dsIncomeExpenditureReports.CreditorsStatement, goUser.FullName, gstrcreditorsCreditor)

    '    End If
    '    Me.ReportViewer1.RefreshReport()
    '    ' End If
    'End Sub

    Private Sub lbExpCreditors_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbExpCreditors.DoubleClick
        Dim b As Integer
        Dim searchstring As String
        b = InStr(Trim(lbExpCreditors.SelectedItem), "-")
        searchstring = Mid(Trim(lbExpCreditors.SelectedItem), 1, b - 1)
        txtExpCreditor.Text = searchstring
        lbExpCreditors.Visible = False
    End Sub


    Private Sub lbExpCreditors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbExpCreditors.SelectedIndexChanged

    End Sub

    Private Sub txtExpenditureSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExpenditureSearch.TextChanged
        If cboExpSearch.Text = "Creditor" Then
            Dim sql As String
            Dim drr As SqlDataReader
            If Not mblnaddindexp Then
                lbExSearchCred.Visible = True
                lbExSearchCred.Items.Clear()
                sql = " select account ,name from creditors where convert(nvarchar(50),account) + ' ' + name like '%" & txtExpenditureSearch.Text & "%'"
                drr = ExecuteReader(sql, , True)

                While drr.Read
                    lbExSearchCred.Items.Add(drr(0).ToString + "-" + drr(1).ToString)
                End While
            End If

        End If
    End Sub

    Private Sub lbExSearchCred_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbExSearchCred.DoubleClick
        Dim b As Integer
        Dim searchstring As String
        b = InStr(Trim(lbExSearchCred.SelectedItem), "-")
        searchstring = Mid(Trim(lbExSearchCred.SelectedItem), 1, b - 1)
        txtExpenditureSearch.Text = searchstring

        Try
            'Me.FeesPayments_Header1TableAdapter.FillByCreditor(DsFees.FeesPayments_Header1, searchstring)
        Catch ex As Exception

        End Try

        lbExSearchCred.Visible = False



    End Sub

    Private Sub lbExSearchCred_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbExSearchCred.SelectedIndexChanged

    End Sub

    'Private Sub cboExpenditureSearchCart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboExpenditureSearchCart.SelectedIndexChanged
    '    If cboExpenditureSearchCart.Text <> "ALL" Then
    '        Me.CreditorsStatementTableAdapter.FillByCartegory(Me.dsIncomeExpenditureReports.CreditorsStatement, goUser.FullName, txtExpCreditor.Text, cboExpenditureSearchCart.Text)
    '    Else
    '        Me.CreditorsStatementTableAdapter.FillByStudAll(Me.dsIncomeExpenditureReports.CreditorsStatement, goUser.FullName, txtExpCreditor.Text)
    '    End If
    '    Me.ReportViewer1.RefreshReport()
    'End Sub
End Class