Public Class frmHoras
    Dim hr As New GestHorarioEntities()
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Horas_tbBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If idPeriodo <> 0 Then
                Dim h As New Horas_tb()
                h.Horas = HorasTextBox.Text + " ás " + HorasTextBox1.Text
                h.idPeriodo = idPeriodo
                hr.Horas_tb.Add(h)
                hr.SaveChanges()
                MetroFramework.MetroMessageBox.Show(Me, "Horas salvas com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Horas_tbBindingSource.DataSource = hr.Horas_tb.Where(Function(d) d.idPeriodo = idPeriodo).ToList()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Seleciona o periodo", "Periodo!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub frmHoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Horas_tbBindingSource.DataSource = hr.Horas_tb.ToList()
        PeriodotbBindingSource.DataSource = hr.Periodo_tb.ToList()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
    Dim idPeriodo As Integer
    Private Sub IdPeriodoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdPeriodoComboBox.SelectedIndexChanged
        Try
            idPeriodo = Integer.Parse(IdPeriodoComboBox.SelectedValue.ToString())
            Horas_tbBindingSource.DataSource = hr.Horas_tb.Where(Function(d) d.idPeriodo = idPeriodo).ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abrir As New frmPeriodo()
        abrir.ShowDialog()
        PeriodotbBindingSource.DataSource = hr.Periodo_tb.ToList()
    End Sub
    Dim idHoras As Integer
    Private Sub Horas_tbDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Horas_tbDataGridView.CellClick
        Try
            idHoras = Integer.Parse(Horas_tbDataGridView.CurrentRow.Cells(1).Value.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Horas_tbDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles Horas_tbDataGridView.KeyUp
        Try
            If e.KeyCode = Keys.Delete Then
                If MetroFramework.MetroMessageBox.Show(Me, "Deseja realmente apagar?" + vbNewLine + "NB: Todos os dados que estao ligados a informacao que deseja apagar, serao juntamente apagados com todos os outros!", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim tb As New Horas_tb()
                    tb = (From d In hr.Horas_tb Where d.idHoras = idHoras Select d).FirstOrDefault()
                    hr.Horas_tb.Remove(tb)
                    hr.SaveChanges()
                    MetroFramework.MetroMessageBox.Show(Me, "Eliminado  Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Horas_tbBindingSource.DataSource = hr.Horas_tb.Where(Function(d) d.idPeriodo = idPeriodo).ToList()
                Else

                End If
            ElseIf e.KeyCode = Keys.Enter Then

                If MetroFramework.MetroMessageBox.Show(Me, "Deseja realmente efectuar alteracao?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        Dim CAdtb As New Horas_tb()
                        CAdtb = (From d In hr.Horas_tb Where d.idHoras = idHoras Select d).FirstOrDefault()
                        CAdtb.Horas = horas
                        hr.SaveChanges()
                        MetroFramework.MetroMessageBox.Show(Me, "Alerado Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Horas_tbBindingSource.DataSource = hr.Horas_tb.Where(Function(d) d.idPeriodo = idPeriodo).ToList()
                    Catch ex As Exception
                        Return
                    End Try
                Else
                    Horas_tbBindingSource.DataSource = hr.Horas_tb.Where(Function(d) d.idPeriodo = idPeriodo).ToList()
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Dim horas As String
    Private Sub Horas_tbDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Horas_tbDataGridView.CellEndEdit
        Try
            horas = Horas_tbDataGridView.CurrentRow.Cells(0).Value.ToString()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class