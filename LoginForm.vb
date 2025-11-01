Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class LoginForm
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Library.mdf;Integrated Security=True;Connect Timeout=30"

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide password characters with asterisks
        txtPassword.PasswordChar = "•"c  ' You can use "*" if you prefer
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Using con As New SqlConnection(connectionString)
                ' Case-sensitive login using COLLATE
                Dim query As String = "
                    SELECT User_ID, Role 
                    FROM Users 
                    WHERE Username COLLATE SQL_Latin1_General_CP1_CS_AS = @u 
                      AND Password COLLATE SQL_Latin1_General_CP1_CS_AS = @p"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@u", txtUsername.Text)
                cmd.Parameters.AddWithValue("@p", txtPassword.Text)

                con.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim userID As Integer = reader("User_ID")
                    Dim role As String = reader("Role").ToString()
                    con.Close()

                    If role = "Admin" Then
                        MessageBox.Show("Welcome, Admin!", "Login Successful")
                        MainForm.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Welcome, Member!", "Login Successful")

                        ' --- Get corresponding Member_ID for this User ---
                        Dim memberID As Integer
                        Using con2 As New SqlConnection(connectionString)
                            con2.Open()
                            Dim getMemberCmd As New SqlCommand("SELECT Member_ID FROM Members WHERE User_ID=@UserID", con2)
                            getMemberCmd.Parameters.AddWithValue("@UserID", userID)
                            Dim result = getMemberCmd.ExecuteScalar()
                            If result IsNot Nothing Then
                                memberID = Convert.ToInt32(result)
                            End If
                        End Using

                        ' --- Open MemberMainForm ---
                        Dim memberForm As New MemberMainForm()
                        memberForm.MemberID = memberID
                        memberForm.Show()
                        Me.Hide()
                    End If
                Else
                    MessageBox.Show("Invalid username or password (case-sensitive).", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    con.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        SignUpForm.Show()
        Me.Hide()
    End Sub
End Class
