Public Class Form1


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If radCoffee.Checked = True Then
            lblResult.Text = "You selected coffee"
        ElseIf radTea.Checked = True Then
            lblResult.Text = "You selected tea"
        ElseIf radSoftDrink.Checked = True Then
            lblResult.Text = "You selected soft drink"
        End If

        If chkWhippedCream.Checked = True Then
            lblResult.Text &= ", and Whipped Cream"
        End If

        If chkMoca.Checked = True Then
            lblResult.Text &= ", and Moca"
        End If

        If chkAmaretto.Checked = True Then
            lblResult.Text &= ", and Amaretto"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = String.Empty
        radCoffee.Checked = False
        radTea.Checked = False
        radSoftDrink.Checked = False
        chkWhippedCream.Checked = False
        chkMoca.Checked = False
        chkAmaretto.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
