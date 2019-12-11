Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datFuncion
    Public Function nuevaFuncion(objent As entFuncion) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registroFuncion"
            cmd.Parameters.AddWithValue("@idsala", objent._idSala)
            cmd.Parameters.AddWithValue("@idpelicula", objent._idPelicula)
            cmd.Parameters.AddWithValue("@preciofuncion", objent._precio)
            cmd.Parameters.AddWithValue("@horafuncion", objent._hora)
            cmd.Parameters.AddWithValue("@fechainiciofuncion", objent._fechaInicio)
            cmd.Parameters.AddWithValue("@fechafinfuncion", objent._fechaFin)
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
    Public Function editarFuncion(objent As entFuncion, idFuncion As Integer) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "actualizarFuncion"
            cmd.Parameters.AddWithValue("@idfuncion", idFuncion)
            cmd.Parameters.AddWithValue("@idsala", objent._idSala)
            cmd.Parameters.AddWithValue("@idpelicula", objent._idPelicula)
            cmd.Parameters.AddWithValue("@preciofuncion", objent._precio)
            cmd.Parameters.AddWithValue("@horafuncion", objent._hora)
            cmd.Parameters.AddWithValue("@fechainiciofuncion", objent._fechaInicio)
            cmd.Parameters.AddWithValue("@fechafinfuncion", objent._fechaFin)
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

    Public Function eliminarFuncion(id As Integer) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "eliminarFuncion"
            cmd.Parameters.AddWithValue("@idfuncion", id)
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If
        Catch ex As Exception
        End Try
        Return False
    End Function
    Public Function listarFuncion() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "listarFuncion"
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

    Public Function buscarFuncion(id As Integer) As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "buscarFuncion"
        cmd.Parameters.AddWithValue("@idfuncion", id)
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

    Public Function listarData() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "listarDgvFuncion"
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
