<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberMainForm))
        MenuStrip1 = New MenuStrip()
        VIEWToolStripMenuItem = New ToolStripMenuItem()
        AvailableBooksToolStripMenuItem = New ToolStripMenuItem()
        BorrowedBooksToolStripMenuItem = New ToolStripMenuItem()
        ABOUTToolStripMenuItem = New ToolStripMenuItem()
        LOGOUTToolStripMenuItem = New ToolStripMenuItem()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        btnViewBorrowedBooks = New Button()
        btnViewAvailableBooks = New Button()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {VIEWToolStripMenuItem, ABOUTToolStripMenuItem, LOGOUTToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' VIEWToolStripMenuItem
        ' 
        VIEWToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AvailableBooksToolStripMenuItem, BorrowedBooksToolStripMenuItem})
        VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        VIEWToolStripMenuItem.Size = New Size(58, 24)
        VIEWToolStripMenuItem.Text = "VIEW"
        ' 
        ' AvailableBooksToolStripMenuItem
        ' 
        AvailableBooksToolStripMenuItem.Name = "AvailableBooksToolStripMenuItem"
        AvailableBooksToolStripMenuItem.Size = New Size(201, 26)
        AvailableBooksToolStripMenuItem.Text = "Available Books"
        ' 
        ' BorrowedBooksToolStripMenuItem
        ' 
        BorrowedBooksToolStripMenuItem.Name = "BorrowedBooksToolStripMenuItem"
        BorrowedBooksToolStripMenuItem.Size = New Size(201, 26)
        BorrowedBooksToolStripMenuItem.Text = "Borrowed Books"
        ' 
        ' ABOUTToolStripMenuItem
        ' 
        ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        ABOUTToolStripMenuItem.Size = New Size(71, 24)
        ABOUTToolStripMenuItem.Text = "ABOUT"
        ' 
        ' LOGOUTToolStripMenuItem
        ' 
        LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        LOGOUTToolStripMenuItem.Size = New Size(79, 24)
        LOGOUTToolStripMenuItem.Text = "LOGOUT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(268, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(248, 19)
        Label2.TabIndex = 6
        Label2.Text = "Smart Library Management System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(326, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(144, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(267, 245)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 31)
        Label1.TabIndex = 4
        Label1.Text = "Welcome, Member!"
        ' 
        ' btnViewBorrowedBooks
        ' 
        btnViewBorrowedBooks.BackColor = SystemColors.Highlight
        btnViewBorrowedBooks.FlatAppearance.BorderColor = Color.Black
        btnViewBorrowedBooks.FlatAppearance.BorderSize = 3
        btnViewBorrowedBooks.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewBorrowedBooks.ForeColor = Color.White
        btnViewBorrowedBooks.Location = New Point(428, 326)
        btnViewBorrowedBooks.Name = "btnViewBorrowedBooks"
        btnViewBorrowedBooks.Size = New Size(176, 66)
        btnViewBorrowedBooks.TabIndex = 8
        btnViewBorrowedBooks.Text = "Borrowed Books"
        btnViewBorrowedBooks.UseVisualStyleBackColor = False
        ' 
        ' btnViewAvailableBooks
        ' 
        btnViewAvailableBooks.BackColor = SystemColors.Highlight
        btnViewAvailableBooks.FlatAppearance.BorderColor = Color.Black
        btnViewAvailableBooks.FlatAppearance.BorderSize = 3
        btnViewAvailableBooks.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewAvailableBooks.ForeColor = Color.White
        btnViewAvailableBooks.Location = New Point(190, 326)
        btnViewAvailableBooks.Name = "btnViewAvailableBooks"
        btnViewAvailableBooks.Size = New Size(176, 66)
        btnViewAvailableBooks.TabIndex = 7
        btnViewAvailableBooks.Text = "Available Books"
        btnViewAvailableBooks.UseVisualStyleBackColor = False
        ' 
        ' MemberMainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnViewBorrowedBooks)
        Controls.Add(btnViewAvailableBooks)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MemberMainForm"
        Text = "MemberMainForm"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvailableBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowedBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnViewBorrowedBooks As Button
    Friend WithEvents btnViewAvailableBooks As Button
End Class
