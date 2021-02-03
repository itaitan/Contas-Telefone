Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Drawing.Printing

Public Class ConsultaDpVendas

    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema
    Dim conn As New SqlConnection(connect.ToString)
    Dim setoor As String


    Private leitor As SqlDataReader
    Dim cmd As SqlCommand
    Private paginaAtual As Integer = 1
    Private relatorioTitulo As String

    Private Sub cmb_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_search.SelectedIndexChanged
        Try
            conn.Open()
            If cmb_search.Text = "Todos" Then
                Dim table As New DataTable
                Dim cpt As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, Total_func FROM dados_telefonicos WHERE  setores  LIKE 'VEN%'", conn)
                setoor = "VEN%"
                cpt.Fill(table)
                dtg_view.Visible = True
                dtg_view.DataSource = table
            End If
            If cmb_search.Text = "Vend-Alex" Then
                Dim dttable As New DataTable
                Dim Command As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND ALEX'", conn)
                setoor = "VEND ALEX"
                Command.Fill(dttable)
                dtg_view.Visible = True
                dtg_view.DataSource = dttable
            End If

            If cmb_search.Text = "Vend-André" Then
                Dim dtable As New DataTable
                Dim Comand As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND ANDRE'", conn)
                setoor = "VEND ANDRE"
                Comand.Fill(dtable)
                dtg_view.Visible = True
                dtg_view.DataSource = dtable
            End If

            If cmb_search.Text = "Vend-Durbem" Then
                Dim dtablle As New DataTable
                Dim Comando As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND DURBEM'", conn)
                setoor = "VEND DURBEM"
                Comando.Fill(dtablle)
                dtg_view.Visible = True
                dtg_view.DataSource = dtablle
            End If

            If cmb_search.Text = "Vend-Gabriel" Then
                Dim dttablle As New DataTable
                Dim Commando As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND GABRIEL'", conn)
                setoor = "VEND GABRIEL"
                Commando.Fill(dttablle)
                dtg_view.Visible = True
                dtg_view.DataSource = dttablle
            End If

            If cmb_search.Text = "Vend-Itamar ABCDM" Then
                Dim dt As New DataTable
                Dim cmd As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND ITAMAR ABCDM'", conn)
                setoor = "VEND ITAMAR ABCDM"
                cmd.Fill(dt)
                dtg_view.Visible = True
                dtg_view.DataSource = dt
            End If

            If cmb_search.Text = "Vend-Itamar BAIXADA" Then
                Dim dttablex As New DataTable
                Dim Commandx As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND ITAMAR BAIXADA'", conn)
                setoor = "VEND ITAMAR BAIXADA"
                Commandx.Fill(dttablex)
                dtg_view.Visible = True
                dtg_view.DataSource = dttablex
            End If

            If cmb_search.Text = "Vend-Itamar VALE" Then
                Dim dttablex As New DataTable
                Dim Commandx As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND ITAMAR VALE'", conn)
                setoor = "VEND ITAMAR VALE"
                Commandx.Fill(dttablex)
                dtg_view.Visible = True
                dtg_view.DataSource = dttablex
            End If

            If cmb_search.Text = "Vend-Junior" Then
                Dim dtabllex As New DataTable
                Dim Comandx As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND JUNIOR'", conn)
                setoor = "VEND JUNIOR"
                Comandx.Fill(dtabllex)
                dtg_view.Visible = True
                dtg_view.DataSource = dtabllex
            End If

            If cmb_search.Text = "Vend-Leandro" Then
                Dim dttabllex As New DataTable
                Dim Comandox As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND LEANDRO'", conn)
                setoor = "VEND LEANDRO"
                Comandox.Fill(dttabllex)
                dtg_view.Visible = True
                dtg_view.DataSource = dttabllex
            End If

            If cmb_search.Text = "Vend-Lucio" Then
                Dim dtx As New DataTable
                Dim cmdx As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND LUCIO'", conn)
                setoor = "VEND LUCIO"
                cmdx.Fill(dtx)
                dtg_view.Visible = True
                dtg_view.DataSource = dtx
            End If

            If cmb_search.Text = "Vend-Mauro" Then
                Dim dtt As New DataTable
                Dim cmmd As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND MAURO'", conn)
                setoor = "VEND MAURO"
                cmmd.Fill(dtt)
                dtg_view.Visible = True
                dtg_view.DataSource = dtt
            End If

            If cmb_search.Text = "Vend-Marcelo" Then
                Dim dttx As New DataTable
                Dim cmmdx As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND MARCELO'", conn)
                setoor = "VEND MARCELO"
                cmmdx.Fill(dttx)
                dtg_view.Visible = True
                dtg_view.DataSource = dttx
            End If

            If cmb_search.Text = "Vend-Sidnei" Then
                Dim dttxx As New DataTable
                Dim cmddx As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND SIDNEI'", conn)
                setoor = "VEND SIDNEI"
                cmddx.Fill(dttxx)
                dtg_view.Visible = True
                dtg_view.DataSource = dttxx
            End If

            If cmb_search.Text = "Vend-Wilson" Then
                Dim datatable As New DataTable
                Dim sqlcmd As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Setores, Ndados, total_func FROM dados_telefonicos WHERE  setores = 'VEND WILSON'", conn)
                setoor = "VEND WILSON"
                sqlcmd.Fill(datatable)
                dtg_view.Visible = True
                dtg_view.DataSource = datatable
            End If

            conn.Close()
        Catch ex As Exception

        End Try
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
        dtg_view.Columns(1).Width = 200
        dtg_view.Columns(2).Width = 130
        dtg_view.Columns(5).Width = 130

        dtg_view.Columns(0).HeaderText = "Cod"
        dtg_view.Columns(1).HeaderText = "Nome"
        dtg_view.Columns(2).HeaderText = "Linha"
        dtg_view.Columns(3).HeaderText = "Setor"
        dtg_view.Columns(4).HeaderText = "Nº Dados"
        dtg_view.Columns(5).HeaderText = "Total Func."
        dtg_view.Columns(5).DefaultCellStyle.Format = "c"

    End Sub

    Private Sub ConsultaDpVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Me.Controls.Clear()
        InitializeComponent()
        ConsultaDpVendas_Load(e, e)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Try
            Dim browser = New WebBrowser()
            browser.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Erro", ex.ToString)
        End Try
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click

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
        Dim codigo = "SELECT COD, Funcionarios, Telefones, Ndados, Setores, Centrodecusto, Ndados, TTFatura, Total_func FROM dados_telefonicos Where setores like '" + setoor + "'"
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
        e.Graphics.DrawString("Funcionarios", FonteNegrito, Brushes.Black, MargemEsquerda + 60, 170, New StringFormat())
        e.Graphics.DrawString("Telefones", FonteNegrito, Brushes.Black, MargemEsquerda + 305, 170, New StringFormat())
        e.Graphics.DrawString("Setores", FonteNegrito, Brushes.Black, MargemEsquerda + 420, 170, New StringFormat())
        e.Graphics.DrawString("NDados", FonteNegrito, Brushes.Black, MargemEsquerda + 600, 170, New StringFormat())
        e.Graphics.DrawString("T_Func", FonteNegrito, Brushes.Black, MargemEsquerda + 700, 170, New StringFormat())


        'Imprimir Linha
        e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda, 190, MargemDireita, 190)

        'Definir numero de linhas por pagina
        linhasPorPaginas = CInt(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9)

        'Leitura dos dados da tabela e onde acontece a impressão
        While (LinhaAtual < linhasPorPaginas AndAlso leitor.Read)

            'obtem os valores do DataREADER
            COD = leitor.Item("COD").ToString
            Funcionario = leitor.Item("Funcionarios").ToString
            telefone = leitor.Item("telefones").ToString
            setores = leitor.Item("Setores").ToString
            ndados = leitor.Item("NDados").ToString
            totalFunc = leitor.Item("Total_func").ToString

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
            e.Graphics.DrawString(totalFunc, FonteNormal, Brushes.Black, MargemEsquerda + 700, PosicaoDaLinha, New StringFormat())

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