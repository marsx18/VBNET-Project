Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class MembersForm

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True")

    ' Load all members when form opens
    Private Sub MembersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembers()
        SetupGrid()
    End Sub

    Private Sub SetupGrid()
        dgvMembers.ReadOnly = True
        dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' Load all members from database
    Private Sub LoadMembers()
        Try
            Using connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True")
                connection.Open()
                Dim query As String = "SELECT * FROM Members"
                Dim cmd As New SqlCommand(query, connection)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvMembers.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading members: " & ex.Message)
        End Try
    End Sub


    ' Add member
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtName.Text = "" Then
                MessageBox.Show("Please enter a name.")
                Return
            End If

            con.Open()
            Dim query As String = "INSERT INTO Members (Name, Phone, Email) VALUES (@Name, @Phone, @Email)"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Member added successfully!")
            LoadMembers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding member: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Update member
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If dgvMembers.CurrentRow Is Nothing Then
                MessageBox.Show("Please select a member to update.")
                Return
            End If

            Dim memberID As Integer = dgvMembers.CurrentRow.Cells("Member_ID").Value

            con.Open()
            Dim query As String = "UPDATE Members SET Name=@Name, Phone=@Phone, Email=@Email WHERE Member_ID=@ID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@ID", memberID)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Member updated successfully!")
            LoadMembers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating member: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Delete member
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If dgvMembers.CurrentRow Is Nothing Then
                MessageBox.Show("Please select a member to delete.")
                Return
            End If

            Dim memberID As Integer = dgvMembers.CurrentRow.Cells("Member_ID").Value

            con.Open()
            Dim query As String = "DELETE FROM Members WHERE Member_ID=@ID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ID", memberID)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Member deleted successfully!")
            LoadMembers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error deleting member: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Search members
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            con.Open()
            Dim query As String = "SELECT * FROM Members WHERE Name LIKE @search OR Email LIKE @search"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvMembers.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error searching members: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Clear input fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtSearch.Clear()
    End Sub

    ' Click row to fill inputs
    Private Sub dgvMembers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvMembers.Rows(e.RowIndex)
            txtName.Text = row.Cells("Name").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()
            txtEmail.Text = row.Cells("Email").Value.ToString()
        End If
    End Sub

    Private Sub dgvMembers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembers.CellContentClick

    End Sub
End Class
