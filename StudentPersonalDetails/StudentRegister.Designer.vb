<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentRegister))
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim TermLabel As System.Windows.Forms.Label
        Dim ClasLabel As System.Windows.Forms.Label
        Dim FormLabel As System.Windows.Forms.Label

        Me.StudentRegisterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.StudentRegisterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.StatusTextBox = New System.Windows.Forms.TextBox
        Me.YearTextBox = New System.Windows.Forms.TextBox
        Me.TermTextBox = New System.Windows.Forms.TextBox
        Me.ClasTextBox = New System.Windows.Forms.TextBox
        Me.FormTextBox = New System.Windows.Forms.TextBox
        StudentIDLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        YearLabel = New System.Windows.Forms.Label
        TermLabel = New System.Windows.Forms.Label
        ClasLabel = New System.Windows.Forms.Label
        FormLabel = New System.Windows.Forms.Label

        CType(Me.StudentRegisterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRegisterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentRegisterBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'dsschool
        '

        '
        'StudentRegisterBindingSource
        '
        Me.StudentRegisterBindingSource.DataMember = "StudentRegister"

        '
        'StudentRegisterTableAdapter

        '
        'TableAdapterManager


        ' Me.TableAdapterManager.Fees_BreakdownTableAdapter = Nothing
        ' Me.TableAdapterManager.formsTableAdapter = Nothing

        'Me.TableAdapterManager.LivTypeTableAdapter = Nothing



        ' Me.TableAdapterManager.YearTermTableAdapter = Nothing
        '
        'StudentRegisterBindingNavigator
        '
        Me.StudentRegisterBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentRegisterBindingNavigator.BindingSource = Me.StudentRegisterBindingSource
        Me.StudentRegisterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentRegisterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentRegisterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentRegisterBindingNavigatorSaveItem})
        Me.StudentRegisterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentRegisterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentRegisterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentRegisterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentRegisterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentRegisterBindingNavigator.Name = "StudentRegisterBindingNavigator"
        Me.StudentRegisterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentRegisterBindingNavigator.Size = New System.Drawing.Size(502, 25)
        Me.StudentRegisterBindingNavigator.TabIndex = 0
        Me.StudentRegisterBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'StudentRegisterBindingNavigatorSaveItem
        '
        Me.StudentRegisterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentRegisterBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentRegisterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentRegisterBindingNavigatorSaveItem.Name = "StudentRegisterBindingNavigatorSaveItem"
        Me.StudentRegisterBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.StudentRegisterBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(130, 109)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(59, 13)
        StudentIDLabel.TabIndex = 1
        StudentIDLabel.Text = "student ID:"
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRegisterBindingSource, "studentID", True))
        Me.StudentIDTextBox.Location = New System.Drawing.Point(195, 106)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StudentIDTextBox.TabIndex = 2
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(134, 237)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentRegisterBindingSource, "Date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(195, 237)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 4
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(134, 272)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 5
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRegisterBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(195, 265)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 6
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.Location = New System.Drawing.Point(132, 187)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(32, 13)
        YearLabel.TabIndex = 7
        YearLabel.Text = "Year:"
        '
        'YearTextBox
        '
        Me.YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRegisterBindingSource, "Year", True))
        Me.YearTextBox.Location = New System.Drawing.Point(195, 184)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(200, 20)
        Me.YearTextBox.TabIndex = 8
        '
        'TermLabel
        '
        TermLabel.AutoSize = True
        TermLabel.Location = New System.Drawing.Point(130, 213)
        TermLabel.Name = "TermLabel"
        TermLabel.Size = New System.Drawing.Size(34, 13)
        TermLabel.TabIndex = 9
        TermLabel.Text = "Term:"
        '
        'TermTextBox
        '
        Me.TermTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRegisterBindingSource, "Term", True))
        Me.TermTextBox.Location = New System.Drawing.Point(195, 210)
        Me.TermTextBox.Name = "TermTextBox"
        Me.TermTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TermTextBox.TabIndex = 10
        '
        'ClasLabel
        '
        ClasLabel.AutoSize = True
        ClasLabel.Location = New System.Drawing.Point(134, 160)
        ClasLabel.Name = "ClasLabel"
        ClasLabel.Size = New System.Drawing.Size(30, 13)
        ClasLabel.TabIndex = 11
        ClasLabel.Text = "Clas:"
        '
        'ClasTextBox
        '
        Me.ClasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRegisterBindingSource, "Clas", True))
        Me.ClasTextBox.Location = New System.Drawing.Point(195, 157)
        Me.ClasTextBox.Name = "ClasTextBox"
        Me.ClasTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ClasTextBox.TabIndex = 12
        '
        'FormLabel
        '
        FormLabel.AutoSize = True
        FormLabel.Location = New System.Drawing.Point(131, 134)
        FormLabel.Name = "FormLabel"
        FormLabel.Size = New System.Drawing.Size(33, 13)
        FormLabel.TabIndex = 13
        FormLabel.Text = "Form:"
        '
        'FormTextBox
        '
        Me.FormTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentRegisterBindingSource, "Form", True))
        Me.FormTextBox.Location = New System.Drawing.Point(195, 131)
        Me.FormTextBox.Name = "FormTextBox"
        Me.FormTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FormTextBox.TabIndex = 14
        '
        'StudentRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 372)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(YearLabel)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(TermLabel)
        Me.Controls.Add(Me.TermTextBox)
        Me.Controls.Add(ClasLabel)
        Me.Controls.Add(Me.ClasTextBox)
        Me.Controls.Add(FormLabel)
        Me.Controls.Add(Me.FormTextBox)
        Me.Controls.Add(Me.StudentRegisterBindingNavigator)
        Me.Name = "StudentRegister"
        Me.Text = "StudentRegister"

        CType(Me.StudentRegisterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRegisterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentRegisterBindingNavigator.ResumeLayout(False)
        Me.StudentRegisterBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentRegisterBindingSource As System.Windows.Forms.BindingSource


    Friend WithEvents StudentRegisterBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StudentRegisterBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TermTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FormTextBox As System.Windows.Forms.TextBox
End Class
