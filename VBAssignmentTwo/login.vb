Imports System.Data.OleDb
Public Class login
    Dim strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\HistoricalArtifactManagement.accdb"
    Dim strQuery As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim directoryPath As String = "..\..\..\sessiontoken.temp"
        strQuery = "SELECT * From users WHERE Username = @Username"
        Using conn As New OleDbConnection(strConn)
            conn.Open()
            Using cmd As New OleDbCommand(strQuery, conn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        If txtUsername.Text = reader.GetString(1) And txtPassword.Text = reader.GetString(2) Then
                            Try
                                My.Computer.FileSystem.WriteAllText(directoryPath, "Authenticated: True" & Environment.NewLine & "Duration: 1000", False)
                            Catch ex As Exception
                                System.IO.Directory.CreateDirectory(directoryPath)
                                My.Computer.FileSystem.WriteAllText(directoryPath, "Authenticated: True" & Environment.NewLine & "Duration: 1000", False)
                            End Try
                            txtUsername.Clear()
                            txtPassword.Clear()

                            Me.Close()
                        Else
                            MessageBox.Show("Login failed. Please check your credentials.")
                        End If

                    End While
                Else
                    MessageBox.Show("Login failed. Please check your credentials.")
                End If
                reader.Close()
            End Using
        End Using

        'If txtUsername.Text = strusername And txtPassword.Text = strpassword Then

        '    Try
        '        My.Computer.FileSystem.WriteAllText(directoryPath, "Authenticated: True" & Environment.NewLine & "Duration: 1000", False)
        '    Catch ex As Exception
        '        System.IO.Directory.CreateDirectory(directoryPath)
        '        My.Computer.FileSystem.WriteAllText(directoryPath, "Authenticated: True" & Environment.NewLine & "Duration: 1000", False)
        '    End Try

    End Sub

End Class