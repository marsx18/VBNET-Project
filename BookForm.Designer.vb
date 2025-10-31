<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvBooks = New DataGridView()
        Label1 = New Label()
        txtTitle = New TextBox()
        Label2 = New Label()
        txtAuthor = New TextBox()
        Label3 = New Label()
        txtGenre = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        Panel1 = New Panel()
        lblTitle = New Label()
        grpBookDetails = New GroupBox()
        txtBook_ID = New TextBox()
        Label5 = New Label()
        btnDelete = New Button()
        btnClear = New Button()
        Label6 = New Label()
        txtSearch = New TextBox()
        btnSearch2 = New Button()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        grpBookDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvBooks
        ' 
        dgvBooks.AllowUserToAddRows = False
        dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Dock = DockStyle.Bottom
        dgvBooks.Location = New Point(0, 636)
        dgvBooks.Name = "dgvBooks"
        dgvBooks.ReadOnly = True
        dgvBooks.RowHeadersWidth = 51
        dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBooks.Size = New Size(1033, 233)
        dgvBooks.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(41, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 23)
        Label1.TabIndex = 1
        Label1.Text = "Title :" & vbCrLf
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Segoe UI", 9.75F)
        txtTitle.Location = New Point(129, 99)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(281, 29)
        txtTitle.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F)
        Label2.Location = New Point(41, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 23)
        Label2.TabIndex = 3
        Label2.Text = "Author :"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Font = New Font("Segoe UI", 9.75F)
        txtAuthor.Location = New Point(129, 157)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(281, 29)
        txtAuthor.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.Location = New Point(41, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 23)
        Label3.TabIndex = 5
        Label3.Text = "Genre :"
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Segoe UI", 9.75F)
        txtGenre.Location = New Point(129, 211)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(281, 29)
        txtGenre.TabIndex = 6
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.White
        btnAdd.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnAdd.ForeColor = Color.Green
        btnAdd.Location = New Point(97, 420)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(120, 40)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.White
        btnUpdate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.Green
        btnUpdate.Location = New Point(268, 420)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(120, 40)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGreen
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1033, 80)
        Panel1.TabIndex = 11
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(11, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1010, 80)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Book Management"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' grpBookDetails
        ' 
        grpBookDetails.Controls.Add(txtBook_ID)
        grpBookDetails.Controls.Add(Label5)
        grpBookDetails.Controls.Add(Label1)
        grpBookDetails.Controls.Add(txtTitle)
        grpBookDetails.Controls.Add(Label2)
        grpBookDetails.Controls.Add(txtAuthor)
        grpBookDetails.Controls.Add(Label3)
        grpBookDetails.Controls.Add(txtGenre)
        grpBookDetails.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpBookDetails.Location = New Point(14, 97)
        grpBookDetails.Margin = New Padding(3, 13, 3, 4)
        grpBookDetails.Name = "grpBookDetails"
        grpBookDetails.Padding = New Padding(3, 4, 3, 4)
        grpBookDetails.Size = New Size(805, 292)
        grpBookDetails.TabIndex = 12
        grpBookDetails.TabStop = False
        grpBookDetails.Text = "Book Information"
        ' 
        ' txtBook_ID
        ' 
        txtBook_ID.Font = New Font("Segoe UI", 9.75F)
        txtBook_ID.Location = New Point(129, 44)
        txtBook_ID.Name = "txtBook_ID"
        txtBook_ID.ReadOnly = True
        txtBook_ID.Size = New Size(74, 29)
        txtBook_ID.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(41, 55)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 23)
        Label5.TabIndex = 12
        Label5.Text = "Book ID :"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.White
        btnDelete.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnDelete.ForeColor = Color.Green
        btnDelete.Location = New Point(444, 420)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(120, 40)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnClear.ForeColor = Color.Green
        btnClear.Location = New Point(617, 420)
        btnClear.Margin = New Padding(3, 4, 3, 4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(120, 40)
        btnClear.TabIndex = 14
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(19, 504)
        Label6.Name = "Label6"
        Label6.Size = New Size(141, 28)
        Label6.TabIndex = 16
        Label6.Text = "Book Records"
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(19, 556)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(351, 31)
        txtSearch.TabIndex = 17
        ' 
        ' btnSearch2
        ' 
        btnSearch2.BackColor = Color.White
        btnSearch2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch2.ForeColor = Color.Green
        btnSearch2.Location = New Point(396, 549)
        btnSearch2.Margin = New Padding(3, 4, 3, 4)
        btnSearch2.Name = "btnSearch2"
        btnSearch2.Size = New Size(117, 45)
        btnSearch2.TabIndex = 18
        btnSearch2.Text = "Search"
        btnSearch2.UseVisualStyleBackColor = False
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' BookForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(1033, 869)
        Controls.Add(btnSearch2)
        Controls.Add(txtSearch)
        Controls.Add(Label6)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(dgvBooks)
        Controls.Add(grpBookDetails)
        Controls.Add(Panel1)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Name = "BookForm"
        Text = "Library Management System"
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        grpBookDetails.ResumeLayout(False)
        grpBookDetails.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpBookDetails As GroupBox
    Friend WithEvents txtBook_ID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch2 As Button
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
End Class
