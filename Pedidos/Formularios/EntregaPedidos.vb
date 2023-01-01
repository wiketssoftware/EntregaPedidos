Imports System.ComponentModel

Public Class EntregaPedidos

    Implements iFormulario
    Public NombreUsuario As String

    Public gTipoDoc As String
    Public gNumDoc As Decimal

    Const _Boleta = "BOLETA DE VENTA"
    Const _Factura = "FACTURA DE VENTA"

    Public Estado_Amarillo As Decimal
    Public Estado_Rojo As Decimal

    Public Omitir_Local As Decimal

    Public Property G_OBSERVACIONCOMANDA As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.F1 Then Entregar_Pedido(EstadosDoc.Entregada)
        If keyData = Keys.F5 Then Entregar_Pedido(EstadosDoc.NoEstaba)
        If keyData = Keys.F6 Then Entregar_Pedido(EstadosDoc.Removida)
        If keyData = Keys.F7 Then bLimpiar_Click()
        If keyData = Keys.F10 Then Actualizar_Pedidos(G_LOCALACTUAL)

        Return False
    End Function

    Private Sub IngresarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resultado = Settings.GetSettings()
        If resultado <> "" Then
            MsgError($"No se puede utilizar Pedidos {vbCrLf}{resultado}.", "Error crítico")
            End
        End If

        Omitir_Local = 3

        Dim wFormAcceso = New Acceso()
        wFormAcceso.Visible = False
        If wFormAcceso.ShowDialog = DialogResult.Cancel Then
            End
        End If

        Dim DC = New SupermercadoDataContext(P_CONEXION)
        Dim wListaLocales = DC.T_Locales.ToList
        Dim datolocal = wListaLocales.FirstOrDefault(Function(x) x.Local = G_LOCALACTUAL)
        xLocal.Text = If(datolocal Is Nothing, CONFIGURACION.NombreLocal, datolocal.NombreLocal)

        lVersion.Text = "Versión " & VERSION

        Estado_Amarillo = CONFIGURACION.Estado_Amarillo
        Estado_Rojo = CONFIGURACION.Estado_Rojo

        sTablaEntregas.DataSource = New List(Of TablaEntregas)

        Limpiar()

        Dim wPar = DC.T_Locales.FirstOrDefault()
        Try
            Dim MatrizImagen() As Byte = CType(wPar.Logo, Byte())
            Dim ImagenMemoria As New IO.MemoryStream(MatrizImagen)
            If MatrizImagen.Length > 0 Then
                Imagen.Image = Image.FromStream(ImagenMemoria)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CargarRegistro(ByVal wControl As Control, ByVal wValor As String) Implements iFormulario.CargarRegistro
        wControl.Text = wValor
        wControl.Validate
    End Sub

    Private Sub xBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBarra.KeyPress
        'ValidarDigitos(e)
        If e.KeyChar = vbCr Then
            xBarra_Validating(Nothing, Nothing)
        End If
    End Sub

    Private Sub xBarra_Validating(sender As Object, e As CancelEventArgs) Handles xBarra.Validating
        'ValidarDigitos(sender)
        If xBarra.Text.Trim() = "" Then Exit Sub
        Extrae_Datos(xBarra.Text.Trim)
        If gTipoDoc = "" Or gNumDoc = 0 Then
            MsgError("Error en datos de la barra")
            Exit Sub
        End If
        If gTipoDoc <> "FV" And gTipoDoc <> "BV" Then
            MsgError("Tipo de Documento Incorrecto")
            Exit Sub
        End If

        Dim DC = New SupermercadoDataContext(P_CONEXION)
        Dim doc = DC.T_TipoDoc.FirstOrDefault(Function(x) x.TipoDoc = gTipoDoc)
        xDocumento.Text = If(doc?.NombreDoc.ToUpper().Trim, "")
        xNumero.Text = gNumDoc.ToString

        If gTipoDoc = "BV" Then
            Dim wBoleta = DC.T_BoGen.FirstOrDefault(Function(x) x.Boleta = gNumDoc.ToDecimal And (x.Local = 1 Or x.Local = 3))
            If wBoleta IsNot Nothing Then
                xCliente.Text = wBoleta.Observaciones
                xLugar.Text = wBoleta.Local.ToString
                xDetalle.Text = Llenar_Detalle(wBoleta.Local, gTipoDoc, gNumDoc)
            End If
        End If

        If gTipoDoc = "FV" Then
            Dim wFactura = DC.T_FvGen.FirstOrDefault(Function(x) x.Factura = gNumDoc.ToDecimal And (x.Local = 1 Or x.Local = 3))
            If wFactura IsNot Nothing Then
                xCliente.Text = wFactura.Observaciones
                xLugar.Text = wFactura.Local.ToString
                xDetalle.Text = Llenar_Detalle(wFactura.Local, gTipoDoc, gNumDoc)
            End If
        End If

        gBotonera.Visible = True
        xBarra.Text = ""
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        Limpiar()
    End Sub

    Sub Limpiar()
        xBarra.Clear()
        xDocumento.Clear()
        xCliente.Clear()
        xNumero.Clear()
        xDetalle.Clear()
        xLugar.Clear()

        ' sTablaEntregas.DataSource = New List(Of TablaEntregas)

        gTipoDoc = ""
        gNumDoc = 0
        gBotonera.Visible = False
        xBarra.Focus()
    End Sub

    Function Llenar_Detalle(wLocal As Decimal, wTipoDoc As String, wNumDoc As Decimal) As String
        Dim DC = New SupermercadoDataContext(P_CONEXION)
        Llenar_Detalle = ""

        If wTipoDoc = "BV" Then
            Dim wBoleta = DC.T_BoDet.Where(Function(x) x.Boleta = wNumDoc.ToDecimal And x.Local = wLocal)
            If wBoleta IsNot Nothing Then
                For Each bol In wBoleta
                    Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = bol.Articulo)
                    Llenar_Detalle += (bol.Cantidad.ToString & "   " & wArt.Descripcion + vbCrLf)
                Next
            End If
        End If

        If wTipoDoc = "FV" Then
            Dim wFactura = DC.T_FvDet.Where(Function(x) x.Factura = wNumDoc.ToDecimal And x.Local = wLocal)
            If wFactura IsNot Nothing Then
                For Each fac In wFactura
                    Dim wArt = DC.T_Articulos.FirstOrDefault(Function(x) x.Articulo = fac.Articulo)
                    Llenar_Detalle += (fac.CantiFac.ToString & "   " & wArt.Descripcion + vbCrLf)
                Next
            End If
        End If
    End Function

    Private Sub xAbono_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.NextControl(bEntregar)
    End Sub

    Private Sub bCancelar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bCancelar.Click
        If Pregunta("¿Desea salir?") Then
            End
        End If
    End Sub

    'Private Sub xTabla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles xTabla.CellDoubleClick
    '    If e.RowIndex = -1 Then Exit Sub
    '    If e.ColumnIndex = 0 Then
    '        Dim wArticulo = DirectCast(xTabla.Rows(e.RowIndex).DataBoundItem, TablaEntregas)
    '        Dim wArticulos = CType(sTablaEntregas.DataSource, List(Of TablaEntregas))
    '        wArticulos.Remove(wArticulo)
    '        sTablaEntregas.Load(wArticulos)
    '        xBarra.Focus()
    '    End If
    'End Sub

    Private Sub IngresarPedido_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Actualizar_Pedidos(G_LOCALACTUAL)
        xBarra.Focus()
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        xFecha.Text = Date.Now.ToString
    End Sub

    Private Sub xBarra_TextChanged(sender As Object, e As EventArgs) Handles xBarra.TextChanged

    End Sub

    Private Sub Extrae_Datos(wDato As String)
        If wDato.Trim = "" Then
            gTipoDoc = ""
            gNumDoc = 0
            Exit Sub
        End If

        gTipoDoc = Mid(wDato, 1, 2)
        gNumDoc = (Mid(wDato, 3, 8)).ToDecimal
    End Sub

    Private Sub Ciclo_Tick(sender As Object, e As EventArgs) Handles Ciclo.Tick
        Actualizar_Pedidos(G_LOCALACTUAL)
    End Sub

    Sub Actualizar_Pedidos(wLocal As Decimal)
        Ciclo.Enabled = False
        bActualizar.Visible = False
        'Me.Cursor = Cursors.WaitCursor
        xTabla.Visible = False

        Dim wNombreLocal As String, wTipoDoc As String
        Dim wFecha As Date = Now.Date
        Dim DC = New SupermercadoDataContext(P_CONEXION)
        Dim wTabla = New List(Of TablaEntregas)
        Dim wListaLocales = DC.T_Locales.ToList
        Dim Demora As Double

        sTablaEntregas.DataSource = Nothing

        'Omitir_Local Local 3 = WEB, estos no se entregan
        'Omitir_Local = 3

        'Blasoni debe ver local 1 y 3 como 1
        Dim wBoletas = DC.T_BoGen.Where(Function(x) (x.Local = 1 Or x.Local = 2) And x.Fecha >= wFecha And x.Estado = EstadosDoc.Normal And x.Observaciones <> "")
        For Each bol In wBoletas
            DoEvents()

            Dim datolocal = wListaLocales.FirstOrDefault(Function(x) x.Local = bol.Local)
            wNombreLocal = If(datolocal Is Nothing, "", datolocal.NombreLocal)
            wTipoDoc = _Boleta
            Demora = DateDiff(DateInterval.Minute, bol.Fecha, Now)

            Dim wLineas = New TablaEntregas With
                {
                    .Fecha = bol.Fecha,
                    .Local = bol.Local,
                    .TipoDoc = wTipoDoc,
                    .NombreLocal = wNombreLocal,
                    .NumDoc = bol.Boleta,
                    .Cliente = bol.Observaciones,
                    .Tiempo = Demora,
                    .Smile = If(Demora < Estado_Amarillo, My.Resources.smile_bien, If(Demora >= Estado_Rojo, My.Resources.smile_mal, My.Resources.smile_regular)),
                    .Entregado = "NO"
                }
            wTabla.Add(wLineas)
        Next


        Dim wFacturas = DC.T_FvGen.Where(Function(x) (x.Local = 1 Or x.Local = 2) And x.FechaFac >= wFecha And x.Estado = EstadosDoc.Normal And x.Observaciones <> "" And x.POS <> 99)
        For Each fac In wFacturas
            DoEvents()

            Dim datolocal = wListaLocales.FirstOrDefault(Function(x) x.Local = fac.Local)
            wNombreLocal = If(datolocal Is Nothing, "", datolocal.NombreLocal)
            wTipoDoc = _Factura
            Demora = DateDiff(DateInterval.Minute, fac.FechaFac, Now)

            Dim wLineas = New TablaEntregas With
                {
                    .Fecha = fac.FechaFac,
                    .Local = fac.Local,
                    .TipoDoc = wTipoDoc,
                    .NombreLocal = wNombreLocal,
                    .NumDoc = fac.Factura,
                    .Cliente = fac.Observaciones,
                    .Tiempo = Demora,
                    .Smile = If(Demora < Estado_Amarillo, My.Resources.smile_bien, If(Demora >= Estado_Rojo, My.Resources.smile_mal, My.Resources.smile_regular)),
                    .Entregado = "NO"
                }
            wTabla.Add(wLineas)
        Next

        sTablaEntregas.Load(wTabla)
        Pintar_Grilla()

        Ciclo.Enabled = True
        bActualizar.Visible = True
        'Me.Cursor = Cursors.Default
        xTabla.Visible = True
        xBarra.Focus()
    End Sub

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        Actualizar_Pedidos(G_LOCALACTUAL)
    End Sub

    Private Sub bEntregar_Click(sender As Object, e As EventArgs) Handles bEntregar.Click
        Entregar_Pedido(EstadosDoc.Entregada)
    End Sub

    Sub Entregar_Pedido(wModo As String)
        If Val(xNumero.Text) = 0 Or xDocumento.Text.Trim = "" Or xLugar.Text = "" Then
            Exit Sub
        End If

        Dim Ventana As New Aviso
        Ventana.Show()
        Ventana.BringToFront()

        Dim DC = New SupermercadoDataContext(P_CONEXION)
        If xDocumento.Text.Trim = _Boleta Then
            Dim wBoleta As New T_BoGen
            Dim qBoleta = DC.T_BoGen.FirstOrDefault(Function(x) x.Boleta = xNumero.Text.ToDecimal And x.Local = xLugar.Text.ToDecimal)

            If qBoleta IsNot Nothing Then
                wBoleta = qBoleta
                wBoleta.Estado = wModo

                If wModo <> EstadosDoc.Removida Then
                    Dim wEntregas As New T_Entregas
                    Dim qEntregas = DC.T_Entregas.FirstOrDefault(Function(x) x.TipoDoc = "BV" And x.NumDoc = xNumero.Text.ToDecimal And x.Local = xLugar.Text.ToDecimal)
                    If qEntregas IsNot Nothing Then
                        wEntregas = qEntregas
                    End If

                    Ventana.BringToFront()


                    wEntregas.Local = xLugar.Text.ToDecimal
                    wEntregas.TipoDoc = "BV"
                    wEntregas.NumDoc = xNumero.Text.ToDecimal
                    wEntregas.FechaEmi = wBoleta.Fecha
                    wEntregas.FechaEnt = Now
                    wEntregas.Usuario = "SYS"
                    wEntregas.Entregado = wModo

                    If qEntregas Is Nothing Then
                        DC.T_Entregas.InsertOnSubmit(wEntregas)
                    End If
                End If

                DC.SubmitChanges()
                Limpiar()

                Ventana.Show()
                Ventana.BringToFront()

                Actualizar_Pedidos(G_LOCALACTUAL)

            Else
                MsgError("Boleta no encontrada")
            End If
        End If

        If xDocumento.Text.Trim = _Factura Then
            Dim wFactura As New T_FvGen
            Dim qFactura = DC.T_FvGen.FirstOrDefault(Function(x) x.Factura = xNumero.Text.ToDecimal And x.Local = xLugar.Text.ToDecimal)

            If qFactura IsNot Nothing Then
                wFactura = qFactura
                wFactura.Estado = CChar(wModo)
                DC.SubmitChanges()

                If wModo <> EstadosDoc.Removida Then
                    Dim wEntregas As New T_Entregas
                    Dim qEntregas = DC.T_Entregas.FirstOrDefault(Function(x) x.TipoDoc = "FV" And x.NumDoc = xNumero.Text.ToDecimal And x.Local = xLugar.Text.ToDecimal)
                    If qEntregas IsNot Nothing Then
                        wEntregas = qEntregas
                    End If

                    Ventana.BringToFront()

                    wEntregas.Local = xLugar.Text.ToDecimal
                    wEntregas.TipoDoc = "FV"
                    wEntregas.NumDoc = xNumero.Text.ToDecimal
                    wEntregas.FechaEmi = wFactura.FechaFac
                    wEntregas.FechaEnt = Now
                    wEntregas.Usuario = "SYS"
                    wEntregas.Entregado = wModo

                    If qEntregas Is Nothing Then
                        DC.T_Entregas.InsertOnSubmit(wEntregas)
                    End If
                End If

                DC.SubmitChanges()
                Limpiar()

                Ventana.Show()
                Ventana.BringToFront()

                Actualizar_Pedidos(G_LOCALACTUAL)

            Else
                MsgError("Factura no encontrada")
            End If
        End If

    End Sub

    Private Sub xFecha_GotFocus(sender As Object, e As EventArgs) Handles xFecha.GotFocus, xLocal.GotFocus, xDocumento.GotFocus, xNumero.GotFocus, xCliente.GotFocus
        xBarra.Focus()
    End Sub

    Private Sub bLimpiar2_Click(sender As Object, e As EventArgs) Handles bLimpiar2.Click
        Limpiar()
    End Sub

    Sub Pintar_Grilla()
        Dim DC = New SupermercadoDataContext(P_CONEXION)
        Dim documentos = CType(sTablaEntregas.DataSource, List(Of TablaEntregas))
        Dim Demora As Decimal

        Try
            Dim wFila As Integer = 0
            For Each dato In documentos
                DoEvents()
                If dato IsNot Nothing Then
                    Demora = DateDiff(DateInterval.Minute, dato.Fecha, Now)
                    If Demora >= Estado_Amarillo And Demora < Estado_Rojo Then
                        xTabla.Rows(wFila).DefaultCellStyle.BackColor = Color.Yellow
                    End If
                    If Demora >= Estado_Rojo Then
                        xTabla.Rows(wFila).DefaultCellStyle.BackColor = Color.FromArgb(255, 222, 144)
                    End If
                End If
                wFila += 1
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub xTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles xTabla.CellContentClick
        If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub

        Dim documento = DirectCast(xTabla.CurrentRow.DataBoundItem, TablaEntregas)
        xBarra.Text = If(documento.TipoDoc.Trim = _Boleta, "BV", "FV") & Strings.Right(("00000000" & documento.NumDoc), 8).Trim
        xBarra_Validating(sender, Nothing)

    End Sub

    Private Sub xDocumento_TextChanged(sender As Object, e As EventArgs) Handles xDocumento.TextChanged

    End Sub

    Private Sub bPendiente_Click(sender As Object, e As EventArgs) Handles bPendiente.Click
        Entregar_Pedido(EstadosDoc.NoEstaba)
    End Sub

    Private Sub bSacar_Click(sender As Object, e As EventArgs) Handles bSacar.Click
        Entregar_Pedido(EstadosDoc.Removida)
    End Sub
End Class

Public Class TablaEntregas
    Sub New()
        Fecha = CDate("01/01/2000")
        Local = 0
        NombreLocal = ""
        TipoDoc = ""
        NumDoc = 0
        Cliente = ""
    End Sub

    Public ReadOnly Property Eliminar As Image
        Get
            Return My.Resources.Resources.remove_table
        End Get
    End Property

    Public Property Fecha As DateTime
    Public Property Local As Decimal
    Public Property NombreLocal As String
    Public Property TipoDoc As String
    Public Property NumDoc As Double
    Public Property Cliente As String
    Public Property Tiempo As Double
    Public Property Smile As Image
    Public Property Entregado As String

End Class