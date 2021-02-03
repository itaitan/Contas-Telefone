Imports System.Data.SqlClient
Imports System.Data.Sql
'Public Class Fiscal1
'    Dim connect As New SqlConnectionStringBuilder("")'Retirei endereço de conexão devido a segurança do sistema
'    Dim conn As New SqlConnection(connect.ToString)
'    Private Sub cmb_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_search.SelectedIndexChanged
'        Try
'            conn.Open()
'            If cmb_search.Text = "Diretoria" Then

'                Dim dttable As New DataTable
'                Dim Commando As New SqlDataAdapter("SELECT DISTINCT SETORES, CENTRODECUSTO, (SELECT SUM(total_func) FROM DADOS_TELEFONICOS AS DSA	WHERE SETORES = DADOS_TELEFONICOS.SETORES) AS VALOR FROM DADOS_TELEFONICOS WHERE SETORES = 'HELIO' OR SETORES = 'ROBERTO'", conn)
'                Commando.Fill(dttable)
'                dtg_view.Visible = True
'                dtg_view.DataSource = dttable

'            End If
'            If cmb_search.Text = "Recursos Humanos - Gestão" Then

'                Dim dttxz As New DataTable
'                Dim cmdd As New SqlDataAdapter("SELECT DESCONTADO,CENTRODECUSTO,VALOR FROM fiscal_rh ORDER BY descontado", conn)
'                cmdd.Fill(dttxz)
'                dtg_view.Visible = True
'                dtg_view.DataSource = dttxz

'            End If
'            If cmb_search.Text = "Gerencia das Lojas" Then

'                Dim dttx As New DataTable
'                Dim cmdx As New SqlDataAdapter("SELECT DISTINCT asd.filial, dados_telefonicos.centrodecusto, asd.total_func  FROM dados_telefonicos , (SELECT SUM(total_func) AS total_func, filial FROM dados_telefonicos WHERE filial IS NOT NULL GROUP BY filial) AS asd WHERE asd.filial = dados_telefonicos.filial ORDER BY asd.filial", conn)
'                cmdx.Fill(dttx)
'                dtg_view.Visible = True
'                dtg_view.DataSource = dttx

'            End If
'            If cmb_search.Text = "Corporativo das Lojas" Then

'                Dim dtx As New DataTable
'                Dim cmdxx As New SqlDataAdapter("SELECT DESCONTADO,CENTRODECUSTO,VALOR FROM CORPORATIVO", conn)
'                cmdxx.Fill(dtx)
'                dtg_view.Visible = True
'                dtg_view.DataSource = dtx

'            End If
'            conn.Close()

'            dtg_view.ColumnHeadersDefaultCellStyle.Font = New Font("Arial Black", 14)
'            dtg_view.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'            dtg_view.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
'            dtg_view.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'            dtg_view.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
'            dtg_view.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'            dtg_view.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
'            'dtg_view.Columns(0).Width = 200
'            'dtg_view.Columns(1).Width = 200
'            'dtg_view.Columns(2).Width = 130
'            dtg_view.Columns(0).HeaderText = "Setor"
'            dtg_view.Columns(1).HeaderText = "Centro de Custo"
'            dtg_view.Columns(2).HeaderText = "Total da Fatura"
'            dtg_view.Columns(2).DefaultCellStyle.Format = "c"

'        Catch ex As Exception

'        End Try
'    End Sub
'    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
'        Me.Controls.Clear()
'        InitializeComponent()
'        Fiscal1_Load(e, e)
'    End Sub
'End Class