<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSchoolParameters
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
        Dim SubjectIDLabel As System.Windows.Forms.Label
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim FormsLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim SemestersLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim CreditsLabel As System.Windows.Forms.Label
        Dim TypeLabel1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim LogoLabel As System.Windows.Forms.Label
        Dim StudIdLengthLabel As System.Windows.Forms.Label
        Dim StudIdPrefixLabel As System.Windows.Forms.Label
        Dim ProgSufixLabel As System.Windows.Forms.Label
        Dim FeesLabel1 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim ServerLabel As System.Windows.Forms.Label
        Dim MailfromLabel As System.Windows.Forms.Label
        Dim PortLabel As System.Windows.Forms.Label
        Dim PasswordLabel1 As System.Windows.Forms.Label
        Dim DescriptionLabel1 As System.Windows.Forms.Label
        Dim ClasLabel As System.Windows.Forms.Label
        Dim SemLabel As System.Windows.Forms.Label
        Dim IntakeLabel1 As System.Windows.Forms.Label
        Dim ClassLabel As System.Windows.Forms.Label
        Dim ProgramLabel As System.Windows.Forms.Label
        Dim StartDateLabel As System.Windows.Forms.Label
        Dim EndDateLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim SessionLabel As System.Windows.Forms.Label
        Dim ExamClassRefLabel As System.Windows.Forms.Label
        Dim SittingLabel As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchoolParameters))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboBaseCurrency = New System.Windows.Forms.ComboBox()
        Me.SchoolinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSchoolParameters = New SchoolParameters.dsSchoolParameters()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtschoolref = New System.Windows.Forms.TextBox()
        Me.cboIdYearFormat = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.StudIdPrefixTextBox = New System.Windows.Forms.TextBox()
        Me.StudIdLengthTextBox = New System.Windows.Forms.TextBox()
        Me.AutoStudIDCheckBox = New System.Windows.Forms.CheckBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.SchoolInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SchoolInfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.WebTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbprograms = New System.Windows.Forms.ListBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnProgSearch = New System.Windows.Forms.Button()
        Me.txtProgSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtProgRef = New System.Windows.Forms.TextBox()
        Me.FormsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgSufixTextBox = New System.Windows.Forms.TextBox()
        Me.FormsTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.SemestersTextBox = New System.Windows.Forms.TextBox()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.SectionComboBox = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AddNew3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Add = New System.Windows.Forms.ToolStripButton()
        Me.Save = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.tbClasses = New System.Windows.Forms.TabPage()
        Me.lbClasses = New System.Windows.Forms.ListBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.btnClassSearch = New System.Windows.Forms.Button()
        Me.txtClassSearch = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.DescriptionTextBox1 = New System.Windows.Forms.TextBox()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClasComboBox = New System.Windows.Forms.ComboBox()
        Me.SemComboBox = New System.Windows.Forms.ComboBox()
        Me.IntakeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RefTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator18 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton90 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel14 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton92 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton93 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator40 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox14 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator41 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton94 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton95 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator42 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton96 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton91 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lbSubjects = New System.Windows.Forms.ListBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnSubjectSearch = New System.Windows.Forms.Button()
        Me.txtSubjectSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSubref = New System.Windows.Forms.TextBox()
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.FeesTextBox1 = New System.Windows.Forms.TextBox()
        Me.TypeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CreditsTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem3 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem3 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton75 = New System.Windows.Forms.ToolStripButton()
        Me.SubjectIDTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator4 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem4 = New System.Windows.Forms.ToolStripButton()
        Me.SMSAccBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem4 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem4 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.BindingNavigator8 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AddNew8 = New System.Windows.Forms.ToolStripButton()
        Me.SchoolsessionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton27 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton28 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton29 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton30 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton31 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton32 = New System.Windows.Forms.ToolStripButton()
        Me.SchoolsessionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.SessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator13 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton54 = New System.Windows.Forms.ToolStripButton()
        Me.DepsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton55 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton56 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton57 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox9 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton58 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton59 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton60 = New System.Windows.Forms.ToolStripButton()
        Me.DepsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage14 = New System.Windows.Forms.TabPage()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator14 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton61 = New System.Windows.Forms.ToolStripButton()
        Me.SchoolSectionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel10 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton62 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton63 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton64 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator28 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox10 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator29 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton65 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton66 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator30 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton67 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.SectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage18 = New System.Windows.Forms.TabPage()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator17 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton83 = New System.Windows.Forms.ToolStripButton()
        Me.SmtpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel13 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton84 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton85 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton86 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator37 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox13 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator38 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton87 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton88 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator39 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton89 = New System.Windows.Forms.ToolStripButton()
        Me.ServerTextBox = New System.Windows.Forms.TextBox()
        Me.MailfromTextBox = New System.Windows.Forms.TextBox()
        Me.PortTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BindingNavigator5 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tbGeneral = New System.Windows.Forms.TabPage()
        Me.tbExams = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.tbTermDuration = New System.Windows.Forms.TabPage()
        Me.lbTermDurations = New System.Windows.Forms.ListBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtTermDurationsSearch = New System.Windows.Forms.TextBox()
        Me.btnTermDurationSearch = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSemDurRef = New System.Windows.Forms.TextBox()
        Me.SemesterDurationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.msksemEndDate = New System.Windows.Forms.MaskedTextBox()
        Me.mskSemStartDate = New System.Windows.Forms.MaskedTextBox()
        Me.ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.ProgramComboBox = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AddNew = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.SemSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.tbProgramSubjects = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkPrograms = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tbExamSessions = New System.Windows.Forms.TabPage()
        Me.lbExamSearch = New System.Windows.Forms.ListBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.btnExamSearch = New System.Windows.Forms.Button()
        Me.txtExamSearch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.cboExamParentExam = New System.Windows.Forms.ComboBox()
        Me.ExamSessionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SessionTextBox = New System.Windows.Forms.TextBox()
        Me.ExamClassRefComboBox = New System.Windows.Forms.ComboBox()
        Me.SittingTextBox = New System.Windows.Forms.TextBox()
        Me.RefTextBox1 = New System.Windows.Forms.TextBox()
        Me.PublishCheckBox = New System.Windows.Forms.CheckBox()
        Me.AutoCommentCheckBox = New System.Windows.Forms.CheckBox()
        Me.BindingNavigator7 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton23 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton24 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton25 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton97 = New System.Windows.Forms.ToolStripButton()
        Me.tbExamGrading = New System.Windows.Forms.TabPage()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.chkMultipleAutoComments = New System.Windows.Forms.CheckBox()
        Me.txtgradeRef = New System.Windows.Forms.TextBox()
        Me.chkAllSessions = New System.Windows.Forms.CheckBox()
        Me.cboGradeSession = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtGradingCredits = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnAddGrade = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtGradingGrade = New System.Windows.Forms.TextBox()
        Me.txtGradingUpperLimit = New System.Windows.Forms.TextBox()
        Me.txtGradingLowerLimit = New System.Windows.Forms.TextBox()
        Me.lvExmGrd = New System.Windows.Forms.ListView()
        Me.Grade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Lower = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Upper = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Credits = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ref = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbGradingProg = New System.Windows.Forms.ComboBox()
        Me.tbMarkWeights = New System.Windows.Forms.TabPage()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator16 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton76 = New System.Windows.Forms.ToolStripButton()
        Me.MarkWeightingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel12 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton77 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton78 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton79 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator34 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox12 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator35 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton80 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton81 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator36 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton82 = New System.Windows.Forms.ToolStripButton()
        Me.MarkWeightingDataGridView = New System.Windows.Forms.DataGridView()
        Me.Section = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbFess = New System.Windows.Forms.TabPage()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.tbPaymentPeriods = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.PaymentPeriodsDataGridView = New System.Windows.Forms.DataGridView()
        Me.PeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PaymentPeriodsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator6 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AddNew6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton()
        Me.tbPayCart = New System.Windows.Forms.TabPage()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator9 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AddNew9 = New System.Windows.Forms.ToolStripButton()
        Me.PaymentTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton34 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton35 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton36 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton37 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton38 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton39 = New System.Windows.Forms.ToolStripButton()
        Me.PaymentTypeDataGridView = New System.Windows.Forms.DataGridView()
        Me.PaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbPAyMethods = New System.Windows.Forms.TabPage()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator10 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AddNew10 = New System.Windows.Forms.ToolStripButton()
        Me.CashtypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton41 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton42 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton43 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox6 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton44 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton45 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton46 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CashtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbCurrencies = New System.Windows.Forms.TabPage()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator11 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
        Me.CurrenciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton26 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton33 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton40 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox7 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton68 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton69 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton70 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.CurrencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbExchangeRates = New System.Windows.Forms.TabPage()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.mskExDateTo = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mskExDateFrom = New System.Windows.Forms.MaskedTextBox()
        Me.txtCurrToVal = New System.Windows.Forms.TextBox()
        Me.txtCurrFromValue = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboCurrToCurr = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnAddExchangeRate = New System.Windows.Forms.Button()
        Me.lvExchangeRate = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboCurrFromCurr = New System.Windows.Forms.ComboBox()
        Me.tbstaff = New System.Windows.Forms.TabPage()
        Me.TabControl5 = New System.Windows.Forms.TabControl()
        Me.tbStaffQual = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator12 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton47 = New System.Windows.Forms.ToolStripButton()
        Me.QualificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton48 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton49 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton50 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox8 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton51 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton52 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton53 = New System.Windows.Forms.ToolStripButton()
        Me.QualificationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.QualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolinfoTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.schoolinfoTableAdapter()
        Me.FormsTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.formsTableAdapter()
        Me.ClassesTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.ClassesTableAdapter()
        Me.SubjectsTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.SubjectsTableAdapter()
        Me.SMSAccTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.SMSAccTableAdapter()
        Me.SchoolsessionsTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.schoolsessionsTableAdapter()
        Me.DepsTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.DepsTableAdapter()
        Me.SchoolSectionsTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.SchoolSectionsTableAdapter()
        Me.SmtpTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.smtpTableAdapter()
        Me.SemesterDurationsTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.SemesterDurationsTableAdapter()
        Me.ExamSessionsTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.ExamSessionsTableAdapter()
        Me.MarkWeightingTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.MarkWeightingTableAdapter()
        Me.PaymentPeriodsTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.PaymentPeriodsTableAdapter()
        Me.PaymentTypeTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.PaymentTypeTableAdapter()
        Me.CashtypeTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.CashtypeTableAdapter()
        Me.QualificationsTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.QualificationsTableAdapter()
        Me.CurrenciesTableAdapter = New SchoolParameters.dsSchoolParametersTableAdapters.CurrenciesTableAdapter()
        SubjectIDLabel = New System.Windows.Forms.Label()
        SubjectLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        FormsLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        YearLabel = New System.Windows.Forms.Label()
        SemestersLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        CreditsLabel = New System.Windows.Forms.Label()
        TypeLabel1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        WebLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        LogoLabel = New System.Windows.Forms.Label()
        StudIdLengthLabel = New System.Windows.Forms.Label()
        StudIdPrefixLabel = New System.Windows.Forms.Label()
        ProgSufixLabel = New System.Windows.Forms.Label()
        FeesLabel1 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        ServerLabel = New System.Windows.Forms.Label()
        MailfromLabel = New System.Windows.Forms.Label()
        PortLabel = New System.Windows.Forms.Label()
        PasswordLabel1 = New System.Windows.Forms.Label()
        DescriptionLabel1 = New System.Windows.Forms.Label()
        ClasLabel = New System.Windows.Forms.Label()
        SemLabel = New System.Windows.Forms.Label()
        IntakeLabel1 = New System.Windows.Forms.Label()
        ClassLabel = New System.Windows.Forms.Label()
        ProgramLabel = New System.Windows.Forms.Label()
        StartDateLabel = New System.Windows.Forms.Label()
        EndDateLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        SessionLabel = New System.Windows.Forms.Label()
        ExamClassRefLabel = New System.Windows.Forms.Label()
        SittingLabel = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SchoolinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSchoolParameters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SchoolInfoBindingNavigator.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FormsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.tbClasses.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator18.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator4.SuspendLayout()
        CType(Me.SMSAccBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.BindingNavigator8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator8.SuspendLayout()
        CType(Me.SchoolsessionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolsessionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage13.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.BindingNavigator13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator13.SuspendLayout()
        CType(Me.DepsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage14.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.BindingNavigator14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator14.SuspendLayout()
        CType(Me.SchoolSectionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage18.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        CType(Me.BindingNavigator17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator17.SuspendLayout()
        CType(Me.SmtpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator5.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tbGeneral.SuspendLayout()
        Me.tbExams.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.tbTermDuration.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SemesterDurationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.tbProgramSubjects.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tbExamSessions.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        CType(Me.ExamSessionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator7.SuspendLayout()
        Me.tbExamGrading.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.tbMarkWeights.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        CType(Me.BindingNavigator16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator16.SuspendLayout()
        CType(Me.MarkWeightingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarkWeightingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbFess.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.tbPaymentPeriods.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PaymentPeriodsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentPeriodsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator6.SuspendLayout()
        Me.tbPayCart.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        CType(Me.BindingNavigator9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator9.SuspendLayout()
        CType(Me.PaymentTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbPAyMethods.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        CType(Me.BindingNavigator10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator10.SuspendLayout()
        CType(Me.CashtypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCurrencies.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        CType(Me.BindingNavigator11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator11.SuspendLayout()
        CType(Me.CurrenciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbExchangeRates.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.tbstaff.SuspendLayout()
        Me.TabControl5.SuspendLayout()
        Me.tbStaffQual.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.BindingNavigator12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator12.SuspendLayout()
        CType(Me.QualificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualificationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubjectIDLabel
        '
        SubjectIDLabel.AutoSize = True
        SubjectIDLabel.Location = New System.Drawing.Point(16, 96)
        SubjectIDLabel.Name = "SubjectIDLabel"
        SubjectIDLabel.Size = New System.Drawing.Size(74, 13)
        SubjectIDLabel.TabIndex = 0
        SubjectIDLabel.Text = "Subject Code:"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Location = New System.Drawing.Point(16, 125)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(46, 13)
        SubjectLabel.TabIndex = 2
        SubjectLabel.Text = "Subject:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(35, 73)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(63, 13)
        UserNameLabel.TabIndex = 0
        UserNameLabel.Text = "User Name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(42, 99)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Password:"
        '
        'FormsLabel
        '
        FormsLabel.AutoSize = True
        FormsLabel.Location = New System.Drawing.Point(86, 100)
        FormsLabel.Name = "FormsLabel"
        FormsLabel.Size = New System.Drawing.Size(74, 13)
        FormsLabel.TabIndex = 12
        FormsLabel.Text = "ProgramCode:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(86, 126)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 14
        DescriptionLabel.Text = "Description:"
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.Location = New System.Drawing.Point(86, 152)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(37, 13)
        YearLabel.TabIndex = 16
        YearLabel.Text = "Years:"
        '
        'SemestersLabel
        '
        SemestersLabel.AutoSize = True
        SemestersLabel.Location = New System.Drawing.Point(86, 178)
        SemestersLabel.Name = "SemestersLabel"
        SemestersLabel.Size = New System.Drawing.Size(86, 13)
        SemestersLabel.TabIndex = 18
        SemestersLabel.Text = "Semesters/Year:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(86, 204)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 20
        TypeLabel.Text = "Type:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(86, 231)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(46, 13)
        SectionLabel.TabIndex = 22
        SectionLabel.Text = "Section:"
        '
        'CreditsLabel
        '
        CreditsLabel.AutoSize = True
        CreditsLabel.Location = New System.Drawing.Point(16, 157)
        CreditsLabel.Name = "CreditsLabel"
        CreditsLabel.Size = New System.Drawing.Size(42, 13)
        CreditsLabel.TabIndex = 5
        CreditsLabel.Text = "Credits:"
        '
        'TypeLabel1
        '
        TypeLabel1.AutoSize = True
        TypeLabel1.Location = New System.Drawing.Point(16, 184)
        TypeLabel1.Name = "TypeLabel1"
        TypeLabel1.Size = New System.Drawing.Size(34, 13)
        TypeLabel1.TabIndex = 7
        TypeLabel1.Text = "Type:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(16, 184)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(34, 13)
        Label3.TabIndex = 7
        Label3.Text = "Type:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(16, 157)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(42, 13)
        Label4.TabIndex = 5
        Label4.Text = "Credits:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(16, 96)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(74, 13)
        Label5.TabIndex = 0
        Label5.Text = "Subject Code:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(16, 125)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(46, 13)
        Label6.TabIndex = 2
        Label6.Text = "Subject:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(25, 112)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 6
        PhoneLabel.Text = "Phone:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(24, 86)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 4
        AddressLabel.Text = "Address:"
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.Location = New System.Drawing.Point(24, 142)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(33, 13)
        WebLabel.TabIndex = 2
        WebLabel.Text = "Web:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(24, 64)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name:"
        '
        'LogoLabel
        '
        LogoLabel.AutoSize = True
        LogoLabel.Location = New System.Drawing.Point(460, 176)
        LogoLabel.Name = "LogoLabel"
        LogoLabel.Size = New System.Drawing.Size(34, 13)
        LogoLabel.TabIndex = 10
        LogoLabel.Text = "Logo:"
        '
        'StudIdLengthLabel
        '
        StudIdLengthLabel.AutoSize = True
        StudIdLengthLabel.Location = New System.Drawing.Point(24, 224)
        StudIdLengthLabel.Name = "StudIdLengthLabel"
        StudIdLengthLabel.Size = New System.Drawing.Size(133, 13)
        StudIdLengthLabel.TabIndex = 21
        StudIdLengthLabel.Text = "Max StudentID Numeric #:"
        '
        'StudIdPrefixLabel
        '
        StudIdPrefixLabel.AutoSize = True
        StudIdPrefixLabel.Location = New System.Drawing.Point(25, 198)
        StudIdPrefixLabel.Name = "StudIdPrefixLabel"
        StudIdPrefixLabel.Size = New System.Drawing.Size(87, 13)
        StudIdPrefixLabel.TabIndex = 23
        StudIdPrefixLabel.Text = "StudentID Prefix:"
        '
        'ProgSufixLabel
        '
        ProgSufixLabel.AutoSize = True
        ProgSufixLabel.Location = New System.Drawing.Point(86, 255)
        ProgSufixLabel.Name = "ProgSufixLabel"
        ProgSufixLabel.Size = New System.Drawing.Size(58, 13)
        ProgSufixLabel.TabIndex = 23
        ProgSufixLabel.Text = "Prog Sufix:"
        '
        'FeesLabel1
        '
        FeesLabel1.AutoSize = True
        FeesLabel1.Location = New System.Drawing.Point(17, 218)
        FeesLabel1.Name = "FeesLabel1"
        FeesLabel1.Size = New System.Drawing.Size(33, 13)
        FeesLabel1.TabIndex = 9
        FeesLabel1.Text = "Fees:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(16, 252)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(55, 13)
        Label18.TabIndex = 11
        Label18.Text = "Cartegory:"
        '
        'ServerLabel
        '
        ServerLabel.AutoSize = True
        ServerLabel.Location = New System.Drawing.Point(224, 87)
        ServerLabel.Name = "ServerLabel"
        ServerLabel.Size = New System.Drawing.Size(32, 13)
        ServerLabel.TabIndex = 0
        ServerLabel.Text = "Host:"
        '
        'MailfromLabel
        '
        MailfromLabel.AutoSize = True
        MailfromLabel.Location = New System.Drawing.Point(224, 136)
        MailfromLabel.Name = "MailfromLabel"
        MailfromLabel.Size = New System.Drawing.Size(52, 13)
        MailfromLabel.TabIndex = 2
        MailfromLabel.Text = "MailFrom:"
        '
        'PortLabel
        '
        PortLabel.AutoSize = True
        PortLabel.Location = New System.Drawing.Point(224, 109)
        PortLabel.Name = "PortLabel"
        PortLabel.Size = New System.Drawing.Size(29, 13)
        PortLabel.TabIndex = 4
        PortLabel.Text = "Port:"
        '
        'PasswordLabel1
        '
        PasswordLabel1.AutoSize = True
        PasswordLabel1.Location = New System.Drawing.Point(224, 165)
        PasswordLabel1.Name = "PasswordLabel1"
        PasswordLabel1.Size = New System.Drawing.Size(56, 13)
        PasswordLabel1.TabIndex = 6
        PasswordLabel1.Text = "Password:"
        '
        'DescriptionLabel1
        '
        DescriptionLabel1.AutoSize = True
        DescriptionLabel1.Location = New System.Drawing.Point(158, 96)
        DescriptionLabel1.Name = "DescriptionLabel1"
        DescriptionLabel1.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel1.TabIndex = 7
        DescriptionLabel1.Text = "Description:"
        '
        'ClasLabel
        '
        ClasLabel.AutoSize = True
        ClasLabel.Location = New System.Drawing.Point(158, 122)
        ClasLabel.Name = "ClasLabel"
        ClasLabel.Size = New System.Drawing.Size(32, 13)
        ClasLabel.TabIndex = 9
        ClasLabel.Text = "Year:"
        '
        'SemLabel
        '
        SemLabel.AutoSize = True
        SemLabel.Location = New System.Drawing.Point(158, 149)
        SemLabel.Name = "SemLabel"
        SemLabel.Size = New System.Drawing.Size(54, 13)
        SemLabel.TabIndex = 11
        SemLabel.Text = "Semester:"
        '
        'IntakeLabel1
        '
        IntakeLabel1.AutoSize = True
        IntakeLabel1.Location = New System.Drawing.Point(158, 176)
        IntakeLabel1.Name = "IntakeLabel1"
        IntakeLabel1.Size = New System.Drawing.Size(40, 13)
        IntakeLabel1.TabIndex = 13
        IntakeLabel1.Text = "Intake:"
        '
        'ClassLabel
        '
        ClassLabel.AutoSize = True
        ClassLabel.Location = New System.Drawing.Point(37, 93)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New System.Drawing.Size(35, 13)
        ClassLabel.TabIndex = 13
        ClassLabel.Text = "Class:"
        '
        'ProgramLabel
        '
        ProgramLabel.AutoSize = True
        ProgramLabel.Location = New System.Drawing.Point(37, 71)
        ProgramLabel.Name = "ProgramLabel"
        ProgramLabel.Size = New System.Drawing.Size(49, 13)
        ProgramLabel.TabIndex = 12
        ProgramLabel.Text = "Program:"
        '
        'StartDateLabel
        '
        StartDateLabel.AutoSize = True
        StartDateLabel.Location = New System.Drawing.Point(37, 118)
        StartDateLabel.Name = "StartDateLabel"
        StartDateLabel.Size = New System.Drawing.Size(58, 13)
        StartDateLabel.TabIndex = 4
        StartDateLabel.Text = "Start Date:"
        '
        'EndDateLabel
        '
        EndDateLabel.AutoSize = True
        EndDateLabel.Location = New System.Drawing.Point(37, 146)
        EndDateLabel.Name = "EndDateLabel"
        EndDateLabel.Size = New System.Drawing.Size(55, 13)
        EndDateLabel.TabIndex = 6
        EndDateLabel.Text = "End Date:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(6, 21)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(34, 13)
        Label9.TabIndex = 22
        Label9.Text = "Term:"
        '
        'SessionLabel
        '
        SessionLabel.AutoSize = True
        SessionLabel.Location = New System.Drawing.Point(134, 90)
        SessionLabel.Name = "SessionLabel"
        SessionLabel.Size = New System.Drawing.Size(47, 13)
        SessionLabel.TabIndex = 7
        SessionLabel.Text = "Session:"
        '
        'ExamClassRefLabel
        '
        ExamClassRefLabel.AutoSize = True
        ExamClassRefLabel.Location = New System.Drawing.Point(134, 116)
        ExamClassRefLabel.Name = "ExamClassRefLabel"
        ExamClassRefLabel.Size = New System.Drawing.Size(35, 13)
        ExamClassRefLabel.TabIndex = 9
        ExamClassRefLabel.Text = "Class:"
        '
        'SittingLabel
        '
        SittingLabel.AutoSize = True
        SittingLabel.Location = New System.Drawing.Point(134, 167)
        SittingLabel.Name = "SittingLabel"
        SittingLabel.Size = New System.Drawing.Size(39, 13)
        SittingLabel.TabIndex = 11
        SittingLabel.Text = "Sitting:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(134, 142)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(67, 13)
        Label24.TabIndex = 19
        Label24.Text = "ParentExam:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.tbClasses)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage13)
        Me.TabControl1.Controls.Add(Me.TabPage14)
        Me.TabControl1.Controls.Add(Me.TabPage18)
        Me.TabControl1.Location = New System.Drawing.Point(15, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(923, 404)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(915, 378)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "SchoolInfo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboBaseCurrency)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtschoolref)
        Me.GroupBox1.Controls.Add(Me.cboIdYearFormat)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(StudIdPrefixLabel)
        Me.GroupBox1.Controls.Add(Me.StudIdPrefixTextBox)
        Me.GroupBox1.Controls.Add(StudIdLengthLabel)
        Me.GroupBox1.Controls.Add(Me.StudIdLengthTextBox)
        Me.GroupBox1.Controls.Add(Me.AutoStudIDCheckBox)
        Me.GroupBox1.Controls.Add(LogoLabel)
        Me.GroupBox1.Controls.Add(Me.LogoPictureBox)
        Me.GroupBox1.Controls.Add(Me.SchoolInfoBindingNavigator)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(WebLabel)
        Me.GroupBox1.Controls.Add(Me.WebTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(PhoneLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 366)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SchoolInfo"
        '
        'cboBaseCurrency
        '
        Me.cboBaseCurrency.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolinfoBindingSource, "BaseCurrency", True))
        Me.cboBaseCurrency.FormattingEnabled = True
        Me.cboBaseCurrency.Location = New System.Drawing.Point(180, 276)
        Me.cboBaseCurrency.Name = "cboBaseCurrency"
        Me.cboBaseCurrency.Size = New System.Drawing.Size(100, 21)
        Me.cboBaseCurrency.TabIndex = 28
        '
        'SchoolinfoBindingSource
        '
        Me.SchoolinfoBindingSource.DataMember = "schoolinfo"
        Me.SchoolinfoBindingSource.DataSource = Me.DsSchoolParameters
        '
        'DsSchoolParameters
        '
        Me.DsSchoolParameters.DataSetName = "dsSchoolParameters"
        Me.DsSchoolParameters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Base Currency:"
        '
        'txtschoolref
        '
        Me.txtschoolref.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtschoolref.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolinfoBindingSource, "Ref", True))
        Me.txtschoolref.Location = New System.Drawing.Point(180, 307)
        Me.txtschoolref.Name = "txtschoolref"
        Me.txtschoolref.ReadOnly = True
        Me.txtschoolref.Size = New System.Drawing.Size(10, 20)
        Me.txtschoolref.TabIndex = 27
        '
        'cboIdYearFormat
        '
        Me.cboIdYearFormat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolinfoBindingSource, "yearformat", True))
        Me.cboIdYearFormat.FormattingEnabled = True
        Me.cboIdYearFormat.Items.AddRange(New Object() {"YY", "YYY", "YYYY"})
        Me.cboIdYearFormat.Location = New System.Drawing.Point(180, 247)
        Me.cboIdYearFormat.Name = "cboIdYearFormat"
        Me.cboIdYearFormat.Size = New System.Drawing.Size(100, 21)
        Me.cboIdYearFormat.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(24, 250)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "StudentIDYearFormat:"
        '
        'StudIdPrefixTextBox
        '
        Me.StudIdPrefixTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudIdPrefixTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolinfoBindingSource, "StudIdPrefix", True))
        Me.StudIdPrefixTextBox.Location = New System.Drawing.Point(180, 195)
        Me.StudIdPrefixTextBox.Name = "StudIdPrefixTextBox"
        Me.StudIdPrefixTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudIdPrefixTextBox.TabIndex = 5
        '
        'StudIdLengthTextBox
        '
        Me.StudIdLengthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolinfoBindingSource, "StudIdLength", True))
        Me.StudIdLengthTextBox.Location = New System.Drawing.Point(180, 221)
        Me.StudIdLengthTextBox.Name = "StudIdLengthTextBox"
        Me.StudIdLengthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudIdLengthTextBox.TabIndex = 6
        '
        'AutoStudIDCheckBox
        '
        Me.AutoStudIDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SchoolinfoBindingSource, "AutoStudID", True))
        Me.AutoStudIDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SchoolinfoBindingSource, "AutoStudID", True))
        Me.AutoStudIDCheckBox.Location = New System.Drawing.Point(180, 165)
        Me.AutoStudIDCheckBox.Name = "AutoStudIDCheckBox"
        Me.AutoStudIDCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AutoStudIDCheckBox.TabIndex = 4
        Me.AutoStudIDCheckBox.Text = "AutoStudentID"
        Me.AutoStudIDCheckBox.UseVisualStyleBackColor = True
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImage = Global.SchoolParameters.My.Resources.Resources.Upload___Transfer_Photos
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.SchoolinfoBindingSource, "Logo", True))
        Me.LogoPictureBox.Location = New System.Drawing.Point(369, 195)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(226, 147)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 10
        Me.LogoPictureBox.TabStop = False
        '
        'SchoolInfoBindingNavigator
        '
        Me.SchoolInfoBindingNavigator.AddNewItem = Nothing
        Me.SchoolInfoBindingNavigator.CountItem = Nothing
        Me.SchoolInfoBindingNavigator.DeleteItem = Nothing
        Me.SchoolInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchoolInfoBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.SchoolInfoBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.SchoolInfoBindingNavigator.MoveFirstItem = Nothing
        Me.SchoolInfoBindingNavigator.MoveLastItem = Nothing
        Me.SchoolInfoBindingNavigator.MoveNextItem = Nothing
        Me.SchoolInfoBindingNavigator.MovePreviousItem = Nothing
        Me.SchoolInfoBindingNavigator.Name = "SchoolInfoBindingNavigator"
        Me.SchoolInfoBindingNavigator.PositionItem = Nothing
        Me.SchoolInfoBindingNavigator.Size = New System.Drawing.Size(758, 25)
        Me.SchoolInfoBindingNavigator.TabIndex = 1
        Me.SchoolInfoBindingNavigator.Text = "BindingNavigator1"
        '
        'SchoolInfoBindingNavigatorSaveItem
        '
        Me.SchoolInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SchoolInfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("SchoolInfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SchoolInfoBindingNavigatorSaveItem.Name = "SchoolInfoBindingNavigatorSaveItem"
        Me.SchoolInfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SchoolInfoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.SchoolParameters.My.Resources.Resources.Delete
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'NameTextBox
        '
        Me.NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolinfoBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(180, 57)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(260, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'WebTextBox
        '
        Me.WebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolinfoBindingSource, "Web", True))
        Me.WebTextBox.Location = New System.Drawing.Point(180, 139)
        Me.WebTextBox.Name = "WebTextBox"
        Me.WebTextBox.Size = New System.Drawing.Size(260, 20)
        Me.WebTextBox.TabIndex = 3
        '
        'AddressTextBox
        '
        Me.AddressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolinfoBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(180, 83)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(260, 20)
        Me.AddressTextBox.TabIndex = 1
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolinfoBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(180, 109)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(260, 20)
        Me.PhoneTextBox.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.lbprograms)
        Me.TabPage2.Controls.Add(Me.GroupBox9)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(915, 378)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Programs"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbprograms
        '
        Me.lbprograms.FormattingEnabled = True
        Me.lbprograms.Location = New System.Drawing.Point(585, 52)
        Me.lbprograms.Name = "lbprograms"
        Me.lbprograms.Size = New System.Drawing.Size(282, 160)
        Me.lbprograms.TabIndex = 10
        Me.lbprograms.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.btnProgSearch)
        Me.GroupBox9.Controls.Add(Me.txtProgSearch)
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Location = New System.Drawing.Point(530, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(379, 46)
        Me.GroupBox9.TabIndex = 9
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Program Search"
        '
        'btnProgSearch
        '
        Me.btnProgSearch.BackgroundImage = Global.SchoolParameters.My.Resources.Resources.Find
        Me.btnProgSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProgSearch.Location = New System.Drawing.Point(344, 19)
        Me.btnProgSearch.Name = "btnProgSearch"
        Me.btnProgSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnProgSearch.TabIndex = 18
        Me.btnProgSearch.UseVisualStyleBackColor = True
        '
        'txtProgSearch
        '
        Me.txtProgSearch.Location = New System.Drawing.Point(52, 19)
        Me.txtProgSearch.Name = "txtProgSearch"
        Me.txtProgSearch.Size = New System.Drawing.Size(286, 20)
        Me.txtProgSearch.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Program:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtProgRef)
        Me.GroupBox2.Controls.Add(Me.ProgSufixTextBox)
        Me.GroupBox2.Controls.Add(ProgSufixLabel)
        Me.GroupBox2.Controls.Add(FormsLabel)
        Me.GroupBox2.Controls.Add(Me.FormsTextBox)
        Me.GroupBox2.Controls.Add(DescriptionLabel)
        Me.GroupBox2.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox2.Controls.Add(YearLabel)
        Me.GroupBox2.Controls.Add(Me.YearTextBox)
        Me.GroupBox2.Controls.Add(SemestersLabel)
        Me.GroupBox2.Controls.Add(Me.SemestersTextBox)
        Me.GroupBox2.Controls.Add(TypeLabel)
        Me.GroupBox2.Controls.Add(Me.TypeComboBox)
        Me.GroupBox2.Controls.Add(SectionLabel)
        Me.GroupBox2.Controls.Add(Me.SectionComboBox)
        Me.GroupBox2.Controls.Add(Me.BindingNavigator1)
        Me.GroupBox2.Location = New System.Drawing.Point(73, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(594, 300)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'txtProgRef
        '
        Me.txtProgRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProgRef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormsBindingSource, "Progref", True))
        Me.txtProgRef.Location = New System.Drawing.Point(188, 274)
        Me.txtProgRef.Name = "txtProgRef"
        Me.txtProgRef.ReadOnly = True
        Me.txtProgRef.Size = New System.Drawing.Size(10, 20)
        Me.txtProgRef.TabIndex = 25
        '
        'FormsBindingSource
        '
        Me.FormsBindingSource.DataMember = "forms"
        Me.FormsBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ProgSufixTextBox
        '
        Me.ProgSufixTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProgSufixTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormsBindingSource, "ProgSufix", True))
        Me.ProgSufixTextBox.Location = New System.Drawing.Point(188, 250)
        Me.ProgSufixTextBox.Name = "ProgSufixTextBox"
        Me.ProgSufixTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProgSufixTextBox.TabIndex = 6
        '
        'FormsTextBox
        '
        Me.FormsTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FormsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormsBindingSource, "Forms", True))
        Me.FormsTextBox.Location = New System.Drawing.Point(188, 97)
        Me.FormsTextBox.Name = "FormsTextBox"
        Me.FormsTextBox.Size = New System.Drawing.Size(121, 20)
        Me.FormsTextBox.TabIndex = 0
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(188, 123)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(336, 20)
        Me.DescriptionTextBox.TabIndex = 1
        '
        'YearTextBox
        '
        Me.YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormsBindingSource, "Year", True))
        Me.YearTextBox.Location = New System.Drawing.Point(188, 149)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(121, 20)
        Me.YearTextBox.TabIndex = 2
        '
        'SemestersTextBox
        '
        Me.SemestersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormsBindingSource, "Semesters", True))
        Me.SemestersTextBox.Location = New System.Drawing.Point(188, 171)
        Me.SemestersTextBox.Name = "SemestersTextBox"
        Me.SemestersTextBox.Size = New System.Drawing.Size(121, 20)
        Me.SemestersTextBox.TabIndex = 3
        '
        'TypeComboBox
        '
        Me.TypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormsBindingSource, "Type", True))
        Me.TypeComboBox.DisplayMember = "ProgType"
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Location = New System.Drawing.Point(188, 196)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TypeComboBox.TabIndex = 4
        Me.TypeComboBox.ValueMember = "ProgType"
        '
        'SectionComboBox
        '
        Me.SectionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SectionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SectionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormsBindingSource, "Section", True))
        Me.SectionComboBox.DisplayMember = "Section"
        Me.SectionComboBox.FormattingEnabled = True
        Me.SectionComboBox.Location = New System.Drawing.Point(188, 223)
        Me.SectionComboBox.Name = "SectionComboBox"
        Me.SectionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SectionComboBox.TabIndex = 5
        Me.SectionComboBox.ValueMember = "Section"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.AddNew3
        Me.BindingNavigator1.BindingSource = Me.FormsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.Add, Me.Save, Me.ToolStripButton2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(588, 25)
        Me.BindingNavigator1.TabIndex = 12
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'AddNew3
        '
        Me.AddNew3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddNew3.Image = CType(resources.GetObject("AddNew3.Image"), System.Drawing.Image)
        Me.AddNew3.Name = "AddNew3"
        Me.AddNew3.RightToLeftAutoMirrorImage = True
        Me.AddNew3.Size = New System.Drawing.Size(23, 22)
        Me.AddNew3.Text = "Add new"
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
        'Add
        '
        Me.Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Add.Image = CType(resources.GetObject("Add.Image"), System.Drawing.Image)
        Me.Add.Name = "Add"
        Me.Add.RightToLeftAutoMirrorImage = True
        Me.Add.Size = New System.Drawing.Size(23, 22)
        Me.Add.Text = "Add new"
        '
        'Save
        '
        Me.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(23, 22)
        Me.Save.Text = "Save Data"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.SchoolParameters.My.Resources.Resources.Delete
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'tbClasses
        '
        Me.tbClasses.Controls.Add(Me.lbClasses)
        Me.tbClasses.Controls.Add(Me.GroupBox11)
        Me.tbClasses.Controls.Add(Me.GroupBox19)
        Me.tbClasses.Location = New System.Drawing.Point(4, 22)
        Me.tbClasses.Name = "tbClasses"
        Me.tbClasses.Padding = New System.Windows.Forms.Padding(3)
        Me.tbClasses.Size = New System.Drawing.Size(915, 378)
        Me.tbClasses.TabIndex = 19
        Me.tbClasses.Text = "Classes"
        Me.tbClasses.UseVisualStyleBackColor = True
        '
        'lbClasses
        '
        Me.lbClasses.FormattingEnabled = True
        Me.lbClasses.Location = New System.Drawing.Point(586, 51)
        Me.lbClasses.Name = "lbClasses"
        Me.lbClasses.Size = New System.Drawing.Size(282, 160)
        Me.lbClasses.TabIndex = 11
        Me.lbClasses.Visible = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.btnClassSearch)
        Me.GroupBox11.Controls.Add(Me.txtClassSearch)
        Me.GroupBox11.Controls.Add(Me.Label21)
        Me.GroupBox11.Location = New System.Drawing.Point(530, 6)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(379, 46)
        Me.GroupBox11.TabIndex = 10
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Class Search"
        '
        'btnClassSearch
        '
        Me.btnClassSearch.BackgroundImage = Global.SchoolParameters.My.Resources.Resources.Find
        Me.btnClassSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClassSearch.Location = New System.Drawing.Point(344, 19)
        Me.btnClassSearch.Name = "btnClassSearch"
        Me.btnClassSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnClassSearch.TabIndex = 18
        Me.btnClassSearch.UseVisualStyleBackColor = True
        '
        'txtClassSearch
        '
        Me.txtClassSearch.Location = New System.Drawing.Point(52, 19)
        Me.txtClassSearch.Name = "txtClassSearch"
        Me.txtClassSearch.Size = New System.Drawing.Size(286, 20)
        Me.txtClassSearch.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 13)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Class:"
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(DescriptionLabel1)
        Me.GroupBox19.Controls.Add(Me.DescriptionTextBox1)
        Me.GroupBox19.Controls.Add(ClasLabel)
        Me.GroupBox19.Controls.Add(Me.ClasComboBox)
        Me.GroupBox19.Controls.Add(SemLabel)
        Me.GroupBox19.Controls.Add(Me.SemComboBox)
        Me.GroupBox19.Controls.Add(IntakeLabel1)
        Me.GroupBox19.Controls.Add(Me.IntakeComboBox1)
        Me.GroupBox19.Controls.Add(Me.RefTextBox)
        Me.GroupBox19.Controls.Add(Me.BindingNavigator18)
        Me.GroupBox19.Location = New System.Drawing.Point(204, 95)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(507, 236)
        Me.GroupBox19.TabIndex = 1
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Classes"
        '
        'DescriptionTextBox1
        '
        Me.DescriptionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassesBindingSource, "Description", True))
        Me.DescriptionTextBox1.Location = New System.Drawing.Point(227, 93)
        Me.DescriptionTextBox1.Name = "DescriptionTextBox1"
        Me.DescriptionTextBox1.Size = New System.Drawing.Size(220, 20)
        Me.DescriptionTextBox1.TabIndex = 8
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ClasComboBox
        '
        Me.ClasComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ClasComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ClasComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassesBindingSource, "Clas", True))
        Me.ClasComboBox.FormattingEnabled = True
        Me.ClasComboBox.Location = New System.Drawing.Point(227, 119)
        Me.ClasComboBox.Name = "ClasComboBox"
        Me.ClasComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ClasComboBox.TabIndex = 10
        '
        'SemComboBox
        '
        Me.SemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SemComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassesBindingSource, "Sem", True))
        Me.SemComboBox.FormattingEnabled = True
        Me.SemComboBox.Items.AddRange(New Object() {"1", "2", "3"})
        Me.SemComboBox.Location = New System.Drawing.Point(227, 146)
        Me.SemComboBox.Name = "SemComboBox"
        Me.SemComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SemComboBox.TabIndex = 12
        '
        'IntakeComboBox1
        '
        Me.IntakeComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.IntakeComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.IntakeComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassesBindingSource, "Intake", True))
        Me.IntakeComboBox1.FormattingEnabled = True
        Me.IntakeComboBox1.Location = New System.Drawing.Point(227, 173)
        Me.IntakeComboBox1.Name = "IntakeComboBox1"
        Me.IntakeComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.IntakeComboBox1.TabIndex = 14
        '
        'RefTextBox
        '
        Me.RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassesBindingSource, "ref", True))
        Me.RefTextBox.Location = New System.Drawing.Point(227, 200)
        Me.RefTextBox.Name = "RefTextBox"
        Me.RefTextBox.Size = New System.Drawing.Size(10, 20)
        Me.RefTextBox.TabIndex = 16
        '
        'BindingNavigator18
        '
        Me.BindingNavigator18.AddNewItem = Me.ToolStripButton90
        Me.BindingNavigator18.BindingSource = Me.ClassesBindingSource
        Me.BindingNavigator18.CountItem = Me.ToolStripLabel14
        Me.BindingNavigator18.DeleteItem = Nothing
        Me.BindingNavigator18.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton92, Me.ToolStripButton93, Me.ToolStripSeparator40, Me.ToolStripTextBox14, Me.ToolStripLabel14, Me.ToolStripSeparator41, Me.ToolStripButton94, Me.ToolStripButton95, Me.ToolStripSeparator42, Me.ToolStripButton90, Me.ToolStripButton96, Me.ToolStripButton91})
        Me.BindingNavigator18.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator18.MoveFirstItem = Me.ToolStripButton92
        Me.BindingNavigator18.MoveLastItem = Me.ToolStripButton95
        Me.BindingNavigator18.MoveNextItem = Me.ToolStripButton94
        Me.BindingNavigator18.MovePreviousItem = Me.ToolStripButton93
        Me.BindingNavigator18.Name = "BindingNavigator18"
        Me.BindingNavigator18.PositionItem = Me.ToolStripTextBox14
        Me.BindingNavigator18.Size = New System.Drawing.Size(501, 25)
        Me.BindingNavigator18.TabIndex = 7
        Me.BindingNavigator18.Text = "BindingNavigator18"
        '
        'ToolStripButton90
        '
        Me.ToolStripButton90.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton90.Image = CType(resources.GetObject("ToolStripButton90.Image"), System.Drawing.Image)
        Me.ToolStripButton90.Name = "ToolStripButton90"
        Me.ToolStripButton90.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton90.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton90.Text = "Add new"
        '
        'ToolStripLabel14
        '
        Me.ToolStripLabel14.Name = "ToolStripLabel14"
        Me.ToolStripLabel14.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel14.Text = "of {0}"
        Me.ToolStripLabel14.ToolTipText = "Total number of items"
        '
        'ToolStripButton92
        '
        Me.ToolStripButton92.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton92.Image = CType(resources.GetObject("ToolStripButton92.Image"), System.Drawing.Image)
        Me.ToolStripButton92.Name = "ToolStripButton92"
        Me.ToolStripButton92.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton92.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton92.Text = "Move first"
        '
        'ToolStripButton93
        '
        Me.ToolStripButton93.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton93.Image = CType(resources.GetObject("ToolStripButton93.Image"), System.Drawing.Image)
        Me.ToolStripButton93.Name = "ToolStripButton93"
        Me.ToolStripButton93.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton93.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton93.Text = "Move previous"
        '
        'ToolStripSeparator40
        '
        Me.ToolStripSeparator40.Name = "ToolStripSeparator40"
        Me.ToolStripSeparator40.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox14
        '
        Me.ToolStripTextBox14.AccessibleName = "Position"
        Me.ToolStripTextBox14.AutoSize = False
        Me.ToolStripTextBox14.Name = "ToolStripTextBox14"
        Me.ToolStripTextBox14.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox14.Text = "0"
        Me.ToolStripTextBox14.ToolTipText = "Current position"
        '
        'ToolStripSeparator41
        '
        Me.ToolStripSeparator41.Name = "ToolStripSeparator41"
        Me.ToolStripSeparator41.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton94
        '
        Me.ToolStripButton94.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton94.Image = CType(resources.GetObject("ToolStripButton94.Image"), System.Drawing.Image)
        Me.ToolStripButton94.Name = "ToolStripButton94"
        Me.ToolStripButton94.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton94.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton94.Text = "Move next"
        '
        'ToolStripButton95
        '
        Me.ToolStripButton95.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton95.Image = CType(resources.GetObject("ToolStripButton95.Image"), System.Drawing.Image)
        Me.ToolStripButton95.Name = "ToolStripButton95"
        Me.ToolStripButton95.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton95.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton95.Text = "Move last"
        '
        'ToolStripSeparator42
        '
        Me.ToolStripSeparator42.Name = "ToolStripSeparator42"
        Me.ToolStripSeparator42.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton96
        '
        Me.ToolStripButton96.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton96.Image = CType(resources.GetObject("ToolStripButton96.Image"), System.Drawing.Image)
        Me.ToolStripButton96.Name = "ToolStripButton96"
        Me.ToolStripButton96.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton96.Text = "Save Data"
        '
        'ToolStripButton91
        '
        Me.ToolStripButton91.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton91.Image = Global.SchoolParameters.My.Resources.Resources.Delete
        Me.ToolStripButton91.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton91.Name = "ToolStripButton91"
        Me.ToolStripButton91.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton91.Text = "Delete"
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.lbSubjects)
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(915, 378)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Subjects"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lbSubjects
        '
        Me.lbSubjects.FormattingEnabled = True
        Me.lbSubjects.Location = New System.Drawing.Point(593, 49)
        Me.lbSubjects.Name = "lbSubjects"
        Me.lbSubjects.Size = New System.Drawing.Size(282, 160)
        Me.lbSubjects.TabIndex = 14
        Me.lbSubjects.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnSubjectSearch)
        Me.GroupBox7.Controls.Add(Me.txtSubjectSearch)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Location = New System.Drawing.Point(533, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(361, 46)
        Me.GroupBox7.TabIndex = 13
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Subject Search"
        '
        'btnSubjectSearch
        '
        Me.btnSubjectSearch.BackgroundImage = Global.SchoolParameters.My.Resources.Resources.Find
        Me.btnSubjectSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubjectSearch.Location = New System.Drawing.Point(325, 17)
        Me.btnSubjectSearch.Name = "btnSubjectSearch"
        Me.btnSubjectSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnSubjectSearch.TabIndex = 18
        Me.btnSubjectSearch.UseVisualStyleBackColor = True
        '
        'txtSubjectSearch
        '
        Me.txtSubjectSearch.Location = New System.Drawing.Point(60, 17)
        Me.txtSubjectSearch.Name = "txtSubjectSearch"
        Me.txtSubjectSearch.Size = New System.Drawing.Size(264, 20)
        Me.txtSubjectSearch.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Subject:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSubref)
        Me.GroupBox4.Controls.Add(Label18)
        Me.GroupBox4.Controls.Add(Me.ComboBox3)
        Me.GroupBox4.Controls.Add(FeesLabel1)
        Me.GroupBox4.Controls.Add(Me.FeesTextBox1)
        Me.GroupBox4.Controls.Add(TypeLabel1)
        Me.GroupBox4.Controls.Add(Me.TypeComboBox1)
        Me.GroupBox4.Controls.Add(CreditsLabel)
        Me.GroupBox4.Controls.Add(Me.CreditsTextBox)
        Me.GroupBox4.Controls.Add(Me.BindingNavigator3)
        Me.GroupBox4.Controls.Add(SubjectIDLabel)
        Me.GroupBox4.Controls.Add(Me.SubjectIDTextBox)
        Me.GroupBox4.Controls.Add(SubjectLabel)
        Me.GroupBox4.Controls.Add(Me.SubjectTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(160, 67)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(505, 294)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Subject"
        '
        'txtSubref
        '
        Me.txtSubref.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubref.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "SubRef", True))
        Me.txtSubref.Location = New System.Drawing.Point(93, 271)
        Me.txtSubref.Name = "txtSubref"
        Me.txtSubref.Size = New System.Drawing.Size(10, 20)
        Me.txtSubref.TabIndex = 13
        '
        'SubjectsBindingSource
        '
        Me.SubjectsBindingSource.DataMember = "Subjects"
        Me.SubjectsBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "Dept", True))
        Me.ComboBox3.DisplayMember = "Department"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(93, 244)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 12
        Me.ComboBox3.ValueMember = "Department"
        '
        'FeesTextBox1
        '
        Me.FeesTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "Fees", True))
        Me.FeesTextBox1.Location = New System.Drawing.Point(93, 211)
        Me.FeesTextBox1.Name = "FeesTextBox1"
        Me.FeesTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.FeesTextBox1.TabIndex = 10
        '
        'TypeComboBox1
        '
        Me.TypeComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TypeComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TypeComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "Type", True))
        Me.TypeComboBox1.FormattingEnabled = True
        Me.TypeComboBox1.Items.AddRange(New Object() {"Normal", "Others"})
        Me.TypeComboBox1.Location = New System.Drawing.Point(93, 176)
        Me.TypeComboBox1.Name = "TypeComboBox1"
        Me.TypeComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.TypeComboBox1.TabIndex = 8
        '
        'CreditsTextBox
        '
        Me.CreditsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "Credits", True))
        Me.CreditsTextBox.Location = New System.Drawing.Point(93, 150)
        Me.CreditsTextBox.Name = "CreditsTextBox"
        Me.CreditsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CreditsTextBox.TabIndex = 6
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.AddNew3
        Me.BindingNavigator3.BindingSource = Me.SubjectsBindingSource
        Me.BindingNavigator3.CountItem = Me.BindingNavigatorCountItem3
        Me.BindingNavigator3.DeleteItem = Nothing
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem3, Me.BindingNavigatorMovePreviousItem3, Me.BindingNavigatorSeparator9, Me.BindingNavigatorPositionItem3, Me.BindingNavigatorCountItem3, Me.BindingNavigatorSeparator10, Me.BindingNavigatorMoveNextItem3, Me.BindingNavigatorMoveLastItem3, Me.BindingNavigatorSeparator11, Me.AddNew3, Me.ToolStripButton3, Me.ToolStripButton75})
        Me.BindingNavigator3.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator3.MoveFirstItem = Me.BindingNavigatorMoveFirstItem3
        Me.BindingNavigator3.MoveLastItem = Me.BindingNavigatorMoveLastItem3
        Me.BindingNavigator3.MoveNextItem = Me.BindingNavigatorMoveNextItem3
        Me.BindingNavigator3.MovePreviousItem = Me.BindingNavigatorMovePreviousItem3
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.BindingNavigatorPositionItem3
        Me.BindingNavigator3.Size = New System.Drawing.Size(499, 25)
        Me.BindingNavigator3.TabIndex = 5
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'BindingNavigatorCountItem3
        '
        Me.BindingNavigatorCountItem3.Name = "BindingNavigatorCountItem3"
        Me.BindingNavigatorCountItem3.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem3.Text = "of {0}"
        Me.BindingNavigatorCountItem3.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem3
        '
        Me.BindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem3.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem3.Name = "BindingNavigatorMoveFirstItem3"
        Me.BindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem3.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem3
        '
        Me.BindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem3.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem3.Name = "BindingNavigatorMovePreviousItem3"
        Me.BindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem3.Text = "Move previous"
        '
        'BindingNavigatorSeparator9
        '
        Me.BindingNavigatorSeparator9.Name = "BindingNavigatorSeparator9"
        Me.BindingNavigatorSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem3
        '
        Me.BindingNavigatorPositionItem3.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem3.AutoSize = False
        Me.BindingNavigatorPositionItem3.Name = "BindingNavigatorPositionItem3"
        Me.BindingNavigatorPositionItem3.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem3.Text = "0"
        Me.BindingNavigatorPositionItem3.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator10
        '
        Me.BindingNavigatorSeparator10.Name = "BindingNavigatorSeparator10"
        Me.BindingNavigatorSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem3
        '
        Me.BindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem3.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem3.Name = "BindingNavigatorMoveNextItem3"
        Me.BindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem3.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem3
        '
        Me.BindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem3.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem3.Name = "BindingNavigatorMoveLastItem3"
        Me.BindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem3.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem3.Text = "Move last"
        '
        'BindingNavigatorSeparator11
        '
        Me.BindingNavigatorSeparator11.Name = "BindingNavigatorSeparator11"
        Me.BindingNavigatorSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Save Data"
        '
        'ToolStripButton75
        '
        Me.ToolStripButton75.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton75.Image = Global.SchoolParameters.My.Resources.Resources.Delete
        Me.ToolStripButton75.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton75.Name = "ToolStripButton75"
        Me.ToolStripButton75.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton75.Text = "ToolStripButton75"
        '
        'SubjectIDTextBox
        '
        Me.SubjectIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SubjectIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "SubjectID", True))
        Me.SubjectIDTextBox.Location = New System.Drawing.Point(93, 89)
        Me.SubjectIDTextBox.Name = "SubjectIDTextBox"
        Me.SubjectIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubjectIDTextBox.TabIndex = 1
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SubjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "Subject", True))
        Me.SubjectTextBox.Location = New System.Drawing.Point(93, 118)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(406, 20)
        Me.SubjectTextBox.TabIndex = 3
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(915, 378)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "SMS Account"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BindingNavigator4)
        Me.GroupBox5.Controls.Add(UserNameLabel)
        Me.GroupBox5.Controls.Add(Me.UserNameTextBox)
        Me.GroupBox5.Controls.Add(PasswordLabel)
        Me.GroupBox5.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox5.Location = New System.Drawing.Point(311, 140)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(317, 148)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Account"
        '
        'BindingNavigator4
        '
        Me.BindingNavigator4.AddNewItem = Me.BindingNavigatorAddNewItem4
        Me.BindingNavigator4.BindingSource = Me.SMSAccBindingSource
        Me.BindingNavigator4.CountItem = Me.BindingNavigatorCountItem4
        Me.BindingNavigator4.DeleteItem = Me.BindingNavigatorDeleteItem4
        Me.BindingNavigator4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem4, Me.BindingNavigatorMovePreviousItem4, Me.BindingNavigatorSeparator12, Me.BindingNavigatorPositionItem4, Me.BindingNavigatorCountItem4, Me.BindingNavigatorSeparator13, Me.BindingNavigatorMoveNextItem4, Me.BindingNavigatorMoveLastItem4, Me.BindingNavigatorSeparator14, Me.BindingNavigatorAddNewItem4, Me.BindingNavigatorDeleteItem4, Me.ToolStripButton4})
        Me.BindingNavigator4.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator4.MoveFirstItem = Me.BindingNavigatorMoveFirstItem4
        Me.BindingNavigator4.MoveLastItem = Me.BindingNavigatorMoveLastItem4
        Me.BindingNavigator4.MoveNextItem = Me.BindingNavigatorMoveNextItem4
        Me.BindingNavigator4.MovePreviousItem = Me.BindingNavigatorMovePreviousItem4
        Me.BindingNavigator4.Name = "BindingNavigator4"
        Me.BindingNavigator4.PositionItem = Me.BindingNavigatorPositionItem4
        Me.BindingNavigator4.Size = New System.Drawing.Size(311, 25)
        Me.BindingNavigator4.TabIndex = 5
        Me.BindingNavigator4.Text = "BindingNavigator4"
        '
        'BindingNavigatorAddNewItem4
        '
        Me.BindingNavigatorAddNewItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem4.Image = CType(resources.GetObject("BindingNavigatorAddNewItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem4.Name = "BindingNavigatorAddNewItem4"
        Me.BindingNavigatorAddNewItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem4.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem4.Text = "Add new"
        '
        'SMSAccBindingSource
        '
        Me.SMSAccBindingSource.DataMember = "SMSAcc"
        Me.SMSAccBindingSource.DataSource = Me.DsSchoolParameters
        '
        'BindingNavigatorCountItem4
        '
        Me.BindingNavigatorCountItem4.Name = "BindingNavigatorCountItem4"
        Me.BindingNavigatorCountItem4.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem4.Text = "of {0}"
        Me.BindingNavigatorCountItem4.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem4
        '
        Me.BindingNavigatorDeleteItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem4.Image = CType(resources.GetObject("BindingNavigatorDeleteItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem4.Name = "BindingNavigatorDeleteItem4"
        Me.BindingNavigatorDeleteItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem4.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem4.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem4
        '
        Me.BindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem4.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem4.Name = "BindingNavigatorMoveFirstItem4"
        Me.BindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem4.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem4.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem4
        '
        Me.BindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem4.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem4.Name = "BindingNavigatorMovePreviousItem4"
        Me.BindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem4.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem4.Text = "Move previous"
        '
        'BindingNavigatorSeparator12
        '
        Me.BindingNavigatorSeparator12.Name = "BindingNavigatorSeparator12"
        Me.BindingNavigatorSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem4
        '
        Me.BindingNavigatorPositionItem4.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem4.AutoSize = False
        Me.BindingNavigatorPositionItem4.Name = "BindingNavigatorPositionItem4"
        Me.BindingNavigatorPositionItem4.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem4.Text = "0"
        Me.BindingNavigatorPositionItem4.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator13
        '
        Me.BindingNavigatorSeparator13.Name = "BindingNavigatorSeparator13"
        Me.BindingNavigatorSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem4
        '
        Me.BindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem4.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem4.Name = "BindingNavigatorMoveNextItem4"
        Me.BindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem4.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem4.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem4
        '
        Me.BindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem4.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem4.Name = "BindingNavigatorMoveLastItem4"
        Me.BindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem4.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem4.Text = "Move last"
        '
        'BindingNavigatorSeparator14
        '
        Me.BindingNavigatorSeparator14.Name = "BindingNavigatorSeparator14"
        Me.BindingNavigatorSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Save Data"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SMSAccBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(104, 70)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(187, 20)
        Me.UserNameTextBox.TabIndex = 0
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SMSAccBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(104, 96)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(187, 20)
        Me.PasswordTextBox.TabIndex = 1
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.BindingNavigator8)
        Me.TabPage8.Controls.Add(Me.SchoolsessionsDataGridView)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(915, 378)
        Me.TabPage8.TabIndex = 8
        Me.TabPage8.Text = "SchoolSessions"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'BindingNavigator8
        '
        Me.BindingNavigator8.AddNewItem = Me.AddNew8
        Me.BindingNavigator8.BindingSource = Me.SchoolsessionsBindingSource
        Me.BindingNavigator8.CountItem = Me.ToolStripLabel4
        Me.BindingNavigator8.DeleteItem = Me.ToolStripButton27
        Me.BindingNavigator8.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton28, Me.ToolStripButton29, Me.ToolStripSeparator10, Me.ToolStripTextBox4, Me.ToolStripLabel4, Me.ToolStripSeparator11, Me.ToolStripButton30, Me.ToolStripButton31, Me.ToolStripSeparator12, Me.AddNew8, Me.ToolStripButton27, Me.ToolStripButton32})
        Me.BindingNavigator8.Location = New System.Drawing.Point(233, 58)
        Me.BindingNavigator8.MoveFirstItem = Me.ToolStripButton28
        Me.BindingNavigator8.MoveLastItem = Me.ToolStripButton31
        Me.BindingNavigator8.MoveNextItem = Me.ToolStripButton30
        Me.BindingNavigator8.MovePreviousItem = Me.ToolStripButton29
        Me.BindingNavigator8.Name = "BindingNavigator8"
        Me.BindingNavigator8.PositionItem = Me.ToolStripTextBox4
        Me.BindingNavigator8.Size = New System.Drawing.Size(278, 25)
        Me.BindingNavigator8.TabIndex = 8
        Me.BindingNavigator8.Text = "BindingNavigator8"
        '
        'AddNew8
        '
        Me.AddNew8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddNew8.Image = CType(resources.GetObject("AddNew8.Image"), System.Drawing.Image)
        Me.AddNew8.Name = "AddNew8"
        Me.AddNew8.RightToLeftAutoMirrorImage = True
        Me.AddNew8.Size = New System.Drawing.Size(23, 22)
        Me.AddNew8.Text = "Add new"
        '
        'SchoolsessionsBindingSource
        '
        Me.SchoolsessionsBindingSource.DataMember = "schoolsessions"
        Me.SchoolsessionsBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel4.Text = "of {0}"
        Me.ToolStripLabel4.ToolTipText = "Total number of items"
        '
        'ToolStripButton27
        '
        Me.ToolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton27.Image = CType(resources.GetObject("ToolStripButton27.Image"), System.Drawing.Image)
        Me.ToolStripButton27.Name = "ToolStripButton27"
        Me.ToolStripButton27.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton27.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton27.Text = "Delete"
        '
        'ToolStripButton28
        '
        Me.ToolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton28.Image = CType(resources.GetObject("ToolStripButton28.Image"), System.Drawing.Image)
        Me.ToolStripButton28.Name = "ToolStripButton28"
        Me.ToolStripButton28.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton28.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton28.Text = "Move first"
        '
        'ToolStripButton29
        '
        Me.ToolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton29.Image = CType(resources.GetObject("ToolStripButton29.Image"), System.Drawing.Image)
        Me.ToolStripButton29.Name = "ToolStripButton29"
        Me.ToolStripButton29.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton29.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton29.Text = "Move previous"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton30
        '
        Me.ToolStripButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton30.Image = CType(resources.GetObject("ToolStripButton30.Image"), System.Drawing.Image)
        Me.ToolStripButton30.Name = "ToolStripButton30"
        Me.ToolStripButton30.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton30.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton30.Text = "Move next"
        '
        'ToolStripButton31
        '
        Me.ToolStripButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton31.Image = CType(resources.GetObject("ToolStripButton31.Image"), System.Drawing.Image)
        Me.ToolStripButton31.Name = "ToolStripButton31"
        Me.ToolStripButton31.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton31.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton31.Text = "Move last"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton32
        '
        Me.ToolStripButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton32.Image = CType(resources.GetObject("ToolStripButton32.Image"), System.Drawing.Image)
        Me.ToolStripButton32.Name = "ToolStripButton32"
        Me.ToolStripButton32.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton32.Text = "Save Data"
        '
        'SchoolsessionsDataGridView
        '
        Me.SchoolsessionsDataGridView.AutoGenerateColumns = False
        Me.SchoolsessionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SchoolsessionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SessionDataGridViewTextBoxColumn})
        Me.SchoolsessionsDataGridView.DataSource = Me.SchoolsessionsBindingSource
        Me.SchoolsessionsDataGridView.Location = New System.Drawing.Point(242, 99)
        Me.SchoolsessionsDataGridView.Name = "SchoolsessionsDataGridView"
        Me.SchoolsessionsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.SchoolsessionsDataGridView.TabIndex = 0
        '
        'SessionDataGridViewTextBoxColumn
        '
        Me.SessionDataGridViewTextBoxColumn.DataPropertyName = "Session"
        Me.SessionDataGridViewTextBoxColumn.HeaderText = "Session"
        Me.SessionDataGridViewTextBoxColumn.Name = "SessionDataGridViewTextBoxColumn"
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.GroupBox13)
        Me.TabPage13.Location = New System.Drawing.Point(4, 22)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(915, 378)
        Me.TabPage13.TabIndex = 13
        Me.TabPage13.Text = "SubjectCartegories"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.BindingNavigator13)
        Me.GroupBox13.Controls.Add(Me.DepsDataGridView)
        Me.GroupBox13.Location = New System.Drawing.Point(191, 35)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(507, 320)
        Me.GroupBox13.TabIndex = 0
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "BookMaster"
        '
        'BindingNavigator13
        '
        Me.BindingNavigator13.AddNewItem = Me.ToolStripButton54
        Me.BindingNavigator13.BindingSource = Me.DepsBindingSource
        Me.BindingNavigator13.CountItem = Me.ToolStripLabel9
        Me.BindingNavigator13.DeleteItem = Me.ToolStripButton55
        Me.BindingNavigator13.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton56, Me.ToolStripButton57, Me.ToolStripSeparator25, Me.ToolStripTextBox9, Me.ToolStripLabel9, Me.ToolStripSeparator26, Me.ToolStripButton58, Me.ToolStripButton59, Me.ToolStripSeparator27, Me.ToolStripButton54, Me.ToolStripButton55, Me.ToolStripButton60})
        Me.BindingNavigator13.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator13.MoveFirstItem = Me.ToolStripButton56
        Me.BindingNavigator13.MoveLastItem = Me.ToolStripButton59
        Me.BindingNavigator13.MoveNextItem = Me.ToolStripButton58
        Me.BindingNavigator13.MovePreviousItem = Me.ToolStripButton57
        Me.BindingNavigator13.Name = "BindingNavigator13"
        Me.BindingNavigator13.PositionItem = Me.ToolStripTextBox9
        Me.BindingNavigator13.Size = New System.Drawing.Size(501, 25)
        Me.BindingNavigator13.TabIndex = 7
        Me.BindingNavigator13.Text = "BindingNavigator13"
        '
        'ToolStripButton54
        '
        Me.ToolStripButton54.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton54.Image = CType(resources.GetObject("ToolStripButton54.Image"), System.Drawing.Image)
        Me.ToolStripButton54.Name = "ToolStripButton54"
        Me.ToolStripButton54.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton54.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton54.Text = "Add new"
        '
        'DepsBindingSource
        '
        Me.DepsBindingSource.DataMember = "Deps"
        Me.DepsBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel9.Text = "of {0}"
        Me.ToolStripLabel9.ToolTipText = "Total number of items"
        '
        'ToolStripButton55
        '
        Me.ToolStripButton55.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton55.Image = CType(resources.GetObject("ToolStripButton55.Image"), System.Drawing.Image)
        Me.ToolStripButton55.Name = "ToolStripButton55"
        Me.ToolStripButton55.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton55.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton55.Text = "Delete"
        '
        'ToolStripButton56
        '
        Me.ToolStripButton56.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton56.Image = CType(resources.GetObject("ToolStripButton56.Image"), System.Drawing.Image)
        Me.ToolStripButton56.Name = "ToolStripButton56"
        Me.ToolStripButton56.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton56.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton56.Text = "Move first"
        '
        'ToolStripButton57
        '
        Me.ToolStripButton57.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton57.Image = CType(resources.GetObject("ToolStripButton57.Image"), System.Drawing.Image)
        Me.ToolStripButton57.Name = "ToolStripButton57"
        Me.ToolStripButton57.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton57.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton57.Text = "Move previous"
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox9
        '
        Me.ToolStripTextBox9.AccessibleName = "Position"
        Me.ToolStripTextBox9.AutoSize = False
        Me.ToolStripTextBox9.Name = "ToolStripTextBox9"
        Me.ToolStripTextBox9.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox9.Text = "0"
        Me.ToolStripTextBox9.ToolTipText = "Current position"
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        Me.ToolStripSeparator26.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton58
        '
        Me.ToolStripButton58.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton58.Image = CType(resources.GetObject("ToolStripButton58.Image"), System.Drawing.Image)
        Me.ToolStripButton58.Name = "ToolStripButton58"
        Me.ToolStripButton58.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton58.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton58.Text = "Move next"
        '
        'ToolStripButton59
        '
        Me.ToolStripButton59.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton59.Image = CType(resources.GetObject("ToolStripButton59.Image"), System.Drawing.Image)
        Me.ToolStripButton59.Name = "ToolStripButton59"
        Me.ToolStripButton59.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton59.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton59.Text = "Move last"
        '
        'ToolStripSeparator27
        '
        Me.ToolStripSeparator27.Name = "ToolStripSeparator27"
        Me.ToolStripSeparator27.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton60
        '
        Me.ToolStripButton60.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton60.Image = CType(resources.GetObject("ToolStripButton60.Image"), System.Drawing.Image)
        Me.ToolStripButton60.Name = "ToolStripButton60"
        Me.ToolStripButton60.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton60.Text = "Save Data"
        '
        'DepsDataGridView
        '
        Me.DepsDataGridView.AutoGenerateColumns = False
        Me.DepsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DepsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DepartmentDataGridViewTextBoxColumn, Me.ReportOrder})
        Me.DepsDataGridView.DataSource = Me.DepsBindingSource
        Me.DepsDataGridView.Location = New System.Drawing.Point(123, 58)
        Me.DepsDataGridView.Name = "DepsDataGridView"
        Me.DepsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DepsDataGridView.TabIndex = 0
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'ReportOrder
        '
        Me.ReportOrder.DataPropertyName = "ReportOrder"
        Me.ReportOrder.HeaderText = "ReportOrder"
        Me.ReportOrder.Name = "ReportOrder"
        Me.ReportOrder.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReportOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.GroupBox14)
        Me.TabPage14.Location = New System.Drawing.Point(4, 22)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage14.Size = New System.Drawing.Size(915, 378)
        Me.TabPage14.TabIndex = 14
        Me.TabPage14.Text = "SchoolSections"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.BindingNavigator14)
        Me.GroupBox14.Controls.Add(Me.DataGridView2)
        Me.GroupBox14.Location = New System.Drawing.Point(190, 101)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(559, 269)
        Me.GroupBox14.TabIndex = 0
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "SchoolSections"
        '
        'BindingNavigator14
        '
        Me.BindingNavigator14.AddNewItem = Me.ToolStripButton61
        Me.BindingNavigator14.BindingSource = Me.SchoolSectionsBindingSource
        Me.BindingNavigator14.CountItem = Me.ToolStripLabel10
        Me.BindingNavigator14.DeleteItem = Me.ToolStripButton62
        Me.BindingNavigator14.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton63, Me.ToolStripButton64, Me.ToolStripSeparator28, Me.ToolStripTextBox10, Me.ToolStripLabel10, Me.ToolStripSeparator29, Me.ToolStripButton65, Me.ToolStripButton66, Me.ToolStripSeparator30, Me.ToolStripButton61, Me.ToolStripButton62, Me.ToolStripButton67})
        Me.BindingNavigator14.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator14.MoveFirstItem = Me.ToolStripButton63
        Me.BindingNavigator14.MoveLastItem = Me.ToolStripButton66
        Me.BindingNavigator14.MoveNextItem = Me.ToolStripButton65
        Me.BindingNavigator14.MovePreviousItem = Me.ToolStripButton64
        Me.BindingNavigator14.Name = "BindingNavigator14"
        Me.BindingNavigator14.PositionItem = Me.ToolStripTextBox10
        Me.BindingNavigator14.Size = New System.Drawing.Size(553, 25)
        Me.BindingNavigator14.TabIndex = 8
        Me.BindingNavigator14.Text = "BindingNavigator14"
        '
        'ToolStripButton61
        '
        Me.ToolStripButton61.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton61.Image = CType(resources.GetObject("ToolStripButton61.Image"), System.Drawing.Image)
        Me.ToolStripButton61.Name = "ToolStripButton61"
        Me.ToolStripButton61.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton61.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton61.Text = "Add new"
        '
        'SchoolSectionsBindingSource
        '
        Me.SchoolSectionsBindingSource.DataMember = "SchoolSections"
        Me.SchoolSectionsBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ToolStripLabel10
        '
        Me.ToolStripLabel10.Name = "ToolStripLabel10"
        Me.ToolStripLabel10.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel10.Text = "of {0}"
        Me.ToolStripLabel10.ToolTipText = "Total number of items"
        '
        'ToolStripButton62
        '
        Me.ToolStripButton62.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton62.Image = CType(resources.GetObject("ToolStripButton62.Image"), System.Drawing.Image)
        Me.ToolStripButton62.Name = "ToolStripButton62"
        Me.ToolStripButton62.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton62.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton62.Text = "Delete"
        '
        'ToolStripButton63
        '
        Me.ToolStripButton63.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton63.Image = CType(resources.GetObject("ToolStripButton63.Image"), System.Drawing.Image)
        Me.ToolStripButton63.Name = "ToolStripButton63"
        Me.ToolStripButton63.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton63.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton63.Text = "Move first"
        '
        'ToolStripButton64
        '
        Me.ToolStripButton64.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton64.Image = CType(resources.GetObject("ToolStripButton64.Image"), System.Drawing.Image)
        Me.ToolStripButton64.Name = "ToolStripButton64"
        Me.ToolStripButton64.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton64.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton64.Text = "Move previous"
        '
        'ToolStripSeparator28
        '
        Me.ToolStripSeparator28.Name = "ToolStripSeparator28"
        Me.ToolStripSeparator28.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox10
        '
        Me.ToolStripTextBox10.AccessibleName = "Position"
        Me.ToolStripTextBox10.AutoSize = False
        Me.ToolStripTextBox10.Name = "ToolStripTextBox10"
        Me.ToolStripTextBox10.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox10.Text = "0"
        Me.ToolStripTextBox10.ToolTipText = "Current position"
        '
        'ToolStripSeparator29
        '
        Me.ToolStripSeparator29.Name = "ToolStripSeparator29"
        Me.ToolStripSeparator29.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton65
        '
        Me.ToolStripButton65.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton65.Image = CType(resources.GetObject("ToolStripButton65.Image"), System.Drawing.Image)
        Me.ToolStripButton65.Name = "ToolStripButton65"
        Me.ToolStripButton65.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton65.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton65.Text = "Move next"
        '
        'ToolStripButton66
        '
        Me.ToolStripButton66.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton66.Image = CType(resources.GetObject("ToolStripButton66.Image"), System.Drawing.Image)
        Me.ToolStripButton66.Name = "ToolStripButton66"
        Me.ToolStripButton66.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton66.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton66.Text = "Move last"
        '
        'ToolStripSeparator30
        '
        Me.ToolStripSeparator30.Name = "ToolStripSeparator30"
        Me.ToolStripSeparator30.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton67
        '
        Me.ToolStripButton67.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton67.Image = CType(resources.GetObject("ToolStripButton67.Image"), System.Drawing.Image)
        Me.ToolStripButton67.Name = "ToolStripButton67"
        Me.ToolStripButton67.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton67.Text = "Save Data"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SectionDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.SchoolSectionsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(121, 77)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 0
        '
        'SectionDataGridViewTextBoxColumn
        '
        Me.SectionDataGridViewTextBoxColumn.DataPropertyName = "section"
        Me.SectionDataGridViewTextBoxColumn.HeaderText = "section"
        Me.SectionDataGridViewTextBoxColumn.Name = "SectionDataGridViewTextBoxColumn"
        '
        'TabPage18
        '
        Me.TabPage18.Controls.Add(Me.GroupBox18)
        Me.TabPage18.Location = New System.Drawing.Point(4, 22)
        Me.TabPage18.Name = "TabPage18"
        Me.TabPage18.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage18.Size = New System.Drawing.Size(915, 378)
        Me.TabPage18.TabIndex = 18
        Me.TabPage18.Text = "SMTP Credentials"
        Me.TabPage18.UseVisualStyleBackColor = True
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.BindingNavigator17)
        Me.GroupBox18.Controls.Add(ServerLabel)
        Me.GroupBox18.Controls.Add(Me.ServerTextBox)
        Me.GroupBox18.Controls.Add(MailfromLabel)
        Me.GroupBox18.Controls.Add(Me.MailfromTextBox)
        Me.GroupBox18.Controls.Add(PortLabel)
        Me.GroupBox18.Controls.Add(Me.PortTextBox)
        Me.GroupBox18.Controls.Add(PasswordLabel1)
        Me.GroupBox18.Controls.Add(Me.PasswordTextBox1)
        Me.GroupBox18.Location = New System.Drawing.Point(145, 40)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(693, 345)
        Me.GroupBox18.TabIndex = 0
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "SMTP Credentials"
        '
        'BindingNavigator17
        '
        Me.BindingNavigator17.AddNewItem = Me.ToolStripButton83
        Me.BindingNavigator17.BindingSource = Me.SmtpBindingSource
        Me.BindingNavigator17.CountItem = Me.ToolStripLabel13
        Me.BindingNavigator17.DeleteItem = Me.ToolStripButton84
        Me.BindingNavigator17.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton85, Me.ToolStripButton86, Me.ToolStripSeparator37, Me.ToolStripTextBox13, Me.ToolStripLabel13, Me.ToolStripSeparator38, Me.ToolStripButton87, Me.ToolStripButton88, Me.ToolStripSeparator39, Me.ToolStripButton83, Me.ToolStripButton84, Me.ToolStripButton89})
        Me.BindingNavigator17.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator17.MoveFirstItem = Me.ToolStripButton85
        Me.BindingNavigator17.MoveLastItem = Me.ToolStripButton88
        Me.BindingNavigator17.MoveNextItem = Me.ToolStripButton87
        Me.BindingNavigator17.MovePreviousItem = Me.ToolStripButton86
        Me.BindingNavigator17.Name = "BindingNavigator17"
        Me.BindingNavigator17.PositionItem = Me.ToolStripTextBox13
        Me.BindingNavigator17.Size = New System.Drawing.Size(687, 25)
        Me.BindingNavigator17.TabIndex = 9
        Me.BindingNavigator17.Text = "BindingNavigator17"
        '
        'ToolStripButton83
        '
        Me.ToolStripButton83.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton83.Image = CType(resources.GetObject("ToolStripButton83.Image"), System.Drawing.Image)
        Me.ToolStripButton83.Name = "ToolStripButton83"
        Me.ToolStripButton83.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton83.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton83.Text = "Add new"
        '
        'SmtpBindingSource
        '
        Me.SmtpBindingSource.DataMember = "smtp"
        Me.SmtpBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ToolStripLabel13
        '
        Me.ToolStripLabel13.Name = "ToolStripLabel13"
        Me.ToolStripLabel13.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel13.Text = "of {0}"
        Me.ToolStripLabel13.ToolTipText = "Total number of items"
        '
        'ToolStripButton84
        '
        Me.ToolStripButton84.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton84.Image = CType(resources.GetObject("ToolStripButton84.Image"), System.Drawing.Image)
        Me.ToolStripButton84.Name = "ToolStripButton84"
        Me.ToolStripButton84.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton84.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton84.Text = "Delete"
        '
        'ToolStripButton85
        '
        Me.ToolStripButton85.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton85.Image = CType(resources.GetObject("ToolStripButton85.Image"), System.Drawing.Image)
        Me.ToolStripButton85.Name = "ToolStripButton85"
        Me.ToolStripButton85.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton85.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton85.Text = "Move first"
        '
        'ToolStripButton86
        '
        Me.ToolStripButton86.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton86.Image = CType(resources.GetObject("ToolStripButton86.Image"), System.Drawing.Image)
        Me.ToolStripButton86.Name = "ToolStripButton86"
        Me.ToolStripButton86.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton86.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton86.Text = "Move previous"
        '
        'ToolStripSeparator37
        '
        Me.ToolStripSeparator37.Name = "ToolStripSeparator37"
        Me.ToolStripSeparator37.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox13
        '
        Me.ToolStripTextBox13.AccessibleName = "Position"
        Me.ToolStripTextBox13.AutoSize = False
        Me.ToolStripTextBox13.Name = "ToolStripTextBox13"
        Me.ToolStripTextBox13.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox13.Text = "0"
        Me.ToolStripTextBox13.ToolTipText = "Current position"
        '
        'ToolStripSeparator38
        '
        Me.ToolStripSeparator38.Name = "ToolStripSeparator38"
        Me.ToolStripSeparator38.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton87
        '
        Me.ToolStripButton87.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton87.Image = CType(resources.GetObject("ToolStripButton87.Image"), System.Drawing.Image)
        Me.ToolStripButton87.Name = "ToolStripButton87"
        Me.ToolStripButton87.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton87.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton87.Text = "Move next"
        '
        'ToolStripButton88
        '
        Me.ToolStripButton88.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton88.Image = CType(resources.GetObject("ToolStripButton88.Image"), System.Drawing.Image)
        Me.ToolStripButton88.Name = "ToolStripButton88"
        Me.ToolStripButton88.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton88.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton88.Text = "Move last"
        '
        'ToolStripSeparator39
        '
        Me.ToolStripSeparator39.Name = "ToolStripSeparator39"
        Me.ToolStripSeparator39.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton89
        '
        Me.ToolStripButton89.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton89.Image = CType(resources.GetObject("ToolStripButton89.Image"), System.Drawing.Image)
        Me.ToolStripButton89.Name = "ToolStripButton89"
        Me.ToolStripButton89.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton89.Text = "Save Data"
        '
        'ServerTextBox
        '
        Me.ServerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SmtpBindingSource, "server", True))
        Me.ServerTextBox.Location = New System.Drawing.Point(291, 80)
        Me.ServerTextBox.Name = "ServerTextBox"
        Me.ServerTextBox.Size = New System.Drawing.Size(179, 20)
        Me.ServerTextBox.TabIndex = 1
        '
        'MailfromTextBox
        '
        Me.MailfromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SmtpBindingSource, "mailfrom", True))
        Me.MailfromTextBox.Location = New System.Drawing.Point(291, 132)
        Me.MailfromTextBox.Name = "MailfromTextBox"
        Me.MailfromTextBox.Size = New System.Drawing.Size(179, 20)
        Me.MailfromTextBox.TabIndex = 3
        '
        'PortTextBox
        '
        Me.PortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SmtpBindingSource, "port", True))
        Me.PortTextBox.Location = New System.Drawing.Point(291, 106)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(60, 20)
        Me.PortTextBox.TabIndex = 5
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SmtpBindingSource, "password", True))
        Me.PasswordTextBox1.Location = New System.Drawing.Point(291, 162)
        Me.PasswordTextBox1.Name = "PasswordTextBox1"
        Me.PasswordTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox1.Size = New System.Drawing.Size(179, 20)
        Me.PasswordTextBox1.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(842, 486)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 36)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "&Refresh"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Normal", "Project", "WRL", "Core"})
        Me.ComboBox2.Location = New System.Drawing.Point(93, 176)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'BindingNavigator5
        '
        Me.BindingNavigator5.AddNewItem = Me.ToolStripButton5
        Me.BindingNavigator5.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator5.DeleteItem = Me.ToolStripButton6
        Me.BindingNavigator5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton11})
        Me.BindingNavigator5.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator5.MoveFirstItem = Me.ToolStripButton7
        Me.BindingNavigator5.MoveLastItem = Me.ToolStripButton10
        Me.BindingNavigator5.MoveNextItem = Me.ToolStripButton9
        Me.BindingNavigator5.MovePreviousItem = Me.ToolStripButton8
        Me.BindingNavigator5.Name = "BindingNavigator5"
        Me.BindingNavigator5.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator5.Size = New System.Drawing.Size(538, 25)
        Me.BindingNavigator5.TabIndex = 5
        Me.BindingNavigator5.Text = "BindingNavigator3"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Add new"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Delete"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Move first"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Move previous"
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
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Move next"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Save Data"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(93, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(93, 118)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(431, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.tbGeneral)
        Me.TabControl2.Controls.Add(Me.tbExams)
        Me.TabControl2.Controls.Add(Me.tbFess)
        Me.TabControl2.Controls.Add(Me.tbstaff)
        Me.TabControl2.Location = New System.Drawing.Point(12, 26)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(952, 454)
        Me.TabControl2.TabIndex = 14
        '
        'tbGeneral
        '
        Me.tbGeneral.Controls.Add(Me.TabControl1)
        Me.tbGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tbGeneral.Name = "tbGeneral"
        Me.tbGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGeneral.Size = New System.Drawing.Size(944, 428)
        Me.tbGeneral.TabIndex = 0
        Me.tbGeneral.Text = "General"
        Me.tbGeneral.UseVisualStyleBackColor = True
        '
        'tbExams
        '
        Me.tbExams.Controls.Add(Me.TabControl3)
        Me.tbExams.Location = New System.Drawing.Point(4, 22)
        Me.tbExams.Name = "tbExams"
        Me.tbExams.Padding = New System.Windows.Forms.Padding(3)
        Me.tbExams.Size = New System.Drawing.Size(944, 428)
        Me.tbExams.TabIndex = 1
        Me.tbExams.Text = "ExamCenter"
        Me.tbExams.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.tbTermDuration)
        Me.TabControl3.Controls.Add(Me.tbProgramSubjects)
        Me.TabControl3.Controls.Add(Me.tbExamSessions)
        Me.TabControl3.Controls.Add(Me.tbExamGrading)
        Me.TabControl3.Controls.Add(Me.tbMarkWeights)
        Me.TabControl3.Location = New System.Drawing.Point(6, 7)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(932, 415)
        Me.TabControl3.TabIndex = 0
        '
        'tbTermDuration
        '
        Me.tbTermDuration.Controls.Add(Me.lbTermDurations)
        Me.tbTermDuration.Controls.Add(Me.GroupBox10)
        Me.tbTermDuration.Controls.Add(Me.GroupBox3)
        Me.tbTermDuration.Location = New System.Drawing.Point(4, 22)
        Me.tbTermDuration.Name = "tbTermDuration"
        Me.tbTermDuration.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTermDuration.Size = New System.Drawing.Size(924, 389)
        Me.tbTermDuration.TabIndex = 0
        Me.tbTermDuration.Text = "Term Duration"
        Me.tbTermDuration.UseVisualStyleBackColor = True
        '
        'lbTermDurations
        '
        Me.lbTermDurations.FormattingEnabled = True
        Me.lbTermDurations.Location = New System.Drawing.Point(599, 51)
        Me.lbTermDurations.Name = "lbTermDurations"
        Me.lbTermDurations.Size = New System.Drawing.Size(282, 160)
        Me.lbTermDurations.TabIndex = 16
        Me.lbTermDurations.Visible = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtTermDurationsSearch)
        Me.GroupBox10.Controls.Add(Me.btnTermDurationSearch)
        Me.GroupBox10.Controls.Add(Label9)
        Me.GroupBox10.Location = New System.Drawing.Point(562, 6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(356, 46)
        Me.GroupBox10.TabIndex = 15
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Term Search"
        '
        'txtTermDurationsSearch
        '
        Me.txtTermDurationsSearch.Location = New System.Drawing.Point(46, 18)
        Me.txtTermDurationsSearch.Name = "txtTermDurationsSearch"
        Me.txtTermDurationsSearch.Size = New System.Drawing.Size(264, 20)
        Me.txtTermDurationsSearch.TabIndex = 24
        '
        'btnTermDurationSearch
        '
        Me.btnTermDurationSearch.BackgroundImage = Global.SchoolParameters.My.Resources.Resources.Find
        Me.btnTermDurationSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTermDurationSearch.Location = New System.Drawing.Point(316, 19)
        Me.btnTermDurationSearch.Name = "btnTermDurationSearch"
        Me.btnTermDurationSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnTermDurationSearch.TabIndex = 23
        Me.btnTermDurationSearch.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSemDurRef)
        Me.GroupBox3.Controls.Add(Me.msksemEndDate)
        Me.GroupBox3.Controls.Add(Me.mskSemStartDate)
        Me.GroupBox3.Controls.Add(ClassLabel)
        Me.GroupBox3.Controls.Add(Me.ClassComboBox)
        Me.GroupBox3.Controls.Add(ProgramLabel)
        Me.GroupBox3.Controls.Add(Me.ProgramComboBox)
        Me.GroupBox3.Controls.Add(Me.BindingNavigator2)
        Me.GroupBox3.Controls.Add(StartDateLabel)
        Me.GroupBox3.Controls.Add(EndDateLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(286, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 215)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Term Durations"
        '
        'txtSemDurRef
        '
        Me.txtSemDurRef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SemesterDurationsBindingSource, "SemDurRef", True))
        Me.txtSemDurRef.Location = New System.Drawing.Point(141, 170)
        Me.txtSemDurRef.Name = "txtSemDurRef"
        Me.txtSemDurRef.Size = New System.Drawing.Size(10, 20)
        Me.txtSemDurRef.TabIndex = 17
        '
        'SemesterDurationsBindingSource
        '
        Me.SemesterDurationsBindingSource.DataMember = "SemesterDurations"
        Me.SemesterDurationsBindingSource.DataSource = Me.DsSchoolParameters
        '
        'msksemEndDate
        '
        Me.msksemEndDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SemesterDurationsBindingSource, "EndDate", True))
        Me.msksemEndDate.Location = New System.Drawing.Point(141, 143)
        Me.msksemEndDate.Mask = "00/00/0000"
        Me.msksemEndDate.Name = "msksemEndDate"
        Me.msksemEndDate.Size = New System.Drawing.Size(121, 20)
        Me.msksemEndDate.TabIndex = 16
        Me.msksemEndDate.ValidatingType = GetType(Date)
        '
        'mskSemStartDate
        '
        Me.mskSemStartDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SemesterDurationsBindingSource, "StartDate", True))
        Me.mskSemStartDate.Location = New System.Drawing.Point(141, 117)
        Me.mskSemStartDate.Mask = "00/00/0000"
        Me.mskSemStartDate.Name = "mskSemStartDate"
        Me.mskSemStartDate.Size = New System.Drawing.Size(121, 20)
        Me.mskSemStartDate.TabIndex = 15
        Me.mskSemStartDate.ValidatingType = GetType(Date)
        '
        'ClassComboBox
        '
        Me.ClassComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ClassComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ClassComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SemesterDurationsBindingSource, "ClassDesc", True))
        Me.ClassComboBox.FormattingEnabled = True
        Me.ClassComboBox.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016"})
        Me.ClassComboBox.Location = New System.Drawing.Point(141, 90)
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ClassComboBox.TabIndex = 0
        '
        'ProgramComboBox
        '
        Me.ProgramComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProgramComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProgramComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SemesterDurationsBindingSource, "Program", True))
        Me.ProgramComboBox.DisplayMember = "Forms"
        Me.ProgramComboBox.FormattingEnabled = True
        Me.ProgramComboBox.Location = New System.Drawing.Point(141, 63)
        Me.ProgramComboBox.Name = "ProgramComboBox"
        Me.ProgramComboBox.Size = New System.Drawing.Size(200, 21)
        Me.ProgramComboBox.TabIndex = 6
        Me.ProgramComboBox.ValueMember = "Forms"
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.AddNew
        Me.BindingNavigator2.BindingSource = Me.SemesterDurationsBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.AddNew, Me.SemSave, Me.ToolStripButton12})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator2.Size = New System.Drawing.Size(346, 25)
        Me.BindingNavigator2.TabIndex = 12
        Me.BindingNavigator2.Text = "BindingNavigator2"
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
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'SemSave
        '
        Me.SemSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SemSave.Image = CType(resources.GetObject("SemSave.Image"), System.Drawing.Image)
        Me.SemSave.Name = "SemSave"
        Me.SemSave.Size = New System.Drawing.Size(23, 22)
        Me.SemSave.Text = "Save Data"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = Global.SchoolParameters.My.Resources.Resources.Delete
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "ToolStripButton12"
        '
        'tbProgramSubjects
        '
        Me.tbProgramSubjects.Controls.Add(Me.GroupBox6)
        Me.tbProgramSubjects.Location = New System.Drawing.Point(4, 22)
        Me.tbProgramSubjects.Name = "tbProgramSubjects"
        Me.tbProgramSubjects.Padding = New System.Windows.Forms.Padding(3)
        Me.tbProgramSubjects.Size = New System.Drawing.Size(924, 389)
        Me.tbProgramSubjects.TabIndex = 1
        Me.tbProgramSubjects.Text = "ProgramSubjects"
        Me.tbProgramSubjects.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.chkPrograms)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.ComboBox1)
        Me.GroupBox6.Location = New System.Drawing.Point(236, 13)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(453, 363)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Subject Programs"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(169, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 24)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(210, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkPrograms
        '
        Me.chkPrograms.FormattingEnabled = True
        Me.chkPrograms.Location = New System.Drawing.Point(122, 70)
        Me.chkPrograms.Name = "chkPrograms"
        Me.chkPrograms.Size = New System.Drawing.Size(245, 244)
        Me.chkPrograms.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Program"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DisplayMember = "Forms"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(55, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(362, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Forms"
        '
        'tbExamSessions
        '
        Me.tbExamSessions.Controls.Add(Me.lbExamSearch)
        Me.tbExamSessions.Controls.Add(Me.GroupBox16)
        Me.tbExamSessions.Controls.Add(Me.GroupBox20)
        Me.tbExamSessions.Location = New System.Drawing.Point(4, 22)
        Me.tbExamSessions.Name = "tbExamSessions"
        Me.tbExamSessions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbExamSessions.Size = New System.Drawing.Size(924, 389)
        Me.tbExamSessions.TabIndex = 2
        Me.tbExamSessions.Text = "ExamSessions"
        Me.tbExamSessions.UseVisualStyleBackColor = True
        '
        'lbExamSearch
        '
        Me.lbExamSearch.FormattingEnabled = True
        Me.lbExamSearch.Location = New System.Drawing.Point(622, 59)
        Me.lbExamSearch.Name = "lbExamSearch"
        Me.lbExamSearch.Size = New System.Drawing.Size(282, 160)
        Me.lbExamSearch.TabIndex = 17
        Me.lbExamSearch.Visible = False
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.btnExamSearch)
        Me.GroupBox16.Controls.Add(Me.txtExamSearch)
        Me.GroupBox16.Controls.Add(Me.Label10)
        Me.GroupBox16.Location = New System.Drawing.Point(539, 16)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(379, 46)
        Me.GroupBox16.TabIndex = 10
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "ExamSession Search"
        '
        'btnExamSearch
        '
        Me.btnExamSearch.BackgroundImage = Global.SchoolParameters.My.Resources.Resources.Find
        Me.btnExamSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExamSearch.Location = New System.Drawing.Point(344, 19)
        Me.btnExamSearch.Name = "btnExamSearch"
        Me.btnExamSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnExamSearch.TabIndex = 18
        Me.btnExamSearch.UseVisualStyleBackColor = True
        '
        'txtExamSearch
        '
        Me.txtExamSearch.Location = New System.Drawing.Point(83, 19)
        Me.txtExamSearch.Name = "txtExamSearch"
        Me.txtExamSearch.Size = New System.Drawing.Size(255, 20)
        Me.txtExamSearch.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "ExamSession:"
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Label24)
        Me.GroupBox20.Controls.Add(Me.cboExamParentExam)
        Me.GroupBox20.Controls.Add(SessionLabel)
        Me.GroupBox20.Controls.Add(Me.SessionTextBox)
        Me.GroupBox20.Controls.Add(ExamClassRefLabel)
        Me.GroupBox20.Controls.Add(Me.ExamClassRefComboBox)
        Me.GroupBox20.Controls.Add(SittingLabel)
        Me.GroupBox20.Controls.Add(Me.SittingTextBox)
        Me.GroupBox20.Controls.Add(Me.RefTextBox1)
        Me.GroupBox20.Controls.Add(Me.PublishCheckBox)
        Me.GroupBox20.Controls.Add(Me.AutoCommentCheckBox)
        Me.GroupBox20.Controls.Add(Me.BindingNavigator7)
        Me.GroupBox20.Location = New System.Drawing.Point(205, 90)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(507, 265)
        Me.GroupBox20.TabIndex = 3
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "ExamSessions"
        '
        'cboExamParentExam
        '
        Me.cboExamParentExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboExamParentExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboExamParentExam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamSessionsBindingSource, "ParentExam", True))
        Me.cboExamParentExam.FormattingEnabled = True
        Me.cboExamParentExam.Location = New System.Drawing.Point(224, 139)
        Me.cboExamParentExam.Name = "cboExamParentExam"
        Me.cboExamParentExam.Size = New System.Drawing.Size(121, 21)
        Me.cboExamParentExam.TabIndex = 20
        '
        'ExamSessionsBindingSource
        '
        Me.ExamSessionsBindingSource.DataMember = "ExamSessions"
        Me.ExamSessionsBindingSource.DataSource = Me.DsSchoolParameters
        '
        'SessionTextBox
        '
        Me.SessionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamSessionsBindingSource, "Session", True))
        Me.SessionTextBox.Location = New System.Drawing.Point(224, 87)
        Me.SessionTextBox.Name = "SessionTextBox"
        Me.SessionTextBox.Size = New System.Drawing.Size(259, 20)
        Me.SessionTextBox.TabIndex = 8
        '
        'ExamClassRefComboBox
        '
        Me.ExamClassRefComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ExamClassRefComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ExamClassRefComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamSessionsBindingSource, "ExamClassRef", True))
        Me.ExamClassRefComboBox.FormattingEnabled = True
        Me.ExamClassRefComboBox.Location = New System.Drawing.Point(224, 113)
        Me.ExamClassRefComboBox.Name = "ExamClassRefComboBox"
        Me.ExamClassRefComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ExamClassRefComboBox.TabIndex = 10
        '
        'SittingTextBox
        '
        Me.SittingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamSessionsBindingSource, "Sitting", True))
        Me.SittingTextBox.Location = New System.Drawing.Point(224, 164)
        Me.SittingTextBox.Name = "SittingTextBox"
        Me.SittingTextBox.Size = New System.Drawing.Size(121, 20)
        Me.SittingTextBox.TabIndex = 12
        '
        'RefTextBox1
        '
        Me.RefTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExamSessionsBindingSource, "Ref", True))
        Me.RefTextBox1.Location = New System.Drawing.Point(6, 44)
        Me.RefTextBox1.Name = "RefTextBox1"
        Me.RefTextBox1.Size = New System.Drawing.Size(10, 20)
        Me.RefTextBox1.TabIndex = 14
        '
        'PublishCheckBox
        '
        Me.PublishCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ExamSessionsBindingSource, "Publish", True))
        Me.PublishCheckBox.Location = New System.Drawing.Point(224, 190)
        Me.PublishCheckBox.Name = "PublishCheckBox"
        Me.PublishCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.PublishCheckBox.TabIndex = 16
        Me.PublishCheckBox.Text = "Publish"
        Me.PublishCheckBox.UseVisualStyleBackColor = True
        '
        'AutoCommentCheckBox
        '
        Me.AutoCommentCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ExamSessionsBindingSource, "AutoComment", True))
        Me.AutoCommentCheckBox.Location = New System.Drawing.Point(224, 220)
        Me.AutoCommentCheckBox.Name = "AutoCommentCheckBox"
        Me.AutoCommentCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.AutoCommentCheckBox.TabIndex = 18
        Me.AutoCommentCheckBox.Text = "MultiComment"
        Me.AutoCommentCheckBox.UseVisualStyleBackColor = True
        '
        'BindingNavigator7
        '
        Me.BindingNavigator7.AddNewItem = Me.ToolStripButton20
        Me.BindingNavigator7.BindingSource = Me.ExamSessionsBindingSource
        Me.BindingNavigator7.CountItem = Me.ToolStripLabel3
        Me.BindingNavigator7.DeleteItem = Nothing
        Me.BindingNavigator7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton21, Me.ToolStripButton22, Me.ToolStripSeparator7, Me.ToolStripTextBox3, Me.ToolStripLabel3, Me.ToolStripSeparator8, Me.ToolStripButton23, Me.ToolStripButton24, Me.ToolStripSeparator9, Me.ToolStripButton20, Me.ToolStripButton25, Me.ToolStripButton97})
        Me.BindingNavigator7.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator7.MoveFirstItem = Me.ToolStripButton21
        Me.BindingNavigator7.MoveLastItem = Me.ToolStripButton24
        Me.BindingNavigator7.MoveNextItem = Me.ToolStripButton23
        Me.BindingNavigator7.MovePreviousItem = Me.ToolStripButton22
        Me.BindingNavigator7.Name = "BindingNavigator7"
        Me.BindingNavigator7.PositionItem = Me.ToolStripTextBox3
        Me.BindingNavigator7.Size = New System.Drawing.Size(501, 25)
        Me.BindingNavigator7.TabIndex = 7
        Me.BindingNavigator7.Text = "BindingNavigator7"
        '
        'ToolStripButton20
        '
        Me.ToolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton20.Image = CType(resources.GetObject("ToolStripButton20.Image"), System.Drawing.Image)
        Me.ToolStripButton20.Name = "ToolStripButton20"
        Me.ToolStripButton20.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton20.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton20.Text = "Add new"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel3.Text = "of {0}"
        Me.ToolStripLabel3.ToolTipText = "Total number of items"
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton21.Image = CType(resources.GetObject("ToolStripButton21.Image"), System.Drawing.Image)
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton21.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton21.Text = "Move first"
        '
        'ToolStripButton22
        '
        Me.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton22.Image = CType(resources.GetObject("ToolStripButton22.Image"), System.Drawing.Image)
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton22.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton22.Text = "Move previous"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton23
        '
        Me.ToolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton23.Image = CType(resources.GetObject("ToolStripButton23.Image"), System.Drawing.Image)
        Me.ToolStripButton23.Name = "ToolStripButton23"
        Me.ToolStripButton23.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton23.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton23.Text = "Move next"
        '
        'ToolStripButton24
        '
        Me.ToolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton24.Image = CType(resources.GetObject("ToolStripButton24.Image"), System.Drawing.Image)
        Me.ToolStripButton24.Name = "ToolStripButton24"
        Me.ToolStripButton24.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton24.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton24.Text = "Move last"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton25
        '
        Me.ToolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton25.Image = CType(resources.GetObject("ToolStripButton25.Image"), System.Drawing.Image)
        Me.ToolStripButton25.Name = "ToolStripButton25"
        Me.ToolStripButton25.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton25.Text = "Save Data"
        '
        'ToolStripButton97
        '
        Me.ToolStripButton97.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton97.Image = Global.SchoolParameters.My.Resources.Resources.Delete
        Me.ToolStripButton97.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton97.Name = "ToolStripButton97"
        Me.ToolStripButton97.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton97.Text = "Delete"
        '
        'tbExamGrading
        '
        Me.tbExamGrading.Controls.Add(Me.GroupBox15)
        Me.tbExamGrading.Location = New System.Drawing.Point(4, 22)
        Me.tbExamGrading.Name = "tbExamGrading"
        Me.tbExamGrading.Padding = New System.Windows.Forms.Padding(3)
        Me.tbExamGrading.Size = New System.Drawing.Size(924, 389)
        Me.tbExamGrading.TabIndex = 3
        Me.tbExamGrading.Text = "ExamGrading"
        Me.tbExamGrading.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.chkMultipleAutoComments)
        Me.GroupBox15.Controls.Add(Me.txtgradeRef)
        Me.GroupBox15.Controls.Add(Me.chkAllSessions)
        Me.GroupBox15.Controls.Add(Me.cboGradeSession)
        Me.GroupBox15.Controls.Add(Me.Label19)
        Me.GroupBox15.Controls.Add(Me.Label17)
        Me.GroupBox15.Controls.Add(Me.txtGradingCredits)
        Me.GroupBox15.Controls.Add(Me.Button5)
        Me.GroupBox15.Controls.Add(Me.btnAddGrade)
        Me.GroupBox15.Controls.Add(Me.Label15)
        Me.GroupBox15.Controls.Add(Me.Label14)
        Me.GroupBox15.Controls.Add(Me.Label13)
        Me.GroupBox15.Controls.Add(Me.TxtGradingGrade)
        Me.GroupBox15.Controls.Add(Me.txtGradingUpperLimit)
        Me.GroupBox15.Controls.Add(Me.txtGradingLowerLimit)
        Me.GroupBox15.Controls.Add(Me.lvExmGrd)
        Me.GroupBox15.Controls.Add(Me.Label12)
        Me.GroupBox15.Controls.Add(Me.cbGradingProg)
        Me.GroupBox15.Location = New System.Drawing.Point(89, 6)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(746, 377)
        Me.GroupBox15.TabIndex = 1
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "ExamGrading"
        '
        'chkMultipleAutoComments
        '
        Me.chkMultipleAutoComments.AutoSize = True
        Me.chkMultipleAutoComments.Location = New System.Drawing.Point(503, 78)
        Me.chkMultipleAutoComments.Name = "chkMultipleAutoComments"
        Me.chkMultipleAutoComments.Size = New System.Drawing.Size(94, 17)
        Me.chkMultipleAutoComments.TabIndex = 22
        Me.chkMultipleAutoComments.Text = "AddComments"
        Me.chkMultipleAutoComments.UseVisualStyleBackColor = True
        '
        'txtgradeRef
        '
        Me.txtgradeRef.Location = New System.Drawing.Point(649, 36)
        Me.txtgradeRef.Name = "txtgradeRef"
        Me.txtgradeRef.ReadOnly = True
        Me.txtgradeRef.Size = New System.Drawing.Size(10, 20)
        Me.txtgradeRef.TabIndex = 21
        '
        'chkAllSessions
        '
        Me.chkAllSessions.AutoSize = True
        Me.chkAllSessions.Checked = True
        Me.chkAllSessions.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAllSessions.Location = New System.Drawing.Point(564, 38)
        Me.chkAllSessions.Name = "chkAllSessions"
        Me.chkAllSessions.Size = New System.Drawing.Size(79, 17)
        Me.chkAllSessions.TabIndex = 18
        Me.chkAllSessions.Text = "AllSessions"
        Me.chkAllSessions.UseVisualStyleBackColor = True
        '
        'cboGradeSession
        '
        Me.cboGradeSession.DisplayMember = "Session"
        Me.cboGradeSession.FormattingEnabled = True
        Me.cboGradeSession.Location = New System.Drawing.Point(410, 36)
        Me.cboGradeSession.Name = "cboGradeSession"
        Me.cboGradeSession.Size = New System.Drawing.Size(121, 21)
        Me.cboGradeSession.TabIndex = 17
        Me.cboGradeSession.ValueMember = "Session"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(351, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 13)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Session : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(108, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Credits:"
        '
        'txtGradingCredits
        '
        Me.txtGradingCredits.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGradingCredits.Location = New System.Drawing.Point(153, 79)
        Me.txtGradingCredits.Name = "txtGradingCredits"
        Me.txtGradingCredits.Size = New System.Drawing.Size(51, 20)
        Me.txtGradingCredits.TabIndex = 14
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(295, 344)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "SAVE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnAddGrade
        '
        Me.btnAddGrade.Enabled = False
        Me.btnAddGrade.Location = New System.Drawing.Point(603, 72)
        Me.btnAddGrade.Name = "btnAddGrade"
        Me.btnAddGrade.Size = New System.Drawing.Size(75, 23)
        Me.btnAddGrade.TabIndex = 9
        Me.btnAddGrade.Text = "ADD"
        Me.btnAddGrade.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Grade:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(362, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "UpperLimit:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(217, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "LowerLimit:"
        '
        'TxtGradingGrade
        '
        Me.TxtGradingGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGradingGrade.Location = New System.Drawing.Point(51, 79)
        Me.TxtGradingGrade.Name = "TxtGradingGrade"
        Me.TxtGradingGrade.Size = New System.Drawing.Size(51, 20)
        Me.TxtGradingGrade.TabIndex = 5
        '
        'txtGradingUpperLimit
        '
        Me.txtGradingUpperLimit.Location = New System.Drawing.Point(428, 75)
        Me.txtGradingUpperLimit.Name = "txtGradingUpperLimit"
        Me.txtGradingUpperLimit.Size = New System.Drawing.Size(57, 20)
        Me.txtGradingUpperLimit.TabIndex = 4
        '
        'txtGradingLowerLimit
        '
        Me.txtGradingLowerLimit.Location = New System.Drawing.Point(295, 78)
        Me.txtGradingLowerLimit.Name = "txtGradingLowerLimit"
        Me.txtGradingLowerLimit.Size = New System.Drawing.Size(61, 20)
        Me.txtGradingLowerLimit.TabIndex = 3
        '
        'lvExmGrd
        '
        Me.lvExmGrd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Grade, Me.Lower, Me.Upper, Me.Credits, Me.Ref})
        Me.lvExmGrd.FullRowSelect = True
        Me.lvExmGrd.GridLines = True
        Me.lvExmGrd.HideSelection = False
        Me.lvExmGrd.Location = New System.Drawing.Point(108, 111)
        Me.lvExmGrd.MultiSelect = False
        Me.lvExmGrd.Name = "lvExmGrd"
        Me.lvExmGrd.Size = New System.Drawing.Size(474, 227)
        Me.lvExmGrd.TabIndex = 2
        Me.lvExmGrd.UseCompatibleStateImageBehavior = False
        Me.lvExmGrd.View = System.Windows.Forms.View.Details
        '
        'Grade
        '
        Me.Grade.Text = "Grade"
        Me.Grade.Width = 120
        '
        'Lower
        '
        Me.Lower.Text = ">="
        '
        'Upper
        '
        Me.Upper.Text = "<="
        Me.Upper.Width = 81
        '
        'Credits
        '
        Me.Credits.Text = "Credits"
        '
        'Ref
        '
        Me.Ref.Text = "Reference"
        Me.Ref.Width = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(155, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Program:"
        '
        'cbGradingProg
        '
        Me.cbGradingProg.DisplayMember = "Forms"
        Me.cbGradingProg.FormattingEnabled = True
        Me.cbGradingProg.Location = New System.Drawing.Point(210, 36)
        Me.cbGradingProg.Name = "cbGradingProg"
        Me.cbGradingProg.Size = New System.Drawing.Size(121, 21)
        Me.cbGradingProg.TabIndex = 0
        Me.cbGradingProg.ValueMember = "Forms"
        '
        'tbMarkWeights
        '
        Me.tbMarkWeights.Controls.Add(Me.GroupBox17)
        Me.tbMarkWeights.Location = New System.Drawing.Point(4, 22)
        Me.tbMarkWeights.Name = "tbMarkWeights"
        Me.tbMarkWeights.Padding = New System.Windows.Forms.Padding(3)
        Me.tbMarkWeights.Size = New System.Drawing.Size(924, 389)
        Me.tbMarkWeights.TabIndex = 4
        Me.tbMarkWeights.Text = "MarkWeights"
        Me.tbMarkWeights.UseVisualStyleBackColor = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.BindingNavigator16)
        Me.GroupBox17.Controls.Add(Me.MarkWeightingDataGridView)
        Me.GroupBox17.Location = New System.Drawing.Point(216, 36)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(492, 316)
        Me.GroupBox17.TabIndex = 1
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Wights"
        '
        'BindingNavigator16
        '
        Me.BindingNavigator16.AddNewItem = Me.ToolStripButton76
        Me.BindingNavigator16.BindingSource = Me.MarkWeightingBindingSource
        Me.BindingNavigator16.CountItem = Me.ToolStripLabel12
        Me.BindingNavigator16.DeleteItem = Me.ToolStripButton77
        Me.BindingNavigator16.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton78, Me.ToolStripButton79, Me.ToolStripSeparator34, Me.ToolStripTextBox12, Me.ToolStripLabel12, Me.ToolStripSeparator35, Me.ToolStripButton80, Me.ToolStripButton81, Me.ToolStripSeparator36, Me.ToolStripButton76, Me.ToolStripButton77, Me.ToolStripButton82})
        Me.BindingNavigator16.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator16.MoveFirstItem = Me.ToolStripButton78
        Me.BindingNavigator16.MoveLastItem = Me.ToolStripButton81
        Me.BindingNavigator16.MoveNextItem = Me.ToolStripButton80
        Me.BindingNavigator16.MovePreviousItem = Me.ToolStripButton79
        Me.BindingNavigator16.Name = "BindingNavigator16"
        Me.BindingNavigator16.PositionItem = Me.ToolStripTextBox12
        Me.BindingNavigator16.Size = New System.Drawing.Size(486, 25)
        Me.BindingNavigator16.TabIndex = 9
        Me.BindingNavigator16.Text = "BindingNavigator16"
        '
        'ToolStripButton76
        '
        Me.ToolStripButton76.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton76.Image = CType(resources.GetObject("ToolStripButton76.Image"), System.Drawing.Image)
        Me.ToolStripButton76.Name = "ToolStripButton76"
        Me.ToolStripButton76.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton76.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton76.Text = "Add new"
        '
        'MarkWeightingBindingSource
        '
        Me.MarkWeightingBindingSource.DataMember = "MarkWeighting"
        Me.MarkWeightingBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ToolStripLabel12
        '
        Me.ToolStripLabel12.Name = "ToolStripLabel12"
        Me.ToolStripLabel12.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel12.Text = "of {0}"
        Me.ToolStripLabel12.ToolTipText = "Total number of items"
        '
        'ToolStripButton77
        '
        Me.ToolStripButton77.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton77.Image = CType(resources.GetObject("ToolStripButton77.Image"), System.Drawing.Image)
        Me.ToolStripButton77.Name = "ToolStripButton77"
        Me.ToolStripButton77.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton77.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton77.Text = "Delete"
        '
        'ToolStripButton78
        '
        Me.ToolStripButton78.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton78.Image = CType(resources.GetObject("ToolStripButton78.Image"), System.Drawing.Image)
        Me.ToolStripButton78.Name = "ToolStripButton78"
        Me.ToolStripButton78.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton78.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton78.Text = "Move first"
        '
        'ToolStripButton79
        '
        Me.ToolStripButton79.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton79.Image = CType(resources.GetObject("ToolStripButton79.Image"), System.Drawing.Image)
        Me.ToolStripButton79.Name = "ToolStripButton79"
        Me.ToolStripButton79.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton79.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton79.Text = "Move previous"
        '
        'ToolStripSeparator34
        '
        Me.ToolStripSeparator34.Name = "ToolStripSeparator34"
        Me.ToolStripSeparator34.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox12
        '
        Me.ToolStripTextBox12.AccessibleName = "Position"
        Me.ToolStripTextBox12.AutoSize = False
        Me.ToolStripTextBox12.Name = "ToolStripTextBox12"
        Me.ToolStripTextBox12.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox12.Text = "0"
        Me.ToolStripTextBox12.ToolTipText = "Current position"
        '
        'ToolStripSeparator35
        '
        Me.ToolStripSeparator35.Name = "ToolStripSeparator35"
        Me.ToolStripSeparator35.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton80
        '
        Me.ToolStripButton80.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton80.Image = CType(resources.GetObject("ToolStripButton80.Image"), System.Drawing.Image)
        Me.ToolStripButton80.Name = "ToolStripButton80"
        Me.ToolStripButton80.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton80.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton80.Text = "Move next"
        '
        'ToolStripButton81
        '
        Me.ToolStripButton81.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton81.Image = CType(resources.GetObject("ToolStripButton81.Image"), System.Drawing.Image)
        Me.ToolStripButton81.Name = "ToolStripButton81"
        Me.ToolStripButton81.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton81.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton81.Text = "Move last"
        '
        'ToolStripSeparator36
        '
        Me.ToolStripSeparator36.Name = "ToolStripSeparator36"
        Me.ToolStripSeparator36.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton82
        '
        Me.ToolStripButton82.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton82.Image = CType(resources.GetObject("ToolStripButton82.Image"), System.Drawing.Image)
        Me.ToolStripButton82.Name = "ToolStripButton82"
        Me.ToolStripButton82.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton82.Text = "Save Data"
        '
        'MarkWeightingDataGridView
        '
        Me.MarkWeightingDataGridView.AutoGenerateColumns = False
        Me.MarkWeightingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarkWeightingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Section, Me.type, Me.WeightDataGridViewTextBoxColumn})
        Me.MarkWeightingDataGridView.DataSource = Me.MarkWeightingBindingSource
        Me.MarkWeightingDataGridView.Location = New System.Drawing.Point(102, 58)
        Me.MarkWeightingDataGridView.Name = "MarkWeightingDataGridView"
        Me.MarkWeightingDataGridView.Size = New System.Drawing.Size(346, 220)
        Me.MarkWeightingDataGridView.TabIndex = 0
        '
        'Section
        '
        Me.Section.DataPropertyName = "section"
        Me.Section.DataSource = Me.FormsBindingSource
        Me.Section.DisplayMember = "Forms"
        Me.Section.HeaderText = "Program"
        Me.Section.Name = "Section"
        Me.Section.ValueMember = "Forms"
        '
        'type
        '
        Me.type.DataPropertyName = "type"
        Me.type.HeaderText = "Type"
        Me.type.Items.AddRange(New Object() {"C", "E"})
        Me.type.Name = "type"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'tbFess
        '
        Me.tbFess.Controls.Add(Me.TabControl4)
        Me.tbFess.Location = New System.Drawing.Point(4, 22)
        Me.tbFess.Name = "tbFess"
        Me.tbFess.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFess.Size = New System.Drawing.Size(944, 428)
        Me.tbFess.TabIndex = 2
        Me.tbFess.Text = "FeesPayments"
        Me.tbFess.UseVisualStyleBackColor = True
        '
        'TabControl4
        '
        Me.TabControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl4.Controls.Add(Me.tbPaymentPeriods)
        Me.TabControl4.Controls.Add(Me.tbPayCart)
        Me.TabControl4.Controls.Add(Me.tbPAyMethods)
        Me.TabControl4.Controls.Add(Me.tbCurrencies)
        Me.TabControl4.Controls.Add(Me.tbExchangeRates)
        Me.TabControl4.Location = New System.Drawing.Point(15, 9)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(918, 409)
        Me.TabControl4.TabIndex = 0
        '
        'tbPaymentPeriods
        '
        Me.tbPaymentPeriods.Controls.Add(Me.GroupBox8)
        Me.tbPaymentPeriods.Location = New System.Drawing.Point(4, 22)
        Me.tbPaymentPeriods.Name = "tbPaymentPeriods"
        Me.tbPaymentPeriods.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPaymentPeriods.Size = New System.Drawing.Size(910, 383)
        Me.tbPaymentPeriods.TabIndex = 0
        Me.tbPaymentPeriods.Text = "PaymentPeriod"
        Me.tbPaymentPeriods.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.PaymentPeriodsDataGridView)
        Me.GroupBox8.Controls.Add(Me.BindingNavigator6)
        Me.GroupBox8.Location = New System.Drawing.Point(125, 58)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(660, 266)
        Me.GroupBox8.TabIndex = 26
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Periods"
        '
        'PaymentPeriodsDataGridView
        '
        Me.PaymentPeriodsDataGridView.AutoGenerateColumns = False
        Me.PaymentPeriodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentPeriodsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PeriodDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.CurrentDataGridViewCheckBoxColumn})
        Me.PaymentPeriodsDataGridView.DataSource = Me.PaymentPeriodsBindingSource
        Me.PaymentPeriodsDataGridView.Location = New System.Drawing.Point(57, 60)
        Me.PaymentPeriodsDataGridView.Name = "PaymentPeriodsDataGridView"
        Me.PaymentPeriodsDataGridView.Size = New System.Drawing.Size(445, 181)
        Me.PaymentPeriodsDataGridView.TabIndex = 6
        '
        'PeriodDataGridViewTextBoxColumn
        '
        Me.PeriodDataGridViewTextBoxColumn.DataPropertyName = "Period"
        Me.PeriodDataGridViewTextBoxColumn.HeaderText = "Period"
        Me.PeriodDataGridViewTextBoxColumn.Name = "PeriodDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'CurrentDataGridViewCheckBoxColumn
        '
        Me.CurrentDataGridViewCheckBoxColumn.DataPropertyName = "Current"
        Me.CurrentDataGridViewCheckBoxColumn.HeaderText = "Current"
        Me.CurrentDataGridViewCheckBoxColumn.Name = "CurrentDataGridViewCheckBoxColumn"
        '
        'PaymentPeriodsBindingSource
        '
        Me.PaymentPeriodsBindingSource.DataMember = "PaymentPeriods"
        Me.PaymentPeriodsBindingSource.DataSource = Me.DsSchoolParameters
        '
        'BindingNavigator6
        '
        Me.BindingNavigator6.AddNewItem = Me.AddNew6
        Me.BindingNavigator6.BindingSource = Me.PaymentPeriodsBindingSource
        Me.BindingNavigator6.CountItem = Me.ToolStripLabel2
        Me.BindingNavigator6.DeleteItem = Me.ToolStripButton13
        Me.BindingNavigator6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton14, Me.ToolStripButton15, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton16, Me.ToolStripButton17, Me.ToolStripSeparator6, Me.AddNew6, Me.ToolStripButton13, Me.ToolStripButton18})
        Me.BindingNavigator6.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator6.MoveFirstItem = Me.ToolStripButton14
        Me.BindingNavigator6.MoveLastItem = Me.ToolStripButton17
        Me.BindingNavigator6.MoveNextItem = Me.ToolStripButton16
        Me.BindingNavigator6.MovePreviousItem = Me.ToolStripButton15
        Me.BindingNavigator6.Name = "BindingNavigator6"
        Me.BindingNavigator6.PositionItem = Me.ToolStripTextBox2
        Me.BindingNavigator6.Size = New System.Drawing.Size(654, 25)
        Me.BindingNavigator6.TabIndex = 6
        Me.BindingNavigator6.Text = "BindingNavigator6"
        '
        'AddNew6
        '
        Me.AddNew6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddNew6.Image = CType(resources.GetObject("AddNew6.Image"), System.Drawing.Image)
        Me.AddNew6.Name = "AddNew6"
        Me.AddNew6.RightToLeftAutoMirrorImage = True
        Me.AddNew6.Size = New System.Drawing.Size(23, 22)
        Me.AddNew6.Text = "Add new"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "Delete"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "Move first"
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
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton16.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton16.Text = "Move next"
        '
        'ToolStripButton17
        '
        Me.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"), System.Drawing.Image)
        Me.ToolStripButton17.Name = "ToolStripButton17"
        Me.ToolStripButton17.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton17.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton17.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton18
        '
        Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton18.Text = "Save Data"
        '
        'tbPayCart
        '
        Me.tbPayCart.Controls.Add(Me.GroupBox21)
        Me.tbPayCart.Location = New System.Drawing.Point(4, 22)
        Me.tbPayCart.Name = "tbPayCart"
        Me.tbPayCart.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPayCart.Size = New System.Drawing.Size(910, 383)
        Me.tbPayCart.TabIndex = 1
        Me.tbPayCart.Text = "PaymentCartegories"
        Me.tbPayCart.UseVisualStyleBackColor = True
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.BindingNavigator9)
        Me.GroupBox21.Controls.Add(Me.PaymentTypeDataGridView)
        Me.GroupBox21.Location = New System.Drawing.Point(138, 28)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(634, 282)
        Me.GroupBox21.TabIndex = 0
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Payment Cartegories"
        '
        'BindingNavigator9
        '
        Me.BindingNavigator9.AddNewItem = Me.AddNew9
        Me.BindingNavigator9.BindingSource = Me.PaymentTypeBindingSource
        Me.BindingNavigator9.CountItem = Me.ToolStripLabel5
        Me.BindingNavigator9.DeleteItem = Me.ToolStripButton34
        Me.BindingNavigator9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton35, Me.ToolStripButton36, Me.ToolStripSeparator13, Me.ToolStripTextBox5, Me.ToolStripLabel5, Me.ToolStripSeparator14, Me.ToolStripButton37, Me.ToolStripButton38, Me.ToolStripSeparator15, Me.AddNew9, Me.ToolStripButton34, Me.ToolStripButton39})
        Me.BindingNavigator9.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator9.MoveFirstItem = Me.ToolStripButton35
        Me.BindingNavigator9.MoveLastItem = Me.ToolStripButton38
        Me.BindingNavigator9.MoveNextItem = Me.ToolStripButton37
        Me.BindingNavigator9.MovePreviousItem = Me.ToolStripButton36
        Me.BindingNavigator9.Name = "BindingNavigator9"
        Me.BindingNavigator9.PositionItem = Me.ToolStripTextBox5
        Me.BindingNavigator9.Size = New System.Drawing.Size(628, 25)
        Me.BindingNavigator9.TabIndex = 11
        Me.BindingNavigator9.Text = "BindingNavigator9"
        '
        'AddNew9
        '
        Me.AddNew9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddNew9.Image = CType(resources.GetObject("AddNew9.Image"), System.Drawing.Image)
        Me.AddNew9.Name = "AddNew9"
        Me.AddNew9.RightToLeftAutoMirrorImage = True
        Me.AddNew9.Size = New System.Drawing.Size(23, 22)
        Me.AddNew9.Text = "Add new"
        '
        'PaymentTypeBindingSource
        '
        Me.PaymentTypeBindingSource.DataMember = "PaymentType"
        Me.PaymentTypeBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel5.Text = "of {0}"
        Me.ToolStripLabel5.ToolTipText = "Total number of items"
        '
        'ToolStripButton34
        '
        Me.ToolStripButton34.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton34.Image = CType(resources.GetObject("ToolStripButton34.Image"), System.Drawing.Image)
        Me.ToolStripButton34.Name = "ToolStripButton34"
        Me.ToolStripButton34.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton34.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton34.Text = "Delete"
        '
        'ToolStripButton35
        '
        Me.ToolStripButton35.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton35.Image = CType(resources.GetObject("ToolStripButton35.Image"), System.Drawing.Image)
        Me.ToolStripButton35.Name = "ToolStripButton35"
        Me.ToolStripButton35.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton35.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton35.Text = "Move first"
        '
        'ToolStripButton36
        '
        Me.ToolStripButton36.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton36.Image = CType(resources.GetObject("ToolStripButton36.Image"), System.Drawing.Image)
        Me.ToolStripButton36.Name = "ToolStripButton36"
        Me.ToolStripButton36.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton36.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton36.Text = "Move previous"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.AccessibleName = "Position"
        Me.ToolStripTextBox5.AutoSize = False
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox5.Text = "0"
        Me.ToolStripTextBox5.ToolTipText = "Current position"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton37
        '
        Me.ToolStripButton37.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton37.Image = CType(resources.GetObject("ToolStripButton37.Image"), System.Drawing.Image)
        Me.ToolStripButton37.Name = "ToolStripButton37"
        Me.ToolStripButton37.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton37.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton37.Text = "Move next"
        '
        'ToolStripButton38
        '
        Me.ToolStripButton38.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton38.Image = CType(resources.GetObject("ToolStripButton38.Image"), System.Drawing.Image)
        Me.ToolStripButton38.Name = "ToolStripButton38"
        Me.ToolStripButton38.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton38.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton38.Text = "Move last"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton39
        '
        Me.ToolStripButton39.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton39.Image = CType(resources.GetObject("ToolStripButton39.Image"), System.Drawing.Image)
        Me.ToolStripButton39.Name = "ToolStripButton39"
        Me.ToolStripButton39.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton39.Text = "Save Data"
        '
        'PaymentTypeDataGridView
        '
        Me.PaymentTypeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PaymentTypeDataGridView.AutoGenerateColumns = False
        Me.PaymentTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn1, Me.AmountDataGridViewTextBoxColumn})
        Me.PaymentTypeDataGridView.DataSource = Me.PaymentTypeBindingSource
        Me.PaymentTypeDataGridView.Location = New System.Drawing.Point(69, 76)
        Me.PaymentTypeDataGridView.Name = "PaymentTypeDataGridView"
        Me.PaymentTypeDataGridView.Size = New System.Drawing.Size(496, 174)
        Me.PaymentTypeDataGridView.TabIndex = 10
        '
        'PaymentDataGridViewTextBoxColumn
        '
        Me.PaymentDataGridViewTextBoxColumn.DataPropertyName = "Payment"
        Me.PaymentDataGridViewTextBoxColumn.HeaderText = "Payment"
        Me.PaymentDataGridViewTextBoxColumn.Name = "PaymentDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn1
        '
        Me.TypeDataGridViewTextBoxColumn1.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn1.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn1.Items.AddRange(New Object() {"SchoolFees", "Ancillary"})
        Me.TypeDataGridViewTextBoxColumn1.Name = "TypeDataGridViewTextBoxColumn1"
        Me.TypeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TypeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'tbPAyMethods
        '
        Me.tbPAyMethods.Controls.Add(Me.GroupBox22)
        Me.tbPAyMethods.Location = New System.Drawing.Point(4, 22)
        Me.tbPAyMethods.Name = "tbPAyMethods"
        Me.tbPAyMethods.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPAyMethods.Size = New System.Drawing.Size(910, 383)
        Me.tbPAyMethods.TabIndex = 2
        Me.tbPAyMethods.Text = "PaymentMethods"
        Me.tbPAyMethods.UseVisualStyleBackColor = True
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.BindingNavigator10)
        Me.GroupBox22.Controls.Add(Me.DataGridView1)
        Me.GroupBox22.Location = New System.Drawing.Point(191, 57)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(580, 252)
        Me.GroupBox22.TabIndex = 0
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "PaymentMethods"
        '
        'BindingNavigator10
        '
        Me.BindingNavigator10.AddNewItem = Me.AddNew10
        Me.BindingNavigator10.BindingSource = Me.CashtypeBindingSource
        Me.BindingNavigator10.CountItem = Me.ToolStripLabel6
        Me.BindingNavigator10.DeleteItem = Me.ToolStripButton41
        Me.BindingNavigator10.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton42, Me.ToolStripButton43, Me.ToolStripSeparator16, Me.ToolStripTextBox6, Me.ToolStripLabel6, Me.ToolStripSeparator17, Me.ToolStripButton44, Me.ToolStripButton45, Me.ToolStripSeparator18, Me.AddNew10, Me.ToolStripButton41, Me.ToolStripButton46})
        Me.BindingNavigator10.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator10.MoveFirstItem = Me.ToolStripButton42
        Me.BindingNavigator10.MoveLastItem = Me.ToolStripButton45
        Me.BindingNavigator10.MoveNextItem = Me.ToolStripButton44
        Me.BindingNavigator10.MovePreviousItem = Me.ToolStripButton43
        Me.BindingNavigator10.Name = "BindingNavigator10"
        Me.BindingNavigator10.PositionItem = Me.ToolStripTextBox6
        Me.BindingNavigator10.Size = New System.Drawing.Size(574, 25)
        Me.BindingNavigator10.TabIndex = 13
        Me.BindingNavigator10.Text = "BindingNavigator10"
        '
        'AddNew10
        '
        Me.AddNew10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddNew10.Image = CType(resources.GetObject("AddNew10.Image"), System.Drawing.Image)
        Me.AddNew10.Name = "AddNew10"
        Me.AddNew10.RightToLeftAutoMirrorImage = True
        Me.AddNew10.Size = New System.Drawing.Size(23, 22)
        Me.AddNew10.Text = "Add new"
        '
        'CashtypeBindingSource
        '
        Me.CashtypeBindingSource.DataMember = "Cashtype"
        Me.CashtypeBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel6.Text = "of {0}"
        Me.ToolStripLabel6.ToolTipText = "Total number of items"
        '
        'ToolStripButton41
        '
        Me.ToolStripButton41.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton41.Image = CType(resources.GetObject("ToolStripButton41.Image"), System.Drawing.Image)
        Me.ToolStripButton41.Name = "ToolStripButton41"
        Me.ToolStripButton41.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton41.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton41.Text = "Delete"
        '
        'ToolStripButton42
        '
        Me.ToolStripButton42.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton42.Image = CType(resources.GetObject("ToolStripButton42.Image"), System.Drawing.Image)
        Me.ToolStripButton42.Name = "ToolStripButton42"
        Me.ToolStripButton42.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton42.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton42.Text = "Move first"
        '
        'ToolStripButton43
        '
        Me.ToolStripButton43.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton43.Image = CType(resources.GetObject("ToolStripButton43.Image"), System.Drawing.Image)
        Me.ToolStripButton43.Name = "ToolStripButton43"
        Me.ToolStripButton43.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton43.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton43.Text = "Move previous"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox6
        '
        Me.ToolStripTextBox6.AccessibleName = "Position"
        Me.ToolStripTextBox6.AutoSize = False
        Me.ToolStripTextBox6.Name = "ToolStripTextBox6"
        Me.ToolStripTextBox6.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox6.Text = "0"
        Me.ToolStripTextBox6.ToolTipText = "Current position"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton44
        '
        Me.ToolStripButton44.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton44.Image = CType(resources.GetObject("ToolStripButton44.Image"), System.Drawing.Image)
        Me.ToolStripButton44.Name = "ToolStripButton44"
        Me.ToolStripButton44.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton44.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton44.Text = "Move next"
        '
        'ToolStripButton45
        '
        Me.ToolStripButton45.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton45.Image = CType(resources.GetObject("ToolStripButton45.Image"), System.Drawing.Image)
        Me.ToolStripButton45.Name = "ToolStripButton45"
        Me.ToolStripButton45.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton45.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton45.Text = "Move last"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton46
        '
        Me.ToolStripButton46.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton46.Image = CType(resources.GetObject("ToolStripButton46.Image"), System.Drawing.Image)
        Me.ToolStripButton46.Name = "ToolStripButton46"
        Me.ToolStripButton46.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton46.Text = "Save Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CashtypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CashtypeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(84, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(413, 165)
        Me.DataGridView1.TabIndex = 12
        '
        'CashtypeDataGridViewTextBoxColumn
        '
        Me.CashtypeDataGridViewTextBoxColumn.DataPropertyName = "Cashtype"
        Me.CashtypeDataGridViewTextBoxColumn.HeaderText = "Cashtype"
        Me.CashtypeDataGridViewTextBoxColumn.Name = "CashtypeDataGridViewTextBoxColumn"
        '
        'tbCurrencies
        '
        Me.tbCurrencies.Controls.Add(Me.GroupBox23)
        Me.tbCurrencies.Location = New System.Drawing.Point(4, 22)
        Me.tbCurrencies.Name = "tbCurrencies"
        Me.tbCurrencies.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCurrencies.Size = New System.Drawing.Size(910, 383)
        Me.tbCurrencies.TabIndex = 3
        Me.tbCurrencies.Text = "Currency"
        Me.tbCurrencies.UseVisualStyleBackColor = True
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.BindingNavigator11)
        Me.GroupBox23.Controls.Add(Me.DataGridView3)
        Me.GroupBox23.Location = New System.Drawing.Point(165, 65)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(580, 252)
        Me.GroupBox23.TabIndex = 1
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "Currency"
        '
        'BindingNavigator11
        '
        Me.BindingNavigator11.AddNewItem = Me.ToolStripButton19
        Me.BindingNavigator11.BindingSource = Me.CurrenciesBindingSource
        Me.BindingNavigator11.CountItem = Me.ToolStripLabel7
        Me.BindingNavigator11.DeleteItem = Me.ToolStripButton26
        Me.BindingNavigator11.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton33, Me.ToolStripButton40, Me.ToolStripSeparator19, Me.ToolStripTextBox7, Me.ToolStripLabel7, Me.ToolStripSeparator20, Me.ToolStripButton68, Me.ToolStripButton69, Me.ToolStripSeparator21, Me.ToolStripButton19, Me.ToolStripButton26, Me.ToolStripButton70})
        Me.BindingNavigator11.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator11.MoveFirstItem = Me.ToolStripButton33
        Me.BindingNavigator11.MoveLastItem = Me.ToolStripButton69
        Me.BindingNavigator11.MoveNextItem = Me.ToolStripButton68
        Me.BindingNavigator11.MovePreviousItem = Me.ToolStripButton40
        Me.BindingNavigator11.Name = "BindingNavigator11"
        Me.BindingNavigator11.PositionItem = Me.ToolStripTextBox7
        Me.BindingNavigator11.Size = New System.Drawing.Size(574, 25)
        Me.BindingNavigator11.TabIndex = 13
        Me.BindingNavigator11.Text = "BindingNavigator11"
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"), System.Drawing.Image)
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton19.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton19.Text = "Add new"
        '
        'CurrenciesBindingSource
        '
        Me.CurrenciesBindingSource.DataMember = "Currencies"
        Me.CurrenciesBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel7.Text = "of {0}"
        Me.ToolStripLabel7.ToolTipText = "Total number of items"
        '
        'ToolStripButton26
        '
        Me.ToolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton26.Image = CType(resources.GetObject("ToolStripButton26.Image"), System.Drawing.Image)
        Me.ToolStripButton26.Name = "ToolStripButton26"
        Me.ToolStripButton26.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton26.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton26.Text = "Delete"
        '
        'ToolStripButton33
        '
        Me.ToolStripButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton33.Image = CType(resources.GetObject("ToolStripButton33.Image"), System.Drawing.Image)
        Me.ToolStripButton33.Name = "ToolStripButton33"
        Me.ToolStripButton33.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton33.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton33.Text = "Move first"
        '
        'ToolStripButton40
        '
        Me.ToolStripButton40.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton40.Image = CType(resources.GetObject("ToolStripButton40.Image"), System.Drawing.Image)
        Me.ToolStripButton40.Name = "ToolStripButton40"
        Me.ToolStripButton40.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton40.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton40.Text = "Move previous"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox7
        '
        Me.ToolStripTextBox7.AccessibleName = "Position"
        Me.ToolStripTextBox7.AutoSize = False
        Me.ToolStripTextBox7.Name = "ToolStripTextBox7"
        Me.ToolStripTextBox7.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox7.Text = "0"
        Me.ToolStripTextBox7.ToolTipText = "Current position"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton68
        '
        Me.ToolStripButton68.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton68.Image = CType(resources.GetObject("ToolStripButton68.Image"), System.Drawing.Image)
        Me.ToolStripButton68.Name = "ToolStripButton68"
        Me.ToolStripButton68.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton68.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton68.Text = "Move next"
        '
        'ToolStripButton69
        '
        Me.ToolStripButton69.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton69.Image = CType(resources.GetObject("ToolStripButton69.Image"), System.Drawing.Image)
        Me.ToolStripButton69.Name = "ToolStripButton69"
        Me.ToolStripButton69.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton69.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton69.Text = "Move last"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton70
        '
        Me.ToolStripButton70.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton70.Image = CType(resources.GetObject("ToolStripButton70.Image"), System.Drawing.Image)
        Me.ToolStripButton70.Name = "ToolStripButton70"
        Me.ToolStripButton70.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton70.Text = "Save Data"
        '
        'DataGridView3
        '
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CurrencyDataGridViewTextBoxColumn, Me.DesriptionDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.CurrenciesBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(84, 68)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(413, 165)
        Me.DataGridView3.TabIndex = 12
        '
        'CurrencyDataGridViewTextBoxColumn
        '
        Me.CurrencyDataGridViewTextBoxColumn.DataPropertyName = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn.HeaderText = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn.Name = "CurrencyDataGridViewTextBoxColumn"
        '
        'DesriptionDataGridViewTextBoxColumn
        '
        Me.DesriptionDataGridViewTextBoxColumn.DataPropertyName = "Desription"
        Me.DesriptionDataGridViewTextBoxColumn.HeaderText = "Desription"
        Me.DesriptionDataGridViewTextBoxColumn.Name = "DesriptionDataGridViewTextBoxColumn"
        Me.DesriptionDataGridViewTextBoxColumn.Width = 250
        '
        'tbExchangeRates
        '
        Me.tbExchangeRates.Controls.Add(Me.GroupBox24)
        Me.tbExchangeRates.Location = New System.Drawing.Point(4, 22)
        Me.tbExchangeRates.Name = "tbExchangeRates"
        Me.tbExchangeRates.Padding = New System.Windows.Forms.Padding(3)
        Me.tbExchangeRates.Size = New System.Drawing.Size(910, 383)
        Me.tbExchangeRates.TabIndex = 4
        Me.tbExchangeRates.Text = "ExchangRates"
        Me.tbExchangeRates.UseVisualStyleBackColor = True
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.Label23)
        Me.GroupBox24.Controls.Add(Me.mskExDateTo)
        Me.GroupBox24.Controls.Add(Me.Label11)
        Me.GroupBox24.Controls.Add(Me.mskExDateFrom)
        Me.GroupBox24.Controls.Add(Me.txtCurrToVal)
        Me.GroupBox24.Controls.Add(Me.txtCurrFromValue)
        Me.GroupBox24.Controls.Add(Me.Label22)
        Me.GroupBox24.Controls.Add(Me.cboCurrToCurr)
        Me.GroupBox24.Controls.Add(Me.Button4)
        Me.GroupBox24.Controls.Add(Me.btnAddExchangeRate)
        Me.GroupBox24.Controls.Add(Me.lvExchangeRate)
        Me.GroupBox24.Controls.Add(Me.Label27)
        Me.GroupBox24.Controls.Add(Me.cboCurrFromCurr)
        Me.GroupBox24.Location = New System.Drawing.Point(82, 3)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(746, 377)
        Me.GroupBox24.TabIndex = 2
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "ExchangeRates"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(499, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(23, 13)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "To:"
        '
        'mskExDateTo
        '
        Me.mskExDateTo.Location = New System.Drawing.Point(528, 76)
        Me.mskExDateTo.Mask = "00/00/0000"
        Me.mskExDateTo.Name = "mskExDateTo"
        Me.mskExDateTo.Size = New System.Drawing.Size(100, 20)
        Me.mskExDateTo.TabIndex = 25
        Me.mskExDateTo.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(331, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "DateFrom:"
        '
        'mskExDateFrom
        '
        Me.mskExDateFrom.Location = New System.Drawing.Point(393, 78)
        Me.mskExDateFrom.Mask = "00/00/0000"
        Me.mskExDateFrom.Name = "mskExDateFrom"
        Me.mskExDateFrom.Size = New System.Drawing.Size(100, 20)
        Me.mskExDateFrom.TabIndex = 23
        Me.mskExDateFrom.ValidatingType = GetType(Date)
        '
        'txtCurrToVal
        '
        Me.txtCurrToVal.Location = New System.Drawing.Point(214, 77)
        Me.txtCurrToVal.Name = "txtCurrToVal"
        Me.txtCurrToVal.Size = New System.Drawing.Size(36, 20)
        Me.txtCurrToVal.TabIndex = 22
        '
        'txtCurrFromValue
        '
        Me.txtCurrFromValue.Location = New System.Drawing.Point(81, 78)
        Me.txtCurrFromValue.Name = "txtCurrFromValue"
        Me.txtCurrFromValue.Size = New System.Drawing.Size(45, 20)
        Me.txtCurrFromValue.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(182, 81)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "To :"
        '
        'cboCurrToCurr
        '
        Me.cboCurrToCurr.DisplayMember = "Forms"
        Me.cboCurrToCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurrToCurr.FormattingEnabled = True
        Me.cboCurrToCurr.Location = New System.Drawing.Point(253, 76)
        Me.cboCurrToCurr.Name = "cboCurrToCurr"
        Me.cboCurrToCurr.Size = New System.Drawing.Size(69, 21)
        Me.cboCurrToCurr.TabIndex = 19
        Me.cboCurrToCurr.ValueMember = "Forms"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(295, 344)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnAddExchangeRate
        '
        Me.btnAddExchangeRate.Enabled = False
        Me.btnAddExchangeRate.Location = New System.Drawing.Point(634, 74)
        Me.btnAddExchangeRate.Name = "btnAddExchangeRate"
        Me.btnAddExchangeRate.Size = New System.Drawing.Size(75, 23)
        Me.btnAddExchangeRate.TabIndex = 9
        Me.btnAddExchangeRate.Text = "ADD"
        Me.btnAddExchangeRate.UseVisualStyleBackColor = True
        '
        'lvExchangeRate
        '
        Me.lvExchangeRate.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvExchangeRate.FullRowSelect = True
        Me.lvExchangeRate.GridLines = True
        Me.lvExchangeRate.HideSelection = False
        Me.lvExchangeRate.Location = New System.Drawing.Point(108, 111)
        Me.lvExchangeRate.MultiSelect = False
        Me.lvExchangeRate.Name = "lvExchangeRate"
        Me.lvExchangeRate.Size = New System.Drawing.Size(508, 227)
        Me.lvExchangeRate.TabIndex = 2
        Me.lvExchangeRate.UseCompatibleStateImageBehavior = False
        Me.lvExchangeRate.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CurrencyFrom"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CurrencyTo"
        Me.ColumnHeader4.Width = 78
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Rate"
        Me.ColumnHeader5.Width = 81
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DateFrom"
        Me.ColumnHeader6.Width = 131
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DateTo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 81)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(78, 13)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "CurrencyFrom :"
        '
        'cboCurrFromCurr
        '
        Me.cboCurrFromCurr.DisplayMember = "Forms"
        Me.cboCurrFromCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurrFromCurr.FormattingEnabled = True
        Me.cboCurrFromCurr.Location = New System.Drawing.Point(128, 78)
        Me.cboCurrFromCurr.Name = "cboCurrFromCurr"
        Me.cboCurrFromCurr.Size = New System.Drawing.Size(54, 21)
        Me.cboCurrFromCurr.TabIndex = 0
        Me.cboCurrFromCurr.ValueMember = "Forms"
        '
        'tbstaff
        '
        Me.tbstaff.Controls.Add(Me.TabControl5)
        Me.tbstaff.Location = New System.Drawing.Point(4, 22)
        Me.tbstaff.Name = "tbstaff"
        Me.tbstaff.Padding = New System.Windows.Forms.Padding(3)
        Me.tbstaff.Size = New System.Drawing.Size(944, 428)
        Me.tbstaff.TabIndex = 3
        Me.tbstaff.Text = "Staff"
        Me.tbstaff.UseVisualStyleBackColor = True
        '
        'TabControl5
        '
        Me.TabControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl5.Controls.Add(Me.tbStaffQual)
        Me.TabControl5.Location = New System.Drawing.Point(36, 14)
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.SelectedIndex = 0
        Me.TabControl5.Size = New System.Drawing.Size(892, 399)
        Me.TabControl5.TabIndex = 0
        '
        'tbStaffQual
        '
        Me.tbStaffQual.Controls.Add(Me.GroupBox12)
        Me.tbStaffQual.Location = New System.Drawing.Point(4, 22)
        Me.tbStaffQual.Name = "tbStaffQual"
        Me.tbStaffQual.Padding = New System.Windows.Forms.Padding(3)
        Me.tbStaffQual.Size = New System.Drawing.Size(884, 373)
        Me.tbStaffQual.TabIndex = 0
        Me.tbStaffQual.Text = "Qualifications"
        Me.tbStaffQual.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.BindingNavigator12)
        Me.GroupBox12.Controls.Add(Me.QualificationsDataGridView)
        Me.GroupBox12.Location = New System.Drawing.Point(227, 20)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(431, 333)
        Me.GroupBox12.TabIndex = 2
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Qualifications"
        '
        'BindingNavigator12
        '
        Me.BindingNavigator12.AddNewItem = Me.ToolStripButton47
        Me.BindingNavigator12.BindingSource = Me.QualificationsBindingSource
        Me.BindingNavigator12.CountItem = Me.ToolStripLabel8
        Me.BindingNavigator12.DeleteItem = Me.ToolStripButton48
        Me.BindingNavigator12.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton49, Me.ToolStripButton50, Me.ToolStripSeparator22, Me.ToolStripTextBox8, Me.ToolStripLabel8, Me.ToolStripSeparator23, Me.ToolStripButton51, Me.ToolStripButton52, Me.ToolStripSeparator24, Me.ToolStripButton47, Me.ToolStripButton48, Me.ToolStripButton53})
        Me.BindingNavigator12.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator12.MoveFirstItem = Me.ToolStripButton49
        Me.BindingNavigator12.MoveLastItem = Me.ToolStripButton52
        Me.BindingNavigator12.MoveNextItem = Me.ToolStripButton51
        Me.BindingNavigator12.MovePreviousItem = Me.ToolStripButton50
        Me.BindingNavigator12.Name = "BindingNavigator12"
        Me.BindingNavigator12.PositionItem = Me.ToolStripTextBox8
        Me.BindingNavigator12.Size = New System.Drawing.Size(425, 25)
        Me.BindingNavigator12.TabIndex = 8
        Me.BindingNavigator12.Text = "BindingNavigator12"
        '
        'ToolStripButton47
        '
        Me.ToolStripButton47.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton47.Image = CType(resources.GetObject("ToolStripButton47.Image"), System.Drawing.Image)
        Me.ToolStripButton47.Name = "ToolStripButton47"
        Me.ToolStripButton47.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton47.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton47.Text = "Add new"
        '
        'QualificationsBindingSource
        '
        Me.QualificationsBindingSource.DataMember = "Qualifications"
        Me.QualificationsBindingSource.DataSource = Me.DsSchoolParameters
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel8.Text = "of {0}"
        Me.ToolStripLabel8.ToolTipText = "Total number of items"
        '
        'ToolStripButton48
        '
        Me.ToolStripButton48.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton48.Image = CType(resources.GetObject("ToolStripButton48.Image"), System.Drawing.Image)
        Me.ToolStripButton48.Name = "ToolStripButton48"
        Me.ToolStripButton48.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton48.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton48.Text = "Delete"
        '
        'ToolStripButton49
        '
        Me.ToolStripButton49.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton49.Image = CType(resources.GetObject("ToolStripButton49.Image"), System.Drawing.Image)
        Me.ToolStripButton49.Name = "ToolStripButton49"
        Me.ToolStripButton49.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton49.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton49.Text = "Move first"
        '
        'ToolStripButton50
        '
        Me.ToolStripButton50.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton50.Image = CType(resources.GetObject("ToolStripButton50.Image"), System.Drawing.Image)
        Me.ToolStripButton50.Name = "ToolStripButton50"
        Me.ToolStripButton50.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton50.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton50.Text = "Move previous"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox8
        '
        Me.ToolStripTextBox8.AccessibleName = "Position"
        Me.ToolStripTextBox8.AutoSize = False
        Me.ToolStripTextBox8.Name = "ToolStripTextBox8"
        Me.ToolStripTextBox8.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox8.Text = "0"
        Me.ToolStripTextBox8.ToolTipText = "Current position"
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton51
        '
        Me.ToolStripButton51.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton51.Image = CType(resources.GetObject("ToolStripButton51.Image"), System.Drawing.Image)
        Me.ToolStripButton51.Name = "ToolStripButton51"
        Me.ToolStripButton51.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton51.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton51.Text = "Move next"
        '
        'ToolStripButton52
        '
        Me.ToolStripButton52.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton52.Image = CType(resources.GetObject("ToolStripButton52.Image"), System.Drawing.Image)
        Me.ToolStripButton52.Name = "ToolStripButton52"
        Me.ToolStripButton52.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton52.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton52.Text = "Move last"
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton53
        '
        Me.ToolStripButton53.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton53.Image = CType(resources.GetObject("ToolStripButton53.Image"), System.Drawing.Image)
        Me.ToolStripButton53.Name = "ToolStripButton53"
        Me.ToolStripButton53.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton53.Text = "Save Data"
        '
        'QualificationsDataGridView
        '
        Me.QualificationsDataGridView.AutoGenerateColumns = False
        Me.QualificationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QualificationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QualificationDataGridViewTextBoxColumn})
        Me.QualificationsDataGridView.DataSource = Me.QualificationsBindingSource
        Me.QualificationsDataGridView.Location = New System.Drawing.Point(65, 63)
        Me.QualificationsDataGridView.Name = "QualificationsDataGridView"
        Me.QualificationsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.QualificationsDataGridView.TabIndex = 0
        '
        'QualificationDataGridViewTextBoxColumn
        '
        Me.QualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.HeaderText = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.Name = "QualificationDataGridViewTextBoxColumn"
        '
        'SchoolinfoTableAdapter
        '
        Me.SchoolinfoTableAdapter.ClearBeforeFill = True
        '
        'FormsTableAdapter
        '
        Me.FormsTableAdapter.ClearBeforeFill = True
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'SMSAccTableAdapter
        '
        Me.SMSAccTableAdapter.ClearBeforeFill = True
        '
        'SchoolsessionsTableAdapter
        '
        Me.SchoolsessionsTableAdapter.ClearBeforeFill = True
        '
        'DepsTableAdapter
        '
        Me.DepsTableAdapter.ClearBeforeFill = True
        '
        'SchoolSectionsTableAdapter
        '
        Me.SchoolSectionsTableAdapter.ClearBeforeFill = True
        '
        'SmtpTableAdapter
        '
        Me.SmtpTableAdapter.ClearBeforeFill = True
        '
        'SemesterDurationsTableAdapter
        '
        Me.SemesterDurationsTableAdapter.ClearBeforeFill = True
        '
        'ExamSessionsTableAdapter
        '
        Me.ExamSessionsTableAdapter.ClearBeforeFill = True
        '
        'MarkWeightingTableAdapter
        '
        Me.MarkWeightingTableAdapter.ClearBeforeFill = True
        '
        'PaymentPeriodsTableAdapter
        '
        Me.PaymentPeriodsTableAdapter.ClearBeforeFill = True
        '
        'PaymentTypeTableAdapter
        '
        Me.PaymentTypeTableAdapter.ClearBeforeFill = True
        '
        'CashtypeTableAdapter
        '
        Me.CashtypeTableAdapter.ClearBeforeFill = True
        '
        'QualificationsTableAdapter
        '
        Me.QualificationsTableAdapter.ClearBeforeFill = True
        '
        'CurrenciesTableAdapter
        '
        Me.CurrenciesTableAdapter.ClearBeforeFill = True
        '
        'frmSchoolParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 526)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSchoolParameters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSchoolParameters"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SchoolinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSchoolParameters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SchoolInfoBindingNavigator.ResumeLayout(False)
        Me.SchoolInfoBindingNavigator.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FormsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.tbClasses.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator18.ResumeLayout(False)
        Me.BindingNavigator18.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator4.ResumeLayout(False)
        Me.BindingNavigator4.PerformLayout()
        CType(Me.SMSAccBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.BindingNavigator8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator8.ResumeLayout(False)
        Me.BindingNavigator8.PerformLayout()
        CType(Me.SchoolsessionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolsessionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage13.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.BindingNavigator13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator13.ResumeLayout(False)
        Me.BindingNavigator13.PerformLayout()
        CType(Me.DepsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage14.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.BindingNavigator14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator14.ResumeLayout(False)
        Me.BindingNavigator14.PerformLayout()
        CType(Me.SchoolSectionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage18.ResumeLayout(False)
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        CType(Me.BindingNavigator17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator17.ResumeLayout(False)
        Me.BindingNavigator17.PerformLayout()
        CType(Me.SmtpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator5.ResumeLayout(False)
        Me.BindingNavigator5.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.tbGeneral.ResumeLayout(False)
        Me.tbExams.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.tbTermDuration.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SemesterDurationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.tbProgramSubjects.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tbExamSessions.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        CType(Me.ExamSessionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator7.ResumeLayout(False)
        Me.BindingNavigator7.PerformLayout()
        Me.tbExamGrading.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.tbMarkWeights.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        CType(Me.BindingNavigator16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator16.ResumeLayout(False)
        Me.BindingNavigator16.PerformLayout()
        CType(Me.MarkWeightingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarkWeightingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbFess.ResumeLayout(False)
        Me.TabControl4.ResumeLayout(False)
        Me.tbPaymentPeriods.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.PaymentPeriodsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentPeriodsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator6.ResumeLayout(False)
        Me.BindingNavigator6.PerformLayout()
        Me.tbPayCart.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        CType(Me.BindingNavigator9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator9.ResumeLayout(False)
        Me.BindingNavigator9.PerformLayout()
        CType(Me.PaymentTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbPAyMethods.ResumeLayout(False)
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        CType(Me.BindingNavigator10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator10.ResumeLayout(False)
        Me.BindingNavigator10.PerformLayout()
        CType(Me.CashtypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCurrencies.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        CType(Me.BindingNavigator11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator11.ResumeLayout(False)
        Me.BindingNavigator11.PerformLayout()
        CType(Me.CurrenciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbExchangeRates.ResumeLayout(False)
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox24.PerformLayout()
        Me.tbstaff.ResumeLayout(False)
        Me.TabControl5.ResumeLayout(False)
        Me.tbStaffQual.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.BindingNavigator12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator12.ResumeLayout(False)
        Me.BindingNavigator12.PerformLayout()
        CType(Me.QualificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualificationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BindingNavigator3 As System.Windows.Forms.BindingNavigator
    Friend WithEvents AddNew3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents SubjectIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator4 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents Add As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FormsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SemestersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SectionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CreditsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator5 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AutoStudIDCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SchoolInfoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents SchoolInfoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudIdLengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents SchoolsessionsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator8 As System.Windows.Forms.BindingNavigator
    Friend WithEvents AddNew8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton27 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton28 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton29 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton30 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton31 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton32 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudIdPrefixTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProgSufixTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FeesTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage13 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage14 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator14 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton61 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel10 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton62 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton63 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton64 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator28 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox10 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator29 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton65 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton66 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator30 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton67 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigator13 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton54 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel9 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton55 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton56 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton57 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator25 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox9 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator26 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton58 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton59 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator27 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton60 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DepsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton75 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage18 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator17 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton83 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel13 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton84 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton85 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton86 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator37 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox13 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator38 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton87 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton88 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator39 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton89 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ServerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MailfromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cboIdYearFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbClasses As Windows.Forms.TabPage
    Friend WithEvents GroupBox19 As Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator18 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton90 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel14 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton92 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton93 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator40 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox14 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator41 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton94 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton95 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator42 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton96 As Windows.Forms.ToolStripButton
    Friend WithEvents DescriptionTextBox1 As Windows.Forms.TextBox
    Friend WithEvents ClasComboBox As Windows.Forms.ComboBox
    Friend WithEvents SemComboBox As Windows.Forms.ComboBox
    Friend WithEvents IntakeComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents RefTextBox As Windows.Forms.TextBox
    Friend WithEvents ToolStripButton91 As Windows.Forms.ToolStripButton
    Friend WithEvents TabControl2 As Windows.Forms.TabControl
    Friend WithEvents tbGeneral As Windows.Forms.TabPage
    Friend WithEvents tbExams As Windows.Forms.TabPage
    Friend WithEvents TabControl3 As Windows.Forms.TabControl
    Friend WithEvents tbTermDuration As Windows.Forms.TabPage
    Friend WithEvents GroupBox10 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents ClassComboBox As Windows.Forms.ComboBox
    Friend WithEvents ProgramComboBox As Windows.Forms.ComboBox
    Friend WithEvents BindingNavigator2 As Windows.Forms.BindingNavigator
    Friend WithEvents AddNew As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem2 As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As Windows.Forms.ToolStripSeparator
    Friend WithEvents SemSave As Windows.Forms.ToolStripButton
    Friend WithEvents tbProgramSubjects As Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents chkPrograms As Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents tbExamSessions As Windows.Forms.TabPage
    Friend WithEvents GroupBox20 As Windows.Forms.GroupBox
    Friend WithEvents SessionTextBox As Windows.Forms.TextBox
    Friend WithEvents ExamClassRefComboBox As Windows.Forms.ComboBox
    Friend WithEvents SittingTextBox As Windows.Forms.TextBox
    Friend WithEvents RefTextBox1 As Windows.Forms.TextBox
    Friend WithEvents PublishCheckBox As Windows.Forms.CheckBox
    Friend WithEvents AutoCommentCheckBox As Windows.Forms.CheckBox
    Friend WithEvents BindingNavigator7 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton20 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton21 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton22 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator8 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton23 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton24 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton25 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton97 As Windows.Forms.ToolStripButton
    Friend WithEvents tbExamGrading As Windows.Forms.TabPage
    Friend WithEvents GroupBox15 As Windows.Forms.GroupBox
    Friend WithEvents chkAllSessions As Windows.Forms.CheckBox
    Friend WithEvents cboGradeSession As Windows.Forms.ComboBox
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents txtGradingCredits As Windows.Forms.TextBox
    Friend WithEvents Button5 As Windows.Forms.Button
    Friend WithEvents btnAddGrade As Windows.Forms.Button
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents TxtGradingGrade As Windows.Forms.TextBox
    Friend WithEvents txtGradingUpperLimit As Windows.Forms.TextBox
    Friend WithEvents txtGradingLowerLimit As Windows.Forms.TextBox
    Friend WithEvents lvExmGrd As Windows.Forms.ListView
    Friend WithEvents Grade As Windows.Forms.ColumnHeader
    Friend WithEvents Lower As Windows.Forms.ColumnHeader
    Friend WithEvents Upper As Windows.Forms.ColumnHeader
    Friend WithEvents Credits As Windows.Forms.ColumnHeader
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents cbGradingProg As Windows.Forms.ComboBox
    Friend WithEvents tbMarkWeights As Windows.Forms.TabPage
    Friend WithEvents GroupBox17 As Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator16 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton76 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel12 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton77 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton78 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton79 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator34 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox12 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator35 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton80 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton81 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator36 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton82 As Windows.Forms.ToolStripButton
    Friend WithEvents MarkWeightingDataGridView As Windows.Forms.DataGridView
    Friend WithEvents tbFess As Windows.Forms.TabPage
    Friend WithEvents TabControl4 As Windows.Forms.TabControl
    Friend WithEvents tbPaymentPeriods As Windows.Forms.TabPage
    Friend WithEvents GroupBox8 As Windows.Forms.GroupBox
    Friend WithEvents PaymentPeriodsDataGridView As Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator6 As Windows.Forms.BindingNavigator
    Friend WithEvents AddNew6 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton13 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton14 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton15 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton16 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton17 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton18 As Windows.Forms.ToolStripButton
    Friend WithEvents tbPayCart As Windows.Forms.TabPage
    Friend WithEvents GroupBox21 As Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator9 As Windows.Forms.BindingNavigator
    Friend WithEvents AddNew9 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel5 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton34 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton35 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton36 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox5 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator14 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton37 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton38 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton39 As Windows.Forms.ToolStripButton
    Friend WithEvents PaymentTypeDataGridView As Windows.Forms.DataGridView
    Friend WithEvents tbPAyMethods As Windows.Forms.TabPage
    Friend WithEvents GroupBox22 As Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator10 As Windows.Forms.BindingNavigator
    Friend WithEvents AddNew10 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel6 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton41 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton42 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton43 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox6 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator17 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton44 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton45 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator18 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton46 As Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents tbstaff As Windows.Forms.TabPage
    Friend WithEvents TabControl5 As Windows.Forms.TabControl
    Friend WithEvents tbStaffQual As Windows.Forms.TabPage
    Friend WithEvents GroupBox12 As Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator12 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton47 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel8 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton48 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton49 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton50 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator22 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox8 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator23 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton51 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton52 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator24 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton53 As Windows.Forms.ToolStripButton
    Friend WithEvents QualificationsDataGridView As Windows.Forms.DataGridView
    Friend WithEvents DsSchoolParameters As dsSchoolParameters
    Friend WithEvents SchoolinfoTableAdapter As dsSchoolParametersTableAdapters.schoolinfoTableAdapter
    Friend WithEvents ToolStripButton1 As Windows.Forms.ToolStripButton
    Friend WithEvents txtschoolref As Windows.Forms.TextBox
    Friend WithEvents FormsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents FormsTableAdapter As dsSchoolParametersTableAdapters.formsTableAdapter
    Friend WithEvents txtProgRef As Windows.Forms.TextBox
    Friend WithEvents ToolStripButton2 As Windows.Forms.ToolStripButton
    Friend WithEvents ClassesBindingSource As Windows.Forms.BindingSource
    Friend WithEvents ClassesTableAdapter As dsSchoolParametersTableAdapters.ClassesTableAdapter
    Friend WithEvents txtProgSearch As Windows.Forms.TextBox
    Friend WithEvents btnProgSearch As Windows.Forms.Button
    Friend WithEvents GroupBox11 As Windows.Forms.GroupBox
    Friend WithEvents btnClassSearch As Windows.Forms.Button
    Friend WithEvents txtClassSearch As Windows.Forms.TextBox
    Friend WithEvents Label21 As Windows.Forms.Label
    Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
    Friend WithEvents btnSubjectSearch As Windows.Forms.Button
    Friend WithEvents txtSubjectSearch As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents SubjectsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As dsSchoolParametersTableAdapters.SubjectsTableAdapter
    Friend WithEvents txtSubref As Windows.Forms.TextBox
    Friend WithEvents SMSAccBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SMSAccTableAdapter As dsSchoolParametersTableAdapters.SMSAccTableAdapter
    Friend WithEvents SchoolsessionsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SchoolsessionsTableAdapter As dsSchoolParametersTableAdapters.schoolsessionsTableAdapter
    Friend WithEvents DepsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents DepsTableAdapter As dsSchoolParametersTableAdapters.DepsTableAdapter
    Friend WithEvents SchoolSectionsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SchoolSectionsTableAdapter As dsSchoolParametersTableAdapters.SchoolSectionsTableAdapter
    Friend WithEvents SmtpBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SmtpTableAdapter As dsSchoolParametersTableAdapters.smtpTableAdapter
    Friend WithEvents msksemEndDate As Windows.Forms.MaskedTextBox
    Friend WithEvents mskSemStartDate As Windows.Forms.MaskedTextBox
    Friend WithEvents txtSemDurRef As Windows.Forms.TextBox
    Friend WithEvents SemesterDurationsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents SemesterDurationsTableAdapter As dsSchoolParametersTableAdapters.SemesterDurationsTableAdapter
    Friend WithEvents ToolStripButton12 As Windows.Forms.ToolStripButton
    Friend WithEvents btnTermDurationSearch As Windows.Forms.Button
    Friend WithEvents ExamSessionsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents ExamSessionsTableAdapter As dsSchoolParametersTableAdapters.ExamSessionsTableAdapter
    Friend WithEvents GroupBox16 As Windows.Forms.GroupBox
    Friend WithEvents btnExamSearch As Windows.Forms.Button
    Friend WithEvents txtExamSearch As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents MarkWeightingBindingSource As Windows.Forms.BindingSource
    Friend WithEvents MarkWeightingTableAdapter As dsSchoolParametersTableAdapters.MarkWeightingTableAdapter
    Friend WithEvents SessionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentPeriodsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents PaymentPeriodsTableAdapter As dsSchoolParametersTableAdapters.PaymentPeriodsTableAdapter
    Friend WithEvents PeriodDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PaymentTypeBindingSource As Windows.Forms.BindingSource
    Friend WithEvents PaymentTypeTableAdapter As dsSchoolParametersTableAdapters.PaymentTypeTableAdapter
    Friend WithEvents CashtypeBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CashtypeTableAdapter As dsSchoolParametersTableAdapters.CashtypeTableAdapter
    Friend WithEvents CashtypeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QualificationsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents QualificationsTableAdapter As dsSchoolParametersTableAdapters.QualificationsTableAdapter
    Friend WithEvents QualificationDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolinfoBindingSource As Windows.Forms.BindingSource
    Friend WithEvents lbprograms As Windows.Forms.ListBox
    Friend WithEvents lbClasses As Windows.Forms.ListBox
    Friend WithEvents lbSubjects As Windows.Forms.ListBox
    Friend WithEvents txtTermDurationsSearch As Windows.Forms.TextBox
    Friend WithEvents lbTermDurations As Windows.Forms.ListBox
    Friend WithEvents lbExamSearch As Windows.Forms.ListBox
    Friend WithEvents tbCurrencies As Windows.Forms.TabPage
    Friend WithEvents GroupBox23 As Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator11 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton19 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel7 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton26 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton33 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton40 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator19 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox7 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator20 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton68 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton69 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator21 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton70 As Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView3 As Windows.Forms.DataGridView
    Friend WithEvents CurrenciesBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CurrenciesTableAdapter As dsSchoolParametersTableAdapters.CurrenciesTableAdapter
    Friend WithEvents CurrencyDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesriptionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboBaseCurrency As Windows.Forms.ComboBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents tbExchangeRates As Windows.Forms.TabPage
    Friend WithEvents GroupBox24 As Windows.Forms.GroupBox
    Friend WithEvents Label23 As Windows.Forms.Label
    Friend WithEvents mskExDateTo As Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents mskExDateFrom As Windows.Forms.MaskedTextBox
    Friend WithEvents txtCurrToVal As Windows.Forms.TextBox
    Friend WithEvents txtCurrFromValue As Windows.Forms.TextBox
    Friend WithEvents Label22 As Windows.Forms.Label
    Friend WithEvents cboCurrToCurr As Windows.Forms.ComboBox
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents btnAddExchangeRate As Windows.Forms.Button
    Friend WithEvents lvExchangeRate As Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As Windows.Forms.ColumnHeader
    Friend WithEvents Label27 As Windows.Forms.Label
    Friend WithEvents cboCurrFromCurr As Windows.Forms.ComboBox
    Friend WithEvents PaymentDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Section As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents type As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboExamParentExam As Windows.Forms.ComboBox
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportOrder As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkMultipleAutoComments As Windows.Forms.CheckBox
    Friend WithEvents txtgradeRef As Windows.Forms.TextBox
    Friend WithEvents Ref As Windows.Forms.ColumnHeader
End Class
