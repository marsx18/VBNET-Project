<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembersForm
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
        lblName = New Label()
        lblPhone = New Label()
        lblEmail = New Label()
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        txtSearch = New TextBox()
        btnSearch = New Button()
        dgvMembers = New DataGridView()
        Panel1 = New Panel()
        lblTitle = New Label()
        GroupBox1 = New GroupBox()
        CType(dgvMembers, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(44, 61)
        lblName.Name = "lblName"
        lblName.Size = New Size(71, 28)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPhone.Location = New Point(39, 114)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(76, 28)
        lblPhone.TabIndex = 1
        lblPhone.Text = "Phone:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(50, 169)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(65, 28)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(136, 61)
        txtName.Name = "txtName"
        txtName.Size = New Size(283, 30)
        txtName.TabIndex = 3
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhone.Location = New Point(136, 116)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(283, 30)
        txtPhone.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(136, 167)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(283, 30)
        txtEmail.TabIndex = 5
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnAdd.ForeColor = Color.Green
        btnAdd.Location = New Point(123, 389)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(123, 40)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.Green
        btnUpdate.Location = New Point(279, 389)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(123, 40)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnDelete.ForeColor = Color.Green
        btnDelete.Location = New Point(453, 389)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(123, 40)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnClear.ForeColor = Color.Green
        btnClear.Location = New Point(624, 389)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(123, 40)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(38, 475)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(341, 31)
        txtSearch.TabIndex = 11
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.Green
        btnSearch.Location = New Point(430, 473)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(111, 40)
        btnSearch.TabIndex = 12
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' dgvMembers
        ' 
        dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMembers.Dock = DockStyle.Bottom
        dgvMembers.Location = New Point(0, 542)
        dgvMembers.Name = "dgvMembers"
        dgvMembers.RowHeadersWidth = 51
        dgvMembers.Size = New Size(924, 189)
        dgvMembers.TabIndex = 13
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGreen
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(924, 80)
        Panel1.TabIndex = 14
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(269, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(391, 80)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Members Management"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(lblName)
        GroupBox1.Controls.Add(lblPhone)
        GroupBox1.Controls.Add(lblEmail)
        GroupBox1.Controls.Add(txtPhone)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 109)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(865, 260)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Member Information"
        ' 
        ' MembersForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(924, 731)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(dgvMembers)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Name = "MembersForm"
        Text = "MembersForm"
        CType(dgvMembers, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
