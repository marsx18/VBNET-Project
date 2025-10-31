Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class BookForm

    '--------------------------------------------
    ' DATABASE CONNECTION
    '--------------------------------------------
    Dim databasePath As String = Path.Combine(Application.StartupPath, "..\..\..\Database\Library.mdf")
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True")

    '--------------------------------------------
    ' LOAD DATA WHEN FORM OPENS
    '--------------------------------------------
    Private Sub BookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatus.Items.Clear()
        cboStatus.Items.AddRange(New String() {"Available", "Borrowed", "Reserved", "Lost"})
        cboStatus.SelectedIndex = 0
        LoadBooks()
    End Sub


    '--------------------------------------------
    ' DISPLAY ALL BOOK RECORDS IN DATAGRIDVIEW
    '--------------------------------------------
    Private Sub LoadBooks()
        Try
            Dim query As String = "SELECT Book_ID, Title, Author, Genre, Status FROM Books"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvBooks.DataSource = table

            dgvBooks.ReadOnly = True
            dgvBooks.AllowUserToAddRows = False
            dgvBooks.AllowUserToDeleteRows = False
            dgvBooks.RowHeadersVisible = False
        Catch ex As Exception
            MessageBox.Show("Error loading books: " & ex.Message)
        End Try
    End Sub


    '--------------------------------------------
    ' ADD NEW BOOK
    '--------------------------------------------
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtTitle.Text = "" Or txtAuthor.Text = "" Or txtGenre.Text = "" Or cboStatus.Text = "" Then
            MessageBox.Show("Please fill in all book details before adding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim query As String = "INSERT INTO Books (Title, Author, Genre, Status) VALUES (@Title, @Author, @Genre, @Status)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text)
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
                cmd.Parameters.AddWithValue("@Status", cboStatus.Text)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                LoadBooks()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding book: " & ex.Message)
            con.Close()
        End Try
    End Sub


    '--------------------------------------------
    ' UPDATE BOOK RECORD
    '--------------------------------------------
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtBook_ID.Text = "" Then
            MessageBox.Show("Please select a book record to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim query As String = "UPDATE Books SET Title=@Title, Author=@Author, Genre=@Genre, Status=@Status WHERE Book_ID=@Book_ID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text)
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
                cmd.Parameters.AddWithValue("@Status", cboStatus.Text)
                cmd.Parameters.AddWithValue("@Book_ID", txtBook_ID.Text)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Book record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                LoadBooks()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating book: " & ex.Message)
            con.Close()
        End Try
    End Sub


    '--------------------------------------------
    ' DELETE BOOK RECORD
    '--------------------------------------------
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtBook_ID.Text = "" Then
            MessageBox.Show("Please select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM Books WHERE Book_ID=@Book_ID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Book_ID", txtBook_ID.Text)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                    LoadBooks()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting book: " & ex.Message)
                con.Close()
            End Try
        End If
    End Sub


    '--------------------------------------------
    ' SEARCH BOOK BY TITLE OR AUTHOR
    '--------------------------------------------
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim query As String = "SELECT * FROM Books WHERE Title LIKE @Search OR Author LIKE @Search"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvBooks.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching books: " & ex.Message)
        End Try
    End Sub


    '--------------------------------------------
    ' LOAD SELECTED RECORD INTO TEXTBOXES
    '--------------------------------------------
    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBooks.Rows(e.RowIndex)
            txtBook_ID.Text = row.Cells("Book_ID").Value.ToString()
            txtTitle.Text = row.Cells("Title").Value.ToString()
            txtAuthor.Text = row.Cells("Author").Value.ToString()
            txtGenre.Text = row.Cells("Genre").Value.ToString()
            cboStatus.Text = row.Cells("Status").Value.ToString()
        End If
    End Sub


    '--------------------------------------------
    ' CLEAR INPUT FIELDS h
    '--------------------------------------------
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtBook_ID.Clear()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtGenre.Clear()
        cboStatus.SelectedIndex = -1
        txtSearch.Clear()
    End Sub

    Private Sub dgvBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick

    End Sub
End Class
