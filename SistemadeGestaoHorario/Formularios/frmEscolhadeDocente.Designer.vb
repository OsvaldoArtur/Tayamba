<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEscolhadeDocente
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PeriodotbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.View_HorarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_HorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HorasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCadeiraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemestreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeSalaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeperiodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semestre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnotbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PeriodotbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.View_HorarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_HorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnotbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(23, 78)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(873, 95)
        Me.Panel1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.PeriodotbBindingSource
        Me.ComboBox2.DisplayMember = "Nome_periodo"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(543, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.ValueMember = "idPeriodo"
        '
        'PeriodotbBindingSource
        '
        Me.PeriodotbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Periodo_tb)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(539, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Periodo:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(468, 41)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(60, 25)
        Me.NumericUpDown1.TabIndex = 5
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.AnotbBindingSource
        Me.ComboBox1.DisplayMember = "Ano"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(332, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Semestre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ano:"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Print_25px
        Me.Button1.Location = New System.Drawing.Point(747, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome Docente:"
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.Location = New System.Drawing.Point(15, 41)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(311, 25)
        Me.TextBox1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.View_HorarioDataGridView)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(23, 173)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(873, 367)
        Me.Panel3.TabIndex = 2
        '
        'View_HorarioDataGridView
        '
        Me.View_HorarioDataGridView.AllowUserToAddRows = False
        Me.View_HorarioDataGridView.AllowUserToDeleteRows = False
        Me.View_HorarioDataGridView.AutoGenerateColumns = False
        Me.View_HorarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.View_HorarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_HorarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn17})
        Me.View_HorarioDataGridView.DataSource = Me.View_HorarioBindingSource
        Me.View_HorarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.View_HorarioDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.View_HorarioDataGridView.MultiSelect = False
        Me.View_HorarioDataGridView.Name = "View_HorarioDataGridView"
        Me.View_HorarioDataGridView.ReadOnly = True
        Me.View_HorarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.View_HorarioDataGridView.Size = New System.Drawing.Size(873, 367)
        Me.View_HorarioDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idDocente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idDocente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Nome_Curso"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Curso"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Nome_Cadeira"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cadeira"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Nome_periodo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Periodo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Horas"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Horas"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ano"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ano"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Semestre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Semestre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Nome_Sala"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Sala"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Dia"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Dia"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'View_HorarioBindingSource
        '
        Me.View_HorarioBindingSource.DataSource = GetType(SistemadeGestaoHorario.View_Horario)
        '
        'HorasDataGridViewTextBoxColumn
        '
        Me.HorasDataGridViewTextBoxColumn.DataPropertyName = "Horas"
        Me.HorasDataGridViewTextBoxColumn.HeaderText = "Horas"
        Me.HorasDataGridViewTextBoxColumn.Name = "HorasDataGridViewTextBoxColumn"
        '
        'NomeCursoDataGridViewTextBoxColumn
        '
        Me.NomeCursoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Curso"
        Me.NomeCursoDataGridViewTextBoxColumn.HeaderText = "Curso"
        Me.NomeCursoDataGridViewTextBoxColumn.Name = "NomeCursoDataGridViewTextBoxColumn"
        '
        'NomeCadeiraDataGridViewTextBoxColumn
        '
        Me.NomeCadeiraDataGridViewTextBoxColumn.DataPropertyName = "Nome_Cadeira"
        Me.NomeCadeiraDataGridViewTextBoxColumn.HeaderText = "Cadeira"
        Me.NomeCadeiraDataGridViewTextBoxColumn.Name = "NomeCadeiraDataGridViewTextBoxColumn"
        '
        'AnoDataGridViewTextBoxColumn
        '
        Me.AnoDataGridViewTextBoxColumn.DataPropertyName = "Ano"
        Me.AnoDataGridViewTextBoxColumn.HeaderText = "Ano"
        Me.AnoDataGridViewTextBoxColumn.Name = "AnoDataGridViewTextBoxColumn"
        '
        'SemestreDataGridViewTextBoxColumn
        '
        Me.SemestreDataGridViewTextBoxColumn.DataPropertyName = "Semestre"
        Me.SemestreDataGridViewTextBoxColumn.HeaderText = "Semestre"
        Me.SemestreDataGridViewTextBoxColumn.Name = "SemestreDataGridViewTextBoxColumn"
        '
        'NomeSalaDataGridViewTextBoxColumn
        '
        Me.NomeSalaDataGridViewTextBoxColumn.DataPropertyName = "Nome_Sala"
        Me.NomeSalaDataGridViewTextBoxColumn.HeaderText = "Sala"
        Me.NomeSalaDataGridViewTextBoxColumn.Name = "NomeSalaDataGridViewTextBoxColumn"
        '
        'NomeperiodoDataGridViewTextBoxColumn
        '
        Me.NomeperiodoDataGridViewTextBoxColumn.DataPropertyName = "Nome_periodo"
        Me.NomeperiodoDataGridViewTextBoxColumn.HeaderText = "Periodo"
        Me.NomeperiodoDataGridViewTextBoxColumn.Name = "NomeperiodoDataGridViewTextBoxColumn"
        '
        'DiaDataGridViewTextBoxColumn
        '
        Me.DiaDataGridViewTextBoxColumn.DataPropertyName = "Dia"
        Me.DiaDataGridViewTextBoxColumn.HeaderText = "Dia"
        Me.DiaDataGridViewTextBoxColumn.Name = "DiaDataGridViewTextBoxColumn"
        '
        'Ano
        '
        Me.Ano.DataPropertyName = "Ano"
        Me.Ano.HeaderText = "Ano"
        Me.Ano.Name = "Ano"
        '
        'Semestre
        '
        Me.Semestre.DataPropertyName = "Semestre"
        Me.Semestre.HeaderText = "Semestre"
        Me.Semestre.Name = "Semestre"
        '
        'AnotbBindingSource
        '
        Me.AnotbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Ano_tb)
        '
        'frmEscolhadeDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 566)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmEscolhadeDocente"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Imprimir Horario do Docente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PeriodotbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.View_HorarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_HorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnotbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents HorasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCadeiraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SemestreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeSalaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeperiodoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ano As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Semestre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents View_HorarioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents View_HorarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents PeriodotbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AnotbBindingSource As BindingSource
End Class
