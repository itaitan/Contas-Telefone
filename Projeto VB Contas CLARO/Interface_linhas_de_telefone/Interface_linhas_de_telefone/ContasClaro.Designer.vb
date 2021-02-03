<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContasClaro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContasClaro))
        Me.cmb_telefone = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fun = New System.Windows.Forms.TextBox()
        Me.txt_TotalFatura = New System.Windows.Forms.TextBox()
        Me.txt_Ndados = New System.Windows.Forms.TextBox()
        Me.txt_TotalFun = New System.Windows.Forms.TextBox()
        Me.txt_Desconto = New System.Windows.Forms.TextBox()
        Me.txt_cargo = New System.Windows.Forms.TextBox()
        Me.txt_CentroCusto = New System.Windows.Forms.TextBox()
        Me.txt_setor = New System.Windows.Forms.TextBox()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_cargo = New System.Windows.Forms.Label()
        Me.Labe = New System.Windows.Forms.Label()
        Me.lblNDADOS = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbldesconto = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_Reserva = New System.Windows.Forms.Button()
        Me.btn_Vincular = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.cmb_ndados = New System.Windows.Forms.ComboBox()
        Me.btn_ndados = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.cmb_RVoz = New System.Windows.Forms.ComboBox()
        Me.cmb_Ndados_inclu = New System.Windows.Forms.ComboBox()
        Me.cmb_setores = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbFuncionario = New System.Windows.Forms.ComboBox()
        Me.txt_Filial = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmb_telefone
        '
        Me.cmb_telefone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_telefone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_telefone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_telefone.FormattingEnabled = True
        Me.cmb_telefone.Items.AddRange(New Object() {""})
        Me.cmb_telefone.Location = New System.Drawing.Point(201, 78)
        Me.cmb_telefone.Name = "cmb_telefone"
        Me.cmb_telefone.Size = New System.Drawing.Size(208, 27)
        Me.cmb_telefone.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(115, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Telefone:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_fun
        '
        Me.txt_fun.Enabled = False
        Me.txt_fun.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fun.Location = New System.Drawing.Point(201, 145)
        Me.txt_fun.Name = "txt_fun"
        Me.txt_fun.Size = New System.Drawing.Size(272, 26)
        Me.txt_fun.TabIndex = 9
        '
        'txt_TotalFatura
        '
        Me.txt_TotalFatura.Enabled = False
        Me.txt_TotalFatura.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalFatura.Location = New System.Drawing.Point(201, 337)
        Me.txt_TotalFatura.Name = "txt_TotalFatura"
        Me.txt_TotalFatura.Size = New System.Drawing.Size(272, 26)
        Me.txt_TotalFatura.TabIndex = 10
        '
        'txt_Ndados
        '
        Me.txt_Ndados.Enabled = False
        Me.txt_Ndados.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ndados.Location = New System.Drawing.Point(201, 401)
        Me.txt_Ndados.Name = "txt_Ndados"
        Me.txt_Ndados.Size = New System.Drawing.Size(272, 26)
        Me.txt_Ndados.TabIndex = 11
        '
        'txt_TotalFun
        '
        Me.txt_TotalFun.Enabled = False
        Me.txt_TotalFun.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalFun.Location = New System.Drawing.Point(202, 369)
        Me.txt_TotalFun.Name = "txt_TotalFun"
        Me.txt_TotalFun.Size = New System.Drawing.Size(272, 26)
        Me.txt_TotalFun.TabIndex = 13
        '
        'txt_Desconto
        '
        Me.txt_Desconto.Enabled = False
        Me.txt_Desconto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Desconto.Location = New System.Drawing.Point(201, 305)
        Me.txt_Desconto.Name = "txt_Desconto"
        Me.txt_Desconto.Size = New System.Drawing.Size(272, 26)
        Me.txt_Desconto.TabIndex = 14
        Me.txt_Desconto.Text = "0"
        '
        'txt_cargo
        '
        Me.txt_cargo.Enabled = False
        Me.txt_cargo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cargo.Location = New System.Drawing.Point(201, 273)
        Me.txt_cargo.Name = "txt_cargo"
        Me.txt_cargo.Size = New System.Drawing.Size(272, 26)
        Me.txt_cargo.TabIndex = 15
        '
        'txt_CentroCusto
        '
        Me.txt_CentroCusto.Enabled = False
        Me.txt_CentroCusto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CentroCusto.Location = New System.Drawing.Point(201, 241)
        Me.txt_CentroCusto.Name = "txt_CentroCusto"
        Me.txt_CentroCusto.Size = New System.Drawing.Size(272, 26)
        Me.txt_CentroCusto.TabIndex = 16
        '
        'txt_setor
        '
        Me.txt_setor.Enabled = False
        Me.txt_setor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_setor.Location = New System.Drawing.Point(201, 209)
        Me.txt_setor.Name = "txt_setor"
        Me.txt_setor.Size = New System.Drawing.Size(272, 26)
        Me.txt_setor.TabIndex = 17
        '
        'txt_cod
        '
        Me.txt_cod.Enabled = False
        Me.txt_cod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod.Location = New System.Drawing.Point(201, 177)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(272, 26)
        Me.txt_cod.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(133, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Setor:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(15, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Total de Funcionarios:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_cargo
        '
        Me.lbl_cargo.AutoSize = True
        Me.lbl_cargo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cargo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cargo.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_cargo.Location = New System.Drawing.Point(127, 276)
        Me.lbl_cargo.Name = "lbl_cargo"
        Me.lbl_cargo.Size = New System.Drawing.Size(62, 19)
        Me.lbl_cargo.TabIndex = 21
        Me.lbl_cargo.Text = "Cargo:"
        Me.lbl_cargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labe
        '
        Me.Labe.AutoSize = True
        Me.Labe.BackColor = System.Drawing.Color.Transparent
        Me.Labe.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labe.ForeColor = System.Drawing.Color.ForestGreen
        Me.Labe.Location = New System.Drawing.Point(61, 340)
        Me.Labe.Name = "Labe"
        Me.Labe.Size = New System.Drawing.Size(128, 19)
        Me.Labe.TabIndex = 22
        Me.Labe.Text = "Total da Fatura:"
        Me.Labe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNDADOS
        '
        Me.lblNDADOS.AutoSize = True
        Me.lblNDADOS.BackColor = System.Drawing.Color.Transparent
        Me.lblNDADOS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNDADOS.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblNDADOS.Location = New System.Drawing.Point(115, 404)
        Me.lblNDADOS.Name = "lblNDADOS"
        Me.lblNDADOS.Size = New System.Drawing.Size(75, 19)
        Me.lblNDADOS.TabIndex = 23
        Me.lblNDADOS.Text = "Ndados:"
        Me.lblNDADOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label7.Location = New System.Drawing.Point(49, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Centro de Custo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldesconto
        '
        Me.lbldesconto.AutoSize = True
        Me.lbldesconto.BackColor = System.Drawing.Color.Transparent
        Me.lbldesconto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesconto.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbldesconto.Location = New System.Drawing.Point(100, 308)
        Me.lbldesconto.Name = "lbldesconto"
        Me.lbldesconto.Size = New System.Drawing.Size(89, 19)
        Me.lbldesconto.TabIndex = 25
        Me.lbldesconto.Text = "Desconto:"
        Me.lbldesconto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label9.Location = New System.Drawing.Point(142, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 19)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Cod:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label10.Location = New System.Drawing.Point(82, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 19)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Funcionario:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label11.Location = New System.Drawing.Point(139, 436)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 19)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Filial:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Reserva
        '
        Me.btn_Reserva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Reserva.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_Reserva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reserva.Location = New System.Drawing.Point(477, 112)
        Me.btn_Reserva.Name = "btn_Reserva"
        Me.btn_Reserva.Size = New System.Drawing.Size(236, 27)
        Me.btn_Reserva.TabIndex = 31
        Me.btn_Reserva.Text = "Mover para Reserva Voz"
        Me.ToolTip1.SetToolTip(Me.btn_Reserva, "Move o NVoz selecionado para Reserva Voz e desvincula do funcionário")
        Me.btn_Reserva.UseVisualStyleBackColor = True
        '
        'btn_Vincular
        '
        Me.btn_Vincular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Vincular.Enabled = False
        Me.btn_Vincular.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_Vincular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Vincular.Location = New System.Drawing.Point(479, 477)
        Me.btn_Vincular.Name = "btn_Vincular"
        Me.btn_Vincular.Size = New System.Drawing.Size(94, 28)
        Me.btn_Vincular.TabIndex = 32
        Me.btn_Vincular.Text = "Vincular"
        Me.ToolTip1.SetToolTip(Me.btn_Vincular, "Salvar alterações após ter clicado em ""Modificar Campos""")
        Me.btn_Vincular.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_Modificar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modificar.Location = New System.Drawing.Point(199, 477)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(273, 28)
        Me.btn_Modificar.TabIndex = 34
        Me.btn_Modificar.Text = "Vincular funcionário"
        Me.ToolTip1.SetToolTip(Me.btn_Modificar, "Usar esse botão para vincular um funcionário a um telefone.")
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'cmb_ndados
        '
        Me.cmb_ndados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_ndados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_ndados.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ndados.FormattingEnabled = True
        Me.cmb_ndados.Items.AddRange(New Object() {""})
        Me.cmb_ndados.Location = New System.Drawing.Point(202, 400)
        Me.cmb_ndados.Name = "cmb_ndados"
        Me.cmb_ndados.Size = New System.Drawing.Size(271, 27)
        Me.cmb_ndados.TabIndex = 35
        '
        'btn_ndados
        '
        Me.btn_ndados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ndados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_ndados.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ndados.Location = New System.Drawing.Point(477, 400)
        Me.btn_ndados.Name = "btn_ndados"
        Me.btn_ndados.Size = New System.Drawing.Size(236, 27)
        Me.btn_ndados.TabIndex = 36
        Me.btn_ndados.Text = "Mover para Reserva Dados"
        Me.ToolTip1.SetToolTip(Me.btn_ndados, "Mover o NDados selecionado para Reserva Dados e desvincula do funcionário")
        Me.btn_ndados.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(134, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "NVoz:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_tel
        '
        Me.txt_tel.Enabled = False
        Me.txt_tel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.Location = New System.Drawing.Point(201, 113)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(272, 26)
        Me.txt_tel.TabIndex = 37
        '
        'cmb_RVoz
        '
        Me.cmb_RVoz.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_RVoz.FormattingEnabled = True
        Me.cmb_RVoz.Items.AddRange(New Object() {""})
        Me.cmb_RVoz.Location = New System.Drawing.Point(202, 113)
        Me.cmb_RVoz.Name = "cmb_RVoz"
        Me.cmb_RVoz.Size = New System.Drawing.Size(271, 27)
        Me.cmb_RVoz.TabIndex = 39
        Me.cmb_RVoz.Visible = False
        '
        'cmb_Ndados_inclu
        '
        Me.cmb_Ndados_inclu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_Ndados_inclu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Ndados_inclu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Ndados_inclu.FormattingEnabled = True
        Me.cmb_Ndados_inclu.Items.AddRange(New Object() {""})
        Me.cmb_Ndados_inclu.Location = New System.Drawing.Point(203, 400)
        Me.cmb_Ndados_inclu.Name = "cmb_Ndados_inclu"
        Me.cmb_Ndados_inclu.Size = New System.Drawing.Size(271, 27)
        Me.cmb_Ndados_inclu.TabIndex = 40
        Me.cmb_Ndados_inclu.Visible = False
        '
        'cmb_setores
        '
        Me.cmb_setores.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_setores.FormattingEnabled = True
        Me.cmb_setores.Items.AddRange(New Object() {""})
        Me.cmb_setores.Location = New System.Drawing.Point(201, 209)
        Me.cmb_setores.Name = "cmb_setores"
        Me.cmb_setores.Size = New System.Drawing.Size(271, 27)
        Me.cmb_setores.TabIndex = 41
        Me.cmb_setores.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Atenção"
        '
        'cmbFuncionario
        '
        Me.cmbFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFuncionario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFuncionario.FormattingEnabled = True
        Me.cmbFuncionario.Items.AddRange(New Object() {""})
        Me.cmbFuncionario.Location = New System.Drawing.Point(201, 144)
        Me.cmbFuncionario.Name = "cmbFuncionario"
        Me.cmbFuncionario.Size = New System.Drawing.Size(271, 27)
        Me.cmbFuncionario.TabIndex = 42
        Me.cmbFuncionario.Visible = False
        '
        'txt_Filial
        '
        Me.txt_Filial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Filial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_Filial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Filial.FormattingEnabled = True
        Me.txt_Filial.Items.AddRange(New Object() {"", "Loja 01", "Loja 03", "Loja 04", "Loja 05", "Loja 06", "Loja 08", "Loja 09", "Loja 11", "Loja 12", "Loja 14", "Loja 16", "Loja 17"})
        Me.txt_Filial.Location = New System.Drawing.Point(201, 436)
        Me.txt_Filial.Name = "txt_Filial"
        Me.txt_Filial.Size = New System.Drawing.Size(271, 27)
        Me.txt_Filial.TabIndex = 43
        '
        'ContasClaro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Interface_linhas_de_telefone.My.Resources.Resources.instaPrancheta_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(765, 661)
        Me.Controls.Add(Me.txt_Filial)
        Me.Controls.Add(Me.cmbFuncionario)
        Me.Controls.Add(Me.cmb_setores)
        Me.Controls.Add(Me.cmb_Ndados_inclu)
        Me.Controls.Add(Me.cmb_RVoz)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.btn_ndados)
        Me.Controls.Add(Me.cmb_ndados)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Vincular)
        Me.Controls.Add(Me.btn_Reserva)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbldesconto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblNDADOS)
        Me.Controls.Add(Me.Labe)
        Me.Controls.Add(Me.lbl_cargo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.txt_setor)
        Me.Controls.Add(Me.txt_CentroCusto)
        Me.Controls.Add(Me.txt_cargo)
        Me.Controls.Add(Me.txt_Desconto)
        Me.Controls.Add(Me.txt_TotalFun)
        Me.Controls.Add(Me.txt_Ndados)
        Me.Controls.Add(Me.txt_TotalFatura)
        Me.Controls.Add(Me.txt_fun)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_telefone)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ContasClaro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vinculos Telefônicos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cmb_telefone As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_fun As TextBox
    Friend WithEvents txt_TotalFatura As TextBox
    Friend WithEvents txt_Ndados As TextBox
    Friend WithEvents txt_TotalFun As TextBox
    Friend WithEvents txt_Desconto As TextBox
    Friend WithEvents txt_cargo As TextBox
    Friend WithEvents txt_CentroCusto As TextBox
    Friend WithEvents txt_setor As TextBox
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_cargo As Label
    Friend WithEvents Labe As Label
    Friend WithEvents lblNDADOS As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbldesconto As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_Reserva As Button
    Friend WithEvents btn_Vincular As Button
    Friend WithEvents btn_Modificar As Button
    Private WithEvents cmb_ndados As ComboBox
    Friend WithEvents btn_ndados As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_tel As TextBox
    Private WithEvents cmb_RVoz As ComboBox
    Private WithEvents cmb_Ndados_inclu As ComboBox
    Private WithEvents cmb_setores As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Private WithEvents cmbFuncionario As ComboBox
    Private WithEvents txt_Filial As ComboBox
End Class
