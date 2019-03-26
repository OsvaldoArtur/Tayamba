Public Class frmCadeira
    Dim hr As New GestHorarioEntities()

    Dim Tipodecadeira As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CBTipo.Checked = True Then
            Tipodecadeira = "Em Comum"
        Else
            Tipodecadeira = "Nao Comum"
        End If
        Try
            Dim dc As New Cadeira_tb()
            dc.Ano = AnoTextBox.Text
            dc.Nome_Cadeira = Nome_CadeiraTextBox.Text
            dc.Semestre = SemestreTextBox.Text
            dc.idCurso = idCurso
            dc.Credito_Cadeira = credito_textBox.Value
            dc.TipoCadeira = Tipodecadeira
            hr.Cadeira_tb.Add(dc)
            hr.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Cadeira Salva Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cadeira_tbBindingSource.DataSource = (From d In hr.Cadeira_tb Where d.idCurso = idCurso AndAlso d.Ano = AnoTextBox.Value AndAlso d.Semestre = SemestreTextBox.Value Select d).ToList()
            Nome_CadeiraTextBox.Clear()
        Catch ex As Exception
            Return
        End Try
    End Sub
    Dim idCurso As Integer
    Private Sub IdCursoTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdCursoTextBox.SelectedIndexChanged
        Try
            idCurso = Integer.Parse(IdCursoTextBox.SelectedValue.ToString())
            Cadeira_tbBindingSource.DataSource = (From d In hr.Cadeira_tb Where d.idCurso = idCurso Select d).ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub frmCadeira_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Cadeira_tbBindingSource.DataSource = hr.Cadeira_tb.ToList()
        CusostbBindingSource.DataSource = hr.Cusos_tb.ToList()
        SelecionarPrimeiroNoCombo()
    End Sub
    Private Sub SelecionarPrimeiroNoCombo()
        Try
            IdCursoTextBox.SelectedValue = 1
        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim abrir As New frmCursos()
        abrir.ShowDialog()
        CusostbBindingSource.DataSource = hr.Cusos_tb.ToList()
    End Sub

    Private Sub AnoTextBox_ValueChanged(sender As Object, e As EventArgs) Handles AnoTextBox.ValueChanged
        Try
            Cadeira_tbBindingSource.DataSource = (From d In hr.Cadeira_tb Where d.idCurso = idCurso AndAlso d.Ano = AnoTextBox.Value Select d).ToList()

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub SemestreTextBox_ValueChanged(sender As Object, e As EventArgs) Handles SemestreTextBox.ValueChanged
        Try
            Cadeira_tbBindingSource.DataSource = (From d In hr.Cadeira_tb Where d.idCurso = idCurso AndAlso d.Ano = AnoTextBox.Value AndAlso d.Semestre = SemestreTextBox.Value Select d).ToList()

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Cadeira_tbDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles Cadeira_tbDataGridView.KeyUp
        Try
            If e.KeyCode = Keys.Delete Then
                Try
                    If MetroFramework.MetroMessageBox.Show(Me, "Deseja realmente apagar?" + vbNewLine + "NB: Todos os dados que estao ligados a informacao que deseja apagar, serao juntamente apagados com todos os outros!", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim tb As New Cadeira_tb()
                        tb = (From d In hr.Cadeira_tb Where d.idCadeira = idCadeira Select d).FirstOrDefault()
                        hr.Cadeira_tb.Remove(tb)
                        hr.SaveChanges()
                        MetroFramework.MetroMessageBox.Show(Me, "Eliminado  Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Cadeira_tbBindingSource.DataSource = (From d In hr.Cadeira_tb Where d.idCurso = idCurso AndAlso d.Ano = AnoTextBox.Value AndAlso d.Semestre = SemestreTextBox.Value Select d).ToList()
                    Else

                    End If
                Catch ex As Exception
                    Return
                End Try

            ElseIf e.KeyCode = Keys.Enter Then

                If MetroFramework.MetroMessageBox.Show(Me, "Deseja realmente efectuar alteracao?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        Dim CAdtb As New Cadeira_tb()
                        CAdtb = (From d In hr.Cadeira_tb Where d.idCadeira = idCadeira Select d).FirstOrDefault()
                        CAdtb.Ano = Ano
                        CAdtb.Credito_Cadeira = Credito
                        CAdtb.Nome_Cadeira = Nome
                        CAdtb.Semestre = Semestre
                        CAdtb.TipoCadeira = TipoCadeira
                        hr.SaveChanges()
                        MetroFramework.MetroMessageBox.Show(Me, "Alerado Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Cadeira_tbBindingSource.DataSource = (From d In hr.Cadeira_tb Where d.idCurso = idCurso AndAlso d.Ano = AnoTextBox.Value AndAlso d.Semestre = SemestreTextBox.Value Select d).ToList()
                    Catch ex As Exception
                        Return
                    End Try
                Else
                    Cadeira_tbBindingSource.DataSource = (From d In hr.Cadeira_tb Where d.idCurso = idCurso AndAlso d.Ano = AnoTextBox.Value AndAlso d.Semestre = SemestreTextBox.Value Select d).ToList()
                End If

            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Dim idCadeira As Integer



    Dim Nome As String
    Dim Credito As Integer
    Dim Ano As Integer
    Dim Semestre As Integer
    Dim idCuro As Integer
    Dim TipoCadeira As String

    Private Sub Cadeira_tbDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Cadeira_tbDataGridView.CellClick
        Try
            idCadeira = Integer.Parse(Cadeira_tbDataGridView.CurrentRow.Cells(0).Value.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub



    Private Sub Cadeira_tbDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Cadeira_tbDataGridView.CellEndEdit
        Try
            Nome = Cadeira_tbDataGridView.CurrentRow.Cells(1).Value.ToString()
            Credito = Convert.ToInt16(Cadeira_tbDataGridView.CurrentRow.Cells(2).Value).ToString()
            Ano = Convert.ToInt16(Cadeira_tbDataGridView.CurrentRow.Cells(3).Value).ToString()
            Semestre = Convert.ToInt16(Cadeira_tbDataGridView.CurrentRow.Cells(4).Value).ToString()
            idCuro = Convert.ToInt16(Cadeira_tbDataGridView.CurrentRow.Cells(5).Value).ToString()
            TipoCadeira = Cadeira_tbDataGridView.CurrentRow.Cells(6).Value.ToString()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class