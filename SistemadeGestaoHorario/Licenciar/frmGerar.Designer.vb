<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGerar
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
        Me.cbLicenceType = New System.Windows.Forms.ComboBox()
        Me.btnGenerete = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtProductKey = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtExperienceday = New System.Windows.Forms.NumericUpDown()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.txtExperienceday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbLicenceType
        '
        Me.cbLicenceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLicenceType.FormattingEnabled = True
        Me.cbLicenceType.Items.AddRange(New Object() {"Trial"})
        Me.cbLicenceType.Location = New System.Drawing.Point(143, 232)
        Me.cbLicenceType.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLicenceType.Name = "cbLicenceType"
        Me.cbLicenceType.Size = New System.Drawing.Size(142, 25)
        Me.cbLicenceType.TabIndex = 4
        '
        'btnGenerete
        '
        Me.btnGenerete.Location = New System.Drawing.Point(350, 331)
        Me.btnGenerete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerete.Name = "btnGenerete"
        Me.btnGenerete.Size = New System.Drawing.Size(92, 30)
        Me.btnGenerete.TabIndex = 6
        Me.btnGenerete.Text = "Gerar Key"
        Me.btnGenerete.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(143, 102)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(312, 25)
        Me.txtUsuario.TabIndex = 1
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(27, 268)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(108, 19)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Experience days:"
        '
        'txtProductKey
        '
        Me.txtProductKey.Location = New System.Drawing.Point(143, 298)
        Me.txtProductKey.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductKey.Name = "txtProductKey"
        Me.txtProductKey.ReadOnly = True
        Me.txtProductKey.Size = New System.Drawing.Size(399, 25)
        Me.txtProductKey.TabIndex = 9
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(46, 238)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(89, 19)
        Me.label4.TabIndex = 5
        Me.label4.Text = "Licence Type:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(49, 301)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(86, 19)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Product Key:"
        '
        'txtProductId
        '
        Me.txtProductId.Location = New System.Drawing.Point(143, 199)
        Me.txtProductId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.ReadOnly = True
        Me.txtProductId.Size = New System.Drawing.Size(399, 25)
        Me.txtProductId.TabIndex = 10
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(55, 202)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 19)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Produto ID:"
        '
        'txtExperienceday
        '
        Me.txtExperienceday.Location = New System.Drawing.Point(143, 266)
        Me.txtExperienceday.Name = "txtExperienceday"
        Me.txtExperienceday.Size = New System.Drawing.Size(120, 25)
        Me.txtExperienceday.TabIndex = 5
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(143, 135)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(312, 25)
        Me.txtSenha.TabIndex = 2
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Nome Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Senha Usuario:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(463, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 58)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Activar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(450, 331)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 30)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Licenciar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmGerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 425)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtExperienceday)
        Me.Controls.Add(Me.cbLicenceType)
        Me.Controls.Add(Me.btnGenerete)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtProductKey)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtProductId)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmGerar"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Gerar Key"
        CType(Me.txtExperienceday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cbLicenceType As System.Windows.Forms.ComboBox
    Private WithEvents btnGenerete As System.Windows.Forms.Button
    Private WithEvents txtUsuario As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtProductKey As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtProductId As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents txtExperienceday As System.Windows.Forms.NumericUpDown
    Private WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Button2 As System.Windows.Forms.Button
End Class
