Public Class SeccionClientes
    Dim cliente As New Clientes()
    Private Sub btnCAlta_Click(sender As Object, e As EventArgs) Handles btnCAlta.Click
        Me.Hide()
        AltaClientes.Show()
    End Sub

    Private Sub btnCBaja_Click(sender As Object, e As EventArgs) Handles btnCBaja.Click
        cliente.Baja()

    End Sub

    Private Sub btnCModif_Click(sender As Object, e As EventArgs) Handles btnCModif.Click
        cliente.Modificacion(dgvMClientes)

    End Sub

    Private Sub SeccionClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cliente.Carga(dgvMClientes)
    End Sub

    Private Sub btnCRefrescar_Click(sender As Object, e As EventArgs) Handles btnCRefrescar.Click
        cliente.Carga(dgvMClientes)
    End Sub

    Private Sub btnCLobby_Click(sender As Object, e As EventArgs) Handles btnCLobby.Click
        Me.Hide()
        Lobby.Show()
    End Sub
End Class