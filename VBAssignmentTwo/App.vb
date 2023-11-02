Public Class App
    Dim username As String
    Dim Password As String
    Private isAdmin As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
    End Sub
End Class
