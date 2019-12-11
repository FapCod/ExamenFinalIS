Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datSala
    Public Function nuevaSala(objent As entSala) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registroSala"
            cmd.Parameters.AddWithValue("@ubicacionsala", objent._ubicacion)
            cmd.Parameters.AddWithValue("@capacidadsala", objent._capacidad)
            cmd.Parameters.AddWithValue("@tiposala", objent._tipo)
            cmd.Parameters.AddWithValue("@estadosala", objent._estado)
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
    Public Function listarSala() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "listarSala"
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
        cmd.CommandText = "listarComboboxSala"
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
