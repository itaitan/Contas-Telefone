Imports System.Data
Imports System.Data.SqlClient

Public Class Cadastro
    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema
    Dim conn As New SqlConnection(connect.ToString)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        TxtLog.Clear()
        TxtPass.Clear()
        TxtPass2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Try
            If TxtPass.Text = TxtPass2.Text Then

                conn.Open()
                Dim dttable As SqlDataReader
                Dim commmand As New SqlCommand("INSERT INTO Logins(Usuario,Senha) values ('" + TxtLog.Text + "','" + TxtPass.Text + "')", conn)
                dttable = commmand.ExecuteReader

                MessageBox.Show("Login cadastrado com sucesso!")
                conn.Close()
                TxtPass.Clear()
                TxtPass2.Clear()
                TxtLog.Clear()

            Else
                MessageBox.Show("Senha invalida")
                TxtPass.Clear()
                TxtPass2.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtLog_TextChanged(sender As Object, e As EventArgs) Handles TxtLog.TextChanged

    End Sub
End Class