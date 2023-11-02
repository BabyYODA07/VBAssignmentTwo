Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strusername As String = "qwe"
        Dim strpassword As String = "123"
        Dim directoryPath As String = "C:\Users\root\Desktop\test\test.temp"
        If txtUsername.Text = strusername And txtPassword.Text = strpassword Then
            MsgBox("Success!")
            Try
                My.Computer.FileSystem.WriteAllText(directoryPath, "Authenticated: True" & Environment.NewLine & "Duration: 1000", False)
            Catch ex As Exception
                System.IO.Directory.CreateDirectory(directoryPath)
                My.Computer.FileSystem.WriteAllText(directoryPath, "Authenticated: True" & Environment.NewLine & "Duration: 1000", False)
            End Try
        Else
            MessageBox.Show("Login failed. Please check your credentials.")
        End If
    End Sub
End Class