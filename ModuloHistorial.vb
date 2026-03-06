Module ModuloHistorial

    ' Límite máximo de entradas en el historial
    Private Const MAX_HISTORIAL As Integer = 50

    ''' <summary>
    ''' Agrega una conversión al ListBox de historial.
    ''' Mantiene un máximo de MAX_HISTORIAL entradas.
    ''' </summary>
    ''' <param name="lista">El ListBox donde se muestra el historial</param>
    ''' <param name="montoOrigen">Monto original ingresado</param>
    ''' <param name="codigoOrigen">Código de moneda origen (ej: "USD")</param>
    ''' <param name="montoDestino">Monto convertido resultante</param>
    ''' <param name="codigoDestino">Código de moneda destino (ej: "COP")</param>
    Public Sub AgregarAlHistorial(lista As ListBox,
                                   montoOrigen As Double,
                                   codigoOrigen As String,
                                   montoDestino As Double,
                                   codigoDestino As String)

        ' Construir texto de la entrada
        Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
        Dim entrada As String = $"[{hora}]  {montoOrigen:N2} {codigoOrigen}  →  {montoDestino:N2} {codigoDestino}"

        ' Insertar al inicio para mostrar el más reciente arriba
        lista.Items.Insert(0, entrada)

        ' Eliminar entradas antiguas si se supera el límite
        Do While lista.Items.Count > MAX_HISTORIAL
            lista.Items.RemoveAt(lista.Items.Count - 1)
        Loop
    End Sub

    ''' <summary>
    ''' Limpia todas las entradas del historial tras confirmación del usuario.
    ''' </summary>
    ''' <param name="lista">El ListBox del historial a limpiar</param>
    Public Sub LimpiarHistorial(lista As ListBox)
        If lista.Items.Count = 0 Then
            MessageBox.Show("El historial ya está vacío.",
                            "Historial",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Return
        End If

        Dim respuesta As DialogResult = MessageBox.Show(
            "¿Está seguro de que desea limpiar todo el historial?",
            "Confirmar limpieza",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            lista.Items.Clear()
        End If
    End Sub

    ''' <summary>
    ''' Devuelve el número de conversiones registradas en el historial.
    ''' </summary>
    Public Function ContarEntradas(lista As ListBox) As Integer
        Return lista.Items.Count
    End Function

    ''' <summary>
    ''' Exporta el historial como texto plano (útil para copiar o guardar).
    ''' </summary>
    Public Function ExportarHistorial(lista As ListBox) As String
        If lista.Items.Count = 0 Then Return "Historial vacío."

        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("=== HISTORIAL DE CONVERSIONES ===")
        sb.AppendLine($"Exportado el: {DateTime.Now:dd/MM/yyyy HH:mm:ss}")
        sb.AppendLine()

        For Each item As String In lista.Items
            sb.AppendLine(item)
        Next

        Return sb.ToString()
    End Function

    End ModuleModule ModuloHistorial

End Module
