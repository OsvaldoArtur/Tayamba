<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocente
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
        Dim Formacao_AcademicaLabel As System.Windows.Forms.Label
        Dim IdDepartamentoLabel As System.Windows.Forms.Label
        Dim Nome_DocenteLabel As System.Windows.Forms.Label
        Me.Docente_tbDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Docente_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nome_DocenteTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DepartamentotbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Formacao_AcademicaTextBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Formacao_AcademicaLabel = New System.Windows.Forms.Label()
        IdDepartamentoLabel = New System.Windows.Forms.Label()
        Nome_DocenteLabel = New System.Windows.Forms.Label()
        CType(Me.Docente_tbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Docente_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentotbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Formacao_AcademicaLabel
        '
        Formacao_AcademicaLabel.AutoSize = True
        Formacao_AcademicaLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Formacao_AcademicaLabel.Location = New System.Drawing.Point(97, 61)
        Formacao_AcademicaLabel.Name = "Formacao_AcademicaLabel"
        Formacao_AcademicaLabel.Size = New System.Drawing.Size(141, 19)
        Formacao_AcademicaLabel.TabIndex = 2
        Formacao_AcademicaLabel.Text = "Formacao Academica:"
        Formacao_AcademicaLabel.Visible = False
        '
        'IdDepartamentoLabel
        '
        IdDepartamentoLabel.AutoSize = True
        IdDepartamentoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdDepartamentoLabel.Location = New System.Drawing.Point(133, 28)
        IdDepartamentoLabel.Name = "IdDepartamentoLabel"
        IdDepartamentoLabel.Size = New System.Drawing.Size(101, 19)
        IdDepartamentoLabel.TabIndex = 4
        IdDepartamentoLabel.Text = "Departamento:"
        IdDepartamentoLabel.Visible = False
        '
        'Nome_DocenteLabel
        '
        Nome_DocenteLabel.AutoSize = True
        Nome_DocenteLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_DocenteLabel.Location = New System.Drawing.Point(26, 95)
        Nome_DocenteLabel.Name = "Nome_DocenteLabel"
        Nome_DocenteLabel.Size = New System.Drawing.Size(104, 19)
        Nome_DocenteLabel.TabIndex = 8
        Nome_DocenteLabel.Text = "Nome Docente:"
        '
        'Docente_tbDataGridView
        '
        Me.Docente_tbDataGridView.AllowUserToAddRows = False
        Me.Docente_tbDataGridView.AllowUserToDeleteRows = False
        Me.Docente_tbDataGridView.AutoGenerateColumns = False
        Me.Docente_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Docente_tbDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Docente_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Docente_tbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Docente_tbDataGridView.DataSource = Me.Docente_tbBindingSource
        Me.Docente_tbDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Docente_tbDataGridView.Location = New System.Drawing.Point(23, 149)
        Me.Docente_tbDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Docente_tbDataGridView.Name = "Docente_tbDataGridView"
        Me.Docente_tbDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Docente_tbDataGridView.Size = New System.Drawing.Size(544, 279)
        Me.Docente_tbDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idDocente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idDocente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome_Docente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome Docente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Formacao_Academica"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Formacao_Academica"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "idDepartamento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "idDepartamento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'Docente_tbBindingSource
        '
        Me.Docente_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Docente_tb)
        '
        'Nome_DocenteTextBox
        '
        Me.Nome_DocenteTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_DocenteTextBox.Location = New System.Drawing.Point(136, 92)
        Me.Nome_DocenteTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_DocenteTextBox.Name = "Nome_DocenteTextBox"
        Me.Nome_DocenteTextBox.Size = New System.Drawing.Size(316, 25)
        Me.Nome_DocenteTextBox.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Save_25px
        Me.Button2.Location = New System.Drawing.Point(458, 88)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 31)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salvar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DepartamentotbBindingSource
        Me.ComboBox1.DisplayMember = "Nome_Departamento"
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(243, 28)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 25)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.ValueMember = "idDepartamento"
        Me.ComboBox1.Visible = False
        '
        'DepartamentotbBindingSource
        '
        Me.DepartamentotbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Departamento_tb)
        '
        'Formacao_AcademicaTextBox
        '
        Me.Formacao_AcademicaTextBox.FormattingEnabled = True
        Me.Formacao_AcademicaTextBox.Items.AddRange(New Object() {"Primario", "Secundario", "Medio", "Tecnico", "Licenciado", "Enginheiro", "Mestrado", "PHD"})
        Me.Formacao_AcademicaTextBox.Location = New System.Drawing.Point(244, 60)
        Me.Formacao_AcademicaTextBox.Name = "Formacao_AcademicaTextBox"
        Me.Formacao_AcademicaTextBox.Size = New System.Drawing.Size(208, 25)
        Me.Formacao_AcademicaTextBox.TabIndex = 2
        Me.Formacao_AcademicaTextBox.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.P5lus_25px
        Me.Button1.Location = New System.Drawing.Point(458, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 25)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(19, 432)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(246, 19)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Desenvolvedor: Osvaldo Artur Dionisio"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Close_Window_25px
        Me.Button3.Location = New System.Drawing.Point(458, 56)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 31)
        Me.Button3.TabIndex = 24
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'frmDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 454)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Formacao_AcademicaTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Formacao_AcademicaLabel)
        Me.Controls.Add(IdDepartamentoLabel)
        Me.Controls.Add(Nome_DocenteLabel)
        Me.Controls.Add(Me.Nome_DocenteTextBox)
        Me.Controls.Add(Me.Docente_tbDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmDocente"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Docente"
        CType(Me.Docente_tbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Docente_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentotbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Docente_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Docente_tbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Nome_DocenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DepartamentotbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Formacao_AcademicaTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
