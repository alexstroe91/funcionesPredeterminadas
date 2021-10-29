Public Class frmCadenas

    Dim metodos As New metodos

    Private Sub btnLimpia_Click(sender As Object, e As EventArgs) Handles btnLimpia.Click
        'metodo que al pulsar el boton de limpiar, te borra todo el contenido de la informacion
        metodos.limpiarDatosCadenas(Me)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'metodo que cierra el formulario al pulsar el boton de salir
        Me.Close()
    End Sub

    Private Sub btnMuestra_Click(sender As Object, e As EventArgs) Handles btnMuestra.Click
        'Llamada al metodo de mostrar informacion en el formulario de cadenas.
        metodos.mostrarInfoCadenas(Me)
    End Sub
End Class