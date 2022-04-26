<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlunos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.lblCod_Postal = New System.Windows.Forms.Label()
        Me.txtCod_Postal = New System.Windows.Forms.TextBox()
        Me.lblLocalidade = New System.Windows.Forms.Label()
        Me.txtLocalidade = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblCod_Aluno = New System.Windows.Forms.Label()
        Me.txtCod_Aluno = New System.Windows.Forms.TextBox()
        Me.btnPrimeiro = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.lblRegistos = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.PanelTop.SuspendLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.lblEmail)
        Me.PanelTop.Controls.Add(Me.txtEmail)
        Me.PanelTop.Controls.Add(Me.picPhoto)
        Me.PanelTop.Controls.Add(Me.lblCurso)
        Me.PanelTop.Controls.Add(Me.txtCurso)
        Me.PanelTop.Controls.Add(Me.lblCod_Postal)
        Me.PanelTop.Controls.Add(Me.txtCod_Postal)
        Me.PanelTop.Controls.Add(Me.lblLocalidade)
        Me.PanelTop.Controls.Add(Me.txtLocalidade)
        Me.PanelTop.Controls.Add(Me.lblNome)
        Me.PanelTop.Controls.Add(Me.txtNome)
        Me.PanelTop.Controls.Add(Me.lblEndereco)
        Me.PanelTop.Controls.Add(Me.txtEndereco)
        Me.PanelTop.Controls.Add(Me.lblCod_Aluno)
        Me.PanelTop.Controls.Add(Me.txtCod_Aluno)
        Me.PanelTop.Location = New System.Drawing.Point(12, 12)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(776, 213)
        Me.PanelTop.TabIndex = 0
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(51, 171)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(95, 168)
        Me.txtEmail.MaxLength = 80
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(375, 20)
        Me.txtEmail.TabIndex = 13
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPhoto.Location = New System.Drawing.Point(572, 3)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(200, 200)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 12
        Me.picPhoto.TabStop = False
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(51, 145)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(34, 13)
        Me.lblCurso.TabIndex = 11
        Me.lblCurso.Text = "Curso"
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(95, 142)
        Me.txtCurso.MaxLength = 5
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(66, 20)
        Me.txtCurso.TabIndex = 10
        '
        'lblCod_Postal
        '
        Me.lblCod_Postal.AutoSize = True
        Me.lblCod_Postal.Location = New System.Drawing.Point(31, 119)
        Me.lblCod_Postal.Name = "lblCod_Postal"
        Me.lblCod_Postal.Size = New System.Drawing.Size(58, 13)
        Me.lblCod_Postal.TabIndex = 9
        Me.lblCod_Postal.Text = "Cod Postal"
        '
        'txtCod_Postal
        '
        Me.txtCod_Postal.Location = New System.Drawing.Point(95, 116)
        Me.txtCod_Postal.MaxLength = 8
        Me.txtCod_Postal.Name = "txtCod_Postal"
        Me.txtCod_Postal.Size = New System.Drawing.Size(66, 20)
        Me.txtCod_Postal.TabIndex = 8
        '
        'lblLocalidade
        '
        Me.lblLocalidade.AutoSize = True
        Me.lblLocalidade.Location = New System.Drawing.Point(27, 93)
        Me.lblLocalidade.Name = "lblLocalidade"
        Me.lblLocalidade.Size = New System.Drawing.Size(59, 13)
        Me.lblLocalidade.TabIndex = 7
        Me.lblLocalidade.Text = "Localidade"
        '
        'txtLocalidade
        '
        Me.txtLocalidade.Location = New System.Drawing.Point(95, 90)
        Me.txtLocalidade.MaxLength = 30
        Me.txtLocalidade.Name = "txtLocalidade"
        Me.txtLocalidade.Size = New System.Drawing.Size(375, 20)
        Me.txtLocalidade.TabIndex = 6
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(54, 41)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 5
        Me.lblNome.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(95, 38)
        Me.txtNome.MaxLength = 80
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(375, 20)
        Me.txtNome.TabIndex = 4
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(33, 67)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lblEndereco.TabIndex = 3
        Me.lblEndereco.Text = "Endereço"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(95, 64)
        Me.txtEndereco.MaxLength = 80
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(375, 20)
        Me.txtEndereco.TabIndex = 2
        '
        'lblCod_Aluno
        '
        Me.lblCod_Aluno.AutoSize = True
        Me.lblCod_Aluno.Location = New System.Drawing.Point(33, 15)
        Me.lblCod_Aluno.Name = "lblCod_Aluno"
        Me.lblCod_Aluno.Size = New System.Drawing.Size(56, 13)
        Me.lblCod_Aluno.TabIndex = 1
        Me.lblCod_Aluno.Text = "Cod Aluno"
        '
        'txtCod_Aluno
        '
        Me.txtCod_Aluno.Location = New System.Drawing.Point(95, 12)
        Me.txtCod_Aluno.MaxLength = 4
        Me.txtCod_Aluno.Name = "txtCod_Aluno"
        Me.txtCod_Aluno.Size = New System.Drawing.Size(66, 20)
        Me.txtCod_Aluno.TabIndex = 0
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.Location = New System.Drawing.Point(11, 245)
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(48, 25)
        Me.btnPrimeiro.TabIndex = 2
        Me.btnPrimeiro.Text = "<<"
        Me.btnPrimeiro.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(65, 245)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(32, 25)
        Me.btnAnterior.TabIndex = 3
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnProximo
        '
        Me.btnProximo.Location = New System.Drawing.Point(103, 245)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(32, 25)
        Me.btnProximo.TabIndex = 4
        Me.btnProximo.Text = ">"
        Me.btnProximo.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUltimo.Location = New System.Drawing.Point(141, 245)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(48, 25)
        Me.btnUltimo.TabIndex = 5
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'lblRegistos
        '
        Me.lblRegistos.AutoSize = True
        Me.lblRegistos.Location = New System.Drawing.Point(195, 251)
        Me.lblRegistos.Name = "lblRegistos"
        Me.lblRegistos.Size = New System.Drawing.Size(57, 13)
        Me.lblRegistos.TabIndex = 12
        Me.lblRegistos.Text = "Registos : "
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(709, 246)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(709, 275)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(628, 246)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 15
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.Location = New System.Drawing.Point(628, 275)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(75, 23)
        Me.btnRemover.TabIndex = 16
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(547, 261)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 17
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'frmAlunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblRegistos)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnProximo)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimeiro)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "frmAlunos"
        Me.Text = "Form1"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents btnPrimeiro As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnProximo As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents lblCod_Aluno As Label
    Friend WithEvents txtCod_Aluno As TextBox
    Friend WithEvents lblCurso As Label
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents lblCod_Postal As Label
    Friend WithEvents txtCod_Postal As TextBox
    Friend WithEvents lblLocalidade As Label
    Friend WithEvents txtLocalidade As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblEndereco As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents lblRegistos As Label
    Friend WithEvents picPhoto As PictureBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnRemover As Button
    Friend WithEvents btnEditar As Button
End Class
