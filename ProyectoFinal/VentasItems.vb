Imports MySql.Data.MySqlClient

Public Class VentasItems
    Inherits Clientes
    Private _Id As Integer
    Private _IdVenta As Integer
    Private _IdProducto As Integer
    Private _PrecioU As Double
    Private _Cantidad As Integer
    Private _PrecioT As Double
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            If value > 0 Then
                _Id = value
            Else
                MsgBox("Error con el id")
            End If
        End Set
    End Property
    Public Property IdVenta As Integer
        Get
            Return _IdVenta
        End Get
        Set(value As Integer)
            If value > 0 Then
                _IdVenta = value
            Else
                MsgBox("Error con el id venta")
            End If
        End Set
    End Property
    Public Property IdProducto As Integer
        Get
            Return _IdProducto
        End Get
        Set(value As Integer)
            If value > 0 Then
                _IdProducto = value
            Else
                MsgBox("Error con el id producto")
            End If
        End Set
    End Property
    Public Property PrecioU As Double
        Get
            Return _PrecioU
        End Get
        Set(value As Double)
            If value >= 0 Then
                _PrecioU = value
            Else
                MsgBox("Error con el precio unitario")
            End If
        End Set
    End Property
    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            If value > 0 Then
                _Cantidad = value
            Else
                MsgBox("Error con la cantidad")
            End If
        End Set
    End Property
    Public Property PrecioT As Double
        Get
            Return _PrecioT
        End Get
        Set(value As Double)
            If value >= 0 Then
                _PrecioT = value
            Else
                MsgBox("Error con el precio total")
            End If
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(Id As Integer, IdVenta As Integer, IdProducto As Integer, PrecioU As Double, Cantidad As Integer, PrecioT As Double)
        Me.Id = Id
        Me.IdVenta = IdVenta
        Me.IdProducto = IdProducto
        Me.PrecioU = PrecioU
        Me.Cantidad = Cantidad
        Me.PrecioT = PrecioU * Cantidad

    End Sub
    Public Sub New(IdProducto As Integer, Cantidad As Integer)

        Me.IdProducto = IdProducto
        Me.Cantidad = Cantidad


    End Sub
    Public Function Verificacion(IdProducto As Integer) As Boolean
        Dim con As New Conexion
        Dim resultado As Boolean
        Try
            con.Encendido()

            Dim consulta As String = "SELECT COUNT(*) FROM productos WHERE ID = @IDProducto AND Activo='si'"
            Dim comando As New MySqlCommand(consulta, con.ObtenerConexion())
            comando.Parameters.AddWithValue("@IDProducto", IdProducto)

            Dim ResultadoConsulta As Integer = Val(comando.ExecuteScalar())
            If ResultadoConsulta > 0 Then
                resultado = True
            Else
                MsgBox("Producto inexistente")
                Return False
            End If


        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False

        Finally
            con.Apagado()
        End Try
        Return resultado
    End Function
    Public Overrides Function Alta() As Boolean
        Dim resultado As Boolean
        Dim con As New Conexion
        Try
            If (Verificacion(Me.IdProducto) = False) Then
                resultado = False

            Else
                con.Encendido()


                Dim Consulta As String = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"
                Dim Comando As New MySqlCommand(Consulta, con.ObtenerConexion())
                Dim ConsultaIDventas As String = "SELECT MAX(ID) FROM ventas"
                Dim ComandoIDventas As New MySqlCommand(ConsultaIDventas, con.ObtenerConexion())
                Dim ResultadoIDventas As Integer = Val(ComandoIDventas.ExecuteScalar())
                Dim ConsultaPrecio As String = "SELECT Precio FROM productos WHERE ID = @IDProducto"
                Dim ComandoPrecio As New MySqlCommand(ConsultaPrecio, con.ObtenerConexion())
                ComandoPrecio.Parameters.AddWithValue("@IDProducto", Me.IdProducto)
                Dim PrecioProducto As Double = Val(ComandoPrecio.ExecuteScalar())

                Comando.Parameters.AddWithValue("@IDVenta", ResultadoIDventas)
                Comando.Parameters.AddWithValue("@IDProducto", Me.IdProducto)
                Comando.Parameters.AddWithValue("@PrecioUnitario", PrecioProducto)
                Comando.Parameters.AddWithValue("@Cantidad", Me.Cantidad)
                Comando.Parameters.AddWithValue("@PrecioTotal", Me.Cantidad * PrecioProducto)
                Comando.ExecuteNonQuery()

                Dim ConsultaTotal As String = "SELECT SUM(PrecioTotal) FROM ventasitems WHERE IDVenta = @IDVenta"
                Dim ComandoTotal As New MySqlCommand(ConsultaTotal, con.ObtenerConexion())
                ComandoTotal.Parameters.AddWithValue("@IDVenta", ResultadoIDventas)
                Dim Total As Double = Val(ComandoTotal.ExecuteScalar())


                Dim ConsultaSubirTotal As String = "UPDATE ventas SET Total = @Total, Activo = 'si' WHERE ID = @IDVenta"
                Dim ComandoSubirTotal As New MySqlCommand(ConsultaSubirTotal, con.ObtenerConexion())
                ComandoSubirTotal.Parameters.AddWithValue("@Total", Total)
                ComandoSubirTotal.Parameters.AddWithValue("@IDVenta", ResultadoIDventas)
                ComandoSubirTotal.ExecuteNonQuery()

                MsgBox("Ventas items registrado")
                resultado = True
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            resultado = False
        Finally
            con.Apagado()
        End Try
        Return resultado
    End Function
End Class
