Public Class frmCadeiraAdd
    Dim hr As New GestHorarioEntities()
    Public Property idCurso As Integer
    Public Property Semestre As Integer
    Public Property Ano As Integer

    Private Sub frmCadeiraAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CadeiratbBindingSource.DataSource = (From d In hr.Cadeira_tb Where d.idCurso = idCurso AndAlso d.Ano = Ano AndAlso d.Semestre = Semestre Select d).ToList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CBTipo.Checked = True Then
            Tipodecadeira = "Em Comum"
        Else
            Tipodecadeira = "Nao Comum"
        End If
        Try
            Dim dc As New Cadeira_tb()
            dc.Ano = Ano
            dc.Nome_Cadeira = Nome_CadeiraTextBox.Text
            dc.Semestre = Semestre
            dc.idCurso = idCurso
            dc.Credito_Cadeira = credito_textBox.Value
            dc.TipoCadeira = Tipodecadeira
            hr.Cadeira_tb.Add(dc)
            hr.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Cadeira Salva Com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nome_CadeiraTextBox.Clear()
            CadeiratbBindingSource.DataSource = (From d In hr.Cadeira_tb Where d.idCurso = idCurso AndAlso d.Ano = Ano AndAlso d.Semestre = Semestre Select d).ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Dim Tipodecadeira As String
End Class