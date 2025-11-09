Imports MySql.Data.MySqlClient

Public Class Clientes
    Inherits Usuario
    Private _Id As Integer
    Private _Cliente As String
    Private _Tel As String
    Private _Correo As String
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
    Public Property Cliente As String
        Get
            Return _Cliente
        End Get
        Set(value As String)
            Dim Longi As Integer
            Dim aux As Integer

            Longi = Len(value)
            For i = 0 To Longi - 1
                If IsNumeric(value(i)) Then
                    aux = aux + 1
                End If
            Next i
            If aux >= 1 Or value = "" Then
                MsgBox("Error con el cliente")
            Else
                _Cliente = value
            End If
        End Set
    End Property
    Public Property Tel As String
        Get
            Return _Tel
        End Get
        Set(value As String)
            If Val(value) > 0 Or value = Not Nothing Then
                _Tel = value
            Else
                MsgBox("Error con el telefono")
            End If
        End Set
    End Property
    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            Dim Longi As Integer
            Dim aux As Integer

            Longi = Len(value)
            For i = 0 To Longi - 1
                If (value(i)) = "@" Then
                    aux = aux + 1
                End If
            Next i
            If aux > 1 Or aux = 0 Or value = "" Then
                MsgBox("Error con el correo")
            Else
                _Correo = value
            End If
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(Cliente As String, Tel As Integer, Correo As String)

        Me.Cliente = Cliente
        Me.Tel = Tel
        Me.Correo = Correo

    End Sub
    Public Sub Descender(dgv As DataGridView)
        Dim con As New Conexion
        Try

            con.Encendido()
            Dim consulta As String = "SELECT * FROM clientes WHERE Activo = 'si' ORDER BY ID DESC"
            Dim adaptador As New MySqlDataAdapter(consulta, con.ObtenerConexion())
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            dgv.DataSource = tabla
            dgv.Columns("ID").ReadOnly = True
            dgv.Columns("Activo").ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
        Finally
            con.Apagado()
        End Try
    End Sub
    Public Sub BusquedaTotal(dgv As DataGridView)
        Dim con As New Conexion
        Try
            con.Encendido()
            Dim TotalString As String = InputBox("Ingrese total")
            If (TotalString = "" Or Not IsNumeric(TotalString)) Then
                MsgBox("Ingrese valores validos")
            Else
                Dim Total As Double = Val(TotalString)

                Dim consulta As String = "SELECT DISTINCT c.* FROM clientes c INNER JOIN ventas v ON c.ID = v.IDCliente WHERE v.Total > @Total AND c.Activo = 'si'"
                Dim comando As New MySqlCommand(consulta, con.ObtenerConexion())
                comando.Parameters.AddWithValue("@Total", Total)
                Dim adaptador As New MySqlDataAdapter(comando)

                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                dgv.DataSource = tabla

            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)

        Finally
            con.Apagado()
        End Try

    End Sub
    Public Overridable Sub Carga(dgv As DataGridView)
        Dim con As New Conexion
        Try

            con.Encendido()
            Dim consulta As String = "SELECT * FROM clientes WHERE Activo = 'si'"
            Dim adaptador As New MySqlDataAdapter(consulta, con.ObtenerConexion())
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            dgv.DataSource = tabla
            dgv.Columns("ID").ReadOnly = True
            dgv.Columns("Activo").ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
        Finally
            con.Apagado()
        End Try
    End Sub

    Public Overrides Function Alta() As Boolean
        Dim resultado As Boolean
        Dim con As New Conexion
        Try
            con.Encendido()
            Dim Consulta As String = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)"
            Dim Comando As New MySqlCommand(Consulta, con.ObtenerConexion())
            If (Tel = "") Then
                resultado = False
            Else
                Comando.Parameters.AddWithValue("@Cliente", Me.Cliente)
                Comando.Parameters.AddWithValue("@Telefono", Me.Tel)
                Comando.Parameters.AddWithValue("@Correo", Me.Correo)
                Comando.ExecuteNonQuery()
                MsgBox("Cliente registrado")
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
    Public Overridable Function Baja() As Boolean
        Dim resultado As Boolean
        Dim con As New Conexion
        Try
            con.Encendido()
            Dim Consulta As String = "UPDATE clientes SET Activo = CASE WHEN Activo = 'si' THEN 'no' ELSE 'si' END WHERE ID = @ID"

            Dim Comando As New MySqlCommand(Consulta, con.ObtenerConexion())
            Comando.Parameters.AddWithValue("@ID", InputBox("Ingrese el id cliente que desea desactivar o activar"))

            If (Comando.ExecuteNonQuery() > 0) Then
                MsgBox("Cliente actualizado")
                resultado = True
            Else
                MsgBox("Cliente inexistente o sin cambios")
                resultado = False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            resultado = False
        Finally
            con.Apagado()
        End Try
        Return resultado
    End Function
    Public Overridable Function Modificacion(dgv As DataGridView) As Boolean
        Dim resultado As Boolean
        Dim con As New Conexion

        Try
            con.Encendido()

            Dim Consulta As String = "UPDATE clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @ID AND (Cliente <> @Cliente OR Telefono <> @Telefono OR Correo <> @Correo)"
            Dim Comando As New MySqlCommand(Consulta, con.ObtenerConexion())

            Comando.Parameters.AddWithValue("@Cliente", dgv.CurrentRow.Cells("Cliente").Value)
            Comando.Parameters.AddWithValue("@Telefono", dgv.CurrentRow.Cells("Telefono").Value)
            Comando.Parameters.AddWithValue("@Correo", dgv.CurrentRow.Cells("Correo").Value)
            Comando.Parameters.AddWithValue("@ID", dgv.CurrentRow.Cells("ID").Value)

            If (Comando.ExecuteNonQuery() > 0) Then
                MsgBox("Cliente modificado")
                resultado = True
            Else
                MsgBox("Cliente inexistente o sin cambios")
                resultado = False
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
