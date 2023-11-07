Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Security.Cryptography
Public Class App
    'Dim username As String
    'Dim Password As String
    Private isAdmin As Boolean = False
    Private tokenpath As String = "..\..\..\sessiontoken.temp"

    'Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\root\Source\Repos\CPT117-Visual-Basic\WindowsApp13\WindowsApp13\Database23.mdb"
    'Dim strQuery As String

    'Sub loadData()
    '    strQuery = "SELECT * From info"
    '    Using conn As New OleDbConnection(strConn)
    '        conn.Open()
    '        Using cmd As New OleDbCommand(strQuery, conn)
    '            Dim reader As OleDbDataReader = cmd.ExecuteReader()
    '            If reader.HasRows Then
    '                While reader.Read()
    '                    txtID.Text = reader.GetValue(0)
    '                    txtFirstName.Text = reader.GetString(1)
    '                    txtLastName.Text = reader.GetString(2)
    '                End While
    '            Else
    '                MessageBox.Show("No Records Found.")
    '            End If
    '            reader.Close()
    '        End Using
    '    End Using
    'End Sub

    Sub auth()
        If My.Computer.FileSystem.FileExists(tokenpath) Then
            Dim reader As New IO.StreamReader(tokenpath)
            Dim AuthStatus As String
            AuthStatus = reader.ReadLine.Remove(0, 15)
            reader.Close()
            isAdmin = AuthStatus
        Else
            isAdmin = False

        End If

    End Sub
    Sub authclear()
        If My.Computer.FileSystem.FileExists(tokenpath) Then
            My.Computer.FileSystem.DeleteFile(tokenpath)
        End If
    End Sub
    Sub access()
        If isAdmin = True Then
            btnAddartifacts.Enabled = True
            btnAddExhibits.Enabled = True
            btnUsers.Enabled = True
            btnLogin.Text = "Logout"
            authclear()
        Else
            btnAddartifacts.Enabled = False
            btnAddExhibits.Enabled = False
            btnUsers.Enabled = False
        End If

    End Sub


    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If btnLogin.Text = "Logout" Then
            btnAddartifacts.Enabled = False
            btnAddExhibits.Enabled = False
            btnUsers.Enabled = False
            btnLogin.Text = "Login"

        Else
            login.ShowDialog()
            auth()
            access()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddartifacts.Click
        AddArtifact.Show()
    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub App_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        authclear()
    End Sub
End Class
