<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffLogin
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbTimer = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.PictureBox_V = New System.Windows.Forms.PictureBox
        Me.lbDevStatus = New System.Windows.Forms.Label
        Me.lbCofirmName = New System.Windows.Forms.Label
        CType(Me.PictureBox_V, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
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
        Me.Label12.Size = New System.Drawing.Size(420, 26)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "PRINT IS CAPTURED AFTER EVERY 3s"
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
        Me.lbDevStatus.Location = New System.Drawing.Point(469, 137)
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
        'frmStaffLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 421)
        Me.Controls.Add(Me.lbCofirmName)
        Me.Controls.Add(Me.lbDevStatus)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbTimer)
        Me.Controls.Add(Me.PictureBox_V)
        Me.Name = "frmStaffLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStaffLogin"
        CType(Me.PictureBox_V, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_V As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbTimer As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbDevStatus As System.Windows.Forms.Label
    Friend WithEvents lbCofirmName As System.Windows.Forms.Label
End Class
