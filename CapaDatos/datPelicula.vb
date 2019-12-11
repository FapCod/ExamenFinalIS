Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datPelicula
    Public Function nuevaPelicula(objent As entPelicula) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registroPelicula"
            cmd.Parameters.AddWithValue("@nombrepelicula", objent._nombre)
            cmd.Parameters.AddWithValue("@generopelicula", objent._genero)
            cmd.Parameters.AddWithValue("@clasificacionpelicula", objent._clasificacion)
            cmd.Parameters.AddWithValue("@fechaestrenopelicula", objent._fechaEstreno)
            cmd.Parameters.AddWithValue("@estadopelicula", objent._estado)
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
    Public Function listarPelicula() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "listarPelicula"
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
        cmd.CommandText = "listarComboboxPelicula"
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
