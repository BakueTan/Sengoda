<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibrary
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
        Dim BorrowerLabel As System.Windows.Forms.Label
        Dim DateIssuedLabel As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim CopyLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim DateAcquiredLabel As System.Windows.Forms.Label
        Dim SerialLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim StatusLabel1 As System.Windows.Forms.Label
        Dim TitleLabel1 As System.Windows.Forms.Label
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim ProgramLabel As System.Windows.Forms.Label
        Dim YearPublishedLabel1 As System.Windows.Forms.Label
        Dim PublisherLabel1 As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim AuthorLabel1 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibrary))
        Me.BookIssueFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSchoolLibrary = New SchoolLibrary.dsSchoolLibrary()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tbBillAccounts = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboLibraryBilling = New System.Windows.Forms.ComboBox()
        Me.btnLibraryBilling = New System.Windows.Forms.Button()
        Me.mskBillTo = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mskBillFrom = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tpBookReturning = New System.Windows.Forms.TabPage()
        Me.btnReturnsSave = New System.Windows.Forms.Button()
        Me.gbBookReturns = New System.Windows.Forms.GroupBox()
        Me.btnReturnSearch = New System.Windows.Forms.Button()
        Me.cboReturnType = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.rbretByIssue = New System.Windows.Forms.RadioButton()
        Me.rbretbyborrower = New System.Windows.Forms.RadioButton()
        Me.rbretbybook = New System.Windows.Forms.RadioButton()
        Me.lbReturnsStud = New System.Windows.Forms.ListBox()
        Me.cboBookState = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskReturnDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkIssues = New System.Windows.Forms.CheckedListBox()
        Me.lbReturnText = New System.Windows.Forms.Label()
        Me.txtReturnStud = New System.Windows.Forms.TextBox()
        Me.tpBookBorrowing = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnStudSearchPanel = New System.Windows.Forms.Button()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cboIssueSearch = New System.Windows.Forms.ComboBox()
        Me.txtissueSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lbissued = New System.Windows.Forms.Label()
        Me.rbPerTitle = New System.Windows.Forms.RadioButton()
        Me.lbSearchIssue = New System.Windows.Forms.ListBox()
        Me.rbSingleIssue = New System.Windows.Forms.RadioButton()
        Me.LabelBorrower = New System.Windows.Forms.Label()
        Me.btnCancelIssue = New System.Windows.Forms.Button()
        Me.txtBook = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbBook = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lvBooks = New System.Windows.Forms.ListView()
        Me.Reference = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblStud = New System.Windows.Forms.Label()
        Me.lbBorrower = New System.Windows.Forms.ListBox()
        Me.DateIssuedMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BorrowerTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tbBookTrans = New System.Windows.Forms.TabPage()
        Me.tbLibMaster = New System.Windows.Forms.TabPage()
        Me.tbParameters = New System.Windows.Forms.TabControl()
        Me.tbBarCodes = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodePrefix = New System.Windows.Forms.TextBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtCodeTo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCodeFrom = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbBookTitles = New System.Windows.Forms.TabPage()
        Me.btnBokkTitleSearch = New System.Windows.Forms.Button()
        Me.lbTitleSearch = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTitleSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTilteRef = New System.Windows.Forms.TextBox()
        Me.BookTitlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Del = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.ProgramComboBox = New System.Windows.Forms.ComboBox()
        Me.YearPublishedTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherTextBox1 = New System.Windows.Forms.TextBox()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox1 = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.tbBookLoan = New System.Windows.Forms.TabPage()
        Me.BookLoanType = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.BookLoanTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.BookLoanTypeDataGridView = New System.Windows.Forms.DataGridView()
        Me.LoanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbBookMaster = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lbBookAvailability = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbboooksearch = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbStudent = New System.Windows.Forms.ListBox()
        Me.txtBookSearch = New System.Windows.Forms.TextBox()
        Me.gbreplacement = New System.Windows.Forms.GroupBox()
        Me.mskReplacementDate = New System.Windows.Forms.MaskedTextBox()
        Me.BookMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkDamagedBooks = New System.Windows.Forms.CheckedListBox()
        Me.txtBukreplaceStud = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBookMasterCost = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtBookMasterRef = New System.Windows.Forms.TextBox()
        Me.txtBookMasterTitle = New System.Windows.Forms.TextBox()
        Me.txtBookMasterComment = New System.Windows.Forms.TextBox()
        Me.lbIndTitleSearch = New System.Windows.Forms.ListBox()
        Me.CopyComboBox = New System.Windows.Forms.ComboBox()
        Me.cboLoanType = New System.Windows.Forms.ComboBox()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.DateAcquiredMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Add = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.StatusComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BookTitlesTableAdapter1 = New SchoolLibrary.dsSchoolLibraryTableAdapters.BookTitlesTableAdapter()
        Me.BookMasterTableAdapter1 = New SchoolLibrary.dsSchoolLibraryTableAdapters.BookMasterTableAdapter()
        Me.BookLoanTypeTableAdapter1 = New SchoolLibrary.dsSchoolLibraryTableAdapters.BookLoanTypeTableAdapter()
        Me.BookIssueFormTableAdapter = New SchoolLibrary.dsSchoolLibraryTableAdapters.BookIssueFormTableAdapter()
        Me.Button6 = New System.Windows.Forms.Button()
        BorrowerLabel = New System.Windows.Forms.Label()
        DateIssuedLabel = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        CopyLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        DateAcquiredLabel = New System.Windows.Forms.Label()
        SerialLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        StatusLabel1 = New System.Windows.Forms.Label()
        TitleLabel1 = New System.Windows.Forms.Label()
        SubjectLabel = New System.Windows.Forms.Label()
        ProgramLabel = New System.Windows.Forms.Label()
        YearPublishedLabel1 = New System.Windows.Forms.Label()
        PublisherLabel1 = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        AuthorLabel1 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        CType(Me.BookIssueFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSchoolLibrary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBillAccounts.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tpBookReturning.SuspendLayout()
        Me.gbBookReturns.SuspendLayout()
        Me.tpBookBorrowing.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tbBookTrans.SuspendLayout()
        Me.tbLibMaster.SuspendLayout()
        Me.tbParameters.SuspendLayout()
        Me.tbBarCodes.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.tbBookTitles.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BookTitlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.tbBookLoan.SuspendLayout()
        Me.BookLoanType.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.BookLoanTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookLoanTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBookMaster.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.gbreplacement.SuspendLayout()
        CType(Me.BookMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorrowerLabel
        '
        BorrowerLabel.AutoSize = True
        BorrowerLabel.Location = New System.Drawing.Point(126, 57)
        BorrowerLabel.Name = "BorrowerLabel"
        BorrowerLabel.Size = New System.Drawing.Size(54, 13)
        BorrowerLabel.TabIndex = 2
        BorrowerLabel.Text = "IssuedTo:"
        '
        'DateIssuedLabel
        '
        DateIssuedLabel.AutoSize = True
        DateIssuedLabel.Location = New System.Drawing.Point(126, 89)
        DateIssuedLabel.Name = "DateIssuedLabel"
        DateIssuedLabel.Size = New System.Drawing.Size(67, 13)
        DateIssuedLabel.TabIndex = 14
        DateIssuedLabel.Text = "Date Issued:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(15, 238)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(54, 13)
        Label16.TabIndex = 23
        Label16.Text = "Comment:"
        '
        'CopyLabel
        '
        CopyLabel.AutoSize = True
        CopyLabel.Location = New System.Drawing.Point(15, 165)
        CopyLabel.Name = "CopyLabel"
        CopyLabel.Size = New System.Drawing.Size(34, 13)
        CopyLabel.TabIndex = 21
        CopyLabel.Text = "Copy:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(15, 141)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(58, 13)
        Label8.TabIndex = 21
        Label8.Text = "LoanType:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(15, 96)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 18
        TitleLabel.Text = "Title:"
        '
        'DateAcquiredLabel
        '
        DateAcquiredLabel.AutoSize = True
        DateAcquiredLabel.Location = New System.Drawing.Point(15, 186)
        DateAcquiredLabel.Name = "DateAcquiredLabel"
        DateAcquiredLabel.Size = New System.Drawing.Size(78, 13)
        DateAcquiredLabel.TabIndex = 18
        DateAcquiredLabel.Text = "Date Acquired:"
        '
        'SerialLabel
        '
        SerialLabel.AutoSize = True
        SerialLabel.Location = New System.Drawing.Point(15, 73)
        SerialLabel.Name = "SerialLabel"
        SerialLabel.Size = New System.Drawing.Size(36, 13)
        SerialLabel.TabIndex = 0
        SerialLabel.Text = "Serial:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(15, 50)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 10
        TypeLabel.Text = "Type:"
        '
        'StatusLabel1
        '
        StatusLabel1.AutoSize = True
        StatusLabel1.Location = New System.Drawing.Point(15, 119)
        StatusLabel1.Name = "StatusLabel1"
        StatusLabel1.Size = New System.Drawing.Size(40, 13)
        StatusLabel1.TabIndex = 12
        StatusLabel1.Text = "Status:"
        '
        'TitleLabel1
        '
        TitleLabel1.AutoSize = True
        TitleLabel1.Location = New System.Drawing.Point(57, 51)
        TitleLabel1.Name = "TitleLabel1"
        TitleLabel1.Size = New System.Drawing.Size(30, 13)
        TitleLabel1.TabIndex = 17
        TitleLabel1.Text = "Title:"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Location = New System.Drawing.Point(56, 208)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(62, 13)
        SubjectLabel.TabIndex = 29
        SubjectLabel.Text = "Department"
        '
        'ProgramLabel
        '
        ProgramLabel.AutoSize = True
        ProgramLabel.Location = New System.Drawing.Point(57, 181)
        ProgramLabel.Name = "ProgramLabel"
        ProgramLabel.Size = New System.Drawing.Size(49, 13)
        ProgramLabel.TabIndex = 27
        ProgramLabel.Text = "Program:"
        '
        'YearPublishedLabel1
        '
        YearPublishedLabel1.AutoSize = True
        YearPublishedLabel1.Location = New System.Drawing.Point(57, 155)
        YearPublishedLabel1.Name = "YearPublishedLabel1"
        YearPublishedLabel1.Size = New System.Drawing.Size(81, 13)
        YearPublishedLabel1.TabIndex = 25
        YearPublishedLabel1.Text = "Year Published:"
        '
        'PublisherLabel1
        '
        PublisherLabel1.AutoSize = True
        PublisherLabel1.Location = New System.Drawing.Point(56, 129)
        PublisherLabel1.Name = "PublisherLabel1"
        PublisherLabel1.Size = New System.Drawing.Size(53, 13)
        PublisherLabel1.TabIndex = 23
        PublisherLabel1.Text = "Publisher:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(57, 103)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 21
        ISBNLabel.Text = "ISBN:"
        '
        'AuthorLabel1
        '
        AuthorLabel1.AutoSize = True
        AuthorLabel1.Location = New System.Drawing.Point(57, 77)
        AuthorLabel1.Name = "AuthorLabel1"
        AuthorLabel1.Size = New System.Drawing.Size(41, 13)
        AuthorLabel1.TabIndex = 19
        AuthorLabel1.Text = "Author:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(53, 228)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(82, 13)
        Label5.TabIndex = 20
        Label5.Text = "Date Replaced:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(15, 215)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(31, 13)
        Label17.TabIndex = 38
        Label17.Text = "Cost:"
        '
        'BookIssueFormBindingSource
        '
        Me.BookIssueFormBindingSource.DataMember = "BookIssueForm"
        Me.BookIssueFormBindingSource.DataSource = Me.DsSchoolLibrary
        '
        'DsSchoolLibrary
        '
        Me.DsSchoolLibrary.DataSetName = "dsSchoolLibrary"
        Me.DsSchoolLibrary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.Location = New System.Drawing.Point(1131, 534)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(110, 46)
        Me.btnPreview.TabIndex = 17
        Me.btnPreview.Text = "R&efresh"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(1015, 534)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 46)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tbBillAccounts
        '
        Me.tbBillAccounts.Controls.Add(Me.GroupBox4)
        Me.tbBillAccounts.Location = New System.Drawing.Point(4, 22)
        Me.tbBillAccounts.Name = "tbBillAccounts"
        Me.tbBillAccounts.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBillAccounts.Size = New System.Drawing.Size(1207, 445)
        Me.tbBillAccounts.TabIndex = 6
        Me.tbBillAccounts.Text = "BillOverdueAccounts"
        Me.tbBillAccounts.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.cboLibraryBilling)
        Me.GroupBox4.Controls.Add(Me.btnLibraryBilling)
        Me.GroupBox4.Controls.Add(Me.mskBillTo)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.mskBillFrom)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(347, 67)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(513, 285)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LibraryBilling"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Period:"
        '
        'cboLibraryBilling
        '
        Me.cboLibraryBilling.DisplayMember = "Period"
        Me.cboLibraryBilling.FormattingEnabled = True
        Me.cboLibraryBilling.Location = New System.Drawing.Point(73, 150)
        Me.cboLibraryBilling.Name = "cboLibraryBilling"
        Me.cboLibraryBilling.Size = New System.Drawing.Size(100, 21)
        Me.cboLibraryBilling.TabIndex = 5
        Me.cboLibraryBilling.ValueMember = "Period"
        '
        'btnLibraryBilling
        '
        Me.btnLibraryBilling.Location = New System.Drawing.Point(73, 191)
        Me.btnLibraryBilling.Name = "btnLibraryBilling"
        Me.btnLibraryBilling.Size = New System.Drawing.Size(90, 23)
        Me.btnLibraryBilling.TabIndex = 4
        Me.btnLibraryBilling.Text = "PerformBilling"
        Me.btnLibraryBilling.UseVisualStyleBackColor = True
        '
        'mskBillTo
        '
        Me.mskBillTo.Location = New System.Drawing.Point(212, 113)
        Me.mskBillTo.Mask = "00/00/0000"
        Me.mskBillTo.Name = "mskBillTo"
        Me.mskBillTo.Size = New System.Drawing.Size(100, 20)
        Me.mskBillTo.TabIndex = 3
        Me.mskBillTo.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(183, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "To:"
        '
        'mskBillFrom
        '
        Me.mskBillFrom.Location = New System.Drawing.Point(73, 113)
        Me.mskBillFrom.Mask = "00/00/0000"
        Me.mskBillFrom.Name = "mskBillFrom"
        Me.mskBillFrom.Size = New System.Drawing.Size(100, 20)
        Me.mskBillFrom.TabIndex = 1
        Me.mskBillFrom.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "From:"
        '
        'tpBookReturning
        '
        Me.tpBookReturning.Controls.Add(Me.btnReturnsSave)
        Me.tpBookReturning.Controls.Add(Me.gbBookReturns)
        Me.tpBookReturning.Location = New System.Drawing.Point(4, 22)
        Me.tpBookReturning.Name = "tpBookReturning"
        Me.tpBookReturning.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBookReturning.Size = New System.Drawing.Size(1207, 445)
        Me.tpBookReturning.TabIndex = 2
        Me.tpBookReturning.Text = "Returns"
        Me.tpBookReturning.UseVisualStyleBackColor = True
        '
        'btnReturnsSave
        '
        Me.btnReturnsSave.Location = New System.Drawing.Point(566, 409)
        Me.btnReturnsSave.Name = "btnReturnsSave"
        Me.btnReturnsSave.Size = New System.Drawing.Size(75, 23)
        Me.btnReturnsSave.TabIndex = 1
        Me.btnReturnsSave.Text = "Save"
        Me.btnReturnsSave.UseVisualStyleBackColor = True
        '
        'gbBookReturns
        '
        Me.gbBookReturns.Controls.Add(Me.btnReturnSearch)
        Me.gbBookReturns.Controls.Add(Me.cboReturnType)
        Me.gbBookReturns.Controls.Add(Me.Label18)
        Me.gbBookReturns.Controls.Add(Me.rbretByIssue)
        Me.gbBookReturns.Controls.Add(Me.rbretbyborrower)
        Me.gbBookReturns.Controls.Add(Me.rbretbybook)
        Me.gbBookReturns.Controls.Add(Me.lbReturnsStud)
        Me.gbBookReturns.Controls.Add(Me.cboBookState)
        Me.gbBookReturns.Controls.Add(Me.Label4)
        Me.gbBookReturns.Controls.Add(Me.mskReturnDate)
        Me.gbBookReturns.Controls.Add(Me.Label3)
        Me.gbBookReturns.Controls.Add(Me.chkIssues)
        Me.gbBookReturns.Controls.Add(Me.lbReturnText)
        Me.gbBookReturns.Controls.Add(Me.txtReturnStud)
        Me.gbBookReturns.Location = New System.Drawing.Point(174, 6)
        Me.gbBookReturns.Name = "gbBookReturns"
        Me.gbBookReturns.Size = New System.Drawing.Size(732, 393)
        Me.gbBookReturns.TabIndex = 0
        Me.gbBookReturns.TabStop = False
        Me.gbBookReturns.Text = "BookReturns"
        '
        'btnReturnSearch
        '
        Me.btnReturnSearch.BackgroundImage = Global.SchoolLibrary.My.Resources.Resources.search
        Me.btnReturnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturnSearch.Location = New System.Drawing.Point(359, 37)
        Me.btnReturnSearch.Name = "btnReturnSearch"
        Me.btnReturnSearch.Size = New System.Drawing.Size(24, 23)
        Me.btnReturnSearch.TabIndex = 38
        Me.btnReturnSearch.UseVisualStyleBackColor = True
        '
        'cboReturnType
        '
        Me.cboReturnType.FormattingEnabled = True
        Me.cboReturnType.Items.AddRange(New Object() {"Return", "Reversal"})
        Me.cboReturnType.Location = New System.Drawing.Point(158, 12)
        Me.cboReturnType.Name = "cboReturnType"
        Me.cboReturnType.Size = New System.Drawing.Size(100, 21)
        Me.cboReturnType.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(71, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 13)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "ReturnType"
        '
        'rbretByIssue
        '
        Me.rbretByIssue.AutoSize = True
        Me.rbretByIssue.Location = New System.Drawing.Point(590, 37)
        Me.rbretByIssue.Name = "rbretByIssue"
        Me.rbretByIssue.Size = New System.Drawing.Size(87, 17)
        Me.rbretByIssue.TabIndex = 10
        Me.rbretByIssue.Text = "ByIssueCode"
        Me.rbretByIssue.UseVisualStyleBackColor = True
        '
        'rbretbyborrower
        '
        Me.rbretbyborrower.AutoSize = True
        Me.rbretbyborrower.Location = New System.Drawing.Point(491, 37)
        Me.rbretbyborrower.Name = "rbretbyborrower"
        Me.rbretbyborrower.Size = New System.Drawing.Size(79, 17)
        Me.rbretbyborrower.TabIndex = 9
        Me.rbretbyborrower.Text = "ByBorrower"
        Me.rbretbyborrower.UseVisualStyleBackColor = True
        '
        'rbretbybook
        '
        Me.rbretbybook.AutoSize = True
        Me.rbretbybook.Checked = True
        Me.rbretbybook.Location = New System.Drawing.Point(405, 37)
        Me.rbretbybook.Name = "rbretbybook"
        Me.rbretbybook.Size = New System.Drawing.Size(62, 17)
        Me.rbretbybook.TabIndex = 8
        Me.rbretbybook.TabStop = True
        Me.rbretbybook.Text = "ByBook"
        Me.rbretbybook.UseVisualStyleBackColor = True
        '
        'lbReturnsStud
        '
        Me.lbReturnsStud.FormattingEnabled = True
        Me.lbReturnsStud.Location = New System.Drawing.Point(158, 66)
        Me.lbReturnsStud.Name = "lbReturnsStud"
        Me.lbReturnsStud.Size = New System.Drawing.Size(366, 173)
        Me.lbReturnsStud.TabIndex = 7
        Me.lbReturnsStud.Visible = False
        '
        'cboBookState
        '
        Me.cboBookState.FormattingEnabled = True
        Me.cboBookState.Items.AddRange(New Object() {"Available", "Damaged", "Lost"})
        Me.cboBookState.Location = New System.Drawing.Point(158, 352)
        Me.cboBookState.Name = "cboBookState"
        Me.cboBookState.Size = New System.Drawing.Size(100, 21)
        Me.cboBookState.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NewBookState"
        '
        'mskReturnDate
        '
        Me.mskReturnDate.Location = New System.Drawing.Point(158, 326)
        Me.mskReturnDate.Mask = "00/00/0000"
        Me.mskReturnDate.Name = "mskReturnDate"
        Me.mskReturnDate.Size = New System.Drawing.Size(100, 20)
        Me.mskReturnDate.TabIndex = 4
        Me.mskReturnDate.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Return Date:"
        '
        'chkIssues
        '
        Me.chkIssues.FormattingEnabled = True
        Me.chkIssues.Location = New System.Drawing.Point(74, 61)
        Me.chkIssues.Name = "chkIssues"
        Me.chkIssues.Size = New System.Drawing.Size(578, 259)
        Me.chkIssues.TabIndex = 2
        '
        'lbReturnText
        '
        Me.lbReturnText.AutoSize = True
        Me.lbReturnText.Location = New System.Drawing.Point(71, 41)
        Me.lbReturnText.Name = "lbReturnText"
        Me.lbReturnText.Size = New System.Drawing.Size(35, 13)
        Me.lbReturnText.TabIndex = 1
        Me.lbReturnText.Text = "Book:"
        '
        'txtReturnStud
        '
        Me.txtReturnStud.Location = New System.Drawing.Point(158, 38)
        Me.txtReturnStud.Name = "txtReturnStud"
        Me.txtReturnStud.Size = New System.Drawing.Size(200, 20)
        Me.txtReturnStud.TabIndex = 0
        '
        'tpBookBorrowing
        '
        Me.tpBookBorrowing.Controls.Add(Me.SplitContainer3)
        Me.tpBookBorrowing.Location = New System.Drawing.Point(4, 22)
        Me.tpBookBorrowing.Name = "tpBookBorrowing"
        Me.tpBookBorrowing.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBookBorrowing.Size = New System.Drawing.Size(1207, 445)
        Me.tpBookBorrowing.TabIndex = 1
        Me.tpBookBorrowing.Text = "Issues"
        Me.tpBookBorrowing.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.SplitContainer3.Panel2.Controls.Add(Me.btnStudSearchPanel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox17)
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer3.Size = New System.Drawing.Size(1201, 439)
        Me.SplitContainer3.SplitterDistance = 513
        Me.SplitContainer3.SplitterWidth = 1
        Me.SplitContainer3.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BookIssueFormBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SchoolLibrary.rptBorrowerIssues.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(511, 437)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.ZoomPercent = 500
        '
        'btnStudSearchPanel
        '
        Me.btnStudSearchPanel.BackColor = System.Drawing.Color.Green
        Me.btnStudSearchPanel.ForeColor = System.Drawing.Color.White
        Me.btnStudSearchPanel.Location = New System.Drawing.Point(3, -1)
        Me.btnStudSearchPanel.Name = "btnStudSearchPanel"
        Me.btnStudSearchPanel.Size = New System.Drawing.Size(75, 41)
        Me.btnStudSearchPanel.TabIndex = 46
        Me.btnStudSearchPanel.Text = "Hide " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "View Panel"
        Me.btnStudSearchPanel.UseVisualStyleBackColor = False
        '
        'GroupBox17
        '
        Me.GroupBox17.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox17.Controls.Add(Me.Button3)
        Me.GroupBox17.Controls.Add(Me.Label36)
        Me.GroupBox17.Controls.Add(Me.cboIssueSearch)
        Me.GroupBox17.Controls.Add(Me.txtissueSearch)
        Me.GroupBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.Location = New System.Drawing.Point(84, 3)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(516, 41)
        Me.GroupBox17.TabIndex = 21
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Issue Search"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.SchoolLibrary.My.Resources.Resources.search
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(413, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 23)
        Me.Button3.TabIndex = 37
        Me.Button3.UseVisualStyleBackColor = True
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
        'cboIssueSearch
        '
        Me.cboIssueSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboIssueSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIssueSearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboIssueSearch.FormattingEnabled = True
        Me.cboIssueSearch.ItemHeight = 13
        Me.cboIssueSearch.Items.AddRange(New Object() {"Issue", "Member"})
        Me.cboIssueSearch.Location = New System.Drawing.Point(91, 14)
        Me.cboIssueSearch.Name = "cboIssueSearch"
        Me.cboIssueSearch.Size = New System.Drawing.Size(121, 21)
        Me.cboIssueSearch.TabIndex = 1
        '
        'txtissueSearch
        '
        Me.txtissueSearch.Location = New System.Drawing.Point(218, 15)
        Me.txtissueSearch.Name = "txtissueSearch"
        Me.txtissueSearch.Size = New System.Drawing.Size(192, 20)
        Me.txtissueSearch.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.lbissued)
        Me.GroupBox3.Controls.Add(Me.rbPerTitle)
        Me.GroupBox3.Controls.Add(Me.lbSearchIssue)
        Me.GroupBox3.Controls.Add(Me.rbSingleIssue)
        Me.GroupBox3.Controls.Add(Me.LabelBorrower)
        Me.GroupBox3.Controls.Add(Me.btnCancelIssue)
        Me.GroupBox3.Controls.Add(Me.txtBook)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.lbBook)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.btnAddBook)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lvBooks)
        Me.GroupBox3.Controls.Add(Me.lblStud)
        Me.GroupBox3.Controls.Add(Me.lbBorrower)
        Me.GroupBox3.Controls.Add(DateIssuedLabel)
        Me.GroupBox3.Controls.Add(Me.DateIssuedMaskedTextBox)
        Me.GroupBox3.Controls.Add(BorrowerLabel)
        Me.GroupBox3.Controls.Add(Me.BorrowerTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(647, 353)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BookIssuing"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.SchoolLibrary.My.Resources.Resources.search
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(367, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 23)
        Me.Button5.TabIndex = 38
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lbissued
        '
        Me.lbissued.AutoSize = True
        Me.lbissued.Location = New System.Drawing.Point(439, 265)
        Me.lbissued.Name = "lbissued"
        Me.lbissued.Size = New System.Drawing.Size(0, 13)
        Me.lbissued.TabIndex = 35
        '
        'rbPerTitle
        '
        Me.rbPerTitle.AutoSize = True
        Me.rbPerTitle.Location = New System.Drawing.Point(574, 114)
        Me.rbPerTitle.Name = "rbPerTitle"
        Me.rbPerTitle.Size = New System.Drawing.Size(61, 17)
        Me.rbPerTitle.TabIndex = 34
        Me.rbPerTitle.Text = "PerTitle"
        Me.rbPerTitle.UseVisualStyleBackColor = True
        '
        'lbSearchIssue
        '
        Me.lbSearchIssue.FormattingEnabled = True
        Me.lbSearchIssue.Location = New System.Drawing.Point(290, 1)
        Me.lbSearchIssue.Name = "lbSearchIssue"
        Me.lbSearchIssue.Size = New System.Drawing.Size(351, 43)
        Me.lbSearchIssue.TabIndex = 22
        Me.lbSearchIssue.Visible = False
        '
        'rbSingleIssue
        '
        Me.rbSingleIssue.AutoSize = True
        Me.rbSingleIssue.Checked = True
        Me.rbSingleIssue.Location = New System.Drawing.Point(485, 115)
        Me.rbSingleIssue.Name = "rbSingleIssue"
        Me.rbSingleIssue.Size = New System.Drawing.Size(79, 17)
        Me.rbSingleIssue.TabIndex = 33
        Me.rbSingleIssue.TabStop = True
        Me.rbSingleIssue.Text = "SingleIssue"
        Me.rbSingleIssue.UseVisualStyleBackColor = True
        '
        'LabelBorrower
        '
        Me.LabelBorrower.AutoSize = True
        Me.LabelBorrower.Location = New System.Drawing.Point(415, 57)
        Me.LabelBorrower.Name = "LabelBorrower"
        Me.LabelBorrower.Size = New System.Drawing.Size(0, 13)
        Me.LabelBorrower.TabIndex = 32
        '
        'btnCancelIssue
        '
        Me.btnCancelIssue.Location = New System.Drawing.Point(352, 278)
        Me.btnCancelIssue.Name = "btnCancelIssue"
        Me.btnCancelIssue.Size = New System.Drawing.Size(75, 35)
        Me.btnCancelIssue.TabIndex = 31
        Me.btnCancelIssue.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Book Issue"
        Me.btnCancelIssue.UseVisualStyleBackColor = True
        '
        'txtBook
        '
        Me.txtBook.Location = New System.Drawing.Point(203, 114)
        Me.txtBook.Name = "txtBook"
        Me.txtBook.Size = New System.Drawing.Size(164, 20)
        Me.txtBook.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbBook
        '
        Me.lbBook.FormattingEnabled = True
        Me.lbBook.Location = New System.Drawing.Point(201, 140)
        Me.lbBook.Name = "lbBook"
        Me.lbBook.Size = New System.Drawing.Size(408, 82)
        Me.lbBook.TabIndex = 28
        Me.lbBook.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(94, 284)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddBook
        '
        Me.btnAddBook.Location = New System.Drawing.Point(397, 111)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBook.TabIndex = 26
        Me.btnAddBook.Text = "AddBook"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(126, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Book:"
        '
        'lvBooks
        '
        Me.lvBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Reference, Me.Title, Me.DueDate})
        Me.lvBooks.FullRowSelect = True
        Me.lvBooks.GridLines = True
        Me.lvBooks.HideSelection = False
        Me.lvBooks.Location = New System.Drawing.Point(94, 167)
        Me.lvBooks.MultiSelect = False
        Me.lvBooks.Name = "lvBooks"
        Me.lvBooks.Size = New System.Drawing.Size(333, 111)
        Me.lvBooks.TabIndex = 23
        Me.lvBooks.UseCompatibleStateImageBehavior = False
        Me.lvBooks.View = System.Windows.Forms.View.Details
        '
        'Reference
        '
        Me.Reference.Text = "Reference"
        '
        'Title
        '
        Me.Title.Text = "Title"
        '
        'DueDate
        '
        Me.DueDate.Text = "DueDate"
        '
        'lblStud
        '
        Me.lblStud.AutoSize = True
        Me.lblStud.Location = New System.Drawing.Point(409, 60)
        Me.lblStud.Name = "lblStud"
        Me.lblStud.Size = New System.Drawing.Size(0, 13)
        Me.lblStud.TabIndex = 17
        '
        'lbBorrower
        '
        Me.lbBorrower.FormattingEnabled = True
        Me.lbBorrower.Location = New System.Drawing.Point(397, 50)
        Me.lbBorrower.Name = "lbBorrower"
        Me.lbBorrower.Size = New System.Drawing.Size(238, 56)
        Me.lbBorrower.TabIndex = 15
        Me.lbBorrower.Visible = False
        '
        'DateIssuedMaskedTextBox
        '
        Me.DateIssuedMaskedTextBox.Location = New System.Drawing.Point(203, 82)
        Me.DateIssuedMaskedTextBox.Mask = "00/00/0000"
        Me.DateIssuedMaskedTextBox.Name = "DateIssuedMaskedTextBox"
        Me.DateIssuedMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DateIssuedMaskedTextBox.TabIndex = 2
        Me.DateIssuedMaskedTextBox.ValidatingType = GetType(Date)
        '
        'BorrowerTextBox
        '
        Me.BorrowerTextBox.Location = New System.Drawing.Point(203, 50)
        Me.BorrowerTextBox.Name = "BorrowerTextBox"
        Me.BorrowerTextBox.Size = New System.Drawing.Size(164, 20)
        Me.BorrowerTextBox.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpBookBorrowing)
        Me.TabControl1.Controls.Add(Me.tpBookReturning)
        Me.TabControl1.Controls.Add(Me.tbBillAccounts)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1215, 471)
        Me.TabControl1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tbBookTrans)
        Me.TabControl2.Controls.Add(Me.tbLibMaster)
        Me.TabControl2.Location = New System.Drawing.Point(12, 25)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1229, 503)
        Me.TabControl2.TabIndex = 18
        '
        'tbBookTrans
        '
        Me.tbBookTrans.Controls.Add(Me.TabControl1)
        Me.tbBookTrans.Location = New System.Drawing.Point(4, 22)
        Me.tbBookTrans.Name = "tbBookTrans"
        Me.tbBookTrans.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBookTrans.Size = New System.Drawing.Size(1221, 477)
        Me.tbBookTrans.TabIndex = 1
        Me.tbBookTrans.Text = "Book Transactions"
        Me.tbBookTrans.UseVisualStyleBackColor = True
        '
        'tbLibMaster
        '
        Me.tbLibMaster.Controls.Add(Me.tbParameters)
        Me.tbLibMaster.Location = New System.Drawing.Point(4, 22)
        Me.tbLibMaster.Name = "tbLibMaster"
        Me.tbLibMaster.Padding = New System.Windows.Forms.Padding(3)
        Me.tbLibMaster.Size = New System.Drawing.Size(1221, 477)
        Me.tbLibMaster.TabIndex = 0
        Me.tbLibMaster.Text = "Library Parameters"
        Me.tbLibMaster.UseVisualStyleBackColor = True
        '
        'tbParameters
        '
        Me.tbParameters.Controls.Add(Me.tbBarCodes)
        Me.tbParameters.Controls.Add(Me.tbBookTitles)
        Me.tbParameters.Controls.Add(Me.tbBookLoan)
        Me.tbParameters.Controls.Add(Me.tbBookMaster)
        Me.tbParameters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbParameters.Location = New System.Drawing.Point(3, 3)
        Me.tbParameters.Name = "tbParameters"
        Me.tbParameters.SelectedIndex = 0
        Me.tbParameters.Size = New System.Drawing.Size(1215, 471)
        Me.tbParameters.TabIndex = 0
        '
        'tbBarCodes
        '
        Me.tbBarCodes.Controls.Add(Me.GroupBox5)
        Me.tbBarCodes.Location = New System.Drawing.Point(4, 22)
        Me.tbBarCodes.Name = "tbBarCodes"
        Me.tbBarCodes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBarCodes.Size = New System.Drawing.Size(1207, 445)
        Me.tbBarCodes.TabIndex = 3
        Me.tbBarCodes.Text = "Generate Book Barcodes"
        Me.tbBarCodes.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtCodePrefix)
        Me.GroupBox5.Controls.Add(Me.btnView)
        Me.GroupBox5.Controls.Add(Me.btnGenerate)
        Me.GroupBox5.Controls.Add(Me.txtCodeTo)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtCodeFrom)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(422, 139)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(363, 115)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GenerateBarcodes"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Prefix:"
        '
        'txtCodePrefix
        '
        Me.txtCodePrefix.Location = New System.Drawing.Point(66, 22)
        Me.txtCodePrefix.Name = "txtCodePrefix"
        Me.txtCodePrefix.Size = New System.Drawing.Size(100, 20)
        Me.txtCodePrefix.TabIndex = 9
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(133, 75)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(149, 23)
        Me.btnView.TabIndex = 8
        Me.btnView.Text = "ViewBarcodes"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(52, 75)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 7
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtCodeTo
        '
        Me.txtCodeTo.Location = New System.Drawing.Point(198, 48)
        Me.txtCodeTo.Name = "txtCodeTo"
        Me.txtCodeTo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodeTo.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(172, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "To"
        '
        'txtCodeFrom
        '
        Me.txtCodeFrom.Location = New System.Drawing.Point(66, 48)
        Me.txtCodeFrom.Name = "txtCodeFrom"
        Me.txtCodeFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtCodeFrom.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "From:"
        '
        'tbBookTitles
        '
        Me.tbBookTitles.Controls.Add(Me.btnBokkTitleSearch)
        Me.tbBookTitles.Controls.Add(Me.lbTitleSearch)
        Me.tbBookTitles.Controls.Add(Me.Label9)
        Me.tbBookTitles.Controls.Add(Me.txtTitleSearch)
        Me.tbBookTitles.Controls.Add(Me.GroupBox1)
        Me.tbBookTitles.Location = New System.Drawing.Point(4, 22)
        Me.tbBookTitles.Name = "tbBookTitles"
        Me.tbBookTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBookTitles.Size = New System.Drawing.Size(1207, 445)
        Me.tbBookTitles.TabIndex = 1
        Me.tbBookTitles.Text = "Maintain Book Titles"
        Me.tbBookTitles.UseVisualStyleBackColor = True
        '
        'btnBokkTitleSearch
        '
        Me.btnBokkTitleSearch.BackgroundImage = Global.SchoolLibrary.My.Resources.Resources.search
        Me.btnBokkTitleSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBokkTitleSearch.Location = New System.Drawing.Point(1177, 3)
        Me.btnBokkTitleSearch.Name = "btnBokkTitleSearch"
        Me.btnBokkTitleSearch.Size = New System.Drawing.Size(24, 23)
        Me.btnBokkTitleSearch.TabIndex = 38
        Me.btnBokkTitleSearch.UseVisualStyleBackColor = True
        '
        'lbTitleSearch
        '
        Me.lbTitleSearch.FormattingEnabled = True
        Me.lbTitleSearch.Location = New System.Drawing.Point(864, 31)
        Me.lbTitleSearch.Name = "lbTitleSearch"
        Me.lbTitleSearch.Size = New System.Drawing.Size(337, 95)
        Me.lbTitleSearch.TabIndex = 37
        Me.lbTitleSearch.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(902, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "BookSearch"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(974, 5)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(197, 20)
        Me.txtTitleSearch.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTilteRef)
        Me.GroupBox1.Controls.Add(TitleLabel1)
        Me.GroupBox1.Controls.Add(Me.BindingNavigator2)
        Me.GroupBox1.Controls.Add(Me.SubjectComboBox)
        Me.GroupBox1.Controls.Add(SubjectLabel)
        Me.GroupBox1.Controls.Add(Me.ProgramComboBox)
        Me.GroupBox1.Controls.Add(ProgramLabel)
        Me.GroupBox1.Controls.Add(Me.YearPublishedTextBox)
        Me.GroupBox1.Controls.Add(YearPublishedLabel1)
        Me.GroupBox1.Controls.Add(Me.PublisherTextBox1)
        Me.GroupBox1.Controls.Add(PublisherLabel1)
        Me.GroupBox1.Controls.Add(Me.ISBNTextBox)
        Me.GroupBox1.Controls.Add(ISBNLabel)
        Me.GroupBox1.Controls.Add(Me.AuthorTextBox1)
        Me.GroupBox1.Controls.Add(AuthorLabel1)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(372, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 325)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BookTitles"
        '
        'txtTilteRef
        '
        Me.txtTilteRef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookTitlesBindingSource, "TitleRef", True))
        Me.txtTilteRef.Location = New System.Drawing.Point(170, 232)
        Me.txtTilteRef.Name = "txtTilteRef"
        Me.txtTilteRef.ReadOnly = True
        Me.txtTilteRef.Size = New System.Drawing.Size(10, 20)
        Me.txtTilteRef.TabIndex = 30
        '
        'BookTitlesBindingSource
        '
        Me.BookTitlesBindingSource.DataMember = "BookTitles"
        Me.BookTitlesBindingSource.DataSource = Me.DsSchoolLibrary
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.Del
        Me.BindingNavigator2.BindingSource = Me.BookTitlesBindingSource
        Me.BindingNavigator2.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.Del, Me.ToolStripButton7, Me.ToolStripButton9, Me.ToolStripButton16})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator2.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator2.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator2.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator2.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator2.Size = New System.Drawing.Size(457, 25)
        Me.BindingNavigator2.TabIndex = 17
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Save Data"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = Global.SchoolLibrary.My.Resources.Resources.Delete
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Delete"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton16.Text = "ToolStripButton16"
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SubjectComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SubjectComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookTitlesBindingSource, "Department", True))
        Me.SubjectComboBox.DisplayMember = "Department"
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Location = New System.Drawing.Point(170, 205)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SubjectComboBox.TabIndex = 6
        Me.SubjectComboBox.ValueMember = "Department"
        '
        'ProgramComboBox
        '
        Me.ProgramComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProgramComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProgramComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookTitlesBindingSource, "program", True))
        Me.ProgramComboBox.DisplayMember = "Forms"
        Me.ProgramComboBox.FormattingEnabled = True
        Me.ProgramComboBox.Location = New System.Drawing.Point(170, 178)
        Me.ProgramComboBox.Name = "ProgramComboBox"
        Me.ProgramComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ProgramComboBox.TabIndex = 5
        Me.ProgramComboBox.ValueMember = "Forms"
        '
        'YearPublishedTextBox
        '
        Me.YearPublishedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookTitlesBindingSource, "YearPublished", True))
        Me.YearPublishedTextBox.Location = New System.Drawing.Point(170, 152)
        Me.YearPublishedTextBox.Name = "YearPublishedTextBox"
        Me.YearPublishedTextBox.Size = New System.Drawing.Size(201, 20)
        Me.YearPublishedTextBox.TabIndex = 4
        '
        'PublisherTextBox1
        '
        Me.PublisherTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PublisherTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookTitlesBindingSource, "Publisher", True))
        Me.PublisherTextBox1.Location = New System.Drawing.Point(170, 126)
        Me.PublisherTextBox1.Name = "PublisherTextBox1"
        Me.PublisherTextBox1.Size = New System.Drawing.Size(201, 20)
        Me.PublisherTextBox1.TabIndex = 3
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookTitlesBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(170, 100)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(201, 20)
        Me.ISBNTextBox.TabIndex = 2
        '
        'AuthorTextBox1
        '
        Me.AuthorTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookTitlesBindingSource, "Author", True))
        Me.AuthorTextBox1.Location = New System.Drawing.Point(170, 74)
        Me.AuthorTextBox1.Name = "AuthorTextBox1"
        Me.AuthorTextBox1.Size = New System.Drawing.Size(201, 20)
        Me.AuthorTextBox1.TabIndex = 1
        '
        'TitleTextBox
        '
        Me.TitleTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookTitlesBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(170, 48)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(201, 20)
        Me.TitleTextBox.TabIndex = 0
        '
        'tbBookLoan
        '
        Me.tbBookLoan.Controls.Add(Me.BookLoanType)
        Me.tbBookLoan.Location = New System.Drawing.Point(4, 22)
        Me.tbBookLoan.Name = "tbBookLoan"
        Me.tbBookLoan.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBookLoan.Size = New System.Drawing.Size(1207, 445)
        Me.tbBookLoan.TabIndex = 2
        Me.tbBookLoan.Text = "Maintain Book Loan Types"
        Me.tbBookLoan.UseVisualStyleBackColor = True
        '
        'BookLoanType
        '
        Me.BookLoanType.Controls.Add(Me.BindingNavigator3)
        Me.BookLoanType.Controls.Add(Me.BookLoanTypeDataGridView)
        Me.BookLoanType.Location = New System.Drawing.Point(238, 44)
        Me.BookLoanType.Name = "BookLoanType"
        Me.BookLoanType.Size = New System.Drawing.Size(730, 304)
        Me.BookLoanType.TabIndex = 1
        Me.BookLoanType.TabStop = False
        Me.BookLoanType.Text = "BookLoanType"
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.ToolStripButton2
        Me.BindingNavigator3.BindingSource = Me.BookLoanTypeBindingSource
        Me.BindingNavigator3.CountItem = Me.ToolStripLabel2
        Me.BindingNavigator3.DeleteItem = Nothing
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton12, Me.ToolStripButton13, Me.ToolStripSeparator6, Me.ToolStripButton2, Me.ToolStripButton14, Me.ToolStripButton15})
        Me.BindingNavigator3.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator3.MoveFirstItem = Me.ToolStripButton10
        Me.BindingNavigator3.MoveLastItem = Me.ToolStripButton13
        Me.BindingNavigator3.MoveNextItem = Me.ToolStripButton12
        Me.BindingNavigator3.MovePreviousItem = Me.ToolStripButton11
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.ToolStripTextBox2
        Me.BindingNavigator3.Size = New System.Drawing.Size(724, 25)
        Me.BindingNavigator3.TabIndex = 18
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Add new"
        '
        'BookLoanTypeBindingSource
        '
        Me.BookLoanTypeBindingSource.DataMember = "BookLoanType"
        Me.BookLoanTypeBindingSource.DataSource = Me.DsSchoolLibrary
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Move first"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Move next"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "Save Data"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "ToolStripButton9"
        '
        'BookLoanTypeDataGridView
        '
        Me.BookLoanTypeDataGridView.AutoGenerateColumns = False
        Me.BookLoanTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookLoanTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoanDataGridViewTextBoxColumn, Me.DurationDataGridViewTextBoxColumn, Me.PeriodDataGridViewTextBoxColumn, Me.FineDataGridViewTextBoxColumn})
        Me.BookLoanTypeDataGridView.DataSource = Me.BookLoanTypeBindingSource
        Me.BookLoanTypeDataGridView.Location = New System.Drawing.Point(70, 60)
        Me.BookLoanTypeDataGridView.Name = "BookLoanTypeDataGridView"
        Me.BookLoanTypeDataGridView.Size = New System.Drawing.Size(544, 220)
        Me.BookLoanTypeDataGridView.TabIndex = 0
        '
        'LoanDataGridViewTextBoxColumn
        '
        Me.LoanDataGridViewTextBoxColumn.DataPropertyName = "Loan"
        Me.LoanDataGridViewTextBoxColumn.HeaderText = "Loan"
        Me.LoanDataGridViewTextBoxColumn.Name = "LoanDataGridViewTextBoxColumn"
        Me.LoanDataGridViewTextBoxColumn.Width = 150
        '
        'DurationDataGridViewTextBoxColumn
        '
        Me.DurationDataGridViewTextBoxColumn.DataPropertyName = "Duration"
        Me.DurationDataGridViewTextBoxColumn.HeaderText = "Duration"
        Me.DurationDataGridViewTextBoxColumn.Name = "DurationDataGridViewTextBoxColumn"
        '
        'PeriodDataGridViewTextBoxColumn
        '
        Me.PeriodDataGridViewTextBoxColumn.DataPropertyName = "Period"
        Me.PeriodDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.PeriodDataGridViewTextBoxColumn.HeaderText = "Period"
        Me.PeriodDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Hours", "Days"})
        Me.PeriodDataGridViewTextBoxColumn.Name = "PeriodDataGridViewTextBoxColumn"
        Me.PeriodDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PeriodDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FineDataGridViewTextBoxColumn
        '
        Me.FineDataGridViewTextBoxColumn.DataPropertyName = "Fine"
        Me.FineDataGridViewTextBoxColumn.HeaderText = "Fine/Unit"
        Me.FineDataGridViewTextBoxColumn.Name = "FineDataGridViewTextBoxColumn"
        Me.FineDataGridViewTextBoxColumn.Width = 150
        '
        'tbBookMaster
        '
        Me.tbBookMaster.Controls.Add(Me.SplitContainer2)
        Me.tbBookMaster.Location = New System.Drawing.Point(4, 22)
        Me.tbBookMaster.Name = "tbBookMaster"
        Me.tbBookMaster.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBookMaster.Size = New System.Drawing.Size(1207, 445)
        Me.tbBookMaster.TabIndex = 0
        Me.tbBookMaster.Text = "Maintain Individual Books"
        Me.tbBookMaster.UseVisualStyleBackColor = True
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbBookAvailability)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lbboooksearch)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lbStudent)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtBookSearch)
        Me.SplitContainer2.Panel2.Controls.Add(Me.gbreplacement)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1201, 439)
        Me.SplitContainer2.SplitterDistance = 249
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 1
        '
        'lbBookAvailability
        '
        Me.lbBookAvailability.AutoSize = True
        Me.lbBookAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBookAvailability.Location = New System.Drawing.Point(4, 160)
        Me.lbBookAvailability.Name = "lbBookAvailability"
        Me.lbBookAvailability.Size = New System.Drawing.Size(0, 24)
        Me.lbBookAvailability.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.SchoolLibrary.My.Resources.Resources.search
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(902, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbboooksearch
        '
        Me.lbboooksearch.FormattingEnabled = True
        Me.lbboooksearch.Location = New System.Drawing.Point(639, 38)
        Me.lbboooksearch.Name = "lbboooksearch"
        Me.lbboooksearch.Size = New System.Drawing.Size(307, 95)
        Me.lbboooksearch.TabIndex = 4
        Me.lbboooksearch.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(626, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "BookSearch"
        '
        'lbStudent
        '
        Me.lbStudent.FormattingEnabled = True
        Me.lbStudent.Location = New System.Drawing.Point(639, 94)
        Me.lbStudent.Name = "lbStudent"
        Me.lbStudent.Size = New System.Drawing.Size(193, 108)
        Me.lbStudent.TabIndex = 3
        Me.lbStudent.Visible = False
        '
        'txtBookSearch
        '
        Me.txtBookSearch.Location = New System.Drawing.Point(698, 12)
        Me.txtBookSearch.Name = "txtBookSearch"
        Me.txtBookSearch.Size = New System.Drawing.Size(204, 20)
        Me.txtBookSearch.TabIndex = 2
        '
        'gbreplacement
        '
        Me.gbreplacement.Controls.Add(Label5)
        Me.gbreplacement.Controls.Add(Me.mskReplacementDate)
        Me.gbreplacement.Controls.Add(Me.Label1)
        Me.gbreplacement.Controls.Add(Me.chkDamagedBooks)
        Me.gbreplacement.Controls.Add(Me.txtBukreplaceStud)
        Me.gbreplacement.Location = New System.Drawing.Point(358, 67)
        Me.gbreplacement.Name = "gbreplacement"
        Me.gbreplacement.Size = New System.Drawing.Size(334, 283)
        Me.gbreplacement.TabIndex = 1
        Me.gbreplacement.TabStop = False
        Me.gbreplacement.Text = "BookReplacement"
        Me.gbreplacement.Visible = False
        '
        'mskReplacementDate
        '
        Me.mskReplacementDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookMasterBindingSource, "dateacquired", True))
        Me.mskReplacementDate.Location = New System.Drawing.Point(141, 225)
        Me.mskReplacementDate.Mask = "00/00/0000"
        Me.mskReplacementDate.Name = "mskReplacementDate"
        Me.mskReplacementDate.Size = New System.Drawing.Size(134, 20)
        Me.mskReplacementDate.TabIndex = 19
        Me.mskReplacementDate.ValidatingType = GetType(Date)
        '
        'BookMasterBindingSource
        '
        Me.BookMasterBindingSource.DataMember = "BookMaster"
        Me.BookMasterBindingSource.DataSource = Me.DsSchoolLibrary
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Borrower:"
        '
        'chkDamagedBooks
        '
        Me.chkDamagedBooks.FormattingEnabled = True
        Me.chkDamagedBooks.Location = New System.Drawing.Point(69, 53)
        Me.chkDamagedBooks.Name = "chkDamagedBooks"
        Me.chkDamagedBooks.Size = New System.Drawing.Size(206, 169)
        Me.chkDamagedBooks.TabIndex = 1
        '
        'txtBukreplaceStud
        '
        Me.txtBukreplaceStud.Location = New System.Drawing.Point(69, 27)
        Me.txtBukreplaceStud.Name = "txtBukreplaceStud"
        Me.txtBukreplaceStud.Size = New System.Drawing.Size(206, 20)
        Me.txtBukreplaceStud.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label17)
        Me.GroupBox2.Controls.Add(Me.txtBookMasterCost)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.txtBookMasterRef)
        Me.GroupBox2.Controls.Add(Me.txtBookMasterTitle)
        Me.GroupBox2.Controls.Add(Me.txtBookMasterComment)
        Me.GroupBox2.Controls.Add(Label16)
        Me.GroupBox2.Controls.Add(Me.lbIndTitleSearch)
        Me.GroupBox2.Controls.Add(CopyLabel)
        Me.GroupBox2.Controls.Add(Me.CopyComboBox)
        Me.GroupBox2.Controls.Add(Label8)
        Me.GroupBox2.Controls.Add(Me.cboLoanType)
        Me.GroupBox2.Controls.Add(TitleLabel)
        Me.GroupBox2.Controls.Add(Me.TypeComboBox)
        Me.GroupBox2.Controls.Add(DateAcquiredLabel)
        Me.GroupBox2.Controls.Add(Me.DateAcquiredMaskedTextBox)
        Me.GroupBox2.Controls.Add(Me.BindingNavigator1)
        Me.GroupBox2.Controls.Add(SerialLabel)
        Me.GroupBox2.Controls.Add(Me.SerialTextBox)
        Me.GroupBox2.Controls.Add(TypeLabel)
        Me.GroupBox2.Controls.Add(StatusLabel1)
        Me.GroupBox2.Controls.Add(Me.StatusComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 314)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Books"
        '
        'txtBookMasterCost
        '
        Me.txtBookMasterCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookMasterBindingSource, "Cost", True))
        Me.txtBookMasterCost.Location = New System.Drawing.Point(102, 212)
        Me.txtBookMasterCost.Name = "txtBookMasterCost"
        Me.txtBookMasterCost.Size = New System.Drawing.Size(117, 20)
        Me.txtBookMasterCost.TabIndex = 39
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.SchoolLibrary.My.Resources.Resources.search
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(278, 91)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 23)
        Me.Button4.TabIndex = 37
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtBookMasterRef
        '
        Me.txtBookMasterRef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookMasterBindingSource, "Bookref", True))
        Me.txtBookMasterRef.Location = New System.Drawing.Point(3, 288)
        Me.txtBookMasterRef.Name = "txtBookMasterRef"
        Me.txtBookMasterRef.ReadOnly = True
        Me.txtBookMasterRef.Size = New System.Drawing.Size(10, 20)
        Me.txtBookMasterRef.TabIndex = 26
        '
        'txtBookMasterTitle
        '
        Me.txtBookMasterTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookMasterBindingSource, "title", True))
        Me.txtBookMasterTitle.Location = New System.Drawing.Point(102, 93)
        Me.txtBookMasterTitle.Name = "txtBookMasterTitle"
        Me.txtBookMasterTitle.Size = New System.Drawing.Size(175, 20)
        Me.txtBookMasterTitle.TabIndex = 25
        '
        'txtBookMasterComment
        '
        Me.txtBookMasterComment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookMasterBindingSource, "Comments", True))
        Me.txtBookMasterComment.Location = New System.Drawing.Point(102, 235)
        Me.txtBookMasterComment.Multiline = True
        Me.txtBookMasterComment.Name = "txtBookMasterComment"
        Me.txtBookMasterComment.Size = New System.Drawing.Size(200, 73)
        Me.txtBookMasterComment.TabIndex = 24
        '
        'lbIndTitleSearch
        '
        Me.lbIndTitleSearch.FormattingEnabled = True
        Me.lbIndTitleSearch.Location = New System.Drawing.Point(102, 116)
        Me.lbIndTitleSearch.Name = "lbIndTitleSearch"
        Me.lbIndTitleSearch.Size = New System.Drawing.Size(200, 82)
        Me.lbIndTitleSearch.TabIndex = 22
        Me.lbIndTitleSearch.Visible = False
        '
        'CopyComboBox
        '
        Me.CopyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CopyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CopyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookMasterBindingSource, "Copy", True))
        Me.CopyComboBox.FormattingEnabled = True
        Me.CopyComboBox.Items.AddRange(New Object() {"Original", "Copy"})
        Me.CopyComboBox.Location = New System.Drawing.Point(102, 162)
        Me.CopyComboBox.Name = "CopyComboBox"
        Me.CopyComboBox.Size = New System.Drawing.Size(117, 21)
        Me.CopyComboBox.TabIndex = 5
        '
        'cboLoanType
        '
        Me.cboLoanType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookMasterBindingSource, "Loan", True))
        Me.cboLoanType.DisplayMember = "Loan"
        Me.cboLoanType.FormattingEnabled = True
        Me.cboLoanType.Location = New System.Drawing.Point(102, 138)
        Me.cboLoanType.Name = "cboLoanType"
        Me.cboLoanType.Size = New System.Drawing.Size(117, 21)
        Me.cboLoanType.TabIndex = 4
        Me.cboLoanType.ValueMember = "Loan"
        '
        'TypeComboBox
        '
        Me.TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookMasterBindingSource, "type", True))
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"NewConsignment", "Replacement", "Donation"})
        Me.TypeComboBox.Location = New System.Drawing.Point(102, 47)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(117, 21)
        Me.TypeComboBox.TabIndex = 0
        '
        'DateAcquiredMaskedTextBox
        '
        Me.DateAcquiredMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookMasterBindingSource, "dateacquired", True))
        Me.DateAcquiredMaskedTextBox.Location = New System.Drawing.Point(102, 186)
        Me.DateAcquiredMaskedTextBox.Mask = "00/00/0000"
        Me.DateAcquiredMaskedTextBox.Name = "DateAcquiredMaskedTextBox"
        Me.DateAcquiredMaskedTextBox.Size = New System.Drawing.Size(117, 20)
        Me.DateAcquiredMaskedTextBox.TabIndex = 6
        Me.DateAcquiredMaskedTextBox.ValidatingType = GetType(Date)
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.Add
        Me.BindingNavigator1.BindingSource = Me.BookMasterBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.Add, Me.ToolStripButton1, Me.ToolStripButton8})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(332, 25)
        Me.BindingNavigator1.TabIndex = 16
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Save Data"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.SchoolLibrary.My.Resources.Resources.Delete
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Delete"
        '
        'SerialTextBox
        '
        Me.SerialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookMasterBindingSource, "serial", True))
        Me.SerialTextBox.Location = New System.Drawing.Point(102, 70)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SerialTextBox.TabIndex = 1
        '
        'StatusComboBox1
        '
        Me.StatusComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookMasterBindingSource, "bookstate", True))
        Me.StatusComboBox1.FormattingEnabled = True
        Me.StatusComboBox1.Items.AddRange(New Object() {"Available", "Damaged", "Lost"})
        Me.StatusComboBox1.Location = New System.Drawing.Point(102, 116)
        Me.StatusComboBox1.Name = "StatusComboBox1"
        Me.StatusComboBox1.Size = New System.Drawing.Size(117, 21)
        Me.StatusComboBox1.TabIndex = 3
        '
        'BookTitlesTableAdapter1
        '
        Me.BookTitlesTableAdapter1.ClearBeforeFill = True
        '
        'BookMasterTableAdapter1
        '
        Me.BookMasterTableAdapter1.ClearBeforeFill = True
        '
        'BookLoanTypeTableAdapter1
        '
        Me.BookLoanTypeTableAdapter1.ClearBeforeFill = True
        '
        'BookIssueFormTableAdapter
        '
        Me.BookIssueFormTableAdapter.ClearBeforeFill = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.SchoolLibrary.My.Resources.Resources.search
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(367, 112)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 23)
        Me.Button6.TabIndex = 39
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 582)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLibrary"
        CType(Me.BookIssueFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSchoolLibrary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBillAccounts.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tpBookReturning.ResumeLayout(False)
        Me.gbBookReturns.ResumeLayout(False)
        Me.gbBookReturns.PerformLayout()
        Me.tpBookBorrowing.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.tbBookTrans.ResumeLayout(False)
        Me.tbLibMaster.ResumeLayout(False)
        Me.tbParameters.ResumeLayout(False)
        Me.tbBarCodes.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tbBookTitles.ResumeLayout(False)
        Me.tbBookTitles.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BookTitlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.tbBookLoan.ResumeLayout(False)
        Me.BookLoanType.ResumeLayout(False)
        Me.BookLoanType.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.BookLoanTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookLoanTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBookMaster.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.gbreplacement.ResumeLayout(False)
        Me.gbreplacement.PerformLayout()
        CType(Me.BookMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    '  Friend WithEvents DsLibrary As dsLibrary
    '  Friend WithEvents LibMemRegTableAdapter As dsLibraryTableAdapters.LibMemRegTableAdapter
    '  Friend WithEvents TableAdapterManager As dsLibraryTableAdapters.TableAdapterManager
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    ' Friend WithEvents BooksTableAdapter As dsLibraryTableAdapters.BooksTableAdapter
    '  Friend WithEvents BookIssuesTableAdapter As dsLibraryTableAdapters.BookIssuesTableAdapter
    '  Friend WithEvents BookMasterTableAdapter As dsLibraryTableAdapters.BookMasterTableAdapter
    '  Friend WithEvents BookTitlesTableAdapter As dsLibraryTableAdapters.BookTitlesTableAdapter
    '  Friend WithEvents Bookissiue_linesTableAdapter As dsLibraryTableAdapters.bookissiue_linesTableAdapter
    '   Friend WithEvents BookSearchTableAdapter As dsLibraryTableAdapters.BookSearchTableAdapter
    '  Friend WithEvents BookLoanTypeTableAdapter As dsLibraryTableAdapters.BookLoanTypeTableAdapter
    Friend WithEvents dsLibraryReports As dsLibraryReports
    Friend WithEvents CurrentIssuesTableAdapter As dsLibraryReportsTableAdapters.CurrentIssuesTableAdapter
    '  Friend WithEvents DepsTableAdapter As dsLibraryTableAdapters.DepsTableAdapter
    Friend WithEvents tbBillAccounts As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboLibraryBilling As System.Windows.Forms.ComboBox
    Friend WithEvents btnLibraryBilling As System.Windows.Forms.Button
    Friend WithEvents mskBillTo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mskBillFrom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpBookReturning As System.Windows.Forms.TabPage
    Friend WithEvents btnReturnsSave As System.Windows.Forms.Button
    Friend WithEvents gbBookReturns As System.Windows.Forms.GroupBox
    Friend WithEvents lbReturnsStud As System.Windows.Forms.ListBox
    Friend WithEvents cboBookState As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mskReturnDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkIssues As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbReturnText As System.Windows.Forms.Label
    Friend WithEvents txtReturnStud As System.Windows.Forms.TextBox
    Friend WithEvents tpBookBorrowing As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cboIssueSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtissueSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelBorrower As System.Windows.Forms.Label
    Friend WithEvents btnCancelIssue As System.Windows.Forms.Button
    Friend WithEvents txtBook As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbBook As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lvBooks As System.Windows.Forms.ListView
    Friend WithEvents Reference As System.Windows.Forms.ColumnHeader
    Friend WithEvents Title As System.Windows.Forms.ColumnHeader
    Friend WithEvents DueDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbSearchIssue As System.Windows.Forms.ListBox
    Friend WithEvents lblStud As System.Windows.Forms.Label
    Friend WithEvents lbBorrower As System.Windows.Forms.ListBox
    Friend WithEvents DateIssuedMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BorrowerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents rbretbyborrower As System.Windows.Forms.RadioButton
    Friend WithEvents rbretbybook As System.Windows.Forms.RadioButton
    Friend WithEvents rbretByIssue As System.Windows.Forms.RadioButton
    Friend WithEvents rbSingleIssue As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerTitle As System.Windows.Forms.RadioButton
    Friend WithEvents lbissued As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents DsSchoolLibrary As dsSchoolLibrary
    Friend WithEvents BookTitlesBindingSource As Windows.Forms.BindingSource
    Friend WithEvents BookTitlesTableAdapter1 As dsSchoolLibraryTableAdapters.BookTitlesTableAdapter
    Friend WithEvents BookMasterBindingSource As Windows.Forms.BindingSource
    Friend WithEvents BookMasterTableAdapter1 As dsSchoolLibraryTableAdapters.BookMasterTableAdapter
    Friend WithEvents BookLoanTypeBindingSource As Windows.Forms.BindingSource
    Friend WithEvents BookLoanTypeTableAdapter1 As dsSchoolLibraryTableAdapters.BookLoanTypeTableAdapter
    Friend WithEvents TabControl2 As Windows.Forms.TabControl
    Friend WithEvents tbLibMaster As Windows.Forms.TabPage
    Friend WithEvents tbParameters As Windows.Forms.TabControl
    Friend WithEvents tbBarCodes As Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents txtCodePrefix As Windows.Forms.TextBox
    Friend WithEvents btnView As Windows.Forms.Button
    Friend WithEvents btnGenerate As Windows.Forms.Button
    Friend WithEvents txtCodeTo As Windows.Forms.TextBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents txtCodeFrom As Windows.Forms.TextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents tbBookTitles As Windows.Forms.TabPage
    Friend WithEvents btnBokkTitleSearch As Windows.Forms.Button
    Friend WithEvents lbTitleSearch As Windows.Forms.ListBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents txtTitleSearch As Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents txtTilteRef As Windows.Forms.TextBox
    Friend WithEvents BindingNavigator2 As Windows.Forms.BindingNavigator
    Friend WithEvents Del As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton3 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton16 As Windows.Forms.ToolStripButton
    Friend WithEvents SubjectComboBox As Windows.Forms.ComboBox
    Friend WithEvents ProgramComboBox As Windows.Forms.ComboBox
    Friend WithEvents YearPublishedTextBox As Windows.Forms.TextBox
    Friend WithEvents PublisherTextBox1 As Windows.Forms.TextBox
    Friend WithEvents ISBNTextBox As Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox1 As Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As Windows.Forms.TextBox
    Friend WithEvents tbBookLoan As Windows.Forms.TabPage
    Friend WithEvents BookLoanType As Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator3 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton2 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton10 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton11 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton12 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton14 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton15 As Windows.Forms.ToolStripButton
    Friend WithEvents BookLoanTypeDataGridView As Windows.Forms.DataGridView
    Friend WithEvents tbBookMaster As Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As Windows.Forms.SplitContainer
    Friend WithEvents lbBookAvailability As Windows.Forms.Label
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents lbboooksearch As Windows.Forms.ListBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents lbStudent As Windows.Forms.ListBox
    Friend WithEvents txtBookSearch As Windows.Forms.TextBox
    Friend WithEvents gbreplacement As Windows.Forms.GroupBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents chkDamagedBooks As Windows.Forms.CheckedListBox
    Friend WithEvents txtBukreplaceStud As Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents txtBookMasterTitle As Windows.Forms.TextBox
    Friend WithEvents txtBookMasterComment As Windows.Forms.TextBox
    Friend WithEvents lbIndTitleSearch As Windows.Forms.ListBox
    Friend WithEvents CopyComboBox As Windows.Forms.ComboBox
    Friend WithEvents cboLoanType As Windows.Forms.ComboBox
    Friend WithEvents TypeComboBox As Windows.Forms.ComboBox
    Friend WithEvents DateAcquiredMaskedTextBox As Windows.Forms.MaskedTextBox
    Friend WithEvents BindingNavigator1 As Windows.Forms.BindingNavigator
    Friend WithEvents Add As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As Windows.Forms.ToolStripButton
    Friend WithEvents SerialTextBox As Windows.Forms.TextBox
    Friend WithEvents StatusComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents tbBookTrans As Windows.Forms.TabPage
    Friend WithEvents txtBookMasterRef As Windows.Forms.TextBox
    Friend WithEvents btnStudSearchPanel As Windows.Forms.Button
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents LoanDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DurationDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodDataGridViewTextBoxColumn As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FineDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents mskReplacementDate As Windows.Forms.MaskedTextBox
    Friend WithEvents txtBookMasterCost As Windows.Forms.TextBox
    Friend WithEvents BookIssueFormBindingSource As Windows.Forms.BindingSource
    Friend WithEvents BookIssueFormTableAdapter As dsSchoolLibraryTableAdapters.BookIssueFormTableAdapter
    Friend WithEvents cboReturnType As Windows.Forms.ComboBox
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents btnReturnSearch As Windows.Forms.Button
    Friend WithEvents Button5 As Windows.Forms.Button
    Friend WithEvents Button6 As Windows.Forms.Button
End Class
