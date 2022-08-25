Imports System
Imports System.IO
Imports System.Linq
Imports Newtonsoft.Json


Public Class Settings
    Public Property Base As String
    Public Property IPServidorPOS As String
    Public Property IPServidor As String
    Public Property TiempoConexion As Integer
    Public Property NombreCliente As String
    Public Property IdentificadorCliente As String
    Public Property NombreImpresoraTermica As String

    Public Property Local As Decimal
    Public Property NombreLocal As String
    Public Property Caja As Decimal
    Public Property POS As Decimal

    Public Property IVA As Decimal
    Public Property PermisoDescuento As Boolean

    Public Property ImpresoraFrito As String
    Public Property ImpresoraHorno As String
    Public Property CantidadFrito As Integer
    Public Property CantidadHorno As Integer

    Public Property Estado_Amarillo As Integer
    Public Property Estado_Rojo As Integer

    Public Property IngresoAutomatico As Boolean

    Private Const NombreArchivo As String = "settings"

    Public Sub New()
        Base = ""
        IPServidorPOS = ""
        IPServidor = ""
        IdentificadorCliente = ""
        Local = 0
        Caja = 0
        POS = 0
        ImpresoraFrito = ""
        ImpresoraHorno = ""
        CantidadFrito = 0
        CantidadHorno = 0
        IngresoAutomatico = False

        Estado_Amarillo = 10
        Estado_Rojo = 20
    End Sub

    Public Sub Open()
        Dim ruta = $"{Path.GetDirectoryName(Reflection.Assembly.GetEntryAssembly().Location)}/{NombreArchivo}.json"
        Process.Start("notepad.exe", ruta)
    End Sub

    Public Function Check() As Boolean
        If IPServidorPOS = "" Then Return False
        If IPServidor = "" Then Return False
        If Base = "" Then Return False
        If POS = 0 Then Return False
        If Caja = 0 Then Return False
        If Local = 0 Then Return False
        If ImpresoraFrito = "" Then Return False
        If ImpresoraHorno = "" Then Return False
        If IngresoAutomatico = False Then Return False
        Return True
    End Function

    Public Shared Function GetSettings() As String
        Try
            Funciones.CONFIGURACION = LoadConfig(Of Settings)()

            If Funciones.CONFIGURACION Is Nothing Then
                Funciones.CONFIGURACION = New Settings()
                SaveConfig(Funciones.CONFIGURACION)
                Throw New Exception("No se ha establecido una configuración.")
            Else

                If Not Funciones.CONFIGURACION.Check() Then
                    Throw New Exception("Los valores de configuración no son válidos.")
                End If

            End If

        Catch ex As Exception
            Return ex.Message
        End Try

        Return ""
    End Function

    Public Shared Function LoadConfig(Of T)() As T
        Dim ruta = $"{Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)}/"
        Dim d As DirectoryInfo = New DirectoryInfo(Path.GetDirectoryName(ruta))
        Dim Files As FileInfo() = d.GetFiles(Path.GetFileName($"{NombreArchivo}.json"))
        If Files.Length = 0 Then Return Nothing
        Dim archivo = Files.First()
        Dim obj = JsonConvert.DeserializeObject(Of T)(File.ReadAllText(archivo.FullName))
        Return obj
    End Function

    Public Shared Function SaveConfig(Of T)(ByVal obj As T) As String
        Dim json = JsonConvert.SerializeObject(obj, Formatting.Indented)
        Dim nombre = $"{NombreArchivo}.json"
        Dim ruta = $"{Path.GetDirectoryName(Reflection.Assembly.GetEntryAssembly().Location)}/"
        Directory.CreateDirectory(ruta)
        Dim RutaArchivo = $"{ruta}{nombre}"

        Try
            Directory.CreateDirectory(Path.GetDirectoryName(RutaArchivo))
            Try
                File.Delete(RutaArchivo)
            Catch ex As Exception
            End Try

            File.WriteAllText(RutaArchivo, json)
        Catch ex As Exception
            Return ""
        End Try

        Return RutaArchivo
    End Function
End Class
