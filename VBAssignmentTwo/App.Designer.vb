<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        Button1 = New Button()
        Button2 = New Button()
        btnAddartifacts = New Button()
        btnAddExhibits = New Button()
        btnUsers = New Button()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(713, 12)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 68)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 23)
        Button1.TabIndex = 1
        Button1.Text = "View Artifacts"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 97)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 23)
        Button2.TabIndex = 2
        Button2.Text = "View Exhibits"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnAddartifacts
        ' 
        btnAddartifacts.Enabled = False
        btnAddartifacts.Location = New Point(12, 126)
        btnAddartifacts.Name = "btnAddartifacts"
        btnAddartifacts.Size = New Size(94, 23)
        btnAddartifacts.TabIndex = 3
        btnAddartifacts.Text = "Add Artifacts"
        btnAddartifacts.UseVisualStyleBackColor = True
        ' 
        ' btnAddExhibits
        ' 
        btnAddExhibits.Enabled = False
        btnAddExhibits.Location = New Point(12, 155)
        btnAddExhibits.Name = "btnAddExhibits"
        btnAddExhibits.Size = New Size(94, 23)
        btnAddExhibits.TabIndex = 4
        btnAddExhibits.Text = "Add Exhibits"
        btnAddExhibits.UseVisualStyleBackColor = True
        ' 
        ' btnUsers
        ' 
        btnUsers.Enabled = False
        btnUsers.Location = New Point(12, 184)
        btnUsers.Name = "btnUsers"
        btnUsers.Size = New Size(94, 23)
        btnUsers.TabIndex = 5
        btnUsers.Text = "Users"
        btnUsers.UseVisualStyleBackColor = True
        ' 
        ' App
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnUsers)
        Controls.Add(btnAddExhibits)
        Controls.Add(btnAddartifacts)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnLogin)
        Name = "App"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAddartifacts As Button
    Friend WithEvents btnAddExhibits As Button
    Friend WithEvents btnUsers As Button

End Class
