Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Public Class frmAdicionar
    '---------------------------------------------
    Public strConnection As String = My.Settings.Connection
    Dim strCMD As String
    Dim sqlConnection As New SqlConnection(strConnection)
    Dim sqlCMD As SqlCommand
    Dim ImageBase As String = Nothing
    Dim ofdPhoto As New OpenFileDialog
    '---------------------------------------------
    '---------------------------------------------

    '---------------------------------------------
    '---------------------------------------------

    '---------------------------------------------
    '---------------------------------------------
    Private Sub frmAdicionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCod_Aluno.ReadOnly = True
        txtCod_Aluno.Text = "A" & frmAlunos.mMaxRow + 1
        btnGuardar.Enabled = False
    End Sub
    '---------------------------------------------
    '---------------------------------------------
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        strCMD = "INSERT INTO Alunos"
        strCMD += " VALUES ('" & txtCod_Aluno.Text & "','" & txtNome.Text & "','" & txtEndereco.Text & "','" & txtLocalidade.Text & "','" & txtCod_Postal.Text & "','" & txtCurso.Text & "'," & 1 & ",'" & txtEmail.Text & "','" & ImageBase & "')"
        Try
            sqlConnection.Open()
            sqlCMD = New SqlCommand(strCMD, sqlConnection)
            Dim x = sqlCMD.ExecuteNonQuery()
            If x Then
                frmAlunos.mMaxRow += 1
            End If
            sqlConnection.Close()
            sqlCMD.Dispose()

            'strCMD = "INSERT INTO Alunos"
            'strCMD += "VALUES( " & txtCod_Aluno.Text & ",'" & txtNome.Text & "','" & txtEndereco.Text & "','" & txtLocalidade.Text & "','" _
            '          & txtCod_Postal.Text & "','" & txtCurso.Text & "'," & 1 & ",'" & txtEmail.Text & "','" & ImageBase & "')"
        Catch ex As Exception
            MsgBox("Erro!!!" + vbCrLf + ex.ToString)
        End Try
        Me.Close()
        frmAlunos.Show()
    End Sub
    '---------------------------------------------
    '---------------------------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmAlunos.Show()
    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        ofdPhoto.ShowDialog()
        Try
            If ofdPhoto.ShowDialog.OK Then
                Dim ImageArray() As Byte = System.IO.File.ReadAllBytes(ofdPhoto.FileName)
                ImageBase = Convert.ToBase64String(ImageArray)
            End If
            btnGuardar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    '---------------------------------------------
    '---------------------------------------------
End Class