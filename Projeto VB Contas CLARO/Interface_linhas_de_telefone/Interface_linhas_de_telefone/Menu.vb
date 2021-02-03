Imports System.Data
Imports System.Data.SqlClient
Imports Interface_linhas_de_telefone.Login.user
Imports Interface_linhas_de_telefone.Login.pass


Public Class Home
    Dim usuario = Login.user
    Dim senha = Login.pass
    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema
    Dim conn As New SqlConnection(connect.ToString)


    Private Sub AdicionarAlterarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarAlterarToolStripMenuItem.Click

    End Sub

    Private Sub AdicionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem.Click
        Adicionar.ShowDialog()
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarToolStripMenuItem.Click
        Dim modify = New Alteracao()
        modify.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Login.Close()
            conn.Open()

            Dim reader As SqlDataReader
            Dim dttablef As New DataTable

            Dim Commandof As New SqlCommand("SELECT permission from Logins WHERE Usuario = '" + usuario + "' ", conn)
            reader = Commandof.ExecuteReader()

            Dim per As String
            reader.Read()
            per = reader.GetInt32(0)

            If (reader.HasRows) Then

                If (per = 1) Then
                    AdicionarAlterarToolStripMenuItem.Visible = True
                    ConsultaDPToolStripMenuItem.Visible = True
                    FiscalToolStripMenuItem.Visible = True
                    ConsultaGeralToolStripMenuItem.Visible = True
                    ConsultaDPVendasToolStripMenuItem.Visible = True
                    InserirPedidosToolStripMenuItem.Visible = True
                ElseIf (per = 2) Then
                    AdicionarAlterarToolStripMenuItem.Visible = False
                    ConsultaDPToolStripMenuItem.Visible = False
                    ConsultaGeralToolStripMenuItem.Visible = False
                    FiscalToolStripMenuItem.Visible = True
                    ConsultaDPVendasToolStripMenuItem.Visible = False
                    InserirPedidosToolStripMenuItem.Visible = False
                ElseIf (per = 0) Then
                    AdicionarAlterarToolStripMenuItem.Visible = False
                    ConsultaDPToolStripMenuItem.Visible = True
                    ConsultaDPVendasToolStripMenuItem.Visible = True
                    ConsultaGeralToolStripMenuItem.Visible = False
                    FiscalToolStripMenuItem.Visible = False
                    InserirPedidosToolStripMenuItem.Visible = False



                End If

            Else
                MessageBox.Show("Senha incorreta.")
                senha.Clear()
            End If
            conn.Close()

            ' DESABILITA A TELA DE ALTERAÇÃO, NÃO ESTA SENDO USADA.
            AlterarToolStripMenuItem.Visible = False


            ' SÓ HABILITA A OPÇÃO DE VINCULOS TELEFONICOS APÓS O DIA 25
            Dim DtVinculos As Integer = DateTime.Now.Day
            If (DtVinculos > 24) Then
                MovimentaçõesDeLinhaToolStripMenuItem.Enabled = True
                MovimentaçõesDeLinhaToolStripMenuItem.ToolTipText = "MENU HABILITADO"
            Else
                MovimentaçõesDeLinhaToolStripMenuItem.Enabled = False
                MovimentaçõesDeLinhaToolStripMenuItem.ToolTipText = "MENU SERÁ HABILITADO APÓS O DIA 25."
            End If




            'conn.Open()
            'Dim Readerd As SqlDataReader
            'Dim dt As New DataTable
            'Dim c As New SqlCommand("SELECT N_Requisicao, N_Pedido FROM REQUISICAO", conn)
            'Readerd = c.ExecuteReader()
            'Readerd.Read()
            'If (Readerd.HasRows) Then
            'Else
            '    ConsultaFiscalToolStripMenuItem.Visible = False
            'End If
            'conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error")
        End Try
    End Sub

    Private Sub CadastrarNovoLoginToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Singin = New Cadastro()
        Singin.ShowDialog()
    End Sub

    Private Sub ConsultaGeralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaGeralToolStripMenuItem.Click
        Dim consult = New Consulta()
        consult.ShowDialog()
    End Sub
    Private Sub ConsultaDPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDPToolStripMenuItem.Click
        Dim consultdp = New DP()
        consultdp.ShowDialog()
    End Sub

    Private Sub FiscalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiscalToolStripMenuItem.Click
        Dim consultfiscal = New Fiscal()
        consultfiscal.ShowDialog()
    End Sub

    Private Sub ConsultaDPVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDPVendasToolStripMenuItem.Click
        Dim consultadpvend = New ConsultaDpVendas()
        consultadpvend.ShowDialog()
    End Sub
    Private Sub InserirPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InserirPedidosToolStripMenuItem.Click
        Dim req = New Pedidos()
        req.ShowDialog()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim browser = New WebBrowser()
        browser.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            Dim browser = New WebBrowser()
            browser.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Erro", ex.ToString)
        End Try
    End Sub

    Private Sub MovimentaçõesDeLinhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimentaçõesDeLinhaToolStripMenuItem.Click

        Dim ContasClaro = New ContasClaro()
        ContasClaro.ShowDialog()

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click

    End Sub
End Class