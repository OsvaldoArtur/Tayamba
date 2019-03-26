Public Class frmPeriodo
    Dim hr As New GestHorarioEntities()
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Periodo_tbBindingSource.AddNew()
    End Sub

    Private Sub frmPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Periodo_tbBindingSource.DataSource = hr.Periodo_tb.ToList()
        HorastbBindingSource.DataSource = hr.Horas_tb.ToList()
    End Sub
    Dim idHoras As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pd As New Periodo_tb()
        pd.Nome_periodo = Nome_periodoTextBox.Text

        hr.Periodo_tb.Add(pd)
        hr.SaveChanges()
        MetroFramework.MetroMessageBox.Show(Me, "Periodo Salvo Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Periodo_tbBindingSource.DataSource = hr.Periodo_tb.ToList()
        Nome_periodoTextBox.Clear()
    End Sub

   
End Class