Public Class FrmSectCase
    Private Sub Cmdmensaje_Click(sender As Object, e As EventArgs) Handles Cmdmensaje.Click
        Dim opcion As Integer
        opcion = Val(Txtopcion.Text)

        Select Case opcion
            Case 1
                Iblmensaje.Text = "Se seleccionó el número 1"
            Case 2
                Iblmensaje.Text = "Se seleccionó el número 2"
            Case 3
                Iblmensaje.Text = "Se seleccionó el número 3"
            Case 4
                Iblmensaje.Text = "Se seleccionó el número 4"
            Case 5
                Iblmensaje.Text = "Se seleccionó el número 5"
            Case 6
                Iblmensaje.Text = "Se seleccionó el número 6"
            Case 7
                Iblmensaje.Text = "Se seleccionó el número 7"
            Case 8
                Iblmensaje.Text = "Se seleccionó el número 8"
            Case 9
                Iblmensaje.Text = "Se seleccionó el número 9"
            Case 10
                Iblmensaje.Text = "Se seleccionó el número 10"
            Case 11
                Iblmensaje.Text = "Se seleccionó el número 11"
            Case 11
                Iblmensaje.Text = "Se seleccionó el número 11"
            Case 12
                Iblmensaje.Text = "Se seleccionó el número 12"
            Case 13
                Iblmensaje.Text = "Se seleccionó el número 13"
            Case 14
                Iblmensaje.Text = "Se seleccionó el número 14"
            Case 15
                Iblmensaje.Text = "Se seleccionó el número 15"
            Case 16
                Iblmensaje.Text = "Se seleccionó el número 16"
            Case 17
                Iblmensaje.Text = "Se seleccionó el número 17"
            Case 18
                Iblmensaje.Text = "Se seleccionó el número 18"
            Case 19
                Iblmensaje.Text = "Se seleccionó el número 19"
            Case 20
                Iblmensaje.Text = "Se seleccionó el número 20"


        End Select
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
        If MessageBox.Show("¿Realmente deseas salir de la aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            End
        End If
    End Sub
End Class