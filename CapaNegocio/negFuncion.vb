Imports CapaDatos
Imports CapaEntidad
Public Class negFuncion

    Public Function nuevaFuncion(objent As entFuncion) As Boolean
        Dim objdat As New datFuncion
        Return objdat.nuevaFuncion(objent)
    End Function
    Public Function editarFuncion(objent As entFuncion, idFuncion As Integer) As Boolean
        Dim objdat As New datFuncion
        Return objdat.editarFuncion(objent, idFuncion)
    End Function
    Public Function eliminarFuncion(id As Integer) As Boolean
        Dim objdat As New datFuncion
        Return objdat.eliminarFuncion(id)
    End Function
    Public Function buscarFuncion(id As Integer) As DataTable
        Dim objpro As New datFuncion
        Return objpro.buscarFuncion(id)
    End Function
    Public Function listarFuncion() As DataTable
        Dim objpro As New datFuncion
        Return objpro.listarFuncion()
    End Function
    Public Function listarData() As DataTable
        Dim objpro As New datFuncion
        Return objpro.listarData()
    End Function
End Class
