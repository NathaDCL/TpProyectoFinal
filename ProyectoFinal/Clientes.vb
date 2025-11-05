Imports MySql.Data.MySqlClient

Public Class Clientes
    Inherits Usuario
    Private _Id As Integer
    Private _Cliente As String
    Private _Tel As Integer
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
    Public Property Tel As Integer
        Get
            Return _Tel
        End Get
        Set(value As Integer)
            If value > 0 Or value = Not Nothing Then
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
    Public Overrides Function Alta() As Boolean
        Dim resultado As Boolean
        Dim con As New Conexion
        Try
            con.Encendido()
            Dim Consulta As String = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)"
            Dim Comando As New MySqlCommand(Consulta, con.ObtenerConexion())
            Comando.Parameters.AddWithValue("@Cliente", Me.Cliente)
            Comando.Parameters.AddWithValue("@Telefono", Me.Tel)
            Comando.Parameters.AddWithValue("@Correo", Me.Correo)
            Comando.ExecuteNonQuery()
            MsgBox("Cliente registrado")
            resultado = True


        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            resultado = False
        Finally
            con.Apagado()
        End Try
        Return resultado
    End Function

End Class
