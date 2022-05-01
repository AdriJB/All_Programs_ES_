Public Class FrmSuma2Numeros
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim num1, num2, suma As Integer

        num1 = TxtNum1.Text
        num2 = TxtNum2.Text
        suma = num1 + num2
        TxtSuma.Text = suma
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNum1.Text = ""
        TxtNum2.Text = ""
        TxtSuma.Text = ""
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("¿Realmente deseas salir de la aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            End
        End If
    End Sub
End Class