<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents txtMonto As TextBox
    Friend WithEvents cmbOrigen As ComboBox
    Friend WithEvents cmbDestino As ComboBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents lstHistorial As ListBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblMontoTitle As Label
    Friend WithEvents lblOrigenTitle As Label
    Friend WithEvents lblDestinoTitle As Label
    Friend WithEvents lblHistorialTitle As Label
    Friend WithEvents pnlResultado As Panel
    Friend WithEvents lblResultadoIcono As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtMonto = New TextBox()
        cmbOrigen = New ComboBox()
        cmbDestino = New ComboBox()
        btnConvertir = New Button()
        btnLimpiar = New Button()
        lblResultado = New Label()
        lstHistorial = New ListBox()
        pnlHeader = New Panel()
        lblTitulo = New Label()
        lblSubtitulo = New Label()
        lblMontoTitle = New Label()
        lblOrigenTitle = New Label()
        lblDestinoTitle = New Label()
        lblHistorialTitle = New Label()
        pnlResultado = New Panel()
        lblResultadoIcono = New Label()

        SuspendLayout()

        ' FORM
        Me.ClientSize = New Size(480, 620)
        Me.Name = "Form1"
        Me.Text = "Conversor de Monedas"
        Me.BackColor = Color.FromArgb(240, 242, 248)
        Me.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

        ' HEADER
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Size = New Size(480, 90)
        pnlHeader.BackColor = Color.FromArgb(30, 58, 138)

        lblTitulo.Location = New Point(20, 18)
        lblTitulo.Size = New Size(440, 36)
        lblTitulo.Text = "Conversor de Monedas"
        lblTitulo.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblTitulo.ForeColor = Color.White

        lblSubtitulo.Location = New Point(22, 54)
        lblSubtitulo.Size = New Size(440, 22)
        lblSubtitulo.Text = "Conversiones rapidas y precisas"
        lblSubtitulo.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        lblSubtitulo.ForeColor = Color.FromArgb(180, 200, 255)

        pnlHeader.Controls.Add(lblTitulo)
        pnlHeader.Controls.Add(lblSubtitulo)

        ' MONTO
        lblMontoTitle.Location = New Point(20, 105)
        lblMontoTitle.Size = New Size(440, 18)
        lblMontoTitle.Text = "MONTO A CONVERTIR"
        lblMontoTitle.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblMontoTitle.ForeColor = Color.FromArgb(100, 116, 139)

        txtMonto.Location = New Point(20, 126)
        txtMonto.Size = New Size(440, 34)
        txtMonto.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular)
        txtMonto.BackColor = Color.White
        txtMonto.ForeColor = Color.FromArgb(15, 23, 42)
        txtMonto.BorderStyle = BorderStyle.FixedSingle
        txtMonto.TabIndex = 0

        ' ORIGEN
        lblOrigenTitle.Location = New Point(20, 178)
        lblOrigenTitle.Size = New Size(210, 18)
        lblOrigenTitle.Text = "MONEDA ORIGEN"
        lblOrigenTitle.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblOrigenTitle.ForeColor = Color.FromArgb(100, 116, 139)

        cmbOrigen.Location = New Point(20, 200)
        cmbOrigen.Size = New Size(210, 32)
        cmbOrigen.Font = New Font("Segoe UI", 10.0F)
        cmbOrigen.BackColor = Color.White
        cmbOrigen.ForeColor = Color.FromArgb(15, 23, 42)
        cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList
        cmbOrigen.FlatStyle = FlatStyle.Flat
        cmbOrigen.TabIndex = 1

        ' DESTINO
        lblDestinoTitle.Location = New Point(250, 178)
        lblDestinoTitle.Size = New Size(210, 18)
        lblDestinoTitle.Text = "MONEDA DESTINO"
        lblDestinoTitle.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblDestinoTitle.ForeColor = Color.FromArgb(100, 116, 139)

        cmbDestino.Location = New Point(250, 200)
        cmbDestino.Size = New Size(210, 32)
        cmbDestino.Font = New Font("Segoe UI", 10.0F)
        cmbDestino.BackColor = Color.White
        cmbDestino.ForeColor = Color.FromArgb(15, 23, 42)
        cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDestino.FlatStyle = FlatStyle.Flat
        cmbDestino.TabIndex = 2

        ' BOTONES
        btnConvertir.Location = New Point(20, 252)
        btnConvertir.Size = New Size(210, 42)
        btnConvertir.Text = "Convertir"
        btnConvertir.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnConvertir.BackColor = Color.FromArgb(30, 58, 138)
        btnConvertir.ForeColor = Color.White
        btnConvertir.FlatStyle = FlatStyle.Flat
        btnConvertir.FlatAppearance.BorderSize = 0
        btnConvertir.Cursor = Cursors.Hand
        btnConvertir.TabIndex = 3

        btnLimpiar.Location = New Point(250, 252)
        btnLimpiar.Size = New Size(210, 42)
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnLimpiar.BackColor = Color.FromArgb(241, 245, 249)
        btnLimpiar.ForeColor = Color.FromArgb(71, 85, 105)
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnLimpiar.FlatAppearance.BorderSize = 1
        btnLimpiar.Cursor = Cursors.Hand
        btnLimpiar.TabIndex = 4

        ' RESULTADO
        pnlResultado.Location = New Point(20, 314)
        pnlResultado.Size = New Size(440, 56)
        pnlResultado.BackColor = Color.FromArgb(239, 246, 255)

        lblResultadoIcono.Location = New Point(12, 14)
        lblResultadoIcono.Size = New Size(30, 28)
        lblResultadoIcono.Text = "="
        lblResultadoIcono.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblResultadoIcono.ForeColor = Color.FromArgb(30, 58, 138)

        lblResultado.Location = New Point(44, 10)
        lblResultado.Size = New Size(386, 36)
        lblResultado.Text = "Resultado:"
        lblResultado.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular)
        lblResultado.ForeColor = Color.FromArgb(30, 58, 138)
        lblResultado.TabIndex = 5

        pnlResultado.Controls.Add(lblResultadoIcono)
        pnlResultado.Controls.Add(lblResultado)

        ' HISTORIAL
        lblHistorialTitle.Location = New Point(20, 390)
        lblHistorialTitle.Size = New Size(440, 20)
        lblHistorialTitle.Text = "HISTORIAL DE CONVERSIONES"
        lblHistorialTitle.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblHistorialTitle.ForeColor = Color.FromArgb(100, 116, 139)

        lstHistorial.Location = New Point(20, 414)
        lstHistorial.Size = New Size(440, 180)
        lstHistorial.Font = New Font("Segoe UI", 9.5F)
        lstHistorial.BackColor = Color.White
        lstHistorial.ForeColor = Color.FromArgb(30, 41, 59)
        lstHistorial.BorderStyle = BorderStyle.FixedSingle
        lstHistorial.TabIndex = 6

        ' AGREGAR AL FORM (sin pnlCard, todo directo al form)
        Me.Controls.Add(pnlHeader)
        Me.Controls.Add(lblMontoTitle)
        Me.Controls.Add(txtMonto)
        Me.Controls.Add(lblOrigenTitle)
        Me.Controls.Add(cmbOrigen)
        Me.Controls.Add(lblDestinoTitle)
        Me.Controls.Add(cmbDestino)
        Me.Controls.Add(btnConvertir)
        Me.Controls.Add(btnLimpiar)
        Me.Controls.Add(pnlResultado)
        Me.Controls.Add(lblHistorialTitle)
        Me.Controls.Add(lstHistorial)

        ResumeLayout(False)
        PerformLayout()
    End Sub

End Class