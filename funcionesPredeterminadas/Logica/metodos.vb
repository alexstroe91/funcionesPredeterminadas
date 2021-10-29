Public Class metodos
    Public Sub limpiarDatosCadenas(frm As frmCadenas)
        With frm
            'limpio cada textbox y cada label para que este vacio
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

            For i As Integer = 0 To miArray.GetUpperBound(0) Step +1
                ' compruebo letra a letra si es una A y si lo es, el booleano de encontrado pasa a true para que no se siga comprobando
                If (miArray(i) = "A") AndAlso (Not encontrada) Then
                    .lblPosPrimeraA.Text = CType(i + 1, String)
                    encontrada = True
                ElseIf Not encontrada Then
                    .lblPosPrimeraA.Text = "-"
                End If
            Next

            'Transoformo el texto que teng en .txtFrase a Mayuscula o Minuscula, lo que necesite
            'repectivamente
            .lblMayusculas.Text = Strings.UCase(.txtFrase.Text)
            .lblMinusculas.Text = Strings.LCase(.txtFrase.Text)

            'Convierto la primera letra de cada palabra a mayusculas con ese metodo.
            .lblSoloPrimeraMayus.Text = StrConv(.txtFrase.Text, vbProperCase)

        End With

    End Sub

    Public Sub limpiarDatosNumeros(frm As frmNumeros)
        With frm
            'limpio cada textbox y cada label para que este vacio
            .numNumeros.Value = 0
            .lblParteEntera.Text = ""
            .lblParteDecimal.Text = ""
            .lblValorAbsoluto.Text = ""
            .lblRaiz.Text = ""
            .lblSignoDelNumero.Text = ""
            .lblValorOctal.Text = ""
            .lblValorHexadecimal.Text = ""
        End With
    End Sub

    Public Sub mostrarInfoNumeros(frm As frmNumeros)
        With frm
            'con el metodo truncate, saco la parte entera de un nr
            .lblParteEntera.Text = CType(Math.Truncate(.numNumeros.Value), String)

            'Le resto al nr la parte entera y se me queda la parte decimal
            .lblParteDecimal.Text = CType(Math.Abs((.numNumeros.Value) - Math.Truncate(.numNumeros.Value)), String)

            'con el metodo abs saco el valor absoluto del nr introducido
            .lblValorAbsoluto.Text = CType(Math.Abs(.numNumeros.Value), String)

            'compruebo si el nr es mayor que 0 si es asi hago la raiz cuadrada y sino muestro un mensaje informativo
            If .numNumeros.Value > 0 Then
                .lblRaiz.Text = CType(Math.Sqrt(.numNumeros.Value), String)
            Else
                .lblRaiz.Text = "No existe la raiz cuadrada de un nr negativo."
            End If

            'compruebo si el nr es mayor que 0 y muestro el mensaje informativo
            If .numNumeros.Value >= 0 Then
                .lblSignoDelNumero.Text = "Positivo"
            Else
                .lblSignoDelNumero.Text = "Negativo"
            End If

            'si el nr es mayor que 0 saco el octal con el metodo Oct, sino muestro un mensaje
            If .numNumeros.Value > 0 Then
                .lblValorOctal.Text = Conversion.Oct(.numNumeros.Value)
            Else
                .lblValorOctal.Text = "No existe el valor octal de un nr negativo."
            End If


            'si el nr es mayor que 0 saco el hexadecimal con el metodo Oct, sino muestro un mensaje
            If .numNumeros.Value > 0 Then
                .lblValorHexadecimal.Text = Conversion.Hex(.numNumeros.Value)
            Else
                .lblValorHexadecimal.Text = "No existe el valor hexadecimal de un nr negativo."
            End If


        End With
    End Sub

End Class
