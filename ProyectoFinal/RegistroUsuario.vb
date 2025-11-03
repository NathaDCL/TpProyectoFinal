Public Class RegistroUsuario

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim usuario As New Usuario(txtRNom.Text, txtRAP.Text, txtRUsuario.Text, txtRContra.Text, txtRCContra.Text)
        If (usuario.Registrar()) = True Then
            Me.Hide()
            LogIn.Show()
        End If
    End Sub

    Private Sub btnRLogin_Click(sender As Object, e As EventArgs) Handles btnRLogin.Click
        Me.Hide()
        LogIn.Show()
    End Sub
End Class