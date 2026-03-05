Module ModuloValidaciones

    ''' <summary>
    ''' Valida que el texto ingresado sea un número válido y positivo.
    ''' Muestra mensajes de error descriptivos si la validación falla.
    ''' </summary>
    ''' <param name="texto">Texto del TextBox ingresado por el usuario</param>
    ''' <param name="resultado">Variable donde se guarda el número parseado</param>
    ''' <returns>True si es válido, False si hay error</returns>
    Public Function ValidarEntrada(texto As String, ByRef resultado As Double) As Boolean

        ' Validar que no esté vacío
        If String.IsNullOrWhiteSpace(texto) Then
            MostrarError("El campo de monto no puede estar vacío." & vbNewLine &
                         "Por favor ingrese un valor numérico.")
            Return False
        End If

        ' Validar que sea un número (acepta coma y punto como decimal)
        Dim textoLimpio As String = texto.Replace(",", ".")
        If Not Double.TryParse(textoLimpio,
                               Globalization.NumberStyles.Any,
                               Globalization.CultureInfo.InvariantCulture,
                               resultado) Then
            MostrarError("El valor ingresado no es un número válido." & vbNewLine &
                         "Ejemplo de formato correcto: 1500 o 1500.50")
            Return False
        End If

        ' Validar que sea mayor que cero
        If resultado <= 0 Then
            MostrarError("El monto debe ser un número mayor a cero." & vbNewLine &
                         "No se permiten valores negativos ni cero.")
            Return False
        End If

        ' Validar que no sea un número absurdamente grande
        If resultado > 999_999_999_999 Then
            MostrarError("El monto ingresado es demasiado grande." & vbNewLine &
                         "Ingrese un valor menor a 999,999,999,999.")
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Muestra un MessageBox de error con el mensaje proporcionado.
    ''' </summary>
    Private Sub MostrarError(mensaje As String)
        MessageBox.Show(mensaje,
                        "Error de validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
    End Sub

    ''' <summary>
    ''' Verifica que el usuario haya seleccionado monedas diferentes.
    ''' </summary>
    Public Function ValidarMonedasDistintas(origen As String, destino As String) As Boolean
        If origen = destino Then
            MostrarError("La moneda origen y destino no pueden ser iguales." & vbNewLine &
                         "Por favor seleccione monedas diferentes.")
            Return False
        End If
        Return True
    End Function

End Module
