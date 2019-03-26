<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadeira
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
        Dim AnoLabel As System.Windows.Forms.Label
        Dim IdCursoLabel As System.Windows.Forms.Label
        Dim Nome_CadeiraLabel As System.Windows.Forms.Label
        Dim SemestreLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.Nome_CadeiraTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IdCursoTextBox = New System.Windows.Forms.ComboBox()
        Me.CusostbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnoTextBox = New System.Windows.Forms.NumericUpDown()
        Me.SemestreTextBox = New System.Windows.Forms.NumericUpDown()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CBTipo = New System.Windows.Forms.CheckBox()
        Me.Cadeira_tbDataGridView = New System.Windows.Forms.DataGridView()
        Me.Cadeira_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.credito_textBox = New System.Windows.Forms.NumericUpDown()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        AnoLabel = New System.Windows.Forms.Label()
        IdCursoLabel = New System.Windows.Forms.Label()
        Nome_CadeiraLabel = New System.Windows.Forms.Label()
        SemestreLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.CusostbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnoTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemestreTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cadeira_tbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cadeira_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.credito_textBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AnoLabel.Location = New System.Drawing.Point(40, 134)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(34, 17)
        AnoLabel.TabIndex = 1
        AnoLabel.Text = "Ano:"
        '
        'IdCursoLabel
        '
        IdCursoLabel.AutoSize = True
        IdCursoLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdCursoLabel.Location = New System.Drawing.Point(26, 78)
        IdCursoLabel.Name = "IdCursoLabel"
        IdCursoLabel.Size = New System.Drawing.Size(45, 17)
        IdCursoLabel.TabIndex = 7
        IdCursoLabel.Text = "Curso:"
        '
        'Nome_CadeiraLabel
        '
        Nome_CadeiraLabel.AutoSize = True
        Nome_CadeiraLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_CadeiraLabel.Location = New System.Drawing.Point(401, 78)
        Nome_CadeiraLabel.Name = "Nome_CadeiraLabel"
        Nome_CadeiraLabel.Size = New System.Drawing.Size(96, 17)
        Nome_CadeiraLabel.TabIndex = 9
        Nome_CadeiraLabel.Text = "Nome Cadeira:"
        '
        'SemestreLabel
        '
        SemestreLabel.AutoSize = True
        SemestreLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SemestreLabel.Location = New System.Drawing.Point(125, 134)
        SemestreLabel.Name = "SemestreLabel"
        SemestreLabel.Size = New System.Drawing.Size(65, 17)
        SemestreLabel.TabIndex = 11
        SemestreLabel.Text = "Semestre:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(745, 79)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(102, 17)
        Label1.TabIndex = 11
        Label1.Text = "Tipo de Cadeira"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(220, 134)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(54, 17)
        Label2.TabIndex = 23
        Label2.Text = "Credito:"
        '
        'Nome_CadeiraTextBox
        '
        Me.Nome_CadeiraTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_CadeiraTextBox.Location = New System.Drawing.Point(404, 99)
        Me.Nome_CadeiraTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_CadeiraTextBox.Name = "Nome_CadeiraTextBox"
        Me.Nome_CadeiraTextBox.Size = New System.Drawing.Size(337, 25)
        Me.Nome_CadeiraTextBox.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(780, 146)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 33)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'IdCursoTextBox
        '
        Me.IdCursoTextBox.DataSource = Me.CusostbBindingSource
        Me.IdCursoTextBox.DisplayMember = "Nome_Curso"
        Me.IdCursoTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdCursoTextBox.FormattingEnabled = True
        Me.IdCursoTextBox.Location = New System.Drawing.Point(29, 99)
        Me.IdCursoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IdCursoTextBox.Name = "IdCursoTextBox"
        Me.IdCursoTextBox.Size = New System.Drawing.Size(333, 25)
        Me.IdCursoTextBox.TabIndex = 1
        Me.IdCursoTextBox.ValueMember = "idCurso"
        '
        'CusostbBindingSource
        '
        Me.CusostbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Cusos_tb)
        '
        'AnoTextBox
        '
        Me.AnoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnoTextBox.Location = New System.Drawing.Point(29, 154)
        Me.AnoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AnoTextBox.Name = "AnoTextBox"
        Me.AnoTextBox.Size = New System.Drawing.Size(57, 25)
        Me.AnoTextBox.TabIndex = 2
        Me.AnoTextBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SemestreTextBox
        '
        Me.SemestreTextBox.Location = New System.Drawing.Point(128, 154)
        Me.SemestreTextBox.Name = "SemestreTextBox"
        Me.SemestreTextBox.Size = New System.Drawing.Size(57, 25)
        Me.SemestreTextBox.TabIndex = 3
        Me.SemestreTextBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.P5lus_25px
        Me.Button3.Location = New System.Drawing.Point(368, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 25)
        Me.Button3.TabIndex = 20
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CBTipo
        '
        Me.CBTipo.AutoSize = True
        Me.CBTipo.Location = New System.Drawing.Point(747, 99)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(100, 23)
        Me.CBTipo.TabIndex = 4
        Me.CBTipo.Text = "Em Comum"
        Me.CBTipo.UseVisualStyleBackColor = True
        '
        'Cadeira_tbDataGridView
        '
        Me.Cadeira_tbDataGridView.AllowUserToAddRows = False
        Me.Cadeira_tbDataGridView.AllowUserToDeleteRows = False
        Me.Cadeira_tbDataGridView.AutoGenerateColumns = False
        Me.Cadeira_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cadeira_tbDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cadeira_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cadeira_tbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Cadeira_tbDataGridView.DataSource = Me.Cadeira_tbBindingSource
        Me.Cadeira_tbDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Cadeira_tbDataGridView.Location = New System.Drawing.Point(23, 185)
        Me.Cadeira_tbDataGridView.Name = "Cadeira_tbDataGridView"
        Me.Cadeira_tbDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Cadeira_tbDataGridView.Size = New System.Drawing.Size(834, 286)
        Me.Cadeira_tbDataGridView.TabIndex = 22
        '
        'Cadeira_tbBindingSource
        '
        Me.Cadeira_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Cadeira_tb)
        '
        'credito_textBox
        '
        Me.credito_textBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credito_textBox.Location = New System.Drawing.Point(223, 154)
        Me.credito_textBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.credito_textBox.Name = "credito_textBox"
        Me.credito_textBox.Size = New System.Drawing.Size(57, 25)
        Me.credito_textBox.TabIndex = 6
        Me.credito_textBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idCadeira"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idCadeira"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome_Cadeira"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Credito_Cadeira"
        Me.DataGridViewTextBoxColumn3.FillWeight = 25.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Credito"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ano"
        Me.DataGridViewTextBoxColumn4.FillWeight = 25.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ano"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Semestre"
        Me.DataGridViewTextBoxColumn5.FillWeight = 25.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Semestre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idCurso"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idCurso"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TipoCadeira"
        Me.DataGridViewTextBoxColumn7.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "TipoCadeira"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'frmCadeira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 497)
        Me.Controls.Add(Me.credito_textBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Cadeira_tbDataGridView)
        Me.Controls.Add(Me.CBTipo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SemestreTextBox)
        Me.Controls.Add(Me.AnoTextBox)
        Me.Controls.Add(Me.IdCursoTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(AnoLabel)
        Me.Controls.Add(IdCursoLabel)
        Me.Controls.Add(Nome_CadeiraLabel)
        Me.Controls.Add(Me.Nome_CadeiraTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(SemestreLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmCadeira"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Cadeira"
        CType(Me.CusostbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnoTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemestreTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cadeira_tbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cadeira_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.credito_textBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nome_CadeiraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents IdCursoTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents AnoTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents SemestreTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CBTipo As System.Windows.Forms.CheckBox
    Friend WithEvents Cadeira_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cadeira_tbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CusostbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents credito_textBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
