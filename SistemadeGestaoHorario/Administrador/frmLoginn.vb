Imports System.IO

Public Class frmLoginn
    Dim db As New GestHorarioEntities()
    Dim senha As String
    Private Sub Entrar()
        Try
            senha = Eramake.eCryptography.Encrypt(txtSenha.Text)
            Dim conta = db.Administrador_tb.Where(Function(d) d.NomeUsuario.Equals(txtUsuario.Text) AndAlso d.SenhaUsuario.Equals(senha)).Count()

            If conta <= 0 Then


                MetroFramework.MetroMessageBox.Show(Me, "Usuario ou Senha invalidos!", "Falha das Credenciais", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSenha.Text = ""

            Else
                Dim leva = db.Administrador_tb.Where(Function(d) d.NomeUsuario.Equals(txtUsuario.Text) AndAlso d.SenhaUsuario.Equals(senha)).FirstOrDefault()
                Dim mn As frmMenu = New frmMenu()
                mn.Nome = leva.NomeCompleto
                mn.ShowDialog()
                txtSenha.Clear()
                senha = ""



            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error: " + ex.Message, "Por favor Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



        End
    End Sub


    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Entrar()
    End Sub
    Public Sub verificar()
        Try
            Dim verifica = db.Administrador_tb.Count()
            If verifica <= 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Nenhum Administrador Encontrado! Por favor cadastre um administrador.", "Administador", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim ab As frmAddAdministrator = New frmAddAdministrator()
                ab.ShowDialog()
            Else
            End If

            Dim verificaFaculdade = db.Faculdade_tb.Count()
            If verificaFaculdade <= 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Nenhuma Instituicao foi Encontrada! Por favor cadastre uma instituicao.", "Instituicao", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim ab As frmFaculdade = New frmFaculdade()
                ab.Button2.Visible = True
                ab.ShowDialog()
            Else
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error: " + ex.Message, "Por favor Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub

    Private Sub frmLoginn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verificar()

    End Sub
End Class