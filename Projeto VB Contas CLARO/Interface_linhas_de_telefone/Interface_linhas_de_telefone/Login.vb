Imports System.Data
Imports System.Data.SqlClient



Public Class Login
    Public user As String
    Public pass As String

    Dim connect As New SqlConnectionStringBuilder("") 'Retirei endereço de conexão devido a segurança do sistema
    Dim conn As New SqlConnection(connect.ToString)


    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try

            conn.Open()

            Dim pas As SqlDataReader
            Dim dttablef As New DataTable
            Dim Command As New SqlCommand("SELECT * from Logins WHERE Senha = '" + TextBoxPassword.Text + "' AND Usuario ='" + TextBoxLogin.Text + "'", conn)
            pas = Command.ExecuteReader()
            pas.Read()

            If (pas.HasRows) Then

                user = TextBoxLogin.Text
                pass = TextBoxPassword.Text

                Home.Visible = True



            Else
                MessageBox.Show("Senha incorreta.")
                TextBoxPassword.Clear()

            End If

            conn.Close()

            'Try
            '    conn.Open()
            '    Dim dttable As New DataTable
            '    Dim cmd As New SqlDataAdapter("INSERT INTO logs (usuario) VALUES '" + TextBoxLogin.Text + "'", conn)
            '    cmd.Fill(dttable)
            '    conn.Close()
            'Catch ex As Exception

            'End Try


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error")
        End Try


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub TextBoxPassword_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter)) Then
            btn_login.PerformClick()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        ContasClaro.Show()
    End Sub

    Private Sub TextBoxLogin_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLogin.TextChanged

    End Sub
End Class