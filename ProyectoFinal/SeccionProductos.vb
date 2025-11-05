Public Class SeccionProductos
    Dim producto As New Productos()
    Private Sub btnPAlta_Click(sender As Object, e As EventArgs) Handles btnPAlta.Click
        Me.Hide()
        AltaProductos.Show()
    End Sub

    Private Sub btnPBaja_Click(sender As Object, e As EventArgs) Handles btnPBaja.Click
        producto.Baja()
    End Sub

    Private Sub btnPModif_Click(sender As Object, e As EventArgs) Handles btnPModif.Click
        producto.Modificacion(dgvMProductos)
    End Sub

    Private Sub btnPRefrescar_Click(sender As Object, e As EventArgs) Handles btnPRefrescar.Click
        producto.Carga(dgvMProductos)
    End Sub

    Private Sub btnPLobby_Click(sender As Object, e As EventArgs) Handles btnPLobby.Click
        Me.Hide()
        Lobby.Show()
    End Sub

    Private Sub SeccionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        producto.Carga(dgvMProductos)
    End Sub
End Class