Public Class frmSemana
    Dim hr As New GestHorarioEntities()
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Semana_tbBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim seman As New Semana_tb()
        seman.Dia = DiaTextBox.Text
        hr.Semana_tb.Add(seman)
        hr.SaveChanges()
        MetroFramework.MetroMessageBox.Show(Me, "Semana Salva Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Semana_tbBindingSource.DataSource = hr.Semana_tb.ToList()
        DiaTextBox.Clear()
    End Sub

    Private Sub frmSemana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Semana_tbBindingSource.DataSource = hr.Semana_tb.ToList()
    End Sub
End Class