Public Class Frmmenu
    Private Sub SumaDe2NúmerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaDe2NúmerosToolStripMenuItem.Click
        Dim SumaNum As New FrmSuma2Numeros
        SumaNum.MdiParent = Me
        SumaNum.Show()
    End Sub

    Private Sub CalculoDeEdadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculoDeEdadToolStripMenuItem.Click
        Dim CalcEdad As New Frmedad
        CalcEdad.MdiParent = Me
        CalcEdad.Show()
    End Sub

    Private Sub SelectCaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCaseToolStripMenuItem.Click
        Dim SecCas As New FrmSectCase
        SecCas.MdiParent = Me
        SecCas.Show()
    End Sub

    Private Sub CicloDoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CicloDoToolStripMenuItem.Click
        Dim CNT As New FrmCNT
        CNT.MdiParent = Me
        CNT.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim DAT As New FrmDATOS
        DAT.MdiParent = Me
        DAT.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("¿Realmente deseas salir de la aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            End
        End If
    End Sub

    Private Sub CerrarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicaciónToolStripMenuItem.Click
        If MessageBox.Show("¿Realmente deseas salir de la aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            End
        End If
    End Sub
End Class
