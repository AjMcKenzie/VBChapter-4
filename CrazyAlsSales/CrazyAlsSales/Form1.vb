Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decSalesAmount, decAdvacePayAmount As Decimal
        Dim decCommissionRate, decCommissionAmount, decNetPay As Decimal

        Try
            decSalesAmount = CDec(txtSalesForMonth.Text)
            decAdvacePayAmount = CDec(txtAdvancePay.Text)

            Select Case decSalesAmount
                Case Is < 10000
                    decCommissionRate = 0.5D

                Case 10000 To 14999
                    decCommissionRate = 0.1D
                Case 15000 To 17999
                    decCommissionRate = 0.12D
                Case 18000 To 21999
                    decCommissionRate = 0.14D
                Case Is >= 22000
                    decCommissionRate = 0.15D
            End Select
            decCommissionAmount = decSalesAmount * decCommissionRate
            decNetPay = decCommissionAmount - decAdvacePayAmount

            lblCommisionRate.Text = decCommissionRate.ToString("P")
            lblCommission.Text = decCommissionAmount.ToString("c")
            lblNetPay.Text = decNetPay.ToString("c")

        Catch
            lblMessage.Text = "Please enter numeric values."
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblCommisionRate.Text = String.Empty
        lblCommission.Text = String.Empty
        lblNetPay.Text = String.Empty
        lblMessage.Text = String.Empty
        txtAdvancePay.Clear()
        txtSalesForMonth.Clear()
        txtSalesForMonth.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
