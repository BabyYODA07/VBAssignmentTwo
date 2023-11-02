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
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label3 = New Label()
        Button6 = New Button()
        Button7 = New Button()
        DataGridView1 = New DataGridView()
        Button8 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 0
        Label1.Text = "Add Artifacts"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 15)
        Label2.TabIndex = 1
        Label2.Text = "ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 3
        Label4.Text = "Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 120)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 15)
        Label6.TabIndex = 5
        Label6.Text = "Origin"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 150)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 15)
        Label8.TabIndex = 8
        Label8.Text = "History"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(57, 237)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(231, 235)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(57, 57)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(310, 23)
        TextBox1.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(57, 86)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(310, 23)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(57, 117)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(310, 23)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(57, 147)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(310, 84)
        TextBox4.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(294, 237)
        Button1.Name = "Button1"
        Button1.Size = New Size(73, 23)
        Button1.TabIndex = 14
        Button1.Text = "Browse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(57, 478)
        Button2.Name = "Button2"
        Button2.Size = New Size(73, 23)
        Button2.TabIndex = 15
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(136, 478)
        Button3.Name = "Button3"
        Button3.Size = New Size(73, 23)
        Button3.TabIndex = 16
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(215, 478)
        Button4.Name = "Button4"
        Button4.Size = New Size(73, 23)
        Button4.TabIndex = 17
        Button4.Text = "Update"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(294, 478)
        Button5.Name = "Button5"
        Button5.Size = New Size(73, 23)
        Button5.TabIndex = 18
        Button5.Text = "Add"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 19
        Label3.Text = "Image"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(294, 295)
        Button6.Name = "Button6"
        Button6.Size = New Size(73, 23)
        Button6.TabIndex = 20
        Button6.Text = "Remove"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(294, 266)
        Button7.Name = "Button7"
        Button7.Size = New Size(73, 23)
        Button7.TabIndex = 21
        Button7.Text = "Crop"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(404, 57)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(309, 415)
        DataGridView1.TabIndex = 22
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(404, 478)
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
        ClientSize = New Size(738, 542)
        Controls.Add(Button8)
        Controls.Add(DataGridView1)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Label3)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AddArtifact"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button8 As Button
End Class
