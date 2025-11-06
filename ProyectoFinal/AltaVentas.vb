Public Class AltaVentas

    Private Sub btnAVCancelar_Click(sender As Object, e As EventArgs) Handles btnAVCancelar.Click
        Me.Hide()
        SeccionVentas.Show()
    End Sub

    Private Sub btnAVAlta_Click(sender As Object, e As EventArgs) Handles btnAVCrear.Click
        Dim ventas As New Ventas(Val(txtVIdCliente.Text), Date.Parse(txtVFecha.Text))
        ventas.Alta()
        Me.Hide()
        AltaVentasItems.Show()

    End Sub
End Class