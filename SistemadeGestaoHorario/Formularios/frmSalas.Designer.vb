<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalas
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
        Dim Nome_SalaLabel As System.Windows.Forms.Label
        Me.Nome_SalaTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdSalaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeSalaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salas_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Nome_SalaLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salas_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nome_SalaLabel
        '
        Nome_SalaLabel.AutoSize = True
        Nome_SalaLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_SalaLabel.Location = New System.Drawing.Point(19, 86)
        Nome_SalaLabel.Name = "Nome_SalaLabel"
        Nome_SalaLabel.Size = New System.Drawing.Size(77, 19)
        Nome_SalaLabel.TabIndex = 4
        Nome_SalaLabel.Text = "Nome Sala:"
        '
        'Nome_SalaTextBox
        '
        Me.Nome_SalaTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_SalaTextBox.Location = New System.Drawing.Point(102, 82)
        Me.Nome_SalaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_SalaTextBox.Name = "Nome_SalaTextBox"
        Me.Nome_SalaTextBox.Size = New System.Drawing.Size(351, 25)
        Me.Nome_SalaTextBox.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(459, 81)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 27)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(38, 384)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(246, 19)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Desenvolvedor: Osvaldo Artur Dionisio"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSalaDataGridViewTextBoxColumn, Me.NomeSalaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Salas_tbBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(23, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(504, 246)
        Me.DataGridView1.TabIndex = 17
        '
        'IdSalaDataGridViewTextBoxColumn
        '
        Me.IdSalaDataGridViewTextBoxColumn.DataPropertyName = "idSala"
        Me.IdSalaDataGridViewTextBoxColumn.HeaderText = "idSala"
        Me.IdSalaDataGridViewTextBoxColumn.Name = "IdSalaDataGridViewTextBoxColumn"
        Me.IdSalaDataGridViewTextBoxColumn.Visible = False
        '
        'NomeSalaDataGridViewTextBoxColumn
        '
        Me.NomeSalaDataGridViewTextBoxColumn.DataPropertyName = "Nome_Sala"
        Me.NomeSalaDataGridViewTextBoxColumn.HeaderText = "Nome_Sala"
        Me.NomeSalaDataGridViewTextBoxColumn.Name = "NomeSalaDataGridViewTextBoxColumn"
        '
        'Salas_tbBindingSource
        '
        Me.Salas_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Salas_tb)
        '
        'frmSalas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 410)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Nome_SalaLabel)
        Me.Controls.Add(Me.Nome_SalaTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmSalas"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Salas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salas_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Salas_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nome_SalaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdSalaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeSalaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
