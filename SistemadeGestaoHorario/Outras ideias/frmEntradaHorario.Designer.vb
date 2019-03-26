<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntradaHorario
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuracaoCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CusostbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CusostbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCursoDataGridViewTextBoxColumn, Me.NomeCursoDataGridViewTextBoxColumn, Me.DuracaoCursoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CusostbBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(23, 78)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(715, 448)
        Me.DataGridView1.TabIndex = 0
        '
        'IdCursoDataGridViewTextBoxColumn
        '
        Me.IdCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso"
        Me.IdCursoDataGridViewTextBoxColumn.HeaderText = "idCurso"
        Me.IdCursoDataGridViewTextBoxColumn.Name = "IdCursoDataGridViewTextBoxColumn"
        Me.IdCursoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCursoDataGridViewTextBoxColumn.Visible = False
        '
        'NomeCursoDataGridViewTextBoxColumn
        '
        Me.NomeCursoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Curso"
        Me.NomeCursoDataGridViewTextBoxColumn.HeaderText = "Nome do Curso"
        Me.NomeCursoDataGridViewTextBoxColumn.Name = "NomeCursoDataGridViewTextBoxColumn"
        Me.NomeCursoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DuracaoCursoDataGridViewTextBoxColumn
        '
        Me.DuracaoCursoDataGridViewTextBoxColumn.DataPropertyName = "Duracao_Curso"
        Me.DuracaoCursoDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.DuracaoCursoDataGridViewTextBoxColumn.HeaderText = "Duracao do Curso"
        Me.DuracaoCursoDataGridViewTextBoxColumn.Name = "DuracaoCursoDataGridViewTextBoxColumn"
        Me.DuracaoCursoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CusostbBindingSource
        '
        Me.CusostbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Cusos_tb)
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.P5lus_25px
        Me.Button1.Location = New System.Drawing.Point(359, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(19, 530)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(378, 19)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Clica duas vezes sobre a grelha para atribuir o horario."
        '
        'frmEntradaHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 552)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmEntradaHorario"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Seleciona o curso"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CusostbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdCursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DuracaoCursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CusostbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
