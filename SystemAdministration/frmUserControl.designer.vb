<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim lblGP As System.Windows.Forms.Label
        Dim lblConfirm As System.Windows.Forms.Label
        Dim lblPassword As System.Windows.Forms.Label
        Dim lblFullName As System.Windows.Forms.Label
        Dim lblUserName As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserControl))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gbOne = New System.Windows.Forms.GroupBox
        Me.tbOne = New System.Windows.Forms.TabControl
        Me.tbGroups = New System.Windows.Forms.TabPage
        Me.gbCC = New System.Windows.Forms.GroupBox
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.UserGroups1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSecurity = New dsSecurity
        Me.BindingNavigatorCountItem3 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem3 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem3 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem3 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem3 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem3 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ugp_GroupName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserGroups1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.bnUserGp = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.delgp = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.savegp = New System.Windows.Forms.ToolStripButton
        Me.dgvUserGps = New System.Windows.Forms.DataGridView
        Me.tbAuthorization = New System.Windows.Forms.TabPage
        Me.gbGD = New System.Windows.Forms.GroupBox
        Me.clstAuth = New System.Windows.Forms.CheckedListBox
        Me.lblSelectGp = New System.Windows.Forms.Label
        Me.cboGp = New System.Windows.Forms.ComboBox
        Me.UserGroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbUsers = New System.Windows.Forms.TabPage
        Me.gbAuth = New System.Windows.Forms.GroupBox
        Me.btnChangGroup = New System.Windows.Forms.Button
        Me.lbusers = New System.Windows.Forms.ListBox
        Me.txtUserSearch = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnLockUser = New System.Windows.Forms.Button
        Me.cboGp_for_Users = New System.Windows.Forms.ComboBox
        Me.bnUsers = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AddNew = New System.Windows.Forms.ToolStripButton
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.txtUid = New System.Windows.Forms.TextBox
        Me.spltHelp = New System.Windows.Forms.SplitContainer
        Me.rtbHelp = New System.Windows.Forms.RichTextBox
        Me.UserNameTextBox = New System.Windows.Forms.TextBox
        Me.FullNameTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.UserGroupTextBox = New System.Windows.Forms.TextBox
        Me.btnResetPass = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ComponentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsComponents = New dsComponents
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CompAccessIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompCompNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnClose = New System.Windows.Forms.Button
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.btnSave = New System.Windows.Forms.Button
        Me.ttOne = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComponentsTableAdapter = New dsComponentsTableAdapters.ComponentsTableAdapter
        Me.TableAdapterManager = New dsComponentsTableAdapters.TableAdapterManager
        Me.UserAuthorisationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserAuthorisationsTableAdapter = New dsSecurityTableAdapters.UserAuthorisationsTableAdapter
        Me.TableAdapterManager1 = New dsSecurityTableAdapters.TableAdapterManager
        Me.UserGroups1TableAdapter = New dsSecurityTableAdapters.UserGroups1TableAdapter
        Me.UsersTableAdapter = New dsSecurityTableAdapters.UsersTableAdapter
        Me.UserGroupsTableAdapter = New dsSecurityTableAdapters.UserGroupsTableAdapter
        lblGP = New System.Windows.Forms.Label
        lblConfirm = New System.Windows.Forms.Label
        lblPassword = New System.Windows.Forms.Label
        lblFullName = New System.Windows.Forms.Label
        lblUserName = New System.Windows.Forms.Label
        Me.gbOne.SuspendLayout()
        Me.tbOne.SuspendLayout()
        Me.tbGroups.SuspendLayout()
        Me.gbCC.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.UserGroups1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSecurity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGroups1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnUserGp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnUserGp.SuspendLayout()
        CType(Me.dgvUserGps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbAuthorization.SuspendLayout()
        Me.gbGD.SuspendLayout()
        CType(Me.UserGroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbUsers.SuspendLayout()
        Me.gbAuth.SuspendLayout()
        CType(Me.bnUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnUsers.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltHelp.Panel1.SuspendLayout()
        Me.spltHelp.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ComponentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAuthorisationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGP
        '
        lblGP.Location = New System.Drawing.Point(33, 64)
        lblGP.Name = "lblGP"
        lblGP.Size = New System.Drawing.Size(97, 20)
        lblGP.TabIndex = 95
        lblGP.Text = "Group:"
        lblGP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConfirm
        '
        lblConfirm.Location = New System.Drawing.Point(33, 209)
        lblConfirm.Name = "lblConfirm"
        lblConfirm.Size = New System.Drawing.Size(97, 20)
        lblConfirm.TabIndex = 105
        lblConfirm.Text = "Confirm Password:"
        lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPassword
        '
        lblPassword.Location = New System.Drawing.Point(33, 173)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New System.Drawing.Size(97, 20)
        lblPassword.TabIndex = 103
        lblPassword.Text = "Password:"
        lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFullName
        '
        lblFullName.Location = New System.Drawing.Point(33, 137)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New System.Drawing.Size(97, 20)
        lblFullName.TabIndex = 101
        lblFullName.Text = "Full Name:"
        lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserName
        '
        lblUserName.Location = New System.Drawing.Point(33, 101)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New System.Drawing.Size(97, 20)
        lblUserName.TabIndex = 99
        lblUserName.Text = "User Name:"
        lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbOne
        '
        Me.gbOne.Controls.Add(Me.tbOne)
        Me.gbOne.Location = New System.Drawing.Point(1, 1)
        Me.gbOne.Name = "gbOne"
        Me.gbOne.Size = New System.Drawing.Size(570, 348)
        Me.gbOne.TabIndex = 1
        Me.gbOne.TabStop = False
        '
        'tbOne
        '
        Me.tbOne.Controls.Add(Me.tbGroups)
        Me.tbOne.Controls.Add(Me.tbAuthorization)
        Me.tbOne.Controls.Add(Me.tbUsers)
        Me.tbOne.Controls.Add(Me.TabPage1)
        Me.tbOne.Location = New System.Drawing.Point(6, 19)
        Me.tbOne.Name = "tbOne"
        Me.tbOne.SelectedIndex = 0
        Me.tbOne.Size = New System.Drawing.Size(558, 309)
        Me.tbOne.TabIndex = 1
        '
        'tbGroups
        '
        Me.tbGroups.AutoScroll = True
        Me.tbGroups.BackColor = System.Drawing.SystemColors.Control
        Me.tbGroups.Controls.Add(Me.gbCC)
        Me.tbGroups.Location = New System.Drawing.Point(4, 22)
        Me.tbGroups.Name = "tbGroups"
        Me.tbGroups.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGroups.Size = New System.Drawing.Size(550, 283)
        Me.tbGroups.TabIndex = 0
        Me.tbGroups.Text = "Groups"
        '
        'gbCC
        '
        Me.gbCC.BackColor = System.Drawing.SystemColors.Control
        Me.gbCC.Controls.Add(Me.BindingNavigator2)
        Me.gbCC.Controls.Add(Me.DataGridView2)
        Me.gbCC.Controls.Add(Me.Label1)
        Me.gbCC.Controls.Add(Me.bnUserGp)
        Me.gbCC.Controls.Add(Me.dgvUserGps)
        Me.gbCC.Location = New System.Drawing.Point(3, 0)
        Me.gbCC.Name = "gbCC"
        Me.gbCC.Size = New System.Drawing.Size(501, 280)
        Me.gbCC.TabIndex = 13
        Me.gbCC.TabStop = False
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.AutoSize = False
        Me.BindingNavigator2.BindingSource = Me.UserGroups1BindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem3
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem3, Me.BindingNavigatorMovePreviousItem3, Me.BindingNavigatorSeparator9, Me.BindingNavigatorPositionItem3, Me.BindingNavigatorCountItem3, Me.BindingNavigatorSeparator10, Me.BindingNavigatorMoveNextItem3, Me.BindingNavigatorMoveLastItem3, Me.BindingNavigatorSeparator11})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 44)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem3
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem3
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem3
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem3
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem3
        Me.BindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator2.Size = New System.Drawing.Size(489, 25)
        Me.BindingNavigator2.TabIndex = 75
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'UserGroups1BindingSource
        '
        Me.UserGroups1BindingSource.DataMember = "UserGroups1"
        Me.UserGroups1BindingSource.DataSource = Me.DsSecurity
        '
        'DsSecurity
        '
        Me.DsSecurity.DataSetName = "dsSecurity"
        Me.DsSecurity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Ugp_GroupName})
        Me.DataGridView2.DataSource = Me.UserGroups1BindingSource1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.Location = New System.Drawing.Point(3, 72)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(492, 205)
        Me.DataGridView2.TabIndex = 74
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ugp_UserGroup"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Group"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 61
        '
        'Ugp_GroupName
        '
        Me.Ugp_GroupName.DataPropertyName = "Ugp_GroupName"
        Me.Ugp_GroupName.HeaderText = "Description"
        Me.Ugp_GroupName.Name = "Ugp_GroupName"
        Me.Ugp_GroupName.Width = 85
        '
        'UserGroups1BindingSource1
        '
        Me.UserGroups1BindingSource1.DataMember = "UserGroups1"
        Me.UserGroups1BindingSource1.DataSource = Me.DsSecurity
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Beige
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Olive
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(495, 25)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Group"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnUserGp
        '
        Me.bnUserGp.AddNewItem = Nothing
        Me.bnUserGp.CountItem = Me.BindingNavigatorCountItem
        Me.bnUserGp.DeleteItem = Me.delgp
        Me.bnUserGp.Dock = System.Windows.Forms.DockStyle.None
        Me.bnUserGp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.delgp, Me.savegp})
        Me.bnUserGp.Location = New System.Drawing.Point(3, 16)
        Me.bnUserGp.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnUserGp.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnUserGp.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnUserGp.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnUserGp.Name = "bnUserGp"
        Me.bnUserGp.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnUserGp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.bnUserGp.Size = New System.Drawing.Size(255, 25)
        Me.bnUserGp.TabIndex = 72
        Me.bnUserGp.Text = "BindingNavigator1"
        Me.bnUserGp.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'delgp
        '
        Me.delgp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.delgp.Image = CType(resources.GetObject("delgp.Image"), System.Drawing.Image)
        Me.delgp.Name = "delgp"
        Me.delgp.RightToLeftAutoMirrorImage = True
        Me.delgp.Size = New System.Drawing.Size(23, 22)
        Me.delgp.Text = "Delete"
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
        'savegp
        '
        Me.savegp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.savegp.Enabled = False
        Me.savegp.Image = CType(resources.GetObject("savegp.Image"), System.Drawing.Image)
        Me.savegp.Name = "savegp"
        Me.savegp.Size = New System.Drawing.Size(23, 22)
        Me.savegp.Text = "Save Data"
        '
        'dgvUserGps
        '
        Me.dgvUserGps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUserGps.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvUserGps.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserGps.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUserGps.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvUserGps.Location = New System.Drawing.Point(3, 44)
        Me.dgvUserGps.Name = "dgvUserGps"
        Me.dgvUserGps.Size = New System.Drawing.Size(495, 233)
        Me.dgvUserGps.TabIndex = 0
        '
        'tbAuthorization
        '
        Me.tbAuthorization.AutoScroll = True
        Me.tbAuthorization.BackColor = System.Drawing.SystemColors.Control
        Me.tbAuthorization.Controls.Add(Me.gbGD)
        Me.tbAuthorization.Location = New System.Drawing.Point(4, 22)
        Me.tbAuthorization.Name = "tbAuthorization"
        Me.tbAuthorization.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAuthorization.Size = New System.Drawing.Size(550, 283)
        Me.tbAuthorization.TabIndex = 1
        Me.tbAuthorization.Text = "Authorization"
        '
        'gbGD
        '
        Me.gbGD.BackColor = System.Drawing.SystemColors.Control
        Me.gbGD.Controls.Add(Me.clstAuth)
        Me.gbGD.Controls.Add(Me.lblSelectGp)
        Me.gbGD.Controls.Add(Me.cboGp)
        Me.gbGD.Location = New System.Drawing.Point(3, 0)
        Me.gbGD.Name = "gbGD"
        Me.gbGD.Size = New System.Drawing.Size(610, 292)
        Me.gbGD.TabIndex = 14
        Me.gbGD.TabStop = False
        '
        'clstAuth
        '
        Me.clstAuth.BackColor = System.Drawing.Color.LightYellow
        Me.clstAuth.FormattingEnabled = True
        Me.clstAuth.Location = New System.Drawing.Point(25, 43)
        Me.clstAuth.Name = "clstAuth"
        Me.clstAuth.Size = New System.Drawing.Size(288, 229)
        Me.clstAuth.TabIndex = 75
        '
        'lblSelectGp
        '
        Me.lblSelectGp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectGp.ForeColor = System.Drawing.Color.Olive
        Me.lblSelectGp.Location = New System.Drawing.Point(22, 16)
        Me.lblSelectGp.Name = "lblSelectGp"
        Me.lblSelectGp.Size = New System.Drawing.Size(100, 21)
        Me.lblSelectGp.TabIndex = 74
        Me.lblSelectGp.Text = "Select Group >>"
        Me.lblSelectGp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboGp
        '
        Me.cboGp.BackColor = System.Drawing.Color.LightYellow
        Me.cboGp.DataSource = Me.UserGroupsBindingSource
        Me.cboGp.DisplayMember = "Description"
        Me.cboGp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGp.ForeColor = System.Drawing.Color.Black
        Me.cboGp.FormattingEnabled = True
        Me.cboGp.Location = New System.Drawing.Point(128, 16)
        Me.cboGp.Name = "cboGp"
        Me.cboGp.Size = New System.Drawing.Size(185, 21)
        Me.cboGp.TabIndex = 0
        Me.cboGp.ValueMember = "Ugp_UserGroup"
        '
        'UserGroupsBindingSource
        '
        Me.UserGroupsBindingSource.DataMember = "UserGroups"
        Me.UserGroupsBindingSource.DataSource = Me.DsSecurity
        '
        'tbUsers
        '
        Me.tbUsers.AutoScroll = True
        Me.tbUsers.BackColor = System.Drawing.SystemColors.Control
        Me.tbUsers.Controls.Add(Me.gbAuth)
        Me.tbUsers.Location = New System.Drawing.Point(4, 22)
        Me.tbUsers.Name = "tbUsers"
        Me.tbUsers.Size = New System.Drawing.Size(550, 283)
        Me.tbUsers.TabIndex = 2
        Me.tbUsers.Text = "Users"
        '
        'gbAuth
        '
        Me.gbAuth.BackColor = System.Drawing.SystemColors.Control
        Me.gbAuth.Controls.Add(Me.btnChangGroup)
        Me.gbAuth.Controls.Add(Me.lbusers)
        Me.gbAuth.Controls.Add(Me.txtUserSearch)
        Me.gbAuth.Controls.Add(Me.Label2)
        Me.gbAuth.Controls.Add(Me.btnLockUser)
        Me.gbAuth.Controls.Add(Me.cboGp_for_Users)
        Me.gbAuth.Controls.Add(Me.bnUsers)
        Me.gbAuth.Controls.Add(Me.txtUid)
        Me.gbAuth.Controls.Add(Me.spltHelp)
        Me.gbAuth.Controls.Add(lblUserName)
        Me.gbAuth.Controls.Add(Me.UserNameTextBox)
        Me.gbAuth.Controls.Add(lblFullName)
        Me.gbAuth.Controls.Add(Me.FullNameTextBox)
        Me.gbAuth.Controls.Add(lblPassword)
        Me.gbAuth.Controls.Add(Me.PasswordTextBox)
        Me.gbAuth.Controls.Add(lblConfirm)
        Me.gbAuth.Controls.Add(Me.UserGroupTextBox)
        Me.gbAuth.Controls.Add(lblGP)
        Me.gbAuth.Controls.Add(Me.btnResetPass)
        Me.gbAuth.Location = New System.Drawing.Point(3, 3)
        Me.gbAuth.Name = "gbAuth"
        Me.gbAuth.Size = New System.Drawing.Size(544, 277)
        Me.gbAuth.TabIndex = 15
        Me.gbAuth.TabStop = False
        '
        'btnChangGroup
        '
        Me.btnChangGroup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChangGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangGroup.Location = New System.Drawing.Point(346, 247)
        Me.btnChangGroup.Name = "btnChangGroup"
        Me.btnChangGroup.Size = New System.Drawing.Size(110, 24)
        Me.btnChangGroup.TabIndex = 117
        Me.btnChangGroup.Text = "Change Group"
        Me.btnChangGroup.UseVisualStyleBackColor = True
        '
        'lbusers
        '
        Me.lbusers.FormattingEnabled = True
        Me.lbusers.Location = New System.Drawing.Point(336, 36)
        Me.lbusers.Name = "lbusers"
        Me.lbusers.Size = New System.Drawing.Size(185, 17)
        Me.lbusers.TabIndex = 116
        Me.lbusers.Visible = False
        '
        'txtUserSearch
        '
        Me.txtUserSearch.Location = New System.Drawing.Point(336, 16)
        Me.txtUserSearch.Name = "txtUserSearch"
        Me.txtUserSearch.Size = New System.Drawing.Size(185, 20)
        Me.txtUserSearch.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "UserSearch"
        '
        'btnLockUser
        '
        Me.btnLockUser.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLockUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLockUser.Location = New System.Drawing.Point(59, 247)
        Me.btnLockUser.Name = "btnLockUser"
        Me.btnLockUser.Size = New System.Drawing.Size(139, 24)
        Me.btnLockUser.TabIndex = 113
        Me.btnLockUser.Text = "Lock / UnLock User"
        Me.btnLockUser.UseVisualStyleBackColor = True
        '
        'cboGp_for_Users
        '
        Me.cboGp_for_Users.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboGp_for_Users.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGp_for_Users.BackColor = System.Drawing.Color.LightYellow
        Me.cboGp_for_Users.DataSource = Me.UserGroupsBindingSource
        Me.cboGp_for_Users.DisplayMember = "Description"
        Me.cboGp_for_Users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGp_for_Users.ForeColor = System.Drawing.Color.Black
        Me.cboGp_for_Users.FormattingEnabled = True
        Me.cboGp_for_Users.Location = New System.Drawing.Point(146, 64)
        Me.cboGp_for_Users.Name = "cboGp_for_Users"
        Me.cboGp_for_Users.Size = New System.Drawing.Size(221, 21)
        Me.cboGp_for_Users.TabIndex = 0
        Me.cboGp_for_Users.ValueMember = "Ugp_UserGroup"
        '
        'bnUsers
        '
        Me.bnUsers.AddNewItem = Me.AddNew
        Me.bnUsers.BindingSource = Me.UsersBindingSource
        Me.bnUsers.CountItem = Me.BindingNavigatorCountItem1
        Me.bnUsers.DeleteItem = Nothing
        Me.bnUsers.Dock = System.Windows.Forms.DockStyle.None
        Me.bnUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.AddNew})
        Me.bnUsers.Location = New System.Drawing.Point(3, 16)
        Me.bnUsers.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.bnUsers.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.bnUsers.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.bnUsers.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.bnUsers.Name = "bnUsers"
        Me.bnUsers.PositionItem = Me.BindingNavigatorPositionItem1
        Me.bnUsers.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.bnUsers.Size = New System.Drawing.Size(232, 25)
        Me.bnUsers.TabIndex = 112
        Me.bnUsers.Text = "BindingNavigator1"
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
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.DsSecurity
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
        'txtUid
        '
        Me.txtUid.BackColor = System.Drawing.SystemColors.Control
        Me.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUid.ForeColor = System.Drawing.SystemColors.Control
        Me.txtUid.Location = New System.Drawing.Point(6, 65)
        Me.txtUid.Name = "txtUid"
        Me.txtUid.ReadOnly = True
        Me.txtUid.Size = New System.Drawing.Size(10, 13)
        Me.txtUid.TabIndex = 16
        Me.txtUid.TabStop = False
        '
        'spltHelp
        '
        Me.spltHelp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spltHelp.Location = New System.Drawing.Point(429, 173)
        Me.spltHelp.Name = "spltHelp"
        '
        'spltHelp.Panel1
        '
        Me.spltHelp.Panel1.Controls.Add(Me.rtbHelp)
        Me.spltHelp.Size = New System.Drawing.Size(92, 56)
        Me.spltHelp.SplitterDistance = 63
        Me.spltHelp.TabIndex = 84
        '
        'rtbHelp
        '
        Me.rtbHelp.BackColor = System.Drawing.SystemColors.Control
        Me.rtbHelp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbHelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbHelp.ForeColor = System.Drawing.Color.LemonChiffon
        Me.rtbHelp.Location = New System.Drawing.Point(0, 0)
        Me.rtbHelp.Name = "rtbHelp"
        Me.rtbHelp.ReadOnly = True
        Me.rtbHelp.Size = New System.Drawing.Size(63, 56)
        Me.rtbHelp.TabIndex = 84
        Me.rtbHelp.TabStop = False
        Me.rtbHelp.Text = ""
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Usr_User", True))
        Me.UserNameTextBox.Enabled = False
        Me.UserNameTextBox.Location = New System.Drawing.Point(146, 101)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(221, 20)
        Me.UserNameTextBox.TabIndex = 1
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Usr_FullName", True))
        Me.FullNameTextBox.Location = New System.Drawing.Point(146, 137)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(221, 20)
        Me.FullNameTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Usr_Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(146, 173)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(221, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'UserGroupTextBox
        '
        Me.UserGroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Usr_Password", True))
        Me.UserGroupTextBox.Location = New System.Drawing.Point(146, 209)
        Me.UserGroupTextBox.Name = "UserGroupTextBox"
        Me.UserGroupTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UserGroupTextBox.Size = New System.Drawing.Size(221, 20)
        Me.UserGroupTextBox.TabIndex = 4
        '
        'btnResetPass
        '
        Me.btnResetPass.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResetPass.Location = New System.Drawing.Point(220, 247)
        Me.btnResetPass.Name = "btnResetPass"
        Me.btnResetPass.Size = New System.Drawing.Size(110, 24)
        Me.btnResetPass.TabIndex = 5
        Me.btnResetPass.Text = "Reset Password"
        Me.btnResetPass.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BindingNavigator1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(550, 283)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Components"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.ComponentsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(544, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'ComponentsBindingSource
        '
        Me.ComponentsBindingSource.DataMember = "Components"
        Me.ComponentsBindingSource.DataSource = Me.DsComponents
        '
        'DsComponents
        '
        Me.DsComponents.DataSetName = "dsComponents"
        Me.DsComponents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompAccessIdDataGridViewTextBoxColumn, Me.CompCompNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ComponentsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(3, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(498, 249)
        Me.DataGridView1.TabIndex = 0
        '
        'CompAccessIdDataGridViewTextBoxColumn
        '
        Me.CompAccessIdDataGridViewTextBoxColumn.DataPropertyName = "Comp_AccessId"
        Me.CompAccessIdDataGridViewTextBoxColumn.HeaderText = "Comp_AccessId"
        Me.CompAccessIdDataGridViewTextBoxColumn.Name = "CompAccessIdDataGridViewTextBoxColumn"
        Me.CompAccessIdDataGridViewTextBoxColumn.Width = 109
        '
        'CompCompNameDataGridViewTextBoxColumn
        '
        Me.CompCompNameDataGridViewTextBoxColumn.DataPropertyName = "Comp_CompName"
        Me.CompCompNameDataGridViewTextBoxColumn.HeaderText = "Comp_CompName"
        Me.CompCompNameDataGridViewTextBoxColumn.Name = "CompCompNameDataGridViewTextBoxColumn"
        Me.CompCompNameDataGridViewTextBoxColumn.Width = 120
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(395, 341)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(134, 39)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tmr
        '
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Location = New System.Drawing.Point(255, 341)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 39)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ttOne
        '
        Me.ttOne.AutoPopDelay = 5000
        Me.ttOne.InitialDelay = 3000
        Me.ttOne.ReshowDelay = 100
        Me.ttOne.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttOne.ToolTipTitle = "atlantic assistant"
        '
        'ComponentsTableAdapter
        '
        Me.ComponentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ComponentsTableAdapter = Me.ComponentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = dsComponentsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UserAuthorisationsBindingSource
        '
        Me.UserAuthorisationsBindingSource.DataMember = "UserAuthorisations"
        Me.UserAuthorisationsBindingSource.DataSource = Me.DsSecurity
        '
        'UserAuthorisationsTableAdapter
        '
        Me.UserAuthorisationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = dsSecurityTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UserAuthorisationsTableAdapter = Me.UserAuthorisationsTableAdapter
        Me.TableAdapterManager1.UserGroups1TableAdapter = Me.UserGroups1TableAdapter
        Me.TableAdapterManager1.UsersTableAdapter = Me.UsersTableAdapter
        '
        'UserGroups1TableAdapter
        '
        Me.UserGroups1TableAdapter.ClearBeforeFill = True
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'UserGroupsTableAdapter
        '
        Me.UserGroupsTableAdapter.ClearBeforeFill = True
        '
        'frmUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 387)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.gbOne)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                               User Creation, Editing"
        Me.gbOne.ResumeLayout(False)
        Me.tbOne.ResumeLayout(False)
        Me.tbGroups.ResumeLayout(False)
        Me.gbCC.ResumeLayout(False)
        Me.gbCC.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.UserGroups1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSecurity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGroups1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnUserGp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnUserGp.ResumeLayout(False)
        Me.bnUserGp.PerformLayout()
        CType(Me.dgvUserGps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbAuthorization.ResumeLayout(False)
        Me.gbGD.ResumeLayout(False)
        CType(Me.UserGroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbUsers.ResumeLayout(False)
        Me.gbAuth.ResumeLayout(False)
        Me.gbAuth.PerformLayout()
        CType(Me.bnUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnUsers.ResumeLayout(False)
        Me.bnUsers.PerformLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltHelp.Panel1.ResumeLayout(False)
        Me.spltHelp.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.ComponentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsComponents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAuthorisationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbOne As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    ' Friend WithEvents DsSecurity AsdsSecurity
    'Friend WithEvents TaUserGroups AsdsSecurityTableAdapters.UserGroupsTableAdapter
    Friend WithEvents tmr As System.Windows.Forms.Timer
    ' Friend WithEvents TaUsers AsdsSecurityTableAdapters.UsersTableAdapter
    Friend WithEvents tbOne As System.Windows.Forms.TabControl
    Friend WithEvents tbGroups As System.Windows.Forms.TabPage
    Friend WithEvents gbCC As System.Windows.Forms.GroupBox

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bnUserGp As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents delgp As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents savegp As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvUserGps As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbAuthorization As System.Windows.Forms.TabPage
    Friend WithEvents gbGD As System.Windows.Forms.GroupBox
    Friend WithEvents lblSelectGp As System.Windows.Forms.Label
    Friend WithEvents cboGp As System.Windows.Forms.ComboBox
    Friend WithEvents tbUsers As System.Windows.Forms.TabPage
    Friend WithEvents gbAuth As System.Windows.Forms.GroupBox
    Friend WithEvents txtUid As System.Windows.Forms.TextBox
    Friend WithEvents spltHelp As System.Windows.Forms.SplitContainer

    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserGroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cboGp_for_Users As System.Windows.Forms.ComboBox
    Friend WithEvents btnResetPass As System.Windows.Forms.Button
    Friend WithEvents UgpGroupNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    ' Friend WithEvents DsComponents AsdsComponents
    ' Friend WithEvents ComponentsTableAdapter AsdsComponentsTableAdapters.ComponentsTableAdapter
    Friend WithEvents clstAuth As System.Windows.Forms.CheckedListBox
    ' Friend WithEvents UserAuthorisationsTableAdapter AsdsSecurityTableAdapters.UserAuthorisationsTableAdapter
    Friend WithEvents bnUsers As System.Windows.Forms.BindingNavigator
    Friend WithEvents AddNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents rtbHelp As System.Windows.Forms.RichTextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UgpUserGroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ttOne As System.Windows.Forms.ToolTip
    Friend WithEvents DsComponents As dsComponents
    Friend WithEvents ComponentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComponentsTableAdapter As dsComponentsTableAdapters.ComponentsTableAdapter
    Friend WithEvents TableAdapterManager As dsComponentsTableAdapters.TableAdapterManager
    Friend WithEvents DsSecurity As dsSecurity
    Friend WithEvents UserAuthorisationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserAuthorisationsTableAdapter As dsSecurityTableAdapters.UserAuthorisationsTableAdapter
    Friend WithEvents TableAdapterManager1 As dsSecurityTableAdapters.TableAdapterManager
    Friend WithEvents UserGroupsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserGroupsTableAdapter As dsSecurityTableAdapters.UserGroupsTableAdapter
    Friend WithEvents UsersTableAdapter As dsSecurityTableAdapters.UsersTableAdapter
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompAccessIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompCompNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserGroups1TableAdapter As dsSecurityTableAdapters.UserGroups1TableAdapter
    Friend WithEvents UserGroups1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserGroups1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ugp_GroupName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLockUser As System.Windows.Forms.Button
    Friend WithEvents lbusers As System.Windows.Forms.ListBox
    Friend WithEvents txtUserSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnChangGroup As System.Windows.Forms.Button
End Class
