Imports System.Windows.Forms
Imports System
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Web
Imports System.IO

'Imports System.Windows.Forms
''Imports atlantic_BLL_01
''Imports atlantic_BLL_02
''Imports atlantic_BLL_libAtlantic
Public Module modGeneral


    Public staffreg, studfeesstatement As Boolean

    Public pos As Integer = 0
    Public sessions(1) As String
    Public studs As Integer = 0
    Public staffnumber, staffname, staffsurname, gstrcuttoff As String
    Public temp1(400) As Byte
    Public temp2(400) As Byte
    Public clas, intake, session, level, sem, program As String
    Public cnctera, getinfoera, drawera, nodev_era As Boolean
    Public gstrReceipt As String
    Public sesscollection As String = ""
    Public gblnsinglebil, gblnsinglemsg, gblnsinglesub, gblnsingleliv, gblnsinglemark, studcheckList As Boolean
    Public idinit, genderinit, proginit, yearinit, enrolinit, sessint, seminit, intakeinit, date_enrolinit As String
    Public gblnconfirmUpdate As Boolean = False
    Public goUser As clsUser
    Public gblnaddbookissue, gblnaddbook As Boolean
    Public gstrstudid, gstrstud2, gstrstaffid As String
    Public enteredsupedit As Boolean = False
    Public enteredrepedit As Boolean = False
    Public enteredredoedit As Boolean = False
    Public gblErrorMarks, gblDelMarks As Boolean
    Public gblClassList As Boolean = False
    'Public goCashSale As clsCashSale
    Public garrSaleData(,) As String
    Public gstrCustomPath, gstrCondensedPath, gstrReportPath As String
    Public gstrCompanyName, gstrUserName, gstrCompanyDepoID As String
    Public gstrDepoName, gstrRecPrefix, gstrInvPrefix As String
    Public gstrDebtorPrefix$
    Public gintDPrefixLength%
    Public gstrSystemDate, gstrLastAgedDate As String
    Public gdteSystemDate, gdteLastAgedDate As Date
    Public gintRecPrefLen, gintInvPrefLen As Integer
    Public goCurrentForm As Form
    Public gdtFinYearStart, gdtFinYearEnd As Date
    ''Public goKernel As clsAllDeclarations
    ''Public goMajorDomo As clsMajorDomo
    Public gintTheGroup
    Public gsngDaysToAge As Single
    Public gblnError, gblnCreditSale As Boolean
    Public gstrPayType, gstrCustomerName, gstrCustomerAddress, gstrcashtype, gstruser, gstrCurrency As String
    Public gstridgroup, gstridclass, gstridterm, gstridsess1, gstridsess2, gstridyr1, gstridyr2 As String
    Public gstrpassrateboard, gstrpassrateprog As String
    Public gstrStaffstatus As String
    Public gblnstaffbyType, gblnstaffbydesignation, gblnstaffbycontract, gblnstaffQualByStaff, gblnstaffqualbyqual, gblnSchoolParticulars, gblnSchoolCurricula As Boolean

    Public gblnpassrateperboard, gblnpassrateperpro As Boolean
    Public gblnidbyClass, gblnidbyGroup As Boolean
    Public gdatelogfrm, gdatelogTo As Date
    Public gblnlogdin, gblnbysuer, gblnbydate As Boolean
    Public gstrTelephone, gstrIDNo, gstrChq As String
    Public gstrBankNm, gstraAccNo, gstrDebtorAcc As String
    Public gblnDebtorsExist
    Public gintDebtorsCount
    Public gstrTvSelNod As String, gstrSlectedprog, gstrSlectedStudID As String, gstrSelectedYear As String, gstrSelectedSem, gstrTransRef, gstrTrsnsClass, gstrtransintake As String, transyears As Boolean
    Public gstrSubSlctedStud, gstrSubSlctdYear, gstrSubSlctdSem, gstrSubSlctdProg, gstrsubSlctdClass, gstrSubSlctdSess As String, subyears, rbClassSubs, rbSubSpec As Boolean
    Public gstrSubStudsSlctID, gstrSubStudsSlctdYear, gstrSubStudsSection, gstrstudsubSect, gstrsubstudlvl, gstrsubstudsem, gstrsubstudsess As String
    Public gstrClassStudsSlctProg, gstrClassSection, gstrClassStudsenrol, gstrClassStudsenIntake, gstrClassYr, gstrClassYr2, gsrtClassStudsSem, gstrClassStudsSess, gstrClassStudClass, gstrClassStudsSex, gstrClassStudAgeFrom, gstrClassStudAgeto As String
    Public allsexes As Boolean
    Public gstrSchoolEnrolCls, gstrschoolsection, gstrSchoolEnrolStatus, gstrSchoolEnrolSession, gstrschoolEnrolSemester, gstrknwhowanalprog, gstrknwhowanalclass, gstrknwhowanallevl, gstrknwhowanalsem, gstrknwhowanalintak, gstrknwhowanalsess As String
    Public gdtenrolPeriodAnalysisDatefrom, gdtenrolPeriodAnalysisDateTo As Date
    Public allstatus As Boolean
    Public gstrSubPntEnrol, gstrSubPntSub, gstrStudPersStatus, gstrSubPntIntake, gstrSubPntSect, gstrSubPntSess As String
    Public gstrDetailedMarksProg, gstrDetailedMarksLevel, gstrDetailedMarksClass, gstrDetailedMarksSem, gstrDetailedMarkRef, gstrDetailedMarkSect, gstrTransSumStud, gstrDetailedMarksIntake As String, gblDetRes, gblSumRes, gblDispRes, gblnTransSum, gblnResltStat, gblnResPublish As Boolean
    Public gstrStudContactsSession, gstrcontactsProgram, gstrContactsLevel, gstrContactsSemester, gstrContactsSubject, gstrContactsClass, gstrContactsIntk, gstrcontactssect As String
    Public gstrContSectionChecked, gstrContSubChecked, gstrContClassChecked, gstrAllContacts As Boolean
    Public gstrsubCourseMark, gstrExamMark As String
    Public gblnCancelledMarks As Boolean = False
    Public addforms As Boolean = False
    Public gstrprofilestud, gstrprofileexam, gstrprofileperiod As String
    Public gstrHsMarksProg, gstrHsMarksStud, gstrHsMarksClass, gstrHsMarksLev, gstrHsMarkSess, gstrHsMarkSessto, gstrHsMarksSem, gstrHsMarksRef, gstrHsMarksSub, gstrMarkSection, gstrMarkEmailMsg As String
    Public gblnHsMarksPerClass, gblnHsMarksPerLev, gblnHsMarksPerStud, gblnHsMarksPerSub, gblnHsPublish, gblnReportPerstud, gblnreportPerClass, gblnmailperclass, gblnconsolmarks, gblna4Reports, gblnBookletReports, gblnPublishPerClass, gblnPublishPerExam, gblnPublish, gblnGraphical As Boolean
    Public gstrExamAttExam, gstrExamAttSub As String
    Public gblnAllSubStuds, gblnExamAtt, gblnMarkSheet, gblnCourseWek, gblnPerSubject, gblnPerProgram As Boolean
    Public gstrmarksheetExam, gstrmarksheetProg, gstrmatrksheetintk As String
    Public gstrAccPrgm, gstrAccClass, gstrAccClass2, gstrAccStatus, gstrAccLvl, gstrAccLvl2, gstrAccSem, gstrAccPrdFrom, gstrAccSection, gstrAccPrdTo, gstrAccIntk, gstrAccStud, gstraccAddinfo, gstrAccSess, gstrAccSess2, gstrAccSub, gstrAccBBFCutOffPeriod As String
    Public gblnAccPerClass, gblnAccPerForm, gblnAccDebtors, gblnAccPerSub, gblnAccPerStud, gblnClassStat, gblnSectDebts, gblnDebtorsOnly, gblnShowReceipts, gblnShowInvoices As Boolean
    Public gdatefrom, gdateTo, gpdatefrom, gpdateto As Date
    Public gstrfizpaypfrom, gstrfizpaypto, gstrYearLeft, gstrtermleftfrom, gstrtermleftTo, gstrReasonLeft As String
    Public chckdtaerange As Boolean
    Public gblnFeesDetail, gblnFeesAnalysis, gblnByType, gblnBymode, gblnbyUser As Boolean
    Public addLibMem As Boolean, enrolPeriodAnalysis, clsperiodanalysis, gblnclsAgeAnalysis As Boolean
    Public gstrSubStudsProg, gstrSubStudsCls, gstrSubStudsIntk, gstrSubStudsLvl, gstrSubStudsSem, gstrSubStudsSess As String
    Public gdtdropdSubFrom, gdtdrpsubTo As Date
    Public blnschoolsections, panel, groups As Boolean
    Public gstrKnowHowYear As String
    Public gstrperiod As String = ""
    Public era As Boolean = False
    Public eramsg As String
    Public gstrLectAssLect, gstrLectAssProg, gstrLectAssSub, gstrLectAssYr, gstrLectAssSem, gstrLectAssSess, gstrLectAssIntk, gstrLectAssCls, gstrLectAssSect As String
    Public gstrDeptAssSchool, gstrDeptAssCls, gstrDeptAssIntk, gstrDeptAssSem As String
    Public gblnAllDeptAnal As Boolean = False
    Public gstrLectRatingSect, gstrLectRatingCls, gstrLectRatingIntk As String
    Public gblnBysection As Boolean
    Public gblnStaffAssPerClass, gblnStaffAssPerLect, gblnStaffAssPerSub, gblnStaffAssPerSect As Boolean
    Public gblnDepartmentalAssessment, gblnDepartmentAssessmentDel, gblnLectureAssessmentDel As Boolean
    '  gblnDepartmentalAssessment = false :
    'gblnDepartmentAssessmentDel = false : gblnLectureAssessmentDel = false 
    Public gstrColAvgClas, gstrColAvgIntk As String
    Public gstrSubtotClas, gstrSubtotteacher, gstrSubtotTerm, gstrSubtotSub As String
    Public gblnsubtaughtperteacher, gblnsubtaughtpersubject As Boolean
    Public gstrGeneralAnalClass, gstrGeneralAnalIntk, gstrGeneralAnalSect As String
    Public gstrEnrolFormStud, gstrEnrolFormLvl, gstrEnrolFormSem As String
    Public gstrreg3prog, gstrreg3session, gstrreg3section, gstrreg3class, gstrreg3intake, gstrreg3subject As String
    Public gstrSubRegCls, gstrSubRegIntk, gstrSubRegSub, gstrSubRegSect, gstrSubRegSess, gstrSubRegLvl, gstrSubRegProg, gstrSubRegSem As String
    Public gstrClsRegCls, gstrClsRegForm, gstrClsRegTerm, gstrClsRegSess, gstrClsRegStud As String
    Public gstrstaffregdatefrm, gstrstaffregdateto As Date
    Public gblnstaffregbydate, gblnstaffregbystaff As Boolean
    Public gblnreceipt, gblnReceiptCopy, gblnSubRegPerStud, gblnsubregpersub, gblnClsRegPerDay, gblnClsRegPerCls, gblnClsRegPerStud, gblnhardcopy, receiptprnt, studprnt, lectprnt, enrolform, stmntprnt, clsprint As Boolean
    Public gstrSubRegDateFrom, gstrSubRegDateTo, gstrClsRegDateto, gstrclsregatefrom, gstrSubRegStud, gstrissueno, gstrcreditorsPrdTo, gstrcreditorsPrdfrom As String
    Public rbBookmasterPerbook, rbBookmasterPerLvl, rbBookmasterSummary, rbBookmasterSummaryPerProg, gblnIncExpDetailed, gblnIncExpSummary, rbissuesbybook, rbissuesbyStud, gblnborrowhisPerBook, gblnBorrowhisPerStud, rbissuesbyDate, gblncreditorstatement, gblnAllCreditors, gstraddtitle, lbryissue, gblnOtherDebtors As Boolean
    Public gstrIncExpdatefrm, gstrIncExpdateTo, gstrbookissuefrm, gstrdueby, gstrbookissueTo As Date

    Public gstrIncExpCrt, gstrcreditorsCreditor As String
    Public gstrbookref, gstrborrowhist As String
    Public gblnprntbk As Boolean
    Public studreg As Boolean
    Public sqltext As String
    Public cmd As SqlCommand
    Public cnn As SqlConnection





    Public enrollment As New Enrol()
    Public globaltype As String
    Public mblnaddingperiod, mblnaddingstaffhours, mblnaddinghourlyrate As Boolean

    Public gstrRegisterClassID As String

    Public params As List(Of SqlParameter)
    Public param As SqlParameter

    Public EnrYearSearch, ProgramSearch, EnrLevSearch, EnrSemSearch, EnrSessSearch, EnrIntkSearch As String
    Public gblnClassList, gblnEnrolFrm As Boolean


    Public gblnAllintakes As Boolean



    Public gstrSubtotSect, gstrSubtotIntk As String

    Public gstrEnrolFormprog As String
    Public gstrsubregRegID As String
    Public gstrPaydateFrom, gstrPaydateTo, gstrstaffpaylecturer As String
    Public gstrTimeSheetfrom, gstrTimeSheetTo As String
    Public gstrStaffregfrom, gstrStaffRegto, gstrstaffregtype As String

    Public gstrplanfrom, gstrplanto, gstrplandueby As Date
    Public gblnTimeSheetPerLecturer, gblnTimeSheetPerDay As Boolean
    Public gblnstaffpaypeperiod, gblnstaffpayperlecturer, gblnstaffpayperSection, gblnstaffpayperProgram As Boolean
    Public gstrLectAttPrFrm, gstrLectAttPrTo, gstrLectAttlecturer As String
    Public gblnLectAttpeperiod, gblnLectAttperlecturer As Boolean

    Public osmtpclient As New CSmtp()

    Public classList As New List(Of Enrol)


    Public sql As String

    Public ReadOnly Property CurrentPaymentPeriod() As String
        Get
            Dim period As String = ""
            cnn = New SqlConnection(ConnectionString)
            sql = "select [period] from paymentperiods where [current] = 1"
            Try
                cnn.Open()
                cmd = New SqlCommand(sql, cnn)
                period = cmd.ExecuteScalar
                Return period
            Catch ex As Exception
            Finally
                cnn.Close()
            End Try



            Return period
        End Get
    End Property
    Public Enum EmailType
        ConfirmApplication = 6
        ApplicationSubmitted = 1
        DecisionMade = 5
        StudentAccepted = 3
        StudentDeclined = 4
        StudentIDAssigned = 2
        ApplicationReceived = 7
        OfferAccepted = 8
        ApplicationWithDrawn = 9
    End Enum

    Public Function SendEmail(ByVal stud As Enrol, emailtype As EmailType, Optional ByRef UI As Guid = Nothing, Optional msg As String = "") As Boolean
        Dim SmtpServer As New SmtpClient()
        Dim mail As New MailMessage()
        Dim emailfrom As String = osmtpclient.MailFrom
        Dim password As String = osmtpclient.Password
        Dim messages As SqlDataReader
        'linkmsg = ""
        Dim link As String

        If stud.Email = "" Then
            Return False
        End If

        Dim strmessage As String = ""
        Dim subject As String = ""

        sql = "select [content],description from messages where [type] = '" & emailtype & "'"
        messages = ExecuteReader(sql, , True)

        If msg <> "" Then
            strmessage = msg

        ElseIf messages.HasRows Then
            While messages.Read
                strmessage = messages(0)
                subject = messages(1)
            End While
        Else
            '      Throw New Exception("Messages not maintaned")
            Return False
        End If






        strmessage = "Dear " & stud.FullName & vbNewLine & strmessage


        pos = InStr(Trim(strmessage), "#")
        If pos > 0 Then

            strmessage = Mid(Trim(strmessage), 1, pos - 1) & " " & stud.Student & " " & Mid(Trim(strmessage), (pos + 1))
        End If

        Try
            'Net.NetworkCredential("tangaiwasb@gmail.com", "bothwell")
            SmtpServer.Credentials = New _
        Net.NetworkCredential(emailfrom, password)
            SmtpServer.Port = osmtpclient.Port '587
            SmtpServer.EnableSsl = True
            '  SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.Host = osmtpclient.Server
            mail = New MailMessage()
            mail.From = New MailAddress("btangai@vawsystems.com")
            mail.To.Add(stud.Email)
            If emailtype = EmailType.ConfirmApplication Then
                '   link = "http://192.168.1.4:8000/Student/OnlineApplication/RegConfirm.aspx?Reference=" & UI.ToString
                link = "https://exams.trustacademy.co.zw:444//Student/OnlineApplication/RegConfirm.aspx?Reference=" & UI.ToString
                mail.Subject = subject
                mail.Body = "Please click link below to activate application:  " & vbNewLine & link
            ElseIf emailtype = EmailType.ApplicationSubmitted Then
                mail.Subject = subject
                mail.Body = strmessage
            ElseIf emailtype = EmailType.DecisionMade Then
                mail.Subject = subject
                mail.Body = strmessage

            ElseIf emailtype = EmailType.StudentDeclined Then
                mail.Subject = subject
                mail.Body = strmessage
            ElseIf emailtype = EmailType.StudentIDAssigned Then
                mail.Subject = subject
                mail.Body = strmessage
            ElseIf emailtype = EmailType.StudentAccepted Then
                mail.Subject = subject
                mail.Body = strmessage

            ElseIf emailtype = EmailType.ApplicationReceived Then
                mail.Subject = "Application received"
                mail.Body = strmessage

            ElseIf emailtype = EmailType.ApplicationWithDrawn Then
                mail.Subject = "Application WithDrawn"
                mail.Body = strmessage


            End If

            SmtpServer.Send(mail)
            Return True
            '   errorstatus.Text = ""
        Catch ex As Exception
            '       linkmsg = ex.Message
            Return False
        End Try






    End Function

    Public Function changedate(ByVal dat As String) As String
        Dim arr As String()

        Dim det, month, yr, fulldate As String
        Try

            arr = dat.Split("/")

            yr = arr(2).ToString
            det = arr(0).ToString

            month = arr(1).ToString

            fulldate = yr & "-" & month & "-" & det
            Return fulldate

        Catch ex As Exception

            Return "01-01-01"
        End Try
    End Function
    Public Function changedatetime(ByVal dat As String) As String
        Dim arr As String()

        Dim det, month, yr, yr2, fulldate As String
        Dim tym As String
        Try

            arr = dat.Split("/")

            yr = arr(2).ToString
            det = arr(0).ToString

            month = arr(1).ToString
            arr = yr.Split(" ")
            yr2 = arr(0)
            tym = arr(1)



            fulldate = yr2 & "-" & month & "-" & det & " " & tym

            Return fulldate

        Catch ex As Exception

            Return "01-01-01"
        End Try


    End Function

    Public Function changefulldate(ByVal dat As String) As String
        Dim arr, arr1 As String()

        Dim det, month, yr2, fulldate, tim, yr As String
        Try

            arr = dat.Split("/")

            yr2 = arr(2).ToString
            arr1 = yr2.Split(" ")
            yr = arr1(0)
            tim = arr1(1)
            det = arr(0).ToString

            month = arr(1).ToString

            fulldate = yr & "-" & month & "-" & det & " " & tim
            Return fulldate

        Catch ex As Exception

            Return "01-01-01 00:00:00"
        End Try
    End Function


    Public Function getimage(pic As PictureBox) As Byte()
        '     Dim postedfile As New FileInfo(pic.ImageLocation)

        Dim imgbytes() As Byte = Nothing
        '   If fileextension.ToLower = ".jpg" Or fileextension.ToLower = ".png" Or fileextension.ToLower = ".jpeg" Or fileextension.ToLower = ".bmp" Then
        Dim imgstream As New IO.MemoryStream
        Try
            pic.Image.Save(imgstream, Drawing.Imaging.ImageFormat.Jpeg)
            imgbytes = imgstream.ToArray
        Catch ex As Exception

        End Try


        Return imgbytes
        'Else
        '    Return Nothing
        'End If
    End Function

    Public Function GetCorrectAmt(ByVal txt As String) As Double
        Dim TheAmt As Double = 0
        Dim TheText As String = ""
        Try
            If InStr(txt, "$ ") > 0 Then
                TheText = Mid(txt, 2)
                TheAmt = CDbl(TheText)
            Else
                TheAmt = CDbl(txt)
            End If
        Catch
        End Try
        Return TheAmt
    End Function
    Public Sub Prepareform(ByVal frm As Form, ByVal main As Form, Optional ByVal DoDock As Boolean = True)
        Dim fm As Form = Nothing
        Try
            For Each fm In main.MdiChildren
                fm.Close()
            Next
        Catch
        End Try
        With frm
            .MdiParent = main
            If DoDock Then .Dock = DockStyle.Fill
        End With
    End Sub
    Public Function CamelCase(ByVal Passed$) As String
        Dim TheThing$ = ""
        Dim i, j, k As Integer
        i = 0 : j = 0 : k = 0
        Try
            TheThing = UCase(Mid(Passed, 1, 1))
            TheThing = TheThing + LCase(Mid(Passed, 2))
        Catch
            TheThing = Passed
        End Try
        Return TheThing
    End Function
    ''Private Sub CheckQty()
    ''    Try
    ''        Sql = "SELECT Stk_Quantity FROM dbo.StockItems WHERE Stk_Code ='" & Itm & "'"
    ''        oResult = ExecuteScalar(Sql)
    ''        If Not IsNothing(oResult) Then
    ''            k = CInt(oResult)
    ''            If Val(txtQty.Text) > k Then
    ''                ItsOk = False
    ''                MsgBox("Amount in stock is " & k & " enter a valid amount", MsgBoxStyle.Exclamation, "qauntity too large")
    ''                Exit Sub
    ''            End If
    ''        End If
    ''    Catch ex As Exception
    ''    End Try
    ''End Sub
    'Public Sub RptPreview(ByVal frm As Form, ByVal CloseBtn As System.Windows.Forms.Button, _
    '   ByVal PreviewBtn As System.Windows.Forms.Button, ByVal rpt$, _
    'Optional ByVal Exportable As Boolean = True, _
    'Optional ByVal Dt As DataSet = Nothing, _
    'Optional ByVal DataTable$ = "", _
    'Optional ByVal arrDtSub() As DataSet = Nothing, _
    'Optional ByVal arrDataTableSub$() = Nothing, _
    'Optional ByVal ZoomLevel% = 100, _
    'Optional ByVal Customised As Boolean = False, _
    'Optional ByVal Condensed As Boolean = False, _
    'Optional ByVal Pnl As Panel = Nothing, _
    'Optional ByVal ReportTile$ = "<< Report Preview >>", _
    'Optional ByVal JustPrintItOk As Boolean = False)
    ' Try
    '     Try
    '         If Dt.Tables(DataTable).Rows.Count = 0 Then
    '             MsgBox("no data for the current selection range", MsgBoxStyle.Information, "no data for report")
    '             Exit Sub
    '         End If
    '     Catch ex As Exception
    '     End Try
    '     frm.Cursor = Cursors.WaitCursor
    '     gstrReportPath = My.Application.Info.DirectoryPath & "\Reports\"
    '     goCurrentForm = frm
    '     InitViewer(Pnl, ReportTile)
    '     If Not IsNothing(PreviewBtn) Then PreviewBtn.Visible = False
    '     If Not IsNothing(CloseBtn) Then CloseBtn.Visible = False
    '     ''frm.Hide()
    '     Dim thePath$
    '     If Customised Then
    '         thePath = gstrCustomPath & rpt
    '     Else
    '         If Condensed Then
    '             thePath = gstrCondensedPath & rpt
    '         Else
    '             thePath = gstrReportPath & rpt
    '         End If
    '     End If
    '     Dim Crx As New ReportDocument
    '     Crx.FileName = thePath

    '     Crx.Database.Tables.Item(DataTable).SetDataSource(Dt)

    '     If Not IsNothing(arrDataTableSub) Then
    '         Dim i% = arrDataTableSub.GetUpperBound(0)
    '         Dim j% = 0
    '         For j = 0 To i
    '             Crx.Subreports(arrDataTableSub(j)).SetDataSource(arrDtSub(j))
    '         Next
    '     End If

    '     With gcrvMain
    '         .ReportSource = Crx
    '         If JustPrintItOk Then
    '             Try
    '                 Crx.PrintToPrinter(1, False, 1, 1)
    '                 If IsNothing(Pnl) Then
    '                     frmReportPreview.Close()
    '                 Else
    '                     Pnl.Dispose()
    '                 End If
    '             Catch
    '             End Try
    '         Else
    '             .Dock = DockStyle.Fill
    '             .ShowExportButton = CType(IIf(Exportable, True, False), Boolean)
    '             .Zoom(ZoomLevel)
    '             .Visible = True
    '         End If
    '     End With
    ' Catch ex As Exception
    '     MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error with report data")
    ' End Try
    ' If Not IsNothing(PreviewBtn) Then PreviewBtn.Visible = True
    ' If Not IsNothing(CloseBtn) Then CloseBtn.Visible = True
    ' frm.Cursor = Cursors.Default
    'End Sub


    Public Function TrueDate$(ByVal Dte$, Optional ByVal plsql As Boolean = False, Optional ByVal ABAP As Boolean = False)
        Try
            If plsql Then
                Return Mid(Dte, 8, 4) & "-" & GetMonth(Mid(Dte, 4, 3)) & "-" & Mid(Dte, 1, 2)
            Else
                If ABAP Then
                    Return Mid(Dte, 1, 2) & Mid(Dte, 4, 2) & Mid(Dte, 7, 4)
                Else
                    Return Mid(Dte, 7, 4) & "-" & Mid(Dte, 4, 2) & "-" & Mid(Dte, 1, 2)
                End If
            End If
        Catch ex As Exception
            Return "1900-01-01"
        End Try
    End Function
    Public Function GetVat(ByVal Amt As Double, ByVal Perc As Double, ByVal Incl As Boolean) As Double
        Dim TheVat As Double = 0
        Dim i, j, k As Double
        i = 0 : j = 0 : k = 0
        Try
            If Incl Then
                i = Amt / (1 + (Perc * (0.01)))
                TheVat = Amt - i
            Else
                TheVat = Perc * 0.01 * Amt
            End If
        Catch ex As Exception

        End Try
        Return TheVat
    End Function
    Private Function GetMonth$(ByVal mnth$)
        Dim Num$ = ""
        Select Case LCase(mnth)
            Case "jan"
                Num = "01"
            Case "feb"
                Num = "02"
            Case "mar"
                Num = "03"
            Case "apr"
                Num = "04"
            Case "may"
                Num = "05"
            Case "jun"
                Num = "06"
            Case "jul"
                Num = "07"
            Case "aug"
                Num = "08"
            Case "sep"
                Num = "09"
            Case "oct"
                Num = "10"
            Case "nov"
                Num = "11"
            Case "dec"
                Num = "12"
        End Select
        Return Num
    End Function
    Public Function CleanComboVal$(ByVal theVal$)
        Dim CleanValue$ = " "
        Dim i% = 0, j% = 0
        Try
            i = Len(theVal)
            j = InStr(theVal, "-")
            If j > 1 Then CleanValue = Trim(Mid(theVal, 1, j - 1))
        Catch ex As Exception
            CleanValue = " "
        End Try
        Return CleanValue
    End Function
    Public Function CleanComboVal$(ByVal theVal$, ByVal Left$)
        Dim CleanValue$ = " "
        Dim i% = 0, j% = 0
        Try
            i = Len(theVal)
            j = InStr(theVal, "- ")
            If j > 1 Then CleanValue = Trim(Mid(theVal, j + 1))
        Catch ex As Exception
            CleanValue = " "
        End Try
        Return CleanValue
    End Function
    Public Function GetNextTableID%(ByVal Tbl$, ByVal Fld$, Optional ByVal Prefix% = 0,
                                    Optional ByVal Cdn$ = "", Optional ByVal CastAsInt As Boolean = False,
                                    Optional ByVal planB As Boolean = False, Optional ByVal planC As Boolean = False)
        Dim sql$ = ""
        Dim intResult% = 1
        Dim oResult As Object = Nothing
        Dim StartingPos% = 0
        StartingPos = Prefix + 1
        Try
            If CastAsInt Then
                If Prefix > 0 Then
                    sql = "SELECT ISNULL(MAX(CAST(SUBSTRING(" & Fld & ", " & StartingPos & ", LEN(" & Fld & ") - " & Prefix & " ) AS INTEGER)),0) + 1 FROM " & Tbl
                Else
                    sql = "SELECT ISNULL(MAX(CAST(" & Fld & " AS INTEGER)),0) + 1 FROM " & Tbl
                End If
            Else
                If Prefix > 0 Then
                    sql = "SELECT ISNULL(MAX(CAST(SUBSTRING(" & Fld & ", " & StartingPos & ", LEN(" & Fld & ") - " & Prefix & " ) AS INTEGER)),0) + 1 FROM " & Tbl
                Else
                    sql = "SELECT ISNULL(MAX(" & Fld & "),0) + 1 FROM " & Tbl
                End If
            End If

            sql += Cdn
            oResult = ExecuteScalar(sql, planB, planC)
            If Not IsNothing(oResult) Then
                intResult = CInt(oResult)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error getting next id")
        Finally
            CloseConnection(planB, planC)
        End Try
        Return intResult
    End Function
    Public Function FillSpace(ByVal ValuePassed As String, ByVal Chr As String, ByVal ChrNumber As Integer,
                               ByVal Left As Boolean) As String
        Dim i, j, k As Integer
        Dim ValueReturned As String = ""
        i = 0 : j = 0 : k = 0
        If Left Then
            ValueReturned = StrDup(ChrNumber, Chr) & ValuePassed
            i = Len(ValueReturned)
            j = i - ChrNumber + 1
            If j > 0 Then
                ValueReturned = Mid(ValueReturned, j)
            Else
                ValueReturned = ValuePassed
            End If
        Else
            ValueReturned = ValuePassed & StrDup(ChrNumber, Chr)
            ValueReturned = Mid(ValueReturned, 1, ChrNumber)
        End If
        Return ValueReturned
    End Function
    Public Sub LoadListView(ByVal lst As ListView, ByVal pnl As Panel, ByVal sql$,
                            ByVal NumCols%, Optional ByVal msg$ = "", Optional ByVal DoPlanB As Boolean = False,
                            Optional ByVal DoPlanC As Boolean = False)
        Dim i%
        Dim drR As SqlDataReader
        Dim lstNew As ListViewItem
        Dim lstSub As ListViewItem.ListViewSubItem
        Try
            drR = ExecuteReader(sql, DoPlanB, DoPlanC)
            lst.Items.Clear()
            While drR.Read
                lstNew = lst.Items.Add("")
                lstNew.Text = CType(drR(0), String)
                If NumCols > 1 Then
                    For i = 2 To NumCols
                        lstSub = lstNew.SubItems.Add("")
                        lstSub.Text = CType(drR(i - 1), String)
                    Next
                End If
            End While
            If lst.Items.Count = 0 Then
                If msg <> "" Then
                    MsgBox(msg, MsgBoxStyle.Information, "no data")
                Else
                    MsgBox("no more data to load", MsgBoxStyle.Information, "no more data")
                End If
            Else
                pnl.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error filling list")
        Finally
            CloseConnection(DoPlanB, DoPlanC)
        End Try
    End Sub
    Public Function v(ByVal Tbl$, ByVal KeyFld$, ByVal SoughtFld$, ByVal Val$,
                          ByVal Numerical As Boolean, Optional ByVal PlanB As Boolean = False,
                          Optional ByVal PlanC As Boolean = False) As Object
        Dim oResult As Object = Nothing
        Dim sql$ = ""
        Dim cnt% = 0
        If Numerical Then
            sql = "SELECT " & SoughtFld & " FROM " & Tbl & " WHERE " & KeyFld & " = " & Val
        Else
            sql = "SELECT " & SoughtFld & " FROM " & Tbl & " WHERE " & KeyFld & " = '" & Val & "'"
        End If

        Try
            While cnt < 3
                Try
                    OpenConnection(PlanB, PlanC)
                    PrepareCmdText(sql, , PlanB, PlanC)
                    oResult = gcmdPos.ExecuteScalar()
                    cnt = 3
                Catch
                    cnt += 1
                End Try
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, " error getting value from the table : " & Tbl)
        Finally
            CloseConnection(PlanB, PlanC)
        End Try
        If IsNothing(oResult) Then
            oResult = "-1"
        End If
        Return oResult
    End Function




    Public Function UserLogins(blnShowinactive As Boolean, Optional ByVal blnIncludeAll As Boolean = False) As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)

        cnn = New SqlConnection(ConnectionString)
        Dim users As SqlDataReader

        Try
            cnn.Open()
            sqltext = "spLoadUserLogins"
            cmd = New SqlCommand(sqltext, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@inactive", blnShowinactive)
            users = cmd.ExecuteReader
            If users.HasRows Then

                If blnIncludeAll Then
                    itm = New ComboItem("All", "All")
                    values.Add(itm)
                End If
                While users.Read
                    itm = New ComboItem(users(0), users(0))
                    values.Add(itm)
                End While
            Else
                Return Nothing
            End If

            Return values
        Catch ex As Exception
        Finally
            cnn.Close()

        End Try
    End Function

    Public Function BookLoanTypes() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)



        sql = "select loan from bookloantype "

        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)
        If drr.HasRows Then
            While drr.Read
                itm = New ComboItem(drr(0), drr(0))
                values.Add(itm)
            End While
        Else
            Return Nothing
        End If




        Return values


    End Function
    Public Function Departments() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)



        sql = "select * from deps"

        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)
        If drr.HasRows Then
            While drr.Read
                itm = New ComboItem(drr(0), drr(0))
                values.Add(itm)
            End While
        Else
            Return Nothing
        End If




        Return values


    End Function

    Public Function Programs(Optional query As String = "") As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        Dim sql As String
        If query = "" Then
            sql = "select forms from forms"
        Else
            sql = "select forms from forms where concat(forms,' ',description) like '%" & query & "%'"
        End If

        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)
        If drr.HasRows Then
            While drr.Read
                itm = New ComboItem(drr(0), drr(0))
                values.Add(itm)
            End While
        Else
            Return Nothing
        End If




        Return values


    End Function

    Public Function ProgramSubjects(prog As String) As List(Of ComboItem)

        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)
        params = New List(Of SqlParameter)
        cnn = New SqlConnection(ConnectionString)

        Dim subs As SqlDataReader
        Try


            cnn.Open()
            sqltext = "spGetProgramSubjects"

            cmd = New SqlCommand(sqltext, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            param = New SqlParameter("@prog", prog)
            cmd.Parameters.Add(param)

            subs = cmd.ExecuteReader
            If subs.HasRows Then
                While subs.Read
                    itm = New ComboItem(subs(0), subs(1))
                    values.Add(itm)

                End While
            Else
                values = Nothing

            End If

        Catch ex As Exception
        Finally
            cnn.Close()
        End Try
        Return values
    End Function

    Public Function Exams(Optional ByVal exm As String = "") As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        Dim sql As String
        If Trim(exm) = "" Then
            sql = "select session from examSessions"
        Else
            sql = "select session from examSessions where session like '%" & exm & "%'"
        End If

        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)

        While drr.Read
            itm = New ComboItem(drr(0), drr(0))
            values.Add(itm)
        End While



        Return values


    End Function






    Public Function Ints() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)
        Dim i As Integer = 1

        While i <= 10
            itm = New ComboItem(i, i)
            values.Add(itm)
            i += 1
        End While



        Return values


    End Function

    Public Function Years() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)
        Dim cnter As Integer = Now.Year - 10


        For i = 0 To 11
            itm = New ComboItem(cnter, cnter)
            values.Add(itm)
            cnter += 1
        Next



        Return values
    End Function

    Public Function bools() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        itm = New ComboItem("True", "True")
        values.Add(itm)

        itm = New ComboItem("False", "False")
        values.Add(itm)

        Return values


    End Function


    Public Function Gender() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)





        itm = New ComboItem("F", "F")
        values.Add(itm)

        itm = New ComboItem("M", "M")
        values.Add(itm)

        Return values


    End Function


    Public Function Classes() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        sql = "select ref,description from classes order by clas desc,sem desc  "
        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)



        While drr.Read
            itm = New ComboItem(drr(1), drr(0).ToString)
            values.Add(itm)
        End While





        Return values


    End Function

    Public Function Intakes() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        sql = "select month from months where pos <> 0  order by pos asc  "
        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)



        While drr.Read
            itm = New ComboItem(drr(0), drr(0))
            values.Add(itm)
        End While





        Return values
    End Function

    Public Function Currencies(Optional blnbase As Boolean = False) As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)

        If Not blnbase Then
            sql = "select currency from currencies  "
        Else
            sql = "select isnull(basecurrency,'') from schoolinfo"
        End If

        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)



        While drr.Read
            itm = New ComboItem(drr(0), drr(0))
            values.Add(itm)
        End While





        Return values
    End Function

    Public Function SchoolSections() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        sql = "select section from schoolsections "
        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)



        While drr.Read
            itm = New ComboItem(drr(0), drr(0))
            values.Add(itm)
        End While





        Return values
    End Function

    Public Function ProgramTypes() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        sql = "select progtype from programtype "
        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)



        While drr.Read
            itm = New ComboItem(drr(0), drr(0))
            values.Add(itm)
        End While





        Return values
    End Function


    Public Function SubjectCartegories() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        sql = "select department from deps "
        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)



        While drr.Read
            itm = New ComboItem(drr(0), drr(0))
            values.Add(itm)
        End While





        Return values
    End Function

    Public Function IntValues() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)

        itm = New ComboItem("", "")
        values.Add(itm)
        itm = New ComboItem("1", 1)
        values.Add(itm)

        itm = New ComboItem("2", 2)
        values.Add(itm)
        itm = New ComboItem("3", 3)
        values.Add(itm)
        itm = New ComboItem("4", 4)
        values.Add(itm)
        itm = New ComboItem("5", 5)
        values.Add(itm)



        Return values


    End Function



    Public Function SchoolSessions(Optional blnIncludeAll As Boolean = False) As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        Dim sql As String
        If Not blnIncludeAll Then
            sql = "select session from schoolsessions"
        Else
            sql = "select session from schoolsessions  union Select 'All' order by session asc"
        End If

        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)

        While drr.Read
            itm = New ComboItem(drr(0), drr(0))
            values.Add(itm)
        End While



        Return values


    End Function

    Public Function PaymentTypes(paytype As String) As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        Dim sql As String = "select * from paymenttype where type = '" & paytype & "'"
        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)


        itm = New ComboItem("All", "All")
        values.Add(itm)

        While drr.Read
            itm = New ComboItem(drr("payment"), drr("payment"))
            values.Add(itm)
        End While



        Return values


    End Function

    Public Function CashTypes(Optional ByVal blnIncludeAll As Boolean = False) As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        Dim sql As String

        If blnIncludeAll Then
            sql = "select cashtype from cashtype union select 'All' "
        Else
            sql = "select * from cashtype "
        End If

        Dim drr As SqlDataReader
            drr = ExecuteReader(sql, , True)


            While drr.Read
                itm = New ComboItem(drr("cashtype"), drr("cashtype"))
                values.Add(itm)
            End While



            Return values
    End Function
    Public Sub StudSearch(lb As ListBox, txt As String)
        lb.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Try


            cnn.Open()

            Dim filter As String = " where concat(s.studentid , ' ' , studentname , ' ' , studentsurname) like '%" & txt & "%'"

            cmd.CommandText = "spMainScreenStudentSearch"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)



            lb.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lb.DataSource = dsApps.Tables(0)
            lb.DisplayMember = "StudName"
            lb.ValueMember = "StudentID"

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try

    End Sub

    Public Function FeesPaymentPeriods() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        Dim sql As String = "spLoadFeesPeriods"


        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True,, , False)

        While drr.Read
            itm = New ComboItem(drr("Description"), drr("Period"))
            values.Add(itm)
        End While



        Return values
    End Function

    Public Function Subjects() As List(Of ComboItem)

        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)


        Dim sql As String = "spLoadSubjects"


        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True,, , False)

        While drr.Read
            itm = New ComboItem(drr("Subject"), drr("SubjectID"))
            values.Add(itm)
        End While



        Return values

    End Function

    Public Function SchoolExams(Optional clas As String = "0000-0000-0000-0000") As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)
        params = New List(Of SqlParameter)
        param = New SqlParameter("@classref", clas)
        params.Add(param)

        Dim sql As String = "spSelectExams"


        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True,, params, False)

        While drr.Read
            itm = New ComboItem(drr(0), drr(1).ToString)
            values.Add(itm)
        End While



        Return values


    End Function

    Public Function ChildExams(Optional clas As String = "All") As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)
        params = New List(Of SqlParameter)
        param = New SqlParameter("@classref", clas)
        params.Add(param)

        Dim sql As String = "spSelectChildExams"


        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True,, params, False)

        While drr.Read
            itm = New ComboItem(drr(0), drr(1).ToString)
            values.Add(itm)
        End While



        Return values


    End Function


    Public Function Students() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)



        Dim sql As String = "select s.studentid ,concat(s.studentname,'-',s.studentsurname) as StudName from studentpersonaldetails s inner join enrollment e on s.enrolref = e.enrolref"


        Dim drr As SqlDataReader
        drr = ExecuteReader(sql, , True)

        While drr.Read
            itm = New ComboItem(drr(1), drr(0).ToString)
            values.Add(itm)
        End While



        Return values

    End Function

    Public Function Headmasters() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)
        Dim drr As SqlDataReader

        Dim sql As String = "spLoadHeadmasters"
        cnn = New SqlConnection(ConnectionString)
        cmd = New SqlCommand(sql, cnn)
        cnn.Open()
        cmd.CommandType = CommandType.StoredProcedure

        drr = cmd.ExecuteReader





        While drr.Read
            itm = New ComboItem(drr("name") & " " & drr("Surname"), drr("StaffID"))
            values.Add(itm)
        End While

        Return values
    End Function

    Public Function Boardingmasters() As List(Of ComboItem)
        Dim itm As ComboItem
        Dim values As New List(Of ComboItem)
        Dim drr As SqlDataReader

        Dim sql As String = "spLoadBoardingmasters"
        cnn = New SqlConnection(ConnectionString)
        cmd = New SqlCommand(sql, cnn)
        cnn.Open()
        cmd.CommandType = CommandType.StoredProcedure

        drr = cmd.ExecuteReader





        While drr.Read
            itm = New ComboItem(drr("name") & " " & drr("Surname"), drr("StaffID"))
            values.Add(itm)
        End While

        Return values
    End Function

    Public Function GetTableValue(ByVal Tbl$, ByVal KeyFld$, ByVal SoughtFld$, ByVal Val$,
                         ByVal Numerical As Boolean, Optional ByVal PlanB As Boolean = False,
                         Optional ByVal PlanC As Boolean = False) As Object
        Dim oResult As Object = Nothing
        Dim sql$ = ""
        Dim cnt% = 0
        If Numerical Then
            sql = "SELECT " & SoughtFld & " FROM " & Tbl & " WHERE " & KeyFld & " = " & Val
        Else
            sql = "SELECT " & SoughtFld & " FROM " & Tbl & " WHERE " & KeyFld & " = '" & Val & "'"
        End If

        Try
            While cnt < 3
                Try
                    OpenConnection(PlanB, PlanC)
                    PrepareCmdText(sql, , PlanB, PlanC)
                    oResult = gcmdPos.ExecuteScalar()
                    cnt = 3
                Catch
                    cnt += 1
                End Try
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, " error getting value from the table : " & Tbl)
        Finally
            CloseConnection(PlanB, PlanC)
        End Try
        If IsNothing(oResult) Then
            oResult = "-1"
        End If
        Return oResult
    End Function
End Module

Public Class ComboItem
    Private _text As String
    Private _value As String
    Public Property Text() As String
        Get
            Return _text
        End Get
        Set(ByVal value As String)
            _text = value
        End Set
    End Property
    Public Property Value() As String
        Get
            Return _value
        End Get
        Set(ByVal value As String)
            _value = value
        End Set






    End Property

    Public Overrides Function ToString() As String
        Return _text
    End Function


    Public Sub New(ByVal txt As String, ByVal val As String)
        _text = txt
        _value = val

    End Sub
End Class
