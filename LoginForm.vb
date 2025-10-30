Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class LoginForm
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim cmd As New SqlCommand("SELECT Role FROM Users WHERE Username=@u AND Password=@p", con)
            cmd.Parameters.AddWithValue("@u", txtUsername.Text)
            cmd.Parameters.AddWithValue("@p", txtPassword.Text)

            con.Open()
            Dim role = cmd.ExecuteScalar()
            con.Close()

            If role Is Nothing Then
                MessageBox.Show("Invalid username or password.", "Login Failed")
            Else
                If role.ToString() = "Admin" Then
                    MessageBox.Show("Welcome, Admin!", "Login Successful")
                    MainForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Welcome, Member!", "Login Successful")
                    MemberMainForm.Show()
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        SignUpForm.Show()
        Me.Hide()
    End Sub
End Class
