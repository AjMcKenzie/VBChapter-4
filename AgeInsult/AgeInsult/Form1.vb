Public Class Form1

    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim intAge As Integer

        Try
            intAge = txtUserAgeInput.Text

            If intAge < 10 Then
                lblResult.Text = "Can you even read?"
            ElseIf intAge >= 10 And intAge < 14 Then
                lblResult.Text = "There are no words to express how naive you are."
            ElseIf intAge >= 14 And intAge < 18 Then
                lblResult.Text = "You have no clue how the real word works."
            ElseIf intAge >= 18 And intAge < 24 Then
                lblResult.Text = "You can will fail in life."
            ElseIf intAge >= 24 And intAge < 30 Then
                lblResult.Text = "You are don't know what you are doing with you life."
            ElseIf intAge >= 30 And intAge < 40 Then
                lblResult.Text = "You are getting old."
            ElseIf intAge >= 40 And intAge < 60 Then
                lblResult.Text = "Wow you are old."
            ElseIf intAge >= 60 Then
                lblResult.Text = "I didn't know there were computers in the grave."
            End If
        Catch
            lblMessage.Text = "Enter a numaric value"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = String.Empty
        lblMessage.Text = String.Empty
        txtUserAgeInput.Clear()
        txtUserAgeInput.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
