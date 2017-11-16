Public Class Form1

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim dblSalary As Double
        Dim intYearsOnJob As Integer

        Try
            dblSalary = CDbl(txtAnnualSalary.Text)
            intYearsOnJob = CInt(txtYearsAtJob.Text)

            If dblSalary > 30000 Then
                If intYearsOnJob > 2 Then
                    lblMessage.Text = "The applicant qualifies"
                Else
                    lblMessage.Text = "The applicant does notqualifies"
                End If
            Else
                If intYearsOnJob > 5 Then
                    lblMessage.Text = "The applicant qualifies"
                Else
                    lblMessage.Text = "The applicant does not qualifies"
                End If
            End If
        Catch
            lblMessage.Text = "Please enter numeric values."
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMessage.Text = String.Empty
        txtAnnualSalary.Clear()
        txtYearsAtJob.Clear()
        txtAnnualSalary.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
