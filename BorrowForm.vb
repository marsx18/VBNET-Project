Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class BorrowForm

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30"

    Private Sub BorrowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembers()
        LoadBooks()
        LoadBorrowRecords()

        dtpBorrow.Value = Date.Now
        dtpDue.Value = Date.Now.AddDays(7)
        dtpReturn.Enabled = False ' Disabled until selecting a record
    End Sub

    ' ----------------------------
    ' LOAD MEMBERS
    ' ----------------------------
    Private Sub LoadMembers()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT Member_ID, Name FROM Members", con)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                cmbMember.DataSource = dt
                cmbMember.DisplayMember = "Name"
                cmbMember.ValueMember = "Member_ID"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading members: " & ex.Message)
        End Try
    End Sub

    ' ----------------------------
    ' LOAD AVAILABLE BOOKS
    ' ----------------------------
    Private Sub LoadBooks()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT Book_ID, Title FROM Books WHERE Status = 'Available'", con)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                cmbBook.DataSource = dt
                cmbBook.DisplayMember = "Title"
                cmbBook.ValueMember = "Book_ID"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading books: " & ex.Message)
        End Try
    End Sub

    ' ----------------------------
    ' LOAD BORROW RECORDS
    ' ----------------------------
    Private Sub LoadBorrowRecords()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Include Book_ID & Member_ID for internal use (hidden in grid)
                Dim cmd As New SqlCommand("
                    SELECT 
                        br.Record_ID,
                        br.Book_ID,
                        br.Member_ID,
                        m.Name AS Member_Name,
                        b.Title AS Book_Title,
                        br.Borrow_Date,
                        br.Due_Date,
                        br.Return_Date,
                        br.Fine
                    FROM BorrowRecords br
                    INNER JOIN Members m ON br.Member_ID = m.Member_ID
                    INNER JOIN Books b ON br.Book_ID = b.Book_ID
                ", con)

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                dgvBorrowRecords.DataSource = dt

                ' Rename headers
                dgvBorrowRecords.Columns("Member_Name").HeaderText = "Member Name"
                dgvBorrowRecords.Columns("Book_Title").HeaderText = "Book Title"

                ' Hide IDs
                dgvBorrowRecords.Columns("Book_ID").Visible = False
                dgvBorrowRecords.Columns("Member_ID").Visible = False
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading records: " & ex.Message)
        End Try
    End Sub

    ' ----------------------------
    ' BORROW A BOOK
    ' ----------------------------
    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Try
            Dim bookID As Integer = CInt(cmbBook.SelectedValue)
            Dim memberID As Integer = CInt(cmbMember.SelectedValue)
            Dim borrowDate As Date = dtpBorrow.Value
            Dim dueDate As Date = dtpDue.Value

            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Insert into BorrowRecords
                Dim insertQuery As String = "INSERT INTO BorrowRecords (Book_ID, Member_ID, Borrow_Date, Due_Date) VALUES (@Book, @Member, @Borrow, @Due)"
                Using cmd As New SqlCommand(insertQuery, con)
                    cmd.Parameters.AddWithValue("@Book", bookID)
                    cmd.Parameters.AddWithValue("@Member", memberID)
                    cmd.Parameters.AddWithValue("@Borrow", borrowDate)
                    cmd.Parameters.AddWithValue("@Due", dueDate)
                    cmd.ExecuteNonQuery()
                End Using

                ' Update Book status
                Dim updateQuery As String = "UPDATE Books SET Status='Borrowed' WHERE Book_ID=@BookID"
                Using updateCmd As New SqlCommand(updateQuery, con)
                    updateCmd.Parameters.AddWithValue("@BookID", bookID)
                    updateCmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book borrowed successfully!")
            LoadBorrowRecords()
            LoadBooks()

        Catch ex As Exception
            MessageBox.Show("Error borrowing book: " & ex.Message)
        End Try
    End Sub

    ' ----------------------------
    ' SELECT RECORD (ENABLE RETURN DATE)
    ' ----------------------------
    Private Sub dgvBorrowRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowRecords.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBorrowRecords.Rows(e.RowIndex)
            dtpReturn.Enabled = True

            If Not IsDBNull(row.Cells("Return_Date").Value) Then
                dtpReturn.Value = row.Cells("Return_Date").Value
            Else
                dtpReturn.Value = Date.Now
            End If
        End If
    End Sub

    ' ----------------------------
    ' RETURN BOOK + CALCULATE FINE
    ' ----------------------------
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Try
            If dgvBorrowRecords.CurrentRow Is Nothing Then
                MessageBox.Show("Please select a record to return.")
                Return
            End If

            Dim recordID As Integer = dgvBorrowRecords.CurrentRow.Cells("Record_ID").Value
            Dim bookID As Integer = dgvBorrowRecords.CurrentRow.Cells("Book_ID").Value
            Dim dueDate As Date = dgvBorrowRecords.CurrentRow.Cells("Due_Date").Value
            Dim returnDate As Date = dtpReturn.Value

            Dim memberName As String = dgvBorrowRecords.CurrentRow.Cells("Member_Name").Value.ToString()
            Dim bookTitle As String = dgvBorrowRecords.CurrentRow.Cells("Book_Title").Value.ToString()

            ' Fine Calculation
            Dim fine As Decimal = 0
            Dim daysLate As Integer = (returnDate - dueDate).Days
            If daysLate > 0 Then
                fine = daysLate * 1D ' RM1 per day late
            End If

            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Update BorrowRecords
                Dim updateQuery As String = "UPDATE BorrowRecords SET Return_Date=@Return, Fine=@Fine WHERE Record_ID=@ID"
                Using cmd As New SqlCommand(updateQuery, con)
                    cmd.Parameters.AddWithValue("@Return", returnDate)
                    cmd.Parameters.AddWithValue("@Fine", fine)
                    cmd.Parameters.AddWithValue("@ID", recordID)
                    cmd.ExecuteNonQuery()
                End Using

                ' Update book back to Available
                Dim bookQuery As String = "UPDATE Books SET Status='Available' WHERE Book_ID=@BookID"
                Using bookCmd As New SqlCommand(bookQuery, con)
                    bookCmd.Parameters.AddWithValue("@BookID", bookID)
                    bookCmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show($"{memberName} returned '{bookTitle}' successfully! Fine: RM{fine:F2}")
            LoadBorrowRecords()
            LoadBooks()

        Catch ex As Exception
            MessageBox.Show("Error returning book: " & ex.Message)
        End Try
    End Sub
End Class
