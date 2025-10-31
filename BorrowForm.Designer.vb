<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowForm
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
        cmbMember = New ComboBox()
        lblMember = New Label()
        lblBook = New Label()
        cmbBook = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        dtpBorrow = New DateTimePicker()
        dtpDue = New DateTimePicker()
        btnBorrow = New Button()
        btnReturn = New Button()
        dgvBorrowRecords = New DataGridView()
        lblReturn = New Label()
        dtpReturn = New DateTimePicker()
        btnGenerateReport = New Button()
        Panel1 = New Panel()
        lblTitle = New Label()
        CType(dgvBorrowRecords, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbMember
        ' 
        cmbMember.Font = New Font("Segoe UI", 10.2F)
        cmbMember.FormattingEnabled = True
        cmbMember.Location = New Point(200, 139)
        cmbMember.Name = "cmbMember"
        cmbMember.Size = New Size(191, 31)
        cmbMember.TabIndex = 0
        ' 
        ' lblMember
        ' 
        lblMember.AutoSize = True
        lblMember.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblMember.Location = New Point(68, 135)
        lblMember.Name = "lblMember"
        lblMember.Size = New Size(95, 28)
        lblMember.TabIndex = 1
        lblMember.Text = "Member:"
        ' 
        ' lblBook
        ' 
        lblBook.AutoSize = True
        lblBook.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblBook.Location = New Point(68, 181)
        lblBook.Name = "lblBook"
        lblBook.Size = New Size(65, 28)
        lblBook.TabIndex = 2
        lblBook.Text = "Book:"
        ' 
        ' cmbBook
        ' 
        cmbBook.Font = New Font("Segoe UI", 10.2F)
        cmbBook.FormattingEnabled = True
        cmbBook.Location = New Point(200, 183)
        cmbBook.Name = "cmbBook"
        cmbBook.Size = New Size(191, 31)
        cmbBook.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(68, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 28)
        Label3.TabIndex = 4
        Label3.Text = "Borrow date:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(68, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 28)
        Label4.TabIndex = 5
        Label4.Text = "Due date:"
        ' 
        ' dtpBorrow
        ' 
        dtpBorrow.Font = New Font("Segoe UI", 10.2F)
        dtpBorrow.Location = New Point(217, 239)
        dtpBorrow.Name = "dtpBorrow"
        dtpBorrow.Size = New Size(277, 30)
        dtpBorrow.TabIndex = 7
        ' 
        ' dtpDue
        ' 
        dtpDue.Font = New Font("Segoe UI", 10.2F)
        dtpDue.Location = New Point(217, 276)
        dtpDue.Name = "dtpDue"
        dtpDue.Size = New Size(277, 30)
        dtpDue.TabIndex = 8
        ' 
        ' btnBorrow
        ' 
        btnBorrow.BackColor = Color.White
        btnBorrow.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnBorrow.ForeColor = Color.Green
        btnBorrow.Location = New Point(101, 360)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(135, 53)
        btnBorrow.TabIndex = 9
        btnBorrow.Text = "Borrow"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.White
        btnReturn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnReturn.ForeColor = Color.Green
        btnReturn.Location = New Point(256, 360)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(135, 53)
        btnReturn.TabIndex = 10
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' dgvBorrowRecords
        ' 
        dgvBorrowRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBorrowRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrowRecords.Dock = DockStyle.Bottom
        dgvBorrowRecords.Location = New Point(0, 442)
        dgvBorrowRecords.Name = "dgvBorrowRecords"
        dgvBorrowRecords.RowHeadersWidth = 51
        dgvBorrowRecords.Size = New Size(925, 232)
        dgvBorrowRecords.TabIndex = 11
        ' 
        ' lblReturn
        ' 
        lblReturn.AutoSize = True
        lblReturn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblReturn.Location = New Point(565, 245)
        lblReturn.Name = "lblReturn"
        lblReturn.Size = New Size(123, 28)
        lblReturn.TabIndex = 12
        lblReturn.Text = "Return date:"
        ' 
        ' dtpReturn
        ' 
        dtpReturn.Font = New Font("Segoe UI", 10.2F)
        dtpReturn.Location = New Point(565, 276)
        dtpReturn.Name = "dtpReturn"
        dtpReturn.Size = New Size(283, 30)
        dtpReturn.TabIndex = 13
        ' 
        ' btnGenerateReport
        ' 
        btnGenerateReport.BackColor = Color.White
        btnGenerateReport.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnGenerateReport.ForeColor = Color.Green
        btnGenerateReport.Location = New Point(537, 360)
        btnGenerateReport.Name = "btnGenerateReport"
        btnGenerateReport.Size = New Size(188, 53)
        btnGenerateReport.TabIndex = 14
        btnGenerateReport.Text = "Generate Report"
        btnGenerateReport.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGreen
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(925, 80)
        Panel1.TabIndex = 15
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(226, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(512, 80)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Borrow/Return Management"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BorrowForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(925, 674)
        Controls.Add(Panel1)
        Controls.Add(btnGenerateReport)
        Controls.Add(dtpReturn)
        Controls.Add(lblReturn)
        Controls.Add(dgvBorrowRecords)
        Controls.Add(btnReturn)
        Controls.Add(btnBorrow)
        Controls.Add(dtpDue)
        Controls.Add(dtpBorrow)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(cmbBook)
        Controls.Add(lblBook)
        Controls.Add(lblMember)
        Controls.Add(cmbMember)
        Name = "BorrowForm"
        Text = "BorrowForm"
        CType(dgvBorrowRecords, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbMember As ComboBox
    Friend WithEvents lblMember As Label
    Friend WithEvents lblBook As Label
    Friend WithEvents cmbBook As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpBorrow As DateTimePicker
    Friend WithEvents dtpDue As DateTimePicker
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents dgvBorrowRecords As DataGridView
    Friend WithEvents lblReturn As Label
    Friend WithEvents dtpReturn As DateTimePicker
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
End Class
