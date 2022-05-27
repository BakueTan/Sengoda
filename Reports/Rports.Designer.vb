Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("School Enrollment")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Class Students")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Exam Marks")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GraphicalAnalysis")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HighSchool", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Exam Results", New System.Windows.Forms.TreeNode() {TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Student Academics", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Students", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SubjectsTaught")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Staff", New System.Windows.Forms.TreeNode() {TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cumulative Payments")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PaymentsPerDate")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accounts", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UserLoginHistory")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administration", New System.Windows.Forms.TreeNode() {TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BookDetails")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BookIssues")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DueBy")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BorrowingHistory")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BookCentre", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17, TreeNode18, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("AllReports", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode10, TreeNode13, TreeNode15, TreeNode20})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rports))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvRpts = New System.Windows.Forms.TreeView()
        Me.gbStudProfile = New System.Windows.Forms.GroupBox()
        Me.cboProfilePeriod = New System.Windows.Forms.ComboBox()
        Me.Label191 = New System.Windows.Forms.Label()
        Me.lbstudprofile = New System.Windows.Forms.ListBox()
        Me.txtProfileStud = New System.Windows.Forms.TextBox()
        Me.Label188 = New System.Windows.Forms.Label()
        Me.gbExamGraphicalAnalysis = New System.Windows.Forms.GroupBox()
        Me.Label190 = New System.Windows.Forms.Label()
        Me.cboExamGraphSection = New System.Windows.Forms.ComboBox()
        Me.cboExamGraphSessTo = New System.Windows.Forms.ComboBox()
        Me.Label183 = New System.Windows.Forms.Label()
        Me.cboExamGraphSessFrom = New System.Windows.Forms.ComboBox()
        Me.rbGraphPerSub = New System.Windows.Forms.RadioButton()
        Me.rbgraphperstud = New System.Windows.Forms.RadioButton()
        Me.Label184 = New System.Windows.Forms.Label()
        Me.cboExamGraphClass = New System.Windows.Forms.ComboBox()
        Me.Label185 = New System.Windows.Forms.Label()
        Me.cboExamGraphForm = New System.Windows.Forms.ComboBox()
        Me.gbBorrowHistory = New System.Windows.Forms.GroupBox()
        Me.lbHistSearch = New System.Windows.Forms.ListBox()
        Me.txtHistSearch = New System.Windows.Forms.TextBox()
        Me.Label182 = New System.Windows.Forms.Label()
        Me.rbHistoryPerBook = New System.Windows.Forms.RadioButton()
        Me.rbHistoryPerStud = New System.Windows.Forms.RadioButton()
        Me.gbDueBy = New System.Windows.Forms.GroupBox()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label181 = New System.Windows.Forms.Label()
        Me.gbCreditors = New System.Windows.Forms.GroupBox()
        Me.lbCreditors = New System.Windows.Forms.ListBox()
        Me.txtCrCreditor = New System.Windows.Forms.TextBox()
        Me.Label180 = New System.Windows.Forms.Label()
        Me.Label179 = New System.Windows.Forms.Label()
        Me.Label178 = New System.Windows.Forms.Label()
        Me.cboCrPrdTo = New System.Windows.Forms.ComboBox()
        Me.cboCrPrdFrm = New System.Windows.Forms.ComboBox()
        Me.rbAllCreditors = New System.Windows.Forms.RadioButton()
        Me.rbCreditorStat = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label162 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label163 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label164 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label165 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label166 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.ComboBox14 = New System.Windows.Forms.ComboBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label167 = New System.Windows.Forms.Label()
        Me.Label168 = New System.Windows.Forms.Label()
        Me.ComboBox15 = New System.Windows.Forms.ComboBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.ComboBox16 = New System.Windows.Forms.ComboBox()
        Me.Label169 = New System.Windows.Forms.Label()
        Me.ComboBox17 = New System.Windows.Forms.ComboBox()
        Me.Label170 = New System.Windows.Forms.Label()
        Me.ComboBox18 = New System.Windows.Forms.ComboBox()
        Me.Label171 = New System.Windows.Forms.Label()
        Me.ComboBox19 = New System.Windows.Forms.ComboBox()
        Me.Label172 = New System.Windows.Forms.Label()
        Me.ComboBox20 = New System.Windows.Forms.ComboBox()
        Me.Label173 = New System.Windows.Forms.Label()
        Me.ComboBox21 = New System.Windows.Forms.ComboBox()
        Me.Label174 = New System.Windows.Forms.Label()
        Me.ComboBox22 = New System.Windows.Forms.ComboBox()
        Me.Label175 = New System.Windows.Forms.Label()
        Me.ComboBox23 = New System.Windows.Forms.ComboBox()
        Me.Label176 = New System.Windows.Forms.Label()
        Me.ComboBox24 = New System.Windows.Forms.ComboBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.gbIncomeExpenditure = New System.Windows.Forms.GroupBox()
        Me.rbIncExpDetailed = New System.Windows.Forms.RadioButton()
        Me.rbIncExpSummary = New System.Windows.Forms.RadioButton()
        Me.cboIncomeExpenditureCart = New System.Windows.Forms.ComboBox()
        Me.Label177 = New System.Windows.Forms.Label()
        Me.dtpIncExpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpIncExpDatefrom = New System.Windows.Forms.DateTimePicker()
        Me.Label160 = New System.Windows.Forms.Label()
        Me.Label161 = New System.Windows.Forms.Label()
        Me.gbBookMaster = New System.Windows.Forms.GroupBox()
        Me.rbSummaryPerprog = New System.Windows.Forms.RadioButton()
        Me.rbBookSummary = New System.Windows.Forms.RadioButton()
        Me.rbPerProgram = New System.Windows.Forms.RadioButton()
        Me.rbPerBook = New System.Windows.Forms.RadioButton()
        Me.gbBookIssues = New System.Windows.Forms.GroupBox()
        Me.rbBookIssuesPerDate = New System.Windows.Forms.RadioButton()
        Me.rbIssuesPerBook = New System.Windows.Forms.RadioButton()
        Me.rbIssuesPerStud = New System.Windows.Forms.RadioButton()
        Me.dtpBookIssuesTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpBookIssuesFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label158 = New System.Windows.Forms.Label()
        Me.Label159 = New System.Windows.Forms.Label()
        Me.gbstudentregister2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.ComboBox13 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.Label157 = New System.Windows.Forms.Label()
        Me.gbStaffRegister = New System.Windows.Forms.GroupBox()
        Me.rbStaffRegByStaff = New System.Windows.Forms.RadioButton()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label152 = New System.Windows.Forms.Label()
        Me.StaffRegDateTo = New System.Windows.Forms.MaskedTextBox()
        Me.staffregdatefrom = New System.Windows.Forms.MaskedTextBox()
        Me.rbStaffRegByDay = New System.Windows.Forms.RadioButton()
        Me.gbClassRegister = New System.Windows.Forms.GroupBox()
        Me.rbClsRegPerStud = New System.Windows.Forms.RadioButton()
        Me.rbClsRegHardCopy = New System.Windows.Forms.RadioButton()
        Me.lbClsRegStud = New System.Windows.Forms.ListBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.cboClsRegDetTo = New System.Windows.Forms.MaskedTextBox()
        Me.cboClsRegDetFrm = New System.Windows.Forms.MaskedTextBox()
        Me.rbClsRegByDay = New System.Windows.Forms.RadioButton()
        Me.cboClsRegStud = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cboClsRegCls = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.rbClsRegByCls = New System.Windows.Forms.RadioButton()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.cboClsRegTern = New System.Windows.Forms.ComboBox()
        Me.cboClsRegSess = New System.Windows.Forms.ComboBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.cboClsRegForm = New System.Windows.Forms.ComboBox()
        Me.gbSchoolProfile = New System.Windows.Forms.GroupBox()
        Me.rbSchoolCurricula = New System.Windows.Forms.RadioButton()
        Me.rbSchoolParticulars = New System.Windows.Forms.RadioButton()
        Me.gbHsStudMarks = New System.Windows.Forms.GroupBox()
        Me.gbCustomEmailmsg = New System.Windows.Forms.GroupBox()
        Me.txtCustomEmailmsg = New System.Windows.Forms.TextBox()
        Me.gbGraphicalView = New System.Windows.Forms.GroupBox()
        Me.chkGraphical = New System.Windows.Forms.CheckBox()
        Me.gbPublishOptions = New System.Windows.Forms.GroupBox()
        Me.rbPublishPerExam = New System.Windows.Forms.RadioButton()
        Me.RbPublishPerClass = New System.Windows.Forms.RadioButton()
        Me.chkPublish = New System.Windows.Forms.CheckBox()
        Me.Label189 = New System.Windows.Forms.Label()
        Me.cboHsMarksSect = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbBooklet = New System.Windows.Forms.RadioButton()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.rbA4 = New System.Windows.Forms.RadioButton()
        Me.rbConsolMarkSheet = New System.Windows.Forms.RadioButton()
        Me.lbMarksPerStud = New System.Windows.Forms.ListBox()
        Me.rbReportPerStud = New System.Windows.Forms.RadioButton()
        Me.cboHsMarksStud = New System.Windows.Forms.TextBox()
        Me.Label187 = New System.Windows.Forms.Label()
        Me.rbpub = New System.Windows.Forms.RadioButton()
        Me.cboHsMarksSess = New System.Windows.Forms.ComboBox()
        Me.rbHsReportPerClass = New System.Windows.Forms.RadioButton()
        Me.rbHsMarksPerSubject = New System.Windows.Forms.RadioButton()
        Me.rbHsMarksPerClass = New System.Windows.Forms.RadioButton()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cboHsMarksRef = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cboHsMarksLev = New System.Windows.Forms.ComboBox()
        Me.gbStaffQualifictions = New System.Windows.Forms.GroupBox()
        Me.rbQualByQual = New System.Windows.Forms.RadioButton()
        Me.rbQualByStaff = New System.Windows.Forms.RadioButton()
        Me.gbStaffPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.rbStaffTeaching = New System.Windows.Forms.RadioButton()
        Me.RbStaffGvt = New System.Windows.Forms.RadioButton()
        Me.rbStaffContract = New System.Windows.Forms.RadioButton()
        Me.Label153 = New System.Windows.Forms.Label()
        Me.cboStaffPersStaus = New System.Windows.Forms.ComboBox()
        Me.gbExamBoardPassRates = New System.Windows.Forms.GroupBox()
        Me.rbPassRatePerProgram = New System.Windows.Forms.RadioButton()
        Me.rbPassRatePerBoard = New System.Windows.Forms.RadioButton()
        Me.Label154 = New System.Windows.Forms.Label()
        Me.cboPassRatesProg = New System.Windows.Forms.ComboBox()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.cboPassRatesBoard = New System.Windows.Forms.ComboBox()
        Me.gbIDcards = New System.Windows.Forms.GroupBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.cboCardsGrp = New System.Windows.Forms.ComboBox()
        Me.rbCardsPerGroup = New System.Windows.Forms.RadioButton()
        Me.rbCardsPerClas = New System.Windows.Forms.RadioButton()
        Me.cboCardsSess2 = New System.Windows.Forms.ComboBox()
        Me.cboCardsForm2 = New System.Windows.Forms.ComboBox()
        Me.Label146 = New System.Windows.Forms.Label()
        Me.cboCardsSess1 = New System.Windows.Forms.ComboBox()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.cboCardsTerm = New System.Windows.Forms.ComboBox()
        Me.Label148 = New System.Windows.Forms.Label()
        Me.cboCardsForm1 = New System.Windows.Forms.ComboBox()
        Me.Label150 = New System.Windows.Forms.Label()
        Me.cboCardsYr = New System.Windows.Forms.ComboBox()
        Me.gbUserHistory = New System.Windows.Forms.GroupBox()
        Me.rbUserHisByDate = New System.Windows.Forms.RadioButton()
        Me.rbUserHisByUser = New System.Windows.Forms.RadioButton()
        Me.rbLoggedInUser = New System.Windows.Forms.RadioButton()
        Me.lbUsers = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskLognHisTo = New System.Windows.Forms.MaskedTextBox()
        Me.mskLognHisFrm = New System.Windows.Forms.MaskedTextBox()
        Me.UserName = New System.Windows.Forms.Label()
        Me.cbUserHisUser = New System.Windows.Forms.ComboBox()
        Me.gbSubjectRegister = New System.Windows.Forms.GroupBox()
        Me.rbHardCopy = New System.Windows.Forms.RadioButton()
        Me.lbSubRegStudSearch = New System.Windows.Forms.ListBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.SubRegDateTo = New System.Windows.Forms.MaskedTextBox()
        Me.subRegDateFrom = New System.Windows.Forms.MaskedTextBox()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.cboSubRegSub = New System.Windows.Forms.ComboBox()
        Me.rbSubRegPerSub = New System.Windows.Forms.RadioButton()
        Me.cboSubRegStud = New System.Windows.Forms.ComboBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.cboSubRegCls = New System.Windows.Forms.ComboBox()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.rbSubRegPerStud = New System.Windows.Forms.RadioButton()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.cboSubRegSem = New System.Windows.Forms.ComboBox()
        Me.cboSubRegSess = New System.Windows.Forms.ComboBox()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.cboStudRegLvl = New System.Windows.Forms.ComboBox()
        Me.gbKnowhowAnalysis = New System.Windows.Forms.GroupBox()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.cboKhasess = New System.Windows.Forms.ComboBox()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.cboKhasem = New System.Windows.Forms.ComboBox()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.cboKhalev = New System.Windows.Forms.ComboBox()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.cboKhaintak = New System.Windows.Forms.ComboBox()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.cboKhaclass = New System.Windows.Forms.ComboBox()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.cboKhaprog = New System.Windows.Forms.ComboBox()
        Me.gbRegister3 = New System.Windows.Forms.GroupBox()
        Me.lbReg3Sub = New System.Windows.Forms.ListBox()
        Me.cboReg3Sub = New System.Windows.Forms.ComboBox()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.lbReg3Prog = New System.Windows.Forms.ListBox()
        Me.cboReg3Prog = New System.Windows.Forms.ComboBox()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.cboReg3Session = New System.Windows.Forms.ComboBox()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.cboReg3Intake = New System.Windows.Forms.ComboBox()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.cboReg3Class = New System.Windows.Forms.ComboBox()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.cboReg3Sec = New System.Windows.Forms.ComboBox()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.gbSchoolEnrollment = New System.Windows.Forms.GroupBox()
        Me.chkGraphicalenrol = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkPeriodAnalysis = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnAddEnrol = New System.Windows.Forms.Button()
        Me.lbAnalysisEnrols = New System.Windows.Forms.ListBox()
        Me.pnlDateAnalysis = New System.Windows.Forms.Panel()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.dtpEnrolPerAnalDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.dtpEnrolPerAnalDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboSchoolEnrolClass = New System.Windows.Forms.ComboBox()
        Me.Staus = New System.Windows.Forms.Label()
        Me.cboSchoolEnrolSection = New System.Windows.Forms.ComboBox()
        Me.gbGeneralanalysis = New System.Windows.Forms.GroupBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.cboGeneralAnalSect = New System.Windows.Forms.ComboBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.cboGeneralAnalIntk = New System.Windows.Forms.ComboBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.cboGeneralAnalClass = New System.Windows.Forms.ComboBox()
        Me.gbSubjectsTaught = New System.Windows.Forms.GroupBox()
        Me.lbSubjects = New System.Windows.Forms.ListBox()
        Me.lbteachers = New System.Windows.Forms.ListBox()
        Me.cboSubTaughtSubject = New System.Windows.Forms.TextBox()
        Me.Label186 = New System.Windows.Forms.Label()
        Me.txtsubtaughtteachers = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.cboSubTaughtTerm = New System.Windows.Forms.ComboBox()
        Me.rbSubTaughtPerSubject = New System.Windows.Forms.RadioButton()
        Me.rbSubTaughtPerTeacher = New System.Windows.Forms.RadioButton()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.cboSubTotCls = New System.Windows.Forms.ComboBox()
        Me.gbSubjectsDropped = New System.Windows.Forms.GroupBox()
        Me.dtpSubDrpdTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpSudDropdFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.gbStaffRatings = New System.Windows.Forms.GroupBox()
        Me.chkBySection = New System.Windows.Forms.CheckBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.cboStaffRatingSection = New System.Windows.Forms.ComboBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.cboStaffRatingIntk = New System.Windows.Forms.ComboBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.cboStaffRatingCls = New System.Windows.Forms.ComboBox()
        Me.gbDepartmentalAssessment = New System.Windows.Forms.GroupBox()
        Me.chkDeptAnaly = New System.Windows.Forms.CheckBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.cboDptAnlSchool = New System.Windows.Forms.ComboBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.cboDeptAnalIntk = New System.Windows.Forms.ComboBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.cboDeptAnalClass = New System.Windows.Forms.ComboBox()
        Me.gbStaffAssessment = New System.Windows.Forms.GroupBox()
        Me.rbStaffAssPerSection = New System.Windows.Forms.RadioButton()
        Me.rbAssessmentPerSub = New System.Windows.Forms.RadioButton()
        Me.lblectures = New System.Windows.Forms.ListBox()
        Me.rbStaffAssPerIndv = New System.Windows.Forms.RadioButton()
        Me.rbStaffAssPerClass = New System.Windows.Forms.RadioButton()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.cboStaffAssSub = New System.Windows.Forms.ComboBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.cboStaffAssStaff = New System.Windows.Forms.ComboBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.cboStaffAssIntk = New System.Windows.Forms.ComboBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.cboStaffAssCls = New System.Windows.Forms.ComboBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.cboStaffAssSect = New System.Windows.Forms.ComboBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.cboStaffAssSem = New System.Windows.Forms.ComboBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.cboStaffAssYear = New System.Windows.Forms.ComboBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.cboStaffAssProg = New System.Windows.Forms.ComboBox()
        Me.gbDetailedMarks = New System.Windows.Forms.GroupBox()
        Me.rbPublish = New System.Windows.Forms.RadioButton()
        Me.rbClassResStats = New System.Windows.Forms.RadioButton()
        Me.rbResStat = New System.Windows.Forms.RadioButton()
        Me.lbTransSumStud = New System.Windows.Forms.ListBox()
        Me.rbTansSum = New System.Windows.Forms.RadioButton()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.cboDetailedMarksStud = New System.Windows.Forms.ComboBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.cboDetailedMarksIntake = New System.Windows.Forms.ComboBox()
        Me.rbResDisplay = New System.Windows.Forms.RadioButton()
        Me.rbResSummary = New System.Windows.Forms.RadioButton()
        Me.rbResDetail = New System.Windows.Forms.RadioButton()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cboDetailedMarksSect = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboDetailedMarksLevel = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboDetailedMarksClass = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cboDetailedMarksProg = New System.Windows.Forms.ComboBox()
        Me.gbKnowHow = New System.Windows.Forms.GroupBox()
        Me.cboKnowHowYear = New System.Windows.Forms.ComboBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.gbSubStuds = New System.Windows.Forms.GroupBox()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.cboSubStudsLvl = New System.Windows.Forms.ComboBox()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.cboSubStudsSem = New System.Windows.Forms.ComboBox()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.cboSubStudsSession = New System.Windows.Forms.ComboBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.cboSubStudSection = New System.Windows.Forms.ComboBox()
        Me.rbCoursewek = New System.Windows.Forms.RadioButton()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cboMarkSheetExam = New System.Windows.Forms.ComboBox()
        Me.RbMarkSheet = New System.Windows.Forms.RadioButton()
        Me.rbExamAttendance = New System.Windows.Forms.RadioButton()
        Me.rbAllSubStuds = New System.Windows.Forms.RadioButton()
        Me.rbSubByProg = New System.Windows.Forms.RadioButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboSubStudsProgram = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboSubStudsIntake = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboSubStudsYera = New System.Windows.Forms.ComboBox()
        Me.cboSubStudsID = New System.Windows.Forms.ComboBox()
        Me.gbTrans = New System.Windows.Forms.GroupBox()
        Me.lstStudents = New System.Windows.Forms.ListBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.cboTransStudID = New System.Windows.Forms.ComboBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cboTransIntk = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cboTransClass = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cboTransReg = New System.Windows.Forms.ComboBox()
        Me.chkAllYears = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTransSem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTransYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTransProg = New System.Windows.Forms.ComboBox()
        Me.gbStudSub = New System.Windows.Forms.GroupBox()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.cboStudSubSess = New System.Windows.Forms.ComboBox()
        Me.lbStudSubSearch = New System.Windows.Forms.ListBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.cboStudSubProg = New System.Windows.Forms.ComboBox()
        Me.rbStubSubPerSem = New System.Windows.Forms.RadioButton()
        Me.rbStudSubPerClass = New System.Windows.Forms.RadioButton()
        Me.rbStudsubAll = New System.Windows.Forms.RadioButton()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.cboStudSubCls = New System.Windows.Forms.ComboBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.cboStudSubSem = New System.Windows.Forms.ComboBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.cboStudSubLvl = New System.Windows.Forms.ComboBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.cbostudsubStudid = New System.Windows.Forms.ComboBox()
        Me.gbLeftStudents = New System.Windows.Forms.GroupBox()
        Me.Label151 = New System.Windows.Forms.Label()
        Me.cboReasonLeft = New System.Windows.Forms.ComboBox()
        Me.cboTermLeftTo = New System.Windows.Forms.ComboBox()
        Me.Label149 = New System.Windows.Forms.Label()
        Me.Label145 = New System.Windows.Forms.Label()
        Me.cboTermLeftFrom = New System.Windows.Forms.ComboBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.cboYearLeft = New System.Windows.Forms.ComboBox()
        Me.gbPersDetails = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboPersDetStatus = New System.Windows.Forms.ComboBox()
        Me.gbStudClasses = New System.Windows.Forms.GroupBox()
        Me.gbClassAgeRange = New System.Windows.Forms.GroupBox()
        Me.txtStudClassAgeFrom = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStudClassAgeto = New System.Windows.Forms.TextBox()
        Me.chkClssAge = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkperiodAnalysis1 = New System.Windows.Forms.CheckBox()
        Me.cboStudClassCls = New System.Windows.Forms.ComboBox()
        Me.pnlclassstudent = New System.Windows.Forms.Panel()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.dtpclassstudentdateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.dtpclassstudentdatefrom = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboClassStudsSex = New System.Windows.Forms.ComboBox()
        Me.cboStudClassSession = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboStudClasYr = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboStudClasProgram = New System.Windows.Forms.ComboBox()
        Me.gbPaymentsPerDate = New System.Windows.Forms.GroupBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cboFeesPayCurrency = New System.Windows.Forms.ComboBox()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.Label143 = New System.Windows.Forms.Label()
        Me.dtpPostDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpPostDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboPayPerDaterUser = New System.Windows.Forms.ComboBox()
        Me.cboPayPerDateMode = New System.Windows.Forms.ComboBox()
        Me.cboPayperDateType = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbFeesPayWithStudents = New System.Windows.Forms.RadioButton()
        Me.rbFeesPaymentsAnalysis = New System.Windows.Forms.RadioButton()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.cbofeesPayPto = New System.Windows.Forms.ComboBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.cboFeesPayPfrpm = New System.Windows.Forms.ComboBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.dtpPayDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpPayDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.gbAccounts = New System.Windows.Forms.GroupBox()
        Me.chkDebtorsOnly = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboAccClass = New System.Windows.Forms.ComboBox()
        Me.txtAccStud = New System.Windows.Forms.TextBox()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.rtxtAccAddinfo = New System.Windows.Forms.RichTextBox()
        Me.rbClassStatement = New System.Windows.Forms.RadioButton()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.cboAccPayType = New System.Windows.Forms.ComboBox()
        Me.rbStudStatement = New System.Windows.Forms.RadioButton()
        Me.lbAccStud = New System.Windows.Forms.ListBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.cboAccSection = New System.Windows.Forms.ComboBox()
        Me.rbAccDebtors = New System.Windows.Forms.RadioButton()
        Me.cboAccSession = New System.Windows.Forms.ComboBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.cboAccPerTo = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cboAccPerFrm = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.cboAccLvl = New System.Windows.Forms.ComboBox()
        Me.rbAccPerForm = New System.Windows.Forms.RadioButton()
        Me.gbExamAttendance = New System.Windows.Forms.GroupBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cboExamAttExam = New System.Windows.Forms.ComboBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.cboExamAttSub = New System.Windows.Forms.ComboBox()
        Me.gbContactDetails = New System.Windows.Forms.GroupBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.cboContactsSect = New System.Windows.Forms.ComboBox()
        Me.rbAllConts = New System.Windows.Forms.RadioButton()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.cboContsIntk = New System.Windows.Forms.ComboBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.gbCollegeAssessment = New System.Windows.Forms.GroupBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.cboColAssIntk = New System.Windows.Forms.ComboBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.CboColAssCls = New System.Windows.Forms.ComboBox()
        Me.cboContsSession = New System.Windows.Forms.ComboBox()
        Me.lbStudContsSearch = New System.Windows.Forms.ListBox()
        Me.rbContactsPerStud = New System.Windows.Forms.RadioButton()
        Me.cboContactsStud = New System.Windows.Forms.ComboBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cboContactsSem = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cboContactsClass = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cboContactsProgra = New System.Windows.Forms.ComboBox()
        Me.rbContsPerClass = New System.Windows.Forms.RadioButton()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cboContsLevel = New System.Windows.Forms.ComboBox()
        Me.gbSubjectPoints = New System.Windows.Forms.GroupBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.cboSubPntSess = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.cboSubPntIntk = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboSubPntSect = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboSubPntClass = New System.Windows.Forms.ComboBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlTranstype = New System.Windows.Forms.Panel()
        Me.chkAccShoRec = New System.Windows.Forms.CheckBox()
        Me.chkAccShowInv = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboBBFCutOff = New System.Windows.Forms.ComboBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbStudProfile.SuspendLayout()
        Me.gbExamGraphicalAnalysis.SuspendLayout()
        Me.gbBorrowHistory.SuspendLayout()
        Me.gbDueBy.SuspendLayout()
        Me.gbCreditors.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbIncomeExpenditure.SuspendLayout()
        Me.gbBookMaster.SuspendLayout()
        Me.gbBookIssues.SuspendLayout()
        Me.gbstudentregister2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbStaffRegister.SuspendLayout()
        Me.gbClassRegister.SuspendLayout()
        Me.gbSchoolProfile.SuspendLayout()
        Me.gbHsStudMarks.SuspendLayout()
        Me.gbCustomEmailmsg.SuspendLayout()
        Me.gbGraphicalView.SuspendLayout()
        Me.gbPublishOptions.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbStaffQualifictions.SuspendLayout()
        Me.gbStaffPersonalDetails.SuspendLayout()
        Me.gbExamBoardPassRates.SuspendLayout()
        Me.gbIDcards.SuspendLayout()
        Me.gbUserHistory.SuspendLayout()
        Me.gbSubjectRegister.SuspendLayout()
        Me.gbKnowhowAnalysis.SuspendLayout()
        Me.gbRegister3.SuspendLayout()
        Me.gbSchoolEnrollment.SuspendLayout()
        Me.pnlDateAnalysis.SuspendLayout()
        Me.gbGeneralanalysis.SuspendLayout()
        Me.gbSubjectsTaught.SuspendLayout()
        Me.gbSubjectsDropped.SuspendLayout()
        Me.gbStaffRatings.SuspendLayout()
        Me.gbDepartmentalAssessment.SuspendLayout()
        Me.gbStaffAssessment.SuspendLayout()
        Me.gbDetailedMarks.SuspendLayout()
        Me.gbKnowHow.SuspendLayout()
        Me.gbSubStuds.SuspendLayout()
        Me.gbTrans.SuspendLayout()
        Me.gbStudSub.SuspendLayout()
        Me.gbLeftStudents.SuspendLayout()
        Me.gbPersDetails.SuspendLayout()
        Me.gbStudClasses.SuspendLayout()
        Me.gbClassAgeRange.SuspendLayout()
        Me.pnlclassstudent.SuspendLayout()
        Me.gbPaymentsPerDate.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbAccounts.SuspendLayout()
        Me.gbExamAttendance.SuspendLayout()
        Me.gbContactDetails.SuspendLayout()
        Me.gbCollegeAssessment.SuspendLayout()
        Me.gbSubjectPoints.SuspendLayout()
        Me.pnlTranstype.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 46)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvRpts)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbStudProfile)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbExamGraphicalAnalysis)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbBorrowHistory)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbDueBy)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbCreditors)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbIncomeExpenditure)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbBookMaster)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbBookIssues)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbstudentregister2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbStaffRegister)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbClassRegister)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSchoolProfile)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbHsStudMarks)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbStaffQualifictions)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbStaffPersonalDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbExamBoardPassRates)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbIDcards)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbUserHistory)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSubjectRegister)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbKnowhowAnalysis)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbRegister3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSchoolEnrollment)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbGeneralanalysis)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSubjectsTaught)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSubjectsDropped)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbStaffRatings)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbDepartmentalAssessment)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbStaffAssessment)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbDetailedMarks)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbKnowHow)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSubStuds)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbTrans)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbStudSub)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbLeftStudents)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbPersDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbStudClasses)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbPaymentsPerDate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbAccounts)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbExamAttendance)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbContactDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSubjectPoints)
        Me.SplitContainer1.Size = New System.Drawing.Size(1156, 487)
        Me.SplitContainer1.SplitterDistance = 206
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'tvRpts
        '
        Me.tvRpts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvRpts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvRpts.Location = New System.Drawing.Point(37, 11)
        Me.tvRpts.Name = "tvRpts"
        TreeNode1.Name = "Node1"
        TreeNode1.Tag = "30"
        TreeNode1.Text = "School Enrollment"
        TreeNode2.Name = "Node0"
        TreeNode2.Tag = "27"
        TreeNode2.Text = "Class Students"
        TreeNode3.Name = "Node5"
        TreeNode3.Tag = "40"
        TreeNode3.Text = "Exam Marks"
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "GraphicalAnalysis"
        TreeNode5.Name = "Node4"
        TreeNode5.Tag = "45"
        TreeNode5.Text = "HighSchool"
        TreeNode6.Name = "Node1"
        TreeNode6.Tag = "38"
        TreeNode6.Text = "Exam Results"
        TreeNode7.Name = "Node4"
        TreeNode7.Tag = "34"
        TreeNode7.Text = "Student Academics"
        TreeNode8.Name = "node0"
        TreeNode8.Tag = "33"
        TreeNode8.Text = "Students"
        TreeNode9.Name = "Node0"
        TreeNode9.Text = "SubjectsTaught"
        TreeNode10.Name = "Node3"
        TreeNode10.Tag = "35"
        TreeNode10.Text = "Staff"
        TreeNode11.Name = "Node1"
        TreeNode11.Tag = "46"
        TreeNode11.Text = "Cumulative Payments"
        TreeNode12.Name = "Node0"
        TreeNode12.Tag = "62"
        TreeNode12.Text = "PaymentsPerDate"
        TreeNode13.Name = "Node3"
        TreeNode13.Tag = "64"
        TreeNode13.Text = "Accounts"
        TreeNode14.Name = "Node1"
        TreeNode14.Tag = "81"
        TreeNode14.Text = "UserLoginHistory"
        TreeNode15.Name = "Node0"
        TreeNode15.Tag = "71"
        TreeNode15.Text = "Administration"
        TreeNode16.Name = "Node2"
        TreeNode16.Tag = "97"
        TreeNode16.Text = "BookDetails"
        TreeNode17.Name = "Node1"
        TreeNode17.Text = "BookIssues"
        TreeNode18.Name = "Node0"
        TreeNode18.Text = "DueBy"
        TreeNode19.Name = "Node1"
        TreeNode19.Text = "BorrowingHistory"
        TreeNode20.Name = "Node1"
        TreeNode20.Tag = "96"
        TreeNode20.Text = "BookCentre"
        TreeNode21.Name = "Node0"
        TreeNode21.Tag = "32"
        TreeNode21.Text = "AllReports"
        Me.tvRpts.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode21})
        Me.tvRpts.Size = New System.Drawing.Size(116, 299)
        Me.tvRpts.TabIndex = 10
        '
        'gbStudProfile
        '
        Me.gbStudProfile.Controls.Add(Me.cboProfilePeriod)
        Me.gbStudProfile.Controls.Add(Me.Label191)
        Me.gbStudProfile.Controls.Add(Me.lbstudprofile)
        Me.gbStudProfile.Controls.Add(Me.txtProfileStud)
        Me.gbStudProfile.Controls.Add(Me.Label188)
        Me.gbStudProfile.Location = New System.Drawing.Point(620, 16)
        Me.gbStudProfile.Name = "gbStudProfile"
        Me.gbStudProfile.Size = New System.Drawing.Size(25, 30)
        Me.gbStudProfile.TabIndex = 48
        Me.gbStudProfile.TabStop = False
        Me.gbStudProfile.Text = "StudentProfile"
        Me.gbStudProfile.Visible = False
        '
        'cboProfilePeriod
        '
        Me.cboProfilePeriod.DisplayMember = "Period"
        Me.cboProfilePeriod.FormattingEnabled = True
        Me.cboProfilePeriod.Location = New System.Drawing.Point(127, 59)
        Me.cboProfilePeriod.Name = "cboProfilePeriod"
        Me.cboProfilePeriod.Size = New System.Drawing.Size(121, 21)
        Me.cboProfilePeriod.TabIndex = 30
        Me.cboProfilePeriod.ValueMember = "Period"
        '
        'Label191
        '
        Me.Label191.AutoSize = True
        Me.Label191.Location = New System.Drawing.Point(9, 62)
        Me.Label191.Name = "Label191"
        Me.Label191.Size = New System.Drawing.Size(97, 13)
        Me.Label191.TabIndex = 29
        Me.Label191.Text = "BillingPeriodCutOff:"
        '
        'lbstudprofile
        '
        Me.lbstudprofile.FormattingEnabled = True
        Me.lbstudprofile.Location = New System.Drawing.Point(277, 29)
        Me.lbstudprofile.Name = "lbstudprofile"
        Me.lbstudprofile.Size = New System.Drawing.Size(186, 82)
        Me.lbstudprofile.TabIndex = 27
        Me.lbstudprofile.Visible = False
        '
        'txtProfileStud
        '
        Me.txtProfileStud.Location = New System.Drawing.Point(127, 28)
        Me.txtProfileStud.Name = "txtProfileStud"
        Me.txtProfileStud.Size = New System.Drawing.Size(139, 20)
        Me.txtProfileStud.TabIndex = 26
        '
        'Label188
        '
        Me.Label188.AutoSize = True
        Me.Label188.Location = New System.Drawing.Point(10, 34)
        Me.Label188.Name = "Label188"
        Me.Label188.Size = New System.Drawing.Size(47, 13)
        Me.Label188.TabIndex = 25
        Me.Label188.Text = "Student:"
        '
        'gbExamGraphicalAnalysis
        '
        Me.gbExamGraphicalAnalysis.Controls.Add(Me.Label190)
        Me.gbExamGraphicalAnalysis.Controls.Add(Me.cboExamGraphSection)
        Me.gbExamGraphicalAnalysis.Controls.Add(Me.cboExamGraphSessTo)
        Me.gbExamGraphicalAnalysis.Controls.Add(Me.Label183)
        Me.gbExamGraphicalAnalysis.Controls.Add(Me.cboExamGraphSessFrom)
        Me.gbExamGraphicalAnalysis.Controls.Add(Me.rbGraphPerSub)
        Me.gbExamGraphicalAnalysis.Controls.Add(Me.rbgraphperstud)
        Me.gbExamGraphicalAnalysis.Controls.Add(Me.Label184)
        Me.gbExamGraphicalAnalysis.Controls.Add(Me.cboExamGraphClass)
        Me.gbExamGraphicalAnalysis.Controls.Add(Me.Label185)
        Me.gbExamGraphicalAnalysis.Controls.Add(Me.cboExamGraphForm)
        Me.gbExamGraphicalAnalysis.Location = New System.Drawing.Point(36, 132)
        Me.gbExamGraphicalAnalysis.Name = "gbExamGraphicalAnalysis"
        Me.gbExamGraphicalAnalysis.Size = New System.Drawing.Size(30, 27)
        Me.gbExamGraphicalAnalysis.TabIndex = 47
        Me.gbExamGraphicalAnalysis.TabStop = False
        Me.gbExamGraphicalAnalysis.Text = "ExamGraphicalAnalysis"
        Me.gbExamGraphicalAnalysis.Visible = False
        '
        'Label190
        '
        Me.Label190.AutoSize = True
        Me.Label190.Location = New System.Drawing.Point(13, 86)
        Me.Label190.Name = "Label190"
        Me.Label190.Size = New System.Drawing.Size(46, 13)
        Me.Label190.TabIndex = 35
        Me.Label190.Text = "Section:"
        '
        'cboExamGraphSection
        '
        Me.cboExamGraphSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboExamGraphSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboExamGraphSection.DisplayMember = "section"
        Me.cboExamGraphSection.FormattingEnabled = True
        Me.cboExamGraphSection.Location = New System.Drawing.Point(79, 78)
        Me.cboExamGraphSection.Name = "cboExamGraphSection"
        Me.cboExamGraphSection.Size = New System.Drawing.Size(121, 21)
        Me.cboExamGraphSection.TabIndex = 34
        Me.cboExamGraphSection.ValueMember = "section"
        '
        'cboExamGraphSessTo
        '
        Me.cboExamGraphSessTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboExamGraphSessTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboExamGraphSessTo.DisplayMember = "Session"
        Me.cboExamGraphSessTo.FormattingEnabled = True
        Me.cboExamGraphSessTo.Location = New System.Drawing.Point(229, 12)
        Me.cboExamGraphSessTo.Name = "cboExamGraphSessTo"
        Me.cboExamGraphSessTo.Size = New System.Drawing.Size(78, 21)
        Me.cboExamGraphSessTo.TabIndex = 23
        Me.cboExamGraphSessTo.ValueMember = "Session"
        '
        'Label183
        '
        Me.Label183.AutoSize = True
        Me.Label183.Location = New System.Drawing.Point(202, 20)
        Me.Label183.Name = "Label183"
        Me.Label183.Size = New System.Drawing.Size(16, 13)
        Me.Label183.TabIndex = 22
        Me.Label183.Text = "to"
        '
        'cboExamGraphSessFrom
        '
        Me.cboExamGraphSessFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboExamGraphSessFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboExamGraphSessFrom.DisplayMember = "Session"
        Me.cboExamGraphSessFrom.FormattingEnabled = True
        Me.cboExamGraphSessFrom.Location = New System.Drawing.Point(111, 13)
        Me.cboExamGraphSessFrom.Name = "cboExamGraphSessFrom"
        Me.cboExamGraphSessFrom.Size = New System.Drawing.Size(78, 21)
        Me.cboExamGraphSessFrom.TabIndex = 13
        Me.cboExamGraphSessFrom.ValueMember = "Session"
        '
        'rbGraphPerSub
        '
        Me.rbGraphPerSub.AutoSize = True
        Me.rbGraphPerSub.Location = New System.Drawing.Point(156, 116)
        Me.rbGraphPerSub.Name = "rbGraphPerSub"
        Me.rbGraphPerSub.Size = New System.Drawing.Size(77, 17)
        Me.rbGraphPerSub.TabIndex = 11
        Me.rbGraphPerSub.Text = "PerSubject"
        Me.rbGraphPerSub.UseVisualStyleBackColor = True
        '
        'rbgraphperstud
        '
        Me.rbgraphperstud.AutoSize = True
        Me.rbgraphperstud.Checked = True
        Me.rbgraphperstud.Location = New System.Drawing.Point(31, 116)
        Me.rbgraphperstud.Name = "rbgraphperstud"
        Me.rbgraphperstud.Size = New System.Drawing.Size(78, 17)
        Me.rbgraphperstud.TabIndex = 10
        Me.rbgraphperstud.TabStop = True
        Me.rbgraphperstud.Text = "PerStudent"
        Me.rbgraphperstud.UseVisualStyleBackColor = True
        '
        'Label184
        '
        Me.Label184.AutoSize = True
        Me.Label184.Location = New System.Drawing.Point(13, 53)
        Me.Label184.Name = "Label184"
        Me.Label184.Size = New System.Drawing.Size(35, 13)
        Me.Label184.TabIndex = 8
        Me.Label184.Text = "Class:"
        '
        'cboExamGraphClass
        '
        Me.cboExamGraphClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboExamGraphClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboExamGraphClass.DisplayMember = "Sessions"
        Me.cboExamGraphClass.FormattingEnabled = True
        Me.cboExamGraphClass.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024"})
        Me.cboExamGraphClass.Location = New System.Drawing.Point(79, 48)
        Me.cboExamGraphClass.Name = "cboExamGraphClass"
        Me.cboExamGraphClass.Size = New System.Drawing.Size(121, 21)
        Me.cboExamGraphClass.TabIndex = 7
        Me.cboExamGraphClass.ValueMember = "Sessions"
        '
        'Label185
        '
        Me.Label185.AutoSize = True
        Me.Label185.Location = New System.Drawing.Point(13, 23)
        Me.Label185.Name = "Label185"
        Me.Label185.Size = New System.Drawing.Size(33, 13)
        Me.Label185.TabIndex = 3
        Me.Label185.Text = "Form:"
        '
        'cboExamGraphForm
        '
        Me.cboExamGraphForm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboExamGraphForm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboExamGraphForm.FormattingEnabled = True
        Me.cboExamGraphForm.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboExamGraphForm.Location = New System.Drawing.Point(55, 15)
        Me.cboExamGraphForm.Name = "cboExamGraphForm"
        Me.cboExamGraphForm.Size = New System.Drawing.Size(51, 21)
        Me.cboExamGraphForm.TabIndex = 2
        '
        'gbBorrowHistory
        '
        Me.gbBorrowHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbBorrowHistory.Controls.Add(Me.lbHistSearch)
        Me.gbBorrowHistory.Controls.Add(Me.txtHistSearch)
        Me.gbBorrowHistory.Controls.Add(Me.Label182)
        Me.gbBorrowHistory.Controls.Add(Me.rbHistoryPerBook)
        Me.gbBorrowHistory.Controls.Add(Me.rbHistoryPerStud)
        Me.gbBorrowHistory.Location = New System.Drawing.Point(142, 136)
        Me.gbBorrowHistory.Name = "gbBorrowHistory"
        Me.gbBorrowHistory.Size = New System.Drawing.Size(62, 29)
        Me.gbBorrowHistory.TabIndex = 45
        Me.gbBorrowHistory.TabStop = False
        Me.gbBorrowHistory.Text = "BorrowingHistory"
        Me.gbBorrowHistory.Visible = False
        '
        'lbHistSearch
        '
        Me.lbHistSearch.FormattingEnabled = True
        Me.lbHistSearch.Location = New System.Drawing.Point(22, 57)
        Me.lbHistSearch.Name = "lbHistSearch"
        Me.lbHistSearch.Size = New System.Drawing.Size(353, 95)
        Me.lbHistSearch.TabIndex = 4
        Me.lbHistSearch.Visible = False
        '
        'txtHistSearch
        '
        Me.txtHistSearch.Location = New System.Drawing.Point(127, 32)
        Me.txtHistSearch.Name = "txtHistSearch"
        Me.txtHistSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtHistSearch.TabIndex = 3
        '
        'Label182
        '
        Me.Label182.AutoSize = True
        Me.Label182.Location = New System.Drawing.Point(32, 40)
        Me.Label182.Name = "Label182"
        Me.Label182.Size = New System.Drawing.Size(74, 13)
        Me.Label182.TabIndex = 2
        Me.Label182.Text = "Student/Book"
        '
        'rbHistoryPerBook
        '
        Me.rbHistoryPerBook.AutoSize = True
        Me.rbHistoryPerBook.Location = New System.Drawing.Point(156, 71)
        Me.rbHistoryPerBook.Name = "rbHistoryPerBook"
        Me.rbHistoryPerBook.Size = New System.Drawing.Size(66, 17)
        Me.rbHistoryPerBook.TabIndex = 1
        Me.rbHistoryPerBook.Text = "PerBook"
        Me.rbHistoryPerBook.UseVisualStyleBackColor = True
        '
        'rbHistoryPerStud
        '
        Me.rbHistoryPerStud.AutoSize = True
        Me.rbHistoryPerStud.Checked = True
        Me.rbHistoryPerStud.Location = New System.Drawing.Point(27, 73)
        Me.rbHistoryPerStud.Name = "rbHistoryPerStud"
        Me.rbHistoryPerStud.Size = New System.Drawing.Size(78, 17)
        Me.rbHistoryPerStud.TabIndex = 0
        Me.rbHistoryPerStud.TabStop = True
        Me.rbHistoryPerStud.Text = "PerStudent"
        Me.rbHistoryPerStud.UseVisualStyleBackColor = True
        '
        'gbDueBy
        '
        Me.gbDueBy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbDueBy.Controls.Add(Me.dtpDueDate)
        Me.gbDueBy.Controls.Add(Me.Label181)
        Me.gbDueBy.Location = New System.Drawing.Point(651, 36)
        Me.gbDueBy.Name = "gbDueBy"
        Me.gbDueBy.Size = New System.Drawing.Size(28, 28)
        Me.gbDueBy.TabIndex = 44
        Me.gbDueBy.TabStop = False
        Me.gbDueBy.Text = "DueBy"
        Me.gbDueBy.Visible = False
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDueDate.Location = New System.Drawing.Point(82, 48)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(151, 20)
        Me.dtpDueDate.TabIndex = 2
        '
        'Label181
        '
        Me.Label181.AutoSize = True
        Me.Label181.Location = New System.Drawing.Point(46, 55)
        Me.Label181.Name = "Label181"
        Me.Label181.Size = New System.Drawing.Size(33, 13)
        Me.Label181.TabIndex = 1
        Me.Label181.Text = "Date:"
        '
        'gbCreditors
        '
        Me.gbCreditors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbCreditors.Controls.Add(Me.lbCreditors)
        Me.gbCreditors.Controls.Add(Me.txtCrCreditor)
        Me.gbCreditors.Controls.Add(Me.Label180)
        Me.gbCreditors.Controls.Add(Me.Label179)
        Me.gbCreditors.Controls.Add(Me.Label178)
        Me.gbCreditors.Controls.Add(Me.cboCrPrdTo)
        Me.gbCreditors.Controls.Add(Me.cboCrPrdFrm)
        Me.gbCreditors.Controls.Add(Me.rbAllCreditors)
        Me.gbCreditors.Controls.Add(Me.rbCreditorStat)
        Me.gbCreditors.Location = New System.Drawing.Point(114, 62)
        Me.gbCreditors.Name = "gbCreditors"
        Me.gbCreditors.Size = New System.Drawing.Size(38, 30)
        Me.gbCreditors.TabIndex = 43
        Me.gbCreditors.TabStop = False
        Me.gbCreditors.Text = "Creditors"
        Me.gbCreditors.Visible = False
        '
        'lbCreditors
        '
        Me.lbCreditors.FormattingEnabled = True
        Me.lbCreditors.Location = New System.Drawing.Point(185, 62)
        Me.lbCreditors.Name = "lbCreditors"
        Me.lbCreditors.Size = New System.Drawing.Size(173, 95)
        Me.lbCreditors.TabIndex = 14
        Me.lbCreditors.Visible = False
        '
        'txtCrCreditor
        '
        Me.txtCrCreditor.Location = New System.Drawing.Point(76, 41)
        Me.txtCrCreditor.Name = "txtCrCreditor"
        Me.txtCrCreditor.Size = New System.Drawing.Size(136, 20)
        Me.txtCrCreditor.TabIndex = 13
        '
        'Label180
        '
        Me.Label180.AutoSize = True
        Me.Label180.Location = New System.Drawing.Point(7, 48)
        Me.Label180.Name = "Label180"
        Me.Label180.Size = New System.Drawing.Size(46, 13)
        Me.Label180.TabIndex = 12
        Me.Label180.Text = "Creditor:"
        '
        'Label179
        '
        Me.Label179.AutoSize = True
        Me.Label179.Location = New System.Drawing.Point(185, 83)
        Me.Label179.Name = "Label179"
        Me.Label179.Size = New System.Drawing.Size(23, 13)
        Me.Label179.TabIndex = 11
        Me.Label179.Text = "To:"
        '
        'Label178
        '
        Me.Label178.AutoSize = True
        Me.Label178.Location = New System.Drawing.Point(6, 81)
        Me.Label178.Name = "Label178"
        Me.Label178.Size = New System.Drawing.Size(63, 13)
        Me.Label178.TabIndex = 10
        Me.Label178.Text = "PeriodFrom:"
        '
        'cboCrPrdTo
        '
        Me.cboCrPrdTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCrPrdTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCrPrdTo.DisplayMember = "Period"
        Me.cboCrPrdTo.FormattingEnabled = True
        Me.cboCrPrdTo.Location = New System.Drawing.Point(221, 78)
        Me.cboCrPrdTo.Name = "cboCrPrdTo"
        Me.cboCrPrdTo.Size = New System.Drawing.Size(121, 21)
        Me.cboCrPrdTo.TabIndex = 9
        Me.cboCrPrdTo.ValueMember = "Period"
        '
        'cboCrPrdFrm
        '
        Me.cboCrPrdFrm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCrPrdFrm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCrPrdFrm.DisplayMember = "Period"
        Me.cboCrPrdFrm.FormattingEnabled = True
        Me.cboCrPrdFrm.Location = New System.Drawing.Point(77, 75)
        Me.cboCrPrdFrm.Name = "cboCrPrdFrm"
        Me.cboCrPrdFrm.Size = New System.Drawing.Size(105, 21)
        Me.cboCrPrdFrm.TabIndex = 8
        Me.cboCrPrdFrm.ValueMember = "Period"
        '
        'rbAllCreditors
        '
        Me.rbAllCreditors.AutoSize = True
        Me.rbAllCreditors.Location = New System.Drawing.Point(147, 111)
        Me.rbAllCreditors.Name = "rbAllCreditors"
        Me.rbAllCreditors.Size = New System.Drawing.Size(77, 17)
        Me.rbAllCreditors.TabIndex = 7
        Me.rbAllCreditors.Text = "AllCreditors"
        Me.rbAllCreditors.UseVisualStyleBackColor = True
        '
        'rbCreditorStat
        '
        Me.rbCreditorStat.AutoSize = True
        Me.rbCreditorStat.Checked = True
        Me.rbCreditorStat.Location = New System.Drawing.Point(4, 113)
        Me.rbCreditorStat.Name = "rbCreditorStat"
        Me.rbCreditorStat.Size = New System.Drawing.Size(118, 17)
        Me.rbCreditorStat.TabIndex = 6
        Me.rbCreditorStat.TabStop = True
        Me.rbCreditorStat.Text = "IndividualStatement"
        Me.rbCreditorStat.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label162)
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Controls.Add(Me.Label163)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label164)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.Label165)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.ComboBox4)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.Label166)
        Me.GroupBox3.Controls.Add(Me.ComboBox5)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.ComboBox14)
        Me.GroupBox3.Controls.Add(Me.ListBox3)
        Me.GroupBox3.Controls.Add(Me.Label167)
        Me.GroupBox3.Controls.Add(Me.Label168)
        Me.GroupBox3.Controls.Add(Me.ComboBox15)
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
        Me.GroupBox3.Controls.Add(Me.ComboBox16)
        Me.GroupBox3.Controls.Add(Me.Label169)
        Me.GroupBox3.Controls.Add(Me.ComboBox17)
        Me.GroupBox3.Controls.Add(Me.Label170)
        Me.GroupBox3.Controls.Add(Me.ComboBox18)
        Me.GroupBox3.Controls.Add(Me.Label171)
        Me.GroupBox3.Controls.Add(Me.ComboBox19)
        Me.GroupBox3.Controls.Add(Me.Label172)
        Me.GroupBox3.Controls.Add(Me.ComboBox20)
        Me.GroupBox3.Controls.Add(Me.Label173)
        Me.GroupBox3.Controls.Add(Me.ComboBox21)
        Me.GroupBox3.Controls.Add(Me.Label174)
        Me.GroupBox3.Controls.Add(Me.ComboBox22)
        Me.GroupBox3.Controls.Add(Me.Label175)
        Me.GroupBox3.Controls.Add(Me.ComboBox23)
        Me.GroupBox3.Controls.Add(Me.Label176)
        Me.GroupBox3.Controls.Add(Me.ComboBox24)
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Location = New System.Drawing.Point(875, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(63, 29)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Accounting"
        Me.GroupBox3.Visible = False
        '
        'Label162
        '
        Me.Label162.AutoSize = True
        Me.Label162.Location = New System.Drawing.Point(388, 161)
        Me.Label162.Name = "Label162"
        Me.Label162.Size = New System.Drawing.Size(110, 13)
        Me.Label162.TabIndex = 50
        Me.Label162.Text = "Statement Information"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(386, 177)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(290, 96)
        Me.RichTextBox1.TabIndex = 49
        Me.RichTextBox1.Text = ""
        '
        'Label163
        '
        Me.Label163.AutoSize = True
        Me.Label163.Location = New System.Drawing.Point(498, 132)
        Me.Label163.Name = "Label163"
        Me.Label163.Size = New System.Drawing.Size(43, 13)
        Me.Label163.TabIndex = 48
        Me.Label163.Text = "Status :"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DisplayMember = "SubjectID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Available", "Transferred", "Outgoing"})
        Me.ComboBox1.Location = New System.Drawing.Point(562, 123)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 47
        Me.ComboBox1.ValueMember = "SubjectID"
        '
        'Label164
        '
        Me.Label164.AutoSize = True
        Me.Label164.Location = New System.Drawing.Point(174, 129)
        Me.Label164.Name = "Label164"
        Me.Label164.Size = New System.Drawing.Size(20, 13)
        Me.Label164.TabIndex = 46
        Me.Label164.Text = "To"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.ComboBox2.Location = New System.Drawing.Point(198, 122)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(69, 21)
        Me.ComboBox2.TabIndex = 45
        '
        'Label165
        '
        Me.Label165.AutoSize = True
        Me.Label165.Location = New System.Drawing.Point(216, 182)
        Me.Label165.Name = "Label165"
        Me.Label165.Size = New System.Drawing.Size(20, 13)
        Me.Label165.TabIndex = 44
        Me.Label165.Text = "To"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DisplayMember = "Session"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(305, 175)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(54, 21)
        Me.ComboBox3.TabIndex = 43
        Me.ComboBox3.ValueMember = "Session"
        '
        'ComboBox4
        '
        Me.ComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox4.DisplayMember = "SubjectID"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox4.Location = New System.Drawing.Point(238, 177)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(62, 21)
        Me.ComboBox4.TabIndex = 40
        Me.ComboBox4.ValueMember = "SubjectID"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(331, 289)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(103, 17)
        Me.RadioButton1.TabIndex = 39
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ClassStatements"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label166
        '
        Me.Label166.AutoSize = True
        Me.Label166.Location = New System.Drawing.Point(9, 291)
        Me.Label166.Name = "Label166"
        Me.Label166.Size = New System.Drawing.Size(34, 13)
        Me.Label166.TabIndex = 38
        Me.Label166.Text = "Type:"
        '
        'ComboBox5
        '
        Me.ComboBox5.DisplayMember = "Payment"
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(45, 285)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox5.TabIndex = 37
        Me.ComboBox5.ValueMember = "Payment"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(216, 289)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(110, 17)
        Me.RadioButton2.TabIndex = 36
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "StudentStatement"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(542, 286)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(110, 17)
        Me.RadioButton3.TabIndex = 35
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "DebtorsBySection"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'ComboBox14
        '
        Me.ComboBox14.FormattingEnabled = True
        Me.ComboBox14.Location = New System.Drawing.Point(91, 41)
        Me.ComboBox14.Name = "ComboBox14"
        Me.ComboBox14.Size = New System.Drawing.Size(261, 21)
        Me.ComboBox14.TabIndex = 34
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.Color.LightYellow
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(91, 61)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(261, 30)
        Me.ListBox3.TabIndex = 33
        Me.ListBox3.Visible = False
        '
        'Label167
        '
        Me.Label167.AutoSize = True
        Me.Label167.Location = New System.Drawing.Point(11, 44)
        Me.Label167.Name = "Label167"
        Me.Label167.Size = New System.Drawing.Size(47, 13)
        Me.Label167.TabIndex = 31
        Me.Label167.Text = "Student:"
        '
        'Label168
        '
        Me.Label168.AutoSize = True
        Me.Label168.Location = New System.Drawing.Point(305, 127)
        Me.Label168.Name = "Label168"
        Me.Label168.Size = New System.Drawing.Size(46, 13)
        Me.Label168.TabIndex = 29
        Me.Label168.Text = "Section:"
        '
        'ComboBox15
        '
        Me.ComboBox15.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox15.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox15.DisplayMember = "SubjectID"
        Me.ComboBox15.FormattingEnabled = True
        Me.ComboBox15.Items.AddRange(New Object() {"Business School", "IT", "High School"})
        Me.ComboBox15.Location = New System.Drawing.Point(360, 124)
        Me.ComboBox15.Name = "ComboBox15"
        Me.ComboBox15.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox15.TabIndex = 28
        Me.ComboBox15.ValueMember = "SubjectID"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(440, 287)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton4.TabIndex = 27
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "DebtorsByClass"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'ComboBox16
        '
        Me.ComboBox16.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox16.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox16.DisplayMember = "Session"
        Me.ComboBox16.FormattingEnabled = True
        Me.ComboBox16.Location = New System.Drawing.Point(153, 178)
        Me.ComboBox16.Name = "ComboBox16"
        Me.ComboBox16.Size = New System.Drawing.Size(54, 21)
        Me.ComboBox16.TabIndex = 25
        Me.ComboBox16.ValueMember = "Session"
        '
        'Label169
        '
        Me.Label169.AutoSize = True
        Me.Label169.Location = New System.Drawing.Point(8, 97)
        Me.Label169.Name = "Label169"
        Me.Label169.Size = New System.Drawing.Size(46, 13)
        Me.Label169.TabIndex = 24
        Me.Label169.Text = "Subject:"
        '
        'ComboBox17
        '
        Me.ComboBox17.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox17.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox17.DisplayMember = "SubjectID"
        Me.ComboBox17.FormattingEnabled = True
        Me.ComboBox17.Location = New System.Drawing.Point(91, 95)
        Me.ComboBox17.Name = "ComboBox17"
        Me.ComboBox17.Size = New System.Drawing.Size(278, 21)
        Me.ComboBox17.TabIndex = 23
        Me.ComboBox17.ValueMember = "SubjectID"
        '
        'Label170
        '
        Me.Label170.AutoSize = True
        Me.Label170.Location = New System.Drawing.Point(190, 239)
        Me.Label170.Name = "Label170"
        Me.Label170.Size = New System.Drawing.Size(59, 13)
        Me.Label170.TabIndex = 22
        Me.Label170.Text = "Period To :"
        '
        'ComboBox18
        '
        Me.ComboBox18.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox18.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox18.DisplayMember = "Period"
        Me.ComboBox18.FormattingEnabled = True
        Me.ComboBox18.Location = New System.Drawing.Point(255, 232)
        Me.ComboBox18.Name = "ComboBox18"
        Me.ComboBox18.Size = New System.Drawing.Size(119, 21)
        Me.ComboBox18.TabIndex = 21
        Me.ComboBox18.ValueMember = "Period"
        '
        'Label171
        '
        Me.Label171.AutoSize = True
        Me.Label171.Location = New System.Drawing.Point(3, 239)
        Me.Label171.Name = "Label171"
        Me.Label171.Size = New System.Drawing.Size(69, 13)
        Me.Label171.TabIndex = 20
        Me.Label171.Text = "Period From :"
        '
        'ComboBox19
        '
        Me.ComboBox19.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox19.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox19.DisplayMember = "Period"
        Me.ComboBox19.FormattingEnabled = True
        Me.ComboBox19.Location = New System.Drawing.Point(86, 231)
        Me.ComboBox19.Name = "ComboBox19"
        Me.ComboBox19.Size = New System.Drawing.Size(90, 21)
        Me.ComboBox19.TabIndex = 19
        Me.ComboBox19.ValueMember = "Period"
        '
        'Label172
        '
        Me.Label172.AutoSize = True
        Me.Label172.Location = New System.Drawing.Point(11, 207)
        Me.Label172.Name = "Label172"
        Me.Label172.Size = New System.Drawing.Size(34, 13)
        Me.Label172.TabIndex = 18
        Me.Label172.Text = "Term:"
        '
        'ComboBox20
        '
        Me.ComboBox20.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox20.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox20.DisplayMember = "SubjectID"
        Me.ComboBox20.FormattingEnabled = True
        Me.ComboBox20.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.ComboBox20.Location = New System.Drawing.Point(86, 204)
        Me.ComboBox20.Name = "ComboBox20"
        Me.ComboBox20.Size = New System.Drawing.Size(62, 21)
        Me.ComboBox20.TabIndex = 17
        Me.ComboBox20.ValueMember = "SubjectID"
        '
        'Label173
        '
        Me.Label173.AutoSize = True
        Me.Label173.Location = New System.Drawing.Point(10, 182)
        Me.Label173.Name = "Label173"
        Me.Label173.Size = New System.Drawing.Size(33, 13)
        Me.Label173.TabIndex = 16
        Me.Label173.Text = "Form:"
        '
        'ComboBox21
        '
        Me.ComboBox21.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox21.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox21.DisplayMember = "SubjectID"
        Me.ComboBox21.FormattingEnabled = True
        Me.ComboBox21.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox21.Location = New System.Drawing.Point(86, 177)
        Me.ComboBox21.Name = "ComboBox21"
        Me.ComboBox21.Size = New System.Drawing.Size(62, 21)
        Me.ComboBox21.TabIndex = 15
        Me.ComboBox21.ValueMember = "SubjectID"
        '
        'Label174
        '
        Me.Label174.AutoSize = True
        Me.Label174.Location = New System.Drawing.Point(11, 154)
        Me.Label174.Name = "Label174"
        Me.Label174.Size = New System.Drawing.Size(40, 13)
        Me.Label174.TabIndex = 14
        Me.Label174.Text = "Intake:"
        '
        'ComboBox22
        '
        Me.ComboBox22.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox22.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox22.DisplayMember = "SubjectID"
        Me.ComboBox22.FormattingEnabled = True
        Me.ComboBox22.Items.AddRange(New Object() {"January", "February", "March", "April ", "May ", "June", "July", "August", "September ", "October", "November", "December"})
        Me.ComboBox22.Location = New System.Drawing.Point(91, 148)
        Me.ComboBox22.Name = "ComboBox22"
        Me.ComboBox22.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox22.TabIndex = 13
        Me.ComboBox22.ValueMember = "SubjectID"
        '
        'Label175
        '
        Me.Label175.AutoSize = True
        Me.Label175.Location = New System.Drawing.Point(11, 120)
        Me.Label175.Name = "Label175"
        Me.Label175.Size = New System.Drawing.Size(32, 13)
        Me.Label175.TabIndex = 10
        Me.Label175.Text = "Year:"
        '
        'ComboBox23
        '
        Me.ComboBox23.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox23.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox23.FormattingEnabled = True
        Me.ComboBox23.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.ComboBox23.Location = New System.Drawing.Point(91, 123)
        Me.ComboBox23.Name = "ComboBox23"
        Me.ComboBox23.Size = New System.Drawing.Size(77, 21)
        Me.ComboBox23.TabIndex = 9
        '
        'Label176
        '
        Me.Label176.AutoSize = True
        Me.Label176.Location = New System.Drawing.Point(9, 68)
        Me.Label176.Name = "Label176"
        Me.Label176.Size = New System.Drawing.Size(49, 13)
        Me.Label176.TabIndex = 8
        Me.Label176.Text = "Program:"
        '
        'ComboBox24
        '
        Me.ComboBox24.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox24.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox24.DisplayMember = "Forms"
        Me.ComboBox24.FormattingEnabled = True
        Me.ComboBox24.Location = New System.Drawing.Point(92, 66)
        Me.ComboBox24.Name = "ComboBox24"
        Me.ComboBox24.Size = New System.Drawing.Size(310, 21)
        Me.ComboBox24.TabIndex = 7
        Me.ComboBox24.ValueMember = "Forms"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(128, 289)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "ClassPymnts"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'gbIncomeExpenditure
        '
        Me.gbIncomeExpenditure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbIncomeExpenditure.Controls.Add(Me.rbIncExpDetailed)
        Me.gbIncomeExpenditure.Controls.Add(Me.rbIncExpSummary)
        Me.gbIncomeExpenditure.Controls.Add(Me.cboIncomeExpenditureCart)
        Me.gbIncomeExpenditure.Controls.Add(Me.Label177)
        Me.gbIncomeExpenditure.Controls.Add(Me.dtpIncExpDateTo)
        Me.gbIncomeExpenditure.Controls.Add(Me.dtpIncExpDatefrom)
        Me.gbIncomeExpenditure.Controls.Add(Me.Label160)
        Me.gbIncomeExpenditure.Controls.Add(Me.Label161)
        Me.gbIncomeExpenditure.Location = New System.Drawing.Point(216, 133)
        Me.gbIncomeExpenditure.Name = "gbIncomeExpenditure"
        Me.gbIncomeExpenditure.Size = New System.Drawing.Size(24, 18)
        Me.gbIncomeExpenditure.TabIndex = 41
        Me.gbIncomeExpenditure.TabStop = False
        Me.gbIncomeExpenditure.Text = "IncomeExpenditure"
        Me.gbIncomeExpenditure.Visible = False
        '
        'rbIncExpDetailed
        '
        Me.rbIncExpDetailed.AutoSize = True
        Me.rbIncExpDetailed.Location = New System.Drawing.Point(145, 127)
        Me.rbIncExpDetailed.Name = "rbIncExpDetailed"
        Me.rbIncExpDetailed.Size = New System.Drawing.Size(64, 17)
        Me.rbIncExpDetailed.TabIndex = 9
        Me.rbIncExpDetailed.Text = "Detailed"
        Me.rbIncExpDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbIncExpDetailed.UseVisualStyleBackColor = True
        '
        'rbIncExpSummary
        '
        Me.rbIncExpSummary.AutoSize = True
        Me.rbIncExpSummary.Checked = True
        Me.rbIncExpSummary.Location = New System.Drawing.Point(28, 127)
        Me.rbIncExpSummary.Name = "rbIncExpSummary"
        Me.rbIncExpSummary.Size = New System.Drawing.Size(68, 17)
        Me.rbIncExpSummary.TabIndex = 8
        Me.rbIncExpSummary.TabStop = True
        Me.rbIncExpSummary.Text = "Summary"
        Me.rbIncExpSummary.UseVisualStyleBackColor = True
        '
        'cboIncomeExpenditureCart
        '
        Me.cboIncomeExpenditureCart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboIncomeExpenditureCart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIncomeExpenditureCart.DisplayMember = "Payment"
        Me.cboIncomeExpenditureCart.FormattingEnabled = True
        Me.cboIncomeExpenditureCart.Location = New System.Drawing.Point(85, 62)
        Me.cboIncomeExpenditureCart.Name = "cboIncomeExpenditureCart"
        Me.cboIncomeExpenditureCart.Size = New System.Drawing.Size(121, 21)
        Me.cboIncomeExpenditureCart.TabIndex = 7
        Me.cboIncomeExpenditureCart.ValueMember = "Payment"
        '
        'Label177
        '
        Me.Label177.AutoSize = True
        Me.Label177.Location = New System.Drawing.Point(20, 70)
        Me.Label177.Name = "Label177"
        Me.Label177.Size = New System.Drawing.Size(55, 13)
        Me.Label177.TabIndex = 6
        Me.Label177.Text = "Cartegory:"
        '
        'dtpIncExpDateTo
        '
        Me.dtpIncExpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIncExpDateTo.Location = New System.Drawing.Point(248, 93)
        Me.dtpIncExpDateTo.Name = "dtpIncExpDateTo"
        Me.dtpIncExpDateTo.Size = New System.Drawing.Size(111, 20)
        Me.dtpIncExpDateTo.TabIndex = 5
        '
        'dtpIncExpDatefrom
        '
        Me.dtpIncExpDatefrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIncExpDatefrom.Location = New System.Drawing.Point(85, 94)
        Me.dtpIncExpDatefrom.Name = "dtpIncExpDatefrom"
        Me.dtpIncExpDatefrom.Size = New System.Drawing.Size(111, 20)
        Me.dtpIncExpDatefrom.TabIndex = 4
        '
        'Label160
        '
        Me.Label160.AutoSize = True
        Me.Label160.Location = New System.Drawing.Point(206, 100)
        Me.Label160.Name = "Label160"
        Me.Label160.Size = New System.Drawing.Size(26, 13)
        Me.Label160.TabIndex = 3
        Me.Label160.Text = "And"
        '
        'Label161
        '
        Me.Label161.AutoSize = True
        Me.Label161.Location = New System.Drawing.Point(22, 97)
        Me.Label161.Name = "Label161"
        Me.Label161.Size = New System.Drawing.Size(49, 13)
        Me.Label161.TabIndex = 1
        Me.Label161.Text = "Between"
        '
        'gbBookMaster
        '
        Me.gbBookMaster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbBookMaster.Controls.Add(Me.rbSummaryPerprog)
        Me.gbBookMaster.Controls.Add(Me.rbBookSummary)
        Me.gbBookMaster.Controls.Add(Me.rbPerProgram)
        Me.gbBookMaster.Controls.Add(Me.rbPerBook)
        Me.gbBookMaster.Location = New System.Drawing.Point(430, 142)
        Me.gbBookMaster.Name = "gbBookMaster"
        Me.gbBookMaster.Size = New System.Drawing.Size(30, 24)
        Me.gbBookMaster.TabIndex = 40
        Me.gbBookMaster.TabStop = False
        Me.gbBookMaster.Text = "BookMaster"
        Me.gbBookMaster.Visible = False
        '
        'rbSummaryPerprog
        '
        Me.rbSummaryPerprog.AutoSize = True
        Me.rbSummaryPerprog.Location = New System.Drawing.Point(203, 71)
        Me.rbSummaryPerprog.Name = "rbSummaryPerprog"
        Me.rbSummaryPerprog.Size = New System.Drawing.Size(80, 17)
        Me.rbSummaryPerprog.TabIndex = 3
        Me.rbSummaryPerprog.Text = "PerProgram"
        Me.rbSummaryPerprog.UseVisualStyleBackColor = True
        '
        'rbBookSummary
        '
        Me.rbBookSummary.AutoSize = True
        Me.rbBookSummary.Location = New System.Drawing.Point(289, 71)
        Me.rbBookSummary.Name = "rbBookSummary"
        Me.rbBookSummary.Size = New System.Drawing.Size(68, 17)
        Me.rbBookSummary.TabIndex = 2
        Me.rbBookSummary.Text = "Summary"
        Me.rbBookSummary.UseVisualStyleBackColor = True
        '
        'rbPerProgram
        '
        Me.rbPerProgram.AutoSize = True
        Me.rbPerProgram.Location = New System.Drawing.Point(111, 71)
        Me.rbPerProgram.Name = "rbPerProgram"
        Me.rbPerProgram.Size = New System.Drawing.Size(77, 17)
        Me.rbPerProgram.TabIndex = 1
        Me.rbPerProgram.Text = "PerSection"
        Me.rbPerProgram.UseVisualStyleBackColor = True
        '
        'rbPerBook
        '
        Me.rbPerBook.AutoSize = True
        Me.rbPerBook.Checked = True
        Me.rbPerBook.Location = New System.Drawing.Point(40, 71)
        Me.rbPerBook.Name = "rbPerBook"
        Me.rbPerBook.Size = New System.Drawing.Size(61, 17)
        Me.rbPerBook.TabIndex = 0
        Me.rbPerBook.TabStop = True
        Me.rbPerBook.Text = "PerTitle"
        Me.rbPerBook.UseVisualStyleBackColor = True
        '
        'gbBookIssues
        '
        Me.gbBookIssues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbBookIssues.Controls.Add(Me.rbBookIssuesPerDate)
        Me.gbBookIssues.Controls.Add(Me.rbIssuesPerBook)
        Me.gbBookIssues.Controls.Add(Me.rbIssuesPerStud)
        Me.gbBookIssues.Controls.Add(Me.dtpBookIssuesTo)
        Me.gbBookIssues.Controls.Add(Me.dtpBookIssuesFrom)
        Me.gbBookIssues.Controls.Add(Me.Label158)
        Me.gbBookIssues.Controls.Add(Me.Label159)
        Me.gbBookIssues.Location = New System.Drawing.Point(254, 129)
        Me.gbBookIssues.Name = "gbBookIssues"
        Me.gbBookIssues.Size = New System.Drawing.Size(35, 26)
        Me.gbBookIssues.TabIndex = 39
        Me.gbBookIssues.TabStop = False
        Me.gbBookIssues.Text = "BookIssues"
        Me.gbBookIssues.Visible = False
        '
        'rbBookIssuesPerDate
        '
        Me.rbBookIssuesPerDate.AutoSize = True
        Me.rbBookIssuesPerDate.Location = New System.Drawing.Point(188, 66)
        Me.rbBookIssuesPerDate.Name = "rbBookIssuesPerDate"
        Me.rbBookIssuesPerDate.Size = New System.Drawing.Size(60, 17)
        Me.rbBookIssuesPerDate.TabIndex = 8
        Me.rbBookIssuesPerDate.Text = "ByDate"
        Me.rbBookIssuesPerDate.UseVisualStyleBackColor = True
        '
        'rbIssuesPerBook
        '
        Me.rbIssuesPerBook.AutoSize = True
        Me.rbIssuesPerBook.Location = New System.Drawing.Point(95, 67)
        Me.rbIssuesPerBook.Name = "rbIssuesPerBook"
        Me.rbIssuesPerBook.Size = New System.Drawing.Size(62, 17)
        Me.rbIssuesPerBook.TabIndex = 7
        Me.rbIssuesPerBook.Text = "ByBook"
        Me.rbIssuesPerBook.UseVisualStyleBackColor = True
        '
        'rbIssuesPerStud
        '
        Me.rbIssuesPerStud.AutoSize = True
        Me.rbIssuesPerStud.Checked = True
        Me.rbIssuesPerStud.Location = New System.Drawing.Point(6, 69)
        Me.rbIssuesPerStud.Name = "rbIssuesPerStud"
        Me.rbIssuesPerStud.Size = New System.Drawing.Size(74, 17)
        Me.rbIssuesPerStud.TabIndex = 6
        Me.rbIssuesPerStud.TabStop = True
        Me.rbIssuesPerStud.Text = "ByStudent"
        Me.rbIssuesPerStud.UseVisualStyleBackColor = True
        '
        'dtpBookIssuesTo
        '
        Me.dtpBookIssuesTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBookIssuesTo.Location = New System.Drawing.Point(234, 35)
        Me.dtpBookIssuesTo.Name = "dtpBookIssuesTo"
        Me.dtpBookIssuesTo.Size = New System.Drawing.Size(111, 20)
        Me.dtpBookIssuesTo.TabIndex = 5
        '
        'dtpBookIssuesFrom
        '
        Me.dtpBookIssuesFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBookIssuesFrom.Location = New System.Drawing.Point(67, 36)
        Me.dtpBookIssuesFrom.Name = "dtpBookIssuesFrom"
        Me.dtpBookIssuesFrom.Size = New System.Drawing.Size(111, 20)
        Me.dtpBookIssuesFrom.TabIndex = 4
        '
        'Label158
        '
        Me.Label158.AutoSize = True
        Me.Label158.Location = New System.Drawing.Point(191, 43)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(26, 13)
        Me.Label158.TabIndex = 3
        Me.Label158.Text = "And"
        '
        'Label159
        '
        Me.Label159.AutoSize = True
        Me.Label159.Location = New System.Drawing.Point(10, 42)
        Me.Label159.Name = "Label159"
        Me.Label159.Size = New System.Drawing.Size(49, 13)
        Me.Label159.TabIndex = 1
        Me.Label159.Text = "Between"
        '
        'gbstudentregister2
        '
        Me.gbstudentregister2.Controls.Add(Me.ListBox1)
        Me.gbstudentregister2.Controls.Add(Me.ListBox2)
        Me.gbstudentregister2.Controls.Add(Me.Label115)
        Me.gbstudentregister2.Controls.Add(Me.ComboBox6)
        Me.gbstudentregister2.Controls.Add(Me.Label116)
        Me.gbstudentregister2.Controls.Add(Me.ComboBox7)
        Me.gbstudentregister2.Controls.Add(Me.Label117)
        Me.gbstudentregister2.Controls.Add(Me.ComboBox8)
        Me.gbstudentregister2.Controls.Add(Me.Label118)
        Me.gbstudentregister2.Controls.Add(Me.ComboBox9)
        Me.gbstudentregister2.Controls.Add(Me.Label119)
        Me.gbstudentregister2.Controls.Add(Me.ComboBox10)
        Me.gbstudentregister2.Controls.Add(Me.Label120)
        Me.gbstudentregister2.Controls.Add(Me.ComboBox11)
        Me.gbstudentregister2.Controls.Add(Me.Label121)
        Me.gbstudentregister2.Controls.Add(Me.ComboBox12)
        Me.gbstudentregister2.Controls.Add(Me.Label122)
        Me.gbstudentregister2.Controls.Add(Me.ComboBox13)
        Me.gbstudentregister2.Location = New System.Drawing.Point(325, 148)
        Me.gbstudentregister2.Name = "gbstudentregister2"
        Me.gbstudentregister2.Size = New System.Drawing.Size(48, 10)
        Me.gbstudentregister2.TabIndex = 26
        Me.gbstudentregister2.TabStop = False
        Me.gbstudentregister2.Text = "SubjectRegister 2"
        Me.gbstudentregister2.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.LightYellow
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(68, 152)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(241, 4)
        Me.ListBox1.TabIndex = 29
        Me.ListBox1.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox2.BackColor = System.Drawing.Color.LightYellow
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(72, 237)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(241, 4)
        Me.ListBox2.TabIndex = 28
        Me.ListBox2.Visible = False
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Location = New System.Drawing.Point(16, 194)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(54, 13)
        Me.Label115.TabIndex = 15
        Me.Label115.Text = "Semester:"
        '
        'ComboBox6
        '
        Me.ComboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox6.DisplayMember = "Session"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.ComboBox6.Location = New System.Drawing.Point(70, 186)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(89, 21)
        Me.ComboBox6.TabIndex = 14
        Me.ComboBox6.ValueMember = "Session"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Location = New System.Drawing.Point(19, 165)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(36, 13)
        Me.Label116.TabIndex = 13
        Me.Label116.Text = "Level:"
        '
        'ComboBox7
        '
        Me.ComboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox7.DisplayMember = "Session"
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.ComboBox7.Location = New System.Drawing.Point(68, 160)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(91, 21)
        Me.ComboBox7.TabIndex = 12
        Me.ComboBox7.ValueMember = "Session"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Location = New System.Drawing.Point(19, 141)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(49, 13)
        Me.Label117.TabIndex = 11
        Me.Label117.Text = "Program:"
        '
        'ComboBox8
        '
        Me.ComboBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox8.DisplayMember = "Session"
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(68, 134)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox8.TabIndex = 10
        Me.ComboBox8.ValueMember = "Session"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Location = New System.Drawing.Point(19, 229)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(49, 13)
        Me.Label118.TabIndex = 9
        Me.Label118.Text = "Subject :"
        '
        'ComboBox9
        '
        Me.ComboBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox9.DisplayMember = "Session"
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Location = New System.Drawing.Point(73, 217)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox9.TabIndex = 8
        Me.ComboBox9.ValueMember = "Session"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Location = New System.Drawing.Point(16, 112)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(47, 13)
        Me.Label119.TabIndex = 7
        Me.Label119.Text = "Session:"
        '
        'ComboBox10
        '
        Me.ComboBox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox10.DisplayMember = "Session"
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Location = New System.Drawing.Point(66, 107)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox10.TabIndex = 6
        Me.ComboBox10.ValueMember = "Session"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Location = New System.Drawing.Point(19, 82)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(40, 13)
        Me.Label120.TabIndex = 5
        Me.Label120.Text = "Intake:"
        '
        'ComboBox11
        '
        Me.ComboBox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox11.DisplayMember = "SubjectID"
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November ", "December"})
        Me.ComboBox11.Location = New System.Drawing.Point(68, 75)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(161, 21)
        Me.ComboBox11.TabIndex = 4
        Me.ComboBox11.ValueMember = "SubjectID"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Location = New System.Drawing.Point(18, 16)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(46, 13)
        Me.Label121.TabIndex = 3
        Me.Label121.Text = "Section:"
        '
        'ComboBox12
        '
        Me.ComboBox12.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox12.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox12.DisplayMember = "SubjectID"
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Items.AddRange(New Object() {"High School", "IT", "Business School"})
        Me.ComboBox12.Location = New System.Drawing.Point(69, 13)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(163, 21)
        Me.ComboBox12.TabIndex = 2
        Me.ComboBox12.ValueMember = "SubjectID"
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Location = New System.Drawing.Point(19, 48)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(35, 13)
        Me.Label122.TabIndex = 1
        Me.Label122.Text = "Class:"
        '
        'ComboBox13
        '
        Me.ComboBox13.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox13.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox13.DisplayMember = "SubjectID"
        Me.ComboBox13.FormattingEnabled = True
        Me.ComboBox13.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.ComboBox13.Location = New System.Drawing.Point(68, 40)
        Me.ComboBox13.Name = "ComboBox13"
        Me.ComboBox13.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox13.TabIndex = 0
        Me.ComboBox13.ValueMember = "SubjectID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label156)
        Me.GroupBox2.Controls.Add(Me.Label157)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(38, 29)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SubjectsDropped"
        Me.GroupBox2.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(251, 43)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(82, 42)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker2.TabIndex = 4
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Location = New System.Drawing.Point(210, 49)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(26, 13)
        Me.Label156.TabIndex = 3
        Me.Label156.Text = "And"
        '
        'Label157
        '
        Me.Label157.AutoSize = True
        Me.Label157.Location = New System.Drawing.Point(26, 47)
        Me.Label157.Name = "Label157"
        Me.Label157.Size = New System.Drawing.Size(49, 13)
        Me.Label157.TabIndex = 1
        Me.Label157.Text = "Between"
        '
        'gbStaffRegister
        '
        Me.gbStaffRegister.Controls.Add(Me.rbStaffRegByStaff)
        Me.gbStaffRegister.Controls.Add(Me.Label41)
        Me.gbStaffRegister.Controls.Add(Me.Label152)
        Me.gbStaffRegister.Controls.Add(Me.StaffRegDateTo)
        Me.gbStaffRegister.Controls.Add(Me.staffregdatefrom)
        Me.gbStaffRegister.Controls.Add(Me.rbStaffRegByDay)
        Me.gbStaffRegister.Location = New System.Drawing.Point(374, 8)
        Me.gbStaffRegister.Name = "gbStaffRegister"
        Me.gbStaffRegister.Size = New System.Drawing.Size(28, 15)
        Me.gbStaffRegister.TabIndex = 37
        Me.gbStaffRegister.TabStop = False
        Me.gbStaffRegister.Tag = " "
        Me.gbStaffRegister.Text = "StaffRegister"
        Me.gbStaffRegister.Visible = False
        '
        'rbStaffRegByStaff
        '
        Me.rbStaffRegByStaff.AutoSize = True
        Me.rbStaffRegByStaff.Checked = True
        Me.rbStaffRegByStaff.Location = New System.Drawing.Point(100, 86)
        Me.rbStaffRegByStaff.Name = "rbStaffRegByStaff"
        Me.rbStaffRegByStaff.Size = New System.Drawing.Size(63, 17)
        Me.rbStaffRegByStaff.TabIndex = 34
        Me.rbStaffRegByStaff.TabStop = True
        Me.rbStaffRegByStaff.Text = "PerStaff"
        Me.rbStaffRegByStaff.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(192, 50)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(23, 13)
        Me.Label41.TabIndex = 21
        Me.Label41.Text = "To:"
        '
        'Label152
        '
        Me.Label152.AutoSize = True
        Me.Label152.Location = New System.Drawing.Point(59, 47)
        Me.Label152.Name = "Label152"
        Me.Label152.Size = New System.Drawing.Size(33, 13)
        Me.Label152.TabIndex = 20
        Me.Label152.Text = "From:"
        '
        'StaffRegDateTo
        '
        Me.StaffRegDateTo.Location = New System.Drawing.Point(232, 43)
        Me.StaffRegDateTo.Mask = "00/00/0000"
        Me.StaffRegDateTo.Name = "StaffRegDateTo"
        Me.StaffRegDateTo.Size = New System.Drawing.Size(85, 20)
        Me.StaffRegDateTo.TabIndex = 19
        Me.StaffRegDateTo.ValidatingType = GetType(Date)
        '
        'staffregdatefrom
        '
        Me.staffregdatefrom.Location = New System.Drawing.Point(96, 43)
        Me.staffregdatefrom.Mask = "00/00/0000"
        Me.staffregdatefrom.Name = "staffregdatefrom"
        Me.staffregdatefrom.Size = New System.Drawing.Size(85, 20)
        Me.staffregdatefrom.TabIndex = 18
        Me.staffregdatefrom.ValidatingType = GetType(Date)
        '
        'rbStaffRegByDay
        '
        Me.rbStaffRegByDay.AutoSize = True
        Me.rbStaffRegByDay.Location = New System.Drawing.Point(196, 85)
        Me.rbStaffRegByDay.Name = "rbStaffRegByDay"
        Me.rbStaffRegByDay.Size = New System.Drawing.Size(60, 17)
        Me.rbStaffRegByDay.TabIndex = 15
        Me.rbStaffRegByDay.Text = "PerDay"
        Me.rbStaffRegByDay.UseVisualStyleBackColor = True
        '
        'gbClassRegister
        '
        Me.gbClassRegister.Controls.Add(Me.rbClsRegPerStud)
        Me.gbClassRegister.Controls.Add(Me.rbClsRegHardCopy)
        Me.gbClassRegister.Controls.Add(Me.lbClsRegStud)
        Me.gbClassRegister.Controls.Add(Me.Label39)
        Me.gbClassRegister.Controls.Add(Me.Label40)
        Me.gbClassRegister.Controls.Add(Me.cboClsRegDetTo)
        Me.gbClassRegister.Controls.Add(Me.cboClsRegDetFrm)
        Me.gbClassRegister.Controls.Add(Me.rbClsRegByDay)
        Me.gbClassRegister.Controls.Add(Me.cboClsRegStud)
        Me.gbClassRegister.Controls.Add(Me.Label42)
        Me.gbClassRegister.Controls.Add(Me.cboClsRegCls)
        Me.gbClassRegister.Controls.Add(Me.Label43)
        Me.gbClassRegister.Controls.Add(Me.rbClsRegByCls)
        Me.gbClassRegister.Controls.Add(Me.Label113)
        Me.gbClassRegister.Controls.Add(Me.cboClsRegTern)
        Me.gbClassRegister.Controls.Add(Me.cboClsRegSess)
        Me.gbClassRegister.Controls.Add(Me.Label114)
        Me.gbClassRegister.Controls.Add(Me.cboClsRegForm)
        Me.gbClassRegister.Location = New System.Drawing.Point(703, 96)
        Me.gbClassRegister.Name = "gbClassRegister"
        Me.gbClassRegister.Size = New System.Drawing.Size(36, 48)
        Me.gbClassRegister.TabIndex = 36
        Me.gbClassRegister.TabStop = False
        Me.gbClassRegister.Tag = " "
        Me.gbClassRegister.Text = "ClassRegister"
        Me.gbClassRegister.Visible = False
        '
        'rbClsRegPerStud
        '
        Me.rbClsRegPerStud.AutoSize = True
        Me.rbClsRegPerStud.Checked = True
        Me.rbClsRegPerStud.Location = New System.Drawing.Point(41, 208)
        Me.rbClsRegPerStud.Name = "rbClsRegPerStud"
        Me.rbClsRegPerStud.Size = New System.Drawing.Size(78, 17)
        Me.rbClsRegPerStud.TabIndex = 34
        Me.rbClsRegPerStud.TabStop = True
        Me.rbClsRegPerStud.Text = "PerStudent"
        Me.rbClsRegPerStud.UseVisualStyleBackColor = True
        '
        'rbClsRegHardCopy
        '
        Me.rbClsRegHardCopy.AutoSize = True
        Me.rbClsRegHardCopy.Location = New System.Drawing.Point(271, 208)
        Me.rbClsRegHardCopy.Name = "rbClsRegHardCopy"
        Me.rbClsRegHardCopy.Size = New System.Drawing.Size(72, 17)
        Me.rbClsRegHardCopy.TabIndex = 33
        Me.rbClsRegHardCopy.Text = "HardCopy"
        Me.rbClsRegHardCopy.UseVisualStyleBackColor = True
        '
        'lbClsRegStud
        '
        Me.lbClsRegStud.BackColor = System.Drawing.Color.LightYellow
        Me.lbClsRegStud.FormattingEnabled = True
        Me.lbClsRegStud.Location = New System.Drawing.Point(125, 42)
        Me.lbClsRegStud.Name = "lbClsRegStud"
        Me.lbClsRegStud.Size = New System.Drawing.Size(206, 95)
        Me.lbClsRegStud.TabIndex = 32
        Me.lbClsRegStud.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(202, 165)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(23, 13)
        Me.Label39.TabIndex = 21
        Me.Label39.Text = "To:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(65, 166)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(33, 13)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "From:"
        '
        'cboClsRegDetTo
        '
        Me.cboClsRegDetTo.Location = New System.Drawing.Point(251, 157)
        Me.cboClsRegDetTo.Mask = "00/00/0000"
        Me.cboClsRegDetTo.Name = "cboClsRegDetTo"
        Me.cboClsRegDetTo.Size = New System.Drawing.Size(85, 20)
        Me.cboClsRegDetTo.TabIndex = 19
        Me.cboClsRegDetTo.ValidatingType = GetType(Date)
        '
        'cboClsRegDetFrm
        '
        Me.cboClsRegDetFrm.Location = New System.Drawing.Point(111, 156)
        Me.cboClsRegDetFrm.Mask = "00/00/0000"
        Me.cboClsRegDetFrm.Name = "cboClsRegDetFrm"
        Me.cboClsRegDetFrm.Size = New System.Drawing.Size(85, 20)
        Me.cboClsRegDetFrm.TabIndex = 18
        Me.cboClsRegDetFrm.ValidatingType = GetType(Date)
        '
        'rbClsRegByDay
        '
        Me.rbClsRegByDay.AutoSize = True
        Me.rbClsRegByDay.Location = New System.Drawing.Point(204, 208)
        Me.rbClsRegByDay.Name = "rbClsRegByDay"
        Me.rbClsRegByDay.Size = New System.Drawing.Size(60, 17)
        Me.rbClsRegByDay.TabIndex = 15
        Me.rbClsRegByDay.Text = "PerDay"
        Me.rbClsRegByDay.UseVisualStyleBackColor = True
        '
        'cboClsRegStud
        '
        Me.cboClsRegStud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClsRegStud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClsRegStud.DisplayMember = "Section"
        Me.cboClsRegStud.FormattingEnabled = True
        Me.cboClsRegStud.Location = New System.Drawing.Point(125, 20)
        Me.cboClsRegStud.Name = "cboClsRegStud"
        Me.cboClsRegStud.Size = New System.Drawing.Size(121, 21)
        Me.cboClsRegStud.TabIndex = 14
        Me.cboClsRegStud.ValueMember = "Section"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(62, 61)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(32, 13)
        Me.Label42.TabIndex = 13
        Me.Label42.Text = "Class"
        '
        'cboClsRegCls
        '
        Me.cboClsRegCls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClsRegCls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClsRegCls.DisplayMember = "Section"
        Me.cboClsRegCls.FormattingEnabled = True
        Me.cboClsRegCls.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboClsRegCls.Location = New System.Drawing.Point(125, 60)
        Me.cboClsRegCls.Name = "cboClsRegCls"
        Me.cboClsRegCls.Size = New System.Drawing.Size(121, 21)
        Me.cboClsRegCls.TabIndex = 12
        Me.cboClsRegCls.ValueMember = "Section"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(50, 27)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(44, 13)
        Me.Label43.TabIndex = 11
        Me.Label43.Text = "Student"
        '
        'rbClsRegByCls
        '
        Me.rbClsRegByCls.AutoSize = True
        Me.rbClsRegByCls.Location = New System.Drawing.Point(132, 208)
        Me.rbClsRegByCls.Name = "rbClsRegByCls"
        Me.rbClsRegByCls.Size = New System.Drawing.Size(66, 17)
        Me.rbClsRegByCls.TabIndex = 8
        Me.rbClsRegByCls.Text = "PerClass"
        Me.rbClsRegByCls.UseVisualStyleBackColor = True
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Location = New System.Drawing.Point(60, 132)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(34, 13)
        Me.Label113.TabIndex = 7
        Me.Label113.Text = "Term:"
        '
        'cboClsRegTern
        '
        Me.cboClsRegTern.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClsRegTern.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClsRegTern.FormattingEnabled = True
        Me.cboClsRegTern.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboClsRegTern.Location = New System.Drawing.Point(123, 117)
        Me.cboClsRegTern.Name = "cboClsRegTern"
        Me.cboClsRegTern.Size = New System.Drawing.Size(66, 21)
        Me.cboClsRegTern.TabIndex = 6
        '
        'cboClsRegSess
        '
        Me.cboClsRegSess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClsRegSess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClsRegSess.DisplayMember = "Section"
        Me.cboClsRegSess.FormattingEnabled = True
        Me.cboClsRegSess.Location = New System.Drawing.Point(240, 91)
        Me.cboClsRegSess.Name = "cboClsRegSess"
        Me.cboClsRegSess.Size = New System.Drawing.Size(121, 21)
        Me.cboClsRegSess.TabIndex = 2
        Me.cboClsRegSess.ValueMember = "Section"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Location = New System.Drawing.Point(61, 93)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(33, 13)
        Me.Label114.TabIndex = 1
        Me.Label114.Text = "Form:"
        '
        'cboClsRegForm
        '
        Me.cboClsRegForm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClsRegForm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClsRegForm.DisplayMember = "SubjectID"
        Me.cboClsRegForm.FormattingEnabled = True
        Me.cboClsRegForm.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboClsRegForm.Location = New System.Drawing.Point(123, 90)
        Me.cboClsRegForm.Name = "cboClsRegForm"
        Me.cboClsRegForm.Size = New System.Drawing.Size(93, 21)
        Me.cboClsRegForm.TabIndex = 0
        Me.cboClsRegForm.ValueMember = "SubjectID"
        '
        'gbSchoolProfile
        '
        Me.gbSchoolProfile.Controls.Add(Me.rbSchoolCurricula)
        Me.gbSchoolProfile.Controls.Add(Me.rbSchoolParticulars)
        Me.gbSchoolProfile.Location = New System.Drawing.Point(443, 92)
        Me.gbSchoolProfile.Name = "gbSchoolProfile"
        Me.gbSchoolProfile.Size = New System.Drawing.Size(54, 38)
        Me.gbSchoolProfile.TabIndex = 35
        Me.gbSchoolProfile.TabStop = False
        Me.gbSchoolProfile.Text = "SchoolProfile"
        Me.gbSchoolProfile.Visible = False
        '
        'rbSchoolCurricula
        '
        Me.rbSchoolCurricula.AutoSize = True
        Me.rbSchoolCurricula.Location = New System.Drawing.Point(132, 57)
        Me.rbSchoolCurricula.Name = "rbSchoolCurricula"
        Me.rbSchoolCurricula.Size = New System.Drawing.Size(66, 17)
        Me.rbSchoolCurricula.TabIndex = 28
        Me.rbSchoolCurricula.TabStop = True
        Me.rbSchoolCurricula.Text = "Curricula"
        Me.rbSchoolCurricula.UseVisualStyleBackColor = True
        '
        'rbSchoolParticulars
        '
        Me.rbSchoolParticulars.AutoSize = True
        Me.rbSchoolParticulars.Location = New System.Drawing.Point(15, 58)
        Me.rbSchoolParticulars.Name = "rbSchoolParticulars"
        Me.rbSchoolParticulars.Size = New System.Drawing.Size(74, 17)
        Me.rbSchoolParticulars.TabIndex = 27
        Me.rbSchoolParticulars.TabStop = True
        Me.rbSchoolParticulars.Text = "Particulars"
        Me.rbSchoolParticulars.UseVisualStyleBackColor = True
        '
        'gbHsStudMarks
        '
        Me.gbHsStudMarks.Controls.Add(Me.gbCustomEmailmsg)
        Me.gbHsStudMarks.Controls.Add(Me.gbGraphicalView)
        Me.gbHsStudMarks.Controls.Add(Me.gbPublishOptions)
        Me.gbHsStudMarks.Controls.Add(Me.Label189)
        Me.gbHsStudMarks.Controls.Add(Me.cboHsMarksSect)
        Me.gbHsStudMarks.Controls.Add(Me.Panel2)
        Me.gbHsStudMarks.Controls.Add(Me.rbConsolMarkSheet)
        Me.gbHsStudMarks.Controls.Add(Me.lbMarksPerStud)
        Me.gbHsStudMarks.Controls.Add(Me.rbReportPerStud)
        Me.gbHsStudMarks.Controls.Add(Me.cboHsMarksStud)
        Me.gbHsStudMarks.Controls.Add(Me.Label187)
        Me.gbHsStudMarks.Controls.Add(Me.rbpub)
        Me.gbHsStudMarks.Controls.Add(Me.cboHsMarksSess)
        Me.gbHsStudMarks.Controls.Add(Me.rbHsReportPerClass)
        Me.gbHsStudMarks.Controls.Add(Me.rbHsMarksPerSubject)
        Me.gbHsStudMarks.Controls.Add(Me.rbHsMarksPerClass)
        Me.gbHsStudMarks.Controls.Add(Me.Label36)
        Me.gbHsStudMarks.Controls.Add(Me.cboHsMarksRef)
        Me.gbHsStudMarks.Controls.Add(Me.Label38)
        Me.gbHsStudMarks.Controls.Add(Me.cboHsMarksLev)
        Me.gbHsStudMarks.Location = New System.Drawing.Point(781, 65)
        Me.gbHsStudMarks.Name = "gbHsStudMarks"
        Me.gbHsStudMarks.Size = New System.Drawing.Size(123, 26)
        Me.gbHsStudMarks.TabIndex = 0
        Me.gbHsStudMarks.TabStop = False
        Me.gbHsStudMarks.Text = "ExamMark"
        Me.gbHsStudMarks.Visible = False
        '
        'gbCustomEmailmsg
        '
        Me.gbCustomEmailmsg.Controls.Add(Me.txtCustomEmailmsg)
        Me.gbCustomEmailmsg.Location = New System.Drawing.Point(248, 113)
        Me.gbCustomEmailmsg.Name = "gbCustomEmailmsg"
        Me.gbCustomEmailmsg.Size = New System.Drawing.Size(297, 66)
        Me.gbCustomEmailmsg.TabIndex = 36
        Me.gbCustomEmailmsg.TabStop = False
        Me.gbCustomEmailmsg.Text = "Custom Email Message"
        Me.gbCustomEmailmsg.Visible = False
        '
        'txtCustomEmailmsg
        '
        Me.txtCustomEmailmsg.Location = New System.Drawing.Point(12, 20)
        Me.txtCustomEmailmsg.Multiline = True
        Me.txtCustomEmailmsg.Name = "txtCustomEmailmsg"
        Me.txtCustomEmailmsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCustomEmailmsg.Size = New System.Drawing.Size(274, 39)
        Me.txtCustomEmailmsg.TabIndex = 0
        '
        'gbGraphicalView
        '
        Me.gbGraphicalView.Controls.Add(Me.chkGraphical)
        Me.gbGraphicalView.Location = New System.Drawing.Point(71, 136)
        Me.gbGraphicalView.Name = "gbGraphicalView"
        Me.gbGraphicalView.Size = New System.Drawing.Size(153, 43)
        Me.gbGraphicalView.TabIndex = 35
        Me.gbGraphicalView.TabStop = False
        Me.gbGraphicalView.Visible = False
        '
        'chkGraphical
        '
        Me.chkGraphical.AutoSize = True
        Me.chkGraphical.Location = New System.Drawing.Point(13, 19)
        Me.chkGraphical.Name = "chkGraphical"
        Me.chkGraphical.Size = New System.Drawing.Size(97, 17)
        Me.chkGraphical.TabIndex = 31
        Me.chkGraphical.Text = "Graphical View"
        Me.chkGraphical.UseVisualStyleBackColor = True
        '
        'gbPublishOptions
        '
        Me.gbPublishOptions.Controls.Add(Me.rbPublishPerExam)
        Me.gbPublishOptions.Controls.Add(Me.RbPublishPerClass)
        Me.gbPublishOptions.Controls.Add(Me.chkPublish)
        Me.gbPublishOptions.Location = New System.Drawing.Point(76, 136)
        Me.gbPublishOptions.Name = "gbPublishOptions"
        Me.gbPublishOptions.Size = New System.Drawing.Size(240, 43)
        Me.gbPublishOptions.TabIndex = 34
        Me.gbPublishOptions.TabStop = False
        Me.gbPublishOptions.Text = "Publish Options"
        '
        'rbPublishPerExam
        '
        Me.rbPublishPerExam.AutoSize = True
        Me.rbPublishPerExam.Location = New System.Drawing.Point(82, 17)
        Me.rbPublishPerExam.Name = "rbPublishPerExam"
        Me.rbPublishPerExam.Size = New System.Drawing.Size(67, 17)
        Me.rbPublishPerExam.TabIndex = 33
        Me.rbPublishPerExam.Text = "PerExam"
        Me.rbPublishPerExam.UseVisualStyleBackColor = True
        '
        'RbPublishPerClass
        '
        Me.RbPublishPerClass.AutoSize = True
        Me.RbPublishPerClass.Checked = True
        Me.RbPublishPerClass.Location = New System.Drawing.Point(7, 17)
        Me.RbPublishPerClass.Name = "RbPublishPerClass"
        Me.RbPublishPerClass.Size = New System.Drawing.Size(66, 17)
        Me.RbPublishPerClass.TabIndex = 32
        Me.RbPublishPerClass.TabStop = True
        Me.RbPublishPerClass.Text = "PerClass"
        Me.RbPublishPerClass.UseVisualStyleBackColor = True
        '
        'chkPublish
        '
        Me.chkPublish.AutoSize = True
        Me.chkPublish.Checked = True
        Me.chkPublish.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPublish.Location = New System.Drawing.Point(162, 18)
        Me.chkPublish.Name = "chkPublish"
        Me.chkPublish.Size = New System.Drawing.Size(60, 17)
        Me.chkPublish.TabIndex = 31
        Me.chkPublish.Text = "Publish"
        Me.chkPublish.UseVisualStyleBackColor = True
        '
        'Label189
        '
        Me.Label189.AutoSize = True
        Me.Label189.Location = New System.Drawing.Point(17, 120)
        Me.Label189.Name = "Label189"
        Me.Label189.Size = New System.Drawing.Size(46, 13)
        Me.Label189.TabIndex = 33
        Me.Label189.Text = "Section:"
        '
        'cboHsMarksSect
        '
        Me.cboHsMarksSect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboHsMarksSect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboHsMarksSect.DisplayMember = "section"
        Me.cboHsMarksSect.FormattingEnabled = True
        Me.cboHsMarksSect.Location = New System.Drawing.Point(79, 112)
        Me.cboHsMarksSect.Name = "cboHsMarksSect"
        Me.cboHsMarksSect.Size = New System.Drawing.Size(159, 21)
        Me.cboHsMarksSect.TabIndex = 32
        Me.cboHsMarksSect.ValueMember = "section"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbBooklet)
        Me.Panel2.Controls.Add(Me.chkEmail)
        Me.Panel2.Controls.Add(Me.rbA4)
        Me.Panel2.Location = New System.Drawing.Point(248, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(260, 26)
        Me.Panel2.TabIndex = 31
        '
        'rbBooklet
        '
        Me.rbBooklet.AutoSize = True
        Me.rbBooklet.Checked = True
        Me.rbBooklet.Location = New System.Drawing.Point(91, 4)
        Me.rbBooklet.Name = "rbBooklet"
        Me.rbBooklet.Size = New System.Drawing.Size(61, 17)
        Me.rbBooklet.TabIndex = 1
        Me.rbBooklet.TabStop = True
        Me.rbBooklet.Text = "Booklet"
        Me.rbBooklet.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(3, 4)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(88, 17)
        Me.chkEmail.TabIndex = 30
        Me.chkEmail.Text = "EmailReports"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'rbA4
        '
        Me.rbA4.AutoSize = True
        Me.rbA4.Location = New System.Drawing.Point(155, 4)
        Me.rbA4.Name = "rbA4"
        Me.rbA4.Size = New System.Drawing.Size(61, 17)
        Me.rbA4.TabIndex = 0
        Me.rbA4.Text = "A4 Size"
        Me.rbA4.UseVisualStyleBackColor = True
        Me.rbA4.Visible = False
        '
        'rbConsolMarkSheet
        '
        Me.rbConsolMarkSheet.AutoSize = True
        Me.rbConsolMarkSheet.Location = New System.Drawing.Point(491, 182)
        Me.rbConsolMarkSheet.Name = "rbConsolMarkSheet"
        Me.rbConsolMarkSheet.Size = New System.Drawing.Size(109, 17)
        Me.rbConsolMarkSheet.TabIndex = 28
        Me.rbConsolMarkSheet.Text = "ConsolMarkSheet"
        Me.rbConsolMarkSheet.UseVisualStyleBackColor = True
        '
        'lbMarksPerStud
        '
        Me.lbMarksPerStud.FormattingEnabled = True
        Me.lbMarksPerStud.Location = New System.Drawing.Point(6, 51)
        Me.lbMarksPerStud.Name = "lbMarksPerStud"
        Me.lbMarksPerStud.Size = New System.Drawing.Size(234, 56)
        Me.lbMarksPerStud.TabIndex = 27
        Me.lbMarksPerStud.Visible = False
        '
        'rbReportPerStud
        '
        Me.rbReportPerStud.AutoSize = True
        Me.rbReportPerStud.Location = New System.Drawing.Point(278, 184)
        Me.rbReportPerStud.Name = "rbReportPerStud"
        Me.rbReportPerStud.Size = New System.Drawing.Size(94, 17)
        Me.rbReportPerStud.TabIndex = 1
        Me.rbReportPerStud.Text = "StudentReport"
        Me.rbReportPerStud.UseVisualStyleBackColor = True
        '
        'cboHsMarksStud
        '
        Me.cboHsMarksStud.Location = New System.Drawing.Point(78, 30)
        Me.cboHsMarksStud.Name = "cboHsMarksStud"
        Me.cboHsMarksStud.Size = New System.Drawing.Size(159, 20)
        Me.cboHsMarksStud.TabIndex = 26
        '
        'Label187
        '
        Me.Label187.AutoSize = True
        Me.Label187.Location = New System.Drawing.Point(15, 35)
        Me.Label187.Name = "Label187"
        Me.Label187.Size = New System.Drawing.Size(47, 13)
        Me.Label187.TabIndex = 25
        Me.Label187.Text = "Student:"
        '
        'rbpub
        '
        Me.rbpub.AutoSize = True
        Me.rbpub.Location = New System.Drawing.Point(388, 184)
        Me.rbpub.Name = "rbpub"
        Me.rbpub.Size = New System.Drawing.Size(92, 17)
        Me.rbpub.TabIndex = 21
        Me.rbpub.Text = "Publish Online"
        Me.rbpub.UseVisualStyleBackColor = True
        '
        'cboHsMarksSess
        '
        Me.cboHsMarksSess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboHsMarksSess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboHsMarksSess.DisplayMember = "Session"
        Me.cboHsMarksSess.FormattingEnabled = True
        Me.cboHsMarksSess.Location = New System.Drawing.Point(130, 58)
        Me.cboHsMarksSess.Name = "cboHsMarksSess"
        Me.cboHsMarksSess.Size = New System.Drawing.Size(107, 21)
        Me.cboHsMarksSess.TabIndex = 13
        Me.cboHsMarksSess.ValueMember = "Session"
        '
        'rbHsReportPerClass
        '
        Me.rbHsReportPerClass.AutoSize = True
        Me.rbHsReportPerClass.Checked = True
        Me.rbHsReportPerClass.Location = New System.Drawing.Point(186, 184)
        Me.rbHsReportPerClass.Name = "rbHsReportPerClass"
        Me.rbHsReportPerClass.Size = New System.Drawing.Size(82, 17)
        Me.rbHsReportPerClass.TabIndex = 12
        Me.rbHsReportPerClass.TabStop = True
        Me.rbHsReportPerClass.Text = "ClassReport"
        Me.rbHsReportPerClass.UseVisualStyleBackColor = True
        '
        'rbHsMarksPerSubject
        '
        Me.rbHsMarksPerSubject.AutoSize = True
        Me.rbHsMarksPerSubject.Location = New System.Drawing.Point(94, 184)
        Me.rbHsMarksPerSubject.Name = "rbHsMarksPerSubject"
        Me.rbHsMarksPerSubject.Size = New System.Drawing.Size(77, 17)
        Me.rbHsMarksPerSubject.TabIndex = 11
        Me.rbHsMarksPerSubject.Text = "PerSubject"
        Me.rbHsMarksPerSubject.UseVisualStyleBackColor = True
        '
        'rbHsMarksPerClass
        '
        Me.rbHsMarksPerClass.AutoSize = True
        Me.rbHsMarksPerClass.Location = New System.Drawing.Point(8, 184)
        Me.rbHsMarksPerClass.Name = "rbHsMarksPerClass"
        Me.rbHsMarksPerClass.Size = New System.Drawing.Size(78, 17)
        Me.rbHsMarksPerClass.TabIndex = 10
        Me.rbHsMarksPerClass.Text = "PerStudent"
        Me.rbHsMarksPerClass.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(15, 93)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(36, 13)
        Me.Label36.TabIndex = 8
        Me.Label36.Text = "Exam:"
        '
        'cboHsMarksRef
        '
        Me.cboHsMarksRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboHsMarksRef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboHsMarksRef.DisplayMember = "Sessions"
        Me.cboHsMarksRef.FormattingEnabled = True
        Me.cboHsMarksRef.Location = New System.Drawing.Point(78, 85)
        Me.cboHsMarksRef.Name = "cboHsMarksRef"
        Me.cboHsMarksRef.Size = New System.Drawing.Size(159, 21)
        Me.cboHsMarksRef.TabIndex = 7
        Me.cboHsMarksRef.ValueMember = "Sessions"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(15, 63)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(33, 13)
        Me.Label38.TabIndex = 3
        Me.Label38.Text = "Form:"
        '
        'cboHsMarksLev
        '
        Me.cboHsMarksLev.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboHsMarksLev.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboHsMarksLev.FormattingEnabled = True
        Me.cboHsMarksLev.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboHsMarksLev.Location = New System.Drawing.Point(78, 58)
        Me.cboHsMarksLev.Name = "cboHsMarksLev"
        Me.cboHsMarksLev.Size = New System.Drawing.Size(51, 21)
        Me.cboHsMarksLev.TabIndex = 2
        '
        'gbStaffQualifictions
        '
        Me.gbStaffQualifictions.Controls.Add(Me.rbQualByQual)
        Me.gbStaffQualifictions.Controls.Add(Me.rbQualByStaff)
        Me.gbStaffQualifictions.Location = New System.Drawing.Point(142, 114)
        Me.gbStaffQualifictions.Name = "gbStaffQualifictions"
        Me.gbStaffQualifictions.Size = New System.Drawing.Size(10, 21)
        Me.gbStaffQualifictions.TabIndex = 34
        Me.gbStaffQualifictions.TabStop = False
        Me.gbStaffQualifictions.Text = "StaffQualifications"
        Me.gbStaffQualifictions.Visible = False
        '
        'rbQualByQual
        '
        Me.rbQualByQual.AutoSize = True
        Me.rbQualByQual.Location = New System.Drawing.Point(132, 57)
        Me.rbQualByQual.Name = "rbQualByQual"
        Me.rbQualByQual.Size = New System.Drawing.Size(99, 17)
        Me.rbQualByQual.TabIndex = 28
        Me.rbQualByQual.TabStop = True
        Me.rbQualByQual.Text = "PerQualification"
        Me.rbQualByQual.UseVisualStyleBackColor = True
        '
        'rbQualByStaff
        '
        Me.rbQualByStaff.AutoSize = True
        Me.rbQualByStaff.Location = New System.Drawing.Point(15, 58)
        Me.rbQualByStaff.Name = "rbQualByStaff"
        Me.rbQualByStaff.Size = New System.Drawing.Size(63, 17)
        Me.rbQualByStaff.TabIndex = 27
        Me.rbQualByStaff.TabStop = True
        Me.rbQualByStaff.Text = "PerStaff"
        Me.rbQualByStaff.UseVisualStyleBackColor = True
        '
        'gbStaffPersonalDetails
        '
        Me.gbStaffPersonalDetails.Controls.Add(Me.rbStaffTeaching)
        Me.gbStaffPersonalDetails.Controls.Add(Me.RbStaffGvt)
        Me.gbStaffPersonalDetails.Controls.Add(Me.rbStaffContract)
        Me.gbStaffPersonalDetails.Controls.Add(Me.Label153)
        Me.gbStaffPersonalDetails.Controls.Add(Me.cboStaffPersStaus)
        Me.gbStaffPersonalDetails.Location = New System.Drawing.Point(301, 87)
        Me.gbStaffPersonalDetails.Name = "gbStaffPersonalDetails"
        Me.gbStaffPersonalDetails.Size = New System.Drawing.Size(19, 35)
        Me.gbStaffPersonalDetails.TabIndex = 33
        Me.gbStaffPersonalDetails.TabStop = False
        Me.gbStaffPersonalDetails.Text = "StaffPersonalDetails"
        Me.gbStaffPersonalDetails.Visible = False
        '
        'rbStaffTeaching
        '
        Me.rbStaffTeaching.AutoSize = True
        Me.rbStaffTeaching.Location = New System.Drawing.Point(212, 93)
        Me.rbStaffTeaching.Name = "rbStaffTeaching"
        Me.rbStaffTeaching.Size = New System.Drawing.Size(93, 17)
        Me.rbStaffTeaching.TabIndex = 29
        Me.rbStaffTeaching.TabStop = True
        Me.rbStaffTeaching.Text = "ByDesignation"
        Me.rbStaffTeaching.UseVisualStyleBackColor = True
        '
        'RbStaffGvt
        '
        Me.RbStaffGvt.AutoSize = True
        Me.RbStaffGvt.Location = New System.Drawing.Point(137, 94)
        Me.RbStaffGvt.Name = "RbStaffGvt"
        Me.RbStaffGvt.Size = New System.Drawing.Size(69, 17)
        Me.RbStaffGvt.TabIndex = 28
        Me.RbStaffGvt.TabStop = True
        Me.RbStaffGvt.Text = "Gvt/SDA"
        Me.RbStaffGvt.UseVisualStyleBackColor = True
        '
        'rbStaffContract
        '
        Me.rbStaffContract.AutoSize = True
        Me.rbStaffContract.Location = New System.Drawing.Point(9, 96)
        Me.rbStaffContract.Name = "rbStaffContract"
        Me.rbStaffContract.Size = New System.Drawing.Size(121, 17)
        Me.rbStaffContract.TabIndex = 27
        Me.rbStaffContract.TabStop = True
        Me.rbStaffContract.Text = "Contract/Permanent"
        Me.rbStaffContract.UseVisualStyleBackColor = True
        '
        'Label153
        '
        Me.Label153.AutoSize = True
        Me.Label153.Location = New System.Drawing.Point(39, 53)
        Me.Label153.Name = "Label153"
        Me.Label153.Size = New System.Drawing.Size(40, 13)
        Me.Label153.TabIndex = 26
        Me.Label153.Text = "Status:"
        '
        'cboStaffPersStaus
        '
        Me.cboStaffPersStaus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffPersStaus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffPersStaus.FormattingEnabled = True
        Me.cboStaffPersStaus.Items.AddRange(New Object() {"Available", "Left"})
        Me.cboStaffPersStaus.Location = New System.Drawing.Point(101, 51)
        Me.cboStaffPersStaus.Name = "cboStaffPersStaus"
        Me.cboStaffPersStaus.Size = New System.Drawing.Size(87, 21)
        Me.cboStaffPersStaus.TabIndex = 23
        '
        'gbExamBoardPassRates
        '
        Me.gbExamBoardPassRates.Controls.Add(Me.rbPassRatePerProgram)
        Me.gbExamBoardPassRates.Controls.Add(Me.rbPassRatePerBoard)
        Me.gbExamBoardPassRates.Controls.Add(Me.Label154)
        Me.gbExamBoardPassRates.Controls.Add(Me.cboPassRatesProg)
        Me.gbExamBoardPassRates.Controls.Add(Me.Label155)
        Me.gbExamBoardPassRates.Controls.Add(Me.cboPassRatesBoard)
        Me.gbExamBoardPassRates.Location = New System.Drawing.Point(92, 109)
        Me.gbExamBoardPassRates.Name = "gbExamBoardPassRates"
        Me.gbExamBoardPassRates.Size = New System.Drawing.Size(47, 10)
        Me.gbExamBoardPassRates.TabIndex = 32
        Me.gbExamBoardPassRates.TabStop = False
        Me.gbExamBoardPassRates.Text = "PassRatesAnalysis"
        Me.gbExamBoardPassRates.Visible = False
        '
        'rbPassRatePerProgram
        '
        Me.rbPassRatePerProgram.AutoSize = True
        Me.rbPassRatePerProgram.Location = New System.Drawing.Point(152, 87)
        Me.rbPassRatePerProgram.Name = "rbPassRatePerProgram"
        Me.rbPassRatePerProgram.Size = New System.Drawing.Size(80, 17)
        Me.rbPassRatePerProgram.TabIndex = 30
        Me.rbPassRatePerProgram.Text = "PerProgram"
        Me.rbPassRatePerProgram.UseVisualStyleBackColor = True
        '
        'rbPassRatePerBoard
        '
        Me.rbPassRatePerBoard.AutoSize = True
        Me.rbPassRatePerBoard.Checked = True
        Me.rbPassRatePerBoard.Location = New System.Drawing.Point(35, 85)
        Me.rbPassRatePerBoard.Name = "rbPassRatePerBoard"
        Me.rbPassRatePerBoard.Size = New System.Drawing.Size(69, 17)
        Me.rbPassRatePerBoard.TabIndex = 29
        Me.rbPassRatePerBoard.TabStop = True
        Me.rbPassRatePerBoard.Text = "PerBoard"
        Me.rbPassRatePerBoard.UseVisualStyleBackColor = True
        '
        'Label154
        '
        Me.Label154.AutoSize = True
        Me.Label154.Location = New System.Drawing.Point(38, 58)
        Me.Label154.Name = "Label154"
        Me.Label154.Size = New System.Drawing.Size(49, 13)
        Me.Label154.TabIndex = 28
        Me.Label154.Text = "Program:"
        '
        'cboPassRatesProg
        '
        Me.cboPassRatesProg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPassRatesProg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPassRatesProg.DisplayMember = "Forms"
        Me.cboPassRatesProg.FormattingEnabled = True
        Me.cboPassRatesProg.Location = New System.Drawing.Point(97, 54)
        Me.cboPassRatesProg.Name = "cboPassRatesProg"
        Me.cboPassRatesProg.Size = New System.Drawing.Size(134, 21)
        Me.cboPassRatesProg.TabIndex = 27
        Me.cboPassRatesProg.ValueMember = "Forms"
        '
        'Label155
        '
        Me.Label155.AutoSize = True
        Me.Label155.Location = New System.Drawing.Point(38, 29)
        Me.Label155.Name = "Label155"
        Me.Label155.Size = New System.Drawing.Size(38, 13)
        Me.Label155.TabIndex = 26
        Me.Label155.Text = "Board:"
        '
        'cboPassRatesBoard
        '
        Me.cboPassRatesBoard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPassRatesBoard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPassRatesBoard.FormattingEnabled = True
        Me.cboPassRatesBoard.Items.AddRange(New Object() {"ZIMSEC", "HEXCO", "CAMBRIDGE"})
        Me.cboPassRatesBoard.Location = New System.Drawing.Point(97, 22)
        Me.cboPassRatesBoard.Name = "cboPassRatesBoard"
        Me.cboPassRatesBoard.Size = New System.Drawing.Size(87, 21)
        Me.cboPassRatesBoard.TabIndex = 23
        '
        'gbIDcards
        '
        Me.gbIDcards.Controls.Add(Me.Label57)
        Me.gbIDcards.Controls.Add(Me.cboCardsGrp)
        Me.gbIDcards.Controls.Add(Me.rbCardsPerGroup)
        Me.gbIDcards.Controls.Add(Me.rbCardsPerClas)
        Me.gbIDcards.Controls.Add(Me.cboCardsSess2)
        Me.gbIDcards.Controls.Add(Me.cboCardsForm2)
        Me.gbIDcards.Controls.Add(Me.Label146)
        Me.gbIDcards.Controls.Add(Me.cboCardsSess1)
        Me.gbIDcards.Controls.Add(Me.Label147)
        Me.gbIDcards.Controls.Add(Me.cboCardsTerm)
        Me.gbIDcards.Controls.Add(Me.Label148)
        Me.gbIDcards.Controls.Add(Me.cboCardsForm1)
        Me.gbIDcards.Controls.Add(Me.Label150)
        Me.gbIDcards.Controls.Add(Me.cboCardsYr)
        Me.gbIDcards.Location = New System.Drawing.Point(210, 13)
        Me.gbIDcards.Name = "gbIDcards"
        Me.gbIDcards.Size = New System.Drawing.Size(27, 17)
        Me.gbIDcards.TabIndex = 31
        Me.gbIDcards.TabStop = False
        Me.gbIDcards.Text = "StudentID Cards"
        Me.gbIDcards.Visible = False
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(11, 130)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(36, 13)
        Me.Label57.TabIndex = 21
        Me.Label57.Text = "Group"
        '
        'cboCardsGrp
        '
        Me.cboCardsGrp.DisplayMember = "club"
        Me.cboCardsGrp.FormattingEnabled = True
        Me.cboCardsGrp.Location = New System.Drawing.Point(59, 126)
        Me.cboCardsGrp.Name = "cboCardsGrp"
        Me.cboCardsGrp.Size = New System.Drawing.Size(117, 21)
        Me.cboCardsGrp.TabIndex = 20
        Me.cboCardsGrp.ValueMember = "club"
        '
        'rbCardsPerGroup
        '
        Me.rbCardsPerGroup.AutoSize = True
        Me.rbCardsPerGroup.Location = New System.Drawing.Point(140, 176)
        Me.rbCardsPerGroup.Name = "rbCardsPerGroup"
        Me.rbCardsPerGroup.Size = New System.Drawing.Size(66, 17)
        Me.rbCardsPerGroup.TabIndex = 19
        Me.rbCardsPerGroup.TabStop = True
        Me.rbCardsPerGroup.Text = "PerClass"
        Me.rbCardsPerGroup.UseVisualStyleBackColor = True
        '
        'rbCardsPerClas
        '
        Me.rbCardsPerClas.AutoSize = True
        Me.rbCardsPerClas.Location = New System.Drawing.Point(24, 178)
        Me.rbCardsPerClas.Name = "rbCardsPerClas"
        Me.rbCardsPerClas.Size = New System.Drawing.Size(70, 17)
        Me.rbCardsPerClas.TabIndex = 18
        Me.rbCardsPerClas.TabStop = True
        Me.rbCardsPerClas.Text = "PerGroup"
        Me.rbCardsPerClas.UseVisualStyleBackColor = True
        '
        'cboCardsSess2
        '
        Me.cboCardsSess2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCardsSess2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCardsSess2.DisplayMember = "Session"
        Me.cboCardsSess2.FormattingEnabled = True
        Me.cboCardsSess2.Location = New System.Drawing.Point(318, 58)
        Me.cboCardsSess2.Name = "cboCardsSess2"
        Me.cboCardsSess2.Size = New System.Drawing.Size(61, 21)
        Me.cboCardsSess2.TabIndex = 17
        Me.cboCardsSess2.ValueMember = "Session"
        '
        'cboCardsForm2
        '
        Me.cboCardsForm2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCardsForm2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCardsForm2.FormattingEnabled = True
        Me.cboCardsForm2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboCardsForm2.Location = New System.Drawing.Point(235, 57)
        Me.cboCardsForm2.Name = "cboCardsForm2"
        Me.cboCardsForm2.Size = New System.Drawing.Size(63, 21)
        Me.cboCardsForm2.TabIndex = 16
        '
        'Label146
        '
        Me.Label146.AutoSize = True
        Me.Label146.Location = New System.Drawing.Point(204, 65)
        Me.Label146.Name = "Label146"
        Me.Label146.Size = New System.Drawing.Size(23, 13)
        Me.Label146.TabIndex = 11
        Me.Label146.Text = "To:"
        '
        'cboCardsSess1
        '
        Me.cboCardsSess1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCardsSess1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCardsSess1.DisplayMember = "Session"
        Me.cboCardsSess1.FormattingEnabled = True
        Me.cboCardsSess1.Location = New System.Drawing.Point(125, 58)
        Me.cboCardsSess1.Name = "cboCardsSess1"
        Me.cboCardsSess1.Size = New System.Drawing.Size(61, 21)
        Me.cboCardsSess1.TabIndex = 10
        Me.cboCardsSess1.ValueMember = "Session"
        '
        'Label147
        '
        Me.Label147.AutoSize = True
        Me.Label147.Location = New System.Drawing.Point(23, 93)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(34, 13)
        Me.Label147.TabIndex = 9
        Me.Label147.Text = "Term:"
        '
        'cboCardsTerm
        '
        Me.cboCardsTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCardsTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCardsTerm.FormattingEnabled = True
        Me.cboCardsTerm.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboCardsTerm.Location = New System.Drawing.Point(58, 92)
        Me.cboCardsTerm.Name = "cboCardsTerm"
        Me.cboCardsTerm.Size = New System.Drawing.Size(121, 21)
        Me.cboCardsTerm.TabIndex = 8
        '
        'Label148
        '
        Me.Label148.AutoSize = True
        Me.Label148.Location = New System.Drawing.Point(21, 61)
        Me.Label148.Name = "Label148"
        Me.Label148.Size = New System.Drawing.Size(33, 13)
        Me.Label148.TabIndex = 7
        Me.Label148.Text = "Form:"
        '
        'cboCardsForm1
        '
        Me.cboCardsForm1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCardsForm1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCardsForm1.FormattingEnabled = True
        Me.cboCardsForm1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboCardsForm1.Location = New System.Drawing.Point(58, 57)
        Me.cboCardsForm1.Name = "cboCardsForm1"
        Me.cboCardsForm1.Size = New System.Drawing.Size(63, 21)
        Me.cboCardsForm1.TabIndex = 6
        '
        'Label150
        '
        Me.Label150.AutoSize = True
        Me.Label150.Location = New System.Drawing.Point(15, 34)
        Me.Label150.Name = "Label150"
        Me.Label150.Size = New System.Drawing.Size(32, 13)
        Me.Label150.TabIndex = 3
        Me.Label150.Text = "Year:"
        '
        'cboCardsYr
        '
        Me.cboCardsYr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCardsYr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCardsYr.FormattingEnabled = True
        Me.cboCardsYr.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboCardsYr.Location = New System.Drawing.Point(56, 28)
        Me.cboCardsYr.Name = "cboCardsYr"
        Me.cboCardsYr.Size = New System.Drawing.Size(121, 21)
        Me.cboCardsYr.TabIndex = 2
        '
        'gbUserHistory
        '
        Me.gbUserHistory.Controls.Add(Me.rbUserHisByDate)
        Me.gbUserHistory.Controls.Add(Me.rbUserHisByUser)
        Me.gbUserHistory.Controls.Add(Me.rbLoggedInUser)
        Me.gbUserHistory.Controls.Add(Me.lbUsers)
        Me.gbUserHistory.Controls.Add(Me.Label5)
        Me.gbUserHistory.Controls.Add(Me.Label4)
        Me.gbUserHistory.Controls.Add(Me.mskLognHisTo)
        Me.gbUserHistory.Controls.Add(Me.mskLognHisFrm)
        Me.gbUserHistory.Controls.Add(Me.UserName)
        Me.gbUserHistory.Controls.Add(Me.cbUserHisUser)
        Me.gbUserHistory.Location = New System.Drawing.Point(333, 56)
        Me.gbUserHistory.Name = "gbUserHistory"
        Me.gbUserHistory.Size = New System.Drawing.Size(35, 29)
        Me.gbUserHistory.TabIndex = 30
        Me.gbUserHistory.TabStop = False
        Me.gbUserHistory.Text = "UserLoginHistory"
        '
        'rbUserHisByDate
        '
        Me.rbUserHisByDate.AutoSize = True
        Me.rbUserHisByDate.Location = New System.Drawing.Point(17, 144)
        Me.rbUserHisByDate.Name = "rbUserHisByDate"
        Me.rbUserHisByDate.Size = New System.Drawing.Size(127, 17)
        Me.rbUserHisByDate.TabIndex = 10
        Me.rbUserHisByDate.TabStop = True
        Me.rbUserHisByDate.Text = "View History By Date "
        Me.rbUserHisByDate.UseVisualStyleBackColor = True
        '
        'rbUserHisByUser
        '
        Me.rbUserHisByUser.AutoSize = True
        Me.rbUserHisByUser.Location = New System.Drawing.Point(14, 118)
        Me.rbUserHisByUser.Name = "rbUserHisByUser"
        Me.rbUserHisByUser.Size = New System.Drawing.Size(123, 17)
        Me.rbUserHisByUser.TabIndex = 9
        Me.rbUserHisByUser.TabStop = True
        Me.rbUserHisByUser.Text = "View History By User"
        Me.rbUserHisByUser.UseVisualStyleBackColor = True
        '
        'rbLoggedInUser
        '
        Me.rbLoggedInUser.AutoSize = True
        Me.rbLoggedInUser.Location = New System.Drawing.Point(14, 100)
        Me.rbLoggedInUser.Name = "rbLoggedInUser"
        Me.rbLoggedInUser.Size = New System.Drawing.Size(165, 17)
        Me.rbLoggedInUser.TabIndex = 8
        Me.rbLoggedInUser.TabStop = True
        Me.rbLoggedInUser.Text = "View Currently LoggedIn User"
        Me.rbLoggedInUser.UseVisualStyleBackColor = True
        '
        'lbUsers
        '
        Me.lbUsers.FormattingEnabled = True
        Me.lbUsers.Location = New System.Drawing.Point(97, 41)
        Me.lbUsers.Name = "lbUsers"
        Me.lbUsers.Size = New System.Drawing.Size(163, 56)
        Me.lbUsers.TabIndex = 7
        Me.lbUsers.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "From:"
        '
        'mskLognHisTo
        '
        Me.mskLognHisTo.Location = New System.Drawing.Point(195, 59)
        Me.mskLognHisTo.Mask = "00/00/0000"
        Me.mskLognHisTo.Name = "mskLognHisTo"
        Me.mskLognHisTo.Size = New System.Drawing.Size(100, 20)
        Me.mskLognHisTo.TabIndex = 3
        Me.mskLognHisTo.ValidatingType = GetType(Date)
        '
        'mskLognHisFrm
        '
        Me.mskLognHisFrm.Location = New System.Drawing.Point(34, 61)
        Me.mskLognHisFrm.Mask = "00/00/0000"
        Me.mskLognHisFrm.Name = "mskLognHisFrm"
        Me.mskLognHisFrm.Size = New System.Drawing.Size(100, 20)
        Me.mskLognHisFrm.TabIndex = 2
        Me.mskLognHisFrm.ValidatingType = GetType(Date)
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.Location = New System.Drawing.Point(55, 26)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(32, 13)
        Me.UserName.TabIndex = 1
        Me.UserName.Text = "User:"
        '
        'cbUserHisUser
        '
        Me.cbUserHisUser.DisplayMember = "Usr_User"
        Me.cbUserHisUser.FormattingEnabled = True
        Me.cbUserHisUser.Location = New System.Drawing.Point(108, 20)
        Me.cbUserHisUser.Name = "cbUserHisUser"
        Me.cbUserHisUser.Size = New System.Drawing.Size(121, 21)
        Me.cbUserHisUser.TabIndex = 0
        Me.cbUserHisUser.ValueMember = "Usr_User"
        '
        'gbSubjectRegister
        '
        Me.gbSubjectRegister.Controls.Add(Me.rbHardCopy)
        Me.gbSubjectRegister.Controls.Add(Me.lbSubRegStudSearch)
        Me.gbSubjectRegister.Controls.Add(Me.Label107)
        Me.gbSubjectRegister.Controls.Add(Me.Label108)
        Me.gbSubjectRegister.Controls.Add(Me.SubRegDateTo)
        Me.gbSubjectRegister.Controls.Add(Me.subRegDateFrom)
        Me.gbSubjectRegister.Controls.Add(Me.Label109)
        Me.gbSubjectRegister.Controls.Add(Me.cboSubRegSub)
        Me.gbSubjectRegister.Controls.Add(Me.rbSubRegPerSub)
        Me.gbSubjectRegister.Controls.Add(Me.cboSubRegStud)
        Me.gbSubjectRegister.Controls.Add(Me.Label110)
        Me.gbSubjectRegister.Controls.Add(Me.cboSubRegCls)
        Me.gbSubjectRegister.Controls.Add(Me.Label111)
        Me.gbSubjectRegister.Controls.Add(Me.rbSubRegPerStud)
        Me.gbSubjectRegister.Controls.Add(Me.Label112)
        Me.gbSubjectRegister.Controls.Add(Me.cboSubRegSem)
        Me.gbSubjectRegister.Controls.Add(Me.cboSubRegSess)
        Me.gbSubjectRegister.Controls.Add(Me.Label131)
        Me.gbSubjectRegister.Controls.Add(Me.cboStudRegLvl)
        Me.gbSubjectRegister.Location = New System.Drawing.Point(441, 47)
        Me.gbSubjectRegister.Name = "gbSubjectRegister"
        Me.gbSubjectRegister.Size = New System.Drawing.Size(25, 29)
        Me.gbSubjectRegister.TabIndex = 29
        Me.gbSubjectRegister.TabStop = False
        Me.gbSubjectRegister.Tag = " "
        Me.gbSubjectRegister.Text = "SubjectRegister"
        Me.gbSubjectRegister.Visible = False
        '
        'rbHardCopy
        '
        Me.rbHardCopy.AutoSize = True
        Me.rbHardCopy.Location = New System.Drawing.Point(206, 228)
        Me.rbHardCopy.Name = "rbHardCopy"
        Me.rbHardCopy.Size = New System.Drawing.Size(72, 17)
        Me.rbHardCopy.TabIndex = 33
        Me.rbHardCopy.TabStop = True
        Me.rbHardCopy.Text = "HardCopy"
        Me.rbHardCopy.UseVisualStyleBackColor = True
        '
        'lbSubRegStudSearch
        '
        Me.lbSubRegStudSearch.BackColor = System.Drawing.Color.LightYellow
        Me.lbSubRegStudSearch.FormattingEnabled = True
        Me.lbSubRegStudSearch.Location = New System.Drawing.Point(112, 35)
        Me.lbSubRegStudSearch.Name = "lbSubRegStudSearch"
        Me.lbSubRegStudSearch.Size = New System.Drawing.Size(206, 82)
        Me.lbSubRegStudSearch.TabIndex = 32
        Me.lbSubRegStudSearch.Visible = False
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Location = New System.Drawing.Point(237, 196)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(23, 13)
        Me.Label107.TabIndex = 21
        Me.Label107.Text = "To:"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Location = New System.Drawing.Point(61, 194)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(33, 13)
        Me.Label108.TabIndex = 20
        Me.Label108.Text = "From:"
        '
        'SubRegDateTo
        '
        Me.SubRegDateTo.Location = New System.Drawing.Point(269, 189)
        Me.SubRegDateTo.Mask = "00/00/0000"
        Me.SubRegDateTo.Name = "SubRegDateTo"
        Me.SubRegDateTo.Size = New System.Drawing.Size(85, 20)
        Me.SubRegDateTo.TabIndex = 19
        Me.SubRegDateTo.ValidatingType = GetType(Date)
        '
        'subRegDateFrom
        '
        Me.subRegDateFrom.Location = New System.Drawing.Point(124, 187)
        Me.subRegDateFrom.Mask = "00/00/0000"
        Me.subRegDateFrom.Name = "subRegDateFrom"
        Me.subRegDateFrom.Size = New System.Drawing.Size(85, 20)
        Me.subRegDateFrom.TabIndex = 18
        Me.subRegDateFrom.ValidatingType = GetType(Date)
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Location = New System.Drawing.Point(48, 164)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(46, 13)
        Me.Label109.TabIndex = 17
        Me.Label109.Text = "Subject:"
        '
        'cboSubRegSub
        '
        Me.cboSubRegSub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubRegSub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubRegSub.DisplayMember = "SubjectID"
        Me.cboSubRegSub.Enabled = False
        Me.cboSubRegSub.FormattingEnabled = True
        Me.cboSubRegSub.Location = New System.Drawing.Point(123, 153)
        Me.cboSubRegSub.Name = "cboSubRegSub"
        Me.cboSubRegSub.Size = New System.Drawing.Size(121, 21)
        Me.cboSubRegSub.TabIndex = 16
        Me.cboSubRegSub.ValueMember = "SubjectID"
        '
        'rbSubRegPerSub
        '
        Me.rbSubRegPerSub.AutoSize = True
        Me.rbSubRegPerSub.Location = New System.Drawing.Point(111, 228)
        Me.rbSubRegPerSub.Name = "rbSubRegPerSub"
        Me.rbSubRegPerSub.Size = New System.Drawing.Size(77, 17)
        Me.rbSubRegPerSub.TabIndex = 15
        Me.rbSubRegPerSub.TabStop = True
        Me.rbSubRegPerSub.Text = "PerSubject"
        Me.rbSubRegPerSub.UseVisualStyleBackColor = True
        '
        'cboSubRegStud
        '
        Me.cboSubRegStud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubRegStud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubRegStud.DisplayMember = "Section"
        Me.cboSubRegStud.FormattingEnabled = True
        Me.cboSubRegStud.Location = New System.Drawing.Point(114, 15)
        Me.cboSubRegStud.Name = "cboSubRegStud"
        Me.cboSubRegStud.Size = New System.Drawing.Size(132, 21)
        Me.cboSubRegStud.TabIndex = 14
        Me.cboSubRegStud.ValueMember = "Section"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Location = New System.Drawing.Point(62, 61)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(32, 13)
        Me.Label110.TabIndex = 13
        Me.Label110.Text = "Class"
        '
        'cboSubRegCls
        '
        Me.cboSubRegCls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubRegCls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubRegCls.DisplayMember = "Section"
        Me.cboSubRegCls.FormattingEnabled = True
        Me.cboSubRegCls.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboSubRegCls.Location = New System.Drawing.Point(125, 60)
        Me.cboSubRegCls.Name = "cboSubRegCls"
        Me.cboSubRegCls.Size = New System.Drawing.Size(121, 21)
        Me.cboSubRegCls.TabIndex = 12
        Me.cboSubRegCls.ValueMember = "Section"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Location = New System.Drawing.Point(50, 27)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(44, 13)
        Me.Label111.TabIndex = 11
        Me.Label111.Text = "Student"
        '
        'rbSubRegPerStud
        '
        Me.rbSubRegPerStud.AutoSize = True
        Me.rbSubRegPerStud.Location = New System.Drawing.Point(27, 228)
        Me.rbSubRegPerStud.Name = "rbSubRegPerStud"
        Me.rbSubRegPerStud.Size = New System.Drawing.Size(78, 17)
        Me.rbSubRegPerStud.TabIndex = 8
        Me.rbSubRegPerStud.TabStop = True
        Me.rbSubRegPerStud.Text = "PerStudent"
        Me.rbSubRegPerStud.UseVisualStyleBackColor = True
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(60, 132)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(34, 13)
        Me.Label112.TabIndex = 7
        Me.Label112.Text = "Term:"
        '
        'cboSubRegSem
        '
        Me.cboSubRegSem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubRegSem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubRegSem.FormattingEnabled = True
        Me.cboSubRegSem.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboSubRegSem.Location = New System.Drawing.Point(123, 117)
        Me.cboSubRegSem.Name = "cboSubRegSem"
        Me.cboSubRegSem.Size = New System.Drawing.Size(66, 21)
        Me.cboSubRegSem.TabIndex = 6
        '
        'cboSubRegSess
        '
        Me.cboSubRegSess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubRegSess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubRegSess.DisplayMember = "Section"
        Me.cboSubRegSess.FormattingEnabled = True
        Me.cboSubRegSess.Location = New System.Drawing.Point(240, 91)
        Me.cboSubRegSess.Name = "cboSubRegSess"
        Me.cboSubRegSess.Size = New System.Drawing.Size(121, 21)
        Me.cboSubRegSess.TabIndex = 2
        Me.cboSubRegSess.ValueMember = "Section"
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Location = New System.Drawing.Point(61, 93)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(33, 13)
        Me.Label131.TabIndex = 1
        Me.Label131.Text = "Form:"
        '
        'cboStudRegLvl
        '
        Me.cboStudRegLvl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudRegLvl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudRegLvl.DisplayMember = "SubjectID"
        Me.cboStudRegLvl.FormattingEnabled = True
        Me.cboStudRegLvl.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboStudRegLvl.Location = New System.Drawing.Point(123, 90)
        Me.cboStudRegLvl.Name = "cboStudRegLvl"
        Me.cboStudRegLvl.Size = New System.Drawing.Size(93, 21)
        Me.cboStudRegLvl.TabIndex = 0
        Me.cboStudRegLvl.ValueMember = "SubjectID"
        '
        'gbKnowhowAnalysis
        '
        Me.gbKnowhowAnalysis.Controls.Add(Me.Label134)
        Me.gbKnowhowAnalysis.Controls.Add(Me.cboKhasess)
        Me.gbKnowhowAnalysis.Controls.Add(Me.Label135)
        Me.gbKnowhowAnalysis.Controls.Add(Me.cboKhasem)
        Me.gbKnowhowAnalysis.Controls.Add(Me.Label136)
        Me.gbKnowhowAnalysis.Controls.Add(Me.cboKhalev)
        Me.gbKnowhowAnalysis.Controls.Add(Me.Label137)
        Me.gbKnowhowAnalysis.Controls.Add(Me.cboKhaintak)
        Me.gbKnowhowAnalysis.Controls.Add(Me.Label138)
        Me.gbKnowhowAnalysis.Controls.Add(Me.cboKhaclass)
        Me.gbKnowhowAnalysis.Controls.Add(Me.Label139)
        Me.gbKnowhowAnalysis.Controls.Add(Me.cboKhaprog)
        Me.gbKnowhowAnalysis.Location = New System.Drawing.Point(43, 57)
        Me.gbKnowhowAnalysis.Name = "gbKnowhowAnalysis"
        Me.gbKnowhowAnalysis.Size = New System.Drawing.Size(55, 32)
        Me.gbKnowhowAnalysis.TabIndex = 28
        Me.gbKnowhowAnalysis.TabStop = False
        Me.gbKnowhowAnalysis.Text = "Knowhow Analysis"
        Me.gbKnowhowAnalysis.Visible = False
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Location = New System.Drawing.Point(106, 241)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(47, 13)
        Me.Label134.TabIndex = 11
        Me.Label134.Text = "Session:"
        '
        'cboKhasess
        '
        Me.cboKhasess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboKhasess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboKhasess.DisplayMember = "Session"
        Me.cboKhasess.FormattingEnabled = True
        Me.cboKhasess.Location = New System.Drawing.Point(201, 233)
        Me.cboKhasess.Name = "cboKhasess"
        Me.cboKhasess.Size = New System.Drawing.Size(121, 21)
        Me.cboKhasess.TabIndex = 10
        Me.cboKhasess.ValueMember = "Session"
        '
        'Label135
        '
        Me.Label135.AutoSize = True
        Me.Label135.Location = New System.Drawing.Point(106, 162)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(54, 13)
        Me.Label135.TabIndex = 9
        Me.Label135.Text = "Semester:"
        '
        'cboKhasem
        '
        Me.cboKhasem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboKhasem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboKhasem.FormattingEnabled = True
        Me.cboKhasem.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboKhasem.Location = New System.Drawing.Point(201, 154)
        Me.cboKhasem.Name = "cboKhasem"
        Me.cboKhasem.Size = New System.Drawing.Size(121, 21)
        Me.cboKhasem.TabIndex = 8
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.Location = New System.Drawing.Point(106, 123)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(36, 13)
        Me.Label136.TabIndex = 7
        Me.Label136.Text = "Level:"
        '
        'cboKhalev
        '
        Me.cboKhalev.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboKhalev.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboKhalev.FormattingEnabled = True
        Me.cboKhalev.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboKhalev.Location = New System.Drawing.Point(201, 123)
        Me.cboKhalev.Name = "cboKhalev"
        Me.cboKhalev.Size = New System.Drawing.Size(121, 21)
        Me.cboKhalev.TabIndex = 6
        '
        'Label137
        '
        Me.Label137.AutoSize = True
        Me.Label137.Location = New System.Drawing.Point(106, 197)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(40, 13)
        Me.Label137.TabIndex = 5
        Me.Label137.Text = "Intake:"
        '
        'cboKhaintak
        '
        Me.cboKhaintak.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboKhaintak.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboKhaintak.FormattingEnabled = True
        Me.cboKhaintak.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November ", "December"})
        Me.cboKhaintak.Location = New System.Drawing.Point(201, 189)
        Me.cboKhaintak.Name = "cboKhaintak"
        Me.cboKhaintak.Size = New System.Drawing.Size(121, 21)
        Me.cboKhaintak.TabIndex = 4
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Location = New System.Drawing.Point(106, 88)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(35, 13)
        Me.Label138.TabIndex = 3
        Me.Label138.Text = "Class:"
        '
        'cboKhaclass
        '
        Me.cboKhaclass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboKhaclass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboKhaclass.FormattingEnabled = True
        Me.cboKhaclass.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboKhaclass.Location = New System.Drawing.Point(201, 81)
        Me.cboKhaclass.Name = "cboKhaclass"
        Me.cboKhaclass.Size = New System.Drawing.Size(121, 21)
        Me.cboKhaclass.TabIndex = 2
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Location = New System.Drawing.Point(106, 42)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(46, 13)
        Me.Label139.TabIndex = 1
        Me.Label139.Text = "Program"
        '
        'cboKhaprog
        '
        Me.cboKhaprog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboKhaprog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboKhaprog.DisplayMember = "Forms"
        Me.cboKhaprog.FormattingEnabled = True
        Me.cboKhaprog.Location = New System.Drawing.Point(201, 34)
        Me.cboKhaprog.Name = "cboKhaprog"
        Me.cboKhaprog.Size = New System.Drawing.Size(121, 21)
        Me.cboKhaprog.TabIndex = 0
        Me.cboKhaprog.ValueMember = "Forms"
        '
        'gbRegister3
        '
        Me.gbRegister3.Controls.Add(Me.lbReg3Sub)
        Me.gbRegister3.Controls.Add(Me.cboReg3Sub)
        Me.gbRegister3.Controls.Add(Me.Label128)
        Me.gbRegister3.Controls.Add(Me.lbReg3Prog)
        Me.gbRegister3.Controls.Add(Me.cboReg3Prog)
        Me.gbRegister3.Controls.Add(Me.Label127)
        Me.gbRegister3.Controls.Add(Me.cboReg3Session)
        Me.gbRegister3.Controls.Add(Me.Label126)
        Me.gbRegister3.Controls.Add(Me.cboReg3Intake)
        Me.gbRegister3.Controls.Add(Me.Label125)
        Me.gbRegister3.Controls.Add(Me.cboReg3Class)
        Me.gbRegister3.Controls.Add(Me.Label124)
        Me.gbRegister3.Controls.Add(Me.cboReg3Sec)
        Me.gbRegister3.Controls.Add(Me.Label123)
        Me.gbRegister3.Location = New System.Drawing.Point(817, 38)
        Me.gbRegister3.Name = "gbRegister3"
        Me.gbRegister3.Size = New System.Drawing.Size(11, 13)
        Me.gbRegister3.TabIndex = 27
        Me.gbRegister3.TabStop = False
        Me.gbRegister3.Text = "Register 3"
        Me.gbRegister3.Visible = False
        '
        'lbReg3Sub
        '
        Me.lbReg3Sub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbReg3Sub.BackColor = System.Drawing.Color.LightYellow
        Me.lbReg3Sub.FormattingEnabled = True
        Me.lbReg3Sub.Location = New System.Drawing.Point(67, 203)
        Me.lbReg3Sub.Name = "lbReg3Sub"
        Me.lbReg3Sub.Size = New System.Drawing.Size(177, 4)
        Me.lbReg3Sub.TabIndex = 33
        Me.lbReg3Sub.Visible = False
        '
        'cboReg3Sub
        '
        Me.cboReg3Sub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboReg3Sub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReg3Sub.DisplayMember = "Session"
        Me.cboReg3Sub.FormattingEnabled = True
        Me.cboReg3Sub.Location = New System.Drawing.Point(75, 184)
        Me.cboReg3Sub.Name = "cboReg3Sub"
        Me.cboReg3Sub.Size = New System.Drawing.Size(121, 21)
        Me.cboReg3Sub.TabIndex = 32
        Me.cboReg3Sub.ValueMember = "Session"
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Location = New System.Drawing.Point(19, 187)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(43, 13)
        Me.Label128.TabIndex = 31
        Me.Label128.Text = "Subject"
        '
        'lbReg3Prog
        '
        Me.lbReg3Prog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbReg3Prog.BackColor = System.Drawing.Color.LightYellow
        Me.lbReg3Prog.FormattingEnabled = True
        Me.lbReg3Prog.Location = New System.Drawing.Point(194, 144)
        Me.lbReg3Prog.Name = "lbReg3Prog"
        Me.lbReg3Prog.Size = New System.Drawing.Size(177, 4)
        Me.lbReg3Prog.TabIndex = 30
        Me.lbReg3Prog.Visible = False
        '
        'cboReg3Prog
        '
        Me.cboReg3Prog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboReg3Prog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReg3Prog.DisplayMember = "Session"
        Me.cboReg3Prog.FormattingEnabled = True
        Me.cboReg3Prog.Location = New System.Drawing.Point(71, 148)
        Me.cboReg3Prog.Name = "cboReg3Prog"
        Me.cboReg3Prog.Size = New System.Drawing.Size(121, 21)
        Me.cboReg3Prog.TabIndex = 9
        Me.cboReg3Prog.ValueMember = "Session"
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Location = New System.Drawing.Point(18, 151)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(46, 13)
        Me.Label127.TabIndex = 8
        Me.Label127.Text = "Program"
        '
        'cboReg3Session
        '
        Me.cboReg3Session.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboReg3Session.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReg3Session.DisplayMember = "Session"
        Me.cboReg3Session.FormattingEnabled = True
        Me.cboReg3Session.Location = New System.Drawing.Point(70, 119)
        Me.cboReg3Session.Name = "cboReg3Session"
        Me.cboReg3Session.Size = New System.Drawing.Size(121, 21)
        Me.cboReg3Session.TabIndex = 7
        Me.cboReg3Session.ValueMember = "Session"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Location = New System.Drawing.Point(18, 122)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(44, 13)
        Me.Label126.TabIndex = 6
        Me.Label126.Text = "Session"
        '
        'cboReg3Intake
        '
        Me.cboReg3Intake.FormattingEnabled = True
        Me.cboReg3Intake.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June"})
        Me.cboReg3Intake.Location = New System.Drawing.Point(70, 92)
        Me.cboReg3Intake.Name = "cboReg3Intake"
        Me.cboReg3Intake.Size = New System.Drawing.Size(121, 21)
        Me.cboReg3Intake.TabIndex = 5
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Location = New System.Drawing.Point(17, 90)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(37, 13)
        Me.Label125.TabIndex = 4
        Me.Label125.Text = "Intake"
        '
        'cboReg3Class
        '
        Me.cboReg3Class.FormattingEnabled = True
        Me.cboReg3Class.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015"})
        Me.cboReg3Class.Location = New System.Drawing.Point(70, 63)
        Me.cboReg3Class.Name = "cboReg3Class"
        Me.cboReg3Class.Size = New System.Drawing.Size(121, 21)
        Me.cboReg3Class.TabIndex = 3
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Location = New System.Drawing.Point(15, 62)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(32, 13)
        Me.Label124.TabIndex = 2
        Me.Label124.Text = "Class"
        '
        'cboReg3Sec
        '
        Me.cboReg3Sec.FormattingEnabled = True
        Me.cboReg3Sec.Items.AddRange(New Object() {"IT", "High School", "Business School"})
        Me.cboReg3Sec.Location = New System.Drawing.Point(71, 26)
        Me.cboReg3Sec.Name = "cboReg3Sec"
        Me.cboReg3Sec.Size = New System.Drawing.Size(121, 21)
        Me.cboReg3Sec.TabIndex = 1
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Location = New System.Drawing.Point(14, 29)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(43, 13)
        Me.Label123.TabIndex = 0
        Me.Label123.Text = "Section"
        '
        'gbSchoolEnrollment
        '
        Me.gbSchoolEnrollment.Controls.Add(Me.chkGraphicalenrol)
        Me.gbSchoolEnrollment.Controls.Add(Me.Label17)
        Me.gbSchoolEnrollment.Controls.Add(Me.chkPeriodAnalysis)
        Me.gbSchoolEnrollment.Controls.Add(Me.Label23)
        Me.gbSchoolEnrollment.Controls.Add(Me.btnAddEnrol)
        Me.gbSchoolEnrollment.Controls.Add(Me.lbAnalysisEnrols)
        Me.gbSchoolEnrollment.Controls.Add(Me.pnlDateAnalysis)
        Me.gbSchoolEnrollment.Controls.Add(Me.Label24)
        Me.gbSchoolEnrollment.Controls.Add(Me.cboSchoolEnrolClass)
        Me.gbSchoolEnrollment.Controls.Add(Me.Staus)
        Me.gbSchoolEnrollment.Controls.Add(Me.cboSchoolEnrolSection)
        Me.gbSchoolEnrollment.Location = New System.Drawing.Point(771, 99)
        Me.gbSchoolEnrollment.Name = "gbSchoolEnrollment"
        Me.gbSchoolEnrollment.Size = New System.Drawing.Size(46, 32)
        Me.gbSchoolEnrollment.TabIndex = 5
        Me.gbSchoolEnrollment.TabStop = False
        Me.gbSchoolEnrollment.Text = "SchoolEnrollment"
        Me.gbSchoolEnrollment.Visible = False
        '
        'chkGraphicalenrol
        '
        Me.chkGraphicalenrol.AccessibleDescription = ""
        Me.chkGraphicalenrol.AutoSize = True
        Me.chkGraphicalenrol.Location = New System.Drawing.Point(479, 32)
        Me.chkGraphicalenrol.Name = "chkGraphicalenrol"
        Me.chkGraphicalenrol.Size = New System.Drawing.Size(71, 17)
        Me.chkGraphicalenrol.TabIndex = 24
        Me.chkGraphicalenrol.Text = "Graphical"
        Me.chkGraphicalenrol.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(386, 94)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(140, 39)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Double Click respective" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enrollment Line to remove it " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from the Enrollment List"
        '
        'chkPeriodAnalysis
        '
        Me.chkPeriodAnalysis.AccessibleDescription = ""
        Me.chkPeriodAnalysis.AutoSize = True
        Me.chkPeriodAnalysis.Location = New System.Drawing.Point(39, 197)
        Me.chkPeriodAnalysis.Name = "chkPeriodAnalysis"
        Me.chkPeriodAnalysis.Size = New System.Drawing.Size(94, 17)
        Me.chkPeriodAnalysis.TabIndex = 12
        Me.chkPeriodAnalysis.Text = "PeriodAnalysis"
        Me.chkPeriodAnalysis.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(35, 55)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 13)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Enrollment List"
        '
        'btnAddEnrol
        '
        Me.btnAddEnrol.Location = New System.Drawing.Point(373, 20)
        Me.btnAddEnrol.Name = "btnAddEnrol"
        Me.btnAddEnrol.Size = New System.Drawing.Size(103, 43)
        Me.btnAddEnrol.TabIndex = 21
        Me.btnAddEnrol.Text = "Add To " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enrollment List"
        Me.btnAddEnrol.UseVisualStyleBackColor = True
        '
        'lbAnalysisEnrols
        '
        Me.lbAnalysisEnrols.FormattingEnabled = True
        Me.lbAnalysisEnrols.Location = New System.Drawing.Point(39, 74)
        Me.lbAnalysisEnrols.Name = "lbAnalysisEnrols"
        Me.lbAnalysisEnrols.Size = New System.Drawing.Size(333, 95)
        Me.lbAnalysisEnrols.TabIndex = 20
        '
        'pnlDateAnalysis
        '
        Me.pnlDateAnalysis.Controls.Add(Me.Label72)
        Me.pnlDateAnalysis.Controls.Add(Me.dtpEnrolPerAnalDateTo)
        Me.pnlDateAnalysis.Controls.Add(Me.Label71)
        Me.pnlDateAnalysis.Controls.Add(Me.dtpEnrolPerAnalDateFrom)
        Me.pnlDateAnalysis.Enabled = False
        Me.pnlDateAnalysis.Location = New System.Drawing.Point(134, 175)
        Me.pnlDateAnalysis.Name = "pnlDateAnalysis"
        Me.pnlDateAnalysis.Size = New System.Drawing.Size(374, 55)
        Me.pnlDateAnalysis.TabIndex = 13
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(190, 27)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(23, 13)
        Me.Label72.TabIndex = 11
        Me.Label72.Text = "To:"
        '
        'dtpEnrolPerAnalDateTo
        '
        Me.dtpEnrolPerAnalDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnrolPerAnalDateTo.Location = New System.Drawing.Point(219, 23)
        Me.dtpEnrolPerAnalDateTo.Name = "dtpEnrolPerAnalDateTo"
        Me.dtpEnrolPerAnalDateTo.Size = New System.Drawing.Size(151, 20)
        Me.dtpEnrolPerAnalDateTo.TabIndex = 9
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(10, 27)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(33, 13)
        Me.Label71.TabIndex = 10
        Me.Label71.Text = "From:"
        '
        'dtpEnrolPerAnalDateFrom
        '
        Me.dtpEnrolPerAnalDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnrolPerAnalDateFrom.Location = New System.Drawing.Point(48, 23)
        Me.dtpEnrolPerAnalDateFrom.Name = "dtpEnrolPerAnalDateFrom"
        Me.dtpEnrolPerAnalDateFrom.Size = New System.Drawing.Size(130, 20)
        Me.dtpEnrolPerAnalDateFrom.TabIndex = 8
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(208, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 13)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Class:"
        '
        'cboSchoolEnrolClass
        '
        Me.cboSchoolEnrolClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSchoolEnrolClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSchoolEnrolClass.FormattingEnabled = True
        Me.cboSchoolEnrolClass.Location = New System.Drawing.Point(245, 27)
        Me.cboSchoolEnrolClass.Name = "cboSchoolEnrolClass"
        Me.cboSchoolEnrolClass.Size = New System.Drawing.Size(121, 21)
        Me.cboSchoolEnrolClass.TabIndex = 6
        '
        'Staus
        '
        Me.Staus.AutoSize = True
        Me.Staus.Location = New System.Drawing.Point(30, 28)
        Me.Staus.Name = "Staus"
        Me.Staus.Size = New System.Drawing.Size(46, 13)
        Me.Staus.TabIndex = 3
        Me.Staus.Text = "Section:"
        '
        'cboSchoolEnrolSection
        '
        Me.cboSchoolEnrolSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSchoolEnrolSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSchoolEnrolSection.DisplayMember = "section"
        Me.cboSchoolEnrolSection.FormattingEnabled = True
        Me.cboSchoolEnrolSection.Location = New System.Drawing.Point(78, 26)
        Me.cboSchoolEnrolSection.Name = "cboSchoolEnrolSection"
        Me.cboSchoolEnrolSection.Size = New System.Drawing.Size(121, 21)
        Me.cboSchoolEnrolSection.TabIndex = 2
        Me.cboSchoolEnrolSection.ValueMember = "section"
        '
        'gbGeneralanalysis
        '
        Me.gbGeneralanalysis.Controls.Add(Me.Label104)
        Me.gbGeneralanalysis.Controls.Add(Me.cboGeneralAnalSect)
        Me.gbGeneralanalysis.Controls.Add(Me.Label102)
        Me.gbGeneralanalysis.Controls.Add(Me.cboGeneralAnalIntk)
        Me.gbGeneralanalysis.Controls.Add(Me.Label103)
        Me.gbGeneralanalysis.Controls.Add(Me.cboGeneralAnalClass)
        Me.gbGeneralanalysis.Location = New System.Drawing.Point(153, 23)
        Me.gbGeneralanalysis.Name = "gbGeneralanalysis"
        Me.gbGeneralanalysis.Size = New System.Drawing.Size(45, 41)
        Me.gbGeneralanalysis.TabIndex = 24
        Me.gbGeneralanalysis.TabStop = False
        Me.gbGeneralanalysis.Text = "GeneralAnalysis"
        Me.gbGeneralanalysis.Visible = False
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Location = New System.Drawing.Point(53, 116)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(46, 13)
        Me.Label104.TabIndex = 14
        Me.Label104.Text = "Section:"
        '
        'cboGeneralAnalSect
        '
        Me.cboGeneralAnalSect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboGeneralAnalSect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGeneralAnalSect.FormattingEnabled = True
        Me.cboGeneralAnalSect.Items.AddRange(New Object() {"High School", "ICT", "Business School"})
        Me.cboGeneralAnalSect.Location = New System.Drawing.Point(111, 108)
        Me.cboGeneralAnalSect.Name = "cboGeneralAnalSect"
        Me.cboGeneralAnalSect.Size = New System.Drawing.Size(129, 21)
        Me.cboGeneralAnalSect.TabIndex = 13
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(53, 81)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(40, 13)
        Me.Label102.TabIndex = 12
        Me.Label102.Text = "Intake:"
        '
        'cboGeneralAnalIntk
        '
        Me.cboGeneralAnalIntk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboGeneralAnalIntk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGeneralAnalIntk.FormattingEnabled = True
        Me.cboGeneralAnalIntk.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Decmber"})
        Me.cboGeneralAnalIntk.Location = New System.Drawing.Point(111, 78)
        Me.cboGeneralAnalIntk.Name = "cboGeneralAnalIntk"
        Me.cboGeneralAnalIntk.Size = New System.Drawing.Size(129, 21)
        Me.cboGeneralAnalIntk.TabIndex = 11
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Location = New System.Drawing.Point(52, 44)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(35, 13)
        Me.Label103.TabIndex = 3
        Me.Label103.Text = "Class:"
        '
        'cboGeneralAnalClass
        '
        Me.cboGeneralAnalClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboGeneralAnalClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGeneralAnalClass.FormattingEnabled = True
        Me.cboGeneralAnalClass.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014 ", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboGeneralAnalClass.Location = New System.Drawing.Point(111, 36)
        Me.cboGeneralAnalClass.Name = "cboGeneralAnalClass"
        Me.cboGeneralAnalClass.Size = New System.Drawing.Size(121, 21)
        Me.cboGeneralAnalClass.TabIndex = 2
        '
        'gbSubjectsTaught
        '
        Me.gbSubjectsTaught.Controls.Add(Me.lbSubjects)
        Me.gbSubjectsTaught.Controls.Add(Me.lbteachers)
        Me.gbSubjectsTaught.Controls.Add(Me.cboSubTaughtSubject)
        Me.gbSubjectsTaught.Controls.Add(Me.Label186)
        Me.gbSubjectsTaught.Controls.Add(Me.txtsubtaughtteachers)
        Me.gbSubjectsTaught.Controls.Add(Me.Label100)
        Me.gbSubjectsTaught.Controls.Add(Me.Label91)
        Me.gbSubjectsTaught.Controls.Add(Me.cboSubTaughtTerm)
        Me.gbSubjectsTaught.Controls.Add(Me.rbSubTaughtPerSubject)
        Me.gbSubjectsTaught.Controls.Add(Me.rbSubTaughtPerTeacher)
        Me.gbSubjectsTaught.Controls.Add(Me.Label99)
        Me.gbSubjectsTaught.Controls.Add(Me.cboSubTotCls)
        Me.gbSubjectsTaught.Location = New System.Drawing.Point(505, 124)
        Me.gbSubjectsTaught.Name = "gbSubjectsTaught"
        Me.gbSubjectsTaught.Size = New System.Drawing.Size(56, 30)
        Me.gbSubjectsTaught.TabIndex = 23
        Me.gbSubjectsTaught.TabStop = False
        Me.gbSubjectsTaught.Text = "SubjectsTaught"
        Me.gbSubjectsTaught.Visible = False
        '
        'lbSubjects
        '
        Me.lbSubjects.FormattingEnabled = True
        Me.lbSubjects.Location = New System.Drawing.Point(231, 78)
        Me.lbSubjects.Name = "lbSubjects"
        Me.lbSubjects.Size = New System.Drawing.Size(120, 56)
        Me.lbSubjects.TabIndex = 24
        Me.lbSubjects.Visible = False
        '
        'lbteachers
        '
        Me.lbteachers.FormattingEnabled = True
        Me.lbteachers.Location = New System.Drawing.Point(231, 13)
        Me.lbteachers.Name = "lbteachers"
        Me.lbteachers.Size = New System.Drawing.Size(120, 56)
        Me.lbteachers.TabIndex = 23
        Me.lbteachers.Visible = False
        '
        'cboSubTaughtSubject
        '
        Me.cboSubTaughtSubject.Location = New System.Drawing.Point(108, 89)
        Me.cboSubTaughtSubject.Name = "cboSubTaughtSubject"
        Me.cboSubTaughtSubject.Size = New System.Drawing.Size(100, 20)
        Me.cboSubTaughtSubject.TabIndex = 22
        '
        'Label186
        '
        Me.Label186.AutoSize = True
        Me.Label186.Location = New System.Drawing.Point(45, 93)
        Me.Label186.Name = "Label186"
        Me.Label186.Size = New System.Drawing.Size(46, 13)
        Me.Label186.TabIndex = 21
        Me.Label186.Text = "Subject:"
        '
        'txtsubtaughtteachers
        '
        Me.txtsubtaughtteachers.Location = New System.Drawing.Point(112, 14)
        Me.txtsubtaughtteachers.Name = "txtsubtaughtteachers"
        Me.txtsubtaughtteachers.Size = New System.Drawing.Size(100, 20)
        Me.txtsubtaughtteachers.TabIndex = 20
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Location = New System.Drawing.Point(43, 19)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(50, 13)
        Me.Label100.TabIndex = 19
        Me.Label100.Text = "Teacher:"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Location = New System.Drawing.Point(45, 71)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(34, 13)
        Me.Label91.TabIndex = 18
        Me.Label91.Text = "Term:"
        '
        'cboSubTaughtTerm
        '
        Me.cboSubTaughtTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubTaughtTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubTaughtTerm.FormattingEnabled = True
        Me.cboSubTaughtTerm.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboSubTaughtTerm.Location = New System.Drawing.Point(109, 63)
        Me.cboSubTaughtTerm.Name = "cboSubTaughtTerm"
        Me.cboSubTaughtTerm.Size = New System.Drawing.Size(69, 21)
        Me.cboSubTaughtTerm.TabIndex = 17
        '
        'rbSubTaughtPerSubject
        '
        Me.rbSubTaughtPerSubject.AutoSize = True
        Me.rbSubTaughtPerSubject.Location = New System.Drawing.Point(158, 143)
        Me.rbSubTaughtPerSubject.Name = "rbSubTaughtPerSubject"
        Me.rbSubTaughtPerSubject.Size = New System.Drawing.Size(77, 17)
        Me.rbSubTaughtPerSubject.TabIndex = 16
        Me.rbSubTaughtPerSubject.Text = "PerSubject"
        Me.rbSubTaughtPerSubject.UseVisualStyleBackColor = True
        '
        'rbSubTaughtPerTeacher
        '
        Me.rbSubTaughtPerTeacher.AutoSize = True
        Me.rbSubTaughtPerTeacher.Checked = True
        Me.rbSubTaughtPerTeacher.Location = New System.Drawing.Point(20, 143)
        Me.rbSubTaughtPerTeacher.Name = "rbSubTaughtPerTeacher"
        Me.rbSubTaughtPerTeacher.Size = New System.Drawing.Size(81, 17)
        Me.rbSubTaughtPerTeacher.TabIndex = 15
        Me.rbSubTaughtPerTeacher.TabStop = True
        Me.rbSubTaughtPerTeacher.Text = "PerTeacher"
        Me.rbSubTaughtPerTeacher.UseVisualStyleBackColor = True
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(48, 45)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(35, 13)
        Me.Label99.TabIndex = 3
        Me.Label99.Text = "Class:"
        '
        'cboSubTotCls
        '
        Me.cboSubTotCls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubTotCls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubTotCls.FormattingEnabled = True
        Me.cboSubTotCls.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014 ", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboSubTotCls.Location = New System.Drawing.Point(112, 37)
        Me.cboSubTotCls.Name = "cboSubTotCls"
        Me.cboSubTotCls.Size = New System.Drawing.Size(66, 21)
        Me.cboSubTotCls.TabIndex = 2
        '
        'gbSubjectsDropped
        '
        Me.gbSubjectsDropped.Controls.Add(Me.dtpSubDrpdTo)
        Me.gbSubjectsDropped.Controls.Add(Me.dtpSudDropdFrom)
        Me.gbSubjectsDropped.Controls.Add(Me.Label79)
        Me.gbSubjectsDropped.Controls.Add(Me.Label80)
        Me.gbSubjectsDropped.Location = New System.Drawing.Point(294, 9)
        Me.gbSubjectsDropped.Name = "gbSubjectsDropped"
        Me.gbSubjectsDropped.Size = New System.Drawing.Size(65, 14)
        Me.gbSubjectsDropped.TabIndex = 17
        Me.gbSubjectsDropped.TabStop = False
        Me.gbSubjectsDropped.Text = "SubjectsDropped"
        Me.gbSubjectsDropped.Visible = False
        '
        'dtpSubDrpdTo
        '
        Me.dtpSubDrpdTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSubDrpdTo.Location = New System.Drawing.Point(251, 43)
        Me.dtpSubDrpdTo.Name = "dtpSubDrpdTo"
        Me.dtpSubDrpdTo.Size = New System.Drawing.Size(111, 20)
        Me.dtpSubDrpdTo.TabIndex = 5
        '
        'dtpSudDropdFrom
        '
        Me.dtpSudDropdFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSudDropdFrom.Location = New System.Drawing.Point(82, 42)
        Me.dtpSudDropdFrom.Name = "dtpSudDropdFrom"
        Me.dtpSudDropdFrom.Size = New System.Drawing.Size(111, 20)
        Me.dtpSudDropdFrom.TabIndex = 4
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(210, 49)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(26, 13)
        Me.Label79.TabIndex = 3
        Me.Label79.Text = "And"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(26, 47)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(49, 13)
        Me.Label80.TabIndex = 1
        Me.Label80.Text = "Between"
        '
        'gbStaffRatings
        '
        Me.gbStaffRatings.Controls.Add(Me.chkBySection)
        Me.gbStaffRatings.Controls.Add(Me.Label94)
        Me.gbStaffRatings.Controls.Add(Me.cboStaffRatingSection)
        Me.gbStaffRatings.Controls.Add(Me.Label95)
        Me.gbStaffRatings.Controls.Add(Me.cboStaffRatingIntk)
        Me.gbStaffRatings.Controls.Add(Me.Label97)
        Me.gbStaffRatings.Controls.Add(Me.cboStaffRatingCls)
        Me.gbStaffRatings.Location = New System.Drawing.Point(64, 11)
        Me.gbStaffRatings.Name = "gbStaffRatings"
        Me.gbStaffRatings.Size = New System.Drawing.Size(63, 40)
        Me.gbStaffRatings.TabIndex = 21
        Me.gbStaffRatings.TabStop = False
        Me.gbStaffRatings.Text = "StaffRatings"
        Me.gbStaffRatings.Visible = False
        '
        'chkBySection
        '
        Me.chkBySection.AutoSize = True
        Me.chkBySection.Location = New System.Drawing.Point(78, 157)
        Me.chkBySection.Name = "chkBySection"
        Me.chkBySection.Size = New System.Drawing.Size(74, 17)
        Me.chkBySection.TabIndex = 15
        Me.chkBySection.Text = "BySection"
        Me.chkBySection.UseVisualStyleBackColor = True
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(32, 48)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(46, 13)
        Me.Label94.TabIndex = 14
        Me.Label94.Text = "Section:"
        '
        'cboStaffRatingSection
        '
        Me.cboStaffRatingSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffRatingSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffRatingSection.FormattingEnabled = True
        Me.cboStaffRatingSection.Items.AddRange(New Object() {"High School", "Business School", "ICT"})
        Me.cboStaffRatingSection.Location = New System.Drawing.Point(102, 40)
        Me.cboStaffRatingSection.Name = "cboStaffRatingSection"
        Me.cboStaffRatingSection.Size = New System.Drawing.Size(84, 21)
        Me.cboStaffRatingSection.TabIndex = 13
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(35, 123)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(40, 13)
        Me.Label95.TabIndex = 12
        Me.Label95.Text = "Intake:"
        '
        'cboStaffRatingIntk
        '
        Me.cboStaffRatingIntk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffRatingIntk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffRatingIntk.FormattingEnabled = True
        Me.cboStaffRatingIntk.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Decmber"})
        Me.cboStaffRatingIntk.Location = New System.Drawing.Point(102, 113)
        Me.cboStaffRatingIntk.Name = "cboStaffRatingIntk"
        Me.cboStaffRatingIntk.Size = New System.Drawing.Size(129, 21)
        Me.cboStaffRatingIntk.TabIndex = 11
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Location = New System.Drawing.Point(35, 80)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(35, 13)
        Me.Label97.TabIndex = 10
        Me.Label97.Text = "Class:"
        '
        'cboStaffRatingCls
        '
        Me.cboStaffRatingCls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffRatingCls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffRatingCls.FormattingEnabled = True
        Me.cboStaffRatingCls.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboStaffRatingCls.Location = New System.Drawing.Point(102, 78)
        Me.cboStaffRatingCls.Name = "cboStaffRatingCls"
        Me.cboStaffRatingCls.Size = New System.Drawing.Size(129, 21)
        Me.cboStaffRatingCls.TabIndex = 9
        '
        'gbDepartmentalAssessment
        '
        Me.gbDepartmentalAssessment.Controls.Add(Me.chkDeptAnaly)
        Me.gbDepartmentalAssessment.Controls.Add(Me.Label105)
        Me.gbDepartmentalAssessment.Controls.Add(Me.cboDptAnlSchool)
        Me.gbDepartmentalAssessment.Controls.Add(Me.Label92)
        Me.gbDepartmentalAssessment.Controls.Add(Me.cboDeptAnalIntk)
        Me.gbDepartmentalAssessment.Controls.Add(Me.Label96)
        Me.gbDepartmentalAssessment.Controls.Add(Me.cboDeptAnalClass)
        Me.gbDepartmentalAssessment.Location = New System.Drawing.Point(547, 55)
        Me.gbDepartmentalAssessment.Name = "gbDepartmentalAssessment"
        Me.gbDepartmentalAssessment.Size = New System.Drawing.Size(69, 23)
        Me.gbDepartmentalAssessment.TabIndex = 20
        Me.gbDepartmentalAssessment.TabStop = False
        Me.gbDepartmentalAssessment.Text = "DepartmentalAssessment"
        Me.gbDepartmentalAssessment.Visible = False
        '
        'chkDeptAnaly
        '
        Me.chkDeptAnaly.AutoSize = True
        Me.chkDeptAnaly.Location = New System.Drawing.Point(123, 161)
        Me.chkDeptAnaly.Name = "chkDeptAnaly"
        Me.chkDeptAnaly.Size = New System.Drawing.Size(115, 17)
        Me.chkDeptAnaly.TabIndex = 16
        Me.chkDeptAnaly.Text = "OverallAssessment"
        Me.chkDeptAnaly.UseVisualStyleBackColor = True
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Location = New System.Drawing.Point(49, 134)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(43, 13)
        Me.Label105.TabIndex = 14
        Me.Label105.Text = "School:"
        '
        'cboDptAnlSchool
        '
        Me.cboDptAnlSchool.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDptAnlSchool.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDptAnlSchool.FormattingEnabled = True
        Me.cboDptAnlSchool.Items.AddRange(New Object() {"High School", "Business School", "ICT"})
        Me.cboDptAnlSchool.Location = New System.Drawing.Point(114, 127)
        Me.cboDptAnlSchool.Name = "cboDptAnlSchool"
        Me.cboDptAnlSchool.Size = New System.Drawing.Size(129, 21)
        Me.cboDptAnlSchool.TabIndex = 13
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(44, 97)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(40, 13)
        Me.Label92.TabIndex = 12
        Me.Label92.Text = "Intake:"
        '
        'cboDeptAnalIntk
        '
        Me.cboDeptAnalIntk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDeptAnalIntk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDeptAnalIntk.FormattingEnabled = True
        Me.cboDeptAnalIntk.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Decmber"})
        Me.cboDeptAnalIntk.Location = New System.Drawing.Point(114, 91)
        Me.cboDeptAnalIntk.Name = "cboDeptAnalIntk"
        Me.cboDeptAnalIntk.Size = New System.Drawing.Size(129, 21)
        Me.cboDeptAnalIntk.TabIndex = 11
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(44, 63)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(35, 13)
        Me.Label96.TabIndex = 3
        Me.Label96.Text = "Class:"
        '
        'cboDeptAnalClass
        '
        Me.cboDeptAnalClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDeptAnalClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDeptAnalClass.FormattingEnabled = True
        Me.cboDeptAnalClass.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014 ", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboDeptAnalClass.Location = New System.Drawing.Point(114, 54)
        Me.cboDeptAnalClass.Name = "cboDeptAnalClass"
        Me.cboDeptAnalClass.Size = New System.Drawing.Size(121, 21)
        Me.cboDeptAnalClass.TabIndex = 2
        '
        'gbStaffAssessment
        '
        Me.gbStaffAssessment.Controls.Add(Me.rbStaffAssPerSection)
        Me.gbStaffAssessment.Controls.Add(Me.rbAssessmentPerSub)
        Me.gbStaffAssessment.Controls.Add(Me.lblectures)
        Me.gbStaffAssessment.Controls.Add(Me.rbStaffAssPerIndv)
        Me.gbStaffAssessment.Controls.Add(Me.rbStaffAssPerClass)
        Me.gbStaffAssessment.Controls.Add(Me.Label89)
        Me.gbStaffAssessment.Controls.Add(Me.cboStaffAssSub)
        Me.gbStaffAssessment.Controls.Add(Me.Label81)
        Me.gbStaffAssessment.Controls.Add(Me.cboStaffAssStaff)
        Me.gbStaffAssessment.Controls.Add(Me.Label82)
        Me.gbStaffAssessment.Controls.Add(Me.cboStaffAssIntk)
        Me.gbStaffAssessment.Controls.Add(Me.Label83)
        Me.gbStaffAssessment.Controls.Add(Me.cboStaffAssCls)
        Me.gbStaffAssessment.Controls.Add(Me.Label85)
        Me.gbStaffAssessment.Controls.Add(Me.cboStaffAssSect)
        Me.gbStaffAssessment.Controls.Add(Me.Label86)
        Me.gbStaffAssessment.Controls.Add(Me.cboStaffAssSem)
        Me.gbStaffAssessment.Controls.Add(Me.Label87)
        Me.gbStaffAssessment.Controls.Add(Me.cboStaffAssYear)
        Me.gbStaffAssessment.Controls.Add(Me.Label88)
        Me.gbStaffAssessment.Controls.Add(Me.cboStaffAssProg)
        Me.gbStaffAssessment.Location = New System.Drawing.Point(257, 16)
        Me.gbStaffAssessment.Name = "gbStaffAssessment"
        Me.gbStaffAssessment.Size = New System.Drawing.Size(27, 14)
        Me.gbStaffAssessment.TabIndex = 19
        Me.gbStaffAssessment.TabStop = False
        Me.gbStaffAssessment.Text = "StaffAssessment"
        Me.gbStaffAssessment.Visible = False
        '
        'rbStaffAssPerSection
        '
        Me.rbStaffAssPerSection.AutoSize = True
        Me.rbStaffAssPerSection.Location = New System.Drawing.Point(298, 282)
        Me.rbStaffAssPerSection.Name = "rbStaffAssPerSection"
        Me.rbStaffAssPerSection.Size = New System.Drawing.Size(77, 17)
        Me.rbStaffAssPerSection.TabIndex = 28
        Me.rbStaffAssPerSection.TabStop = True
        Me.rbStaffAssPerSection.Text = "PerSection"
        Me.rbStaffAssPerSection.UseVisualStyleBackColor = True
        '
        'rbAssessmentPerSub
        '
        Me.rbAssessmentPerSub.AutoSize = True
        Me.rbAssessmentPerSub.Location = New System.Drawing.Point(198, 282)
        Me.rbAssessmentPerSub.Name = "rbAssessmentPerSub"
        Me.rbAssessmentPerSub.Size = New System.Drawing.Size(77, 17)
        Me.rbAssessmentPerSub.TabIndex = 27
        Me.rbAssessmentPerSub.TabStop = True
        Me.rbAssessmentPerSub.Text = "PerSubject"
        Me.rbAssessmentPerSub.UseVisualStyleBackColor = True
        '
        'lblectures
        '
        Me.lblectures.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblectures.BackColor = System.Drawing.Color.LightYellow
        Me.lblectures.FormattingEnabled = True
        Me.lblectures.Location = New System.Drawing.Point(100, 39)
        Me.lblectures.Name = "lblectures"
        Me.lblectures.Size = New System.Drawing.Size(273, 4)
        Me.lblectures.TabIndex = 26
        Me.lblectures.Visible = False
        '
        'rbStaffAssPerIndv
        '
        Me.rbStaffAssPerIndv.AutoSize = True
        Me.rbStaffAssPerIndv.Location = New System.Drawing.Point(102, 282)
        Me.rbStaffAssPerIndv.Name = "rbStaffAssPerIndv"
        Me.rbStaffAssPerIndv.Size = New System.Drawing.Size(80, 17)
        Me.rbStaffAssPerIndv.TabIndex = 18
        Me.rbStaffAssPerIndv.TabStop = True
        Me.rbStaffAssPerIndv.Text = "PerLecturer"
        Me.rbStaffAssPerIndv.UseVisualStyleBackColor = True
        '
        'rbStaffAssPerClass
        '
        Me.rbStaffAssPerClass.AutoSize = True
        Me.rbStaffAssPerClass.Location = New System.Drawing.Point(16, 282)
        Me.rbStaffAssPerClass.Name = "rbStaffAssPerClass"
        Me.rbStaffAssPerClass.Size = New System.Drawing.Size(66, 17)
        Me.rbStaffAssPerClass.TabIndex = 17
        Me.rbStaffAssPerClass.TabStop = True
        Me.rbStaffAssPerClass.Text = "PerClass"
        Me.rbStaffAssPerClass.UseVisualStyleBackColor = True
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(39, 93)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(46, 13)
        Me.Label89.TabIndex = 16
        Me.Label89.Text = "Subject:"
        '
        'cboStaffAssSub
        '
        Me.cboStaffAssSub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffAssSub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffAssSub.DisplayMember = "SubjectID"
        Me.cboStaffAssSub.FormattingEnabled = True
        Me.cboStaffAssSub.Location = New System.Drawing.Point(102, 90)
        Me.cboStaffAssSub.Name = "cboStaffAssSub"
        Me.cboStaffAssSub.Size = New System.Drawing.Size(270, 21)
        Me.cboStaffAssSub.TabIndex = 15
        Me.cboStaffAssSub.ValueMember = "SubjectID"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(33, 24)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(49, 13)
        Me.Label81.TabIndex = 14
        Me.Label81.Text = "Lecturer:"
        '
        'cboStaffAssStaff
        '
        Me.cboStaffAssStaff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffAssStaff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffAssStaff.DisplayMember = "StudentID"
        Me.cboStaffAssStaff.FormattingEnabled = True
        Me.cboStaffAssStaff.Location = New System.Drawing.Point(101, 17)
        Me.cboStaffAssStaff.Name = "cboStaffAssStaff"
        Me.cboStaffAssStaff.Size = New System.Drawing.Size(270, 21)
        Me.cboStaffAssStaff.TabIndex = 13
        Me.cboStaffAssStaff.ValueMember = "StudentID"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(38, 250)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(40, 13)
        Me.Label82.TabIndex = 12
        Me.Label82.Text = "Intake:"
        '
        'cboStaffAssIntk
        '
        Me.cboStaffAssIntk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffAssIntk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffAssIntk.FormattingEnabled = True
        Me.cboStaffAssIntk.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Decmber"})
        Me.cboStaffAssIntk.Location = New System.Drawing.Point(100, 242)
        Me.cboStaffAssIntk.Name = "cboStaffAssIntk"
        Me.cboStaffAssIntk.Size = New System.Drawing.Size(129, 21)
        Me.cboStaffAssIntk.TabIndex = 11
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(39, 223)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(35, 13)
        Me.Label83.TabIndex = 10
        Me.Label83.Text = "Class:"
        '
        'cboStaffAssCls
        '
        Me.cboStaffAssCls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffAssCls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffAssCls.FormattingEnabled = True
        Me.cboStaffAssCls.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboStaffAssCls.Location = New System.Drawing.Point(101, 214)
        Me.cboStaffAssCls.Name = "cboStaffAssCls"
        Me.cboStaffAssCls.Size = New System.Drawing.Size(129, 21)
        Me.cboStaffAssCls.TabIndex = 9
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(38, 193)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(46, 13)
        Me.Label85.TabIndex = 8
        Me.Label85.Text = "Section:"
        '
        'cboStaffAssSect
        '
        Me.cboStaffAssSect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffAssSect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffAssSect.Enabled = False
        Me.cboStaffAssSect.FormattingEnabled = True
        Me.cboStaffAssSect.Items.AddRange(New Object() {"ICT", "Business School"})
        Me.cboStaffAssSect.Location = New System.Drawing.Point(101, 184)
        Me.cboStaffAssSect.Name = "cboStaffAssSect"
        Me.cboStaffAssSect.Size = New System.Drawing.Size(129, 21)
        Me.cboStaffAssSect.TabIndex = 7
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(38, 159)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(51, 13)
        Me.Label86.TabIndex = 5
        Me.Label86.Text = "Semester"
        '
        'cboStaffAssSem
        '
        Me.cboStaffAssSem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffAssSem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffAssSem.FormattingEnabled = True
        Me.cboStaffAssSem.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cboStaffAssSem.Location = New System.Drawing.Point(102, 158)
        Me.cboStaffAssSem.Name = "cboStaffAssSem"
        Me.cboStaffAssSem.Size = New System.Drawing.Size(121, 21)
        Me.cboStaffAssSem.TabIndex = 4
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(38, 133)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(29, 13)
        Me.Label87.TabIndex = 3
        Me.Label87.Text = "Year"
        '
        'cboStaffAssYear
        '
        Me.cboStaffAssYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffAssYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffAssYear.FormattingEnabled = True
        Me.cboStaffAssYear.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboStaffAssYear.Location = New System.Drawing.Point(101, 125)
        Me.cboStaffAssYear.Name = "cboStaffAssYear"
        Me.cboStaffAssYear.Size = New System.Drawing.Size(121, 21)
        Me.cboStaffAssYear.TabIndex = 2
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(38, 60)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(49, 13)
        Me.Label88.TabIndex = 1
        Me.Label88.Text = "Program:"
        '
        'cboStaffAssProg
        '
        Me.cboStaffAssProg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStaffAssProg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStaffAssProg.DisplayMember = "Forms"
        Me.cboStaffAssProg.FormattingEnabled = True
        Me.cboStaffAssProg.Location = New System.Drawing.Point(102, 52)
        Me.cboStaffAssProg.Name = "cboStaffAssProg"
        Me.cboStaffAssProg.Size = New System.Drawing.Size(270, 21)
        Me.cboStaffAssProg.TabIndex = 0
        Me.cboStaffAssProg.ValueMember = "Forms"
        '
        'gbDetailedMarks
        '
        Me.gbDetailedMarks.Controls.Add(Me.rbPublish)
        Me.gbDetailedMarks.Controls.Add(Me.rbClassResStats)
        Me.gbDetailedMarks.Controls.Add(Me.rbResStat)
        Me.gbDetailedMarks.Controls.Add(Me.lbTransSumStud)
        Me.gbDetailedMarks.Controls.Add(Me.rbTansSum)
        Me.gbDetailedMarks.Controls.Add(Me.Label90)
        Me.gbDetailedMarks.Controls.Add(Me.cboDetailedMarksStud)
        Me.gbDetailedMarks.Controls.Add(Me.Label75)
        Me.gbDetailedMarks.Controls.Add(Me.cboDetailedMarksIntake)
        Me.gbDetailedMarks.Controls.Add(Me.rbResDisplay)
        Me.gbDetailedMarks.Controls.Add(Me.rbResSummary)
        Me.gbDetailedMarks.Controls.Add(Me.rbResDetail)
        Me.gbDetailedMarks.Controls.Add(Me.Label26)
        Me.gbDetailedMarks.Controls.Add(Me.cboDetailedMarksSect)
        Me.gbDetailedMarks.Controls.Add(Me.Label25)
        Me.gbDetailedMarks.Controls.Add(Me.cboDetailedMarksLevel)
        Me.gbDetailedMarks.Controls.Add(Me.Label27)
        Me.gbDetailedMarks.Controls.Add(Me.cboDetailedMarksClass)
        Me.gbDetailedMarks.Controls.Add(Me.Label28)
        Me.gbDetailedMarks.Controls.Add(Me.cboDetailedMarksProg)
        Me.gbDetailedMarks.Location = New System.Drawing.Point(730, 9)
        Me.gbDetailedMarks.Name = "gbDetailedMarks"
        Me.gbDetailedMarks.Size = New System.Drawing.Size(38, 44)
        Me.gbDetailedMarks.TabIndex = 10
        Me.gbDetailedMarks.TabStop = False
        Me.gbDetailedMarks.Text = "DetailedStudMarks"
        Me.gbDetailedMarks.Visible = False
        '
        'rbPublish
        '
        Me.rbPublish.AutoSize = True
        Me.rbPublish.Location = New System.Drawing.Point(579, 286)
        Me.rbPublish.Name = "rbPublish"
        Me.rbPublish.Size = New System.Drawing.Size(92, 17)
        Me.rbPublish.TabIndex = 25
        Me.rbPublish.TabStop = True
        Me.rbPublish.Text = "Publish Online"
        Me.rbPublish.UseVisualStyleBackColor = True
        '
        'rbClassResStats
        '
        Me.rbClassResStats.AutoSize = True
        Me.rbClassResStats.Location = New System.Drawing.Point(437, 286)
        Me.rbClassResStats.Name = "rbClassResStats"
        Me.rbClassResStats.Size = New System.Drawing.Size(142, 17)
        Me.rbClassResStats.TabIndex = 24
        Me.rbClassResStats.TabStop = True
        Me.rbClassResStats.Text = "ClassResultsResultsSlips"
        Me.rbClassResStats.UseVisualStyleBackColor = True
        '
        'rbResStat
        '
        Me.rbResStat.AutoSize = True
        Me.rbResStat.Location = New System.Drawing.Point(320, 286)
        Me.rbResStat.Name = "rbResStat"
        Me.rbResStat.Size = New System.Drawing.Size(122, 17)
        Me.rbResStat.TabIndex = 23
        Me.rbResStat.TabStop = True
        Me.rbResStat.Text = "IndividualResultsSlip"
        Me.rbResStat.UseVisualStyleBackColor = True
        '
        'lbTransSumStud
        '
        Me.lbTransSumStud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbTransSumStud.BackColor = System.Drawing.Color.LightYellow
        Me.lbTransSumStud.FormattingEnabled = True
        Me.lbTransSumStud.Location = New System.Drawing.Point(355, 44)
        Me.lbTransSumStud.Name = "lbTransSumStud"
        Me.lbTransSumStud.Size = New System.Drawing.Size(209, 17)
        Me.lbTransSumStud.TabIndex = 22
        Me.lbTransSumStud.Visible = False
        '
        'rbTansSum
        '
        Me.rbTansSum.AutoSize = True
        Me.rbTansSum.Location = New System.Drawing.Point(201, 286)
        Me.rbTansSum.Name = "rbTansSum"
        Me.rbTansSum.Size = New System.Drawing.Size(115, 17)
        Me.rbTansSum.TabIndex = 21
        Me.rbTansSum.TabStop = True
        Me.rbTansSum.Text = "TranscriptSummary"
        Me.rbTansSum.UseVisualStyleBackColor = True
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Location = New System.Drawing.Point(105, 52)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(44, 13)
        Me.Label90.TabIndex = 20
        Me.Label90.Text = "Student"
        '
        'cboDetailedMarksStud
        '
        Me.cboDetailedMarksStud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDetailedMarksStud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDetailedMarksStud.DisplayMember = "Forms"
        Me.cboDetailedMarksStud.Enabled = False
        Me.cboDetailedMarksStud.FormattingEnabled = True
        Me.cboDetailedMarksStud.Location = New System.Drawing.Point(201, 44)
        Me.cboDetailedMarksStud.Name = "cboDetailedMarksStud"
        Me.cboDetailedMarksStud.Size = New System.Drawing.Size(152, 21)
        Me.cboDetailedMarksStud.TabIndex = 19
        Me.cboDetailedMarksStud.ValueMember = "Forms"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(106, 232)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(40, 13)
        Me.Label75.TabIndex = 18
        Me.Label75.Text = "Intake:"
        '
        'cboDetailedMarksIntake
        '
        Me.cboDetailedMarksIntake.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDetailedMarksIntake.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDetailedMarksIntake.FormattingEnabled = True
        Me.cboDetailedMarksIntake.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November ", "December"})
        Me.cboDetailedMarksIntake.Location = New System.Drawing.Point(201, 221)
        Me.cboDetailedMarksIntake.Name = "cboDetailedMarksIntake"
        Me.cboDetailedMarksIntake.Size = New System.Drawing.Size(121, 21)
        Me.cboDetailedMarksIntake.TabIndex = 17
        '
        'rbResDisplay
        '
        Me.rbResDisplay.AutoSize = True
        Me.rbResDisplay.Location = New System.Drawing.Point(130, 286)
        Me.rbResDisplay.Name = "rbResDisplay"
        Me.rbResDisplay.Size = New System.Drawing.Size(70, 17)
        Me.rbResDisplay.TabIndex = 16
        Me.rbResDisplay.TabStop = True
        Me.rbResDisplay.Text = "PUBLIST"
        Me.rbResDisplay.UseVisualStyleBackColor = True
        '
        'rbResSummary
        '
        Me.rbResSummary.AutoSize = True
        Me.rbResSummary.Location = New System.Drawing.Point(64, 286)
        Me.rbResSummary.Name = "rbResSummary"
        Me.rbResSummary.Size = New System.Drawing.Size(68, 17)
        Me.rbResSummary.TabIndex = 15
        Me.rbResSummary.TabStop = True
        Me.rbResSummary.Text = "Summary"
        Me.rbResSummary.UseVisualStyleBackColor = True
        '
        'rbResDetail
        '
        Me.rbResDetail.AutoSize = True
        Me.rbResDetail.Location = New System.Drawing.Point(3, 286)
        Me.rbResDetail.Name = "rbResDetail"
        Me.rbResDetail.Size = New System.Drawing.Size(64, 17)
        Me.rbResDetail.TabIndex = 14
        Me.rbResDetail.TabStop = True
        Me.rbResDetail.Text = "Detailed"
        Me.rbResDetail.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(106, 192)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 13)
        Me.Label26.TabIndex = 11
        Me.Label26.Text = "Section:"
        '
        'cboDetailedMarksSect
        '
        Me.cboDetailedMarksSect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDetailedMarksSect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDetailedMarksSect.FormattingEnabled = True
        Me.cboDetailedMarksSect.Items.AddRange(New Object() {"High School", "IT", "Business School"})
        Me.cboDetailedMarksSect.Location = New System.Drawing.Point(201, 184)
        Me.cboDetailedMarksSect.Name = "cboDetailedMarksSect"
        Me.cboDetailedMarksSect.Size = New System.Drawing.Size(121, 21)
        Me.cboDetailedMarksSect.TabIndex = 10
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(105, 159)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 13)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Level:"
        '
        'cboDetailedMarksLevel
        '
        Me.cboDetailedMarksLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDetailedMarksLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDetailedMarksLevel.Enabled = False
        Me.cboDetailedMarksLevel.FormattingEnabled = True
        Me.cboDetailedMarksLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboDetailedMarksLevel.Location = New System.Drawing.Point(201, 147)
        Me.cboDetailedMarksLevel.Name = "cboDetailedMarksLevel"
        Me.cboDetailedMarksLevel.Size = New System.Drawing.Size(121, 21)
        Me.cboDetailedMarksLevel.TabIndex = 6
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(111, 127)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(35, 13)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Class:"
        '
        'cboDetailedMarksClass
        '
        Me.cboDetailedMarksClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDetailedMarksClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDetailedMarksClass.FormattingEnabled = True
        Me.cboDetailedMarksClass.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboDetailedMarksClass.Location = New System.Drawing.Point(201, 113)
        Me.cboDetailedMarksClass.Name = "cboDetailedMarksClass"
        Me.cboDetailedMarksClass.Size = New System.Drawing.Size(121, 21)
        Me.cboDetailedMarksClass.TabIndex = 2
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(105, 94)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(46, 13)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Program"
        '
        'cboDetailedMarksProg
        '
        Me.cboDetailedMarksProg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDetailedMarksProg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDetailedMarksProg.DisplayMember = "Forms"
        Me.cboDetailedMarksProg.FormattingEnabled = True
        Me.cboDetailedMarksProg.Location = New System.Drawing.Point(201, 82)
        Me.cboDetailedMarksProg.Name = "cboDetailedMarksProg"
        Me.cboDetailedMarksProg.Size = New System.Drawing.Size(208, 21)
        Me.cboDetailedMarksProg.TabIndex = 0
        Me.cboDetailedMarksProg.ValueMember = "Forms"
        '
        'gbKnowHow
        '
        Me.gbKnowHow.Controls.Add(Me.cboKnowHowYear)
        Me.gbKnowHow.Controls.Add(Me.Label84)
        Me.gbKnowHow.Location = New System.Drawing.Point(286, 47)
        Me.gbKnowHow.Name = "gbKnowHow"
        Me.gbKnowHow.Size = New System.Drawing.Size(29, 24)
        Me.gbKnowHow.TabIndex = 18
        Me.gbKnowHow.TabStop = False
        Me.gbKnowHow.Text = "KnowHow"
        Me.gbKnowHow.Visible = False
        '
        'cboKnowHowYear
        '
        Me.cboKnowHowYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboKnowHowYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboKnowHowYear.FormattingEnabled = True
        Me.cboKnowHowYear.Items.AddRange(New Object() {"2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboKnowHowYear.Location = New System.Drawing.Point(65, 25)
        Me.cboKnowHowYear.Name = "cboKnowHowYear"
        Me.cboKnowHowYear.Size = New System.Drawing.Size(121, 21)
        Me.cboKnowHowYear.TabIndex = 19
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(18, 29)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(32, 13)
        Me.Label84.TabIndex = 18
        Me.Label84.Text = "Year:"
        '
        'gbSubStuds
        '
        Me.gbSubStuds.Controls.Add(Me.Label141)
        Me.gbSubStuds.Controls.Add(Me.cboSubStudsLvl)
        Me.gbSubStuds.Controls.Add(Me.Label140)
        Me.gbSubStuds.Controls.Add(Me.cboSubStudsSem)
        Me.gbSubStuds.Controls.Add(Me.Label133)
        Me.gbSubStuds.Controls.Add(Me.cboSubStudsSession)
        Me.gbSubStuds.Controls.Add(Me.Label73)
        Me.gbSubStuds.Controls.Add(Me.cboSubStudSection)
        Me.gbSubStuds.Controls.Add(Me.rbCoursewek)
        Me.gbSubStuds.Controls.Add(Me.Label45)
        Me.gbSubStuds.Controls.Add(Me.cboMarkSheetExam)
        Me.gbSubStuds.Controls.Add(Me.RbMarkSheet)
        Me.gbSubStuds.Controls.Add(Me.rbExamAttendance)
        Me.gbSubStuds.Controls.Add(Me.rbAllSubStuds)
        Me.gbSubStuds.Controls.Add(Me.rbSubByProg)
        Me.gbSubStuds.Controls.Add(Me.Label21)
        Me.gbSubStuds.Controls.Add(Me.cboSubStudsProgram)
        Me.gbSubStuds.Controls.Add(Me.Label19)
        Me.gbSubStuds.Controls.Add(Me.cboSubStudsIntake)
        Me.gbSubStuds.Controls.Add(Me.Label8)
        Me.gbSubStuds.Controls.Add(Me.Label9)
        Me.gbSubStuds.Controls.Add(Me.cboSubStudsYera)
        Me.gbSubStuds.Controls.Add(Me.cboSubStudsID)
        Me.gbSubStuds.Location = New System.Drawing.Point(564, 124)
        Me.gbSubStuds.Name = "gbSubStuds"
        Me.gbSubStuds.Size = New System.Drawing.Size(114, 41)
        Me.gbSubStuds.TabIndex = 3
        Me.gbSubStuds.TabStop = False
        Me.gbSubStuds.Text = "SubjectStudents"
        Me.gbSubStuds.Visible = False
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Location = New System.Drawing.Point(13, 77)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(30, 13)
        Me.Label141.TabIndex = 26
        Me.Label141.Text = "Form"
        '
        'cboSubStudsLvl
        '
        Me.cboSubStudsLvl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubStudsLvl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubStudsLvl.FormattingEnabled = True
        Me.cboSubStudsLvl.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboSubStudsLvl.Location = New System.Drawing.Point(91, 85)
        Me.cboSubStudsLvl.Name = "cboSubStudsLvl"
        Me.cboSubStudsLvl.Size = New System.Drawing.Size(67, 21)
        Me.cboSubStudsLvl.TabIndex = 25
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.Location = New System.Drawing.Point(9, 115)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(31, 13)
        Me.Label140.TabIndex = 24
        Me.Label140.Text = "Term"
        '
        'cboSubStudsSem
        '
        Me.cboSubStudsSem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubStudsSem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubStudsSem.FormattingEnabled = True
        Me.cboSubStudsSem.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboSubStudsSem.Location = New System.Drawing.Point(90, 110)
        Me.cboSubStudsSem.Name = "cboSubStudsSem"
        Me.cboSubStudsSem.Size = New System.Drawing.Size(68, 21)
        Me.cboSubStudsSem.TabIndex = 23
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Location = New System.Drawing.Point(9, 144)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(44, 13)
        Me.Label133.TabIndex = 22
        Me.Label133.Text = "Session"
        '
        'cboSubStudsSession
        '
        Me.cboSubStudsSession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubStudsSession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubStudsSession.DisplayMember = "Session"
        Me.cboSubStudsSession.FormattingEnabled = True
        Me.cboSubStudsSession.Location = New System.Drawing.Point(90, 134)
        Me.cboSubStudsSession.Name = "cboSubStudsSession"
        Me.cboSubStudsSession.Size = New System.Drawing.Size(113, 21)
        Me.cboSubStudsSession.TabIndex = 21
        Me.cboSubStudsSession.ValueMember = "Session"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(8, 229)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(46, 13)
        Me.Label73.TabIndex = 20
        Me.Label73.Text = "Section:"
        '
        'cboSubStudSection
        '
        Me.cboSubStudSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubStudSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubStudSection.DisplayMember = "Forms"
        Me.cboSubStudSection.FormattingEnabled = True
        Me.cboSubStudSection.Items.AddRange(New Object() {"IT", "High School", "Business School"})
        Me.cboSubStudSection.Location = New System.Drawing.Point(90, 217)
        Me.cboSubStudSection.Name = "cboSubStudSection"
        Me.cboSubStudSection.Size = New System.Drawing.Size(113, 21)
        Me.cboSubStudSection.TabIndex = 19
        Me.cboSubStudSection.ValueMember = "Forms"
        '
        'rbCoursewek
        '
        Me.rbCoursewek.AutoSize = True
        Me.rbCoursewek.Location = New System.Drawing.Point(435, 244)
        Me.rbCoursewek.Name = "rbCoursewek"
        Me.rbCoursewek.Size = New System.Drawing.Size(142, 17)
        Me.rbCoursewek.TabIndex = 18
        Me.rbCoursewek.TabStop = True
        Me.rbCoursewek.Text = "MarkSheet(CourseWork)"
        Me.rbCoursewek.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(9, 199)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(36, 13)
        Me.Label45.TabIndex = 17
        Me.Label45.Text = "Exam:"
        '
        'cboMarkSheetExam
        '
        Me.cboMarkSheetExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMarkSheetExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarkSheetExam.DisplayMember = "Forms"
        Me.cboMarkSheetExam.Enabled = False
        Me.cboMarkSheetExam.FormattingEnabled = True
        Me.cboMarkSheetExam.Items.AddRange(New Object() {"June 2012", "November 2012", "First Term 2012", "Second Term 2012", "Third Term 2012", "June 2013", "November 2013", "First Term 2013", "Second Term 2013", "Third Term 2013", "June 2013", "November 2013", "First Term 2013", "Second Term 2013", "Third Term 2012", "November 2011", "June 2011"})
        Me.cboMarkSheetExam.Location = New System.Drawing.Point(91, 190)
        Me.cboMarkSheetExam.Name = "cboMarkSheetExam"
        Me.cboMarkSheetExam.Size = New System.Drawing.Size(112, 21)
        Me.cboMarkSheetExam.TabIndex = 16
        Me.cboMarkSheetExam.ValueMember = "Forms"
        '
        'RbMarkSheet
        '
        Me.RbMarkSheet.AutoSize = True
        Me.RbMarkSheet.Location = New System.Drawing.Point(319, 244)
        Me.RbMarkSheet.Name = "RbMarkSheet"
        Me.RbMarkSheet.Size = New System.Drawing.Size(109, 17)
        Me.RbMarkSheet.TabIndex = 15
        Me.RbMarkSheet.TabStop = True
        Me.RbMarkSheet.Text = "MarkSheet(Exam)"
        Me.RbMarkSheet.UseVisualStyleBackColor = True
        '
        'rbExamAttendance
        '
        Me.rbExamAttendance.AutoSize = True
        Me.rbExamAttendance.Location = New System.Drawing.Point(176, 244)
        Me.rbExamAttendance.Name = "rbExamAttendance"
        Me.rbExamAttendance.Size = New System.Drawing.Size(129, 17)
        Me.rbExamAttendance.TabIndex = 14
        Me.rbExamAttendance.TabStop = True
        Me.rbExamAttendance.Text = "ExamAttendanceForm"
        Me.rbExamAttendance.UseVisualStyleBackColor = True
        '
        'rbAllSubStuds
        '
        Me.rbAllSubStuds.AutoSize = True
        Me.rbAllSubStuds.Location = New System.Drawing.Point(96, 244)
        Me.rbAllSubStuds.Name = "rbAllSubStuds"
        Me.rbAllSubStuds.Size = New System.Drawing.Size(73, 17)
        Me.rbAllSubStuds.TabIndex = 13
        Me.rbAllSubStuds.TabStop = True
        Me.rbAllSubStuds.Text = "BySubject"
        Me.rbAllSubStuds.UseVisualStyleBackColor = True
        '
        'rbSubByProg
        '
        Me.rbSubByProg.AutoSize = True
        Me.rbSubByProg.Location = New System.Drawing.Point(7, 245)
        Me.rbSubByProg.Name = "rbSubByProg"
        Me.rbSubByProg.Size = New System.Drawing.Size(76, 17)
        Me.rbSubByProg.TabIndex = 11
        Me.rbSubByProg.TabStop = True
        Me.rbSubByProg.Text = "ByProgram"
        Me.rbSubByProg.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 171)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 13)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Program"
        '
        'cboSubStudsProgram
        '
        Me.cboSubStudsProgram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubStudsProgram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubStudsProgram.DisplayMember = "Forms"
        Me.cboSubStudsProgram.Enabled = False
        Me.cboSubStudsProgram.FormattingEnabled = True
        Me.cboSubStudsProgram.Location = New System.Drawing.Point(91, 161)
        Me.cboSubStudsProgram.Name = "cboSubStudsProgram"
        Me.cboSubStudsProgram.Size = New System.Drawing.Size(212, 21)
        Me.cboSubStudsProgram.TabIndex = 9
        Me.cboSubStudsProgram.ValueMember = "Forms"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 13)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Intake"
        '
        'cboSubStudsIntake
        '
        Me.cboSubStudsIntake.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubStudsIntake.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubStudsIntake.Enabled = False
        Me.cboSubStudsIntake.FormattingEnabled = True
        Me.cboSubStudsIntake.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboSubStudsIntake.Location = New System.Drawing.Point(91, 59)
        Me.cboSubStudsIntake.Name = "cboSubStudsIntake"
        Me.cboSubStudsIntake.Size = New System.Drawing.Size(121, 21)
        Me.cboSubStudsIntake.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Year"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Subject"
        '
        'cboSubStudsYera
        '
        Me.cboSubStudsYera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubStudsYera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubStudsYera.Enabled = False
        Me.cboSubStudsYera.FormattingEnabled = True
        Me.cboSubStudsYera.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboSubStudsYera.Location = New System.Drawing.Point(91, 37)
        Me.cboSubStudsYera.Name = "cboSubStudsYera"
        Me.cboSubStudsYera.Size = New System.Drawing.Size(67, 21)
        Me.cboSubStudsYera.TabIndex = 2
        '
        'cboSubStudsID
        '
        Me.cboSubStudsID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubStudsID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubStudsID.DisplayMember = "SubjectID"
        Me.cboSubStudsID.FormattingEnabled = True
        Me.cboSubStudsID.Location = New System.Drawing.Point(91, 10)
        Me.cboSubStudsID.Name = "cboSubStudsID"
        Me.cboSubStudsID.Size = New System.Drawing.Size(216, 21)
        Me.cboSubStudsID.TabIndex = 0
        Me.cboSubStudsID.ValueMember = "SubjectID"
        '
        'gbTrans
        '
        Me.gbTrans.Controls.Add(Me.lstStudents)
        Me.gbTrans.Controls.Add(Me.Label76)
        Me.gbTrans.Controls.Add(Me.cboTransStudID)
        Me.gbTrans.Controls.Add(Me.Label46)
        Me.gbTrans.Controls.Add(Me.cboTransIntk)
        Me.gbTrans.Controls.Add(Me.Label34)
        Me.gbTrans.Controls.Add(Me.cboTransClass)
        Me.gbTrans.Controls.Add(Me.Label35)
        Me.gbTrans.Controls.Add(Me.cboTransReg)
        Me.gbTrans.Controls.Add(Me.chkAllYears)
        Me.gbTrans.Controls.Add(Me.Label3)
        Me.gbTrans.Controls.Add(Me.cbTransSem)
        Me.gbTrans.Controls.Add(Me.Label2)
        Me.gbTrans.Controls.Add(Me.cbTransYear)
        Me.gbTrans.Controls.Add(Me.Label1)
        Me.gbTrans.Controls.Add(Me.cbTransProg)
        Me.gbTrans.Location = New System.Drawing.Point(571, 27)
        Me.gbTrans.Name = "gbTrans"
        Me.gbTrans.Size = New System.Drawing.Size(33, 24)
        Me.gbTrans.TabIndex = 0
        Me.gbTrans.TabStop = False
        Me.gbTrans.Text = "Transcript"
        Me.gbTrans.Visible = False
        '
        'lstStudents
        '
        Me.lstStudents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstStudents.BackColor = System.Drawing.Color.LightYellow
        Me.lstStudents.FormattingEnabled = True
        Me.lstStudents.Location = New System.Drawing.Point(100, 74)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(209, 4)
        Me.lstStudents.TabIndex = 15
        Me.lstStudents.Visible = False
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(34, 61)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(47, 13)
        Me.Label76.TabIndex = 14
        Me.Label76.Text = "Student:"
        '
        'cboTransStudID
        '
        Me.cboTransStudID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTransStudID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTransStudID.DisplayMember = "StudentID"
        Me.cboTransStudID.Enabled = False
        Me.cboTransStudID.FormattingEnabled = True
        Me.cboTransStudID.Location = New System.Drawing.Point(99, 53)
        Me.cboTransStudID.Name = "cboTransStudID"
        Me.cboTransStudID.Size = New System.Drawing.Size(270, 21)
        Me.cboTransStudID.TabIndex = 13
        Me.cboTransStudID.ValueMember = "StudentID"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(38, 250)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(40, 13)
        Me.Label46.TabIndex = 12
        Me.Label46.Text = "Intake:"
        '
        'cboTransIntk
        '
        Me.cboTransIntk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTransIntk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTransIntk.FormattingEnabled = True
        Me.cboTransIntk.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Decmber"})
        Me.cboTransIntk.Location = New System.Drawing.Point(100, 242)
        Me.cboTransIntk.Name = "cboTransIntk"
        Me.cboTransIntk.Size = New System.Drawing.Size(129, 21)
        Me.cboTransIntk.TabIndex = 11
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(39, 223)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(35, 13)
        Me.Label34.TabIndex = 10
        Me.Label34.Text = "Class:"
        '
        'cboTransClass
        '
        Me.cboTransClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTransClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTransClass.FormattingEnabled = True
        Me.cboTransClass.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboTransClass.Location = New System.Drawing.Point(101, 214)
        Me.cboTransClass.Name = "cboTransClass"
        Me.cboTransClass.Size = New System.Drawing.Size(129, 21)
        Me.cboTransClass.TabIndex = 9
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(38, 193)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(46, 13)
        Me.Label35.TabIndex = 8
        Me.Label35.Text = "Section:"
        '
        'cboTransReg
        '
        Me.cboTransReg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTransReg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTransReg.FormattingEnabled = True
        Me.cboTransReg.Items.AddRange(New Object() {"IT", "Business School"})
        Me.cboTransReg.Location = New System.Drawing.Point(101, 184)
        Me.cboTransReg.Name = "cboTransReg"
        Me.cboTransReg.Size = New System.Drawing.Size(129, 21)
        Me.cboTransReg.TabIndex = 7
        '
        'chkAllYears
        '
        Me.chkAllYears.AutoSize = True
        Me.chkAllYears.Location = New System.Drawing.Point(10, 279)
        Me.chkAllYears.Name = "chkAllYears"
        Me.chkAllYears.Size = New System.Drawing.Size(82, 17)
        Me.chkAllYears.TabIndex = 6
        Me.chkAllYears.Text = "All Students"
        Me.chkAllYears.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Semester"
        '
        'cbTransSem
        '
        Me.cbTransSem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTransSem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTransSem.Enabled = False
        Me.cbTransSem.FormattingEnabled = True
        Me.cbTransSem.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbTransSem.Location = New System.Drawing.Point(101, 156)
        Me.cbTransSem.Name = "cbTransSem"
        Me.cbTransSem.Size = New System.Drawing.Size(121, 21)
        Me.cbTransSem.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Year"
        '
        'cbTransYear
        '
        Me.cbTransYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTransYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTransYear.FormattingEnabled = True
        Me.cbTransYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbTransYear.Location = New System.Drawing.Point(100, 125)
        Me.cbTransYear.Name = "cbTransYear"
        Me.cbTransYear.Size = New System.Drawing.Size(121, 21)
        Me.cbTransYear.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Program:"
        '
        'cbTransProg
        '
        Me.cbTransProg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTransProg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTransProg.DisplayMember = "Forms"
        Me.cbTransProg.FormattingEnabled = True
        Me.cbTransProg.Location = New System.Drawing.Point(99, 91)
        Me.cbTransProg.Name = "cbTransProg"
        Me.cbTransProg.Size = New System.Drawing.Size(270, 21)
        Me.cbTransProg.TabIndex = 0
        Me.cbTransProg.ValueMember = "Forms"
        '
        'gbStudSub
        '
        Me.gbStudSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbStudSub.Controls.Add(Me.Label144)
        Me.gbStudSub.Controls.Add(Me.cboStudSubSess)
        Me.gbStudSub.Controls.Add(Me.lbStudSubSearch)
        Me.gbStudSub.Controls.Add(Me.Label66)
        Me.gbStudSub.Controls.Add(Me.cboStudSubProg)
        Me.gbStudSub.Controls.Add(Me.rbStubSubPerSem)
        Me.gbStudSub.Controls.Add(Me.rbStudSubPerClass)
        Me.gbStudSub.Controls.Add(Me.rbStudsubAll)
        Me.gbStudSub.Controls.Add(Me.Label67)
        Me.gbStudSub.Controls.Add(Me.cboStudSubCls)
        Me.gbStudSub.Controls.Add(Me.Label68)
        Me.gbStudSub.Controls.Add(Me.cboStudSubSem)
        Me.gbStudSub.Controls.Add(Me.Label69)
        Me.gbStudSub.Controls.Add(Me.cboStudSubLvl)
        Me.gbStudSub.Controls.Add(Me.Label70)
        Me.gbStudSub.Controls.Add(Me.cbostudsubStudid)
        Me.gbStudSub.Location = New System.Drawing.Point(402, 54)
        Me.gbStudSub.Name = "gbStudSub"
        Me.gbStudSub.Size = New System.Drawing.Size(68, 63)
        Me.gbStudSub.TabIndex = 16
        Me.gbStudSub.TabStop = False
        Me.gbStudSub.Text = "StudentSubjects"
        Me.gbStudSub.Visible = False
        '
        'Label144
        '
        Me.Label144.AutoSize = True
        Me.Label144.Location = New System.Drawing.Point(61, 137)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(50, 13)
        Me.Label144.TabIndex = 16
        Me.Label144.Text = "Session :"
        '
        'cboStudSubSess
        '
        Me.cboStudSubSess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudSubSess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudSubSess.DisplayMember = "Session"
        Me.cboStudSubSess.FormattingEnabled = True
        Me.cboStudSubSess.Location = New System.Drawing.Point(120, 130)
        Me.cboStudSubSess.Name = "cboStudSubSess"
        Me.cboStudSubSess.Size = New System.Drawing.Size(80, 21)
        Me.cboStudSubSess.TabIndex = 15
        Me.cboStudSubSess.ValueMember = "Session"
        '
        'lbStudSubSearch
        '
        Me.lbStudSubSearch.BackColor = System.Drawing.SystemColors.Info
        Me.lbStudSubSearch.FormattingEnabled = True
        Me.lbStudSubSearch.Location = New System.Drawing.Point(121, 39)
        Me.lbStudSubSearch.Name = "lbStudSubSearch"
        Me.lbStudSubSearch.Size = New System.Drawing.Size(204, 82)
        Me.lbStudSubSearch.TabIndex = 15
        Me.lbStudSubSearch.Visible = False
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(59, 177)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(49, 13)
        Me.Label66.TabIndex = 14
        Me.Label66.Text = "Program:"
        '
        'cboStudSubProg
        '
        Me.cboStudSubProg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudSubProg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudSubProg.DisplayMember = "Forms"
        Me.cboStudSubProg.FormattingEnabled = True
        Me.cboStudSubProg.Location = New System.Drawing.Point(121, 166)
        Me.cboStudSubProg.Name = "cboStudSubProg"
        Me.cboStudSubProg.Size = New System.Drawing.Size(206, 21)
        Me.cboStudSubProg.TabIndex = 13
        Me.cboStudSubProg.ValueMember = "Forms"
        '
        'rbStubSubPerSem
        '
        Me.rbStubSubPerSem.AutoSize = True
        Me.rbStubSubPerSem.Location = New System.Drawing.Point(213, 205)
        Me.rbStubSubPerSem.Name = "rbStubSubPerSem"
        Me.rbStubSubPerSem.Size = New System.Drawing.Size(107, 17)
        Me.rbStubSubPerSem.TabIndex = 12
        Me.rbStubSubPerSem.TabStop = True
        Me.rbStubSubPerSem.Text = "SpecificSemester"
        Me.rbStubSubPerSem.UseVisualStyleBackColor = True
        '
        'rbStudSubPerClass
        '
        Me.rbStudSubPerClass.AutoSize = True
        Me.rbStudSubPerClass.Location = New System.Drawing.Point(141, 205)
        Me.rbStudSubPerClass.Name = "rbStudSubPerClass"
        Me.rbStudSubPerClass.Size = New System.Drawing.Size(66, 17)
        Me.rbStudSubPerClass.TabIndex = 11
        Me.rbStudSubPerClass.TabStop = True
        Me.rbStudSubPerClass.Text = "PerClass"
        Me.rbStudSubPerClass.UseVisualStyleBackColor = True
        '
        'rbStudsubAll
        '
        Me.rbStudsubAll.AutoSize = True
        Me.rbStudsubAll.Location = New System.Drawing.Point(14, 209)
        Me.rbStudsubAll.Name = "rbStudsubAll"
        Me.rbStudsubAll.Size = New System.Drawing.Size(116, 17)
        Me.rbStudsubAll.TabIndex = 10
        Me.rbStudsubAll.TabStop = True
        Me.rbStudsubAll.Text = "All Academic Years"
        Me.rbStudsubAll.UseVisualStyleBackColor = True
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(62, 47)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(32, 13)
        Me.Label67.TabIndex = 9
        Me.Label67.Text = "Year:"
        '
        'cboStudSubCls
        '
        Me.cboStudSubCls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudSubCls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudSubCls.FormattingEnabled = True
        Me.cboStudSubCls.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboStudSubCls.Location = New System.Drawing.Point(121, 43)
        Me.cboStudSubCls.Name = "cboStudSubCls"
        Me.cboStudSubCls.Size = New System.Drawing.Size(80, 21)
        Me.cboStudSubCls.TabIndex = 8
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(60, 103)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(31, 13)
        Me.Label68.TabIndex = 5
        Me.Label68.Text = "Term"
        '
        'cboStudSubSem
        '
        Me.cboStudSubSem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudSubSem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudSubSem.FormattingEnabled = True
        Me.cboStudSubSem.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboStudSubSem.Location = New System.Drawing.Point(120, 96)
        Me.cboStudSubSem.Name = "cboStudSubSem"
        Me.cboStudSubSem.Size = New System.Drawing.Size(80, 21)
        Me.cboStudSubSem.TabIndex = 4
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(64, 79)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(36, 13)
        Me.Label69.TabIndex = 3
        Me.Label69.Text = "Form: "
        '
        'cboStudSubLvl
        '
        Me.cboStudSubLvl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudSubLvl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudSubLvl.FormattingEnabled = True
        Me.cboStudSubLvl.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboStudSubLvl.Location = New System.Drawing.Point(120, 69)
        Me.cboStudSubLvl.Name = "cboStudSubLvl"
        Me.cboStudSubLvl.Size = New System.Drawing.Size(80, 21)
        Me.cboStudSubLvl.TabIndex = 2
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(57, 22)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(58, 13)
        Me.Label70.TabIndex = 1
        Me.Label70.Text = "StudentID:"
        '
        'cbostudsubStudid
        '
        Me.cbostudsubStudid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbostudsubStudid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbostudsubStudid.DisplayMember = "StudentID"
        Me.cbostudsubStudid.FormattingEnabled = True
        Me.cbostudsubStudid.Location = New System.Drawing.Point(123, 17)
        Me.cbostudsubStudid.Name = "cbostudsubStudid"
        Me.cbostudsubStudid.Size = New System.Drawing.Size(199, 21)
        Me.cbostudsubStudid.TabIndex = 0
        Me.cbostudsubStudid.ValueMember = "StudentID"
        '
        'gbLeftStudents
        '
        Me.gbLeftStudents.Controls.Add(Me.Label151)
        Me.gbLeftStudents.Controls.Add(Me.cboReasonLeft)
        Me.gbLeftStudents.Controls.Add(Me.cboTermLeftTo)
        Me.gbLeftStudents.Controls.Add(Me.Label149)
        Me.gbLeftStudents.Controls.Add(Me.Label145)
        Me.gbLeftStudents.Controls.Add(Me.cboTermLeftFrom)
        Me.gbLeftStudents.Controls.Add(Me.Label62)
        Me.gbLeftStudents.Controls.Add(Me.cboYearLeft)
        Me.gbLeftStudents.Location = New System.Drawing.Point(59, 169)
        Me.gbLeftStudents.Name = "gbLeftStudents"
        Me.gbLeftStudents.Size = New System.Drawing.Size(12, 12)
        Me.gbLeftStudents.TabIndex = 15
        Me.gbLeftStudents.TabStop = False
        Me.gbLeftStudents.Text = "LeftStudents"
        Me.gbLeftStudents.Visible = False
        '
        'Label151
        '
        Me.Label151.AutoSize = True
        Me.Label151.Location = New System.Drawing.Point(38, 95)
        Me.Label151.Name = "Label151"
        Me.Label151.Size = New System.Drawing.Size(47, 13)
        Me.Label151.TabIndex = 35
        Me.Label151.Text = "Reason:"
        '
        'cboReasonLeft
        '
        Me.cboReasonLeft.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboReasonLeft.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReasonLeft.FormattingEnabled = True
        Me.cboReasonLeft.Items.AddRange(New Object() {"OutGoing", "Transferred", "Deceased"})
        Me.cboReasonLeft.Location = New System.Drawing.Point(97, 89)
        Me.cboReasonLeft.Name = "cboReasonLeft"
        Me.cboReasonLeft.Size = New System.Drawing.Size(131, 21)
        Me.cboReasonLeft.TabIndex = 34
        '
        'cboTermLeftTo
        '
        Me.cboTermLeftTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTermLeftTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTermLeftTo.FormattingEnabled = True
        Me.cboTermLeftTo.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboTermLeftTo.Location = New System.Drawing.Point(210, 51)
        Me.cboTermLeftTo.Name = "cboTermLeftTo"
        Me.cboTermLeftTo.Size = New System.Drawing.Size(60, 21)
        Me.cboTermLeftTo.TabIndex = 33
        '
        'Label149
        '
        Me.Label149.AutoSize = True
        Me.Label149.Location = New System.Drawing.Point(168, 57)
        Me.Label149.Name = "Label149"
        Me.Label149.Size = New System.Drawing.Size(26, 13)
        Me.Label149.TabIndex = 32
        Me.Label149.Text = " To "
        '
        'Label145
        '
        Me.Label145.AutoSize = True
        Me.Label145.Location = New System.Drawing.Point(38, 58)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(34, 13)
        Me.Label145.TabIndex = 28
        Me.Label145.Text = "Term:"
        '
        'cboTermLeftFrom
        '
        Me.cboTermLeftFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTermLeftFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTermLeftFrom.FormattingEnabled = True
        Me.cboTermLeftFrom.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboTermLeftFrom.Location = New System.Drawing.Point(97, 54)
        Me.cboTermLeftFrom.Name = "cboTermLeftFrom"
        Me.cboTermLeftFrom.Size = New System.Drawing.Size(60, 21)
        Me.cboTermLeftFrom.TabIndex = 27
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(38, 29)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(32, 13)
        Me.Label62.TabIndex = 26
        Me.Label62.Text = "Year:"
        '
        'cboYearLeft
        '
        Me.cboYearLeft.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYearLeft.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYearLeft.FormattingEnabled = True
        Me.cboYearLeft.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboYearLeft.Location = New System.Drawing.Point(97, 22)
        Me.cboYearLeft.Name = "cboYearLeft"
        Me.cboYearLeft.Size = New System.Drawing.Size(83, 21)
        Me.cboYearLeft.TabIndex = 23
        '
        'gbPersDetails
        '
        Me.gbPersDetails.Controls.Add(Me.Label20)
        Me.gbPersDetails.Controls.Add(Me.cboPersDetStatus)
        Me.gbPersDetails.Location = New System.Drawing.Point(208, 69)
        Me.gbPersDetails.Name = "gbPersDetails"
        Me.gbPersDetails.Size = New System.Drawing.Size(59, 23)
        Me.gbPersDetails.TabIndex = 8
        Me.gbPersDetails.TabStop = False
        Me.gbPersDetails.Text = "StudentDetails"
        Me.gbPersDetails.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(57, 52)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Status:"
        '
        'cboPersDetStatus
        '
        Me.cboPersDetStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPersDetStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPersDetStatus.DisplayMember = "SubjectID"
        Me.cboPersDetStatus.FormattingEnabled = True
        Me.cboPersDetStatus.Items.AddRange(New Object() {"Available", "Left"})
        Me.cboPersDetStatus.Location = New System.Drawing.Point(133, 44)
        Me.cboPersDetStatus.Name = "cboPersDetStatus"
        Me.cboPersDetStatus.Size = New System.Drawing.Size(153, 21)
        Me.cboPersDetStatus.TabIndex = 0
        Me.cboPersDetStatus.ValueMember = "SubjectID"
        '
        'gbStudClasses
        '
        Me.gbStudClasses.Controls.Add(Me.gbClassAgeRange)
        Me.gbStudClasses.Controls.Add(Me.chkClssAge)
        Me.gbStudClasses.Controls.Add(Me.Label6)
        Me.gbStudClasses.Controls.Add(Me.chkperiodAnalysis1)
        Me.gbStudClasses.Controls.Add(Me.cboStudClassCls)
        Me.gbStudClasses.Controls.Add(Me.pnlclassstudent)
        Me.gbStudClasses.Controls.Add(Me.Label15)
        Me.gbStudClasses.Controls.Add(Me.cboClassStudsSex)
        Me.gbStudClasses.Controls.Add(Me.cboStudClassSession)
        Me.gbStudClasses.Controls.Add(Me.Label12)
        Me.gbStudClasses.Controls.Add(Me.cboStudClasYr)
        Me.gbStudClasses.Controls.Add(Me.Label10)
        Me.gbStudClasses.Controls.Add(Me.cboStudClasProgram)
        Me.gbStudClasses.Location = New System.Drawing.Point(88, 177)
        Me.gbStudClasses.Name = "gbStudClasses"
        Me.gbStudClasses.Size = New System.Drawing.Size(73, 31)
        Me.gbStudClasses.TabIndex = 4
        Me.gbStudClasses.TabStop = False
        Me.gbStudClasses.Text = "Class Students"
        Me.gbStudClasses.Visible = False
        '
        'gbClassAgeRange
        '
        Me.gbClassAgeRange.Controls.Add(Me.txtStudClassAgeFrom)
        Me.gbClassAgeRange.Controls.Add(Me.Label13)
        Me.gbClassAgeRange.Controls.Add(Me.txtStudClassAgeto)
        Me.gbClassAgeRange.Enabled = False
        Me.gbClassAgeRange.Location = New System.Drawing.Point(76, 123)
        Me.gbClassAgeRange.Name = "gbClassAgeRange"
        Me.gbClassAgeRange.Size = New System.Drawing.Size(247, 44)
        Me.gbClassAgeRange.TabIndex = 24
        Me.gbClassAgeRange.TabStop = False
        Me.gbClassAgeRange.Text = "Age Range in Years"
        '
        'txtStudClassAgeFrom
        '
        Me.txtStudClassAgeFrom.Location = New System.Drawing.Point(7, 18)
        Me.txtStudClassAgeFrom.Name = "txtStudClassAgeFrom"
        Me.txtStudClassAgeFrom.Size = New System.Drawing.Size(64, 20)
        Me.txtStudClassAgeFrom.TabIndex = 19
        Me.txtStudClassAgeFrom.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(78, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "To:"
        '
        'txtStudClassAgeto
        '
        Me.txtStudClassAgeto.Location = New System.Drawing.Point(107, 18)
        Me.txtStudClassAgeto.Name = "txtStudClassAgeto"
        Me.txtStudClassAgeto.Size = New System.Drawing.Size(64, 20)
        Me.txtStudClassAgeto.TabIndex = 21
        Me.txtStudClassAgeto.Text = "100"
        '
        'chkClssAge
        '
        Me.chkClssAge.AccessibleDescription = ""
        Me.chkClssAge.AutoSize = True
        Me.chkClssAge.Location = New System.Drawing.Point(13, 139)
        Me.chkClssAge.Name = "chkClssAge"
        Me.chkClssAge.Size = New System.Drawing.Size(45, 17)
        Me.chkClssAge.TabIndex = 23
        Me.chkClssAge.Text = "Age"
        Me.chkClssAge.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Class:"
        '
        'chkperiodAnalysis1
        '
        Me.chkperiodAnalysis1.AccessibleDescription = ""
        Me.chkperiodAnalysis1.AutoSize = True
        Me.chkperiodAnalysis1.Location = New System.Drawing.Point(13, 178)
        Me.chkperiodAnalysis1.Name = "chkperiodAnalysis1"
        Me.chkperiodAnalysis1.Size = New System.Drawing.Size(56, 17)
        Me.chkperiodAnalysis1.TabIndex = 12
        Me.chkperiodAnalysis1.Text = "Period"
        Me.chkperiodAnalysis1.UseVisualStyleBackColor = True
        '
        'cboStudClassCls
        '
        Me.cboStudClassCls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudClassCls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudClassCls.FormattingEnabled = True
        Me.cboStudClassCls.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboStudClassCls.Location = New System.Drawing.Point(76, 74)
        Me.cboStudClassCls.Name = "cboStudClassCls"
        Me.cboStudClassCls.Size = New System.Drawing.Size(123, 21)
        Me.cboStudClassCls.TabIndex = 16
        '
        'pnlclassstudent
        '
        Me.pnlclassstudent.Controls.Add(Me.Label129)
        Me.pnlclassstudent.Controls.Add(Me.dtpclassstudentdateTo)
        Me.pnlclassstudent.Controls.Add(Me.Label130)
        Me.pnlclassstudent.Controls.Add(Me.dtpclassstudentdatefrom)
        Me.pnlclassstudent.Enabled = False
        Me.pnlclassstudent.Location = New System.Drawing.Point(76, 169)
        Me.pnlclassstudent.Name = "pnlclassstudent"
        Me.pnlclassstudent.Size = New System.Drawing.Size(360, 39)
        Me.pnlclassstudent.TabIndex = 15
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Location = New System.Drawing.Point(176, 16)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(23, 13)
        Me.Label129.TabIndex = 11
        Me.Label129.Text = "To:"
        '
        'dtpclassstudentdateTo
        '
        Me.dtpclassstudentdateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpclassstudentdateTo.Location = New System.Drawing.Point(199, 12)
        Me.dtpclassstudentdateTo.Name = "dtpclassstudentdateTo"
        Me.dtpclassstudentdateTo.Size = New System.Drawing.Size(151, 20)
        Me.dtpclassstudentdateTo.TabIndex = 9
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Location = New System.Drawing.Point(4, 16)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(33, 13)
        Me.Label130.TabIndex = 10
        Me.Label130.Text = "From:"
        '
        'dtpclassstudentdatefrom
        '
        Me.dtpclassstudentdatefrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpclassstudentdatefrom.Location = New System.Drawing.Point(40, 12)
        Me.dtpclassstudentdatefrom.Name = "dtpclassstudentdatefrom"
        Me.dtpclassstudentdatefrom.Size = New System.Drawing.Size(130, 20)
        Me.dtpclassstudentdatefrom.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Gender:"
        '
        'cboClassStudsSex
        '
        Me.cboClassStudsSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClassStudsSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClassStudsSex.FormattingEnabled = True
        Me.cboClassStudsSex.Items.AddRange(New Object() {"All", "F", "M"})
        Me.cboClassStudsSex.Location = New System.Drawing.Point(76, 98)
        Me.cboClassStudsSex.Name = "cboClassStudsSex"
        Me.cboClassStudsSex.Size = New System.Drawing.Size(64, 21)
        Me.cboClassStudsSex.TabIndex = 12
        '
        'cboStudClassSession
        '
        Me.cboStudClassSession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudClassSession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudClassSession.DisplayMember = "Session"
        Me.cboStudClassSession.FormattingEnabled = True
        Me.cboStudClassSession.Location = New System.Drawing.Point(142, 51)
        Me.cboStudClassSession.Name = "cboStudClassSession"
        Me.cboStudClassSession.Size = New System.Drawing.Size(55, 21)
        Me.cboStudClassSession.TabIndex = 10
        Me.cboStudClassSession.ValueMember = "Session"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Level:"
        '
        'cboStudClasYr
        '
        Me.cboStudClasYr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudClasYr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudClasYr.FormattingEnabled = True
        Me.cboStudClasYr.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboStudClasYr.Location = New System.Drawing.Point(76, 51)
        Me.cboStudClasYr.Name = "cboStudClasYr"
        Me.cboStudClasYr.Size = New System.Drawing.Size(55, 21)
        Me.cboStudClasYr.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Program"
        '
        'cboStudClasProgram
        '
        Me.cboStudClasProgram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudClasProgram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudClasProgram.DisplayMember = "Forms"
        Me.cboStudClasProgram.FormattingEnabled = True
        Me.cboStudClasProgram.Location = New System.Drawing.Point(76, 25)
        Me.cboStudClasProgram.Name = "cboStudClasProgram"
        Me.cboStudClasProgram.Size = New System.Drawing.Size(121, 21)
        Me.cboStudClasProgram.TabIndex = 0
        Me.cboStudClasProgram.ValueMember = "Forms"
        '
        'gbPaymentsPerDate
        '
        Me.gbPaymentsPerDate.Controls.Add(Me.Label50)
        Me.gbPaymentsPerDate.Controls.Add(Me.cboFeesPayCurrency)
        Me.gbPaymentsPerDate.Controls.Add(Me.Label142)
        Me.gbPaymentsPerDate.Controls.Add(Me.Label143)
        Me.gbPaymentsPerDate.Controls.Add(Me.dtpPostDateTo)
        Me.gbPaymentsPerDate.Controls.Add(Me.dtpPostDateFrom)
        Me.gbPaymentsPerDate.Controls.Add(Me.GroupBox1)
        Me.gbPaymentsPerDate.Controls.Add(Me.Panel1)
        Me.gbPaymentsPerDate.Controls.Add(Me.Label60)
        Me.gbPaymentsPerDate.Controls.Add(Me.cbofeesPayPto)
        Me.gbPaymentsPerDate.Controls.Add(Me.Label61)
        Me.gbPaymentsPerDate.Controls.Add(Me.cboFeesPayPfrpm)
        Me.gbPaymentsPerDate.Controls.Add(Me.Label59)
        Me.gbPaymentsPerDate.Controls.Add(Me.Label58)
        Me.gbPaymentsPerDate.Controls.Add(Me.dtpPayDateTo)
        Me.gbPaymentsPerDate.Controls.Add(Me.dtpPayDateFrom)
        Me.gbPaymentsPerDate.Location = New System.Drawing.Point(23, 183)
        Me.gbPaymentsPerDate.Name = "gbPaymentsPerDate"
        Me.gbPaymentsPerDate.Size = New System.Drawing.Size(48, 23)
        Me.gbPaymentsPerDate.TabIndex = 14
        Me.gbPaymentsPerDate.TabStop = False
        Me.gbPaymentsPerDate.Text = "FeesPayments"
        Me.gbPaymentsPerDate.Visible = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(11, 95)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(52, 13)
        Me.Label50.TabIndex = 40
        Me.Label50.Text = "Currency:"
        '
        'cboFeesPayCurrency
        '
        Me.cboFeesPayCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFeesPayCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFeesPayCurrency.DisplayMember = "Usr_User"
        Me.cboFeesPayCurrency.FormattingEnabled = True
        Me.cboFeesPayCurrency.Location = New System.Drawing.Point(104, 88)
        Me.cboFeesPayCurrency.Name = "cboFeesPayCurrency"
        Me.cboFeesPayCurrency.Size = New System.Drawing.Size(119, 21)
        Me.cboFeesPayCurrency.TabIndex = 39
        Me.cboFeesPayCurrency.ValueMember = "Usr_User"
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Location = New System.Drawing.Point(280, 44)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(67, 13)
        Me.Label142.TabIndex = 38
        Me.Label142.Text = "PostDateTo:"
        '
        'Label143
        '
        Me.Label143.AutoSize = True
        Me.Label143.Location = New System.Drawing.Point(11, 49)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(77, 13)
        Me.Label143.TabIndex = 37
        Me.Label143.Text = "PostDateFrom:"
        '
        'dtpPostDateTo
        '
        Me.dtpPostDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPostDateTo.Location = New System.Drawing.Point(373, 44)
        Me.dtpPostDateTo.Name = "dtpPostDateTo"
        Me.dtpPostDateTo.Size = New System.Drawing.Size(164, 20)
        Me.dtpPostDateTo.TabIndex = 36
        '
        'dtpPostDateFrom
        '
        Me.dtpPostDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPostDateFrom.Location = New System.Drawing.Point(104, 44)
        Me.dtpPostDateFrom.Name = "dtpPostDateFrom"
        Me.dtpPostDateFrom.Size = New System.Drawing.Size(164, 20)
        Me.dtpPostDateFrom.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cboPayPerDaterUser)
        Me.GroupBox1.Controls.Add(Me.cboPayPerDateMode)
        Me.GroupBox1.Controls.Add(Me.cboPayperDateType)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 91)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SelectOptions"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(8, 61)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(78, 13)
        Me.Label48.TabIndex = 37
        Me.Label48.Text = "PaymentType :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(8, 38)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(58, 13)
        Me.Label37.TabIndex = 36
        Me.Label37.Text = "Cartegory :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "CapturedBy:"
        '
        'cboPayPerDaterUser
        '
        Me.cboPayPerDaterUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPayPerDaterUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPayPerDaterUser.DisplayMember = "Usr_User"
        Me.cboPayPerDaterUser.FormattingEnabled = True
        Me.cboPayPerDaterUser.Location = New System.Drawing.Point(90, 12)
        Me.cboPayPerDaterUser.Name = "cboPayPerDaterUser"
        Me.cboPayPerDaterUser.Size = New System.Drawing.Size(121, 21)
        Me.cboPayPerDaterUser.TabIndex = 34
        Me.cboPayPerDaterUser.ValueMember = "Usr_User"
        '
        'cboPayPerDateMode
        '
        Me.cboPayPerDateMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPayPerDateMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPayPerDateMode.DisplayMember = "CashType"
        Me.cboPayPerDateMode.FormattingEnabled = True
        Me.cboPayPerDateMode.Location = New System.Drawing.Point(90, 58)
        Me.cboPayPerDateMode.Name = "cboPayPerDateMode"
        Me.cboPayPerDateMode.Size = New System.Drawing.Size(121, 21)
        Me.cboPayPerDateMode.TabIndex = 32
        Me.cboPayPerDateMode.ValueMember = "CashType"
        '
        'cboPayperDateType
        '
        Me.cboPayperDateType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPayperDateType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPayperDateType.DisplayMember = "Payment"
        Me.cboPayperDateType.FormattingEnabled = True
        Me.cboPayperDateType.Location = New System.Drawing.Point(90, 35)
        Me.cboPayperDateType.Name = "cboPayperDateType"
        Me.cboPayperDateType.Size = New System.Drawing.Size(121, 21)
        Me.cboPayperDateType.TabIndex = 30
        Me.cboPayperDateType.ValueMember = "Payment"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbFeesPayWithStudents)
        Me.Panel1.Controls.Add(Me.rbFeesPaymentsAnalysis)
        Me.Panel1.Location = New System.Drawing.Point(285, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 27)
        Me.Panel1.TabIndex = 28
        '
        'rbFeesPayWithStudents
        '
        Me.rbFeesPayWithStudents.AutoSize = True
        Me.rbFeesPayWithStudents.Checked = True
        Me.rbFeesPayWithStudents.Location = New System.Drawing.Point(6, 4)
        Me.rbFeesPayWithStudents.Name = "rbFeesPayWithStudents"
        Me.rbFeesPayWithStudents.Size = New System.Drawing.Size(64, 17)
        Me.rbFeesPayWithStudents.TabIndex = 20
        Me.rbFeesPayWithStudents.TabStop = True
        Me.rbFeesPayWithStudents.Text = "Detailed"
        Me.rbFeesPayWithStudents.UseVisualStyleBackColor = True
        '
        'rbFeesPaymentsAnalysis
        '
        Me.rbFeesPaymentsAnalysis.AutoSize = True
        Me.rbFeesPaymentsAnalysis.Location = New System.Drawing.Point(106, 4)
        Me.rbFeesPaymentsAnalysis.Name = "rbFeesPaymentsAnalysis"
        Me.rbFeesPaymentsAnalysis.Size = New System.Drawing.Size(99, 17)
        Me.rbFeesPaymentsAnalysis.TabIndex = 21
        Me.rbFeesPaymentsAnalysis.Text = "SectionAnalysis"
        Me.rbFeesPaymentsAnalysis.UseVisualStyleBackColor = True
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(279, 70)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(59, 13)
        Me.Label60.TabIndex = 26
        Me.Label60.Text = "Period To :"
        '
        'cbofeesPayPto
        '
        Me.cbofeesPayPto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbofeesPayPto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbofeesPayPto.DisplayMember = "Period"
        Me.cbofeesPayPto.FormattingEnabled = True
        Me.cbofeesPayPto.Location = New System.Drawing.Point(373, 65)
        Me.cbofeesPayPto.Name = "cbofeesPayPto"
        Me.cbofeesPayPto.Size = New System.Drawing.Size(119, 21)
        Me.cbofeesPayPto.TabIndex = 25
        Me.cbofeesPayPto.ValueMember = "Period"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(11, 73)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(69, 13)
        Me.Label61.TabIndex = 24
        Me.Label61.Text = "Period From :"
        '
        'cboFeesPayPfrpm
        '
        Me.cboFeesPayPfrpm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFeesPayPfrpm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFeesPayPfrpm.DisplayMember = "Period"
        Me.cboFeesPayPfrpm.FormattingEnabled = True
        Me.cboFeesPayPfrpm.Location = New System.Drawing.Point(104, 65)
        Me.cboFeesPayPfrpm.Name = "cboFeesPayPfrpm"
        Me.cboFeesPayPfrpm.Size = New System.Drawing.Size(119, 21)
        Me.cboFeesPayPfrpm.TabIndex = 23
        Me.cboFeesPayPfrpm.ValueMember = "Period"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(280, 27)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(83, 13)
        Me.Label59.TabIndex = 19
        Me.Label59.Text = "ReceiptDateTo:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(11, 28)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(84, 13)
        Me.Label58.TabIndex = 18
        Me.Label58.Text = "ReceiDateFrom:"
        '
        'dtpPayDateTo
        '
        Me.dtpPayDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPayDateTo.Location = New System.Drawing.Point(373, 21)
        Me.dtpPayDateTo.Name = "dtpPayDateTo"
        Me.dtpPayDateTo.Size = New System.Drawing.Size(164, 20)
        Me.dtpPayDateTo.TabIndex = 17
        '
        'dtpPayDateFrom
        '
        Me.dtpPayDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPayDateFrom.Location = New System.Drawing.Point(104, 21)
        Me.dtpPayDateFrom.Name = "dtpPayDateFrom"
        Me.dtpPayDateFrom.Size = New System.Drawing.Size(164, 20)
        Me.dtpPayDateFrom.TabIndex = 16
        '
        'gbAccounts
        '
        Me.gbAccounts.Controls.Add(Me.Label11)
        Me.gbAccounts.Controls.Add(Me.cboBBFCutOff)
        Me.gbAccounts.Controls.Add(Me.pnlTranstype)
        Me.gbAccounts.Controls.Add(Me.chkDebtorsOnly)
        Me.gbAccounts.Controls.Add(Me.Label7)
        Me.gbAccounts.Controls.Add(Me.cboAccClass)
        Me.gbAccounts.Controls.Add(Me.txtAccStud)
        Me.gbAccounts.Controls.Add(Me.Label101)
        Me.gbAccounts.Controls.Add(Me.rtxtAccAddinfo)
        Me.gbAccounts.Controls.Add(Me.rbClassStatement)
        Me.gbAccounts.Controls.Add(Me.Label132)
        Me.gbAccounts.Controls.Add(Me.cboAccPayType)
        Me.gbAccounts.Controls.Add(Me.rbStudStatement)
        Me.gbAccounts.Controls.Add(Me.lbAccStud)
        Me.gbAccounts.Controls.Add(Me.Label77)
        Me.gbAccounts.Controls.Add(Me.Label74)
        Me.gbAccounts.Controls.Add(Me.cboAccSection)
        Me.gbAccounts.Controls.Add(Me.rbAccDebtors)
        Me.gbAccounts.Controls.Add(Me.cboAccSession)
        Me.gbAccounts.Controls.Add(Me.Label55)
        Me.gbAccounts.Controls.Add(Me.cboAccPerTo)
        Me.gbAccounts.Controls.Add(Me.Label54)
        Me.gbAccounts.Controls.Add(Me.cboAccPerFrm)
        Me.gbAccounts.Controls.Add(Me.Label52)
        Me.gbAccounts.Controls.Add(Me.cboAccLvl)
        Me.gbAccounts.Controls.Add(Me.rbAccPerForm)
        Me.gbAccounts.Location = New System.Drawing.Point(207, 164)
        Me.gbAccounts.Name = "gbAccounts"
        Me.gbAccounts.Size = New System.Drawing.Size(707, 247)
        Me.gbAccounts.TabIndex = 13
        Me.gbAccounts.TabStop = False
        Me.gbAccounts.Text = "Accounting"
        Me.gbAccounts.Visible = False
        '
        'chkDebtorsOnly
        '
        Me.chkDebtorsOnly.AutoSize = True
        Me.chkDebtorsOnly.Location = New System.Drawing.Point(92, 191)
        Me.chkDebtorsOnly.Name = "chkDebtorsOnly"
        Me.chkDebtorsOnly.Size = New System.Drawing.Size(87, 17)
        Me.chkDebtorsOnly.TabIndex = 55
        Me.chkDebtorsOnly.Text = "Debtors Only"
        Me.chkDebtorsOnly.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Class:"
        '
        'cboAccClass
        '
        Me.cboAccClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccClass.DisplayMember = "Period"
        Me.cboAccClass.FormattingEnabled = True
        Me.cboAccClass.Location = New System.Drawing.Point(91, 87)
        Me.cboAccClass.Name = "cboAccClass"
        Me.cboAccClass.Size = New System.Drawing.Size(119, 21)
        Me.cboAccClass.TabIndex = 53
        Me.cboAccClass.ValueMember = "Period"
        '
        'txtAccStud
        '
        Me.txtAccStud.Location = New System.Drawing.Point(91, 15)
        Me.txtAccStud.Name = "txtAccStud"
        Me.txtAccStud.Size = New System.Drawing.Size(121, 20)
        Me.txtAccStud.TabIndex = 52
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Location = New System.Drawing.Point(430, 14)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(110, 13)
        Me.Label101.TabIndex = 50
        Me.Label101.Text = "Statement Information"
        '
        'rtxtAccAddinfo
        '
        Me.rtxtAccAddinfo.Location = New System.Drawing.Point(392, 34)
        Me.rtxtAccAddinfo.Name = "rtxtAccAddinfo"
        Me.rtxtAccAddinfo.Size = New System.Drawing.Size(290, 96)
        Me.rtxtAccAddinfo.TabIndex = 49
        Me.rtxtAccAddinfo.Text = ""
        '
        'rbClassStatement
        '
        Me.rbClassStatement.AutoSize = True
        Me.rbClassStatement.Location = New System.Drawing.Point(342, 213)
        Me.rbClassStatement.Name = "rbClassStatement"
        Me.rbClassStatement.Size = New System.Drawing.Size(103, 17)
        Me.rbClassStatement.TabIndex = 39
        Me.rbClassStatement.TabStop = True
        Me.rbClassStatement.Text = "ClassStatements"
        Me.rbClassStatement.UseVisualStyleBackColor = True
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Location = New System.Drawing.Point(16, 215)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(34, 13)
        Me.Label132.TabIndex = 38
        Me.Label132.Text = "Type:"
        '
        'cboAccPayType
        '
        Me.cboAccPayType.DisplayMember = "Payment"
        Me.cboAccPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccPayType.FormattingEnabled = True
        Me.cboAccPayType.Location = New System.Drawing.Point(53, 212)
        Me.cboAccPayType.Name = "cboAccPayType"
        Me.cboAccPayType.Size = New System.Drawing.Size(72, 21)
        Me.cboAccPayType.TabIndex = 37
        Me.cboAccPayType.ValueMember = "Payment"
        '
        'rbStudStatement
        '
        Me.rbStudStatement.AutoSize = True
        Me.rbStudStatement.Location = New System.Drawing.Point(220, 213)
        Me.rbStudStatement.Name = "rbStudStatement"
        Me.rbStudStatement.Size = New System.Drawing.Size(110, 17)
        Me.rbStudStatement.TabIndex = 36
        Me.rbStudStatement.TabStop = True
        Me.rbStudStatement.Text = "StudentStatement"
        Me.rbStudStatement.UseVisualStyleBackColor = True
        '
        'lbAccStud
        '
        Me.lbAccStud.BackColor = System.Drawing.Color.LightYellow
        Me.lbAccStud.FormattingEnabled = True
        Me.lbAccStud.Location = New System.Drawing.Point(216, 19)
        Me.lbAccStud.Name = "lbAccStud"
        Me.lbAccStud.Size = New System.Drawing.Size(173, 108)
        Me.lbAccStud.TabIndex = 33
        Me.lbAccStud.Visible = False
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(16, 20)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(47, 13)
        Me.Label77.TabIndex = 31
        Me.Label77.Text = "Student:"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(16, 44)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(46, 13)
        Me.Label74.TabIndex = 29
        Me.Label74.Text = "Section:"
        '
        'cboAccSection
        '
        Me.cboAccSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccSection.DisplayMember = "SubjectID"
        Me.cboAccSection.FormattingEnabled = True
        Me.cboAccSection.Items.AddRange(New Object() {"Business School", "IT", "High School", "NonStudent"})
        Me.cboAccSection.Location = New System.Drawing.Point(91, 40)
        Me.cboAccSection.Name = "cboAccSection"
        Me.cboAccSection.Size = New System.Drawing.Size(119, 21)
        Me.cboAccSection.TabIndex = 28
        Me.cboAccSection.ValueMember = "SubjectID"
        '
        'rbAccDebtors
        '
        Me.rbAccDebtors.AutoSize = True
        Me.rbAccDebtors.Location = New System.Drawing.Point(458, 213)
        Me.rbAccDebtors.Name = "rbAccDebtors"
        Me.rbAccDebtors.Size = New System.Drawing.Size(99, 17)
        Me.rbAccDebtors.TabIndex = 27
        Me.rbAccDebtors.TabStop = True
        Me.rbAccDebtors.Text = "DebtorsByClass"
        Me.rbAccDebtors.UseVisualStyleBackColor = True
        '
        'cboAccSession
        '
        Me.cboAccSession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccSession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccSession.DisplayMember = "Session"
        Me.cboAccSession.FormattingEnabled = True
        Me.cboAccSession.Location = New System.Drawing.Point(145, 64)
        Me.cboAccSession.Name = "cboAccSession"
        Me.cboAccSession.Size = New System.Drawing.Size(65, 21)
        Me.cboAccSession.TabIndex = 25
        Me.cboAccSession.ValueMember = "Session"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(213, 139)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(26, 13)
        Me.Label55.TabIndex = 22
        Me.Label55.Text = "To :"
        '
        'cboAccPerTo
        '
        Me.cboAccPerTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccPerTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccPerTo.DisplayMember = "Period"
        Me.cboAccPerTo.FormattingEnabled = True
        Me.cboAccPerTo.Location = New System.Drawing.Point(248, 135)
        Me.cboAccPerTo.Name = "cboAccPerTo"
        Me.cboAccPerTo.Size = New System.Drawing.Size(119, 21)
        Me.cboAccPerTo.TabIndex = 21
        Me.cboAccPerTo.ValueMember = "Period"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(13, 142)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(69, 13)
        Me.Label54.TabIndex = 20
        Me.Label54.Text = "Period From :"
        '
        'cboAccPerFrm
        '
        Me.cboAccPerFrm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccPerFrm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccPerFrm.DisplayMember = "Period"
        Me.cboAccPerFrm.FormattingEnabled = True
        Me.cboAccPerFrm.Location = New System.Drawing.Point(90, 135)
        Me.cboAccPerFrm.Name = "cboAccPerFrm"
        Me.cboAccPerFrm.Size = New System.Drawing.Size(119, 21)
        Me.cboAccPerFrm.TabIndex = 19
        Me.cboAccPerFrm.ValueMember = "Period"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(16, 69)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(36, 13)
        Me.Label52.TabIndex = 16
        Me.Label52.Text = "Level:"
        '
        'cboAccLvl
        '
        Me.cboAccLvl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccLvl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccLvl.DisplayMember = "SubjectID"
        Me.cboAccLvl.FormattingEnabled = True
        Me.cboAccLvl.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboAccLvl.Location = New System.Drawing.Point(91, 64)
        Me.cboAccLvl.Name = "cboAccLvl"
        Me.cboAccLvl.Size = New System.Drawing.Size(49, 21)
        Me.cboAccLvl.TabIndex = 15
        Me.cboAccLvl.ValueMember = "SubjectID"
        '
        'rbAccPerForm
        '
        Me.rbAccPerForm.AutoSize = True
        Me.rbAccPerForm.Location = New System.Drawing.Point(133, 213)
        Me.rbAccPerForm.Name = "rbAccPerForm"
        Me.rbAccPerForm.Size = New System.Drawing.Size(84, 17)
        Me.rbAccPerForm.TabIndex = 5
        Me.rbAccPerForm.TabStop = True
        Me.rbAccPerForm.Text = "ClassPymnts"
        Me.rbAccPerForm.UseVisualStyleBackColor = True
        '
        'gbExamAttendance
        '
        Me.gbExamAttendance.Controls.Add(Me.Label44)
        Me.gbExamAttendance.Controls.Add(Me.cboExamAttExam)
        Me.gbExamAttendance.Controls.Add(Me.Label49)
        Me.gbExamAttendance.Controls.Add(Me.cboExamAttSub)
        Me.gbExamAttendance.Location = New System.Drawing.Point(520, 93)
        Me.gbExamAttendance.Name = "gbExamAttendance"
        Me.gbExamAttendance.Size = New System.Drawing.Size(148, 23)
        Me.gbExamAttendance.TabIndex = 12
        Me.gbExamAttendance.TabStop = False
        Me.gbExamAttendance.Text = "ExamAttendance"
        Me.gbExamAttendance.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(29, 63)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(36, 13)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "Exam:"
        '
        'cboExamAttExam
        '
        Me.cboExamAttExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboExamAttExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboExamAttExam.FormattingEnabled = True
        Me.cboExamAttExam.Items.AddRange(New Object() {"June 2012", "November 2012", "First Term 2012", "Second Term 2012", "Third Term 2012", "June 2013", "November 2013", "First Term 2013", "Second Term 2013", "Third Term 2013", "June 2013", "November 2013", "First Term 2013", "Second Term 2013", "Third Term 2012"})
        Me.cboExamAttExam.Location = New System.Drawing.Point(115, 65)
        Me.cboExamAttExam.Name = "cboExamAttExam"
        Me.cboExamAttExam.Size = New System.Drawing.Size(163, 21)
        Me.cboExamAttExam.TabIndex = 12
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(29, 37)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(43, 13)
        Me.Label49.TabIndex = 1
        Me.Label49.Text = "Subject"
        '
        'cboExamAttSub
        '
        Me.cboExamAttSub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboExamAttSub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboExamAttSub.DisplayMember = "SubjectID"
        Me.cboExamAttSub.FormattingEnabled = True
        Me.cboExamAttSub.Location = New System.Drawing.Point(115, 33)
        Me.cboExamAttSub.Name = "cboExamAttSub"
        Me.cboExamAttSub.Size = New System.Drawing.Size(242, 21)
        Me.cboExamAttSub.TabIndex = 0
        Me.cboExamAttSub.ValueMember = "SubjectID"
        '
        'gbContactDetails
        '
        Me.gbContactDetails.Controls.Add(Me.Label78)
        Me.gbContactDetails.Controls.Add(Me.cboContactsSect)
        Me.gbContactDetails.Controls.Add(Me.rbAllConts)
        Me.gbContactDetails.Controls.Add(Me.Label65)
        Me.gbContactDetails.Controls.Add(Me.cboContsIntk)
        Me.gbContactDetails.Controls.Add(Me.Label64)
        Me.gbContactDetails.Controls.Add(Me.gbCollegeAssessment)
        Me.gbContactDetails.Controls.Add(Me.cboContsSession)
        Me.gbContactDetails.Controls.Add(Me.lbStudContsSearch)
        Me.gbContactDetails.Controls.Add(Me.rbContactsPerStud)
        Me.gbContactDetails.Controls.Add(Me.cboContactsStud)
        Me.gbContactDetails.Controls.Add(Me.Label63)
        Me.gbContactDetails.Controls.Add(Me.Label33)
        Me.gbContactDetails.Controls.Add(Me.cboContactsSem)
        Me.gbContactDetails.Controls.Add(Me.Label31)
        Me.gbContactDetails.Controls.Add(Me.cboContactsClass)
        Me.gbContactDetails.Controls.Add(Me.Label30)
        Me.gbContactDetails.Controls.Add(Me.cboContactsProgra)
        Me.gbContactDetails.Controls.Add(Me.rbContsPerClass)
        Me.gbContactDetails.Controls.Add(Me.Label29)
        Me.gbContactDetails.Controls.Add(Me.cboContsLevel)
        Me.gbContactDetails.Location = New System.Drawing.Point(194, 109)
        Me.gbContactDetails.Name = "gbContactDetails"
        Me.gbContactDetails.Size = New System.Drawing.Size(26, 20)
        Me.gbContactDetails.TabIndex = 11
        Me.gbContactDetails.TabStop = False
        Me.gbContactDetails.Text = "StudentContactDetails"
        Me.gbContactDetails.Visible = False
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(20, 28)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(46, 13)
        Me.Label78.TabIndex = 25
        Me.Label78.Text = "Section:"
        '
        'cboContactsSect
        '
        Me.cboContactsSect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboContactsSect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboContactsSect.DisplayMember = "Forms"
        Me.cboContactsSect.Enabled = False
        Me.cboContactsSect.FormattingEnabled = True
        Me.cboContactsSect.Items.AddRange(New Object() {"IT", "Business School", "High School"})
        Me.cboContactsSect.Location = New System.Drawing.Point(90, 18)
        Me.cboContactsSect.Name = "cboContactsSect"
        Me.cboContactsSect.Size = New System.Drawing.Size(240, 21)
        Me.cboContactsSect.TabIndex = 24
        Me.cboContactsSect.ValueMember = "Forms"
        '
        'rbAllConts
        '
        Me.rbAllConts.AutoSize = True
        Me.rbAllConts.Location = New System.Drawing.Point(182, 285)
        Me.rbAllConts.Name = "rbAllConts"
        Me.rbAllConts.Size = New System.Drawing.Size(78, 17)
        Me.rbAllConts.TabIndex = 23
        Me.rbAllConts.TabStop = True
        Me.rbAllConts.Text = "AllContacts"
        Me.rbAllConts.UseVisualStyleBackColor = True
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(22, 204)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(40, 13)
        Me.Label65.TabIndex = 22
        Me.Label65.Text = "Intake:"
        '
        'cboContsIntk
        '
        Me.cboContsIntk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboContsIntk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboContsIntk.DisplayMember = "Forms"
        Me.cboContsIntk.Enabled = False
        Me.cboContsIntk.FormattingEnabled = True
        Me.cboContsIntk.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboContsIntk.Location = New System.Drawing.Point(90, 203)
        Me.cboContsIntk.Name = "cboContsIntk"
        Me.cboContsIntk.Size = New System.Drawing.Size(139, 21)
        Me.cboContsIntk.TabIndex = 21
        Me.cboContsIntk.ValueMember = "Forms"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(22, 180)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(47, 13)
        Me.Label64.TabIndex = 20
        Me.Label64.Text = "Session:"
        '
        'gbCollegeAssessment
        '
        Me.gbCollegeAssessment.Controls.Add(Me.Label93)
        Me.gbCollegeAssessment.Controls.Add(Me.cboColAssIntk)
        Me.gbCollegeAssessment.Controls.Add(Me.Label98)
        Me.gbCollegeAssessment.Controls.Add(Me.CboColAssCls)
        Me.gbCollegeAssessment.Location = New System.Drawing.Point(50, 5)
        Me.gbCollegeAssessment.Name = "gbCollegeAssessment"
        Me.gbCollegeAssessment.Size = New System.Drawing.Size(148, 29)
        Me.gbCollegeAssessment.TabIndex = 22
        Me.gbCollegeAssessment.TabStop = False
        Me.gbCollegeAssessment.Text = "CollegeAverage"
        Me.gbCollegeAssessment.Visible = False
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Location = New System.Drawing.Point(51, 102)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(40, 13)
        Me.Label93.TabIndex = 12
        Me.Label93.Text = "Intake:"
        '
        'cboColAssIntk
        '
        Me.cboColAssIntk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboColAssIntk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboColAssIntk.FormattingEnabled = True
        Me.cboColAssIntk.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Decmber"})
        Me.cboColAssIntk.Location = New System.Drawing.Point(118, 94)
        Me.cboColAssIntk.Name = "cboColAssIntk"
        Me.cboColAssIntk.Size = New System.Drawing.Size(129, 21)
        Me.cboColAssIntk.TabIndex = 11
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Location = New System.Drawing.Point(49, 66)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(35, 13)
        Me.Label98.TabIndex = 10
        Me.Label98.Text = "Class:"
        '
        'CboColAssCls
        '
        Me.CboColAssCls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboColAssCls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboColAssCls.FormattingEnabled = True
        Me.CboColAssCls.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.CboColAssCls.Location = New System.Drawing.Point(118, 58)
        Me.CboColAssCls.Name = "CboColAssCls"
        Me.CboColAssCls.Size = New System.Drawing.Size(129, 21)
        Me.CboColAssCls.TabIndex = 9
        '
        'cboContsSession
        '
        Me.cboContsSession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboContsSession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboContsSession.DisplayMember = "Session"
        Me.cboContsSession.Enabled = False
        Me.cboContsSession.FormattingEnabled = True
        Me.cboContsSession.Location = New System.Drawing.Point(91, 172)
        Me.cboContsSession.Name = "cboContsSession"
        Me.cboContsSession.Size = New System.Drawing.Size(139, 21)
        Me.cboContsSession.TabIndex = 19
        Me.cboContsSession.ValueMember = "Session"
        '
        'lbStudContsSearch
        '
        Me.lbStudContsSearch.BackColor = System.Drawing.SystemColors.Info
        Me.lbStudContsSearch.FormattingEnabled = True
        Me.lbStudContsSearch.Location = New System.Drawing.Point(246, 227)
        Me.lbStudContsSearch.Name = "lbStudContsSearch"
        Me.lbStudContsSearch.Size = New System.Drawing.Size(153, 69)
        Me.lbStudContsSearch.TabIndex = 18
        Me.lbStudContsSearch.Visible = False
        '
        'rbContactsPerStud
        '
        Me.rbContactsPerStud.AutoSize = True
        Me.rbContactsPerStud.Location = New System.Drawing.Point(92, 285)
        Me.rbContactsPerStud.Name = "rbContactsPerStud"
        Me.rbContactsPerStud.Size = New System.Drawing.Size(78, 17)
        Me.rbContactsPerStud.TabIndex = 17
        Me.rbContactsPerStud.TabStop = True
        Me.rbContactsPerStud.Text = "PerStudent"
        Me.rbContactsPerStud.UseVisualStyleBackColor = True
        '
        'cboContactsStud
        '
        Me.cboContactsStud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboContactsStud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboContactsStud.DisplayMember = "StudentID"
        Me.cboContactsStud.FormattingEnabled = True
        Me.cboContactsStud.Location = New System.Drawing.Point(91, 230)
        Me.cboContactsStud.Name = "cboContactsStud"
        Me.cboContactsStud.Size = New System.Drawing.Size(149, 21)
        Me.cboContactsStud.TabIndex = 16
        Me.cboContactsStud.ValueMember = "StudentID"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(19, 238)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(55, 13)
        Me.Label63.TabIndex = 15
        Me.Label63.Text = "StudentID"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(24, 151)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(34, 13)
        Me.Label33.TabIndex = 14
        Me.Label33.Text = "Sem::"
        '
        'cboContactsSem
        '
        Me.cboContactsSem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboContactsSem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboContactsSem.DisplayMember = "SubjectID"
        Me.cboContactsSem.Enabled = False
        Me.cboContactsSem.FormattingEnabled = True
        Me.cboContactsSem.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboContactsSem.Location = New System.Drawing.Point(88, 143)
        Me.cboContactsSem.Name = "cboContactsSem"
        Me.cboContactsSem.Size = New System.Drawing.Size(127, 21)
        Me.cboContactsSem.TabIndex = 13
        Me.cboContactsSem.ValueMember = "SubjectID"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(19, 87)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(35, 13)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "Class:"
        '
        'cboContactsClass
        '
        Me.cboContactsClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboContactsClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboContactsClass.Enabled = False
        Me.cboContactsClass.FormattingEnabled = True
        Me.cboContactsClass.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboContactsClass.Location = New System.Drawing.Point(88, 81)
        Me.cboContactsClass.Name = "cboContactsClass"
        Me.cboContactsClass.Size = New System.Drawing.Size(121, 21)
        Me.cboContactsClass.TabIndex = 9
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(19, 55)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 13)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Program:"
        '
        'cboContactsProgra
        '
        Me.cboContactsProgra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboContactsProgra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboContactsProgra.DisplayMember = "Forms"
        Me.cboContactsProgra.Enabled = False
        Me.cboContactsProgra.FormattingEnabled = True
        Me.cboContactsProgra.Location = New System.Drawing.Point(90, 47)
        Me.cboContactsProgra.Name = "cboContactsProgra"
        Me.cboContactsProgra.Size = New System.Drawing.Size(240, 21)
        Me.cboContactsProgra.TabIndex = 7
        Me.cboContactsProgra.ValueMember = "Forms"
        '
        'rbContsPerClass
        '
        Me.rbContsPerClass.AutoSize = True
        Me.rbContsPerClass.Location = New System.Drawing.Point(14, 285)
        Me.rbContsPerClass.Name = "rbContsPerClass"
        Me.rbContsPerClass.Size = New System.Drawing.Size(66, 17)
        Me.rbContsPerClass.TabIndex = 4
        Me.rbContsPerClass.TabStop = True
        Me.rbContsPerClass.Text = "PerClass"
        Me.rbContsPerClass.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(22, 122)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(36, 13)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "Level:"
        '
        'cboContsLevel
        '
        Me.cboContsLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboContsLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboContsLevel.Enabled = False
        Me.cboContsLevel.FormattingEnabled = True
        Me.cboContsLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboContsLevel.Location = New System.Drawing.Point(90, 114)
        Me.cboContsLevel.Name = "cboContsLevel"
        Me.cboContsLevel.Size = New System.Drawing.Size(121, 21)
        Me.cboContsLevel.TabIndex = 2
        '
        'gbSubjectPoints
        '
        Me.gbSubjectPoints.Controls.Add(Me.Label106)
        Me.gbSubjectPoints.Controls.Add(Me.cboSubPntSess)
        Me.gbSubjectPoints.Controls.Add(Me.Label47)
        Me.gbSubjectPoints.Controls.Add(Me.cboSubPntIntk)
        Me.gbSubjectPoints.Controls.Add(Me.Label16)
        Me.gbSubjectPoints.Controls.Add(Me.cboSubPntSect)
        Me.gbSubjectPoints.Controls.Add(Me.Label18)
        Me.gbSubjectPoints.Controls.Add(Me.cboSubPntClass)
        Me.gbSubjectPoints.Location = New System.Drawing.Point(700, 68)
        Me.gbSubjectPoints.Name = "gbSubjectPoints"
        Me.gbSubjectPoints.Size = New System.Drawing.Size(49, 23)
        Me.gbSubjectPoints.TabIndex = 7
        Me.gbSubjectPoints.TabStop = False
        Me.gbSubjectPoints.Text = "SubjectPoints"
        Me.gbSubjectPoints.Visible = False
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Location = New System.Drawing.Point(6, 151)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(47, 13)
        Me.Label106.TabIndex = 7
        Me.Label106.Text = "Session:"
        '
        'cboSubPntSess
        '
        Me.cboSubPntSess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubPntSess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubPntSess.DisplayMember = "Session"
        Me.cboSubPntSess.FormattingEnabled = True
        Me.cboSubPntSess.Location = New System.Drawing.Point(64, 143)
        Me.cboSubPntSess.Name = "cboSubPntSess"
        Me.cboSubPntSess.Size = New System.Drawing.Size(164, 21)
        Me.cboSubPntSess.TabIndex = 6
        Me.cboSubPntSess.ValueMember = "Session"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(11, 91)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(40, 13)
        Me.Label47.TabIndex = 5
        Me.Label47.Text = "Intake:"
        '
        'cboSubPntIntk
        '
        Me.cboSubPntIntk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubPntIntk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubPntIntk.DisplayMember = "SubjectID"
        Me.cboSubPntIntk.FormattingEnabled = True
        Me.cboSubPntIntk.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November ", "December"})
        Me.cboSubPntIntk.Location = New System.Drawing.Point(66, 83)
        Me.cboSubPntIntk.Name = "cboSubPntIntk"
        Me.cboSubPntIntk.Size = New System.Drawing.Size(161, 21)
        Me.cboSubPntIntk.TabIndex = 4
        Me.cboSubPntIntk.ValueMember = "SubjectID"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Section:"
        '
        'cboSubPntSect
        '
        Me.cboSubPntSect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubPntSect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubPntSect.DisplayMember = "SubjectID"
        Me.cboSubPntSect.FormattingEnabled = True
        Me.cboSubPntSect.Items.AddRange(New Object() {"High School", "IT", "Business School"})
        Me.cboSubPntSect.Location = New System.Drawing.Point(64, 113)
        Me.cboSubPntSect.Name = "cboSubPntSect"
        Me.cboSubPntSect.Size = New System.Drawing.Size(163, 21)
        Me.cboSubPntSect.TabIndex = 2
        Me.cboSubPntSect.ValueMember = "SubjectID"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Class:"
        '
        'cboSubPntClass
        '
        Me.cboSubPntClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubPntClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubPntClass.DisplayMember = "SubjectID"
        Me.cboSubPntClass.FormattingEnabled = True
        Me.cboSubPntClass.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboSubPntClass.Location = New System.Drawing.Point(65, 44)
        Me.cboSubPntClass.Name = "cboSubPntClass"
        Me.cboSubPntClass.Size = New System.Drawing.Size(162, 21)
        Me.cboSubPntClass.TabIndex = 0
        Me.cboSubPntClass.ValueMember = "SubjectID"
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.Location = New System.Drawing.Point(733, 539)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(212, 52)
        Me.btnPreview.TabIndex = 4
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(951, 539)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(212, 52)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pnlTranstype
        '
        Me.pnlTranstype.Controls.Add(Me.chkAccShoRec)
        Me.pnlTranstype.Controls.Add(Me.chkAccShowInv)
        Me.pnlTranstype.Location = New System.Drawing.Point(91, 162)
        Me.pnlTranstype.Name = "pnlTranstype"
        Me.pnlTranstype.Size = New System.Drawing.Size(274, 26)
        Me.pnlTranstype.TabIndex = 59
        '
        'chkAccShoRec
        '
        Me.chkAccShoRec.AutoSize = True
        Me.chkAccShoRec.Location = New System.Drawing.Point(94, 5)
        Me.chkAccShoRec.Name = "chkAccShoRec"
        Me.chkAccShoRec.Size = New System.Drawing.Size(98, 17)
        Me.chkAccShoRec.TabIndex = 12
        Me.chkAccShoRec.Text = "Show Receipts"
        Me.chkAccShoRec.UseVisualStyleBackColor = True
        '
        'chkAccShowInv
        '
        Me.chkAccShowInv.AutoSize = True
        Me.chkAccShowInv.Location = New System.Drawing.Point(4, 4)
        Me.chkAccShowInv.Name = "chkAccShowInv"
        Me.chkAccShowInv.Size = New System.Drawing.Size(88, 17)
        Me.chkAccShowInv.TabIndex = 11
        Me.chkAccShowInv.Text = "Show Billings"
        Me.chkAccShowInv.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "BBF Cut Off :"
        '
        'cboBBFCutOff
        '
        Me.cboBBFCutOff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBBFCutOff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBBFCutOff.DisplayMember = "Period"
        Me.cboBBFCutOff.FormattingEnabled = True
        Me.cboBBFCutOff.Location = New System.Drawing.Point(91, 110)
        Me.cboBBFCutOff.Name = "cboBBFCutOff"
        Me.cboBBFCutOff.Size = New System.Drawing.Size(119, 21)
        Me.cboBBFCutOff.TabIndex = 60
        Me.cboBBFCutOff.ValueMember = "Period"
        '
        'Rports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1181, 608)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbStudProfile.ResumeLayout(False)
        Me.gbStudProfile.PerformLayout()
        Me.gbExamGraphicalAnalysis.ResumeLayout(False)
        Me.gbExamGraphicalAnalysis.PerformLayout()
        Me.gbBorrowHistory.ResumeLayout(False)
        Me.gbBorrowHistory.PerformLayout()
        Me.gbDueBy.ResumeLayout(False)
        Me.gbDueBy.PerformLayout()
        Me.gbCreditors.ResumeLayout(False)
        Me.gbCreditors.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbIncomeExpenditure.ResumeLayout(False)
        Me.gbIncomeExpenditure.PerformLayout()
        Me.gbBookMaster.ResumeLayout(False)
        Me.gbBookMaster.PerformLayout()
        Me.gbBookIssues.ResumeLayout(False)
        Me.gbBookIssues.PerformLayout()
        Me.gbstudentregister2.ResumeLayout(False)
        Me.gbstudentregister2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbStaffRegister.ResumeLayout(False)
        Me.gbStaffRegister.PerformLayout()
        Me.gbClassRegister.ResumeLayout(False)
        Me.gbClassRegister.PerformLayout()
        Me.gbSchoolProfile.ResumeLayout(False)
        Me.gbSchoolProfile.PerformLayout()
        Me.gbHsStudMarks.ResumeLayout(False)
        Me.gbHsStudMarks.PerformLayout()
        Me.gbCustomEmailmsg.ResumeLayout(False)
        Me.gbCustomEmailmsg.PerformLayout()
        Me.gbGraphicalView.ResumeLayout(False)
        Me.gbGraphicalView.PerformLayout()
        Me.gbPublishOptions.ResumeLayout(False)
        Me.gbPublishOptions.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gbStaffQualifictions.ResumeLayout(False)
        Me.gbStaffQualifictions.PerformLayout()
        Me.gbStaffPersonalDetails.ResumeLayout(False)
        Me.gbStaffPersonalDetails.PerformLayout()
        Me.gbExamBoardPassRates.ResumeLayout(False)
        Me.gbExamBoardPassRates.PerformLayout()
        Me.gbIDcards.ResumeLayout(False)
        Me.gbIDcards.PerformLayout()
        Me.gbUserHistory.ResumeLayout(False)
        Me.gbUserHistory.PerformLayout()
        Me.gbSubjectRegister.ResumeLayout(False)
        Me.gbSubjectRegister.PerformLayout()
        Me.gbKnowhowAnalysis.ResumeLayout(False)
        Me.gbKnowhowAnalysis.PerformLayout()
        Me.gbRegister3.ResumeLayout(False)
        Me.gbRegister3.PerformLayout()
        Me.gbSchoolEnrollment.ResumeLayout(False)
        Me.gbSchoolEnrollment.PerformLayout()
        Me.pnlDateAnalysis.ResumeLayout(False)
        Me.pnlDateAnalysis.PerformLayout()
        Me.gbGeneralanalysis.ResumeLayout(False)
        Me.gbGeneralanalysis.PerformLayout()
        Me.gbSubjectsTaught.ResumeLayout(False)
        Me.gbSubjectsTaught.PerformLayout()
        Me.gbSubjectsDropped.ResumeLayout(False)
        Me.gbSubjectsDropped.PerformLayout()
        Me.gbStaffRatings.ResumeLayout(False)
        Me.gbStaffRatings.PerformLayout()
        Me.gbDepartmentalAssessment.ResumeLayout(False)
        Me.gbDepartmentalAssessment.PerformLayout()
        Me.gbStaffAssessment.ResumeLayout(False)
        Me.gbStaffAssessment.PerformLayout()
        Me.gbDetailedMarks.ResumeLayout(False)
        Me.gbDetailedMarks.PerformLayout()
        Me.gbKnowHow.ResumeLayout(False)
        Me.gbKnowHow.PerformLayout()
        Me.gbSubStuds.ResumeLayout(False)
        Me.gbSubStuds.PerformLayout()
        Me.gbTrans.ResumeLayout(False)
        Me.gbTrans.PerformLayout()
        Me.gbStudSub.ResumeLayout(False)
        Me.gbStudSub.PerformLayout()
        Me.gbLeftStudents.ResumeLayout(False)
        Me.gbLeftStudents.PerformLayout()
        Me.gbPersDetails.ResumeLayout(False)
        Me.gbPersDetails.PerformLayout()
        Me.gbStudClasses.ResumeLayout(False)
        Me.gbStudClasses.PerformLayout()
        Me.gbClassAgeRange.ResumeLayout(False)
        Me.gbClassAgeRange.PerformLayout()
        Me.pnlclassstudent.ResumeLayout(False)
        Me.pnlclassstudent.PerformLayout()
        Me.gbPaymentsPerDate.ResumeLayout(False)
        Me.gbPaymentsPerDate.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbAccounts.ResumeLayout(False)
        Me.gbAccounts.PerformLayout()
        Me.gbExamAttendance.ResumeLayout(False)
        Me.gbExamAttendance.PerformLayout()
        Me.gbContactDetails.ResumeLayout(False)
        Me.gbContactDetails.PerformLayout()
        Me.gbCollegeAssessment.ResumeLayout(False)
        Me.gbCollegeAssessment.PerformLayout()
        Me.gbSubjectPoints.ResumeLayout(False)
        Me.gbSubjectPoints.PerformLayout()
        Me.pnlTranstype.ResumeLayout(False)
        Me.pnlTranstype.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dsschool As dsSchool
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tvRpts As System.Windows.Forms.TreeView
    Friend WithEvents gbTrans As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTransProg As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbTransSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTransYear As System.Windows.Forms.ComboBox
    Friend WithEvents chkAllYears As System.Windows.Forms.CheckBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents StudentPersonalDetailsTableAdapter As dsStudentSearchesTableAdapters.StudentPersonalDetailsTableAdapter
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TranscriptTableAdapter As dsReportsTableAdapters.TranscriptTableAdapter
    Friend WithEvents TableAdapterManager As dsReportsTableAdapters.TableAdapterManager
    Friend WithEvents StudentPersonalDetailsTableAdapter1 As dsReportsTableAdapters.StudentPersonalDetailsTableAdapter
    Friend WithEvents gbSubStuds As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboSubStudsYera As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboSubStudsID As System.Windows.Forms.ComboBox
    Friend WithEvents SubjectsTableAdapter As dsSchoolTableAdapters.SubjectsTableAdapter
    Friend WithEvents gbStudClasses As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboStudClasProgram As System.Windows.Forms.ComboBox
    Friend WithEvents ProgramsTableAdapter As dsStudentSearchesTableAdapters.ProgramsTableAdapter
    Friend WithEvents FormsTableAdapter As dsSchoolTableAdapters.formsTableAdapter
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboStudClasYr As System.Windows.Forms.ComboBox
    Friend WithEvents cboStudClassSession As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboClassStudsSex As System.Windows.Forms.ComboBox
    Friend WithEvents gbSchoolEnrollment As System.Windows.Forms.GroupBox
    Friend WithEvents Staus As System.Windows.Forms.Label
    Friend WithEvents cboSchoolEnrolSection As System.Windows.Forms.ComboBox
    Friend WithEvents gbSubjectPoints As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboSubPntSect As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboSubPntClass As System.Windows.Forms.ComboBox
    Friend WithEvents gbPersDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboPersDetStatus As System.Windows.Forms.ComboBox
    Friend WithEvents SchoolEnrollmentTableAdapter As dsReportsTableAdapters.SchoolEnrollmentTableAdapter
    Friend WithEvents DsReports As dsReports
    Friend WithEvents SchoolEnrollment1TableAdapter As dsReportsTableAdapters.SchoolEnrollment1TableAdapter
    Friend WithEvents SubjectsTableAdapter1 As dsStudentSearchesTableAdapters.SubjectsTableAdapter
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboSubStudsProgram As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboSubStudsIntake As System.Windows.Forms.ComboBox
    Friend WithEvents rbAllSubStuds As System.Windows.Forms.RadioButton
    Friend WithEvents rbSubByProg As System.Windows.Forms.RadioButton
    Friend WithEvents StudentPersonalDetailsTableAdapter2 As dsSchoolTableAdapters.StudentPersonalDetailsTableAdapter
    Friend WithEvents gbContactDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cboContactsSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cboContactsClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cboContactsProgra As System.Windows.Forms.ComboBox
    Friend WithEvents rbContsPerClass As System.Windows.Forms.RadioButton
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cboContsLevel As System.Windows.Forms.ComboBox
    Friend WithEvents gbDetailedMarks As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cboDetailedMarksLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cboDetailedMarksClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cboDetailedMarksProg As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cboDetailedMarksSect As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cboTransReg As System.Windows.Forms.ComboBox
    Friend WithEvents rbResSummary As System.Windows.Forms.RadioButton
    Friend WithEvents rbResDetail As System.Windows.Forms.RadioButton
    Friend WithEvents gbHsStudMarks As System.Windows.Forms.GroupBox
    Friend WithEvents rbHsMarksPerClass As System.Windows.Forms.RadioButton
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cboHsMarksRef As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cboHsMarksLev As System.Windows.Forms.ComboBox
    Friend WithEvents rbHsMarksPerSubject As System.Windows.Forms.RadioButton
    Friend WithEvents rbHsReportPerClass As System.Windows.Forms.RadioButton
    Friend WithEvents rbResDisplay As System.Windows.Forms.RadioButton
    Friend WithEvents gbExamAttendance As System.Windows.Forms.GroupBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cboExamAttExam As System.Windows.Forms.ComboBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents cboExamAttSub As System.Windows.Forms.ComboBox
    Friend WithEvents rbExamAttendance As System.Windows.Forms.RadioButton
    Friend WithEvents RbMarkSheet As System.Windows.Forms.RadioButton
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cboMarkSheetExam As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cboSchoolEnrolClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cboTransClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cboTransIntk As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents cboSubPntIntk As System.Windows.Forms.ComboBox
    Friend WithEvents gbAccounts As System.Windows.Forms.GroupBox
    Friend WithEvents rbAccPerForm As System.Windows.Forms.RadioButton
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cboAccLvl As System.Windows.Forms.ComboBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents cboAccPerFrm As System.Windows.Forms.ComboBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents cboAccPerTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboAccSession As System.Windows.Forms.ComboBox
    Friend WithEvents PaymentPeriodsTableAdapter As dsStudentSearchesTableAdapters.PaymentPeriodsTableAdapter
    Friend WithEvents TableAdapterManager1 As dsStudentSearchesTableAdapters.TableAdapterManager
    Friend WithEvents PaymentPeriods1TableAdapter As dsStudentSearchesTableAdapters.PaymentPeriods1TableAdapter
    Friend WithEvents gbPaymentsPerDate As System.Windows.Forms.GroupBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents dtpPayDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpPayDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents rbFeesPaymentsAnalysis As System.Windows.Forms.RadioButton
    Friend WithEvents rbFeesPayWithStudents As System.Windows.Forms.RadioButton
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents cbofeesPayPto As System.Windows.Forms.ComboBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents cboFeesPayPfrpm As System.Windows.Forms.ComboBox
    Friend WithEvents gbLeftStudents As System.Windows.Forms.GroupBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents cboYearLeft As System.Windows.Forms.ComboBox
    Friend WithEvents rbCoursewek As System.Windows.Forms.RadioButton
    Friend WithEvents StudentFullNameTableAdapter As dsStudentSearchesTableAdapters.StudentFullNameTableAdapter
    Friend WithEvents cboContactsStud As System.Windows.Forms.ComboBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents rbContactsPerStud As System.Windows.Forms.RadioButton
    Friend WithEvents lbStudContsSearch As System.Windows.Forms.ListBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents cboContsSession As System.Windows.Forms.ComboBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents cboContsIntk As System.Windows.Forms.ComboBox
    Friend WithEvents lbStudSubSearch As System.Windows.Forms.ListBox
    Friend WithEvents gbStudSub As System.Windows.Forms.GroupBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents cboStudSubProg As System.Windows.Forms.ComboBox
    Friend WithEvents rbStubSubPerSem As System.Windows.Forms.RadioButton
    Friend WithEvents rbStudSubPerClass As System.Windows.Forms.RadioButton
    Friend WithEvents rbStudsubAll As System.Windows.Forms.RadioButton
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents cboStudSubCls As System.Windows.Forms.ComboBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents cboStudSubSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents cboStudSubLvl As System.Windows.Forms.ComboBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents cbostudsubStudid As System.Windows.Forms.ComboBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents dtpEnrolPerAnalDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnrolPerAnalDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlDateAnalysis As System.Windows.Forms.Panel
    Friend WithEvents chkPeriodAnalysis As System.Windows.Forms.CheckBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents cboSubStudSection As System.Windows.Forms.ComboBox
    Friend WithEvents gbSubjectsDropped As System.Windows.Forms.GroupBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents dtpSubDrpdTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSudDropdFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbAccDebtors As System.Windows.Forms.RadioButton
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents cboAccSection As System.Windows.Forms.ComboBox
    Friend WithEvents rbAllConts As System.Windows.Forms.RadioButton
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents cboDetailedMarksIntake As System.Windows.Forms.ComboBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents cboTransStudID As System.Windows.Forms.ComboBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents lbAccStud As System.Windows.Forms.ListBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents cboContactsSect As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbKnowHow As System.Windows.Forms.GroupBox
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents cboKnowHowYear As System.Windows.Forms.ComboBox
    Friend WithEvents gbStaffAssessment As System.Windows.Forms.GroupBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents cboStaffAssStaff As System.Windows.Forms.ComboBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents cboStaffAssIntk As System.Windows.Forms.ComboBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents cboStaffAssCls As System.Windows.Forms.ComboBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents cboStaffAssSect As System.Windows.Forms.ComboBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents cboStaffAssSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents cboStaffAssYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents cboStaffAssProg As System.Windows.Forms.ComboBox
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents cboStaffAssSub As System.Windows.Forms.ComboBox
    Friend WithEvents rbStaffAssPerIndv As System.Windows.Forms.RadioButton
    Friend WithEvents rbStaffAssPerClass As System.Windows.Forms.RadioButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents gbDepartmentalAssessment As System.Windows.Forms.GroupBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents cboDeptAnalIntk As System.Windows.Forms.ComboBox
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents cboDeptAnalClass As System.Windows.Forms.ComboBox
    Friend WithEvents gbStaffRatings As System.Windows.Forms.GroupBox
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents cboStaffRatingIntk As System.Windows.Forms.ComboBox
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents cboStaffRatingCls As System.Windows.Forms.ComboBox
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents cboStaffRatingSection As System.Windows.Forms.ComboBox
    Friend WithEvents gbCollegeAssessment As System.Windows.Forms.GroupBox
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents cboColAssIntk As System.Windows.Forms.ComboBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents CboColAssCls As System.Windows.Forms.ComboBox
    Friend WithEvents lblectures As System.Windows.Forms.ListBox
    Friend WithEvents rbAssessmentPerSub As System.Windows.Forms.RadioButton
    Friend WithEvents lstStudents As System.Windows.Forms.ListBox
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents cboDetailedMarksStud As System.Windows.Forms.ComboBox
    Friend WithEvents rbTansSum As System.Windows.Forms.RadioButton
    Friend WithEvents lbTransSumStud As System.Windows.Forms.ListBox
    Friend WithEvents rbStaffAssPerSection As System.Windows.Forms.RadioButton
    Friend WithEvents gbSubjectsTaught As System.Windows.Forms.GroupBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents cboSubTotCls As System.Windows.Forms.ComboBox
    Friend WithEvents gbGeneralanalysis As System.Windows.Forms.GroupBox
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents cboGeneralAnalIntk As System.Windows.Forms.ComboBox
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents cboGeneralAnalClass As System.Windows.Forms.ComboBox
    Friend WithEvents chkBySection As System.Windows.Forms.CheckBox
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents cboGeneralAnalSect As System.Windows.Forms.ComboBox
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents cboDptAnlSchool As System.Windows.Forms.ComboBox
    Friend WithEvents rbResStat As System.Windows.Forms.RadioButton
    Friend WithEvents chkDeptAnaly As System.Windows.Forms.CheckBox
    Friend WithEvents rbClassResStats As System.Windows.Forms.RadioButton
    Friend WithEvents SchoolsessionsTableAdapter As dsSchoolTableAdapters.schoolsessionsTableAdapter
    Friend WithEvents ExamSessionsTableAdapter As dsSchoolTableAdapters.ExamSessionsTableAdapter
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents cboSubPntSess As System.Windows.Forms.ComboBox
    Friend WithEvents gbstudentregister2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents ComboBox11 As System.Windows.Forms.ComboBox
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents ComboBox12 As System.Windows.Forms.ComboBox
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents ComboBox13 As System.Windows.Forms.ComboBox
    Friend WithEvents gbRegister3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboReg3Sec As System.Windows.Forms.ComboBox
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents cboReg3Intake As System.Windows.Forms.ComboBox
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents cboReg3Class As System.Windows.Forms.ComboBox
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents cboReg3Session As System.Windows.Forms.ComboBox
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents cboReg3Prog As System.Windows.Forms.ComboBox
    Friend WithEvents Label127 As System.Windows.Forms.Label
    Friend WithEvents lbReg3Prog As System.Windows.Forms.ListBox
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents lbReg3Sub As System.Windows.Forms.ListBox
    Friend WithEvents cboReg3Sub As System.Windows.Forms.ComboBox
    Friend WithEvents pnlclassstudent As System.Windows.Forms.Panel
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents chkperiodAnalysis1 As System.Windows.Forms.CheckBox
    Friend WithEvents dtpclassstudentdateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents dtpclassstudentdatefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbKnowhowAnalysis As System.Windows.Forms.GroupBox
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents cboKhasess As System.Windows.Forms.ComboBox
    Friend WithEvents Label135 As System.Windows.Forms.Label
    Friend WithEvents cboKhasem As System.Windows.Forms.ComboBox
    Friend WithEvents Label136 As System.Windows.Forms.Label
    Friend WithEvents cboKhalev As System.Windows.Forms.ComboBox
    Friend WithEvents Label137 As System.Windows.Forms.Label
    Friend WithEvents cboKhaintak As System.Windows.Forms.ComboBox
    Friend WithEvents Label138 As System.Windows.Forms.Label
    Friend WithEvents cboKhaclass As System.Windows.Forms.ComboBox
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents cboKhaprog As System.Windows.Forms.ComboBox
    Friend WithEvents rbPublish As System.Windows.Forms.RadioButton
    Friend WithEvents rbpub As System.Windows.Forms.RadioButton
    Friend WithEvents gbSubjectRegister As System.Windows.Forms.GroupBox
    Friend WithEvents lbSubRegStudSearch As System.Windows.Forms.ListBox
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents SubRegDateTo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents subRegDateFrom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents cboSubRegSub As System.Windows.Forms.ComboBox
    Friend WithEvents rbSubRegPerSub As System.Windows.Forms.RadioButton
    Friend WithEvents cboSubRegStud As System.Windows.Forms.ComboBox
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents cboSubRegCls As System.Windows.Forms.ComboBox
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents rbSubRegPerStud As System.Windows.Forms.RadioButton
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents cboSubRegSem As System.Windows.Forms.ComboBox
    Friend WithEvents cboSubRegSess As System.Windows.Forms.ComboBox
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents cboStudRegLvl As System.Windows.Forms.ComboBox
    Friend WithEvents rbStudStatement As System.Windows.Forms.RadioButton
    Friend WithEvents cboAccPayType As System.Windows.Forms.ComboBox
    Friend WithEvents rbClassStatement As System.Windows.Forms.RadioButton
    Friend WithEvents Label132 As System.Windows.Forms.Label
    Friend WithEvents CurrentSubjectsTableAdapter As dsStudentSearchesTableAdapters.CurrentSubjectsTableAdapter
    Friend WithEvents DsStudentSearches As dsStudentSearches
    Friend WithEvents SchoolDataSet As schoolDataSet
    Friend WithEvents PaymentType1TableAdapter As schoolDataSetTableAdapters.PaymentType1TableAdapter
    Friend WithEvents cboPayperDateType As System.Windows.Forms.ComboBox
    Friend WithEvents rbHardCopy As System.Windows.Forms.RadioButton
    Friend WithEvents cboPayPerDateMode As System.Windows.Forms.ComboBox
    Friend WithEvents CashTypeTableAdapter As schoolDataSetTableAdapters.CashTypeTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboPayPerDaterUser As System.Windows.Forms.ComboBox
    Friend WithEvents UsersTableAdapter As schoolDataSetTableAdapters.usersTableAdapter
    Friend WithEvents Label133 As System.Windows.Forms.Label
    Friend WithEvents cboSubStudsSession As System.Windows.Forms.ComboBox
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents cboSubStudsLvl As System.Windows.Forms.ComboBox
    Friend WithEvents Label140 As System.Windows.Forms.Label
    Friend WithEvents cboSubStudsSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label142 As System.Windows.Forms.Label
    Friend WithEvents Label143 As System.Windows.Forms.Label
    Friend WithEvents dtpPostDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpPostDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label144 As System.Windows.Forms.Label
    Friend WithEvents cboStudSubSess As System.Windows.Forms.ComboBox
    Friend WithEvents StudentMarksTableAdapter As schoolDataSetTableAdapters.StudentMarksTableAdapter
    Friend WithEvents TableAdapterManager2 As schoolDataSetTableAdapters.TableAdapterManager
    Friend WithEvents gbUserHistory As System.Windows.Forms.GroupBox
    Friend WithEvents UserName As System.Windows.Forms.Label
    Friend WithEvents cbUserHisUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mskLognHisTo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskLognHisFrm As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbUsers As System.Windows.Forms.ListBox
    Friend WithEvents rbUserHisByDate As System.Windows.Forms.RadioButton
    Friend WithEvents rbUserHisByUser As System.Windows.Forms.RadioButton
    Friend WithEvents rbLoggedInUser As System.Windows.Forms.RadioButton
    Friend WithEvents Schoolsessions1TableAdapter As dsStudentSearchesTableAdapters.schoolsessions1TableAdapter
    Friend WithEvents gbIDcards As System.Windows.Forms.GroupBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents cboCardsGrp As System.Windows.Forms.ComboBox
    Friend WithEvents rbCardsPerGroup As System.Windows.Forms.RadioButton
    Friend WithEvents rbCardsPerClas As System.Windows.Forms.RadioButton
    Friend WithEvents cboCardsSess2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCardsForm2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label146 As System.Windows.Forms.Label
    Friend WithEvents cboCardsSess1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label147 As System.Windows.Forms.Label
    Friend WithEvents cboCardsTerm As System.Windows.Forms.ComboBox
    Friend WithEvents Label148 As System.Windows.Forms.Label
    Friend WithEvents cboCardsForm1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label150 As System.Windows.Forms.Label
    Friend WithEvents cboCardsYr As System.Windows.Forms.ComboBox
    Friend WithEvents ClubsTableAdapter As schoolDataSetTableAdapters.clubsTableAdapter
    Friend WithEvents rtxtAccAddinfo As System.Windows.Forms.RichTextBox
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label145 As System.Windows.Forms.Label
    Friend WithEvents cboTermLeftFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label151 As System.Windows.Forms.Label
    Friend WithEvents cboReasonLeft As System.Windows.Forms.ComboBox
    Friend WithEvents cboTermLeftTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label149 As System.Windows.Forms.Label
    Friend WithEvents gbExamBoardPassRates As System.Windows.Forms.GroupBox
    Friend WithEvents Label154 As System.Windows.Forms.Label
    Friend WithEvents cboPassRatesProg As System.Windows.Forms.ComboBox
    Friend WithEvents Label155 As System.Windows.Forms.Label
    Friend WithEvents cboPassRatesBoard As System.Windows.Forms.ComboBox
    Friend WithEvents rbPassRatePerProgram As System.Windows.Forms.RadioButton
    Friend WithEvents rbPassRatePerBoard As System.Windows.Forms.RadioButton
    Friend WithEvents gbStaffPersonalDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label153 As System.Windows.Forms.Label
    Friend WithEvents cboStaffPersStaus As System.Windows.Forms.ComboBox
    Friend WithEvents RbStaffGvt As System.Windows.Forms.RadioButton
    Friend WithEvents rbStaffContract As System.Windows.Forms.RadioButton
    Friend WithEvents rbStaffTeaching As System.Windows.Forms.RadioButton
    Friend WithEvents gbStaffQualifictions As System.Windows.Forms.GroupBox
    Friend WithEvents rbQualByQual As System.Windows.Forms.RadioButton
    Friend WithEvents rbQualByStaff As System.Windows.Forms.RadioButton
    Friend WithEvents gbSchoolProfile As System.Windows.Forms.GroupBox
    Friend WithEvents rbSchoolCurricula As System.Windows.Forms.RadioButton
    Friend WithEvents rbSchoolParticulars As System.Windows.Forms.RadioButton
    Friend WithEvents PaymentTypeTableAdapter As schoolDataSetTableAdapters.PaymentTypeTableAdapter
    Friend WithEvents gbClassRegister As System.Windows.Forms.GroupBox
    Friend WithEvents rbClsRegHardCopy As System.Windows.Forms.RadioButton
    Friend WithEvents lbClsRegStud As System.Windows.Forms.ListBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cboClsRegDetTo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboClsRegDetFrm As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rbClsRegByDay As System.Windows.Forms.RadioButton
    Friend WithEvents cboClsRegStud As System.Windows.Forms.ComboBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cboClsRegCls As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents rbClsRegByCls As System.Windows.Forms.RadioButton
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents cboClsRegTern As System.Windows.Forms.ComboBox
    Friend WithEvents cboClsRegSess As System.Windows.Forms.ComboBox
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents cboClsRegForm As System.Windows.Forms.ComboBox
    Friend WithEvents rbClsRegPerStud As System.Windows.Forms.RadioButton
    Friend WithEvents gbStaffRegister As System.Windows.Forms.GroupBox
    Friend WithEvents rbStaffRegByStaff As System.Windows.Forms.RadioButton
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label152 As System.Windows.Forms.Label
    Friend WithEvents StaffRegDateTo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents staffregdatefrom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rbStaffRegByDay As System.Windows.Forms.RadioButton

    Friend WithEvents gbBookIssues As System.Windows.Forms.GroupBox
    Friend WithEvents dtpBookIssuesTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBookIssuesFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label158 As System.Windows.Forms.Label
    Friend WithEvents Label159 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label156 As System.Windows.Forms.Label
    Friend WithEvents Label157 As System.Windows.Forms.Label
    Friend WithEvents gbBookMaster As System.Windows.Forms.GroupBox
    Friend WithEvents rbPerProgram As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerBook As System.Windows.Forms.RadioButton
    Friend WithEvents gbIncomeExpenditure As System.Windows.Forms.GroupBox
    Friend WithEvents dtpIncExpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpIncExpDatefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label160 As System.Windows.Forms.Label
    Friend WithEvents Label161 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label162 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label163 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label164 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label165 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label166 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox14 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label167 As System.Windows.Forms.Label
    Friend WithEvents Label168 As System.Windows.Forms.Label
    Friend WithEvents ComboBox15 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox16 As System.Windows.Forms.ComboBox
    Friend WithEvents Label169 As System.Windows.Forms.Label
    Friend WithEvents ComboBox17 As System.Windows.Forms.ComboBox
    Friend WithEvents Label170 As System.Windows.Forms.Label
    Friend WithEvents ComboBox18 As System.Windows.Forms.ComboBox
    Friend WithEvents Label171 As System.Windows.Forms.Label
    Friend WithEvents ComboBox19 As System.Windows.Forms.ComboBox
    Friend WithEvents Label172 As System.Windows.Forms.Label
    Friend WithEvents ComboBox20 As System.Windows.Forms.ComboBox
    Friend WithEvents Label173 As System.Windows.Forms.Label
    Friend WithEvents ComboBox21 As System.Windows.Forms.ComboBox
    Friend WithEvents Label174 As System.Windows.Forms.Label
    Friend WithEvents ComboBox22 As System.Windows.Forms.ComboBox
    Friend WithEvents Label175 As System.Windows.Forms.Label
    Friend WithEvents ComboBox23 As System.Windows.Forms.ComboBox
    Friend WithEvents Label176 As System.Windows.Forms.Label
    Friend WithEvents ComboBox24 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents cboIncomeExpenditureCart As System.Windows.Forms.ComboBox
    Friend WithEvents Label177 As System.Windows.Forms.Label
    Friend WithEvents rbBookIssuesPerDate As System.Windows.Forms.RadioButton
    Friend WithEvents rbIssuesPerBook As System.Windows.Forms.RadioButton
    Friend WithEvents rbIssuesPerStud As System.Windows.Forms.RadioButton
    Friend WithEvents rbIncExpDetailed As System.Windows.Forms.RadioButton
    Friend WithEvents rbIncExpSummary As System.Windows.Forms.RadioButton
    Friend WithEvents gbCreditors As System.Windows.Forms.GroupBox
    Friend WithEvents rbAllCreditors As System.Windows.Forms.RadioButton
    Friend WithEvents rbCreditorStat As System.Windows.Forms.RadioButton
    Friend WithEvents Label178 As System.Windows.Forms.Label
    Friend WithEvents cboCrPrdTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboCrPrdFrm As System.Windows.Forms.ComboBox
    Friend WithEvents txtCrCreditor As System.Windows.Forms.TextBox
    Friend WithEvents Label180 As System.Windows.Forms.Label
    Friend WithEvents Label179 As System.Windows.Forms.Label
    Friend WithEvents lbCreditors As System.Windows.Forms.ListBox
    Friend WithEvents gbDueBy As System.Windows.Forms.GroupBox
    Friend WithEvents Label181 As System.Windows.Forms.Label
    Friend WithEvents gbBorrowHistory As System.Windows.Forms.GroupBox
    Friend WithEvents rbHistoryPerBook As System.Windows.Forms.RadioButton
    Friend WithEvents rbHistoryPerStud As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtHistSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label182 As System.Windows.Forms.Label
    Friend WithEvents lbHistSearch As System.Windows.Forms.ListBox
    Friend WithEvents rbBookSummary As System.Windows.Forms.RadioButton
    Friend WithEvents rbSummaryPerprog As System.Windows.Forms.RadioButton
    Friend WithEvents gbExamGraphicalAnalysis As System.Windows.Forms.GroupBox
    Friend WithEvents cboExamGraphSessTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label183 As System.Windows.Forms.Label
    Friend WithEvents cboExamGraphSessFrom As System.Windows.Forms.ComboBox
    Friend WithEvents rbGraphPerSub As System.Windows.Forms.RadioButton
    Friend WithEvents rbgraphperstud As System.Windows.Forms.RadioButton
    Friend WithEvents Label184 As System.Windows.Forms.Label
    Friend WithEvents cboExamGraphClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label185 As System.Windows.Forms.Label
    Friend WithEvents cboExamGraphForm As System.Windows.Forms.ComboBox
    Friend WithEvents rbSubTaughtPerSubject As System.Windows.Forms.RadioButton
    Friend WithEvents rbSubTaughtPerTeacher As System.Windows.Forms.RadioButton
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents cboSubTaughtTerm As System.Windows.Forms.ComboBox
    Friend WithEvents cboSubTaughtSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label186 As System.Windows.Forms.Label
    Friend WithEvents txtsubtaughtteachers As System.Windows.Forms.TextBox
    Friend WithEvents lbteachers As System.Windows.Forms.ListBox
    Friend WithEvents lbSubjects As System.Windows.Forms.ListBox
    Friend WithEvents cboHsMarksStud As System.Windows.Forms.TextBox
    Friend WithEvents Label187 As System.Windows.Forms.Label
    Friend WithEvents rbReportPerStud As System.Windows.Forms.RadioButton
    Friend WithEvents lbMarksPerStud As System.Windows.Forms.ListBox
    Friend WithEvents rbConsolMarkSheet As System.Windows.Forms.RadioButton
    Friend WithEvents gbStudProfile As System.Windows.Forms.GroupBox
    Friend WithEvents Label191 As System.Windows.Forms.Label
    Friend WithEvents lbstudprofile As System.Windows.Forms.ListBox
    Friend WithEvents txtProfileStud As System.Windows.Forms.TextBox
    Friend WithEvents Label188 As System.Windows.Forms.Label
    Friend WithEvents cboProfilePeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbBooklet As System.Windows.Forms.RadioButton
    Friend WithEvents chkEmail As System.Windows.Forms.CheckBox
    Friend WithEvents rbA4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label189 As System.Windows.Forms.Label
    Friend WithEvents cboHsMarksSect As System.Windows.Forms.ComboBox
    Friend WithEvents Label190 As System.Windows.Forms.Label
    Friend WithEvents cboExamGraphSection As System.Windows.Forms.ComboBox
    Friend WithEvents cboHsMarksSess As ComboBox
    Friend WithEvents gbPublishOptions As GroupBox
    Friend WithEvents chkPublish As CheckBox
    Friend WithEvents rbPublishPerExam As RadioButton
    Friend WithEvents RbPublishPerClass As RadioButton
    Friend WithEvents txtAccStud As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboAccClass As ComboBox
    Friend WithEvents chkDebtorsOnly As CheckBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents cboFeesPayCurrency As ComboBox
    Friend WithEvents gbGraphicalView As GroupBox
    Friend WithEvents chkGraphical As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btnAddEnrol As Button
    Friend WithEvents lbAnalysisEnrols As ListBox
    Friend WithEvents chkGraphicalenrol As CheckBox
    Friend WithEvents txtStudClassAgeto As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtStudClassAgeFrom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboStudClassCls As ComboBox
    Friend WithEvents gbClassAgeRange As GroupBox
    Friend WithEvents chkClssAge As CheckBox
    Friend WithEvents gbCustomEmailmsg As GroupBox
    Friend WithEvents txtCustomEmailmsg As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboBBFCutOff As ComboBox
    Friend WithEvents pnlTranstype As Panel
    Friend WithEvents chkAccShoRec As CheckBox
    Friend WithEvents chkAccShowInv As CheckBox
    ' Friend WithEvents DebtPaymentTableAdapter As SMS.dsschoolTableAdapters.DebtPaymentTableAdapter
    ' Friend WithEvents AssertliquidationTableAdapter As SMS.dsschoolTableAdapters.assertliquidationTableAdapter
    'Friend WithEvents ReceitsdonationsTableAdapter As SMS.dsschoolTableAdapters.receitsdonationsTableAdapter
    ' Friend WithEvents LoansTableAdapter As SMS.dsschoolTableAdapters.LoansTableAdapter
    ' Friend WithEvents OtherPaymentsTableAdapter As SMS.dsschoolTableAdapters.OtherPaymentsTableAdapter
    'Friend WithEvents InvoicedExpendituresTableAdapter As SMS.dsschoolTableAdapters.InvoicedExpendituresTableAdapter
End Class
