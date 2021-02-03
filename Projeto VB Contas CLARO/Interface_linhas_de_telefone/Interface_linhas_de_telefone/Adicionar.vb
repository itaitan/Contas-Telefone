Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Adicionar



    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema
    Dim conn As New SqlConnection(connect.ToString)


    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_sng_Click_1(sender As Object, e As EventArgs) Handles btn_sng.Click

        Try

            conn.Open()
            If (TxtCargo.Text = "") Or (TxtCel.Text = "(  )      -") Or (TxtNome.Text = "") Or (TxtDp.Text = "") Then
                MessageBox.Show("Existem campos vazios")

            ElseIf MsgBox("Deseja salvar esses dados?", MsgBoxStyle.YesNo, "Aviso") = Windows.Forms.DialogResult.Yes Then

                Dim telefones = TxtCel.Text
                Dim nudados = Ndados.Text
                telefones = telefones.Replace("(", "")
                telefones = telefones.Replace(")", "")

                Dim cmd As New SqlCommand("INSERT INTO dados_telefonicos (Cod, Funcionarios , Telefones , NDADOS, Setores ,Desconto, Cargo, CENTRODECUSTO) VALUES (" + TxtCod.Text + ", '" + TxtNome.Text + "', '" + telefones + "','" + nudados + "', '" + TxtDp.Text + "', " + TxtDesc.Text + ", '" + TxtCargo.Text + "','" + txtCC.Text + "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Dados cadastrado com sucesso!")

                TxtCod.Clear()
                txtCC.Clear()
                Ndados.Clear()
                TxtCargo.Clear()
                TxtDesc.Clear()
                TxtNome.Clear()
                TxtDp.Clear()
                TxtCel.Clear()



            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Erro")
        Finally



        End Try
    End Sub

    Private Sub Adicionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Try
            Dim browser = New WebBrowser()
            browser.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Erro", ex.ToString)
        End Try
    End Sub

    Private Sub TxtNome_TextChanged(sender As Object, e As EventArgs) Handles TxtNome.TextChanged

    End Sub
End Class