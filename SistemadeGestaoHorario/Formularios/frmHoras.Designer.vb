<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoras
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
        Dim HorasLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim IdPeriodoLabel As System.Windows.Forms.Label
        Me.Horas_tbDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horas_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IdPeriodoComboBox = New System.Windows.Forms.ComboBox()
        Me.PeriodotbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.HorasTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.HorasTextBox1 = New System.Windows.Forms.MaskedTextBox()
        HorasLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        IdPeriodoLabel = New System.Windows.Forms.Label()
        CType(Me.Horas_tbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodotbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HorasLabel
        '
        HorasLabel.AutoSize = True
        HorasLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HorasLabel.Location = New System.Drawing.Point(334, 65)
        HorasLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HorasLabel.Name = "HorasLabel"
        HorasLabel.Size = New System.Drawing.Size(48, 19)
        HorasLabel.TabIndex = 1
        HorasLabel.Text = "Horas:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(347, 90)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(22, 19)
        Label1.TabIndex = 18
        Label1.Text = "as"
        '
        'IdPeriodoLabel
        '
        IdPeriodoLabel.AutoSize = True
        IdPeriodoLabel.Location = New System.Drawing.Point(40, 65)
        IdPeriodoLabel.Name = "IdPeriodoLabel"
        IdPeriodoLabel.Size = New System.Drawing.Size(59, 19)
        IdPeriodoLabel.TabIndex = 18
        IdPeriodoLabel.Text = "Periodo:"
        '
        'Horas_tbDataGridView
        '
        Me.Horas_tbDataGridView.AllowUserToAddRows = False
        Me.Horas_tbDataGridView.AllowUserToDeleteRows = False
        Me.Horas_tbDataGridView.AutoGenerateColumns = False
        Me.Horas_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Horas_tbDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Horas_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Horas_tbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Horas_tbDataGridView.DataSource = Me.Horas_tbBindingSource
        Me.Horas_tbDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Horas_tbDataGridView.Location = New System.Drawing.Point(24, 156)
        Me.Horas_tbDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Horas_tbDataGridView.Name = "Horas_tbDataGridView"
        Me.Horas_tbDataGridView.Size = New System.Drawing.Size(484, 254)
        Me.Horas_tbDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Horas"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Horas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idHoras"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idHoras"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'Horas_tbBindingSource
        '
        Me.Horas_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Horas_tb)
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(425, 85)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'IdPeriodoComboBox
        '
        Me.IdPeriodoComboBox.DataSource = Me.PeriodotbBindingSource
        Me.IdPeriodoComboBox.DisplayMember = "Nome_periodo"
        Me.IdPeriodoComboBox.FormattingEnabled = True
        Me.IdPeriodoComboBox.Location = New System.Drawing.Point(44, 87)
        Me.IdPeriodoComboBox.Name = "IdPeriodoComboBox"
        Me.IdPeriodoComboBox.Size = New System.Drawing.Size(216, 25)
        Me.IdPeriodoComboBox.TabIndex = 1
        Me.IdPeriodoComboBox.ValueMember = "idPeriodo"
        '
        'PeriodotbBindingSource
        '
        Me.PeriodotbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Periodo_tb)
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.P5lus_25px
        Me.Button1.Location = New System.Drawing.Point(262, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 25)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(20, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(246, 19)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Desenvolvedor: Osvaldo Artur Dionisio"
        '
        'HorasTextBox
        '
        Me.HorasTextBox.Location = New System.Drawing.Point(298, 87)
        Me.HorasTextBox.Mask = "90:00"
        Me.HorasTextBox.Name = "HorasTextBox"
        Me.HorasTextBox.Size = New System.Drawing.Size(42, 25)
        Me.HorasTextBox.TabIndex = 2
        Me.HorasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HorasTextBox.ValidatingType = GetType(Date)
        '
        'HorasTextBox1
        '
        Me.HorasTextBox1.Location = New System.Drawing.Point(376, 87)
        Me.HorasTextBox1.Mask = "90:00"
        Me.HorasTextBox1.Name = "HorasTextBox1"
        Me.HorasTextBox1.Size = New System.Drawing.Size(42, 25)
        Me.HorasTextBox1.TabIndex = 3
        Me.HorasTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HorasTextBox1.ValidatingType = GetType(Date)
        '
        'frmHoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 437)
        Me.Controls.Add(Me.HorasTextBox1)
        Me.Controls.Add(Me.HorasTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdPeriodoLabel)
        Me.Controls.Add(Me.IdPeriodoComboBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(HorasLabel)
        Me.Controls.Add(Me.Horas_tbDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmHoras"
        Me.Padding = New System.Windows.Forms.Padding(24, 79, 24, 27)
        Me.Resizable = False
        Me.Text = "Horas"
        CType(Me.Horas_tbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodotbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Horas_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Horas_tbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents IdPeriodoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PeriodotbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents HorasTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents HorasTextBox1 As System.Windows.Forms.MaskedTextBox
End Class
