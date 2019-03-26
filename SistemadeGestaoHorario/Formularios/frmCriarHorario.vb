Public Class frmCriarHorario
    Dim hr As New GestHorarioEntities()
    Dim idDocente, idCadeira, idFaculdade, idDia As Integer
    Public Property idHorario As Integer
    Public Property idCurso As Integer
    Public Property idSemestre As Integer
    Public Property idSala As Integer
    Public Property idPeriodo As Integer
    Public Property iAno As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Criar_Horario_tbBindingSource.AddNew()
    End Sub

    Private Sub Adddd()
        Try
            Dim crh As New Criar_Horario_tb()
            crh.idCadeira = idCadeira
            crh.idDia = idDia
            crh.idDocente = idDocente
            crh.idHoras = idhoras
            crh.idHorarioPorSemestre = idHorario
            hr.Criar_Horario_tb.Add(crh)
            hr.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Alocacao efectuada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            View_HorarioBindingSource.DataSource = (From d In hr.View_Horario Where d.idCurso = idCurso AndAlso d.idHorarioPorSemestre = idHorario Order By d.idHoras Ascending Order By d.idDia Ascending Select d).ToList()
            Button2.Enabled = False
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim procura As Object = (From d In hr.Criar_Horario_tb Where d.idCadeira = idCadeira AndAlso d.idDia = idDia AndAlso d.idDocente = idDocente AndAlso d.idHoras = idhoras Select d).Count()
            If procura = 1 Then
                Dim leva = (From d In hr.Criar_Horario_tb Where d.idCadeira = idCadeira AndAlso d.idDia = idDia AndAlso d.idDocente = idDocente AndAlso d.idHoras = idhoras Select d).FirstOrDefault()

                MetroFramework.MetroMessageBox.Show(Me, "Alocacao Repetida, Altere os dados!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Adddd()
            End If
        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub frmCriarHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoCompleteFuncionario()
        SalastbBindingSource.DataSource = hr.Salas_tb.ToList()
        FaculdadetbBindingSource.DataSource = hr.Faculdade_tb.ToList()
        PeriodotbBindingSource.DataSource = hr.Periodo_tb.ToList()
        CadeiratbBindingSource.DataSource = (From d In hr.Cadeira_tb Where d.idCurso = idCurso AndAlso d.Ano = iAno AndAlso d.Semestre = idSemestre Select d).ToList()

        DocentetbBindingSource.DataSource = hr.Docente_tb.ToList()
        View_HorarioBindingSource.DataSource = (From d In hr.View_Horario Where d.idCurso = idCurso AndAlso d.idHorarioPorSemestre = idHorario Order By d.idHoras Ascending Order By d.idDia Ascending Select d).ToList()
        Button2.Enabled = False
    End Sub





    Private Sub IdDiaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdDiaComboBox.SelectedIndexChanged
        Try
            idDia = Integer.Parse(IdDiaComboBox.SelectedValue.ToString())
            HorastbBindingSource.DataSource = hr.Horas_tb.Where(Function(d) d.idPeriodo = idPeriodo).ToList()
            Button2.Enabled = False
            ToolStripStatusLabel3.Text = IdDiaComboBox.Text
        Catch ex As Exception
            Return
        End Try
    End Sub



    Private Sub IdCadeiraComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdCadeiraComboBox.SelectedIndexChanged
        Try
            idCadeira = Integer.Parse(IdCadeiraComboBox.SelectedValue.ToString())
            SemanatbBindingSource.DataSource = hr.Semana_tb.ToList()
            Button2.Enabled = False
            ToolStripStatusLabel2.Text = IdCadeiraComboBox.Text
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub IdDocenteComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdDocenteComboBox.SelectedIndexChanged
        Try
            idDocente = Integer.Parse(IdDocenteComboBox.SelectedValue.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub


    Private Sub Criar_Horario_tbDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            'idDocente = Integer.Parse(Criar_Horario_tbDataGridView.CurrentRow.Cells(2).Value.ToString())


        Catch ex As Exception

        End Try
    End Sub

    Private Sub IdHorarioComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception
            Return
        End Try
    End Sub
    Dim idhoras As Integer

    Public Sub verifica()


        Try
            idhoras = Integer.Parse(ComboBox1.SelectedValue.ToString())


            Dim procurar As Object = (From d In hr.View_Horario Where d.Ano = Label14.Text AndAlso d.idDia = idDia AndAlso d.idHoras = idhoras AndAlso d.idSala = idSala AndAlso d.idPeriodo = idPeriodo AndAlso d.idCurso = idCurso AndAlso d.Semestre = idSemestre Select d).Count()
            If procurar = 1 Then
                Button2.Enabled = False
                Label2.Text = "Ocupado"
            Else
                Dim procura As Object = (From d In hr.View_Horario Where d.Ano = Label14.Text AndAlso d.idDocente = idDocente AndAlso d.idPeriodo = idPeriodo AndAlso d.idHoras = idhoras AndAlso d.idDia = idDia AndAlso d.Semestre = idSemestre Select d).Count()
                If procura = 1 Then
                    Button2.Enabled = False
                    MetroFramework.MetroMessageBox.Show(Me, "Repaticao na atribuicao de horas ", "Repeticao!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Label2.Text = "Indisponivel"
                ElseIf procura = 0 Then
                    Button2.Enabled = True
                    Label2.Text = "Disponivel"
                Else
                    Button2.Enabled = False
                    MetroFramework.MetroMessageBox.Show(Me, "Repeticao na Atribuicao", "Repeticao!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Label2.Text = "Indisponivel"
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim dia, horas, sala, periodo, docente As String
        ToolStripStatusLabel4.Text = ComboBox1.Text
        idhoras = Integer.Parse(ComboBox1.SelectedValue.ToString())
        Dim ver As Object = (From d In hr.Cadeira_tb Where d.idCadeira = idCadeira Select d).FirstOrDefault()

        Dim procuraa As Object = (From d In hr.View_Horario Where d.Ano = Label14.Text AndAlso d.idDia = idDia AndAlso d.idHoras = idhoras AndAlso d.idSala = idSala AndAlso d.idPeriodo = idPeriodo AndAlso d.idCurso = idCurso AndAlso d.Semestre = idSemestre Select d).Count()

        If ver.TipoCadeira = "Em Comum" And procuraa = 0 Then
            Button2.Enabled = True
        Else

            Try

                Dim procurar As Object = (From d In hr.View_Horario Where d.Ano = Label14.Text AndAlso d.idDia = idDia AndAlso d.idHoras = idhoras AndAlso d.idSala = idSala AndAlso d.idPeriodo = idPeriodo AndAlso d.idCurso = idCurso AndAlso d.Semestre = idSemestre Select d).Count()
                If procurar = 1 Then
                    Dim primeira = (From d In hr.View_Horario Where d.Ano = Label14.Text AndAlso d.idDia = idDia AndAlso d.idHoras = idhoras AndAlso d.idSala = idSala AndAlso d.idPeriodo = idPeriodo AndAlso d.idCurso = idCurso AndAlso d.Semestre = idSemestre Select d).FirstOrDefault()
                    dia = primeira.Dia
                    horas = primeira.Horas
                    sala = primeira.Nome_Sala
                    periodo = primeira.Nome_periodo

                    Button2.Enabled = False
                    Label2.ForeColor = Color.Red
                    Label2.Text = "Ocupado"
                    MetroFramework.MetroMessageBox.Show(Me, "No periodo " + periodo + ", Na Sala: " + sala + ", Na " + dia + ", das " + horas + ", esta Ocupado!", "Ocupado!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else
                    Dim procura As Object = (From d In hr.View_Horario Where d.Ano = Label14.Text AndAlso d.idDocente = idDocente AndAlso d.idPeriodo = idPeriodo AndAlso d.idHoras = idhoras AndAlso d.idDia = idDia AndAlso d.Semestre = idSemestre Select d).Count()
                    If procura = 1 Then
                        Dim segunda = (From d In hr.View_Horario Where d.Ano = Label14.Text AndAlso d.idDocente = idDocente AndAlso d.idPeriodo = idPeriodo AndAlso d.idHoras = idhoras AndAlso d.idDia = idDia AndAlso d.Semestre = idSemestre Select d).FirstOrDefault()
                        dia = segunda.Dia
                        horas = segunda.Horas
                        sala = segunda.Nome_Sala
                        periodo = segunda.Nome_periodo
                        docente = segunda.Nome_Docente
                        Button2.Enabled = False
                        MetroFramework.MetroMessageBox.Show(Me, "O docente: " + docente + ", Encontra-se ocupado na Sala: " + sala + ", Na " + dia + ", das " + horas + ", No periodo: " + periodo + ".", "Repeticao de Atribuicao das Horas!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Label2.Text = "Indisponivel"
                        Label2.ForeColor = Color.Yellow
                    ElseIf procura = 0 Then
                        Button2.Enabled = True
                        Label2.Text = "Disponivel"
                        Label2.ForeColor = Color.Green

                    Else
                        Button2.Enabled = False
                        MetroFramework.MetroMessageBox.Show(Me, "O/A Docente Encontra-se Ocupado Com Duas ou Mais turmas no mesmo Perido.", "Repeticao Na Atribuicao!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Label2.Text = "Indisponivel"
                    End If

                End If


            Catch ex As Exception
                Return
            End Try
        End If

    End Sub

    Private Sub autoCompleteFuncionario()
        Dim cl As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        hr = New GestHorarioEntities()
        Dim pro As Object = (From d In hr.Docente_tb).ToList()

        For Each item As Object In pro
            cl.Add(item.Nome_Docente.ToString())
            TextBox1.AutoCompleteCustomSource = cl
        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try

            If (TextBox1.Text.Equals("")) Then
                Return
            Else

                Dim nclient As Object = (From d In hr.Docente_tb Where d.Nome_Docente.Equals(TextBox1.Text)).Count()
                If nclient <> 0 Then
                    Dim clien As Object = (From d In hr.Docente_tb Where d.Nome_Docente.Equals(TextBox1.Text)).FirstOrDefault()
                    idDocente = clien.idDocente
                    Button2.Enabled = False
                    ToolStripStatusLabel1.Text = clien.Nome_Docente.ToString()
                End If
            End If
        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            If numero <> 0 Then
                Dim tb As New Criar_Horario_tb()
                tb = (From d In hr.Criar_Horario_tb Where d.idHorario = numero Select d).FirstOrDefault()
                hr.Criar_Horario_tb.Remove(tb)
                hr.SaveChanges()
                MetroFramework.MetroMessageBox.Show(Me, "Eliminado  Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                View_HorarioBindingSource.DataSource = (From d In hr.View_Horario Where d.idCurso = idCurso AndAlso d.idHorarioPorSemestre = idHorario Select d).ToList()

            Else

            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Dim numero As Integer
    Private Sub View_HorarioDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_HorarioDataGridView.CellClick
        Try
            numero = Integer.Parse(View_HorarioDataGridView.CurrentRow.Cells(0).Value.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If idHorario <> 0 Then
                Dim abrir As New frmRelatorioTeste()
                abrir.idHorario = idHorario
                abrir.idcurso = idCurso
                abrir.ShowDialog()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub View_HorarioDataGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles View_HorarioDataGridView.UserDeletedRow
        Dim tb As New Criar_Horario_tb()
        tb = (From d In hr.Criar_Horario_tb Where d.idHorario = numero Select d).FirstOrDefault()
        hr.Criar_Horario_tb.Remove(tb)
        hr.SaveChanges()
        MetroFramework.MetroMessageBox.Show(Me, "Eliminado  Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.None)
        View_HorarioBindingSource.DataSource = (From d In hr.View_Horario Where d.idCurso = idCurso AndAlso d.idHorarioPorSemestre = idHorario Select d).ToList()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            If numero <> 0 Then
                Dim tb As New Criar_Horario_tb()
                tb = (From d In hr.Criar_Horario_tb Where d.idHorario = numero Select d).FirstOrDefault()
                hr.Criar_Horario_tb.Remove(tb)
                hr.SaveChanges()
                MetroFramework.MetroMessageBox.Show(Me, "Eliminado  Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                View_HorarioBindingSource.DataSource = (From d In hr.View_Horario Where d.idCurso = idCurso AndAlso d.idHorarioPorSemestre = idHorario Order By d.idHoras Ascending Order By d.idDia Ascending Select d).ToList()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub View_HorarioDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles View_HorarioDataGridView.KeyUp
        If e.KeyCode = Keys.Delete Then
            Try
                If numero <> 0 Then
                    If MetroFramework.MetroMessageBox.Show(Me, "Deseja remover a alocacao?" + vbNewLine + "NB: Apos a confirmacao nao tem como voltar.", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


                        Dim tb As New Criar_Horario_tb()
                        tb = (From d In hr.Criar_Horario_tb Where d.idHorario = numero Select d).FirstOrDefault()
                        hr.Criar_Horario_tb.Remove(tb)
                        hr.SaveChanges()
                        MetroFramework.MetroMessageBox.Show(Me, "Eliminado  Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        View_HorarioBindingSource.DataSource = (From d In hr.View_Horario Where d.idCurso = idCurso AndAlso d.idHorarioPorSemestre = idHorario Order By d.idHoras Ascending Order By d.idDia Ascending Select d).ToList()
                    Else

                    End If
                End If
            Catch ex As Exception
                Return
            End Try
        End If
    End Sub

    Private Sub ImprimirHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If idHorario <> 0 Then
                Dim abrir As New frmModelo()
                abrir.idHorario = idHorario
                abrir.idcurso = idCurso
                abrir.ShowDialog()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.Close()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim ab As New frmCadeiraAdd()
            ab.idCurso = idCurso
            ab.Ano = Label12.Text
            ab.Semestre = Label3.Text
            ab.Label5.Text = Label12.Text
            ab.Label7.Text = Label3.Text
            ab.Label4.Text = Label4.Text
            ab.ShowDialog()
            CadeiratbBindingSource.DataSource = (From d In hr.Cadeira_tb Where d.idCurso = idCurso AndAlso d.Ano = iAno AndAlso d.Semestre = idSemestre Select d).ToList()

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim ab As New frmDocente()
            ab.ShowDialog()
            autoCompleteFuncionario()
            DocentetbBindingSource.DataSource = hr.Docente_tb.ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class