Public Class Form1

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNum2.TextChanged

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim num1, num2, soma As Single
        num1 = tbNum1.Text
        num2 = tbNum2.Text
        soma = num1 + num2
        lblResultados.Text = soma


    End Sub
End Class
