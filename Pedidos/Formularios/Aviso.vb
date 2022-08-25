Public Class Aviso
    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        Me.Close()
    End Sub

    Private Sub Aviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoEvents()
    End Sub
End Class