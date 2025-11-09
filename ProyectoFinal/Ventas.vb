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
    Public Sub BusquedaFechas(Fecha1 As Date, Fecha2 As Date, dgv As DataGridView)
        Dim con As New Conexion
        Try
            con.Encendido()

            Dim consulta As String = "SELECT ID, IDCliente, Fecha, Total FROM ventas WHERE (Fecha BETWEEN @FechaInicio AND @FechaFin) AND Activo = 'si'"

            Dim adaptador As New MySqlDataAdapter(consulta, con.ObtenerConexion())
            adaptador.SelectCommand.Parameters.AddWithValue("@FechaInicio", Fecha1)
            adaptador.SelectCommand.Parameters.AddWithValue("@FechaFin", Fecha2)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            dgv.DataSource = tabla
            dgv.Columns("ID").ReadOnly = True
            dgv.Columns("IDCliente").ReadOnly = True
            dgv.Columns("Fecha").ReadOnly = True
            dgv.Columns("Total").ReadOnly = True

        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
        Finally
            con.Apagado()
        End Try
    End Sub
    Public Overrides Sub Carga(dgv As DataGridView)
        Dim con As New Conexion
        Try

            con.Encendido()
            Dim consulta As String = "SELECT ID, IDCliente, Fecha, Total FROM ventas WHERE Activo = 'si'"
            Dim adaptador As New MySqlDataAdapter(consulta, con.ObtenerConexion())
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            dgv.DataSource = tabla
            dgv.Columns("ID").ReadOnly = True
            dgv.Columns("IDCliente").ReadOnly = True
            dgv.Columns("Fecha").ReadOnly = True
            dgv.Columns("Total").ReadOnly = True

        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
        Finally
            con.Apagado()
        End Try
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

    Public Overrides Function Alta() As Boolean
        Dim resultado As Boolean
        Dim con As New Conexion

        Try
            If (Verificacion(Me.IdCliente) = False) Then
                MsgBox("Cliente inexistente")
                resultado = False
            Else
                con.Encendido()
                Dim Consulta As String = "INSERT INTO ventas (IDCliente, Fecha) VALUES (@IDCliente, @Fecha)"
                Dim Comando As New MySqlCommand(Consulta, con.ObtenerConexion())

                Comando.Parameters.AddWithValue("@IDCliente", Me.IdCliente)
                Comando.Parameters.AddWithValue("@Fecha", Me.Fecha)

                Comando.ExecuteNonQuery()
                MsgBox("Venta creada")

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
