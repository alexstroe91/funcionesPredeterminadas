Public Class metodos

    '---------------------------------------------------------------------
    '------------------------------ CADENAS -------------------------------
    '---------------------------------------------------------------------

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

    '---------------------------------------------------------------------
    '------------------------------ NUMEROS -------------------------------
    '---------------------------------------------------------------------
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

    '---------------------------------------------------------------------
    '------------------------------ FECHAS -------------------------------
    '---------------------------------------------------------------------
    Public Sub mostrarDatosFechas(frm As frmFechas)

        'Creo un array para despues usarlo en el label de mes ingresado
        Dim arrayMeses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}

        With frm

            'recojo  el dia de la fecha indicada
            .lblDiaDeLaSemana.Text = CType(.dteFecha.Value.Day, String)

            ' recojo el dia de la semana con el metodo de abajo y con el case le doy valor
            Select Case CInt(.dteFecha.Value.DayOfWeek)
                Case 1
                    .lblDiaDeLaSemana.Text = "Lunes"
                Case 2
                    .lblDiaDeLaSemana.Text = "Martes"
                Case 3
                    .lblDiaDeLaSemana.Text = "Miercoles"
                Case 4
                    .lblDiaDeLaSemana.Text = "Jueves"
                Case 5
                    .lblDiaDeLaSemana.Text = "Viernes"
                Case 6
                    .lblDiaDeLaSemana.Text = "Sabado"
                Case 7
                    .lblDiaDeLaSemana.Text = "Domingo"
            End Select

            ' recojo el dia ingresado de la semana 
            .lblDiaIngresado.Text = CType(.dteFecha.Value.Day, String)

            'recojo el mes ingresado y compruebo la posicion del array y le doy valor
            .lblMesIngresado.Text = CType(arrayMeses(.dteFecha.Value.Month - 1), String)

            'recojo de la fecha indicada el año
            .lblAnoIngresado.Text = CType(.dteFecha.Value.Year, String)

            'recojo la fecha de ingreso que es la fecha indicada
            .lblFechaIngreso.Text = CType(.dteFecha.Value.Date, String)

            'recojo la fecha actual con el metodo
            .lblFechaAct.Text = CStr(Now.Date & " o " & .lblDiaDeLaSemana.Text & ", " & .lblDiaIngresado.Text & " de " & .lblMesIngresado.Text & " de " & .lblAnoIngresado.Text)

            'resto los dias del año con el dia actual
            .lblDiasFaltan.Text = CStr(365 - Date.Now.DayOfYear)

            'muestro infromacion de este año
            .lblEsteAno.Text = CStr(.txtNombre.Text & " cumple " & (Date.Now.Year - .dteFecha.Value.Year) & " años")
        End With
    End Sub

End Class
