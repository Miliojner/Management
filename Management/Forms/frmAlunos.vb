Imports System.IO
Imports System.Data.SqlClient
Public Class frmAlunos
    '---------------------------------------------
    '---------------------------------------------
    Dim strConnection As String = My.Settings.Connection
    Dim strCMD As String
    Dim sqlConnection As SqlConnection
    Dim sqlCMD As SqlCommand
    Dim mRow As Integer = 0
    Dim mMaxRow As Integer
    Dim Mode As Integer = 727 ' default
    Const Add As Integer = 0
    Const Delete As Integer = 1
    Const Edit As Integer = 2
    '---------------------------------------------
    '---------------------------------------------
    Public Shared Property Cod_Aluno As String
    Public Shared Property Nome As String
    Public Shared Property Endereco As String
    Public Shared Property Localidade As String
    Public Shared Property Cod_Postal As String
    Public Shared Property Curso As String
    Public Shared Property FLG_Ativo As Boolean
    '---------------------------------------------
    '---------------------------------------------
    Private Sub LoadAlunos()
        btnVisible(True)
        sqlConnection = New SqlConnection(strConnection)
        Try
            strCMD = "SELECT * FROM Alunos "
            strCMD += "WHERE FLG_Ativo = 1"
            sqlConnection.Open()
            sqlCMD = New SqlCommand(strCMD, sqlConnection)
            Dim sqlReader As SqlDataReader = sqlCMD.ExecuteReader
            While sqlReader.Read()
                If mMaxRow = 0 Then
                    txtCod_Aluno.Text = sqlReader.Item(0) '("Cod_Aluno")
                    txtNome.Text = sqlReader.Item(1) '("Nome")
                    txtEndereco.Text = sqlReader.Item(2) '("Endereco")
                    txtLocalidade.Text = sqlReader.Item(3) '("Cod_Postal")
                    txtCod_Postal.Text = sqlReader.Item(4)
                    txtCurso.Text = sqlReader.Item(5) '("Curso")
                    txtEmail.Text = sqlReader.Item(7) '("Email")
                    'Dim Base64ToImage = Image.FromStream(New MemoryStream(Convert.FromBase64String(sqlReader.Item(8))))
                    picPhoto.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(sqlReader.Item(8))))
                End If
                mMaxRow += 1
            End While

            sqlReader.Close()
            sqlConnection.Close()
            sqlCMD.Dispose()
            lblRegistos.Text = mRow + 1 & " de " & mMaxRow
        Catch ex As Exception
            MsgBox("Erro!!!" + vbCrLf + ex.ToString)
        End Try
    End Sub
    '---------------------------------------------
    '---------------------------------------------
    Private Sub frmAlunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAlunos()
        Filltxt()
    End Sub
    '---------------------------------------------
    '---------------------------------------------
    Private Sub Filltxt()
        Dim i As Integer = 0
        strCMD = "SELECT * FROM Alunos "
        strCMD += "WHERE FLG_Ativo = 1"
        sqlCMD = New SqlCommand(strCMD, sqlConnection)
        Try
            sqlConnection.Open()
            Dim sqlReader As SqlDataReader = sqlCMD.ExecuteReader()
            While sqlReader.Read()
                If i = mRow Then
                    txtCod_Aluno.Text = sqlReader.Item(0) '("Cod_Aluno")
                    txtNome.Text = sqlReader.Item(1) '("Nome")
                    txtEndereco.Text = sqlReader.Item(2) '("Endereco")
                    txtLocalidade.Text = sqlReader.Item(3) '("Cod_Postal")
                    txtCod_Postal.Text = sqlReader.Item(4)
                    txtCurso.Text = sqlReader.Item(5) '("Curso")
                    txtEmail.Text = sqlReader.Item(7) '("Email")
                    picPhoto.Load(sqlReader.Item(8)) ' ("Photo")
                End If
                i += 1
            End While
            sqlReader.Close()
            sqlCMD.Dispose()
            sqlConnection.Close()
            lblRegistos.Text = mRow + 1 & " de " & mMaxRow
        Catch ex As Exception
            MsgBox("Erro!!!" + vbCrLf + ex.Message)
        End Try
    End Sub
    '---------------------------------------------
    '---------------------------------------------
    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        If mRow < mMaxRow - 1 Then
            mRow += 1
        End If
        Filltxt()
    End Sub
    '---------------------------------------------
    '---------------------------------------------
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        mRow = mMaxRow - 1
        Filltxt()
    End Sub
    '---------------------------------------------
    '---------------------------------------------
    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        mRow = 0
        Filltxt()
    End Sub
    '---------------------------------------------
    '---------------------------------------------
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If mRow > 0 Then
            mRow -= 1
        End If
        Filltxt()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        btnVisible(True)
        Try
            Select Case Mode
                Case Add
                    'TODO ||para fazer numa form separada||
                Case Delete
                    strCMD = "UPDATE Alunos "
                    strCMD += "SET FLG_Ativo = 0 "
                    strCMD += "WHERE Cod_Aluno = '" & txtCod_Aluno.Text & "'"
                    Try
                        sqlConnection.Open()
                        sqlCMD = New SqlCommand(strCMD, sqlConnection)
                        Dim x = sqlCMD.ExecuteNonQuery()
                        If x Then
                            mMaxRow -= 1
                        End If
                        sqlConnection.Close()
                        sqlCMD.Dispose()
                    Catch ex As Exception
                        sqlConnection.Close()
                        MsgBox("Erro!!!" + vbCrLf + ex.Message)
                    End Try
                    Filltxt()

                Case Edit
                    strCMD = "UPDATE Alunos "
                    strCMD += "SET Nome ='" & txtNome.Text & "', "
                    strCMD += "Endereco ='" & txtEndereco.Text & "', "
                    strCMD += "Localidade ='" & txtLocalidade.Text & "', "
                    strCMD += "Cod_Postal ='" & txtCod_Postal.Text & "', "
                    strCMD += "Curso ='" & txtCurso.Text & "', "
                    strCMD += "Email ='" & txtEmail.Text & "' "
                    strCMD += "WHERE Cod_Aluno = '" & txtCod_Aluno.Text & "'"
                    'TODO ||strCMD += "Photo =" & txtEndereco.Text & "'," || fazer a converção de photo --> Base64 --> string(perhaps)|| e vice versa quando pegar a photo da database
                    Try
                        sqlConnection.Open()
                        sqlCMD = New SqlCommand(strCMD, sqlConnection)
                        sqlCMD.ExecuteNonQuery()
                        sqlConnection.Close()
                        sqlCMD.Dispose()
                    Catch ex As Exception
                        sqlConnection.Close()
                        MsgBox("Erro!!!" + vbCrLf + ex.Message)
                        Filltxt()
                    End Try
            End Select
        Catch ex As Exception
            MsgBox("Erro!!!" + vbCrLf + ex.ToString)
        End Try
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Me.Hide()
        frmAdicionar.Show()
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        btnVisible(False)
        Mode = Delete
    End Sub
    '---------------------------------------------
    '---------------------------------------------
    Private Sub btnVisible(ByVal xBool As Boolean)
        btnAdicionar.Visible = xBool
        btnEditar.Visible = xBool
        btnRemover.Visible = xBool
        btnGuardar.Visible = Not xBool
        btnCancel.Visible = Not xBool
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnVisible(True)
        Filltxt()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnVisible(False)
        Mode = Edit
    End Sub

    '---------------------------------------------
    '---------------------------------------------
End Class
