Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datEntradas
    Public Function nuevaEntrada(objent As entEntradas) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registrarEntrada"
            cmd.Parameters.AddWithValue("@idfuncion", objent._idFuncion)
            cmd.Parameters.AddWithValue("@fechaentrada", objent._fecha)
            cmd.Parameters.AddWithValue("@asientoentrada", objent._asiento)
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("error ex" + ex.Message)
        End Try
        Return False
    End Function

    Public Function listarEntradas() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "listarEntrada"
        objdat.Conectar("", "", True)
        cmd.Connection = objdat.cnn
        If cmd.ExecuteNonQuery Then
            dt = New DataTable
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Else
            Return Nothing
        End If
    End Function
End Class
