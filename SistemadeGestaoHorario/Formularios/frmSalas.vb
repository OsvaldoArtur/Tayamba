Public Class frmSalas
    Dim hr As New GestHorarioEntities()

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Salas_tbBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Nome_SalaTextBox.Text.Equals("") Then
                MetroFramework.MetroMessageBox.Show(Me, "Insira o nome da Sala Por Favor!", "Nome da Sala!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim verifica = hr.Salas_tb.Where(Function(d) d.Nome_Sala = Nome_SalaTextBox.Text).Count()
                If verifica <> 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Nome da Sala Ja existente no Sistema!", "Nome da Sala existente!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim sl As New Salas_tb()
                    sl.Nome_Sala = Nome_SalaTextBox.Text
                    hr.Salas_tb.Add(sl)
                    hr.SaveChanges()
                    MetroFramework.MetroMessageBox.Show(Me, "Sala Salva Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Salas_tbBindingSource.DataSource = hr.Salas_tb.ToList()
                    Nome_SalaTextBox.Clear()
                End If

            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub frmSalas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Salas_tbBindingSource.DataSource = hr.Salas_tb.ToList()
    End Sub
    Dim idSala As Integer
    Private Sub Salas_tbDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            idSala = Integer.Parse(DataGridView1.CurrentRow.Cells(0).Value.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Salas_tbDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        Try
            If e.KeyCode = Keys.Delete Then
                If MetroFramework.MetroMessageBox.Show(Me, "Deseja realmente apagar?" + vbNewLine + "NB: Todos os dados que estao ligados a informacao que deseja apagar, serao juntamente apagados com todos os outros!", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim tb As New Salas_tb()
                    tb = (From d In hr.Salas_tb Where d.idSala = idSala Select d).FirstOrDefault()
                    hr.Salas_tb.Remove(tb)
                    hr.SaveChanges()
                    MetroFramework.MetroMessageBox.Show(Me, "Eliminado  Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Salas_tbBindingSource.DataSource = hr.Salas_tb.ToList()
                Else
                End If

            ElseIf e.KeyCode = Keys.Enter Then

                If MetroFramework.MetroMessageBox.Show(Me, "Deseja realmente efectuar alteracao?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        Dim CAdtb As New Salas_tb()
                        CAdtb = (From d In hr.Salas_tb Where d.idSala = idSala Select d).FirstOrDefault()
                        CAdtb.Nome_Sala = nome
                        hr.SaveChanges()
                        MetroFramework.MetroMessageBox.Show(Me, "Alerado Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Salas_tbBindingSource.DataSource = (From d In hr.Salas_tb Select d).ToList()
                    Catch ex As Exception
                        Return
                    End Try
                Else
                    Salas_tbBindingSource.DataSource = (From d In hr.Salas_tb Select d).ToList()
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Dim nome As String
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try
            nome = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class