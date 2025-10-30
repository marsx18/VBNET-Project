<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        txtTitle = New TextBox()
        Label2 = New Label()
        txtAuthor = New TextBox()
        Label3 = New Label()
        txtGenre = New TextBox()
        Label4 = New Label()
        txtStatus = New TextBox()
        btnAdd = New Button()
        btnLoad = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(96, 268)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(635, 188)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(101, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 20)
        Label1.TabIndex = 1
        Label1.Text = "Title"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(271, 73)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(125, 27)
        txtTitle.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 3
        Label2.Text = "Author"
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(271, 118)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(125, 27)
        txtAuthor.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(101, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 5
        Label3.Text = "Genre"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(271, 162)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(125, 27)
        txtGenre.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(101, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 20)
        Label4.TabIndex = 7
        Label4.Text = "Status"
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(271, 209)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(125, 27)
        txtStatus.TabIndex = 8
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(501, 97)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(501, 161)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(94, 29)
        btnLoad.TabIndex = 10
        btnLoad.Text = "Load"
        btnLoad.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(917, 581)
        Controls.Add(btnLoad)
        Controls.Add(btnAdd)
        Controls.Add(txtStatus)
        Controls.Add(Label4)
        Controls.Add(txtGenre)
        Controls.Add(Label3)
        Controls.Add(txtAuthor)
        Controls.Add(Label2)
        Controls.Add(txtTitle)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Library Management System"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnLoad As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
