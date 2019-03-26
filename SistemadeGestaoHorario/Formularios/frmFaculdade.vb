Imports System.IO

Public Class frmFaculdade
    Dim hr As New GestHorarioEntities()
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Faculdade_tbBindingSource.AddNew()
    End Sub

    Private Function ConvertImageToBinary(img As Image) As Byte()
        Using ms As New MemoryStream()
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function


    Dim filename As String

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
                Faculdade_tbBindingSource.DataSource = hr.Faculdade_tb.ToList()
                Me.Close()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub frmFaculdade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Faculdade_tbBindingSource.DataSource = hr.Faculdade_tb.ToList()

    End Sub
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
            Return
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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
                Faculdade_tbBindingSource.DataSource = hr.Faculdade_tb.ToList()
                Me.Close()
            End If

        Catch ex As Exception
            Return
        End Try
    End Sub
End Class