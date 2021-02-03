Imports System.Data.SqlClient
Public Class Pedidos

    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema
    Dim conn As New SqlConnection(connect.ToString)

    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            Dim dttable As New DataTable
            Dim command As New SqlDataAdapter("SELECT FILIAL, CENTRODECUSTO, N_REQUISICAO, N_PEDIDO FROM requisicao ORDER BY requisicao.Centrodecusto", conn)
            command.Fill(dttable)

            DgvPedidos.DataSource = dttable
            'DgvPedidos.Columns("Filial").ReadOnly = True
            conn.Close()

            DgvPedidos.ColumnHeadersDefaultCellStyle.Font = New Font("Arial Black", 14)
            DgvPedidos.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgvPedidos.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            DgvPedidos.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgvPedidos.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            DgvPedidos.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgvPedidos.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            DgvPedidos.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgvPedidos.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            DgvPedidos.Columns(0).HeaderText = "Filial"
            DgvPedidos.Columns(1).HeaderText = "Centro de Custo"
            DgvPedidos.Columns(3).HeaderText = "Número de Pedido"
            DgvPedidos.Columns(2).HeaderText = "Número de Requisição"
            DgvPedidos.Columns("Filial").ReadOnly = True


        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If MsgBox("Deseja salvar essa alteração?", MsgBoxStyle.YesNo, "Aviso") = Windows.Forms.DialogResult.Yes Then
                For Each row As DataGridViewRow In DgvPedidos.Rows
                    conn.Open()

                    Dim command As New SqlCommand("UPDATE requisicao SET n_pedido = " + row.Cells(1).Value.ToString + ", n_requisicao = " + row.Cells(2).Value.ToString + " WHERE Filial = '" + row.Cells(0).Value.ToString + "'", conn)
                    command.ExecuteNonQuery()

                    conn.Close()
                Next

                Me.Controls.Clear()
                InitializeComponent()
                Pedidos_Load(e, e)

            End If

        Catch ex As Exception
            MessageBox.Show("Valor do número de pedido e número de requisição não pode ser nullo, caso não tenha inserir 0", "Valor Nulo")
            Me.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Deseja excluir os números de pedido e requisição ?", MsgBoxStyle.YesNo, "Aviso") = Windows.Forms.DialogResult.Yes Then
            Try
                conn.Open()
                Dim command As New SqlCommand("UPDATE requisicao SET n_pedido = 0, n_requisicao = 0", conn)
                command.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error")
            End Try

            Me.Controls.Clear()
            InitializeComponent()
            Pedidos_Load(e, e)

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Try
            Dim browser = New WebBrowser()
            browser.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Erro", ex.ToString)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            Dim browser = New WebBrowser()
            browser.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Erro", ex.ToString)
        End Try
    End Sub

    Private Sub DgvPedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPedidos.CellContentClick

    End Sub
End Class