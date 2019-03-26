<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamento
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
        Dim Nome_DepartamentoLabel As System.Windows.Forms.Label
        Me.Departamento_tbDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nome_DepartamentoTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Nome_DepartamentoLabel = New System.Windows.Forms.Label()
        CType(Me.Departamento_tbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Departamento_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nome_DepartamentoLabel
        '
        Nome_DepartamentoLabel.AutoSize = True
        Nome_DepartamentoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_DepartamentoLabel.Location = New System.Drawing.Point(26, 82)
        Nome_DepartamentoLabel.Name = "Nome_DepartamentoLabel"
        Nome_DepartamentoLabel.Size = New System.Drawing.Size(142, 19)
        Nome_DepartamentoLabel.TabIndex = 4
        Nome_DepartamentoLabel.Text = "Nome Departamento:"
        '
        'Departamento_tbDataGridView
        '
        Me.Departamento_tbDataGridView.AllowUserToAddRows = False
        Me.Departamento_tbDataGridView.AllowUserToDeleteRows = False
        Me.Departamento_tbDataGridView.AutoGenerateColumns = False
        Me.Departamento_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Departamento_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Departamento_tbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Departamento_tbDataGridView.DataSource = Me.Departamento_tbBindingSource
        Me.Departamento_tbDataGridView.Location = New System.Drawing.Point(26, 154)
        Me.Departamento_tbDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Departamento_tbDataGridView.Name = "Departamento_tbDataGridView"
        Me.Departamento_tbDataGridView.ReadOnly = True
        Me.Departamento_tbDataGridView.Size = New System.Drawing.Size(346, 266)
        Me.Departamento_tbDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idDepartamento"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idDepartamento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome_Departamento"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome_Departamento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Departamento_tbBindingSource
        '
        Me.Departamento_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Departamento_tb)
        '
        'Nome_DepartamentoTextBox
        '
        Me.Nome_DepartamentoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_DepartamentoTextBox.Location = New System.Drawing.Point(174, 82)
        Me.Nome_DepartamentoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nome_DepartamentoTextBox.Name = "Nome_DepartamentoTextBox"
        Me.Nome_DepartamentoTextBox.Size = New System.Drawing.Size(198, 25)
        Me.Nome_DepartamentoTextBox.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(294, 115)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 31)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(26, 424)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(246, 19)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Desenvolvedor: Osvaldo Artur Dionisio"
        '
        'frmDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 450)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Nome_DepartamentoLabel)
        Me.Controls.Add(Me.Nome_DepartamentoTextBox)
        Me.Controls.Add(Me.Departamento_tbDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmDepartamento"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Departamento"
        CType(Me.Departamento_tbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Departamento_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Departamento_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Departamento_tbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Nome_DepartamentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
