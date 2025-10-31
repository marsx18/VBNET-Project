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
        CType(dgvBorrowRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbMember
        ' 
        cmbMember.FormattingEnabled = True
        cmbMember.Location = New Point(146, 54)
        cmbMember.Name = "cmbMember"
        cmbMember.Size = New Size(151, 28)
        cmbMember.TabIndex = 0
        ' 
        ' lblMember
        ' 
        lblMember.AutoSize = True
        lblMember.Location = New Point(63, 57)
        lblMember.Name = "lblMember"
        lblMember.Size = New Size(68, 20)
        lblMember.TabIndex = 1
        lblMember.Text = "Member:"
        ' 
        ' lblBook
        ' 
        lblBook.AutoSize = True
        lblBook.Location = New Point(63, 103)
        lblBook.Name = "lblBook"
        lblBook.Size = New Size(46, 20)
        lblBook.TabIndex = 2
        lblBook.Text = "Book:"
        ' 
        ' cmbBook
        ' 
        cmbBook.FormattingEnabled = True
        cmbBook.Location = New Point(146, 103)
        cmbBook.Name = "cmbBook"
        cmbBook.Size = New Size(151, 28)
        cmbBook.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(63, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 20)
        Label3.TabIndex = 4
        Label3.Text = "Borrow date:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(63, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 5
        Label4.Text = "Due date:"
        ' 
        ' dtpBorrow
        ' 
        dtpBorrow.Location = New Point(163, 154)
        dtpBorrow.Name = "dtpBorrow"
        dtpBorrow.Size = New Size(250, 27)
        dtpBorrow.TabIndex = 7
        ' 
        ' dtpDue
        ' 
        dtpDue.Location = New Point(163, 191)
        dtpDue.Name = "dtpDue"
        dtpDue.Size = New Size(250, 27)
        dtpDue.TabIndex = 8
        ' 
        ' btnBorrow
        ' 
        btnBorrow.Location = New Point(99, 278)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(94, 29)
        btnBorrow.TabIndex = 9
        btnBorrow.Text = "Borrow"
        btnBorrow.UseVisualStyleBackColor = True
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(254, 278)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(94, 29)
        btnReturn.TabIndex = 10
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' dgvBorrowRecords
        ' 
        dgvBorrowRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrowRecords.Dock = DockStyle.Bottom
        dgvBorrowRecords.Location = New Point(0, 339)
        dgvBorrowRecords.Name = "dgvBorrowRecords"
        dgvBorrowRecords.RowHeadersWidth = 51
        dgvBorrowRecords.Size = New Size(925, 261)
        dgvBorrowRecords.TabIndex = 11
        ' 
        ' lblReturn
        ' 
        lblReturn.AutoSize = True
        lblReturn.Location = New Point(555, 159)
        lblReturn.Name = "lblReturn"
        lblReturn.Size = New Size(89, 20)
        lblReturn.TabIndex = 12
        lblReturn.Text = "Return date:"
        ' 
        ' dtpReturn
        ' 
        dtpReturn.Location = New Point(555, 189)
        dtpReturn.Name = "dtpReturn"
        dtpReturn.Size = New Size(250, 27)
        dtpReturn.TabIndex = 13
        ' 
        ' BorrowForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(925, 600)
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
End Class
