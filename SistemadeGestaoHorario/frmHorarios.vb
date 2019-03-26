Public Class frmHorarios
    Dim idCurso, idPeriodo, idSala, idAno, idSemestre As Integer
    Dim si As New GestHorarioEntities()
    Private Sub IdCursoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdCursoComboBox.SelectedIndexChanged
        Try
            idCurso = Integer.Parse(IdCursoComboBox.SelectedValue.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Criar()
        Try
            Dim ab As New Horario_tb()
            ab.idAno = IdAnoTextBox.Text
            ab.Ano = DateAndTime.Now.Year
            ab.Semestre = SemestreTextBox.Text
            ab.idCurso = idCurso
            ab.idSala = idSala
            ab.idPeriodo = idPeriodo
            si.Horario_tb.Add(ab)
            si.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Primeira fase de criacao do sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim verifica As Object = (From d In si.View_ListaHorario Where d.Ano = DateAndTime.Now.Year AndAlso d.idAno = IdAnoTextBox.Text AndAlso d.idCurso = idCurso AndAlso d.idPeriodo = idPeriodo AndAlso d.idSala = idSala AndAlso d.Semestre = SemestreTextBox.Text Select d).Count()
        Dim ver As Object = (From d In si.View_ListaHorario Where d.Ano = DateAndTime.Now.Year AndAlso d.idAno = IdAnoTextBox.Text AndAlso d.idPeriodo = idPeriodo AndAlso d.idSala = idSala AndAlso d.Semestre = SemestreTextBox.Text Select d).Count()
        Dim achar As Object = (From d In si.View_ListaHorario Where d.Ano = DateAndTime.Now.Year AndAlso d.idAno = IdAnoTextBox.Text AndAlso d.idSala = idSala AndAlso d.Semestre = SemestreTextBox.Text Select d).Count()
        If verifica = 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Horario Nao Pode Ser Criado, porque ja Existe", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If ver = 1 Then

                MetroFramework.MetroMessageBox.Show(Me, "Sala Ja ocupada", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                If achar = 1 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Horario Pra Sala Existente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else
                    Criar()
                End If
            End If
        End If

    End Sub

    Private Sub frmHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CusostbBindingSource.DataSource = si.Cusos_tb.ToList()
        PeriodotbBindingSource.DataSource = si.Periodo_tb.ToList()
        SalastbBindingSource.DataSource = si.Salas_tb.ToList()
    End Sub

    Private Sub IdPeriodoTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdPeriodoTextBox.SelectedIndexChanged
        Try
            idPeriodo = Integer.Parse(IdPeriodoTextBox.SelectedValue.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub IdSalaTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdSalaTextBox.SelectedIndexChanged
        Try
            idSala = Integer.Parse(IdSalaTextBox.SelectedValue.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub


End Class