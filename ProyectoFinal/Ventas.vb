Imports MySql.Data.MySqlClient

Public Class Ventas
    Inherits Clientes
    Private _Id As Integer
    Private _IdCliente As Integer
    Private _Fecha As Date
    Private _Total As Double
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
    Public Property IdCliente As Integer
        Get
            Return _IdCliente
        End Get
        Set(value As Integer)
            If value > 0 Then
                _IdCliente = value
            Else
                MsgBox("Error con el id cliente")
            End If
        End Set
    End Property
    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            If value <= Date.Today Then
                _Fecha = value
            Else
                MsgBox("Error con la fecha")
            End If

        End Set
    End Property
    Public Property Total As Double
        Get
            Return _Total
        End Get
        Set(value As Double)
            If value >= 0 Then
                _Total = value
            Else
                MsgBox("Error con el total")
            End If
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(IdCliente As Integer, Fecha As Date)

        Me.IdCliente = IdCliente
        Me.Fecha = Fecha


    End Sub
    Public Sub New(Id As Integer, IdCliente As Integer, Fecha As Date, Total As Double)
        Me.Id = Id
        Me.IdCliente = IdCliente
        Me.Fecha = Fecha
        Me.Total = Total

    End Sub
    Public Function Verificacion(Id As Integer) As Boolean
        Dim con As New Conexion
        Dim resultado As Boolean
        Try
            con.Encendido()

            Dim consulta As String = "SELECT COUNT(*) FROM clientes WHERE ID = @ID"
            Dim comando As New MySqlCommand(consulta, con.ObtenerConexion())
            comando.Parameters.AddWithValue("@ID", Id)

            Dim ResultadoConsulta As Integer = Val(comando.ExecuteScalar())
            If ResultadoConsulta > 0 Then
                resultado = True
            Else
                resultado = False
            End If
            Return resultado

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False

        Finally
            con.Apagado()
        End Try
    End Function
    Public Function Alta() As Integer

        Dim con As New Conexion
        Try
            If (Verificacion(Me.IdCliente) = False) Then

                MsgBox("Cliente inexistente")
                Return -1
            Else
                con.Encendido()
                Dim Consulta As String = "INSERT INTO ventas (IDCliente, Fecha) VALUES (@IDCliente, @Fecha)"
                Dim Comando As New MySqlCommand(Consulta, con.ObtenerConexion())

                Comando.Parameters.AddWithValue("@IDCliente", Me.IdCliente)
                Comando.Parameters.AddWithValue("@Fecha", Me.Fecha)

                Comando.ExecuteNonQuery()
                MsgBox("Venta creada")
                Dim ConsultaIDventas As String = "SELECT LAST_INSERT_ID()"
                Dim ComandoIDventas As New MySqlCommand(ConsultaIDventas, con.ObtenerConexion())
                Dim ResultadoIDventas As Integer = Val(ComandoIDventas.ExecuteScalar())

                ModuloVentas.IdVentaGenerado = ResultadoIDventas

            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return -1
        Finally
            con.Apagado()
        End Try
        Return 0
    End Function

End Class
