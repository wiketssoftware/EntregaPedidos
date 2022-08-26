Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.Integration
Imports LibMsg

Module Funciones
    Public MaxDouble As Double = 999999999999999 '15 dígitos / Máximo para evitar notación científica en conversión
    Public Const P_EMPRESA As String = "Wikets Software"
    Public Const P_SISTEMA As String = "MarketONE"
    Public Const VERSION As String = "1.1"
    Public G_LOCALACTUAL As Decimal
    Public G_USUARIO As String
    Public G_BODEGA As Decimal
    Public Const FechaDespliegue As String = "26/04/2020"
    Public CONFIGURACION As Settings
    Public Const PATRONCONEXION As String = "Data Source={0};Initial Catalog={1};User ID=wikets;Password=software"

    Public ReadOnly Property P_CONEXION As String
        Get
            Return String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID=wikets;Password=software", CONFIGURACION.IPServidor, CONFIGURACION.Base)
        End Get
    End Property

    Public Function SQL(ByVal wQuery As String) As DataTable
        Dim dataTable As DataTable = New DataTable()

        Try

            Using sqlConnection As SqlConnection = New SqlConnection(P_CONEXION)
                sqlConnection.Open()

                Using selectCommand As SqlCommand = New SqlCommand(wQuery, sqlConnection)

                    Using sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(selectCommand)
                        sqlDataAdapter.Fill(dataTable)
                    End Using
                End Using

                SqlConnection.ClearPool(sqlConnection)
            End Using

            Return dataTable
        Catch __unusedException1__ As Exception
            Return Nothing
        End Try
    End Function


    Function NextID(ByVal table As String) As Decimal
        Return If(SQL("SELECT (IDENT_CURRENT('" & table & "') + IDENT_INCR('" & table & "')) AS ID").Top()?.GetDecimal("ID"), 1D)
    End Function
    <Extension()>
    Public Sub NextControl(ByVal wOrigen As KeyPressEventArgs, wDestino As Control)
        If wOrigen.KeyChar = vbCr Then
            wDestino.Focus()
        End If
    End Sub
    <Extension>
    Public Sub NextControl(ByRef WOrigen As KeyEventArgs, ByRef WDestino As Control)
        If WOrigen.KeyCode = Keys.Enter Then
            WDestino.Focus()
        End If
    End Sub
    <Extension>
    Public Function ToDouble(ByRef Texto As TextBox) As Double
        Dim wTexto = Texto.Text
        Return If(IsNumeric(wTexto), wTexto.ToDecimal, 0)
    End Function

    <Extension>
    Public Sub TrimText(ByRef Texto As TextBox)
        Texto.Text = Texto.Text.Trim()
    End Sub

    <Extension>
    Public Function ToDouble(ByRef Texto As String) As Double
        Return If(IsNumeric(Texto), Convert.ToDouble(Texto.ToDecimal), 0)
    End Function
    <Extension>
    Public Function ToDecimal(ByRef Texto As TextBox) As Decimal
        Return Texto.Text.ToDecimal
    End Function

    <Extension()>
    Public Function ToDecimal(ByVal texto As String, ByVal Optional precision As Integer = 0, ByVal Optional truncar As Boolean = False) As Decimal
        Dim result = ""

        result = New String(texto.Where(Function(x) Char.IsDigit(x) OrElse New Char() {","c, "."c}.Contains(x)).ToArray())

        result = $"{If(texto.Length > 0, (If(texto(0) = "-", "-", "")), "")}{result}"

        If result.Contains(",") AndAlso result.Contains(".") Then
            result = result.Replace(".", "").Replace(",", ".")
        ElseIf result.Contains(",") Then
            result = result.Replace(",", ".")
        ElseIf result.Contains(".") Then
            result = result.Replace(".", "")
        End If

        If result.Where(Function(x) x = ","c).Count > 1 Then
            Return 0D
        End If
        If result.Where(Function(x) x = "."c).Count > 1 Then
            Return 0D
        End If

        'Validacion
        If truncar Then
            Return If(result = "", 0D, Truncate(Convert.ToDecimal(result, New CultureInfo("en-us")), precision))
        Else
            Return If(result = "", 0D, Math.Round(Convert.ToDecimal(result, New CultureInfo("en-us")), precision, MidpointRounding.AwayFromZero))
        End If
    End Function


    <Extension()>
    Public Function ToDecimal(ByVal num As Decimal, ByVal Optional precision As Integer = 0, ByVal Optional truncate As Boolean = False) As Decimal
        Return num.ToString("G29").ToDecimal(precision, truncate)
    End Function

    <Extension()>
    Public Function ToDecimal(ByVal num As Double, ByVal Optional precision As Integer = 0, ByVal Optional truncate As Boolean = False) As Decimal
        Return num.ToString("G29").ToDecimal(precision, truncate)
    End Function

    Public Function Truncate(ByVal valor As Decimal, ByVal precision As Integer) As Decimal
        Dim multiplo As Decimal = Convert.ToDecimal(Math.Pow(10, precision))
        Dim resultado As Decimal = Math.Truncate(multiplo * valor)
        Return (resultado / multiplo)
    End Function
    <Extension>
    Public Function ToInteger(ByRef Texto As TextBox) As Integer
        Return If(IsNumeric(Texto), Convert.ToInt32(Texto.Text), 0)
    End Function
    <Extension>
    Public Function ToInteger(ByRef Texto As String) As Integer
        Return If(IsNumeric(Texto), Convert.ToInt32(Texto), 0)
    End Function

    Public Enum NumericFormat
        Normal
        Money
    End Enum

    <Extension>
    Public Function ToText(ByRef Numero As TextBox, Formato As NumericFormat, Optional Precision As Integer = 0) As String
        Dim Dec = If(IsNumeric(Numero.Text), Convert.ToDecimal(Numero.Text), 0)
        Return Dec.ToText(Formato, Precision)
    End Function

    <Extension>
    Public Function ToText(ByRef Numero As Double, Formato As NumericFormat, Optional Precision As Integer = 0) As String
        Dim Dec = Convert.ToDecimal(Numero)
        Return Dec.ToText(Formato, Precision)
    End Function

    <Extension>
    Public Function ToText(ByRef Numero As Decimal, Formato As NumericFormat, Optional Precision As Integer = 0) As String
        Dim wPartes() As String
        Dim wDecimal As String = ""
        Dim wEntero As String = ""
        Dim wFormato As String = ""
        Dim wCondicion As String = ""
        Numero = Math.Round(Numero, Precision, MidpointRounding.AwayFromZero)

        If InStr(Numero.ToString, ".") > 0 Then
            wPartes = Numero.ToString.Split(CType(".", Char()))
            wDecimal = wPartes(1).ToString
            wEntero = wPartes(0).ToString
        Else
            wEntero = Numero.ToString
        End If

        wFormato = FormatNumber(wEntero, 0,,, TriState.True).Replace(",", ".").ToString

        Return If(wDecimal = "", wFormato, wFormato & "," & wDecimal)
    End Function

    <Extension()>
    Public Function ToMoney(ByVal num As Decimal) As String
        Dim text As String = num.ToString("G29")
        Dim str As String = ""

        If text.Contains(".") Then
            Dim array As String() = text.Split("."c)
            str = "," & array(1)
        End If

        Return num.ToString("#,##0").Replace(",", ".") & str
    End Function
    <Extension()>
    Public Function ToMoney(ByVal num As Double) As String
        Dim text As String = num.ToString("G29")
        Dim str As String = ""

        If text.Contains(".") Then
            Dim array As String() = text.Split("."c)
            str = "," & array(1)
        End If

        Return num.ToString("#,##0").Replace(",", ".") & str
    End Function

    Public ReadOnly Property P_IMPRESORAFRITO As String
        Get
            Return CONFIGURACION.ImpresoraFrito
        End Get
    End Property

    Public ReadOnly Property P_IMPRESORAHORNO As String
        Get
            Return CONFIGURACION.ImpresoraHorno
        End Get
    End Property

    Public ReadOnly Property P_CANTIDADFRITO As Integer
        Get
            Return CONFIGURACION.CantidadFrito
        End Get
    End Property

    Public ReadOnly Property P_CANTIDADHORNO As Integer
        Get
            Return CONFIGURACION.CantidadHorno
        End Get
    End Property

    Public Sub ValidarDigitos(ByRef e As KeyPressEventArgs, Optional ByRef decimales As Boolean = False)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            If e.KeyChar = ","c And decimales Then
                e.Handled = False
                Exit Sub
            End If
            e.Handled = True
        End If
    End Sub

    Public Sub ValidarDigitosDecimal(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = CChar(",") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Public Sub ValidarDigitos(ByRef sender As Object, Optional ByVal wPosicionesDecimales As Integer = 3)
        If sender Is Nothing Then Exit Sub
        Dim wTextBox As TextBox = DirectCast(sender, TextBox)
        Trim(wTextBox.Text)
        If wTextBox.Text <> "" AndAlso Not wTextBox.Text = "0" Then
            Dim wValor As Double = Val(wTextBox.Text.Replace(",", "."))
            wValor.Validar(wPosicionesDecimales)
            wTextBox.Text = IIf(wValor = 0, "", wValor).ToString
        End If
    End Sub
    <Extension()>
    Public Function Validar(ByRef wValor As Double, Optional ByVal wPosicionesDecimales As Integer = 3) As Double
        Try
            wValor = Decimal.Round(CInt(wValor), wPosicionesDecimales, MidpointRounding.AwayFromZero)
            If wValor > MaxDouble Then wValor = MaxDouble
        Catch ex As OverflowException
            wValor = MaxDouble
        End Try
        Return wValor
    End Function

    <Extension()>
    Function Top(ByVal wTabla As DataTable) As DataRow
        If wTabla.Rows.Count = 0 Then
            Return Nothing
        End If

        Return wTabla.Rows(0)
    End Function

    <Extension()>
    Function GetText(ByVal wFila As DataRow, ByVal wCampo As String) As String
        Return wFila(wCampo).ToString().Trim()
    End Function
    <Extension()>
    Function GetValue(ByVal wFila As DataRow, ByVal wCampo As String) As Object
        Return wFila(wCampo)
    End Function
    <Extension()>
    Function GetNum(ByVal wFila As DataRow, ByVal wCampo As String) As Double
        Return wFila(wCampo).ToString().ToDouble()
    End Function
    <Extension()>
    Function GetDate(ByVal wFila As DataRow, ByVal wCampo As String) As DateTime
        Return CDate(wFila(wCampo))
    End Function

    <Extension()>
    Function GetInt(ByVal wFila As DataRow, ByVal wCampo As String) As Integer
        Return Convert.ToInt32(wFila(wCampo))
    End Function

    <Extension()>
    Function GetBool(ByVal wFila As DataRow, ByVal wCampo As String) As Boolean
        Return Convert.ToBoolean(wFila(wCampo))
    End Function
    <Extension>
    Function GetDecimal(ByRef wFila As DataRow, wCampo As String, Optional precision As Integer = 0) As Decimal
        Return wFila.Item(wCampo).ToString.ToDecimal(precision)
    End Function
    Public Sub DoEvents()
        Application.DoEvents()
    End Sub

    Public Sub MsgError(ByVal wError As String, Optional wTitulo As String = "Error")
        Dim _mensaje = New Msg()
        _mensaje.Mostrar(wTitulo, wError, TipoMensaje.Error, LibMsg.Ubicacion.Centrado)
        ElementHost.EnableModelessKeyboardInterop(_mensaje)
        _mensaje.ShowDialog()
    End Sub

    Public Sub Mensaje(ByVal wMensaje As String, Optional wTitulo As String = "Mensaje")
        Dim wMsg = New Msg
        wMsg.Mostrar(wTitulo, wMensaje, TipoMensaje.Ok, LibMsg.Ubicacion.Centrado)
        wMsg.ShowDialog()
    End Sub

    Public Function Pregunta(ByVal wMensaje As String, Optional wTitulo As String = "Pregunta") As Boolean
        Dim wMsg = New Msg
        wMsg.Mostrar(wTitulo, wMensaje, TipoMensaje.Confirmacion, LibMsg.Ubicacion.Centrado)
        wMsg.ShowDialog()
        Return wMsg.DialogResult.Value
    End Function
    Public Function PreguntaAdvertencia(ByVal wMensaje As String, Optional wTitulo As String = "Advertencia") As Boolean
        Dim wMsg = New Msg
        wMsg.Mostrar(wTitulo, wMensaje, TipoMensaje.Advertencia, LibMsg.Ubicacion.Centrado)
        wMsg.ShowDialog()
        Return wMsg.DialogResult.Value
    End Function
    Public Sub Informacion(ByVal wMensaje As String, Optional Titulo As String = "Información")
        Dim wMsg = New Msg
        wMsg.Mostrar(Titulo, wMensaje, TipoMensaje.Info, LibMsg.Ubicacion.Centrado)
        wMsg.ShowDialog()
    End Sub

    Private Function Ping(ip As String) As Boolean
        Try
            Dim pg = New Net.NetworkInformation.Ping()
            Dim resultado = pg.Send(ip, CInt(CONFIGURACION.TiempoConexion / 2) * 1000)
            Return resultado.Status = Net.NetworkInformation.IPStatus.Success
        Catch ex As Net.Sockets.SocketException
            Return False
        End Try
    End Function

    Private Function ProbarConexion(ip As String, base As String) As Boolean
        Dim resultado = IgnoreErrors(Function() ProbarConexionEx(ip, base), False)
        Return resultado
    End Function

    Private Function ProbarConexionEx(ip As String, base As String) As Boolean
        Dim conexion As String = String.Format(PATRONCONEXION, ip, base)
        Dim DC As New SupermercadoDataContext(conexion)
        Try
            DC.ExecuteCommand("SELECT 1")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function IgnoreErrors(Of T)(ByVal operation As Func(Of T), ByVal Optional defaultValue As T = Nothing) As T
        If operation Is Nothing Then Return defaultValue
        Dim result As T
        Try
            result = operation.Invoke()
        Catch
            result = defaultValue
        End Try
        Return result
    End Function

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Function ProbarConexionServidor(Servidor As String, base As String) As RespuestaServidor


        Dim ServidorPing = Servidor
        If (Servidor.Contains(",") Or Servidor.Contains("\")) Then
            ServidorPing = Servidor.Replace(",", "~").Replace("\", "~").Split("~"c)(0)
        End If

        Dim timeout = TimeSpan.FromSeconds(CONFIGURACION.TiempoConexion)

        Dim pruebaConexion = New Task(Of RespuestaServidor) _
            (Function()
                 Dim intentoConexion = New Task(Of Boolean) _
                    (Function()
                         Try
                             If Not Ping(ServidorPing) Then Return False
                             ProbarConexion(Servidor, base)
                             Return True
                         Catch e As Exception
                             Return False
                         End Try
                     End Function, TaskCreationOptions.LongRunning)

                 intentoConexion.Start()

                 If intentoConexion.Wait(timeout) Then
                     If intentoConexion.Result Then
                         Return New RespuestaServidor() With {.Resultado = ResultadoConexion.Correcto}
                     Else
                         Return New RespuestaServidor() With {.Resultado = ResultadoConexion.ErrorConexion}
                     End If
                 End If
                 Return New RespuestaServidor() With {.Resultado = ResultadoConexion.TiempoAgotado}

             End Function)

        pruebaConexion.Start()
        pruebaConexion.Wait()

        Return pruebaConexion.Result
    End Function

    Public Function Descripta(ByRef wCadena As String) As String
        Dim Descriptado As String
        Dim X As Integer
        Dim AUX As String

        wCadena = Trim(wCadena)
        Descriptado = ""
        AUX = " "
        For X = 1 To Len(wCadena)
            AUX = Mid(wCadena, X, 1)
            Descriptado = Descriptado & Chr(CInt((Asc(AUX) / 2) - 2))
        Next X
        Return Descriptado
    End Function

    <Extension()>
    Public Sub Load(Source As BindingSource, Lista As Object)
        Source.DataSource = Nothing
        Source.DataSource = Lista
    End Sub

    Public Function ObtenerPrecio(ByVal wArticulo As String, ByVal wCantidad As Decimal, Optional ByVal IgnorarCliente As Boolean = False) As Double
        Dim PorBarra As Boolean
        Dim nBarra As Object
        Dim pImp As Double

        If Val(wArticulo) = 0 Or wArticulo = "999999" Then
            Return 0
        End If

        PorBarra = False
        nBarra = wArticulo
        If Val(wArticulo) > 999999 Then
            nBarra = wArticulo
            PorBarra = True
        End If

        If PorBarra Then
            'Precio por Barra, si no lo encuentra, buscara por articulo
            Dim PrecioEspecial As Double = 0
            Dim wArt = SQL($"Select Articulo,PVentaMin,PVentaMay,PVentaDis,MarMinorista,MarMayorista,Especial,CantBarra from Barras where Barra = '{wArticulo}'").Top()
            If wArt IsNot Nothing Then
                PrecioEspecial = 0
                wArt = SQL("Select Articulo, PVenta1 As PVentaMin, PVenta1 As PVentaMay, PVenta1 As PVentaDis " &
                                            " FROM Costos where Articulo = '" & wArticulo.Trim().Substring(2, 5) & "' ORDER BY FechaUltCompra Desc").Top()
                If Len(wArticulo) = 13 And Mid(wArticulo, 1, 2) = "24" Or Mid(wArticulo, 1, 2) = "25" Then
                    wArticulo = wArticulo.Substring(3, 5)
                End If
                GoTo Por_Articulo
            Else
                PrecioEspecial = wArt.GetDecimal("Especial")
                If wArt.GetDecimal("CantBarra") > 1 Then
                    PrecioEspecial = wArt.GetDecimal("PVentaMin")
                End If
            End If
            If wArt IsNot Nothing Then
                Dim wCos = SQL("Select * from Costos Where Articulo = " & wArt.GetDecimal("Articulo") & " ORDER BY FechaUltCompra Desc").Top

                If PrecioEspecial = 0 Then
                    pImp = If(wCos IsNot Nothing, wCos.GetDecimal("Impto1"), 0)
                    'If wCos.Rows.Count > 0 AndAlso (G_CLAVE_CLIENTE = "A" Or G_CLAVE_CLIENTE = "C") Then
                    If wCos IsNot Nothing Then
                        'Si la barra tiene margen mayorista, entonces usar el valor de la barra, caso contrario usar el valor mayorista del costo
                        If wCantidad >= wCos.GetDecimal("MinMayorista") And wCos.GetDecimal("MinMayorista") > 1 Then
                            If wArt.GetDecimal("MarMayorista") > 0 Then
                                Return Precio_Final(wArt.GetDecimal("PVentaMay"), pImp, False)
                            Else
                                Return Precio_Final(wCos.GetDecimal("PVenta2"), pImp, False)
                            End If
                        Else
                            If wArt.GetDecimal("MarMinorista") > 0 Then
                                Return Precio_Final(wArt.GetDecimal("PVentaMin"), pImp, False)
                            Else
                                If wCos.GetDecimal("PrecioOferta" & CONFIGURACION.Local) > 0 Then
                                    PrecioEspecial = wCos.GetDecimal("PrecioOferta" & CONFIGURACION.Local)
                                Else
                                    PrecioEspecial = wCos.GetDecimal("PVenta1")
                                End If
                                Return Precio_Final(PrecioEspecial, pImp, False)
                            End If
                        End If
                        Return Precio_Final(wArt.GetDecimal("PVentaMin"), pImp, False)
                    End If
                Else
                    Return Precio_Final(PrecioEspecial, 0, False)
                End If
            End If
            ' Buscar Precio Normal de Venta segun los Costos
            GoTo Por_Articulo
        Else
Por_Articulo:'Si el Producto viene en codigo barra y esta en oferta y ademas cliente es traspaso
            'Buscar Precio Normal de Venta segun los Costos, Ver si es receta o no
            Dim wArt As DataRow = Nothing
            If IsNumeric(wArticulo) Then
                wArt = SQL("SELECT Articulo, ConReceta FROM Articulos WHERE Articulo= " & wArticulo).Top
            End If
            If wArt IsNot Nothing Then
                'Si el producto es receta, sacar su valor de venta
                If wArt.GetBool("ConReceta") Then
                    Dim ReG = SQL("SELECT PVenta1, Pventa2,Pventa3,Pnuevo1,Pnuevo2,Pnuevo3 FROM Recetas WHERE Receta ={0}" & wArticulo).Top()
                    If ReG IsNot Nothing Then
                        Return ReG.GetDecimal("PVenta1")
                    Else
                        Return 0
                    End If
                Else
                    'Producto normal
                    wArt = SQL("Select Pventa1,PVenta2,PVenta3,PrecioOferta0,PrecioOferta1,PrecioOferta2,PrecioOferta3,PrecioOferta4,PrecioOferta5,PrecioOferta6," &
                                " PrecioOferta7,PrecioOferta8,PrecioOferta9,PrecioOferta10,Impto1,MinMayorista from Costos Where Articulo = " & wArticulo &
                                " ORDER BY FechaUltCompra Desc").Top()

                    If wArt Is Nothing Then Return 0  'No se encontro el articulo

                    pImp = wArt.GetDecimal("Impto1")

                    If CONFIGURACION.IdentificadorCliente = "A" Or CONFIGURACION.IdentificadorCliente = "C" Then
                        If wCantidad >= wArt.GetDecimal("MinMayorista") And wArt.GetDecimal("MinMayorista") > 1 Then
                            Return Precio_Final(wArt.GetDecimal("PVenta2"), pImp, False)
                        End If
                    End If

                    'Retornar Precio de Venta si tiene uno especifico por local, si no, entregar precio normal
                    If (CONFIGURACION.Local >= 0 And CONFIGURACION.Local <= 10) AndAlso wArt.GetDecimal("PrecioOferta" & CONFIGURACION.Local) > 0 Then
                        Return Precio_Final(wArt.GetDecimal("PrecioOferta" & CONFIGURACION.Local), pImp, False)
                    Else
                        Return wArt.GetDecimal("PVenta1")
                    End If

                End If
            End If
            Return 0
        End If
    End Function

    Function Precio_Final(ByVal pPrecio As Double, ByVal pImto As Double, ByVal pRecetas As Boolean) As Double
        Dim pValor As Double

        If pRecetas Then
            If pImto = 0 Then
                Return pPrecio
            End If
            If Val(pImto) = 0 Then
                Return pPrecio
            End If
            Return pPrecio
        Else
            Dim wImpuesto = SQL("Select * from Impuestos where Impuesto = " & pImto).Top()
            If wImpuesto IsNot Nothing Then
                If wImpuesto.GetText("TipoImp") = "ICAR" Or wImpuesto.GetText("TipoImp") = "IHA" Then
                    pValor = Math.Round(pPrecio / (1 + (CONFIGURACION.IVA / 100)), 2)
                    Return Math.Round(pValor + (pValor * (CONFIGURACION.IVA / 100)) + (pValor * (wImpuesto.GetDecimal("Porcentaje") / 100)))
                Else
                    Return pPrecio
                End If
            Else
                Return pPrecio
            End If
        End If
    End Function

    Private ReadOnly onValidating As MethodInfo = GetType(Control).GetMethod("OnValidating", BindingFlags.Instance Or BindingFlags.NonPublic)
    Private ReadOnly onValidated As MethodInfo = GetType(Control).GetMethod("OnValidated", BindingFlags.Instance Or BindingFlags.NonPublic)

    <System.Runtime.CompilerServices.Extension>
    Public Function Validate(control As Control) As Boolean
        Dim e As New CancelEventArgs()
        onValidating.Invoke(control, New Object() {e})
        If e.Cancel Then
            Return False
        End If
        onValidated.Invoke(control, New Object() {EventArgs.Empty})
        Return True
    End Function
End Module

Public Enum ResultadoConexion
    Correcto = 0
    ErrorConexion = 1
    TiempoAgotado = 2
End Enum

Public Structure EstadosDoc
    Public Const Anulada As String = "A"
    Public Const Normal As String = "C"
    Public Const Entregada As String = "E"
End Structure

Public Class RespuestaServidor
    Public Resultado As ResultadoConexion
    Public ReadOnly Property IsCompleted As Boolean
        Get
            Return Resultado = ResultadoConexion.Correcto Or
                        Resultado = ResultadoConexion.ErrorConexion
        End Get
    End Property

    Public ReadOnly Property Result As Boolean
        Get
            Return Resultado = ResultadoConexion.Correcto
        End Get
    End Property

End Class