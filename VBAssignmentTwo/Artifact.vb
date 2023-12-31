﻿Imports System.Data.OleDb
Imports System.Configuration

Public Class Artifact
    Dim strConn As String = ConfigurationManager.ConnectionStrings("MyConnString").ConnectionString
    Dim strQuery As String
    Dim imgdir As String = "..\..\..\images\"
    Dim dataTable As New DataTable()
    Private IsAdmine As Boolean
    Public Property IsAdmin() As Boolean
        Get
            Return IsAdmine
        End Get
        Set(value As Boolean)
            IsAdmine = value
        End Set
    End Property

    Sub UpdateButtonStates()
        btnAdd.Enabled = IsAdmin
        btnBrowse.Enabled = IsAdmin
        btnCancel.Enabled = IsAdmin
        btnDelete.Enabled = IsAdmin
        btnUpdate.Enabled = IsAdmin
        btnRemove.Enabled = IsAdmin

    End Sub
    Sub loadData()
        Dim imgpath As String
        strQuery = "SELECT * From artifacts"
        Using conn As New OleDbConnection(strConn)
            Dim adpter As New OleDbDataAdapter(strQuery, conn)
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
                adpter.Fill(dataTable)
                DataGridView1.DataSource = dataTable
                reader.Close()
            End Using
        End Using
    End Sub

    Public Function filetype(loc As String) As String
        Dim imgtype As String
        Dim imgtypef() As String
        imgtype = loc
        imgtypef = Split(imgtype, "\")
        imgtypef = Split(imgtypef(imgtypef.GetUpperBound(0)), ".")
        Return imgtypef(1)
    End Function

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtID.Clear()
        txtName.Clear()
        txtOrgin.Clear()
        txtHistory.Clear()
        Me.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        strQuery = "DELETE from artifacts WHERE ArtifactID = @ArtifactID"
        Using conn As New OleDbConnection(strConn)
            conn.Open()
            Using cmd As New OleDbCommand(strQuery, conn)
                cmd.Parameters.AddWithValue("@ArtifactID", txtID.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        loadData()
    End Sub

    Private Sub AddArtifact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateButtonStates()
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
                cmd.Parameters.AddWithValue("@ArtifactHistoricalSignificance", txtHistory.Text)
                cmd.Parameters.AddWithValue("@ArtifactImages", txtID.Text & txtName.Text & "." & filetype(PictureBox1.ImageLocation))
                cmd.ExecuteNonQuery()
            End Using
        End Using
        savedir()
        loadData()
        txtName.Clear()
        txtOrgin.Clear()
        txtHistory.Clear()
        PictureBox1.ImageLocation = ""
        txtName.Focus()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                PictureBox1.ImageLocation = ofd.FileName
            End If
        End Using
    End Sub

    Sub savedir()
        If Not System.IO.Directory.Exists(imgdir) Then
            System.IO.Directory.CreateDirectory(imgdir)
        End If
        PictureBox1.Image.Save(imgdir & txtID.Text & txtName.Text & "." & filetype(PictureBox1.ImageLocation))
    End Sub
    Private Sub btnCrop_Click(sender As Object, e As EventArgs) Handles btnCrop.Click

    End Sub

    '//This Button Will Update the entry 
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        strQuery = "UPDATE artifacts SET ArtifactName = @ArtifactName, ArtifactOrigin = @ArtifactOrigin, ArtifactHistoricalSignificance = @ArtifactHistoricalSignificance, ArtifactImages = @ArtifactImages WHERE ID = @ID"
        Using conn As New OleDbConnection(strConn)
            conn.Open()
            Using cmd As New OleDbCommand(strQuery, conn)
                cmd.Parameters.AddWithValue("@ArtifactName", txtName.Text)
                cmd.Parameters.AddWithValue("@ArtifactOrigin", txtOrgin.Text)
                cmd.Parameters.AddWithValue("@ArtifactHistoricalSignificance", txtHistory.Text)
                cmd.Parameters.AddWithValue("@ArtifactImages", txtID.Text & txtName.Text & "." & filetype(PictureBox1.ImageLocation))
                cmd.Parameters.AddWithValue("@ID", txtID.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        loadData()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            txtID.Text = selectedRow.Cells("ArtifactID").Value.ToString()
            txtName.Text = selectedRow.Cells("ArtifactName").Value.ToString()
            txtOrgin.Text = selectedRow.Cells("ArtifactOrigin").Value.ToString()
            txtHistory.Text = selectedRow.Cells("ArtifactHistoricalSignificance").Value.ToString()
            PictureBox1.ImageLocation = imgdir & selectedRow.Cells("ArtifactImages").Value.ToString()

        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        PictureBox1.ImageLocation = ""
    End Sub
End Class