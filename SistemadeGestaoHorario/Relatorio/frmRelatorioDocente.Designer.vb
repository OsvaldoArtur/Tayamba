<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorioDocente
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.View_HorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Faculdade_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.View_HorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Faculdade_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Docente"
        ReportDataSource1.Value = Me.View_HorarioBindingSource
        ReportDataSource2.Name = "Instituicao"
        ReportDataSource2.Value = Me.Faculdade_tbBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemadeGestaoHorario.ReportDocente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(20, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(960, 656)
        Me.ReportViewer1.TabIndex = 0
        '
        'View_HorarioBindingSource
        '
        Me.View_HorarioBindingSource.DataSource = GetType(SistemadeGestaoHorario.View_Horario)
        '
        'Faculdade_tbBindingSource
        '
        Me.Faculdade_tbBindingSource.DataSource = GetType(SistemadeGestaoHorario.Faculdade_tb)
        '
        'frmRelatorioDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 736)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmRelatorioDocente"
        Me.Resizable = False
        Me.Text = "Horario do  Docente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.View_HorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Faculdade_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents View_HorarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Faculdade_tbBindingSource As System.Windows.Forms.BindingSource
End Class
