Public Class frmAddAdministrator

    'Osvaldo Artur Dionisio
    'Desenvolvedor do Sistema de Gestao de Horarios
    'Contacto: 848046991
    'Nacionalidade: Mocambicana
    'Provincia de Tete
    'SaluT

    Dim db As GestHorarioEntities = New GestHorarioEntities()

    Private Sub frmAddAdministrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If PaswordTextBox.Text = TextBox1.Text Then

                Dim ad As Administrador_tb = New Administrador_tb()
                ad.DataRegistro = DateTime.Now
                ad.NomeCompleto = Nome_CompletoTextBox.Text
                ad.NomeUsuario = Nome_UsuarioTextBox.Text
                ad.SenhaUsuario = Eramake.eCryptography.Encrypt(TextBox1.Text)
                db.Administrador_tb.Add(ad)
                db.SaveChanges()
                MetroFramework.MetroMessageBox.Show(Me, "Administrador adicionado com sucesso!", "Novo Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            Else
                MetroFramework.MetroMessageBox.Show(Me, "O Administrador nao pode ser adicionado, porque as sehnas nao conscidem!", "Novo Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error nº 2: " + ex.Message, "Por favor Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

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
End Class