<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReigisterPrints2
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
        Me.btnCaptuerPrint = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBoxR1 = New System.Windows.Forms.PictureBox
        Me.btnRegisterPrint = New System.Windows.Forms.Button
        Me.lblImageQuality = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxR1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCaptuerPrint
        '
        Me.btnCaptuerPrint.Location = New System.Drawing.Point(221, 253)
        Me.btnCaptuerPrint.Name = "btnCaptuerPrint"
        Me.btnCaptuerPrint.Size = New System.Drawing.Size(101, 27)
        Me.btnCaptuerPrint.TabIndex = 2
        Me.btnCaptuerPrint.Text = "CapturePrint"
        Me.btnCaptuerPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'PictureBoxR1
        '
        Me.PictureBoxR1.BackColor = System.Drawing.Color.White
        Me.PictureBoxR1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxR1.Location = New System.Drawing.Point(175, 47)
        Me.PictureBoxR1.Name = "PictureBoxR1"
        Me.PictureBoxR1.Size = New System.Drawing.Size(197, 200)
        Me.PictureBoxR1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxR1.TabIndex = 0
        Me.PictureBoxR1.TabStop = False
        '
        'btnRegisterPrint
        '
        Me.btnRegisterPrint.Location = New System.Drawing.Point(232, 314)
        Me.btnRegisterPrint.Name = "btnRegisterPrint"
        Me.btnRegisterPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnRegisterPrint.TabIndex = 5
        Me.btnRegisterPrint.Text = "Register"
        Me.btnRegisterPrint.UseVisualStyleBackColor = True
        '
        'lblImageQuality
        '
        Me.lblImageQuality.AutoSize = True
        Me.lblImageQuality.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImageQuality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblImageQuality.Location = New System.Drawing.Point(378, 143)
        Me.lblImageQuality.Name = "lblImageQuality"
        Me.lblImageQuality.Size = New System.Drawing.Size(0, 20)
        Me.lblImageQuality.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'frmReigisterPrints2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 362)
        Me.Controls.Add(Me.lblImageQuality)
        Me.Controls.Add(Me.btnRegisterPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCaptuerPrint)
        Me.Controls.Add(Me.PictureBoxR1)
        Me.Name = "frmReigisterPrints2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Finger Print"
        Me.TopMost = True
        CType(Me.PictureBoxR1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxR1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCaptuerPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRegisterPrint As System.Windows.Forms.Button
    Friend WithEvents lblImageQuality As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
