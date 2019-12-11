Imports CapaDatos
Imports CapaEntidad
Public Class negSala
    Public Function nuevaSala(objent As entSala) As Boolean
        Dim objdat As New datSala
        Return objdat.nuevaSala(objent)
    End Function
    Public Function listarSala() As DataTable
        Dim objpro As New datSala
        Return objpro.listarSala()
    End Function
    Public Function listarData() As DataTable
        Dim objpro As New datSala
        Return objpro.listarData()
    End Function
End Class
