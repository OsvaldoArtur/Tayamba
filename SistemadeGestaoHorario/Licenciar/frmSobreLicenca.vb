Imports FoxLearn.License

Public Class frmSobreLicenca
    Dim si As New GestHorarioEntities()

    Const ProductCode As Integer = 1
    Private Sub frmSobreLicenca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        lblProductID.Text = ComputerInfo.GetComputerId()
        '    Dim km As KeyManager = New KeyManager(lblProductID.Text)
        '    Dim lic As LicenseInfo = New LicenseInfo()
        '    Dim value As Integer = km.LoadSuretyFile(String.Format("{0}\key.lic", Application.StartupPath), lic)
        '    Dim productkey As String = lic.ProductKey
        '    If km.ValidKey(productkey) Then
        '        Dim kv As KeyValuesClass = New KeyValuesClass()
        '        If km.DisassembleKey(productkey, kv) Then
        '            lblProductName.Text = "Sistema de Gestao de Horario"
        '            lblProductKey.Text = productkey
        '            If kv.Type = LicenseType.TRIAL Then
        '                lblLicenceType.Text = String.Format("{0} days", (kv.Expiration - DateTime.Now.Date).Days)
        '            End If

        '        End If
        '    End If
        'Catch ex As Exception
        '    Return
        'End Try



        Try
            Dim contaLicenca = si.Licenca_tb.Count()
            If contaLicenca <> 0 Then
                Dim lev As Licenca_tb = si.Licenca_tb.FirstOrDefault()


                Dim data = Eramake.eCryptography.Decrypt((lev.Expiration.ToString()))
                Dim dataexpira As Date = data
                lblProductKey.Text = Eramake.eCryptography.Decrypt(lev.ProductoKey.ToString())
                lblLicenceTyp = String.Format("{0} dias", (dataexpira - DateTime.Now.Date).Days)
                lblLicenceType.Text = lblLicenceTyp
                lblProductName.Text = Eramake.eCryptography.Decrypt(lev.FullName.ToString())

            End If


        Catch ex As Exception
            Return
        End Try

    End Sub



    Dim lblLicenceTyp As String
End Class