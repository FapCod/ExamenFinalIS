Public Class entEntradas
    Public idFuncion
    Private fecha
    Private asiento
    Public Property _idFuncion As Integer
        Get
            Return idFuncion
        End Get
        Set(value As Integer)
            idFuncion = value
        End Set
    End Property
    Public Property _fecha As String
        Get
            Return fecha
        End Get
        Set(value As String)
            fecha = value
        End Set
    End Property
    Public Property _asiento As String
        Get
            Return asiento
        End Get
        Set(value As String)
            asiento = value
        End Set
    End Property

    
End Class
