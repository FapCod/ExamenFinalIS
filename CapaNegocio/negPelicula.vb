Imports CapaDatos
Imports CapaEntidad
Public Class negPelicula
    Public Function nuevaPelicula(objent As entPelicula) As Boolean
        Dim objdat As New datPelicula
        Return objdat.nuevaPelicula(objent)
    End Function
    Public Function listarPelicula() As DataTable
        Dim objpro As New datPelicula
        Return objpro.listarPelicula()
    End Function
    Public Function listarData() As DataTable
        Dim objpro As New datPelicula
        Return objpro.listarData()
    End Function
End Class
