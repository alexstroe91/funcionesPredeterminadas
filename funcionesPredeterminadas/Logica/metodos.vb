﻿Public Class metodos
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


    Public Sub mostrarInfoCadenas(frm As frmCadenas)
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
                .lblSegundoAlSextoCaracter.Text = .txtFrase.Text.Substring(1, 5)
            Else
                .lblSegundoAlSextoCaracter.Text = "-"
            End If

            'paso la cadena caracter por caracter a un array de carracteres
            Dim miArray As Char() = .txtFrase.Text.ToCharArray
            Dim encontrada As Boolean = False
            Dim contadorMayus As Integer = 0
            Dim contadorMinus As Integer = 0

            For i As Integer = 0 To miArray.GetUpperBound(0) Step +1
                'compruebo caracter a caracter si es mayuscula y si es asi al contador y +1 y sino +1 a contadorMinus
                If Char.IsUpper(miArray(i)) Then
                    contadorMayus += 1
                Else
                    contadorMinus += 1
                End If
                ' compruebo letra a letra si es una A y si lo es, el booleano de encontrado pasa a true para que no se siga comprobando
                If (miArray(i) = "A" OrElse miArray(i) = "a") AndAlso (Not encontrada) Then
                    .lblPosPrimeraA.Text = CType(i + 1, String)
                    encontrada = True
                ElseIf Not encontrada Then
                    .lblPosPrimeraA.Text = "-"
                End If
            Next

            'voy letra por letra comprobando si es mayuscula o minuscula y voy sumando a su contador respectivo
            If Char.IsUpper(.txtFrase.Text.First()) Then
                .lblSoloPrimeraMayus.Text = "Sí"
            Else
                .lblSoloPrimeraMayus.Text = "No"
            End If

            .lblMayusculas.Text = CType(contadorMayus, String)
            .lblMinusculas.Text = CType(contadorMinus, String)

        End With

    End Sub
End Class
