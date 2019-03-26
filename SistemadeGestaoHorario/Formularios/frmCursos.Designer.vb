<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCursos
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
        Dim Duracao_CursoLabel As System.Windows.Forms.Label
        Dim Nome_CursoLabel As System.Windows.Forms.Label
        Me.Nome_CursoTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Duracao_CursoTextBox = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuracaoCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cusos_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Duracao_CursoLabel = New System.Windows.Forms.Label()
        Nome_CursoLabel = New System.Windows.Forms.Label()
        CType(Me.Duracao_CursoTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cusos_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Duracao_CursoLabel
        '
        Duracao_CursoLabel.AutoSize = True
        Duracao_CursoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Duracao_CursoLabel.Location = New System.Drawing.Point(523, 80)
        Duracao_CursoLabel.Name = "Duracao_CursoLabel"
        Duracao_CursoLabel.Size = New System.Drawing.Size(103, 19)
        Duracao_CursoLabel.TabIndex = 2
        Duracao_CursoLabel.Text = "Duracao Curso:"
        '
        'Nome_CursoLabel
        '
        Nome_CursoLabel.AutoSize = True
        Nome_CursoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_CursoLabel.Location = New System.Drawing.Point(26, 78)
        Nome_CursoLabel.Name = "Nome_CursoLabel"
        Nome_CursoLabel.Size = New System.Drawing.Size(89, 19)
        Nome_CursoLabel.TabIndex = 6
        Nome_CursoLabel.Text = "Nome Curso:"
        '
        'Nome_CursoTextBox
        '
        Me.Nome_CursoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_CursoTextBox.Location = New System.Drawing.Point(30, 101)
        Me.Nome_CursoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_CursoTextBox.Name = "Nome_CursoTextBox"
        Me.Nome_CursoTextBox.Size = New System.Drawing.Size(491, 25)
        Me.Nome_CursoTextBox.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(632, 98)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Duracao_CursoTextBox
        '
        Me.Duracao_CursoTextBox.Location = New System.Drawing.Point(527, 102)
        Me.Duracao_CursoTextBox.Name = "Duracao_CursoTextBox"
        Me.Duracao_CursoTextBox.Size = New System.Drawing.Size(99, 25)
        Me.Duracao_CursoTextBox.TabIndex = 2
        Me.Duracao_CursoTextBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(26, 444)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(246, 19)
        Me.Label15.TabIndex = 17
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCursoDataGridViewTextBoxColumn, Me.NomeCursoDataGridViewTextBoxColumn, Me.DuracaoCursoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Cusos_tbBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(23, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(697, 311)
        Me.DataGridView1.TabIndex = 18
        '
        'IdCursoDataGridViewTextBoxColumn
        '
        Me.IdCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso"
        Me.IdCursoDataGridViewTextBoxColumn.HeaderText = "idCurso"
        Me.IdCursoDataGridViewTextBoxColumn.Name = "IdCursoDataGridViewTextBoxColumn"
        Me.IdCursoDataGridViewTextBoxColumn.Visible = False
        '
        'NomeCursoDataGridViewTextBoxColumn
        '
        Me.NomeCursoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Curso"
        Me.NomeCursoDataGridViewTextBoxColumn.HeaderText = "Curso"
        Me.NomeCursoDataGridViewTextBoxColumn.Name = "NomeCursoDataGridViewTextBoxColumn"
        '
        'DuracaoCursoDataGridViewTextBoxColumn
        '
        Me.DuracaoCursoDataGridViewTextBoxColumn.DataPropertyName = "Duracao_Curso"
        Me.DuracaoCursoDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.DuracaoCursoDataGridViewTextBoxColumn.HeaderText = "Duracao"
        Me.DuracaoCursoDataGridViewTextBoxColumn.Name = "DuracaoCursoDataGridViewTextBoxColumn"
        '
        'Cusos_tbBindingSource
        '
        Me.Cusos_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Cusos_tb)
        '
        'frmCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 470)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Duracao_CursoTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Duracao_CursoLabel)
        Me.Controls.Add(Nome_CursoLabel)
        Me.Controls.Add(Me.Nome_CursoTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmCursos"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Cursos"
        CType(Me.Duracao_CursoTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cusos_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cusos_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nome_CursoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Duracao_CursoTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdCursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DuracaoCursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
