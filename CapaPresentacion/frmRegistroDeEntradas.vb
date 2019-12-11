Imports CapaEntidad
Imports CapaNegocio
Public Class frmRegistroDeEntradas
    Private Sub frmRegistroDeEntradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objfuncion As New negFuncion
        DataGridView2.DataSource = objfuncion.listarData()
        DataGridView2.Columns(0).Visible = False
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim objent As New entEntradas
        Dim objneg As New negEntradas
        objent._idFuncion = txtIDfuncion.Text
        objent._fecha = dtfecha.Text
        objent._asiento = numAsiento.Value
        Dim verificar = objneg.nuevaEntrada(objent)
        If verificar Then
            MsgBox("Registro de Entrada correcto")
        Else
            MsgBox("Error en registro de entrada")
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim objneg As New negEntradas
        DataGridView1.DataSource = objneg.listarEntrada()
    End Sub

    
   
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index
        txtIDfuncion.Text = DataGridView2.Item(0, i).Value()
    End Sub
End Class