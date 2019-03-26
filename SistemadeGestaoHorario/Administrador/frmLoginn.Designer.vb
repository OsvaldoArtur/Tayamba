<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginn
    Inherits MetroFramework.Forms.MetroForm

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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(400, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 11)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Supported by IT 3º ANO 2017"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(62, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(410, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Não compartilhe a sua senha, e mantenha o sistema seguro!"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(128, 193)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(305, 25)
        Me.txtSenha.TabIndex = 20
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(128, 137)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(305, 25)
        Me.txtUsuario.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 169)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 113)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nome de Usuario"
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.icons8_Password_1_25px
        Me.btnEntrar.Location = New System.Drawing.Point(146, 237)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(112, 37)
        Me.btnEntrar.TabIndex = 21
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.icons8_Password_Check_25px
        Me.PictureBox4.Location = New System.Drawing.Point(99, 193)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 27
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.icons8_Checked_User_Male_25px_1
        Me.PictureBox3.Location = New System.Drawing.Point(99, 137)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.icons8_No_Entry_25px
        Me.btnCancelar.Location = New System.Drawing.Point(289, 237)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 37)
        Me.btnCancelar.TabIndex = 22
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Workflow_128px1
        Me.PictureBox1.Location = New System.Drawing.Point(297, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'frmLoginn
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 360)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmLoginn"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Entrada do Administrador"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
