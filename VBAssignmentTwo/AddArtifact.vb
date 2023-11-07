Imports System.Data.OleDb
Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles

Public Class AddArtifact
    Dim strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\HistoricalArtifactManagement.accdb"
    Dim strQuery As String
    Dim imgdir As String = "..\..\..\images\"
    Dim filename As String = "filename.jpg"
    Sub loadData()
        Dim imgpath As String
        strQuery = "SELECT * From artifacts"
        Using conn As New OleDbConnection(strConn)
            conn.Open()
            Using cmd As New OleDbCommand(strQuery, conn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        txtID.Text = reader.GetValue(0)
                        txtName.Text = reader.GetString(1)
                        txtOrgin.Text = reader.GetString(2)
                        txtHistory.Text = reader.GetString(3)
                        imgpath = reader.GetString(4)
                    End While
                Else
                    MessageBox.Show("No Records Found.")
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Sub filetype()
        Dim imgtype As String
        imgtype = PictureBox1.ImageLocation
        MsgBox(imgtype.Split("."))
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtID.Clear()
        txtName.Clear()
        txtOrgin.Clear()
        txtHistory.Clear()
        Me.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub AddArtifact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Enabled = False
        loadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using conn As New OleDbConnection(strConn)
            strQuery = "INSERT INTO artifacts (ArtifactName, ArtifactOrigin, ArtifactHistoricalSignificance, ArtifactImages) VALUES (@ArtifactName, @ArtifactOrigin, @ArtifactHistoricalSignificance, @ArtifactImages)"
            Using cmd As New OleDbCommand(strQuery, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@ArtifactName", txtName.Text)
                cmd.Parameters.AddWithValue("@ArtifactOrigin", txtOrgin.Text)
                cmd.Parameters.AddWithValue("@ArtifactHistoricalSignificance", txtOrgin.Text)
                cmd.Parameters.AddWithValue("@ArtifactImages", PictureBox1.ImageLocation)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        loadData()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                PictureBox1.ImageLocation = ofd.FileName
                btnCrop.Enabled = True
            End If
        End Using
    End Sub

    Sub savedir()
        If Not System.IO.Directory.Exists(imgdir) Then
            System.IO.Directory.CreateDirectory(imgdir)
        End If
        PictureBox1.Image.Save("..\..\..\images\" & filename & )
    End Sub
    Private Sub btnCrop_Click(sender As Object, e As EventArgs) Handles btnCrop.Click
        savedir()
    End Sub
End Class