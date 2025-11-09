Public Class AltaVentas

    Private Sub btnAVCancelar_Click(sender As Object, e As EventArgs) Handles btnAVCancelar.Click
        Me.Hide()
        SeccionVentas.Show()
        txtVIdCliente.Text = ""
        txtVFecha.Text = ""
    End Sub

    Private Sub btnAVAlta_Click(sender As Object, e As EventArgs) Handles btnAVCrear.Click
        Dim Fecha As Date
        If Date.TryParse(txtVFecha.Text, Fecha) Then
            If Fecha <= Date.Today() = True Then
                Dim ventas As New Ventas(Val(txtVIdCliente.Text), Fecha)
                If ventas.Alta() = True Then
                    Me.Hide()
                    AltaVentasItems.Show()
                    txtVIdCliente.Text = ""
                    txtVFecha.Text = ""
                End If
            Else
                MsgBox("Error con la fecha")
            End If

        Else
            MsgBox("Error con la fecha")
        End If
    End Sub
End Class