Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class BorrowForm

    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30"

    '----------------------------------------------
    ' LOAD FORM
    '----------------------------------------------
    Private Sub BorrowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembers()
        LoadBooks()
        LoadBorrowRecords()

        dtpBorrow.Value = Date.Now
        dtpDue.Value = Date.Now.AddDays(7)
        dtpReturn.Enabled = False
    End Sub

    ' Auto-refresh when form becomes active
    Private Sub BorrowForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LoadBorrowRecords()
        LoadBooks()
    End Sub

    '----------------------------------------------
    ' LOAD MEMBERS
    '----------------------------------------------
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

    '----------------------------------------------
    ' LOAD AVAILABLE BOOKS
    '----------------------------------------------
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

    '----------------------------------------------
    ' LOAD ALL BORROW RECORDS
    '----------------------------------------------
    Private Sub LoadBorrowRecords()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "
                    SELECT 
                        br.Record_ID,
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

                dgvBorrowRecords.Columns("Member_Name").HeaderText = "Member"
                dgvBorrowRecords.Columns("Book_Title").HeaderText = "Book"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading borrow records: " & ex.Message)
        End Try
    End Sub

    '----------------------------------------------
    ' BORROW A BOOK
    '----------------------------------------------
    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Try
            If cmbMember.SelectedIndex = -1 Or cmbBook.SelectedIndex = -1 Then
                MessageBox.Show("Please select both a member and a book.")
                Return
            End If

            Dim memberID As Integer = CInt(cmbMember.SelectedValue)
            Dim bookID As Integer = CInt(cmbBook.SelectedValue)
            Dim borrowDate As Date = dtpBorrow.Value
            Dim dueDate As Date = dtpDue.Value

            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Prevent borrowing a book already borrowed
                Dim checkQuery As String = "SELECT COUNT(*) FROM BorrowRecords WHERE Book_ID=@Book AND Return_Date IS NULL"
                Using checkCmd As New SqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@Book", bookID)
                    If CInt(checkCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("This book is already borrowed.")
                        Return
                    End If
                End Using

                ' Insert record
                Dim insertQuery As String = "
                    INSERT INTO BorrowRecords (Book_ID, Member_ID, Borrow_Date, Due_Date)
                    VALUES (@Book, @Member, @Borrow, @Due)"
                Using cmd As New SqlCommand(insertQuery, con)
                    cmd.Parameters.AddWithValue("@Book", bookID)
                    cmd.Parameters.AddWithValue("@Member", memberID)
                    cmd.Parameters.AddWithValue("@Borrow", borrowDate)
                    cmd.Parameters.AddWithValue("@Due", dueDate)
                    cmd.ExecuteNonQuery()
                End Using

                ' Update book status
                Using updateCmd As New SqlCommand("UPDATE Books SET Status='Borrowed' WHERE Book_ID=@Book", con)
                    updateCmd.Parameters.AddWithValue("@Book", bookID)
                    updateCmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book borrowed successfully!", "Success")
            LoadBorrowRecords()
            LoadBooks()

        Catch ex As Exception
            MessageBox.Show("Error borrowing book: " & ex.Message)
        End Try
    End Sub

    '----------------------------------------------
    ' SELECT ROW
    '----------------------------------------------
    Private Sub dgvBorrowRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowRecords.CellClick
        If e.RowIndex >= 0 Then
            dtpReturn.Enabled = True
        End If
    End Sub

    '----------------------------------------------
    ' RETURN BOOK
    '----------------------------------------------
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Try
            If dgvBorrowRecords.CurrentRow Is Nothing Then
                MessageBox.Show("Please select a record to return.")
                Return
            End If

            Dim recordID As Integer = dgvBorrowRecords.CurrentRow.Cells("Record_ID").Value
            Dim returnDate As Date = dtpReturn.Value
            Dim fine As Decimal = 0

            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Get book and due date
                Dim infoCmd As New SqlCommand("
                    SELECT br.Book_ID, br.Due_Date, m.Name, b.Title
                    FROM BorrowRecords br
                    INNER JOIN Members m ON br.Member_ID=m.Member_ID
                    INNER JOIN Books b ON br.Book_ID=b.Book_ID
                    WHERE br.Record_ID=@ID", con)
                infoCmd.Parameters.AddWithValue("@ID", recordID)

                Dim reader = infoCmd.ExecuteReader()
                If Not reader.Read() Then
                    MessageBox.Show("Record not found.")
                    Return
                End If
                Dim bookID As Integer = reader("Book_ID")
                Dim dueDate As Date = reader("Due_Date")
                Dim memberName As String = reader("Name").ToString()
                Dim bookTitle As String = reader("Title").ToString()
                reader.Close()

                ' Calculate fine
                Dim daysLate As Integer = (returnDate - dueDate).Days
                If daysLate > 0 Then fine = daysLate * 5D

                ' Update return info
                Dim updateCmd As New SqlCommand("
                    UPDATE BorrowRecords
                    SET Return_Date=@Return, Fine=@Fine
                    WHERE Record_ID=@ID", con)
                updateCmd.Parameters.AddWithValue("@Return", returnDate)
                updateCmd.Parameters.AddWithValue("@Fine", fine)
                updateCmd.Parameters.AddWithValue("@ID", recordID)
                updateCmd.ExecuteNonQuery()

                ' Update book status
                Dim bookCmd As New SqlCommand("UPDATE Books SET Status='Available' WHERE Book_ID=@Book", con)
                bookCmd.Parameters.AddWithValue("@Book", bookID)
                bookCmd.ExecuteNonQuery()
            End Using


            LoadBorrowRecords()
            LoadBooks()

        Catch ex As Exception
            MessageBox.Show("Error returning book: " & ex.Message)
        End Try
    End Sub

    '----------------------------------------------
    ' GENERATE REPORT
    '----------------------------------------------
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Try
            Dim saveFile As New SaveFileDialog() With {
                .Filter = "CSV files (*.csv)|*.csv",
                .FileName = $"BorrowReport_{Date.Now:yyyyMMdd}.csv"
            }

            If saveFile.ShowDialog() = DialogResult.OK Then
                Using writer As New StreamWriter(saveFile.FileName)
                    ' Headers
                    For i As Integer = 0 To dgvBorrowRecords.Columns.Count - 1
                        writer.Write(dgvBorrowRecords.Columns(i).HeaderText)
                        If i < dgvBorrowRecords.Columns.Count - 1 Then writer.Write(",")
                    Next
                    writer.WriteLine()

                    ' Rows
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

                MessageBox.Show("Report generated successfully!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message)
        End Try
    End Sub

End Class
