Module ModuloHistorial

    ' Límite máximo de entradas en el historial
    Private Const MAX_HISTORIAL As Integer = 50

    ' Agrega una conversión al historial
    Public Sub AgregarAlHistorial(lista As ListBox,
                                   montoOrigen As Double,
                                   codigoOrigen As String,
                                   montoDestino As Double,
                                   codigoDestino As String)

        Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
        Dim entrada As String = "[" & hora & "]  " & montoOrigen.ToString("N2") & " " &
                                codigoOrigen & "  ->  " &
                                montoDestino.ToString("N2") & " " & codigoDestino

        lista.Items.Insert(0, entrada)

        Do While lista.Items.Count > MAX_HISTORIAL
            lista.Items.RemoveAt(lista.Items.Count - 1)
        Loop

    End Sub

    ' Limpia el historial
    Public Sub LimpiarHistorial(lista As ListBox)

        If lista.Items.Count = 0 Then
            MessageBox.Show("El historial ya está vacío.",
                            "Historial",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
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

    ' Cuenta las entradas del historial
    Public Function ContarEntradas(lista As ListBox) As Integer
        Return lista.Items.Count
    End Function

    ' Exporta el historial
    Public Function ExportarHistorial(lista As ListBox) As String

        If lista.Items.Count = 0 Then
            Return "Historial vacío."
        End If

        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("=== HISTORIAL DE CONVERSIONES ===")
        sb.AppendLine("Exportado el: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
        sb.AppendLine("")

        For Each item As String In lista.Items
            sb.AppendLine(item)
        Next

        Return sb.ToString()

    End Function

End Module
