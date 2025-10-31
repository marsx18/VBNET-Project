Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class BorrowForm

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30"

    '------------------------------------------------------------
    ' FORM LOAD
    '------------------------------------------------------------
    Private Sub BorrowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembers()
        LoadBooks()
        LoadBorrowRecords()

        dtpBorrow.Value = Date.Now
        dtpDue.Value = Date.Now.AddDays(7)
        dtpReturn.Enabled = False
    End Sub

    '------------------------------------------------------------
    ' LOAD MEMBERS
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    ' LOAD AVAILABLE BOOKS
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    ' LOAD BORROW RECORDS
    '------------------------------------------------------------
    Private Sub LoadBorrowRecords()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String =
                    "SELECT 
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
                    ORDER BY br.Record_ID DESC"

                Dim dt As New DataTable()
                dt.Load(New SqlCommand(query, con).ExecuteReader())
                dgvBorrowRecords.DataSource = dt

                dgvBorrowRecords.Columns("Member_Name").HeaderText = "Member Name"
                dgvBorrowRecords.Columns("Book_Title").HeaderText = "Book Title"

                dgvBorrowRecords.Columns("Book_ID").Visible = False
                dgvBorrowRecords.Columns("Member_ID").Visible = False
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading borrow records: " & ex.Message)
        End Try
    End Sub

    '------------------------------------------------------------
    ' BORROW A BOOK
    '------------------------------------------------------------
    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Try
            If cmbBook.SelectedIndex = -1 Or cmbMember.SelectedIndex = -1 Then
                MessageBox.Show("Please select both a member and a book.")
                Return
            End If

            Dim bookID As Integer = CInt(cmbBook.SelectedValue)
            Dim memberID As Integer = CInt(cmbMember.SelectedValue)
            Dim borrowDate As Date = dtpBorrow.Value
            Dim dueDate As Date = dtpDue.Value

            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Prevent double borrowing same book
                Dim checkQuery As String = "SELECT COUNT(*) FROM BorrowRecords WHERE Book_ID=@BookID AND Return_Date IS NULL"
                Using checkCmd As New SqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@BookID", bookID)
                    Dim alreadyBorrowed As Integer = CInt(checkCmd.ExecuteScalar())
                    If alreadyBorrowed > 0 Then
                        MessageBox.Show("This book is currently borrowed by someone else.")
                        Return
                    End If
                End Using

                ' Insert record
                Dim insertQuery As String = "INSERT INTO BorrowRecords (Book_ID, Member_ID, Borrow_Date, Due_Date) VALUES (@Book, @Member, @Borrow, @Due)"
                Using cmd As New SqlCommand(insertQuery, con)
                    cmd.Parameters.AddWithValue("@Book", bookID)
                    cmd.Parameters.AddWithValue("@Member", memberID)
                    cmd.Parameters.AddWithValue("@Borrow", borrowDate)
                    cmd.Parameters.AddWithValue("@Due", dueDate)
                    cmd.ExecuteNonQuery()
                End Using

                ' Update status
                Using updateCmd As New SqlCommand("UPDATE Books SET Status='Borrowed' WHERE Book_ID=@BookID", con)
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

    '------------------------------------------------------------
    ' SELECT RECORD
    '------------------------------------------------------------
    Private Sub dgvBorrowRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowRecords.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvBorrowRecords.Rows(e.RowIndex)
            dtpReturn.Enabled = True

            If Not IsDBNull(row.Cells("Return_Date").Value) Then
                dtpReturn.Value = row.Cells("Return_Date").Value
            Else
                dtpReturn.Value = Date.Now
            End If
        End If
    End Sub

    '------------------------------------------------------------
    ' RETURN BOOK + FINE CALCULATION
    '------------------------------------------------------------
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Try
            If dgvBorrowRecords.CurrentRow Is Nothing Then
                MessageBox.Show("Please select a record to return.")
                Return
            End If

            Dim row = dgvBorrowRecords.CurrentRow
            Dim recordID As Integer = row.Cells("Record_ID").Value
            Dim bookID As Integer = row.Cells("Book_ID").Value
            Dim dueDate As Date = row.Cells("Due_Date").Value
            Dim memberName As String = row.Cells("Member_Name").Value.ToString()
            Dim bookTitle As String = row.Cells("Book_Title").Value.ToString()

            If Not IsDBNull(row.Cells("Return_Date").Value) Then
                MessageBox.Show("This book is already returned.")
                Return
            End If

            Dim returnDate As Date = dtpReturn.Value
            Dim fine As Decimal = 0D
            Dim daysLate As Integer = (returnDate - dueDate).Days
            If daysLate > 0 Then fine = daysLate * 1D ' RM1 per late day

            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Update record
                Using cmd As New SqlCommand("UPDATE BorrowRecords SET Return_Date=@Return, Fine=@Fine WHERE Record_ID=@ID", con)
                    cmd.Parameters.AddWithValue("@Return", returnDate)
                    cmd.Parameters.AddWithValue("@Fine", fine)
                    cmd.Parameters.AddWithValue("@ID", recordID)
                    cmd.ExecuteNonQuery()
                End Using

                ' Change book back to Available
                Using cmd As New SqlCommand("UPDATE Books SET Status='Available' WHERE Book_ID=@BookID", con)
                    cmd.Parameters.AddWithValue("@BookID", bookID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show($"{memberName} returned '{bookTitle}' successfully! Fine: RM{fine:F2}")
            LoadBorrowRecords()
            LoadBooks()

        Catch ex As Exception
            MessageBox.Show("Error returning book: " & ex.Message)
        End Try
    End Sub

    '------------------------------------------------------------
    ' GENERATE CSV REPORT
    '------------------------------------------------------------
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Try
            Dim saveFile As New SaveFileDialog() With {
                .Filter = "CSV files (*.csv)|*.csv",
                .FileName = $"BorrowReport_{Date.Now:yyyyMMdd}.csv"
            }

            If saveFile.ShowDialog() = DialogResult.OK Then
                Using writer As New StreamWriter(saveFile.FileName)
                    ' Write headers
                    For i As Integer = 0 To dgvBorrowRecords.Columns.Count - 1
                        writer.Write(dgvBorrowRecords.Columns(i).HeaderText)
                        If i < dgvBorrowRecords.Columns.Count - 1 Then writer.Write(",")
                    Next
                    writer.WriteLine()

                    ' Write rows
                    For Each row As DataGridViewRow In dgvBorrowRecords.Rows
                        If Not row.IsNewRow Then
                            For i As Integer = 0 To dgvBorrowRecords.Columns.Count - 1
                                writer.Write(row.Cells(i).Value?.ToString())
                                If i < dgvBorrowRecords.Columns.Count - 1 Then writer.Write(",")
                            Next
                            writer.WriteLine()
                        End If
                    Next
                End Using

                MessageBox.Show("Borrow report generated successfully!", "Success")
            End If

        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message)
        End Try
    End Sub
End Class
