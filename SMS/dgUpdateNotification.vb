Imports System.Windows.Forms

Public Class dgUpdateNotification

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Public Sub Writetextbox()
        Try
            With txtUpdateNotification

                ' Clear all text from the RichTextBox;
                .Clear()


                .BulletIndent = 30
                .SelectionIndent = 10
                ' Set the font for the opening text to a larger Arial font;
                .SelectionFont = New Font("Calibri", 12, FontStyle.Bold)

                ' Assign the introduction text to the RichTextBox control.
                .SelectedText = "Version: 2.0.0.39" + ControlChars.Cr

                .SelectionFont = New Font("Calibri", 12, FontStyle.Bold)
                ' Assign the introduction text to the RichTextBox control.
                .SelectedText = "Published Date: May 23, 2022" + ControlChars.Cr

                .SelectionBullet = True
                .SelectionFont = New Font("Calibri", 12)
                ' Specify that the following items are to be added to a bulleted list.
                .SelectedText = "Added Multi-Comment option functionality for the Exams Module." + ControlChars.Cr

                .SelectionBullet = True
                .SelectionFont = New Font("Calibri", 12)
                ' Specify that the following items are to be added to a bulleted list.
                .SelectedText = "Misc - Minor bug fixes and performance enhancements." + ControlChars.Cr
                .SelectionBullet = False
                .SelectionFont = New Font("Calibri", 12, FontStyle.Bold)
                .SelectedText = "" + ControlChars.Cr
            End With
            '==============================================================================================
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgUpdateNotification_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveSetting("Imela", "RevoEdu\", "RevoUpdateNumber", RevoUpdateNumber)
    End Sub
End Class
