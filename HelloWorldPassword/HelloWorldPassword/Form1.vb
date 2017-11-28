Public Class Form1

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim intPassword As Integer = 7829

        If txtUserPassword.Text = intPassword Then
            MessageBox.Show("Correct! Hello!")
        Else
            MessageBox.Show("Incorrect!")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserPassword.Clear()
    End Sub
End Class
