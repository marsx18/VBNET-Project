Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class SignUpForm
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            If txtUsername.Text = "" Or txtPassword.Text = "" Or cmbRole.Text = "" Then
                MessageBox.Show("Please fill in all fields.", "Warning")
                Exit Sub
            End If

            Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@u", con)
            checkCmd.Parameters.AddWithValue("@u", txtUsername.Text)
            con.Open()
            Dim count = checkCmd.ExecuteScalar()
            con.Close()

            If count > 0 Then
                MessageBox.Show("Username already exists. Choose another one.")
                Exit Sub
            End If

            Dim cmd As New SqlCommand("INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, @r)", con)
            cmd.Parameters.AddWithValue("@u", txtUsername.Text)
            cmd.Parameters.AddWithValue("@p", txtPassword.Text)
            cmd.Parameters.AddWithValue("@r", cmbRole.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Account created successfully!", "Success")
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
