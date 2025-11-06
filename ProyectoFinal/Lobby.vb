Public Class Lobby
    Private Sub btnLClientes_Click(sender As Object, e As EventArgs) Handles btnLClientes.Click
        Me.Hide()
        SeccionClientes.Show()
    End Sub

    Private Sub btnLProductos_Click(sender As Object, e As EventArgs) Handles btnLProductos.Click
        Me.Hide()
        SeccionProductos.Show()
    End Sub

    Private Sub btnLVentas_Click(sender As Object, e As EventArgs) Handles btnLVentas.Click
        Me.Hide()
        SeccionVentas.Show()
    End Sub
End Class