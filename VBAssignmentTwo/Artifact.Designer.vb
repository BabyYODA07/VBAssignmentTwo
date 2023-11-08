<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Artifact
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
        lblAddArtifact = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        txtID = New TextBox()
        txtName = New TextBox()
        txtOrgin = New TextBox()
        txtHistory = New TextBox()
        btnBrowse = New Button()
        btnCancel = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        Label3 = New Label()
        btnRemove = New Button()
        btnCrop = New Button()
        DataGridView1 = New DataGridView()
        Button8 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblAddArtifact
        ' 
        lblAddArtifact.AutoSize = True
        lblAddArtifact.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddArtifact.Location = New Point(12, 9)
        lblAddArtifact.Name = "lblAddArtifact"
        lblAddArtifact.Size = New Size(67, 21)
        lblAddArtifact.TabIndex = 0
        lblAddArtifact.Text = "Artifacts"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 15)
        Label2.TabIndex = 1
        Label2.Text = "ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 3
        Label4.Text = "Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 106)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 15)
        Label6.TabIndex = 5
        Label6.Text = "Origin"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 136)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 15)
        Label8.TabIndex = 8
        Label8.Text = "History"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(59, 223)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(231, 235)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(59, 43)
        txtID.Name = "txtID"
        txtID.Size = New Size(310, 23)
        txtID.TabIndex = 10
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(59, 72)
        txtName.Name = "txtName"
        txtName.Size = New Size(310, 23)
        txtName.TabIndex = 11
        ' 
        ' txtOrgin
        ' 
        txtOrgin.Location = New Point(59, 103)
        txtOrgin.Name = "txtOrgin"
        txtOrgin.Size = New Size(310, 23)
        txtOrgin.TabIndex = 12
        ' 
        ' txtHistory
        ' 
        txtHistory.Location = New Point(59, 133)
        txtHistory.Multiline = True
        txtHistory.Name = "txtHistory"
        txtHistory.Size = New Size(310, 84)
        txtHistory.TabIndex = 13
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(296, 223)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(73, 23)
        btnBrowse.TabIndex = 14
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(296, 464)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(73, 23)
        btnCancel.TabIndex = 20
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(138, 464)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(73, 23)
        btnDelete.TabIndex = 18
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(217, 464)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(73, 23)
        btnUpdate.TabIndex = 19
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(59, 464)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(73, 23)
        btnAdd.TabIndex = 17
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 19
        Label3.Text = "Image"
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(296, 281)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(73, 23)
        btnRemove.TabIndex = 16
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnCrop
        ' 
        btnCrop.AccessibleDescription = "Not Inplimented yet"
        btnCrop.AccessibleName = "Crop"
        btnCrop.Enabled = False
        btnCrop.Location = New Point(296, 252)
        btnCrop.Name = "btnCrop"
        btnCrop.Size = New Size(73, 23)
        btnCrop.TabIndex = 15
        btnCrop.Text = "Crop"
        btnCrop.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.Location = New Point(406, 43)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(480, 415)
        DataGridView1.TabIndex = 22
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(406, 464)
        Button8.Name = "Button8"
        Button8.Size = New Size(73, 23)
        Button8.TabIndex = 23
        Button8.Text = "Print"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' AddArtifact
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(923, 542)
        Controls.Add(Button8)
        Controls.Add(DataGridView1)
        Controls.Add(btnCrop)
        Controls.Add(btnRemove)
        Controls.Add(Label3)
        Controls.Add(btnAdd)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(btnCancel)
        Controls.Add(btnBrowse)
        Controls.Add(txtHistory)
        Controls.Add(txtOrgin)
        Controls.Add(txtName)
        Controls.Add(txtID)
        Controls.Add(PictureBox1)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(lblAddArtifact)
        Name = "AddArtifact"
        Text = "Artifacts"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAddArtifact As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtOrgin As TextBox
    Friend WithEvents txtHistory As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnCrop As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button8 As Button
End Class
