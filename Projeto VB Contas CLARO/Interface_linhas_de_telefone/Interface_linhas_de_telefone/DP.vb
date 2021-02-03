Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Printing

Public Class DP

    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema
    Dim conn As New SqlConnection(connect.ToString)


    Private leitor As SqlDataReader
    Dim cmd As SqlCommand
    Private paginaAtual As Integer = 1
    Private relatorioTitulo As String


    Private Sub DP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim dttablef As New DataTable
            Dim Commandof As New SqlDataAdapter("select 'EXP - LOG' AS Setor union SELECT DISTINCT Setor FROM Dp WHERE SETOR NOT LIKE 'LOJA%'", conn)
            Commandof.Fill(dttablef)
            cmb_search.DataSource = dttablef
            cmb_search.DisplayMember = "setor"

            conn.Close()
            dtg_view.DefaultCellStyle.Font = New Font("Arial", 12)

            dtg_view.ColumnHeadersDefaultCellStyle.Font = New Font("Arial Black", 12)
            dtg_view.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(0).HeaderText = "Cod"
            dtg_view.Columns(1).HeaderText = "Nome"
            dtg_view.Columns(2).HeaderText = "Linha"
            dtg_view.Columns(3).HeaderText = "Setor"
            dtg_view.Columns(4).HeaderText = "Cargo"
            dtg_view.Columns(5).HeaderText = "Total Func."
            dtg_view.Columns(5).DefaultCellStyle.Format = "c"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_setores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_search.SelectedIndexChanged
        Try




            '        cmb_search.Text = "Lojas" Then
            '    conn.Open()
            '    Dim dtt As New DataTable
            '    Dim cmd As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Cargo, Total_func, Filial FROM dados_telefonicos WHERE Filial IS NOT NULL", conn)
            '    cmd.Fill(dtt)
            '    dtg_view.Visible = True
            '    dtg_view.DataSource = dtt
            '    conn.Close()
            '    dtg_view.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            '    dtg_view.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
            '    dtg_view.Columns(6).HeaderText = "Filial"




            'ElseIf
            If cmb_search.Text = "Selecionar Todos" Then
                conn.Open()
                Dim dttables As New DataTable
                Dim Commandos As New SqlDataAdapter("SELECT Cod,Nome,Linha,Setor,Cargo,Total_Func FROM Dp where nome <> '0'", conn)
                Commandos.Fill(dttables)
                dtg_view.Visible = True
                dtg_view.DataSource = dttables
                conn.Close()
            ElseIf cmb_search.Text = "EXP - LOG" Then ' QUANDO MUDAR SELECT DO EXP LOG, MUDAR TAMBÉM SELECT DA IMPRESSÃO PARA NÃO BUGAR
                conn.Open()
                Dim dttable As New DataTable
                Dim Commando As New SqlDataAdapter("select Cod,Funcionarios as Nome,Telefones as Linha,Setores as Setor,Cargo,Total_Func from dados_telefonicos where funcionarios like '%EXP - LOG%' AND cod <> 0", conn)
                Commando.Fill(dttable)
                dtg_view.Visible = True
                dtg_view.DataSource = dttable
                conn.Close()
            Else
                conn.Open()
                Dim dttable As New DataTable
                Dim Commando As New SqlDataAdapter("SELECT Cod,Nome,Linha,Setor,Cargo,Total_Func FROM Dp WHERE Setor = '" + cmb_search.Text + "'", conn)
                Commando.Fill(dttable)

                dtg_view.Visible = True
                dtg_view.DataSource = dttable
                conn.Close()
            End If

            dtg_view.DefaultCellStyle.Font = New Font("Arial", 12)

            dtg_view.ColumnHeadersDefaultCellStyle.Font = New Font("Arial Black", 12)
            dtg_view.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(0).Width = 50
            dtg_view.Columns(1).Width = 170
            dtg_view.Columns(2).Width = 110
            dtg_view.Columns(5).Width = 120

            dtg_view.Columns(0).HeaderText = "Cod"
            dtg_view.Columns(1).HeaderText = "Nome"
            dtg_view.Columns(2).HeaderText = "Linha"
            dtg_view.Columns(3).HeaderText = "Setor"
            dtg_view.Columns(4).HeaderText = "Cargo"
            dtg_view.Columns(5).HeaderText = "Total Func."
            dtg_view.Columns(5).DefaultCellStyle.Format = "c"

        Catch ex As Exception
            'MessageBox.Show(ex.ToString, "Erro")
        End Try
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Me.Controls.Clear()
        InitializeComponent()
        DP_Load(e, e)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Try
            Dim browser = New WebBrowser()
            browser.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Erro", ex.ToString)
        End Try
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click

        'largura = print_documento.DefaultPageSettings.Bounds.Width
        'print_documento.DefaultPageSettings.Landscape = True
        relatorioTitulo = "CONSULTA DEPARTAMENTO PESSOAL"

        'Define o objeto printdocument e os eventos associados
        Dim pd As PrintDocument = New PrintDocument()
        pd.DefaultPageSettings.Landscape = True

        'EVENTOS PARA IMPRESSÃO : PrintPage, BeginPrint, EndPrint
        AddHandler pd.PrintPage, New PrintPageEventHandler(AddressOf Me.pdRelatorios_printPage)
        AddHandler pd.BeginPrint, New PrintEventHandler(AddressOf Me.Begin_Print)
        AddHandler pd.EndPrint, New PrintEventHandler(AddressOf Me.End_Print)

        'Define o objeto para visualizar a Impressão
        Dim objPrintPreview As New PrintPreviewDialog

        Try
            'Definindo o formulario com maximizado e com Zoom
            With objPrintPreview
                .Document = pd
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .Text = "Contas Claro"
                .ShowDialog()

            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Private Sub Begin_Print(ByVal sender As System.Object, ByVal e As Printing.PrintEventArgs)
        Dim codigo As String

        If cmb_search.Text = "Selecionar Todos" Then
            codigo = "SELECT Cod,Nome,Linha,Setor,Cargo,Total_Func FROM Dp where nome <> '0'"
        ElseIf cmb_search.Text = "Lojas" Then
            codigo = "SELECT Cod, Funcionarios, Telefones, Setores, Cargo, Total_func, Filial FROM dados_telefonicos WHERE Filial IS NOT NULL"
        ElseIf cmb_search.Text = "EXP - LOG" Then
            codigo = "Select Cod,Funcionarios as Nome,Telefones as Linha,Setores as Setor,Cargo,Total_Func from dados_telefonicos where funcionarios like '%EXP - LOG%' AND cod <> 0"
        Else
            codigo = "SELECT Cod,Nome,Linha,Setor,Cargo,Total_Func FROM Dp WHERE Setor = '" + cmb_search.Text + "'"
        End If

        Dim cmd As New SqlCommand(codigo, conn)

        conn.Open()
        leitor = cmd.ExecuteReader()
        paginaAtual = 1

    End Sub

    Private Sub pdRelatorios_printPage(sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        'Variaveis das linhas
        Dim linhasPorPaginas As Single = 0
        Dim PosicaoDaLinha As Single = 0
        Dim LinhaAtual As Integer = 0

        'Variaveis das margens (Margens da pagina retangular
        Dim MargemEsquerda As Single = e.MarginBounds.Left
        Dim MargemSuperior As Single = e.MarginBounds.Top + 100
        Dim MargemDireita As Single = e.MarginBounds.Right
        Dim MargemInferior As Single = e.MarginBounds.Bottom

        'classe Caneta que define as expessura da linha
        Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)

        'Definir Variaveis para impressão "Colunas" Relacionada a tabela do sql

        Dim COD As String
        Dim Funcionario As String
        Dim telefone As String
        Dim setores As String
        Dim ndados As String
        Dim totalFunc As String

        'Variaveis de Fontes ( Classe serve para definição de Tamanho, tipo de texto, e formato)
        Dim FonteNegrito As Font = New Font("Arial", 9, FontStyle.Bold)
        Dim FonteTitulo As Font = New Font("Arial", 14, FontStyle.Bold)
        Dim FonteSubTitulo As Font = New Font("Arial", 12, FontStyle.Bold)
        Dim FonteRodape As Font = New Font("Arial", 8)
        Dim FonteNormal As Font = New Font("Arial", 9)

        'Define o valores da linha atual e para linha da impressao
        LinhaAtual = 0

        'Cabeçalho do Relatorio .......................
        'DrawLine - Desenha uma linha que conecta os dois pontos especificos pelas duas cordenadas.
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 60, MargemDireita, 60)
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 160, MargemDireita, 160)

        'nome da empresa... Configuração designer
        e.Graphics.DrawString(My.Settings.Empresa, FonteTitulo, Brushes.Black, MargemEsquerda + 250, 80, New StringFormat())

        'Imprimir titulo do relatorio
        e.Graphics.DrawString(relatorioTitulo, FonteSubTitulo, Brushes.Black, MargemEsquerda + 250, 120, New StringFormat())

        'Imprimir os campos na tabela Codigo, funcionario, Ndados e telefone

        e.Graphics.DrawString("COD", FonteNegrito, Brushes.Black, MargemEsquerda + 10, 170, New StringFormat())
        e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 60, 170, New StringFormat())
        e.Graphics.DrawString("Linha", FonteNegrito, Brushes.Black, MargemEsquerda + 305, 170, New StringFormat())
        e.Graphics.DrawString("Setores", FonteNegrito, Brushes.Black, MargemEsquerda + 420, 170, New StringFormat())
        e.Graphics.DrawString("Cargo", FonteNegrito, Brushes.Black, MargemEsquerda + 600, 170, New StringFormat())
        e.Graphics.DrawString("Total Func.", FonteNegrito, Brushes.Black, MargemEsquerda + 780, 170, New StringFormat())


        'Imprimir Linha
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)

        'Definir numero de linhas por pagina
        linhasPorPaginas = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)

        'Leitura dos dados da tabela e onde acontece a impressão
        While (LinhaAtual < linhasPorPaginas AndAlso leitor.Read)

            If cmb_search.Text = "Lojas" Then
                'obtem os valores do DataREADER
                COD = leitor.Item("COD").ToString
                Funcionario = leitor.Item("Funcionarios").ToString
                telefone = leitor.Item("telefones").ToString
                setores = leitor.Item("setores").ToString
                ndados = leitor.Item("cargo").ToString
                totalFunc = leitor.Item("Total_func").ToString
            Else
                'obtem os valores do DataREADER
                COD = leitor.Item("COD").ToString
                Funcionario = leitor.Item("nome").ToString
                telefone = leitor.Item("linha").ToString
                setores = leitor.Item("setor").ToString
                ndados = leitor.Item("cargo").ToString
                totalFunc = leitor.Item("Total_func").ToString
            End If




            If (Funcionario.Length >= 27) Then
                Funcionario = Funcionario.Substring(0, 27)
            End If
            'Inciando a impressão - define a posição da linha e a posição da impressora

            PosicaoDaLinha = MargemSuperior + (LinhaAtual * FonteNormal.GetHeight(e.Graphics))
            e.Graphics.DrawString(COD, FonteNormal, Brushes.Black, MargemEsquerda + 10, PosicaoDaLinha, New StringFormat())
            e.Graphics.DrawString(Funcionario, FonteNormal, Brushes.Black, MargemEsquerda + 60, PosicaoDaLinha, New StringFormat())
            e.Graphics.DrawString(telefone, FonteNormal, Brushes.Black, MargemEsquerda + 305, PosicaoDaLinha, New StringFormat())
            e.Graphics.DrawString(setores, FonteNormal, Brushes.Black, MargemEsquerda + 420, PosicaoDaLinha, New StringFormat())
            e.Graphics.DrawString(ndados, FonteNormal, Brushes.Black, MargemEsquerda + 600, PosicaoDaLinha, New StringFormat())
            e.Graphics.DrawString(totalFunc, FonteNormal, Brushes.Black, MargemEsquerda + 780, PosicaoDaLinha, New StringFormat())

            'incremente Linha
            LinhaAtual += 1

        End While

        'Imprime o Rodapé
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, MargemInferior, MargemDireita, MargemInferior)
        e.Graphics.DrawString(System.DateTime.Now.ToString, FonteRodape, Brushes.Black, MargemEsquerda, MargemInferior, New StringFormat())

        LinhaAtual += CInt(FonteNormal.GetHeight(e.Graphics))
        LinhaAtual += 1

        e.Graphics.DrawString("Pagina: " & paginaAtual, FonteRodape, Brushes.Black, MargemDireita - 50, MargemInferior, New StringFormat())

        'Incrementa o numero da pagina
        paginaAtual += 1

        'Verifica se a mais paginas para impressão

        If (LinhaAtual > linhasPorPaginas) Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If

    End Sub

    'Encerrar a conexão e o Data Reader

    Private Sub End_Print(ByVal sender As Object, ByVal byvale As Printing.PrintEventArgs)
        leitor.Close()
        conn.Close()

    End Sub

End Class