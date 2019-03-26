Public Class frmResertarSenha
    Dim db As New GestHorarioEntities()
    Public Property idUsuaro As Integer
    Public Property Nome As String
    Private Sub frmResertarSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label2.Text = idUsuaro.ToString()
        label4.Text = Nome
    End Sub

    Private Sub metroButton1_Click(sender As Object, e As EventArgs) Handles metroButton1.Click
        Try
            Dim adms As Usuario_tb = New Usuario_tb()
            adms = db.Usuario_tb.Where(Function(d) d.idUsuario = idUsuaro).FirstOrDefault()
            adms.SenhaUsuario = Eramake.eCryptography.Encrypt(metroTextBox1.Text)
            db.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Senha resertada com Sucesso!", "Resertar Senha", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error: " + ex.Message, "Por favor Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub metroButton2_Click(sender As Object, e As EventArgs) Handles metroButton2.Click
        Try
            Dim adms As Administrador_tb = New Administrador_tb()
            adms = db.Administrador_tb.Where(Function(d) d.idAdministrador = idUsuaro).FirstOrDefault()
            adms.SenhaUsuario = Eramake.eCryptography.Encrypt(metroTextBox1.Text)
            db.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Senha resertada com Sucesso!", "Resertar Senha", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error: " + ex.Message, "Por favor Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class