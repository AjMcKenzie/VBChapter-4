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

        Catch

        End Try

    End Sub
End Class
