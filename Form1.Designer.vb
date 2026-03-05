<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    ' ===== DECLARACIÓN DE CONTROLES =====
    Friend WithEvents txtMonto As New TextBox()
    Friend WithEvents cmbOrigen As New ComboBox()
    Friend WithEvents cmbDestino As New ComboBox()
    Friend WithEvents btnConvertir As New Button()
    Friend WithEvents lblResultado As New Label()
    Friend WithEvents lstHistorial As New ListBox()
    Friend WithEvents btnLimpiar As New Button()

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 520)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
    End Sub

End Class