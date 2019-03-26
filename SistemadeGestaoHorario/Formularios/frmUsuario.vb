Imports System.Security.Cryptography
Imports System.Text
Public Class frmUsuario
    Dim hr As New GestHorarioEntities()
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    UsuarioBindingSource.AddNew()
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim us As New Usuario()
    '    us.Nome_Completo = Nome_CompletoTextBox.Text
    '    us.Nome_Usuario = Nome_UsuarioTextBox.Text
    '    us.Pasword = PaswordTextBox.Text
    '    us.Perfil = PerfilTextBox.Text
    '    hr.Usuario.Add(us)
    '    hr.SaveChanges()
    '    MsgBox("Salvado com suceeso")
    '    UsuarioBindingSource.DataSource = hr.Usuario.ToList()
    'End Sub

    'Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    UsuarioBindingSource.DataSource = hr.Usuario.ToList()
    'End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Shared Function Encrypt(value As String) As String
        Using md5 As New MD5CryptoServiceProvider()
            Dim utf8 As New UTF8Encoding()
            Dim data As Byte() = md5.ComputeHash(utf8.GetBytes(value))
            Return Convert.ToBase64String(data)
        End Using
    End Function
    Dim codigo As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text = PaswordTextBox.Text Then
                Dim us As New Usuario_tb()
                us.NomeCompleto = Nome_CompletoTextBox.Text
                us.NomeUsuario = Nome_UsuarioTextBox.Text
                us.SenhaUsuario = Eramake.eCryptography.Encrypt(PaswordTextBox.Text)
                hr.Usuario_tb.Add(us)
                hr.SaveChanges()
                MetroFramework.MetroMessageBox.Show(Me, "Salvado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UsuarioBindingSource.DataSource = hr.Usuario_tb.ToList()
                Me.Close()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "A senha repetida nao e igual. por favor coloque a senha correcta ", "Senha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub PaswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PaswordTextBox.TextChanged
        If PaswordTextBox.TextLength >= 8 Then
            Label3.Text = "Suficiente"
        Else
            Label3.Text = "Insuficiente"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = PaswordTextBox.Text Then
            Label4.Text = "Correcto"
        Else
            Label4.Text = "Incorrecto"
        End If
    End Sub
End Class