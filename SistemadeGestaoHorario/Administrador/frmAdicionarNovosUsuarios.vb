Imports System.Security.Cryptography
Imports System.Text

Public Class frmAdicionarNovosUsuarios
    Dim db As GestHorarioEntities = New GestHorarioEntities()

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

    Private Sub frmAdicionarNovosUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Usuario_tbBindingSource.DataSource = db.Usuario_tb.ToList()
    End Sub

    Private Shared Function Encrypt(value As String) As String
        Using md5 As New MD5CryptoServiceProvider()
            Dim utf8 As New UTF8Encoding()
            Dim data As Byte() = md5.ComputeHash(utf8.GetBytes(value))
            Return Convert.ToBase64String(data)
        End Using
    End Function

    Public Sub Limpar()
        Nome_CompletoTextBox.Clear()
        Nome_UsuarioTextBox.Clear()
        PaswordTextBox.Clear()
        TextBox1.Clear()
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
                MetroFramework.MetroMessageBox.Show(Me, "Usuario  adicionado com sucesso!", "Novo Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Usuario_tbBindingSource.DataSource = db.Usuario_tb.ToList()
                Limpar()

            Else

                MetroFramework.MetroMessageBox.Show(Me, "O Usuario nao pode ser adicionado, porque as sehnas nao conscidem!", "Novo Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error nº 2: " + ex.Message, "Por favor Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Dim idUsuario As Integer
    Dim Nome As String

    Private Sub Usuario_tbDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Usuario_tbDataGridView.CellClick
        Try
            idUsuario = Integer.Parse(Usuario_tbDataGridView.CurrentRow.Cells(0).Value.ToString())
            Nome = Usuario_tbDataGridView.CurrentRow.Cells(1).Value.ToString()

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub resertarSenhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles resertarSenhaToolStripMenuItem.Click
        Try
            If idUsuario <> 0 Then
                Dim fb As frmResertarSenha = New frmResertarSenha()
                fb.idUsuaro = idUsuario
                fb.metroButton1.Visible = True
                fb.metroButton2.Visible = False
                fb.Nome = Nome
                fb.ShowDialog()
                Usuario_tbBindingSource.DataSource = db.Usuario_tb.ToList()

            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class