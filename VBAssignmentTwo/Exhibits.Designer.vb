<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddArtifact
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
        txtID = New TextBox()
        txtTitle = New TextBox()
        txtLocation = New TextBox()
        btnCancel = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        DataGridView1 = New DataGridView()
        Button8 = New Button()
        txtDescription = New TextBox()
        Label8 = New Label()
        txtTime = New TextBox()
        Label1 = New Label()
        txtDuration = New TextBox()
        Label3 = New Label()
        txtCurator = New TextBox()
        Label5 = New Label()
        txtTheme = New TextBox()
        Label7 = New Label()
        txtStatus = New TextBox()
        Label9 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblAddArtifact
        ' 
        lblAddArtifact.AutoSize = True
        lblAddArtifact.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddArtifact.Location = New Point(12, 9)
        lblAddArtifact.Name = "lblAddArtifact"
        lblAddArtifact.Size = New Size(63, 21)
        lblAddArtifact.TabIndex = 0
        lblAddArtifact.Text = "Exhibits"
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
        Label4.Size = New Size(29, 15)
        Label4.TabIndex = 3
        Label4.Text = "Title"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 106)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 15)
        Label6.TabIndex = 5
        Label6.Text = "Location"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(82, 43)
        txtID.Name = "txtID"
        txtID.Size = New Size(310, 23)
        txtID.TabIndex = 10
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(82, 72)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(310, 23)
        txtTitle.TabIndex = 11
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(82, 103)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(310, 23)
        txtLocation.TabIndex = 12
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(319, 464)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(73, 23)
        btnCancel.TabIndex = 20
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(161, 464)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(73, 23)
        btnDelete.TabIndex = 18
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(240, 464)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(73, 23)
        btnUpdate.TabIndex = 19
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(82, 464)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(73, 23)
        btnAdd.TabIndex = 17
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
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
        ' txtDescription
        ' 
        txtDescription.Location = New Point(82, 277)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(310, 181)
        txtDescription.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 280)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 15)
        Label8.TabIndex = 24
        Label8.Text = "Description"
        ' 
        ' txtTime
        ' 
        txtTime.Location = New Point(82, 132)
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(310, 23)
        txtTime.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(33, 15)
        Label1.TabIndex = 26
        Label1.Text = "Time"
        ' 
        ' txtDuration
        ' 
        txtDuration.Location = New Point(82, 161)
        txtDuration.Name = "txtDuration"
        txtDuration.Size = New Size(310, 23)
        txtDuration.TabIndex = 29
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 28
        Label3.Text = "Duration"
        ' 
        ' txtCurator
        ' 
        txtCurator.Location = New Point(82, 190)
        txtCurator.Name = "txtCurator"
        txtCurator.Size = New Size(310, 23)
        txtCurator.TabIndex = 31
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 15)
        Label5.TabIndex = 30
        Label5.Text = "Curator"
        ' 
        ' txtTheme
        ' 
        txtTheme.Location = New Point(82, 219)
        txtTheme.Name = "txtTheme"
        txtTheme.Size = New Size(310, 23)
        txtTheme.TabIndex = 33
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 223)
        Label7.Name = "Label7"
        Label7.Size = New Size(43, 15)
        Label7.TabIndex = 32
        Label7.Text = "Theme"
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(82, 248)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(310, 23)
        txtStatus.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(14, 252)
        Label9.Name = "Label9"
        Label9.Size = New Size(39, 15)
        Label9.TabIndex = 34
        Label9.Text = "Status"
        ' 
        ' AddArtifact
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(923, 542)
        Controls.Add(txtStatus)
        Controls.Add(Label9)
        Controls.Add(txtTheme)
        Controls.Add(Label7)
        Controls.Add(txtCurator)
        Controls.Add(Label5)
        Controls.Add(txtDuration)
        Controls.Add(Label3)
        Controls.Add(txtTime)
        Controls.Add(Label1)
        Controls.Add(txtDescription)
        Controls.Add(Label8)
        Controls.Add(Button8)
        Controls.Add(DataGridView1)
        Controls.Add(btnAdd)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(btnCancel)
        Controls.Add(txtLocation)
        Controls.Add(txtTitle)
        Controls.Add(txtID)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(lblAddArtifact)
        Name = "AddArtifact"
        Text = "Artifacts"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAddArtifact As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCurator As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTheme As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label9 As Label
End Class
