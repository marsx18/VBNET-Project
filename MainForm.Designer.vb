<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        MenuStrip1 = New MenuStrip()
        BooksToolStripMenuItem = New ToolStripMenuItem()
        MembersListToolStripMenuItem = New ToolStripMenuItem()
        BorrowReturnToolStripMenuItem = New ToolStripMenuItem()
        BorrowReturnToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {BooksToolStripMenuItem, AboutToolStripMenuItem, LogoutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' BooksToolStripMenuItem
        ' 
        BooksToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MembersListToolStripMenuItem, BorrowReturnToolStripMenuItem, BorrowReturnToolStripMenuItem1})
        BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        BooksToolStripMenuItem.Size = New Size(58, 24)
        BooksToolStripMenuItem.Text = "VIEW"
        ' 
        ' MembersListToolStripMenuItem
        ' 
        MembersListToolStripMenuItem.Name = "MembersListToolStripMenuItem"
        MembersListToolStripMenuItem.Size = New Size(240, 26)
        MembersListToolStripMenuItem.Text = "Book Management"
        ' 
        ' BorrowReturnToolStripMenuItem
        ' 
        BorrowReturnToolStripMenuItem.Name = "BorrowReturnToolStripMenuItem"
        BorrowReturnToolStripMenuItem.Size = New Size(240, 26)
        BorrowReturnToolStripMenuItem.Text = "Member Management"
        ' 
        ' BorrowReturnToolStripMenuItem1
        ' 
        BorrowReturnToolStripMenuItem1.Name = "BorrowReturnToolStripMenuItem1"
        BorrowReturnToolStripMenuItem1.Size = New Size(240, 26)
        BorrowReturnToolStripMenuItem1.Text = "Borrow / Return"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(71, 24)
        AboutToolStripMenuItem.Text = "ABOUT"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(79, 24)
        LogoutToolStripMenuItem.Text = "LOGOUT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(296, 240)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 31)
        Label1.TabIndex = 1
        Label1.Text = "Welcome, Admin!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(343, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(144, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(285, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(248, 19)
        Label2.TabIndex = 3
        Label2.Text = "Smart Library Management System"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.FlatAppearance.BorderSize = 3
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(73, 328)
        Button1.Name = "Button1"
        Button1.Size = New Size(176, 66)
        Button1.TabIndex = 4
        Button1.Text = "Manage Books"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Highlight
        Button2.FlatAppearance.BorderColor = Color.Black
        Button2.FlatAppearance.BorderSize = 3
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(311, 328)
        Button2.Name = "Button2"
        Button2.Size = New Size(176, 66)
        Button2.TabIndex = 5
        Button2.Text = "Manage Members"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Highlight
        Button3.FlatAppearance.BorderColor = Color.Black
        Button3.FlatAppearance.BorderSize = 3
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(548, 328)
        Button3.Name = "Button3"
        Button3.Size = New Size(176, 66)
        Button3.TabIndex = 6
        Button3.Text = "Manage Borrows/Returns"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainForm"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MembersListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowReturnToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
