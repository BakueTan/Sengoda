<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudBalances
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
        Me.lbTimer = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.PictureBox_V = New System.Windows.Forms.PictureBox
        Me.lbDevStatus = New System.Windows.Forms.Label
        Me.lbCofirmName = New System.Windows.Forms.Label
        Me.btnScan = New System.Windows.Forms.Button
        Me.rbBiometric = New System.Windows.Forms.RadioButton
        Me.rbIDScanner = New System.Windows.Forms.RadioButton
        Me.txtStudID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboCutOffPeriod = New System.Windows.Forms.ComboBox
        '      Me.PaymentPeriodsPastelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '     Me.DsSchool = New SMS.dsSchool
        'Me.PaymentPeriodsPastelTableAdapter = New SMS.dsSchoolTableAdapters.PaymentPeriodsPastelTableAdapter
        '    Me.PaymentPeriodsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.PaymentPeriodsTableAdapter = New SMS.dsSchoolTableAdapters.PaymentPeriodsTableAdapter
        CType(Me.PictureBox_V, System.ComponentModel.ISupportInitialize).BeginInit()
        '    CType(Me.PaymentPeriodsPastelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        '     CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        '    CType(Me.PaymentPeriodsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbTimer
        '
        Me.lbTimer.AutoSize = True
        Me.lbTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbTimer.Location = New System.Drawing.Point(469, 103)
        Me.lbTimer.Name = "lbTimer"
        Me.lbTimer.Size = New System.Drawing.Size(0, 24)
        Me.lbTimer.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(459, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 26)
        Me.Label12.TabIndex = 3
        '
        'PictureBox_V
        '
        Me.PictureBox_V.BackColor = System.Drawing.Color.White
        Me.PictureBox_V.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_V.Location = New System.Drawing.Point(43, 44)
        Me.PictureBox_V.Name = "PictureBox_V"
        Me.PictureBox_V.Size = New System.Drawing.Size(364, 306)
        Me.PictureBox_V.TabIndex = 0
        Me.PictureBox_V.TabStop = False
        '
        'lbDevStatus
        '
        Me.lbDevStatus.AutoSize = True
        Me.lbDevStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDevStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbDevStatus.Location = New System.Drawing.Point(469, 170)
        Me.lbDevStatus.Name = "lbDevStatus"
        Me.lbDevStatus.Size = New System.Drawing.Size(0, 24)
        Me.lbDevStatus.TabIndex = 4
        '
        'lbCofirmName
        '
        Me.lbCofirmName.AutoSize = True
        Me.lbCofirmName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCofirmName.Location = New System.Drawing.Point(39, 362)
        Me.lbCofirmName.Name = "lbCofirmName"
        Me.lbCofirmName.Size = New System.Drawing.Size(0, 24)
        Me.lbCofirmName.TabIndex = 5
        '
        'btnScan
        '
        Me.btnScan.Location = New System.Drawing.Point(543, 315)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(158, 35)
        Me.btnScan.TabIndex = 6
        Me.btnScan.Text = "StartScan"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'rbBiometric
        '
        Me.rbBiometric.AutoSize = True
        Me.rbBiometric.Checked = True
        Me.rbBiometric.Location = New System.Drawing.Point(473, 57)
        Me.rbBiometric.Name = "rbBiometric"
        Me.rbBiometric.Size = New System.Drawing.Size(108, 17)
        Me.rbBiometric.TabIndex = 7
        Me.rbBiometric.TabStop = True
        Me.rbBiometric.Text = "BiometricScanner"
        Me.rbBiometric.UseVisualStyleBackColor = True
        '
        'rbIDScanner
        '
        Me.rbIDScanner.AutoSize = True
        Me.rbIDScanner.Location = New System.Drawing.Point(650, 57)
        Me.rbIDScanner.Name = "rbIDScanner"
        Me.rbIDScanner.Size = New System.Drawing.Size(74, 17)
        Me.rbIDScanner.TabIndex = 8
        Me.rbIDScanner.Text = "IDscanner"
        Me.rbIDScanner.UseVisualStyleBackColor = True
        '
        'txtStudID
        '
        Me.txtStudID.Enabled = False
        Me.txtStudID.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.Location = New System.Drawing.Point(464, 112)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.Size = New System.Drawing.Size(230, 30)
        Me.txtStudID.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(713, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "CutOffPeriod"
        '
        'cboCutOffPeriod
        '
        Me.cboCutOffPeriod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCutOffPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCutOffPeriod.DataSource = Me.PaymentPeriodsBindingSource
        Me.cboCutOffPeriod.DisplayMember = "Description"
        Me.cboCutOffPeriod.FormattingEnabled = True
        Me.cboCutOffPeriod.Location = New System.Drawing.Point(786, 119)
        Me.cboCutOffPeriod.Name = "cboCutOffPeriod"
        Me.cboCutOffPeriod.Size = New System.Drawing.Size(121, 21)
        Me.cboCutOffPeriod.TabIndex = 11
        Me.cboCutOffPeriod.ValueMember = "Period"
        '
        'PaymentPeriodsPastelBindingSource
        '
        Me.PaymentPeriodsPastelBindingSource.DataMember = "PaymentPeriodsPastel"
        Me.PaymentPeriodsPastelBindingSource.DataSource = Me.DsSchool
        '
        'DsSchool
        '
        Me.DsSchool.DataSetName = "dsSchool"
        Me.DsSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentPeriodsPastelTableAdapter
        '

        '
        'PaymentPeriodsBindingSource
        '
        Me.PaymentPeriodsBindingSource.DataMember = "PaymentPeriods"
        Me.PaymentPeriodsBindingSource.DataSource = Me.DsSchool
        '
        'PaymentPeriodsTableAdapter
        '

        '
        'frmStudBalances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 421)
        Me.Controls.Add(Me.cboCutOffPeriod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStudID)
        Me.Controls.Add(Me.rbIDScanner)
        Me.Controls.Add(Me.rbBiometric)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.lbCofirmName)
        Me.Controls.Add(Me.lbDevStatus)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbTimer)
        Me.Controls.Add(Me.PictureBox_V)
        Me.Name = "frmStudBalances"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckFeesBalances "
        CType(Me.PictureBox_V, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentPeriodsPastelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentPeriodsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_V As System.Windows.Forms.PictureBox
    Friend WithEvents lbTimer As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbDevStatus As System.Windows.Forms.Label
    Friend WithEvents lbCofirmName As System.Windows.Forms.Label
    Friend WithEvents btnScan As System.Windows.Forms.Button
    Friend WithEvents rbBiometric As System.Windows.Forms.RadioButton
    Friend WithEvents rbIDScanner As System.Windows.Forms.RadioButton
    Friend WithEvents txtStudID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCutOffPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents DsSchool As dsSchool
    Friend WithEvents PaymentPeriodsPastelBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents PaymentPeriodsBindingSource As System.Windows.Forms.BindingSource

End Class
