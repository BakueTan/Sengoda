Imports System.Windows.Forms
Imports Miscelleneous
Public Class dgProgressBar

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ProgressBar1.Value = pos
        dgProgressBar_Load(Me, Nothing)
    End Sub

    Private Sub dgProgressBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pers As Integer
        Dim temppos As Integer
        ProgressBar1.Maximum = studs
      
        pers = (pos / studs) * 100

        Me.Text = pers & "% Complete "


        'lbprog.Text = pos & "/" & studs
    End Sub
End Class
