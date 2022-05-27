<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiptUpload_1
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
        Me.cboClsUpCls = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboclsUpFrm = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboClsUpSess = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboClsUpProg = New System.Windows.Forms.ComboBox()
        Me.btnUploadStydents = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'cboClsUpCls
        '
        Me.cboClsUpCls.FormattingEnabled = True
        Me.cboClsUpCls.Location = New System.Drawing.Point(70, 132)
        Me.cboClsUpCls.Name = "cboClsUpCls"
        Me.cboClsUpCls.Size = New System.Drawing.Size(121, 21)
        Me.cboClsUpCls.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Level"
        '
        'cboclsUpFrm
        '
        Me.cboclsUpFrm.FormattingEnabled = True
        Me.cboclsUpFrm.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboclsUpFrm.Location = New System.Drawing.Point(70, 64)
        Me.cboclsUpFrm.Name = "cboclsUpFrm"
        Me.cboclsUpFrm.Size = New System.Drawing.Size(121, 21)
        Me.cboclsUpFrm.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Session"
        '
        'cboClsUpSess
        '
        Me.cboClsUpSess.DisplayMember = "Session"
        Me.cboClsUpSess.FormattingEnabled = True
        Me.cboClsUpSess.Location = New System.Drawing.Point(70, 96)
        Me.cboClsUpSess.Name = "cboClsUpSess"
        Me.cboClsUpSess.Size = New System.Drawing.Size(121, 21)
        Me.cboClsUpSess.TabIndex = 8
        Me.cboClsUpSess.ValueMember = "Session"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Program"
        '
        'cboClsUpProg
        '
        Me.cboClsUpProg.DisplayMember = "Forms"
        Me.cboClsUpProg.FormattingEnabled = True
        Me.cboClsUpProg.Location = New System.Drawing.Point(70, 31)
        Me.cboClsUpProg.Name = "cboClsUpProg"
        Me.cboClsUpProg.Size = New System.Drawing.Size(121, 21)
        Me.cboClsUpProg.TabIndex = 10
        Me.cboClsUpProg.ValueMember = "Forms"
        '
        'btnUploadStydents
        '
        Me.btnUploadStydents.Location = New System.Drawing.Point(70, 179)
        Me.btnUploadStydents.Name = "btnUploadStydents"
        Me.btnUploadStydents.Size = New System.Drawing.Size(96, 28)
        Me.btnUploadStydents.TabIndex = 12
        Me.btnUploadStydents.Text = "Upload"
        Me.btnUploadStydents.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmReceiptUpload_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 236)
        Me.Controls.Add(Me.btnUploadStydents)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboClsUpProg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboClsUpSess)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboclsUpFrm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboClsUpCls)
        Me.Name = "frmReceiptUpload_1"
        Me.Text = "Class Upload"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboClsUpCls As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboclsUpFrm As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboClsUpSess As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboClsUpProg As System.Windows.Forms.ComboBox
    '   Friend WithEvents DsStudentSearches As SMS.dsStudentSearches
    '   Friend WithEvents SchoolsessionsBindingSource As System.Windows.Forms.BindingSource
    '   Friend WithEvents SchoolsessionsTableAdapter As SMS.dsStudentSearchesTableAdapters.schoolsessionsTableAdapter
    '  Friend WithEvents FormsBindingSource As System.Windows.Forms.BindingSource
    '   Friend WithEvents FormsTableAdapter As SMS.dsStudentSearchesTableAdapters.formsTableAdapter
    Friend WithEvents btnUploadStydents As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As Windows.Forms.SaveFileDialog
End Class
