Imports CapaDatos
Imports CapaEntidad
Public Class negEntradas
    Public Function nuevaEntrada(objent As entEntradas) As Boolean
        Dim objdat As New datEntradas
        Return objdat.nuevaEntrada(objent)
    End Function
    Public Function listarEntrada() As DataTable
        Dim objpro As New datEntradas
        Return objpro.listarEntradas()
    End Function
End Class
