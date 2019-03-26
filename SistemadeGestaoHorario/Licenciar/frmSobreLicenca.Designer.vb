<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSobreLicenca
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
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblLicenceType = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblProductKey = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(138, 105)
        Me.lblProductName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(15, 19)
        Me.lblProductName.TabIndex = 6
        Me.lblProductName.Text = "?"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(39, 132)
        Me.label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(89, 19)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Licence Type:"
        '
        'lblLicenceType
        '
        Me.lblLicenceType.AutoSize = True
        Me.lblLicenceType.Location = New System.Drawing.Point(138, 132)
        Me.lblLicenceType.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblLicenceType.Name = "lblLicenceType"
        Me.lblLicenceType.Size = New System.Drawing.Size(15, 19)
        Me.lblLicenceType.TabIndex = 8
        Me.lblLicenceType.Text = "?"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(28, 105)
        Me.label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 19)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Product Name:"
        '
        'lblProductKey
        '
        Me.lblProductKey.AutoSize = True
        Me.lblProductKey.Location = New System.Drawing.Point(138, 159)
        Me.lblProductKey.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblProductKey.Name = "lblProductKey"
        Me.lblProductKey.Size = New System.Drawing.Size(15, 19)
        Me.lblProductKey.TabIndex = 10
        Me.lblProductKey.Text = "?"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(138, 78)
        Me.lblProductID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(15, 19)
        Me.lblProductID.TabIndex = 12
        Me.lblProductID.Text = "?"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(42, 159)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(86, 19)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Product Key:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(48, 78)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 19)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Produto ID:"
        '
        'frmSobreLicenca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 239)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lblLicenceType)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.lblProductKey)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmSobreLicenca"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Sobre Licenca"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblProductName As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents lblLicenceType As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents lblProductKey As System.Windows.Forms.Label
    Private WithEvents lblProductID As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
