Imports System.Data.OleDb
Public Class App
    'Dim username As String
    'Dim Password As String
    'Private isAdmin As Boolean = False

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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login.Show()
    End Sub
End Class
