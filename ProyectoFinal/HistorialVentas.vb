Public Class HistorialVentas
    Dim venta As New Ventas()
    Private Sub btnVFechas_Click(sender As Object, e As EventArgs) Handles btnVFechas.Click
        Dim Fechauno As Date
        Dim Fechados As Date
        If Date.TryParse(txtHVFechauno.Text, Fechauno) Then
            If Date.TryParse(txtHVFechados.Text, Fechados) Then


                venta.BusquedaFechas(Fechauno, Fechados, dgvMVentas)
                txtHVFechauno.Text = ""
                txtHVFechados.Text = ""
            Else
                MsgBox("Error con fecha/s")
            End If


        Else
            MsgBox("Error con fecha/s")
        End If
    End Sub

    Private Sub HistorialVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        venta.Carga(dgvMVentas)
    End Sub

    Private Sub btnHVCancelar_Click(sender As Object, e As EventArgs) Handles btnHVCancelar.Click
        Me.Hide()
        SeccionVentas.Show()
        txtHVFechauno.Text = ""
        txtHVFechados.Text = ""
    End Sub

    Private Sub btnVRefrescar_Click(sender As Object, e As EventArgs) Handles btnVRefrescar.Click
        venta.Carga(dgvMVentas)
        txtHVFechauno.Text = ""
        txtHVFechados.Text = ""
    End Sub
End Class