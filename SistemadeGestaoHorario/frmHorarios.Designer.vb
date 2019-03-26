<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorarios
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
        Dim SemestreLabel As System.Windows.Forms.Label
        Dim IdCursoLabel As System.Windows.Forms.Label
        Dim IdPeriodoLabel As System.Windows.Forms.Label
        Dim IdSalaLabel As System.Windows.Forms.Label
        Dim IdAnoLabel As System.Windows.Forms.Label
        Me.SemestreTextBox = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Horario_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cadeira_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdCursoComboBox = New System.Windows.Forms.ComboBox()
        Me.CusostbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdPeriodoTextBox = New System.Windows.Forms.ComboBox()
        Me.PeriodotbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdSalaTextBox = New System.Windows.Forms.ComboBox()
        Me.SalastbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdAnoTextBox = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        SemestreLabel = New System.Windows.Forms.Label()
        IdCursoLabel = New System.Windows.Forms.Label()
        IdPeriodoLabel = New System.Windows.Forms.Label()
        IdSalaLabel = New System.Windows.Forms.Label()
        IdAnoLabel = New System.Windows.Forms.Label()
        CType(Me.SemestreTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horario_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cadeira_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CusostbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodotbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalastbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdAnoTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SemestreLabel
        '
        SemestreLabel.AutoSize = True
        SemestreLabel.Location = New System.Drawing.Point(28, 115)
        SemestreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SemestreLabel.Name = "SemestreLabel"
        SemestreLabel.Size = New System.Drawing.Size(68, 19)
        SemestreLabel.TabIndex = 1
        SemestreLabel.Text = "Semestre:"
        '
        'IdCursoLabel
        '
        IdCursoLabel.AutoSize = True
        IdCursoLabel.Location = New System.Drawing.Point(46, 82)
        IdCursoLabel.Name = "IdCursoLabel"
        IdCursoLabel.Size = New System.Drawing.Size(48, 19)
        IdCursoLabel.TabIndex = 6
        IdCursoLabel.Text = "Curso:"
        '
        'IdPeriodoLabel
        '
        IdPeriodoLabel.AutoSize = True
        IdPeriodoLabel.Location = New System.Drawing.Point(335, 115)
        IdPeriodoLabel.Name = "IdPeriodoLabel"
        IdPeriodoLabel.Size = New System.Drawing.Size(59, 19)
        IdPeriodoLabel.TabIndex = 7
        IdPeriodoLabel.Text = "Periodo:"
        '
        'IdSalaLabel
        '
        IdSalaLabel.AutoSize = True
        IdSalaLabel.Location = New System.Drawing.Point(58, 147)
        IdSalaLabel.Name = "IdSalaLabel"
        IdSalaLabel.Size = New System.Drawing.Size(36, 19)
        IdSalaLabel.TabIndex = 8
        IdSalaLabel.Text = "Sala:"
        '
        'IdAnoLabel
        '
        IdAnoLabel.AutoSize = True
        IdAnoLabel.Location = New System.Drawing.Point(357, 83)
        IdAnoLabel.Name = "IdAnoLabel"
        IdAnoLabel.Size = New System.Drawing.Size(37, 19)
        IdAnoLabel.TabIndex = 11
        IdAnoLabel.Text = "Ano:"
        '
        'SemestreTextBox
        '
        Me.SemestreTextBox.Location = New System.Drawing.Point(103, 113)
        Me.SemestreTextBox.Name = "SemestreTextBox"
        Me.SemestreTextBox.Size = New System.Drawing.Size(201, 25)
        Me.SemestreTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(526, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Criar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Horario_tbBindingSource
        '
        Me.Horario_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Horario_tb)
        '
        'Cadeira_tbBindingSource
        '
        Me.Cadeira_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Cadeira_tb)
        '
        'IdCursoComboBox
        '
        Me.IdCursoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cadeira_tbBindingSource, "idCurso", True))
        Me.IdCursoComboBox.DataSource = Me.CusostbBindingSource
        Me.IdCursoComboBox.DisplayMember = "Nome_Curso"
        Me.IdCursoComboBox.FormattingEnabled = True
        Me.IdCursoComboBox.Location = New System.Drawing.Point(103, 82)
        Me.IdCursoComboBox.Name = "IdCursoComboBox"
        Me.IdCursoComboBox.Size = New System.Drawing.Size(201, 25)
        Me.IdCursoComboBox.TabIndex = 7
        Me.IdCursoComboBox.ValueMember = "idCurso"
        '
        'CusostbBindingSource
        '
        Me.CusostbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Cusos_tb)
        '
        'IdPeriodoTextBox
        '
        Me.IdPeriodoTextBox.DataSource = Me.PeriodotbBindingSource
        Me.IdPeriodoTextBox.DisplayMember = "Nome_periodo"
        Me.IdPeriodoTextBox.FormattingEnabled = True
        Me.IdPeriodoTextBox.Location = New System.Drawing.Point(400, 112)
        Me.IdPeriodoTextBox.Name = "IdPeriodoTextBox"
        Me.IdPeriodoTextBox.Size = New System.Drawing.Size(201, 25)
        Me.IdPeriodoTextBox.TabIndex = 10
        Me.IdPeriodoTextBox.ValueMember = "idPeriodo"
        '
        'PeriodotbBindingSource
        '
        Me.PeriodotbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Periodo_tb)
        '
        'IdSalaTextBox
        '
        Me.IdSalaTextBox.DataSource = Me.SalastbBindingSource
        Me.IdSalaTextBox.DisplayMember = "Nome_Sala"
        Me.IdSalaTextBox.FormattingEnabled = True
        Me.IdSalaTextBox.Location = New System.Drawing.Point(103, 144)
        Me.IdSalaTextBox.Name = "IdSalaTextBox"
        Me.IdSalaTextBox.Size = New System.Drawing.Size(201, 25)
        Me.IdSalaTextBox.TabIndex = 11
        Me.IdSalaTextBox.ValueMember = "idSala"
        '
        'SalastbBindingSource
        '
        Me.SalastbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Salas_tb)
        '
        'IdAnoTextBox
        '
        Me.IdAnoTextBox.Location = New System.Drawing.Point(400, 81)
        Me.IdAnoTextBox.Name = "IdAnoTextBox"
        Me.IdAnoTextBox.Size = New System.Drawing.Size(201, 25)
        Me.IdAnoTextBox.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(27, 196)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(246, 19)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Desenvolvedor: Osvaldo Artur Dionisio"
        '
        'frmHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 264)
        Me.Controls.Add(Me.Label15)
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
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmHorarios"
        Me.Padding = New System.Windows.Forms.Padding(24, 79, 24, 27)
        Me.Resizable = False
        Me.Text = "Horario"
        CType(Me.SemestreTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horario_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cadeira_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CusostbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodotbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalastbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdAnoTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Horario_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SemestreTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cadeira_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdCursoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CusostbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdPeriodoTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdSalaTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents PeriodotbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalastbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdAnoTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
