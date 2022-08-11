Public Class DatosLocal
    Public Property NombreFantasia As String
    Public Property NombreLocal As String
    Public Property NombreEncargado As String
    Public Property Giro As String
    Public Property Rut As String
    Public Property Direccion As String
    Public Property Ciudad As String
    Public Property Correo As String
    Public Property Telefono As String
    Public Property SSI As String
    Public Property NResolucion As Decimal
    Public Property AñoResolucion As Date
    Public Property VersionSistema As String

    Sub New()
        Dim DC = New SupermercadoDataContext(P_CONEXION)
        Dim wLocal = DC.T_Locales.FirstOrDefault(Function(x) x.Local = CONFIGURACION.Local)
        If wLocal IsNot Nothing Then
            Dim wCiudad = DC.T_Ciudades.FirstOrDefault(Function(x) x.Ciudad = wLocal.Ciudad)
            NombreFantasia = wLocal.NombreFantasia
            NombreLocal = wLocal.RazonLocal
            Giro = wLocal.GiroLocal
            NombreEncargado = ""
            Rut = wLocal.RutLocal
            Direccion = wLocal.DirLocal
            Ciudad = If(wCiudad Is Nothing, "", wCiudad.NombreCiudad)
            Correo = wLocal.EMailLocal
            Telefono = wLocal.TelefonosLocal
            SSI = wLocal.SII
            NResolucion = wLocal.NResolucion
            AñoResolucion = wLocal.FResolucion
            VersionSistema = VERSION
        End If
    End Sub
End Class
