Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label43 As System.Windows.Forms.Label
        Dim ReceiptLabel As System.Windows.Forms.Label
        Dim Label35 As System.Windows.Forms.Label
        Dim StudentIDLabel1 As System.Windows.Forms.Label
        Dim CashTypeLabel As System.Windows.Forms.Label
        Dim NokNameLabel As System.Windows.Forms.Label
        Dim NOKAddressLabel As System.Windows.Forms.Label
        Dim NOKContactNumberLabel As System.Windows.Forms.Label
        Dim NOKSurnameLabel As System.Windows.Forms.Label
        Dim Residential_AdressLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim ProgramLabel As System.Windows.Forms.Label
        Dim YearLabel1 As System.Windows.Forms.Label
        Dim Date_EnrolledLabel1 As System.Windows.Forms.Label
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim NationalIDLabel As System.Windows.Forms.Label
        Dim StudentNameLabel As System.Windows.Forms.Label
        Dim StudentSurnameLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim AccountNumberLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim PlaceOfBirthLabel As System.Windows.Forms.Label
        Dim PostDateLabel As System.Windows.Forms.Label
        Dim ReasonForReversalLabel As System.Windows.Forms.Label
        Dim Label39 As System.Windows.Forms.Label
        Dim Label38 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label51 As System.Windows.Forms.Label
        Dim Label37 As System.Windows.Forms.Label
        Dim Label53 As System.Windows.Forms.Label
        Dim Label57 As System.Windows.Forms.Label
        Dim Label60 As System.Windows.Forms.Label
        Dim Label45 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label67 As System.Windows.Forms.Label
        Dim Label71 As System.Windows.Forms.Label
        Dim Label68 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStudent))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("EditMarks")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("StudentMarks", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StudentFeesTranscationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSchool = New StudentDetails.dsSchool()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator41 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator42 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator43 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel13 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel14 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel15 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton23 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator44 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton24 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator45 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton25 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator46 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator47 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cmdRefreshPastel = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdLink = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tbBilling = New System.Windows.Forms.TabPage()
        Me.SplitContainer8 = New System.Windows.Forms.SplitContainer()
        Me.btnStudBillingStudentSearch = New System.Windows.Forms.Button()
        Me.btnClearBillStuds = New System.Windows.Forms.Button()
        Me.lbBillStud = New System.Windows.Forms.ListBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtBillStud = New System.Windows.Forms.TextBox()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.lbBillSearch = New System.Windows.Forms.ListBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txtStudBillSearch = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.btnPerfomBilling = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.dgPayType = New System.Windows.Forms.DataGridView()
        Me.Payment = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FeesPaymentTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkBilPeriods = New System.Windows.Forms.CheckedListBox()
        Me.cboBillType = New System.Windows.Forms.ComboBox()
        Me.dgBilling = New System.Windows.Forms.DataGridView()
        Me.BillingStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillingStudName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillingEnrolRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.btnBillingClass = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboBillingClass = New System.Windows.Forms.ComboBox()
        Me.cboBillingSess = New System.Windows.Forms.ComboBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.cboBillingLevel = New System.Windows.Forms.ComboBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.cboBillingProg = New System.Windows.Forms.ComboBox()
        Me.tbClassTRansferring = New System.Windows.Forms.TabPage()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.chkMaintainPrevSubjects = New System.Windows.Forms.CheckBox()
        Me.lbStudDeactivationSearch = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbonewClassCls = New System.Windows.Forms.ComboBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.cbonewclassprog = New System.Windows.Forms.ComboBox()
        Me.cbonewclassSess = New System.Windows.Forms.ComboBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.cbonewclassform = New System.Windows.Forms.ComboBox()
        Me.Chkmitype = New System.Windows.Forms.CheckBox()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.chknewclass = New System.Windows.Forms.CheckedListBox()
        Me.txtDeactivationStudSearch = New System.Windows.Forms.TextBox()
        Me.btnLeavingStudent = New System.Windows.Forms.Button()
        Me.chkoldclass = New System.Windows.Forms.CheckedListBox()
        Me.chkSelectOldClassStuds = New System.Windows.Forms.CheckBox()
        Me.gbActPerClass = New System.Windows.Forms.GroupBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.cboOldClassprog = New System.Windows.Forms.ComboBox()
        Me.cboOldClassSess = New System.Windows.Forms.ComboBox()
        Me.cboOldClassCls = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cboOldclassForm = New System.Windows.Forms.ComboBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.tbSMS = New System.Windows.Forms.TabPage()
        Me.SplitContainer10 = New System.Windows.Forms.SplitContainer()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.lbStudNotif = New System.Windows.Forms.ListBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtStudNotif = New System.Windows.Forms.TextBox()
        Me.othernot = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.cboSmsClubs = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rbSmsGroups = New System.Windows.Forms.RadioButton()
        Me.cboSchoolSections = New System.Windows.Forms.ComboBox()
        Me.rbsmsSection = New System.Windows.Forms.RadioButton()
        Me.rbSmsNotAtDb = New System.Windows.Forms.RadioButton()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.rbsmsClass = New System.Windows.Forms.RadioButton()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.characters = New System.Windows.Forms.Label()
        Me.specific = New System.Windows.Forms.Panel()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.gbSendingOptions = New System.Windows.Forms.GroupBox()
        Me.rbStudOnly = New System.Windows.Forms.RadioButton()
        Me.rbBoth = New System.Windows.Forms.RadioButton()
        Me.rbNextOfKinOnly = New System.Windows.Forms.RadioButton()
        Me.gbFeesSms = New System.Windows.Forms.GroupBox()
        Me.chkDebtorsOnly = New System.Windows.Forms.CheckBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.dgClassList = New System.Windows.Forms.DataGridView()
        Me.NOKContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.cboSmsSess = New System.Windows.Forms.ComboBox()
        Me.cboSmsSem = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cboSmslevel = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cboSmdClass = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Marks = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.btnStudentMarksSearch = New System.Windows.Forms.Button()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbStudMarks = New System.Windows.Forms.ListBox()
        Me.txtStudMarksSearch = New System.Windows.Forms.TextBox()
        Me.tvEditMarks = New System.Windows.Forms.TreeView()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.cboMarkSession = New System.Windows.Forms.ComboBox()
        Me.cboMarkSubject = New System.Windows.Forms.ComboBox()
        Me.btnMarkClass = New System.Windows.Forms.Button()
        Me.cboMarkClass = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.cboMarkExam = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboMarkLevel = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboMarkProg = New System.Windows.Forms.ComboBox()
        Me.StudentMarks = New System.Windows.Forms.GroupBox()
        Me.Button39 = New System.Windows.Forms.Button()
        Me.chkdef = New System.Windows.Forms.CheckBox()
        Me.lbDetails = New System.Windows.Forms.Label()
        Me.gvMarks = New System.Windows.Forms.DataGridView()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseMark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamMark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MultiComment = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Effort = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MarkRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboRemarks = New System.Windows.Forms.ComboBox()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.lbstuds = New System.Windows.Forms.ListBox()
        Me.txtstudsearch = New System.Windows.Forms.TextBox()
        Me.gdStudents = New System.Windows.Forms.DataGridView()
        Me.MarksStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarksStudName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarksEnrolRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEnterMarks = New System.Windows.Forms.Button()
        Me.tbStudentReceipts = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rvOnScreenStat = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rvOnScreenDatPay = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkTransScreenShowReceipts = New System.Windows.Forms.CheckBox()
        Me.chkTransScreenShowInvoices = New System.Windows.Forms.CheckBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.cboBBFCutOffPeriod = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnFeesClassMoveNext = New System.Windows.Forms.Button()
        Me.btnFeesClassMovePrev = New System.Windows.Forms.Button()
        Me.txtPos = New System.Windows.Forms.TextBox()
        Me.btnFessClass = New System.Windows.Forms.Button()
        Me.lbFeesHidedStudID = New System.Windows.Forms.TextBox()
        Me.ClassListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbofeesClassSearch = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboFeesProgSearch = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbofeessessSearch = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cbofeesLvlsearch = New System.Windows.Forms.ComboBox()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnCancelAllLines = New System.Windows.Forms.Button()
        Me.btnUpdateAllLines = New System.Windows.Forms.Button()
        Me.lbSeacrhFees = New System.Windows.Forms.ListBox()
        Me.dgFessDetails = New System.Windows.Forms.DataGridView()
        Me.Cart = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Amnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Currency = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CurrenciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Perd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PaymentPeriodsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LineRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeespaymentsdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Insert = New System.Windows.Forms.ToolStripButton()
        Me.FeesPaymentsHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Save = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Delete = New System.Windows.Forms.ToolStripButton()
        Me.Reprint = New System.Windows.Forms.ToolStripButton()
        Me.Edt = New System.Windows.Forms.ToolStripButton()
        Me.rec_import = New System.Windows.Forms.ToolStripButton()
        Me.gbFeesPay = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.pnlReversal = New System.Windows.Forms.Panel()
        Me.ReasonForReversalComboBox = New System.Windows.Forms.ComboBox()
        Me.lbStudRef = New System.Windows.Forms.TextBox()
        Me.txtFeesStudID = New System.Windows.Forms.TextBox()
        Me.PostDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lbStudFees = New System.Windows.Forms.ListBox()
        Me.cboCashType = New System.Windows.Forms.ComboBox()
        Me.mskpaydate = New System.Windows.Forms.MaskedTextBox()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.ReceiptTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.cboFeesCartegory = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.FeesDateSearch = New System.Windows.Forms.MaskedTextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cboReceiptSearch = New System.Windows.Forms.ComboBox()
        Me.txtReceiptSearch = New System.Windows.Forms.TextBox()
        Me.tbStudentSubjects = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.lbSubStudSearch = New System.Windows.Forms.ListBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtSubStudsSearch = New System.Windows.Forms.TextBox()
        Me.btnSubSearchPanel = New System.Windows.Forms.Button()
        Me.Academics = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.cboSubExam = New System.Windows.Forms.ComboBox()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.chkAllStuds = New System.Windows.Forms.CheckBox()
        Me.lbSubs = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.lsbSubStud = New System.Windows.Forms.ListBox()
        Me.txtSubSearch = New System.Windows.Forms.TextBox()
        Me.dgSubStuds = New System.Windows.Forms.DataGridView()
        Me.SubjectsStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnrolRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.saveSub = New System.Windows.Forms.Button()
        Me.Available_Subjects = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnSubClassList = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSubClass = New System.Windows.Forms.ComboBox()
        Me.cboSubSess = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSubLvl = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboSubProg = New System.Windows.Forms.ComboBox()
        Me.tbPersonalDetails = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvEnrol = New System.Windows.Forms.TreeView()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.ttxSearchtext = New System.Windows.Forms.TextBox()
        Me.btnStudProfile = New System.Windows.Forms.Button()
        Me.btnStudSearchPanel = New System.Windows.Forms.Button()
        Me.lbAddingStudent = New System.Windows.Forms.Label()
        Me.lbEditDetails = New System.Windows.Forms.Label()
        Me.gbSiblings = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.dgSiblings = New System.Windows.Forms.DataGridView()
        Me.SiblingID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboSibling = New System.Windows.Forms.ComboBox()
        Me.btnAddSibling = New System.Windows.Forms.Button()
        Me.gbXtraCurricular = New System.Windows.Forms.GroupBox()
        Me.txtHouse = New System.Windows.Forms.TextBox()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.txtSports = New System.Windows.Forms.TextBox()
        Me.gbMedicalDetails = New System.Windows.Forms.GroupBox()
        Me.txtMedComments = New System.Windows.Forms.TextBox()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.txtDocContNumber = New System.Windows.Forms.TextBox()
        Me.txtFamilyDoc = New System.Windows.Forms.TextBox()
        Me.gbPrevSchoolDetails = New System.Windows.Forms.GroupBox()
        Me.txtPrevSchoolCommnt = New System.Windows.Forms.TextBox()
        Me.txtPrevSchoolContact = New System.Windows.Forms.TextBox()
        Me.txtprevSchool = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SchoolInfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Print = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.gbClassSearch = New System.Windows.Forms.GroupBox()
        Me.txtStudRef = New System.Windows.Forms.TextBox()
        Me.txtHiddenStudID = New System.Windows.Forms.TextBox()
        Me.cboEnrolClassSearch = New System.Windows.Forms.ComboBox()
        Me.cboEnrlProgSearch = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CboEnrSessSearch = New System.Windows.Forms.ComboBox()
        Me.btnClassReport = New System.Windows.Forms.Button()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.cboEnrLevSearch = New System.Windows.Forms.ComboBox()
        Me.gbStudPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.DateOfBirthMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PlaceOfBirthTextBox = New System.Windows.Forms.TextBox()
        Me.FeesSourceComboBox = New System.Windows.Forms.ComboBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentSurnameTextBox = New System.Windows.Forms.TextBox()
        Me.NationalIDTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.gbEnrollmentDetails = New System.Windows.Forms.GroupBox()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.cboEnrolType = New System.Windows.Forms.ComboBox()
        Me.Date_EnrolledMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.ProgramComboBox = New System.Windows.Forms.ComboBox()
        Me.SessionComboBox = New System.Windows.Forms.ComboBox()
        Me.gbPic = New System.Windows.Forms.GroupBox()
        Me.lnkRemoveImage = New System.Windows.Forms.LinkLabel()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.gbContactDetails = New System.Windows.Forms.GroupBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.gbNok = New System.Windows.Forms.GroupBox()
        Me.btnDeleteParent = New System.Windows.Forms.Button()
        Me.dgStudNok = New System.Windows.Forms.DataGridView()
        Me.NokName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Relationship = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NokRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNokSurname = New System.Windows.Forms.TextBox()
        Me.btnAddNok = New System.Windows.Forms.Button()
        Me.NOKRelationTextBox = New System.Windows.Forms.TextBox()
        Me.NOKContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.NOKOccupationTextBox = New System.Windows.Forms.TextBox()
        Me.NokNameTextBox = New System.Windows.Forms.TextBox()
        Me.PersonalDetails = New System.Windows.Forms.TabControl()
        Me.tbStudBehavior = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.lbBehaviorRecourCount = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.lbStudBehaviorName = New System.Windows.Forms.Label()
        Me.txtBehaviorRef = New System.Windows.Forms.TextBox()
        Me.cboBehaviorPeriod = New System.Windows.Forms.ComboBox()
        Me.lbStudBehavior = New System.Windows.Forms.ListBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.btnStudBeaviorSearch = New System.Windows.Forms.Button()
        Me.cboBehaviorClass = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.btnAddBehavior = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtBehaviorDetails = New System.Windows.Forms.RichTextBox()
        Me.cboBehaviorSeverity = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mskBehaviorDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboBehaviorType = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgStudBehavior = New System.Windows.Forms.DataGridView()
        Me.BehaviorStudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BehaviorClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BehaviorPeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BehaviorDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BehaviorType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BehaviorSeverity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BehaviorDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BehaviorEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BehaviorView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BehaviorDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BehaviorRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtBehaviorStud = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton26 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton27 = New System.Windows.Forms.ToolStripButton()
        Me.Cartegory = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PaymentPeriodsTableAdapter = New StudentDetails.dsSchoolTableAdapters.PaymentPeriodsTableAdapter()
        Me.Feespayments_detailsTableAdapter = New StudentDetails.dsSchoolTableAdapters.feespayments_detailsTableAdapter()
        Me.FeesPayments_HeaderTableAdapter = New StudentDetails.dsSchoolTableAdapters.FeesPayments_HeaderTableAdapter()
        Me.CurrenciesTableAdapter = New StudentDetails.dsSchoolTableAdapters.CurrenciesTableAdapter()
        Me.ClassListTableAdapter = New StudentDetails.dsSchoolTableAdapters.ClassListTableAdapter()
        Me.StudentFeesTranscationsTableAdapter = New StudentDetails.dsSchoolTableAdapters.StudentFeesTranscationsTableAdapter()
        Me.FeespaymentsdetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FeesPaymentTypeTableAdapter = New StudentDetails.dsSchoolTableAdapters.FeesPaymentTypeTableAdapter()
        Me.ctxEnrollment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cxtToolDeleteEnrollment = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxtToolEditEnrollment = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxtToolCopyEnrollment = New System.Windows.Forms.ToolStripMenuItem()
        Label43 = New System.Windows.Forms.Label()
        ReceiptLabel = New System.Windows.Forms.Label()
        Label35 = New System.Windows.Forms.Label()
        StudentIDLabel1 = New System.Windows.Forms.Label()
        CashTypeLabel = New System.Windows.Forms.Label()
        NokNameLabel = New System.Windows.Forms.Label()
        NOKAddressLabel = New System.Windows.Forms.Label()
        NOKContactNumberLabel = New System.Windows.Forms.Label()
        NOKSurnameLabel = New System.Windows.Forms.Label()
        Residential_AdressLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        ProgramLabel = New System.Windows.Forms.Label()
        YearLabel1 = New System.Windows.Forms.Label()
        Date_EnrolledLabel1 = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        NationalIDLabel = New System.Windows.Forms.Label()
        StudentNameLabel = New System.Windows.Forms.Label()
        StudentSurnameLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        AccountNumberLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        PlaceOfBirthLabel = New System.Windows.Forms.Label()
        PostDateLabel = New System.Windows.Forms.Label()
        ReasonForReversalLabel = New System.Windows.Forms.Label()
        Label39 = New System.Windows.Forms.Label()
        Label38 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label51 = New System.Windows.Forms.Label()
        Label37 = New System.Windows.Forms.Label()
        Label53 = New System.Windows.Forms.Label()
        Label57 = New System.Windows.Forms.Label()
        Label60 = New System.Windows.Forms.Label()
        Label45 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label67 = New System.Windows.Forms.Label()
        Label71 = New System.Windows.Forms.Label()
        Label68 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.StudentFeesTranscationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBilling.SuspendLayout()
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer8.Panel1.SuspendLayout()
        Me.SplitContainer8.Panel2.SuspendLayout()
        Me.SplitContainer8.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.dgPayType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeesPaymentTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        Me.tbClassTRansferring.SuspendLayout()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbActPerClass.SuspendLayout()
        Me.tbSMS.SuspendLayout()
        CType(Me.SplitContainer10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer10.Panel1.SuspendLayout()
        Me.SplitContainer10.Panel2.SuspendLayout()
        Me.SplitContainer10.SuspendLayout()
        Me.othernot.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.specific.SuspendLayout()
        Me.gbSendingOptions.SuspendLayout()
        Me.gbFeesSms.SuspendLayout()
        CType(Me.dgClassList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        Me.Marks.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.StudentMarks.SuspendLayout()
        CType(Me.gvMarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbStudentReceipts.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ClassListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgFessDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrenciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentPeriodsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeespaymentsdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.FeesPaymentsHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFeesPay.SuspendLayout()
        Me.pnlReversal.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.tbStudentSubjects.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Academics.SuspendLayout()
        CType(Me.dgSubStuds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.tbPersonalDetails.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbSiblings.SuspendLayout()
        CType(Me.dgSiblings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbXtraCurricular.SuspendLayout()
        Me.gbMedicalDetails.SuspendLayout()
        Me.gbPrevSchoolDetails.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.gbClassSearch.SuspendLayout()
        Me.gbStudPersonalDetails.SuspendLayout()
        Me.gbEnrollmentDetails.SuspendLayout()
        Me.gbPic.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbContactDetails.SuspendLayout()
        Me.gbNok.SuspendLayout()
        CType(Me.dgStudNok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PersonalDetails.SuspendLayout()
        Me.tbStudBehavior.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgStudBehavior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeespaymentsdetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxEnrollment.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label43
        '
        Label43.AutoSize = True
        Label43.Location = New System.Drawing.Point(64, 16)
        Label43.Name = "Label43"
        Label43.Size = New System.Drawing.Size(34, 13)
        Label43.TabIndex = 26
        Label43.Text = "Type:"
        '
        'ReceiptLabel
        '
        ReceiptLabel.AutoSize = True
        ReceiptLabel.Location = New System.Drawing.Point(6, 107)
        ReceiptLabel.Name = "ReceiptLabel"
        ReceiptLabel.Size = New System.Drawing.Size(47, 13)
        ReceiptLabel.TabIndex = 12
        ReceiptLabel.Text = "Receipt:"
        '
        'Label35
        '
        Label35.AutoSize = True
        Label35.Location = New System.Drawing.Point(6, 82)
        Label35.Name = "Label35"
        Label35.Size = New System.Drawing.Size(70, 13)
        Label35.TabIndex = 10
        Label35.Text = "ReceiptDate:"
        '
        'StudentIDLabel1
        '
        StudentIDLabel1.AutoSize = True
        StudentIDLabel1.Location = New System.Drawing.Point(6, 35)
        StudentIDLabel1.Name = "StudentIDLabel1"
        StudentIDLabel1.Size = New System.Drawing.Size(47, 13)
        StudentIDLabel1.TabIndex = 0
        StudentIDLabel1.Text = "Student:"
        '
        'CashTypeLabel
        '
        CashTypeLabel.AutoSize = True
        CashTypeLabel.Location = New System.Drawing.Point(6, 56)
        CashTypeLabel.Name = "CashTypeLabel"
        CashTypeLabel.Size = New System.Drawing.Size(52, 13)
        CashTypeLabel.TabIndex = 23
        CashTypeLabel.Text = "PayType:"
        '
        'NokNameLabel
        '
        NokNameLabel.AutoSize = True
        NokNameLabel.Location = New System.Drawing.Point(2, 20)
        NokNameLabel.Name = "NokNameLabel"
        NokNameLabel.Size = New System.Drawing.Size(38, 13)
        NokNameLabel.TabIndex = 0
        NokNameLabel.Text = "Name:"
        '
        'NOKAddressLabel
        '
        NOKAddressLabel.AutoSize = True
        NOKAddressLabel.Location = New System.Drawing.Point(2, 63)
        NOKAddressLabel.Name = "NOKAddressLabel"
        NOKAddressLabel.Size = New System.Drawing.Size(65, 13)
        NOKAddressLabel.TabIndex = 2
        NOKAddressLabel.Text = "Occupation:"
        '
        'NOKContactNumberLabel
        '
        NOKContactNumberLabel.AutoSize = True
        NOKContactNumberLabel.Location = New System.Drawing.Point(2, 84)
        NOKContactNumberLabel.Name = "NOKContactNumberLabel"
        NOKContactNumberLabel.Size = New System.Drawing.Size(87, 13)
        NOKContactNumberLabel.TabIndex = 4
        NOKContactNumberLabel.Text = "Contact Number:"
        '
        'NOKSurnameLabel
        '
        NOKSurnameLabel.AutoSize = True
        NOKSurnameLabel.Location = New System.Drawing.Point(2, 41)
        NOKSurnameLabel.Name = "NOKSurnameLabel"
        NOKSurnameLabel.Size = New System.Drawing.Size(68, 13)
        NOKSurnameLabel.TabIndex = 1
        NOKSurnameLabel.Text = "Relationship:"
        '
        'Residential_AdressLabel
        '
        Residential_AdressLabel.AutoSize = True
        Residential_AdressLabel.Location = New System.Drawing.Point(6, 17)
        Residential_AdressLabel.Name = "Residential_AdressLabel"
        Residential_AdressLabel.Size = New System.Drawing.Size(79, 13)
        Residential_AdressLabel.TabIndex = 0
        Residential_AdressLabel.Text = "Street Address:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(6, 106)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(76, 13)
        EmailAddressLabel.TabIndex = 4
        EmailAddressLabel.Text = "Email Address:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(6, 39)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(51, 13)
        Label21.TabIndex = 5
        Label21.Text = "Location:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(6, 61)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(27, 13)
        Label22.TabIndex = 7
        Label22.Text = "City:"
        '
        'ProgramLabel
        '
        ProgramLabel.AutoSize = True
        ProgramLabel.Location = New System.Drawing.Point(6, 20)
        ProgramLabel.Name = "ProgramLabel"
        ProgramLabel.Size = New System.Drawing.Size(49, 13)
        ProgramLabel.TabIndex = 9
        ProgramLabel.Text = "Program:"
        '
        'YearLabel1
        '
        YearLabel1.AutoSize = True
        YearLabel1.Location = New System.Drawing.Point(6, 64)
        YearLabel1.Name = "YearLabel1"
        YearLabel1.Size = New System.Drawing.Size(36, 13)
        YearLabel1.TabIndex = 10
        YearLabel1.Text = "Level:"
        '
        'Date_EnrolledLabel1
        '
        Date_EnrolledLabel1.AutoSize = True
        Date_EnrolledLabel1.Location = New System.Drawing.Point(6, 109)
        Date_EnrolledLabel1.Name = "Date_EnrolledLabel1"
        Date_EnrolledLabel1.Size = New System.Drawing.Size(74, 13)
        Date_EnrolledLabel1.TabIndex = 18
        Date_EnrolledLabel1.Text = "Date Enrolled:"
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(6, 22)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(61, 13)
        StudentIDLabel.TabIndex = 0
        StudentIDLabel.Text = "Student ID:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(180, 66)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(33, 13)
        DateOfBirthLabel.TabIndex = 3
        DateOfBirthLabel.Text = "DOB:"
        '
        'NationalIDLabel
        '
        NationalIDLabel.AutoSize = True
        NationalIDLabel.Location = New System.Drawing.Point(6, 91)
        NationalIDLabel.Name = "NationalIDLabel"
        NationalIDLabel.Size = New System.Drawing.Size(63, 13)
        NationalIDLabel.TabIndex = 12
        NationalIDLabel.Text = "National ID:"
        '
        'StudentNameLabel
        '
        StudentNameLabel.AutoSize = True
        StudentNameLabel.Location = New System.Drawing.Point(324, 44)
        StudentNameLabel.Name = "StudentNameLabel"
        StudentNameLabel.Size = New System.Drawing.Size(38, 13)
        StudentNameLabel.TabIndex = 2
        StudentNameLabel.Text = "Name:"
        '
        'StudentSurnameLabel
        '
        StudentSurnameLabel.AutoSize = True
        StudentSurnameLabel.Location = New System.Drawing.Point(6, 44)
        StudentSurnameLabel.Name = "StudentSurnameLabel"
        StudentSurnameLabel.Size = New System.Drawing.Size(52, 13)
        StudentSurnameLabel.TabIndex = 6
        StudentSurnameLabel.Text = "Surname:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Location = New System.Drawing.Point(4, 111)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(100, 13)
        ReligionLabel.TabIndex = 14
        ReligionLabel.Text = "SchoolFeesSource:"
        '
        'AccountNumberLabel
        '
        AccountNumberLabel.AutoSize = True
        AccountNumberLabel.Location = New System.Drawing.Point(6, 89)
        AccountNumberLabel.Name = "AccountNumberLabel"
        AccountNumberLabel.Size = New System.Drawing.Size(83, 13)
        AccountNumberLabel.TabIndex = 16
        AccountNumberLabel.Text = "EnrollmentType:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(6, 66)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 17
        GenderLabel.Text = "Gender:"
        '
        'PlaceOfBirthLabel
        '
        PlaceOfBirthLabel.AutoSize = True
        PlaceOfBirthLabel.Location = New System.Drawing.Point(327, 66)
        PlaceOfBirthLabel.Name = "PlaceOfBirthLabel"
        PlaceOfBirthLabel.Size = New System.Drawing.Size(75, 13)
        PlaceOfBirthLabel.TabIndex = 18
        PlaceOfBirthLabel.Text = "Place Of Birth:"
        '
        'PostDateLabel
        '
        PostDateLabel.AutoSize = True
        PostDateLabel.Location = New System.Drawing.Point(6, 135)
        PostDateLabel.Name = "PostDateLabel"
        PostDateLabel.Size = New System.Drawing.Size(57, 13)
        PostDateLabel.TabIndex = 23
        PostDateLabel.Text = "Post Date:"
        '
        'ReasonForReversalLabel
        '
        ReasonForReversalLabel.AutoSize = True
        ReasonForReversalLabel.Location = New System.Drawing.Point(3, 12)
        ReasonForReversalLabel.Name = "ReasonForReversalLabel"
        ReasonForReversalLabel.Size = New System.Drawing.Size(110, 13)
        ReasonForReversalLabel.TabIndex = 24
        ReasonForReversalLabel.Text = "Reason For Reversal:"
        '
        'Label39
        '
        Label39.AutoSize = True
        Label39.Location = New System.Drawing.Point(10, 16)
        Label39.Name = "Label39"
        Label39.Size = New System.Drawing.Size(71, 13)
        Label39.TabIndex = 0
        Label39.Text = "SchoolName:"
        '
        'Label38
        '
        Label38.AutoSize = True
        Label38.Location = New System.Drawing.Point(10, 41)
        Label38.Name = "Label38"
        Label38.Size = New System.Drawing.Size(87, 13)
        Label38.TabIndex = 2
        Label38.Text = "Contact Number:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(5, 41)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(110, 13)
        Label23.TabIndex = 5
        Label23.Text = "Doc Contact Number:"
        '
        'Label51
        '
        Label51.AutoSize = True
        Label51.Location = New System.Drawing.Point(5, 24)
        Label51.Name = "Label51"
        Label51.Size = New System.Drawing.Size(74, 13)
        Label51.TabIndex = 0
        Label51.Text = "Family Doctor:"
        '
        'Label37
        '
        Label37.AutoSize = True
        Label37.Location = New System.Drawing.Point(10, 67)
        Label37.Name = "Label37"
        Label37.Size = New System.Drawing.Size(54, 13)
        Label37.TabIndex = 4
        Label37.Text = "Comment:"
        '
        'Label53
        '
        Label53.AutoSize = True
        Label53.Location = New System.Drawing.Point(6, 84)
        Label53.Name = "Label53"
        Label53.Size = New System.Drawing.Size(87, 13)
        Label53.TabIndex = 2
        Label53.Text = "Contact Number:"
        '
        'Label57
        '
        Label57.AutoSize = True
        Label57.Location = New System.Drawing.Point(6, 42)
        Label57.Name = "Label57"
        Label57.Size = New System.Drawing.Size(35, 13)
        Label57.TabIndex = 20
        Label57.Text = "Class:"
        '
        'Label60
        '
        Label60.AutoSize = True
        Label60.Location = New System.Drawing.Point(228, 20)
        Label60.Name = "Label60"
        Label60.Size = New System.Drawing.Size(52, 13)
        Label60.TabIndex = 6
        Label60.Text = "Surname:"
        '
        'Label45
        '
        Label45.AutoSize = True
        Label45.Location = New System.Drawing.Point(5, 60)
        Label45.Name = "Label45"
        Label45.Size = New System.Drawing.Size(49, 13)
        Label45.TabIndex = 9
        Label45.Text = "Allergies:"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(5, 84)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(59, 13)
        Label20.TabIndex = 11
        Label20.Text = "Comments:"
        '
        'Label67
        '
        Label67.AutoSize = True
        Label67.Location = New System.Drawing.Point(6, 67)
        Label67.Name = "Label67"
        Label67.Size = New System.Drawing.Size(41, 13)
        Label67.TabIndex = 6
        Label67.Text = "House:"
        '
        'Label71
        '
        Label71.AutoSize = True
        Label71.Location = New System.Drawing.Point(2, 20)
        Label71.Name = "Label71"
        Label71.Size = New System.Drawing.Size(79, 13)
        Label71.TabIndex = 0
        Label71.Text = "Sports/Activity:"
        '
        'Label68
        '
        Label68.AutoSize = True
        Label68.Location = New System.Drawing.Point(6, 20)
        Label68.Name = "Label68"
        Label68.Size = New System.Drawing.Size(41, 13)
        Label68.TabIndex = 22
        Label68.Text = "Sibling:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Location = New System.Drawing.Point(195, 22)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(35, 13)
        Label26.TabIndex = 43
        Label26.Text = "Class:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(8, 107)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(96, 13)
        Label3.TabIndex = 9
        Label3.Text = "Parents/Guardians"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(6, 91)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(43, 13)
        Label9.TabIndex = 23
        Label9.Text = "Siblings"
        '
        'StudentFeesTranscationsBindingSource
        '
        Me.StudentFeesTranscationsBindingSource.DataMember = "StudentFeesTranscations"
        Me.StudentFeesTranscationsBindingSource.DataSource = Me.DsSchool
        '
        'DsSchool
        '
        Me.DsSchool.DataSetName = "dsSchool"
        Me.DsSchool.EnforceConstraints = False
        Me.DsSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripButton1.Text = "<<first"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripButton2.Text = "<previous"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripLabel4.Text = "Of "
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripButton3.Text = ">next"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripButton4.Text = ">>Last"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripButton5.Text = "Newitem"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripButton21.Text = "<<first"
        '
        'ToolStripSeparator41
        '
        Me.ToolStripSeparator41.Name = "ToolStripSeparator41"
        Me.ToolStripSeparator41.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton22
        '
        Me.ToolStripButton22.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripButton22.Text = "<previous"
        '
        'ToolStripSeparator42
        '
        Me.ToolStripSeparator42.Name = "ToolStripSeparator42"
        Me.ToolStripSeparator42.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator43
        '
        Me.ToolStripSeparator43.Name = "ToolStripSeparator43"
        Me.ToolStripSeparator43.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel13
        '
        Me.ToolStripLabel13.Name = "ToolStripLabel13"
        Me.ToolStripLabel13.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripLabel14
        '
        Me.ToolStripLabel14.Name = "ToolStripLabel14"
        Me.ToolStripLabel14.Size = New System.Drawing.Size(20, 22)
        Me.ToolStripLabel14.Text = "Of"
        '
        'ToolStripLabel15
        '
        Me.ToolStripLabel15.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripLabel15.Name = "ToolStripLabel15"
        Me.ToolStripLabel15.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripLabel15.Text = "Count"
        '
        'ToolStripButton23
        '
        Me.ToolStripButton23.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton23.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton23.Name = "ToolStripButton23"
        Me.ToolStripButton23.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripButton23.Text = ">next"
        '
        'ToolStripSeparator44
        '
        Me.ToolStripSeparator44.Name = "ToolStripSeparator44"
        Me.ToolStripSeparator44.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton24
        '
        Me.ToolStripButton24.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton24.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton24.Name = "ToolStripButton24"
        Me.ToolStripButton24.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripButton24.Text = ">>Last"
        '
        'ToolStripSeparator45
        '
        Me.ToolStripSeparator45.Name = "ToolStripSeparator45"
        Me.ToolStripSeparator45.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton25
        '
        Me.ToolStripButton25.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton25.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton25.Name = "ToolStripButton25"
        Me.ToolStripButton25.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripButton25.Text = "Newitem"
        '
        'ToolStripSeparator46
        '
        Me.ToolStripSeparator46.Name = "ToolStripSeparator46"
        Me.ToolStripSeparator46.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator47
        '
        Me.ToolStripSeparator47.Name = "ToolStripSeparator47"
        Me.ToolStripSeparator47.Size = New System.Drawing.Size(6, 25)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "home.png")
        Me.ImageList1.Images.SetKeyName(1, "Folder Yellow Search.png")
        Me.ImageList1.Images.SetKeyName(2, "Dollars.png")
        Me.ImageList1.Images.SetKeyName(3, "Links 2.png")
        Me.ImageList1.Images.SetKeyName(4, "Doc Write 2.png")
        Me.ImageList1.Images.SetKeyName(5, "Tutorials.png")
        Me.ImageList1.Images.SetKeyName(6, "Light Bulb 2.png")
        Me.ImageList1.Images.SetKeyName(7, "Green Tick 2.png")
        Me.ImageList1.Images.SetKeyName(8, "Exit 2.png")
        Me.ImageList1.Images.SetKeyName(9, "Torrent File Type 2.png")
        Me.ImageList1.Images.SetKeyName(10, "Office Building 1.png")
        Me.ImageList1.Images.SetKeyName(11, "Payment 2.png")
        Me.ImageList1.Images.SetKeyName(12, "Pen 1.png")
        Me.ImageList1.Images.SetKeyName(13, "Red Cross.png")
        Me.ImageList1.Images.SetKeyName(14, "Red Tick.png")
        Me.ImageList1.Images.SetKeyName(15, "Search 3.png")
        Me.ImageList1.Images.SetKeyName(16, "Settings 1.png")
        Me.ImageList1.Images.SetKeyName(17, "Settings 3.png")
        Me.ImageList1.Images.SetKeyName(18, "Test.png")
        Me.ImageList1.Images.SetKeyName(19, "Benchmark.png")
        Me.ImageList1.Images.SetKeyName(20, "Certificate 5.png")
        Me.ImageList1.Images.SetKeyName(21, "Payment 1.png")
        Me.ImageList1.Images.SetKeyName(22, "Payment 1.png")
        Me.ImageList1.Images.SetKeyName(23, "Upload - Transfer Photos.png")
        Me.ImageList1.Images.SetKeyName(24, "Webmail 2.png")
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.AutoScroll = True
        Me.ContentPanel.Size = New System.Drawing.Size(1133, 538)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmdRefreshPastel
        '
        Me.cmdRefreshPastel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRefreshPastel.Location = New System.Drawing.Point(2740, 638)
        Me.cmdRefreshPastel.Name = "cmdRefreshPastel"
        Me.cmdRefreshPastel.Size = New System.Drawing.Size(140, 44)
        Me.cmdRefreshPastel.TabIndex = 3
        Me.cmdRefreshPastel.Text = "RefreshPastelLink"
        Me.cmdRefreshPastel.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button21.Location = New System.Drawing.Point(2887, 638)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(140, 44)
        Me.Button21.TabIndex = 4
        Me.Button21.Text = "Refresh"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button22.Location = New System.Drawing.Point(3028, 638)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(140, 44)
        Me.Button22.TabIndex = 5
        Me.Button22.Text = "Close"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Location = New System.Drawing.Point(1474, 747)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(125, 34)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdLink
        '
        Me.cmdLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLink.Location = New System.Drawing.Point(1342, 747)
        Me.cmdLink.Name = "cmdLink"
        Me.cmdLink.Size = New System.Drawing.Size(125, 34)
        Me.cmdLink.TabIndex = 7
        Me.cmdLink.Text = "&Refresh "
        Me.cmdLink.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(1211, 747)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 34)
        Me.Button4.TabIndex = 8
        Me.Button4.Tag = " "
        Me.Button4.Text = "&Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tbBilling
        '
        Me.tbBilling.Controls.Add(Me.SplitContainer8)
        Me.tbBilling.ImageKey = "Dollars.png"
        Me.tbBilling.Location = New System.Drawing.Point(4, 23)
        Me.tbBilling.Name = "tbBilling"
        Me.tbBilling.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBilling.Size = New System.Drawing.Size(1587, 715)
        Me.tbBilling.TabIndex = 11
        Me.tbBilling.Tag = "68"
        Me.tbBilling.Text = "StudentsBilling"
        Me.tbBilling.UseVisualStyleBackColor = True
        '
        'SplitContainer8
        '
        Me.SplitContainer8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer8.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer8.Name = "SplitContainer8"
        '
        'SplitContainer8.Panel1
        '
        Me.SplitContainer8.Panel1.AutoScroll = True
        Me.SplitContainer8.Panel1.Controls.Add(Me.btnStudBillingStudentSearch)
        Me.SplitContainer8.Panel1.Controls.Add(Me.btnClearBillStuds)
        Me.SplitContainer8.Panel1.Controls.Add(Me.lbBillStud)
        Me.SplitContainer8.Panel1.Controls.Add(Me.Label44)
        Me.SplitContainer8.Panel1.Controls.Add(Me.txtBillStud)
        '
        'SplitContainer8.Panel2
        '
        Me.SplitContainer8.Panel2.AutoScroll = True
        Me.SplitContainer8.Panel2.Controls.Add(Me.Button36)
        Me.SplitContainer8.Panel2.Controls.Add(Me.Button26)
        Me.SplitContainer8.Panel2.Controls.Add(Me.lbBillSearch)
        Me.SplitContainer8.Panel2.Controls.Add(Me.Label83)
        Me.SplitContainer8.Panel2.Controls.Add(Me.txtStudBillSearch)
        Me.SplitContainer8.Panel2.Controls.Add(Me.CheckBox2)
        Me.SplitContainer8.Panel2.Controls.Add(Me.btnPerfomBilling)
        Me.SplitContainer8.Panel2.Controls.Add(Me.GroupBox11)
        Me.SplitContainer8.Panel2.Controls.Add(Me.dgBilling)
        Me.SplitContainer8.Panel2.Controls.Add(Me.GroupBox12)
        Me.SplitContainer8.Size = New System.Drawing.Size(1581, 709)
        Me.SplitContainer8.SplitterDistance = 243
        Me.SplitContainer8.SplitterWidth = 1
        Me.SplitContainer8.TabIndex = 0
        '
        'btnStudBillingStudentSearch
        '
        Me.btnStudBillingStudentSearch.BackgroundImage = Global.StudentDetails.My.Resources.Resources.search
        Me.btnStudBillingStudentSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStudBillingStudentSearch.Location = New System.Drawing.Point(164, 248)
        Me.btnStudBillingStudentSearch.Name = "btnStudBillingStudentSearch"
        Me.btnStudBillingStudentSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnStudBillingStudentSearch.TabIndex = 18
        Me.btnStudBillingStudentSearch.UseVisualStyleBackColor = True
        '
        'btnClearBillStuds
        '
        Me.btnClearBillStuds.Location = New System.Drawing.Point(48, 195)
        Me.btnClearBillStuds.Name = "btnClearBillStuds"
        Me.btnClearBillStuds.Size = New System.Drawing.Size(75, 23)
        Me.btnClearBillStuds.TabIndex = 15
        Me.btnClearBillStuds.Text = "Clear"
        Me.btnClearBillStuds.UseVisualStyleBackColor = True
        '
        'lbBillStud
        '
        Me.lbBillStud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbBillStud.DisplayMember = "StudName"
        Me.lbBillStud.FormattingEnabled = True
        Me.lbBillStud.Location = New System.Drawing.Point(25, 274)
        Me.lbBillStud.Name = "lbBillStud"
        Me.lbBillStud.Size = New System.Drawing.Size(213, 134)
        Me.lbBillStud.TabIndex = 14
        Me.lbBillStud.ValueMember = "StudentID"
        Me.lbBillStud.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(45, 232)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(89, 13)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "IndividualStudent"
        '
        'txtBillStud
        '
        Me.txtBillStud.Location = New System.Drawing.Point(25, 248)
        Me.txtBillStud.Name = "txtBillStud"
        Me.txtBillStud.Size = New System.Drawing.Size(142, 20)
        Me.txtBillStud.TabIndex = 12
        '
        'Button36
        '
        Me.Button36.BackColor = System.Drawing.Color.Green
        Me.Button36.ForeColor = System.Drawing.Color.White
        Me.Button36.Location = New System.Drawing.Point(5, 12)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(75, 41)
        Me.Button36.TabIndex = 54
        Me.Button36.Text = "Hide Search Panel"
        Me.Button36.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(262, 518)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(123, 38)
        Me.Button26.TabIndex = 52
        Me.Button26.Text = "Import Invoices"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'lbBillSearch
        '
        Me.lbBillSearch.BackColor = System.Drawing.Color.LightYellow
        Me.lbBillSearch.DisplayMember = "StudName"
        Me.lbBillSearch.ForeColor = System.Drawing.Color.Black
        Me.lbBillSearch.FormattingEnabled = True
        Me.lbBillSearch.Location = New System.Drawing.Point(603, 99)
        Me.lbBillSearch.Name = "lbBillSearch"
        Me.lbBillSearch.Size = New System.Drawing.Size(278, 238)
        Me.lbBillSearch.TabIndex = 51
        Me.lbBillSearch.ValueMember = "StudentID"
        Me.lbBillSearch.Visible = False
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(516, 81)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(81, 13)
        Me.Label83.TabIndex = 50
        Me.Label83.Text = "StudentSearch:"
        '
        'txtStudBillSearch
        '
        Me.txtStudBillSearch.Location = New System.Drawing.Point(603, 78)
        Me.txtStudBillSearch.Name = "txtStudBillSearch"
        Me.txtStudBillSearch.Size = New System.Drawing.Size(233, 20)
        Me.txtStudBillSearch.TabIndex = 49
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(708, 530)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox2.TabIndex = 28
        Me.CheckBox2.Text = "SelectAll"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'btnPerfomBilling
        '
        Me.btnPerfomBilling.Location = New System.Drawing.Point(84, 518)
        Me.btnPerfomBilling.Name = "btnPerfomBilling"
        Me.btnPerfomBilling.Size = New System.Drawing.Size(123, 38)
        Me.btnPerfomBilling.TabIndex = 0
        Me.btnPerfomBilling.Text = "Perfom Billing"
        Me.btnPerfomBilling.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox11.Controls.Add(Me.dgPayType)
        Me.GroupBox11.Controls.Add(Me.chkBilPeriods)
        Me.GroupBox11.Controls.Add(Label43)
        Me.GroupBox11.Controls.Add(Me.cboBillType)
        Me.GroupBox11.Location = New System.Drawing.Point(5, 81)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(505, 413)
        Me.GroupBox11.TabIndex = 26
        Me.GroupBox11.TabStop = False
        '
        'dgPayType
        '
        Me.dgPayType.AllowUserToAddRows = False
        Me.dgPayType.AllowUserToDeleteRows = False
        Me.dgPayType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPayType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPayType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Payment, Me.BillingAmount})
        Me.dgPayType.Location = New System.Drawing.Point(119, 245)
        Me.dgPayType.Name = "dgPayType"
        Me.dgPayType.Size = New System.Drawing.Size(246, 153)
        Me.dgPayType.TabIndex = 30
        '
        'Payment
        '
        Me.Payment.DataPropertyName = "Payment"
        Me.Payment.DataSource = Me.FeesPaymentTypeBindingSource
        Me.Payment.DisplayMember = "Payment"
        Me.Payment.HeaderText = "Payment"
        Me.Payment.Name = "Payment"
        Me.Payment.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Payment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Payment.ValueMember = "Payment"
        '
        'FeesPaymentTypeBindingSource
        '
        Me.FeesPaymentTypeBindingSource.DataMember = "FeesPaymentType"
        Me.FeesPaymentTypeBindingSource.DataSource = Me.DsSchool
        '
        'BillingAmount
        '
        Me.BillingAmount.DataPropertyName = "Amount"
        Me.BillingAmount.HeaderText = "Amount"
        Me.BillingAmount.Name = "BillingAmount"
        '
        'chkBilPeriods
        '
        Me.chkBilPeriods.FormattingEnabled = True
        Me.chkBilPeriods.Location = New System.Drawing.Point(79, 40)
        Me.chkBilPeriods.Name = "chkBilPeriods"
        Me.chkBilPeriods.ScrollAlwaysVisible = True
        Me.chkBilPeriods.Size = New System.Drawing.Size(301, 184)
        Me.chkBilPeriods.TabIndex = 27
        '
        'cboBillType
        '
        Me.cboBillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBillType.FormattingEnabled = True
        Me.cboBillType.Items.AddRange(New Object() {"Combined", "Normal", "PerSubject", "Reversal"})
        Me.cboBillType.Location = New System.Drawing.Point(134, 13)
        Me.cboBillType.Name = "cboBillType"
        Me.cboBillType.Size = New System.Drawing.Size(128, 21)
        Me.cboBillType.Sorted = True
        Me.cboBillType.TabIndex = 0
        '
        'dgBilling
        '
        Me.dgBilling.AllowUserToAddRows = False
        Me.dgBilling.AllowUserToDeleteRows = False
        Me.dgBilling.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBilling.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBilling.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillingStudentID, Me.BillingStudName, Me.BillingEnrolRef})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgBilling.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgBilling.GridColor = System.Drawing.Color.LightSteelBlue
        Me.dgBilling.Location = New System.Drawing.Point(576, 142)
        Me.dgBilling.Name = "dgBilling"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBilling.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgBilling.Size = New System.Drawing.Size(260, 382)
        Me.dgBilling.TabIndex = 25
        '
        'BillingStudentID
        '
        Me.BillingStudentID.DataPropertyName = "StudentID"
        Me.BillingStudentID.HeaderText = "StudentID"
        Me.BillingStudentID.Name = "BillingStudentID"
        '
        'BillingStudName
        '
        Me.BillingStudName.DataPropertyName = "StudName"
        Me.BillingStudName.HeaderText = "StudentName"
        Me.BillingStudName.Name = "BillingStudName"
        '
        'BillingEnrolRef
        '
        Me.BillingEnrolRef.DataPropertyName = "EnrolRef"
        Me.BillingEnrolRef.HeaderText = "Ref"
        Me.BillingEnrolRef.Name = "BillingEnrolRef"
        Me.BillingEnrolRef.Visible = False
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox12.Controls.Add(Me.btnBillingClass)
        Me.GroupBox12.Controls.Add(Me.Label10)
        Me.GroupBox12.Controls.Add(Me.cboBillingClass)
        Me.GroupBox12.Controls.Add(Me.cboBillingSess)
        Me.GroupBox12.Controls.Add(Me.Label62)
        Me.GroupBox12.Controls.Add(Me.cboBillingLevel)
        Me.GroupBox12.Controls.Add(Me.Label64)
        Me.GroupBox12.Controls.Add(Me.cboBillingProg)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(84, 12)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(812, 44)
        Me.GroupBox12.TabIndex = 24
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Class_Search"
        '
        'btnBillingClass
        '
        Me.btnBillingClass.Location = New System.Drawing.Point(641, 11)
        Me.btnBillingClass.Name = "btnBillingClass"
        Me.btnBillingClass.Size = New System.Drawing.Size(129, 27)
        Me.btnBillingClass.TabIndex = 27
        Me.btnBillingClass.Text = "Refresh Class List"
        Me.btnBillingClass.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(454, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Class:"
        '
        'cboBillingClass
        '
        Me.cboBillingClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBillingClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBillingClass.FormattingEnabled = True
        Me.cboBillingClass.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November ", "December"})
        Me.cboBillingClass.Location = New System.Drawing.Point(501, 14)
        Me.cboBillingClass.Name = "cboBillingClass"
        Me.cboBillingClass.Size = New System.Drawing.Size(112, 21)
        Me.cboBillingClass.TabIndex = 25
        '
        'cboBillingSess
        '
        Me.cboBillingSess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBillingSess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBillingSess.DisplayMember = "Session"
        Me.cboBillingSess.FormattingEnabled = True
        Me.cboBillingSess.Location = New System.Drawing.Point(330, 14)
        Me.cboBillingSess.Name = "cboBillingSess"
        Me.cboBillingSess.Size = New System.Drawing.Size(118, 21)
        Me.cboBillingSess.TabIndex = 5
        Me.cboBillingSess.ValueMember = "Session"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(209, 17)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(42, 13)
        Me.Label62.TabIndex = 22
        Me.Label62.Text = "Level:"
        '
        'cboBillingLevel
        '
        Me.cboBillingLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBillingLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBillingLevel.FormattingEnabled = True
        Me.cboBillingLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboBillingLevel.Location = New System.Drawing.Point(257, 14)
        Me.cboBillingLevel.Name = "cboBillingLevel"
        Me.cboBillingLevel.Size = New System.Drawing.Size(67, 21)
        Me.cboBillingLevel.TabIndex = 2
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(25, 17)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(57, 13)
        Me.Label64.TabIndex = 17
        Me.Label64.Text = "Program:"
        '
        'cboBillingProg
        '
        Me.cboBillingProg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBillingProg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBillingProg.FormattingEnabled = True
        Me.cboBillingProg.Items.AddRange(New Object() {"2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboBillingProg.Location = New System.Drawing.Point(99, 14)
        Me.cboBillingProg.Name = "cboBillingProg"
        Me.cboBillingProg.Size = New System.Drawing.Size(104, 21)
        Me.cboBillingProg.TabIndex = 1
        '
        'tbClassTRansferring
        '
        Me.tbClassTRansferring.AutoScroll = True
        Me.tbClassTRansferring.Controls.Add(Me.SplitContainer7)
        Me.tbClassTRansferring.ImageKey = "Upload - Transfer Photos.png"
        Me.tbClassTRansferring.Location = New System.Drawing.Point(4, 23)
        Me.tbClassTRansferring.Name = "tbClassTRansferring"
        Me.tbClassTRansferring.Padding = New System.Windows.Forms.Padding(3)
        Me.tbClassTRansferring.Size = New System.Drawing.Size(1587, 715)
        Me.tbClassTRansferring.TabIndex = 10
        Me.tbClassTRansferring.Tag = "82"
        Me.tbClassTRansferring.Text = "Class Transferring"
        Me.tbClassTRansferring.UseVisualStyleBackColor = True
        '
        'SplitContainer7
        '
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer7.Name = "SplitContainer7"
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.AutoScroll = True
        Me.SplitContainer7.Panel1.Controls.Add(Me.Button25)
        Me.SplitContainer7.Panel1.Controls.Add(Me.chkMaintainPrevSubjects)
        Me.SplitContainer7.Panel1.Controls.Add(Me.lbStudDeactivationSearch)
        Me.SplitContainer7.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer7.Panel1.Controls.Add(Me.Chkmitype)
        Me.SplitContainer7.Panel1.Controls.Add(Me.Button19)
        Me.SplitContainer7.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer7.Panel1.Controls.Add(Me.Label95)
        Me.SplitContainer7.Panel1.Controls.Add(Me.chknewclass)
        Me.SplitContainer7.Panel1.Controls.Add(Me.txtDeactivationStudSearch)
        Me.SplitContainer7.Panel1.Controls.Add(Me.btnLeavingStudent)
        Me.SplitContainer7.Panel1.Controls.Add(Me.chkoldclass)
        Me.SplitContainer7.Panel1.Controls.Add(Me.chkSelectOldClassStuds)
        Me.SplitContainer7.Panel1.Controls.Add(Me.gbActPerClass)
        Me.SplitContainer7.Panel1.Controls.Add(Me.Button24)
        Me.SplitContainer7.Panel1.Controls.Add(Me.Button18)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.AutoScroll = True
        Me.SplitContainer7.Panel2Collapsed = True
        Me.SplitContainer7.Size = New System.Drawing.Size(1581, 709)
        Me.SplitContainer7.SplitterDistance = 1057
        Me.SplitContainer7.SplitterWidth = 1
        Me.SplitContainer7.TabIndex = 0
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(987, 624)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(90, 42)
        Me.Button25.TabIndex = 27
        Me.Button25.Text = "Clear Items"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'chkMaintainPrevSubjects
        '
        Me.chkMaintainPrevSubjects.AutoSize = True
        Me.chkMaintainPrevSubjects.Checked = True
        Me.chkMaintainPrevSubjects.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMaintainPrevSubjects.Location = New System.Drawing.Point(812, 635)
        Me.chkMaintainPrevSubjects.Name = "chkMaintainPrevSubjects"
        Me.chkMaintainPrevSubjects.Size = New System.Drawing.Size(175, 17)
        Me.chkMaintainPrevSubjects.TabIndex = 28
        Me.chkMaintainPrevSubjects.Text = "Maintain Current Class Subjects"
        Me.chkMaintainPrevSubjects.UseVisualStyleBackColor = True
        '
        'lbStudDeactivationSearch
        '
        Me.lbStudDeactivationSearch.BackColor = System.Drawing.Color.LightYellow
        Me.lbStudDeactivationSearch.FormattingEnabled = True
        Me.lbStudDeactivationSearch.Location = New System.Drawing.Point(91, 120)
        Me.lbStudDeactivationSearch.Name = "lbStudDeactivationSearch"
        Me.lbStudDeactivationSearch.Size = New System.Drawing.Size(229, 225)
        Me.lbStudDeactivationSearch.TabIndex = 44
        Me.lbStudDeactivationSearch.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbonewClassCls)
        Me.GroupBox1.Controls.Add(Me.Label82)
        Me.GroupBox1.Controls.Add(Me.cbonewclassprog)
        Me.GroupBox1.Controls.Add(Me.cbonewclassSess)
        Me.GroupBox1.Controls.Add(Me.Label78)
        Me.GroupBox1.Controls.Add(Me.cbonewclassform)
        Me.GroupBox1.Location = New System.Drawing.Point(589, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 43)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Class"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Class:"
        '
        'cbonewClassCls
        '
        Me.cbonewClassCls.FormattingEnabled = True
        Me.cbonewClassCls.Location = New System.Drawing.Point(398, 16)
        Me.cbonewClassCls.Name = "cbonewClassCls"
        Me.cbonewClassCls.Size = New System.Drawing.Size(154, 21)
        Me.cbonewClassCls.TabIndex = 18
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(6, 21)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(32, 13)
        Me.Label82.TabIndex = 17
        Me.Label82.Text = "Prog:"
        '
        'cbonewclassprog
        '
        Me.cbonewclassprog.DisplayMember = "Description"
        Me.cbonewclassprog.FormattingEnabled = True
        Me.cbonewclassprog.Location = New System.Drawing.Point(44, 16)
        Me.cbonewclassprog.Name = "cbonewclassprog"
        Me.cbonewclassprog.Size = New System.Drawing.Size(132, 21)
        Me.cbonewclassprog.TabIndex = 16
        Me.cbonewclassprog.ValueMember = "Forms"
        '
        'cbonewclassSess
        '
        Me.cbonewclassSess.DisplayMember = "Session"
        Me.cbonewclassSess.FormattingEnabled = True
        Me.cbonewclassSess.Location = New System.Drawing.Point(293, 16)
        Me.cbonewclassSess.Name = "cbonewclassSess"
        Me.cbonewclassSess.Size = New System.Drawing.Size(59, 21)
        Me.cbonewclassSess.TabIndex = 4
        Me.cbonewclassSess.ValueMember = "Session"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(182, 21)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(36, 13)
        Me.Label78.TabIndex = 9
        Me.Label78.Text = "Level:"
        '
        'cbonewclassform
        '
        Me.cbonewclassform.FormattingEnabled = True
        Me.cbonewclassform.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cbonewclassform.Location = New System.Drawing.Point(231, 16)
        Me.cbonewclassform.Name = "cbonewclassform"
        Me.cbonewclassform.Size = New System.Drawing.Size(56, 21)
        Me.cbonewclassform.TabIndex = 2
        '
        'Chkmitype
        '
        Me.Chkmitype.AutoSize = True
        Me.Chkmitype.Checked = True
        Me.Chkmitype.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chkmitype.Location = New System.Drawing.Point(600, 624)
        Me.Chkmitype.Name = "Chkmitype"
        Me.Chkmitype.Size = New System.Drawing.Size(98, 17)
        Me.Chkmitype.TabIndex = 26
        Me.Chkmitype.Text = "Keep Old Class"
        Me.Chkmitype.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(704, 621)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(102, 42)
        Me.Button19.TabIndex = 21
        Me.Button19.Text = "Transfer"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(289, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 20)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Clear Items"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(12, 97)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(78, 13)
        Me.Label95.TabIndex = 41
        Me.Label95.Text = "StudentSearch"
        '
        'chknewclass
        '
        Me.chknewclass.FormattingEnabled = True
        Me.chknewclass.Location = New System.Drawing.Point(600, 119)
        Me.chknewclass.Name = "chknewclass"
        Me.chknewclass.Size = New System.Drawing.Size(413, 499)
        Me.chknewclass.TabIndex = 23
        '
        'txtDeactivationStudSearch
        '
        Me.txtDeactivationStudSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDeactivationStudSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtDeactivationStudSearch.Location = New System.Drawing.Point(91, 94)
        Me.txtDeactivationStudSearch.Name = "txtDeactivationStudSearch"
        Me.txtDeactivationStudSearch.Size = New System.Drawing.Size(173, 20)
        Me.txtDeactivationStudSearch.TabIndex = 40
        '
        'btnLeavingStudent
        '
        Me.btnLeavingStudent.Location = New System.Drawing.Point(439, 378)
        Me.btnLeavingStudent.Name = "btnLeavingStudent"
        Me.btnLeavingStudent.Size = New System.Drawing.Size(134, 64)
        Me.btnLeavingStudent.TabIndex = 25
        Me.btnLeavingStudent.Text = "Leaving Institution"
        Me.btnLeavingStudent.UseVisualStyleBackColor = True
        '
        'chkoldclass
        '
        Me.chkoldclass.FormattingEnabled = True
        Me.chkoldclass.Location = New System.Drawing.Point(6, 119)
        Me.chkoldclass.Name = "chkoldclass"
        Me.chkoldclass.Size = New System.Drawing.Size(413, 499)
        Me.chkoldclass.TabIndex = 23
        '
        'chkSelectOldClassStuds
        '
        Me.chkSelectOldClassStuds.AutoSize = True
        Me.chkSelectOldClassStuds.Location = New System.Drawing.Point(6, 635)
        Me.chkSelectOldClassStuds.Name = "chkSelectOldClassStuds"
        Me.chkSelectOldClassStuds.Size = New System.Drawing.Size(115, 17)
        Me.chkSelectOldClassStuds.TabIndex = 24
        Me.chkSelectOldClassStuds.Text = "Select All Students"
        Me.chkSelectOldClassStuds.UseVisualStyleBackColor = True
        '
        'gbActPerClass
        '
        Me.gbActPerClass.Controls.Add(Me.Label81)
        Me.gbActPerClass.Controls.Add(Me.cboOldClassprog)
        Me.gbActPerClass.Controls.Add(Me.cboOldClassSess)
        Me.gbActPerClass.Controls.Add(Me.cboOldClassCls)
        Me.gbActPerClass.Controls.Add(Me.Label48)
        Me.gbActPerClass.Controls.Add(Me.cboOldclassForm)
        Me.gbActPerClass.Controls.Add(Me.Label46)
        Me.gbActPerClass.Location = New System.Drawing.Point(6, 41)
        Me.gbActPerClass.Name = "gbActPerClass"
        Me.gbActPerClass.Size = New System.Drawing.Size(577, 43)
        Me.gbActPerClass.TabIndex = 19
        Me.gbActPerClass.TabStop = False
        Me.gbActPerClass.Text = "Current Class"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(6, 21)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(32, 13)
        Me.Label81.TabIndex = 15
        Me.Label81.Text = "Prog:"
        '
        'cboOldClassprog
        '
        Me.cboOldClassprog.DisplayMember = "Description"
        Me.cboOldClassprog.FormattingEnabled = True
        Me.cboOldClassprog.Location = New System.Drawing.Point(44, 18)
        Me.cboOldClassprog.Name = "cboOldClassprog"
        Me.cboOldClassprog.Size = New System.Drawing.Size(132, 21)
        Me.cboOldClassprog.TabIndex = 14
        Me.cboOldClassprog.ValueMember = "Forms"
        '
        'cboOldClassSess
        '
        Me.cboOldClassSess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOldClassSess.DisplayMember = "Session"
        Me.cboOldClassSess.FormattingEnabled = True
        Me.cboOldClassSess.Location = New System.Drawing.Point(288, 18)
        Me.cboOldClassSess.Name = "cboOldClassSess"
        Me.cboOldClassSess.Size = New System.Drawing.Size(59, 21)
        Me.cboOldClassSess.TabIndex = 4
        Me.cboOldClassSess.ValueMember = "Session"
        '
        'cboOldClassCls
        '
        Me.cboOldClassCls.FormattingEnabled = True
        Me.cboOldClassCls.Location = New System.Drawing.Point(410, 18)
        Me.cboOldClassCls.Name = "cboOldClassCls"
        Me.cboOldClassCls.Size = New System.Drawing.Size(154, 21)
        Me.cboOldClassCls.TabIndex = 3
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(369, 19)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(35, 13)
        Me.Label48.TabIndex = 11
        Me.Label48.Text = "Class:"
        '
        'cboOldclassForm
        '
        Me.cboOldclassForm.FormattingEnabled = True
        Me.cboOldclassForm.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboOldclassForm.Location = New System.Drawing.Point(226, 18)
        Me.cboOldclassForm.Name = "cboOldclassForm"
        Me.cboOldclassForm.Size = New System.Drawing.Size(56, 21)
        Me.cboOldclassForm.TabIndex = 2
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(187, 21)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(36, 13)
        Me.Label46.TabIndex = 9
        Me.Label46.Text = "Level:"
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(439, 308)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(134, 64)
        Me.Button24.TabIndex = 22
        Me.Button24.Text = "<<"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(437, 238)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(136, 64)
        Me.Button18.TabIndex = 21
        Me.Button18.Text = ">>"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'tbSMS
        '
        Me.tbSMS.Controls.Add(Me.SplitContainer10)
        Me.tbSMS.ImageKey = "Webmail 2.png"
        Me.tbSMS.Location = New System.Drawing.Point(4, 23)
        Me.tbSMS.Name = "tbSMS"
        Me.tbSMS.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSMS.Size = New System.Drawing.Size(1587, 715)
        Me.tbSMS.TabIndex = 9
        Me.tbSMS.Tag = "16"
        Me.tbSMS.Text = "Student SMS  Notification"
        Me.tbSMS.UseVisualStyleBackColor = True
        '
        'SplitContainer10
        '
        Me.SplitContainer10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer10.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer10.Name = "SplitContainer10"
        '
        'SplitContainer10.Panel1
        '
        Me.SplitContainer10.Panel1.Controls.Add(Me.Button27)
        Me.SplitContainer10.Panel1.Controls.Add(Me.lbStudNotif)
        Me.SplitContainer10.Panel1.Controls.Add(Me.Label34)
        Me.SplitContainer10.Panel1.Controls.Add(Me.txtStudNotif)
        Me.SplitContainer10.Panel1.Controls.Add(Me.othernot)
        '
        'SplitContainer10.Panel2
        '
        Me.SplitContainer10.Panel2.AutoScroll = True
        Me.SplitContainer10.Panel2.Controls.Add(Me.Button38)
        Me.SplitContainer10.Panel2.Controls.Add(Me.GroupBox14)
        Me.SplitContainer10.Panel2.Controls.Add(Me.Button17)
        Me.SplitContainer10.Panel2.Controls.Add(Me.Button16)
        Me.SplitContainer10.Panel2.Controls.Add(Me.Button15)
        Me.SplitContainer10.Panel2.Controls.Add(Me.Button14)
        Me.SplitContainer10.Panel2.Controls.Add(Me.characters)
        Me.SplitContainer10.Panel2.Controls.Add(Me.specific)
        Me.SplitContainer10.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer10.Panel2.Controls.Add(Me.RichTextBox)
        Me.SplitContainer10.Size = New System.Drawing.Size(1581, 709)
        Me.SplitContainer10.SplitterDistance = 288
        Me.SplitContainer10.SplitterWidth = 1
        Me.SplitContainer10.TabIndex = 0
        Me.SplitContainer10.Tag = "16"
        '
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(59, 176)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(107, 34)
        Me.Button27.TabIndex = 14
        Me.Button27.Text = "Clear Search"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'lbStudNotif
        '
        Me.lbStudNotif.FormattingEnabled = True
        Me.lbStudNotif.Location = New System.Drawing.Point(38, 262)
        Me.lbStudNotif.Name = "lbStudNotif"
        Me.lbStudNotif.Size = New System.Drawing.Size(185, 147)
        Me.lbStudNotif.TabIndex = 13
        Me.lbStudNotif.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(68, 220)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(89, 13)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "IndividualStudent"
        '
        'txtStudNotif
        '
        Me.txtStudNotif.Location = New System.Drawing.Point(48, 236)
        Me.txtStudNotif.Name = "txtStudNotif"
        Me.txtStudNotif.Size = New System.Drawing.Size(142, 20)
        Me.txtStudNotif.TabIndex = 11
        '
        'othernot
        '
        Me.othernot.Controls.Add(Me.Button10)
        Me.othernot.Location = New System.Drawing.Point(21, 101)
        Me.othernot.Name = "othernot"
        Me.othernot.Size = New System.Drawing.Size(202, 58)
        Me.othernot.TabIndex = 7
        Me.othernot.TabStop = False
        Me.othernot.Text = "Other Notifications"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(18, 21)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(169, 25)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "Credit Balance"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button38
        '
        Me.Button38.BackColor = System.Drawing.Color.Green
        Me.Button38.ForeColor = System.Drawing.Color.White
        Me.Button38.Location = New System.Drawing.Point(15, 16)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(75, 41)
        Me.Button38.TabIndex = 55
        Me.Button38.Text = "Hide Search Panel"
        Me.Button38.UseVisualStyleBackColor = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.cboSmsClubs)
        Me.GroupBox14.Controls.Add(Me.Label13)
        Me.GroupBox14.Controls.Add(Me.rbSmsGroups)
        Me.GroupBox14.Controls.Add(Me.cboSchoolSections)
        Me.GroupBox14.Controls.Add(Me.rbsmsSection)
        Me.GroupBox14.Controls.Add(Me.rbSmsNotAtDb)
        Me.GroupBox14.Controls.Add(Me.Label33)
        Me.GroupBox14.Controls.Add(Me.rbsmsClass)
        Me.GroupBox14.Location = New System.Drawing.Point(582, 8)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(340, 144)
        Me.GroupBox14.TabIndex = 23
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "GroupOptions"
        '
        'cboSmsClubs
        '
        Me.cboSmsClubs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSmsClubs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSmsClubs.DisplayMember = "club"
        Me.cboSmsClubs.Enabled = False
        Me.cboSmsClubs.FormattingEnabled = True
        Me.cboSmsClubs.Location = New System.Drawing.Point(219, 105)
        Me.cboSmsClubs.Name = "cboSmsClubs"
        Me.cboSmsClubs.Size = New System.Drawing.Size(105, 21)
        Me.cboSmsClubs.TabIndex = 27
        Me.cboSmsClubs.ValueMember = "club"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(177, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Clubs:"
        '
        'rbSmsGroups
        '
        Me.rbSmsGroups.AutoSize = True
        Me.rbSmsGroups.Location = New System.Drawing.Point(17, 88)
        Me.rbSmsGroups.Name = "rbSmsGroups"
        Me.rbSmsGroups.Size = New System.Drawing.Size(161, 17)
        Me.rbSmsGroups.TabIndex = 26
        Me.rbSmsGroups.TabStop = True
        Me.rbSmsGroups.Text = "SendToSchoolGroups/Clubs"
        Me.rbSmsGroups.UseVisualStyleBackColor = True
        '
        'cboSchoolSections
        '
        Me.cboSchoolSections.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSchoolSections.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSchoolSections.Enabled = False
        Me.cboSchoolSections.FormattingEnabled = True
        Me.cboSchoolSections.Items.AddRange(New Object() {"IT", "Business School", "High School"})
        Me.cboSchoolSections.Location = New System.Drawing.Point(54, 110)
        Me.cboSchoolSections.Name = "cboSchoolSections"
        Me.cboSchoolSections.Size = New System.Drawing.Size(117, 21)
        Me.cboSchoolSections.TabIndex = 18
        '
        'rbsmsSection
        '
        Me.rbsmsSection.AutoSize = True
        Me.rbsmsSection.Location = New System.Drawing.Point(17, 65)
        Me.rbsmsSection.Name = "rbsmsSection"
        Me.rbsmsSection.Size = New System.Drawing.Size(127, 17)
        Me.rbsmsSection.TabIndex = 25
        Me.rbsmsSection.TabStop = True
        Me.rbsmsSection.Text = "SendToWholeSchool"
        Me.rbsmsSection.UseVisualStyleBackColor = True
        '
        'rbSmsNotAtDb
        '
        Me.rbSmsNotAtDb.AutoSize = True
        Me.rbSmsNotAtDb.Location = New System.Drawing.Point(17, 42)
        Me.rbSmsNotAtDb.Name = "rbSmsNotAtDb"
        Me.rbSmsNotAtDb.Size = New System.Drawing.Size(179, 17)
        Me.rbSmsNotAtDb.TabIndex = 24
        Me.rbSmsNotAtDb.TabStop = True
        Me.rbSmsNotAtDb.Text = "SendToIndividualsNotInDatabse"
        Me.rbSmsNotAtDb.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(2, 113)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(46, 13)
        Me.Label33.TabIndex = 19
        Me.Label33.Text = "Section:"
        '
        'rbsmsClass
        '
        Me.rbsmsClass.AutoSize = True
        Me.rbsmsClass.Location = New System.Drawing.Point(17, 19)
        Me.rbsmsClass.Name = "rbsmsClass"
        Me.rbsmsClass.Size = New System.Drawing.Size(166, 17)
        Me.rbsmsClass.TabIndex = 23
        Me.rbsmsClass.TabStop = True
        Me.rbsmsClass.Text = "SendToIndvidualsInDatabase"
        Me.rbsmsClass.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(303, 158)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(111, 39)
        Me.Button17.TabIndex = 11
        Me.Button17.Text = "UploadFromExternal"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(217, 158)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(80, 39)
        Me.Button16.TabIndex = 10
        Me.Button16.Text = "Clear Text Box"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(131, 158)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(80, 39)
        Me.Button15.TabIndex = 9
        Me.Button15.Text = "Save Message"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(45, 158)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(80, 39)
        Me.Button14.TabIndex = 8
        Me.Button14.Text = "Upload Saved Message"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'characters
        '
        Me.characters.AutoSize = True
        Me.characters.BackColor = System.Drawing.Color.Black
        Me.characters.ForeColor = System.Drawing.Color.White
        Me.characters.Location = New System.Drawing.Point(79, 134)
        Me.characters.Name = "characters"
        Me.characters.Size = New System.Drawing.Size(0, 13)
        Me.characters.TabIndex = 7
        '
        'specific
        '
        Me.specific.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.specific.Controls.Add(Me.CheckBox4)
        Me.specific.Controls.Add(Me.gbSendingOptions)
        Me.specific.Controls.Add(Me.gbFeesSms)
        Me.specific.Controls.Add(Me.dgClassList)
        Me.specific.Controls.Add(Me.Button6)
        Me.specific.Controls.Add(Me.GroupBox13)
        Me.specific.Location = New System.Drawing.Point(15, 221)
        Me.specific.Name = "specific"
        Me.specific.Size = New System.Drawing.Size(950, 367)
        Me.specific.TabIndex = 5
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(408, 327)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(109, 17)
        Me.CheckBox4.TabIndex = 26
        Me.CheckBox4.Text = "SelectAllStudents"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'gbSendingOptions
        '
        Me.gbSendingOptions.Controls.Add(Me.rbStudOnly)
        Me.gbSendingOptions.Controls.Add(Me.rbBoth)
        Me.gbSendingOptions.Controls.Add(Me.rbNextOfKinOnly)
        Me.gbSendingOptions.Location = New System.Drawing.Point(528, 307)
        Me.gbSendingOptions.Name = "gbSendingOptions"
        Me.gbSendingOptions.Size = New System.Drawing.Size(257, 48)
        Me.gbSendingOptions.TabIndex = 25
        Me.gbSendingOptions.TabStop = False
        Me.gbSendingOptions.Text = "SendingOptions"
        '
        'rbStudOnly
        '
        Me.rbStudOnly.AutoSize = True
        Me.rbStudOnly.Checked = True
        Me.rbStudOnly.Location = New System.Drawing.Point(6, 19)
        Me.rbStudOnly.Name = "rbStudOnly"
        Me.rbStudOnly.Size = New System.Drawing.Size(83, 17)
        Me.rbStudOnly.TabIndex = 22
        Me.rbStudOnly.TabStop = True
        Me.rbStudOnly.Text = "StudentOnly"
        Me.rbStudOnly.UseVisualStyleBackColor = True
        '
        'rbBoth
        '
        Me.rbBoth.AutoSize = True
        Me.rbBoth.Location = New System.Drawing.Point(184, 17)
        Me.rbBoth.Name = "rbBoth"
        Me.rbBoth.Size = New System.Drawing.Size(47, 17)
        Me.rbBoth.TabIndex = 24
        Me.rbBoth.Text = "Both"
        Me.rbBoth.UseVisualStyleBackColor = True
        '
        'rbNextOfKinOnly
        '
        Me.rbNextOfKinOnly.AutoSize = True
        Me.rbNextOfKinOnly.Location = New System.Drawing.Point(95, 17)
        Me.rbNextOfKinOnly.Name = "rbNextOfKinOnly"
        Me.rbNextOfKinOnly.Size = New System.Drawing.Size(72, 17)
        Me.rbNextOfKinOnly.TabIndex = 23
        Me.rbNextOfKinOnly.Text = "NOK Only"
        Me.rbNextOfKinOnly.UseVisualStyleBackColor = True
        '
        'gbFeesSms
        '
        Me.gbFeesSms.Controls.Add(Me.chkDebtorsOnly)
        Me.gbFeesSms.Controls.Add(Me.Button20)
        Me.gbFeesSms.Enabled = False
        Me.gbFeesSms.Location = New System.Drawing.Point(13, 302)
        Me.gbFeesSms.Name = "gbFeesSms"
        Me.gbFeesSms.Size = New System.Drawing.Size(253, 58)
        Me.gbFeesSms.TabIndex = 8
        Me.gbFeesSms.TabStop = False
        '
        'chkDebtorsOnly
        '
        Me.chkDebtorsOnly.AutoSize = True
        Me.chkDebtorsOnly.Location = New System.Drawing.Point(150, 32)
        Me.chkDebtorsOnly.Name = "chkDebtorsOnly"
        Me.chkDebtorsOnly.Size = New System.Drawing.Size(87, 17)
        Me.chkDebtorsOnly.TabIndex = 21
        Me.chkDebtorsOnly.Text = "Debtors Only"
        Me.chkDebtorsOnly.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(6, 10)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(127, 39)
        Me.Button20.TabIndex = 20
        Me.Button20.Text = "SendFeesBalanceNotification"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'dgClassList
        '
        Me.dgClassList.AllowUserToAddRows = False
        Me.dgClassList.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgClassList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClassList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOKContactNumber})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgClassList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgClassList.GridColor = System.Drawing.Color.LightSteelBlue
        Me.dgClassList.Location = New System.Drawing.Point(4, 54)
        Me.dgClassList.Name = "dgClassList"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgClassList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgClassList.Size = New System.Drawing.Size(782, 247)
        Me.dgClassList.TabIndex = 17
        '
        'NOKContactNumber
        '
        Me.NOKContactNumber.DataPropertyName = "NOKContactNumber"
        Me.NOKContactNumber.HeaderText = "NOKContactNumber"
        Me.NOKContactNumber.Name = "NOKContactNumber"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(293, 304)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 56)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Send"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox13.Controls.Add(Me.cboSmsSess)
        Me.GroupBox13.Controls.Add(Me.cboSmsSem)
        Me.GroupBox13.Controls.Add(Me.Label30)
        Me.GroupBox13.Controls.Add(Me.Label31)
        Me.GroupBox13.Controls.Add(Me.cboSmslevel)
        Me.GroupBox13.Controls.Add(Me.Label32)
        Me.GroupBox13.Controls.Add(Me.cboSmdClass)
        Me.GroupBox13.Location = New System.Drawing.Point(163, 3)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(533, 50)
        Me.GroupBox13.TabIndex = 10
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Class Search"
        '
        'cboSmsSess
        '
        Me.cboSmsSess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSmsSess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSmsSess.DisplayMember = "Session"
        Me.cboSmsSess.FormattingEnabled = True
        Me.cboSmsSess.Location = New System.Drawing.Point(283, 24)
        Me.cboSmsSess.Name = "cboSmsSess"
        Me.cboSmsSess.Size = New System.Drawing.Size(96, 21)
        Me.cboSmsSess.TabIndex = 11
        Me.cboSmsSess.ValueMember = "Session"
        '
        'cboSmsSem
        '
        Me.cboSmsSem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSmsSem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSmsSem.FormattingEnabled = True
        Me.cboSmsSem.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboSmsSem.Location = New System.Drawing.Point(425, 23)
        Me.cboSmsSem.Name = "cboSmsSem"
        Me.cboSmsSem.Size = New System.Drawing.Size(55, 21)
        Me.cboSmsSem.TabIndex = 7
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(385, 31)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(34, 13)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Term:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 28)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 13)
        Me.Label31.TabIndex = 3
        Me.Label31.Text = "Year:"
        '
        'cboSmslevel
        '
        Me.cboSmslevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSmslevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSmslevel.FormattingEnabled = True
        Me.cboSmslevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cboSmslevel.Location = New System.Drawing.Point(214, 24)
        Me.cboSmslevel.Name = "cboSmslevel"
        Me.cboSmslevel.Size = New System.Drawing.Size(59, 21)
        Me.cboSmslevel.TabIndex = 5
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(150, 31)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(67, 13)
        Me.Label32.TabIndex = 6
        Me.Label32.Text = "Form/Grade:"
        '
        'cboSmdClass
        '
        Me.cboSmdClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSmdClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSmdClass.FormattingEnabled = True
        Me.cboSmdClass.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboSmdClass.Location = New System.Drawing.Point(44, 23)
        Me.cboSmdClass.Name = "cboSmdClass"
        Me.cboSmdClass.Size = New System.Drawing.Size(91, 21)
        Me.cboSmdClass.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(403, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Message"
        '
        'RichTextBox
        '
        Me.RichTextBox.EnableAutoDragDrop = True
        Me.RichTextBox.Location = New System.Drawing.Point(96, 8)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.Size = New System.Drawing.Size(480, 144)
        Me.RichTextBox.TabIndex = 1
        Me.RichTextBox.Text = ""
        '
        'Marks
        '
        Me.Marks.AutoScroll = True
        Me.Marks.Controls.Add(Me.SplitContainer5)
        Me.Marks.ImageKey = "Settings 1.png"
        Me.Marks.Location = New System.Drawing.Point(4, 23)
        Me.Marks.Name = "Marks"
        Me.Marks.Padding = New System.Windows.Forms.Padding(3)
        Me.Marks.Size = New System.Drawing.Size(1587, 715)
        Me.Marks.TabIndex = 4
        Me.Marks.Tag = "19"
        Me.Marks.Text = "Student Marks"
        Me.Marks.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer5.Panel1.Controls.Add(Me.btnStudentMarksSearch)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label52)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer5.Panel1.Controls.Add(Me.lbStudMarks)
        Me.SplitContainer5.Panel1.Controls.Add(Me.txtStudMarksSearch)
        Me.SplitContainer5.Panel1.Controls.Add(Me.tvEditMarks)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.AutoScroll = True
        Me.SplitContainer5.Panel2.Controls.Add(Me.Button34)
        Me.SplitContainer5.Panel2.Controls.Add(Me.GroupBox15)
        Me.SplitContainer5.Panel2.Controls.Add(Me.StudentMarks)
        Me.SplitContainer5.Size = New System.Drawing.Size(1581, 709)
        Me.SplitContainer5.SplitterDistance = 269
        Me.SplitContainer5.SplitterWidth = 1
        Me.SplitContainer5.TabIndex = 1
        '
        'btnStudentMarksSearch
        '
        Me.btnStudentMarksSearch.BackgroundImage = Global.StudentDetails.My.Resources.Resources.search
        Me.btnStudentMarksSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStudentMarksSearch.Location = New System.Drawing.Point(170, 231)
        Me.btnStudentMarksSearch.Name = "btnStudentMarksSearch"
        Me.btnStudentMarksSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnStudentMarksSearch.TabIndex = 18
        Me.btnStudentMarksSearch.UseVisualStyleBackColor = True
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(47, 209)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(89, 13)
        Me.Label52.TabIndex = 15
        Me.Label52.Text = "IndividualStudent"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbStudMarks
        '
        Me.lbStudMarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbStudMarks.FormattingEnabled = True
        Me.lbStudMarks.Location = New System.Drawing.Point(3, 257)
        Me.lbStudMarks.Name = "lbStudMarks"
        Me.lbStudMarks.Size = New System.Drawing.Size(252, 95)
        Me.lbStudMarks.TabIndex = 13
        Me.lbStudMarks.Visible = False
        '
        'txtStudMarksSearch
        '
        Me.txtStudMarksSearch.Location = New System.Drawing.Point(22, 231)
        Me.txtStudMarksSearch.Name = "txtStudMarksSearch"
        Me.txtStudMarksSearch.Size = New System.Drawing.Size(153, 20)
        Me.txtStudMarksSearch.TabIndex = 12
        '
        'tvEditMarks
        '
        Me.tvEditMarks.Location = New System.Drawing.Point(22, 370)
        Me.tvEditMarks.Name = "tvEditMarks"
        TreeNode1.Name = "Node1"
        TreeNode1.Tag = "23"
        TreeNode1.Text = "EditMarks"
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "StudentMarks"
        Me.tvEditMarks.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.tvEditMarks.Size = New System.Drawing.Size(121, 97)
        Me.tvEditMarks.TabIndex = 1
        Me.tvEditMarks.Tag = ""
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.Green
        Me.Button34.ForeColor = System.Drawing.Color.White
        Me.Button34.Location = New System.Drawing.Point(12, 45)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(75, 41)
        Me.Button34.TabIndex = 47
        Me.Button34.Text = "Hide Search Panel"
        Me.Button34.UseVisualStyleBackColor = False
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox15.Controls.Add(Me.cboMarkSession)
        Me.GroupBox15.Controls.Add(Me.cboMarkSubject)
        Me.GroupBox15.Controls.Add(Me.btnMarkClass)
        Me.GroupBox15.Controls.Add(Me.cboMarkClass)
        Me.GroupBox15.Controls.Add(Me.Label1)
        Me.GroupBox15.Controls.Add(Me.Label56)
        Me.GroupBox15.Controls.Add(Me.cboMarkExam)
        Me.GroupBox15.Controls.Add(Me.Label8)
        Me.GroupBox15.Controls.Add(Me.cboMarkLevel)
        Me.GroupBox15.Controls.Add(Me.Label42)
        Me.GroupBox15.Controls.Add(Me.Label11)
        Me.GroupBox15.Controls.Add(Me.cboMarkProg)
        Me.GroupBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(94, 22)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(1213, 78)
        Me.GroupBox15.TabIndex = 20
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Class_Search"
        '
        'cboMarkSession
        '
        Me.cboMarkSession.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboMarkSession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboMarkSession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarkSession.DisplayMember = "Sessions"
        Me.cboMarkSession.FormattingEnabled = True
        Me.cboMarkSession.Location = New System.Drawing.Point(483, 23)
        Me.cboMarkSession.Name = "cboMarkSession"
        Me.cboMarkSession.Size = New System.Drawing.Size(88, 21)
        Me.cboMarkSession.TabIndex = 57
        Me.cboMarkSession.ValueMember = "Sessions"
        '
        'cboMarkSubject
        '
        Me.cboMarkSubject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboMarkSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboMarkSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarkSubject.DisplayMember = "Sessions"
        Me.cboMarkSubject.FormattingEnabled = True
        Me.cboMarkSubject.Location = New System.Drawing.Point(852, 23)
        Me.cboMarkSubject.Name = "cboMarkSubject"
        Me.cboMarkSubject.Size = New System.Drawing.Size(238, 21)
        Me.cboMarkSubject.TabIndex = 56
        Me.cboMarkSubject.ValueMember = "Sessions"
        '
        'btnMarkClass
        '
        Me.btnMarkClass.Location = New System.Drawing.Point(1096, 17)
        Me.btnMarkClass.Name = "btnMarkClass"
        Me.btnMarkClass.Size = New System.Drawing.Size(112, 29)
        Me.btnMarkClass.TabIndex = 55
        Me.btnMarkClass.Text = "Refresh Class"
        Me.btnMarkClass.UseVisualStyleBackColor = True
        '
        'cboMarkClass
        '
        Me.cboMarkClass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboMarkClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboMarkClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarkClass.DisplayMember = "Sessions"
        Me.cboMarkClass.FormattingEnabled = True
        Me.cboMarkClass.Location = New System.Drawing.Point(225, 23)
        Me.cboMarkClass.Name = "cboMarkClass"
        Me.cboMarkClass.Size = New System.Drawing.Size(150, 21)
        Me.cboMarkClass.TabIndex = 54
        Me.cboMarkClass.ValueMember = "Sessions"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Class:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(792, 25)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(54, 13)
        Me.Label56.TabIndex = 51
        Me.Label56.Text = "Subject:"
        '
        'cboMarkExam
        '
        Me.cboMarkExam.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboMarkExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboMarkExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarkExam.DisplayMember = "Sessions"
        Me.cboMarkExam.FormattingEnabled = True
        Me.cboMarkExam.Location = New System.Drawing.Point(615, 23)
        Me.cboMarkExam.Name = "cboMarkExam"
        Me.cboMarkExam.Size = New System.Drawing.Size(175, 21)
        Me.cboMarkExam.TabIndex = 45
        Me.cboMarkExam.ValueMember = "Sessions"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(381, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Level:"
        '
        'cboMarkLevel
        '
        Me.cboMarkLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMarkLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarkLevel.FormattingEnabled = True
        Me.cboMarkLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboMarkLevel.Location = New System.Drawing.Point(429, 23)
        Me.cboMarkLevel.Name = "cboMarkLevel"
        Me.cboMarkLevel.Size = New System.Drawing.Size(53, 21)
        Me.cboMarkLevel.TabIndex = 2
        '
        'Label42
        '
        Me.Label42.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(575, 26)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(37, 13)
        Me.Label42.TabIndex = 43
        Me.Label42.Text = "Exam"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Program:"
        '
        'cboMarkProg
        '
        Me.cboMarkProg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMarkProg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMarkProg.FormattingEnabled = True
        Me.cboMarkProg.Items.AddRange(New Object() {"2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022"})
        Me.cboMarkProg.Location = New System.Drawing.Point(69, 23)
        Me.cboMarkProg.Name = "cboMarkProg"
        Me.cboMarkProg.Size = New System.Drawing.Size(103, 21)
        Me.cboMarkProg.TabIndex = 1
        '
        'StudentMarks
        '
        Me.StudentMarks.Controls.Add(Me.Button39)
        Me.StudentMarks.Controls.Add(Me.chkdef)
        Me.StudentMarks.Controls.Add(Me.lbDetails)
        Me.StudentMarks.Controls.Add(Me.gvMarks)
        Me.StudentMarks.Controls.Add(Me.cboRemarks)
        Me.StudentMarks.Controls.Add(Me.Button29)
        Me.StudentMarks.Controls.Add(Me.Button28)
        Me.StudentMarks.Controls.Add(Me.Label47)
        Me.StudentMarks.Controls.Add(Me.Label54)
        Me.StudentMarks.Controls.Add(Me.lbstuds)
        Me.StudentMarks.Controls.Add(Me.txtstudsearch)
        Me.StudentMarks.Controls.Add(Me.gdStudents)
        Me.StudentMarks.Controls.Add(Me.btnEnterMarks)
        Me.StudentMarks.Location = New System.Drawing.Point(12, 106)
        Me.StudentMarks.Name = "StudentMarks"
        Me.StudentMarks.Size = New System.Drawing.Size(1282, 598)
        Me.StudentMarks.TabIndex = 15
        Me.StudentMarks.TabStop = False
        Me.StudentMarks.Text = "Class Students"
        '
        'Button39
        '
        Me.Button39.Location = New System.Drawing.Point(975, 367)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(138, 69)
        Me.Button39.TabIndex = 56
        Me.Button39.Text = "BoardingMasterComments"
        Me.Button39.UseVisualStyleBackColor = True
        '
        'chkdef
        '
        Me.chkdef.AutoSize = True
        Me.chkdef.Location = New System.Drawing.Point(70, 52)
        Me.chkdef.Name = "chkdef"
        Me.chkdef.Size = New System.Drawing.Size(67, 17)
        Me.chkdef.TabIndex = 54
        Me.chkdef.Text = "SelectAll"
        Me.chkdef.UseVisualStyleBackColor = True
        '
        'lbDetails
        '
        Me.lbDetails.AutoSize = True
        Me.lbDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDetails.Location = New System.Drawing.Point(280, 43)
        Me.lbDetails.Name = "lbDetails"
        Me.lbDetails.Size = New System.Drawing.Size(79, 20)
        Me.lbDetails.TabIndex = 47
        Me.lbDetails.Text = "Subjects"
        '
        'gvMarks
        '
        Me.gvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvMarks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.Item, Me.Subject, Me.CourseMark, Me.ExamMark, Me.Comment, Me.MultiComment, Me.Effort, Me.Remarks, Me.MarkRef})
        Me.gvMarks.Location = New System.Drawing.Point(6, 70)
        Me.gvMarks.Name = "gvMarks"
        Me.gvMarks.Size = New System.Drawing.Size(888, 283)
        Me.gvMarks.TabIndex = 53
        '
        'Check
        '
        Me.Check.HeaderText = "Check"
        Me.Check.Name = "Check"
        Me.Check.Width = 50
        '
        'Item
        '
        Me.Item.HeaderText = "Item#"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 50
        '
        'Subject
        '
        Me.Subject.HeaderText = "Subject"
        Me.Subject.Name = "Subject"
        Me.Subject.Width = 200
        '
        'CourseMark
        '
        Me.CourseMark.HeaderText = "CM"
        Me.CourseMark.Name = "CourseMark"
        Me.CourseMark.Visible = False
        Me.CourseMark.Width = 60
        '
        'ExamMark
        '
        Me.ExamMark.HeaderText = "EM"
        Me.ExamMark.Name = "ExamMark"
        Me.ExamMark.Width = 60
        '
        'Comment
        '
        Me.Comment.HeaderText = "Comment(F2 to Expand)"
        Me.Comment.Name = "Comment"
        Me.Comment.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Comment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Comment.Width = 200
        '
        'MultiComment
        '
        Me.MultiComment.HeaderText = "Comment"
        Me.MultiComment.Name = "MultiComment"
        Me.MultiComment.Visible = False
        Me.MultiComment.Width = 200
        '
        'Effort
        '
        Me.Effort.HeaderText = "Effort"
        Me.Effort.Items.AddRange(New Object() {"OE", "CE", "UE", "AE", "IE"})
        Me.Effort.Name = "Effort"
        '
        'Remarks
        '
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Items.AddRange(New Object() {"Absent", "Present"})
        Me.Remarks.Name = "Remarks"
        '
        'MarkRef
        '
        Me.MarkRef.HeaderText = "MarkRef"
        Me.MarkRef.Name = "MarkRef"
        Me.MarkRef.Visible = False
        '
        'cboRemarks
        '
        Me.cboRemarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRemarks.FormattingEnabled = True
        Me.cboRemarks.Items.AddRange(New Object() {"Absent", "Present"})
        Me.cboRemarks.Location = New System.Drawing.Point(765, 84)
        Me.cboRemarks.Name = "cboRemarks"
        Me.cboRemarks.Size = New System.Drawing.Size(107, 21)
        Me.cboRemarks.TabIndex = 46
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(831, 367)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(138, 69)
        Me.Button29.TabIndex = 52
        Me.Button29.Text = "HeadComments"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.Enabled = False
        Me.Button28.Location = New System.Drawing.Point(1115, 367)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(138, 69)
        Me.Button28.TabIndex = 51
        Me.Button28.Text = "FormTeacherComments"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Label47
        '
        Me.Label47.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(681, 91)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(78, 13)
        Me.Label47.TabIndex = 44
        Me.Label47.Text = "DefaultRemark"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(908, 16)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(81, 13)
        Me.Label54.TabIndex = 48
        Me.Label54.Text = "StudentSearch:"
        '
        'lbstuds
        '
        Me.lbstuds.BackColor = System.Drawing.Color.LightYellow
        Me.lbstuds.DisplayMember = "StudName"
        Me.lbstuds.ForeColor = System.Drawing.Color.Black
        Me.lbstuds.FormattingEnabled = True
        Me.lbstuds.Location = New System.Drawing.Point(995, 39)
        Me.lbstuds.Name = "lbstuds"
        Me.lbstuds.Size = New System.Drawing.Size(278, 225)
        Me.lbstuds.TabIndex = 42
        Me.lbstuds.ValueMember = "StudentID"
        Me.lbstuds.Visible = False
        '
        'txtstudsearch
        '
        Me.txtstudsearch.Location = New System.Drawing.Point(995, 13)
        Me.txtstudsearch.Name = "txtstudsearch"
        Me.txtstudsearch.Size = New System.Drawing.Size(233, 20)
        Me.txtstudsearch.TabIndex = 41
        '
        'gdStudents
        '
        Me.gdStudents.AllowUserToAddRows = False
        Me.gdStudents.AllowUserToDeleteRows = False
        Me.gdStudents.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.gdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MarksStudentID, Me.MarksStudName, Me.MarksEnrolRef})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gdStudents.DefaultCellStyle = DataGridViewCellStyle8
        Me.gdStudents.GridColor = System.Drawing.Color.White
        Me.gdStudents.Location = New System.Drawing.Point(911, 45)
        Me.gdStudents.MultiSelect = False
        Me.gdStudents.Name = "gdStudents"
        Me.gdStudents.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdStudents.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.gdStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gdStudents.Size = New System.Drawing.Size(346, 316)
        Me.gdStudents.TabIndex = 0
        '
        'MarksStudentID
        '
        Me.MarksStudentID.DataPropertyName = "StudentID"
        Me.MarksStudentID.HeaderText = "StudentID"
        Me.MarksStudentID.Name = "MarksStudentID"
        Me.MarksStudentID.ReadOnly = True
        '
        'MarksStudName
        '
        Me.MarksStudName.DataPropertyName = "StudName"
        Me.MarksStudName.HeaderText = "StudentName"
        Me.MarksStudName.Name = "MarksStudName"
        Me.MarksStudName.ReadOnly = True
        '
        'MarksEnrolRef
        '
        Me.MarksEnrolRef.DataPropertyName = "EnrolRef"
        Me.MarksEnrolRef.HeaderText = "Ref"
        Me.MarksEnrolRef.Name = "MarksEnrolRef"
        Me.MarksEnrolRef.ReadOnly = True
        Me.MarksEnrolRef.Visible = False
        '
        'btnEnterMarks
        '
        Me.btnEnterMarks.Location = New System.Drawing.Point(284, 359)
        Me.btnEnterMarks.Name = "btnEnterMarks"
        Me.btnEnterMarks.Size = New System.Drawing.Size(138, 69)
        Me.btnEnterMarks.TabIndex = 1
        Me.btnEnterMarks.Text = "Save"
        Me.btnEnterMarks.UseVisualStyleBackColor = True
        '
        'tbStudentReceipts
        '
        Me.tbStudentReceipts.Controls.Add(Me.SplitContainer4)
        Me.tbStudentReceipts.ImageKey = "Dollars.png"
        Me.tbStudentReceipts.Location = New System.Drawing.Point(4, 23)
        Me.tbStudentReceipts.Name = "tbStudentReceipts"
        Me.tbStudentReceipts.Padding = New System.Windows.Forms.Padding(3)
        Me.tbStudentReceipts.Size = New System.Drawing.Size(1587, 715)
        Me.tbStudentReceipts.TabIndex = 3
        Me.tbStudentReceipts.Tag = "18"
        Me.tbStudentReceipts.Text = "StudentReceipts"
        Me.tbStudentReceipts.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.AutoScroll = True
        Me.SplitContainer4.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer4.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer4.Panel1.Controls.Add(Me.GroupBox6)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.AutoScroll = True
        Me.SplitContainer4.Panel2.Controls.Add(Me.Button37)
        Me.SplitContainer4.Panel2.Controls.Add(Me.GroupBox7)
        Me.SplitContainer4.Panel2.Controls.Add(Me.GroupBox17)
        Me.SplitContainer4.Size = New System.Drawing.Size(1581, 709)
        Me.SplitContainer4.SplitterDistance = 782
        Me.SplitContainer4.SplitterWidth = 1
        Me.SplitContainer4.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rvOnScreenStat)
        Me.Panel2.Controls.Add(Me.rvOnScreenDatPay)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 632)
        Me.Panel2.TabIndex = 45
        '
        'rvOnScreenStat
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.StudentFeesTranscationsBindingSource
        Me.rvOnScreenStat.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvOnScreenStat.LocalReport.ReportEmbeddedResource = "StudentDetails.rptStudFeesStatement.rdlc"
        Me.rvOnScreenStat.Location = New System.Drawing.Point(116, 216)
        Me.rvOnScreenStat.Name = "rvOnScreenStat"
        Me.rvOnScreenStat.ServerReport.BearerToken = Nothing
        Me.rvOnScreenStat.Size = New System.Drawing.Size(396, 246)
        Me.rvOnScreenStat.TabIndex = 2
        Me.rvOnScreenStat.Visible = False
        Me.rvOnScreenStat.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'rvOnScreenDatPay
        '
        Me.rvOnScreenDatPay.LocalReport.ReportEmbeddedResource = "SMS.rptFeesByDate.rdlc"
        Me.rvOnScreenDatPay.Location = New System.Drawing.Point(45, 20)
        Me.rvOnScreenDatPay.Name = "rvOnScreenDatPay"
        Me.rvOnScreenDatPay.ServerReport.BearerToken = Nothing
        Me.rvOnScreenDatPay.Size = New System.Drawing.Size(347, 150)
        Me.rvOnScreenDatPay.TabIndex = 1
        Me.rvOnScreenDatPay.Visible = False
        Me.rvOnScreenDatPay.ZoomPercent = 500
        '
        'GroupBox6
        '
        Me.GroupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox6.Controls.Add(Me.chkTransScreenShowReceipts)
        Me.GroupBox6.Controls.Add(Me.chkTransScreenShowInvoices)
        Me.GroupBox6.Controls.Add(Me.Label66)
        Me.GroupBox6.Controls.Add(Me.cboBBFCutOffPeriod)
        Me.GroupBox6.Controls.Add(Me.Panel3)
        Me.GroupBox6.Controls.Add(Me.btnFessClass)
        Me.GroupBox6.Controls.Add(Me.lbFeesHidedStudID)
        Me.GroupBox6.Controls.Add(Me.cbofeesClassSearch)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.cboFeesProgSearch)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.cbofeessessSearch)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.cbofeesLvlsearch)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(778, 73)
        Me.GroupBox6.TabIndex = 44
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ClassSearch"
        '
        'chkTransScreenShowReceipts
        '
        Me.chkTransScreenShowReceipts.AutoSize = True
        Me.chkTransScreenShowReceipts.Checked = True
        Me.chkTransScreenShowReceipts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTransScreenShowReceipts.Location = New System.Drawing.Point(671, 45)
        Me.chkTransScreenShowReceipts.Name = "chkTransScreenShowReceipts"
        Me.chkTransScreenShowReceipts.Size = New System.Drawing.Size(95, 17)
        Me.chkTransScreenShowReceipts.TabIndex = 60
        Me.chkTransScreenShowReceipts.Text = "ShowReceipts"
        Me.chkTransScreenShowReceipts.UseVisualStyleBackColor = True
        '
        'chkTransScreenShowInvoices
        '
        Me.chkTransScreenShowInvoices.AutoSize = True
        Me.chkTransScreenShowInvoices.Checked = True
        Me.chkTransScreenShowInvoices.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTransScreenShowInvoices.Location = New System.Drawing.Point(572, 45)
        Me.chkTransScreenShowInvoices.Name = "chkTransScreenShowInvoices"
        Me.chkTransScreenShowInvoices.Size = New System.Drawing.Size(93, 17)
        Me.chkTransScreenShowInvoices.TabIndex = 59
        Me.chkTransScreenShowInvoices.Text = "ShowInvoices"
        Me.chkTransScreenShowInvoices.UseVisualStyleBackColor = True
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(280, 46)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(95, 13)
        Me.Label66.TabIndex = 58
        Me.Label66.Text = "BBF cut off period:"
        '
        'cboBBFCutOffPeriod
        '
        Me.cboBBFCutOffPeriod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBBFCutOffPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBBFCutOffPeriod.FormattingEnabled = True
        Me.cboBBFCutOffPeriod.Items.AddRange(New Object() {"Refund", "Error In Capturing", "Test Receipt", "Others"})
        Me.cboBBFCutOffPeriod.Location = New System.Drawing.Point(378, 43)
        Me.cboBBFCutOffPeriod.Name = "cboBBFCutOffPeriod"
        Me.cboBBFCutOffPeriod.Size = New System.Drawing.Size(184, 21)
        Me.cboBBFCutOffPeriod.TabIndex = 57
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnFeesClassMoveNext)
        Me.Panel3.Controls.Add(Me.btnFeesClassMovePrev)
        Me.Panel3.Controls.Add(Me.txtPos)
        Me.Panel3.Location = New System.Drawing.Point(45, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(232, 28)
        Me.Panel3.TabIndex = 52
        '
        'btnFeesClassMoveNext
        '
        Me.btnFeesClassMoveNext.Location = New System.Drawing.Point(193, 2)
        Me.btnFeesClassMoveNext.Name = "btnFeesClassMoveNext"
        Me.btnFeesClassMoveNext.Size = New System.Drawing.Size(36, 23)
        Me.btnFeesClassMoveNext.TabIndex = 42
        Me.btnFeesClassMoveNext.Text = ">>"
        Me.btnFeesClassMoveNext.UseVisualStyleBackColor = True
        '
        'btnFeesClassMovePrev
        '
        Me.btnFeesClassMovePrev.Location = New System.Drawing.Point(3, 3)
        Me.btnFeesClassMovePrev.Name = "btnFeesClassMovePrev"
        Me.btnFeesClassMovePrev.Size = New System.Drawing.Size(33, 23)
        Me.btnFeesClassMovePrev.TabIndex = 43
        Me.btnFeesClassMovePrev.Text = "<<"
        Me.btnFeesClassMovePrev.UseVisualStyleBackColor = True
        '
        'txtPos
        '
        Me.txtPos.Location = New System.Drawing.Point(70, 4)
        Me.txtPos.Name = "txtPos"
        Me.txtPos.Size = New System.Drawing.Size(85, 20)
        Me.txtPos.TabIndex = 50
        '
        'btnFessClass
        '
        Me.btnFessClass.Location = New System.Drawing.Point(543, 12)
        Me.btnFessClass.Name = "btnFessClass"
        Me.btnFessClass.Size = New System.Drawing.Size(112, 29)
        Me.btnFessClass.TabIndex = 51
        Me.btnFessClass.Text = "Refresh Class"
        Me.btnFessClass.UseVisualStyleBackColor = True
        '
        'lbFeesHidedStudID
        '
        Me.lbFeesHidedStudID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassListBindingSource, "StudentID", True))
        Me.lbFeesHidedStudID.Location = New System.Drawing.Point(661, 15)
        Me.lbFeesHidedStudID.Name = "lbFeesHidedStudID"
        Me.lbFeesHidedStudID.ReadOnly = True
        Me.lbFeesHidedStudID.Size = New System.Drawing.Size(10, 20)
        Me.lbFeesHidedStudID.TabIndex = 49
        '
        'ClassListBindingSource
        '
        Me.ClassListBindingSource.DataMember = "ClassList"
        Me.ClassListBindingSource.DataSource = Me.DsSchool
        '
        'cbofeesClassSearch
        '
        Me.cbofeesClassSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbofeesClassSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbofeesClassSearch.DisplayMember = "Forms"
        Me.cbofeesClassSearch.FormattingEnabled = True
        Me.cbofeesClassSearch.Location = New System.Drawing.Point(202, 16)
        Me.cbofeesClassSearch.Name = "cbofeesClassSearch"
        Me.cbofeesClassSearch.Size = New System.Drawing.Size(165, 21)
        Me.cbofeesClassSearch.TabIndex = 48
        Me.cbofeesClassSearch.ValueMember = "Forms"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(161, 19)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(35, 13)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "Class:"
        '
        'cboFeesProgSearch
        '
        Me.cboFeesProgSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFeesProgSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFeesProgSearch.DisplayMember = "Forms"
        Me.cboFeesProgSearch.FormattingEnabled = True
        Me.cboFeesProgSearch.Location = New System.Drawing.Point(44, 16)
        Me.cboFeesProgSearch.Name = "cboFeesProgSearch"
        Me.cboFeesProgSearch.Size = New System.Drawing.Size(111, 21)
        Me.cboFeesProgSearch.TabIndex = 45
        Me.cboFeesProgSearch.ValueMember = "Forms"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Program:"
        '
        'cbofeessessSearch
        '
        Me.cbofeessessSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbofeessessSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbofeessessSearch.DisplayMember = "Session"
        Me.cbofeessessSearch.FormattingEnabled = True
        Me.cbofeessessSearch.Location = New System.Drawing.Point(471, 15)
        Me.cbofeessessSearch.Name = "cbofeessessSearch"
        Me.cbofeessessSearch.Size = New System.Drawing.Size(66, 21)
        Me.cbofeessessSearch.TabIndex = 5
        Me.cbofeessessSearch.ValueMember = "Session"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(373, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(36, 13)
        Me.Label28.TabIndex = 38
        Me.Label28.Text = "Level:"
        '
        'cbofeesLvlsearch
        '
        Me.cbofeesLvlsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbofeesLvlsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbofeesLvlsearch.FormattingEnabled = True
        Me.cbofeesLvlsearch.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cbofeesLvlsearch.Location = New System.Drawing.Point(415, 14)
        Me.cbofeesLvlsearch.Name = "cbofeesLvlsearch"
        Me.cbofeesLvlsearch.Size = New System.Drawing.Size(50, 21)
        Me.cbofeesLvlsearch.TabIndex = 3
        '
        'Button37
        '
        Me.Button37.BackColor = System.Drawing.Color.Green
        Me.Button37.ForeColor = System.Drawing.Color.White
        Me.Button37.Location = New System.Drawing.Point(1, 3)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(75, 41)
        Me.Button37.TabIndex = 55
        Me.Button37.Text = "Hide Search Panel"
        Me.Button37.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.btnCancelAllLines)
        Me.GroupBox7.Controls.Add(Me.btnUpdateAllLines)
        Me.GroupBox7.Controls.Add(Me.lbSeacrhFees)
        Me.GroupBox7.Controls.Add(Me.dgFessDetails)
        Me.GroupBox7.Controls.Add(Me.BindingNavigator2)
        Me.GroupBox7.Controls.Add(Me.gbFeesPay)
        Me.GroupBox7.Location = New System.Drawing.Point(27, 48)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(725, 435)
        Me.GroupBox7.TabIndex = 21
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Fees Payments"
        '
        'btnCancelAllLines
        '
        Me.btnCancelAllLines.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelAllLines.Location = New System.Drawing.Point(281, 395)
        Me.btnCancelAllLines.Name = "btnCancelAllLines"
        Me.btnCancelAllLines.Size = New System.Drawing.Size(125, 34)
        Me.btnCancelAllLines.TabIndex = 43
        Me.btnCancelAllLines.Tag = " "
        Me.btnCancelAllLines.Text = "Cancel All Selected Lines"
        Me.btnCancelAllLines.UseVisualStyleBackColor = True
        '
        'btnUpdateAllLines
        '
        Me.btnUpdateAllLines.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateAllLines.Location = New System.Drawing.Point(103, 395)
        Me.btnUpdateAllLines.Name = "btnUpdateAllLines"
        Me.btnUpdateAllLines.Size = New System.Drawing.Size(125, 34)
        Me.btnUpdateAllLines.TabIndex = 42
        Me.btnUpdateAllLines.Tag = " "
        Me.btnUpdateAllLines.Text = "Update All Selected Lines"
        Me.btnUpdateAllLines.UseVisualStyleBackColor = True
        '
        'lbSeacrhFees
        '
        Me.lbSeacrhFees.FormattingEnabled = True
        Me.lbSeacrhFees.Location = New System.Drawing.Point(384, 0)
        Me.lbSeacrhFees.Name = "lbSeacrhFees"
        Me.lbSeacrhFees.Size = New System.Drawing.Size(341, 82)
        Me.lbSeacrhFees.TabIndex = 23
        Me.lbSeacrhFees.Visible = False
        '
        'dgFessDetails
        '
        Me.dgFessDetails.AutoGenerateColumns = False
        Me.dgFessDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFessDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cart, Me.Amnt, Me.Currency, Me.Perd, Me.Ref, Me.btnUpdate, Me.btnDelete, Me.LineRef})
        Me.dgFessDetails.DataSource = Me.FeespaymentsdetailsBindingSource
        Me.dgFessDetails.Enabled = False
        Me.dgFessDetails.Location = New System.Drawing.Point(8, 239)
        Me.dgFessDetails.Name = "dgFessDetails"
        Me.dgFessDetails.Size = New System.Drawing.Size(632, 151)
        Me.dgFessDetails.TabIndex = 1
        '
        'Cart
        '
        Me.Cart.DataPropertyName = "Cartegory"
        Me.Cart.DataSource = Me.FeesPaymentTypeBindingSource
        Me.Cart.DisplayMember = "Payment"
        Me.Cart.HeaderText = "Cartegory"
        Me.Cart.Name = "Cart"
        Me.Cart.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Amnt
        '
        Me.Amnt.DataPropertyName = "Amount"
        Me.Amnt.HeaderText = "Amount"
        Me.Amnt.Name = "Amnt"
        '
        'Currency
        '
        Me.Currency.DataPropertyName = "Currency"
        Me.Currency.DataSource = Me.CurrenciesBindingSource
        Me.Currency.DisplayMember = "Currency"
        Me.Currency.HeaderText = "Currency"
        Me.Currency.Name = "Currency"
        Me.Currency.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Currency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Currency.ValueMember = "Currency"
        '
        'CurrenciesBindingSource
        '
        Me.CurrenciesBindingSource.DataMember = "Currencies"
        Me.CurrenciesBindingSource.DataSource = Me.DsSchool
        '
        'Perd
        '
        Me.Perd.DataPropertyName = "Period"
        Me.Perd.DataSource = Me.PaymentPeriodsBindingSource
        Me.Perd.DisplayMember = "Description"
        Me.Perd.HeaderText = "Period"
        Me.Perd.Name = "Perd"
        Me.Perd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Perd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Perd.ValueMember = "Period"
        '
        'PaymentPeriodsBindingSource
        '
        Me.PaymentPeriodsBindingSource.DataMember = "PaymentPeriods"
        Me.PaymentPeriodsBindingSource.DataSource = Me.DsSchool
        '
        'Ref
        '
        Me.Ref.DataPropertyName = "Reference"
        Me.Ref.HeaderText = "Reference"
        Me.Ref.Name = "Ref"
        '
        'btnUpdate
        '
        Me.btnUpdate.HeaderText = "Update"
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseColumnTextForButtonValue = True
        Me.btnUpdate.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.HeaderText = "Delete"
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseColumnTextForButtonValue = True
        Me.btnDelete.Visible = False
        '
        'LineRef
        '
        Me.LineRef.DataPropertyName = "LineRef"
        Me.LineRef.HeaderText = "LineRef"
        Me.LineRef.Name = "LineRef"
        Me.LineRef.Visible = False
        '
        'FeespaymentsdetailsBindingSource
        '
        Me.FeespaymentsdetailsBindingSource.DataMember = "feespayments_details"
        Me.FeespaymentsdetailsBindingSource.DataSource = Me.DsSchool
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.Insert
        Me.BindingNavigator2.BindingSource = Me.FeesPaymentsHeaderBindingSource
        Me.BindingNavigator2.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator1, Me.ToolStripTextBox2, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator3, Me.Insert, Me.Save, Me.ToolStripSeparator4, Me.Delete, Me.Reprint, Me.Edt, Me.rec_import})
        Me.BindingNavigator2.Location = New System.Drawing.Point(6, 16)
        Me.BindingNavigator2.MoveFirstItem = Me.ToolStripButton9
        Me.BindingNavigator2.MoveLastItem = Me.ToolStripButton12
        Me.BindingNavigator2.MoveNextItem = Me.ToolStripButton11
        Me.BindingNavigator2.MovePreviousItem = Me.ToolStripButton10
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.ToolStripTextBox2
        Me.BindingNavigator2.Size = New System.Drawing.Size(353, 25)
        Me.BindingNavigator2.TabIndex = 41
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'Insert
        '
        Me.Insert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Insert.Image = CType(resources.GetObject("Insert.Image"), System.Drawing.Image)
        Me.Insert.Name = "Insert"
        Me.Insert.RightToLeftAutoMirrorImage = True
        Me.Insert.Size = New System.Drawing.Size(23, 22)
        Me.Insert.Text = "Add new"
        '
        'FeesPaymentsHeaderBindingSource
        '
        Me.FeesPaymentsHeaderBindingSource.DataMember = "FeesPayments_Header"
        Me.FeesPaymentsHeaderBindingSource.DataSource = Me.DsSchool
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Move first"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Move next"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Save
        '
        Me.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(23, 22)
        Me.Save.Tag = "70"
        Me.Save.Text = "Save Data"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Delete
        '
        Me.Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(23, 22)
        Me.Delete.Tag = "69"
        Me.Delete.Text = "ToolStripButton14"
        Me.Delete.ToolTipText = "Cancel/Delete"
        '
        'Reprint
        '
        Me.Reprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Reprint.Image = CType(resources.GetObject("Reprint.Image"), System.Drawing.Image)
        Me.Reprint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Reprint.Name = "Reprint"
        Me.Reprint.Size = New System.Drawing.Size(23, 22)
        Me.Reprint.Text = "Reprint"
        '
        'Edt
        '
        Me.Edt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Edt.Image = Global.StudentDetails.My.Resources.Resources.edit
        Me.Edt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Edt.Name = "Edt"
        Me.Edt.Size = New System.Drawing.Size(23, 22)
        Me.Edt.Text = "Edit"
        '
        'rec_import
        '
        Me.rec_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.rec_import.Image = CType(resources.GetObject("rec_import.Image"), System.Drawing.Image)
        Me.rec_import.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.rec_import.Name = "rec_import"
        Me.rec_import.Size = New System.Drawing.Size(23, 22)
        Me.rec_import.Text = "Import Receipts"
        '
        'gbFeesPay
        '
        Me.gbFeesPay.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbFeesPay.Controls.Add(Me.Button11)
        Me.gbFeesPay.Controls.Add(Me.pnlReversal)
        Me.gbFeesPay.Controls.Add(Me.lbStudRef)
        Me.gbFeesPay.Controls.Add(Me.txtFeesStudID)
        Me.gbFeesPay.Controls.Add(PostDateLabel)
        Me.gbFeesPay.Controls.Add(Me.PostDateDateTimePicker)
        Me.gbFeesPay.Controls.Add(CashTypeLabel)
        Me.gbFeesPay.Controls.Add(Me.lbStudFees)
        Me.gbFeesPay.Controls.Add(Me.cboCashType)
        Me.gbFeesPay.Controls.Add(Me.mskpaydate)
        Me.gbFeesPay.Controls.Add(Me.lblfullname)
        Me.gbFeesPay.Controls.Add(StudentIDLabel1)
        Me.gbFeesPay.Controls.Add(Label35)
        Me.gbFeesPay.Controls.Add(ReceiptLabel)
        Me.gbFeesPay.Controls.Add(Me.ReceiptTextBox)
        Me.gbFeesPay.Enabled = False
        Me.gbFeesPay.Location = New System.Drawing.Point(6, 44)
        Me.gbFeesPay.Name = "gbFeesPay"
        Me.gbFeesPay.Size = New System.Drawing.Size(482, 189)
        Me.gbFeesPay.TabIndex = 0
        Me.gbFeesPay.TabStop = False
        '
        'Button11
        '
        Me.Button11.BackgroundImage = Global.StudentDetails.My.Resources.Resources.search
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Location = New System.Drawing.Point(334, 28)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(19, 20)
        Me.Button11.TabIndex = 52
        Me.Button11.UseVisualStyleBackColor = True
        '
        'pnlReversal
        '
        Me.pnlReversal.Controls.Add(ReasonForReversalLabel)
        Me.pnlReversal.Controls.Add(Me.ReasonForReversalComboBox)
        Me.pnlReversal.Location = New System.Drawing.Point(6, 151)
        Me.pnlReversal.Name = "pnlReversal"
        Me.pnlReversal.Size = New System.Drawing.Size(321, 35)
        Me.pnlReversal.TabIndex = 51
        Me.pnlReversal.Visible = False
        '
        'ReasonForReversalComboBox
        '
        Me.ReasonForReversalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ReasonForReversalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ReasonForReversalComboBox.FormattingEnabled = True
        Me.ReasonForReversalComboBox.Items.AddRange(New Object() {"Refund", "Error In Capturing", "Test Receipt", "Others"})
        Me.ReasonForReversalComboBox.Location = New System.Drawing.Point(129, 9)
        Me.ReasonForReversalComboBox.Name = "ReasonForReversalComboBox"
        Me.ReasonForReversalComboBox.Size = New System.Drawing.Size(141, 21)
        Me.ReasonForReversalComboBox.TabIndex = 9
        '
        'lbStudRef
        '
        Me.lbStudRef.Location = New System.Drawing.Point(294, 129)
        Me.lbStudRef.Name = "lbStudRef"
        Me.lbStudRef.ReadOnly = True
        Me.lbStudRef.Size = New System.Drawing.Size(10, 20)
        Me.lbStudRef.TabIndex = 50
        '
        'txtFeesStudID
        '
        Me.txtFeesStudID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsHeaderBindingSource, "StudentID", True))
        Me.txtFeesStudID.Location = New System.Drawing.Point(135, 27)
        Me.txtFeesStudID.Name = "txtFeesStudID"
        Me.txtFeesStudID.Size = New System.Drawing.Size(200, 20)
        Me.txtFeesStudID.TabIndex = 25
        '
        'PostDateDateTimePicker
        '
        Me.PostDateDateTimePicker.CustomFormat = ""
        Me.PostDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FeesPaymentsHeaderBindingSource, "PostDate", True))
        Me.PostDateDateTimePicker.Enabled = False
        Me.PostDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PostDateDateTimePicker.Location = New System.Drawing.Point(135, 129)
        Me.PostDateDateTimePicker.Name = "PostDateDateTimePicker"
        Me.PostDateDateTimePicker.Size = New System.Drawing.Size(153, 20)
        Me.PostDateDateTimePicker.TabIndex = 8
        Me.PostDateDateTimePicker.Value = New Date(2015, 2, 10, 0, 0, 0, 0)
        '
        'lbStudFees
        '
        Me.lbStudFees.FormattingEnabled = True
        Me.lbStudFees.Location = New System.Drawing.Point(135, 51)
        Me.lbStudFees.Name = "lbStudFees"
        Me.lbStudFees.Size = New System.Drawing.Size(341, 69)
        Me.lbStudFees.TabIndex = 22
        Me.lbStudFees.Visible = False
        '
        'cboCashType
        '
        Me.cboCashType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsHeaderBindingSource, "CashType", True))
        Me.cboCashType.DisplayMember = "CashType"
        Me.cboCashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCashType.FormattingEnabled = True
        Me.cboCashType.Location = New System.Drawing.Point(135, 53)
        Me.cboCashType.Name = "cboCashType"
        Me.cboCashType.Size = New System.Drawing.Size(121, 21)
        Me.cboCashType.TabIndex = 5
        Me.cboCashType.ValueMember = "CashType"
        '
        'mskpaydate
        '
        Me.mskpaydate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsHeaderBindingSource, "Date", True))
        Me.mskpaydate.Location = New System.Drawing.Point(135, 79)
        Me.mskpaydate.Mask = "00/00/0000"
        Me.mskpaydate.Name = "mskpaydate"
        Me.mskpaydate.Size = New System.Drawing.Size(121, 20)
        Me.mskpaydate.TabIndex = 6
        Me.mskpaydate.ValidatingType = GetType(Date)
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.ForeColor = System.Drawing.Color.Red
        Me.lblfullname.Location = New System.Drawing.Point(137, 11)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(33, 13)
        Me.lblfullname.TabIndex = 23
        Me.lblfullname.Text = "name"
        '
        'ReceiptTextBox
        '
        Me.ReceiptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsHeaderBindingSource, "Receipt", True))
        Me.ReceiptTextBox.Location = New System.Drawing.Point(135, 104)
        Me.ReceiptTextBox.Name = "ReceiptTextBox"
        Me.ReceiptTextBox.ReadOnly = True
        Me.ReceiptTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ReceiptTextBox.TabIndex = 7
        '
        'GroupBox17
        '
        Me.GroupBox17.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox17.Controls.Add(Me.cboFeesCartegory)
        Me.GroupBox17.Controls.Add(Me.Label16)
        Me.GroupBox17.Controls.Add(Me.FeesDateSearch)
        Me.GroupBox17.Controls.Add(Me.Label36)
        Me.GroupBox17.Controls.Add(Me.cboReceiptSearch)
        Me.GroupBox17.Controls.Add(Me.txtReceiptSearch)
        Me.GroupBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.Location = New System.Drawing.Point(82, 3)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(649, 41)
        Me.GroupBox17.TabIndex = 20
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Payment Search"
        '
        'cboFeesCartegory
        '
        Me.cboFeesCartegory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFeesCartegory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFeesCartegory.DisplayMember = "Payment"
        Me.cboFeesCartegory.FormattingEnabled = True
        Me.cboFeesCartegory.Location = New System.Drawing.Point(495, 16)
        Me.cboFeesCartegory.Name = "cboFeesCartegory"
        Me.cboFeesCartegory.Size = New System.Drawing.Size(104, 21)
        Me.cboFeesCartegory.TabIndex = 5
        Me.cboFeesCartegory.ValueMember = "Payment"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(416, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Cartegory : "
        '
        'FeesDateSearch
        '
        Me.FeesDateSearch.Location = New System.Drawing.Point(218, 15)
        Me.FeesDateSearch.Mask = "00/00/0000"
        Me.FeesDateSearch.Name = "FeesDateSearch"
        Me.FeesDateSearch.Size = New System.Drawing.Size(141, 20)
        Me.FeesDateSearch.TabIndex = 3
        Me.FeesDateSearch.ValidatingType = GetType(Date)
        Me.FeesDateSearch.Visible = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 19)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(84, 13)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "SearchOption"
        '
        'cboReceiptSearch
        '
        Me.cboReceiptSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboReceiptSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReceiptSearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboReceiptSearch.FormattingEnabled = True
        Me.cboReceiptSearch.ItemHeight = 13
        Me.cboReceiptSearch.Items.AddRange(New Object() {"Receipt", "Student", "Date"})
        Me.cboReceiptSearch.Location = New System.Drawing.Point(91, 14)
        Me.cboReceiptSearch.Name = "cboReceiptSearch"
        Me.cboReceiptSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboReceiptSearch.TabIndex = 1
        '
        'txtReceiptSearch
        '
        Me.txtReceiptSearch.Location = New System.Drawing.Point(218, 15)
        Me.txtReceiptSearch.Name = "txtReceiptSearch"
        Me.txtReceiptSearch.Size = New System.Drawing.Size(192, 20)
        Me.txtReceiptSearch.TabIndex = 0
        '
        'tbStudentSubjects
        '
        Me.tbStudentSubjects.Controls.Add(Me.SplitContainer2)
        Me.tbStudentSubjects.ImageKey = "Pen 1.png"
        Me.tbStudentSubjects.Location = New System.Drawing.Point(4, 23)
        Me.tbStudentSubjects.Name = "tbStudentSubjects"
        Me.tbStudentSubjects.Padding = New System.Windows.Forms.Padding(3)
        Me.tbStudentSubjects.Size = New System.Drawing.Size(1587, 715)
        Me.tbStudentSubjects.TabIndex = 1
        Me.tbStudentSubjects.Tag = "17"
        Me.tbStudentSubjects.Text = "Student Subjects"
        Me.tbStudentSubjects.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbSubStudSearch)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label27)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtSubStudsSearch)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnSubSearchPanel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Academics)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox9)
        Me.SplitContainer2.Size = New System.Drawing.Size(1581, 709)
        Me.SplitContainer2.SplitterDistance = 231
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.StudentDetails.My.Resources.Resources.search
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(162, 229)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(19, 20)
        Me.Button3.TabIndex = 18
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(42, 176)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Clear"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'lbSubStudSearch
        '
        Me.lbSubStudSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSubStudSearch.DisplayMember = "StudName"
        Me.lbSubStudSearch.FormattingEnabled = True
        Me.lbSubStudSearch.Location = New System.Drawing.Point(19, 255)
        Me.lbSubStudSearch.Name = "lbSubStudSearch"
        Me.lbSubStudSearch.Size = New System.Drawing.Size(207, 186)
        Me.lbSubStudSearch.TabIndex = 10
        Me.lbSubStudSearch.ValueMember = "StudentID"
        Me.lbSubStudSearch.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(39, 213)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(89, 13)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "IndividualStudent"
        '
        'txtSubStudsSearch
        '
        Me.txtSubStudsSearch.Location = New System.Drawing.Point(19, 229)
        Me.txtSubStudsSearch.Name = "txtSubStudsSearch"
        Me.txtSubStudsSearch.Size = New System.Drawing.Size(142, 20)
        Me.txtSubStudsSearch.TabIndex = 8
        '
        'btnSubSearchPanel
        '
        Me.btnSubSearchPanel.BackColor = System.Drawing.Color.Green
        Me.btnSubSearchPanel.ForeColor = System.Drawing.Color.White
        Me.btnSubSearchPanel.Location = New System.Drawing.Point(3, 17)
        Me.btnSubSearchPanel.Name = "btnSubSearchPanel"
        Me.btnSubSearchPanel.Size = New System.Drawing.Size(75, 41)
        Me.btnSubSearchPanel.TabIndex = 46
        Me.btnSubSearchPanel.Text = "Hide Search Panel"
        Me.btnSubSearchPanel.UseVisualStyleBackColor = False
        '
        'Academics
        '
        Me.Academics.Controls.Add(Me.Button5)
        Me.Academics.Controls.Add(Me.Label58)
        Me.Academics.Controls.Add(Me.cboSubExam)
        Me.Academics.Controls.Add(Me.chkAll)
        Me.Academics.Controls.Add(Me.chkAllStuds)
        Me.Academics.Controls.Add(Me.lbSubs)
        Me.Academics.Controls.Add(Me.Label55)
        Me.Academics.Controls.Add(Me.lsbSubStud)
        Me.Academics.Controls.Add(Me.txtSubSearch)
        Me.Academics.Controls.Add(Me.dgSubStuds)
        Me.Academics.Controls.Add(Me.Label6)
        Me.Academics.Controls.Add(Me.saveSub)
        Me.Academics.Controls.Add(Me.Available_Subjects)
        Me.Academics.Location = New System.Drawing.Point(27, 70)
        Me.Academics.Name = "Academics"
        Me.Academics.Size = New System.Drawing.Size(1318, 634)
        Me.Academics.TabIndex = 32
        Me.Academics.TabStop = False
        Me.Academics.Text = "Academic Details"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.StudentDetails.My.Resources.Resources.search
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(852, 64)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(19, 20)
        Me.Button5.TabIndex = 44
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(526, 30)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(36, 13)
        Me.Label58.TabIndex = 43
        Me.Label58.Text = "Exam:"
        '
        'cboSubExam
        '
        Me.cboSubExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubExam.DisplayMember = "Session"
        Me.cboSubExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubExam.FormattingEnabled = True
        Me.cboSubExam.Location = New System.Drawing.Point(610, 27)
        Me.cboSubExam.Name = "cboSubExam"
        Me.cboSubExam.Size = New System.Drawing.Size(238, 21)
        Me.cboSubExam.TabIndex = 42
        Me.cboSubExam.ValueMember = "Session"
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(359, 533)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(114, 17)
        Me.chkAll.TabIndex = 41
        Me.chkAll.Text = "Select All Subjects"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'chkAllStuds
        '
        Me.chkAllStuds.AutoSize = True
        Me.chkAllStuds.Location = New System.Drawing.Point(49, 533)
        Me.chkAllStuds.Name = "chkAllStuds"
        Me.chkAllStuds.Size = New System.Drawing.Size(203, 17)
        Me.chkAllStuds.TabIndex = 40
        Me.chkAllStuds.Text = "Assign Subjects to Selected Students"
        Me.chkAllStuds.UseVisualStyleBackColor = True
        '
        'lbSubs
        '
        Me.lbSubs.AutoSize = True
        Me.lbSubs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubs.Location = New System.Drawing.Point(46, 54)
        Me.lbSubs.Name = "lbSubs"
        Me.lbSubs.Size = New System.Drawing.Size(73, 18)
        Me.lbSubs.TabIndex = 38
        Me.lbSubs.Text = "Subjects"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(526, 68)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(78, 13)
        Me.Label55.TabIndex = 37
        Me.Label55.Text = "StudentSearch"
        '
        'lsbSubStud
        '
        Me.lsbSubStud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsbSubStud.BackColor = System.Drawing.Color.LightYellow
        Me.lsbSubStud.DisplayMember = "StudName"
        Me.lsbSubStud.FormattingEnabled = True
        Me.lsbSubStud.Location = New System.Drawing.Point(610, 91)
        Me.lsbSubStud.Name = "lsbSubStud"
        Me.lsbSubStud.Size = New System.Drawing.Size(238, 225)
        Me.lsbSubStud.TabIndex = 36
        Me.lsbSubStud.ValueMember = "StudentID"
        Me.lsbSubStud.Visible = False
        '
        'txtSubSearch
        '
        Me.txtSubSearch.Location = New System.Drawing.Point(610, 65)
        Me.txtSubSearch.Name = "txtSubSearch"
        Me.txtSubSearch.Size = New System.Drawing.Size(238, 20)
        Me.txtSubSearch.TabIndex = 35
        '
        'dgSubStuds
        '
        Me.dgSubStuds.AllowUserToAddRows = False
        Me.dgSubStuds.AllowUserToDeleteRows = False
        Me.dgSubStuds.BackgroundColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSubStuds.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgSubStuds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSubStuds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubjectsStudentID, Me.StudentName, Me.EnrolRef})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSubStuds.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgSubStuds.Location = New System.Drawing.Point(529, 91)
        Me.dgSubStuds.Name = "dgSubStuds"
        Me.dgSubStuds.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSubStuds.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgSubStuds.RowTemplate.Height = 24
        Me.dgSubStuds.Size = New System.Drawing.Size(346, 424)
        Me.dgSubStuds.TabIndex = 0
        '
        'SubjectsStudentID
        '
        Me.SubjectsStudentID.DataPropertyName = "StudentID"
        Me.SubjectsStudentID.HeaderText = "StudentID"
        Me.SubjectsStudentID.Name = "SubjectsStudentID"
        Me.SubjectsStudentID.ReadOnly = True
        '
        'StudentName
        '
        Me.StudentName.DataPropertyName = "StudName"
        Me.StudentName.HeaderText = "StudentName"
        Me.StudentName.Name = "StudentName"
        Me.StudentName.ReadOnly = True
        '
        'EnrolRef
        '
        Me.EnrolRef.DataPropertyName = "EnrolRef"
        Me.EnrolRef.HeaderText = "Ref"
        Me.EnrolRef.Name = "EnrolRef"
        Me.EnrolRef.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(353, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Tick the Subjects undertaken by the student in the specified year"
        '
        'saveSub
        '
        Me.saveSub.Location = New System.Drawing.Point(270, 528)
        Me.saveSub.Name = "saveSub"
        Me.saveSub.Size = New System.Drawing.Size(71, 24)
        Me.saveSub.TabIndex = 2
        Me.saveSub.Text = "&Save"
        Me.saveSub.UseVisualStyleBackColor = True
        '
        'Available_Subjects
        '
        Me.Available_Subjects.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Available_Subjects.FormattingEnabled = True
        Me.Available_Subjects.Location = New System.Drawing.Point(49, 91)
        Me.Available_Subjects.Name = "Available_Subjects"
        Me.Available_Subjects.Size = New System.Drawing.Size(424, 424)
        Me.Available_Subjects.TabIndex = 1
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox9.Controls.Add(Me.btnSubClassList)
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Controls.Add(Me.cboSubClass)
        Me.GroupBox9.Controls.Add(Me.cboSubSess)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.cboSubLvl)
        Me.GroupBox9.Controls.Add(Me.Label18)
        Me.GroupBox9.Controls.Add(Me.cboSubProg)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(84, 17)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(871, 47)
        Me.GroupBox9.TabIndex = 22
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Class_Search"
        '
        'btnSubClassList
        '
        Me.btnSubClassList.Location = New System.Drawing.Point(649, 9)
        Me.btnSubClassList.Name = "btnSubClassList"
        Me.btnSubClassList.Size = New System.Drawing.Size(123, 29)
        Me.btnSubClassList.TabIndex = 30
        Me.btnSubClassList.Text = "Refresh Class List"
        Me.btnSubClassList.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Class:"
        '
        'cboSubClass
        '
        Me.cboSubClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubClass.FormattingEnabled = True
        Me.cboSubClass.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboSubClass.Location = New System.Drawing.Point(276, 14)
        Me.cboSubClass.Name = "cboSubClass"
        Me.cboSubClass.Size = New System.Drawing.Size(149, 21)
        Me.cboSubClass.TabIndex = 28
        '
        'cboSubSess
        '
        Me.cboSubSess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubSess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubSess.DisplayMember = "Session"
        Me.cboSubSess.FormattingEnabled = True
        Me.cboSubSess.Location = New System.Drawing.Point(540, 14)
        Me.cboSubSess.Name = "cboSubSess"
        Me.cboSubSess.Size = New System.Drawing.Size(103, 21)
        Me.cboSubSess.TabIndex = 27
        Me.cboSubSess.ValueMember = "Session"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(431, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Level:"
        '
        'cboSubLvl
        '
        Me.cboSubLvl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubLvl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubLvl.FormattingEnabled = True
        Me.cboSubLvl.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboSubLvl.Location = New System.Drawing.Point(479, 14)
        Me.cboSubLvl.Name = "cboSubLvl"
        Me.cboSubLvl.Size = New System.Drawing.Size(55, 21)
        Me.cboSubLvl.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Program:"
        '
        'cboSubProg
        '
        Me.cboSubProg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubProg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubProg.FormattingEnabled = True
        Me.cboSubProg.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cboSubProg.Location = New System.Drawing.Point(69, 14)
        Me.cboSubProg.Name = "cboSubProg"
        Me.cboSubProg.Size = New System.Drawing.Size(154, 21)
        Me.cboSubProg.TabIndex = 1
        '
        'tbPersonalDetails
        '
        Me.tbPersonalDetails.AutoScroll = True
        Me.tbPersonalDetails.BackColor = System.Drawing.Color.White
        Me.tbPersonalDetails.Controls.Add(Me.SplitContainer1)
        Me.tbPersonalDetails.ImageIndex = 5
        Me.tbPersonalDetails.Location = New System.Drawing.Point(4, 23)
        Me.tbPersonalDetails.Name = "tbPersonalDetails"
        Me.tbPersonalDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPersonalDetails.Size = New System.Drawing.Size(1587, 715)
        Me.tbPersonalDetails.TabIndex = 0
        Me.tbPersonalDetails.Tag = "15"
        Me.tbPersonalDetails.Text = "Personal Details"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvEnrol)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button31)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button23)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label24)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstResult)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ttxSearchtext)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStudProfile)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStudSearchPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbAddingStudent)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbEditDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSiblings)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbXtraCurricular)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbMedicalDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbPrevSchoolDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdConnect)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button13)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbClassSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbStudPersonalDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbEnrollmentDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbPic)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbContactDetails)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbNok)
        Me.SplitContainer1.Size = New System.Drawing.Size(1581, 709)
        Me.SplitContainer1.SplitterDistance = 242
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.Tag = "15"
        '
        'tvEnrol
        '
        Me.tvEnrol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvEnrol.Location = New System.Drawing.Point(3, 239)
        Me.tvEnrol.Name = "tvEnrol"
        Me.tvEnrol.Size = New System.Drawing.Size(204, 199)
        Me.tvEnrol.TabIndex = 18
        '
        'Button31
        '
        Me.Button31.BackgroundImage = Global.StudentDetails.My.Resources.Resources.search
        Me.Button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button31.Location = New System.Drawing.Point(173, 86)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(19, 20)
        Me.Button31.TabIndex = 17
        Me.Button31.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(6, 42)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(75, 23)
        Me.Button23.TabIndex = 13
        Me.Button23.Text = "Clear"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 13)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "StudentSearch"
        '
        'lstResult
        '
        Me.lstResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstResult.BackColor = System.Drawing.Color.LightYellow
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(3, 112)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(204, 121)
        Me.lstResult.TabIndex = 11
        Me.lstResult.Visible = False
        '
        'ttxSearchtext
        '
        Me.ttxSearchtext.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ttxSearchtext.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.ttxSearchtext.Location = New System.Drawing.Point(6, 87)
        Me.ttxSearchtext.Name = "ttxSearchtext"
        Me.ttxSearchtext.Size = New System.Drawing.Size(161, 20)
        Me.ttxSearchtext.TabIndex = 5
        '
        'btnStudProfile
        '
        Me.btnStudProfile.BackColor = System.Drawing.Color.Yellow
        Me.btnStudProfile.ForeColor = System.Drawing.Color.Black
        Me.btnStudProfile.Location = New System.Drawing.Point(907, 36)
        Me.btnStudProfile.Name = "btnStudProfile"
        Me.btnStudProfile.Size = New System.Drawing.Size(90, 41)
        Me.btnStudProfile.TabIndex = 47
        Me.btnStudProfile.Text = "View Student " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Profile"
        Me.btnStudProfile.UseVisualStyleBackColor = False
        Me.btnStudProfile.Visible = False
        '
        'btnStudSearchPanel
        '
        Me.btnStudSearchPanel.BackColor = System.Drawing.Color.Green
        Me.btnStudSearchPanel.ForeColor = System.Drawing.Color.White
        Me.btnStudSearchPanel.Location = New System.Drawing.Point(10, 37)
        Me.btnStudSearchPanel.Name = "btnStudSearchPanel"
        Me.btnStudSearchPanel.Size = New System.Drawing.Size(75, 41)
        Me.btnStudSearchPanel.TabIndex = 45
        Me.btnStudSearchPanel.Text = "Hide Search Panel"
        Me.btnStudSearchPanel.UseVisualStyleBackColor = False
        '
        'lbAddingStudent
        '
        Me.lbAddingStudent.AutoSize = True
        Me.lbAddingStudent.BackColor = System.Drawing.Color.Red
        Me.lbAddingStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAddingStudent.ForeColor = System.Drawing.Color.White
        Me.lbAddingStudent.Location = New System.Drawing.Point(817, 37)
        Me.lbAddingStudent.Name = "lbAddingStudent"
        Me.lbAddingStudent.Size = New System.Drawing.Size(84, 40)
        Me.lbAddingStudent.TabIndex = 43
        Me.lbAddingStudent.Text = "ADDING" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "STUDENT"
        Me.lbAddingStudent.Visible = False
        '
        'lbEditDetails
        '
        Me.lbEditDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbEditDetails.AutoSize = True
        Me.lbEditDetails.ForeColor = System.Drawing.Color.Red
        Me.lbEditDetails.Location = New System.Drawing.Point(2, 694)
        Me.lbEditDetails.Name = "lbEditDetails"
        Me.lbEditDetails.Size = New System.Drawing.Size(0, 13)
        Me.lbEditDetails.TabIndex = 41
        '
        'gbSiblings
        '
        Me.gbSiblings.AutoSize = True
        Me.gbSiblings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbSiblings.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbSiblings.Controls.Add(Me.Button8)
        Me.gbSiblings.Controls.Add(Label9)
        Me.gbSiblings.Controls.Add(Me.dgSiblings)
        Me.gbSiblings.Controls.Add(Label68)
        Me.gbSiblings.Controls.Add(Me.cboSibling)
        Me.gbSiblings.Controls.Add(Me.btnAddSibling)
        Me.gbSiblings.Location = New System.Drawing.Point(468, 364)
        Me.gbSiblings.Name = "gbSiblings"
        Me.gbSiblings.Size = New System.Drawing.Size(293, 275)
        Me.gbSiblings.TabIndex = 7
        Me.gbSiblings.TabStop = False
        Me.gbSiblings.Text = "Siblings"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(87, 222)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(97, 34)
        Me.Button8.TabIndex = 24
        Me.Button8.Text = "Delete Selected"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = True
        '
        'dgSiblings
        '
        Me.dgSiblings.AllowUserToAddRows = False
        Me.dgSiblings.AllowUserToDeleteRows = False
        Me.dgSiblings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSiblings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SiblingID, Me.DataGridViewTextBoxColumn6})
        Me.dgSiblings.Location = New System.Drawing.Point(9, 107)
        Me.dgSiblings.MultiSelect = False
        Me.dgSiblings.Name = "dgSiblings"
        Me.dgSiblings.ReadOnly = True
        Me.dgSiblings.Size = New System.Drawing.Size(278, 109)
        Me.dgSiblings.TabIndex = 2
        '
        'SiblingID
        '
        Me.SiblingID.DataPropertyName = "Sibling"
        Me.SiblingID.HeaderText = "SiblingID"
        Me.SiblingID.Name = "SiblingID"
        Me.SiblingID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SiblingName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'cboSibling
        '
        Me.cboSibling.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSibling.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSibling.FormattingEnabled = True
        Me.cboSibling.Location = New System.Drawing.Point(53, 16)
        Me.cboSibling.Name = "cboSibling"
        Me.cboSibling.Size = New System.Drawing.Size(143, 21)
        Me.cboSibling.TabIndex = 0
        '
        'btnAddSibling
        '
        Me.btnAddSibling.Location = New System.Drawing.Point(9, 41)
        Me.btnAddSibling.Name = "btnAddSibling"
        Me.btnAddSibling.Size = New System.Drawing.Size(128, 34)
        Me.btnAddSibling.TabIndex = 1
        Me.btnAddSibling.Text = "Add Sibling"
        Me.btnAddSibling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSibling.UseVisualStyleBackColor = True
        '
        'gbXtraCurricular
        '
        Me.gbXtraCurricular.AutoSize = True
        Me.gbXtraCurricular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbXtraCurricular.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbXtraCurricular.Controls.Add(Label67)
        Me.gbXtraCurricular.Controls.Add(Me.txtHouse)
        Me.gbXtraCurricular.Controls.Add(Me.Button30)
        Me.gbXtraCurricular.Controls.Add(Label71)
        Me.gbXtraCurricular.Controls.Add(Me.txtSports)
        Me.gbXtraCurricular.Location = New System.Drawing.Point(363, 238)
        Me.gbXtraCurricular.Name = "gbXtraCurricular"
        Me.gbXtraCurricular.Size = New System.Drawing.Size(389, 120)
        Me.gbXtraCurricular.TabIndex = 3
        Me.gbXtraCurricular.TabStop = False
        Me.gbXtraCurricular.Text = "Extra Curricular Activities"
        '
        'txtHouse
        '
        Me.txtHouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHouse.Location = New System.Drawing.Point(89, 64)
        Me.txtHouse.Name = "txtHouse"
        Me.txtHouse.Size = New System.Drawing.Size(200, 20)
        Me.txtHouse.TabIndex = 1
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(372, 67)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(11, 34)
        Me.Button30.TabIndex = 5
        Me.Button30.Text = "Add Another Parent/Guardian"
        Me.Button30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button30.UseVisualStyleBackColor = True
        Me.Button30.Visible = False
        '
        'txtSports
        '
        Me.txtSports.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSports.Location = New System.Drawing.Point(89, 17)
        Me.txtSports.Multiline = True
        Me.txtSports.Name = "txtSports"
        Me.txtSports.Size = New System.Drawing.Size(200, 41)
        Me.txtSports.TabIndex = 0
        '
        'gbMedicalDetails
        '
        Me.gbMedicalDetails.AutoSize = True
        Me.gbMedicalDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbMedicalDetails.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbMedicalDetails.Controls.Add(Me.txtMedComments)
        Me.gbMedicalDetails.Controls.Add(Label20)
        Me.gbMedicalDetails.Controls.Add(Me.txtAllergies)
        Me.gbMedicalDetails.Controls.Add(Label45)
        Me.gbMedicalDetails.Controls.Add(Me.txtDocContNumber)
        Me.gbMedicalDetails.Controls.Add(Label23)
        Me.gbMedicalDetails.Controls.Add(Label51)
        Me.gbMedicalDetails.Controls.Add(Me.txtFamilyDoc)
        Me.gbMedicalDetails.Location = New System.Drawing.Point(766, 238)
        Me.gbMedicalDetails.Name = "gbMedicalDetails"
        Me.gbMedicalDetails.Size = New System.Drawing.Size(391, 120)
        Me.gbMedicalDetails.TabIndex = 4
        Me.gbMedicalDetails.TabStop = False
        Me.gbMedicalDetails.Text = "Medical Details"
        '
        'txtMedComments
        '
        Me.txtMedComments.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMedComments.Location = New System.Drawing.Point(122, 81)
        Me.txtMedComments.Multiline = True
        Me.txtMedComments.Name = "txtMedComments"
        Me.txtMedComments.Size = New System.Drawing.Size(263, 20)
        Me.txtMedComments.TabIndex = 3
        '
        'txtAllergies
        '
        Me.txtAllergies.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAllergies.Location = New System.Drawing.Point(122, 60)
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.Size = New System.Drawing.Size(263, 20)
        Me.txtAllergies.TabIndex = 2
        '
        'txtDocContNumber
        '
        Me.txtDocContNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocContNumber.Location = New System.Drawing.Point(122, 38)
        Me.txtDocContNumber.Name = "txtDocContNumber"
        Me.txtDocContNumber.Size = New System.Drawing.Size(263, 20)
        Me.txtDocContNumber.TabIndex = 1
        '
        'txtFamilyDoc
        '
        Me.txtFamilyDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFamilyDoc.Location = New System.Drawing.Point(122, 17)
        Me.txtFamilyDoc.Name = "txtFamilyDoc"
        Me.txtFamilyDoc.Size = New System.Drawing.Size(263, 20)
        Me.txtFamilyDoc.TabIndex = 0
        '
        'gbPrevSchoolDetails
        '
        Me.gbPrevSchoolDetails.AutoSize = True
        Me.gbPrevSchoolDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbPrevSchoolDetails.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbPrevSchoolDetails.Controls.Add(Me.txtPrevSchoolCommnt)
        Me.gbPrevSchoolDetails.Controls.Add(Label37)
        Me.gbPrevSchoolDetails.Controls.Add(Me.txtPrevSchoolContact)
        Me.gbPrevSchoolDetails.Controls.Add(Label38)
        Me.gbPrevSchoolDetails.Controls.Add(Label39)
        Me.gbPrevSchoolDetails.Controls.Add(Me.txtprevSchool)
        Me.gbPrevSchoolDetails.Location = New System.Drawing.Point(12, 242)
        Me.gbPrevSchoolDetails.Name = "gbPrevSchoolDetails"
        Me.gbPrevSchoolDetails.Size = New System.Drawing.Size(344, 116)
        Me.gbPrevSchoolDetails.TabIndex = 2
        Me.gbPrevSchoolDetails.TabStop = False
        Me.gbPrevSchoolDetails.Text = "Previous School Details"
        '
        'txtPrevSchoolCommnt
        '
        Me.txtPrevSchoolCommnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrevSchoolCommnt.Location = New System.Drawing.Point(115, 60)
        Me.txtPrevSchoolCommnt.Multiline = True
        Me.txtPrevSchoolCommnt.Name = "txtPrevSchoolCommnt"
        Me.txtPrevSchoolCommnt.Size = New System.Drawing.Size(223, 37)
        Me.txtPrevSchoolCommnt.TabIndex = 2
        '
        'txtPrevSchoolContact
        '
        Me.txtPrevSchoolContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrevSchoolContact.Location = New System.Drawing.Point(115, 38)
        Me.txtPrevSchoolContact.Name = "txtPrevSchoolContact"
        Me.txtPrevSchoolContact.Size = New System.Drawing.Size(222, 20)
        Me.txtPrevSchoolContact.TabIndex = 1
        '
        'txtprevSchool
        '
        Me.txtprevSchool.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtprevSchool.Location = New System.Drawing.Point(115, 16)
        Me.txtprevSchool.Name = "txtprevSchool"
        Me.txtprevSchool.Size = New System.Drawing.Size(223, 20)
        Me.txtprevSchool.TabIndex = 0
        '
        'Button12
        '
        Me.Button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button12.Location = New System.Drawing.Point(-462, 25593)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(118, 34)
        Me.Button12.TabIndex = 1
        Me.Button12.Text = "Close"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'cmdConnect
        '
        Me.cmdConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConnect.Enabled = False
        Me.cmdConnect.Location = New System.Drawing.Point(-710, 25593)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(118, 34)
        Me.cmdConnect.TabIndex = 3
        Me.cmdConnect.Tag = "47"
        Me.cmdConnect.Text = "RefreshPastelLink"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.Location = New System.Drawing.Point(-585, 25593)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(118, 34)
        Me.Button13.TabIndex = 0
        Me.Button13.Text = "Refresh"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.ClassListBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.SchoolInfoBindingNavigatorSaveItem, Me.Print, Me.ToolStripButton14, Me.ToolStripButton8, Me.ToolStripButton13, Me.ToolStripButton15, Me.BindingNavigatorAddNewItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1336, 25)
        Me.BindingNavigator1.TabIndex = 40
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SchoolInfoBindingNavigatorSaveItem
        '
        Me.SchoolInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SchoolInfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("SchoolInfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SchoolInfoBindingNavigatorSaveItem.Name = "SchoolInfoBindingNavigatorSaveItem"
        Me.SchoolInfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SchoolInfoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Print
        '
        Me.Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Print.Image = CType(resources.GetObject("Print.Image"), System.Drawing.Image)
        Me.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(23, 22)
        Me.Print.Text = "Print"
        Me.Print.ToolTipText = "PrintID"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "ImportStudents"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.StudentDetails.My.Resources.Resources.Delete
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        Me.ToolStripButton8.ToolTipText = "Delete"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "LoadFingerPrint"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = Global.StudentDetails.My.Resources.Resources.edit
        Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "Edit Student"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = Global.StudentDetails.My.Resources.Resources.AddNew
        Me.BindingNavigatorAddNewItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add Student"
        '
        'gbClassSearch
        '
        Me.gbClassSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbClassSearch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbClassSearch.Controls.Add(Me.txtStudRef)
        Me.gbClassSearch.Controls.Add(Me.txtHiddenStudID)
        Me.gbClassSearch.Controls.Add(Label26)
        Me.gbClassSearch.Controls.Add(Me.cboEnrolClassSearch)
        Me.gbClassSearch.Controls.Add(Me.cboEnrlProgSearch)
        Me.gbClassSearch.Controls.Add(Me.Label17)
        Me.gbClassSearch.Controls.Add(Me.CboEnrSessSearch)
        Me.gbClassSearch.Controls.Add(Me.btnClassReport)
        Me.gbClassSearch.Controls.Add(Me.Label49)
        Me.gbClassSearch.Controls.Add(Me.cboEnrLevSearch)
        Me.gbClassSearch.Location = New System.Drawing.Point(100, 30)
        Me.gbClassSearch.Name = "gbClassSearch"
        Me.gbClassSearch.Size = New System.Drawing.Size(705, 54)
        Me.gbClassSearch.TabIndex = 11
        Me.gbClassSearch.TabStop = False
        Me.gbClassSearch.Text = "ClassSearch"
        '
        'txtStudRef
        '
        Me.txtStudRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudRef.Location = New System.Drawing.Point(587, 21)
        Me.txtStudRef.Name = "txtStudRef"
        Me.txtStudRef.ReadOnly = True
        Me.txtStudRef.Size = New System.Drawing.Size(10, 20)
        Me.txtStudRef.TabIndex = 19
        '
        'txtHiddenStudID
        '
        Me.txtHiddenStudID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassListBindingSource, "StudentID", True))
        Me.txtHiddenStudID.Location = New System.Drawing.Point(587, 21)
        Me.txtHiddenStudID.Name = "txtHiddenStudID"
        Me.txtHiddenStudID.ReadOnly = True
        Me.txtHiddenStudID.Size = New System.Drawing.Size(10, 20)
        Me.txtHiddenStudID.TabIndex = 44
        '
        'cboEnrolClassSearch
        '
        Me.cboEnrolClassSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEnrolClassSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEnrolClassSearch.FormattingEnabled = True
        Me.cboEnrolClassSearch.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboEnrolClassSearch.Location = New System.Drawing.Point(233, 19)
        Me.cboEnrolClassSearch.Name = "cboEnrolClassSearch"
        Me.cboEnrolClassSearch.Size = New System.Drawing.Size(97, 21)
        Me.cboEnrolClassSearch.TabIndex = 42
        '
        'cboEnrlProgSearch
        '
        Me.cboEnrlProgSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEnrlProgSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEnrlProgSearch.DisplayMember = "Forms"
        Me.cboEnrlProgSearch.FormattingEnabled = True
        Me.cboEnrlProgSearch.Location = New System.Drawing.Point(61, 19)
        Me.cboEnrlProgSearch.Name = "cboEnrlProgSearch"
        Me.cboEnrlProgSearch.Size = New System.Drawing.Size(128, 21)
        Me.cboEnrlProgSearch.TabIndex = 4
        Me.cboEnrlProgSearch.ValueMember = "Forms"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Program:"
        '
        'CboEnrSessSearch
        '
        Me.CboEnrSessSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboEnrSessSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboEnrSessSearch.DisplayMember = "Session"
        Me.CboEnrSessSearch.FormattingEnabled = True
        Me.CboEnrSessSearch.Location = New System.Drawing.Point(434, 19)
        Me.CboEnrSessSearch.Name = "CboEnrSessSearch"
        Me.CboEnrSessSearch.Size = New System.Drawing.Size(66, 21)
        Me.CboEnrSessSearch.TabIndex = 5
        Me.CboEnrSessSearch.ValueMember = "Session"
        '
        'btnClassReport
        '
        Me.btnClassReport.BackgroundImage = Global.StudentDetails.My.Resources.Resources.Businessman_1
        Me.btnClassReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClassReport.ForeColor = System.Drawing.Color.White
        Me.btnClassReport.Location = New System.Drawing.Point(509, 13)
        Me.btnClassReport.Name = "btnClassReport"
        Me.btnClassReport.Size = New System.Drawing.Size(64, 35)
        Me.btnClassReport.TabIndex = 6
        Me.btnClassReport.Text = "--"
        Me.btnClassReport.UseVisualStyleBackColor = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(336, 22)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(36, 13)
        Me.Label49.TabIndex = 38
        Me.Label49.Text = "Level:"
        '
        'cboEnrLevSearch
        '
        Me.cboEnrLevSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEnrLevSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEnrLevSearch.FormattingEnabled = True
        Me.cboEnrLevSearch.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboEnrLevSearch.Location = New System.Drawing.Point(378, 19)
        Me.cboEnrLevSearch.Name = "cboEnrLevSearch"
        Me.cboEnrLevSearch.Size = New System.Drawing.Size(50, 21)
        Me.cboEnrLevSearch.TabIndex = 2
        '
        'gbStudPersonalDetails
        '
        Me.gbStudPersonalDetails.AutoSize = True
        Me.gbStudPersonalDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbStudPersonalDetails.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbStudPersonalDetails.Controls.Add(Me.DateOfBirthMaskedTextBox)
        Me.gbStudPersonalDetails.Controls.Add(PlaceOfBirthLabel)
        Me.gbStudPersonalDetails.Controls.Add(Me.PlaceOfBirthTextBox)
        Me.gbStudPersonalDetails.Controls.Add(Me.FeesSourceComboBox)
        Me.gbStudPersonalDetails.Controls.Add(GenderLabel)
        Me.gbStudPersonalDetails.Controls.Add(Me.GenderComboBox)
        Me.gbStudPersonalDetails.Controls.Add(ReligionLabel)
        Me.gbStudPersonalDetails.Controls.Add(StudentSurnameLabel)
        Me.gbStudPersonalDetails.Controls.Add(Me.StudentNameTextBox)
        Me.gbStudPersonalDetails.Controls.Add(Me.StudentSurnameTextBox)
        Me.gbStudPersonalDetails.Controls.Add(StudentNameLabel)
        Me.gbStudPersonalDetails.Controls.Add(NationalIDLabel)
        Me.gbStudPersonalDetails.Controls.Add(Me.NationalIDTextBox)
        Me.gbStudPersonalDetails.Controls.Add(DateOfBirthLabel)
        Me.gbStudPersonalDetails.Controls.Add(StudentIDLabel)
        Me.gbStudPersonalDetails.Controls.Add(Me.StudentIDTextBox)
        Me.gbStudPersonalDetails.Location = New System.Drawing.Point(12, 88)
        Me.gbStudPersonalDetails.Name = "gbStudPersonalDetails"
        Me.gbStudPersonalDetails.Size = New System.Drawing.Size(572, 148)
        Me.gbStudPersonalDetails.TabIndex = 0
        Me.gbStudPersonalDetails.TabStop = False
        Me.gbStudPersonalDetails.Text = "PersonalDetails"
        '
        'DateOfBirthMaskedTextBox
        '
        Me.DateOfBirthMaskedTextBox.Location = New System.Drawing.Point(219, 63)
        Me.DateOfBirthMaskedTextBox.Mask = "00/00/0000"
        Me.DateOfBirthMaskedTextBox.Name = "DateOfBirthMaskedTextBox"
        Me.DateOfBirthMaskedTextBox.Size = New System.Drawing.Size(105, 20)
        Me.DateOfBirthMaskedTextBox.TabIndex = 4
        Me.DateOfBirthMaskedTextBox.ValidatingType = GetType(Date)
        '
        'PlaceOfBirthTextBox
        '
        Me.PlaceOfBirthTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PlaceOfBirthTextBox.Location = New System.Drawing.Point(408, 63)
        Me.PlaceOfBirthTextBox.Name = "PlaceOfBirthTextBox"
        Me.PlaceOfBirthTextBox.Size = New System.Drawing.Size(158, 20)
        Me.PlaceOfBirthTextBox.TabIndex = 5
        '
        'FeesSourceComboBox
        '
        Me.FeesSourceComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FeesSourceComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FeesSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FeesSourceComboBox.FormattingEnabled = True
        Me.FeesSourceComboBox.Items.AddRange(New Object() {"Beam", "Scholarship", "Guardian/Parent"})
        Me.FeesSourceComboBox.Location = New System.Drawing.Point(115, 108)
        Me.FeesSourceComboBox.Name = "FeesSourceComboBox"
        Me.FeesSourceComboBox.Size = New System.Drawing.Size(135, 21)
        Me.FeesSourceComboBox.TabIndex = 7
        '
        'GenderComboBox
        '
        Me.GenderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GenderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"M", "F"})
        Me.GenderComboBox.Location = New System.Drawing.Point(115, 63)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(59, 21)
        Me.GenderComboBox.TabIndex = 3
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentNameTextBox.Location = New System.Drawing.Point(368, 41)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(198, 20)
        Me.StudentNameTextBox.TabIndex = 2
        '
        'StudentSurnameTextBox
        '
        Me.StudentSurnameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentSurnameTextBox.Location = New System.Drawing.Point(115, 41)
        Me.StudentSurnameTextBox.Name = "StudentSurnameTextBox"
        Me.StudentSurnameTextBox.Size = New System.Drawing.Size(183, 20)
        Me.StudentSurnameTextBox.TabIndex = 1
        '
        'NationalIDTextBox
        '
        Me.NationalIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NationalIDTextBox.Location = New System.Drawing.Point(115, 86)
        Me.NationalIDTextBox.Name = "NationalIDTextBox"
        Me.NationalIDTextBox.Size = New System.Drawing.Size(135, 20)
        Me.NationalIDTextBox.TabIndex = 6
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.StudentIDTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.StudentIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentIDTextBox.Location = New System.Drawing.Point(115, 19)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(451, 20)
        Me.StudentIDTextBox.TabIndex = 0
        '
        'gbEnrollmentDetails
        '
        Me.gbEnrollmentDetails.AutoSize = True
        Me.gbEnrollmentDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbEnrollmentDetails.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbEnrollmentDetails.Controls.Add(Label57)
        Me.gbEnrollmentDetails.Controls.Add(Me.cboClass)
        Me.gbEnrollmentDetails.Controls.Add(Me.cboEnrolType)
        Me.gbEnrollmentDetails.Controls.Add(Date_EnrolledLabel1)
        Me.gbEnrollmentDetails.Controls.Add(Me.Date_EnrolledMaskedTextBox)
        Me.gbEnrollmentDetails.Controls.Add(YearLabel1)
        Me.gbEnrollmentDetails.Controls.Add(Me.YearComboBox)
        Me.gbEnrollmentDetails.Controls.Add(ProgramLabel)
        Me.gbEnrollmentDetails.Controls.Add(Me.ProgramComboBox)
        Me.gbEnrollmentDetails.Controls.Add(Me.SessionComboBox)
        Me.gbEnrollmentDetails.Controls.Add(AccountNumberLabel)
        Me.gbEnrollmentDetails.Location = New System.Drawing.Point(590, 90)
        Me.gbEnrollmentDetails.Name = "gbEnrollmentDetails"
        Me.gbEnrollmentDetails.Size = New System.Drawing.Size(249, 146)
        Me.gbEnrollmentDetails.TabIndex = 0
        Me.gbEnrollmentDetails.TabStop = False
        Me.gbEnrollmentDetails.Text = "Enrollment Details"
        '
        'cboClass
        '
        Me.cboClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboClass.Location = New System.Drawing.Point(100, 39)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(143, 21)
        Me.cboClass.TabIndex = 1
        '
        'cboEnrolType
        '
        Me.cboEnrolType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEnrolType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEnrolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnrolType.FormattingEnabled = True
        Me.cboEnrolType.Items.AddRange(New Object() {"Boarding", "Day"})
        Me.cboEnrolType.Location = New System.Drawing.Point(100, 84)
        Me.cboEnrolType.Name = "cboEnrolType"
        Me.cboEnrolType.Size = New System.Drawing.Size(143, 21)
        Me.cboEnrolType.TabIndex = 4
        '
        'Date_EnrolledMaskedTextBox
        '
        Me.Date_EnrolledMaskedTextBox.Location = New System.Drawing.Point(100, 107)
        Me.Date_EnrolledMaskedTextBox.Mask = "00/00/0000"
        Me.Date_EnrolledMaskedTextBox.Name = "Date_EnrolledMaskedTextBox"
        Me.Date_EnrolledMaskedTextBox.Size = New System.Drawing.Size(143, 20)
        Me.Date_EnrolledMaskedTextBox.TabIndex = 5
        Me.Date_EnrolledMaskedTextBox.ValidatingType = GetType(Date)
        '
        'YearComboBox
        '
        Me.YearComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.YearComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.YearComboBox.Location = New System.Drawing.Point(100, 61)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(46, 21)
        Me.YearComboBox.TabIndex = 2
        '
        'ProgramComboBox
        '
        Me.ProgramComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProgramComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProgramComboBox.DisplayMember = "Forms"
        Me.ProgramComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProgramComboBox.FormattingEnabled = True
        Me.ProgramComboBox.Location = New System.Drawing.Point(100, 17)
        Me.ProgramComboBox.Name = "ProgramComboBox"
        Me.ProgramComboBox.Size = New System.Drawing.Size(143, 21)
        Me.ProgramComboBox.TabIndex = 0
        Me.ProgramComboBox.ValueMember = "Forms"
        '
        'SessionComboBox
        '
        Me.SessionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SessionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SessionComboBox.DisplayMember = "Session"
        Me.SessionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SessionComboBox.FormattingEnabled = True
        Me.SessionComboBox.Location = New System.Drawing.Point(153, 61)
        Me.SessionComboBox.Name = "SessionComboBox"
        Me.SessionComboBox.Size = New System.Drawing.Size(90, 21)
        Me.SessionComboBox.TabIndex = 3
        Me.SessionComboBox.ValueMember = "Session"
        '
        'gbPic
        '
        Me.gbPic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbPic.Controls.Add(Me.lnkRemoveImage)
        Me.gbPic.Controls.Add(Me.ImagePictureBox)
        Me.gbPic.Location = New System.Drawing.Point(766, 364)
        Me.gbPic.Name = "gbPic"
        Me.gbPic.Size = New System.Drawing.Size(370, 275)
        Me.gbPic.TabIndex = 9
        Me.gbPic.TabStop = False
        Me.gbPic.Text = "Click to Load Image"
        '
        'lnkRemoveImage
        '
        Me.lnkRemoveImage.AutoSize = True
        Me.lnkRemoveImage.Location = New System.Drawing.Point(162, 247)
        Me.lnkRemoveImage.Name = "lnkRemoveImage"
        Me.lnkRemoveImage.Size = New System.Drawing.Size(79, 13)
        Me.lnkRemoveImage.TabIndex = 40
        Me.lnkRemoveImage.TabStop = True
        Me.lnkRemoveImage.Text = "Remove Image"
        Me.lnkRemoveImage.Visible = False
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ImagePictureBox.BackgroundImage = Global.StudentDetails.My.Resources.Resources.Businessman_1
        Me.ImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImagePictureBox.Location = New System.Drawing.Point(55, 38)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(272, 206)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagePictureBox.TabIndex = 39
        Me.ImagePictureBox.TabStop = False
        '
        'gbContactDetails
        '
        Me.gbContactDetails.AutoSize = True
        Me.gbContactDetails.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbContactDetails.Controls.Add(Me.CityTextBox)
        Me.gbContactDetails.Controls.Add(Label22)
        Me.gbContactDetails.Controls.Add(Me.LocationTextBox)
        Me.gbContactDetails.Controls.Add(Label21)
        Me.gbContactDetails.Controls.Add(EmailAddressLabel)
        Me.gbContactDetails.Controls.Add(Me.EmailAddressTextBox)
        Me.gbContactDetails.Controls.Add(Label53)
        Me.gbContactDetails.Controls.Add(Me.Contact_NumberTextBox)
        Me.gbContactDetails.Controls.Add(Residential_AdressLabel)
        Me.gbContactDetails.Controls.Add(Me.StreetTextBox)
        Me.gbContactDetails.Location = New System.Drawing.Point(845, 93)
        Me.gbContactDetails.Name = "gbContactDetails"
        Me.gbContactDetails.Size = New System.Drawing.Size(312, 143)
        Me.gbContactDetails.TabIndex = 1
        Me.gbContactDetails.TabStop = False
        Me.gbContactDetails.Text = "Contact Details"
        '
        'CityTextBox
        '
        Me.CityTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CityTextBox.Location = New System.Drawing.Point(99, 58)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(207, 20)
        Me.CityTextBox.TabIndex = 2
        '
        'LocationTextBox
        '
        Me.LocationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LocationTextBox.Location = New System.Drawing.Point(99, 36)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(207, 20)
        Me.LocationTextBox.TabIndex = 1
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(99, 103)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(207, 20)
        Me.EmailAddressTextBox.TabIndex = 4
        '
        'Contact_NumberTextBox
        '
        Me.Contact_NumberTextBox.Location = New System.Drawing.Point(99, 81)
        Me.Contact_NumberTextBox.Name = "Contact_NumberTextBox"
        Me.Contact_NumberTextBox.Size = New System.Drawing.Size(207, 20)
        Me.Contact_NumberTextBox.TabIndex = 3
        Me.Contact_NumberTextBox.Text = "2637"
        '
        'StreetTextBox
        '
        Me.StreetTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StreetTextBox.Location = New System.Drawing.Point(99, 14)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(207, 20)
        Me.StreetTextBox.TabIndex = 0
        '
        'gbNok
        '
        Me.gbNok.AutoSize = True
        Me.gbNok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbNok.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbNok.Controls.Add(Me.btnDeleteParent)
        Me.gbNok.Controls.Add(Label3)
        Me.gbNok.Controls.Add(Me.dgStudNok)
        Me.gbNok.Controls.Add(Label60)
        Me.gbNok.Controls.Add(Me.txtNokSurname)
        Me.gbNok.Controls.Add(Me.btnAddNok)
        Me.gbNok.Controls.Add(NOKSurnameLabel)
        Me.gbNok.Controls.Add(Me.NOKRelationTextBox)
        Me.gbNok.Controls.Add(NOKContactNumberLabel)
        Me.gbNok.Controls.Add(Me.NOKContactNumberTextBox)
        Me.gbNok.Controls.Add(NOKAddressLabel)
        Me.gbNok.Controls.Add(Me.NOKOccupationTextBox)
        Me.gbNok.Controls.Add(NokNameLabel)
        Me.gbNok.Controls.Add(Me.NokNameTextBox)
        Me.gbNok.Location = New System.Drawing.Point(5, 364)
        Me.gbNok.Name = "gbNok"
        Me.gbNok.Size = New System.Drawing.Size(457, 275)
        Me.gbNok.TabIndex = 6
        Me.gbNok.TabStop = False
        Me.gbNok.Text = "Parent/Guardian"
        '
        'btnDeleteParent
        '
        Me.btnDeleteParent.Location = New System.Drawing.Point(160, 222)
        Me.btnDeleteParent.Name = "btnDeleteParent"
        Me.btnDeleteParent.Size = New System.Drawing.Size(97, 34)
        Me.btnDeleteParent.TabIndex = 10
        Me.btnDeleteParent.Text = "Delete Selected"
        Me.btnDeleteParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteParent.UseVisualStyleBackColor = True
        '
        'dgStudNok
        '
        Me.dgStudNok.AllowUserToAddRows = False
        Me.dgStudNok.AllowUserToDeleteRows = False
        Me.dgStudNok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStudNok.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NokName, Me.Relationship, Me.Occupation, Me.ContactNumber, Me.NokRef})
        Me.dgStudNok.Location = New System.Drawing.Point(7, 123)
        Me.dgStudNok.MultiSelect = False
        Me.dgStudNok.Name = "dgStudNok"
        Me.dgStudNok.ReadOnly = True
        Me.dgStudNok.Size = New System.Drawing.Size(444, 84)
        Me.dgStudNok.TabIndex = 8
        '
        'NokName
        '
        Me.NokName.DataPropertyName = "Nok_Name"
        Me.NokName.HeaderText = "Name"
        Me.NokName.Name = "NokName"
        Me.NokName.ReadOnly = True
        '
        'Relationship
        '
        Me.Relationship.DataPropertyName = "Nok_RelationShip"
        Me.Relationship.HeaderText = "Relationship"
        Me.Relationship.Name = "Relationship"
        Me.Relationship.ReadOnly = True
        '
        'Occupation
        '
        Me.Occupation.DataPropertyName = "Nok_Employment"
        Me.Occupation.HeaderText = "Occupation"
        Me.Occupation.Name = "Occupation"
        Me.Occupation.ReadOnly = True
        '
        'ContactNumber
        '
        Me.ContactNumber.DataPropertyName = "Nok_Contact"
        Me.ContactNumber.HeaderText = "ContactNumber"
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.ReadOnly = True
        '
        'NokRef
        '
        Me.NokRef.DataPropertyName = "nok_refid"
        Me.NokRef.HeaderText = "Refid"
        Me.NokRef.Name = "NokRef"
        Me.NokRef.ReadOnly = True
        Me.NokRef.Visible = False
        '
        'txtNokSurname
        '
        Me.txtNokSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNokSurname.Location = New System.Drawing.Point(286, 16)
        Me.txtNokSurname.Name = "txtNokSurname"
        Me.txtNokSurname.Size = New System.Drawing.Size(165, 20)
        Me.txtNokSurname.TabIndex = 1
        '
        'btnAddNok
        '
        Me.btnAddNok.Location = New System.Drawing.Point(286, 41)
        Me.btnAddNok.Name = "btnAddNok"
        Me.btnAddNok.Size = New System.Drawing.Size(97, 34)
        Me.btnAddNok.TabIndex = 5
        Me.btnAddNok.Text = "Add Parent/Guardian"
        Me.btnAddNok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNok.UseVisualStyleBackColor = True
        '
        'NOKRelationTextBox
        '
        Me.NOKRelationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOKRelationTextBox.Location = New System.Drawing.Point(95, 38)
        Me.NOKRelationTextBox.Name = "NOKRelationTextBox"
        Me.NOKRelationTextBox.Size = New System.Drawing.Size(177, 20)
        Me.NOKRelationTextBox.TabIndex = 2
        '
        'NOKContactNumberTextBox
        '
        Me.NOKContactNumberTextBox.Location = New System.Drawing.Point(95, 81)
        Me.NOKContactNumberTextBox.Name = "NOKContactNumberTextBox"
        Me.NOKContactNumberTextBox.Size = New System.Drawing.Size(176, 20)
        Me.NOKContactNumberTextBox.TabIndex = 4
        Me.NOKContactNumberTextBox.Text = "2637"
        '
        'NOKOccupationTextBox
        '
        Me.NOKOccupationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOKOccupationTextBox.Location = New System.Drawing.Point(95, 60)
        Me.NOKOccupationTextBox.Name = "NOKOccupationTextBox"
        Me.NOKOccupationTextBox.Size = New System.Drawing.Size(177, 20)
        Me.NOKOccupationTextBox.TabIndex = 3
        '
        'NokNameTextBox
        '
        Me.NokNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NokNameTextBox.Location = New System.Drawing.Point(95, 16)
        Me.NokNameTextBox.Name = "NokNameTextBox"
        Me.NokNameTextBox.Size = New System.Drawing.Size(126, 20)
        Me.NokNameTextBox.TabIndex = 0
        '
        'PersonalDetails
        '
        Me.PersonalDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonalDetails.Controls.Add(Me.tbPersonalDetails)
        Me.PersonalDetails.Controls.Add(Me.tbStudentSubjects)
        Me.PersonalDetails.Controls.Add(Me.Marks)
        Me.PersonalDetails.Controls.Add(Me.tbBilling)
        Me.PersonalDetails.Controls.Add(Me.tbStudentReceipts)
        Me.PersonalDetails.Controls.Add(Me.tbClassTRansferring)
        Me.PersonalDetails.Controls.Add(Me.tbSMS)
        Me.PersonalDetails.Controls.Add(Me.tbStudBehavior)
        Me.PersonalDetails.ImageList = Me.ImageList1
        Me.PersonalDetails.Location = New System.Drawing.Point(8, 3)
        Me.PersonalDetails.Name = "PersonalDetails"
        Me.PersonalDetails.SelectedIndex = 0
        Me.PersonalDetails.Size = New System.Drawing.Size(1595, 742)
        Me.PersonalDetails.TabIndex = 0
        '
        'tbStudBehavior
        '
        Me.tbStudBehavior.Controls.Add(Me.SplitContainer3)
        Me.tbStudBehavior.Location = New System.Drawing.Point(4, 23)
        Me.tbStudBehavior.Name = "tbStudBehavior"
        Me.tbStudBehavior.Padding = New System.Windows.Forms.Padding(3)
        Me.tbStudBehavior.Size = New System.Drawing.Size(1587, 715)
        Me.tbStudBehavior.TabIndex = 12
        Me.tbStudBehavior.Text = "StudentBehavior"
        Me.tbStudBehavior.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Panel1Collapsed = True
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox20)
        Me.SplitContainer3.Size = New System.Drawing.Size(1581, 709)
        Me.SplitContainer3.SplitterDistance = 282
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.GroupBox2)
        Me.GroupBox20.Controls.Add(Me.lbBehaviorRecourCount)
        Me.GroupBox20.Controls.Add(Me.Label63)
        Me.GroupBox20.Controls.Add(Me.lbStudBehaviorName)
        Me.GroupBox20.Controls.Add(Me.txtBehaviorRef)
        Me.GroupBox20.Controls.Add(Me.cboBehaviorPeriod)
        Me.GroupBox20.Controls.Add(Me.lbStudBehavior)
        Me.GroupBox20.Controls.Add(Me.Label41)
        Me.GroupBox20.Controls.Add(Me.btnStudBeaviorSearch)
        Me.GroupBox20.Controls.Add(Me.cboBehaviorClass)
        Me.GroupBox20.Controls.Add(Me.Label40)
        Me.GroupBox20.Controls.Add(Me.btnAddBehavior)
        Me.GroupBox20.Controls.Add(Me.Label29)
        Me.GroupBox20.Controls.Add(Me.txtBehaviorDetails)
        Me.GroupBox20.Controls.Add(Me.cboBehaviorSeverity)
        Me.GroupBox20.Controls.Add(Me.Label15)
        Me.GroupBox20.Controls.Add(Me.mskBehaviorDate)
        Me.GroupBox20.Controls.Add(Me.Label14)
        Me.GroupBox20.Controls.Add(Me.cboBehaviorType)
        Me.GroupBox20.Controls.Add(Me.Label12)
        Me.GroupBox20.Controls.Add(Me.dgStudBehavior)
        Me.GroupBox20.Controls.Add(Me.btnNew)
        Me.GroupBox20.Controls.Add(Me.btnSave)
        Me.GroupBox20.Controls.Add(Me.txtBehaviorStud)
        Me.GroupBox20.Controls.Add(Me.Label59)
        Me.GroupBox20.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(1114, 393)
        Me.GroupBox20.TabIndex = 0
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "StudentBehaviour"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label61)
        Me.GroupBox2.Controls.Add(Me.Label65)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(538, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 91)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Important Information"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(16, 23)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(511, 13)
        Me.Label61.TabIndex = 27
        Me.Label61.Text = "*Only Behavior Records that have been added to the Bahavior Records List will be " &
    "saved to the Database."
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(16, 43)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(415, 13)
        Me.Label65.TabIndex = 29
        Me.Label65.Text = "*To add a Record to the List, Fill in the Details of the Record and Click ""Add Be" &
    "havior"""
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(16, 63)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(351, 13)
        Me.Label50.TabIndex = 13
        Me.Label50.Text = "*Records Highlighted in Yellow, in the List,  are not yet Saved / Updated."
        '
        'lbBehaviorRecourCount
        '
        Me.lbBehaviorRecourCount.AutoSize = True
        Me.lbBehaviorRecourCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBehaviorRecourCount.Location = New System.Drawing.Point(158, 178)
        Me.lbBehaviorRecourCount.Name = "lbBehaviorRecourCount"
        Me.lbBehaviorRecourCount.Size = New System.Drawing.Size(0, 13)
        Me.lbBehaviorRecourCount.TabIndex = 30
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(21, 178)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(136, 13)
        Me.Label63.TabIndex = 28
        Me.Label63.Text = "Behavior Records List:"
        '
        'lbStudBehaviorName
        '
        Me.lbStudBehaviorName.AutoSize = True
        Me.lbStudBehaviorName.Location = New System.Drawing.Point(245, 11)
        Me.lbStudBehaviorName.Name = "lbStudBehaviorName"
        Me.lbStudBehaviorName.Size = New System.Drawing.Size(0, 13)
        Me.lbStudBehaviorName.TabIndex = 2
        Me.lbStudBehaviorName.Visible = False
        '
        'txtBehaviorRef
        '
        Me.txtBehaviorRef.Location = New System.Drawing.Point(483, 128)
        Me.txtBehaviorRef.Name = "txtBehaviorRef"
        Me.txtBehaviorRef.ReadOnly = True
        Me.txtBehaviorRef.Size = New System.Drawing.Size(10, 20)
        Me.txtBehaviorRef.TabIndex = 26
        Me.txtBehaviorRef.TabStop = False
        '
        'cboBehaviorPeriod
        '
        Me.cboBehaviorPeriod.FormattingEnabled = True
        Me.cboBehaviorPeriod.Location = New System.Drawing.Point(92, 57)
        Me.cboBehaviorPeriod.Name = "cboBehaviorPeriod"
        Me.cboBehaviorPeriod.Size = New System.Drawing.Size(150, 21)
        Me.cboBehaviorPeriod.TabIndex = 4
        '
        'lbStudBehavior
        '
        Me.lbStudBehavior.FormattingEnabled = True
        Me.lbStudBehavior.Location = New System.Drawing.Point(245, 12)
        Me.lbStudBehavior.Name = "lbStudBehavior"
        Me.lbStudBehavior.Size = New System.Drawing.Size(232, 108)
        Me.lbStudBehavior.TabIndex = 23
        Me.lbStudBehavior.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(18, 65)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(40, 13)
        Me.Label41.TabIndex = 25
        Me.Label41.Text = "Period:"
        '
        'btnStudBeaviorSearch
        '
        Me.btnStudBeaviorSearch.BackgroundImage = Global.StudentDetails.My.Resources.Resources.search
        Me.btnStudBeaviorSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStudBeaviorSearch.Location = New System.Drawing.Point(223, 11)
        Me.btnStudBeaviorSearch.Name = "btnStudBeaviorSearch"
        Me.btnStudBeaviorSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnStudBeaviorSearch.TabIndex = 1
        Me.btnStudBeaviorSearch.UseVisualStyleBackColor = True
        '
        'cboBehaviorClass
        '
        Me.cboBehaviorClass.FormattingEnabled = True
        Me.cboBehaviorClass.Location = New System.Drawing.Point(92, 34)
        Me.cboBehaviorClass.Name = "cboBehaviorClass"
        Me.cboBehaviorClass.Size = New System.Drawing.Size(150, 21)
        Me.cboBehaviorClass.TabIndex = 3
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(18, 42)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(35, 13)
        Me.Label40.TabIndex = 21
        Me.Label40.Text = "Class:"
        '
        'btnAddBehavior
        '
        Me.btnAddBehavior.BackColor = System.Drawing.Color.Transparent
        Me.btnAddBehavior.Enabled = False
        Me.btnAddBehavior.ForeColor = System.Drawing.Color.Black
        Me.btnAddBehavior.Location = New System.Drawing.Point(414, 112)
        Me.btnAddBehavior.Name = "btnAddBehavior"
        Me.btnAddBehavior.Size = New System.Drawing.Size(63, 50)
        Me.btnAddBehavior.TabIndex = 9
        Me.btnAddBehavior.Text = "Add Behavior"
        Me.btnAddBehavior.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(18, 120)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 13)
        Me.Label29.TabIndex = 19
        Me.Label29.Text = "Details:"
        '
        'txtBehaviorDetails
        '
        Me.txtBehaviorDetails.Location = New System.Drawing.Point(92, 103)
        Me.txtBehaviorDetails.Name = "txtBehaviorDetails"
        Me.txtBehaviorDetails.Size = New System.Drawing.Size(316, 69)
        Me.txtBehaviorDetails.TabIndex = 8
        Me.txtBehaviorDetails.Text = ""
        '
        'cboBehaviorSeverity
        '
        Me.cboBehaviorSeverity.FormattingEnabled = True
        Me.cboBehaviorSeverity.Items.AddRange(New Object() {"Minor", "Medium", "Serious", "Dismissable"})
        Me.cboBehaviorSeverity.Location = New System.Drawing.Point(287, 80)
        Me.cboBehaviorSeverity.Name = "cboBehaviorSeverity"
        Me.cboBehaviorSeverity.Size = New System.Drawing.Size(121, 21)
        Me.cboBehaviorSeverity.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(248, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Type:"
        '
        'mskBehaviorDate
        '
        Me.mskBehaviorDate.Location = New System.Drawing.Point(287, 57)
        Me.mskBehaviorDate.Mask = "00/00/0000"
        Me.mskBehaviorDate.Name = "mskBehaviorDate"
        Me.mskBehaviorDate.Size = New System.Drawing.Size(121, 20)
        Me.mskBehaviorDate.TabIndex = 5
        Me.mskBehaviorDate.ValidatingType = GetType(Date)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(248, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Date:"
        '
        'cboBehaviorType
        '
        Me.cboBehaviorType.FormattingEnabled = True
        Me.cboBehaviorType.Items.AddRange(New Object() {"Merit", "Offence"})
        Me.cboBehaviorType.Location = New System.Drawing.Point(92, 80)
        Me.cboBehaviorType.Name = "cboBehaviorType"
        Me.cboBehaviorType.Size = New System.Drawing.Size(150, 21)
        Me.cboBehaviorType.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Cartegory:"
        '
        'dgStudBehavior
        '
        Me.dgStudBehavior.AllowUserToAddRows = False
        Me.dgStudBehavior.AllowUserToDeleteRows = False
        Me.dgStudBehavior.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStudBehavior.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BehaviorStudent, Me.BehaviorClass, Me.BehaviorPeriod, Me.BehaviorDate, Me.BehaviorType, Me.BehaviorSeverity, Me.BehaviorDetails, Me.BehaviorEdit, Me.BehaviorView, Me.BehaviorDelete, Me.BehaviorRef})
        Me.dgStudBehavior.Location = New System.Drawing.Point(21, 194)
        Me.dgStudBehavior.Name = "dgStudBehavior"
        Me.dgStudBehavior.Size = New System.Drawing.Size(1070, 154)
        Me.dgStudBehavior.TabIndex = 10
        '
        'BehaviorStudent
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BehaviorStudent.DefaultCellStyle = DataGridViewCellStyle13
        Me.BehaviorStudent.HeaderText = "Student"
        Me.BehaviorStudent.Name = "BehaviorStudent"
        Me.BehaviorStudent.ReadOnly = True
        '
        'BehaviorClass
        '
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BehaviorClass.DefaultCellStyle = DataGridViewCellStyle14
        Me.BehaviorClass.HeaderText = "Class"
        Me.BehaviorClass.Name = "BehaviorClass"
        Me.BehaviorClass.ReadOnly = True
        Me.BehaviorClass.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'BehaviorPeriod
        '
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BehaviorPeriod.DefaultCellStyle = DataGridViewCellStyle15
        Me.BehaviorPeriod.HeaderText = "Period"
        Me.BehaviorPeriod.Name = "BehaviorPeriod"
        Me.BehaviorPeriod.ReadOnly = True
        '
        'BehaviorDate
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BehaviorDate.DefaultCellStyle = DataGridViewCellStyle16
        Me.BehaviorDate.HeaderText = "Date"
        Me.BehaviorDate.Name = "BehaviorDate"
        Me.BehaviorDate.ReadOnly = True
        '
        'BehaviorType
        '
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BehaviorType.DefaultCellStyle = DataGridViewCellStyle17
        Me.BehaviorType.HeaderText = "Cartegory"
        Me.BehaviorType.Name = "BehaviorType"
        Me.BehaviorType.ReadOnly = True
        Me.BehaviorType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'BehaviorSeverity
        '
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BehaviorSeverity.DefaultCellStyle = DataGridViewCellStyle18
        Me.BehaviorSeverity.HeaderText = "Type"
        Me.BehaviorSeverity.Name = "BehaviorSeverity"
        Me.BehaviorSeverity.ReadOnly = True
        Me.BehaviorSeverity.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BehaviorSeverity.Width = 75
        '
        'BehaviorDetails
        '
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BehaviorDetails.DefaultCellStyle = DataGridViewCellStyle19
        Me.BehaviorDetails.HeaderText = "Details"
        Me.BehaviorDetails.MaxInputLength = 1000000
        Me.BehaviorDetails.Name = "BehaviorDetails"
        Me.BehaviorDetails.ReadOnly = True
        Me.BehaviorDetails.Width = 200
        '
        'BehaviorEdit
        '
        Me.BehaviorEdit.HeaderText = ""
        Me.BehaviorEdit.Name = "BehaviorEdit"
        Me.BehaviorEdit.Text = "Edit"
        Me.BehaviorEdit.ToolTipText = "Edit or Delete Row"
        Me.BehaviorEdit.Width = 50
        '
        'BehaviorView
        '
        Me.BehaviorView.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BehaviorView.HeaderText = ""
        Me.BehaviorView.Name = "BehaviorView"
        Me.BehaviorView.Text = "ViewReport"
        '
        'BehaviorDelete
        '
        Me.BehaviorDelete.HeaderText = ""
        Me.BehaviorDelete.Name = "BehaviorDelete"
        '
        'BehaviorRef
        '
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BehaviorRef.DefaultCellStyle = DataGridViewCellStyle20
        Me.BehaviorRef.HeaderText = "Reference"
        Me.BehaviorRef.Name = "BehaviorRef"
        Me.BehaviorRef.ReadOnly = True
        Me.BehaviorRef.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(102, 354)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = "Refresh"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(21, 354)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtBehaviorStud
        '
        Me.txtBehaviorStud.Location = New System.Drawing.Point(92, 11)
        Me.txtBehaviorStud.Name = "txtBehaviorStud"
        Me.txtBehaviorStud.Size = New System.Drawing.Size(130, 20)
        Me.txtBehaviorStud.TabIndex = 0
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(18, 14)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(47, 13)
        Me.Label59.TabIndex = 0
        Me.Label59.Text = "Student:"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "&Save"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "&Print"
        '
        'ToolStripButton26
        '
        Me.ToolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton26.Image = CType(resources.GetObject("ToolStripButton26.Image"), System.Drawing.Image)
        Me.ToolStripButton26.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton26.Name = "ToolStripButton26"
        Me.ToolStripButton26.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton26.Text = "&Save"
        '
        'ToolStripButton27
        '
        Me.ToolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton27.Image = CType(resources.GetObject("ToolStripButton27.Image"), System.Drawing.Image)
        Me.ToolStripButton27.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton27.Name = "ToolStripButton27"
        Me.ToolStripButton27.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButton27.Text = "Delete"
        '
        'Cartegory
        '
        Me.Cartegory.DataPropertyName = "Cartegory"
        Me.Cartegory.HeaderText = "Cartegory"
        Me.Cartegory.Name = "Cartegory"
        Me.Cartegory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cartegory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PaymentPeriodsTableAdapter
        '
        Me.PaymentPeriodsTableAdapter.ClearBeforeFill = True
        '
        'Feespayments_detailsTableAdapter
        '
        Me.Feespayments_detailsTableAdapter.ClearBeforeFill = True
        '
        'FeesPayments_HeaderTableAdapter
        '
        Me.FeesPayments_HeaderTableAdapter.ClearBeforeFill = True
        '
        'CurrenciesTableAdapter
        '
        Me.CurrenciesTableAdapter.ClearBeforeFill = True
        '
        'ClassListTableAdapter
        '
        Me.ClassListTableAdapter.ClearBeforeFill = True
        '
        'StudentFeesTranscationsTableAdapter
        '
        Me.StudentFeesTranscationsTableAdapter.ClearBeforeFill = True
        '
        'FeespaymentsdetailsBindingSource1
        '
        Me.FeespaymentsdetailsBindingSource1.DataMember = "feespayments_details"
        Me.FeespaymentsdetailsBindingSource1.DataSource = Me.DsSchool
        '
        'FeesPaymentTypeTableAdapter
        '
        Me.FeesPaymentTypeTableAdapter.ClearBeforeFill = True
        '
        'ctxEnrollment
        '
        Me.ctxEnrollment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cxtToolDeleteEnrollment, Me.cxtToolEditEnrollment, Me.cxtToolCopyEnrollment})
        Me.ctxEnrollment.Name = "ctxEnrollment"
        Me.ctxEnrollment.Size = New System.Drawing.Size(166, 70)
        '
        'cxtToolDeleteEnrollment
        '
        Me.cxtToolDeleteEnrollment.Name = "cxtToolDeleteEnrollment"
        Me.cxtToolDeleteEnrollment.Size = New System.Drawing.Size(165, 22)
        Me.cxtToolDeleteEnrollment.Text = "DeleteEnrollment"
        '
        'cxtToolEditEnrollment
        '
        Me.cxtToolEditEnrollment.Name = "cxtToolEditEnrollment"
        Me.cxtToolEditEnrollment.Size = New System.Drawing.Size(165, 22)
        Me.cxtToolEditEnrollment.Text = "Edit Enrollment"
        '
        'cxtToolCopyEnrollment
        '
        Me.cxtToolCopyEnrollment.Name = "cxtToolCopyEnrollment"
        Me.cxtToolCopyEnrollment.Size = New System.Drawing.Size(165, 22)
        Me.cxtToolCopyEnrollment.Text = "Copy Enrollment"
        '
        'FrmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1615, 788)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmdLink)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.cmdRefreshPastel)
        Me.Controls.Add(Me.PersonalDetails)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "-+"
        CType(Me.StudentFeesTranscationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBilling.ResumeLayout(False)
        Me.SplitContainer8.Panel1.ResumeLayout(False)
        Me.SplitContainer8.Panel1.PerformLayout()
        Me.SplitContainer8.Panel2.ResumeLayout(False)
        Me.SplitContainer8.Panel2.PerformLayout()
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer8.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.dgPayType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeesPaymentTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBilling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.tbClassTRansferring.ResumeLayout(False)
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel1.PerformLayout()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbActPerClass.ResumeLayout(False)
        Me.gbActPerClass.PerformLayout()
        Me.tbSMS.ResumeLayout(False)
        Me.SplitContainer10.Panel1.ResumeLayout(False)
        Me.SplitContainer10.Panel1.PerformLayout()
        Me.SplitContainer10.Panel2.ResumeLayout(False)
        Me.SplitContainer10.Panel2.PerformLayout()
        CType(Me.SplitContainer10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer10.ResumeLayout(False)
        Me.othernot.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.specific.ResumeLayout(False)
        Me.specific.PerformLayout()
        Me.gbSendingOptions.ResumeLayout(False)
        Me.gbSendingOptions.PerformLayout()
        Me.gbFeesSms.ResumeLayout(False)
        Me.gbFeesSms.PerformLayout()
        CType(Me.dgClassList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.Marks.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.StudentMarks.ResumeLayout(False)
        Me.StudentMarks.PerformLayout()
        CType(Me.gvMarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbStudentReceipts.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ClassListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dgFessDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrenciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentPeriodsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeespaymentsdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.FeesPaymentsHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFeesPay.ResumeLayout(False)
        Me.gbFeesPay.PerformLayout()
        Me.pnlReversal.ResumeLayout(False)
        Me.pnlReversal.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.tbStudentSubjects.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Academics.ResumeLayout(False)
        Me.Academics.PerformLayout()
        CType(Me.dgSubStuds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.tbPersonalDetails.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbSiblings.ResumeLayout(False)
        Me.gbSiblings.PerformLayout()
        CType(Me.dgSiblings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbXtraCurricular.ResumeLayout(False)
        Me.gbXtraCurricular.PerformLayout()
        Me.gbMedicalDetails.ResumeLayout(False)
        Me.gbMedicalDetails.PerformLayout()
        Me.gbPrevSchoolDetails.ResumeLayout(False)
        Me.gbPrevSchoolDetails.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.gbClassSearch.ResumeLayout(False)
        Me.gbClassSearch.PerformLayout()
        Me.gbStudPersonalDetails.ResumeLayout(False)
        Me.gbStudPersonalDetails.PerformLayout()
        Me.gbEnrollmentDetails.ResumeLayout(False)
        Me.gbEnrollmentDetails.PerformLayout()
        Me.gbPic.ResumeLayout(False)
        Me.gbPic.PerformLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbContactDetails.ResumeLayout(False)
        Me.gbContactDetails.PerformLayout()
        Me.gbNok.ResumeLayout(False)
        Me.gbNok.PerformLayout()
        CType(Me.dgStudNok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PersonalDetails.ResumeLayout(False)
        Me.tbStudBehavior.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgStudBehavior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeespaymentsdetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxEnrollment.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    '  Friend WithEvents StudOtherPaymentsTableAdapter As SMS.dsschoolTableAdapters.StudOtherPaymentsTableAdapter
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    '   Friend WithEvents StudentLeavingTableAdapter As SMS.dsschoolTableAdapters.StudentLeavingTableAdapter
    ' Friend WithEvents StudCertificatesTableAdapter As SMS.dsschoolTableAdapters.StudCertificatesTableAdapter
    '  Friend WithEvents StudOtherTableAdapter As SMS.dsschoolTableAdapters.studOtherTableAdapter
    Friend WithEvents ToolStripButton21 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator41 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton22 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator42 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator43 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel13 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel14 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel15 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton23 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator44 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton24 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator45 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton25 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator46 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton26 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator47 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton27 As System.Windows.Forms.ToolStripButton

    ' Friend WithEvents Fees_BreakdownTableAdapter As SMS.dsschoolTableAdapters.Fees_BreakdownTableAdapter

    ' Friend WithEvents DepositsTableAdapter As SMS.dsschoolTableAdapters.DepositsTableAdapter

    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    'Friend WithEvents dsschool2 As SMS.dsschool2
    ' Friend WithEvents StudentPersonalDetailsTableAdapter1 As SMS.dsschool2TableAdapters.StudentPersonalDetailsTableAdapter
    '  Friend WithEvents Forms1TableAdapter As SMS.dsschoolTableAdapters.forms1TableAdapter
    '  Friend WithEvents ProgramDurationsTableAdapter As SMS.dsschoolTableAdapters.ProgramDurationsTableAdapter
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog


    Friend WithEvents StudentFullNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog



    Friend WithEvents cmdRefreshPastel As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button

    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdLink As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    '  Friend WithEvents SchoolsessionsBindingSource As System.Windows.Forms.BindingSource

    ' Friend WithEvents Feespayments_detailsBindingSource As System.Windows.Forms.BindingSource


    Friend WithEvents tbBilling As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer8 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnClearBillStuds As System.Windows.Forms.Button
    Friend WithEvents lbBillStud As System.Windows.Forms.ListBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtBillStud As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnPerfomBilling As System.Windows.Forms.Button
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents cboBillType As System.Windows.Forms.ComboBox
    Friend WithEvents dgBilling As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents cboBillingSess As System.Windows.Forms.ComboBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents cboBillingProg As System.Windows.Forms.ComboBox
    Friend WithEvents tbClassTRansferring As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents tbSMS As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer10 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbStudNotif As System.Windows.Forms.ListBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtStudNotif As System.Windows.Forms.TextBox
    Friend WithEvents othernot As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents cboSchoolSections As System.Windows.Forms.ComboBox
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents characters As System.Windows.Forms.Label
    Friend WithEvents specific As System.Windows.Forms.Panel
    Friend WithEvents gbSendingOptions As System.Windows.Forms.GroupBox
    Friend WithEvents rbStudOnly As System.Windows.Forms.RadioButton
    Friend WithEvents rbBoth As System.Windows.Forms.RadioButton
    Friend WithEvents rbNextOfKinOnly As System.Windows.Forms.RadioButton
    Friend WithEvents gbFeesSms As System.Windows.Forms.GroupBox
    Friend WithEvents chkDebtorsOnly As System.Windows.Forms.CheckBox
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents dgClassList As System.Windows.Forms.DataGridView
    Friend WithEvents StudentIDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentSurnameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SessionDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOKContactNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSmsSess As System.Windows.Forms.ComboBox
    Friend WithEvents cboSmsSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cboSmslevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cboSmdClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents StudentIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentSurnameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SessionDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marks As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents tvEditMarks As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboMarkLevel As System.Windows.Forms.ComboBox
    Friend WithEvents StudentMarks As System.Windows.Forms.GroupBox
    Friend WithEvents cboRemarks As System.Windows.Forms.ComboBox
    Friend WithEvents cboMarkExam As System.Windows.Forms.ComboBox
    Friend WithEvents lbDetails As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents lbstuds As System.Windows.Forms.ListBox
    Friend WithEvents txtstudsearch As System.Windows.Forms.TextBox
    Friend WithEvents gdStudents As System.Windows.Forms.DataGridView
    Friend WithEvents btnEnterMarks As System.Windows.Forms.Button
    Friend WithEvents tbStudentReceipts As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbSeacrhFees As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents Insert As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents Reprint As System.Windows.Forms.ToolStripButton
    Friend WithEvents Edt As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbFeesPay As System.Windows.Forms.GroupBox
    Friend WithEvents cboCashType As System.Windows.Forms.ComboBox
    Friend WithEvents mskpaydate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblfullname As System.Windows.Forms.Label
    Friend WithEvents ReceiptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents FeesDateSearch As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cboReceiptSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtReceiptSearch As System.Windows.Forms.TextBox
    Friend WithEvents tbStudentSubjects As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents lbSubStudSearch As System.Windows.Forms.ListBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtSubStudsSearch As System.Windows.Forms.TextBox
    Friend WithEvents Academics As System.Windows.Forms.GroupBox
    Friend WithEvents lbSubs As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents lsbSubStud As System.Windows.Forms.ListBox
    Friend WithEvents txtSubSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgSubStuds As System.Windows.Forms.DataGridView
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentSurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SessionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents saveSub As System.Windows.Forms.Button
    Friend WithEvents Available_Subjects As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSubSess As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboSubLvl As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboSubProg As System.Windows.Forms.ComboBox
    Friend WithEvents tbPersonalDetails As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
    Friend WithEvents ttxSearchtext As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SchoolInfoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Print As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbClassSearch As System.Windows.Forms.GroupBox
    Friend WithEvents CboEnrSessSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnClassReport As System.Windows.Forms.Button
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents cboEnrLevSearch As System.Windows.Forms.ComboBox
    Friend WithEvents gbStudPersonalDetails As System.Windows.Forms.GroupBox
    Friend WithEvents DateOfBirthMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PlaceOfBirthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FeesSourceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StudentNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentSurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NationalIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gbEnrollmentDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Date_EnrolledMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProgramComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SessionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents gbPic As System.Windows.Forms.GroupBox
    Friend WithEvents ImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents gbContactDetails As System.Windows.Forms.GroupBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Contact_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StreetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gbNok As System.Windows.Forms.GroupBox
    Friend WithEvents NOKRelationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOKContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOKOccupationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NokNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PersonalDetails As System.Windows.Forms.TabControl
    Friend WithEvents PostDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbBillSearch As System.Windows.Forms.ListBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents txtStudBillSearch As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReasonForReversalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents lbStudFees As System.Windows.Forms.ListBox
    Friend WithEvents gbActPerClass As System.Windows.Forms.GroupBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents cboOldClassprog As System.Windows.Forms.ComboBox
    Friend WithEvents cboOldClassSess As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents cboOldClassCls As System.Windows.Forms.ComboBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cboOldclassForm As System.Windows.Forms.ComboBox
    Friend WithEvents chkoldclass As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkSelectOldClassStuds As System.Windows.Forms.CheckBox
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents cbonewclassprog As System.Windows.Forms.ComboBox
    Friend WithEvents cbonewclassSess As System.Windows.Forms.ComboBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents cbonewclassform As System.Windows.Forms.ComboBox
    Friend WithEvents chknewclass As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Chkmitype As System.Windows.Forms.CheckBox
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents chkBilPeriods As System.Windows.Forms.CheckedListBox
    Friend WithEvents dgPayType As System.Windows.Forms.DataGridView
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents rec_import As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn

    Friend WithEvents Button27 As System.Windows.Forms.Button

    Friend WithEvents rvOnScreenDatPay As Microsoft.Reporting.WinForms.ReportViewer

    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbStudMarks As System.Windows.Forms.ListBox
    Friend WithEvents txtStudMarksSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents cboBillingLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSmsClubs As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rbSmsGroups As System.Windows.Forms.RadioButton
    Friend WithEvents rbsmsSection As System.Windows.Forms.RadioButton
    Friend WithEvents rbSmsNotAtDb As System.Windows.Forms.RadioButton
    Friend WithEvents rbsmsClass As System.Windows.Forms.RadioButton

    Friend WithEvents btnFeesClassMovePrev As System.Windows.Forms.Button
    Friend WithEvents btnFeesClassMoveNext As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cbofeessessSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cbofeesLvlsearch As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboFeesCartegory As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboBillingClass As System.Windows.Forms.ComboBox

    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboEnrolType As System.Windows.Forms.ComboBox
    Friend WithEvents cboEnrlProgSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboFeesProgSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents gbPrevSchoolDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrevSchoolContact As System.Windows.Forms.TextBox
    Friend WithEvents txtprevSchool As System.Windows.Forms.TextBox
    Friend WithEvents gbMedicalDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtDocContNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtFamilyDoc As System.Windows.Forms.TextBox
    Friend WithEvents txtPrevSchoolCommnt As System.Windows.Forms.TextBox
    Friend WithEvents tbStudBehavior As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBehaviorStud As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents gvMarks As System.Windows.Forms.DataGridView
    Friend WithEvents chkdef As System.Windows.Forms.CheckBox
    Friend WithEvents StudentIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentSurnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents chkAllStuds As System.Windows.Forms.CheckBox
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents cboClass As ComboBox
    Friend WithEvents txtNokSurname As TextBox
    Friend WithEvents btnAddNok As Button
    Friend WithEvents gbXtraCurricular As GroupBox
    Friend WithEvents txtHouse As TextBox
    Friend WithEvents Button30 As Button
    Friend WithEvents txtSports As TextBox
    Friend WithEvents txtMedComments As TextBox
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents gbSiblings As GroupBox
    Friend WithEvents dgSiblings As DataGridView
    Friend WithEvents cboSibling As ComboBox
    Friend WithEvents btnAddSibling As Button
    Friend WithEvents dgStudNok As DataGridView
    Friend WithEvents lbEditDetails As Label
    Friend WithEvents cboEnrolClassSearch As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSubClass As ComboBox
    Friend WithEvents Label58 As Label
    Friend WithEvents cboSubExam As ComboBox
    Friend WithEvents btnSubClassList As Button
    Friend WithEvents cbofeesClassSearch As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents lbFeesHidedStudID As TextBox
    Friend WithEvents txtFeesStudID As TextBox
    Friend WithEvents btnFessClass As Button
    Friend WithEvents txtPos As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbStudRef As TextBox
    Friend WithEvents pnlReversal As Panel
    Friend WithEvents rvOnScreenStat As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnCancelAllLines As Button
    Friend WithEvents btnUpdateAllLines As Button
    Friend WithEvents btnBillingClass As Button
    Friend WithEvents cboMarkClass As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboMarkProg As ComboBox
    Friend WithEvents btnMarkClass As Button
    Friend WithEvents cboMarkSubject As ComboBox
    Friend WithEvents cboMarkSession As ComboBox
    Friend WithEvents MarksStudentID As DataGridViewTextBoxColumn
    Friend WithEvents MarksStudName As DataGridViewTextBoxColumn
    Friend WithEvents MarksEnrolRef As DataGridViewTextBoxColumn
    Friend WithEvents btnLeavingStudent As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbonewClassCls As ComboBox
    Friend WithEvents lbStudDeactivationSearch As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label95 As Label
    Friend WithEvents txtDeactivationStudSearch As TextBox
    Friend WithEvents Button31 As Button
    Friend WithEvents txtHiddenStudID As TextBox
    Friend WithEvents ToolStripButton15 As ToolStripButton
    Friend WithEvents SiblingID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtStudRef As TextBox
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents Button8 As Button
    Friend WithEvents btnDeleteParent As Button
    Friend WithEvents lbAddingStudent As Label
    Friend WithEvents SubjectsStudentID As DataGridViewTextBoxColumn
    Friend WithEvents StudentName As DataGridViewTextBoxColumn
    Friend WithEvents EnrolRef As DataGridViewTextBoxColumn
    Friend WithEvents NokName As DataGridViewTextBoxColumn
    Friend WithEvents Relationship As DataGridViewTextBoxColumn
    Friend WithEvents Occupation As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents NokRef As DataGridViewTextBoxColumn
    Friend WithEvents PaymentPeriodsBindingSource As BindingSource
    Friend WithEvents BillingStudentID As DataGridViewTextBoxColumn
    Friend WithEvents BillingStudName As DataGridViewTextBoxColumn
    Friend WithEvents BillingEnrolRef As DataGridViewTextBoxColumn
    Friend WithEvents chkMaintainPrevSubjects As CheckBox
    Friend WithEvents btnStudSearchPanel As Button
    Friend WithEvents btnSubSearchPanel As Button
    Friend WithEvents Button34 As Button
    Friend WithEvents Button36 As Button
    Friend WithEvents Button37 As Button
    Friend WithEvents Button38 As Button
    Friend WithEvents lnkRemoveImage As LinkLabel
    Friend WithEvents Button39 As Button
    Friend WithEvents dgStudBehavior As DataGridView
    Friend WithEvents cboBehaviorClass As ComboBox
    Friend WithEvents Label40 As Label
    Friend WithEvents btnAddBehavior As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents txtBehaviorDetails As RichTextBox
    Friend WithEvents cboBehaviorSeverity As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents mskBehaviorDate As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cboBehaviorType As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbStudBehavior As ListBox
    Friend WithEvents btnStudBeaviorSearch As Button
    Friend WithEvents cboBehaviorPeriod As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents Period As DataGridViewComboBoxColumn
    Friend WithEvents Reference As DataGridViewTextBoxColumn
    Friend WithEvents Cartegory As DataGridViewComboBoxColumn
    Friend WithEvents DsSchool As dsSchool
    Friend WithEvents PaymentPeriodsTableAdapter As dsSchoolTableAdapters.PaymentPeriodsTableAdapter
    Friend WithEvents FeespaymentsdetailsBindingSource As BindingSource
    Friend WithEvents Feespayments_detailsTableAdapter As dsSchoolTableAdapters.feespayments_detailsTableAdapter
    Friend WithEvents FeesPaymentsHeaderBindingSource As BindingSource
    Friend WithEvents FeesPayments_HeaderTableAdapter As dsSchoolTableAdapters.FeesPayments_HeaderTableAdapter
    Friend WithEvents CurrenciesBindingSource As BindingSource
    Friend WithEvents CurrenciesTableAdapter As dsSchoolTableAdapters.CurrenciesTableAdapter
    Friend WithEvents ClassListBindingSource As BindingSource
    Friend WithEvents ClassListTableAdapter As dsSchoolTableAdapters.ClassListTableAdapter
    Friend WithEvents StudentFeesTranscationsBindingSource As BindingSource
    Friend WithEvents StudentFeesTranscationsTableAdapter As dsSchoolTableAdapters.StudentFeesTranscationsTableAdapter
    Friend WithEvents FeespaymentsdetailsBindingSource1 As BindingSource
    Friend WithEvents FeesPaymentTypeBindingSource As BindingSource
    Friend WithEvents FeesPaymentTypeTableAdapter As dsSchoolTableAdapters.FeesPaymentTypeTableAdapter
    Friend WithEvents txtBehaviorRef As TextBox
    Friend WithEvents BehaviorStudent As DataGridViewTextBoxColumn
    Friend WithEvents BehaviorClass As DataGridViewTextBoxColumn
    Friend WithEvents BehaviorPeriod As DataGridViewTextBoxColumn
    Friend WithEvents BehaviorDate As DataGridViewTextBoxColumn
    Friend WithEvents BehaviorType As DataGridViewTextBoxColumn
    Friend WithEvents BehaviorSeverity As DataGridViewTextBoxColumn
    Friend WithEvents BehaviorDetails As DataGridViewTextBoxColumn
    Friend WithEvents BehaviorEdit As DataGridViewButtonColumn
    Friend WithEvents BehaviorView As DataGridViewButtonColumn
    Friend WithEvents BehaviorDelete As DataGridViewButtonColumn
    Friend WithEvents BehaviorRef As DataGridViewTextBoxColumn
    Friend WithEvents Label50 As Label
    Friend WithEvents Payment As DataGridViewComboBoxColumn
    Friend WithEvents BillingAmount As DataGridViewTextBoxColumn
    Friend WithEvents dgFessDetails As DataGridView
    Friend WithEvents Cart As DataGridViewComboBoxColumn
    Friend WithEvents Amnt As DataGridViewTextBoxColumn
    Friend WithEvents Currency As DataGridViewComboBoxColumn
    Friend WithEvents Perd As DataGridViewComboBoxColumn
    Friend WithEvents Ref As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
    Friend WithEvents LineRef As DataGridViewTextBoxColumn
    Friend WithEvents lbStudBehaviorName As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents lbBehaviorRecourCount As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnStudBillingStudentSearch As Button
    Friend WithEvents btnStudentMarksSearch As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents tvEnrol As TreeView
    Friend WithEvents ctxEnrollment As ContextMenuStrip
    Friend WithEvents cxtToolDeleteEnrollment As ToolStripMenuItem
    Friend WithEvents cxtToolEditEnrollment As ToolStripMenuItem
    Friend WithEvents cxtToolCopyEnrollment As ToolStripMenuItem
    Friend WithEvents btnStudProfile As Button
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Subject As DataGridViewTextBoxColumn
    Friend WithEvents CourseMark As DataGridViewTextBoxColumn
    Friend WithEvents ExamMark As DataGridViewTextBoxColumn
    Friend WithEvents Comment As DataGridViewTextBoxColumn
    Friend WithEvents MultiComment As DataGridViewComboBoxColumn
    Friend WithEvents Effort As DataGridViewComboBoxColumn
    Friend WithEvents Remarks As DataGridViewComboBoxColumn
    Friend WithEvents MarkRef As DataGridViewTextBoxColumn
    Friend WithEvents chkTransScreenShowReceipts As CheckBox
    Friend WithEvents chkTransScreenShowInvoices As CheckBox
    Friend WithEvents Label66 As Label
    Friend WithEvents cboBBFCutOffPeriod As ComboBox
End Class
