<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRemetente = New System.Windows.Forms.TextBox()
        Me.TxtMensagem = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LblAnexo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnEnviar.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.Location = New System.Drawing.Point(32, 381)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(316, 45)
        Me.BtnEnviar.TabIndex = 0
        Me.BtnEnviar.Text = "Enviar para processamento"
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID do Laboratório"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Informe os elementos desejados"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 50)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Carregar dados espectrais (Clique duas vezes)"
        '
        'TxtRemetente
        '
        Me.TxtRemetente.Location = New System.Drawing.Point(220, 46)
        Me.TxtRemetente.Name = "TxtRemetente"
        Me.TxtRemetente.Size = New System.Drawing.Size(128, 20)
        Me.TxtRemetente.TabIndex = 6
        '
        'TxtMensagem
        '
        Me.TxtMensagem.Location = New System.Drawing.Point(32, 124)
        Me.TxtMensagem.Multiline = True
        Me.TxtMensagem.Name = "TxtMensagem"
        Me.TxtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtMensagem.Size = New System.Drawing.Size(316, 82)
        Me.TxtMensagem.TabIndex = 9
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LblAnexo
        '
        Me.LblAnexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAnexo.Location = New System.Drawing.Point(32, 306)
        Me.LblAnexo.Name = "LblAnexo"
        Me.LblAnexo.Size = New System.Drawing.Size(316, 25)
        Me.LblAnexo.TabIndex = 10
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(391, 450)
        Me.Controls.Add(Me.LblAnexo)
        Me.Controls.Add(Me.TxtMensagem)
        Me.Controls.Add(Me.TxtRemetente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Name = "Form3"
        Me.Text = "Enviar email com os dados espectrais"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEnviar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRemetente As TextBox
    Friend WithEvents TxtMensagem As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LblAnexo As Label
End Class
