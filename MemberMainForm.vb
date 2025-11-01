Public Class MemberMainForm
    ' Store the logged-in user (Member) ID
    Public MemberID As Integer

    Private Sub MemberMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: Display a welcome message
        ' LabelWelcome.Text = "Welcome, Member " & MemberID
    End Sub

    ' --- Menu: View Available Books ---
    Private Sub AvailableBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvailableBooksToolStripMenuItem.Click
        Dim availableForm As New ViewAvailableBooksForm()
        availableForm.MemberID = MemberID
        availableForm.ShowDialog()
    End Sub

    ' --- Menu: View Borrowed Books ---
    Private Sub BorrowedBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowedBooksToolStripMenuItem.Click
        Dim borrowedForm As New ViewBorrowedBooksForm()
        borrowedForm.MemberID = MemberID
        borrowedForm.ShowDialog()
    End Sub

    ' --- Menu: About ---
    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    ' --- Menu: Logout ---
    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewAvailableBooks_Click(sender As Object, e As EventArgs) Handles btnViewAvailableBooks.Click
        Dim availableForm As New ViewAvailableBooksForm()
        availableForm.MemberID = MemberID
        availableForm.ShowDialog()
    End Sub

    Private Sub btnViewBorrowedBooks_Click(sender As Object, e As EventArgs) Handles btnViewBorrowedBooks.Click
        Dim borrowedForm As New ViewBorrowedBooksForm()
        borrowedForm.MemberID = MemberID
        borrowedForm.ShowDialog()
    End Sub

End Class
