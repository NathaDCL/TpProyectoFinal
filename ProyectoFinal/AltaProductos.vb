Public Class AltaProductos
    Private Sub AltaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPCancelarProductos_Click(sender As Object, e As EventArgs) Handles btnPCancelarProductos.Click
        Me.Hide()
        SeccionProductos.Show()
        txtPNombre.Text = ""
        txtPPrecio.Text = ""
        txtPCategoria.Text = ""
    End Sub

    Private Sub btnPAltaProductos_Click(sender As Object, e As EventArgs) Handles btnPAltaProductos.Click
        Dim producto As New Productos(txtPNombre.Text, Val(txtPPrecio.Text), txtPCategoria.Text)
        Dim PrecioIngresado As Double

        If Double.TryParse(txtPPrecio.Text, PrecioIngresado) Then
            producto.Precio = PrecioIngresado
            If (producto.Alta()) = True Then
                Me.Hide()
                SeccionProductos.Show()
                txtPNombre.Text = ""
                txtPPrecio.Text = ""
                txtPCategoria.Text = ""
            End If
        Else
            MsgBox("Error con el precio")
        End If



    End Sub
End Class