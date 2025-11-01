<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBorrowedBooksForm
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
        Panel1 = New Panel()
        lblTitle = New Label()
        dgvBorrowedBooks = New DataGridView()
        lblTotalFine = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        Panel1.SuspendLayout()
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(907, 80)
        Panel1.TabIndex = 16
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(244, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(391, 80)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Borrowed Books"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvBorrowedBooks
        ' 
        dgvBorrowedBooks.AllowUserToAddRows = False
        dgvBorrowedBooks.AllowUserToDeleteRows = False
        dgvBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrowedBooks.Location = New Point(0, 74)
        dgvBorrowedBooks.MultiSelect = False
        dgvBorrowedBooks.Name = "dgvBorrowedBooks"
        dgvBorrowedBooks.ReadOnly = True
        dgvBorrowedBooks.RowHeadersWidth = 51
        dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBorrowedBooks.Size = New Size(907, 232)
        dgvBorrowedBooks.TabIndex = 17
        ' 
        ' lblTotalFine
        ' 
        lblTotalFine.AutoSize = True
        lblTotalFine.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalFine.Location = New Point(35, 379)
        lblTotalFine.Name = "lblTotalFine"
        lblTotalFine.Size = New Size(96, 38)
        lblTotalFine.TabIndex = 18
        lblTotalFine.Text = "Label1"
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(35, 328)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(311, 31)
        txtSearch.TabIndex = 19
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Navy
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(374, 323)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(113, 44)
        btnSearch.TabIndex = 20
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' ViewBorrowedBooksForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(907, 445)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lblTotalFine)
        Controls.Add(dgvBorrowedBooks)
        Controls.Add(Panel1)
        Name = "ViewBorrowedBooksForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewBorrowedBooksForm"
        Panel1.ResumeLayout(False)
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvBorrowedBooks As DataGridView
    Friend WithEvents lblTotalFine As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
End Class
