Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class ViewBorrowedBooksForm

    ' Database connection
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30"

    ' Logged-in member ID (passed from MemberMainForm)
    Public Property MemberID As Integer

    Private Sub ViewBorrowedBooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrowedBooks()
    End Sub

    Private Sub LoadBorrowedBooks()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String =
                    "SELECT 
                        br.Record_ID,
                        b.Title AS Book_Title,
                        br.Borrow_Date,
                        br.Due_Date,
                        br.Return_Date,
                        br.Fine
                     FROM BorrowRecords br
                     INNER JOIN Books b ON br.Book_ID = b.Book_ID
                     WHERE br.Member_ID = @MemberID
                     ORDER BY br.Borrow_Date DESC"

                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@MemberID", MemberID)

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                dgvBorrowedBooks.DataSource = dt

                ' Rename headers for display
                dgvBorrowedBooks.Columns("Book_Title").HeaderText = "Book Title"
                dgvBorrowedBooks.Columns("Borrow_Date").HeaderText = "Borrow Date"
                dgvBorrowedBooks.Columns("Due_Date").HeaderText = "Due Date"
                dgvBorrowedBooks.Columns("Return_Date").HeaderText = "Return Date"
                dgvBorrowedBooks.Columns("Fine").HeaderText = "Fine (RM)"

                ' Calculate total fines
                Dim totalFine As Decimal = 0
                For Each row As DataRow In dt.Rows
                    If Not IsDBNull(row("Fine")) Then
                        totalFine += Convert.ToDecimal(row("Fine"))
                    End If
                Next

                lblTotalFine.Text = "Total Fine: RM" & totalFine.ToString("F2")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading borrowed books: " & ex.Message)
        End Try
    End Sub
End Class
