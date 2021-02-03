Public Class Loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value < 100) Then
            ProgressBar1.Value = ProgressBar1.Value + 10
        Else
            Timer1.Enabled = False
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class