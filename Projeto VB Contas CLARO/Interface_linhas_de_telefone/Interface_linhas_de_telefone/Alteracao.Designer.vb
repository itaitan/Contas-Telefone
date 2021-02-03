<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alteracao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alteracao))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtDp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_fill = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.cmbCel = New System.Windows.Forms.ComboBox()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(156, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Desconto:"
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_save.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(223, 339)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(98, 28)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "Salvar"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(174, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Código:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(140, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Funcionário:"
        '
        'TxtCod
        '
        Me.TxtCod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCod.Enabled = False
        Me.TxtCod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(264, 214)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(102, 26)
        Me.TxtCod.TabIndex = 7
        '
        'TxtNome
        '
        Me.TxtNome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNome.Enabled = False
        Me.TxtNome.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(264, 108)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(272, 26)
        Me.TxtNome.TabIndex = 4
        '
        'TxtDp
        '
        Me.TxtDp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDp.Enabled = False
        Me.TxtDp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDp.Location = New System.Drawing.Point(264, 143)
        Me.TxtDp.Name = "TxtDp"
        Me.TxtDp.Size = New System.Drawing.Size(272, 26)
        Me.TxtDp.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(189, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Setor:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(176, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Celular:"
        '
        'btn_fill
        '
        Me.btn_fill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_fill.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fill.Location = New System.Drawing.Point(414, 72)
        Me.btn_fill.Name = "btn_fill"
        Me.btn_fill.Size = New System.Drawing.Size(25, 26)
        Me.btn_fill.TabIndex = 2
        Me.btn_fill.Text = "..."
        Me.btn_fill.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_del.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(397, 339)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(98, 28)
        Me.btn_del.TabIndex = 0
        Me.btn_del.Text = "Deletar"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'cmbCel
        '
        Me.cmbCel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbCel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCel.FormattingEnabled = True
        Me.cmbCel.Location = New System.Drawing.Point(264, 71)
        Me.cmbCel.Name = "cmbCel"
        Me.cmbCel.Size = New System.Drawing.Size(144, 27)
        Me.cmbCel.TabIndex = 1
        '
        'TxtDesc
        '
        Me.TxtDesc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDesc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(264, 179)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(272, 26)
        Me.TxtDesc.TabIndex = 6
        '
        'btn_clear
        '
        Me.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(445, 72)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(91, 25)
        Me.btn_clear.TabIndex = 3
        Me.btn_clear.Text = "Limpar"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Image = Global.Interface_linhas_de_telefone.My.Resources.Resources.icons8_ajuda_45
        Me.Label3.Location = New System.Drawing.Point(648, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 33)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "    "
        '
        'Alteracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Interface_linhas_de_telefone.My.Resources.Resources.aPrancheta_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(707, 376)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.cmbCel)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_fill)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDesc)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.TxtDp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Alteracao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu > Alterar funcionario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtDp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_fill As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents cmbCel As ComboBox
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label3 As Label
End Class
