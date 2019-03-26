Public Class frmEntradaHorario
    Dim si As New GestHorarioEntities()

    Private Sub frmEntradaHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CusostbBindingSource.DataSource = si.Cusos_tb.ToList()
    End Sub
    Dim idCursos, Duracao As Integer
    Dim NomeCurso As String

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            idCursos = Integer.Parse(DataGridView1.CurrentRow.Cells(0).Value.ToString())
            Duracao = Integer.Parse(DataGridView1.CurrentRow.Cells(2).Value.ToString())
            NomeCurso = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Try
            If idCursos <> 0 Then
                Dim Anos As String
                Dim abrir As New frmHoorariosCursos()
                abrir.idCursos = idCursos
                abrir.Label1.Text = NomeCurso.ToString()

                If Duracao = 1 Then
                    Anos = "Ano"
                    abrir.Label2.Text = Duracao.ToString() + " " + Anos
                Else
                    Anos = "Anos"
                    abrir.Label2.Text = Duracao.ToString() + " " + Anos
                End If
                abrir.ShowDialog()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim abrir As New frmCursos()
            abrir.ShowDialog()
            CusostbBindingSource.DataSource = si.Cusos_tb.ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class