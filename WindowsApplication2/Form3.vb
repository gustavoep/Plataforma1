Imports System.Net.Mail

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        EnviarEmail()
    End Sub

    Private Sub EnviarEmail()
        Try
            Using smtp As New SmtpClient
                Using email As New MailMessage

                    smtp.Host = "smtp.sapo.pt"
                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New Net.NetworkCredential("sensorgreen@sapo.pt", "123888xD")
                    smtp.Port = 587
                    smtp.EnableSsl = False

                    email.From = New MailAddress("sensorgreen@sapo.pt")
                    email.To.Add(New MailAddress("sensorgreen@sapo.pt"))
                    email.Subject = TxtRemetente.Text
                    email.IsBodyHtml = False
                    email.Body = TxtMensagem.Text

                    If LblAnexo.Text <> "" Then
                        email.Attachments.Add(New Attachment(LblAnexo.Text))
                    End If

                    smtp.Send(email)

                End Using
            End Using
            MsgBox("Dados espectrais enviados! Em breve os resultados serão enviados em seu e-mail")
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub LblAnexo_DoubleClick(sender As Object, e As EventArgs) Handles LblAnexo.DoubleClick
        Dim anexo = New OpenFileDialog
        anexo.Title = "Anexar arquivos"
        If anexo.ShowDialog() = DialogResult.OK Then
            LblAnexo.Text = anexo.FileName
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub LblAnexo_Click(sender As Object, e As EventArgs) Handles LblAnexo.Click

    End Sub
End Class