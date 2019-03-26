<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResertarSenha
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
        Me.metroButton2 = New System.Windows.Forms.Button()
        Me.metroTextBox1 = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.metroButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'metroButton2
        '
        Me.metroButton2.Location = New System.Drawing.Point(343, 169)
        Me.metroButton2.Name = "metroButton2"
        Me.metroButton2.Size = New System.Drawing.Size(75, 28)
        Me.metroButton2.TabIndex = 14
        Me.metroButton2.Text = "Resertar"
        Me.metroButton2.UseVisualStyleBackColor = True
        Me.metroButton2.Visible = False
        '
        'metroTextBox1
        '
        Me.metroTextBox1.Location = New System.Drawing.Point(30, 169)
        Me.metroTextBox1.Name = "metroTextBox1"
        Me.metroTextBox1.Size = New System.Drawing.Size(307, 25)
        Me.metroTextBox1.TabIndex = 13
        Me.metroTextBox1.UseSystemPasswordChar = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(27, 146)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 19)
        Me.label5.TabIndex = 12
        Me.label5.Text = "Nova Senha"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(151, 111)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(45, 19)
        Me.label4.TabIndex = 8
        Me.label4.Text = "label1"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(77, 79)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 19)
        Me.label2.TabIndex = 9
        Me.label2.Text = "label1"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(25, 111)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(120, 19)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Nome do Usuario:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(26, 79)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 19)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Codº:"
        '
        'metroButton1
        '
        Me.metroButton1.Location = New System.Drawing.Point(343, 169)
        Me.metroButton1.Name = "metroButton1"
        Me.metroButton1.Size = New System.Drawing.Size(75, 28)
        Me.metroButton1.TabIndex = 15
        Me.metroButton1.Text = "Resertar"
        Me.metroButton1.UseVisualStyleBackColor = True
        Me.metroButton1.Visible = False
        '
        'frmResertarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 226)
        Me.Controls.Add(Me.metroButton1)
        Me.Controls.Add(Me.metroButton2)
        Me.Controls.Add(Me.metroTextBox1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmResertarSenha"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Resertar a Senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents metroButton1 As Button
    Public WithEvents metroButton2 As Button
    Private WithEvents metroTextBox1 As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
End Class
