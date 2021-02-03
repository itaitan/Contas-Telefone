Imports System.Data.SqlClient
Imports System
Imports System.Globalization
Public Class ContasClaro

    Private objetoBanco As New AcessoDB
    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema

    Dim conexao As New SqlConnection(connect.ToString)
    Dim funcionario As String = ""
    Dim setor As String = ""
    Dim codigo As String = ""
    Dim LogVinculo As String = ""

    Public Sub Enable_clearTxtBox()

        txt_fun.Clear()
        txt_setor.Clear()
        txt_cod.Clear()
        txt_CentroCusto.Clear()
        txt_cargo.Clear()
        txt_Desconto.Clear()
        txt_TotalFatura.Clear()
        txt_TotalFun.Clear()
        txt_Ndados.Clear()


    End Sub

    Public Sub Enable_txtBox()

        txt_fun.Enabled = False
        txt_cod.Enabled = False
        txt_setor.Enabled = False
        txt_CentroCusto.Enabled = False
        txt_cargo.Enabled = False
        txt_Desconto.Enabled = False
        txt_TotalFatura.Enabled = False
        txt_TotalFun.Enabled = False
        txt_Filial.Enabled = False
        txt_Ndados.Enabled = False
        txt_tel.Visible = True

    End Sub

    Public Sub InclusaoNdados()
        Try

            conexao.Open()

            If (txt_fun.Enabled = True And txt_Ndados.Enabled = False And txt_Ndados.Text = "SEM NDADOS") Then  '== Vincula um novo funcionario que estava em Reserva voz
                Dim uppdate = "update dados_telefonicos set funcionarios = '" + txt_fun.Text + "', setores = '" + cmb_setores.Text + "', cod = " + txt_cod.Text + ", centrodecusto = '" + txt_CentroCusto.Text + "', CARGO = '" + txt_cargo.Text + "', DESCONTO = " + txt_Desconto.Text.Replace(",", ".") + ", TTFATURA = " + txt_TotalFatura.Text.Replace(",", ".") + ",TOTAL_FUNC = " + txt_TotalFun.Text.Replace(",", ".") + ", NDADOS = '" + txt_Ndados.Text + "', FILIAL = '" + txt_Filial.Text + "' where telefones ='" + cmb_telefone.Text + "'"

                Dim cmd As New SqlCommand(uppdate, conexao)

                cmd.ExecuteNonQuery()

                Enable_txtBox()
                Enable_clearTxtBox()

                MessageBox.Show("Dados INCLUSOS!!")

                Enable_clearTxtBox()


            ElseIf (cmb_RVoz.Visible = True) Then '== Vincula um RVoz em um funinario que tenha apenas um numero de NDADOS

                Dim uppdate1 = "update dados_telefonicos set Telefones = '" + cmb_RVoz.Text + "', DESCONTO = " + txt_Desconto.Text.Replace(",", ".") + ", TTFATURA = " + txt_TotalFatura.Text.Replace(",", ".") + ",TOTAL_FUNC = " + txt_TotalFun.Text.Replace(",", ".") + " where ndados ='" + cmb_ndados.Text + "'"
                Dim deleteRVOZ = "delete from dados_telefonicos where telefones = '" + cmb_RVoz.Text + "'"

                Dim cmddel As New SqlCommand(deleteRVOZ, conexao)
                Dim cmdup As New SqlCommand(uppdate1, conexao)

                cmddel.ExecuteNonQuery()
                cmdup.ExecuteNonQuery()

                MessageBox.Show("Dados incluidos!")
                Enable_clearTxtBox()

            ElseIf (cmb_Ndados_inclu.Visible = True) Then '== Vincula um numero de Ndados em um funcionario que tenha apenas RVOZ

                Dim uppdate2 = "update dados_telefonicos set Telefones = '" + txt_tel.Text + "', DESCONTO = " + txt_Desconto.Text.Replace(",", ".") + ", TTFATURA = " + txt_TotalFatura.Text.Replace(",", ".") + ",TOTAL_FUNC = " + txt_TotalFun.Text.Replace(",", ".") + ", NDADOS = '" + cmb_Ndados_inclu.Text + "' where telefones ='" + txt_tel.Text + "'"
                Dim deleteNdados = "delete from dados_telefonicos where telefones = '" + cmb_Ndados_inclu.Text + "'"

                Dim cmdde2 As New SqlCommand(deleteNdados, conexao)
                Dim cmdup1 As New SqlCommand(uppdate2, conexao)

                cmdde2.ExecuteNonQuery()
                cmdup1.ExecuteNonQuery()

                MessageBox.Show("Dados incluidos!")
                Enable_clearTxtBox()


            ElseIf (txt_Ndados.Enabled = False) Then '== Vincula um novo funcionario que estava no Reserva DADOS
                Dim uppdate = "update dados_telefonicos set telefones = 'SEM TELEFONE', funcionarios = '" + txt_fun.Text + "', setores = '" + cmb_setores.Text + "', cod = " + txt_cod.Text + ", centrodecusto = '" + txt_CentroCusto.Text + "', CARGO = '" + txt_cargo.Text + "', DESCONTO = " + txt_Desconto.Text.Replace(",", ".") + ", TTFATURA = " + txt_TotalFatura.Text.Replace(",", ".") + ",TOTAL_FUNC = " + txt_TotalFun.Text.Replace(",", ".") + ", NDADOS = '" + txt_Ndados.Text + "', FILIAL = '" + txt_Filial.Text + "' where telefones ='" + cmb_telefone.Text + "'"

                Dim cmd As New SqlCommand(uppdate, conexao)

                cmd.ExecuteNonQuery()

                Enable_txtBox()
                Enable_clearTxtBox()

                MessageBox.Show("Dados INCLUSOS!!")

                Enable_clearTxtBox()


            ElseIf (cmbFuncionario.Visible = True And txt_fun.Visible = False) Then '== Vincular quando o setor for igual cooperativo para acrescimo de filial
                Dim uppdate4 = "update dados_telefonicos set funcionarios = '" + cmbFuncionario.Text + "', setores = '" + cmb_setores.Text + "', cod = " + txt_cod.Text + ", centrodecusto = '" + txt_CentroCusto.Text + "', CARGO = '" + txt_cargo.Text + "', DESCONTO = " + txt_Desconto.Text.Replace(",", ".") + ", TTFATURA = " + txt_TotalFatura.Text.Replace(",", ".") + ",TOTAL_FUNC = " + txt_TotalFun.Text.Replace(",", ".") + ", NDADOS = '" + txt_Ndados.Text + "', FILIAL = '" + txt_Filial.Text + "' where telefones ='" + cmb_telefone.Text + "'"

                Dim cmd4 As New SqlCommand(uppdate4, conexao)

                cmd4.ExecuteNonQuery()

                Enable_txtBox()
                Enable_clearTxtBox()

                MessageBox.Show("Dados INCLUSOS!!")

                Enable_clearTxtBox()


            End If
            conexao.Close()
        Catch ex As Exception
            MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
        Finally

        End Try
    End Sub
    Public Sub RESERVA_DE_NDADOS()
        Try

            If (txt_fun.Text = "SEM NOME") Or (txt_setor.Text = "RESERVA VOZ") Then
                MessageBox.Show("Esse telefone ja se encontra na RESERVA!")

            ElseIf MsgBox("Deseja mover para Reserva??", MsgBoxStyle.YesNo, "Aviso") = DialogResult.Yes Then

                conexao.Open()

                If (txt_tel.Text <> "SEM TELEFONE") Then

                    Dim cmd1 As New SqlCommand("INSERT INTO dados_telefonicos (Funcionarios, Cod, Setores, Telefones, CENTRODECUSTO, Cargo, Desconto, TTFATURA, TOTAL_FUNC, NDADOS, FILIAL, EXCEDENTES, CADASTRADO ) VALUES ('" + txt_fun.Text + "', " + txt_cod.Text + ", '" + txt_setor.Text + "', '" + txt_tel.Text + "', '" + txt_CentroCusto.Text + "', '" + txt_cargo.Text + "', " + txt_Desconto.Text.Replace(",", ".") + ", " + txt_TotalFatura.Text.Replace(",", ".") + ", " + txt_TotalFun.Text.Replace(",", ".") + ", 'SEM NDADOS', '" + txt_Filial.Text + "', 0, DEFAULT)", conexao)
                    cmd1.ExecuteNonQuery()

                End If

                Dim cmd As New SqlCommand("update dados_telefonicos set funcionarios = 'SEM NOME', setores = 'RESERVA DADOS', ttfatura = 0, total_func = 0, cod = 0, NDADOS = 'SEM NDADOS', Telefones = '" + txt_Ndados.Text + "', CARGO = ' ', CENTRODECUSTO = ' ', FILIAL = DEFAULT, DESCONTO = 0 where ndados ='" + txt_Ndados.Text + "'", conexao)
                cmd.ExecuteNonQuery()
                conexao.Close()
                MessageBox.Show("Dados Movidos para Reserva!!")
                Enable_clearTxtBox()

            End If

        Catch ex As Exception
            MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
        Finally

        End Try
    End Sub
    Public Sub ReservaVoz()
        Try

            If (txt_fun.Text = "SEM NOME") Or (txt_setor.Text = "RESERVA VOZ") Then
                MessageBox.Show("Esse telefone ja se encontra na RESERVA!")

            ElseIf MsgBox("Deseja mover para Reserva??", MsgBoxStyle.YesNo, "Aviso") = DialogResult.Yes Then

                conexao.Open()

                If (txt_Ndados.Text <> "SEM NDADOS") Then

                    Dim cmd1 As New SqlCommand("INSERT INTO dados_telefonicos (Funcionarios, Cod, Setores, Telefones, CENTRODECUSTO, Cargo, Desconto, TTFATURA, TOTAL_FUNC, NDADOS, FILIAL, EXCEDENTES, CADASTRADO ) VALUES ('" + txt_fun.Text + "', " + txt_cod.Text + ", '" + txt_setor.Text + "', 'SEM TELEFONE', '" + txt_CentroCusto.Text + "', '" + txt_cargo.Text + "', " + txt_Desconto.Text.Replace(",", ".") + ", " + txt_TotalFatura.Text.Replace(",", ".") + ", " + txt_TotalFun.Text.Replace(",", ".") + ", '" + txt_Ndados.Text + "', '" + txt_Filial.Text + "', 0, DEFAULT)", conexao)
                    cmd1.ExecuteNonQuery()

                End If

                Dim cmd As New SqlCommand("update dados_telefonicos set funcionarios = 'SEM NOME', setores = 'RESERVA VOZ', cod = 0, NDADOS = 'SEM NDADOS', CARGO = ' ', CENTRODECUSTO = ' ', FILIAL = DEFAULT, DESCONTO = 0 where telefones ='" + cmb_telefone.Text + "'", conexao)

                cmd.ExecuteNonQuery()
                conexao.Close()

                MessageBox.Show("Dados Movidos para Reserva!!")

                Enable_clearTxtBox()

            End If

        Catch ex As Exception
            MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
        Finally

        End Try
    End Sub
    Public Sub preencherCmb_Ndados_inclu()
        Try

            objetoBanco.Conectar()
            Dim campo As DataTable = New DataTable
            Dim ds As DataSet = objetoBanco.ExecuteQuerry("SELECT telefones FROM DADOS_TELEFONICOS WHERE setores = 'Reserva DADOS' order by telefones desc ")
            campo = ds.Tables(0)

            cmb_Ndados_inclu.ValueMember = "telefones"
            cmb_Ndados_inclu.DisplayMember = "telefones"
            cmb_Ndados_inclu.DataSource = campo

            objetoBanco.Fechar()
        Catch ex As Exception
            MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
        End Try
    End Sub
    Public Sub preencherCmb_RVoz()

        Try

            objetoBanco.Conectar()
            Dim campo As DataTable = New DataTable
            Dim ds As DataSet = objetoBanco.ExecuteQuerry("SELECT telefones FROM DADOS_TELEFONICOS WHERE setores = 'Reserva Voz' order by telefones desc ")
            campo = ds.Tables(0)

            cmb_RVoz.ValueMember = "telefones"
            cmb_RVoz.DisplayMember = "telefones"
            cmb_RVoz.DataSource = campo

            objetoBanco.Fechar()
        Catch ex As Exception
            MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
        End Try

    End Sub

    Public Sub preencherCmb_setores()
        Try

            objetoBanco.Conectar()
            Dim campo As DataTable = New DataTable
            Dim ds As DataSet = objetoBanco.ExecuteQuerry("select distinct setores from dados_telefonicos")
            campo = ds.Tables(0)

            cmb_setores.ValueMember = "SETORES"
            cmb_setores.DisplayMember = "SETORES"
            cmb_setores.DataSource = campo

            objetoBanco.Fechar()
        Catch ex As Exception
            MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
        End Try

    End Sub

    Public Sub preencherCmb_Ndados()
        If cmb_ndados.Enabled = True Then

            Try

                Enable_clearTxtBox()

                objetoBanco.Conectar()
                Dim campo As DataTable = New DataTable
                Dim ds As DataSet = objetoBanco.ExecuteQuerry("SELECT NDADOS FROM DADOS_TELEFONICOS WHERE NDADOS != 'SEM NDADOS' AND TELEFONES LIKE 'SEM TELEFONE' ORDER BY NDADOS")
                campo = ds.Tables(0)

                cmb_ndados.ValueMember = "NDADOS"
                cmb_ndados.DisplayMember = "NDADOS"
                cmb_ndados.DataSource = campo

                objetoBanco.Fechar()
            Catch ex As Exception
                MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
            End Try

        End If
    End Sub

    Public Sub preencherCmB_tel()
        Try

            objetoBanco.Conectar()
            Dim campo As DataTable = New DataTable
            Dim ds As DataSet = objetoBanco.ExecuteQuerry("select distinct telefones from dados_telefonicos order by telefones desc")
            campo = ds.Tables(0)

            cmb_telefone.ValueMember = "telefones"
            cmb_telefone.DisplayMember = "telefones"
            cmb_telefone.DataSource = campo

            objetoBanco.Fechar()

        Catch ex As Exception
            MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
        End Try

    End Sub
    Public Sub buscaPreencheminetotxtbox_NDADOS()
        Try

            Dim leitura As SqlDataReader = Nothing
            Dim selecttabela As String = "select * from dados_telefonicos Where NDADOS = '" + cmb_ndados.Text + "'"

            conexao.Open()
            Dim command As New SqlCommand(selecttabela, conexao)


            leitura = command.ExecuteReader(CommandBehavior.SingleRow)
            If (leitura.HasRows) Then
                leitura.Read()

                txt_tel.Text = leitura.Item("TELEFONES").ToString
                txt_fun.Text = leitura.Item("FUNCIONARIOS").ToString
                txt_cod.Text = leitura.Item("COD").ToString
                txt_setor.Text = leitura.Item("SETORES").ToString
                txt_CentroCusto.Text = leitura.Item("CENTRODECUSTO").ToString
                txt_cargo.Text = leitura.Item("CARGO").ToString
                txt_Desconto.Text = leitura.Item("DESCONTO").ToString
                txt_TotalFatura.Text = leitura.Item("TTFATURA").ToString
                txt_TotalFun.Text = leitura.Item("TOTAL_FUNC").ToString
                txt_Filial.Text = leitura.Item("FILIAL").ToString
                txt_Ndados.Text = leitura.Item("NDADOS").ToString

            End If

            conexao.Close()

        Catch ex As Exception
            MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
        Finally

        End Try

    End Sub
    Public Sub buscaPreenchimentotxtBox_telefone()
        Try

            Dim leitura As SqlDataReader = Nothing
            Dim selecttabela As String = "select * from dados_telefonicos Where telefones = '" + cmb_telefone.Text + "'"

            conexao.Open()
            Dim command As New SqlCommand(selecttabela, conexao)

            leitura = command.ExecuteReader(CommandBehavior.SingleRow)
            If (leitura.HasRows) Then
                leitura.Read()

                txt_tel.Text = leitura.Item("TELEFONES").ToString
                txt_fun.Text = leitura.Item("FUNCIONARIOS").ToString
                txt_cod.Text = leitura.Item("COD").ToString
                txt_setor.Text = leitura.Item("SETORES").ToString
                txt_CentroCusto.Text = leitura.Item("CENTRODECUSTO").ToString
                txt_cargo.Text = leitura.Item("CARGO").ToString
                txt_Desconto.Text = leitura.Item("DESCONTO").ToString
                txt_TotalFatura.Text = leitura.Item("TTFATURA").ToString
                txt_TotalFun.Text = leitura.Item("TOTAL_FUNC").ToString
                txt_Filial.Text = leitura.Item("FILIAL").ToString
                txt_Ndados.Text = leitura.Item("NDADOS").ToString

            End If

            conexao.Close()

        Catch ex As Exception
            MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
        Finally

        End Try

    End Sub

    Public Sub logBackup(ByVal modificar As String)

        'Variaveis para efetuação do insert na tabela de backup
        Dim telefone As String = txt_tel.Text
        funcionario = txt_fun.Text
        codigo = txt_cod.Text
        setor = txt_setor.Text
        Dim centrodecusto As String = txt_CentroCusto.Text
        Dim cargo As String = txt_cargo.Text
        Dim Desconto As String = txt_Desconto.Text
        Dim TotalFatura As String = txt_TotalFatura.Text
        Dim Totalfunc As String = txt_TotalFun.Text
        Dim Filial As String = txt_Filial.Text
        Dim ndados As String = txt_Ndados.Text

        Try
            conexao.Open()
            Dim cmd1 As New SqlCommand("INSERT INTO  LOGAlteracao (COD, FUNCIONARIOS, TELEFONES, SETORES, CENTRODECUSTO, CARGO, DESCONTO, TTFATURA, TOTAL_FUNC, NDADOS, EXCEDENTES, FILIAL, DTModificacao, ACAO) values( '" + codigo + "', '" + funcionario + "', '" + telefone + "', '" + setor + "', '" + centrodecusto + "','" + cargo + "', " + Desconto.Replace(",", ".") + ", " + TotalFatura.Replace(",", ".") + ", " + Totalfunc.Replace(",", ".") + ", '" + ndados + "', 0, '" + Filial + "', getdate(), '" + modificar + "')", conexao)
            cmd1.ExecuteNonQuery()
            conexao.Close()

        Catch ex As Exception
            MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
        End Try


    End Sub


    Private Sub Alterar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preencherCmb_RVoz()
        preencherCmB_tel()
        preencherCmb_Ndados()
        preencherCmb_Ndados_inclu()
        preencherCmb_setores()

    End Sub

    Private Sub btn_Vincular_Click(sender As Object, e As EventArgs) Handles btn_Vincular.Click

        Try
            conexao.Open()
            Dim command As New SqlCommand(LogVinculo, conexao)
            command.ExecuteNonQuery()
            conexao.Close()

            InclusaoNdados()

            btn_Modificar.Enabled = True
            cmb_RVoz.Visible = False
            cmb_Ndados_inclu.Visible = False
            cmb_setores.Visible = False

            preencherCmB_tel()
            preencherCmb_Ndados()
        Catch ex As Exception
            MessageBox.Show("MENSAGEM DE ERRO: " + ex.Message + " ------STRING DO ERRO: " + ex.ToString)
        End Try



    End Sub
    Private Sub btn_ndados_Click(sender As Object, e As EventArgs) Handles btn_ndados.Click
        If (txt_Ndados.Text = "SEM NDADOS") Then
            MessageBox.Show("Nenhum NDados selecionado")
        Else
            Dim MoverReserva As String = "Mover para reserva Ndados"
            logBackup(MoverReserva)
            RESERVA_DE_NDADOS()
            preencherCmB_tel()
            preencherCmb_Ndados()
        End If

    End Sub

    Private Sub btn_Reserva_Click(sender As Object, e As EventArgs) Handles btn_Reserva.Click
        If (txt_tel.Text = "SEM TELEFONE") Then
            MessageBox.Show("Nenhum telefone selecionado")
        Else
            Dim MoverReserva As String = "Mover para reserva voz"
            logBackup(MoverReserva)
            ReservaVoz()
            preencherCmB_tel()
            preencherCmb_Ndados()
        End If
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click

        Dim telefone As String = txt_tel.Text
        funcionario = txt_fun.Text
        codigo = txt_cod.Text
        setor = txt_setor.Text
        Dim centrodecusto As String = txt_CentroCusto.Text
        Dim cargo As String = txt_cargo.Text
        Dim Desconto As String = txt_Desconto.Text
        Dim TotalFatura As String = txt_TotalFatura.Text
        Dim Totalfunc As String = txt_TotalFun.Text
        Dim Filial As String = txt_Filial.Text
        Dim ndados As String = txt_Ndados.Text

        If (Desconto = "") Then
            LogVinculo = "INSERT INTO  LOGAlteracao (COD, FUNCIONARIOS, TELEFONES, SETORES, CENTRODECUSTO, CARGO, DESCONTO, TTFATURA, TOTAL_FUNC, NDADOS, EXCEDENTES, FILIAL, DTModificacao, ACAO) values( '" + codigo + "', '" + funcionario + "', '" + telefone + "', '" + setor + "', '" + centrodecusto + "','" + cargo + "', 0," + TotalFatura.Replace(",", ".") + ", " + Totalfunc.Replace(",", ".") + ", '" + ndados + "', 0, '" + Filial + "', getdate(), 'Vincular')"
        Else
            LogVinculo = "INSERT INTO  LOGAlteracao (COD, FUNCIONARIOS, TELEFONES, SETORES, CENTRODECUSTO, CARGO, DESCONTO, TTFATURA, TOTAL_FUNC, NDADOS, EXCEDENTES, FILIAL, DTModificacao, ACAO) values( '" + codigo + "', '" + funcionario + "', '" + telefone + "', '" + setor + "', '" + centrodecusto + "','" + cargo + "', " + Desconto.Replace(",", ".") + ", " + TotalFatura.Replace(",", ".") + ", " + Totalfunc.Replace(",", ".") + ", '" + ndados + "', 0, '" + Filial + "', getdate(), 'Vincular')"
        End If

        If (funcionario = "SEM NOME") Then
            cmb_setores.Visible = True
            'txt_fun.Enabled = True
            'txt_cod.Enabled = True
            txt_setor.Enabled = False
            'txt_CentroCusto.Enabled = True
            'txt_cargo.Enabled = True
            'txt_Desconto.Enabled = True
            'txt_TotalFatura.Enabled = True
            'txt_TotalFun.Enabled = True
            'txt_Filial.Enabled = True
            'txt_Ndados.Enabled = True
            'btn_Vincular.Enabled = True


            'Condição para que um reserva dados seja vinculado ao um novo funcionario
            If (txt_setor.Text = "RESERVA DADOS" Or txt_setor.Text = "RESERVA DADOS NOVAS") Then
                txt_Ndados.Text = cmb_telefone.Text
                txt_Ndados.Enabled = False
            End If


        ElseIf (txt_tel.Text = "SEM TELEFONE") Then

            txt_TotalFatura.Enabled = True
            txt_TotalFun.Enabled = True
            txt_tel.Visible = False
            cmb_RVoz.Visible = True
            btn_Vincular.Enabled = True

        ElseIf (txt_Ndados.Text = "SEM NDADOS" And txt_fun.Text <> "SEM NOME") Then

            txt_TotalFatura.Enabled = True
            txt_TotalFun.Enabled = True
            btn_Vincular.Enabled = True
            txt_Ndados.Visible = False
            cmb_Ndados_inclu.Visible = True

        End If

        btn_Modificar.Enabled = False

        preencherCmb_RVoz()
        preencherCmb_Ndados_inclu()


    End Sub
    Private Sub cmb_telefone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_telefone.SelectedIndexChanged

        buscaPreenchimentotxtBox_telefone()

        If cmb_telefone.Text <> "SEM TELEFONE" Then

            cmb_ndados.Visible = False
            txt_Ndados.Visible = True
            cmb_RVoz.Visible = False

        Else

            txt_Ndados.Visible = False
            cmb_ndados.Visible = True

        End If

        cmb_setores.Visible = False
        btn_Modificar.Enabled = True

        Enable_txtBox()


    End Sub


    Private Sub cmb_ndados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ndados.SelectedIndexChanged
        buscaPreencheminetotxtbox_NDADOS()
        cmb_RVoz.Visible = False
        btn_Modificar.Enabled = True
        txt_tel.Visible = True

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_setores.SelectedIndexChanged
        If (cmb_setores.Text = "CORPORATIVO") Then
            txt_fun.Visible = False
            txt_fun.Enabled = False
            cmbFuncionario.Visible = True

            conexao.Open()
            Dim campo As DataTable = New DataTable
            Dim ds As DataSet = objetoBanco.ExecuteQuerry("select distinct(funcionarios) from dados_telefonicos where setores = 'CORPORATIVO'")
            campo = ds.Tables(0)

            cmbFuncionario.ValueMember = "funcionarios"
            cmbFuncionario.DisplayMember = "funcionarios"
            cmbFuncionario.DataSource = campo

            conexao.Close()
        Else
            txt_fun.Enabled = True
        End If

        If (cmb_setores.Text = "GER SUB LOJAS") Then
            txt_Filial.Enabled = True
        Else
            txt_Filial.Enabled = False
        End If

        If (txt_setor.Text = "RESERVA DADOS" Or txt_setor.Text = "RESERVA DADOS NOVAS") Then

            txt_Ndados.Enabled = False
        Else
            txt_Ndados.Enabled = False
        End If

        txt_cod.Enabled = True
        txt_CentroCusto.Enabled = True
        txt_cargo.Enabled = True
        txt_Desconto.Enabled = True
        txt_TotalFatura.Enabled = True
        txt_TotalFun.Enabled = True
        btn_Vincular.Enabled = True


    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)
    End Sub

    Private Sub ToolTip1_Popup_1(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub cmbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFuncionario.SelectedIndexChanged

    End Sub
End Class
