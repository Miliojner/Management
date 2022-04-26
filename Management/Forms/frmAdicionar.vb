Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Public Class frmAdicionar
    '---------------------------------------------
    Dim convertingString As String = String.Empty
    Dim strConnection As String = My.Settings.Connection
    Dim strCMD As String
    Dim sqlConnection As SqlConnection
    Dim sqlCMD As SqlCommand
    Dim ImageBase As String
    Dim ofdPhoto As New OpenFileDialog
    Dim imgStream As New MemoryStream
    '---------------------------------------------
    '---------------------------------------------

    '---------------------------------------------
    '---------------------------------------------

    '---------------------------------------------
    '---------------------------------------------
    Private Sub frmAdicionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '---------------------------------------------
    '---------------------------------------------
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            strCMD = "INSERT INTO Alunos"
            strCMD += "VALUES( " & txtCod_Aluno.Text & ",'" & txtNome.Text & "','" & txtEndereco.Text & "','" & txtLocalidade.Text & "','" _
                      & txtCod_Postal.Text & "','" & txtCurso.Text & "'," & 1 & ",'" & txtEmail.Text & "','" & ImageBase & "')"
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
        If ofdPhoto.ShowDialog.OK Then
            Dim ImageArray() As Byte = System.IO.File.ReadAllBytes(ofdPhoto.FileName)
            ImageBase = Convert.ToBase64String(ImageArray)
        End If
    End Sub
    '---------------------------------------------
    '---------------------------------------------
End Class