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
        MenuStrip1 = New MenuStrip()
        BooksToolStripMenuItem = New ToolStripMenuItem()
        MembersListToolStripMenuItem = New ToolStripMenuItem()
        BorrowReturnToolStripMenuItem = New ToolStripMenuItem()
        BorrowReturnToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
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
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MainForm"
        Text = "MainForm"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
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
End Class
