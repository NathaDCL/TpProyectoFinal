Imports System.Runtime.Intrinsics.X86
Imports MySql.Data.MySqlClient

Public Class Usuario

    Private _Nombre As String
    Private _Apellido As String
    Private _Usuario As String
    Private _Contra As String
    Private _CContra As String

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
    Public Property Apellido As String
        Get
            Return _Apellido
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
                MsgBox("Error con el apellido")
            Else
                _Apellido = value
            End If
        End Set
    End Property
    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            If value = "" Then
                MsgBox("Error con el nombre de usuario")
            Else
                _Usuario = value
            End If
        End Set
    End Property
    Public Property Contra As String
        Get
            Return _Contra
        End Get
        Set(value As String)
            If value = "" Then
                MsgBox("Error con la contraseña")
            Else
                _Contra = value
            End If
        End Set
    End Property
    Public Property CContra As String
        Get
            Return _CContra
        End Get
        Set(value As String)
            If value <> Contra Then
                MsgBox("Contraseñas no coincidentes")

            Else
                _CContra = value
            End If
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(Nombre As String, Apellido As String, Usuario As String, Contra As String, CContra As String)
        Me.Nombre = Nombre
        Me.Apellido = Apellido
        Me.Usuario = Usuario
        Me.Contra = Contra
        Me.CContra = CContra
    End Sub

    Public Overridable Function Alta() As Boolean
        Dim resultado As Boolean
        Dim con As New Conexion
        Try
            con.Encendido()
            Dim Consulta As String = "INSERT INTO usuarios (Nombre, Apellido, NomUsuario, Contraseña) VALUES (@Nombre, @Apellido, @NomUsuario, @Contraseña)"
            Dim Comando As New MySqlCommand(Consulta, con.ObtenerConexion())
            If (CContra = "") Then
                resultado = False
            Else
                Comando.Parameters.AddWithValue("@Nombre", Me.Nombre)
                Comando.Parameters.AddWithValue("@Apellido", Me.Apellido)
                Comando.Parameters.AddWithValue("@NomUsuario", Me.Usuario)
                Comando.Parameters.AddWithValue("@Contraseña", Me.Contra)
                Comando.ExecuteNonQuery()
                MsgBox("Usuario registrado")
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
    Public Function Loguear() As Boolean
        Dim resultado As Boolean
        Dim con As New Conexion
        Try
            con.Encendido()
            Dim Consulta As String = "SELECT Contraseña from usuarios where NomUsuario=@NomUsuario"
            Dim comando As New MySqlCommand(Consulta, con.ObtenerConexion())
            comando.Parameters.AddWithValue("@NomUsuario", Me.Usuario)
            Dim ResultadoConsulta As Object = comando.ExecuteScalar()
            If ResultadoConsulta Is Nothing Then
                MsgBox("Usuario no existente")
                Return False
            Else
                If ResultadoConsulta.ToString() <> Me.Contra Then
                    MsgBox("Contraseña incorrecta")
                    Return False
                Else
                    MsgBox("Usuario logueado")
                    Return True
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            con.Apagado()
        End Try
        Return resultado
    End Function
End Class
