<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecup_2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboRecUpClas = New System.Windows.Forms.ComboBox()
        Me.cborecupprog = New System.Windows.Forms.ComboBox()
        Me.cborecupFrm = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cborecupCart = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbpRecUpPeriod = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboRecUpClas
        '
        Me.cboRecUpClas.FormattingEnabled = True
        Me.cboRecUpClas.Location = New System.Drawing.Point(103, 55)
        Me.cboRecUpClas.Name = "cboRecUpClas"
        Me.cboRecUpClas.Size = New System.Drawing.Size(121, 21)
        Me.cboRecUpClas.TabIndex = 1
        '
        'cborecupprog
        '
        Me.cborecupprog.DisplayMember = "Forms"
        Me.cborecupprog.FormattingEnabled = True
        Me.cborecupprog.Location = New System.Drawing.Point(103, 82)
        Me.cborecupprog.Name = "cborecupprog"
        Me.cborecupprog.Size = New System.Drawing.Size(121, 21)
        Me.cborecupprog.TabIndex = 2
        Me.cborecupprog.ValueMember = "Forms"
        '
        'cborecupFrm
        '
        Me.cborecupFrm.FormattingEnabled = True
        Me.cborecupFrm.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cborecupFrm.Location = New System.Drawing.Point(103, 109)
        Me.cborecupFrm.Name = "cborecupFrm"
        Me.cborecupFrm.Size = New System.Drawing.Size(121, 21)
        Me.cborecupFrm.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Class:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Program:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Level:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cartegory:"
        '
        'cborecupCart
        '
        Me.cborecupCart.DisplayMember = "Payment"
        Me.cborecupCart.FormattingEnabled = True
        Me.cborecupCart.Location = New System.Drawing.Point(103, 142)
        Me.cborecupCart.Name = "cborecupCart"
        Me.cborecupCart.Size = New System.Drawing.Size(121, 21)
        Me.cborecupCart.TabIndex = 9
        Me.cborecupCart.ValueMember = "Payment"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Period:"
        '
        'cbpRecUpPeriod
        '
        Me.cbpRecUpPeriod.DisplayMember = "Payment"
        Me.cbpRecUpPeriod.FormattingEnabled = True
        Me.cbpRecUpPeriod.Location = New System.Drawing.Point(103, 170)
        Me.cbpRecUpPeriod.Name = "cbpRecUpPeriod"
        Me.cbpRecUpPeriod.Size = New System.Drawing.Size(121, 21)
        Me.cbpRecUpPeriod.TabIndex = 11
        Me.cbpRecUpPeriod.ValueMember = "Payment"
        '
        'frmRecup_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 298)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbpRecUpPeriod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cborecupCart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cborecupFrm)
        Me.Controls.Add(Me.cborecupprog)
        Me.Controls.Add(Me.cboRecUpClas)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmRecup_2"
        Me.Text = "Upload Receipts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboRecUpClas As System.Windows.Forms.ComboBox
    Friend WithEvents cborecupprog As System.Windows.Forms.ComboBox
    Friend WithEvents cborecupFrm As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cborecupCart As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFileDialog1 As Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents cbpRecUpPeriod As Windows.Forms.ComboBox
    '  Friend WithEvents DsStudentSearches As SMS.dsStudentSearches
    '   Friend WithEvents FormsBindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents FormsTableAdapter As SMS.dsStudentSearchesTableAdapters.formsTableAdapter
    '  Friend WithEvents SchoolDataSet As SMS.schoolDataSet
    '  Friend WithEvents PaymentTypeBindingSource As System.Windows.Forms.BindingSource
    '   Friend WithEvents PaymentTypeTableAdapter As SMS.schoolDataSetTableAdapters.PaymentTypeTableAdapter
End Class
