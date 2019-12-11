Imports CapaEntidad
Imports CapaNegocio
Public Class frmRegistroDePeliculas


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim objent As New entPelicula
        Dim objneg As New negPelicula
        objent._nombre = txtNombre.Text
        objent._genero = txtGenero.Text
        objent._clasificacion = txtClasificacion.Text
        objent._fechaEstreno = dtFecha.Text
        objent._estado = txtEstado.Text
        Dim verificar = objneg.nuevaPelicula(objent)
        If verificar Then
            MsgBox("Regostro de pelicula exitoso")
        Else
            MsgBox("Error al registrar pelicula")
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim objneg As New negPelicula
        DataGridView1.DataSource = objneg.listarPelicula()
    End Sub
End Class
