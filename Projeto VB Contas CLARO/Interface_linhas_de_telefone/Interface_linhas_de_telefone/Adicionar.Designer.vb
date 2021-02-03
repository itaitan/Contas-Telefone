<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Adicionar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adicionar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCel = New System.Windows.Forms.MaskedTextBox()
        Me.TxtDp = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.btn_sng = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.Ndados = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCargo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(208, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Celular:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(221, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Setor:"
        '
        'TxtCel
        '
        Me.TxtCel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCel.Location = New System.Drawing.Point(297, 245)
        Me.TxtCel.Mask = "(00) 00000-0000"
        Me.TxtCel.Name = "TxtCel"
        Me.TxtCel.Size = New System.Drawing.Size(128, 26)
        Me.TxtCel.TabIndex = 7
        '
        'TxtDp
        '
        Me.TxtDp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDp.Location = New System.Drawing.Point(298, 149)
        Me.TxtDp.Name = "TxtDp"
        Me.TxtDp.Size = New System.Drawing.Size(272, 26)
        Me.TxtDp.TabIndex = 4
        '
        'TxtNome
        '
        Me.TxtNome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNome.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(301, 86)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(270, 26)
        Me.TxtNome.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(170, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Funcionario:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(206, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Código:"
        '
        'TxtCod
        '
        Me.TxtCod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(301, 57)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(102, 26)
        Me.TxtCod.TabIndex = 1
        '
        'btn_sng
        '
        Me.btn_sng.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_sng.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sng.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_sng.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sng.Location = New System.Drawing.Point(165, 335)
        Me.btn_sng.Name = "btn_sng"
        Me.btn_sng.Size = New System.Drawing.Size(454, 27)
        Me.btn_sng.TabIndex = 8
        Me.btn_sng.Text = "Cadastrar"
        Me.btn_sng.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(188, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Desconto:"
        '
        'TxtDesc
        '
        Me.TxtDesc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDesc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(298, 181)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(102, 26)
        Me.TxtDesc.TabIndex = 5
        '
        'Ndados
        '
        Me.Ndados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ndados.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ndados.Location = New System.Drawing.Point(297, 277)
        Me.Ndados.Mask = "(00) 00000-0000"
        Me.Ndados.Name = "Ndados"
        Me.Ndados.Size = New System.Drawing.Size(128, 26)
        Me.Ndados.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(200, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "NDados:"
        '
        'TxtCargo
        '
        Me.TxtCargo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCargo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCargo.Location = New System.Drawing.Point(299, 118)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(272, 26)
        Me.TxtCargo.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label7.Location = New System.Drawing.Point(215, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Cargo:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label8.Location = New System.Drawing.Point(140, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Centro de custo:"
        '
        'txtCC
        '
        Me.txtCC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCC.Location = New System.Drawing.Point(298, 213)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(102, 26)
        Me.txtCC.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Image = Global.Interface_linhas_de_telefone.My.Resources.Resources.icons8_ajuda_45
        Me.Label9.Location = New System.Drawing.Point(741, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 33)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "    "
        '
        'Adicionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Interface_linhas_de_telefone.My.Resources.Resources.instaPrancheta_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCargo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Ndados)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDesc)
        Me.Controls.Add(Me.btn_sng)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.TxtDp)
        Me.Controls.Add(Me.TxtCel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Adicionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu > Cadastrar novo funcionario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCel As MaskedTextBox
    Friend WithEvents TxtDp As TextBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents btn_sng As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents Ndados As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCargo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCC As TextBox
    Friend WithEvents Label9 As Label
End Class
