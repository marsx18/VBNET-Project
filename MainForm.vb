Public Class MainForm
    Private Sub BooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooksToolStripMenuItem.Click


    End Sub

    Private Sub MembersToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MembersForm.Show()

    End Sub

    Private Sub BorrowToolStripMenuItem_Click(sender As Object, e As EventArgs)
        BorrowForm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub MembersListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembersListToolStripMenuItem.Click
        BookForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BorrowReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowReturnToolStripMenuItem.Click
        MembersForm.Show()
    End Sub

    Private Sub BorrowReturnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BorrowReturnToolStripMenuItem1.Click
        BorrowForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BookForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MembersForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BorrowForm.Show()
    End Sub
End Class