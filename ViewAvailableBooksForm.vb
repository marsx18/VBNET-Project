Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class ViewAvailableBooksForm
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30"
    Public MemberID As Integer

    Private Sub ViewAvailableBooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAvailableBooks()
        dtpDue.Value = Date.Now.AddDays(7)
    End Sub

    Private Sub LoadAvailableBooks(Optional ByVal searchText As String = "")
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT Book_ID, Title, Author, Genre FROM Books WHERE Status='Available'"

                If searchText <> "" Then
                    query &= " AND (Title LIKE @Search OR Author LIKE @Search)"
                End If

                Using cmd As New SqlCommand(query, con)
                    If searchText <> "" Then
                        cmd.Parameters.AddWithValue("@Search", "%" & searchText & "%")
                    End If

                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    dgvAvailableBooks.DataSource = dt

                    dgvAvailableBooks.ReadOnly = True
                    dgvAvailableBooks.AllowUserToAddRows = False
                    dgvAvailableBooks.RowHeadersVisible = False
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading books: " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadAvailableBooks(txtSearch.Text.Trim())
    End Sub

    Private Sub btnBorrowSelected_Click(sender As Object, e As EventArgs) Handles btnBorrowSelected.Click
        If dgvAvailableBooks.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a book to borrow.")
            Return
        End If

        Dim bookID As Integer = dgvAvailableBooks.CurrentRow.Cells("Book_ID").Value
        Dim borrowDate As Date = Date.Now
        Dim dueDate As Date = dtpDue.Value

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Prevent double borrowing
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM BorrowRecords WHERE Book_ID=@BookID AND Return_Date IS NULL", con)
                checkCmd.Parameters.AddWithValue("@BookID", bookID)
                Dim alreadyBorrowed As Integer = CInt(checkCmd.ExecuteScalar())
                If alreadyBorrowed > 0 Then
                    MessageBox.Show("This book is already borrowed.")
                    Return
                End If

                ' Insert borrow record
                Dim insertQuery As String = "INSERT INTO BorrowRecords (Book_ID, Member_ID, Borrow_Date, Due_Date) VALUES (@BookID, @MemberID, @Borrow, @Due)"
                Using cmd As New SqlCommand(insertQuery, con)
                    cmd.Parameters.AddWithValue("@BookID", bookID)
                    cmd.Parameters.AddWithValue("@MemberID", MemberID)
                    cmd.Parameters.AddWithValue("@Borrow", borrowDate)
                    cmd.Parameters.AddWithValue("@Due", dueDate)
                    cmd.ExecuteNonQuery()
                End Using

                ' Update book status
                Using updateCmd As New SqlCommand("UPDATE Books SET Status='Borrowed' WHERE Book_ID=@BookID", con)
                    updateCmd.Parameters.AddWithValue("@BookID", bookID)
                    updateCmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book borrowed successfully!")
            LoadAvailableBooks(txtSearch.Text.Trim())

        Catch ex As Exception
            MessageBox.Show("Error borrowing book: " & ex.Message)
        End Try
    End Sub

End Class
