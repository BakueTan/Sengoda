<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
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
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.lbChangePaswed = New System.Windows.Forms.Label()
        Me.txtChangPaswed = New System.Windows.Forms.TextBox()
        Me.btnChangePaswed = New System.Windows.Forms.Button()
        Me.lbNewPasswed = New System.Windows.Forms.Label()
        Me.txtNewPasswed = New System.Windows.Forms.TextBox()
        Me.pnlChangePaswed = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlChangePaswed.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Black
        Me.PasswordLabel.Location = New System.Drawing.Point(98, 103)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(180, 29)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UsernameTextBox.Location = New System.Drawing.Point(101, 76)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(215, 24)
        Me.UsernameTextBox.TabIndex = 0
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PasswordTextBox.Location = New System.Drawing.Point(101, 135)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(215, 24)
        Me.PasswordTextBox.TabIndex = 1
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OK.Location = New System.Drawing.Point(101, 206)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(107, 41)
        Me.OK.TabIndex = 3
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(209, 206)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(107, 41)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "&CANCEL"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(98, 44)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(180, 29)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbChangePaswed
        '
        Me.lbChangePaswed.BackColor = System.Drawing.Color.Transparent
        Me.lbChangePaswed.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbChangePaswed.ForeColor = System.Drawing.Color.Black
        Me.lbChangePaswed.Location = New System.Drawing.Point(3, 59)
        Me.lbChangePaswed.Name = "lbChangePaswed"
        Me.lbChangePaswed.Size = New System.Drawing.Size(180, 29)
        Me.lbChangePaswed.TabIndex = 6
        Me.lbChangePaswed.Text = "&Confirm Password"
        Me.lbChangePaswed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtChangPaswed
        '
        Me.txtChangPaswed.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtChangPaswed.Location = New System.Drawing.Point(3, 91)
        Me.txtChangPaswed.Name = "txtChangPaswed"
        Me.txtChangPaswed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtChangPaswed.Size = New System.Drawing.Size(215, 24)
        Me.txtChangPaswed.TabIndex = 1
        '
        'btnChangePaswed
        '
        Me.btnChangePaswed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangePaswed.BackColor = System.Drawing.Color.Transparent
        Me.btnChangePaswed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangePaswed.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnChangePaswed.ForeColor = System.Drawing.Color.Black
        Me.btnChangePaswed.Location = New System.Drawing.Point(101, 253)
        Me.btnChangePaswed.Name = "btnChangePaswed"
        Me.btnChangePaswed.Size = New System.Drawing.Size(215, 25)
        Me.btnChangePaswed.TabIndex = 9
        Me.btnChangePaswed.Text = ">> CHANGE PASSWORD <<"
        Me.btnChangePaswed.UseVisualStyleBackColor = False
        '
        'lbNewPasswed
        '
        Me.lbNewPasswed.BackColor = System.Drawing.Color.Transparent
        Me.lbNewPasswed.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbNewPasswed.ForeColor = System.Drawing.Color.Black
        Me.lbNewPasswed.Location = New System.Drawing.Point(16, 0)
        Me.lbNewPasswed.Name = "lbNewPasswed"
        Me.lbNewPasswed.Size = New System.Drawing.Size(167, 29)
        Me.lbNewPasswed.TabIndex = 4
        Me.lbNewPasswed.Text = "&New Password"
        Me.lbNewPasswed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNewPasswed
        '
        Me.txtNewPasswed.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtNewPasswed.Location = New System.Drawing.Point(3, 32)
        Me.txtNewPasswed.Name = "txtNewPasswed"
        Me.txtNewPasswed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPasswed.Size = New System.Drawing.Size(215, 24)
        Me.txtNewPasswed.TabIndex = 0
        '
        'pnlChangePaswed
        '
        Me.pnlChangePaswed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlChangePaswed.BackColor = System.Drawing.Color.Transparent
        Me.pnlChangePaswed.Controls.Add(Me.txtNewPasswed)
        Me.pnlChangePaswed.Controls.Add(Me.lbNewPasswed)
        Me.pnlChangePaswed.Controls.Add(Me.lbChangePaswed)
        Me.pnlChangePaswed.Controls.Add(Me.txtChangPaswed)
        Me.pnlChangePaswed.Location = New System.Drawing.Point(79, 160)
        Me.pnlChangePaswed.Name = "pnlChangePaswed"
        Me.pnlChangePaswed.Size = New System.Drawing.Size(16, 14)
        Me.pnlChangePaswed.TabIndex = 2
        Me.pnlChangePaswed.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(131, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Login to continue."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RevoEdu.My.Resources.Resources.Imela
        Me.PictureBox1.Location = New System.Drawing.Point(2, 281)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.RevoEdu.My.Resources.Resources.Keys_1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(101, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 32)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Logged In Users: "
        '
        'frmLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(420, 313)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlChangePaswed)
        Me.Controls.Add(Me.btnChangePaswed)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  TAMS"
        Me.pnlChangePaswed.ResumeLayout(False)
        Me.pnlChangePaswed.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents lbChangePaswed As System.Windows.Forms.Label
    Friend WithEvents txtChangPaswed As System.Windows.Forms.TextBox
    Friend WithEvents btnChangePaswed As System.Windows.Forms.Button
    Friend WithEvents lbNewPasswed As System.Windows.Forms.Label
    Friend WithEvents txtNewPasswed As System.Windows.Forms.TextBox
    Friend WithEvents pnlChangePaswed As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
