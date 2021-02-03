Imports System.Data
Imports System.Data.SqlClient

Public Class Consulta
    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema
    Dim conn As New SqlConnection(connect.ToString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim dttablef As New DataTable
            Dim Commandof As New SqlDataAdapter("SELECT DISTINCT(SETORES) FROM dados_telefonicos", conn)
            Commandof.Fill(dttablef)
            cmb_search.DataSource = dttablef
            cmb_search.DisplayMember = "setores"
            conn.Close()

            dtg_view.ColumnHeadersDefaultCellStyle.Font = New Font("Arial Black", 10)
            dtg_view.Columns(0).HeaderText = "Cod"
            dtg_view.Columns(1).HeaderText = "Funcionarios"
            dtg_view.Columns(2).HeaderText = "Telefones"
            dtg_view.Columns(3).HeaderText = "Nº Dados"
            dtg_view.Columns(4).HeaderText = "Setor"
            dtg_view.Columns(5).HeaderText = "Centro de Custo"
            dtg_view.Columns(6).HeaderText = "Desconto"
            dtg_view.Columns(7).HeaderText = "Total da Fatura"
            dtg_view.Columns(8).HeaderText = "Total Func."
            dtg_view.Columns(7).DefaultCellStyle.Format = "c"
            dtg_view.Columns(8).DefaultCellStyle.Format = "c"
            dtg_view.Columns(1).Width = 100
            dtg_view.Columns(0).Width = 45
            dtg_view.Columns(4).Width = 65
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
            dtg_view.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_search_SelectedIndexChanged(sender As System.Object, ByVal e As System.EventArgs) Handles cmb_search.SelectedIndexChanged
        Try
            conn.Open()
            Dim dttable As New DataTable
            Dim Commando As New SqlDataAdapter("SELECT Cod, Funcionarios, Telefones, Ndados, Setores, CentrodeCusto, Desconto, ttfatura, Total_func FROM dados_telefonicos WHERE setores = '" + cmb_search.Text + "'", conn)
            Commando.Fill(dttable)
            dtg_view.Visible = True
            dtg_view.DataSource = dttable
            conn.Close()

            dtg_view.ColumnHeadersDefaultCellStyle.Font = New Font("Arial Black", 10)
            dtg_view.Columns(0).HeaderText = "Cod"
            dtg_view.Columns(1).HeaderText = "Funcionarios"
            dtg_view.Columns(2).HeaderText = "Telefones"
            dtg_view.Columns(3).HeaderText = "Nº Dados"
            dtg_view.Columns(4).HeaderText = "Setor"
            dtg_view.Columns(5).HeaderText = "Centro de Custo"
            dtg_view.Columns(6).HeaderText = "Desconto"
            dtg_view.Columns(7).HeaderText = "Total da Fatura"
            dtg_view.Columns(8).HeaderText = "Total Func."
            dtg_view.Columns(7).DefaultCellStyle.Format = "c"
            dtg_view.Columns(8).DefaultCellStyle.Format = "c"
            dtg_view.Columns(1).Width = 100
            dtg_view.Columns(0).Width = 45
            dtg_view.Columns(4).Width = 65
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
            dtg_view.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            Dim browser = New WebBrowser()
            browser.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Erro", ex.ToString)
        End Try
    End Sub
End Class
