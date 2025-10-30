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
        Label4 = New Label()
        btnAdd = New Button()
        btnUpdate = New Button()
        Panel1 = New Panel()
        lblTitle = New Label()
        grpBookDetails = New GroupBox()
        txtBook_ID = New TextBox()
        Label5 = New Label()
        cboStatus = New ComboBox()
        btnDelete = New Button()
        btnClear = New Button()
        btnSearch = New Button()
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
        dgvBooks.Location = New Point(0, 477)
        dgvBooks.Margin = New Padding(3, 2, 3, 2)
        dgvBooks.Name = "dgvBooks"
        dgvBooks.ReadOnly = True
        dgvBooks.RowHeadersWidth = 51
        dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBooks.Size = New Size(728, 175)
        dgvBooks.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 17)
        Label1.TabIndex = 1
        Label1.Text = "Title :" & vbCrLf
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Segoe UI", 9.75F)
        txtTitle.Location = New Point(113, 74)
        txtTitle.Margin = New Padding(3, 2, 3, 2)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(246, 25)
        txtTitle.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F)
        Label2.Location = New Point(36, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 17)
        Label2.TabIndex = 3
        Label2.Text = "Author :"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Font = New Font("Segoe UI", 9.75F)
        txtAuthor.Location = New Point(113, 118)
        txtAuthor.Margin = New Padding(3, 2, 3, 2)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(246, 25)
        txtAuthor.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.Location = New Point(36, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 17)
        Label3.TabIndex = 5
        Label3.Text = "Genre :"
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Segoe UI", 9.75F)
        txtGenre.Location = New Point(113, 158)
        txtGenre.Margin = New Padding(3, 2, 3, 2)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(246, 25)
        txtGenre.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F)
        Label4.Location = New Point(36, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 17)
        Label4.TabIndex = 7
        Label4.Text = "Status :"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(12, 338)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(105, 30)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(162, 338)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(105, 30)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGreen
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(728, 60)
        Panel1.TabIndex = 11
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(-78, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(884, 60)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Book Management"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' grpBookDetails
        ' 
        grpBookDetails.Controls.Add(txtBook_ID)
        grpBookDetails.Controls.Add(Label5)
        grpBookDetails.Controls.Add(cboStatus)
        grpBookDetails.Controls.Add(Label1)
        grpBookDetails.Controls.Add(txtTitle)
        grpBookDetails.Controls.Add(Label2)
        grpBookDetails.Controls.Add(txtAuthor)
        grpBookDetails.Controls.Add(Label3)
        grpBookDetails.Controls.Add(Label4)
        grpBookDetails.Controls.Add(txtGenre)
        grpBookDetails.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpBookDetails.Location = New Point(12, 73)
        grpBookDetails.Margin = New Padding(3, 10, 3, 3)
        grpBookDetails.Name = "grpBookDetails"
        grpBookDetails.Size = New Size(704, 248)
        grpBookDetails.TabIndex = 12
        grpBookDetails.TabStop = False
        grpBookDetails.Text = "Book Information"
        ' 
        ' txtBook_ID
        ' 
        txtBook_ID.Font = New Font("Segoe UI", 9.75F)
        txtBook_ID.Location = New Point(113, 33)
        txtBook_ID.Margin = New Padding(3, 2, 3, 2)
        txtBook_ID.Name = "txtBook_ID"
        txtBook_ID.ReadOnly = True
        txtBook_ID.Size = New Size(65, 25)
        txtBook_ID.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(36, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 17)
        Label5.TabIndex = 12
        Label5.Text = "Book ID :"
        ' 
        ' cboStatus
        ' 
        cboStatus.Font = New Font("Segoe UI", 9.75F)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Available", "Booked"})
        cboStatus.Location = New Point(113, 198)
        cboStatus.Margin = New Padding(3, 2, 3, 2)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(103, 25)
        cboStatus.TabIndex = 11
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(316, 338)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(105, 30)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(467, 338)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(105, 30)
        btnClear.TabIndex = 14
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(611, 338)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(105, 30)
        btnSearch.TabIndex = 15
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 401)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 21)
        Label6.TabIndex = 16
        Label6.Text = "Book Records"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(17, 436)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(308, 23)
        txtSearch.TabIndex = 17
        ' 
        ' btnSearch2
        ' 
        btnSearch2.Location = New Point(346, 436)
        btnSearch2.Name = "btnSearch2"
        btnSearch2.Size = New Size(75, 23)
        btnSearch2.TabIndex = 18
        btnSearch2.Text = "Search"
        btnSearch2.UseVisualStyleBackColor = True
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' BookForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(728, 652)
        Controls.Add(btnSearch2)
        Controls.Add(txtSearch)
        Controls.Add(Label6)
        Controls.Add(btnSearch)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(dgvBooks)
        Controls.Add(grpBookDetails)
        Controls.Add(Panel1)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Margin = New Padding(3, 2, 3, 2)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpBookDetails As GroupBox
    Friend WithEvents cboStatus As ComboBox
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
