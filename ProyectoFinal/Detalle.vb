Public Class Detalle
    Dim ventaitems As New VentasItems()
    Private Sub btnDCancelar_Click(sender As Object, e As EventArgs) Handles btnDCancelar.Click
        Me.Close()
        HistorialVentas.Show()
    End Sub

    Private Sub Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ventaitems.Carga(dgvMDetalle)
    End Sub
End Class