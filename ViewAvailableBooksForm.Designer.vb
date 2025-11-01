<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAvailableBooksForm
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
        btnBorrow = New Button()
        btnSearch = New Button()
        txtSearch = New TextBox()
        dgvAvailableBooks = New DataGridView()
        Panel1 = New Panel()
        lblTitle = New Label()
        dtpDue = New DateTimePicker()
        dtpBorrow = New DateTimePicker()
        Label4 = New Label()
        Label3 = New Label()
        CType(dgvAvailableBooks, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBorrow
        ' 
        btnBorrow.BackColor = Color.Green
        btnBorrow.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBorrow.ForeColor = Color.White
        btnBorrow.Location = New Point(353, 500)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(194, 72)
        btnBorrow.TabIndex = 3
        btnBorrow.Text = "Borrow"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Navy
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(353, 347)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(107, 38)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(12, 351)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(323, 30)
        txtSearch.TabIndex = 1
        ' 
        ' dgvAvailableBooks
        ' 
        dgvAvailableBooks.AllowUserToAddRows = False
        dgvAvailableBooks.AllowUserToDeleteRows = False
        dgvAvailableBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAvailableBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAvailableBooks.Location = New Point(0, 73)
        dgvAvailableBooks.MultiSelect = False
        dgvAvailableBooks.Name = "dgvAvailableBooks"
        dgvAvailableBooks.ReadOnly = True
        dgvAvailableBooks.RowHeadersWidth = 51
        dgvAvailableBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAvailableBooks.Size = New Size(917, 245)
        dgvAvailableBooks.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(911, 80)
        Panel1.TabIndex = 15
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(260, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(391, 80)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Available Books"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtpDue
        ' 
        dtpDue.Font = New Font("Segoe UI", 10.2F)
        dtpDue.Location = New Point(169, 436)
        dtpDue.Name = "dtpDue"
        dtpDue.Size = New Size(277, 30)
        dtpDue.TabIndex = 19
        ' 
        ' dtpBorrow
        ' 
        dtpBorrow.Font = New Font("Segoe UI", 10.2F)
        dtpBorrow.Location = New Point(169, 399)
        dtpBorrow.Name = "dtpBorrow"
        dtpBorrow.Size = New Size(277, 30)
        dtpBorrow.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(20, 434)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 28)
        Label4.TabIndex = 17
        Label4.Text = "Due date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(20, 397)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 28)
        Label3.TabIndex = 16
        Label3.Text = "Borrow date:"
        ' 
        ' ViewAvailableBooksForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(911, 584)
        Controls.Add(dtpDue)
        Controls.Add(dtpBorrow)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnSearch)
        Controls.Add(btnBorrow)
        Controls.Add(txtSearch)
        Controls.Add(Panel1)
        Controls.Add(dgvAvailableBooks)
        Name = "ViewAvailableBooksForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewAvailableBooks"
        CType(dgvAvailableBooks, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvAvailableBooks As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents dtpDue As DateTimePicker
    Friend WithEvents dtpBorrow As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
