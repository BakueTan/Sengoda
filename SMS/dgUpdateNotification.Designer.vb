<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dgUpdateNotification
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
        Me.txtUpdateNotification = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtUpdateNotification
        '
        Me.txtUpdateNotification.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtUpdateNotification.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUpdateNotification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUpdateNotification.ForeColor = System.Drawing.Color.White
        Me.txtUpdateNotification.Location = New System.Drawing.Point(0, 0)
        Me.txtUpdateNotification.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtUpdateNotification.Name = "txtUpdateNotification"
        Me.txtUpdateNotification.Size = New System.Drawing.Size(858, 427)
        Me.txtUpdateNotification.TabIndex = 1
        Me.txtUpdateNotification.Text = ""
        '
        'dgUpdateNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(858, 427)
        Me.Controls.Add(Me.txtUpdateNotification)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dgUpdateNotification"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SENGODA Revo Version History"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUpdateNotification As RichTextBox
End Class
