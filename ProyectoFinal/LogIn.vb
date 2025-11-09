Public Class LogIn
    Private Sub btnLLogin_Click(sender As Object, e As EventArgs) Handles btnLLogin.Click
        Dim usuario As New Usuario(txtLUsuario.Text, txtLContra.Text)
        If (usuario.Loguear() = True) Then
            Me.Hide()
            Lobby.Show()
            txtLUsuario.Text = ""
            txtLContra.Text = ""
        End If
    End Sub

    Private Sub btnLRegistro_Click(sender As Object, e As EventArgs) Handles btnLRegistro.Click
        Me.Hide()
        RegistroUsuario.Show()
        txtLUsuario.Text = ""
        txtLContra.Text = ""
    End Sub
End Class