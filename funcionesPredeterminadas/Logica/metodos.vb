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

            'paso la cadena caracter por caracter a un array de carracteres
            Dim miArray As Char() = .txtFrase.Text.ToCharArray
            Dim encontrada As Boolean = False
            Dim contadorMayus As Integer = 0
            For i As Integer = 0 To miArray.GetUpperBound(0)
                'compruebo caracter a caracter si es mayuscula y si es asi al contador le sumo 1
                If Char.IsUpper(miArray(i)) Then
                    contadorMayus += 1
                End If

                If (miArray(i) = "A" OrElse miArray(i) = "a") AndAlso (Not encontrada) Then
                    .lblPosPrimeraA.Text = CType(i + 1, String)
                    encontrada = True
                ElseIf Not encontrada Then
                    .lblPosPrimeraA.Text = "-"
                End If
            Next

            .lblMayusculas.Text = CType(contadorMayus, String)

        End With

    End Sub
End Class
