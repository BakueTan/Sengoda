<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvUpload
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboInvUpterm = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboInvupCart = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboInvupFrm = New System.Windows.Forms.ComboBox
        Me.cboInvupintk = New System.Windows.Forms.ComboBox
        Me.cboInvupprog = New System.Windows.Forms.ComboBox
        Me.cboInvUpClas = New System.Windows.Forms.ComboBox
        '    Me.DsStudentSearches = New SMS.dsStudentSearches
        '  Me.PaymentTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '    Me.PaymentTypeTableAdapter = New SMS.dsStudentSearchesTableAdapters.PaymentTypeTableAdapter
        '    Me.FormsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.FormsTableAdapter = New SMS.dsStudentSearchesTableAdapters.formsTableAdapter
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        '  Me.SchoolDataSet = New SMS.schoolDataSet
        '    Me.PaymentType1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '   Me.PaymentType1TableAdapter = New SMS.schoolDataSetTableAdapters.PaymentType1TableAdapter
        '   Me.PaymentType2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '   Me.PaymentType2TableAdapter = New SMS.schoolDataSetTableAdapters.PaymentType2TableAdapter
        '  CType(Me.DsStudentSearches, System.ComponentModel.ISupportInitialize).BeginInit()
        ' C 'ype(Me.PaymentTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        '   CType(Me.FormsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        '  '  CType(Me.PaymentType2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Term"
        '
        'cboInvUpterm
        '
        Me.cboInvUpterm.FormattingEnabled = True
        Me.cboInvUpterm.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboInvUpterm.Location = New System.Drawing.Point(121, 150)
        Me.cboInvUpterm.Name = "cboInvUpterm"
        Me.cboInvUpterm.Size = New System.Drawing.Size(121, 21)
        Me.cboInvUpterm.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Cartegory"
        '
        'cboInvupCart
        '
        '   Me.cboInvupCart.DataSource = Me.PaymentType2BindingSource
        Me.cboInvupCart.DisplayMember = "Payment"
        Me.cboInvupCart.FormattingEnabled = True
        Me.cboInvupCart.Location = New System.Drawing.Point(121, 177)
        Me.cboInvupCart.Name = "cboInvupCart"
        Me.cboInvupCart.Size = New System.Drawing.Size(121, 21)
        Me.cboInvupCart.TabIndex = 21
        Me.cboInvupCart.ValueMember = "Payment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Form"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Intake"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Program"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Class"
        '
        'cboInvupFrm
        '
        Me.cboInvupFrm.FormattingEnabled = True
        Me.cboInvupFrm.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboInvupFrm.Location = New System.Drawing.Point(121, 124)
        Me.cboInvupFrm.Name = "cboInvupFrm"
        Me.cboInvupFrm.Size = New System.Drawing.Size(121, 21)
        Me.cboInvupFrm.TabIndex = 16
        Me.cboInvupFrm.ValueMember = "Forms"
        '
        'cboInvupintk
        '
        Me.cboInvupintk.FormattingEnabled = True
        Me.cboInvupintk.Items.AddRange(New Object() {"January", "February"})
        Me.cboInvupintk.Location = New System.Drawing.Point(121, 97)
        Me.cboInvupintk.Name = "cboInvupintk"
        Me.cboInvupintk.Size = New System.Drawing.Size(121, 21)
        Me.cboInvupintk.TabIndex = 15
        '
        'cboInvupprog
        '
        '  Me.cboInvupprog.DataSource = Me.FormsBindingSource
        Me.cboInvupprog.DisplayMember = "Forms"
        Me.cboInvupprog.FormattingEnabled = True
        Me.cboInvupprog.Location = New System.Drawing.Point(121, 70)
        Me.cboInvupprog.Name = "cboInvupprog"
        Me.cboInvupprog.Size = New System.Drawing.Size(121, 21)
        Me.cboInvupprog.TabIndex = 14
        Me.cboInvupprog.ValueMember = "Forms"
        '
        'cboInvUpClas
        '
        Me.cboInvUpClas.FormattingEnabled = True
        Me.cboInvUpClas.Items.AddRange(New Object() {"2015", "2016", "2017"})
        Me.cboInvUpClas.Location = New System.Drawing.Point(121, 43)
        Me.cboInvUpClas.Name = "cboInvUpClas"
        Me.cboInvUpClas.Size = New System.Drawing.Size(121, 21)
        Me.cboInvUpClas.TabIndex = 13
        '
        'DsStudentSearches
        '
        '      Me.DsStudentSearches.DataSetName = "dsStudentSearches"
        'Me.DsStudentSearches.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentTypeBindingSource
        '
        '   Me.PaymentTypeBindingSource.DataMember = "PaymentType"
        '    Me.PaymentTypeBindingSource.DataSource = Me.DsStudentSearches
        '
        'PaymentTypeTableAdapter
        '
        '  Me.PaymentTypeTableAdapter.ClearBeforeFill = True
        '
        'FormsBindingSource
        '
        '    Me.FormsBindingSource.DataMember = "forms"
        '    '
        'FormsTableAdapter
        '
        '   Me.FormsTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SchoolDataSet
        '
        '     Me.SchoolDataSet.DataSetName = "schoolDataSet"
        ' Me.SchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentType1BindingSource
        '
        '    Me.PaymentType1BindingSource.DataMember = "PaymentType1"
        '       Me.PaymentType1BindingSource.DataSource = Me.SchoolDataSet
        '
        'PaymentType1TableAdapter
        '
        '    Me.PaymentType1TableAdapter.ClearBeforeFill = True
        '
        'PaymentType2BindingSource
        '
        '    Me.PaymentType2BindingSource.DataMember = "PaymentType2"
        '    Me.PaymentType2BindingSource.DataSource = Me.SchoolDataSet
        '
        'PaymentType2TableAdapter
        '
        '  Me.PaymentType2TableAdapter.ClearBeforeFill = True
        '
        'frmInvUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 304)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboInvUpterm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboInvupCart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboInvupFrm)
        Me.Controls.Add(Me.cboInvupintk)
        Me.Controls.Add(Me.cboInvupprog)
        Me.Controls.Add(Me.cboInvUpClas)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmInvUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInvUpload"
        '   CType(Me.DsStudentSearches, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.PaymentTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        ' CType(Me.FormsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '   CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        '    CType(Me.PaymentType1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '   CType(Me.PaymentType2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboInvUpterm As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboInvupCart As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboInvupFrm As System.Windows.Forms.ComboBox
    Friend WithEvents cboInvupintk As System.Windows.Forms.ComboBox
    Friend WithEvents cboInvupprog As System.Windows.Forms.ComboBox
    Friend WithEvents cboInvUpClas As System.Windows.Forms.ComboBox
    '    Friend WithEvents DsStudentSearches As SMS.dsStudentSearches
    '  Friend WithEvents PaymentTypeBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents PaymentTypeTableAdapter As SMS.dsStudentSearchesTableAdapters.PaymentTypeTableAdapter
    '  Friend WithEvents FormsBindingSource As System.Windows.Forms.BindingSource
    '   Friend WithEvents FormsTableAdapter As SMS.dsStudentSearchesTableAdapters.formsTableAdapter
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    '   Friend WithEvents SchoolDataSet As SMS.schoolDataSet
    '  Friend WithEvents PaymentType1BindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents PaymentType1TableAdapter As SMS.schoolDataSetTableAdapters.PaymentType1TableAdapter
    '  Friend WithEvents PaymentType2BindingSource As System.Windows.Forms.BindingSource
    '   Friend WithEvents PaymentType2TableAdapter As SMS.schoolDataSetTableAdapters.PaymentType2TableAdapter
End Class
