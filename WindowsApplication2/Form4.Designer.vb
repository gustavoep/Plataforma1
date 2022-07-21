<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.BtnCopiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCopiar
        '
        Me.BtnCopiar.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnCopiar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopiar.Location = New System.Drawing.Point(70, 39)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(88, 42)
        Me.BtnCopiar.TabIndex = 0
        Me.BtnCopiar.Text = "Backup"
        Me.BtnCopiar.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(241, 117)
        Me.Controls.Add(Me.BtnCopiar)
        Me.Name = "Form4"
        Me.Text = "Cópia de segurança"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCopiar As Button
End Class
