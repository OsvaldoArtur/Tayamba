Imports FoxLearn.License
Imports System.Security.Cryptography
Imports System.Text
Imports Eramake.eCryptography

Public Class frmRegistrar
    Dim si As New GestHorarioEntities()


    Const ProductCode As Integer = 1
    Public Property prodcod As String
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click


        Try
            Dim km As KeyManager = New KeyManager(txtProductId.Text)
            Dim productkey As String = txtProductKey.Text
            If km.ValidKey(productkey) Then
                Dim kv As KeyValuesClass = New KeyValuesClass()
                If km.DisassembleKey(productkey, kv) Then
                    Dim lic As LicenseInfo = New LicenseInfo()
                    lic.ProductKey = productkey
                    lic.FullName = "Sistema de Gestao de Horario"
                    If kv.Type = LicenseType.TRIAL Then
                        lic.Day = kv.Expiration.Day
                        lic.Month = kv.Expiration.Month
                        lic.Year = kv.Expiration.Year
                        Dim dia = lic.Day
                        Dim mes = lic.Month
                        Dim ano = lic.Year
                        Dim cont = si.Licenca_tb.Count()
                        If cont <> 0 Then
                            Dim abs As Licenca_tb = si.Licenca_tb.FirstOrDefault()
                            abs.Ano = Eramake.eCryptography.Encrypt(ano)
                            abs.Dia = Eramake.eCryptography.Encrypt(dia)
                            abs.Mes = Eramake.eCryptography.Encrypt(mes)
                            abs.FullName = Eramake.eCryptography.Encrypt(lic.FullName)
                            abs.ProductoKey = Eramake.eCryptography.Encrypt(lic.ProductKey)
                            abs.TypeLicenc = Eramake.eCryptography.Encrypt(kv.Type)
                            abs.Expiration = Eramake.eCryptography.Encrypt(lic.CheckDate.ToString())
                            si.SaveChanges()
                            MessageBox.Show("You Have Been Successfully registered.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Dim ab As Licenca_tb = New Licenca_tb()
                            ab.Ano = Eramake.eCryptography.Encrypt(ano)
                            ab.Dia = Eramake.eCryptography.Encrypt(dia)
                            ab.Mes = Eramake.eCryptography.Encrypt(mes)
                            ab.FullName = Eramake.eCryptography.Encrypt(lic.FullName)
                            ab.ProductoKey = Eramake.eCryptography.Encrypt(lic.ProductKey)
                            ab.TypeLicenc = Eramake.eCryptography.Encrypt(kv.Type)
                            ab.Expiration = Eramake.eCryptography.Encrypt(lic.CheckDate.ToString())
                            si.Licenca_tb.Add(ab)
                            si.SaveChanges()
                            MessageBox.Show("You Have Been Successfully registered.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        Me.Close()
                    End If

                End If
            Else
                MessageBox.Show("You product  key is Invalid.", "Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])

            End If
        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub frmRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtProductId.Text = ComputerInfo.GetComputerId()
            txtProductKey.Text = prodcod
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class