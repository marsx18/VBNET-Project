Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30")

    ' ========== LOAD DATA ==========
    Private Sub LoadBooks()
        Try
            Dim query As String = "SELECT * FROM Books"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table

            DataGridView1.ReadOnly = True
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.AllowUserToDeleteRows = False
            DataGridView1.RowHeadersVisible = False

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    ' ========== ADD BOOK ==========
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim query As String = "INSERT INTO Books (Title, Author, Genre, Status) VALUES (@Title, @Author, @Genre, @Status)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text)
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
                cmd.Parameters.AddWithValue("@Status", txtStatus.Text)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadBooks()
                ClearTextBoxes()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            con.Close()
        End Try
    End Sub

    ' ========== LOAD BUTTON ==========
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadBooks()
    End Sub

    ' ========== CLEAR INPUT ==========
    Private Sub ClearTextBoxes()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtGenre.Clear()
        txtStatus.Clear()
    End Sub


End Class
