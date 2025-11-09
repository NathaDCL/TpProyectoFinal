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
        rbCAsc.Checked = False
        rbCDsc.Checked = False
    End Sub

    Private Sub btnCLobby_Click(sender As Object, e As EventArgs) Handles btnCLobby.Click
        Me.Hide()
        Lobby.Show()
    End Sub

    Private Sub rbCAsc_CheckedChanged(sender As Object, e As EventArgs) Handles rbCAsc.CheckedChanged
        cliente.Carga(dgvMClientes)
    End Sub

    Private Sub rbCDsc_CheckedChanged(sender As Object, e As EventArgs) Handles rbCDsc.CheckedChanged
        cliente.Descender(dgvMClientes)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCTotal.Click
        cliente.BusquedaTotal(dgvMClientes)
    End Sub
End Class