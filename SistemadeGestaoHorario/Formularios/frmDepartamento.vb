Public Class frmDepartamento
    Dim hr As New GestHorarioEntities()
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Departamento_tbBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dp As New Departamento_tb()
        dp.Nome_Departamento = Nome_DepartamentoTextBox.Text
        hr.Departamento_tb.Add(dp)
        hr.SaveChanges()
        MetroFramework.MetroMessageBox.Show(Me, "Departamento Salvo Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Departamento_tbBindingSource.DataSource = hr.Departamento_tb.ToList()
        Nome_DepartamentoTextBox.Clear()
    End Sub

    Private Sub frmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Departamento_tbBindingSource.DataSource = hr.Departamento_tb.ToList()
    End Sub
End Class