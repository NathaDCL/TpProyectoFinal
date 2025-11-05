Imports MySql.Data.MySqlClient

Public Class Productos
    Inherits Clientes
    Private _Id As Integer
    Private _Nombre As String
    Private _Precio As Double
    Private _Categoria As String
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
    Public Property Nombre As String
        Get
            Return _Nombre
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
                MsgBox("Error con el nombre")
            Else
                _Nombre = value
            End If
        End Set
    End Property
    Public Property Precio As Double
        Get
            Return _Precio
        End Get
        Set(value As Double)

            If value >= 0 Then
                _Precio = value
            Else
                MsgBox("Error con el precio")
            End If
        End Set
    End Property
    Public Property Categoria As String
        Get
            Return _Categoria
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
                MsgBox("Error con la categoria")
            Else
                _Categoria = value
            End If
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(Nombre As String, Precio As Double, Categoria As String)
        Me.Nombre = Nombre
        Me.Precio = Precio
        Me.Categoria = Categoria

    End Sub
    Public Sub New(Id As Integer, Nombre As String, Precio As Double, Categoria As String)
        Me.Id = Id
        Me.Nombre = Nombre
        Me.Precio = Precio
        Me.Categoria = Categoria

    End Sub
    Public Overrides Sub Carga(dgv As DataGridView)
        Dim con As New Conexion
        Try

            con.Encendido()
            Dim consulta As String = "SELECT * FROM productos"
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
            Dim Consulta As String = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"
            Dim Comando As New MySqlCommand(Consulta, con.ObtenerConexion())
            If Precio = Nothing Then
                resultado = False
            End If
            Comando.Parameters.AddWithValue("@Nombre", Me.Nombre)
            Comando.Parameters.AddWithValue("@Precio", Me.Precio)
            Comando.Parameters.AddWithValue("@Categoria", Me.Categoria)
            Comando.ExecuteNonQuery()
            MsgBox("Producto registrado")
            resultado = True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            resultado = False
        Finally
            con.Apagado()
        End Try
        Return resultado
    End Function
    Public Overrides Function Baja() As Boolean
        Dim resultado As Boolean
        Dim con As New Conexion
        Try
            con.Encendido()
            Dim Consulta As String = "UPDATE productos SET Activo = CASE WHEN Activo = 'si' THEN 'no' ELSE 'si' END WHERE ID = @ID"

            Dim Comando As New MySqlCommand(Consulta, con.ObtenerConexion())
            Comando.Parameters.AddWithValue("@ID", InputBox("Ingrese el id producto que desea desactivar o activar"))

            If (Comando.ExecuteNonQuery() > 0) Then
                MsgBox("Producto actualizado")
                resultado = True
            Else
                MsgBox("Producto inexistente o sin cambios")
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
    Public Overrides Function Modificacion(dgv As DataGridView) As Boolean
        Dim resultado As Boolean
        Dim con As New Conexion

        Try
            con.Encendido()

            Dim Consulta As String = "UPDATE productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE ID = @ID AND (Nombre <> @Nombre OR Precio <> @Precio OR Categoria <> @Categoria)"
            Dim Comando As New MySqlCommand(Consulta, con.ObtenerConexion())

            Comando.Parameters.AddWithValue("@Nombre", dgv.CurrentRow.Cells("Nombre").Value)
            Comando.Parameters.AddWithValue("@Precio", dgv.CurrentRow.Cells("Precio").Value)
            Comando.Parameters.AddWithValue("@Categoria", dgv.CurrentRow.Cells("Categoria").Value)
            Comando.Parameters.AddWithValue("@ID", dgv.CurrentRow.Cells("ID").Value)

            If (Comando.ExecuteNonQuery() > 0) Then
                MsgBox("Producto modificado")
                resultado = True
            Else
                MsgBox("Producto inexistente o sin cambios")
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
