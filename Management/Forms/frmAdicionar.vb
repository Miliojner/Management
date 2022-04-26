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
    '---------------------------------------------
    '---------------------------------------------
    Private Sub frmAdicionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '---------------------------------------------
    '---------------------------------------------

    'TODO  || Private Function btnOpen_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click ||
    'TODO  ||     Dim newImg As New OpenFileDialog With {                                                ||
    'TODO  ||         .Filter = "Images(*.jpg;*png;*bmp) |*.jpg;*png;*bmp"                               ||
    'TODO  ||     }                                                                                      ||
    'TODO  ||                                                                                            ||
    'TODO  ||     Dim ms As New MemoryStream()                                                           ||
    'TODO  ||     picPhotoPreview.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)                ||
    'TODO  ||     convertingString = Convert.ToBase64String(ms.ToArray())                                ||
    'TODO  ||     Return convertingString                                                                ||
    'TODO  || End Function                                                                               ||
    'TODO  ||
    'TODO  ||---------------------------------------------
    'TODO  ||---------------------------------------------
    'TODO  || Public Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
    'TODO  ||     Using ms As New MemoryStream()
    'TODO  ||         ' Convert Image to byte[]
    'TODO  ||         image.Save(ms, format)
    'TODO  ||         Dim imageBytes As Byte() = ms.ToArray() ' Convert byte[] to Base64 String
    'TODO  ||         Dim base64String As String = Convert.ToBase64String(imageBytes)
    'TODO  ||         Return base64String
    'TODO  ||     End Using
    'TODO  || End Function
    'TODO  ||---------------------------------------------
    'TODO  ||---------------------------------------------
    'TODO  ||   Public Function Base64ToImage(ByVal base64String As String) As Image
    'TODO  ||       ' Convert Base64 String to byte[]
    'TODO  ||       Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
    'TODO  ||       Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
    'TODO  ||
    'TODO  ||       ' Convert byte[] to Image
    'TODO  ||       ms.Write(imageBytes, 0, imageBytes.Length)
    'TODO  ||       Dim ConvertedBase64Image As Image = Image.FromStream(ms, True)
    'TODO  ||       Return ConvertedBase64Image
    'TODO  ||   End Function
    'TODO  ||---------------------------------------------
    'TODO  ||---------------------------------------------
    Private Sub BtnImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddImage.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            strCMD = "INSERT INTO Alunos"
            strCMD += "VALUES( " & txtCod_Aluno.Text & ",'" & txtNome.Text & "','" & txtEndereco.Text & "','" & txtLocalidade.Text & "','" _
                      & txtCod_Postal.Text & "','" & txtCurso.Text & "'," & 1 & ",'" & txtEmail.Text & "')"
        Catch ex As Exception
            MsgBox("Erro!!!" + vbCrLf + ex.ToString)
        End Try
    End Sub
    '---------------------------------------------
    '---------------------------------------------
End Class