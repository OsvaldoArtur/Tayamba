Public Class frmEscolhadeDocente
    Dim hr As New GestHorarioEntities()
    Dim idDocente As Integer

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
                    View_HorarioBindingSource.DataSource = (From d In hr.View_Horario Where d.idDocente = idDocente Select d).ToList()

                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub frmEscolhadeDocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoCompleteFuncionario()
        '    ComboBox1.SelectedIndex = 0
        AnotbBindingSource.DataSource = hr.Ano_tb.ToList()

        PeriodotbBindingSource.DataSource = hr.Periodo_tb.ToList()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If idDocente <> 0 Then
                Dim abrir As New frmRelatorioDocente()
                abrir.idDocente = idDocente
                abrir.Ano = ComboBox1.Text
                abrir.Semestre = NumericUpDown1.Value
                abrir.idPeriodo = idPeriodoo
                abrir.Show()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Escolha o docente", "Escolha!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim ano As Integer = ComboBox1.Text
            View_HorarioBindingSource.DataSource = (From d In hr.View_Horario Where d.idDocente = idDocente AndAlso d.Ano = ano Select d).ToList()

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Try
            Dim ano As Integer = ComboBox1.Text
            Dim semes As Integer = NumericUpDown1.Value
            View_HorarioBindingSource.DataSource = (From d In hr.View_Horario Where d.idDocente = idDocente AndAlso d.Ano = ano AndAlso d.Semestre = semes Select d).ToList()

        Catch ex As Exception
            Return
        End Try
    End Sub
    Dim idPeriodoo As Integer
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            idPeriodoo = Integer.Parse(ComboBox2.SelectedValue.ToString())
            Dim ano As Integer = ComboBox1.Text
            Dim semes As Integer = NumericUpDown1.Value
            View_HorarioBindingSource.DataSource = (From d In hr.View_Horario Where d.idDocente = idDocente AndAlso d.Ano = ano AndAlso d.Semestre = semes AndAlso d.idPeriodo = idPeriodoo Select d).ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class