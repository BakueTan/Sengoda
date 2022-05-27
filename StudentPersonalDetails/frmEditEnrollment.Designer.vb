<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditEnrollment
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
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim ProgramLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim Date_JoinedLabel As System.Windows.Forms.Label
        Dim SessionLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Date_EnrolledLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditEnrollment))
        Me.EnrollmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.LoadEnrollmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSchool = New StudentDetails.dsSchool()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnrollmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDelete = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EnrolTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.EnrolRefTextBox = New System.Windows.Forms.TextBox()
        Me.Date_EnrolledDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.ProgramComboBox = New System.Windows.Forms.ComboBox()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.SessionComboBox = New System.Windows.Forms.ComboBox()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.LoadEnrollmentsTableAdapter = New StudentDetails.dsSchoolTableAdapters.LoadEnrollmentsTableAdapter()
        Me.txtStudSearch = New System.Windows.Forms.TextBox()
        StudentIDLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        ProgramLabel = New System.Windows.Forms.Label()
        YearLabel = New System.Windows.Forms.Label()
        Date_JoinedLabel = New System.Windows.Forms.Label()
        SessionLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Date_EnrolledLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.EnrollmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EnrollmentBindingNavigator.SuspendLayout()
        CType(Me.LoadEnrollmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(55, 37)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(61, 13)
        StudentIDLabel.TabIndex = 0
        StudentIDLabel.Text = "Student ID:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(55, 63)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 2
        GenderLabel.Text = "Gender:"
        '
        'ProgramLabel
        '
        ProgramLabel.AutoSize = True
        ProgramLabel.Location = New System.Drawing.Point(55, 90)
        ProgramLabel.Name = "ProgramLabel"
        ProgramLabel.Size = New System.Drawing.Size(49, 13)
        ProgramLabel.TabIndex = 4
        ProgramLabel.Text = "Program:"
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.Location = New System.Drawing.Point(55, 117)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(36, 13)
        YearLabel.TabIndex = 6
        YearLabel.Text = "Level:"
        '
        'Date_JoinedLabel
        '
        Date_JoinedLabel.AutoSize = True
        Date_JoinedLabel.Location = New System.Drawing.Point(55, 171)
        Date_JoinedLabel.Name = "Date_JoinedLabel"
        Date_JoinedLabel.Size = New System.Drawing.Size(35, 13)
        Date_JoinedLabel.TabIndex = 10
        Date_JoinedLabel.Text = "Class:"
        '
        'SessionLabel
        '
        SessionLabel.AutoSize = True
        SessionLabel.Location = New System.Drawing.Point(55, 143)
        SessionLabel.Name = "SessionLabel"
        SessionLabel.Size = New System.Drawing.Size(47, 13)
        SessionLabel.TabIndex = 12
        SessionLabel.Text = "Session:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(55, 198)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 16
        StatusLabel.Text = "Status:"
        '
        'Date_EnrolledLabel
        '
        Date_EnrolledLabel.AutoSize = True
        Date_EnrolledLabel.Location = New System.Drawing.Point(55, 251)
        Date_EnrolledLabel.Name = "Date_EnrolledLabel"
        Date_EnrolledLabel.Size = New System.Drawing.Size(74, 13)
        Date_EnrolledLabel.TabIndex = 18
        Date_EnrolledLabel.Text = "Date Enrolled:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(55, 222)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(86, 13)
        Label2.TabIndex = 22
        Label2.Text = "Enrollment Type:"
        '
        'EnrollmentBindingNavigator
        '
        Me.EnrollmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EnrollmentBindingNavigator.BindingSource = Me.LoadEnrollmentsBindingSource
        Me.EnrollmentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EnrollmentBindingNavigator.DeleteItem = Nothing
        Me.EnrollmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.EnrollmentBindingNavigatorSaveItem, Me.ToolStripButtonDelete})
        Me.EnrollmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EnrollmentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EnrollmentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EnrollmentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EnrollmentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EnrollmentBindingNavigator.Name = "EnrollmentBindingNavigator"
        Me.EnrollmentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EnrollmentBindingNavigator.Size = New System.Drawing.Size(846, 25)
        Me.EnrollmentBindingNavigator.TabIndex = 0
        Me.EnrollmentBindingNavigator.Text = "BindingNavigator1"
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
        'LoadEnrollmentsBindingSource
        '
        Me.LoadEnrollmentsBindingSource.DataMember = "LoadEnrollments"
        Me.LoadEnrollmentsBindingSource.DataSource = Me.DsSchool
        '
        'DsSchool
        '
        Me.DsSchool.DataSetName = "dsSchool"
        Me.DsSchool.EnforceConstraints = False
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'EnrollmentBindingNavigatorSaveItem
        '
        Me.EnrollmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EnrollmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("EnrollmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EnrollmentBindingNavigatorSaveItem.Name = "EnrollmentBindingNavigatorSaveItem"
        Me.EnrollmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EnrollmentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButtonDelete
        '
        Me.ToolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonDelete.Image = Global.StudentDetails.My.Resources.Resources.Delete
        Me.ToolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDelete.Name = "ToolStripButtonDelete"
        Me.ToolStripButtonDelete.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonDelete.Text = "ToolStripButton1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.EnrolTypeComboBox)
        Me.GroupBox1.Controls.Add(Me.EnrolRefTextBox)
        Me.GroupBox1.Controls.Add(Date_EnrolledLabel)
        Me.GroupBox1.Controls.Add(Me.Date_EnrolledDateTimePicker)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(Me.StatusComboBox)
        Me.GroupBox1.Controls.Add(StudentIDLabel)
        Me.GroupBox1.Controls.Add(Me.StudentIDTextBox)
        Me.GroupBox1.Controls.Add(GenderLabel)
        Me.GroupBox1.Controls.Add(Me.GenderComboBox)
        Me.GroupBox1.Controls.Add(ProgramLabel)
        Me.GroupBox1.Controls.Add(Me.ProgramComboBox)
        Me.GroupBox1.Controls.Add(YearLabel)
        Me.GroupBox1.Controls.Add(Me.YearComboBox)
        Me.GroupBox1.Controls.Add(Date_JoinedLabel)
        Me.GroupBox1.Controls.Add(Me.ClassComboBox)
        Me.GroupBox1.Controls.Add(SessionLabel)
        Me.GroupBox1.Controls.Add(Me.SessionComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(226, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 307)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enrollment Details"
        '
        'EnrolTypeComboBox
        '
        Me.EnrolTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoadEnrollmentsBindingSource, "EnrolType", True))
        Me.EnrolTypeComboBox.FormattingEnabled = True
        Me.EnrolTypeComboBox.Items.AddRange(New Object() {"Available", "Completed", "Left"})
        Me.EnrolTypeComboBox.Location = New System.Drawing.Point(153, 219)
        Me.EnrolTypeComboBox.Name = "EnrolTypeComboBox"
        Me.EnrolTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EnrolTypeComboBox.TabIndex = 23
        '
        'EnrolRefTextBox
        '
        Me.EnrolRefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoadEnrollmentsBindingSource, "EnrolRef", True))
        Me.EnrolRefTextBox.Location = New System.Drawing.Point(153, 271)
        Me.EnrolRefTextBox.Name = "EnrolRefTextBox"
        Me.EnrolRefTextBox.ReadOnly = True
        Me.EnrolRefTextBox.Size = New System.Drawing.Size(10, 20)
        Me.EnrolRefTextBox.TabIndex = 21
        '
        'Date_EnrolledDateTimePicker
        '
        Me.Date_EnrolledDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LoadEnrollmentsBindingSource, "Date_Enrolled", True))
        Me.Date_EnrolledDateTimePicker.Location = New System.Drawing.Point(153, 245)
        Me.Date_EnrolledDateTimePicker.Name = "Date_EnrolledDateTimePicker"
        Me.Date_EnrolledDateTimePicker.Size = New System.Drawing.Size(121, 20)
        Me.Date_EnrolledDateTimePicker.TabIndex = 19
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoadEnrollmentsBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Available", "Completed", "Left"})
        Me.StatusComboBox.Location = New System.Drawing.Point(153, 195)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StatusComboBox.TabIndex = 17
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoadEnrollmentsBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Location = New System.Drawing.Point(153, 34)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.StudentIDTextBox.TabIndex = 1
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoadEnrollmentsBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"M", "F"})
        Me.GenderComboBox.Location = New System.Drawing.Point(153, 60)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GenderComboBox.TabIndex = 3
        '
        'ProgramComboBox
        '
        Me.ProgramComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LoadEnrollmentsBindingSource, "Program", True))
        Me.ProgramComboBox.DisplayMember = "Forms"
        Me.ProgramComboBox.FormattingEnabled = True
        Me.ProgramComboBox.Location = New System.Drawing.Point(153, 87)
        Me.ProgramComboBox.Name = "ProgramComboBox"
        Me.ProgramComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ProgramComboBox.TabIndex = 5
        Me.ProgramComboBox.ValueMember = "Forms"
        '
        'YearComboBox
        '
        Me.YearComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoadEnrollmentsBindingSource, "Year", True))
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.YearComboBox.Location = New System.Drawing.Point(153, 114)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(121, 21)
        Me.YearComboBox.TabIndex = 7
        '
        'ClassComboBox
        '
        Me.ClassComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoadEnrollmentsBindingSource, "ClassDesc", True))
        Me.ClassComboBox.FormattingEnabled = True
        Me.ClassComboBox.Location = New System.Drawing.Point(153, 168)
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ClassComboBox.TabIndex = 11
        '
        'SessionComboBox
        '
        Me.SessionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SessionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SessionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoadEnrollmentsBindingSource, "Session", True))
        Me.SessionComboBox.DisplayMember = "Session"
        Me.SessionComboBox.FormattingEnabled = True
        Me.SessionComboBox.Location = New System.Drawing.Point(153, 141)
        Me.SessionComboBox.Name = "SessionComboBox"
        Me.SessionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SessionComboBox.TabIndex = 13
        Me.SessionComboBox.ValueMember = "Session"
        '
        'lstResult
        '
        Me.lstResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstResult.BackColor = System.Drawing.Color.LightYellow
        Me.lstResult.DisplayMember = "StudName"
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(626, 74)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(218, 186)
        Me.lstResult.TabIndex = 17
        Me.lstResult.ValueMember = "StudentID"
        Me.lstResult.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(566, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "StudentSearch:"
        '
        'Button31
        '
        Me.Button31.BackgroundImage = Global.StudentDetails.My.Resources.Resources.search
        Me.Button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button31.Location = New System.Drawing.Point(790, 49)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(19, 20)
        Me.Button31.TabIndex = 19
        Me.Button31.UseVisualStyleBackColor = True
        '
        'LoadEnrollmentsTableAdapter
        '
        Me.LoadEnrollmentsTableAdapter.ClearBeforeFill = True
        '
        'txtStudSearch
        '
        Me.txtStudSearch.Location = New System.Drawing.Point(643, 48)
        Me.txtStudSearch.Name = "txtStudSearch"
        Me.txtStudSearch.Size = New System.Drawing.Size(141, 20)
        Me.txtStudSearch.TabIndex = 20
        '
        'frmEditEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(846, 435)
        Me.Controls.Add(Me.txtStudSearch)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstResult)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EnrollmentBindingNavigator)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditEnrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Enrollment"
        CType(Me.EnrollmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EnrollmentBindingNavigator.ResumeLayout(False)
        Me.EnrollmentBindingNavigator.PerformLayout()
        CType(Me.LoadEnrollmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    '  Friend WithEvents DsSchool As SMS.dsSchool
    Friend WithEvents EnrollmentBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents EnrollmentTableAdapter As SMS.dsSchoolTableAdapters.enrollmentTableAdapter
    '  Friend WithEvents TableAdapterManager As SMS.dsSchoolTableAdapters.TableAdapterManager
    Friend WithEvents EnrollmentBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EnrollmentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    '  Friend WithEvents StudentPersonalDetailsTableAdapter As SMS.dsSchoolTableAdapters.StudentPersonalDetailsTableAdapter
    '  Friend WithEvents StudentPersonalDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProgramComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClassComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SessionComboBox As System.Windows.Forms.ComboBox
    ' Friend WithEvents SMSAccBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents SMSAccTableAdapter As SMS.dsSchoolTableAdapters.SMSAccTableAdapter
    ' Friend WithEvents FormsBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents FormsTableAdapter As SMS.dsSchoolTableAdapters.formsTableAdapter
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Date_EnrolledDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
    Friend WithEvents EnrolRefTextBox As Windows.Forms.TextBox
    Friend WithEvents EnrolTypeComboBox As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Button31 As Windows.Forms.Button
    Friend WithEvents LoadEnrollmentsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents DsSchool As dsSchool
    Friend WithEvents ToolStripButtonDelete As Windows.Forms.ToolStripButton
    Friend WithEvents LoadEnrollmentsTableAdapter As dsSchoolTableAdapters.LoadEnrollmentsTableAdapter
    Friend WithEvents txtStudSearch As Windows.Forms.TextBox
    '  Friend WithEvents SchoolsessionsBindingSource As System.Windows.Forms.BindingSource
    '   Friend WithEvents SchoolsessionsTableAdapter As SMS.dsSchoolTableAdapters.schoolsessionsTableAdapter
End Class
