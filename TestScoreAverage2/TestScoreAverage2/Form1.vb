Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblScore1, dblScore2, dblScore3, dblAverage As Double
        Const NUM_SCORES As Integer = 3
        Const dblHIGH_SCORE As Double = 95.0

        Try
            dblScore1 = CDbl(txtScore1.Text)
            dblScore2 = CDbl(txtScore2.Text)
            dblScore3 = CDbl(txtScore3.Text)
            dblAverage = (dblScore1 + dblScore2 + dblScore3) / NUM_SCORES
            lblAverage.Text = dblAverage.ToString("n2")

            If dblAverage < 60 Then
                lblGrade.Text = "F"
            ElseIf dblAverage < 70 Then
                lblGrade.Text = "D"
            ElseIf dblAverage < 80 Then
                lblGrade.Text = "C"
            ElseIf dblAverage < 90 Then
                lblGrade.Text = "B"
            ElseIf dblAverage <= 100 Then
                lblGrade.Text = "A"
            End If

            If dblAverage > dblHIGH_SCORE Then
                lblMessage.Text = "Congratulations! Great Job!"
            Else
                lblMessage.Text = "Keep trying!"
            End If
        Catch
            lblMessage.Text = "Error: Scores must be numeric."
        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        lblAverage.Text = String.Empty
        lblMessage.Text = String.Empty
        lblGrade.Text = String.Empty
        txtScore1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
