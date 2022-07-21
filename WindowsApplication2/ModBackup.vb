Imports System.IO

Module ModBackup

    Private bancoDados = "usuarios.accdb"
    Private arquivoOrigem = "D:\plataforma\" + bancoDados
    Private pastaDestinoBase = "D:\plataforma\backup"

    Public ReadOnly connn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + arquivoOrigem + ";Persist Secuirty Info=True"

    Public Sub FazerCopia()
        Dim pastaDestino = ObterPastaDestino(pastaDestinoBase)

        If CriarPasta(pastaDestinoBase) Then
            If CriarPasta(pastaDestino) Then
                Try
                    File.Copy(arquivoOrigem, pastaDestino + "\" + bancoDados)
                Catch ex As Exception
                    MessageBox.Show("Falha ao fazer a cópia de segurança." + vbCrLf + ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Function CriarPasta(pasta As String) As Boolean
        Try
            If (Directory.Exists(pasta)) Then
                Return True
            Else
                Directory.CreateDirectory(pasta)
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Falha: " + ex.Message)
            Return False

        End Try
    End Function


    Private Function ObterPastaDestino(destinoBase As String) As String
        Dim hoje = Date.Today
        Dim diaSemana = hoje.DayOfWeek

        Select Case diaSemana
            Case 0
                Return destinoBase + "\1-domingo"
            Case 1
                Return destinoBase + "\2-segunda-feira"
            Case 2
                Return destinoBase + "\3-terça-feira"
            Case 3
                Return destinoBase + "\4-quarta-feira"
            Case 4
                Return destinoBase + "\5-quinta-feira"
            Case 5
                Return destinoBase + "\6-sexta-feira"
            Case 6
                Return destinoBase + "\7-sabado"
            Case 7
                Return destinoBase + "\1-domingo"
        End Select

        Return destinoBase
    End Function

End Module
