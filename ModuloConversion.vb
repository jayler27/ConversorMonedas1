Module ModuloConversion

    ' ============================================================
    '   TASAS DE CAMBIO BASE (relativas al USD)
    '   Fuente: tasas aproximadas de referencia
    '   Actualizar manualmente si se requieren tasas reales
    ' ============================================================
    Private ReadOnly tasas As New Dictionary(Of String, Double) From {
        {"USD", 1.0},
        {"COP", 4100.0},
        {"EUR", 0.92},
        {"MXN", 17.15},
        {"GBP", 0.79}
    }

    ''' <summary>
    ''' Convierte un monto de una moneda origen a una moneda destino.
    ''' Primero convierte a USD como moneda intermedia, luego al destino.
    ''' </summary>
    ''' <param name="monto">Cantidad a convertir</param>
    ''' <param name="origen">Código de moneda origen (ej: "USD")</param>
    ''' <param name="destino">Código de moneda destino (ej: "COP")</param>
    ''' <returns>Monto convertido como Double</returns>
    Public Function Convertir(monto As Double, origen As String, destino As String) As Double
        ' Verificar que las monedas existan en el diccionario
        If Not tasas.ContainsKey(origen) OrElse Not tasas.ContainsKey(destino) Then
            MessageBox.Show("Moneda no reconocida. Verifique la selección.",
                            "Error de conversión",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return 0
        End If

        ' Paso 1: Convertir de origen a USD
        Dim enUSD As Double = monto / tasas(origen)

        ' Paso 2: Convertir de USD a destino
        Dim resultado As Double = enUSD * tasas(destino)

        ' Redondear a 2 decimales
        Return Math.Round(resultado, 2)
    End Function

    ''' <summary>
    ''' Devuelve la lista de monedas disponibles con sus nombres completos.
    ''' </summary>
    Public Function ObtenerMonedas() As List(Of String)
        Return New List(Of String) From {
            "USD - Dólar estadounidense",
            "COP - Peso colombiano",
            "EUR - Euro",
            "MXN - Peso mexicano",
            "GBP - Libra esterlina"
        }
    End Function

    ''' <summary>
    ''' Obtiene la tasa de cambio actual de una moneda respecto al USD.
    ''' </summary>
    Public Function ObtenerTasa(moneda As String) As Double
        If tasas.ContainsKey(moneda) Then
            Return tasas(moneda)
        End If
        Return 0
    End Function

End Module