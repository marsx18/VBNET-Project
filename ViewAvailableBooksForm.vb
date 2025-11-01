Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class ViewAvailableBooksForm
    Public Property MemberID As Integer
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30"

    Private Sub ViewAvailableBooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpBorrow.Value = Date.Now
        dtpDue.Value = Date.Now.AddDays(7)
        LoadAvailableBooks()
    End Sub

    Private Sub LoadAvailableBooks()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT Book_ID, Title, Author, Genre, Status FROM Books WHERE Status='Available'", con)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                dgvAvailableBooks.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading available books: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT * FROM Books WHERE Title LIKE @search AND Status='Available'", con)
                cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                dgvAvailableBooks.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching books: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Try
            If dgvAvailableBooks.CurrentRow Is Nothing Then
                MessageBox.Show("Please select a book to borrow.")
                Return
            End If

            Dim bookID As Integer = dgvAvailableBooks.CurrentRow.Cells("Book_ID").Value
            Dim borrowDate As Date = dtpBorrow.Value
            Dim dueDate As Date = dtpDue.Value

            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Prevent duplicate borrow
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM BorrowRecords WHERE Book_ID=@Book AND Return_Date IS NULL", con)
                checkCmd.Parameters.AddWithValue("@Book", bookID)
                If CInt(checkCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("This book is currently borrowed.")
                    Return
                End If

                ' Insert new borrow record
                Dim insertCmd As New SqlCommand("INSERT INTO BorrowRecords (Book_ID, Member_ID, Borrow_Date, Due_Date) VALUES (@Book, @Member, @Borrow, @Due)", con)
                insertCmd.Parameters.AddWithValue("@Book", bookID)
                insertCmd.Parameters.AddWithValue("@Member", MemberID)
                insertCmd.Parameters.AddWithValue("@Borrow", borrowDate)
                insertCmd.Parameters.AddWithValue("@Due", dueDate)
                insertCmd.ExecuteNonQuery()

                ' Update book status
                Dim updateCmd As New SqlCommand("UPDATE Books SET Status='Borrowed' WHERE Book_ID=@Book", con)
                updateCmd.Parameters.AddWithValue("@Book", bookID)
                updateCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Book borrowed successfully!", "Success")
            LoadAvailableBooks()

        Catch ex As Exception
            MessageBox.Show("Error borrowing book: " & ex.Message)
        End Try
    End Sub
End Class
