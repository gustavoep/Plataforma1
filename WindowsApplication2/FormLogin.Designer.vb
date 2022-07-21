<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtSenha
        '
        Me.TxtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSenha.Location = New System.Drawing.Point(163, 202)
        Me.TxtSenha.MaxLength = 30
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(276, 26)
        Me.TxtSenha.TabIndex = 2
        '
        'TxtLogin
        '
        Me.TxtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLogin.Location = New System.Drawing.Point(163, 133)
        Me.TxtLogin.MaxLength = 15
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(276, 26)
        Me.TxtLogin.TabIndex = 1
        '
        'BtnEntrar
        '
        Me.BtnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEntrar.FlatAppearance.BorderSize = 2
        Me.BtnEntrar.Font = New System.Drawing.Font("BankGothic Lt BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrar.Location = New System.Drawing.Point(163, 260)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(129, 52)
        Me.BtnEntrar.TabIndex = 15
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Usuário"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("BankGothic Lt BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 28)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Plataforma SensorGreen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("BankGothic Lt BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(470, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Faça login com seu nome de usuário e senha"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("BankGothic Lt BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(299, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 52)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Sair"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(488, 348)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.TxtLogin)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormLogin"
        Me.Text = "Login Plataforma SensorGreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
