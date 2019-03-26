Public Class frmSobre

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim abr As New frmHistorico()
        abr.ShowDialog()
    End Sub
End Class