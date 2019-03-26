Public Class frmRelatorioDocente
    Public Property idDocente As Integer
    Public Property Semestre As Integer
    Public Property Ano As Integer
    Public Property idPeriodo As Integer
    Dim si As New GestHorarioEntities()
    Private Sub frmRelatorioDocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            View_HorarioBindingSource.DataSource = (From d In si.View_Horario Where d.idDocente = idDocente AndAlso d.Semestre = Semestre AndAlso d.Ano = Ano AndAlso d.idPeriodo = idPeriodo Order By d.idDia Ascending Select d).ToList()
            Faculdade_tbBindingSource.DataSource = si.Faculdade_tb.ToList()
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
            ReportViewer1.ZoomPercent = 95
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class