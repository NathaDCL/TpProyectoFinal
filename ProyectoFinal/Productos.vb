Public Class Productos
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
            If aux >= 1 Then
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
            If aux >= 1 Then
                MsgBox("Error con la categoria")
            Else
                _Categoria = value
            End If
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(Id As Integer, Nombre As String, Precio As Double, Categoria As String)
        Me.Id = Id
        Me.Nombre = Nombre
        Me.Precio = Precio
        Me.Categoria = Categoria

    End Sub
End Class
