Imports CapaEntidad
Imports CapaNegocio
Public Class frmRegistroDeFuncion
    Private Sub frmRegistroDeFuncion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objsala As New negSala
        cmbSala.DataSource = objsala.listarData()
        cmbSala.DisplayMember = "idsala"
        Dim objPelicula As New negPelicula
        cmbPelicula.DataSource = objPelicula.listarData()
        cmbPelicula.DisplayMember = "nombrepelicula"
        cmbPelicula.ValueMember = "idpelicula"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim objent As New entFuncion
        Dim objneg As New negFuncion
        objent._idSala = cmbSala.Text
        objent._idPelicula = cmbPelicula.SelectedValue
        objent._precio = precioFuncion.Value
        objent._hora = txtHora.Text
        objent._fechaInicio = dtFechaInicio.Text
        objent._fechaFin = dtFechaFin.Text
        Dim verificar = objneg.nuevaFuncion(objent)
        If verificar Then
            MsgBox("Registro de Funcion correcta")
        Else
            MsgBox("Error en registro de funcion")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objent As New entFuncion
        Dim objneg As New negFuncion
        Dim idFuncion As Integer
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        idFuncion = DataGridView1.Item(0, i).Value()
        objent._idSala = cmbSala.Text
        objent._idPelicula = cmbPelicula.SelectedValue
        objent._precio = precioFuncion.Value
        objent._hora = txtHora.Text
        objent._fechaInicio = dtFechaInicio.Text
        objent._fechaFin = dtFechaFin.Text
        Dim verificar = objneg.editarFuncion(objent, idFuncion)
        If verificar Then
            MsgBox("Actualizacion de Funcion correcta")
        Else
            MsgBox("Error en actualizacion de funcion")
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim objneg As New negFuncion
        DataGridView1.DataSource = objneg.listarFuncion()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1.Item(0, i).Value()
        Dim objneg As New negFuncion
        Dim verificar = objneg.eliminarFuncion(id)
        If verificar Then
            MsgBox("Eliminacion de Funcion correcta")
        Else
            MsgBox("Ya hay entradas vendidas con esta funcion")
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim id As Integer = txtid.Text
        Dim objneg As New negFuncion
        DataGridView1.DataSource = objneg.buscarFuncion(id)
    End Sub

    
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmbSala.Text = DataGridView1.Item(1, i).Value()
        cmbPelicula.Text = DataGridView1.Item(2, i).Value()
        precioFuncion.Value = DataGridView1.Item(3, i).Value()
        txtHora.Text = DataGridView1.Item(4, i).Value().ToString
        dtFechaInicio.Text = DataGridView1.Item(5, i).Value().ToString
        dtFechaFin.Text = DataGridView1.Item(6, i).Value()
    End Sub
End Class