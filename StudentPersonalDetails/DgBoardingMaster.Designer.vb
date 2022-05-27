<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DgBoardingMaster
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
        Me.StudentAcademicReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsSchool = New dsSchool()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.rbAllChild = New System.Windows.Forms.RadioButton()
        Me.rbOneChild = New System.Windows.Forms.RadioButton()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbStud = New System.Windows.Forms.Label()
        Me.gdHeadStudents = New System.Windows.Forms.DataGridView()
        Me.StudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboBoardingmaster = New System.Windows.Forms.ComboBox()
        Me.StudentAcademicReportTableAdapter = New dsSchoolTableAdapters.StudentAcademicReportTableAdapter()
        CType(Me.StudentAcademicReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.gdHeadStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentAcademicReportBindingSource
        '
        Me.StudentAcademicReportBindingSource.DataMember = "StudentAcademicReport"
        Me.StudentAcademicReportBindingSource.DataSource = Me.dsSchool
        '
        'dsSchool
        '
        Me.dsSchool.DataSetName = "dsSchool"
        Me.dsSchool.EnforceConstraints = False
        Me.dsSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(751, 585)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 42)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 9)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Save Comment"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 9)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Close"
        '
        'rbAllChild
        '
        Me.rbAllChild.AutoSize = True
        Me.rbAllChild.Location = New System.Drawing.Point(131, 585)
        Me.rbAllChild.Name = "rbAllChild"
        Me.rbAllChild.Size = New System.Drawing.Size(127, 17)
        Me.rbAllChild.TabIndex = 14
        Me.rbAllChild.Text = "ForAllStudentsInClass"
        Me.rbAllChild.UseVisualStyleBackColor = True
        Me.rbAllChild.Visible = False
        '
        'rbOneChild
        '
        Me.rbOneChild.AutoSize = True
        Me.rbOneChild.Checked = True
        Me.rbOneChild.Location = New System.Drawing.Point(15, 585)
        Me.rbOneChild.Name = "rbOneChild"
        Me.rbOneChild.Size = New System.Drawing.Size(97, 17)
        Me.rbOneChild.TabIndex = 13
        Me.rbOneChild.TabStop = True
        Me.rbOneChild.Text = "ForThisStudent"
        Me.rbOneChild.UseVisualStyleBackColor = True
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(12, 139)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtComment.Size = New System.Drawing.Size(558, 68)
        Me.txtComment.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Comment:"
        '
        'lbStud
        '
        Me.lbStud.AutoSize = True
        Me.lbStud.Location = New System.Drawing.Point(22, 30)
        Me.lbStud.Name = "lbStud"
        Me.lbStud.Size = New System.Drawing.Size(0, 13)
        Me.lbStud.TabIndex = 15
        '
        'gdHeadStudents
        '
        Me.gdHeadStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdHeadStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentID, Me.StudentName, Me.Ref})
        Me.gdHeadStudents.Location = New System.Drawing.Point(595, 124)
        Me.gdHeadStudents.MultiSelect = False
        Me.gdHeadStudents.Name = "gdHeadStudents"
        Me.gdHeadStudents.ReadOnly = True
        Me.gdHeadStudents.Size = New System.Drawing.Size(311, 455)
        Me.gdHeadStudents.TabIndex = 19
        '
        'StudentID
        '
        Me.StudentID.DataPropertyName = "StudentID"
        Me.StudentID.HeaderText = "StudentID"
        Me.StudentID.Name = "StudentID"
        Me.StudentID.ReadOnly = True
        Me.StudentID.Width = 75
        '
        'StudentName
        '
        Me.StudentName.DataPropertyName = "StudName"
        Me.StudentName.HeaderText = "StudentName"
        Me.StudentName.Name = "StudentName"
        Me.StudentName.ReadOnly = True
        Me.StudentName.Width = 200
        '
        'Ref
        '
        Me.Ref.DataPropertyName = "EnrolRef"
        Me.Ref.HeaderText = "Ref"
        Me.Ref.Name = "Ref"
        Me.Ref.ReadOnly = True
        Me.Ref.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(592, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Class Students"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(598, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "BoardingMaster:"
        '
        'cboBoardingmaster
        '
        Me.cboBoardingmaster.FormattingEnabled = True
        Me.cboBoardingmaster.Location = New System.Drawing.Point(685, 69)
        Me.cboBoardingmaster.Name = "cboBoardingmaster"
        Me.cboBoardingmaster.Size = New System.Drawing.Size(222, 21)
        Me.cboBoardingmaster.TabIndex = 23
        '
        'StudentAcademicReportTableAdapter
        '
        Me.StudentAcademicReportTableAdapter.ClearBeforeFill = True
        '
        'DgBoardingMaster
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(918, 634)
        Me.Controls.Add(Me.cboBoardingmaster)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gdHeadStudents)
        Me.Controls.Add(Me.lbStud)
        Me.Controls.Add(Me.rbAllChild)
        Me.Controls.Add(Me.rbOneChild)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DgBoardingMaster"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  Boarding Master's Comment"
        Me.TopMost = True
        CType(Me.StudentAcademicReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsSchool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.gdHeadStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents rbAllChild As System.Windows.Forms.RadioButton
    Friend WithEvents rbOneChild As System.Windows.Forms.RadioButton
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbStud As System.Windows.Forms.Label

    Friend WithEvents gdHeadStudents As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents cboBoardingmaster As Windows.Forms.ComboBox
    Friend WithEvents StudentAcademicReportBindingSource As Windows.Forms.BindingSource
    Friend WithEvents dsSchool As dsSchool
    Friend WithEvents StudentAcademicReportTableAdapter As dsSchoolTableAdapters.StudentAcademicReportTableAdapter
    Friend WithEvents StudentID As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ref As Windows.Forms.DataGridViewTextBoxColumn
End Class
