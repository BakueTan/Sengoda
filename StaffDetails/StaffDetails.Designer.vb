<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaffDetails
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
        Dim StaffIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim StaffTypeLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim IDNumberLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Residential_AddressLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim Email_adrressLabel As System.Windows.Forms.Label
        Dim DateJoinedSchoolLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim DurationLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim StaffIDLabel2 As System.Windows.Forms.Label
        Dim ReasonForLeavingLabel As System.Windows.Forms.Label
        Dim DateLeftLabel As System.Windows.Forms.Label
        Dim StaffIDLabel3 As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim ContractLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaffDetails))
        Me.StaffTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnSubjectSearch = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.ttxSearchtext = New System.Windows.Forms.TextBox()
        Me.StaffPersonalDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.StaffPersonalDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSchool = New StaffDetails.dsSchool()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StaffPersonalDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ContactTextBox1 = New System.Windows.Forms.TextBox()
        Me.Residential_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Email_adrressTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboLoginID = New System.Windows.Forms.ComboBox()
        Me.ContractComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Date_EnrolledMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.StaffTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.IDNumberTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbsubTeacher = New System.Windows.Forms.TabPage()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.dgSubsTaught = New System.Windows.Forms.DataGridView()
        Me.SubTaughtProgram = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FormsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubTaughtClass = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubTaughtLevel = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SubTaughtSession = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SchoolsessionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubTaughtSubject = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.lbSubTaughtSearch = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbStaffName = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.staffID = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lbFormTeacher = New System.Windows.Forms.ListBox()
        Me.dgFormTeacher = New System.Windows.Forms.DataGridView()
        Me.ftProg = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ftClass = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ftLevel = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ftSession = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtFormTeacher = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.DurationTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LeaveTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.StaffIDComboBox3 = New System.Windows.Forms.ComboBox()
        Me.staflivfirst = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.stafflivprev = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.stafflivpos = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.stafflivcount = New System.Windows.Forms.ToolStripLabel()
        Me.stafflivnext = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.stafflivlast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.stafflivnew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitpos = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.exitcoount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator28 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator29 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator30 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.ReasonForLeavingTextBox = New System.Windows.Forms.TextBox()
        Me.DateLeftDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StaffIDComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TreeView6 = New System.Windows.Forms.TreeView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.StaffPersonalDetailsTableAdapter = New StaffDetails.dsSchoolTableAdapters.StaffPersonalDetailsTableAdapter()
        Me.FormsTableAdapter = New StaffDetails.dsSchoolTableAdapters.formsTableAdapter()
        Me.ClassesTableAdapter = New StaffDetails.dsSchoolTableAdapters.ClassesTableAdapter()
        Me.SchoolsessionsTableAdapter = New StaffDetails.dsSchoolTableAdapters.schoolsessionsTableAdapter()
        Me.stafflivsave = New System.Windows.Forms.ToolStripButton()
        Me.stafflivdel = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.cboSubTeachersbyClass = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        StaffIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        StaffTypeLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        IDNumberLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Residential_AddressLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        Email_adrressLabel = New System.Windows.Forms.Label()
        DateJoinedSchoolLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        DurationLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        StaffIDLabel2 = New System.Windows.Forms.Label()
        ReasonForLeavingLabel = New System.Windows.Forms.Label()
        DateLeftLabel = New System.Windows.Forms.Label()
        StaffIDLabel3 = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        ContractLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.StaffTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.StaffPersonalDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffPersonalDetailsBindingNavigator.SuspendLayout()
        CType(Me.StaffPersonalDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbsubTeacher.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.dgSubsTaught, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolsessionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgFormTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.Location = New System.Drawing.Point(23, 22)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(46, 13)
        StaffIDLabel.TabIndex = 0
        StaffIDLabel.Text = "Staff ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(383, 46)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(60, 13)
        NameLabel.TabIndex = 2
        NameLabel.Text = "First Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(163, 46)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 4
        SurnameLabel.Text = "Surname:"
        '
        'StaffTypeLabel
        '
        StaffTypeLabel.AutoSize = True
        StaffTypeLabel.Location = New System.Drawing.Point(23, 70)
        StaffTypeLabel.Name = "StaffTypeLabel"
        StaffTypeLabel.Size = New System.Drawing.Size(59, 13)
        StaffTypeLabel.TabIndex = 8
        StaffTypeLabel.Text = "Staff Type:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(384, 66)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(71, 13)
        DateOfBirthLabel.TabIndex = 10
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'IDNumberLabel
        '
        IDNumberLabel.AutoSize = True
        IDNumberLabel.Location = New System.Drawing.Point(23, 97)
        IDNumberLabel.Name = "IDNumberLabel"
        IDNumberLabel.Size = New System.Drawing.Size(58, 13)
        IDNumberLabel.TabIndex = 14
        IDNumberLabel.Text = "IDNumber:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(218, 70)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 18
        GenderLabel.Text = "Gender:"
        '
        'Residential_AddressLabel
        '
        Residential_AddressLabel.AutoSize = True
        Residential_AddressLabel.Location = New System.Drawing.Point(6, 30)
        Residential_AddressLabel.Name = "Residential_AddressLabel"
        Residential_AddressLabel.Size = New System.Drawing.Size(103, 13)
        Residential_AddressLabel.TabIndex = 20
        Residential_AddressLabel.Text = "Residential Address:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Location = New System.Drawing.Point(6, 51)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(47, 13)
        ContactLabel.TabIndex = 22
        ContactLabel.Text = "Contact:"
        '
        'Email_adrressLabel
        '
        Email_adrressLabel.AutoSize = True
        Email_adrressLabel.Location = New System.Drawing.Point(6, 73)
        Email_adrressLabel.Name = "Email_adrressLabel"
        Email_adrressLabel.Size = New System.Drawing.Size(76, 13)
        Email_adrressLabel.TabIndex = 24
        Email_adrressLabel.Text = "Email Address:"
        '
        'DateJoinedSchoolLabel
        '
        DateJoinedSchoolLabel.AutoSize = True
        DateJoinedSchoolLabel.Location = New System.Drawing.Point(6, 21)
        DateJoinedSchoolLabel.Name = "DateJoinedSchoolLabel"
        DateJoinedSchoolLabel.Size = New System.Drawing.Size(106, 13)
        DateJoinedSchoolLabel.TabIndex = 0
        DateJoinedSchoolLabel.Text = "Date Joined Service:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(325, -98)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(44, 13)
        Label4.TabIndex = 0
        Label4.Text = "staff ID:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(6, 30)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(62, 13)
        Label6.TabIndex = 2
        Label6.Text = "NOK name:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(6, 73)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(68, 13)
        Label8.TabIndex = 6
        Label8.Text = "Relationship:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(6, 51)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(51, 13)
        Label9.TabIndex = 8
        Label9.Text = "Res Add:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(201, 50)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(87, 13)
        Label10.TabIndex = 10
        Label10.Text = "Contact Number:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(6, 22)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(35, 13)
        Label11.TabIndex = 8
        Label11.Text = "Staff :"
        '
        'DurationLabel
        '
        DurationLabel.AutoSize = True
        DurationLabel.Location = New System.Drawing.Point(15, 116)
        DurationLabel.Name = "DurationLabel"
        DurationLabel.Size = New System.Drawing.Size(83, 13)
        DurationLabel.TabIndex = 6
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(15, 53)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(67, 13)
        TypeLabel.TabIndex = 4
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(15, 85)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 2
        '
        'StaffIDLabel2
        '
        StaffIDLabel2.AutoSize = True
        StaffIDLabel2.Location = New System.Drawing.Point(15, 26)
        StaffIDLabel2.Name = "StaffIDLabel2"
        StaffIDLabel2.Size = New System.Drawing.Size(44, 13)
        StaffIDLabel2.TabIndex = 8
        '
        'ReasonForLeavingLabel
        '
        ReasonForLeavingLabel.AutoSize = True
        ReasonForLeavingLabel.Location = New System.Drawing.Point(34, 76)
        ReasonForLeavingLabel.Name = "ReasonForLeavingLabel"
        ReasonForLeavingLabel.Size = New System.Drawing.Size(106, 13)
        ReasonForLeavingLabel.TabIndex = 4
        '
        'DateLeftLabel
        '
        DateLeftLabel.AutoSize = True
        DateLeftLabel.Location = New System.Drawing.Point(34, 51)
        DateLeftLabel.Name = "DateLeftLabel"
        DateLeftLabel.Size = New System.Drawing.Size(54, 13)
        DateLeftLabel.TabIndex = 2
        '
        'StaffIDLabel3
        '
        StaffIDLabel3.AutoSize = True
        StaffIDLabel3.Location = New System.Drawing.Point(34, 24)
        StaffIDLabel3.Name = "StaffIDLabel3"
        StaffIDLabel3.Size = New System.Drawing.Size(46, 13)
        StaffIDLabel3.TabIndex = 5
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(6, 43)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(67, 17)
        DepartmentLabel.TabIndex = 20
        DepartmentLabel.Text = "Designation:"
        DepartmentLabel.UseCompatibleTextRendering = True
        '
        'ContractLabel
        '
        ContractLabel.AutoSize = True
        ContractLabel.Location = New System.Drawing.Point(6, 66)
        ContractLabel.Name = "ContractLabel"
        ContractLabel.Size = New System.Drawing.Size(103, 13)
        ContractLabel.TabIndex = 20
        ContractLabel.Text = "Contract/Permanent"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(6, 92)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(44, 13)
        Label7.TabIndex = 22
        Label7.Text = "LoginID"
        AddHandler Label7.Click, AddressOf Me.Label7_Click
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(6, 22)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(35, 13)
        Label2.TabIndex = 8
        Label2.Text = "Staff :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(325, -98)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(44, 13)
        Label3.TabIndex = 0
        Label3.Text = "staff ID:"
        '
        'StaffTabControl
        '
        Me.StaffTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StaffTabControl.Controls.Add(Me.TabPage1)
        Me.StaffTabControl.Controls.Add(Me.TabPage5)
        Me.StaffTabControl.Location = New System.Drawing.Point(0, 0)
        Me.StaffTabControl.Name = "StaffTabControl"
        Me.StaffTabControl.SelectedIndex = 0
        Me.StaffTabControl.Size = New System.Drawing.Size(1256, 650)
        Me.StaffTabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.ImageKey = "Man 11.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1248, 624)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal Details"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSubjectSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label24)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstResult)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ttxSearchtext)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.StaffPersonalDetailsBindingNavigator)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox12)
        Me.SplitContainer1.Size = New System.Drawing.Size(1242, 618)
        Me.SplitContainer1.SplitterDistance = 210
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'btnSubjectSearch
        '
        Me.btnSubjectSearch.BackgroundImage = Global.StaffDetails.My.Resources.Resources.Find
        Me.btnSubjectSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubjectSearch.Location = New System.Drawing.Point(166, 214)
        Me.btnSubjectSearch.Name = "btnSubjectSearch"
        Me.btnSubjectSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnSubjectSearch.TabIndex = 19
        Me.btnSubjectSearch.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(30, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 28)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(11, 196)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 13)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "StaffSearch"
        '
        'lstResult
        '
        Me.lstResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstResult.BackColor = System.Drawing.Color.LightYellow
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(0, 240)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(208, 199)
        Me.lstResult.TabIndex = 14
        Me.lstResult.Visible = False
        '
        'ttxSearchtext
        '
        Me.ttxSearchtext.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ttxSearchtext.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.ttxSearchtext.Location = New System.Drawing.Point(14, 215)
        Me.ttxSearchtext.Name = "ttxSearchtext"
        Me.ttxSearchtext.Size = New System.Drawing.Size(146, 20)
        Me.ttxSearchtext.TabIndex = 13
        '
        'StaffPersonalDetailsBindingNavigator
        '
        Me.StaffPersonalDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffPersonalDetailsBindingNavigator.BindingSource = Me.StaffPersonalDetailsBindingSource
        Me.StaffPersonalDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffPersonalDetailsBindingNavigator.DeleteItem = Nothing
        Me.StaffPersonalDetailsBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StaffPersonalDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.StaffPersonalDetailsBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.StaffPersonalDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StaffPersonalDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffPersonalDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffPersonalDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffPersonalDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffPersonalDetailsBindingNavigator.Name = "StaffPersonalDetailsBindingNavigator"
        Me.StaffPersonalDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffPersonalDetailsBindingNavigator.Size = New System.Drawing.Size(1032, 25)
        Me.StaffPersonalDetailsBindingNavigator.TabIndex = 1
        Me.StaffPersonalDetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'StaffPersonalDetailsBindingSource
        '
        Me.StaffPersonalDetailsBindingSource.DataMember = "StaffPersonalDetails"
        Me.StaffPersonalDetailsBindingSource.DataSource = Me.DsSchool
        '
        'DsSchool
        '
        Me.DsSchool.DataSetName = "dsSchool"
        Me.DsSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'StaffPersonalDetailsBindingNavigatorSaveItem
        '
        Me.StaffPersonalDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffPersonalDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffPersonalDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffPersonalDetailsBindingNavigatorSaveItem.Name = "StaffPersonalDetailsBindingNavigatorSaveItem"
        Me.StaffPersonalDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StaffPersonalDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.StaffDetails.My.Resources.Resources.Delete
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Delete"
        Me.ToolStripButton1.ToolTipText = "Delete"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Import"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "PrintProfile"
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.White
        Me.GroupBox12.Controls.Add(Me.Button3)
        Me.GroupBox12.Controls.Add(Me.GroupBox14)
        Me.GroupBox12.Controls.Add(Me.GroupBox9)
        Me.GroupBox12.Controls.Add(Me.GroupBox2)
        Me.GroupBox12.Controls.Add(Me.GroupBox3)
        Me.GroupBox12.Controls.Add(Me.GroupBox1)
        Me.GroupBox12.Location = New System.Drawing.Point(3, 33)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1029, 598)
        Me.GroupBox12.TabIndex = 26
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Staff Details"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(457, 520)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 36)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "RegisterFingerPrint"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.PictureBox13)
        Me.GroupBox14.Location = New System.Drawing.Point(367, 265)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(294, 151)
        Me.GroupBox14.TabIndex = 5
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Double Click To Upload Signature"
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.White
        Me.PictureBox13.BackgroundImage = Global.StaffDetails.My.Resources.Resources.signature
        Me.PictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox13.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StaffPersonalDetailsBindingSource, "Signature", True))
        Me.PictureBox13.Image = Global.StaffDetails.My.Resources.Resources.signature
        Me.PictureBox13.Location = New System.Drawing.Point(32, 35)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(244, 98)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 25
        Me.PictureBox13.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox9.Controls.Add(Label6)
        Me.GroupBox9.Controls.Add(Me.TextBox5)
        Me.GroupBox9.Controls.Add(Label8)
        Me.GroupBox9.Controls.Add(Me.TextBox7)
        Me.GroupBox9.Controls.Add(Label9)
        Me.GroupBox9.Controls.Add(Me.TextBox8)
        Me.GroupBox9.Controls.Add(Label10)
        Me.GroupBox9.Controls.Add(Me.TextBox9)
        Me.GroupBox9.Location = New System.Drawing.Point(445, 148)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(478, 102)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Next Of Kin Details"
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "nokname", True))
        Me.TextBox5.Location = New System.Drawing.Point(95, 27)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(351, 20)
        Me.TextBox5.TabIndex = 0
        '
        'TextBox7
        '
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "relation", True))
        Me.TextBox7.Location = New System.Drawing.Point(95, 70)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 3
        '
        'TextBox8
        '
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "nokadd", True))
        Me.TextBox8.Location = New System.Drawing.Point(95, 48)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 1
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "nokcontact", True))
        Me.TextBox9.Location = New System.Drawing.Point(294, 48)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(152, 20)
        Me.TextBox9.TabIndex = 2
        Me.TextBox9.Text = "+263"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Controls.Add(Me.ContactTextBox1)
        Me.GroupBox2.Controls.Add(Residential_AddressLabel)
        Me.GroupBox2.Controls.Add(ContactLabel)
        Me.GroupBox2.Controls.Add(Email_adrressLabel)
        Me.GroupBox2.Controls.Add(Me.Residential_AddressTextBox)
        Me.GroupBox2.Controls.Add(Me.Email_adrressTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 102)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Staff Contact Details"
        '
        'ContactTextBox1
        '
        Me.ContactTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "Contact", True))
        Me.ContactTextBox1.Location = New System.Drawing.Point(110, 48)
        Me.ContactTextBox1.Name = "ContactTextBox1"
        Me.ContactTextBox1.Size = New System.Drawing.Size(165, 20)
        Me.ContactTextBox1.TabIndex = 1
        Me.ContactTextBox1.Text = "+263"
        '
        'Residential_AddressTextBox
        '
        Me.Residential_AddressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Residential_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "ResidentialAddress", True))
        Me.Residential_AddressTextBox.Location = New System.Drawing.Point(110, 27)
        Me.Residential_AddressTextBox.Name = "Residential_AddressTextBox"
        Me.Residential_AddressTextBox.Size = New System.Drawing.Size(276, 20)
        Me.Residential_AddressTextBox.TabIndex = 0
        '
        'Email_adrressTextBox
        '
        Me.Email_adrressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "EmailAddress", True))
        Me.Email_adrressTextBox.Location = New System.Drawing.Point(110, 70)
        Me.Email_adrressTextBox.Name = "Email_adrressTextBox"
        Me.Email_adrressTextBox.Size = New System.Drawing.Size(164, 20)
        Me.Email_adrressTextBox.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox3.Controls.Add(Label7)
        Me.GroupBox3.Controls.Add(Me.cboLoginID)
        Me.GroupBox3.Controls.Add(ContractLabel)
        Me.GroupBox3.Controls.Add(Me.ContractComboBox)
        Me.GroupBox3.Controls.Add(Me.DepartmentComboBox)
        Me.GroupBox3.Controls.Add(DepartmentLabel)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox3.Controls.Add(DateJoinedSchoolLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(652, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 123)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Staff Contract Details"
        '
        'cboLoginID
        '
        Me.cboLoginID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboLoginID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLoginID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "LoginID", True))
        Me.cboLoginID.FormattingEnabled = True
        Me.cboLoginID.Items.AddRange(New Object() {"Contract", "Permanent"})
        Me.cboLoginID.Location = New System.Drawing.Point(118, 89)
        Me.cboLoginID.Name = "cboLoginID"
        Me.cboLoginID.Size = New System.Drawing.Size(121, 21)
        Me.cboLoginID.TabIndex = 3
        '
        'ContractComboBox
        '
        Me.ContractComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ContractComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ContractComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "Contract", True))
        Me.ContractComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ContractComboBox.FormattingEnabled = True
        Me.ContractComboBox.Items.AddRange(New Object() {"Contract", "Permanent"})
        Me.ContractComboBox.Location = New System.Drawing.Point(118, 63)
        Me.ContractComboBox.Name = "ContractComboBox"
        Me.ContractComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ContractComboBox.TabIndex = 2
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DepartmentComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DepartmentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "Department", True))
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Items.AddRange(New Object() {"TEACHER", "HEADMASTER", "BURSAR", "BOOK_KEEPER", "SECRECTARY", "GENERAL_HAND", "CLERK", "LIBRARIAN", "CARE_TAKER", "DRIVER", "SECURITY", "PRINCIPAL", "ADMINISTRATOR", "RECEPTIONIST", "SENIOR-TEACHER", "BOARDINGMASTER"})
        Me.DepartmentComboBox.Location = New System.Drawing.Point(118, 40)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DepartmentComboBox.TabIndex = 1
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "DateJoinedSchool", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(118, 17)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.MaskedTextBox1.TabIndex = 0
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Date_EnrolledMaskedTextBox)
        Me.GroupBox1.Controls.Add(StaffIDLabel)
        Me.GroupBox1.Controls.Add(Me.StaffIDTextBox)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(SurnameLabel)
        Me.GroupBox1.Controls.Add(Me.SurnameTextBox)
        Me.GroupBox1.Controls.Add(StaffTypeLabel)
        Me.GroupBox1.Controls.Add(Me.StaffTypeComboBox)
        Me.GroupBox1.Controls.Add(DateOfBirthLabel)
        Me.GroupBox1.Controls.Add(IDNumberLabel)
        Me.GroupBox1.Controls.Add(Me.IDNumberTextBox)
        Me.GroupBox1.Controls.Add(GenderLabel)
        Me.GroupBox1.Controls.Add(Me.GenderComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "StaffPersonalDetails"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "ContractRef", True))
        Me.TextBox1.Location = New System.Drawing.Point(264, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 20)
        Me.TextBox1.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "Title", True))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Mr", "Ms", "Miss", "Dr", "Prof"})
        Me.ComboBox1.Location = New System.Drawing.Point(95, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(62, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Title:"
        '
        'Date_EnrolledMaskedTextBox
        '
        Me.Date_EnrolledMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "DateOfBirth", True))
        Me.Date_EnrolledMaskedTextBox.Location = New System.Drawing.Point(458, 63)
        Me.Date_EnrolledMaskedTextBox.Mask = "00/00/0000"
        Me.Date_EnrolledMaskedTextBox.Name = "Date_EnrolledMaskedTextBox"
        Me.Date_EnrolledMaskedTextBox.Size = New System.Drawing.Size(154, 20)
        Me.Date_EnrolledMaskedTextBox.TabIndex = 6
        Me.Date_EnrolledMaskedTextBox.ValidatingType = GetType(Date)
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.StaffIDTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.StaffIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "staffID", True))
        Me.StaffIDTextBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.StaffIDTextBox.Location = New System.Drawing.Point(95, 19)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.ReadOnly = True
        Me.StaffIDTextBox.Size = New System.Drawing.Size(135, 20)
        Me.StaffIDTextBox.TabIndex = 0
        '
        'NameTextBox
        '
        Me.NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(458, 40)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(154, 20)
        Me.NameTextBox.TabIndex = 3
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(221, 43)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(154, 20)
        Me.SurnameTextBox.TabIndex = 2
        '
        'StaffTypeComboBox
        '
        Me.StaffTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StaffTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.StaffTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "StaffType", True))
        Me.StaffTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StaffTypeComboBox.FormattingEnabled = True
        Me.StaffTypeComboBox.Items.AddRange(New Object() {"SDA", "GOVT", "EXECUTIVE", "PRIVATE"})
        Me.StaffTypeComboBox.Location = New System.Drawing.Point(95, 67)
        Me.StaffTypeComboBox.Name = "StaffTypeComboBox"
        Me.StaffTypeComboBox.Size = New System.Drawing.Size(100, 21)
        Me.StaffTypeComboBox.TabIndex = 4
        '
        'IDNumberTextBox
        '
        Me.IDNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "IDNumber", True))
        Me.IDNumberTextBox.Location = New System.Drawing.Point(95, 94)
        Me.IDNumberTextBox.Name = "IDNumberTextBox"
        Me.IDNumberTextBox.Size = New System.Drawing.Size(154, 20)
        Me.IDNumberTextBox.TabIndex = 7
        '
        'GenderComboBox
        '
        Me.GenderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GenderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"M", "F"})
        Me.GenderComboBox.Location = New System.Drawing.Point(296, 67)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(79, 21)
        Me.GenderComboBox.TabIndex = 5
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage5.Controls.Add(Me.SplitContainer3)
        Me.TabPage5.ImageKey = "Test.png"
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1248, 624)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Classes Taught"
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
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer3.Panel1Collapsed = True
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer3.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(1242, 618)
        Me.SplitContainer3.SplitterDistance = 218
        Me.SplitContainer3.SplitterWidth = 1
        Me.SplitContainer3.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbsubTeacher)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1240, 616)
        Me.TabControl1.TabIndex = 26
        '
        'tbsubTeacher
        '
        Me.tbsubTeacher.Controls.Add(Me.GroupBox11)
        Me.tbsubTeacher.Location = New System.Drawing.Point(4, 22)
        Me.tbsubTeacher.Name = "tbsubTeacher"
        Me.tbsubTeacher.Padding = New System.Windows.Forms.Padding(3)
        Me.tbsubTeacher.Size = New System.Drawing.Size(1232, 590)
        Me.tbsubTeacher.TabIndex = 0
        Me.tbsubTeacher.Text = "Subject Teachers"
        Me.tbsubTeacher.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.cboSubTeachersbyClass)
        Me.GroupBox11.Controls.Add(Me.Label5)
        Me.GroupBox11.Controls.Add(Me.Button8)
        Me.GroupBox11.Controls.Add(Me.dgSubsTaught)
        Me.GroupBox11.Controls.Add(Me.lbSubTaughtSearch)
        Me.GroupBox11.Controls.Add(Me.Button1)
        Me.GroupBox11.Controls.Add(Me.GroupBox6)
        Me.GroupBox11.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(1152, 523)
        Me.GroupBox11.TabIndex = 25
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Subjects  Teachers"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(377, 405)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(170, 32)
        Me.Button8.TabIndex = 25
        Me.Button8.Text = "&Remove Selected Subjects"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'dgSubsTaught
        '
        Me.dgSubsTaught.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSubsTaught.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubTaughtProgram, Me.SubTaughtClass, Me.SubTaughtLevel, Me.SubTaughtSession, Me.SubTaughtSubject})
        Me.dgSubsTaught.Location = New System.Drawing.Point(137, 114)
        Me.dgSubsTaught.Name = "dgSubsTaught"
        Me.dgSubsTaught.Size = New System.Drawing.Size(663, 285)
        Me.dgSubsTaught.TabIndex = 24
        '
        'SubTaughtProgram
        '
        Me.SubTaughtProgram.DataPropertyName = "Prog"
        Me.SubTaughtProgram.DataSource = Me.FormsBindingSource
        Me.SubTaughtProgram.DisplayMember = "Forms"
        Me.SubTaughtProgram.HeaderText = "Program"
        Me.SubTaughtProgram.Name = "SubTaughtProgram"
        Me.SubTaughtProgram.ValueMember = "Forms"
        '
        'FormsBindingSource
        '
        Me.FormsBindingSource.DataMember = "forms"
        Me.FormsBindingSource.DataSource = Me.DsSchool
        '
        'SubTaughtClass
        '
        Me.SubTaughtClass.DataPropertyName = "Clas"
        Me.SubTaughtClass.DataSource = Me.ClassesBindingSource
        Me.SubTaughtClass.DisplayMember = "Description"
        Me.SubTaughtClass.HeaderText = "Class"
        Me.SubTaughtClass.Name = "SubTaughtClass"
        Me.SubTaughtClass.ValueMember = "Description"
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.DsSchool
        '
        'SubTaughtLevel
        '
        Me.SubTaughtLevel.DataPropertyName = "lvl"
        Me.SubTaughtLevel.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.SubTaughtLevel.HeaderText = "Level"
        Me.SubTaughtLevel.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.SubTaughtLevel.Name = "SubTaughtLevel"
        '
        'SubTaughtSession
        '
        Me.SubTaughtSession.DataPropertyName = "Sess"
        Me.SubTaughtSession.DataSource = Me.SchoolsessionsBindingSource
        Me.SubTaughtSession.DisplayMember = "Session"
        Me.SubTaughtSession.HeaderText = "Session"
        Me.SubTaughtSession.Name = "SubTaughtSession"
        Me.SubTaughtSession.ValueMember = "Session"
        '
        'SchoolsessionsBindingSource
        '
        Me.SchoolsessionsBindingSource.DataMember = "schoolsessions"
        Me.SchoolsessionsBindingSource.DataSource = Me.DsSchool
        '
        'SubTaughtSubject
        '
        Me.SubTaughtSubject.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.SubTaughtSubject.HeaderText = "Subject"
        Me.SubTaughtSubject.Name = "SubTaughtSubject"
        Me.SubTaughtSubject.Width = 200
        '
        'lbSubTaughtSearch
        '
        Me.lbSubTaughtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbSubTaughtSearch.BackColor = System.Drawing.Color.LightYellow
        Me.lbSubTaughtSearch.FormattingEnabled = True
        Me.lbSubTaughtSearch.Location = New System.Drawing.Point(507, 19)
        Me.lbSubTaughtSearch.Name = "lbSubTaughtSearch"
        Me.lbSubTaughtSearch.Size = New System.Drawing.Size(293, 82)
        Me.lbSubTaughtSearch.TabIndex = 15
        Me.lbSubTaughtSearch.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 32)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox6.Controls.Add(Me.lbStaffName)
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Controls.Add(Label11)
        Me.GroupBox6.Controls.Add(Label4)
        Me.GroupBox6.Controls.Add(Me.staffID)
        Me.GroupBox6.Location = New System.Drawing.Point(244, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(251, 65)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Staff"
        '
        'lbStaffName
        '
        Me.lbStaffName.AutoSize = True
        Me.lbStaffName.Location = New System.Drawing.Point(9, 46)
        Me.lbStaffName.Name = "lbStaffName"
        Me.lbStaffName.Size = New System.Drawing.Size(0, 13)
        Me.lbStaffName.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.StaffDetails.My.Resources.Resources.Find
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(213, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(19, 20)
        Me.Button4.TabIndex = 20
        Me.Button4.UseVisualStyleBackColor = True
        '
        'staffID
        '
        Me.staffID.Location = New System.Drawing.Point(45, 19)
        Me.staffID.Name = "staffID"
        Me.staffID.Size = New System.Drawing.Size(166, 20)
        Me.staffID.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1232, 590)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Class Teachers"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.lbFormTeacher)
        Me.GroupBox4.Controls.Add(Me.dgFormTeacher)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Location = New System.Drawing.Point(193, 33)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(795, 461)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Class Teachers"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(384, 353)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(170, 32)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "&Remove Selected Classes"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(307, 353)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(71, 32)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "&Save"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'lbFormTeacher
        '
        Me.lbFormTeacher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbFormTeacher.BackColor = System.Drawing.Color.LightYellow
        Me.lbFormTeacher.FormattingEnabled = True
        Me.lbFormTeacher.Location = New System.Drawing.Point(500, 65)
        Me.lbFormTeacher.Name = "lbFormTeacher"
        Me.lbFormTeacher.Size = New System.Drawing.Size(293, 121)
        Me.lbFormTeacher.TabIndex = 16
        Me.lbFormTeacher.Visible = False
        '
        'dgFormTeacher
        '
        Me.dgFormTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFormTeacher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ftProg, Me.ftClass, Me.ftLevel, Me.ftSession})
        Me.dgFormTeacher.Location = New System.Drawing.Point(201, 117)
        Me.dgFormTeacher.Name = "dgFormTeacher"
        Me.dgFormTeacher.Size = New System.Drawing.Size(474, 230)
        Me.dgFormTeacher.TabIndex = 12
        '
        'ftProg
        '
        Me.ftProg.DataPropertyName = "Prog"
        Me.ftProg.DataSource = Me.FormsBindingSource
        Me.ftProg.DisplayMember = "Forms"
        Me.ftProg.HeaderText = "Program"
        Me.ftProg.Name = "ftProg"
        Me.ftProg.ValueMember = "Forms"
        '
        'ftClass
        '
        Me.ftClass.DataPropertyName = "Clas"
        Me.ftClass.DataSource = Me.ClassesBindingSource
        Me.ftClass.DisplayMember = "Description"
        Me.ftClass.HeaderText = "Class"
        Me.ftClass.Name = "ftClass"
        Me.ftClass.ValueMember = "Description"
        '
        'ftLevel
        '
        Me.ftLevel.DataPropertyName = "lvl"
        Me.ftLevel.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ftLevel.HeaderText = "Level"
        Me.ftLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.ftLevel.Name = "ftLevel"
        '
        'ftSession
        '
        Me.ftSession.DataPropertyName = "Sess"
        Me.ftSession.DataSource = Me.SchoolsessionsBindingSource
        Me.ftSession.DisplayMember = "Session"
        Me.ftSession.HeaderText = "Session"
        Me.ftSession.Name = "ftSession"
        Me.ftSession.ValueMember = "Session"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Label2)
        Me.GroupBox5.Controls.Add(Label3)
        Me.GroupBox5.Controls.Add(Me.txtFormTeacher)
        Me.GroupBox5.Location = New System.Drawing.Point(262, 46)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(251, 65)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Staff"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 21
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.StaffDetails.My.Resources.Resources.Find
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(213, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(19, 20)
        Me.Button5.TabIndex = 20
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtFormTeacher
        '
        Me.txtFormTeacher.Location = New System.Drawing.Point(45, 19)
        Me.txtFormTeacher.Name = "txtFormTeacher"
        Me.txtFormTeacher.Size = New System.Drawing.Size(166, 20)
        Me.txtFormTeacher.TabIndex = 1
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox10.Location = New System.Drawing.Point(282, 267)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(363, 181)
        Me.GroupBox10.TabIndex = 8
        Me.GroupBox10.TabStop = False
        '
        'DurationTextBox
        '
        Me.DurationTextBox.Location = New System.Drawing.Point(104, 109)
        Me.DurationTextBox.Name = "DurationTextBox"
        Me.DurationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DurationTextBox.TabIndex = 7
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Location = New System.Drawing.Point(104, 78)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 3
        '
        'LeaveTypeComboBox
        '
        Me.LeaveTypeComboBox.FormattingEnabled = True
        Me.LeaveTypeComboBox.Location = New System.Drawing.Point(104, 51)
        Me.LeaveTypeComboBox.Name = "LeaveTypeComboBox"
        Me.LeaveTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.LeaveTypeComboBox.TabIndex = 8
        '
        'StaffIDComboBox3
        '
        Me.StaffIDComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StaffIDComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.StaffIDComboBox3.FormattingEnabled = True
        Me.StaffIDComboBox3.Location = New System.Drawing.Point(104, 23)
        Me.StaffIDComboBox3.Name = "StaffIDComboBox3"
        Me.StaffIDComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.StaffIDComboBox3.TabIndex = 9
        '
        'staflivfirst
        '
        Me.staflivfirst.BackColor = System.Drawing.Color.LightSteelBlue
        Me.staflivfirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.staflivfirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.staflivfirst.Name = "staflivfirst"
        Me.staflivfirst.Size = New System.Drawing.Size(53, 22)
        Me.staflivfirst.Text = "<<first"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 25)
        '
        'stafflivprev
        '
        Me.stafflivprev.BackColor = System.Drawing.Color.LightSteelBlue
        Me.stafflivprev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stafflivprev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stafflivprev.Name = "stafflivprev"
        Me.stafflivprev.Size = New System.Drawing.Size(67, 22)
        Me.stafflivprev.Text = "<previous"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 25)
        '
        'stafflivpos
        '
        Me.stafflivpos.Name = "stafflivpos"
        Me.stafflivpos.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(21, 22)
        Me.ToolStripLabel5.Text = "Of"
        '
        'stafflivcount
        '
        Me.stafflivcount.BackColor = System.Drawing.SystemColors.ControlDark
        Me.stafflivcount.Name = "stafflivcount"
        Me.stafflivcount.Size = New System.Drawing.Size(41, 22)
        Me.stafflivcount.Text = "Count"
        '
        'stafflivnext
        '
        Me.stafflivnext.BackColor = System.Drawing.Color.LightSteelBlue
        Me.stafflivnext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stafflivnext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stafflivnext.Name = "stafflivnext"
        Me.stafflivnext.Size = New System.Drawing.Size(45, 22)
        Me.stafflivnext.Text = ">next"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(6, 25)
        '
        'stafflivlast
        '
        Me.stafflivlast.BackColor = System.Drawing.Color.LightSteelBlue
        Me.stafflivlast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stafflivlast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stafflivlast.Name = "stafflivlast"
        Me.stafflivlast.Size = New System.Drawing.Size(52, 22)
        Me.stafflivlast.Text = ">>Last"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(6, 25)
        '
        'stafflivnew
        '
        Me.stafflivnew.BackColor = System.Drawing.Color.LightSteelBlue
        Me.stafflivnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stafflivnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stafflivnew.Name = "stafflivnew"
        Me.stafflivnew.Size = New System.Drawing.Size(37, 22)
        Me.stafflivnew.Text = "New"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton7.Text = "<<first"
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripButton8.Text = "<previous"
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(6, 25)
        '
        'exitpos
        '
        Me.exitpos.Name = "exitpos"
        Me.exitpos.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        Me.ToolStripSeparator26.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(21, 22)
        Me.ToolStripLabel8.Text = "Of"
        '
        'exitcoount
        '
        Me.exitcoount.BackColor = System.Drawing.SystemColors.ControlDark
        Me.exitcoount.Name = "exitcoount"
        Me.exitcoount.Size = New System.Drawing.Size(41, 22)
        Me.exitcoount.Text = "Count"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripButton9.Text = ">next"
        '
        'ToolStripSeparator27
        '
        Me.ToolStripSeparator27.Name = "ToolStripSeparator27"
        Me.ToolStripSeparator27.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton10.Text = ">>Last"
        '
        'ToolStripSeparator28
        '
        Me.ToolStripSeparator28.Name = "ToolStripSeparator28"
        Me.ToolStripSeparator28.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripButton11.Text = "New"
        '
        'ToolStripSeparator29
        '
        Me.ToolStripSeparator29.Name = "ToolStripSeparator29"
        Me.ToolStripSeparator29.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator30
        '
        Me.ToolStripSeparator30.Name = "ToolStripSeparator30"
        Me.ToolStripSeparator30.Size = New System.Drawing.Size(6, 25)
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox8.Location = New System.Drawing.Point(308, 287)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(376, 144)
        Me.GroupBox8.TabIndex = 15
        Me.GroupBox8.TabStop = False
        '
        'ReasonForLeavingTextBox
        '
        Me.ReasonForLeavingTextBox.Location = New System.Drawing.Point(146, 73)
        Me.ReasonForLeavingTextBox.Name = "ReasonForLeavingTextBox"
        Me.ReasonForLeavingTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ReasonForLeavingTextBox.TabIndex = 5
        '
        'DateLeftDateTimePicker
        '
        Me.DateLeftDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateLeftDateTimePicker.Location = New System.Drawing.Point(146, 47)
        Me.DateLeftDateTimePicker.Name = "DateLeftDateTimePicker"
        Me.DateLeftDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateLeftDateTimePicker.TabIndex = 3
        '
        'StaffIDComboBox2
        '
        Me.StaffIDComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StaffIDComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.StaffIDComboBox2.FormattingEnabled = True
        Me.StaffIDComboBox2.Location = New System.Drawing.Point(146, 19)
        Me.StaffIDComboBox2.Name = "StaffIDComboBox2"
        Me.StaffIDComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.StaffIDComboBox2.TabIndex = 6
        '
        'TreeView6
        '
        Me.TreeView6.BackColor = System.Drawing.Color.White
        Me.TreeView6.LineColor = System.Drawing.Color.Empty
        Me.TreeView6.Location = New System.Drawing.Point(14, 278)
        Me.TreeView6.Name = "TreeView6"
        Me.TreeView6.Size = New System.Drawing.Size(184, 249)
        Me.TreeView6.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(1087, 652)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(169, 49)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(910, 656)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(158, 42)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'StaffPersonalDetailsTableAdapter
        '
        Me.StaffPersonalDetailsTableAdapter.ClearBeforeFill = True
        '
        'FormsTableAdapter
        '
        Me.FormsTableAdapter.ClearBeforeFill = True
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'SchoolsessionsTableAdapter
        '
        Me.SchoolsessionsTableAdapter.ClearBeforeFill = True
        '
        'stafflivsave
        '
        Me.stafflivsave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.stafflivsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stafflivsave.Image = CType(resources.GetObject("stafflivsave.Image"), System.Drawing.Image)
        Me.stafflivsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stafflivsave.Name = "stafflivsave"
        Me.stafflivsave.Size = New System.Drawing.Size(36, 22)
        Me.stafflivsave.Text = "&Save"
        '
        'stafflivdel
        '
        Me.stafflivdel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.stafflivdel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stafflivdel.Image = CType(resources.GetObject("stafflivdel.Image"), System.Drawing.Image)
        Me.stafflivdel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stafflivdel.Name = "stafflivdel"
        Me.stafflivdel.Size = New System.Drawing.Size(47, 22)
        Me.stafflivdel.Text = "Delete"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.StaffDetails.My.Resources.Resources.sms
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(931, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(89, 39)
        Me.PictureBox6.TabIndex = 16
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.StaffDetails.My.Resources.Resources.sms
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(159, 77)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripButton12.Text = "&Save"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripButton13.Text = "Delete"
        '
        'ToolStripButton18
        '
        Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripButton18.Text = "<Refresh>"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.StaffDetails.My.Resources.Resources.sms
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(915, -1)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(89, 39)
        Me.PictureBox7.TabIndex = 17
        Me.PictureBox7.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.StaffDetails.My.Resources.Resources.sms
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(14, 17)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(159, 77)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'cboSubTeachersbyClass
        '
        Me.cboSubTeachersbyClass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffPersonalDetailsBindingSource, "Title", True))
        Me.cboSubTeachersbyClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubTeachersbyClass.FormattingEnabled = True
        Me.cboSubTeachersbyClass.Items.AddRange(New Object() {"Mr", "Ms", "Miss", "Dr", "Prof"})
        Me.cboSubTeachersbyClass.Location = New System.Drawing.Point(887, 13)
        Me.cboSubTeachersbyClass.Name = "cboSubTeachersbyClass"
        Me.cboSubTeachersbyClass.Size = New System.Drawing.Size(226, 21)
        Me.cboSubTeachersbyClass.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(806, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Filter By Class:"
        '
        'frmStaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1273, 703)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.StaffTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStaffDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffDetails"
        Me.StaffTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.StaffPersonalDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffPersonalDetailsBindingNavigator.ResumeLayout(False)
        Me.StaffPersonalDetailsBindingNavigator.PerformLayout()
        CType(Me.StaffPersonalDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbsubTeacher.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.dgSubsTaught, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolsessionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgFormTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StaffTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StaffIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IDNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Residential_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_adrressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents staffID As System.Windows.Forms.TextBox
    '  Friend WithEvents StaffNOKTableAdapter As dsSchoolTableAdapters.StaffNOKTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    ' Friend WithEvents Term_FeesTableAdapter As dsSchoolTableAdapters.Term_FeesTableAdapter
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    ' Friend WithEvents LivTypeTableAdapter As dsSchoolTableAdapters.LivTypeTableAdapter
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    ' Friend WithEvents StaffLeavingTableAdapter As dsSchoolTableAdapters.staffLeavingTableAdapter
    ' Friend WithEvents StafflivTableAdapter As dsSchoolTableAdapters.StafflivTableAdapter
    ' Friend WithEvents DepsTableAdapter As dsSchoolTableAdapters.DepsTableAdapter
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents DurationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LeaveTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StaffIDComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents staflivfirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents stafflivprev As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents stafflivpos As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents stafflivcount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents stafflivnext As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents stafflivlast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents stafflivnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents stafflivsave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents stafflivdel As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator24 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator25 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents exitpos As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator26 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel8 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents exitcoount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator27 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator28 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator29 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator30 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton18 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents ReasonForLeavingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateLeftDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StaffIDComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents TreeView6 As System.Windows.Forms.TreeView
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents StaffPersonalDetailsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StaffPersonalDetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
    Friend WithEvents ttxSearchtext As System.Windows.Forms.TextBox
    Friend WithEvents lbSubTaughtSearch As System.Windows.Forms.ListBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Date_EnrolledMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContractComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents cboLoginID As Windows.Forms.ComboBox
    Friend WithEvents StaffPersonalDetailsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents StaffPersonalDetailsTableAdapter As dsSchoolTableAdapters.StaffPersonalDetailsTableAdapter
    Friend WithEvents btnSubjectSearch As Windows.Forms.Button
    Friend WithEvents DsSchool As dsSchool
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents lbStaffName As Windows.Forms.Label
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents tbsubTeacher As Windows.Forms.TabPage
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents lbFormTeacher As Windows.Forms.ListBox
    Friend WithEvents dgFormTeacher As Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Button5 As Windows.Forms.Button
    Friend WithEvents txtFormTeacher As Windows.Forms.TextBox
    Friend WithEvents Button6 As Windows.Forms.Button
    Friend WithEvents FormsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents FormsTableAdapter As dsSchoolTableAdapters.formsTableAdapter
    Friend WithEvents ClassesBindingSource As Windows.Forms.BindingSource
    Friend WithEvents ClassesTableAdapter As dsSchoolTableAdapters.ClassesTableAdapter
    Friend WithEvents SchoolsessionsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SchoolsessionsTableAdapter As dsSchoolTableAdapters.schoolsessionsTableAdapter
    Friend WithEvents ftProg As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ftClass As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ftLevel As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ftSession As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Button7 As Windows.Forms.Button
    Friend WithEvents dgSubsTaught As Windows.Forms.DataGridView
    Friend WithEvents SubTaughtProgram As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SubTaughtClass As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SubTaughtLevel As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SubTaughtSession As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SubTaughtSubject As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Button8 As Windows.Forms.Button
    Friend WithEvents cboSubTeachersbyClass As Windows.Forms.ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
End Class
