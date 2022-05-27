Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net
Imports System.Web.UI.Page
Imports System.Data
Imports Miscelleneous

Public Class dgPeriod

    '    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    '        gblnsinglemsg = False
    '        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    '        gstrperiod = cboPaymentPeriod.SelectedValue.ToString
    '        If gstrperiod = "" Then
    '            MsgBox("No cut-off billing period selected")
    '            Exit Sub
    '        End If
    '        Dim accrow As dsSchool.SMSAccRow
    '        Dim file_name2 As String
    '        Dim sendcount As Integer = 0
    '        Dim num() As String
    '        Dim webrequest As Net.WebRequest
    '        Dim webresponse As Net.WebResponse
    '        Dim webresponsestring As String = ""
    '        Dim number As String
    '        Dim strPassword, strUsername, strMessage As Object
    '        Dim strurl As String
    '        Dim strMobileNumber, strstudmobilenumber, strnokmobilenumber As String
    '        Dim type As Integer = 0
    '        Dim dlr As Integer = 1
    '        Try
    '            accrow = FrmStudent.dsschool.SMSAcc.Rows.Item(0)
    '        Catch ex As Exception
    '            MsgBox("No SMS Account details found contact the systems Administrator")
    '            Exit Sub
    '        End Try

    '        Dim oHttp As New Object
    '        If schoolsections Then
    '            Dim drr As SqlDataReader
    '            Dim sql As String = "select sum(feespayments_details.Amount),[contact number] ,StudentPersonalDetails .StudentID, StudentPersonalDetails.StudentName, StudentPersonalDetails.StudentSurname,nokcontactnumber from feespayments_header inner join " & _
    '           " studentpersonaldetails on feespayments_header.studentid = studentpersonaldetails.studentid " & _
    '           " inner join forms on studentpersonaldetails.program = forms.forms " & _
    '           "inner join feespayments_details on feespayments_header.receipt = feespayments_details.receipt " & _
    '           " inner join PaymentType on Cartegory = PaymentType .Payment " & _
    '            " where forms.section = '" & Trim(FrmStudent.cboSchoolSections.Text) & "' and feespayments_header.studentid not in (select studentid from studentleaving) and period <= '" & Trim(gstrperiod) & "' and paymenttype.type = 'Schoolfees' " & _
    '            " and feespayments_header.status = '1' group by [contact number],StudentPersonalDetails .StudentID, StudentPersonalDetails.StudentName, StudentPersonalDetails.StudentSurname,nokcontactnumber"
    '            drr = ExecuteReader(sql)
    '            sender = InputBox("Enter Sender Id", "Sender", "Myself")

    '            While drr.Read
    '                Dim d As Integer
    '                Try
    '                    strstudmobilenumber = drr(1).ToString
    '                Catch ex As Exception
    '                    strstudmobilenumber = ""
    '                End Try
    '                Try
    '                    strnokmobilenumber = drr(0).ToString
    '                Catch ex As Exception
    '                    strnokmobilenumber = ""
    '                End Try


    '                If FrmStudent.rbStudOnly.Checked Then
    '                    d = InStr(strstudmobilenumber, "+")
    '                    strMobileNumber = Mid(strstudmobilenumber, d + 1)
    '                ElseIf FrmStudent.rbNextOfKinOnly.Checked Then
    '                    d = InStr(strnokmobilenumber, "+")
    '                    strMobileNumber = Mid(strnokmobilenumber, d + 1)
    '                ElseIf FrmStudent.rbBoth.Checked Then
    '                    d = InStr(strstudmobilenumber, "+")
    '                    strstudmobilenumber = Mid(strstudmobilenumber, d + 1)
    '                    d = InStr(strnokmobilenumber, "+")
    '                    strnokmobilenumber = Mid(strnokmobilenumber, d + 1)

    '                    strMobileNumber = strstudmobilenumber + "," + strnokmobilenumber


    '                End If

    '                If strMobileNumber = "" Then
    '                    GoTo debts
    '                End If
    '                Dim senderid As String
    '                strUsername = accrow.UserName
    '                strPassword = accrow.Password
    '                senderid = sender
    '                If drr(0) > 0 Then

    '                    strMessage = "Dear " & drr(3) & " " & drr(4) & " Your SchoolFess Balance is $" & drr(0) & " " & FrmStudent.RichTextBox.Text
    '                Else
    '                    If FrmStudent.chkDebtorsOnly.Checked Then
    '                        GoTo debts
    '                    Else
    '                        strMessage = "Dear " & drr(3) & " " & drr(4) & " Your SchoolFess Balance is $" & drr(0)
    '                    End If
    '                    ' strMessage = "Dear " & drr(3) & " " & drr(4) & " Your SchoolFess Balance is $" & drr(0)
    '                End If
    '                ' oHttp = CreateObject("Microsoft.XMLHTTP")
    '                'strUrl = "http://121.241.242.120:8080/bulksms/bulksms? username = " & strUsername & " & password =" & strPassword & "& type =" & type = 0 & dlr = " & dlr & " & destination = " & strMobileNumber & " & source = " & senderid & " & Message = " & strMessage"
    '                strurl = "http://121.241.242.114:8080/bulksms/bulksms?username=" & strUsername & "&password=" & strPassword & "&type=" & type & "&dlr=" & dlr & "&destination=" & strMobileNumber & "&source=" & senderid & "&message=" & strMessage & ""
    '                Try
    '                    webrequest = Net.HttpWebRequest.Create(Trim(strurl))
    '                    webrequest.Timeout = 25000
    '                Catch ex As Exception
    '                    MsgBox(ex.Message)
    '                    schoolsections = False
    '                    FrmStudent.cboSchoolSections.Enabled = False
    '                    Exit Sub
    '                End Try
    '                Try
    '                    webresponse = webrequest.GetResponse
    '                    Dim reader As IO.StreamReader = New IO.StreamReader(webresponse.GetResponseStream)
    '                    webresponsestring = reader.ReadToEnd
    '                    webresponse.Close()
    '                Catch ex As Exception
    '                    MsgBox(ex.Message)
    '                    schoolsections = False
    '                    FrmStudent.cboSchoolSections.Enabled = False
    '                    Close()
    '                    Exit Sub
    '                End Try
    '                ReDim Preserve num(sendcount)
    '                num(sendcount) = drr(3) & " " & drr(4) & " " & drr(0) & "|"
    '                sendcount += 1
    'debts:      End While
    '            ' schoolsections = False
    '            ' Student.cboSchoolSections.Enabled = False

    '            MsgBox(IIf(sendcount > 0, sendcount & "  messages succesfully sent choose location to save delivery report", "no message sent"))
    '            FrmStudent.OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
    '            FrmStudent.OpenFileDialog1.FilterIndex = 2
    '            FrmStudent.OpenFileDialog1.RestoreDirectory = True
    '            FrmStudent.SaveFileDialog1.ShowDialog()
    '            If FrmStudent.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                file_name2 = FrmStudent.SaveFileDialog1.FileName
    '                Using objwriter As New StreamWriter(file_name2)
    '                    For d1 = 0 To num.Length - 1
    '                        objwriter.Write(num(d1))
    '                        If d1 = num.Length - 1 Then
    '                            MsgBox("Save Successful")
    '                        End If
    '                    Next
    '                End Using
    '            End If
    '        ElseIf panel Then 'Specific students 
    '            Dim a As Integer = FrmStudent.dgClassList.Rows.Count
    '            Dim b, d As Integer
    '            Dim sql As String
    '            Dim drr As Double
    '            Dim senderid As String = InputBox("Enter Prefered Sender ID", "Sender ID", "Our School")
    '            If a = 0 Then
    '                MsgBox("No students found")
    '            End If
    '            For b = 0 To a - 1
    '                If FrmStudent.dgClassList.Rows(b).Selected Then
    '                    sql = "select sum(feespayments_details.amount) from feespayments_details inner join FeesPayments_Header on " & _
    '                    " feespayments_details.receipt = FeesPayments_Header.receipt " & _
    '                    " inner join PaymentType on Cartegory = PaymentType .Payment  " & _
    '                    " where studentid = '" & Trim(FrmStudent.dgClassList.Rows(b).Cells(0).Value) & "' and period <= '" & Trim(gstrperiod) & "'" & _
    '                    " and paymenttype.type = 'SchoolFees' and status = '1' "
    '                    drr = ExecuteScalar(sql)
    '                    strUsername = accrow.UserName
    '                    strPassword = accrow.Password
    '                    senderid = senderid
    '                    Try
    '                        Try
    '                            strstudmobilenumber = FrmStudent.dgClassList.Rows(b).Cells(5).Value
    '                        Catch ex As Exception
    '                            strstudmobilenumber = ""
    '                        End Try
    '                        Try
    '                            strnokmobilenumber = FrmStudent.dgClassList.Rows(b).Cells(6).Value
    '                        Catch ex As Exception
    '                            strnokmobilenumber = ""
    '                        End Try



    '                        'check sending options 

    '                        If FrmStudent.rbStudOnly.Checked Then
    '                            d = InStr(strstudmobilenumber, "+")
    '                            strMobileNumber = Mid(strstudmobilenumber, d + 1)
    '                        ElseIf FrmStudent.rbNextOfKinOnly.Checked Then
    '                            d = InStr(strnokmobilenumber, "+")
    '                            strMobileNumber = Mid(strnokmobilenumber, d + 1)
    '                        ElseIf FrmStudent.rbBoth.Checked Then
    '                            d = InStr(strstudmobilenumber, "+")
    '                            strstudmobilenumber = Mid(strstudmobilenumber, d + 1)
    '                            d = InStr(strnokmobilenumber, "+")
    '                            strnokmobilenumber = Mid(strnokmobilenumber, d + 1)

    '                            strMobileNumber = strstudmobilenumber + "," + strnokmobilenumber

    '                        End If



    '                        If strMobileNumber = "" Then
    '                            GoTo debts2
    '                        End If
    '                    Catch ex As Exception

    '                    End Try
    '                    If drr > 0 Then
    '                        strMessage = "Dear " & Trim(FrmStudent.dgClassList.Rows(b).Cells(1).Value) & " " & Trim(FrmStudent.dgClassList.Rows(b).Cells(2).Value) & " your school fees balance is $" & drr & " " & FrmStudent.RichTextBox.Text
    '                    Else
    '                        If FrmStudent.chkDebtorsOnly.Checked Then
    '                            ' b += 1
    '                            GoTo debts2
    '                        Else
    '                            strMessage = "Dear " & Trim(FrmStudent.dgClassList.Rows(b).Cells(1).Value) & " " & Trim(FrmStudent.dgClassList.Rows(b).Cells(2).Value) & " your school fees balance is $" & drr
    '                        End If
    '                        ' strMessage = "School fees Balanace for " & Trim(dgClassList.Rows(b).Cells(1).Value) & " " & Trim(dgClassList.Rows(b).Cells(2).Value & " is $" & drr)
    '                    End If
    '                    'oHttp = CreateObject("Microsoft.XMLHTTP")
    '                    strurl = "http://121.241.242.114:8080/bulksms/bulksms?username=" & strUsername & "&password=" & strPassword & "&type=" & type & "&dlr=" & dlr & "&destination=" & strMobileNumber & "&source=" & senderid & "&message=" & strMessage & ""
    '                    Try
    '                        webrequest = Net.HttpWebRequest.Create(Trim(strurl))
    '                        webrequest.Timeout = 25000
    '                    Catch ex As Exception
    '                        MsgBox(ex.Message)
    '                        Exit Sub
    '                    End Try

    '                    Try
    '                        webresponse = webrequest.GetResponse
    '                        Dim reader As IO.StreamReader = New IO.StreamReader(webresponse.GetResponseStream)
    '                        webresponsestring = reader.ReadToEnd
    '                        webresponse.Close()
    '                        ' MsgBox(webresponsestring)
    '                    Catch ex As Exception
    '                        MsgBox(ex.Message)
    '                        schoolsections = False
    '                        FrmStudent.cboSchoolSections.Enabled = False
    '                        Close()
    '                        Exit Sub
    '                    End Try



    '                    ReDim Preserve num(sendcount)
    '                    num(sendcount) = strMobileNumber & ", "
    '                    oHttp = Nothing
    '                    If b = a - 1 Then
    '                        Try
    '                            MsgBox(num.Length & " messages successfully sent ")
    '                        Catch ex As Exception
    '                            MsgBox("No message has been sent")
    '                            Exit Sub
    '                        End Try


    '                    End If
    '                    sendcount += 1
    '                Else
    '                    If b = a - 1 Then
    '                        Try
    '                            MsgBox(num.Length & " messages successfully sent ")
    '                        Catch ex As Exception
    '                            MsgBox("No message has been sent")
    '                            Exit Sub
    '                        End Try


    '                    End If
    '                End If
    'debts2:     Next
    '            'schoolsections = False
    '            'Student.cboSchoolSections.Enabled = False


    '        End If
    '        Me.Close()
    '    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        gstrperiod = ""
        Me.Close()
    End Sub

    Private Sub dgPeriod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSchool.PaymentPeriods' table. You can move, or remove it, as needed.
        ' Me.PaymentPeriodsTableAdapter.Fill(Me.DsSchool.PaymentPeriods)
        'TODO: This line of code loads data into the 'DsSchool.PaymentPeriods' table. You can move, or remove it, as needed.
        ' Me.PaymentPeriodsTableAdapter.Fill(Me.DsSchool .PaymentPeriods)

    End Sub

    Private Sub PaymentPeriodsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        '  Me.PaymentPeriodsBindingSource.EndEdit()
        '   Me.TableAdapterManager.UpdateAll(Me.DsSchool)

    End Sub
End Class
