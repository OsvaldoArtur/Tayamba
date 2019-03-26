Module Referencia
    Public Sub Tulpepe()
        Dim popou As New Tulpep.NotificationWindow.PopupNotifier()
        popou.TitleText = "Tayamba"
        popou.TitleColor = Color.Black
        '    popou.BorderColor = Color.DarkGray
        popou.ContentText = "Bem vindo ao Tayamba, ajude-nos a crescer." + vbNewLine + "Enviando sugestoes de melhoramento nosso Sistema de Gestão de Horário!" + vbNewLine + "Contacte-nos: +258848046991." + vbNewLine + "Email: apgesdevelopers@gmail.com."
        popou.ContentColor = Color.Black
        popou.HeaderColor = Color.Aquamarine
        popou.BodyColor = Color.WhiteSmoke
        popou.Delay = 10000
        '    popou.ShowGrip = False
        popou.HeaderHeight = 12
        popou.Popup()
    End Sub

    Public tituloerro As String = "Error no Sistema"
    Public mensagemdeerror As String = "Ocorreu um erro no sistema, por favor contacte ao administrador do sistema! Reporte o caso detalhadamente ao Administrador do Sistema. Obrigado!"
    Public Sub MessagemErro()
    End Sub


End Module
