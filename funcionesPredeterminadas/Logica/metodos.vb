Public Class metodos
    Public Sub limpiarDatos(frm As frmCadenas)
        With frm
            .txtFrase.Text = ""
            .lblLongitud.Text = ""
            .lblPrimerCaracter.Text = ""
            .lblUltimoCaracter.Text = ""
            .lblSegundoAlSextoCaracter.Text = ""
            .lblPosPrimeraA.Text = ""
            .lblMayusculas.Text = ""
            .lblMinusculas.Text = ""
            .lblSoloPrimeraMayus.Text = ""
        End With

    End Sub


    Public Sub mostrarInfo(frm As frmCadenas)
        With frm
            'recojo la longitud del texto
            .lblLongitud.Text = CType(.txtFrase.TextLength(), String)
            'recojo el primer caracter de la cadena
            .lblPrimerCaracter.Text = .txtFrase.Text.First()
            'recojo e ultimo caracter de la cadena
            .lblUltimoCaracter.Text = .txtFrase.Text.Last()

            'compruebo si la longitud es mayor que 6 y despues recojo los valores que hayan entre el 2ndo y 6to caracter
            'sino, pongo un guión
            If .txtFrase.TextLength > 6 Then
                .lblSegundoAlSextoCaracter.Text = .txtFrase.Text.Substring(2, 5)
            Else
                .lblSegundoAlSextoCaracter.Text = "-"
            End If

            'paso la cadena caracter por caracter a un array de carracteres, y despues recorro todo el array y recojo
            'la posicion de la primera letra A
            Dim miArray As Char() = .txtFrase.Text.ToCharArray
            Dim encontrada As Boolean = False
            For i As Integer = 0 To miArray.GetUpperBound(0)
                If miArray(i) = "A" Or miArray(i) = "a" And Not encontrada Then
                    .lblPosPrimeraA.Text = CType(i + 1, String)
                    encontrada = True
                ElseIf Not encontrada Then
                    .lblPosPrimeraA.Text = "-"
                End If
            Next

        End With

    End Sub
End Class
