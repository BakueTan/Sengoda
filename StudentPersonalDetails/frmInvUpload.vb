
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net
Imports System.Data
Imports Miscelleneous
Public Class frmInvUpload

    Private Sub frmInvUpload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchoolDataSet.PaymentType2' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql, sql2 As String
        Dim drr As SqlDataReader
        Dim file_name2 As String = ""
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        '  OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file_name2 = OpenFileDialog1.FileName
        Else
            Exit Sub
        End If
        ' Dim oReader As New StreamReader()
        Dim theLine As String = ""
        Dim arrSplt() As String
        Dim Fullname, receipt, paytype, amount, intake, session, level, sem, BILTYPE, studentid, program, clas, cartegory, period, currency, ref, surname, name As String
        Dim rec_date, pos_date As String
        Dim oReader As New System.IO.StreamReader(file_name2)
        Dim count As Integer = 0
        Dim trans As SqlTransaction
        Dim sendcount As Integer
        Dim num() As String
        Dim recid As String




StartPosition: While oReader.Peek <> -1
            theLine = oReader.ReadLine()
            arrSplt = theLine.Split("|")
            Fullname = Trim(arrSplt(1)).ToUpper
            ' receipt = Mid(Trim(arrSplt(1)).ToUpper, 13, 9)
            paytype = ""
            amount = Trim(arrSplt(5))
            '  rec_date = changedate(arrSplt(4))
            rec_date = changedate("01/04/2017")
            clas = cboInvUpClas.Text
            intake = cboInvupintk.Text
            level = cboInvupFrm.Text
            sem = cboInvUpterm.Text
            program = cboInvupprog.Text
            pos_date = changedate(Now.Date)
            cartegory = "BILLING"
            BILTYPE = cboInvupCart.Text
            period = "0"
            currency = "USD"
            ref = "BBF"


            ' Dim POS As Integer = InStr(Fullname, " ")
            surname = Trim(arrSplt(0)).ToUpper
            name = Trim(arrSplt(1)).ToUpper
            sql = "select studentid,program,[year],semester,[status],[year joined  joined] from studentpersonaldetails where rtrim(ltrim(studentsurname)) + '' + rtrim(ltrim(studentname)) like '%" & Trim(surname) & "%" & Trim(name) & "'"
            drr = ExecuteReader(sql)
            Try
                While drr.Read
                    If IsNothing(drr(0)) Then

                        ReDim Preserve num(sendcount)
                        num(sendcount) = Fullname & " "
                        ' MsgBox(Fullname & " could not be found in the system")
                        sendcount = sendcount + 1
                        GoTo StartPosition
                    End If
                    studentid = drr(0)
                    program = drr(1)
                    level = drr(2)
                    
                    sem = drr(3)
                    intake = drr(4)
                    clas = drr(5)



                End While
            Catch ex As Exception
                GoTo StartPosition
            End Try

            ReDim Preserve num(sendcount)
            num(sendcount) = Fullname & " "
            ' MsgBox(Fullname & " could not be found in the system")
            sendcount = sendcount + 1
            GoTo StartPosition




        End While
        If count > 0 Then
            MsgBox(count & " receipts successfully imported")
        End If
        '   Try

        If sendcount > 0 Then

            ' trans.Rollback()
            MsgBox(sendcount & " students could not be found in the system choose location below to save students not found")


            OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True
            'SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                file_name2 = SaveFileDialog1.FileName
                Using objwriter As New StreamWriter(file_name2)
                    For d1 = 0 To num.Length - 1
                        objwriter.WriteLine(num(d1))
                        If d1 = num.Length - 1 Then
                            MsgBox("Save Successful")
                        End If
                    Next
                End Using
            End If


        End If


        '  Catch ex As Exception

        '        End Try


    End Sub
End Class