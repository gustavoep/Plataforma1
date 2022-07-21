<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroDeAmostrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisNIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarDadosEspectraisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnálisesDeSolosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarbonoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArgilaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreiaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTCToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocarSenhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CópiaDeSegurançaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeAmostrasToolStripMenuItem, Me.CadastroToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.ControleToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(433, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroDeAmostrasToolStripMenuItem
        '
        Me.CadastroDeAmostrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QRCodeToolStripMenuItem})
        Me.CadastroDeAmostrasToolStripMenuItem.Name = "CadastroDeAmostrasToolStripMenuItem"
        Me.CadastroDeAmostrasToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.CadastroDeAmostrasToolStripMenuItem.Text = "Cadastrar amostras"
        '
        'QRCodeToolStripMenuItem
        '
        Me.QRCodeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SolosToolStripMenuItem})
        Me.QRCodeToolStripMenuItem.Name = "QRCodeToolStripMenuItem"
        Me.QRCodeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QRCodeToolStripMenuItem.Text = "Analise de Solos"
        '
        'SolosToolStripMenuItem
        '
        Me.SolosToolStripMenuItem.Name = "SolosToolStripMenuItem"
        Me.SolosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SolosToolStripMenuItem.Text = "Cadastrar QRCode"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisNIRToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.CadastroToolStripMenuItem.Text = "Envio de espectros"
        '
        'VisNIRToolStripMenuItem
        '
        Me.VisNIRToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnviarDadosEspectraisToolStripMenuItem})
        Me.VisNIRToolStripMenuItem.Name = "VisNIRToolStripMenuItem"
        Me.VisNIRToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.VisNIRToolStripMenuItem.Text = "Vis-NIR"
        '
        'EnviarDadosEspectraisToolStripMenuItem
        '
        Me.EnviarDadosEspectraisToolStripMenuItem.Name = "EnviarDadosEspectraisToolStripMenuItem"
        Me.EnviarDadosEspectraisToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.EnviarDadosEspectraisToolStripMenuItem.Text = "Enviar dados espectrais"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnálisesDeSolosToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ConsultaToolStripMenuItem.Text = "Resultados"
        '
        'AnálisesDeSolosToolStripMenuItem
        '
        Me.AnálisesDeSolosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarbonoToolStripMenuItem1, Me.ArgilaToolStripMenuItem1, Me.AreiaToolStripMenuItem1, Me.FerroToolStripMenuItem1, Me.CTCToolStripMenuItem1})
        Me.AnálisesDeSolosToolStripMenuItem.Name = "AnálisesDeSolosToolStripMenuItem"
        Me.AnálisesDeSolosToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AnálisesDeSolosToolStripMenuItem.Text = "Análises de solos"
        '
        'CarbonoToolStripMenuItem1
        '
        Me.CarbonoToolStripMenuItem1.Name = "CarbonoToolStripMenuItem1"
        Me.CarbonoToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.CarbonoToolStripMenuItem1.Text = "Carbono"
        '
        'ArgilaToolStripMenuItem1
        '
        Me.ArgilaToolStripMenuItem1.Name = "ArgilaToolStripMenuItem1"
        Me.ArgilaToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.ArgilaToolStripMenuItem1.Text = "Argila"
        '
        'AreiaToolStripMenuItem1
        '
        Me.AreiaToolStripMenuItem1.Name = "AreiaToolStripMenuItem1"
        Me.AreiaToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.AreiaToolStripMenuItem1.Text = "Areia"
        '
        'FerroToolStripMenuItem1
        '
        Me.FerroToolStripMenuItem1.Name = "FerroToolStripMenuItem1"
        Me.FerroToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.FerroToolStripMenuItem1.Text = "Ferro"
        '
        'CTCToolStripMenuItem1
        '
        Me.CTCToolStripMenuItem1.Name = "CTCToolStripMenuItem1"
        Me.CTCToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.CTCToolStripMenuItem1.Text = "CTC"
        '
        'ControleToolStripMenuItem
        '
        Me.ControleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrocarSenhaToolStripMenuItem, Me.CadastrarUsuárioToolStripMenuItem, Me.ConsultarUsuárioToolStripMenuItem, Me.CópiaDeSegurançaToolStripMenuItem})
        Me.ControleToolStripMenuItem.Name = "ControleToolStripMenuItem"
        Me.ControleToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ControleToolStripMenuItem.Text = "Controle"
        '
        'TrocarSenhaToolStripMenuItem
        '
        Me.TrocarSenhaToolStripMenuItem.Name = "TrocarSenhaToolStripMenuItem"
        Me.TrocarSenhaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TrocarSenhaToolStripMenuItem.Text = "Trocar senha"
        '
        'CadastrarUsuárioToolStripMenuItem
        '
        Me.CadastrarUsuárioToolStripMenuItem.Name = "CadastrarUsuárioToolStripMenuItem"
        Me.CadastrarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CadastrarUsuárioToolStripMenuItem.Text = "Cadastrar usuário"
        '
        'ConsultarUsuárioToolStripMenuItem
        '
        Me.ConsultarUsuárioToolStripMenuItem.Name = "ConsultarUsuárioToolStripMenuItem"
        Me.ConsultarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultarUsuárioToolStripMenuItem.Text = "Consultar usuário"
        '
        'CópiaDeSegurançaToolStripMenuItem
        '
        Me.CópiaDeSegurançaToolStripMenuItem.Name = "CópiaDeSegurançaToolStripMenuItem"
        Me.CópiaDeSegurançaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CópiaDeSegurançaToolStripMenuItem.Text = "Cópia de segurança"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(138, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(277, 23)
        Me.DateTimePicker1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(405, 274)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(433, 325)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plataforma SensorGreen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrocarSenhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisNIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeAmostrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnálisesDeSolosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarbonoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ArgilaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AreiaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FerroToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CTCToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EnviarDadosEspectraisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CópiaDeSegurançaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
