Public Class frmNumeros
    Dim logica As New metodos
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        logica.mostrarInfoNumeros(Me)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        logica.limpiarDatosNumeros(Me)
    End Sub
End Class