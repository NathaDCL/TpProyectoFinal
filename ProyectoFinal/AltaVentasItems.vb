Public Class AltaVentasItems
    Private Sub btnVIAlta_Click(sender As Object, e As EventArgs) Handles btnVIAlta.Click
        Dim ventasitems As New VentasItems(Val(txtVIIdproducto.Text), Val(txtVIPrecioU.Text), Val(txtVICantidad.Text))
        ventasitems.Alta()
    End Sub

    Private Sub btnVICancelar_Click(sender As Object, e As EventArgs) Handles btnVICancelar.Click
        Me.Hide()
        SeccionVentas.Show()
    End Sub
End Class