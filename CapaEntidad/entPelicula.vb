Public Class entPelicula
    Private nombre
    Private genero
    Private clasificacion
    Private fechaEstreno
    Private estado

    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property _genero As String
        Get
            Return genero
        End Get
        Set(value As String)
            genero = value
        End Set
    End Property
    Public Property _clasificacion As String
        Get
            Return clasificacion
        End Get
        Set(value As String)
            clasificacion = value
        End Set
    End Property
    Public Property _fechaEstreno As String
        Get
            Return fechaEstreno
        End Get
        Set(value As String)
            fechaEstreno = value
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
