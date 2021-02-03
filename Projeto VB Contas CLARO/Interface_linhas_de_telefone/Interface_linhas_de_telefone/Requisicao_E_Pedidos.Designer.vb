<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Requisicao_E_Pedidos
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
        Me.cmb_filial = New System.Windows.Forms.ComboBox()
        Me.Txt_Req = New System.Windows.Forms.TextBox()
        Me.TxT_Ped = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.dgv_view = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_filial
        '
        Me.cmb_filial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_filial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_filial.FormattingEnabled = True
        Me.cmb_filial.Items.AddRange(New Object() {"Todos"})
        Me.cmb_filial.Location = New System.Drawing.Point(93, 62)
        Me.cmb_filial.Name = "cmb_filial"
        Me.cmb_filial.Size = New System.Drawing.Size(159, 27)
        Me.cmb_filial.TabIndex = 0
        '
        'Txt_Req
        '
        Me.Txt_Req.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Req.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Req.Location = New System.Drawing.Point(374, 63)
        Me.Txt_Req.Name = "Txt_Req"
        Me.Txt_Req.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Req.TabIndex = 1
        '
        'TxT_Ped
        '
        Me.TxT_Ped.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxT_Ped.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxT_Ped.Location = New System.Drawing.Point(566, 64)
        Me.TxT_Ped.Name = "TxT_Ped"
        Me.TxT_Ped.Size = New System.Drawing.Size(100, 26)
        Me.TxT_Ped.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(37, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filial:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(267, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Requisição:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(491, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pedido:"
        '
        'btn_insert
        '
        Me.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_insert.Location = New System.Drawing.Point(720, 62)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 6
        Me.btn_insert.Text = "Inserir"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'dgv_view
        '
        Me.dgv_view.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_view.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_view.Location = New System.Drawing.Point(12, 140)
        Me.dgv_view.Name = "dgv_view"
        Me.dgv_view.Size = New System.Drawing.Size(811, 243)
        Me.dgv_view.TabIndex = 7
        '
        'Requisicao_E_Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Interface_linhas_de_telefone.My.Resources.Resources.aPrancheta_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(853, 460)
        Me.Controls.Add(Me.dgv_view)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxT_Ped)
        Me.Controls.Add(Me.Txt_Req)
        Me.Controls.Add(Me.cmb_filial)
        Me.Name = "Requisicao_E_Pedidos"
        Me.Text = "Requisição e Pedidos "
        CType(Me.dgv_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_filial As ComboBox
    Friend WithEvents Txt_Req As TextBox
    Friend WithEvents TxT_Ped As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents dgv_view As DataGridView
End Class
