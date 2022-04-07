Imports System.Data.SqlClient
Public Class frmAlunos
    '---------------------------------------------
    Dim sqlConnection As SqlConnection
    Dim sqlCMD As SqlCommand
    Dim strConnection As String
    Dim strCMD As String
    Dim mRow As Integer = 0
    Dim Mode As Integer
    Const Add As Integer = 0
    Const Drop As Integer = 1
    Const Update As Integer = 2
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

    End Sub
    '---------------------------------------------
    '---------------------------------------------
    Private Sub frmAlunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAlunos()

    End Sub
    '---------------------------------------------
    '---------------------------------------------
End Class
