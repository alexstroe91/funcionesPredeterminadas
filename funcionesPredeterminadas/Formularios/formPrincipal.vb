Public Class formPrincipal
    Private Sub mnuCadena_Click(sender As Object, e As EventArgs) Handles mnuCadena.Click, mnuNumeros.Click, mnuFechas.Click
        Dim objfrm As Form = Nothing

        'Abrir los diferentes formularios dependiendo de en que opcionhaga click
        Select Case CType(sender, ToolStripMenuItem).Name
            Case "mnuCadena"
                objfrm = New frmCadenas()
                objfrm.Show()
            Case "mnuNumeros"
                objfrm = New frmNumeros()
                objfrm.Show()
            Case "mnuFechas"
                objfrm = New frmFechas()
                objfrm.Show()
        End Select

    End Sub
End Class
