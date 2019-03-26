Public Class frmListaHorarios
    Dim si As New GestHorarioEntities()
    Dim idCurso, idAn As Integer

    Private Sub frmListaHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        View_ListaHorarioBindingSource.DataSource = si.View_ListaHorario.ToList()
        CusostbBindingSource.DataSource = si.Cusos_tb.ToList()
        PeriodotbBindingSource.DataSource = si.Periodo_tb.ToList()
        SalastbBindingSource.DataSource = si.Salas_tb.ToList()
    End Sub




    Dim idHorarios, iCurso, idSemestre, idSala, idPeriodo, iAno As Integer
    Dim curso, sala, periodo As String


    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Try
            Dim abrir As New frmRelatorio()
            If idHorarios <> 0 Then
                abrir.idHorario = idHorarios
                abrir.idcurso = iCurso
                abrir.ShowDialog()

            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Dim anooo As Integer
    Private Sub View_ListaHorarioDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_ListaHorarioDataGridView.CellClick
        Try
            idHorarios = Integer.Parse(View_ListaHorarioDataGridView.CurrentRow.Cells(0).Value.ToString())
            iCurso = Integer.Parse(View_ListaHorarioDataGridView.CurrentRow.Cells(1).Value.ToString())
            idSemestre = Integer.Parse(View_ListaHorarioDataGridView.CurrentRow.Cells(3).Value.ToString())
            idSala = Integer.Parse(View_ListaHorarioDataGridView.CurrentRow.Cells(5).Value.ToString())
            idPeriodo = Integer.Parse(View_ListaHorarioDataGridView.CurrentRow.Cells(6).Value.ToString())
            curso = View_ListaHorarioDataGridView.CurrentRow.Cells(2).Value.ToString()
            sala = View_ListaHorarioDataGridView.CurrentRow.Cells(8).Value.ToString()
            periodo = View_ListaHorarioDataGridView.CurrentRow.Cells(7).Value.ToString()
            iAno = Integer.Parse(View_ListaHorarioDataGridView.CurrentRow.Cells(9).Value.ToString())
            anooo = Integer.Parse(View_ListaHorarioDataGridView.CurrentRow.Cells(4).Value.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub View_ListaHorarioDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles View_ListaHorarioDataGridView.DoubleClick
        Try
            Dim abrir As New frmCriarHorario()
            If idHorarios <> 0 Then
                abrir.Label4.Text = curso
                abrir.Label12.Text = iAno
                abrir.Label3.Text = idSemestre
                abrir.iAno = iAno
                abrir.Label14.Text = anooo
                abrir.Label5.Text = sala
                abrir.Label6.Text = periodo
                abrir.idPeriodo = idPeriodo
                abrir.idSala = idSala
                abrir.idHorario = idHorarios
                abrir.idSemestre = idSemestre
                abrir.idCurso = iCurso
                abrir.ShowDialog()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim abri As New frmAjuda()
        abri.ShowDialog()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''








    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub IdCursoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdCursoComboBox.SelectedIndexChanged
        Try
            idCurso = Integer.Parse(IdCursoComboBox.SelectedValue.ToString())
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

    Private Sub IdPeriodoTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdPeriodoTextBox.SelectedIndexChanged
        Try
            idPeriodo = Integer.Parse(IdPeriodoTextBox.SelectedValue.ToString())
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
            View_ListaHorarioBindingSource.DataSource = si.View_ListaHorario.ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If idHorarios = 0 Then Exit Sub
        'If idCurso = 0 Then Exit Sub
        'If idCurso = 0 Then Exit Sub

        Dim verifica As Object = (From d In si.View_ListaHorario Where d.Ano = DateAndTime.Now.Year AndAlso d.idAno = IdAnoTextBox.Text AndAlso d.idCurso = idCurso AndAlso d.idPeriodo = idPeriodo AndAlso d.idSala = idSala AndAlso d.Semestre = SemestreTextBox.Text Select d).Count()

        Dim achar As Object = (From d In si.View_ListaHorario Where d.Ano = DateAndTime.Now.Year AndAlso d.idAno = IdAnoTextBox.Text AndAlso d.idSala = idSala AndAlso d.Semestre = SemestreTextBox.Text Select d).Count()
        If verifica = 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Horario Nao Pode Ser Criado, porque ja Existe", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim ver As Object = (From d In si.View_ListaHorario Where d.Ano = DateAndTime.Now.Year AndAlso d.idAno = IdAnoTextBox.Value AndAlso d.idPeriodo = idPeriodo AndAlso d.idSala = idSala AndAlso d.Semestre = SemestreTextBox.Text Select d).Count()
            If ver = 1 Then

                MetroFramework.MetroMessageBox.Show(Me, "Sala Ja ocupada", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf ver = 0 Then
                Criar()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Horario Pra Sala Existente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            End If
    End Sub

    Private Sub View_ListaHorarioDataGridView_Click(sender As Object, e As EventArgs) Handles View_ListaHorarioDataGridView.Click
       
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Dim pr As Object = (From d In si.Criar_Horario_tb Where d.idHorarioPorSemestre = idHorarios Select d).Count()
            If pr <> 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "O horario nao pode ser apagado porque existe dados nele, para apagar primeiro elimina os dados existentes.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Try
                    If idHorarios <> 0 Then
                        Dim tb As New Horario_tb()
                        tb = (From d In si.Horario_tb Where d.idHorarioPorSemana = idHorarios Select d).FirstOrDefault()
                        si.Horario_tb.Remove(tb)
                        si.SaveChanges()
                        MetroFramework.MetroMessageBox.Show(Me, "Eliminado  Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        View_ListaHorarioBindingSource.DataSource = (From d In si.View_ListaHorario Select d).ToList()
                    End If
                Catch ex As Exception
                    Return
                End Try

            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class