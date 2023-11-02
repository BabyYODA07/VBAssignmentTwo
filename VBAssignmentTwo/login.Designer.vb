<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        lblUserName = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnCancel = New Button()
        Button2 = New Button()
        lblGreeting = New Label()
        btnHAM = New Label()
        SuspendLayout()
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Location = New Point(307, 298)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(65, 15)
        lblUserName.TabIndex = 0
        lblUserName.Text = "User Name"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(307, 327)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(378, 290)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(378, 319)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(307, 360)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(403, 360)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lblGreeting
        ' 
        lblGreeting.AutoSize = True
        lblGreeting.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGreeting.Location = New Point(208, 199)
        lblGreeting.Name = "lblGreeting"
        lblGreeting.Size = New Size(375, 45)
        lblGreeting.TabIndex = 6
        lblGreeting.Text = "Please Login to Continue"
        ' 
        ' btnHAM
        ' 
        btnHAM.AccessibleDescription = "Historical Artifact Management"
        btnHAM.AccessibleName = "Historical Artifact Management"
        btnHAM.AutoSize = True
        btnHAM.Font = New Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHAM.Location = New Point(26, 39)
        btnHAM.Name = "btnHAM"
        btnHAM.Size = New Size(54, 21)
        btnHAM.TabIndex = 7
        btnHAM.Text = "HAM"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnHAM)
        Controls.Add(lblGreeting)
        Controls.Add(Button2)
        Controls.Add(btnCancel)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUserName)
        Name = "login"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblGreeting As Label
    Friend WithEvents btnHAM As Label
End Class
