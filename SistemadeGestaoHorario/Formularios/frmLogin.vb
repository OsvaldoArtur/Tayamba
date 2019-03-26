Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports SGHCriaUser

Public Class frmLogin
    Dim si As New GestHorarioEntities()
    Private Shared Function Encrypt(value As String) As String
        Using md5 As New MD5CryptoServiceProvider()
            Dim utf8 As New UTF8Encoding()
            Dim data As Byte() = md5.ComputeHash(utf8.GetBytes(value))
            Return Convert.ToBase64String(data)
        End Using
    End Function

    Dim nomeempresa As String
    Private Function ConvertBinaryToImage(data As Byte()) As Image
        Using ms As New MemoryStream(data)

            Return Image.FromStream(ms)
        End Using
    End Function
    Public Sub procuraempresa()
        Try

            Dim procura As Object = (From d In si.Faculdade_tb Select d).Count()
            If procura = 1 Then
                Dim leva = (From d In si.Faculdade_tb Select d).FirstOrDefault()
                nomeempresa = leva.Nome_Extensao.ToString()
                PictureBox2.Image = ConvertBinaryToImage(leva.logotipo)
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Dim codigo As String
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim verificarUsuario As Object = (From d In si.Usuario_tb Select d).Count()
            If verificarUsuario <> 0 Then

            Else
                MetroFramework.MetroMessageBox.Show(Me, "Nenhum usuario encontrado no sistema, por favor registre um usuario apos a mensagem, Obrigado!", "Nenhum usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim abrir As New frmUsuario()
                abrir.ShowDialog()

            End If

            Dim verificarinstituicao As Object = (From d In si.Faculdade_tb Select d).Count()
            If verificarinstituicao <> 0 Then

            Else
                MetroFramework.MetroMessageBox.Show(Me, "Nenhuma instituicao encontrada no sistema, por favor registre uma instituicao apos a mensagem, Obrigado!", "Nenhuma instituicao!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim abrir As New frmFaculdade()
                abrir.ShowDialog()

            End If
            procuraempresa()
            Tulpepe()
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub Procurar(ByVal nome As String)

        Try
            Dim var As Object = (From d In si.Usuario_tb Where d.NomeUsuario.Contains(nome) Select d).Count()
            If var = 1 Then
                Dim lis As Object = (From d In si.Usuario_tb Where d.NomeUsuario.Contains(nome) Select d).ToList()

            Else

            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            End
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Try
            codigo = Eramake.eCryptography.Encrypt(txtSenha.Text)
            Dim procura As Object = (From d In si.Usuario_tb Where d.NomeUsuario.Equals(txtUsuario.Text) AndAlso d.SenhaUsuario.Equals(codigo) Select d).Count()
            If procura = 1 Then
                Dim pegaut = (From d In si.Usuario_tb Where d.NomeUsuario.Equals(txtUsuario.Text) AndAlso d.SenhaUsuario.Equals(codigo) Select d).FirstOrDefault()
                Dim abrir As New frmPrincipal()
                abrir.ToolStripStatusLabel1.Text = pegaut.NomeCompleto.ToString()
                abrir.ToolStripStatusLabel2.Text = nomeempresa.ToString()
                abrir.idUsuario = pegaut.idUsuario
                abrir.ShowDialog()
                txtSenha.Clear()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Usuario ou Senha Incorreta!", "Error Tente Novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSenha.Clear()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ab As New frmLoginn
            ab.ShowDialog()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            Dim ab As New frmLoginn
            ab.ShowDialog()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class