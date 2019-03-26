Public Class frmHoorariosCursos
    Dim si As New GestHorarioEntities()
    Public Property idCursos As Integer
    Private Sub frmHoorariosCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ViewListaHorarioBindingSource.DataSource = si.View_ListaHorario.Where(Function(d) d.idCurso = idCursos AndAlso d.Ano = DateAndTime.Now.Year).ToList()
            PeriodotbBindingSource.DataSource = si.Periodo_tb.ToList()
            SalastbBindingSource.DataSource = si.Salas_tb.ToList()
            IdPeriodoTextBox.SelectedValue = 1
            IdSalaTextBox.SelectedValue = 1
            Button1.Enabled = False
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub listar()
        ViewListaHorarioBindingSource.DataSource = si.View_ListaHorario.Where(Function(d) d.idCurso = idCursos AndAlso d.Ano = DateAndTime.Now.Year).ToList()
    End Sub

    Dim idPerido As Integer


    'Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)
    '    Try
    '        ViewListaHorarioBindingSource.DataSource = si.View_ListaHorario.Where(Function(d) d.idAno = NumericUpDown1.Value AndAlso d.idCurso = idCursos AndAlso d.idPeriodo = idPerido).ToList()
    '    Catch ex As Exception
    '        Return
    '    End Try
    'End Sub




    Dim idSala As Integer
    Private Sub IdSalaTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdSalaTextBox.SelectedIndexChanged
        Try
            idSala = Integer.Parse(IdSalaTextBox.SelectedValue.ToString())

            Dim verifica As Object = (From d In si.View_ListaHorario Where d.Ano = DateAndTime.Now.Year AndAlso d.idAno = IdAnoTextBox.Text AndAlso d.idCurso = idCursos AndAlso d.idPeriodo = idPerido AndAlso d.idSala = idSala AndAlso d.Semestre = SemestreTextBox.Text Select d).Count()

            Dim achar As Object = (From d In si.View_ListaHorario Where d.Ano = DateAndTime.Now.Year AndAlso d.idAno = IdAnoTextBox.Text AndAlso d.idSala = idSala AndAlso d.Semestre = SemestreTextBox.Text Select d).Count()
            If verifica = 1 Then
                MetroFramework.MetroMessageBox.Show(Me, "Horario Nao Pode Ser Criado, porque ja Existe", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Button1.Enabled = False
            Else
                Dim ver As Object = (From d In si.View_ListaHorario Where d.Ano = DateAndTime.Now.Year AndAlso d.idPeriodo = idPerido AndAlso d.idSala = idSala AndAlso d.Semestre = SemestreTextBox.Text Select d).Count()

                If ver = 1 Then
                    Dim Coupada = (From d In si.View_ListaHorario Where d.Ano = DateAndTime.Now.Year AndAlso d.idPeriodo = idPerido AndAlso d.idSala = idSala AndAlso d.Semestre = SemestreTextBox.Text Select d).FirstOrDefault()
                    MetroFramework.MetroMessageBox.Show(Me, "Sala ja ocupada com: " + Coupada.Nome_Curso + ", do " + Coupada.idAno.ToString() + " Ano.", "Ocupada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Button1.Enabled = False
                ElseIf ver = 0 Then
                    Dim olha = si.View_ListaHorario.Where(Function(d) d.Ano = DateAndTime.Now.Year AndAlso d.idPeriodo = idPerido AndAlso d.Semestre = SemestreTextBox.Text AndAlso d.idCurso = idCursos AndAlso d.idAno = IdAnoTextBox.Text).Count()
                    If olha <> 0 Then
                        Dim olhadela = si.View_ListaHorario.Where(Function(d) d.Ano = DateAndTime.Now.Year AndAlso d.idPeriodo = idPerido AndAlso d.Semestre = SemestreTextBox.Text AndAlso d.idCurso = idCursos AndAlso d.idAno = IdAnoTextBox.Text).FirstOrDefault()
                        MetroFramework.MetroMessageBox.Show(Me, "Horario Existente, Periodo: " + olhadela.Nome_periodo + " Curso: " + olhadela.Nome_Curso + " Ano: " + olhadela.idAno.ToString() + " Semestre: " + olhadela.Semestre.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Button1.Enabled = True
                End If
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Horario Pra Sala Existente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Button1.Enabled = False
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub IdPeriodoTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdPeriodoTextBox.SelectedIndexChanged
        Try
            idPerido = Integer.Parse(IdPeriodoTextBox.SelectedValue.ToString())
            Button1.Enabled = False
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
            ab.idCurso = idCursos
            ab.idSala = idSala
            ab.idPeriodo = idPerido
            si.Horario_tb.Add(ab)
            si.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Primeira fase de criacao do sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            listar()
            Button1.Enabled = False
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Criar()

        Catch ex As Exception
            Return
        End Try
    End Sub



    Dim idHorarios As Integer
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            idHorarios = Integer.Parse(DataGridView1.CurrentRow.Cells(8).Value.ToString())
            iAno = Integer.Parse(DataGridView1.CurrentRow.Cells(1).Value.ToString())
            idPerido = Integer.Parse(DataGridView1.CurrentRow.Cells(6).Value.ToString())
            idSala = Integer.Parse(DataGridView1.CurrentRow.Cells(5).Value.ToString())
            idSemestre = Integer.Parse(DataGridView1.CurrentRow.Cells(2).Value.ToString())
            sala = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            periodo = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            anooo = Integer.Parse(DataGridView1.CurrentRow.Cells(3).Value.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub
    Dim iAno, idSemestre, anooo As Integer
    Dim sala, periodo As String

    Private Sub IdAnoTextBox_ValueChanged(sender As Object, e As EventArgs) Handles IdAnoTextBox.ValueChanged
        Try
            Button1.Enabled = False
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub SemestreTextBox_ValueChanged(sender As Object, e As EventArgs) Handles SemestreTextBox.ValueChanged
        Try
            Button1.Enabled = False
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub IdAnoTextBox_AutoSizeChanged(sender As Object, e As EventArgs) Handles IdAnoTextBox.AutoSizeChanged
        Try
            Button1.Enabled = False
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub SemestreTextBox_AutoSizeChanged(sender As Object, e As EventArgs) Handles SemestreTextBox.AutoSizeChanged
        Try
            Button1.Enabled = False
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Try
            Dim abrir As New frmCriarHorario()
            If idHorarios <> 0 Then
                abrir.Label4.Text = Label1.Text
                abrir.Label12.Text = iAno
                abrir.Label3.Text = idSemestre
                abrir.iAno = iAno
                abrir.Label14.Text = anooo
                abrir.Label5.Text = sala
                abrir.Label6.Text = periodo
                abrir.idPeriodo = idPerido
                abrir.idSala = idSala
                abrir.idHorario = idHorarios
                abrir.idSemestre = idSemestre
                abrir.idCurso = idCursos
                abrir.ShowDialog()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub





    'Private Sub ComboBox3_TextChanged(sender As Object, e As EventArgs)
    '    Try
    '        ViewListaHorarioBindingSource.DataSource = si.View_ListaHorario.Where(Function(d) d.Ano = ComboBox3.Text AndAlso d.idCurso = idCursos).ToList()
    '    Catch ex As Exception
    '        Return
    '    End Try
    'End Sub

    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        If e.KeyCode = Keys.Delete Then

            Try
                If idHorarios <> 0 Then
                    If MetroFramework.MetroMessageBox.Show(Me, "Deseja realmente apagar o Horario selecionado?" + vbNewLine + "NB: Todas as alocaoes desse horario serao removidas e ao mesmo tempo o horario sera apagado. ", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim tb As New Horario_tb()
                        tb = (From d In si.Horario_tb Where d.idHorarioPorSemana = idHorarios Select d).FirstOrDefault()
                        si.Horario_tb.Remove(tb)
                        si.SaveChanges()
                        MetroFramework.MetroMessageBox.Show(Me, "Eliminado  Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ViewListaHorarioBindingSource.DataSource = (From d In si.View_ListaHorario Where d.idCurso = idCursos AndAlso d.Ano = DateAndTime.Now.Year Select d).ToList()
                    Else

                    End If
                End If
            Catch ex As Exception
                        Return
                    End Try

                End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            idPerido = Integer.Parse(ComboBox1.SelectedValue.ToString())
            ViewListaHorarioBindingSource.DataSource = si.View_ListaHorario.Where(Function(d) d.idPeriodo = idPerido AndAlso d.idCurso = idCursos).ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class