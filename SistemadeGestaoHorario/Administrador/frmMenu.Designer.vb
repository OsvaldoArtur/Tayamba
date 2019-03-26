<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.sairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.novoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.recuperarSenhasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.detalhesDaInstituicaoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuStrip1.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuToolStripMenuItem, Me.novoUsuarioToolStripMenuItem, Me.recuperarSenhasToolStripMenuItem, Me.detalhesDaInstituicaoToolStripMenuItem, Me.sobreToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(23, 78)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.menuStrip1.Size = New System.Drawing.Size(760, 57)
        Me.menuStrip1.TabIndex = 3
        Me.menuStrip1.Text = "menuStrip1"
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
        Me.statusStrip1.Location = New System.Drawing.Point(23, 456)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(760, 22)
        Me.statusStrip1.TabIndex = 4
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(118, 17)
        Me.toolStripStatusLabel1.Text = "toolStripStatusLabel1"
        '
        'menuToolStripMenuItem
        '
        Me.menuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1, Me.sairToolStripMenuItem})
        Me.menuToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.icons8_Menu_30px
        Me.menuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuToolStripMenuItem.Name = "menuToolStripMenuItem"
        Me.menuToolStripMenuItem.Size = New System.Drawing.Size(57, 53)
        Me.menuToolStripMenuItem.Text = "Menu"
        Me.menuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(158, 6)
        '
        'sairToolStripMenuItem
        '
        Me.sairToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.icons8_Cancel_25px
        Me.sairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.sairToolStripMenuItem.Name = "sairToolStripMenuItem"
        Me.sairToolStripMenuItem.Size = New System.Drawing.Size(161, 32)
        Me.sairToolStripMenuItem.Text = "Sair"
        '
        'novoUsuarioToolStripMenuItem
        '
        Me.novoUsuarioToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.icons8_User_Menu_Male_30px
        Me.novoUsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.novoUsuarioToolStripMenuItem.Name = "novoUsuarioToolStripMenuItem"
        Me.novoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(140, 53)
        Me.novoUsuarioToolStripMenuItem.Text = "Gestao de Usuarios"
        Me.novoUsuarioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'recuperarSenhasToolStripMenuItem
        '
        Me.recuperarSenhasToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.icons8_Work_30px
        Me.recuperarSenhasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.recuperarSenhasToolStripMenuItem.Name = "recuperarSenhasToolStripMenuItem"
        Me.recuperarSenhasToolStripMenuItem.Size = New System.Drawing.Size(187, 53)
        Me.recuperarSenhasToolStripMenuItem.Text = "Gestao de Administradores"
        Me.recuperarSenhasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'detalhesDaInstituicaoToolStripMenuItem
        '
        Me.detalhesDaInstituicaoToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.icons8_Autograph_30px
        Me.detalhesDaInstituicaoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.detalhesDaInstituicaoToolStripMenuItem.Name = "detalhesDaInstituicaoToolStripMenuItem"
        Me.detalhesDaInstituicaoToolStripMenuItem.Size = New System.Drawing.Size(160, 53)
        Me.detalhesDaInstituicaoToolStripMenuItem.Text = "Detalhes da Instituicao"
        Me.detalhesDaInstituicaoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'sobreToolStripMenuItem
        '
        Me.sobreToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.icons8_Info_30px_3
        Me.sobreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem"
        Me.sobreToolStripMenuItem.Size = New System.Drawing.Size(56, 53)
        Me.sobreToolStripMenuItem.Text = "Sobre"
        Me.sobreToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Location = New System.Drawing.Point(23, 78)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(760, 400)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 5
        Me.pictureBox1.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 504)
        Me.ControlBox = False
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmMenu"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Menu do Administrador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents menuToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem1 As ToolStripSeparator
    Private WithEvents sairToolStripMenuItem As ToolStripMenuItem
    Private WithEvents novoUsuarioToolStripMenuItem As ToolStripMenuItem
    Private WithEvents recuperarSenhasToolStripMenuItem As ToolStripMenuItem
    Private WithEvents detalhesDaInstituicaoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents sobreToolStripMenuItem As ToolStripMenuItem
    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents toolStripStatusLabel1 As ToolStripStatusLabel
    Private WithEvents pictureBox1 As PictureBox
End Class
