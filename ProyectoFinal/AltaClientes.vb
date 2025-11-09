Public Class AltaClientes
    Private Sub btnCAltaClientes_Click(sender As Object, e As EventArgs) Handles btnCAltaClientes.Click
        Dim cliente As New Clientes(txtCCliente.Text, Val(txtCTel.Text), txtCCorreo.Text)
        If (cliente.Alta()) = True Then
            Me.Hide()
            SeccionClientes.Show()
            txtCCliente.Text = ""
            txtCTel.Text = ""
            txtCCorreo.Text = ""
        End If
    End Sub

    Private Sub btnCCancelarClientes_Click(sender As Object, e As EventArgs) Handles btnCCancelarClientes.Click
        Me.Hide()
        SeccionClientes.Show()
        txtCCliente.Text = ""
        txtCTel.Text = ""
        txtCCorreo.Text = ""
    End Sub
End Class