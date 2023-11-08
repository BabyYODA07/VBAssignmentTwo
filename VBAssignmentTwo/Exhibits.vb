Imports System.Data.OleDb
Imports System.Configuration

Public Class AddArtifact
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
        btnCancel.Enabled = IsAdmin
        btnDelete.Enabled = IsAdmin
        btnUpdate.Enabled = IsAdmin

    End Sub
    Sub loadData()
        Dim imgpath As String
        strQuery = "SELECT * From exhibits"
        Using conn As New OleDbConnection(strConn)
            Dim adpter As New OleDbDataAdapter(strQuery, conn)
            conn.Open()
            Using cmd As New OleDbCommand(strQuery, conn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        txtID.Text = reader.GetValue(0)
                        txtTitle.Text = reader.GetString(1)
                        txtLocation.Text = reader.GetString(2)
                        txtDescription.Text = reader.GetString(3)
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
        txtTitle.Clear()
        txtLocation.Clear()
        txtDescription.Clear()
        Me.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        strQuery = "DELETE from exhibits WHERE ArtifactID = @ArtifactID"
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
            strQuery = "INSERT INTO exhibits (ArtifactName, ArtifactOrigin, ArtifactHistoricalSignificance, ArtifactImages) VALUES (@ArtifactName, @ArtifactOrigin, @ArtifactHistoricalSignificance, @ArtifactImages)"
            Using cmd As New OleDbCommand(strQuery, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@ArtifactName", txtTitle.Text)
                cmd.Parameters.AddWithValue("@ArtifactOrigin", txtLocation.Text)
                cmd.Parameters.AddWithValue("@ArtifactHistoricalSignificance", txtDescription.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        loadData()
        txtTitle.Clear()
        txtLocation.Clear()
        txtDescription.Clear()
        txtTitle.Focus()
    End Sub



    '//This Button Will Update the entry 
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        strQuery = "UPDATE exhibits SET ArtifactName = @ArtifactName, ArtifactOrigin = @ArtifactOrigin, ArtifactHistoricalSignificance = @ArtifactHistoricalSignificance, ArtifactImages = @ArtifactImages WHERE ID = @ID"
        Using conn As New OleDbConnection(strConn)
            conn.Open()
            Using cmd As New OleDbCommand(strQuery, conn)
                cmd.Parameters.AddWithValue("@ArtifactName", txtTitle.Text)
                cmd.Parameters.AddWithValue("@ArtifactOrigin", txtLocation.Text)
                cmd.Parameters.AddWithValue("@ArtifactHistoricalSignificance", txtDescription.Text)
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
            txtTitle.Text = selectedRow.Cells("ArtifactName").Value.ToString()
            txtLocation.Text = selectedRow.Cells("ArtifactOrigin").Value.ToString()
            txtDescription.Text = selectedRow.Cells("ArtifactHistoricalSignificance").Value.ToString()

        End If
    End Sub

End Class