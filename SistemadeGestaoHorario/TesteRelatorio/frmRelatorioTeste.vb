Public Class frmRelatorioTeste
    Dim si As New GestHorarioEntities()

    Public Property idHorario As Integer
    Public Property idcurso As Integer


    Private Sub frmRelatorioTeste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '    View_HorarioBindingSource.DataSource = (From d In si.View_Horario Where Select d).ToList()
            View_HorarioBindingSource.DataSource = (From d In si.View_Horario Where d.idHorarioPorSemana = idHorario Order By d.idDia Descending Select d).ToList()

            Faculdade_tbBindingSource.DataSource = si.Faculdade_tb.ToList()
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            Return
        End Try
    End Sub
End Class