<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditMarks
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.dgeditmarks = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboEditMarksProg = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtStudEditMarks = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboEditMarksRef = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DsSchool = New StudentDetails.dsSchool()
        Me.ExamSessionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamSessionsTableAdapter = New StudentDetails.dsSchoolTableAdapters.ExamSessionsTableAdapter()
        Me.RowNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseMark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalMark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubPoints = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Exam = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Effort = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkEnrolref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Update = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgeditmarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamSessionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.lstResult)
        Me.GroupBox1.Controls.Add(Me.dgeditmarks)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1362, 366)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Marks"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(627, 337)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(141, 23)
        Me.btndelete.TabIndex = 33
        Me.btndelete.Text = "Delete Selected"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(546, 337)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Save All"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(325, 4)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(328, 186)
        Me.lstResult.TabIndex = 30
        Me.lstResult.Visible = False
        '
        'dgeditmarks
        '
        Me.dgeditmarks.AllowUserToAddRows = False
        Me.dgeditmarks.AllowUserToDeleteRows = False
        Me.dgeditmarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgeditmarks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RowNumber, Me.Subject, Me.SubType, Me.Level, Me.Sem, Me.CourseMark, Me.EM, Me.FinalMark, Me.SubPoints, Me.Grade, Me.Status, Me.Exam, Me.Comment, Me.Effort, Me.Ref, Me.MarkEnrolref, Me.Delete, Me.Update})
        Me.dgeditmarks.Location = New System.Drawing.Point(6, 45)
        Me.dgeditmarks.Name = "dgeditmarks"
        Me.dgeditmarks.Size = New System.Drawing.Size(1346, 286)
        Me.dgeditmarks.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Controls.Add(Me.cboEditMarksProg)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtStudEditMarks)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboEditMarksRef)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1223, 48)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ExamSearch"
        '
        'cboEditMarksProg
        '
        Me.cboEditMarksProg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEditMarksProg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEditMarksProg.DisplayMember = "Forms"
        Me.cboEditMarksProg.FormattingEnabled = True
        Me.cboEditMarksProg.Location = New System.Drawing.Point(126, 21)
        Me.cboEditMarksProg.Name = "cboEditMarksProg"
        Me.cboEditMarksProg.Size = New System.Drawing.Size(128, 21)
        Me.cboEditMarksProg.TabIndex = 42
        Me.cboEditMarksProg.ValueMember = "Forms"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(71, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Program:"
        '
        'txtStudEditMarks
        '
        Me.txtStudEditMarks.Location = New System.Drawing.Point(325, 21)
        Me.txtStudEditMarks.Name = "txtStudEditMarks"
        Me.txtStudEditMarks.Size = New System.Drawing.Size(173, 20)
        Me.txtStudEditMarks.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(513, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Exam:"
        '
        'cboEditMarksRef
        '
        Me.cboEditMarksRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEditMarksRef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEditMarksRef.DisplayMember = "Sessions"
        Me.cboEditMarksRef.FormattingEnabled = True
        Me.cboEditMarksRef.Location = New System.Drawing.Point(555, 21)
        Me.cboEditMarksRef.Name = "cboEditMarksRef"
        Me.cboEditMarksRef.Size = New System.Drawing.Size(226, 21)
        Me.cboEditMarksRef.TabIndex = 3
        Me.cboEditMarksRef.ValueMember = "Sessions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student:"
        '
        'DsSchool
        '
        Me.DsSchool.DataSetName = "dsSchool"
        Me.DsSchool.EnforceConstraints = False
        Me.DsSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExamSessionsBindingSource
        '
        Me.ExamSessionsBindingSource.DataMember = "ExamSessions"
        Me.ExamSessionsBindingSource.DataSource = Me.DsSchool
        '
        'ExamSessionsTableAdapter
        '
        Me.ExamSessionsTableAdapter.ClearBeforeFill = True
        '
        'RowNumber
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RowNumber.DefaultCellStyle = DataGridViewCellStyle1
        Me.RowNumber.HeaderText = "#"
        Me.RowNumber.Name = "RowNumber"
        Me.RowNumber.ReadOnly = True
        '
        'Subject
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Subject.DefaultCellStyle = DataGridViewCellStyle2
        Me.Subject.HeaderText = "Subject"
        Me.Subject.Name = "Subject"
        Me.Subject.ReadOnly = True
        '
        'SubType
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SubType.DefaultCellStyle = DataGridViewCellStyle3
        Me.SubType.HeaderText = "Type"
        Me.SubType.Name = "SubType"
        Me.SubType.ReadOnly = True
        Me.SubType.Visible = False
        '
        'Level
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Level.DefaultCellStyle = DataGridViewCellStyle4
        Me.Level.HeaderText = "Level"
        Me.Level.Name = "Level"
        Me.Level.Width = 50
        '
        'Sem
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Sem.DefaultCellStyle = DataGridViewCellStyle5
        Me.Sem.HeaderText = "Sem"
        Me.Sem.Name = "Sem"
        Me.Sem.Width = 50
        '
        'CourseMark
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CourseMark.DefaultCellStyle = DataGridViewCellStyle6
        Me.CourseMark.HeaderText = "CM"
        Me.CourseMark.Name = "CourseMark"
        '
        'EM
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EM.DefaultCellStyle = DataGridViewCellStyle7
        Me.EM.HeaderText = "EM"
        Me.EM.Name = "EM"
        Me.EM.Width = 50
        '
        'FinalMark
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FinalMark.DefaultCellStyle = DataGridViewCellStyle8
        Me.FinalMark.HeaderText = "FM"
        Me.FinalMark.Name = "FinalMark"
        Me.FinalMark.ReadOnly = True
        '
        'SubPoints
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SubPoints.DefaultCellStyle = DataGridViewCellStyle9
        Me.SubPoints.HeaderText = "Points"
        Me.SubPoints.Name = "SubPoints"
        Me.SubPoints.ReadOnly = True
        Me.SubPoints.Width = 50
        '
        'Grade
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Grade.DefaultCellStyle = DataGridViewCellStyle10
        Me.Grade.HeaderText = "Decision"
        Me.Grade.Name = "Grade"
        Me.Grade.ReadOnly = True
        Me.Grade.Width = 50
        '
        'Status
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Status.DefaultCellStyle = DataGridViewCellStyle11
        Me.Status.HeaderText = "ExamStatus"
        Me.Status.Items.AddRange(New Object() {"Present", "Absent", "Deferred", "Presumed WithDrawn", "Not Registered"})
        Me.Status.Name = "Status"
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Status.Width = 150
        '
        'Exam
        '
        Me.Exam.DataSource = Me.ExamSessionsBindingSource
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Exam.DefaultCellStyle = DataGridViewCellStyle12
        Me.Exam.DisplayMember = "Session"
        Me.Exam.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Exam.HeaderText = "Exam"
        Me.Exam.Name = "Exam"
        Me.Exam.ValueMember = "Session"
        Me.Exam.Width = 200
        '
        'Comment
        '
        Me.Comment.HeaderText = "Comment"
        Me.Comment.Name = "Comment"
        '
        'Effort
        '
        Me.Effort.HeaderText = "Effort"
        Me.Effort.Items.AddRange(New Object() {"OE", "UE", "CE", "AE", "IE"})
        Me.Effort.Name = "Effort"
        '
        'Ref
        '
        Me.Ref.HeaderText = "Ref"
        Me.Ref.Name = "Ref"
        Me.Ref.Visible = False
        '
        'MarkEnrolref
        '
        Me.MarkEnrolref.HeaderText = "MarkEnrolRef"
        Me.MarkEnrolref.Name = "MarkEnrolref"
        Me.MarkEnrolref.Visible = False
        '
        'Delete
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle13
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.Text = "Delete"
        Me.Delete.ToolTipText = "Deletes current roww"
        Me.Delete.UseColumnTextForButtonValue = True
        '
        'Update
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        Me.Update.DefaultCellStyle = DataGridViewCellStyle14
        Me.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Update.HeaderText = "Save"
        Me.Update.Name = "Update"
        Me.Update.Text = "Save"
        Me.Update.ToolTipText = "Saves changes made to current row"
        Me.Update.UseColumnTextForButtonValue = True
        '
        'frmEditMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1391, 434)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditMarks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditMarks"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgeditmarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamSessionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btndelete As Windows.Forms.Button
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents lstResult As Windows.Forms.ListBox
    Friend WithEvents dgeditmarks As Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents cboEditMarksRef As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtStudEditMarks As Windows.Forms.TextBox
    Friend WithEvents cboEditMarksProg As Windows.Forms.ComboBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents DsSchool As dsSchool
    Friend WithEvents ExamSessionsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents ExamSessionsTableAdapter As dsSchoolTableAdapters.ExamSessionsTableAdapter
    Friend WithEvents RowNumber As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subject As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubType As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Level As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sem As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseMark As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EM As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinalMark As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubPoints As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grade As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Exam As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Comment As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Effort As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Ref As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarkEnrolref As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Delete As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Update As Windows.Forms.DataGridViewButtonColumn
End Class
