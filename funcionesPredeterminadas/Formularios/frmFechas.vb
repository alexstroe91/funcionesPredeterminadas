Public Class frmFechas
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim logica As New metodos
        logica.mostrarDatosFechas(Me)
    End Sub

End Class