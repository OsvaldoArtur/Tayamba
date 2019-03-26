<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Me.components = New System.ComponentModel.Container()
        Dim Nome_CompletoLabel As System.Windows.Forms.Label
        Dim Nome_UsuarioLabel As System.Windows.Forms.Label
        Dim PaswordLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nome_CompletoTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.PaswordTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Nome_CompletoLabel = New System.Windows.Forms.Label()
        Nome_UsuarioLabel = New System.Windows.Forms.Label()
        PaswordLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nome_CompletoLabel
        '
        Nome_CompletoLabel.AutoSize = True
        Nome_CompletoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_CompletoLabel.Location = New System.Drawing.Point(58, 74)
        Nome_CompletoLabel.Name = "Nome_CompletoLabel"
        Nome_CompletoLabel.Size = New System.Drawing.Size(113, 19)
        Nome_CompletoLabel.TabIndex = 4
        Nome_CompletoLabel.Text = "Nome Completo:"
        '
        'Nome_UsuarioLabel
        '
        Nome_UsuarioLabel.AutoSize = True
        Nome_UsuarioLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_UsuarioLabel.Location = New System.Drawing.Point(71, 108)
        Nome_UsuarioLabel.Name = "Nome_UsuarioLabel"
        Nome_UsuarioLabel.Size = New System.Drawing.Size(100, 19)
        Nome_UsuarioLabel.TabIndex = 6
        Nome_UsuarioLabel.Text = "Nome Usuario:"
        '
        'PaswordLabel
        '
        PaswordLabel.AutoSize = True
        PaswordLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaswordLabel.Location = New System.Drawing.Point(122, 142)
        PaswordLabel.Name = "PaswordLabel"
        PaswordLabel.Size = New System.Drawing.Size(49, 19)
        PaswordLabel.TabIndex = 8
        PaswordLabel.Text = "Senha:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(70, 175)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(101, 19)
        Label1.TabIndex = 8
        Label1.Text = "Repita a senha:"
        '
        'Nome_CompletoTextBox
        '
        Me.Nome_CompletoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_CompletoTextBox.Location = New System.Drawing.Point(177, 71)
        Me.Nome_CompletoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_CompletoTextBox.Name = "Nome_CompletoTextBox"
        Me.Nome_CompletoTextBox.Size = New System.Drawing.Size(220, 25)
        Me.Nome_CompletoTextBox.TabIndex = 1
        '
        'Nome_UsuarioTextBox
        '
        Me.Nome_UsuarioTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_UsuarioTextBox.Location = New System.Drawing.Point(177, 105)
        Me.Nome_UsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_UsuarioTextBox.Name = "Nome_UsuarioTextBox"
        Me.Nome_UsuarioTextBox.Size = New System.Drawing.Size(220, 25)
        Me.Nome_UsuarioTextBox.TabIndex = 2
        '
        'PaswordTextBox
        '
        Me.PaswordTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaswordTextBox.Location = New System.Drawing.Point(177, 139)
        Me.PaswordTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaswordTextBox.Name = "PaswordTextBox"
        Me.PaswordTextBox.Size = New System.Drawing.Size(220, 25)
        Me.PaswordTextBox.TabIndex = 3
        Me.PaswordTextBox.UseSystemPasswordChar = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(330, 228)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 33)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(177, 172)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 25)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "No minimo uso de 8 caracteres!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(403, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 19)
        Me.Label4.TabIndex = 15
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 290)
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
        Me.Name = "frmUsuario"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Usuario"
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome_CompletoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nome_UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
