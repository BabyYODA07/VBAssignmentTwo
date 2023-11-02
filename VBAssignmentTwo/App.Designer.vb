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
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
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
        ' Button3
        ' 
        Button3.Location = New Point(12, 126)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 23)
        Button3.TabIndex = 3
        Button3.Text = "Add Artifacts"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(12, 155)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 23)
        Button4.TabIndex = 4
        Button4.Text = "Add Exhibits"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(12, 184)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 23)
        Button5.TabIndex = 5
        Button5.Text = "Users"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' App
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button

End Class
