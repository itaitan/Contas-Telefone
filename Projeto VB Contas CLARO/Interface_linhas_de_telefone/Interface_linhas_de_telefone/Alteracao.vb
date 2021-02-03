Imports System.Data.SqlClient
Imports System
Imports System.Globalization



Public Class Alteracao

    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema
    Dim conn As New SqlConnection(connect.ToString)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_fill.Click
        Try
            conn.Open()

            Dim dttablebtn As SqlDataReader
            Dim cmdbtn As New SqlCommand("SELECT Cod, Funcionarios, Setores, Desconto FROM dados_telefonicos WHERE Telefones = '" + cmbCel.Text + "'", conn)
            cmdbtn.CommandType = CommandType.Text

            dttablebtn = cmdbtn.ExecuteReader

            dttablebtn.Read()

            If dttablebtn.HasRows = False Then
                MessageBox.Show("Formato do número do celular incorreto, utilize o formato (11 00000-0000)")
            Else

                TxtCod.Text = dttablebtn.GetInt32(0)
                TxtNome.Text = dttablebtn.GetString(1)
                TxtDesc.Text = dttablebtn.GetDouble(3)
                TxtDp.Text = dttablebtn.GetString(2)


                cmbCel.Enabled = False
                End If
                conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "erro")
        End Try
    End Sub

    Private Sub Alteracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            Dim dttable As New DataTable
            Dim cmd As New SqlDataAdapter("Select distinct(telefones) from dados_telefonicos where telefones <> '11'", conn)
            cmd.Fill(dttable)

            cmbCel.DataSource = dttable
            cmbCel.DisplayMember = "telefones"

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("error")
        End Try


    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try

            conn.Open()
            If MsgBox("Deseja alterar esses dados?", MsgBoxStyle.YesNo, "Aviso") = Windows.Forms.DialogResult.Yes Then



                Dim dttaabe As SqlDataReader
                Dim cmd As New SqlCommand("UPDATE dados_telefonicos SET desconto =" + TxtDesc.Text.Replace(",", ".") + " WHERE telefones = '" + cmbCel.Text + "' ", conn)

                dttaabe = cmd.ExecuteReader
                'TxtDesc.Text = dttaabe.GetFloat(3)


                MessageBox.Show("Dados alterados com sucesso!")


                TxtCod.Clear()
                TxtDesc.Clear()
                TxtNome.Clear()
                TxtDp.Clear()
                cmbCel.DisplayMember = Nothing

                cmbCel.Enabled = True
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Erro")
        Finally



        End Try
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Try
            conn.Open()
            If MsgBox("Deseja deletar esses dados?", MsgBoxStyle.YesNo, "Aviso") = Windows.Forms.DialogResult.Yes Then


                Dim dttable As SqlDataReader
                Dim cmd As New SqlCommand("Delete from dados_telefonicos WHERE (telefones ='" + cmbCel.Text + "')", conn)

                dttable = cmd.ExecuteReader

                MessageBox.Show("Dados exluidos com sucesso!")
                cmbCel.DataSource = Nothing

                TxtCod.Clear()
                TxtDesc.Clear()
                TxtNome.Clear()
                TxtDp.Clear()

            End If

            '==================================================================================
            '=========================RETORNA OS NUMEROS PARA O COMBOBOX=======================
            '==================================================================================

            conn.Close()
            conn.Open()

            Dim dttableN As New DataTable
            Dim cmdN As New SqlDataAdapter("Select distinct(telefones) from dados_telefonicos", conn)
            cmdN.Fill(dttableN)

            cmbCel.DataSource = dttableN
            cmbCel.DisplayMember = "telefones"

            cmbCel.Enabled = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Erro")
        End Try
    End Sub

    Private Sub TxtDesc_TextChanged(sender As Object, e As EventArgs) Handles TxtDesc.TextChanged

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Me.Controls.Clear()
        InitializeComponent()
        Alteracao_Load(e, e)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Try
            Dim browser = New WebBrowser()
            browser.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Erro", ex.ToString)
        End Try
    End Sub

    Private Sub cmbCel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCel.SelectedIndexChanged

    End Sub

    Private Sub TxtNome_TextChanged(sender As Object, e As EventArgs) Handles TxtNome.TextChanged

    End Sub
End Class