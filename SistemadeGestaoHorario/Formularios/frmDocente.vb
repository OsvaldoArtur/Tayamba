Public Class frmDocente
    Dim hr As New GestHorarioEntities()

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Docente_tbBindingSource.AddNew()
    End Sub
    Dim IdDepartamento As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Nome_DocenteTextBox.Text.Equals("") Then
                MetroFramework.MetroMessageBox.Show(Me, "Insira o nome do Docente Por Favor!", "Nome do Docente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                Dim verifica = hr.Docente_tb.Where(Function(d) d.Nome_Docente = Nome_DocenteTextBox.Text).Count()
                If verifica <> 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Nome do Docente Ja existente no Sistema!", "Nome do Docente existente!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim dc As New Docente_tb()
                    dc.Formacao_Academica = "Mestrado"
                    dc.idDepartamento = 1
                    dc.Nome_Docente = Nome_DocenteTextBox.Text
                    hr.Docente_tb.Add(dc)
                    hr.SaveChanges()
                    MetroFramework.MetroMessageBox.Show(Me, "Docente Salvo Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Docente_tbBindingSource.DataSource = hr.Docente_tb.ToList()
                    Nome_DocenteTextBox.Clear()
                End If

            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            IdDepartamento = Integer.Parse(ComboBox1.SelectedValue.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub frmDocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Docente_tbBindingSource.DataSource = hr.Docente_tb.ToList()
        DepartamentotbBindingSource.DataSource = hr.Departamento_tb.ToList()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim abrir As New frmDepartamento()
        abrir.ShowDialog()
        DepartamentotbBindingSource.DataSource = hr.Departamento_tb.ToList()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abrir As New frmDepartamento()
        abrir.ShowDialog()
        DepartamentotbBindingSource.DataSource = hr.Departamento_tb.ToList()
    End Sub

    Dim dc As Integer
    Private Sub apagar()
        Try
            If MetroFramework.MetroMessageBox.Show(Me, "Deseja Realmente eliminar o docente?", "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Dim tb As New Docente_tb()
                tb = (From d In hr.Docente_tb Where d.idDocente = dc Select d).FirstOrDefault()
                hr.Docente_tb.Remove(tb)
                hr.SaveChanges()
                Docente_tbBindingSource.DataSource = hr.Docente_tb.ToList()
                MetroFramework.MetroMessageBox.Show(Me, "Docente eliminado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

            End If

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Docente_tbDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Docente_tbDataGridView.CellClick
        Try
            dc = Integer.Parse(Docente_tbDataGridView.CurrentRow.Cells(0).Value.ToString())

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim contar As Object = (From d In hr.Criar_Horario_tb Where d.idDocente = dc Select d).Count()
            If contar <> 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "O docente nao pode ser eliminado por ja esta alocado nos horarios. Por favor elimine as alocacoes para poder eliminar.", "Impossivel", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                apagar()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Docente_tbDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles Docente_tbDataGridView.KeyUp
        Try
            If e.KeyCode = Keys.Delete Then

                apagar()


            ElseIf e.KeyCode = Keys.Enter Then

                If MetroFramework.MetroMessageBox.Show(Me, "Deseja realmente efectuar alteracao?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        Dim CAdtb As New Docente_tb()
                        CAdtb = (From d In hr.Docente_tb Where d.idDocente = dc Select d).FirstOrDefault()
                        CAdtb.Nome_Docente = nome

                        hr.SaveChanges()
                        MetroFramework.MetroMessageBox.Show(Me, "Alerado Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Docente_tbBindingSource.DataSource = (From d In hr.Docente_tb Select d).ToList()
                    Catch ex As Exception
                        Return
                    End Try
                Else
                    Docente_tbBindingSource.DataSource = (From d In hr.Docente_tb Select d).ToList()
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Dim nome As String
    Private Sub Docente_tbDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Docente_tbDataGridView.CellEndEdit
        Try
            nome = Docente_tbDataGridView.CurrentRow.Cells(1).Value.ToString()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class