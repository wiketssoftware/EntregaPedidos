Imports System.ComponentModel
Imports System.Drawing.Printing

Public Class Entregas

    Implements iFormulario
    Public NombreUsuario As String

    Public gTipoDoc As String
    Public gNumDoc As Decimal
    Public gCliente As String

    Public Property G_OBSERVACIONCOMANDA As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.F1 Then xBarra.Focus()
        If keyData = Keys.F5 Then bLimpiar_Click()
        'If keyData = Keys.F8 Then bCancelar_Click()
        If keyData = Keys.F10 Then bImprimir_Click()
        'If keyData = Keys.F2 Then bCancelar_Click()
        Return False
    End Function

    Private Sub IngresarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim resultado = Settings.GetSettings()
        If resultado <> "" Then
            MsgError($"No se puede utilizar Pedidos {vbCrLf}{resultado}.", "Error crítico")
            End
        End If
        Dim wFormAcceso = New Acceso()
        If wFormAcceso.ShowDialog = DialogResult.Cancel Then
            End
        End If
        xLocal.Text = CONFIGURACION.NombreLocal
        'xDescuento.Enabled = CONFIGURACION.PermisoDescuento

        lVersion.Text = "Versión " & VERSION

        xTabla.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        xTabla.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        xTabla.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        bLimpiar_Click()

        Dim DC = New SupermercadoDataContext(P_CONEXION)
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
        xDocumento.Text = If(doc?.NombreDoc.ToUpper(), "")
        xNumero.Text = gNumDoc.ToString
        xCliente.text = gCliente

        If gTipoDoc = "BV" Then
            Dim wBoleta = DC.T_BoGen.FirstOrDefault(Function(x) x.Boleta = gNumDoc.ToDecimal And x.Local = G_LOCALACTUAL)
            If wBoleta IsNot Nothing Then
                xDetalle.Text = Llenar_Detalle(G_LOCALACTUAL, gTipoDoc, gNumDoc)
            End If
        End If

        If gTipoDoc = "FV" Then
            Dim wFactura = DC.T_FvGen.FirstOrDefault(Function(x) x.Factura = gNumDoc.ToDecimal And x.Local = G_LOCALACTUAL)
            If wFactura IsNot Nothing Then
                xDetalle.Text = Llenar_Detalle(G_LOCALACTUAL, gTipoDoc, gNumDoc)
            End If
        End If

        gBotonera.Visible = True
        xBarra.Text = ""
    End Sub

    Private Sub bLimpiar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bLimpiar.Click
        xBarra.Clear()
        xDocumento.Clear()
        xCliente.Clear()
        xNumero.Clear()
        xDetalle.Clear()

        sTablaEntregas.DataSource = New List(Of TablaEntregas)
        gTipoDoc = ""
        gNumDoc = 0
        gCliente = ""
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

    Private Sub bAgregar_Click(sender As Object, e As EventArgs)
        If xBarra.Text.Trim = "" Then
            MsgError("Debe ingresar artículo")
            xBarra.Focus()
            Exit Sub
        End If

        Dim wArticulos = CType(sTablaEntregas.DataSource, List(Of TablaEntregas))

        'Dim wArticuloIngresado = wArticulos.FirstOrDefault(Function(x) x.Articulo = xBarra.Text.ToDecimal())

        'If wArticuloIngresado Is Nothing Then
        '    Dim wArticulo = New TablaEntregas With
        '    {
        '        .Articulo = xBarra.Text.ToDecimal(),
        '        .Descripcion = xDocumento.Text.Trim()
        '    }
        '    wArticulos.Add(wArticulo)

        'End If

        sTablaEntregas.Load(wArticulos)
        xBarra.Clear()
        xDocumento.Clear()
        xBarra.Focus()
        xBarra.Tag = ""
    End Sub

    Private Sub sTablaEntregas_CurrentItemChanged(sender As Object, e As EventArgs) Handles sTablaEntregas.CurrentItemChanged

    End Sub

    Private Sub xAbono_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.NextControl(bEntregar)
    End Sub

    Private Sub bImprimir_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bEntregar.Click

        'If xTabla.Rows.Count = 0 Then
        '    MsgError("Debe ingresar artículos a pedido")
        '    xArticulo.Focus()
        '    Exit Sub
        'End If

        'Dim wFormInput = New InputObservacionComanda()
        'If wFormInput.ShowDialog = DialogResult.Cancel Then
        '    Exit Sub
        'End If

        'Cursor = Cursors.WaitCursor
        'Dim wDC = New SupermercadoDataContext(P_CONEXION)
        'Dim wArticulos = CType(sTablaPedido.DataSource, List(Of TablaPedido))
        'Dim wPedGen = New T_PedGenCoc With
        '{
        '    .FechaPed = Now,
        '    .FechaEnt = dFechaEntrega.Value,
        '    .HoraEnt = dHoraEntrega.Value.ToString("HH:mm"),
        '    .Obs = G_OBSERVACIONCOMANDA,
        '    .Local = CONFIGURACION.Local,
        '    .Garantias = "",
        '    .Piezas = False,
        '    .MontoGar = 0,
        '    .Retira = "L",
        '    .Usuario = P_USUARIO,
        '    .Estado = "P1",
        '    .SubTotal = xTotal.Text.ToDecimal(),
        '    .Descuento = 0,
        '    .Abono = 0,
        '    .Total = xTotal.Text.ToDecimal(),
        '    .GarantiaE = False,
        '    .PiezasE = False,
        '    .AbonoI = 0,
        '    .Cotiza = 0,
        '    .Cliente = "66.666.666-6"
        '}

        'wDC.T_PedGenCoc.InsertOnSubmit(wPedGen)
        'wDC.SubmitChanges()

        'For Each wArticulo In wArticulos
        '    Dim wPedDet = New T_PedDetCoc With
        '    {
        '        .Pedido = wPedGen.Pedido,
        '        .Articulo = wArticulo.Articulo,
        '        .Cantidad = wArticulo.Cantidad,
        '        .Precio = wArticulo.Precio,
        '        .Datos = "",
        '        .Glosa = "",
        '        .Pagina = 0,
        '        .Tomo = 0,
        '        .Dibujo = 0,
        '        .EstadoP = ""
        '    }
        '    wDC.T_PedDetCoc.InsertOnSubmit(wPedDet)
        'Next

        'wDC.SubmitChanges()

        'Dim wImprimirComanda = New Comanda().Generar(wPedGen.Pedido)

        'bLimpiar_Click()
        'Cursor = Cursors.Default
    End Sub

    Private Sub bCancelar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bCancelar.Click
        If Pregunta("¿Desea salir?") Then
            End
        End If
        End
    End Sub

    Private Sub xTabla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles xTabla.CellDoubleClick
        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = 0 Then
            Dim wArticulo = DirectCast(xTabla.Rows(e.RowIndex).DataBoundItem, TablaEntregas)
            Dim wArticulos = CType(sTablaEntregas.DataSource, List(Of TablaEntregas))
            wArticulos.Remove(wArticulo)
            sTablaEntregas.Load(wArticulos)
            xBarra.Focus()
        End If
    End Sub

    Private Sub IngresarPedido_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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
            gCliente = ""
            Exit Sub
        End If

        gTipoDoc = Mid(wDato, 1, 2)
        gNumDoc = (Mid(wDato, 3, 8)).ToDecimal
        gCliente = Mid(wDato, 11, 20)
    End Sub

    Private Sub Ciclo_Tick(sender As Object, e As EventArgs) Handles Ciclo.Tick
        Actualizar_Pedidos(G_LOCALACTUAL)
    End Sub

    Sub Actualizar_Pedidos(wLocal As Decimal)
        Ciclo.Enabled = False
        bActualizar.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        Dim wFecha As Date = Now.Date
        Dim DC = New SupermercadoDataContext(P_CONEXION)
        Dim wTabla = CType(sTablaEntregas.DataSource, List(Of TablaEntregas))

        sTablaEntregas.DataSource = Nothing

        Dim wBoletas = DC.T_BoGen.Where(Function(x) x.Local = wLocal And x.Fecha >= wFecha And x.Estado = "C")
        If wBoletas IsNot Nothing Then
            For Each bol In wBoletas
                Dim wLineas = New TablaEntregas With
                {
                    .Fecha = bol.Fecha,
                    .Local = bol.Local,
                    .TipoDoc = "BOLETA DE VENTA",
                    .NumDoc = bol.Boleta,
                    .Cliente = "",
                    .Entregado = "NO"
                }
                wTabla.Add(wLineas)

                sTablaEntregas.Load(wTabla)
            Next
        End If

        Ciclo.Enabled = True
        bActualizar.Enabled = True
        Me.Cursor = Cursors.Default

        xBarra.Focus()
    End Sub

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        Actualizar_Pedidos(G_LOCALACTUAL)
    End Sub
End Class

Public Class TablaEntregas
    Sub New()
        Fecha = CDate("01/01/2000")
        Local = 0
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
    Public Property TipoDoc As String
    Public Property NumDoc As Double
    Public Property Cliente As String
    Public Property Entregado As String

End Class