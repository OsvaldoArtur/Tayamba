Imports System.Security.Cryptography
Imports System.Text

Public Class frmMudarSenhaUsuario
    Dim si As New GestHorarioEntities()
    Public Property idUsuario As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox2.Text = TextBox3.Text Then
                senhaAntiga = Encrypt(TextBox1.Text)
                Dim Comparar = si.Usuario_tb.Where(Function(d) d.idUsuario = idUsuario AndAlso d.SenhaUsuario = senhaAntiga).Count()
                If Comparar = 1 Then
                    Dim Compararleva = si.Usuario_tb.Where(Function(d) d.idUsuario = idUsuario AndAlso d.SenhaUsuario = senhaAntiga).FirstOrDefault()
                    Dim ab As New Usuario_tb()
                    ab = si.Usuario_tb.Where(Function(s) s.idUsuario = idUsuario).FirstOrDefault()
                    ab.SenhaUsuario = Encrypt(TextBox3.Text)
                    si.SaveChanges()
                    MetroFramework.MetroMessageBox.Show(Me, "Senha Alterada com sucesso!", "Senha Alterada!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Senha Antiga Incorreta!", "Error Tente Novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "A senha repetida nao e igual. por favor coloque a senha correcta ", "Senha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Shared Function Encrypt(value As String) As String
        Using md5 As New MD5CryptoServiceProvider()
            Dim utf8 As New UTF8Encoding()
            Dim data As Byte() = md5.ComputeHash(utf8.GetBytes(value))
            Return Convert.ToBase64String(data)
        End Using
    End Function

    Dim senhaAntiga As String
    Dim Novasenha As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        senhaAntiga = Encrypt(TextBox1.Text)
        Dim Comparar = si.Usuario_tb.Where(Function(d) d.idUsuario = idUsuario AndAlso d.SenhaUsuario = senhaAntiga).Count()
        If Comparar = 1 Then
            Dim Compararleva = si.Usuario_tb.Where(Function(d) d.idUsuario = idUsuario AndAlso d.SenhaUsuario = senhaAntiga).FirstOrDefault()

        Else

        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Try
            If TextBox2.Text = TextBox3.Text Then
                Label4.Text = "Correcto"
                Label4.ForeColor = Color.Green
            Else
                Label4.Text = "Incorrecto"
                Label4.ForeColor = Color.Red
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub frmMudarSenhaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim nome = si.Usuario_tb.Where(Function(s) s.idUsuario = idUsuario).FirstOrDefault()
            ToolStripStatusLabel1.Text = nome.NomeCompleto.ToString()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class