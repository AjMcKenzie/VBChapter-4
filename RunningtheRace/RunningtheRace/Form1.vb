Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblTime1, dblTime2, dblTime3 As Double

        dblTime1 = (txtTime1.Text)
        dblTime2 = (txtTime2.Text)
        dblTime3 = (txtTime3.Text)

        If dblTime1 < dblTime2 And dblTime1 < dblTime3 Then
            lbl1stPlace.Text = (txtRunner1.Text)
            If dblTime2 < dblTime3 Then
                lbl2ndPlace.Text = txtRunner2.Text
                lbl3rdPlace.Text = txtRunner3.Text
            ElseIf dblTime3 < dblTime2 Then
                lbl3rdPlace.Text = txtRunner3.Text
                lbl2ndPlace.Text = txtRunner2.Text
            End If
        End If
        If dblTime2 < dblTime1 And dblTime2 < dblTime3 Then
            lbl1stPlace.Text = (txtRunner2.Text)
            If dblTime1 < dblTime3 Then
                lbl2ndPlace.Text = txtRunner1.Text
                lbl3rdPlace.Text = txtRunner3.Text
            ElseIf dblTime3 < dblTime1 Then
                lbl2ndPlace.Text = txtRunner3.Text
                lbl3rdPlace.Text = txtRunner1.Text
            End If
        End If
        If dblTime3 < dblTime1 And dblTime3 < dblTime2 Then
            lbl1stPlace.Text = (txtRunner3.Text)
            If dblTime1 < dblTime2 Then
                lbl2ndPlace.Text = txtRunner1.Text
                lbl3rdPlace.Text = txtRunner2.Text
            ElseIf dblTime2 < dblTime1 Then
                lbl2ndPlace.Text = txtRunner2.Text
                lbl3rdPlace.Text = txtRunner1.Text
            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRunner1.Clear()
        txtRunner2.Clear()
        txtRunner3.Clear()
        txtTime1.Clear()
        txtTime2.Clear()
        txtTime3.Clear()
        lbl1stPlace.Text = String.Empty
        lbl2ndPlace.Text = String.Empty
        lbl3rdPlace.Text = String.Empty
        txtRunner1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
