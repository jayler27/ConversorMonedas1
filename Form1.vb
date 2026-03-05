Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "💱 Conversor de Monedas"
        Me.Size = New Size(500, 520)
        Me.BackColor = Color.FromArgb(240, 248, 255)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

        ' ===== TÍTULO =====
        Dim lblTitulo As New Label()
        lblTitulo.Text = "Conversor de Monedas"
        lblTitulo.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblTitulo.ForeColor = Color.FromArgb(30, 80, 160)
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(110, 20)
        Me.Controls.Add(lblTitulo)

        ' ===== MONTO =====
        Dim lblMonto As New Label()
        lblMonto.Text = "Monto a convertir:"
        lblMonto.Font = New Font("Segoe UI", 10)
        lblMonto.Location = New Point(40, 80)
        lblMonto.AutoSize = True
        Me.Controls.Add(lblMonto)

        txtMonto.Font = New Font("Segoe UI", 12)
        txtMonto.Location = New Point(40, 105)
        txtMonto.Size = New Size(200, 30)
        txtMonto.BorderStyle = BorderStyle.FixedSingle
        Me.Controls.Add(txtMonto)

        ' ===== MONEDA ORIGEN =====
        Dim lblOrigen As New Label()
        lblOrigen.Text = "Moneda origen:"
        lblOrigen.Font = New Font("Segoe UI", 10)
        lblOrigen.Location = New Point(40, 155)
        lblOrigen.AutoSize = True
        Me.Controls.Add(lblOrigen)

        cmbOrigen.Font = New Font("Segoe UI", 10)
        cmbOrigen.Location = New Point(40, 178)
        cmbOrigen.Size = New Size(180, 30)
        cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Controls.Add(cmbOrigen)

        ' ===== MONEDA DESTINO =====
        Dim lblDestino As New Label()
        lblDestino.Text = "Moneda destino:"
        lblDestino.Font = New Font("Segoe UI", 10)
        lblDestino.Location = New Point(260, 155)
        lblDestino.AutoSize = True
        Me.Controls.Add(lblDestino)

        cmbDestino.Font = New Font("Segoe UI", 10)
        cmbDestino.Location = New Point(260, 178)
        cmbDestino.Size = New Size(180, 30)
        cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList
        Me.Controls.Add(cmbDestino)

        ' Llenar ComboBoxes
        Dim monedas As String() = {"USD - Dólar", "COP - Peso colombiano", "EUR - Euro", "MXN - Peso mexicano", "GBP - Libra esterlina"}
        cmbOrigen.Items.AddRange(monedas)
        cmbDestino.Items.AddRange(monedas)
        cmbOrigen.SelectedIndex = 0
        cmbDestino.SelectedIndex = 1

        ' ===== BOTÓN CONVERTIR =====
        btnConvertir.Text = "💱 Convertir"
        btnConvertir.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnConvertir.BackColor = Color.FromArgb(30, 80, 160)
        btnConvertir.ForeColor = Color.White
        btnConvertir.FlatStyle = FlatStyle.Flat
        btnConvertir.Location = New Point(150, 230)
        btnConvertir.Size = New Size(180, 40)
        btnConvertir.Cursor = Cursors.Hand
        Me.Controls.Add(btnConvertir)

        ' ===== RESULTADO =====
        Dim lblResultadoTxt As New Label()
        lblResultadoTxt.Text = "Resultado:"
        lblResultadoTxt.Font = New Font("Segoe UI", 10)
        lblResultadoTxt.Location = New Point(40, 295)
        lblResultadoTxt.AutoSize = True
        Me.Controls.Add(lblResultadoTxt)

        lblResultado.Text = "---"
        lblResultado.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblResultado.ForeColor = Color.FromArgb(0, 140, 70)
        lblResultado.Location = New Point(40, 318)
        lblResultado.Size = New Size(420, 35)
        Me.Controls.Add(lblResultado)

        ' ===== HISTORIAL =====
        Dim lblHistorial As New Label()
        lblHistorial.Text = "Historial de conversiones:"
        lblHistorial.Font = New Font("Segoe UI", 10)
        lblHistorial.Location = New Point(40, 365)
        lblHistorial.AutoSize = True
        Me.Controls.Add(lblHistorial)

        lstHistorial.Font = New Font("Segoe UI", 9)
        lstHistorial.Location = New Point(40, 388)
        lstHistorial.Size = New Size(330, 80)
        lstHistorial.BorderStyle = BorderStyle.FixedSingle
        Me.Controls.Add(lstHistorial)

        ' ===== BOTÓN LIMPIAR =====
        btnLimpiar.Text = "🗑 Limpiar"
        btnLimpiar.Font = New Font("Segoe UI", 9)
        btnLimpiar.BackColor = Color.FromArgb(200, 50, 50)
        btnLimpiar.ForeColor = Color.White
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.Location = New Point(385, 388)
        btnLimpiar.Size = New Size(80, 35)
        btnLimpiar.Cursor = Cursors.Hand
        Me.Controls.Add(btnLimpiar)
    End Sub

    ' ===== EVENTO CONVERTIR =====
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim monto As Double
        Dim monedaOrigen As String = cmbOrigen.SelectedItem.ToString().Split("-")(0).Trim()
        Dim monedaDestino As String = cmbDestino.SelectedItem.ToString().Split("-")(0).Trim()

        ' Validar entrada
        If Not ModuloValidaciones.ValidarEntrada(txtMonto.Text, monto) Then Exit Sub

        ' Convertir
        Dim resultado As Double = ModuloConversion.Convertir(monto, monedaOrigen, monedaDestino)

        ' Mostrar resultado
        lblResultado.Text = $"{monto:N2} {monedaOrigen}  →  {resultado:N2} {monedaDestino}"

        ' Guardar en historial
        ModuloHistorial.AgregarAlHistorial(lstHistorial, monto, monedaOrigen, resultado, monedaDestino)
    End Sub

    ' ===== EVENTO LIMPIAR =====
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ModuloHistorial.LimpiarHistorial(lstHistorial)
        lblResultado.Text = "---"
        txtMonto.Clear()
    End Sub

End Class