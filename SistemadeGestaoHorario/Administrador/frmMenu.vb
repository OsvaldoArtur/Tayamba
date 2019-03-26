Imports System.IO

Public Class frmMenu
    Public Property Nome As String

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toolStripStatusLabel1.Text = Nome
    End Sub

    Private Sub sairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles sairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub novoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles novoUsuarioToolStripMenuItem.Click
        Try
            Dim dbs As frmAdicionarNovosUsuarios = New frmAdicionarNovosUsuarios()
            dbs.ShowDialog()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub recuperarSenhasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles recuperarSenhasToolStripMenuItem.Click
        Try
            Dim dbs As frmGerenciaAdministradores = New frmGerenciaAdministradores()
            dbs.ShowDialog()
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Function converImage(data As Byte()) As Image
        Using ms As New MemoryStream(data)
            Return Image.FromStream(ms)
        End Using
    End Function
    Private Sub detalhesDaInstituicaoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles detalhesDaInstituicaoToolStripMenuItem.Click
        Try
            Dim fm As frmFaculdade = New frmFaculdade()
            fm.Button1.Visible = True
            fm.ShowDialog()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error: " + ex.Message, "Por favor Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub sobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles sobreToolStripMenuItem.Click
        Try
            Dim ab As New frmSobre()
            ab.ShowDialog()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class