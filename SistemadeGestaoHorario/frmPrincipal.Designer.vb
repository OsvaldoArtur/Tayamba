<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadeiraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeridoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriarHorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriarHorarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeHorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorarioDoDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirHorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorarioDoDocenteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripSplitButton()
        Me.GerarLicencaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.LicenciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.EstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.CriarHorarioToolStripMenuItem, Me.SobreToolStripMenuItem, Me.HorarioDoDocenteToolStripMenuItem1, Me.HorariosToolStripMenuItem, Me.SobreToolStripMenuItem2})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(802, 78)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoUsuarioToolStripMenuItem, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1, Me.SobreToolStripMenuItem1, Me.UsuarioToolStripMenuItem, Me.ToolStripMenuItem2, Me.SairToolStripMenuItem})
        Me.MenuToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Start_Menu_48px
        Me.MenuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 74)
        Me.MenuToolStripMenuItem.Text = "Menu"
        Me.MenuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'NovoUsuarioToolStripMenuItem
        '
        Me.NovoUsuarioToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.AddUserGroupWomanMan_25px
        Me.NovoUsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoUsuarioToolStripMenuItem.Name = "NovoUsuarioToolStripMenuItem"
        Me.NovoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(177, 32)
        Me.NovoUsuarioToolStripMenuItem.Text = "Novo Usuario"
        Me.NovoUsuarioToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.User_Credentials_25px
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(177, 32)
        Me.ToolStripMenuItem3.Text = "Mudar Senha"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 32)
        Me.ToolStripMenuItem1.Text = "Faculdade"
        Me.ToolStripMenuItem1.Visible = False
        '
        'SobreToolStripMenuItem1
        '
        Me.SobreToolStripMenuItem1.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.About_25px
        Me.SobreToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SobreToolStripMenuItem1.Name = "SobreToolStripMenuItem1"
        Me.SobreToolStripMenuItem1.Size = New System.Drawing.Size(177, 32)
        Me.SobreToolStripMenuItem1.Text = "Sobre"
        Me.SobreToolStripMenuItem1.Visible = False
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(177, 32)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        Me.UsuarioToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Cancel_25px
        Me.SairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(177, 32)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentoToolStripMenuItem, Me.DocenteToolStripMenuItem, Me.CursoToolStripMenuItem, Me.CadeiraToolStripMenuItem, Me.SemanaToolStripMenuItem, Me.HorasToolStripMenuItem, Me.PeridoToolStripMenuItem, Me.SalaToolStripMenuItem})
        Me.RegistroToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Edit_Property_48px
        Me.RegistroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(76, 74)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        Me.RegistroToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DepartamentoToolStripMenuItem
        '
        Me.DepartamentoToolStripMenuItem.Name = "DepartamentoToolStripMenuItem"
        Me.DepartamentoToolStripMenuItem.Size = New System.Drawing.Size(184, 32)
        Me.DepartamentoToolStripMenuItem.Text = "Departamento"
        Me.DepartamentoToolStripMenuItem.Visible = False
        '
        'DocenteToolStripMenuItem
        '
        Me.DocenteToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Classroom_25px
        Me.DocenteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DocenteToolStripMenuItem.Name = "DocenteToolStripMenuItem"
        Me.DocenteToolStripMenuItem.Size = New System.Drawing.Size(184, 32)
        Me.DocenteToolStripMenuItem.Text = "Docente "
        '
        'CursoToolStripMenuItem
        '
        Me.CursoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CursoToolStripMenuItem.Name = "CursoToolStripMenuItem"
        Me.CursoToolStripMenuItem.Size = New System.Drawing.Size(184, 32)
        Me.CursoToolStripMenuItem.Text = "Curso"
        Me.CursoToolStripMenuItem.Visible = False
        '
        'CadeiraToolStripMenuItem
        '
        Me.CadeiraToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Course_25px
        Me.CadeiraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CadeiraToolStripMenuItem.Name = "CadeiraToolStripMenuItem"
        Me.CadeiraToolStripMenuItem.Size = New System.Drawing.Size(184, 32)
        Me.CadeiraToolStripMenuItem.Text = "Cadeira"
        '
        'SemanaToolStripMenuItem
        '
        Me.SemanaToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Week_View_25px
        Me.SemanaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SemanaToolStripMenuItem.Name = "SemanaToolStripMenuItem"
        Me.SemanaToolStripMenuItem.Size = New System.Drawing.Size(184, 32)
        Me.SemanaToolStripMenuItem.Text = "Semana"
        Me.SemanaToolStripMenuItem.Visible = False
        '
        'HorasToolStripMenuItem
        '
        Me.HorasToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Clock_25px
        Me.HorasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HorasToolStripMenuItem.Name = "HorasToolStripMenuItem"
        Me.HorasToolStripMenuItem.Size = New System.Drawing.Size(184, 32)
        Me.HorasToolStripMenuItem.Text = "Horas"
        '
        'PeridoToolStripMenuItem
        '
        Me.PeridoToolStripMenuItem.Name = "PeridoToolStripMenuItem"
        Me.PeridoToolStripMenuItem.Size = New System.Drawing.Size(184, 32)
        Me.PeridoToolStripMenuItem.Text = "Perido"
        Me.PeridoToolStripMenuItem.Visible = False
        '
        'SalaToolStripMenuItem
        '
        Me.SalaToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Class_25px
        Me.SalaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalaToolStripMenuItem.Name = "SalaToolStripMenuItem"
        Me.SalaToolStripMenuItem.Size = New System.Drawing.Size(184, 32)
        Me.SalaToolStripMenuItem.Text = "Sala"
        '
        'CriarHorarioToolStripMenuItem
        '
        Me.CriarHorarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriarHorarioToolStripMenuItem1, Me.ListaDeHorarioToolStripMenuItem, Me.HorarioDoDocenteToolStripMenuItem, Me.ImprimirHorarioToolStripMenuItem})
        Me.CriarHorarioToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Property_Time_48px
        Me.CriarHorarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CriarHorarioToolStripMenuItem.Name = "CriarHorarioToolStripMenuItem"
        Me.CriarHorarioToolStripMenuItem.Size = New System.Drawing.Size(72, 74)
        Me.CriarHorarioToolStripMenuItem.Text = "Horario"
        Me.CriarHorarioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CriarHorarioToolStripMenuItem1
        '
        Me.CriarHorarioToolStripMenuItem1.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Cloc5k_25px
        Me.CriarHorarioToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CriarHorarioToolStripMenuItem1.Name = "CriarHorarioToolStripMenuItem1"
        Me.CriarHorarioToolStripMenuItem1.Size = New System.Drawing.Size(220, 32)
        Me.CriarHorarioToolStripMenuItem1.Text = "Criar Horario"
        Me.CriarHorarioToolStripMenuItem1.Visible = False
        '
        'ListaDeHorarioToolStripMenuItem
        '
        Me.ListaDeHorarioToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Property_T4ime_25px
        Me.ListaDeHorarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ListaDeHorarioToolStripMenuItem.Name = "ListaDeHorarioToolStripMenuItem"
        Me.ListaDeHorarioToolStripMenuItem.Size = New System.Drawing.Size(220, 32)
        Me.ListaDeHorarioToolStripMenuItem.Text = "Criar Horario/Lista"
        Me.ListaDeHorarioToolStripMenuItem.Visible = False
        '
        'HorarioDoDocenteToolStripMenuItem
        '
        Me.HorarioDoDocenteToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Classroom_25px
        Me.HorarioDoDocenteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HorarioDoDocenteToolStripMenuItem.Name = "HorarioDoDocenteToolStripMenuItem"
        Me.HorarioDoDocenteToolStripMenuItem.Size = New System.Drawing.Size(220, 32)
        Me.HorarioDoDocenteToolStripMenuItem.Text = "Horario do Docente"
        Me.HorarioDoDocenteToolStripMenuItem.Visible = False
        '
        'ImprimirHorarioToolStripMenuItem
        '
        Me.ImprimirHorarioToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Print_25px
        Me.ImprimirHorarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImprimirHorarioToolStripMenuItem.Name = "ImprimirHorarioToolStripMenuItem"
        Me.ImprimirHorarioToolStripMenuItem.Size = New System.Drawing.Size(220, 32)
        Me.ImprimirHorarioToolStripMenuItem.Text = "Imprimir Horario"
        Me.ImprimirHorarioToolStripMenuItem.Visible = False
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.About_25px
        Me.SobreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(85, 74)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        Me.SobreToolStripMenuItem.Visible = False
        '
        'HorarioDoDocenteToolStripMenuItem1
        '
        Me.HorarioDoDocenteToolStripMenuItem1.AutoToolTip = True
        Me.HorarioDoDocenteToolStripMenuItem1.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Classroom_50px
        Me.HorarioDoDocenteToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HorarioDoDocenteToolStripMenuItem1.Name = "HorarioDoDocenteToolStripMenuItem1"
        Me.HorarioDoDocenteToolStripMenuItem1.Size = New System.Drawing.Size(95, 74)
        Me.HorarioDoDocenteToolStripMenuItem1.Text = "H. Docente"
        Me.HorarioDoDocenteToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Print_50px
        Me.HorariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(78, 74)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        Me.HorariosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SobreToolStripMenuItem2
        '
        Me.SobreToolStripMenuItem2.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Info_48px1
        Me.SobreToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SobreToolStripMenuItem2.Name = "SobreToolStripMenuItem2"
        Me.SobreToolStripMenuItem2.Size = New System.Drawing.Size(60, 74)
        Me.SobreToolStripMenuItem2.Text = "Sobre"
        Me.SobreToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(20, 452)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(802, 24)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(140, 19)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerarLicencaToolStripMenuItem, Me.ToolStripMenuItem4, Me.LicenciarToolStripMenuItem, Me.ToolStripMenuItem5, Me.EstadoToolStripMenuItem})
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripStatusLabel4.Text = "Registrar"
        Me.ToolStripStatusLabel4.Visible = False
        '
        'GerarLicencaToolStripMenuItem
        '
        Me.GerarLicencaToolStripMenuItem.Name = "GerarLicencaToolStripMenuItem"
        Me.GerarLicencaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.GerarLicencaToolStripMenuItem.Text = "Gerar Licenca"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(142, 6)
        '
        'LicenciarToolStripMenuItem
        '
        Me.LicenciarToolStripMenuItem.Name = "LicenciarToolStripMenuItem"
        Me.LicenciarToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.LicenciarToolStripMenuItem.Text = "Licenciar"
        Me.LicenciarToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(142, 6)
        '
        'EstadoToolStripMenuItem
        '
        Me.EstadoToolStripMenuItem.Name = "EstadoToolStripMenuItem"
        Me.EstadoToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EstadoToolStripMenuItem.Text = "Estado"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(0, 19)
        Me.ToolStripStatusLabel5.Visible = False
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip2.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip2.Location = New System.Drawing.Point(20, 138)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip2.Size = New System.Drawing.Size(802, 24)
        Me.StatusStrip2.TabIndex = 3
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(140, 19)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.DoubleClickEnabled = True
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToolStripStatusLabel3.Image = Global.SistemadeGestaoHorario.My.Resources.Resources.Edit_File_25px
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(16, 19)
        Me.ToolStripStatusLabel3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(23, 165)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(802, 338)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(842, 496)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmPrincipal"
        Me.Resizable = False
        Me.Text = "Bem Vindo ao Tayamba"
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadeiraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeridoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriarHorarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriarHorarioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeHorarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorarioDoDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirHorarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents HorarioDoDocenteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents GerarLicencaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LicenciarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EstadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NovoUsuarioToolStripMenuItem As ToolStripMenuItem
End Class
