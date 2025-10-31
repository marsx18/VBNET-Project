Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class ViewBorrowedBooksForm
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30"
    Public LoggedInUserID As Integer

    Private Sub ViewBorrowedBooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrowedBooks()
    End Sub

    Private Sub LoadBorrowedBooks()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "
                    SELECT 
                        b.Title AS [Book Title],
                        br.Borrow_Date AS [Borrow Date],
                        br.Due_Date AS [Due Date],
                        br.Return_Date AS [Return Date],
                        br.Fine AS [Fine (RM)]
                    FROM BorrowRecords br
                    INNER JOIN Books b ON br.Book_ID = b.Book_ID
                    INNER JOIN Members m ON br.Member_ID = m.Member_ID
                    WHERE m.User_ID=@UserID
                    ORDER BY br.Borrow_Date DESC"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@UserID", LoggedInUserID)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvBorrowedBooks.DataSource = dt

                    dgvBorrowedBooks.ReadOnly = True
                    dgvBorrowedBooks.AllowUserToAddRows = False
                    dgvBorrowedBooks.AllowUserToDeleteRows = False
                    dgvBorrowedBooks.RowHeadersVisible = False
                End Using
            End Using

            ' Calculate total fine
            Dim totalFine As Decimal = 0
            For Each row As DataRow In CType(dgvBorrowedBooks.DataSource, DataTable).Rows
                If Not IsDBNull(row("Fine (RM)")) Then
                    totalFine += CDec(row("Fine (RM)"))
                End If
            Next
            lblTotalFine.Text = "Total Fine is: RM" & totalFine.ToString("F2")

        Catch ex As Exception
            MessageBox.Show("Error loading borrowed books: " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If dgvBorrowedBooks.DataSource Is Nothing Then Return
        Dim dv As DataView = CType(dgvBorrowedBooks.DataSource, DataTable).DefaultView
        dv.RowFilter = String.Format("[Book Title] LIKE '%{0}%'", txtSearch.Text.Replace("'", "''"))
    End Sub
End Class
