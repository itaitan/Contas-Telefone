Public Class WebBrowser
    Private Sub WebBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            WebBrowser1.Navigate(String.Format("C:\Quaestum\manual.pdf", Application.StartupPath))
        Catch ex As Exception
            MessageBox.Show("error", ex.ToString)
        End Try

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles MyBase1.DocumentCompleted

    End Sub
End Class