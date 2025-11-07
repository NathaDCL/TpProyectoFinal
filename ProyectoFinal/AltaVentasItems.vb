Public Class AltaVentasItems
    Private Sub btnVIAlta_Click(sender As Object, e As EventArgs) Handles btnVIAlta.Click
        Dim ventasitems As New VentasItems(Val(txtVIIdproducto.Text), Val(txtVICantidad.Text))
        If txtVICantidad.Text = "" Or Val(txtVICantidad.Text) <= 0 Then

        Else

            ventasitems.Alta()
        End If

    End Sub

    Private Sub btnVICancelar_Click(sender As Object, e As EventArgs) Handles btnVICancelar.Click
        Me.Hide()
        SeccionVentas.Show()
    End Sub
End Class