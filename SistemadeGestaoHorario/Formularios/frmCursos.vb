Public Class frmCursos
    Dim hr As New GestHorarioEntities()

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Cusos_tbBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cr As New Cusos_tb()
        cr.Duracao_Curso = Duracao_CursoTextBox.Text
        cr.Nome_Curso = Nome_CursoTextBox.Text
        hr.Cusos_tb.Add(cr)
        hr.SaveChanges()
        MetroFramework.MetroMessageBox.Show(Me, "Curso Salvo Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Cusos_tbBindingSource.DataSource = hr.Cusos_tb.ToList()
        Nome_CursoTextBox.Clear()
    End Sub

    Private Sub frmCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cusos_tbBindingSource.DataSource = hr.Cusos_tb.ToList()
    End Sub
    Dim idCurso As Integer
    Private Sub Cusos_tbDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        Try
            If e.KeyCode = Keys.Delete Then
                If MetroFramework.MetroMessageBox.Show(Me, "Deseja realmente apagar?" + vbNewLine + "NB: Todos os dados que estao ligados a informacao que deseja apagar, serao juntamente apagados com todos os outros!", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim tb As New Cusos_tb()
                    tb = (From d In hr.Cusos_tb Where d.idCurso = idCurso Select d).FirstOrDefault()
                    hr.Cusos_tb.Remove(tb)
                    hr.SaveChanges()
                    MetroFramework.MetroMessageBox.Show(Me, "Eliminado  Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cusos_tbBindingSource.DataSource = hr.Cusos_tb.ToList()
                Else
                End If
            ElseIf e.KeyCode = Keys.Enter Then

                If MetroFramework.MetroMessageBox.Show(Me, "Deseja realmente efectuar alteracao?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        Dim CAdtb As New Cusos_tb()
                        CAdtb = (From d In hr.Cusos_tb Where d.idCurso = idCurso Select d).FirstOrDefault()
                        CAdtb.Nome_Curso = Nome
                        CAdtb.Duracao_Curso = Duracao
                        hr.SaveChanges()
                        MetroFramework.MetroMessageBox.Show(Me, "Alerado Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Cusos_tbBindingSource.DataSource = (From d In hr.Cusos_tb Select d).ToList()
                    Catch ex As Exception
                        Return
                    End Try
                Else


                    Cusos_tbBindingSource.DataSource = (From d In hr.Cusos_tb Select d).ToList()
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Cusos_tbDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            idCurso = Integer.Parse(DataGridView1.CurrentRow.Cells(0).Value.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub
    Dim Nome As String
    Dim Duracao As Integer
    Private Sub Cusos_tbDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try
            Nome = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            Duracao = Convert.ToInt16(DataGridView1.CurrentRow.Cells(2).Value).ToString()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class