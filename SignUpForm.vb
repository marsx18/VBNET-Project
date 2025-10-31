Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class SignUpForm
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            ' Check required fields
            If txtUsername.Text = "" Or txtPassword.Text = "" Or cmbRole.Text = "" Then
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Check if username already exists
            Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@u", con)
            checkCmd.Parameters.AddWithValue("@u", txtUsername.Text)
            con.Open()
            Dim count = Convert.ToInt32(checkCmd.ExecuteScalar())
            con.Close()

            If count > 0 Then
                MessageBox.Show("Username already exists. Please choose another one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Step 1: Insert into Users table and get new User_ID
            Dim userQuery As String = "INSERT INTO Users (Username, Password, Role) OUTPUT INSERTED.User_ID VALUES (@u, @p, @r)"
            Dim userCmd As New SqlCommand(userQuery, con)
            userCmd.Parameters.AddWithValue("@u", txtUsername.Text)
            userCmd.Parameters.AddWithValue("@p", txtPassword.Text)
            userCmd.Parameters.AddWithValue("@r", cmbRole.Text)

            con.Open()
            Dim newUserID As Integer = Convert.ToInt32(userCmd.ExecuteScalar())
            con.Close()

            ' Step 2: If role = Member, insert into Members table as well
            If cmbRole.Text = "Member" Then
                Dim memberQuery As String = "INSERT INTO Members (Name, Phone, Email, User_ID) VALUES (@Name, @Phone, @Email, @User_ID)"
                Dim memberCmd As New SqlCommand(memberQuery, con)
                memberCmd.Parameters.AddWithValue("@Name", txtName.Text)
                memberCmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                memberCmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                memberCmd.Parameters.AddWithValue("@User_ID", newUserID)
                con.Open()
                memberCmd.ExecuteNonQuery()
                con.Close()
            End If

            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear all inputs
            txtUsername.Clear()
            txtPassword.Clear()
            txtName.Clear()
            txtPhone.Clear()
            txtEmail.Clear()
            cmbRole.SelectedIndex = -1

            ' Go back to login form
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
