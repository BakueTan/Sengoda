<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNonStud
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
        Me.components = New System.ComponentModel.Container
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim IDnumberLabel As System.Windows.Forms.Label
        Dim AccLabel As System.Windows.Forms.Label
        Dim MobileNumberLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim ReasonForReversalLabel As System.Windows.Forms.Label
        Dim PostDateLabel As System.Windows.Forms.Label
        Dim CashTypeLabel As System.Windows.Forms.Label
        Dim Label35 As System.Windows.Forms.Label
        Dim ReceiptLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim IDnumberLabel1 As System.Windows.Forms.Label
        Dim AccountLabel As System.Windows.Forms.Label
        Dim MobileNumberLabel1 As System.Windows.Forms.Label
        Dim EmaiAddressLabel As System.Windows.Forms.Label
        Dim BankAccntLabel As System.Windows.Forms.Label
        Dim BankLabel As System.Windows.Forms.Label
        Dim BranchLabel As System.Windows.Forms.Label
        Dim NameLabel1 As System.Windows.Forms.Label
        Dim AddressLabel1 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNonStud))
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        '     Me.DebtorsTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '   Me.dsReports = New SMS.dsReports
        '     Me.CreditorsStatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '   Me.dsIncomeExpenditureReports = New SMS.dsIncomeExpenditureReports
        '   Me.NeawYearStatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.rvDebtStatement = New Microsoft.Reporting.WinForms.ReportViewer
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.cboFeesCartegory = New System.Windows.Forms.ComboBox
        ' Me.PaymentType2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '   Me.SchoolDataSet = New SMS.schoolDataSet
        Me.Label16 = New System.Windows.Forms.Label
        Me.FeesDateSearch = New System.Windows.Forms.MaskedTextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.cboReceiptSearch = New System.Windows.Forms.ComboBox
        Me.txtReceiptSearch = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.lbDebtors2 = New System.Windows.Forms.ListBox
        Me.dgFessDetails = New System.Windows.Forms.DataGridView
        Me.CartegoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReferenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Period = New System.Windows.Forms.DataGridViewComboBoxColumn
        '  Me.PaymentPeriodsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '   Me.DsSchool = New SMS.dsSchool
        Me.Comment = New System.Windows.Forms.DataGridViewTextBoxColumn
        '   Me.FeespaymentsdetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.DsFees = New SMS.dsFees
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Del = New System.Windows.Forms.ToolStripButton
        '  Me.FeesPaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Save = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.Delete = New System.Windows.Forms.ToolStripButton
        Me.Reprint = New System.Windows.Forms.ToolStripButton
        Me.Edt = New System.Windows.Forms.ToolStripButton
        Me.rec_import = New System.Windows.Forms.ToolStripButton
        Me.gbFeesPay = New System.Windows.Forms.GroupBox
        Me.lbDebtorName = New System.Windows.Forms.Label
        Me.lbDebtors = New System.Windows.Forms.ListBox
        Me.cmbDebtorType = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.ReasonForReversalComboBox = New System.Windows.Forms.ComboBox
        Me.PostDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.cboCashType = New System.Windows.Forms.ComboBox
        Me.mskpaydate = New System.Windows.Forms.MaskedTextBox
        Me.ReceiptTextBox = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.lbExSearchCred = New System.Windows.Forms.ListBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.cboExpenditureSearchCart = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cboExpSearch = New System.Windows.Forms.ComboBox
        Me.txtExpenditureSearch = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgExpenses = New System.Windows.Forms.DataGridView
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Feespaymentsdetails1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.DsFees1 = New SMS.dsFees
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Delrt = New System.Windows.Forms.ToolStripButton
        Me.FeesPaymentsHeader1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.pay_save = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton
        Me.gbExpenses = New System.Windows.Forms.GroupBox
        Me.lbExpCreditors = New System.Windows.Forms.ListBox
        Me.txtExpCreditor = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lbCustomerSearch = New System.Windows.Forms.ListBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Add = New System.Windows.Forms.ToolStripButton
        Me.DebtorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '    Me.DsIncomeExpenditure = New SMS.dsIncomeExpenditure
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.IDnumberTextBox = New System.Windows.Forms.TextBox
        Me.AccTextBox = New System.Windows.Forms.TextBox
        Me.MobileNumberTextBox = New System.Windows.Forms.TextBox
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboInvCart = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbdebtors3 = New System.Windows.Forms.ListBox
        Me.txtInvAmount = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDebtName = New System.Windows.Forms.TextBox
        Me.cboInvPeriod = New System.Windows.Forms.ComboBox
        Me.mskInvDate = New System.Windows.Forms.MaskedTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.AddressTextBox1 = New System.Windows.Forms.TextBox
        Me.CreditorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameTextBox1 = New System.Windows.Forms.TextBox
        Me.BindingNavigator4 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AddNew = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton23 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton24 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton25 = New System.Windows.Forms.ToolStripButton
        Me.IDnumberTextBox1 = New System.Windows.Forms.TextBox
        Me.AccountTextBox = New System.Windows.Forms.TextBox
        Me.MobileNumberTextBox1 = New System.Windows.Forms.TextBox
        Me.EmaiAddressTextBox = New System.Windows.Forms.TextBox
        Me.BankAccntTextBox = New System.Windows.Forms.TextBox
        Me.BankTextBox = New System.Windows.Forms.TextBox
        Me.BranchTextBox = New System.Windows.Forms.TextBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnCrInvNew = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtCreditorInv = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cboCreInvCart = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.lbCreditors = New System.Windows.Forms.ListBox
        Me.txtCredInvAmnt = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtCreditor = New System.Windows.Forms.TextBox
        Me.cboCreditorPrd = New System.Windows.Forms.ComboBox
        Me.txtCreInvDate = New System.Windows.Forms.MaskedTextBox
        Me.btnCrdInvSave = New System.Windows.Forms.Button
        Me.PaymentTypeBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        '   Me.FeesPaymentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.PaymentType3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.PaymentTypeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.PaymentTypeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        ' Me.PaymentTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        ' Me.FeesPaymentsTableAdapter = New SMS.schoolDataSetTableAdapters.FeesPaymentsTableAdapter
        '  Me.FeespaymentsdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.Feespayments_detailsTableAdapter = New SMS.dsSchoolTableAdapters.feespayments_detailsTableAdapter
        '  Me.PaymentTypeTableAdapter = New SMS.dsSchoolTableAdapters.PaymentTypeTableAdapter
        '  Me.PaymentType2TableAdapter = New SMS.schoolDataSetTableAdapters.PaymentType2TableAdapter
        '    Me.PaymentPeriodsTableAdapter = New SMS.dsSchoolTableAdapters.PaymentPeriodsTableAdapter
        ' Me.DebtorsTableAdapter = New SMS.dsIncomeExpenditureTableAdapters.DebtorsTableAdapter
        '  Me.TableAdapterManager = New SMS.dsIncomeExpenditureTableAdapters.TableAdapterManager
        '  Me.DebtorsTransactionsTableAdapter = New SMS.dsReportsTableAdapters.DebtorsTransactionsTableAdapter
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        '  Me.StudentContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        ' Me.StudentContactsTableAdapter = New SMS.dsReportsTableAdapters.StudentContactsTableAdapter
        ' Me.NeawYearStatementTableAdapter = New SMS.dsReportsTableAdapters.NeawYearStatementTableAdapter
        ' Me.FeesPaymentsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        ' Me.PaymentTypeTableAdapter1 = New SMS.schoolDataSetTableAdapters.PaymentTypeTableAdapter
        '   Me.PaymentType3TableAdapter = New SMS.schoolDataSetTableAdapters.PaymentType3TableAdapter
        '  Me.Feespaymentsdetails1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.FeespaymentsdetailsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        ' Me.Feespayments_detailsTableAdapter1 = New SMS.dsFeesTableAdapters.feespayments_detailsTableAdapter
        '  Me.Feespayments_details1TableAdapter = New SMS.dsFeesTableAdapters.feespayments_details1TableAdapter
        ' Me.FeesPayments_Header1TableAdapter = New SMS.dsFeesTableAdapters.FeesPayments_Header1TableAdapter
        '  Me.CreditorsTableAdapter = New SMS.dsIncomeExpenditureTableAdapters.CreditorsTableAdapter
        '    Me.CreditorsStatementTableAdapter = New SMS.dsIncomeExpenditureReportsTableAdapters.CreditorsStatementTableAdapter
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        IDnumberLabel = New System.Windows.Forms.Label
        AccLabel = New System.Windows.Forms.Label
        MobileNumberLabel = New System.Windows.Forms.Label
        EmailAddressLabel = New System.Windows.Forms.Label
        ReasonForReversalLabel = New System.Windows.Forms.Label
        PostDateLabel = New System.Windows.Forms.Label
        CashTypeLabel = New System.Windows.Forms.Label
        Label35 = New System.Windows.Forms.Label
        ReceiptLabel = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        Label12 = New System.Windows.Forms.Label
        Label13 = New System.Windows.Forms.Label
        IDnumberLabel1 = New System.Windows.Forms.Label
        AccountLabel = New System.Windows.Forms.Label
        MobileNumberLabel1 = New System.Windows.Forms.Label
        EmaiAddressLabel = New System.Windows.Forms.Label
        BankAccntLabel = New System.Windows.Forms.Label
        BankLabel = New System.Windows.Forms.Label
        BranchLabel = New System.Windows.Forms.Label
        NameLabel1 = New System.Windows.Forms.Label
        AddressLabel1 = New System.Windows.Forms.Label
        Label20 = New System.Windows.Forms.Label
        Label21 = New System.Windows.Forms.Label
        Label22 = New System.Windows.Forms.Label
        '  CType(Me.DebtorsTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.dsReports, System.ComponentModel.ISupportInitialize).BeginInit()
        '   CType(Me.CreditorsStatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        '  CType(Me.dsIncomeExpenditureReports, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.NeawYearStatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        '  CType(Me.PaymentType2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        '  CType(Me.dgFessDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.PaymentPeriodsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.FeespaymentsdetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.DsFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        ' CType(Me.FeesPaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFeesPay.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Feespaymentsdetails1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        '  CType(Me.DsFees1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.FeesPaymentsHeader1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbExpenses.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.DebtorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.DsIncomeExpenditure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CreditorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        '   CType(Me.PaymentTypeBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.FeesPaymentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.PaymentType3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.PaymentTypeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.PaymentTypeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.PaymentTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.FeespaymentsdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.StudentContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        '  CType(Me.FeesPaymentsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.Feespaymentsdetails1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.FeespaymentsdetailsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(8, 155)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(110, 13)
        Label3.TabIndex = 24
        Label3.Text = "Reason For Reversal:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(48, 118)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(57, 13)
        Label4.TabIndex = 23
        Label4.Text = "Post Date:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(34, 56)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(71, 13)
        Label6.TabIndex = 10
        Label6.Text = "ExpenseDate"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(60, 88)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(45, 13)
        Label7.TabIndex = 12
        Label7.Text = "Invoice:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(171, 85)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(171, 113)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 2
        AddressLabel.Text = "Address:"
        '
        'IDnumberLabel
        '
        IDnumberLabel.AutoSize = True
        IDnumberLabel.Location = New System.Drawing.Point(171, 145)
        IDnumberLabel.Name = "IDnumberLabel"
        IDnumberLabel.Size = New System.Drawing.Size(56, 13)
        IDnumberLabel.TabIndex = 4
        IDnumberLabel.Text = "IDnumber:"
        '
        'AccLabel
        '
        AccLabel.AutoSize = True
        AccLabel.Location = New System.Drawing.Point(171, 58)
        AccLabel.Name = "AccLabel"
        AccLabel.Size = New System.Drawing.Size(50, 13)
        AccLabel.TabIndex = 6
        AccLabel.Text = "Account:"
        '
        'MobileNumberLabel
        '
        MobileNumberLabel.AutoSize = True
        MobileNumberLabel.Location = New System.Drawing.Point(171, 175)
        MobileNumberLabel.Name = "MobileNumberLabel"
        MobileNumberLabel.Size = New System.Drawing.Size(81, 13)
        MobileNumberLabel.TabIndex = 8
        MobileNumberLabel.Text = "Mobile Number:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(171, 201)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(76, 13)
        EmailAddressLabel.TabIndex = 10
        EmailAddressLabel.Text = "Email Address:"
        '
        'ReasonForReversalLabel
        '
        ReasonForReversalLabel.AutoSize = True
        ReasonForReversalLabel.Location = New System.Drawing.Point(28, 218)
        ReasonForReversalLabel.Name = "ReasonForReversalLabel"
        ReasonForReversalLabel.Size = New System.Drawing.Size(110, 13)
        ReasonForReversalLabel.TabIndex = 24
        ReasonForReversalLabel.Text = "Reason For Reversal:"
        '
        'PostDateLabel
        '
        PostDateLabel.AutoSize = True
        PostDateLabel.Location = New System.Drawing.Point(68, 190)
        PostDateLabel.Name = "PostDateLabel"
        PostDateLabel.Size = New System.Drawing.Size(57, 13)
        PostDateLabel.TabIndex = 23
        PostDateLabel.Text = "Post Date:"
        '
        'CashTypeLabel
        '
        CashTypeLabel.AutoSize = True
        CashTypeLabel.Location = New System.Drawing.Point(68, 88)
        CashTypeLabel.Name = "CashTypeLabel"
        CashTypeLabel.Size = New System.Drawing.Size(52, 13)
        CashTypeLabel.TabIndex = 23
        CashTypeLabel.Text = "PayType:"
        '
        'Label35
        '
        Label35.AutoSize = True
        Label35.Location = New System.Drawing.Point(68, 123)
        Label35.Name = "Label35"
        Label35.Size = New System.Drawing.Size(70, 13)
        Label35.TabIndex = 10
        Label35.Text = "ReceiptDate:"
        '
        'ReceiptLabel
        '
        ReceiptLabel.AutoSize = True
        ReceiptLabel.Location = New System.Drawing.Point(68, 156)
        ReceiptLabel.Name = "ReceiptLabel"
        ReceiptLabel.Size = New System.Drawing.Size(47, 13)
        ReceiptLabel.TabIndex = 12
        ReceiptLabel.Text = "Receipt:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(68, 169)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(46, 13)
        Label10.TabIndex = 24
        Label10.Text = "Amount:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(68, 67)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(40, 13)
        Label12.TabIndex = 23
        Label12.Text = "Period:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(68, 100)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(68, 13)
        Label13.TabIndex = 10
        Label13.Text = "InvoiceDate:"
        '
        'IDnumberLabel1
        '
        IDnumberLabel1.AutoSize = True
        IDnumberLabel1.Location = New System.Drawing.Point(179, 102)
        IDnumberLabel1.Name = "IDnumberLabel1"
        IDnumberLabel1.Size = New System.Drawing.Size(56, 13)
        IDnumberLabel1.TabIndex = 0
        IDnumberLabel1.Text = "IDnumber:"
        '
        'AccountLabel
        '
        AccountLabel.AutoSize = True
        AccountLabel.Location = New System.Drawing.Point(179, 133)
        AccountLabel.Name = "AccountLabel"
        AccountLabel.Size = New System.Drawing.Size(50, 13)
        AccountLabel.TabIndex = 2
        AccountLabel.Text = "Account:"
        '
        'MobileNumberLabel1
        '
        MobileNumberLabel1.AutoSize = True
        MobileNumberLabel1.Location = New System.Drawing.Point(179, 161)
        MobileNumberLabel1.Name = "MobileNumberLabel1"
        MobileNumberLabel1.Size = New System.Drawing.Size(81, 13)
        MobileNumberLabel1.TabIndex = 4
        MobileNumberLabel1.Text = "Mobile Number:"
        '
        'EmaiAddressLabel
        '
        EmaiAddressLabel.AutoSize = True
        EmaiAddressLabel.Location = New System.Drawing.Point(179, 193)
        EmaiAddressLabel.Name = "EmaiAddressLabel"
        EmaiAddressLabel.Size = New System.Drawing.Size(74, 13)
        EmaiAddressLabel.TabIndex = 6
        EmaiAddressLabel.Text = "Emai Address:"
        '
        'BankAccntLabel
        '
        BankAccntLabel.AutoSize = True
        BankAccntLabel.Location = New System.Drawing.Point(179, 244)
        BankAccntLabel.Name = "BankAccntLabel"
        BankAccntLabel.Size = New System.Drawing.Size(66, 13)
        BankAccntLabel.TabIndex = 8
        BankAccntLabel.Text = "Bank Accnt:"
        '
        'BankLabel
        '
        BankLabel.AutoSize = True
        BankLabel.Location = New System.Drawing.Point(179, 272)
        BankLabel.Name = "BankLabel"
        BankLabel.Size = New System.Drawing.Size(35, 13)
        BankLabel.TabIndex = 10
        BankLabel.Text = "Bank:"
        '
        'BranchLabel
        '
        BranchLabel.AutoSize = True
        BranchLabel.Location = New System.Drawing.Point(179, 301)
        BranchLabel.Name = "BranchLabel"
        BranchLabel.Size = New System.Drawing.Size(44, 13)
        BranchLabel.TabIndex = 12
        BranchLabel.Text = "Branch:"
        '
        'NameLabel1
        '
        NameLabel1.AutoSize = True
        NameLabel1.Location = New System.Drawing.Point(179, 70)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(38, 13)
        NameLabel1.TabIndex = 43
        NameLabel1.Text = "Name:"
        '
        'AddressLabel1
        '
        AddressLabel1.AutoSize = True
        AddressLabel1.Location = New System.Drawing.Point(179, 218)
        AddressLabel1.Name = "AddressLabel1"
        AddressLabel1.Size = New System.Drawing.Size(48, 13)
        AddressLabel1.TabIndex = 44
        AddressLabel1.Text = "Address:"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(68, 192)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(46, 13)
        Label20.TabIndex = 24
        Label20.Text = "Amount:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(68, 67)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(40, 13)
        Label21.TabIndex = 23
        Label21.Text = "Period:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(71, 124)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(68, 13)
        Label22.TabIndex = 10
        Label22.Text = "InvoiceDate:"
        '
        'DebtorsTransactionsBindingSource
        '
        '    Me.DebtorsTransactionsBindingSource.DataMember = "DebtorsTransactions"
        '    Me.DebtorsTransactionsBindingSource.DataSource = Me.dsReports
        '
        'dsReports
        '
        '   Me.dsReports.DataSetName = "dsReports"
        '  Me.dsReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CreditorsStatementBindingSource
        '
        '   Me.CreditorsStatementBindingSource.DataMember = "CreditorsStatement"
        '  Me.CreditorsStatementBindingSource.DataSource = Me.dsIncomeExpenditureReports
        '
        'dsIncomeExpenditureReports
        '
        '    Me.dsIncomeExpenditureReports.DataSetName = "dsIncomeExpenditureReports"
        '   Me.dsIncomeExpenditureReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NeawYearStatementBindingSource
        '
        '   Me.NeawYearStatementBindingSource.DataMember = "NeawYearStatement"
        '  Me.NeawYearStatementBindingSource.DataSource = Me.dsReports
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1186, 560)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1178, 534)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Receipts"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.rvDebtStatement)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox17)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox7)
        Me.SplitContainer1.Size = New System.Drawing.Size(1172, 528)
        Me.SplitContainer1.SplitterDistance = 420
        Me.SplitContainer1.TabIndex = 0
        '
        'rvDebtStatement
        '
        Me.rvDebtStatement.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "dsReports_DebtorsTransactions"
        '   ReportDataSource4.Value = Me.DebtorsTransactionsBindingSource
        Me.rvDebtStatement.LocalReport.DataSources.Add(ReportDataSource4)
        Me.rvDebtStatement.LocalReport.ReportEmbeddedResource = "SMS.rptDebtorsOnScreenStatement.rdlc"
        Me.rvDebtStatement.Location = New System.Drawing.Point(0, 0)
        Me.rvDebtStatement.Name = "rvDebtStatement"
        Me.rvDebtStatement.Size = New System.Drawing.Size(420, 528)
        Me.rvDebtStatement.TabIndex = 0
        Me.rvDebtStatement.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
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
        Me.GroupBox17.Location = New System.Drawing.Point(3, 23)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(600, 41)
        Me.GroupBox17.TabIndex = 25
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Payment Search"
        '
        'cboFeesCartegory
        '
        Me.cboFeesCartegory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFeesCartegory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        '  Me.cboFeesCartegory.DataSource = Me.PaymentType2BindingSource
        Me.cboFeesCartegory.DisplayMember = "Payment"
        Me.cboFeesCartegory.FormattingEnabled = True
        Me.cboFeesCartegory.Location = New System.Drawing.Point(495, 11)
        Me.cboFeesCartegory.Name = "cboFeesCartegory"
        Me.cboFeesCartegory.Size = New System.Drawing.Size(104, 21)
        Me.cboFeesCartegory.TabIndex = 7
        Me.cboFeesCartegory.ValueMember = "Payment"
        '
        'PaymentType2BindingSource
        '
        '   Me.PaymentType2BindingSource.DataMember = "PaymentType2"
        '  Me.PaymentType2BindingSource.DataSource = Me.SchoolDataSet
        '
        'SchoolDataSet
        '
        '  Me.SchoolDataSet.DataSetName = "schoolDataSet"
        '   Me.SchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(416, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 6
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
        Me.cboReceiptSearch.Items.AddRange(New Object() {"Date", "Debtor", "Receipt"})
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
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.lbDebtors2)
        Me.GroupBox7.Controls.Add(Me.dgFessDetails)
        Me.GroupBox7.Controls.Add(Me.BindingNavigator2)
        Me.GroupBox7.Controls.Add(Me.gbFeesPay)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 83)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(614, 443)
        Me.GroupBox7.TabIndex = 24
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Other Payments"
        '
        'lbDebtors2
        '
        Me.lbDebtors2.FormattingEnabled = True
        Me.lbDebtors2.Location = New System.Drawing.Point(385, 0)
        Me.lbDebtors2.Name = "lbDebtors2"
        Me.lbDebtors2.Size = New System.Drawing.Size(192, 95)
        Me.lbDebtors2.TabIndex = 26
        Me.lbDebtors2.Visible = False
        '
        'dgFessDetails
        '
        Me.dgFessDetails.AutoGenerateColumns = False
        Me.dgFessDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFessDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CartegoryDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.ReferenceDataGridViewTextBoxColumn, Me.Period, Me.Comment})
        '  Me.dgFessDetails.DataSource = Me.FeespaymentsdetailsBindingSource1
        Me.dgFessDetails.Enabled = False
        Me.dgFessDetails.Location = New System.Drawing.Point(18, 298)
        Me.dgFessDetails.Name = "dgFessDetails"
        Me.dgFessDetails.Size = New System.Drawing.Size(590, 125)
        Me.dgFessDetails.TabIndex = 1
        '
        'CartegoryDataGridViewTextBoxColumn
        '
        Me.CartegoryDataGridViewTextBoxColumn.DataPropertyName = "Cartegory"
        '  Me.CartegoryDataGridViewTextBoxColumn.DataSource = Me.PaymentType2BindingSource
        Me.CartegoryDataGridViewTextBoxColumn.DisplayMember = "Payment"
        Me.CartegoryDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.CartegoryDataGridViewTextBoxColumn.HeaderText = "Cartegory"
        Me.CartegoryDataGridViewTextBoxColumn.Name = "CartegoryDataGridViewTextBoxColumn"
        Me.CartegoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CartegoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CartegoryDataGridViewTextBoxColumn.ValueMember = "Payment"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'ReferenceDataGridViewTextBoxColumn
        '
        Me.ReferenceDataGridViewTextBoxColumn.DataPropertyName = "Reference"
        Me.ReferenceDataGridViewTextBoxColumn.HeaderText = "Reference"
        Me.ReferenceDataGridViewTextBoxColumn.Name = "ReferenceDataGridViewTextBoxColumn"
        '
        'Period
        '
        Me.Period.DataPropertyName = "Period"
        '  Me.Period.DataSource = Me.PaymentPeriodsBindingSource
        Me.Period.DisplayMember = "Description"
        Me.Period.HeaderText = "Period"
        Me.Period.Name = "Period"
        Me.Period.ValueMember = "Period"
        '
        'PaymentPeriodsBindingSource
        '
        ' Me.PaymentPeriodsBindingSource.DataMember = "PaymentPeriods"
        ' Me.PaymentPeriodsBindingSource.DataSource = Me.DsSchool
        '
        'DsSchool
        '
        '   Me.DsSchool.DataSetName = "dsSchool"
        '    Me.DsSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Comment
        '
        Me.Comment.DataPropertyName = "Comment"
        Me.Comment.HeaderText = "Comment"
        Me.Comment.Name = "Comment"
        '
        'FeespaymentsdetailsBindingSource1
        '
        '   Me.FeespaymentsdetailsBindingSource1.DataMember = "feespayments_details"
        '  Me.FeespaymentsdetailsBindingSource1.DataSource = Me.DsFees
        '
        'DsFees
        '
        '  Me.DsFees.DataSetName = "dsFees"
        '  Me.DsFees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.Del
        '   Me.BindingNavigator2.BindingSource = Me.FeesPaymentsBindingSource
        Me.BindingNavigator2.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator1, Me.ToolStripTextBox2, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator3, Me.Del, Me.Save, Me.ToolStripSeparator4, Me.Delete, Me.Reprint, Me.Edt, Me.rec_import})
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
        'Del
        '
        Me.Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Del.Image = CType(resources.GetObject("Del.Image"), System.Drawing.Image)
        Me.Del.Name = "Del"
        Me.Del.RightToLeftAutoMirrorImage = True
        Me.Del.Size = New System.Drawing.Size(23, 22)
        Me.Del.Text = "Add new"
        '
        'FeesPaymentsBindingSource
        '
        '    Me.FeesPaymentsBindingSource.DataMember = "FeesPayments"
        '  Me.FeesPaymentsBindingSource.DataSource = Me.SchoolDataSet
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
        '  Me.Edt.Image = Global.SMS.My.Resources.Resources.edit
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
        Me.gbFeesPay.Controls.Add(Me.lbDebtorName)
        Me.gbFeesPay.Controls.Add(Me.lbDebtors)
        Me.gbFeesPay.Controls.Add(Me.cmbDebtorType)
        Me.gbFeesPay.Controls.Add(Me.Label8)
        Me.gbFeesPay.Controls.Add(Me.Label1)
        Me.gbFeesPay.Controls.Add(Me.TxtName)
        Me.gbFeesPay.Controls.Add(ReasonForReversalLabel)
        Me.gbFeesPay.Controls.Add(Me.ReasonForReversalComboBox)
        Me.gbFeesPay.Controls.Add(PostDateLabel)
        Me.gbFeesPay.Controls.Add(Me.PostDateDateTimePicker)
        Me.gbFeesPay.Controls.Add(CashTypeLabel)
        Me.gbFeesPay.Controls.Add(Me.cboCashType)
        Me.gbFeesPay.Controls.Add(Me.mskpaydate)
        Me.gbFeesPay.Controls.Add(Label35)
        Me.gbFeesPay.Controls.Add(ReceiptLabel)
        Me.gbFeesPay.Controls.Add(Me.ReceiptTextBox)
        Me.gbFeesPay.Enabled = False
        Me.gbFeesPay.Location = New System.Drawing.Point(85, 44)
        Me.gbFeesPay.Name = "gbFeesPay"
        Me.gbFeesPay.Size = New System.Drawing.Size(414, 248)
        Me.gbFeesPay.TabIndex = 0
        Me.gbFeesPay.TabStop = False
        '
        'lbDebtorName
        '
        Me.lbDebtorName.AutoSize = True
        Me.lbDebtorName.Location = New System.Drawing.Point(255, 55)
        Me.lbDebtorName.Name = "lbDebtorName"
        Me.lbDebtorName.Size = New System.Drawing.Size(0, 13)
        Me.lbDebtorName.TabIndex = 30
        '
        'lbDebtors
        '
        Me.lbDebtors.FormattingEnabled = True
        Me.lbDebtors.Location = New System.Drawing.Point(144, 71)
        Me.lbDebtors.Name = "lbDebtors"
        Me.lbDebtors.Size = New System.Drawing.Size(170, 82)
        Me.lbDebtors.TabIndex = 29
        Me.lbDebtors.Visible = False
        '
        'cmbDebtorType
        '
        Me.cmbDebtorType.FormattingEnabled = True
        Me.cmbDebtorType.Items.AddRange(New Object() {"Registered", "OneTime"})
        Me.cmbDebtorType.Location = New System.Drawing.Point(145, 20)
        Me.cmbDebtorType.Name = "cmbDebtorType"
        Me.cmbDebtorType.Size = New System.Drawing.Size(103, 21)
        Me.cmbDebtorType.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "DebtorType:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Name : "
        '
        'TxtName
        '
        '  Me.TxtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsBindingSource, "StudentID", True))
        Me.TxtName.Location = New System.Drawing.Point(144, 49)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(104, 20)
        Me.TxtName.TabIndex = 0
        '
        'ReasonForReversalComboBox
        '
        Me.ReasonForReversalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ReasonForReversalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        '  Me.ReasonForReversalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsBindingSource, "ReasonForReversal", True))
        Me.ReasonForReversalComboBox.Enabled = False
        Me.ReasonForReversalComboBox.FormattingEnabled = True
        Me.ReasonForReversalComboBox.Items.AddRange(New Object() {"Refund", "Error In Capturing", "Test Receipt", "Others"})
        Me.ReasonForReversalComboBox.Location = New System.Drawing.Point(144, 210)
        Me.ReasonForReversalComboBox.Name = "ReasonForReversalComboBox"
        Me.ReasonForReversalComboBox.Size = New System.Drawing.Size(141, 21)
        Me.ReasonForReversalComboBox.TabIndex = 5
        '
        'PostDateDateTimePicker
        '
        Me.PostDateDateTimePicker.CustomFormat = ""
        '   Me.PostDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsBindingSource, "PostDate", True))
        Me.PostDateDateTimePicker.Enabled = False
        Me.PostDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PostDateDateTimePicker.Location = New System.Drawing.Point(145, 183)
        Me.PostDateDateTimePicker.Name = "PostDateDateTimePicker"
        Me.PostDateDateTimePicker.Size = New System.Drawing.Size(153, 20)
        Me.PostDateDateTimePicker.TabIndex = 4
        Me.PostDateDateTimePicker.Value = New Date(2015, 2, 10, 0, 0, 0, 0)
        '
        'cboCashType
        '
        Me.cboCashType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCashType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        '   Me.cboCashType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsBindingSource, "CashType", True))
        Me.cboCashType.DisplayMember = "CashType"
        Me.cboCashType.FormattingEnabled = True
        Me.cboCashType.Items.AddRange(New Object() {"Cash", "Bank"})
        Me.cboCashType.Location = New System.Drawing.Point(145, 80)
        Me.cboCashType.Name = "cboCashType"
        Me.cboCashType.Size = New System.Drawing.Size(121, 21)
        Me.cboCashType.TabIndex = 1
        Me.cboCashType.ValueMember = "CashType"
        '
        'mskpaydate
        '
        '   Me.mskpaydate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsBindingSource, "Date", True))
        Me.mskpaydate.Location = New System.Drawing.Point(145, 116)
        Me.mskpaydate.Mask = "00/00/0000"
        Me.mskpaydate.Name = "mskpaydate"
        Me.mskpaydate.Size = New System.Drawing.Size(129, 20)
        Me.mskpaydate.TabIndex = 2
        Me.mskpaydate.ValidatingType = GetType(Date)
        '
        'ReceiptTextBox
        '
        '   Me.ReceiptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsBindingSource, "Receipt", True))
        Me.ReceiptTextBox.Location = New System.Drawing.Point(144, 149)
        Me.ReceiptTextBox.Name = "ReceiptTextBox"
        Me.ReceiptTextBox.ReadOnly = True
        Me.ReceiptTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ReceiptTextBox.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1178, 534)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Expenditure"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.ReportViewer1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.lbExSearchCred)
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox9)
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer3.Size = New System.Drawing.Size(1172, 528)
        Me.SplitContainer3.SplitterDistance = 385
        Me.SplitContainer3.TabIndex = 2
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "dsIncomeExpenditureReports_CreditorsStatement"
        ' ReportDataSource3.Value = Me.CreditorsStatementBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SMS.rptCreditorsOnScreenStatement.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(385, 528)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'lbExSearchCred
        '
        Me.lbExSearchCred.FormattingEnabled = True
        Me.lbExSearchCred.Location = New System.Drawing.Point(283, 60)
        Me.lbExSearchCred.Name = "lbExSearchCred"
        Me.lbExSearchCred.Size = New System.Drawing.Size(316, 82)
        Me.lbExSearchCred.TabIndex = 27
        Me.lbExSearchCred.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox9.Controls.Add(Me.cboExpenditureSearchCart)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox9.Controls.Add(Me.Label25)
        Me.GroupBox9.Controls.Add(Me.cboExpSearch)
        Me.GroupBox9.Controls.Add(Me.txtExpenditureSearch)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(24, 18)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(603, 41)
        Me.GroupBox9.TabIndex = 26
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Expenditure Search"
        '
        'cboExpenditureSearchCart
        '
        Me.cboExpenditureSearchCart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboExpenditureSearchCart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        '   Me.cboExpenditureSearchCart.DataSource = Me.PaymentType2BindingSource
        Me.cboExpenditureSearchCart.DisplayMember = "Payment"
        Me.cboExpenditureSearchCart.FormattingEnabled = True
        Me.cboExpenditureSearchCart.Location = New System.Drawing.Point(495, 11)
        Me.cboExpenditureSearchCart.Name = "cboExpenditureSearchCart"
        Me.cboExpenditureSearchCart.Size = New System.Drawing.Size(104, 21)
        Me.cboExpenditureSearchCart.TabIndex = 7
        Me.cboExpenditureSearchCart.ValueMember = "Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cartegory : "
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(218, 15)
        Me.MaskedTextBox2.Mask = "00/00/0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(141, 20)
        Me.MaskedTextBox2.TabIndex = 3
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        Me.MaskedTextBox2.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 19)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 13)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "SearchOption"
        '
        'cboExpSearch
        '
        Me.cboExpSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboExpSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboExpSearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboExpSearch.FormattingEnabled = True
        Me.cboExpSearch.ItemHeight = 13
        Me.cboExpSearch.Items.AddRange(New Object() {"Date", "Creditor", "Invoice"})
        Me.cboExpSearch.Location = New System.Drawing.Point(91, 14)
        Me.cboExpSearch.Name = "cboExpSearch"
        Me.cboExpSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboExpSearch.TabIndex = 1
        '
        'txtExpenditureSearch
        '
        Me.txtExpenditureSearch.Location = New System.Drawing.Point(218, 15)
        Me.txtExpenditureSearch.Name = "txtExpenditureSearch"
        Me.txtExpenditureSearch.Size = New System.Drawing.Size(192, 20)
        Me.txtExpenditureSearch.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dgExpenses)
        Me.GroupBox1.Controls.Add(Me.BindingNavigator1)
        Me.GroupBox1.Controls.Add(Me.gbExpenses)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 390)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Expenses"
        '
        'dgExpenses
        '
        Me.dgExpenses.AutoGenerateColumns = False
        Me.dgExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgExpenses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewComboBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgExpenses.DataSource = Me.Feespaymentsdetails1BindingSource1
        Me.dgExpenses.Enabled = False
        Me.dgExpenses.Location = New System.Drawing.Point(89, 234)
        Me.dgExpenses.Name = "dgExpenses"
        Me.dgExpenses.Size = New System.Drawing.Size(590, 125)
        Me.dgExpenses.TabIndex = 54
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "Cartegory"
        '  Me.DataGridViewComboBoxColumn1.DataSource = Me.PaymentType2BindingSource
        Me.DataGridViewComboBoxColumn1.DisplayMember = "Payment"
        Me.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewComboBoxColumn1.HeaderText = "Cartegory"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.ValueMember = "Payment"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Reference"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Reference"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.DataPropertyName = "Period"
        'Me.DataGridViewComboBoxColumn2.DataSource = Me.PaymentPeriodsBindingSource
        Me.DataGridViewComboBoxColumn2.DisplayMember = "Description"
        Me.DataGridViewComboBoxColumn2.HeaderText = "Period"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.ValueMember = "Period"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Comment"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Feespaymentsdetails1BindingSource1
        '
        Me.Feespaymentsdetails1BindingSource1.DataMember = "feespayments_details1"
        'Me.Feespaymentsdetails1BindingSource1.DataSource = Me.DsFees1
        '
        'DsFees1
        '
        '    Me.DsFees1.DataSetName = "dsFees"
        '   Me.DsFees1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.Delrt
        Me.BindingNavigator1.BindingSource = Me.FeesPaymentsHeader1BindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel2
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator5, Me.ToolStripTextBox1, Me.ToolStripLabel2, Me.ToolStripSeparator6, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator7, Me.Delrt, Me.pay_save, Me.ToolStripSeparator8, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripButton13, Me.ToolStripButton14})
        Me.BindingNavigator1.Location = New System.Drawing.Point(6, 16)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton2
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton5
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton4
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton3
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(353, 25)
        Me.BindingNavigator1.TabIndex = 41
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'Delrt
        '
        Me.Delrt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Delrt.Image = CType(resources.GetObject("Delrt.Image"), System.Drawing.Image)
        Me.Delrt.Name = "Delrt"
        Me.Delrt.RightToLeftAutoMirrorImage = True
        Me.Delrt.Size = New System.Drawing.Size(23, 22)
        Me.Delrt.Text = "Add new"
        '
        'FeesPaymentsHeader1BindingSource
        '
        '   Me.FeesPaymentsHeader1BindingSource.DataMember = "FeesPayments_Header1"
        '  Me.FeesPaymentsHeader1BindingSource.DataSource = Me.DsFees
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move first"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move previous"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move next"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move last"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'pay_save
        '
        Me.pay_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pay_save.Image = CType(resources.GetObject("pay_save.Image"), System.Drawing.Image)
        Me.pay_save.Name = "pay_save"
        Me.pay_save.Size = New System.Drawing.Size(23, 22)
        Me.pay_save.Tag = "70"
        Me.pay_save.Text = "Save Data"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Tag = "69"
        Me.ToolStripButton7.Text = "ToolStripButton14"
        Me.ToolStripButton7.ToolTipText = "Cancel/Delete"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Reprint"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        '     Me.ToolStripButton13.Image = Global.SMS.My.Resources.Resources.edit
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "Edit"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "Import Receipts"
        '
        'gbExpenses
        '
        Me.gbExpenses.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbExpenses.Controls.Add(Me.lbExpCreditors)
        Me.gbExpenses.Controls.Add(Me.txtExpCreditor)
        Me.gbExpenses.Controls.Add(Me.Label15)
        Me.gbExpenses.Controls.Add(Label3)
        Me.gbExpenses.Controls.Add(Me.ComboBox1)
        Me.gbExpenses.Controls.Add(Label4)
        Me.gbExpenses.Controls.Add(Me.DateTimePicker1)
        Me.gbExpenses.Controls.Add(Me.MaskedTextBox1)
        Me.gbExpenses.Controls.Add(Label6)
        Me.gbExpenses.Controls.Add(Label7)
        Me.gbExpenses.Controls.Add(Me.TextBox2)
        Me.gbExpenses.Enabled = False
        Me.gbExpenses.Location = New System.Drawing.Point(152, 44)
        Me.gbExpenses.Name = "gbExpenses"
        Me.gbExpenses.Size = New System.Drawing.Size(414, 184)
        Me.gbExpenses.TabIndex = 0
        Me.gbExpenses.TabStop = False
        '
        'lbExpCreditors
        '
        Me.lbExpCreditors.FormattingEnabled = True
        Me.lbExpCreditors.Location = New System.Drawing.Point(144, 41)
        Me.lbExpCreditors.Name = "lbExpCreditors"
        Me.lbExpCreditors.Size = New System.Drawing.Size(186, 108)
        Me.lbExpCreditors.TabIndex = 27
        Me.lbExpCreditors.Visible = False
        '
        'txtExpCreditor
        '
        Me.txtExpCreditor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsHeader1BindingSource, "StudentID", True))
        Me.txtExpCreditor.Location = New System.Drawing.Point(145, 18)
        Me.txtExpCreditor.Name = "txtExpCreditor"
        Me.txtExpCreditor.Size = New System.Drawing.Size(140, 20)
        Me.txtExpCreditor.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(59, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Creditor:"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsHeader1BindingSource, "ReasonForReversal", True))
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Refund", "Error In Capturing", "Test Receipt", "Others"})
        Me.ComboBox1.Location = New System.Drawing.Point(144, 147)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsHeader1BindingSource, "PostDate", True))
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(145, 111)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(153, 20)
        Me.DateTimePicker1.TabIndex = 4
        Me.DateTimePicker1.Value = New Date(2015, 2, 10, 0, 0, 0, 0)
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsHeader1BindingSource, "Date", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(145, 49)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(129, 20)
        Me.MaskedTextBox1.TabIndex = 2
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeesPaymentsHeader1BindingSource, "Receipt", True))
        Me.TextBox2.Location = New System.Drawing.Point(144, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1178, 534)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Debtors/Customers"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbCustomerSearch)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.BindingNavigator3)
        Me.GroupBox3.Controls.Add(NameLabel)
        Me.GroupBox3.Controls.Add(Me.NameTextBox)
        Me.GroupBox3.Controls.Add(AddressLabel)
        Me.GroupBox3.Controls.Add(Me.AddressTextBox)
        Me.GroupBox3.Controls.Add(IDnumberLabel)
        Me.GroupBox3.Controls.Add(Me.IDnumberTextBox)
        Me.GroupBox3.Controls.Add(AccLabel)
        Me.GroupBox3.Controls.Add(Me.AccTextBox)
        Me.GroupBox3.Controls.Add(MobileNumberLabel)
        Me.GroupBox3.Controls.Add(Me.MobileNumberTextBox)
        Me.GroupBox3.Controls.Add(EmailAddressLabel)
        Me.GroupBox3.Controls.Add(Me.EmailAddressTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(95, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(690, 275)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Debtors"
        '
        'lbCustomerSearch
        '
        Me.lbCustomerSearch.FormattingEnabled = True
        Me.lbCustomerSearch.Location = New System.Drawing.Point(427, 48)
        Me.lbCustomerSearch.Name = "lbCustomerSearch"
        Me.lbCustomerSearch.Size = New System.Drawing.Size(192, 95)
        Me.lbCustomerSearch.TabIndex = 62
        Me.lbCustomerSearch.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(427, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 20)
        Me.TextBox1.TabIndex = 61
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(582, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 60
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(367, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Customer:"
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.Add
        Me.BindingNavigator3.BindingSource = Me.DebtorsBindingSource
        Me.BindingNavigator3.CountItem = Me.ToolStripLabel3
        Me.BindingNavigator3.DeleteItem = Nothing
        Me.BindingNavigator3.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton16, Me.ToolStripButton17, Me.ToolStripSeparator9, Me.ToolStripTextBox3, Me.ToolStripLabel3, Me.ToolStripSeparator10, Me.ToolStripButton18, Me.ToolStripButton19, Me.ToolStripSeparator11, Me.Add, Me.ToolStripButton20, Me.ToolStripSeparator12, Me.ToolStripButton21})
        Me.BindingNavigator3.Location = New System.Drawing.Point(71, 16)
        Me.BindingNavigator3.MoveFirstItem = Me.ToolStripButton16
        Me.BindingNavigator3.MoveLastItem = Me.ToolStripButton19
        Me.BindingNavigator3.MoveNextItem = Me.ToolStripButton18
        Me.BindingNavigator3.MovePreviousItem = Me.ToolStripButton17
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.ToolStripTextBox3
        Me.BindingNavigator3.Size = New System.Drawing.Size(284, 25)
        Me.BindingNavigator3.TabIndex = 42
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'Add
        '
        Me.Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Add.Image = CType(resources.GetObject("Add.Image"), System.Drawing.Image)
        Me.Add.Name = "Add"
        Me.Add.RightToLeftAutoMirrorImage = True
        Me.Add.Size = New System.Drawing.Size(23, 22)
        Me.Add.Text = "Add new"
        '
        'DebtorsBindingSource
        '
        Me.DebtorsBindingSource.DataMember = "Debtors"
        '  Me.DebtorsBindingSource.DataSource = Me.DsIncomeExpenditure
        '
        'DsIncomeExpenditure
        '
        '   Me.DsIncomeExpenditure.DataSetName = "dsIncomeExpenditure"
        '  Me.DsIncomeExpenditure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel3.Text = "of {0}"
        Me.ToolStripLabel3.ToolTipText = "Total number of items"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton16.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton16.Text = "Move first"
        '
        'ToolStripButton17
        '
        Me.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"), System.Drawing.Image)
        Me.ToolStripButton17.Name = "ToolStripButton17"
        Me.ToolStripButton17.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton17.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton17.Text = "Move previous"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.AccessibleName = "Position"
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox3.Text = "0"
        Me.ToolStripTextBox3.ToolTipText = "Current position"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton18
        '
        Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton18.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton18.Text = "Move next"
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"), System.Drawing.Image)
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton19.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton19.Text = "Move last"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton20
        '
        Me.ToolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton20.Image = CType(resources.GetObject("ToolStripButton20.Image"), System.Drawing.Image)
        Me.ToolStripButton20.Name = "ToolStripButton20"
        Me.ToolStripButton20.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton20.Tag = "70"
        Me.ToolStripButton20.Text = "Save Data"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton21.Image = CType(resources.GetObject("ToolStripButton21.Image"), System.Drawing.Image)
        Me.ToolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton21.Tag = "69"
        Me.ToolStripButton21.Text = "ToolStripButton14"
        Me.ToolStripButton21.ToolTipText = "Cancel/Delete"
        '
        'NameTextBox
        '
        Me.NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DebtorsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(258, 80)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(226, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'AddressTextBox
        '
        Me.AddressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DebtorsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(258, 106)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(150, 20)
        Me.AddressTextBox.TabIndex = 3
        '
        'IDnumberTextBox
        '
        Me.IDnumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DebtorsBindingSource, "IDnumber", True))
        Me.IDnumberTextBox.Location = New System.Drawing.Point(258, 138)
        Me.IDnumberTextBox.Name = "IDnumberTextBox"
        Me.IDnumberTextBox.Size = New System.Drawing.Size(150, 20)
        Me.IDnumberTextBox.TabIndex = 5
        '
        'AccTextBox
        '
        Me.AccTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DebtorsBindingSource, "Acc", True))
        Me.AccTextBox.Location = New System.Drawing.Point(258, 51)
        Me.AccTextBox.Name = "AccTextBox"
        Me.AccTextBox.ReadOnly = True
        Me.AccTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccTextBox.TabIndex = 7
        '
        'MobileNumberTextBox
        '
        Me.MobileNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DebtorsBindingSource, "MobileNumber", True))
        Me.MobileNumberTextBox.Location = New System.Drawing.Point(258, 172)
        Me.MobileNumberTextBox.Name = "MobileNumberTextBox"
        Me.MobileNumberTextBox.Size = New System.Drawing.Size(150, 20)
        Me.MobileNumberTextBox.TabIndex = 9
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DebtorsBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(258, 198)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(150, 20)
        Me.EmailAddressTextBox.TabIndex = 11
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SplitContainer2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1178, 534)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "DebtorsInvoice"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer2.Size = New System.Drawing.Size(1172, 528)
        Me.SplitContainer2.SplitterDistance = 180
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Location = New System.Drawing.Point(168, 81)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(502, 311)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Invoice"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(275, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "&New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.cboInvCart)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.lbdebtors3)
        Me.GroupBox6.Controls.Add(Me.txtInvAmount)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.txtDebtName)
        Me.GroupBox6.Controls.Add(Label10)
        Me.GroupBox6.Controls.Add(Label12)
        Me.GroupBox6.Controls.Add(Me.cboInvPeriod)
        Me.GroupBox6.Controls.Add(Me.mskInvDate)
        Me.GroupBox6.Controls.Add(Label13)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 32)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(414, 229)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(302, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 32
        '
        'cboInvCart
        '
        '   Me.cboInvCart.DataSource = Me.PaymentType2BindingSource
        Me.cboInvCart.DisplayMember = "Payment"
        Me.cboInvCart.FormattingEnabled = True
        Me.cboInvCart.Location = New System.Drawing.Point(145, 132)
        Me.cboInvCart.Name = "cboInvCart"
        Me.cboInvCart.Size = New System.Drawing.Size(121, 21)
        Me.cboInvCart.TabIndex = 31
        Me.cboInvCart.ValueMember = "Payment"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(71, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Cartegory:"
        '
        'lbdebtors3
        '
        Me.lbdebtors3.FormattingEnabled = True
        Me.lbdebtors3.Location = New System.Drawing.Point(145, 50)
        Me.lbdebtors3.Name = "lbdebtors3"
        Me.lbdebtors3.Size = New System.Drawing.Size(199, 82)
        Me.lbdebtors3.TabIndex = 27
        Me.lbdebtors3.Visible = False
        '
        'txtInvAmount
        '
        Me.txtInvAmount.Location = New System.Drawing.Point(145, 162)
        Me.txtInvAmount.Name = "txtInvAmount"
        Me.txtInvAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtInvAmount.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Name: "
        '
        'txtDebtName
        '
        Me.txtDebtName.Location = New System.Drawing.Point(145, 33)
        Me.txtDebtName.Name = "txtDebtName"
        Me.txtDebtName.Size = New System.Drawing.Size(140, 20)
        Me.txtDebtName.TabIndex = 0
        '
        'cboInvPeriod
        '
        Me.cboInvPeriod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboInvPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        '   Me.cboInvPeriod.DataSource = Me.PaymentPeriodsBindingSource
        Me.cboInvPeriod.DisplayMember = "Description"
        Me.cboInvPeriod.FormattingEnabled = True
        Me.cboInvPeriod.Location = New System.Drawing.Point(145, 59)
        Me.cboInvPeriod.Name = "cboInvPeriod"
        Me.cboInvPeriod.Size = New System.Drawing.Size(121, 21)
        Me.cboInvPeriod.TabIndex = 1
        Me.cboInvPeriod.ValueMember = "Period"
        '
        'mskInvDate
        '
        Me.mskInvDate.Location = New System.Drawing.Point(145, 93)
        Me.mskInvDate.Mask = "00/00/0000"
        Me.mskInvDate.Name = "mskInvDate"
        Me.mskInvDate.Size = New System.Drawing.Size(129, 20)
        Me.mskInvDate.TabIndex = 2
        Me.mskInvDate.ValidatingType = GetType(Date)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1178, 534)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "Creditors"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(AddressLabel1)
        Me.GroupBox2.Controls.Add(Me.AddressTextBox1)
        Me.GroupBox2.Controls.Add(NameLabel1)
        Me.GroupBox2.Controls.Add(Me.NameTextBox1)
        Me.GroupBox2.Controls.Add(Me.BindingNavigator4)
        Me.GroupBox2.Controls.Add(IDnumberLabel1)
        Me.GroupBox2.Controls.Add(Me.IDnumberTextBox1)
        Me.GroupBox2.Controls.Add(AccountLabel)
        Me.GroupBox2.Controls.Add(Me.AccountTextBox)
        Me.GroupBox2.Controls.Add(MobileNumberLabel1)
        Me.GroupBox2.Controls.Add(Me.MobileNumberTextBox1)
        Me.GroupBox2.Controls.Add(EmaiAddressLabel)
        Me.GroupBox2.Controls.Add(Me.EmaiAddressTextBox)
        Me.GroupBox2.Controls.Add(BankAccntLabel)
        Me.GroupBox2.Controls.Add(Me.BankAccntTextBox)
        Me.GroupBox2.Controls.Add(BankLabel)
        Me.GroupBox2.Controls.Add(Me.BankTextBox)
        Me.GroupBox2.Controls.Add(BranchLabel)
        Me.GroupBox2.Controls.Add(Me.BranchTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(136, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(644, 372)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Creditors"
        '
        'AddressTextBox1
        '
        Me.AddressTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditorsBindingSource, "Address", True))
        Me.AddressTextBox1.Location = New System.Drawing.Point(262, 211)
        Me.AddressTextBox1.Name = "AddressTextBox1"
        Me.AddressTextBox1.Size = New System.Drawing.Size(167, 20)
        Me.AddressTextBox1.TabIndex = 45
        '
        'CreditorsBindingSource
        '
        Me.CreditorsBindingSource.DataMember = "Creditors"
        '   Me.CreditorsBindingSource.DataSource = Me.DsIncomeExpenditure
        '
        'NameTextBox1
        '
        Me.NameTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditorsBindingSource, "Name", True))
        Me.NameTextBox1.Location = New System.Drawing.Point(262, 63)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(167, 20)
        Me.NameTextBox1.TabIndex = 44
        '
        'BindingNavigator4
        '
        Me.BindingNavigator4.AddNewItem = Me.AddNew
        Me.BindingNavigator4.BindingSource = Me.CreditorsBindingSource
        Me.BindingNavigator4.CountItem = Me.ToolStripLabel4
        Me.BindingNavigator4.DeleteItem = Nothing
        Me.BindingNavigator4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton6, Me.ToolStripButton15, Me.ToolStripSeparator13, Me.ToolStripTextBox4, Me.ToolStripLabel4, Me.ToolStripSeparator14, Me.ToolStripButton22, Me.ToolStripButton23, Me.ToolStripSeparator15, Me.AddNew, Me.ToolStripButton24, Me.ToolStripSeparator16, Me.ToolStripButton25})
        Me.BindingNavigator4.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator4.MoveFirstItem = Me.ToolStripButton6
        Me.BindingNavigator4.MoveLastItem = Me.ToolStripButton23
        Me.BindingNavigator4.MoveNextItem = Me.ToolStripButton22
        Me.BindingNavigator4.MovePreviousItem = Me.ToolStripButton15
        Me.BindingNavigator4.Name = "BindingNavigator4"
        Me.BindingNavigator4.PositionItem = Me.ToolStripTextBox4
        Me.BindingNavigator4.Size = New System.Drawing.Size(638, 25)
        Me.BindingNavigator4.TabIndex = 43
        Me.BindingNavigator4.Text = "BindingNavigator4"
        '
        'AddNew
        '
        Me.AddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddNew.Image = CType(resources.GetObject("AddNew.Image"), System.Drawing.Image)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.RightToLeftAutoMirrorImage = True
        Me.AddNew.Size = New System.Drawing.Size(23, 22)
        Me.AddNew.Text = "Add new"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel4.Text = "of {0}"
        Me.ToolStripLabel4.ToolTipText = "Total number of items"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move first"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "Move previous"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.AccessibleName = "Position"
        Me.ToolStripTextBox4.AutoSize = False
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox4.Text = "0"
        Me.ToolStripTextBox4.ToolTipText = "Current position"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton22
        '
        Me.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton22.Image = CType(resources.GetObject("ToolStripButton22.Image"), System.Drawing.Image)
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton22.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton22.Text = "Move next"
        '
        'ToolStripButton23
        '
        Me.ToolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton23.Image = CType(resources.GetObject("ToolStripButton23.Image"), System.Drawing.Image)
        Me.ToolStripButton23.Name = "ToolStripButton23"
        Me.ToolStripButton23.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton23.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton23.Text = "Move last"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton24
        '
        Me.ToolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton24.Image = CType(resources.GetObject("ToolStripButton24.Image"), System.Drawing.Image)
        Me.ToolStripButton24.Name = "ToolStripButton24"
        Me.ToolStripButton24.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton24.Tag = "70"
        Me.ToolStripButton24.Text = "Save Data"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton25
        '
        Me.ToolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton25.Image = CType(resources.GetObject("ToolStripButton25.Image"), System.Drawing.Image)
        Me.ToolStripButton25.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton25.Name = "ToolStripButton25"
        Me.ToolStripButton25.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton25.Tag = "69"
        Me.ToolStripButton25.Text = "ToolStripButton14"
        Me.ToolStripButton25.ToolTipText = "Cancel/Delete"
        '
        'IDnumberTextBox1
        '
        Me.IDnumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditorsBindingSource, "IDnumber", True))
        Me.IDnumberTextBox1.Location = New System.Drawing.Point(262, 95)
        Me.IDnumberTextBox1.Name = "IDnumberTextBox1"
        Me.IDnumberTextBox1.Size = New System.Drawing.Size(123, 20)
        Me.IDnumberTextBox1.TabIndex = 1
        '
        'AccountTextBox
        '
        Me.AccountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditorsBindingSource, "Account", True))
        Me.AccountTextBox.Location = New System.Drawing.Point(262, 126)
        Me.AccountTextBox.Name = "AccountTextBox"
        Me.AccountTextBox.ReadOnly = True
        Me.AccountTextBox.Size = New System.Drawing.Size(167, 20)
        Me.AccountTextBox.TabIndex = 3
        '
        'MobileNumberTextBox1
        '
        Me.MobileNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditorsBindingSource, "MobileNumber", True))
        Me.MobileNumberTextBox1.Location = New System.Drawing.Point(262, 154)
        Me.MobileNumberTextBox1.Name = "MobileNumberTextBox1"
        Me.MobileNumberTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MobileNumberTextBox1.TabIndex = 5
        '
        'EmaiAddressTextBox
        '
        Me.EmaiAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditorsBindingSource, "EmaiAddress", True))
        Me.EmaiAddressTextBox.Location = New System.Drawing.Point(262, 185)
        Me.EmaiAddressTextBox.Name = "EmaiAddressTextBox"
        Me.EmaiAddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmaiAddressTextBox.TabIndex = 7
        '
        'BankAccntTextBox
        '
        Me.BankAccntTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditorsBindingSource, "BankAccnt", True))
        Me.BankAccntTextBox.Location = New System.Drawing.Point(262, 237)
        Me.BankAccntTextBox.Name = "BankAccntTextBox"
        Me.BankAccntTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BankAccntTextBox.TabIndex = 9
        Me.BankAccntTextBox.Text = "0"
        '
        'BankTextBox
        '
        Me.BankTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditorsBindingSource, "Bank", True))
        Me.BankTextBox.Location = New System.Drawing.Point(262, 265)
        Me.BankTextBox.Name = "BankTextBox"
        Me.BankTextBox.Size = New System.Drawing.Size(167, 20)
        Me.BankTextBox.TabIndex = 11
        '
        'BranchTextBox
        '
        Me.BranchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditorsBindingSource, "Branch", True))
        Me.BranchTextBox.Location = New System.Drawing.Point(262, 294)
        Me.BranchTextBox.Name = "BranchTextBox"
        Me.BranchTextBox.Size = New System.Drawing.Size(167, 20)
        Me.BranchTextBox.TabIndex = 13
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox4)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1178, 534)
        Me.TabPage6.TabIndex = 6
        Me.TabPage6.Text = "CreditorsInvoices"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox4.Controls.Add(Me.btnCrInvNew)
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Controls.Add(Me.btnCrdInvSave)
        Me.GroupBox4.Location = New System.Drawing.Point(203, 81)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(577, 311)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Invoice"
        '
        'btnCrInvNew
        '
        Me.btnCrInvNew.Location = New System.Drawing.Point(275, 267)
        Me.btnCrInvNew.Name = "btnCrInvNew"
        Me.btnCrInvNew.Size = New System.Drawing.Size(75, 23)
        Me.btnCrInvNew.TabIndex = 29
        Me.btnCrInvNew.Text = "&New"
        Me.btnCrInvNew.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.Controls.Add(Me.txtCreditorInv)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.cboCreInvCart)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.lbCreditors)
        Me.GroupBox8.Controls.Add(Me.txtCredInvAmnt)
        Me.GroupBox8.Controls.Add(Me.Label19)
        Me.GroupBox8.Controls.Add(Me.txtCreditor)
        Me.GroupBox8.Controls.Add(Label20)
        Me.GroupBox8.Controls.Add(Label21)
        Me.GroupBox8.Controls.Add(Me.cboCreditorPrd)
        Me.GroupBox8.Controls.Add(Me.txtCreInvDate)
        Me.GroupBox8.Controls.Add(Label22)
        Me.GroupBox8.Location = New System.Drawing.Point(17, 32)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(505, 229)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(291, 36)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 13)
        Me.Label24.TabIndex = 35
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(68, 98)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "Invoice: "
        '
        'txtCreditorInv
        '
        Me.txtCreditorInv.Location = New System.Drawing.Point(145, 91)
        Me.txtCreditorInv.Name = "txtCreditorInv"
        Me.txtCreditorInv.Size = New System.Drawing.Size(140, 20)
        Me.txtCreditorInv.TabIndex = 33
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(302, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 13)
        Me.Label17.TabIndex = 32
        '
        'cboCreInvCart
        '
        '    Me.cboCreInvCart.DataSource = Me.PaymentType2BindingSource
        Me.cboCreInvCart.DisplayMember = "Payment"
        Me.cboCreInvCart.FormattingEnabled = True
        Me.cboCreInvCart.Location = New System.Drawing.Point(145, 150)
        Me.cboCreInvCart.Name = "cboCreInvCart"
        Me.cboCreInvCart.Size = New System.Drawing.Size(121, 21)
        Me.cboCreInvCart.TabIndex = 31
        Me.cboCreInvCart.ValueMember = "Payment"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(68, 158)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Cartegory:"
        '
        'lbCreditors
        '
        Me.lbCreditors.FormattingEnabled = True
        Me.lbCreditors.Location = New System.Drawing.Point(291, 49)
        Me.lbCreditors.Name = "lbCreditors"
        Me.lbCreditors.Size = New System.Drawing.Size(199, 95)
        Me.lbCreditors.TabIndex = 27
        Me.lbCreditors.Visible = False
        '
        'txtCredInvAmnt
        '
        Me.txtCredInvAmnt.Location = New System.Drawing.Point(145, 185)
        Me.txtCredInvAmnt.Name = "txtCredInvAmnt"
        Me.txtCredInvAmnt.Size = New System.Drawing.Size(100, 20)
        Me.txtCredInvAmnt.TabIndex = 29
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(68, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Creditor: "
        '
        'txtCreditor
        '
        Me.txtCreditor.Location = New System.Drawing.Point(145, 33)
        Me.txtCreditor.Name = "txtCreditor"
        Me.txtCreditor.Size = New System.Drawing.Size(140, 20)
        Me.txtCreditor.TabIndex = 0
        '
        'cboCreditorPrd
        '
        Me.cboCreditorPrd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCreditorPrd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        '    Me.cboCreditorPrd.DataSource = Me.PaymentPeriodsBindingSource
        Me.cboCreditorPrd.DisplayMember = "Description"
        Me.cboCreditorPrd.FormattingEnabled = True
        Me.cboCreditorPrd.Location = New System.Drawing.Point(145, 59)
        Me.cboCreditorPrd.Name = "cboCreditorPrd"
        Me.cboCreditorPrd.Size = New System.Drawing.Size(121, 21)
        Me.cboCreditorPrd.TabIndex = 1
        Me.cboCreditorPrd.ValueMember = "Period"
        '
        'txtCreInvDate
        '
        Me.txtCreInvDate.Location = New System.Drawing.Point(145, 117)
        Me.txtCreInvDate.Mask = "00/00/0000"
        Me.txtCreInvDate.Name = "txtCreInvDate"
        Me.txtCreInvDate.Size = New System.Drawing.Size(129, 20)
        Me.txtCreInvDate.TabIndex = 2
        Me.txtCreInvDate.ValidatingType = GetType(Date)
        '
        'btnCrdInvSave
        '
        Me.btnCrdInvSave.Location = New System.Drawing.Point(91, 267)
        Me.btnCrdInvSave.Name = "btnCrdInvSave"
        Me.btnCrdInvSave.Size = New System.Drawing.Size(75, 23)
        Me.btnCrdInvSave.TabIndex = 28
        Me.btnCrdInvSave.Text = "&Save"
        Me.btnCrdInvSave.UseVisualStyleBackColor = True
        '
        'PaymentTypeBindingSource3
        '
        '  Me.PaymentTypeBindingSource3.DataMember = "PaymentType"
        '  Me.PaymentTypeBindingSource3.DataSource = Me.SchoolDataSet
        '
        'FeesPaymentsBindingSource1
        '
        '   Me.FeesPaymentsBindingSource1.DataMember = "FeesPayments"
        '     Me.FeesPaymentsBindingSource1.DataSource = Me.SchoolDataSet
        '
        'PaymentType3BindingSource
        '
        '  Me.PaymentType3BindingSource.DataMember = "PaymentType3"
        '   Me.PaymentType3BindingSource.DataSource = Me.SchoolDataSet
        '
        'PaymentTypeBindingSource2
        '
        '   Me.PaymentTypeBindingSource2.DataMember = "PaymentType"
        '  Me.PaymentTypeBindingSource2.DataSource = Me.SchoolDataSet
        '
        'PaymentTypeBindingSource1
        '
        '  Me.PaymentTypeBindingSource1.DataMember = "PaymentType"
        '  Me.PaymentTypeBindingSource1.DataSource = Me.DsSchool
        '
        'PaymentTypeBindingSource
        '
        '   Me.PaymentTypeBindingSource.DataMember = "PaymentType"
        '  Me.PaymentTypeBindingSource.DataSource = Me.DsSchool
        '
        'FeesPaymentsTableAdapter
        '
        '  Me.FeesPaymentsTableAdapter.ClearBeforeFill = True
        '
        'FeespaymentsdetailsBindingSource
        '
        '    Me.FeespaymentsdetailsBindingSource.DataMember = "feespayments_details"
        '  Me.FeespaymentsdetailsBindingSource.DataSource = Me.DsSchool
        '
        'Feespayments_detailsTableAdapter
        '
        ' Me.Feespayments_detailsTableAdapter.ClearBeforeFill = True
        '
        'PaymentTypeTableAdapter
        '
        '  Me.PaymentTypeTableAdapter.ClearBeforeFill = True
        '
        'PaymentType2TableAdapter
        '
        '    Me.PaymentType2TableAdapter.ClearBeforeFill = True
        '
        'PaymentPeriodsTableAdapter
        '
        '  Me.PaymentPeriodsTableAdapter.ClearBeforeFill = True
        '
        'DebtorsTableAdapter
        '
        ' Me.DebtorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        '    Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        '     Me.TableAdapterManager.CreditorsTableAdapter = Nothing
        '   Me.TableAdapterManager.DebtorsTableAdapter = Me.DebtorsTableAdapter
        '   Me.TableAdapterManager.UpdateOrder = SMS.dsIncomeExpenditureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DebtorsTransactionsTableAdapter
        '
        '   Me.DebtorsTransactionsTableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(1156, 566)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(1072, 566)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(991, 566)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'StudentContactsBindingSource
        '
        '    Me.StudentContactsBindingSource.DataMember = "StudentContacts"
        '   Me.StudentContactsBindingSource.DataSource = Me.dsReports
        '
        'StudentContactsTableAdapter
        '
        '   Me.StudentContactsTableAdapter.ClearBeforeFill = True
        '
        'NeawYearStatementTableAdapter
        '
        '       Me.NeawYearStatementTableAdapter.ClearBeforeFill = True
        '
        'FeesPaymentsBindingSource2
        '
        '   Me.FeesPaymentsBindingSource2.DataMember = "FeesPayments"
        '   Me.FeesPaymentsBindingSource2.DataSource = Me.SchoolDataSet
        '
        'PaymentTypeTableAdapter1
        '
        '   Me.PaymentTypeTableAdapter1.ClearBeforeFill = True
        '
        'PaymentType3TableAdapter
        '
        '   Me.PaymentType3TableAdapter.ClearBeforeFill = True
        '
        'Feespaymentsdetails1BindingSource
        '
        '   Me.Feespaymentsdetails1BindingSource.DataMember = "feespayments_details1"
        '    Me.Feespaymentsdetails1BindingSource.DataSource = Me.DsFees
        '
        'FeespaymentsdetailsBindingSource2
        '
        '   Me.FeespaymentsdetailsBindingSource2.DataMember = "feespayments_details"
        '   Me.FeespaymentsdetailsBindingSource2.DataSource = Me.DsFees
        '
        'Feespayments_detailsTableAdapter1
        '
        '  Me.Feespayments_detailsTableAdapter1.ClearBeforeFill = True
        '
        'Feespayments_details1TableAdapter
        '
        '    Me.Feespayments_details1TableAdapter.ClearBeforeFill = True
        '
        'FeesPayments_Header1TableAdapter
        '
        '     Me.FeesPayments_Header1TableAdapter.ClearBeforeFill = True
        '
        'CreditorsTableAdapter
        '
        '     Me.CreditorsTableAdapter.ClearBeforeFill = True
        '
        'CreditorsStatementTableAdapter
        '
        '   Me.CreditorsStatementTableAdapter.ClearBeforeFill = True
        '
        'frmNonStud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 594)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "frmNonStud"
        Me.Text = "frmNonStud"
        '    CType(Me.DebtorsTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '   CType(Me.dsReports, System.ComponentModel.ISupportInitialize).EndInit()
        '   CType(Me.CreditorsStatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.dsIncomeExpenditureReports, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.NeawYearStatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        '   CType(Me.PaymentType2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        ' CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dgFessDetails, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.PaymentPeriodsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        ''  CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.FeespaymentsdetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.DsFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        '  CType(Me.FeesPaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFeesPay.ResumeLayout(False)
        Me.gbFeesPay.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Feespaymentsdetails1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        '    CType(Me.DsFees1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.FeesPaymentsHeader1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbExpenses.ResumeLayout(False)
        Me.gbExpenses.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        '    CType(Me.DebtorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.DsIncomeExpenditure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CreditorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator4.ResumeLayout(False)
        Me.BindingNavigator4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        '   CType(Me.PaymentTypeBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.FeesPaymentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        ' '  CType(Me.PaymentType3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        ' CType(Me.PaymentTypeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.PaymentTypeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        '   CType(Me.PaymentTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.FeespaymentsdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.StudentContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.FeesPaymentsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.Feespaymentsdetails1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '   CType(Me.FeespaymentsdetailsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    '    Friend WithEvents SchoolDataSet As SMS.schoolDataSet
    '  Friend WithEvents FeesPaymentsBindingSource As System.Windows.Forms.BindingSource
    '   Friend WithEvents FeesPaymentsTableAdapter As SMS.schoolDataSetTableAdapters.FeesPaymentsTableAdapter
    '  Friend WithEvents DsSchool As SMS.dsSchool
    '  Friend WithEvents FeespaymentsdetailsBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents Feespayments_detailsTableAdapter As SMS.dsSchoolTableAdapters.feespayments_detailsTableAdapter
    ' Friend WithEvents PaymentTypeBindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents PaymentTypeTableAdapter As SMS.dsSchoolTableAdapters.PaymentTypeTableAdapter
    ' Friend WithEvents PaymentType2BindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents PaymentType2TableAdapter As SMS.schoolDataSetTableAdapters.PaymentType2TableAdapter
    '  Friend WithEvents DsFees As SMS.dsFees
    '  Friend WithEvents FeespaymentsdetailsBindingSource1 As System.Windows.Forms.BindingSource
    ' Friend WithEvents Feespayments_detailsTableAdapter1 As SMS.dsFeesTableAdapters.feespayments_detailsTableAdapter
    ' Friend WithEvents PaymentPeriodsBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents PaymentPeriodsTableAdapter As SMS.dsSchoolTableAdapters.PaymentPeriodsTableAdapter
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents Delrt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pay_save As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbExpenses As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    ' Friend WithEvents DsIncomeExpenditure As SMS.dsIncomeExpenditure
    Friend WithEvents DebtorsBindingSource As System.Windows.Forms.BindingSource
    '   Friend WithEvents DebtorsTableAdapter As SMS.dsIncomeExpenditureTableAdapters.DebtorsTableAdapter
    '  Friend WithEvents TableAdapterManager As SMS.dsIncomeExpenditureTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator3 As System.Windows.Forms.BindingNavigator
    Friend WithEvents Add As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton16 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton17 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton18 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton19 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton20 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton21 As System.Windows.Forms.ToolStripButton
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDnumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobileNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFeesCartegory As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents FeesDateSearch As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cboReceiptSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtReceiptSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dgFessDetails As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents Del As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents rec_import As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbFeesPay As System.Windows.Forms.GroupBox
    Friend WithEvents lbDebtorName As System.Windows.Forms.Label
    Friend WithEvents lbDebtors As System.Windows.Forms.ListBox
    Friend WithEvents cmbDebtorType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents ReasonForReversalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PostDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboCashType As System.Windows.Forms.ComboBox
    Friend WithEvents mskpaydate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ReceiptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents rvDebtStatement As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lbDebtors2 As System.Windows.Forms.ListBox
    ' Friend WithEvents DebtorsTransactionsBindingSource As System.Windows.Forms.BindingSource
    '   Friend WithEvents dsReports As SMS.dsReports
    ' Friend WithEvents DebtorsTransactionsTableAdapter As SMS.dsReportsTableAdapters.DebtorsTransactionsTableAdapter
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lbdebtors3 As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDebtName As System.Windows.Forms.TextBox
    Friend WithEvents cboInvPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents mskInvDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtInvAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboInvCart As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    '  Friend WithEvents NeawYearStatementBindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents StudentContactsBindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents StudentContactsTableAdapter As SMS.dsReportsTableAdapters.StudentContactsTableAdapter
    '  Friend WithEvents NeawYearStatementTableAdapter As SMS.dsReportsTableAdapters.NeawYearStatementTableAdapter
    '  Friend WithEvents FeespaymentsdetailsBindingSource2 As System.Windows.Forms.BindingSource
    '   Friend WithEvents FeesPaymentsBindingSource1 As System.Windows.Forms.BindingSource
    '   Friend WithEvents Feespaymentsdetails1BindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents Feespayments_details1TableAdapter As SMS.dsFeesTableAdapters.feespayments_details1TableAdapter
    '   Friend WithEvents PaymentTypeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CartegoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Period As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Comment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeesPaymentsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentTypeBindingSource2 As System.Windows.Forms.BindingSource
    '  Friend WithEvents PaymentTypeTableAdapter1 As SMS.schoolDataSetTableAdapters.PaymentTypeTableAdapter
    Friend WithEvents PaymentTypeBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentType3BindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents PaymentType3TableAdapter As SMS.schoolDataSetTableAdapters.PaymentType3TableAdapter
    Friend WithEvents dgExpenses As System.Windows.Forms.DataGridView
    ' Friend WithEvents DsFees1 As SMS.dsFees
    Friend WithEvents Feespaymentsdetails1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FeesPaymentsHeader1BindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents FeesPayments_Header1TableAdapter As SMS.dsFeesTableAdapters.FeesPayments_Header1TableAdapter
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbCustomerSearch As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents txtExpCreditor As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CreditorsBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents CreditorsTableAdapter As SMS.dsIncomeExpenditureTableAdapters.CreditorsTableAdapter
    Friend WithEvents IDnumberTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AccountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobileNumberTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents EmaiAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BankAccntTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BankTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator4 As System.Windows.Forms.BindingNavigator
    Friend WithEvents AddNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton22 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton23 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton24 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton25 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AddressTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCrInvNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboCreInvCart As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbCreditors As System.Windows.Forms.ListBox
    Friend WithEvents txtCredInvAmnt As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCreditor As System.Windows.Forms.TextBox
    Friend WithEvents cboCreditorPrd As System.Windows.Forms.ComboBox
    Friend WithEvents txtCreInvDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCrdInvSave As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCreditorInv As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lbExpCreditors As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbExSearchCred As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents cboExpenditureSearchCart As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cboExpSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtExpenditureSearch As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    '  Friend WithEvents CreditorsStatementBindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents dsIncomeExpenditureReports As SMS.dsIncomeExpenditureReports
    '  Friend WithEvents CreditorsStatementTableAdapter As SMS.dsIncomeExpenditureReportsTableAdapters.CreditorsStatementTableAdapter
End Class
