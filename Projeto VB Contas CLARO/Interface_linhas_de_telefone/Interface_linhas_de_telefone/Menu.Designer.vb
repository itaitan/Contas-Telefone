<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdicionarAlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentaçõesDeLinhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiscalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDPVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.requisicao = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserirPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarAlterarToolStripMenuItem, Me.InicioToolStripMenuItem, Me.requisicao, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdicionarAlterarToolStripMenuItem
        '
        Me.AdicionarAlterarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripMenuItem, Me.AlterarToolStripMenuItem, Me.MovimentaçõesDeLinhaToolStripMenuItem})
        Me.AdicionarAlterarToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdicionarAlterarToolStripMenuItem.Name = "AdicionarAlterarToolStripMenuItem"
        Me.AdicionarAlterarToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.AdicionarAlterarToolStripMenuItem.Text = "Linhas Telefonicas"
        '
        'AdicionarToolStripMenuItem
        '
        Me.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        Me.AdicionarToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AdicionarToolStripMenuItem.Text = "Adicionar nova linha"
        '
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AlterarToolStripMenuItem.Text = "Alterar linha existente"
        '
        'MovimentaçõesDeLinhaToolStripMenuItem
        '
        Me.MovimentaçõesDeLinhaToolStripMenuItem.Name = "MovimentaçõesDeLinhaToolStripMenuItem"
        Me.MovimentaçõesDeLinhaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MovimentaçõesDeLinhaToolStripMenuItem.Text = "Vinculos Telefônicos"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaDPToolStripMenuItem, Me.ConsultaGeralToolStripMenuItem, Me.FiscalToolStripMenuItem, Me.ConsultaDPVendasToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.InicioToolStripMenuItem.Text = "Consultar"
        '
        'ConsultaDPToolStripMenuItem
        '
        Me.ConsultaDPToolStripMenuItem.Name = "ConsultaDPToolStripMenuItem"
        Me.ConsultaDPToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ConsultaDPToolStripMenuItem.Text = "Consulta DP"
        '
        'ConsultaGeralToolStripMenuItem
        '
        Me.ConsultaGeralToolStripMenuItem.Name = "ConsultaGeralToolStripMenuItem"
        Me.ConsultaGeralToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ConsultaGeralToolStripMenuItem.Text = "Consulta Geral"
        '
        'FiscalToolStripMenuItem
        '
        Me.FiscalToolStripMenuItem.Name = "FiscalToolStripMenuItem"
        Me.FiscalToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.FiscalToolStripMenuItem.Text = "Consulta Fiscal"
        '
        'ConsultaDPVendasToolStripMenuItem
        '
        Me.ConsultaDPVendasToolStripMenuItem.Name = "ConsultaDPVendasToolStripMenuItem"
        Me.ConsultaDPVendasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ConsultaDPVendasToolStripMenuItem.Text = "Consulta DP Vendas"
        '
        'requisicao
        '
        Me.requisicao.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InserirPedidosToolStripMenuItem})
        Me.requisicao.Name = "requisicao"
        Me.requisicao.Size = New System.Drawing.Size(141, 20)
        Me.requisicao.Text = "Requisição e Pedidos"
        '
        'InserirPedidosToolStripMenuItem
        '
        Me.InserirPedidosToolStripMenuItem.Name = "InserirPedidosToolStripMenuItem"
        Me.InserirPedidosToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.InserirPedidosToolStripMenuItem.Text = "Inserir Requisição e Pedidos"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Image = Global.Interface_linhas_de_telefone.My.Resources.Resources.icons8_ajuda_30
        Me.Label2.Location = New System.Drawing.Point(763, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "   "
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Vinculos Telefônicos"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.Interface_linhas_de_telefone.My.Resources.Resources._25_04_Comenrcial001_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestão de Linhas Telefonicas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarAlterarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaGeralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiscalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDPVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents requisicao As ToolStripMenuItem
    Friend WithEvents InserirPedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents MovimentaçõesDeLinhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
