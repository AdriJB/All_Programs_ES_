Public Class Frmedad
    Private Sub CmdVerificar_Click(sender As Object, e As EventArgs) Handles CmdVerificar.Click
        Dim edad As Integer
        edad = 2022 - Val(Txtanionac.Text)
        If edad >= 18 Then
            Iblmensaje.Text = "MAYOR DE EDAD"
        Else
            Iblmensaje.Text = "MENOR DE EDAD"
        End If
        IblRespuesta.Text = edad
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("¿Realmente deseas salir de la aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            End
        End If
    End Sub
End Class