Public Class frmGerenciaAdministradores
    Dim db As New GestHorarioEntities()
    Private Sub Administrador_tbDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Administrador_tbDataGridView.CellClick
        Try
            idAdministrador = Integer.Parse(Administrador_tbDataGridView.CurrentRow.Cells(0).Value.ToString())
            Nome = Administrador_tbDataGridView.CurrentRow.Cells(1).Value.ToString()

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub PaswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PaswordTextBox.TextChanged
        Try
            If PaswordTextBox.TextLength >= 8 Then

                Label3.Text = "Suficiente"

            Else

                Label3.Text = "Insuficiente"
            End If

        Catch ex As Exception
            Return
        End Try
    End Sub
    Public Sub Limpar()
        Nome_CompletoTextBox.Clear()
        Nome_UsuarioTextBox.Clear()
        PaswordTextBox.Clear()
        TextBox1.Clear()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If PaswordTextBox.Text = TextBox1.Text Then

                Label4.Text = "Correcto"

            Else

                Label4.Text = "Incorrecto"
            End If

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If PaswordTextBox.Text = TextBox1.Text Then

                Dim ad As Usuario_tb = New Usuario_tb()
                ad.NomeCompleto = Nome_CompletoTextBox.Text
                ad.NomeUsuario = Nome_UsuarioTextBox.Text
                ad.SenhaUsuario = Eramake.eCryptography.Encrypt(PaswordTextBox.Text.ToString())
                db.Usuario_tb.Add(ad)
                db.SaveChanges()
                MetroFramework.MetroMessageBox.Show(Me, "Administrador adicionado com sucesso!", "Novo Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
                administradortbBindingSource.DataSource = db.Administrador_tb.ToList()
                Limpar()

            Else

                MetroFramework.MetroMessageBox.Show(Me, "O Usuario nao pode ser adicionado, porque as sehnas nao conscidem!", "Novo Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error: " + ex.Message, "Por favor Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub frmGerenciaAdministradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Administrador_tbBindingSource.DataSource = db.Administrador_tb.ToList()
    End Sub
    Dim Nome As String
    Dim idAdministrador As Integer
    Private Sub resertarSenhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles resertarSenhaToolStripMenuItem.Click
        Try
            If idAdministrador <> 0 Then
                Dim fb As frmResertarSenha = New frmResertarSenha()
                fb.idUsuaro = idAdministrador
                fb.metroButton1.Visible = False
                fb.metroButton2.Visible = True
                fb.Nome = Nome
                fb.ShowDialog()
                Administrador_tbBindingSource.DataSource = db.Administrador_tb.ToList()

            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class