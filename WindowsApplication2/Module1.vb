Module Module1

    Public sistema = "Controle de acesso"

    Public conn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = D:\plataforma\usuarios.accdb; Persist Security Info = False"
    Public con = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = D:\plataforma\amostras.accdb; Persist Security Info = False"

    Public pIdUsuario As Integer
    Public pNomeUsuario As String
    Public pAdministrador As Boolean
    Public pAcessoPermitido = False
    Public pId As Long

End Module