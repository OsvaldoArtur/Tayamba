<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadeiraAdd
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
        Dim Nome_CadeiraLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.Nome_CadeiraTextBox = New System.Windows.Forms.TextBox()
        Me.credito_textBox = New System.Windows.Forms.NumericUpDown()
        Me.CBTipo = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCadeiraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCadeiraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditoCadeiraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemestreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCadeiraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CadeiratbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Nome_CadeiraLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.credito_textBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadeiratbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nome_CadeiraLabel
        '
        Nome_CadeiraLabel.AutoSize = True
        Nome_CadeiraLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_CadeiraLabel.Location = New System.Drawing.Point(20, 178)
        Nome_CadeiraLabel.Name = "Nome_CadeiraLabel"
        Nome_CadeiraLabel.Size = New System.Drawing.Size(96, 17)
        Nome_CadeiraLabel.TabIndex = 11
        Nome_CadeiraLabel.Text = "Nome Cadeira:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(286, 179)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(54, 17)
        Label2.TabIndex = 25
        Label2.Text = "Credito:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(361, 178)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(102, 17)
        Label1.TabIndex = 27
        Label1.Text = "Tipo de Cadeira"
        '
        'Nome_CadeiraTextBox
        '
        Me.Nome_CadeiraTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_CadeiraTextBox.Location = New System.Drawing.Point(23, 199)
        Me.Nome_CadeiraTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_CadeiraTextBox.Name = "Nome_CadeiraTextBox"
        Me.Nome_CadeiraTextBox.Size = New System.Drawing.Size(260, 25)
        Me.Nome_CadeiraTextBox.TabIndex = 1
        '
        'credito_textBox
        '
        Me.credito_textBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credito_textBox.Location = New System.Drawing.Point(289, 199)
        Me.credito_textBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.credito_textBox.Name = "credito_textBox"
        Me.credito_textBox.Size = New System.Drawing.Size(57, 25)
        Me.credito_textBox.TabIndex = 2
        Me.credito_textBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CBTipo
        '
        Me.CBTipo.AutoSize = True
        Me.CBTipo.Location = New System.Drawing.Point(363, 199)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(100, 23)
        Me.CBTipo.TabIndex = 3
        Me.CBTipo.Text = "Em Comum"
        Me.CBTipo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(469, 182)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 33)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCadeiraDataGridViewTextBoxColumn, Me.NomeCadeiraDataGridViewTextBoxColumn, Me.CreditoCadeiraDataGridViewTextBoxColumn, Me.AnoDataGridViewTextBoxColumn, Me.SemestreDataGridViewTextBoxColumn, Me.TipoCadeiraDataGridViewTextBoxColumn, Me.IdCursoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CadeiratbBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(23, 231)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(529, 304)
        Me.DataGridView1.TabIndex = 28
        '
        'IdCadeiraDataGridViewTextBoxColumn
        '
        Me.IdCadeiraDataGridViewTextBoxColumn.DataPropertyName = "idCadeira"
        Me.IdCadeiraDataGridViewTextBoxColumn.HeaderText = "idCadeira"
        Me.IdCadeiraDataGridViewTextBoxColumn.Name = "IdCadeiraDataGridViewTextBoxColumn"
        Me.IdCadeiraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCadeiraDataGridViewTextBoxColumn.Visible = False
        '
        'NomeCadeiraDataGridViewTextBoxColumn
        '
        Me.NomeCadeiraDataGridViewTextBoxColumn.DataPropertyName = "Nome_Cadeira"
        Me.NomeCadeiraDataGridViewTextBoxColumn.HeaderText = "Cadeira"
        Me.NomeCadeiraDataGridViewTextBoxColumn.Name = "NomeCadeiraDataGridViewTextBoxColumn"
        Me.NomeCadeiraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreditoCadeiraDataGridViewTextBoxColumn
        '
        Me.CreditoCadeiraDataGridViewTextBoxColumn.DataPropertyName = "Credito_Cadeira"
        Me.CreditoCadeiraDataGridViewTextBoxColumn.HeaderText = "Credito"
        Me.CreditoCadeiraDataGridViewTextBoxColumn.Name = "CreditoCadeiraDataGridViewTextBoxColumn"
        Me.CreditoCadeiraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnoDataGridViewTextBoxColumn
        '
        Me.AnoDataGridViewTextBoxColumn.DataPropertyName = "Ano"
        Me.AnoDataGridViewTextBoxColumn.HeaderText = "Ano"
        Me.AnoDataGridViewTextBoxColumn.Name = "AnoDataGridViewTextBoxColumn"
        Me.AnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SemestreDataGridViewTextBoxColumn
        '
        Me.SemestreDataGridViewTextBoxColumn.DataPropertyName = "Semestre"
        Me.SemestreDataGridViewTextBoxColumn.HeaderText = "Semestre"
        Me.SemestreDataGridViewTextBoxColumn.Name = "SemestreDataGridViewTextBoxColumn"
        Me.SemestreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoCadeiraDataGridViewTextBoxColumn
        '
        Me.TipoCadeiraDataGridViewTextBoxColumn.DataPropertyName = "TipoCadeira"
        Me.TipoCadeiraDataGridViewTextBoxColumn.HeaderText = "TipoCadeira"
        Me.TipoCadeiraDataGridViewTextBoxColumn.Name = "TipoCadeiraDataGridViewTextBoxColumn"
        Me.TipoCadeiraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCursoDataGridViewTextBoxColumn
        '
        Me.IdCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso"
        Me.IdCursoDataGridViewTextBoxColumn.HeaderText = "idCurso"
        Me.IdCursoDataGridViewTextBoxColumn.Name = "IdCursoDataGridViewTextBoxColumn"
        Me.IdCursoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCursoDataGridViewTextBoxColumn.Visible = False
        '
        'CadeiratbBindingSource
        '
        Me.CadeiratbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Cadeira_tb)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Curso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(100, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Ano:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(100, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 19)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Semestre:"
        '
        'frmCadeiraAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 561)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CBTipo)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.credito_textBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Nome_CadeiraLabel)
        Me.Controls.Add(Me.Nome_CadeiraTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmCadeiraAdd"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Nova cadeira do curso"
        CType(Me.credito_textBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadeiratbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nome_CadeiraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents credito_textBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents CBTipo As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdCadeiraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCadeiraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditoCadeiraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SemestreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCadeiraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CadeiratbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
