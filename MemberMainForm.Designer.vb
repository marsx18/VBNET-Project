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
        MenuStrip1 = New MenuStrip()
        VIEWToolStripMenuItem = New ToolStripMenuItem()
        AvailableBooksToolStripMenuItem = New ToolStripMenuItem()
        BorrowedBooksToolStripMenuItem = New ToolStripMenuItem()
        ABOUTToolStripMenuItem = New ToolStripMenuItem()
        LOGOUTToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
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
        AvailableBooksToolStripMenuItem.Size = New Size(224, 26)
        AvailableBooksToolStripMenuItem.Text = "Available books"
        ' 
        ' BorrowedBooksToolStripMenuItem
        ' 
        BorrowedBooksToolStripMenuItem.Name = "BorrowedBooksToolStripMenuItem"
        BorrowedBooksToolStripMenuItem.Size = New Size(224, 26)
        BorrowedBooksToolStripMenuItem.Text = "Borrowed books"
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
        ' MemberMainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MemberMainForm"
        Text = "MemberMainForm"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvailableBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowedBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
End Class
