Public Class FrmDATOS
    Private Sub LinkGit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkGit.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/AdriJB")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.facebook.com/ElPolloBrice/")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://t.me/ElPolloBrice")
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        If MessageBox.Show("¿Realmente deseas salir de la aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            End
        End If
    End Sub
End Class