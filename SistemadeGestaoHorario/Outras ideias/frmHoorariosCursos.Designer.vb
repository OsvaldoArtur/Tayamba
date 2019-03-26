<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoorariosCursos
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
        Dim IdAnoLabel As System.Windows.Forms.Label
        Dim IdSalaLabel As System.Windows.Forms.Label
        Dim IdPeriodoLabel As System.Windows.Forms.Label
        Dim SemestreLabel As System.Windows.Forms.Label
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PeriodotbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NomeSalaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemestreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeperiodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSalaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPeriodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdHorarioPorSemanaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_Curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewListaHorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.IdAnoTextBox = New System.Windows.Forms.NumericUpDown()
        Me.IdSalaTextBox = New System.Windows.Forms.ComboBox()
        Me.SalastbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdPeriodoTextBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SemestreTextBox = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        IdAnoLabel = New System.Windows.Forms.Label()
        IdSalaLabel = New System.Windows.Forms.Label()
        IdPeriodoLabel = New System.Windows.Forms.Label()
        SemestreLabel = New System.Windows.Forms.Label()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.PeriodotbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewListaHorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.IdAnoTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalastbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemestreTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdAnoLabel
        '
        IdAnoLabel.AutoSize = True
        IdAnoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdAnoLabel.Location = New System.Drawing.Point(241, 102)
        IdAnoLabel.Name = "IdAnoLabel"
        IdAnoLabel.Size = New System.Drawing.Size(37, 19)
        IdAnoLabel.TabIndex = 33
        IdAnoLabel.Text = "Ano:"
        '
        'IdSalaLabel
        '
        IdSalaLabel.AutoSize = True
        IdSalaLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdSalaLabel.Location = New System.Drawing.Point(239, 135)
        IdSalaLabel.Name = "IdSalaLabel"
        IdSalaLabel.Size = New System.Drawing.Size(36, 19)
        IdSalaLabel.TabIndex = 31
        IdSalaLabel.Text = "Sala:"
        '
        'IdPeriodoLabel
        '
        IdPeriodoLabel.AutoSize = True
        IdPeriodoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdPeriodoLabel.Location = New System.Drawing.Point(492, 102)
        IdPeriodoLabel.Name = "IdPeriodoLabel"
        IdPeriodoLabel.Size = New System.Drawing.Size(58, 19)
        IdPeriodoLabel.TabIndex = 30
        IdPeriodoLabel.Text = "Periodo:"
        '
        'SemestreLabel
        '
        SemestreLabel.AutoSize = True
        SemestreLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SemestreLabel.Location = New System.Drawing.Point(354, 103)
        SemestreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SemestreLabel.Name = "SemestreLabel"
        SemestreLabel.Size = New System.Drawing.Size(68, 19)
        SemestreLabel.TabIndex = 27
        SemestreLabel.Text = "Semestre:"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 135)
        Me.MetroTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(885, 451)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.ComboBox1)
        Me.MetroTabPage1.Controls.Add(Me.Label5)
        Me.MetroTabPage1.Controls.Add(Me.DataGridView1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 2
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(877, 409)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Lista de Horarios"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.ComboBox1.DataSource = Me.PeriodotbBindingSource
        Me.ComboBox1.DisplayMember = "Nome_periodo"
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(158, 25)
        Me.ComboBox1.TabIndex = 40
        Me.ComboBox1.ValueMember = "idPeriodo"
        '
        'PeriodotbBindingSource
        '
        Me.PeriodotbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Periodo_tb)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(3, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Escolha o Periodo:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomeSalaDataGridViewTextBoxColumn, Me.IdAnoDataGridViewTextBoxColumn, Me.SemestreDataGridViewTextBoxColumn, Me.AnoDataGridViewTextBoxColumn, Me.NomeperiodoDataGridViewTextBoxColumn, Me.IdSalaDataGridViewTextBoxColumn, Me.IdPeriodoDataGridViewTextBoxColumn, Me.IdCursoDataGridViewTextBoxColumn, Me.IdHorarioPorSemanaDataGridViewTextBoxColumn, Me.Nome_Curso})
        Me.DataGridView1.DataSource = Me.ViewListaHorarioBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 67)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(873, 292)
        Me.DataGridView1.TabIndex = 2
        '
        'NomeSalaDataGridViewTextBoxColumn
        '
        Me.NomeSalaDataGridViewTextBoxColumn.DataPropertyName = "Nome_Sala"
        Me.NomeSalaDataGridViewTextBoxColumn.HeaderText = "Sala"
        Me.NomeSalaDataGridViewTextBoxColumn.Name = "NomeSalaDataGridViewTextBoxColumn"
        Me.NomeSalaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdAnoDataGridViewTextBoxColumn
        '
        Me.IdAnoDataGridViewTextBoxColumn.DataPropertyName = "idAno"
        Me.IdAnoDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.IdAnoDataGridViewTextBoxColumn.HeaderText = "Ano "
        Me.IdAnoDataGridViewTextBoxColumn.Name = "IdAnoDataGridViewTextBoxColumn"
        Me.IdAnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SemestreDataGridViewTextBoxColumn
        '
        Me.SemestreDataGridViewTextBoxColumn.DataPropertyName = "Semestre"
        Me.SemestreDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.SemestreDataGridViewTextBoxColumn.HeaderText = "Semestre"
        Me.SemestreDataGridViewTextBoxColumn.Name = "SemestreDataGridViewTextBoxColumn"
        Me.SemestreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnoDataGridViewTextBoxColumn
        '
        Me.AnoDataGridViewTextBoxColumn.DataPropertyName = "Ano"
        Me.AnoDataGridViewTextBoxColumn.FillWeight = 75.0!
        Me.AnoDataGridViewTextBoxColumn.HeaderText = "Ano Lectivo"
        Me.AnoDataGridViewTextBoxColumn.Name = "AnoDataGridViewTextBoxColumn"
        Me.AnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnoDataGridViewTextBoxColumn.Visible = False
        '
        'NomeperiodoDataGridViewTextBoxColumn
        '
        Me.NomeperiodoDataGridViewTextBoxColumn.DataPropertyName = "Nome_periodo"
        Me.NomeperiodoDataGridViewTextBoxColumn.FillWeight = 70.0!
        Me.NomeperiodoDataGridViewTextBoxColumn.HeaderText = "Periodo"
        Me.NomeperiodoDataGridViewTextBoxColumn.Name = "NomeperiodoDataGridViewTextBoxColumn"
        Me.NomeperiodoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdSalaDataGridViewTextBoxColumn
        '
        Me.IdSalaDataGridViewTextBoxColumn.DataPropertyName = "idSala"
        Me.IdSalaDataGridViewTextBoxColumn.HeaderText = "idSala"
        Me.IdSalaDataGridViewTextBoxColumn.Name = "IdSalaDataGridViewTextBoxColumn"
        Me.IdSalaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdSalaDataGridViewTextBoxColumn.Visible = False
        '
        'IdPeriodoDataGridViewTextBoxColumn
        '
        Me.IdPeriodoDataGridViewTextBoxColumn.DataPropertyName = "idPeriodo"
        Me.IdPeriodoDataGridViewTextBoxColumn.HeaderText = "idPeriodo"
        Me.IdPeriodoDataGridViewTextBoxColumn.Name = "IdPeriodoDataGridViewTextBoxColumn"
        Me.IdPeriodoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPeriodoDataGridViewTextBoxColumn.Visible = False
        '
        'IdCursoDataGridViewTextBoxColumn
        '
        Me.IdCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso"
        Me.IdCursoDataGridViewTextBoxColumn.HeaderText = "idCurso"
        Me.IdCursoDataGridViewTextBoxColumn.Name = "IdCursoDataGridViewTextBoxColumn"
        Me.IdCursoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCursoDataGridViewTextBoxColumn.Visible = False
        '
        'IdHorarioPorSemanaDataGridViewTextBoxColumn
        '
        Me.IdHorarioPorSemanaDataGridViewTextBoxColumn.DataPropertyName = "idHorarioPorSemana"
        Me.IdHorarioPorSemanaDataGridViewTextBoxColumn.HeaderText = "idHorarioPorSemana"
        Me.IdHorarioPorSemanaDataGridViewTextBoxColumn.Name = "IdHorarioPorSemanaDataGridViewTextBoxColumn"
        Me.IdHorarioPorSemanaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdHorarioPorSemanaDataGridViewTextBoxColumn.Visible = False
        '
        'Nome_Curso
        '
        Me.Nome_Curso.DataPropertyName = "Nome_Curso"
        Me.Nome_Curso.HeaderText = "Nome_Curso"
        Me.Nome_Curso.Name = "Nome_Curso"
        Me.Nome_Curso.ReadOnly = True
        Me.Nome_Curso.Visible = False
        '
        'ViewListaHorarioBindingSource
        '
        Me.ViewListaHorarioBindingSource.DataSource = GetType(SistemadeGestaoHorario.View_ListaHorario)
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.IdAnoTextBox)
        Me.MetroTabPage2.Controls.Add(IdAnoLabel)
        Me.MetroTabPage2.Controls.Add(Me.IdSalaTextBox)
        Me.MetroTabPage2.Controls.Add(Me.IdPeriodoTextBox)
        Me.MetroTabPage2.Controls.Add(IdSalaLabel)
        Me.MetroTabPage2.Controls.Add(IdPeriodoLabel)
        Me.MetroTabPage2.Controls.Add(Me.Button1)
        Me.MetroTabPage2.Controls.Add(Me.SemestreTextBox)
        Me.MetroTabPage2.Controls.Add(SemestreLabel)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 2
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(877, 409)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Criar Horario"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 3
        '
        'IdAnoTextBox
        '
        Me.IdAnoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdAnoTextBox.Location = New System.Drawing.Point(284, 103)
        Me.IdAnoTextBox.Name = "IdAnoTextBox"
        Me.IdAnoTextBox.Size = New System.Drawing.Size(57, 25)
        Me.IdAnoTextBox.TabIndex = 35
        Me.IdAnoTextBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'IdSalaTextBox
        '
        Me.IdSalaTextBox.DataSource = Me.SalastbBindingSource
        Me.IdSalaTextBox.DisplayMember = "Nome_Sala"
        Me.IdSalaTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdSalaTextBox.FormattingEnabled = True
        Me.IdSalaTextBox.Location = New System.Drawing.Point(284, 132)
        Me.IdSalaTextBox.Name = "IdSalaTextBox"
        Me.IdSalaTextBox.Size = New System.Drawing.Size(386, 25)
        Me.IdSalaTextBox.TabIndex = 34
        Me.IdSalaTextBox.ValueMember = "idSala"
        '
        'SalastbBindingSource
        '
        Me.SalastbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Salas_tb)
        '
        'IdPeriodoTextBox
        '
        Me.IdPeriodoTextBox.DataSource = Me.PeriodotbBindingSource
        Me.IdPeriodoTextBox.DisplayMember = "Nome_periodo"
        Me.IdPeriodoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdPeriodoTextBox.FormattingEnabled = True
        Me.IdPeriodoTextBox.Location = New System.Drawing.Point(557, 100)
        Me.IdPeriodoTextBox.Name = "IdPeriodoTextBox"
        Me.IdPeriodoTextBox.Size = New System.Drawing.Size(113, 25)
        Me.IdPeriodoTextBox.TabIndex = 32
        Me.IdPeriodoTextBox.ValueMember = "idPeriodo"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.DoubleTick_25px1
        Me.Button1.Location = New System.Drawing.Point(595, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Criar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SemestreTextBox
        '
        Me.SemestreTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemestreTextBox.Location = New System.Drawing.Point(429, 102)
        Me.SemestreTextBox.Name = "SemestreTextBox"
        Me.SemestreTextBox.Size = New System.Drawing.Size(57, 25)
        Me.SemestreTextBox.TabIndex = 28
        Me.SemestreTextBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(26, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Duracao:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(307, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(246, 19)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Desenvolvedor: Osvaldo Artur Dionisio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(272, 586)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(378, 19)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Clica duas vezes sobre a grelha para atribuir o horario."
        '
        'frmHoorariosCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 612)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmHoorariosCursos"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Horarios do Curso"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        CType(Me.PeriodotbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewListaHorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.IdAnoTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalastbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemestreTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ViewListaHorarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PeriodotbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IdAnoTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents IdSalaTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdPeriodoTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SemestreTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SalastbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NomeSalaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SemestreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeperiodoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSalaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPeriodoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdHorarioPorSemanaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome_Curso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
