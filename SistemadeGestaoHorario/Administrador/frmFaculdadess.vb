Imports System.IO

Public Class frmFaculdadess
    Dim hr As GestHorarioEntities = New GestHorarioEntities()
    Private Sub frmFaculdadess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CerregarImage()
    End Sub
    Private Sub CerregarImage()
        Try
            Dim contaFaculdade = hr.Faculdade_tb.Count()
            If contaFaculdade <> 0 Then
                Dim leva = hr.Faculdade_tb.FirstOrDefault()
                Nome_FaculdadeTextBox.Text = leva.Nome_Universidade
                TextBox1.Text = leva.Nome_Extensao
                PictureBox1.Image = ConvertBinaryToImage(leva.logotipo)
                idFaculdade = leva.idFaculdade

            Else
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Function ConvertImageToBinary(img As Image) As Byte()
        Using ms As New MemoryStream()
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function
    Private Function ConvertBinaryToImage(data As Byte()) As Image
        Using ms As New MemoryStream(data)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Label2.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Insira imagem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim f As New Faculdade_tb()
                f.Nome_Universidade = Nome_FaculdadeTextBox.Text
                f.Nome_Extensao = TextBox1.Text
                f.logotipo = ConvertImageToBinary(PictureBox1.Image)
                hr.Faculdade_tb.Add(f)
                hr.SaveChanges()
                MetroFramework.MetroMessageBox.Show(Me, "Salvo com Sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '   Faculdade_tbBindingSource.DataSource = hr.Faculdade_tb.ToList()
                Me.Close()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error: " + ex.Message, "Por favor Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Dim filename As String
    Public Property idFaculdade As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim opena As New OpenFileDialog()
            opena.Filter = "JPG|*.jpg|PNG|*.png"
            opena.ValidateNames = True
            opena.Multiselect = False

            If opena.ShowDialog = Windows.Forms.DialogResult.OK Then
                filename = opena.FileName
                Label2.Text = filename
                PictureBox1.Image = Image.FromFile(filename)
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error: " + ex.Message, "Por favor Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Label2.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Insira imagem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim f As New Faculdade_tb()
                f = (From d In hr.Faculdade_tb Where d.idFaculdade = idFaculdade Select d).FirstOrDefault()
                f.Nome_Universidade = Nome_FaculdadeTextBox.Text
                f.Nome_Extensao = TextBox1.Text
                Try
                    f.logotipo = ConvertImageToBinary(PictureBox1.Image)
                Catch ex As Exception
                    Return
                End Try

                hr.SaveChanges()
                MetroFramework.MetroMessageBox.Show(Me, "Alterado com Sucesso!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Faculdade_tbBindingSource.DataSource = hr.Faculdade_tb.ToList()
                Me.Close()
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error: " + ex.Message, "Por favor Contacte o Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class