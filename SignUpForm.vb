Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class SignUpForm
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide password input with dots
        txtPassword.PasswordChar = "•"c
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            ' Trim input spaces
            Dim username As String = txtUsername.Text.Trim()
            Dim password As String = txtPassword.Text.Trim()
            Dim role As String = cmbRole.Text.Trim()

            ' --- Validation ---
            If username = "" Or password = "" Or role = "" Then
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' --- Check if username already exists (case-insensitive) ---
            Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Users WHERE Username COLLATE SQL_Latin1_General_CP1_CS_AS = @u", con)
            checkCmd.Parameters.AddWithValue("@u", username)

            con.Open()
            Dim count = Convert.ToInt32(checkCmd.ExecuteScalar())
            con.Close()

            If count > 0 Then
                MessageBox.Show("Username already exists. Please choose another one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' --- Insert into Users table and return new User_ID ---
            Dim userQuery As String = "
                INSERT INTO Users (Username, Password, Role)
                OUTPUT INSERTED.User_ID
                VALUES (@u, @p, @r)"
            Dim userCmd As New SqlCommand(userQuery, con)
            userCmd.Parameters.AddWithValue("@u", username)
            userCmd.Parameters.AddWithValue("@p", password)
            userCmd.Parameters.AddWithValue("@r", role)

            con.Open()
            Dim newUserID As Integer = Convert.ToInt32(userCmd.ExecuteScalar())
            con.Close()

            ' --- If role = Member, insert into Members table as well ---
            If role = "Member" Then
                Dim memberQuery As String = "
                    INSERT INTO Members (Name, Phone, Email, User_ID)
                    VALUES (@Name, @Phone, @Email, @User_ID)"
                Dim memberCmd As New SqlCommand(memberQuery, con)
                memberCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim())
                memberCmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                memberCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                memberCmd.Parameters.AddWithValue("@User_ID", newUserID)
                con.Open()
                memberCmd.ExecuteNonQuery()
                con.Close()
            End If

            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' --- Clear inputs ---
            txtUsername.Clear()
            txtPassword.Clear()
            txtName.Clear()
            txtPhone.Clear()
            txtEmail.Clear()
            cmbRole.SelectedIndex = -1

            ' --- Back to login ---
            LoginForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class
