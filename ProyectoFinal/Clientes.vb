Public Class Clientes
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
            If aux >= 1 Then
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
            If value > 0 Then
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
                If IsNumeric(value(i)) = "@" Then
                    aux = aux + 1
                End If
            Next i
            If aux > 1 Or aux = 0 Then
                MsgBox("Error con el correo")
            Else
                _Correo = value
            End If
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(Id As Integer, Cliente As String, Tel As Integer, Correo As String)
        Me.Id = Id
        Me.Cliente = Cliente
        Me.Tel = Tel
        Me.Correo = Correo

    End Sub

End Class
