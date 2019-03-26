Public Class frmRelatorio
    Dim si As New GestHorarioEntities()
    Public Property idHorario As Integer
    Public Property idcurso As Integer
    Private Sub frmRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            View_HorarioBindingSource.DataSource = (From d In si.View_Horario Where d.idHorarioPorSemana = idHorario Order By d.idDia Ascending Select d).ToList()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class