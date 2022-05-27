Partial Class dsReports
    

    Partial Class StudentSubjectsDataTable

        Private Sub StudentSubjectsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DescriptionColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class NeawYearStatementDataTable

        Private Sub NeawYearStatementDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SemesterColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub NeawYearStatementDataTable_NeawYearStatementRowChanging(ByVal sender As System.Object, ByVal e As NeawYearStatementRowChangeEvent) Handles Me.NeawYearStatementRowChanging

        End Sub

    End Class

    Partial Class EndOfTermDataTable

        Private Sub EndOfTermDataTable_EndOfTermRowChanging(ByVal sender As System.Object, ByVal e As EndOfTermRowChangeEvent) Handles Me.EndOfTermRowChanging

        End Sub

    End Class

    Partial Class StaffRegisterDataTable

        Private Sub StaffRegisterDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.staffIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class itenrollmentDataTable

        Private Sub itenrollmentDataTable_itenrollmentRowChanging(ByVal sender As System.Object, ByVal e As itenrollmentRowChangeEvent) Handles Me.itenrollmentRowChanging

        End Sub

    End Class

    Partial Class FeesReceiptDataTable

        Private Sub FeesReceiptDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ReceiptColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class SchoolEnrollment1DataTable

        Private Sub SchoolEnrollment1DataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.YearColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class DebtorsContactsDataTable

        Private Sub DebtorsContactsDataTable_DebtorsContactsRowChanging(ByVal sender As System.Object, ByVal e As DebtorsContactsRowChangeEvent) Handles Me.DebtorsContactsRowChanging

        End Sub

        Private Sub DebtorsContactsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Residential_AdressColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class ContactsSpecificDataTable

        'Private Sub ContactsSpecificDataTable_ContactsSpecificRowChanging(ByVal sender As System.Object, ByVal e As ContactsSpecificRowChangeEvent) Handles Me.ContactsSpecificRowChanging

        'End Sub

    End Class

    Partial Class TranscriptDataTable

        Private Sub TranscriptDataTable_TranscriptRowChanging(ByVal sender As System.Object, ByVal e As TranscriptRowChangeEvent) Handles Me.TranscriptRowChanging

        End Sub

    End Class

    Partial Class StaffAssessmentDataTable

        Private Sub StaffAssessmentDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.a1Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class ContactsSpecificDataTable

        Private Sub ContactsSpecificDataTable_ContactsSpecificRowChanging(ByVal sender As System.Object, ByVal e As ContactsSpecificRowChangeEvent) Handles Me.ContactsSpecificRowChanging

        End Sub

    End Class

    Partial Class SchoolAvgDataTable

        Private Sub SchoolAvgDataTable_SchoolAvgRowChanging(ByVal sender As System.Object, ByVal e As SchoolAvgRowChangeEvent) Handles Me.SchoolAvgRowChanging

        End Sub

    End Class

    Partial Class KnowHowDataTable

        Private Sub KnowHowDataTable_KnowHowRowChanging(ByVal sender As System.Object, ByVal e As KnowHowRowChangeEvent) Handles Me.KnowHowRowChanging

        End Sub

    End Class

    Partial Class TranscriptDataTable

        Private Sub TranscriptDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.StudentIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class LedgerTransactionsDataTable

        Private Sub LedgerTransactionsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.studentidColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub LedgerTransactionsDataTable_LedgerTransactionsRowChanging(ByVal sender As System.Object, ByVal e As LedgerTransactionsRowChangeEvent) Handles Me.LedgerTransactionsRowChanging

        End Sub

    End Class

    Partial Class FeesPaymentsDataTable

        Private Sub FeesPaymentsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IntakeColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class ContactsSpecificDataTable

        Private Sub ContactsSpecificDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DescriptionColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class StudentClassesDataTable

        Private Sub StudentClassesDataTable_StudentClassesRowChanging(ByVal sender As System.Object, ByVal e As StudentClassesRowChangeEvent) Handles Me.StudentClassesRowChanging

        End Sub

    End Class

    Partial Class SubjectStudentsDataTable

        Private Sub SubjectStudentsDataTable_SubjectStudentsRowChanging(ByVal sender As System.Object, ByVal e As SubjectStudentsRowChangeEvent) Handles Me.SubjectStudentsRowChanging

        End Sub

    End Class

    Partial Class ExamAttendanceDataTable

        Private Sub ExamAttendanceDataTable_ExamAttendanceRowChanging(ByVal sender As System.Object, ByVal e As ExamAttendanceRowChangeEvent) Handles Me.ExamAttendanceRowChanging

        End Sub

    End Class

    Partial Class SubjectItemsDataTable

        Private Sub SubjectItemsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SubjectIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub SubjectItemsDataTable_SubjectItemsRowChanging(ByVal sender As System.Object, ByVal e As SubjectItemsRowChangeEvent) Handles Me.SubjectItemsRowChanging

        End Sub

    End Class

    Partial Class StudentPersonalDetailsDataTable

        Private Sub StudentPersonalDetailsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.StudentIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace dsReportsTableAdapters
    
    Partial Class SubjectStudentsTableAdapter

    End Class

    Partial Class DebtorsContactsTableAdapter

    End Class

    Partial Class FeesPaymentsByDateTableAdapter

    End Class

    Partial Class SubjectItemsTableAdapter

    End Class

    Partial Class LedgerTransactionsTableAdapter

    End Class

    Partial Class StudentClassesTableAdapter

    End Class

    Partial Class SchoolEnrollment1TableAdapter

    End Class

    Partial Class TranscriptTableAdapter

    End Class

    Partial Class StudentSubjectsTableAdapter

    End Class

    Partial Public Class SchoolEnrollmentTableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class StaffRatings_TableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class StaffOverallAssessmentTableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class CollegeGeneralAnalysisTableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class StudentRegisterTableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class EnrollmentFormTableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class HsExamMarksTableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class UserLoginHstryTableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class BoardPassRatesTableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class StaffQualificationTableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class SchoolCurriculaTableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class NeawYearStatementTableAdapter
    End Class
End Namespace

Namespace dsReportsTableAdapters
    
    Partial Public Class EndOfTermTableAdapter
    End Class
End Namespace
