Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Llenar ComboBoxes
        Dim monedas As String() = {"USD - Dólar", "COP - Peso colombiano", "EUR - Euro", "MXN - Peso mexicano", "GBP - Libra esterlina"}
        cmbOrigen.Items.AddRange(monedas)
        cmbDestino.Items.AddRange(monedas)
        cmbOrigen.SelectedIndex = 0
        cmbDestino.SelectedIndex = 1

    End Sub

    ' ===== EVENTO CONVERTIR =====
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim monto As Double
        Dim monedaOrigen As String = cmbOrigen.SelectedItem.ToString().Split("-")(0).Trim()
        Dim monedaDestino As String = cmbDestino.SelectedItem.ToString().Split("-")(0).Trim()

        If Not ModuloValidaciones.ValidarEntrada(txtMonto.Text, monto) Then Exit Sub

        Dim resultado As Double = ModuloConversion.Convertir(monto, monedaOrigen, monedaDestino)

        lblResultado.Text = $"{monto:N2} {monedaOrigen}  →  {resultado:N2} {monedaDestino}"

        ModuloHistorial.AgregarAlHistorial(lstHistorial, monto, monedaOrigen, resultado, monedaDestino)
    End Sub

    ' ===== EVENTO LIMPIAR =====
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ModuloHistorial.LimpiarHistorial(lstHistorial)
        lblResultado.Text = "Resultado:"
        txtMonto.Clear()
    End Sub

End Class