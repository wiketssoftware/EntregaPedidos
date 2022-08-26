Public Class Acceso

    Dim AUTOMATICO As Boolean

    Private Sub Acceso_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim ligthBorde = New Rectangle(0, 0, Width - 1, Height - 1)
        Dim borde = New Pen(Color.FromArgb(10, 87, 139), 5)
        e.Graphics.DrawRectangle(borde, ligthBorde)
    End Sub

    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resultado = Settings.GetSettings()
        If resultado <> "" Then
            MsgError($"No se puede utilizar Pedidos {vbCrLf}{resultado}.", "Error crítico")
            End
        End If

        AUTOMATICO = CONFIGURACION.IngresoAutomatico
        WinDeco2.Visible = AUTOMATICO
        DoEvents()
    End Sub

    Private Sub Acceso_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DoEvents()
        Cursor = Cursors.WaitCursor
        Dim task = ProbarConexionServidor(CONFIGURACION.IPServidor, CONFIGURACION.Base)
        Cursor = Cursors.Default
        If Not task.Result Then
            MsgError($"Error al conectar con la base de datos." & vbCrLf &
                     $"{CONFIGURACION.IPServidor} : {CONFIGURACION.Base}", "Error crítico")
            End
        End If

        If Not CargarLocales() Then
            MsgError("Error al cargar locales.", "Error crítico")
            End
        End If
        cLocal.SelectedValue = CONFIGURACION.Local.ToString()

        'Automatizar
        If AUTOMATICO Then
            xUsuario.Text = "000"
            bIngresar_Click(sender, e)
        End If
    End Sub

    Private Function CargarLocales() As Boolean
        Try
            Dim DC = New SupermercadoDataContext(P_CONEXION)
            Dim locales = DC.T_Locales.Select(Function(x) New With {.ID = CStr(x.Local), .Desc = x.NombreLocal}).ToList
            If Not locales.Any Then Return False
            cLocal.ValueMember = "ID"
            cLocal.DisplayMember = "Desc"
            cLocal.DataSource = locales
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        End
    End Sub

    Private Sub bIngresar_Click(sender As Object, e As EventArgs) Handles bIngresar.Click

        If Not AUTOMATICO Then
            If xUsuario.Text = "" Then
                MsgError("Falta ingresar un Usuario")
                xUsuario.Focus()
                Exit Sub
            End If

            If xPassword.Text = "" Then
                MsgError("Falta ingresar una Clave")
                xPassword.Focus()
                Exit Sub
            End If

            If cLocal.Text = "" Then
                MsgError("Debe seleccionar un Local.")
                cLocal.Focus()
                Exit Sub
            End If
        End If

        Dim wDC = New SupermercadoDataContext(P_CONEXION)
        Dim wUsuario = wDC.T_Usuarios.FirstOrDefault(Function(x) x.Usuario = xUsuario.Text.Trim())

        If wUsuario Is Nothing Then
            MsgError("Usuario no registrado")
            xUsuario.Clear()
            xUsuario.Focus()
            Exit Sub
        End If

        If Not AUTOMATICO Then
            If xPassword.Text <> Descripta(wUsuario.Clave) Then
                MsgError("Contraseña inválida ")
                xPassword.Clear()
                xPassword.Focus()
                Exit Sub
            End If
        End If

        CONFIGURACION.NombreLocal = cLocal.Text.Trim()
        G_USUARIO = wUsuario.Usuario.Trim()
        G_LOCALACTUAL = CONFIGURACION.Local
        DialogResult = DialogResult.OK
        EntregaPedidos.Show()

    End Sub

    Private Sub cLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cLocal.SelectedIndexChanged
        xUsuario.Focus()
    End Sub

    Private Sub xUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xUsuario.KeyPress
        e.NextControl(xPassword)
    End Sub

    Private Sub xPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xPassword.KeyPress
        e.NextControl(bIngresar)
    End Sub
End Class

