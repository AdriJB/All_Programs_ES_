Public Class FrmCNT
    Private Sub CmdDespliegue_Click(sender As Object, e As EventArgs) Handles CmdDespliegue.Click
        Dim i, cuadrado As Integer
        For i = 1 To 10
            cuadrado = i * i
            IblDespliegue.Text = IblDespliegue.Text & i & "-" & cuadrado & vbCr
        Next i

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Realmente deseas salir de la aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            End
        End If
    End Sub
End Class