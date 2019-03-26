<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemana
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
        Dim DiaLabel As System.Windows.Forms.Label
        Me.Semana_tbDataGridView = New System.Windows.Forms.DataGridView()
        Me.DiaTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semana_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        DiaLabel = New System.Windows.Forms.Label()
        CType(Me.Semana_tbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Semana_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiaLabel
        '
        DiaLabel.AutoSize = True
        DiaLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DiaLabel.Location = New System.Drawing.Point(28, 87)
        DiaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DiaLabel.Name = "DiaLabel"
        DiaLabel.Size = New System.Drawing.Size(32, 19)
        DiaLabel.TabIndex = 2
        DiaLabel.Text = "Dia:"
        '
        'Semana_tbDataGridView
        '
        Me.Semana_tbDataGridView.AllowUserToAddRows = False
        Me.Semana_tbDataGridView.AllowUserToDeleteRows = False
        Me.Semana_tbDataGridView.AutoGenerateColumns = False
        Me.Semana_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Semana_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Semana_tbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Semana_tbDataGridView.DataSource = Me.Semana_tbBindingSource
        Me.Semana_tbDataGridView.Location = New System.Drawing.Point(32, 116)
        Me.Semana_tbDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Semana_tbDataGridView.Name = "Semana_tbDataGridView"
        Me.Semana_tbDataGridView.ReadOnly = True
        Me.Semana_tbDataGridView.Size = New System.Drawing.Size(350, 221)
        Me.Semana_tbDataGridView.TabIndex = 1
        '
        'DiaTextBox
        '
        Me.DiaTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiaTextBox.Location = New System.Drawing.Point(78, 83)
        Me.DiaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DiaTextBox.Name = "DiaTextBox"
        Me.DiaTextBox.Size = New System.Drawing.Size(223, 25)
        Me.DiaTextBox.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(309, 81)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 27)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(28, 341)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(246, 19)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Desenvolvedor: Osvaldo Artur Dionisio"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idDia"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idDia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dia"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Semana_tbBindingSource
        '
        Me.Semana_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Semana_tb)
        '
        'frmSemana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 368)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(DiaLabel)
        Me.Controls.Add(Me.DiaTextBox)
        Me.Controls.Add(Me.Semana_tbDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmSemana"
        Me.Padding = New System.Windows.Forms.Padding(24, 79, 24, 27)
        Me.Resizable = False
        Me.Text = "Semana"
        CType(Me.Semana_tbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Semana_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Semana_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Semana_tbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
