Public Class Form1
    Private Sub btnGo_Click_1(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intStartIndex, intFoundIndex As Integer

        If IsNumeric(txtStartIndex.Text) Then
            If txtToFind.Text.Length > 0 Then
                intStartIndex = CInt(txtStartIndex.Text)
                intFoundIndex = lblString.Text.IndexOf(txtToFind.Text, intStartIndex)
                If intFoundIndex = -1 Then
                    lblResults.Text = "The string was not found."
                Else
                    lblResults.Text = "The string was found at index " & intFoundIndex
                End If
            Else
                MessageBox.Show("Enter a string to search.")
            End If
        Else
            MessageBox.Show("The index must be a number.")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
