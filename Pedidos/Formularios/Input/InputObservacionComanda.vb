Public Class InputObservacionComanda
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.F1 Then bAceptar_Click()
        If keyData = Keys.F2 Then bCancelar_Click()
        Return False
    End Function
    Private Sub InputObservacionComanda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = True
        DoEvents()
        xObservacion.Focus()
    End Sub

    Private Sub bAceptar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bAceptar.Click
        Entregas.G_OBSERVACIONCOMANDA = xObservacion.Text.Trim()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub bCancelar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub
    Private Sub InputObservacionComanda_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim ligthBorde = New Rectangle(0, 0, Width - 1, Height - 1)
        Dim borde = New Pen(Color.FromArgb(10, 87, 139), 7)
        e.Graphics.DrawRectangle(borde, ligthBorde)
    End Sub

    Private Sub xObservacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xObservacion.KeyPress
        e.NextControl(bAceptar)
    End Sub
End Class