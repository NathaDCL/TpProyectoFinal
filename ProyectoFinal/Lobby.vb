Public Class Lobby
    Private Sub btnLClientes_Click(sender As Object, e As EventArgs) Handles btnLClientes.Click
        Me.Hide()
        SeccionClientes.Show()
    End Sub

    Private Sub btnLProductos_Click(sender As Object, e As EventArgs) Handles btnLProductos.Click
        Me.Hide()
        SeccionProductos.Show()
    End Sub
End Class