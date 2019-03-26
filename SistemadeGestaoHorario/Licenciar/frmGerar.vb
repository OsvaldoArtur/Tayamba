Imports FoxLearn.License

Public Class frmGerar
    Const ProductCode As Integer = 1
    Private Sub btnGenerete_Click(sender As Object, e As EventArgs) Handles btnGenerete.Click
        Try
            Dim km As KeyManager = New KeyManager(txtProductId.Text)
            Dim kv As KeyValuesClass
            Dim productkey As String = String.Empty
            If cbLicenceType.SelectedIndex = 0 Then


                kv = New KeyValuesClass() With {.Type = LicenseType.TRIAL,
                                                .Header = Convert.ToByte(9),
                                                .Footer = Convert.ToByte(6),
                                                .ProductCode = CByte(ProductCode),
                                                .Edition = Edition.ENTERPRISE,
                                                .Version = 1,
                                                .Expiration = DateTime.Now.Date.AddDays(Convert.ToInt32(txtExperienceday.Text))}
                If Not km.GenerateKey(kv, productkey) Then
                    txtProductKey.Text = "Error"
                End If


            Else

            End If

            txtProductKey.Text = productkey
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub frmGerar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbLicenceType.SelectedIndex = 0
            txtProductId.Text = ComputerInfo.GetComputerId()
            btnGenerete.Enabled = False
            Button2.Enabled = False
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtUsuario.Text.Equals("oscavado@vado.com") AndAlso txtSenha.Text.Equals("admin@#199710") Then
                btnGenerete.Enabled = True
                Button2.Enabled = True
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Usuario ou Senha Incorreta!", "Error Tente Novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim ab As New frmRegistrar()
            ab.prodcod = txtProductKey.Text
            ab.ShowDialog()
            Me.Close()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class