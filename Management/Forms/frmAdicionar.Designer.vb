<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdicionar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.picPhotoPreview = New System.Windows.Forms.PictureBox()
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
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.PanelTop.SuspendLayout()
        CType(Me.picPhotoPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.btnAddImage)
        Me.PanelTop.Controls.Add(Me.lblEmail)
        Me.PanelTop.Controls.Add(Me.txtEmail)
        Me.PanelTop.Controls.Add(Me.picPhotoPreview)
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
        Me.PanelTop.Size = New System.Drawing.Size(913, 291)
        Me.PanelTop.TabIndex = 1
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(701, 218)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(200, 23)
        Me.btnAddImage.TabIndex = 19
        Me.btnAddImage.Text = "Adicionar Imagem"
        Me.btnAddImage.UseVisualStyleBackColor = True
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
        'picPhotoPreview
        '
        Me.picPhotoPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPhotoPreview.Location = New System.Drawing.Point(701, 12)
        Me.picPhotoPreview.Name = "picPhotoPreview"
        Me.picPhotoPreview.Size = New System.Drawing.Size(200, 200)
        Me.picPhotoPreview.TabIndex = 12
        Me.picPhotoPreview.TabStop = False
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
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(370, 310)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 18
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(451, 309)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(532, 309)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmAdicionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 570)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "frmAdicionar"
        Me.Text = "frmAdicionar"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.picPhotoPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents picPhotoPreview As PictureBox
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
    Friend WithEvents lblCod_Aluno As Label
    Friend WithEvents txtCod_Aluno As TextBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAddImage As Button
End Class
