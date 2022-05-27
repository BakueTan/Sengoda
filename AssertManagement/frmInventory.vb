
Imports System.Data.SqlClient

Public Class frmInventory

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        dgAssertType.ShowDialog()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSchool.AssertMaster' table. You can move, or remove it, as needed.
      

        Prepareform(Me)
        MdiParent = frmMain
        loadsets()

    End Sub

    Private Sub loadsets()
        Try
            Me.AssertMasterTableAdapter.Fill(Me.DsSchool.AssertMaster)
            'TODO: This line of code loads data into the 'DsSchool.AssertType' table. You can move, or remove it, as needed.
            Me.AssertTypeTableAdapter.Fill(Me.DsSchool.AssertType)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
    End Sub

    Private Sub AssertTypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssertTypeBindingNavigatorSaveItem.Click
        Dim row As dsSchool.AssertMasterRow



        row = DsSchool.AssertMaster.NewAssertMasterRow

        row.state = "True"


        Try
            Me.Validate()
            Me.AssertMasterBindingSource.EndEdit()
            Me.AssertMasterTableAdapter.Update(Me.DsSchool.AssertMaster)
            MsgBox("Assert Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadAssertType()
        Me.AssertTypeTableAdapter.Fill(Me.DsSchool.AssertType)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub lbAssert_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbAssert.DoubleClick
        Dim assert() As String
        assert = lbAssert.SelectedItem.ToString.Split("-")
        txtDispID.Text = assert(0)
        lbAssert.Visible = False

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbAssert.SelectedIndexChanged

    End Sub

    Private Sub txtDispID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDispID.KeyDown
        If e.KeyCode = Keys.Escape Then
            lbAssert.Visible = False
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDispID.TextChanged
        Dim sql As String
        Dim drr As sqldatareader

        lbAssert.Items.Clear()
        lbAssert.Visible = True

        sql = "select assertnumber,description ,type from assertmaster where assertnumber + '' + description + '' + type like '%" & txtDispID.Text & "%' and state = 'true' "
        drr = ExecuteReader(sql, , Nothing)

        While drr.Read
            lbAssert.Items.Add(drr(0) + "-" + drr(1) + "-" + drr(2))


        End While

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String

        sql = "insert into assertdisp(id,value,date,comment) values ('" & txtDispID.Text & "','" & txtdispValue.Text & "','" & changedate(mskDispDate.Text) & "','" & txtDispComment.Text & "')"

        ExecuteNonQuery(sql, , True)

        If era Then
            MsgBox(eramsg)
        Else
            MsgBox("save successful")
        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadsets()
    End Sub
End Class