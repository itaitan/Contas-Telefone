<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.TxtPass2 = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(244, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Adicionar Login"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(543, 320)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(51, 23)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "Sair"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(309, 320)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(152, 23)
        Me.btn_clear.TabIndex = 7
        Me.btn_clear.Text = "Limpar"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_create
        '
        Me.btn_create.Location = New System.Drawing.Point(156, 320)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(138, 23)
        Me.btn_create.TabIndex = 6
        Me.btn_create.Text = "Criar"
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'TxtPass2
        '
        Me.TxtPass2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass2.Location = New System.Drawing.Point(284, 203)
        Me.TxtPass2.Name = "TxtPass2"
        Me.TxtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass2.Size = New System.Drawing.Size(177, 26)
        Me.TxtPass2.TabIndex = 5
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(284, 167)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(177, 26)
        Me.TxtPass.TabIndex = 4
        '
        'TxtLog
        '
        Me.TxtLog.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLog.Location = New System.Drawing.Point(284, 130)
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.Size = New System.Drawing.Size(177, 26)
        Me.TxtLog.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(144, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repita senha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(205, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(208, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login:"
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Interface_linhas_de_telefone.My.Resources.Resources.aPrancheta_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(671, 355)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPass2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtLog)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cadastro"
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPass2 As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents TxtLog As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_create As Button
    Friend WithEvents Label4 As Label
End Class
