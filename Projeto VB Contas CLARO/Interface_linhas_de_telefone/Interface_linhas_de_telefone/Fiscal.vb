Imports System.Data.SqlClient
Imports System.Data

Public Class Fiscal
    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema
    Dim conn As New SqlConnection(connect.ToString)
    Private Sub Fiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Try

        '        conn.Open()
        '        Dim dttr As SqlDataReader
        '        Dim ct As New SqlCommand("SELECT N_Requisicao, N_Pedido FROM REQUISICAO", conn)
        '        dttr = ct.ExecuteReader()
        '        If (dttr.HasRows) Then
        '            dttr.Read()
        '            TxtBoxNumr.Text = dttr("N_Requisicao").ToString
        '            TxtBoxNump.Text = dttr("N_Pedido").ToString
        '        End If
        '        conn.Close()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString, "to")
        '    End Try

    End Sub

    Private Sub cmb_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_search.SelectedIndexChanged
        Try
            conn.Open()
            If cmb_search.Text = "Diretoria" Then

                Dim dttable As New DataTable
                Dim Commando As New SqlDataAdapter("SELECT DISTINCT SETORES, CENTRODECUSTO, (SELECT SUM(total_func) FROM DADOS_TELEFONICOS AS DSA	WHERE SETORES = DADOS_TELEFONICOS.SETORES) AS VALOR FROM DADOS_TELEFONICOS WHERE SETORES = 'HELIO' OR SETORES = 'ROBERTO'", conn)
                Commando.Fill(dttable)

                dtg_view.Visible = True
                dtg_view.DataSource = dttable

            End If
            If cmb_search.Text = "Recursos Humanos - Gestão" Then

                Dim dtt As New DataTable
                Dim cmdd As New SqlDataAdapter("SELECT DESCONTADO,CENTRODECUSTO,VALOR FROM fiscal_rh ORDER BY descontado", conn)
                cmdd.Fill(dtt)
                dtg_view.Visible = True
                dtg_view.DataSource = dtt

            End If

            If cmb_search.Text = "Gerencia das Lojas" Then
                Dim dttx As New DataTable
                Dim cmdx As New SqlDataAdapter("SELECT DISTINCT asd.filial, dados_telefonicos.centrodecusto, asd.total_func  FROM dados_telefonicos , (SELECT SUM(total_func) AS total_func, filial FROM dados_telefonicos WHERE filial IS NOT NULL GROUP BY filial) AS asd WHERE asd.filial = dados_telefonicos.filial ORDER BY asd.filial", conn)
                cmdx.Fill(dttx)

                dtg_view.Visible = True
                dtg_view.DataSource = dttx

            End If
            If cmb_search.Text = "Corporativo das Lojas" Then

                Dim dtx As New DataTable
                Dim cmdxx As New SqlDataAdapter("SELECT DESCONTADO,CENTRODECUSTO,VALOR FROM CORPORATIVO", conn)
                'Dim cmdxx As New SqlDataAdapter("SELECT FUNCIONARIOS,CENTRODECUSTO,TTFATURA FROM DADOS_TELEFONICOS WHERE CENTRODECUSTO IN ('100.1.09.01','100.1.09.03','100.1.09.04','100.1.09.05','100.1.09.06','100.1.09.07','100.1.09.08','100.1.09.09','100.1.09.10','100.1.09.11','100.1.09.12','100.1.09.13','100.1.09.14','100.1.09.15','100.1.09.16','100.1.09.17','100.1.09.17','100.1.12.10')", conn)
                cmdxx.Fill(dtx)

                dtg_view.Visible = True
                dtg_view.DataSource = dtx

            End If
            conn.Close()

            dtg_view.ColumnHeadersDefaultCellStyle.Font = New Font("Arial Black", 14)
            dtg_view.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            dtg_view.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtg_view.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            'dtg_view.Columns(0).Width = 200
            'dtg_view.Columns(1).Width = 200
            'dtg_view.Columns(2).Width = 130
            dtg_view.Columns(0).HeaderText = "Setor"
            dtg_view.Columns(1).HeaderText = "Centro de Custo"
            dtg_view.Columns(2).HeaderText = "Total da Fatura"
            dtg_view.Columns(2).DefaultCellStyle.Format = "c"


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Me.Controls.Clear()
        InitializeComponent()
        Fiscal_Load(e, e)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Try
            Dim browser = New WebBrowser()
            browser.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Erro", ex.ToString)
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Try
            Dim browser = New WebBrowser()
            browser.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Erro", ex.ToString)
        End Try
    End Sub
End Class