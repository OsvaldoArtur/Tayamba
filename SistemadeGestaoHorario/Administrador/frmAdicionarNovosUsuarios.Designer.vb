<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionarNovosUsuarios
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
        Dim Label1 As System.Windows.Forms.Label
        Dim PaswordLabel As System.Windows.Forms.Label
        Me.metroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.resertarSenhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.metroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.Usuario_tbDataGridView = New System.Windows.Forms.DataGridView()
        Me.PaswordTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_CompletoTextBox = New System.Windows.Forms.TextBox()
        Me.metroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Nome_UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.metroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.Usuario_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Nome_CompletoLabel = New System.Windows.Forms.Label()
        Nome_UsuarioLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        PaswordLabel = New System.Windows.Forms.Label()
        Me.metroContextMenu1.SuspendLayout()
        Me.metroTabPage2.SuspendLayout()
        CType(Me.Usuario_tbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.metroTabPage1.SuspendLayout()
        Me.metroTabControl1.SuspendLayout()
        CType(Me.Usuario_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nome_CompletoLabel
        '
        Nome_CompletoLabel.AutoSize = True
        Nome_CompletoLabel.BackColor = System.Drawing.Color.Transparent
        Nome_CompletoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_CompletoLabel.Location = New System.Drawing.Point(39, 52)
        Nome_CompletoLabel.Name = "Nome_CompletoLabel"
        Nome_CompletoLabel.Size = New System.Drawing.Size(113, 19)
        Nome_CompletoLabel.TabIndex = 43
        Nome_CompletoLabel.Text = "Nome Completo:"
        '
        'Nome_UsuarioLabel
        '
        Nome_UsuarioLabel.AutoSize = True
        Nome_UsuarioLabel.BackColor = System.Drawing.Color.Transparent
        Nome_UsuarioLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_UsuarioLabel.Location = New System.Drawing.Point(52, 86)
        Nome_UsuarioLabel.Name = "Nome_UsuarioLabel"
        Nome_UsuarioLabel.Size = New System.Drawing.Size(100, 19)
        Nome_UsuarioLabel.TabIndex = 46
        Nome_UsuarioLabel.Text = "Nome Usuario:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(51, 153)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(101, 19)
        Label1.TabIndex = 47
        Label1.Text = "Repita a senha:"
        '
        'PaswordLabel
        '
        PaswordLabel.AutoSize = True
        PaswordLabel.BackColor = System.Drawing.Color.Transparent
        PaswordLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaswordLabel.Location = New System.Drawing.Point(103, 120)
        PaswordLabel.Name = "PaswordLabel"
        PaswordLabel.Size = New System.Drawing.Size(49, 19)
        PaswordLabel.TabIndex = 48
        PaswordLabel.Text = "Senha:"
        '
        'metroContextMenu1
        '
        Me.metroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.resertarSenhaToolStripMenuItem})
        Me.metroContextMenu1.Name = "metroContextMenu1"
        Me.metroContextMenu1.Size = New System.Drawing.Size(168, 28)
        '
        'resertarSenhaToolStripMenuItem
        '
        Me.resertarSenhaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.resertarSenhaToolStripMenuItem.Name = "resertarSenhaToolStripMenuItem"
        Me.resertarSenhaToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.resertarSenhaToolStripMenuItem.Text = "Resertar Senha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(501, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 19)
        Me.Label4.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(501, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(288, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "No minimo uso de 8 caracteres!"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(424, 202)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 33)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'metroTabPage2
        '
        Me.metroTabPage2.AutoScroll = True
        Me.metroTabPage2.Controls.Add(Me.Usuario_tbDataGridView)
        Me.metroTabPage2.HorizontalScrollbar = True
        Me.metroTabPage2.HorizontalScrollbarBarColor = True
        Me.metroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.metroTabPage2.HorizontalScrollbarSize = 2
        Me.metroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.metroTabPage2.Name = "metroTabPage2"
        Me.metroTabPage2.Size = New System.Drawing.Size(619, 256)
        Me.metroTabPage2.TabIndex = 1
        Me.metroTabPage2.Text = "Lista de Usuarios"
        Me.metroTabPage2.VerticalScrollbar = True
        Me.metroTabPage2.VerticalScrollbarBarColor = True
        Me.metroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.metroTabPage2.VerticalScrollbarSize = 3
        '
        'Usuario_tbDataGridView
        '
        Me.Usuario_tbDataGridView.AllowUserToAddRows = False
        Me.Usuario_tbDataGridView.AllowUserToDeleteRows = False
        Me.Usuario_tbDataGridView.AutoGenerateColumns = False
        Me.Usuario_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Usuario_tbDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Usuario_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Usuario_tbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Usuario_tbDataGridView.ContextMenuStrip = Me.metroContextMenu1
        Me.Usuario_tbDataGridView.DataSource = Me.Usuario_tbBindingSource
        Me.Usuario_tbDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Usuario_tbDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Usuario_tbDataGridView.Name = "Usuario_tbDataGridView"
        Me.Usuario_tbDataGridView.ReadOnly = True
        Me.Usuario_tbDataGridView.Size = New System.Drawing.Size(619, 256)
        Me.Usuario_tbDataGridView.TabIndex = 2
        '
        'PaswordTextBox
        '
        Me.PaswordTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaswordTextBox.Location = New System.Drawing.Point(158, 117)
        Me.PaswordTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaswordTextBox.Name = "PaswordTextBox"
        Me.PaswordTextBox.Size = New System.Drawing.Size(333, 25)
        Me.PaswordTextBox.TabIndex = 42
        Me.PaswordTextBox.UseSystemPasswordChar = True
        '
        'Nome_CompletoTextBox
        '
        Me.Nome_CompletoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_CompletoTextBox.Location = New System.Drawing.Point(158, 49)
        Me.Nome_CompletoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_CompletoTextBox.Name = "Nome_CompletoTextBox"
        Me.Nome_CompletoTextBox.Size = New System.Drawing.Size(333, 25)
        Me.Nome_CompletoTextBox.TabIndex = 40
        '
        'metroTabPage1
        '
        Me.metroTabPage1.Controls.Add(Me.Label4)
        Me.metroTabPage1.Controls.Add(Me.Label3)
        Me.metroTabPage1.Controls.Add(Me.Label2)
        Me.metroTabPage1.Controls.Add(Me.Button2)
        Me.metroTabPage1.Controls.Add(Nome_CompletoLabel)
        Me.metroTabPage1.Controls.Add(Me.Nome_CompletoTextBox)
        Me.metroTabPage1.Controls.Add(Nome_UsuarioLabel)
        Me.metroTabPage1.Controls.Add(Me.Nome_UsuarioTextBox)
        Me.metroTabPage1.Controls.Add(Label1)
        Me.metroTabPage1.Controls.Add(PaswordLabel)
        Me.metroTabPage1.Controls.Add(Me.TextBox1)
        Me.metroTabPage1.Controls.Add(Me.PaswordTextBox)
        Me.metroTabPage1.HorizontalScrollbarBarColor = True
        Me.metroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.metroTabPage1.HorizontalScrollbarSize = 2
        Me.metroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.metroTabPage1.Name = "metroTabPage1"
        Me.metroTabPage1.Size = New System.Drawing.Size(619, 256)
        Me.metroTabPage1.TabIndex = 0
        Me.metroTabPage1.Text = "Adicionar Novo Usuario"
        Me.metroTabPage1.VerticalScrollbarBarColor = True
        Me.metroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.metroTabPage1.VerticalScrollbarSize = 3
        '
        'Nome_UsuarioTextBox
        '
        Me.Nome_UsuarioTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_UsuarioTextBox.Location = New System.Drawing.Point(158, 83)
        Me.Nome_UsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_UsuarioTextBox.Name = "Nome_UsuarioTextBox"
        Me.Nome_UsuarioTextBox.Size = New System.Drawing.Size(333, 25)
        Me.Nome_UsuarioTextBox.TabIndex = 41
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(158, 150)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(333, 25)
        Me.TextBox1.TabIndex = 44
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'metroTabControl1
        '
        Me.metroTabControl1.Controls.Add(Me.metroTabPage1)
        Me.metroTabControl1.Controls.Add(Me.metroTabPage2)
        Me.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.metroTabControl1.Location = New System.Drawing.Point(23, 78)
        Me.metroTabControl1.Name = "metroTabControl1"
        Me.metroTabControl1.SelectedIndex = 0
        Me.metroTabControl1.Size = New System.Drawing.Size(627, 298)
        Me.metroTabControl1.TabIndex = 1
        Me.metroTabControl1.UseSelectable = True
        '
        'Usuario_tbBindingSource
        '
        Me.Usuario_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Usuario_tb)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idUsuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nº"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomeCompleto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NomeCompleto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NomeUsuario"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NomeUsuario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SenhaUsuario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SenhaUsuario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'frmAdicionarNovosUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 402)
        Me.Controls.Add(Me.metroTabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmAdicionarNovosUsuarios"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Gestao de Usuarios"
        Me.metroContextMenu1.ResumeLayout(False)
        Me.metroTabPage2.ResumeLayout(False)
        CType(Me.Usuario_tbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.metroTabPage1.ResumeLayout(False)
        Me.metroTabPage1.PerformLayout()
        Me.metroTabControl1.ResumeLayout(False)
        CType(Me.Usuario_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents metroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Private WithEvents resertarSenhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Private WithEvents metroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PaswordTextBox As TextBox
    Friend WithEvents Nome_CompletoTextBox As TextBox
    Private WithEvents metroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Nome_UsuarioTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents metroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents Usuario_tbDataGridView As DataGridView
    Friend WithEvents Usuario_tbBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
