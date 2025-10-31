<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPass = New Label()
        lblUser = New Label()
        btnSignup = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Green
        btnLogin.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(240, 270)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(125, 61)
        btnLogin.TabIndex = 21
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(174, 190)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(191, 31)
        txtPassword.TabIndex = 18
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(174, 137)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(191, 31)
        txtUsername.TabIndex = 17
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblPass.Location = New Point(46, 190)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(102, 28)
        lblPass.TabIndex = 16
        lblPass.Text = "Password:"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblUser.Location = New Point(39, 137)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(109, 28)
        lblUser.TabIndex = 15
        lblUser.Text = "Username:"
        ' 
        ' btnSignup
        ' 
        btnSignup.BackColor = Color.Lavender
        btnSignup.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignup.ForeColor = Color.Black
        btnSignup.Location = New Point(12, 380)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(125, 58)
        btnSignup.TabIndex = 22
        btnSignup.Text = "Sign Up"
        btnSignup.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._29163523685110
        PictureBox1.Location = New Point(426, 78)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(329, 213)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(165, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 31)
        Label1.TabIndex = 24
        Label1.Text = "Welcome!"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(btnSignup)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPass)
        Controls.Add(lblUser)
        Name = "LoginForm"
        Text = "LoginForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents btnSignup As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
