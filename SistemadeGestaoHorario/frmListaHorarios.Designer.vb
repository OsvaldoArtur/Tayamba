<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaHorarios
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
        Dim IdCursoLabel As System.Windows.Forms.Label
        Dim SemestreLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.View_ListaHorarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.idHorarioPorSemana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idAno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_ListaHorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdAnoTextBox = New System.Windows.Forms.NumericUpDown()
        Me.IdSalaTextBox = New System.Windows.Forms.ComboBox()
        Me.SalastbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdPeriodoTextBox = New System.Windows.Forms.ComboBox()
        Me.PeriodotbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdCursoComboBox = New System.Windows.Forms.ComboBox()
        Me.CusostbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SemestreTextBox = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        IdAnoLabel = New System.Windows.Forms.Label()
        IdSalaLabel = New System.Windows.Forms.Label()
        IdPeriodoLabel = New System.Windows.Forms.Label()
        IdCursoLabel = New System.Windows.Forms.Label()
        SemestreLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.View_ListaHorarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_ListaHorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdAnoTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalastbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodotbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CusostbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemestreTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdAnoLabel
        '
        IdAnoLabel.AutoSize = True
        IdAnoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdAnoLabel.Location = New System.Drawing.Point(58, 148)
        IdAnoLabel.Name = "IdAnoLabel"
        IdAnoLabel.Size = New System.Drawing.Size(37, 19)
        IdAnoLabel.TabIndex = 23
        IdAnoLabel.Text = "Ano:"
        '
        'IdSalaLabel
        '
        IdSalaLabel.AutoSize = True
        IdSalaLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdSalaLabel.Location = New System.Drawing.Point(56, 181)
        IdSalaLabel.Name = "IdSalaLabel"
        IdSalaLabel.Size = New System.Drawing.Size(36, 19)
        IdSalaLabel.TabIndex = 21
        IdSalaLabel.Text = "Sala:"
        '
        'IdPeriodoLabel
        '
        IdPeriodoLabel.AutoSize = True
        IdPeriodoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdPeriodoLabel.Location = New System.Drawing.Point(309, 148)
        IdPeriodoLabel.Name = "IdPeriodoLabel"
        IdPeriodoLabel.Size = New System.Drawing.Size(59, 19)
        IdPeriodoLabel.TabIndex = 19
        IdPeriodoLabel.Text = "Periodo:"
        '
        'IdCursoLabel
        '
        IdCursoLabel.AutoSize = True
        IdCursoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdCursoLabel.Location = New System.Drawing.Point(44, 116)
        IdCursoLabel.Name = "IdCursoLabel"
        IdCursoLabel.Size = New System.Drawing.Size(48, 19)
        IdCursoLabel.TabIndex = 17
        IdCursoLabel.Text = "Curso:"
        '
        'SemestreLabel
        '
        SemestreLabel.AutoSize = True
        SemestreLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SemestreLabel.Location = New System.Drawing.Point(171, 149)
        SemestreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SemestreLabel.Name = "SemestreLabel"
        SemestreLabel.Size = New System.Drawing.Size(68, 19)
        SemestreLabel.TabIndex = 15
        SemestreLabel.Text = "Semestre:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 36)
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ImprimirToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Print_25px
        Me.ImprimirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(137, 32)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'View_ListaHorarioDataGridView
        '
        Me.View_ListaHorarioDataGridView.AllowUserToAddRows = False
        Me.View_ListaHorarioDataGridView.AllowUserToDeleteRows = False
        Me.View_ListaHorarioDataGridView.AutoGenerateColumns = False
        Me.View_ListaHorarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.View_ListaHorarioDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_ListaHorarioDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.View_ListaHorarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_ListaHorarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idHorarioPorSemana, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5, Me.idAno})
        Me.View_ListaHorarioDataGridView.DataSource = Me.View_ListaHorarioBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.View_ListaHorarioDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.View_ListaHorarioDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.View_ListaHorarioDataGridView.Location = New System.Drawing.Point(20, 296)
        Me.View_ListaHorarioDataGridView.MultiSelect = False
        Me.View_ListaHorarioDataGridView.Name = "View_ListaHorarioDataGridView"
        Me.View_ListaHorarioDataGridView.ReadOnly = True
        Me.View_ListaHorarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.View_ListaHorarioDataGridView.Size = New System.Drawing.Size(917, 266)
        Me.View_ListaHorarioDataGridView.TabIndex = 2
        '
        'idHorarioPorSemana
        '
        Me.idHorarioPorSemana.DataPropertyName = "idHorarioPorSemana"
        Me.idHorarioPorSemana.FillWeight = 50.0!
        Me.idHorarioPorSemana.HeaderText = "Nº"
        Me.idHorarioPorSemana.Name = "idHorarioPorSemana"
        Me.idHorarioPorSemana.ReadOnly = True
        Me.idHorarioPorSemana.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idCurso"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idCurso"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Nome_Curso"
        Me.DataGridViewTextBoxColumn9.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Curso"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Semestre"
        Me.DataGridViewTextBoxColumn2.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Semestre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ano"
        Me.DataGridViewTextBoxColumn3.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ano"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idSala"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idSala"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idPeriodo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idPeriodo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nome_periodo"
        Me.DataGridViewTextBoxColumn7.FillWeight = 65.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Periodo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nome_Sala"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sala"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'idAno
        '
        Me.idAno.DataPropertyName = "idAno"
        Me.idAno.FillWeight = 50.0!
        Me.idAno.HeaderText = "Ano"
        Me.idAno.Name = "idAno"
        Me.idAno.ReadOnly = True
        '
        'View_ListaHorarioBindingSource
        '
        Me.View_ListaHorarioBindingSource.DataSource = GetType(SistemadeGestaoHorario.View_ListaHorario)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Precisa de Ajuda?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(449, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Desenvolvedor: Osvaldo Artur Dionisio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(24, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 19)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Desenvolvedor: Osvaldo Artur Dionisio"
        '
        'IdAnoTextBox
        '
        Me.IdAnoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdAnoTextBox.Location = New System.Drawing.Point(101, 146)
        Me.IdAnoTextBox.Name = "IdAnoTextBox"
        Me.IdAnoTextBox.Size = New System.Drawing.Size(57, 25)
        Me.IdAnoTextBox.TabIndex = 25
        Me.IdAnoTextBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'IdSalaTextBox
        '
        Me.IdSalaTextBox.DataSource = Me.SalastbBindingSource
        Me.IdSalaTextBox.DisplayMember = "Nome_Sala"
        Me.IdSalaTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdSalaTextBox.FormattingEnabled = True
        Me.IdSalaTextBox.Location = New System.Drawing.Point(101, 178)
        Me.IdSalaTextBox.Name = "IdSalaTextBox"
        Me.IdSalaTextBox.Size = New System.Drawing.Size(386, 25)
        Me.IdSalaTextBox.TabIndex = 24
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
        Me.IdPeriodoTextBox.Location = New System.Drawing.Point(374, 146)
        Me.IdPeriodoTextBox.Name = "IdPeriodoTextBox"
        Me.IdPeriodoTextBox.Size = New System.Drawing.Size(113, 25)
        Me.IdPeriodoTextBox.TabIndex = 22
        Me.IdPeriodoTextBox.ValueMember = "idPeriodo"
        '
        'PeriodotbBindingSource
        '
        Me.PeriodotbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Periodo_tb)
        '
        'IdCursoComboBox
        '
        Me.IdCursoComboBox.DataSource = Me.CusostbBindingSource
        Me.IdCursoComboBox.DisplayMember = "Nome_Curso"
        Me.IdCursoComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdCursoComboBox.FormattingEnabled = True
        Me.IdCursoComboBox.Location = New System.Drawing.Point(101, 116)
        Me.IdCursoComboBox.Name = "IdCursoComboBox"
        Me.IdCursoComboBox.Size = New System.Drawing.Size(386, 25)
        Me.IdCursoComboBox.TabIndex = 20
        Me.IdCursoComboBox.ValueMember = "idCurso"
        '
        'CusostbBindingSource
        '
        Me.CusostbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Cusos_tb)
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(412, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Criar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SemestreTextBox
        '
        Me.SemestreTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemestreTextBox.Location = New System.Drawing.Point(246, 148)
        Me.SemestreTextBox.Name = "SemestreTextBox"
        Me.SemestreTextBox.Size = New System.Drawing.Size(57, 25)
        Me.SemestreTextBox.TabIndex = 16
        Me.SemestreTextBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Courses_80px
        Me.PictureBox4.Location = New System.Drawing.Point(566, 123)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Watch_100px
        Me.PictureBox3.Location = New System.Drawing.Point(652, 116)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Curriculum_100px
        Me.PictureBox2.Location = New System.Drawing.Point(758, 116)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Help_25px
        Me.PictureBox1.Location = New System.Drawing.Point(363, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(23, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(361, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "1ª Fase: Crie o Horario Escolhendo todos os campos."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(23, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(433, 19)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "2ª Fase: Clica duas vezes sobre a grelha para atribuir o horario."
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Black
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCancelar.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Delete_Row_25px
        Me.btnCancelar.Location = New System.Drawing.Point(822, 253)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 37)
        Me.btnCancelar.TabIndex = 37
        Me.btnCancelar.Text = "Deletar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmListaHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 582)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IdAnoTextBox)
        Me.Controls.Add(IdAnoLabel)
        Me.Controls.Add(Me.IdSalaTextBox)
        Me.Controls.Add(Me.IdPeriodoTextBox)
        Me.Controls.Add(IdSalaLabel)
        Me.Controls.Add(IdPeriodoLabel)
        Me.Controls.Add(IdCursoLabel)
        Me.Controls.Add(Me.IdCursoComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SemestreTextBox)
        Me.Controls.Add(SemestreLabel)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.View_ListaHorarioDataGridView)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmListaHorarios"
        Me.Resizable = False
        Me.Text = "Criar/Lista Horarios"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.View_ListaHorarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_ListaHorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdAnoTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalastbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodotbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CusostbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemestreTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents View_ListaHorarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_ListaHorarioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdAnoTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents IdSalaTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdPeriodoTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdCursoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SemestreTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents SalastbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodotbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CusostbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents idHorarioPorSemana As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idAno As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
