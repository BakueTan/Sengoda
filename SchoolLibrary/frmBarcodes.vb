Imports System.Windows.Forms

Public Class frmBarcodes

    Private Sub frmBarcodes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsSchoolLibrary.Barcodes' table. You can move, or remove it, as needed.
        '   Me.BarcodesTableAdapter.Fill(Me.dsSchoolLibrary.Barcodes)
        'TODO: This line of code loads data into the 'barcodesDataSet.Barcodes' table. You can move, or remove it, as needed.
        '  Me.BarcodesTableAdapter.Fill(Me.barcodesDataSet.Barcodes)
        'TODO: This line of code loads data into the 'barcodesDataSet.Barcodes' table. You can move, or remove it, as needed.


        '  Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.BarcodesTableAdapter.FillByBarcode(Me.dsSchoolLibrary.Barcodes, TextBox1.Text, TextBox2.Text)
            ReportViewer1.RefreshReport()
            ReportViewer1.Dock = DockStyle.Fill
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class