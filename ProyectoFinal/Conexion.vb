Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Public Class Conexion
    Dim _cadena As New MySqlConnection("server=localhost;userid=root;password=;database=bddtpfinal;port=3000")

    Public Property cadena As MySqlConnection
        Get
            Return _cadena
        End Get
        Set(value As MySqlConnection)

        End Set
    End Property
    Public Sub Encendido()
        Try
            cadena.Open()
        Catch ex As MySqlException
            MsgBox("Error al conectar con la base de datos: " & ex.Message)
        End Try
    End Sub
    Public Sub Apagado()
        Try
            cadena.Close()
        Catch ex As MySqlException
            MsgBox("Error al desconectar la base de datos: " & ex.Message)
        Finally
            cadena.Close()
        End Try
    End Sub
    Public Function ObtenerConexion() As MySqlConnection
        Return cadena
    End Function
End Class
