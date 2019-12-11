Public Class entSala
    Private ubicacion
    Private capacidad
    Private tipo
    Private estado
    Public Property _ubicacion As String
        Get
            Return ubicacion
        End Get
        Set(value As String)
            ubicacion = value
        End Set
    End Property
    Public Property _capacidad As Integer
        Get
            Return capacidad
        End Get
        Set(value As Integer)
            capacidad = value
        End Set
    End Property
    Public Property _tipo As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property
    Public Property _estado As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property
End Class
