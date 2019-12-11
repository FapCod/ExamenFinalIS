Public Class frmPrincipal

    
    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        frmRegistroDeEntradas.Show()
    End Sub

    Private Sub btnFuncion_Click(sender As Object, e As EventArgs) Handles btnFuncion.Click
        frmRegistroDeFuncion.Show()
    End Sub

    Private Sub btnPelicula_Click(sender As Object, e As EventArgs) Handles btnPelicula.Click
        frmRegistroDePeliculas.Show()
    End Sub

    Private Sub btnSala_Click(sender As Object, e As EventArgs) Handles btnSala.Click
        frmRegistroDeSalas.Show()
    End Sub
End Class