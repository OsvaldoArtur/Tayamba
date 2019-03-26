<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAdministrator
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
        Dim Nome_CompletoLabel As System.Windows.Forms.Label
        Dim Nome_UsuarioLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim PaswordLabel As System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Nome_CompletoTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PaswordTextBox = New System.Windows.Forms.TextBox()
        Nome_CompletoLabel = New System.Windows.Forms.Label()
        Nome_UsuarioLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        PaswordLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 19)
        Me.Label4.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "No minimo uso de 8 caracteres!"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(431, 239)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 33)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Nome_CompletoLabel
        '
        Nome_CompletoLabel.AutoSize = True
        Nome_CompletoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_CompletoLabel.Location = New System.Drawing.Point(46, 89)
        Nome_CompletoLabel.Name = "Nome_CompletoLabel"
        Nome_CompletoLabel.Size = New System.Drawing.Size(113, 19)
        Nome_CompletoLabel.TabIndex = 43
        Nome_CompletoLabel.Text = "Nome Completo:"
        '
        'Nome_CompletoTextBox
        '
        Me.Nome_CompletoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_CompletoTextBox.Location = New System.Drawing.Point(165, 86)
        Me.Nome_CompletoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_CompletoTextBox.Name = "Nome_CompletoTextBox"
        Me.Nome_CompletoTextBox.Size = New System.Drawing.Size(333, 25)
        Me.Nome_CompletoTextBox.TabIndex = 40
        '
        'Nome_UsuarioLabel
        '
        Nome_UsuarioLabel.AutoSize = True
        Nome_UsuarioLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_UsuarioLabel.Location = New System.Drawing.Point(59, 123)
        Nome_UsuarioLabel.Name = "Nome_UsuarioLabel"
        Nome_UsuarioLabel.Size = New System.Drawing.Size(100, 19)
        Nome_UsuarioLabel.TabIndex = 46
        Nome_UsuarioLabel.Text = "Nome Usuario:"
        '
        'Nome_UsuarioTextBox
        '
        Me.Nome_UsuarioTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_UsuarioTextBox.Location = New System.Drawing.Point(165, 120)
        Me.Nome_UsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_UsuarioTextBox.Name = "Nome_UsuarioTextBox"
        Me.Nome_UsuarioTextBox.Size = New System.Drawing.Size(333, 25)
        Me.Nome_UsuarioTextBox.TabIndex = 41
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(58, 190)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(101, 19)
        Label1.TabIndex = 47
        Label1.Text = "Repita a senha:"
        '
        'PaswordLabel
        '
        PaswordLabel.AutoSize = True
        PaswordLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaswordLabel.Location = New System.Drawing.Point(110, 157)
        PaswordLabel.Name = "PaswordLabel"
        PaswordLabel.Size = New System.Drawing.Size(49, 19)
        PaswordLabel.TabIndex = 48
        PaswordLabel.Text = "Senha:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(165, 187)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(333, 25)
        Me.TextBox1.TabIndex = 44
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'PaswordTextBox
        '
        Me.PaswordTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaswordTextBox.Location = New System.Drawing.Point(165, 154)
        Me.PaswordTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaswordTextBox.Name = "PaswordTextBox"
        Me.PaswordTextBox.Size = New System.Drawing.Size(333, 25)
        Me.PaswordTextBox.TabIndex = 42
        Me.PaswordTextBox.UseSystemPasswordChar = True
        '
        'frmAddAdministrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 302)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Nome_CompletoLabel)
        Me.Controls.Add(Me.Nome_CompletoTextBox)
        Me.Controls.Add(Nome_UsuarioLabel)
        Me.Controls.Add(Me.Nome_UsuarioTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(PaswordLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PaswordTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmAddAdministrator"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Novo Administrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Nome_CompletoTextBox As TextBox
    Friend WithEvents Nome_UsuarioTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PaswordTextBox As TextBox
End Class
