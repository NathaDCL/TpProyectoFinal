Public Class SeccionVentas
    Private Sub btnVAltas_Click(sender As Object, e As EventArgs) Handles btnVAlta.Click
        Me.Hide()
        AltaVentas.Show()
    End Sub

    Private Sub btnVLobby_Click(sender As Object, e As EventArgs) Handles btnVLobby.Click
        Me.Hide()
        Lobby.Show()
    End Sub

    Private Sub btnVHistorial_Click(sender As Object, e As EventArgs) Handles btnVHistorial.Click
        Me.Hide()
        HistorialVentas.Show()
    End Sub
End Class