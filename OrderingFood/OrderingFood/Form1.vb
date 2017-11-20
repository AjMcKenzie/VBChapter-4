Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblBurger As Double = 5.99
        Dim dblCheese As Double = 5.99
        Dim dblChicken As Double = 5.99
        Dim dblHamTurkey As Double = 5.99
        Dim dblTomato As Double = 0.5
        Dim dblLettuce As Double = 0.5
        Dim dblMayo As Double = 0.5
        Dim dblPickles As Double = 0.5
        Dim dblFries As Double = 1.99
        Dim dblOnionRings As Double = 1.99
        Dim dblChips As Double = 1.99
        Dim dblTotal As Double

        If radHambuger.Checked = True Then
            lblResult.Text = "You selected Hambuger"
            dblTotal = dblBurger + dblTotal
        ElseIf radCheeseBuger.Checked = True Then
            lblResult.Text = "You selected Cheese Buger"
            dblTotal = dblCheese + dblTotal
        ElseIf radChickenPatty.Checked = True Then
            lblResult.Text = "You selected Chicken Patty"
            dblTotal = dblChicken + dblTotal
        ElseIf radHamandTurkey.Checked = True Then
            lblResult.Text = "You selected Ham and Turkey sandwhich"
            dblTotal = dblHamTurkey + dblTotal
        End If


        If chkTomato.Checked = True Then
            lblResult.Text &= ", and Tomato"
            dblTotal = dblTomato + dblTotal
        End If
        If chkLettuce.Checked = True Then
            lblResult.Text &= ", and Lettuce"
            dblTotal = dblLettuce + dblTotal
        End If
        If chkMayo.Checked = True Then
            lblResult.Text &= ", and Mayo"
            dblTotal = dblMayo + dblTotal
        End If
        If chkPickles.Checked = True Then
            lblResult.Text &= ", and Pickles"
            dblTotal = dblPickles + dblTotal
        End If


        If radFries.Checked = True Then
            lblResult.Text &= ", and Fries"
            dblTotal = dblFries + dblTotal
        ElseIf radChips.Checked = True Then
            lblResult.Text &= ", and Chips"
            dblTotal = dblChips + dblTotal
        ElseIf radOnionRings.Checked = True Then
            lblResult.Text &= ", and Onion Rings"
            dblTotal = dblOnionRings + dblTotal
        End If
        lblTotal.Text = dblTotal.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = String.Empty
        lblTotal.Text = String.Empty
        radCheeseBuger.Checked = False
        radHambuger.Checked = False
        radChickenPatty.Checked = False
        radHamandTurkey.Checked = False
        radFries.Checked = False
        radOnionRings.Checked = False
        radChips.Checked = False
        chkLettuce.Checked = False
        chkTomato.Checked = False
        chkMayo.Checked = False
        chkPickles.Checked = False

        pbHambuger.Visible = False
        pbCheese.Visible = False
        pbChicken.Visible = False
        pbhamandTurkey.Visible = False


        pbPickles.Visible = False
        pbMayo.Visible = False
        pbTomato.Visible = False
        pbLettuce.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radHambuger_CheckedChanged(sender As Object, e As EventArgs) Handles radHambuger.CheckedChanged
        pbHambuger.Visible = True
        pbCheese.Visible = False
        pbChicken.Visible = False
        pbhamandTurkey.Visible = False
    End Sub

    Private Sub radCheeseBuger_CheckedChanged(sender As Object, e As EventArgs) Handles radCheeseBuger.CheckedChanged
        pbHambuger.Visible = False
        pbCheese.Visible = True
        pbChicken.Visible = False
        pbhamandTurkey.Visible = False
    End Sub

    Private Sub radChickenPatty_CheckedChanged(sender As Object, e As EventArgs) Handles radChickenPatty.CheckedChanged
        pbHambuger.Visible = False
        pbCheese.Visible = False
        pbChicken.Visible = True
        pbhamandTurkey.Visible = False
    End Sub

    Private Sub radHamandTurkey_CheckedChanged(sender As Object, e As EventArgs) Handles radHamandTurkey.CheckedChanged
        pbHambuger.Visible = False
        pbCheese.Visible = False
        pbChicken.Visible = False
        pbhamandTurkey.Visible = True
    End Sub

    Private Sub chkTomato_CheckedChanged(sender As Object, e As EventArgs) Handles chkTomato.CheckedChanged
        pbTomato.Visible = True
    End Sub

    Private Sub chkLettuce_CheckedChanged(sender As Object, e As EventArgs) Handles chkLettuce.CheckedChanged
        pbLettuce.Visible = True
    End Sub

    Private Sub chkMayo_CheckedChanged(sender As Object, e As EventArgs) Handles chkMayo.CheckedChanged
        pbMayo.Visible = True
    End Sub

    Private Sub chkPickles_CheckedChanged(sender As Object, e As EventArgs) Handles chkPickles.CheckedChanged
        pbPickles.Visible = True
    End Sub
End Class
