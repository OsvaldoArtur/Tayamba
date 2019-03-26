Imports System.IO
Imports FoxLearn.License



Public Class frmPrincipal

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim abrir As New frmFaculdade()
        abrir.ShowDialog()

    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Dim abrir As New frmUsuario()
        abrir.ShowDialog()
    End Sub

    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem.Click
        Dim abrir As New frmDepartamento()
        abrir.ShowDialog()
    End Sub

    Private Sub DocenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocenteToolStripMenuItem.Click
        Dim abrir As New frmDocente()
        abrir.ShowDialog()
    End Sub

    Private Sub CursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursoToolStripMenuItem.Click
        Dim abrir As New frmCursos()
        abrir.ShowDialog()
    End Sub

    Private Sub CadeiraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadeiraToolStripMenuItem.Click
        Dim abrir As New frmCadeira()
        abrir.ShowDialog()
    End Sub

    Private Sub SemanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SemanaToolStripMenuItem.Click
        Dim abrir As New frmSemana()
        abrir.ShowDialog()
    End Sub

    Private Sub HorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorasToolStripMenuItem.Click
        Dim abrir As New frmHoras()
        abrir.ShowDialog()
    End Sub

    Private Sub PeridoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeridoToolStripMenuItem.Click
        Dim abrir As New frmPeriodo()
        abrir.ShowDialog()
    End Sub

    Private Sub CriarHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriarHorarioToolStripMenuItem.Click
        Dim abrir As New frmEntradaHorario()
        abrir.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SalaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaToolStripMenuItem.Click
        Dim abrir As New frmSalas()
        abrir.ShowDialog()
    End Sub

    Private Sub CriarHorarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CriarHorarioToolStripMenuItem1.Click
        Dim abrir As New frmHorarios()
        abrir.ShowDialog()
    End Sub

    Private Sub ListaDeHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeHorarioToolStripMenuItem.Click
        Dim abrir As New frmEntradaHorario()
        abrir.ShowDialog()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        Dim abrir As New frmSobre()
        abrir.ShowDialog()
    End Sub

    Private Sub HorarioDoDocenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorarioDoDocenteToolStripMenuItem.Click
        Dim abrir As New frmEscolhadeDocente()
        abrir.ShowDialog()
    End Sub


    Private Sub SobreToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem1.Click
        Dim abrir As New frmSobre()
        abrir.ShowDialog()
    End Sub

    Private Sub ImprimirHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirHorarioToolStripMenuItem.Click
        Dim abri As New frmImprimirHorario()
        abri.ShowDialog()
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click

    End Sub

    Private Sub ToolStripStatusLabel3_DoubleClick(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.DoubleClick
        Try
            Dim abrir As New frmFaculdade()
            Dim si As New GestHorarioEntities()
            Dim procura As Object = (From d In si.Faculdade_tb Where d.Nome_Extensao.Equals(ToolStripStatusLabel2.Text) Select d).Count()
            Dim leva As Object = (From d In si.Faculdade_tb Where d.Nome_Extensao.Equals(ToolStripStatusLabel2.Text) Select d).FirstOrDefault()
            If procura = 1 Then
                abrir.idFaculdade = leva.idFaculdade.ToString()
                abrir.Nome_FaculdadeTextBox.Text = leva.Nome_Universidade.ToString()
                abrir.TextBox1.Text = leva.Nome_Extensao.ToString()
                abrir.PictureBox1.Image = ConvertBinaryToImage(leva.logotipo)
                abrir.Button2.Visible = False
                abrir.Button1.Visible = True
                abrir.ShowDialog()
            End If

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Function ConvertBinaryToImage(data As Byte()) As Image
        Using ms As New MemoryStream(data)

            Return Image.FromStream(ms)
        End Using
    End Function

    Private Sub HorarioDoDocenteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HorarioDoDocenteToolStripMenuItem1.Click
        Dim abrir As New frmEscolhadeDocente()
        abrir.ShowDialog()
    End Sub

    Private Sub HorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorariosToolStripMenuItem.Click
        Dim abri As New frmImprimirHorario()
        abri.ShowDialog()
    End Sub
    Public Property idUsuario As Integer

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim abri As New frmMudarSenhaUsuario()
        abri.idUsuario = idUsuario
        abri.ShowDialog()
    End Sub



    Private Sub SobreToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem2.Click
        Dim abrir As New frmSobre()
        abrir.ShowDialog()
    End Sub
    Dim si As New GestHorarioEntities()

    Private Sub ProcuraAno()
        Try
            Dim procur = si.Ano_tb.Where(Function(d) d.Ano = DateAndTime.Now.Year).Count()
            If procur <> 0 Then

            Else

                Dim adicionaAno As New Ano_tb()
                adicionaAno.Ano = DateAndTime.Now.Year
                si.Ano_tb.Add(adicionaAno)
                si.SaveChanges()

            End If
        Catch ex As Exception
            Return
        End Try

    End Sub
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'licencsa()
        ProcuraAno()

        Dim leva As Object = (From d In si.Faculdade_tb Where d.Nome_Extensao.Equals(ToolStripStatusLabel2.Text) Select d).FirstOrDefault()
        PictureBox2.Image = ConvertBinaryToImage(leva.logotipo)

    End Sub

    Private Sub GerarLicencaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerarLicencaToolStripMenuItem.Click
        Try
            Dim ab As New frmGerar()
            ab.ShowDialog()
            licencsa()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub LicenciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicenciarToolStripMenuItem.Click
        Try
            Dim ab As New frmRegistrar()
            ab.ShowDialog()
            licencsa()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub EstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoToolStripMenuItem.Click
        Try
            Dim ab As New frmSobreLicenca()
            ab.ShowDialog()
            licencsa()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Dim lblProductID As String
    Dim lblProductKey As String
    Dim lblLicenceType As String
    Private Sub licencsa()

        Try
            Dim contaLicenca = si.Licenca_tb.Count()
            If contaLicenca <> 0 Then
                Dim lev As Licenca_tb = si.Licenca_tb.FirstOrDefault()


                Dim data = Eramake.eCryptography.Decrypt((lev.Expiration.ToString()))
                Dim dataexpira As Date = data

                lblLicenceType = String.Format("{0} dias", (dataexpira - DateTime.Now.Date).Days)
                ToolStripStatusLabel5.Text = lblLicenceType
                If dataexpira <= DateTime.Now.Date Then
                    MenuStrip1.Enabled = False
                    MetroFramework.MetroMessageBox.Show(Me, "Licença expirada, por favor contacte o administrador do sistema." + vbNewLine + "Obrigado!", "Licença Expirada.", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else
                    MenuStrip1.Enabled = True
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Sistema nao Licenciado , por favor contacte o administrador do sistema." + vbNewLine + "Obrigado!", "Sistema nao Licenciado.", MessageBoxButtons.OK, MessageBoxIcon.Error)

                MenuStrip1.Enabled = False
            End If


        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub NovoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoUsuarioToolStripMenuItem.Click
        Try
            Dim ab As New frmAddUser()
            ab.ShowDialog()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class
