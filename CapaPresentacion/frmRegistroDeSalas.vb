Imports CapaNegocio
Imports CapaEntidad
Public Class frmRegistroDeSalas

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim objent As New entSala
        Dim objneg As New negSala
        objent._ubicacion = txtUbicacion.Text
        objent._capacidad = numeroCapacidad.Value
        objent._tipo = txtTipo.Text
        objent._estado = txtEstado.Text
        Dim verificar = objneg.nuevaSala(objent)
        If verificar Then
            MsgBox("Registro de sala Exitoso")
        Else
            MsgBox("Error en registro de Sala")
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim objneg As New negSala
        DataGridView1.DataSource = objneg.listarSala()
    End Sub

End Class