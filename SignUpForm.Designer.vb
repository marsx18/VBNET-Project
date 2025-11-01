<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        btnBack = New Button()
        btnRegister = New Button()
        cmbRole = New ComboBox()
        lblRole = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPassword = New Label()
        lblUsername = New Label()
        lblName = New Label()
        txtName = New TextBox()
        lblPhone = New Label()
        txtPhone = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Lavender
        btnBack.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(28, 365)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(148, 61)
        btnBack.TabIndex = 15
        btnBack.Text = "Back to Login"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.SlateBlue
        btnRegister.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(286, 355)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(137, 61)
        btnRegister.TabIndex = 14
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' cmbRole
        ' 
        cmbRole.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Admin", "Member"})
        cmbRole.Location = New Point(260, 285)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(185, 33)
        cmbRole.TabIndex = 13
        cmbRole.Text = "Choose your role"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(185, 285)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(56, 28)
        lblRole.TabIndex = 12
        lblRole.Text = "Role:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(260, 228)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(185, 31)
        txtPassword.TabIndex = 11
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(260, 28)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(185, 31)
        txtUsername.TabIndex = 10
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(139, 228)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(102, 28)
        lblPassword.TabIndex = 9
        lblPassword.Text = "Password:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(132, 31)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(109, 28)
        lblUsername.TabIndex = 8
        lblUsername.Text = "Username:"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(132, 78)
        lblName.Name = "lblName"
        lblName.Size = New Size(109, 28)
        lblName.TabIndex = 16
        lblName.Text = "Full Name:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(260, 75)
        txtName.Name = "txtName"
        txtName.Size = New Size(185, 31)
        txtName.TabIndex = 17
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPhone.Location = New Point(165, 126)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(76, 28)
        lblPhone.TabIndex = 18
        lblPhone.Text = "Phone:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhone.Location = New Point(260, 126)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(185, 31)
        txtPhone.TabIndex = 19
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(176, 174)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(65, 28)
        lblEmail.TabIndex = 20
        lblEmail.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(260, 174)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(185, 31)
        txtEmail.TabIndex = 21
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(618, 450)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(txtPhone)
        Controls.Add(lblPhone)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Controls.Add(btnBack)
        Controls.Add(btnRegister)
        Controls.Add(cmbRole)
        Controls.Add(lblRole)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Name = "SignUpForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignUpForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblRole As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
End Class
