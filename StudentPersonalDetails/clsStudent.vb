Imports System.Data.SqlClient
Imports Miscelleneous

Public Class csStudent

    Private _stud As String
    Public sql As String
    Public cnn As SqlConnection


    Public Property AutoStud As Boolean






    Public erramsg As String = ""


    Private reader As SqlDataReader
    Public isnew As Boolean

    'Peresonal Details 

#Region "Properties"
    Public Property StudentID As String

    Public Property StudentName As String
    Public Property StudentSurname As String
    Public Property Gender As String
    Public Property Dob As Date
    Public Property Pob As String
    Public Property NatId As String

    Public Property Program As String
    Public Property Level As Integer
    Public Property Semester As Integer
    Public Property Intake As String
    Public Property Session As String
    Public Property Dateenrollment As Date
    Public Property Clss As Integer

    Public Property EnrolType As String

    Public Property feessource As String

    'Contact Details

    Public Property Address1 As String
    Public Property Address2 As String
    Public Property Address3 As String
    Public Property EmailAddress As String
    Public Property ContactNumber As String

    'Sponsor 

    Public Property Sponsorname As String
    Public Property SponsorAddres As String
    Public Property SponsorContact As String
    Public Property SponsorRelation As String


    Public Image() As Byte
    Public Property Image64 As String
    Public Property ImageBytes As Byte()
    Public Property FingerPrintBytes As Byte()
    Public Property imagesize As Integer
    Public Property StudImageUrl As String


    'LeavingStud

    Public Property LeavingReason As String
    Public Property DateLeft As String

    Public Property Siblings As List(Of csSiblings)

    Public Property Docs As List(Of csDocs)
    Public Property noks As List(Of StudNok)

    'Medicals 

    Public Property Med_Doctor As String
    Public Property Med_DocContact As String
    Public Property Med_Allergies As String
    Public Property Med_BloodGroup As String
    Public Property Med_Comments As String

    'Xtra Curricular 

    Public Property Xcur_Activities As String
    Public Property Xcur_House As String

    'PreviousSchool 

    Public Property PrevSchool As String
    Public Property PrevSchoolContact As String
    Public Property PrevSchoolComments As String

    'BankingDetails
    Public Property BankName As String
    Public Property BankAccName As String
    Public Property BankAccNumber As String
    Public Property BankBranch As String

    Public enrolref As String

    Public Property StudSubs As List(Of String)

    Public Property ClassDesc As String

    Public Subjets As List(Of csSubjects)

    Public Property SavedStud As String



    Public ReadOnly Property Suffix() As String
        Get
            Dim sufix As String = ""
            sql = "select progsufix from forms where forms = '" & Program & "'"
            sufix = ExecuteScalar(sql,, True)
            Return sufix
        End Get


    End Property
    Public ReadOnly Property Available As Boolean
        Get
            sql = "select *  from studentleaving where studentid =  '" & StudentID & "'"

            reader = ExecuteReader(sql, True)
            While reader.Read
                Return False
            End While

            Return True

        End Get
    End Property

    Public ReadOnly Property GetNextStudID() As String
        Get
            Dim sql As String = ""
            Dim studid As String
            sql = "select dbo.[NextStudentID]('" & ClassDesc & "','" & Program & "')"


            Return ExecuteScalar(sql, True)
        End Get





    End Property





#End Region



    Public Sub New()
        isnew = True


    End Sub

    'Public Function Update(ByVal sect As String, Optional ByVal trans As SqlTransaction = Nothing) As Boolean
    '    Dim param As SqlParameter
    '    Dim params As List(Of SqlParameter)
    '    Select Case sect
    '        Case const_persdetails
    '            params = New List(Of SqlParameter)
    '            sql = "spUpdateStudPersonalDetails"


    '            param = New SqlParameter("@stud", StudentID)
    '            params.Add(param)

    '            param = New SqlParameter("@studname", StudentName)
    '            params.Add(param)

    '            param = New SqlParameter("@studSurname", StudentSurname)
    '            params.Add(param)


    '            param = New SqlParameter("@gender", Gender)
    '            params.Add(param)


    '            param = New SqlParameter("@dob", Dob)
    '            params.Add(param)

    '            param = New SqlParameter("@pob", Pob)
    '            params.Add(param)



    '            param = New SqlParameter("@natid", NatId)
    '            params.Add(param)

    '            param = New SqlParameter("@feessource", feessource)
    '            params.Add(param)



    '            If Not IsNothing(trans) Then
    '                ExecuteNonQuery(sql,, True,, trans, True)
    '                If era Then
    '                    erramsg = eramsg

    '                    trans.Rollback()
    '                Else

    '                    trans.Commit()
    '                End If


    '            Else


    '                ExecuteNonQuery(sql,, True,,,,, params, False)
    '                If era Then
    '                    erramsg = eramsg
    '                    Return False
    '                Else
    '                    CloseConnection(, True)
    '                    Return True
    '                End If
    '            End If
    '        Case const_contdetails


    '            sql = "update studentpersonaldetails set [residentialadress] ='" & Address1 & "',address2 = '" & Address2 & "',address3 = '" & Address3 & "' ,[contactnumber]  = '" & ContactNumber & "',emailaddress = '" & EmailAddress & "' where studentid = '" & StudentID & "'"

    '            If Not IsNothing(trans) Then
    '                ExecuteNonQuery(sql,, True,, trans, True)
    '                If era Then
    '                    eramsg = erramsg

    '                    trans.Rollback()
    '                Else

    '                    trans.Commit()
    '                End If


    '            Else


    '                ExecuteNonQuery(sql,, True)
    '                If era Then
    '                    erramsg = eramsg
    '                    Return False
    '                Else
    '                    Return True
    '                End If
    '            End If
    '        Case const_enroldetails
    '            '          sql = "update studentpersonaldetails  set program = '" & Program & "' ,year = '" & Level & "',gender = '" & Gender & "',session = '" & Session & "',date_enrolled = '" & Dateenrollment.ToShortDateString & "',enroltype = '" & EnrolType & "', classdesc = '" & ClassDesc & "' where studentid = '" & StudentID & "'"
    '            sql = "spUpdateStudEnrollmentDetails"

    '            params = New List(Of SqlParameter)

    '            param = New SqlParameter("@stud", StudentID)
    '            params.Add(param)

    '            param = New SqlParameter("@prog", Program)
    '            params.Add(param)

    '            param = New SqlParameter("@lvl", Level)
    '            params.Add(param)

    '            param = New SqlParameter("@gender", Gender)
    '            params.Add(param)

    '            param = New SqlParameter("@datenrol", Dateenrollment)
    '            params.Add(param)

    '            param = New SqlParameter("@classdesc", ClassDesc)
    '            params.Add(param)

    '            param = New SqlParameter("@sess", Session)
    '            params.Add(param)


    '            param = New SqlParameter("@enroltype", EnrolType)
    '            params.Add(param)


    '            If Not IsNothing(trans) Then
    '                ExecuteNonQuery(sql,, True,, trans, True)
    '                If era Then
    '                    erramsg = eramsg

    '                    trans.Rollback()
    '                Else

    '                    trans.Commit()
    '                End If


    '            Else


    '                ExecuteNonQuery(sql,, True,,,,, params, False)
    '                If era Then
    '                    erramsg = eramsg

    '                    Return False
    '                Else
    '                    CloseConnection(, True)
    '                    Return True
    '                End If
    '            End If
    '        Case const_sponsordetails
    '            sql = "update studentpersonaldetails set nokname ='" & Sponsorname & "',relationship = '" & SponsorRelation & "',nokaddress= '" & SponsorAddres & "' ,nokcontactnumber = '" & SponsorContact & "' where studentid = '" & StudentID & "'"

    '            If Not IsNothing(trans) Then
    '                ExecuteNonQuery(sql,, True,, trans, True)
    '                If era Then
    '                    eramsg = erramsg

    '                    trans.Rollback()
    '                Else

    '                    trans.Commit()
    '                End If


    '            Else


    '                ExecuteNonQuery(sql,, True)
    '                If era Then
    '                    erramsg = eramsg
    '                    Return False
    '                Else
    '                    Return True
    '                End If
    '            End If

    '        Case const_PrevSchooldetails
    '            params = New List(Of SqlParameter)
    '            sql = "spUpdateStudPrevSchoolDetails"
    '            param = New SqlParameter("@stud", StudentID)
    '            params.Add(param)
    '            param = New SqlParameter("@schoolname", PrevSchool)
    '            params.Add(param)
    '            param = New SqlParameter("@schoolcontact", PrevSchoolContact)
    '            params.Add(param)
    '            param = New SqlParameter("@schoolcomments", PrevSchoolComments)
    '            params.Add(param)








    '            If Not IsNothing(trans) Then
    '                ExecuteNonQuery(sql,, True,, trans, True,, params, False)
    '                If era Then
    '                    erramsg = eramsg

    '                    trans.Rollback()
    '                    Return False
    '                Else

    '                    trans.Commit()
    '                    Return True
    '                End If


    '            Else


    '                ExecuteNonQuery(sql,, True,,,,, params, False)
    '                If era Then
    '                    erramsg = eramsg
    '                    Return False
    '                Else
    '                    Return True
    '                End If
    '            End If
    '        Case const_Medicaldetails
    '            params = New List(Of SqlParameter)
    '            sql = "spUpdateStudMedicalDetails"
    '            param = New SqlParameter("@stud", StudentID)
    '            params.Add(param)
    '            param = New SqlParameter("@doc", Med_Doctor)
    '            params.Add(param)
    '            param = New SqlParameter("@doccontact", Med_DocContact)
    '            params.Add(param)
    '            param = New SqlParameter("@bloodgroup", Med_BloodGroup)
    '            params.Add(param)

    '            param = New SqlParameter("@allergies", Med_Allergies)
    '            params.Add(param)

    '            param = New SqlParameter("@medcomments", Med_Comments)
    '            params.Add(param)






    '            If Not IsNothing(trans) Then
    '                ExecuteNonQuery(sql,, True,, trans, True,, params, False)
    '                If era Then
    '                    eramsg = erramsg

    '                    trans.Rollback()
    '                    Return False
    '                Else

    '                    trans.Commit()
    '                    Return True
    '                End If


    '            Else


    '                ExecuteNonQuery(sql,, True,,,,, params, False)
    '                If era Then
    '                    erramsg = eramsg
    '                    Return False
    '                Else
    '                    Return True
    '                End If
    '            End If

    '        Case const_Bankingdetails
    '            params = New List(Of SqlParameter)
    '            sql = "spUpdateStudBankingDetails"
    '            param = New SqlParameter("@stud", StudentID)
    '            params.Add(param)
    '            param = New SqlParameter("@bankname", BankName)
    '            params.Add(param)
    '            param = New SqlParameter("@bankaccname", BankAccName)
    '            params.Add(param)
    '            param = New SqlParameter("@bankaccnumber", BankAccNumber)
    '            params.Add(param)

    '            param = New SqlParameter("@bankbranch", BankBranch)
    '            params.Add(param)
    '            If Not IsNothing(trans) Then
    '                ExecuteNonQuery(sql,, True,, trans, True,, params, False)
    '                If era Then
    '                    eramsg = erramsg

    '                    trans.Rollback()
    '                    Return False
    '                Else

    '                    trans.Commit()
    '                    Return True
    '                End If


    '            Else


    '                ExecuteNonQuery(sql,, True,,,,, params, False)
    '                If era Then
    '                    erramsg = eramsg
    '                    Return False
    '                Else
    '                    Return True
    '                End If
    '            End If

    '        Case const_XtraCurricular
    '            params = New List(Of SqlParameter)
    '            sql = "SpUpdateXtraCurricular"
    '            param = New SqlParameter("@activities", Xcur_Activities)
    '            params.Add(param)

    '            param = New SqlParameter("@house", Xcur_House)
    '            params.Add(param)

    '            param = New SqlParameter("@stud", StudentID)
    '            params.Add(param)

    '            If Not IsNothing(trans) Then
    '                ExecuteNonQuery(sql,, True,, trans, True,, params, False)
    '                If era Then
    '                    eramsg = erramsg

    '                    trans.Rollback()
    '                    Return False
    '                Else

    '                    trans.Commit()
    '                    Return True
    '                End If


    '            Else


    '                ExecuteNonQuery(sql,, True,,,,, params, False)
    '                If era Then
    '                    erramsg = eramsg
    '                    Return False
    '                Else
    '                    Return True
    '                End If
    '            End If




    '        Case const_image
    '            If imagesize > 2000000 Then
    '                erramsg = "Image Size too big ,Limit is 2MB"
    '                Return False
    '            End If
    '            sql = "update studentpersonaldetails set image = @img,studimageurl = @studimageurl where studentid ='" & StudentID & "'"

    '            Dim parameters As New List(Of SqlParameter)

    '            param = New SqlParameter("@img", SqlDbType.Image)

    '            If Not IsNothing(ImageBytes) Then
    '                param.Value = ImageBytes
    '            Else
    '                param.Value = DBNull.Value
    '            End If

    '            parameters.Add(param)

    '            param = New SqlParameter("@StudImageUrl", StudImageUrl)
    '            parameters.Add(param)

    '            If Not IsNothing(trans) Then
    '                ExecuteNonQuery(sql,, True,, trans, True,, parameters)

    '                If era Then
    '                    erramsg = eramsg
    '                    trans.Rollback()
    '                    Return False
    '                Else
    '                    trans.Commit()
    '                    Return True
    '                End If
    '            Else
    '                ExecuteNonQuery(sql,, True,,,,, parameters)

    '                If era Then
    '                    erramsg = eramsg
    '                    Return False
    '                Else
    '                    Return True
    '                End If
    '            End If

    '        Case ""
    '            If IsNothing(trans) Then
    '            Else
    '                trans.Commit()
    '            End If


    '    End Select
    'End Function
    'Public Sub DeleteEnrollment(ByVal enrol As enrollment)
    '    Dim sql As String
    '    sql = "Delete enrollment where = studentid = '" & enrol.StudentID & "' and program = '" & enrol.Program & "' and year = '" & enrol.Year & "' and  session = '" & enrol.Session & "' "
    '    ExecuteNonQuery(sql,, True)
    '    If era Then
    '        erramsg = eramsg
    '    End If



    'End Sub

    Public Function LeavingStudent() As Boolean

        sql = "insert into studentleaving (studentid,reason,dateleft) values('" & StudentID & "' ,'" & LeavingReason & "','" & DateLeft & "')"

    End Function




    Public Function Save() As Boolean


        Dim parameters As List(Of SqlParameter)
            Dim param As SqlParameter
        Dim trans As SqlTransaction

        Dim Studref As String

        If isnew Then
            Studref = Guid.NewGuid.ToString
        Else
            Studref = enrolref

        End If




        Dim cnn As New SqlConnection(ConnectionString)


        Try
            cnn.Open()

            trans = cnn.BeginTransaction


            Dim cmd As New SqlCommand("spInsertStud", cnn, trans)
            cmd.CommandType = CommandType.StoredProcedure

            parameters = New List(Of SqlParameter)

            param = New SqlParameter("@img", SqlDbType.Image)
            If Not IsNothing(ImageBytes) Then
                param.Value = ImageBytes
            Else
                param.Value = DBNull.Value
            End If

            parameters.Add(param)

            param = New SqlParameter("@fingerprint", SqlDbType.Image)
            If Not IsNothing(FingerPrintBytes) Then
                param.Value = FingerPrintBytes
            Else
                param.Value = DBNull.Value
            End If
            parameters.Add(param)

            param = New SqlParameter("@studid", StudentID)
            parameters.Add(param)
            param = New SqlParameter("@gender", Gender)
            parameters.Add(param)
            param = New SqlParameter("@studname", StudentName)
            parameters.Add(param)
            param = New SqlParameter("@studsurname", StudentSurname)
            parameters.Add(param)
            param = New SqlParameter("@program", Program)
            parameters.Add(param)
            param = New SqlParameter("@year", Level)
            parameters.Add(param)

            param = New SqlParameter("@session", Session)
            parameters.Add(param)

            param = New SqlParameter("@enroltype", EnrolType)
            parameters.Add(param)
            param = New SqlParameter("@dob", Dob)
            parameters.Add(param)
            param = New SqlParameter("@pob", Pob)
            parameters.Add(param)
            param = New SqlParameter("@natid", NatId)
            parameters.Add(param)
            param = New SqlParameter("@address1", Address1)
            parameters.Add(param)
            param = New SqlParameter("@contnumber", ContactNumber)
            parameters.Add(param)
            param = New SqlParameter("@emailadd", EmailAddress)
            parameters.Add(param)


            param = New SqlParameter("@address2", Address2)
            parameters.Add(param)
            param = New SqlParameter("@address3", Address3)
            parameters.Add(param)
            param = New SqlParameter("@dateenrolled", Dateenrollment)
            parameters.Add(param)
            param = New SqlParameter("@feessource", feessource)
            parameters.Add(param)
            param = New SqlParameter("@meddoctor", Med_Doctor)
            parameters.Add(param)
            param = New SqlParameter("@docContact", Med_DocContact)
            parameters.Add(param)
            param = New SqlParameter("@allergies", Med_Allergies)
            parameters.Add(param)
            param = New SqlParameter("@bloodgroup", Med_BloodGroup)
            parameters.Add(param)
            param = New SqlParameter("@medcomments", Med_Comments)
            parameters.Add(param)
            param = New SqlParameter("@xcurActivities", Xcur_Activities)
            parameters.Add(param)
            param = New SqlParameter("@xcurHouse", Xcur_House)
            parameters.Add(param)
            param = New SqlParameter("@prevschool", PrevSchool)
            parameters.Add(param)
            param = New SqlParameter("@prevSchoolContact", PrevSchoolContact)
            parameters.Add(param)

            param = New SqlParameter("@prevSchoolComment", PrevSchoolComments)
            parameters.Add(param)

            param = New SqlParameter("@bankname", BankAccName)
            parameters.Add(param)
            param = New SqlParameter("@bankaccname", BankAccName)
            parameters.Add(param)
            param = New SqlParameter("@bankaccnumber", BankAccNumber)
            parameters.Add(param)
            param = New SqlParameter("@bankbranch", BankBranch)

            parameters.Add(param)
            param = New SqlParameter("@studImageurl", StudImageUrl)
            parameters.Add(param)


            param = New SqlParameter("@classdesc", ClassDesc)
            parameters.Add(param)

            param = New SqlParameter("@user", goUser.userName)
            parameters.Add(param)

            param = New SqlParameter("@enrolref", Studref)
            parameters.Add(param)


            '      parameters.Add(param)


            For Each par As SqlParameter In parameters
                cmd.Parameters.Add(par)
            Next

            param = New SqlParameter()
            param.ParameterName = "@savedstud"
            param.Direction = ParameterDirection.Output
            param.DbType = DbType.String
            param.Size = 50
            cmd.Parameters.Add(param)

            cmd.ExecuteNonQuery()
            Try
                SavedStud = cmd.Parameters("@savedstud").Value
            Catch ex As Exception
                SavedStud = ""
            End Try





            If Siblings.Count > 1 And isnew Then





                For Each siblin As csSiblings In Siblings
                    cmd = New SqlCommand("spInsertSibling", cnn) With {
                        .Transaction = trans
                    }
                    cmd.CommandType = CommandType.StoredProcedure
                    parameters = New List(Of SqlParameter)
                    param = New SqlParameter("@stud", savedstud)
                    parameters.Add(param)
                    param = New SqlParameter("@sibling", siblin.Sibling)
                    parameters.Add(param)
                    param = New SqlParameter("@new", 1)
                    parameters.Add(param)

                    For Each par As SqlParameter In parameters
                        cmd.Parameters.Add(par)
                    Next

                    cmd.ExecuteNonQuery()
                Next
            End If



            If Docs.Count > 1 And isnew Then

                For Each doc In Docs

                    sql = "spInsertDoc"
                    cmd = New SqlCommand(sql, cnn) With {
                        .Transaction = trans
                    }

                    cmd.CommandType = CommandType.StoredProcedure
                    parameters = New List(Of SqlParameter)
                    param = New SqlParameter("@stud", savedstud)
                    parameters.Add(param)

                    param = New SqlParameter("@docname", doc.Filename)
                    parameters.Add(param)

                    param = New SqlParameter("@doc", doc.Doc)
                    parameters.Add(param)

                    param = New SqlParameter("@filetype", doc.FileType)
                    parameters.Add(param)

                    param = New SqlParameter("@filesize", doc.filesize)
                    parameters.Add(param)
                    For Each par As SqlParameter In parameters
                        cmd.Parameters.Add(par)
                    Next

                    cmd.ExecuteNonQuery()


                Next
            End If


            If noks.Count > 1 And isnew Then
                For Each NOK In noks

                    sql = "spInsertStudNok"

                    cmd = New SqlCommand(sql, cnn) With {
                        .Transaction = trans
                    }
                    cmd.CommandType = CommandType.StoredProcedure
                    parameters = New List(Of SqlParameter)
                    With NOK

                        param = New SqlParameter("@stud", savedstud)
                        parameters.Add(param)
                        param = New SqlParameter("@nokname", .Nok_Name)
                        parameters.Add(param)
                        param = New SqlParameter("@noksurname", .Nok_Surname)
                        parameters.Add(param)
                        param = New SqlParameter("@nokrelation", .Nok_RelationShip)
                        parameters.Add(param)
                        param = New SqlParameter("@nokaddress", .Nok_Address)
                        parameters.Add(param)
                        param = New SqlParameter("@nokcontact", .Nok_Contact)
                        parameters.Add(param)
                        param = New SqlParameter("@nokemail", .Nok_Email)
                        parameters.Add(param)
                        param = New SqlParameter("@nokjobtitle", .Nok_Employment)
                        parameters.Add(param)
                        param = New SqlParameter("@nokemployer", .Nok_Employer)
                        parameters.Add(param)
                        param = New SqlParameter("@nokemployercontact", .Nok_EmployerContact)
                        parameters.Add(param)
                        param = New SqlParameter("@nokemployerAddress", .Nok_EmployerAddress)
                        parameters.Add(param)
                        param = New SqlParameter("@nokEmployerEmail", .Nok_EmployerEmail)
                        parameters.Add(param)
                        param = New SqlParameter("@refid", .Nok_refid)
                        parameters.Add(param)
                        For Each par As SqlParameter In parameters
                            cmd.Parameters.Add(par)
                        Next

                        cmd.ExecuteNonQuery()




                    End With

                Next
            End If




            trans.Commit()
            enrolref = Studref.ToString

            Return True


        Catch ex As Exception
            erramsg = ex.Message
            trans.Rollback()
            Return False
        Finally
            cnn.Close()

        End Try









    End Function
    Public Sub New(stud As String)

        isnew = False
        _stud = stud
        '   StudentID = stud
        SearchStud()

    End Sub




    Public Sub SearchStud()
        Try
            sql = "  Select * From studentpersonaldetails where studentid = '" & _stud & "'"
            reader = ExecuteReader(sql,, True)



            While reader.Read

                Try
                    StudentID = reader("StudentId")
                Catch ex As Exception
                    StudentID = ""
                End Try

                Try
                    StudentName = reader("StudentName")
                Catch ex As Exception
                    StudentName = ""
                End Try

                Try
                    StudentSurname = reader("StudentSurname")
                Catch ex As Exception
                    StudentSurname = ""
                End Try


                Try
                    Gender = reader("gender")
                Catch ex As Exception

                End Try

                Try
                    feessource = reader("feessource")
                Catch ex As Exception
                    feessource = ""
                End Try

                Try
                    Dob = reader("dateofbirth")
                Catch ex As Exception
                    Dob = "2001-01-01"

                End Try
                Try
                    Pob = reader("placeofbirth")
                Catch ex As Exception
                    Pob = ""
                End Try
                Program = reader("Program")
                Session = reader("session")

                Level = reader("year")

                Try
                    Dateenrollment = reader("date_enrolled")
                Catch ex As Exception

                End Try


                Try
                    EnrolType = reader("enroltype")
                Catch ex As Exception
                    EnrolType = ""
                End Try

                Try
                    Address1 = reader("ResidentialAdress")
                Catch ex As Exception
                    Address1 = ""
                End Try

                Try
                    Address2 = reader("Address2")
                Catch ex As Exception
                    Address2 = ""
                End Try

                Try
                    Address3 = reader("Address3")
                Catch ex As Exception
                    Address3 = ""
                End Try

                Try
                    ContactNumber = reader("ContactNumber")
                Catch ex As Exception
                    ContactNumber = ""
                End Try

                Try
                    EmailAddress = reader("EmailAddress")
                Catch ex As Exception
                    EmailAddress = ""
                End Try

                If Not IsDBNull(reader("nokname")) Then
                    Sponsorname = reader("nokname")
                Else
                    Sponsorname = ""
                End If

                If Not IsDBNull(reader("nokcontactnumber")) Then
                    SponsorContact = reader("nokcontactnumber")
                Else
                    SponsorContact = ""
                End If
                If Not IsDBNull(reader("nokaddress")) Then
                    SponsorAddres = reader("nokaddress")
                Else
                    SponsorAddres = ""
                End If
                If Not IsDBNull(reader("relationship")) Then
                    SponsorRelation = reader("relationship")
                Else
                    SponsorRelation = ""
                End If


                If Not IsDBNull(reader("NationalID")) Then
                    NatId = reader("NationalID")
                Else
                    NatId = ""
                End If

                If Not IsDBNull(reader("prevschool")) Then
                    PrevSchool = reader("prevschool")
                Else
                    PrevSchool = ""
                End If

                If Not IsDBNull(reader("prevschContact")) Then
                    PrevSchoolContact = reader("prevschContact")
                Else
                    PrevSchoolContact = ""
                End If

                If Not IsDBNull(reader("prevschComment")) Then
                    PrevSchoolComments = reader("prevschComment")
                Else
                    PrevSchoolComments = ""
                End If


                If Not IsDBNull(reader("med_doctor")) Then
                    Med_Doctor = reader("med_doctor")
                Else
                    Med_Doctor = ""
                End If

                If Not IsDBNull(reader("med_doctorContact")) Then
                    Med_DocContact = reader("med_doctorContact")
                Else
                    Med_DocContact = ""
                End If

                If Not IsDBNull(reader("med_bloodgroup")) Then
                    Med_BloodGroup = reader("med_bloodgroup")
                Else
                    Med_BloodGroup = ""
                End If

                If Not IsDBNull(reader("med_allergies")) Then
                    Med_Allergies = reader("med_allergies")
                Else
                    Med_Allergies = ""
                End If


                If Not IsDBNull(reader("med_comments")) Then
                    Med_Comments = reader("med_comments")
                Else
                    Med_Comments = ""
                End If
                If Not IsDBNull(reader("xcur_Activities")) Then
                    Xcur_Activities = reader("xcur_Activities")
                Else
                    Xcur_Activities = ""
                End If


                If Not IsDBNull(reader("xcur_house")) Then
                    Xcur_House = reader("xcur_house")
                Else
                    Xcur_House = ""
                End If

                If Not IsDBNull(reader("bank_name")) Then
                    BankName = reader("bank_name")
                Else
                    BankName = ""
                End If

                If Not IsDBNull(reader("bank_accname")) Then
                    BankAccName = reader("bank_accname")
                Else
                    BankAccName = ""
                End If
                If Not IsDBNull(reader("bank_accnumber")) Then
                    BankAccNumber = reader("bank_accnumber")
                Else
                    BankAccNumber = ""
                End If
                If Not IsDBNull(reader("bank_branch")) Then
                    BankBranch = reader("bank_branch")
                Else
                    BankBranch = ""
                End If


                If Not IsDBNull(reader("Image")) Then




                    Image = CType(reader("image"), Byte())



                    Image64 = Convert.ToBase64String(Image)


                Else
                    Image64 = ""
                End If

                If Not IsDBNull(reader("studImageUrl")) Then
                    StudImageUrl = reader("studImageUrl")
                Else
                    StudImageUrl = ""
                End If

                If Not IsDBNull(reader("enrolref")) Then
                    enrolref = reader("enrolref").ToString
                Else
                    enrolref = ""
                End If


                If Not IsDBNull(reader("classdesc")) Then
                    ClassDesc = reader("classdesc").ToString
                Else
                    ClassDesc = ""
                End If

            End While
        Catch ex As Exception
        Finally

            reader.Close()
            CloseConnection(, True)

        End Try

    End Sub

    Public Function DeleteStudent() As Boolean
        sql = "Delete Studentpersonaldetails where studentid = '" & StudentID & "'"

        ExecuteNonQuery(sql,, True)

        If era Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Function SaveSubjects() As Boolean
        Dim sql As String = ""
        Dim params As List(Of SqlParameter)
        Dim param As SqlParameter
        Dim trans As SqlTransaction = Nothing
        Dim i As Integer = 0


        For Each Subj In Subjets
            params = New List(Of SqlParameter)
            i = i + 1
            sql = "spRegisterSubjects"
            param = New SqlParameter("@sub", Subj.SubjectID)
            params.Add(param)

            param = New SqlParameter("@stud", StudentID)
            params.Add(param)


            param = New SqlParameter("@regstatus", "Registered")
            params.Add(param)

            param = New SqlParameter("@regtype", "Normal")
            params.Add(param)

            param = New SqlParameter("@user", "Me")
            params.Add(param)

            param = New SqlParameter("@exam", Subj.Exam)
            params.Add(param)
            param = New SqlParameter("@subExamRef", Subj.ExamRef)
            params.Add(param)

            param = New SqlParameter("@subEnrolRef", enrolref)
            params.Add(param)
            If i = 1 Then
                ExecuteNonQuery(sql,, True,, trans, True, True, params, False)
            Else
                ExecuteNonQuery(sql,, True,, trans, True, False, params, False)
            End If


            If era Then
                trans.Rollback()
                CloseConnection(, True)
                erramsg = eramsg
                Return False
            End If


        Next
        If Not IsNothing(trans) Then
            Try
                trans.Commit()
                CloseConnection(, True)
            Catch ex As Exception
                trans.Rollback()
                erramsg = ex.Message
                Return False
            End Try

        End If

        Return True


    End Function


End Class
