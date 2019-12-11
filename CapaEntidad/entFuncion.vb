Public Class entFuncion
    Public idSala
    Public idPelicula

    Private precio
    Private hora
    Private fechaInicio
    Private fechaFin
    Public Property _idSala As Integer
        Get
            Return idSala
        End Get
        Set(value As Integer)
            idSala = value
        End Set
    End Property
    Public Property _idPelicula As Integer
        Get
            Return idPelicula
        End Get
        Set(value As Integer)
            idPelicula = value
        End Set
    End Property

    Public Property _precio As Double
        Get
            Return precio
        End Get
        Set(value As Double)
            precio = value
        End Set
    End Property
    Public Property _hora As String
        Get
            Return hora
        End Get
        Set(value As String)
            hora = value
        End Set
    End Property
    Public Property _fechaInicio As Date
        Get
            Return fechaInicio
        End Get
        Set(value As Date)
            fechaInicio = value
        End Set
    End Property
    Public Property _fechaFin As Date
        Get
            Return fechaFin
        End Get
        Set(value As Date)
            fechaFin = value
        End Set
    End Property

End Class
