Public Class frmImprimirHorario
    Dim idHorario, idCursos As Integer
    Dim si As New GestHorarioEntities()
  
    Private Sub pesquisar(ByVal nome As String)
        Try
            View_ListaHorarioBindingSource.DataSource = (From d In si.View_ListaHorario Where d.Nome_Curso.Contains(nome) Order By d.Nome_Curso Ascending Select d).ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            pesquisar(TextBox1.Text)
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub frmImprimirHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        View_ListaHorarioBindingSource.DataSource = si.View_ListaHorario.ToList()
        '  ComboBox1.SelectedIndex = 0
        AnotbBindingSource.DataSource = si.Ano_tb.ToList()
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub View_ListaHorarioDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_ListaHorarioDataGridView.CellClick
    End Sub


    Private Sub View_ListaHorarioDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles View_ListaHorarioDataGridView.DoubleClick
        Try
            idHorario = Integer.Parse(View_ListaHorarioDataGridView.CurrentRow.Cells(0).Value.ToString())
            idCursos = Integer.Parse(View_ListaHorarioDataGridView.CurrentRow.Cells(1).Value.ToString())
            If idHorario <> 0 Then
                Dim abrir As New frmModelo()
                abrir.idHorario = idHorario
                abrir.idcurso = idCursos
                abrir.ShowDialog()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            View_ListaHorarioBindingSource.DataSource = si.View_ListaHorario.Where(Function(c) c.Ano = ComboBox1.Text).ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub


    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Try
            View_ListaHorarioBindingSource.DataSource = si.View_ListaHorario.Where(Function(c) c.Ano = ComboBox1.Text AndAlso c.Semestre = NumericUpDown1.Value).ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class