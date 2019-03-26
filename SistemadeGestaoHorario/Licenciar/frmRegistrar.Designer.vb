<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrar
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtProductKey = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Location = New System.Drawing.Point(538, 154)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(43, 28)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtProductKey
        '
        Me.txtProductKey.Enabled = False
        Me.txtProductKey.Location = New System.Drawing.Point(116, 119)
        Me.txtProductKey.Margin = New System.Windows.Forms.Padding(5)
        Me.txtProductKey.Name = "txtProductKey"
        Me.txtProductKey.Size = New System.Drawing.Size(465, 25)
        Me.txtProductKey.TabIndex = 10
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(28, 122)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(86, 19)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Product Key:"
        '
        'txtProductId
        '
        Me.txtProductId.Enabled = False
        Me.txtProductId.Location = New System.Drawing.Point(116, 84)
        Me.txtProductId.Margin = New System.Windows.Forms.Padding(5)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(465, 25)
        Me.txtProductId.TabIndex = 11
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(35, 87)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 19)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Produto ID:"
        '
        'frmRegistrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 214)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtProductKey)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtProductId)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmRegistrar"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Registrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnOK As System.Windows.Forms.Button
    Private WithEvents txtProductKey As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtProductId As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
