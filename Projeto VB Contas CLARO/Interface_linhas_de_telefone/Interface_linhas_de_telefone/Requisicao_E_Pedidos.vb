Imports System.Data.SqlClient
Imports System.Data
Public Class Requisicao_E_Pedidos
    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema
    Dim conn As New SqlConnection(connect.ToString)

    Private Sub Requisicao_E_Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            Dim dttable As New DataTable
            Dim Command As New SqlDataAdapter("SELECT Filial FROM requisicao", conn)
            Command.Fill(dttable)
            cmb_filial.DataSource = dttable
            cmb_filial.DisplayMember = "Filial"

            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_filial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filial.SelectedIndexChanged
        Try
            conn.Open()
            If cmb_filial.Text = "Todos" Then
                Dim dtt As New DataTable
                Dim cmd As New SqlDataAdapter("SELECT Filial, CentroDeCusto,N_Requisicao,N_Pedido FROM requisicao", conn)
                cmd.Fill(dtt)
                dgv_view.Visible = True
                dgv_view.DataSource = dtt
            End If

            Dim dttable As New DataTable
            Dim Command As New SqlDataAdapter("SELECT Filial, CentroDeCusto, N_Requisicao, N_Pedido FROM requisicao WHERE Filial = '" + cmb_filial.Text + "'", conn)
            Command.Fill(dttable)
            dgv_view.Visible = True
            dgv_view.DataSource = dttable
            conn.Close()

            dgv_view.ColumnHeadersDefaultCellStyle.Font = New Font("Arial Black", 14)
            dgv_view.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_view.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            dgv_view.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_view.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            dgv_view.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_view.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            dgv_view.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv_view.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            dgv_view.Columns(0).HeaderText = "Filial"
            dgv_view.Columns(1).HeaderText = "Centro de Custo"
            dgv_view.Columns(2).HeaderText = "Número de Requisição"
            dgv_view.Columns(3).HeaderText = "Número de Pedido"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            conn.Open()
            If MsgBox("Deseja cadastrar esse pedido e requisição ?", MsgBoxStyle.YesNo, "Aviso") = Windows.Forms.DialogResult.Yes Then

                Dim dttablle As New DataTable
                Dim cmd As New SqlDataAdapter("UPDATE REQUISICAO SET N_REQUISICAO = " + Txt_Req.Text + ", N_Pedido = " + TxT_Ped.Text + " WHERE FILIAL = '" + cmb_filial.Text + "'", conn)
                cmd.Fill(dttablle)
                MessageBox.Show("Num.Pedido e Num.Requisição cadastrados com sucesso!")
                Me.Close()
            End If
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class