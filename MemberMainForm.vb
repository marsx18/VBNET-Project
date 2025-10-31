Public Class MemberMainForm

    ' Store logged-in user ID
    Public LoggedInUserID As Integer

    Private Sub MemberMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optionally display welcome message or username
    End Sub

    Private Sub btnViewAvailableBooks_Click(sender As Object, e As EventArgs) Handles btnViewAvailableBooks.Click
        Dim availableForm As New ViewAvailableBooksForm()
        availableForm.MemberID = LoggedInUserID
        availableForm.ShowDialog()
    End Sub

    Private Sub btnViewBorrowedBooks_Click(sender As Object, e As EventArgs) Handles btnViewBorrowedBooks.Click
        Dim borrowedForm As New ViewBorrowedBooksForm()
        borrowedForm.LoggedInUserID = LoggedInUserID
        borrowedForm.ShowDialog()
    End Sub

    Private Sub AvailableBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvailableBooksToolStripMenuItem.Click
        Dim availableForm As New ViewAvailableBooksForm()
        availableForm.MemberID = LoggedInUserID
        availableForm.ShowDialog()
    End Sub
    Private Sub BorrowedBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowedBooksToolStripMenuItem.Click
        Dim borrowedForm As New ViewBorrowedBooksForm()
        borrowedForm.LoggedInUserID = LoggedInUserID
        borrowedForm.ShowDialog()
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class
