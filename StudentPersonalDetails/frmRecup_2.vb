
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net
Imports Miscelleneous
Imports System.Data
Public Class frmRecup_2

    Private Sub frmRecup_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cborecupprog
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboRecUpClas
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cborecupCart
            .DataSource = PaymentTypes("schoolfees")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cbpRecUpPeriod
            .DataSource = FeesPaymentPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

    End Sub

    ' Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql, sql2 As String
        Dim drr As SqlDataReader
        Dim file_name2 As String = ""
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
        OpenFileDialog1.FilterIndex = 2

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file_name2 = OpenFileDialog1.FileName
        Else
            Exit Sub
        End If

        Dim theLine As String = ""
        Dim arrSplt() As String
        Dim paytype, amount, level, program, clas, cartegory, period, currency, ref, surname, name As String
        Dim rec_date, pos_date As Date
        Dim oReader As New System.IO.StreamReader(file_name2)
        Dim count As Integer = 0

        Dim sendcount As Integer
        Dim num As New List(Of String)


        While oReader.Peek <> -1
            Try


                theLine = oReader.ReadLine()
                arrSplt = theLine.Split("|")
                surname = Trim(arrSplt(0)).ToUpper
                name = Trim(arrSplt(1)).ToUpper
                ref = Trim(arrSplt(2)).ToUpper
                Date.TryParse(arrSplt(3), rec_date)
                amount = Trim(arrSplt(4))
                paytype = arrSplt(5)
                currency = arrSplt(6)

                period = cbpRecUpPeriod.Text
                pos_date = Now.Date
                clas = cboRecUpClas.Text
                level = cborecupFrm.Text
                program = cborecupprog.Text
                cartegory = cborecupCart.SelectedValue






















            Catch ex As Exception

                sendcount = sendcount + 1
                num.Add(theLine)
            End Try





        End While

        If count > 0 Then
            MsgBox(count & " receipts successfuly imported")
        End If

        If sendcount > 0 Then

            MsgBox(sendcount & " students could not be found in the system choose location below to save students not found")


            OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True
            '   SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                file_name2 = SaveFileDialog1.FileName
                Using objwriter As New StreamWriter(file_name2)
                    For Each stud In num
                        objwriter.WriteLine(stud)

                    Next
                    MsgBox("Save Successful")
                End Using
            End If


        End If

    End Sub


End Class
'End Sub
