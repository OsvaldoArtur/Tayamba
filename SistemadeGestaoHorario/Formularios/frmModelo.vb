Public Class frmModelo
    Public Property idHorario As Integer
    Public Property idcurso As Integer


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        'Try
        '    If RadioButton1.Checked = True Then
        '        Dim ab As New frmRelatorioTeste()
        '        ab.idcurso = idcurso
        '        ab.idHorario = idHorario
        '        ab.ShowDialog()
        '    End If
        'Catch ex As Exception
        '    Return
        'End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        'Try
        '    If RadioButton1.Checked = True Then
        '        Dim ab As New frmRelatorioHorarioCurso()
        '        ab.idcurso = idcurso
        '        ab.idHorario = idHorario
        '        ab.ShowDialog()
        '    End If
        'Catch ex As Exception
        '    Return
        'End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked = True Then
                Dim ab As New frmRelatorioTeste()
                ab.idcurso = idcurso
                ab.idHorario = idHorario
                ab.ShowDialog()
                CheckBox1.Checked = False
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Try
            If CheckBox2.Checked = True Then
                Dim ab As New frmRelatorioHorarioCurso()
                ab.idcurso = idcurso
                ab.idHorario = idHorario
                ab.ShowDialog()
                CheckBox2.Checked = False
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub


End Class