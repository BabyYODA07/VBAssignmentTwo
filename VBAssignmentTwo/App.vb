Imports System.ComponentModel
Imports System.Data.OleDb

Public Class App
    Private IsAdmin As Boolean = True
    Private TokenPath As String = "..\..\..\sessiontoken.temp"

    Sub Auth()
        If My.Computer.FileSystem.FileExists(TokenPath) Then
            Try
                Dim reader As New IO.StreamReader(TokenPath)
                Dim AuthStatus As String = reader.ReadLine.Remove(0, 15)
                reader.Close()
                IsAdmin = AuthStatus
            Catch ex As Exception
                IsAdmin = False
            End Try
        Else
            IsAdmin = False
        End If
    End Sub

    Sub AuthClear()
        If My.Computer.FileSystem.FileExists(TokenPath) Then
            Try
                My.Computer.FileSystem.DeleteFile(TokenPath)
            Catch ex As Exception
                ' Handle the exception (e.g., show an error message)
            End Try
        End If
    End Sub

    Sub UpdateButtonStates()
        btnUsers.Enabled = IsAdmin
        btnLogin.Text = If(IsAdmin, "Logout", "Login")
    End Sub

    Private Sub BtnLoginLogout_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If btnLogin.Text = "Logout" Then
            IsAdmin = False
            UpdateButtonStates()
        Else
            login.ShowDialog()
            Auth()
            UpdateButtonStates()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddartifacts.Click
        Dim Artifactform As New Artifact()
        Artifactform.IsAdmin = IsAdmin
        Artifactform.Show()
    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auth()
        UpdateButtonStates()
        btnAddartifacts.Focus()
    End Sub

    Private Sub App_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        AuthClear()
    End Sub

    Private Sub btnAddExhibits_Click(sender As Object, e As EventArgs) Handles btnAddExhibits.Click

    End Sub
End Class
