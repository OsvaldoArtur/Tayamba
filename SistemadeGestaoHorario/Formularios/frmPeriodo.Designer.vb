<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeriodo
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
        Dim Nome_periodoLabel As System.Windows.Forms.Label
        Me.Periodo_tbDataGridView = New System.Windows.Forms.DataGridView()
        Me.Nome_periodoTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Periodo_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HorastbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Nome_periodoLabel = New System.Windows.Forms.Label()
        CType(Me.Periodo_tbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Periodo_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorastbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nome_periodoLabel
        '
        Nome_periodoLabel.AutoSize = True
        Nome_periodoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_periodoLabel.Location = New System.Drawing.Point(28, 86)
        Nome_periodoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nome_periodoLabel.Name = "Nome_periodoLabel"
        Nome_periodoLabel.Size = New System.Drawing.Size(100, 19)
        Nome_periodoLabel.TabIndex = 6
        Nome_periodoLabel.Text = "Nome periodo:"
        '
        'Periodo_tbDataGridView
        '
        Me.Periodo_tbDataGridView.AllowUserToAddRows = False
        Me.Periodo_tbDataGridView.AllowUserToDeleteRows = False
        Me.Periodo_tbDataGridView.AutoGenerateColumns = False
        Me.Periodo_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Periodo_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Periodo_tbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3})
        Me.Periodo_tbDataGridView.DataSource = Me.Periodo_tbBindingSource
        Me.Periodo_tbDataGridView.Location = New System.Drawing.Point(32, 152)
        Me.Periodo_tbDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Periodo_tbDataGridView.Name = "Periodo_tbDataGridView"
        Me.Periodo_tbDataGridView.ReadOnly = True
        Me.Periodo_tbDataGridView.Size = New System.Drawing.Size(350, 146)
        Me.Periodo_tbDataGridView.TabIndex = 1
        '
        'Nome_periodoTextBox
        '
        Me.Nome_periodoTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_periodoTextBox.Location = New System.Drawing.Point(136, 83)
        Me.Nome_periodoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Nome_periodoTextBox.Name = "Nome_periodoTextBox"
        Me.Nome_periodoTextBox.Size = New System.Drawing.Size(246, 25)
        Me.Nome_periodoTextBox.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(304, 116)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 28)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idPeriodo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idPeriodo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nome_periodo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nome_periodo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Periodo_tbBindingSource
        '
        Me.Periodo_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Periodo_tb)
        '
        'HorastbBindingSource
        '
        Me.HorastbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Horas_tb)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(28, 302)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(246, 19)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Desenvolvedor: Osvaldo Artur Dionisio"
        '
        'frmPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 330)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Nome_periodoLabel)
        Me.Controls.Add(Me.Nome_periodoTextBox)
        Me.Controls.Add(Me.Periodo_tbDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmPeriodo"
        Me.Padding = New System.Windows.Forms.Padding(24, 79, 24, 27)
        Me.Resizable = False
        Me.Text = "Periodo"
        CType(Me.Periodo_tbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Periodo_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorastbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Periodo_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Periodo_tbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Nome_periodoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorastbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
