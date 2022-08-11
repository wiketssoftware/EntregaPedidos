Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.CompilerServices
Public Class SearchButton
    Inherits Button

    Public Delegate Sub ItemSearched(ByVal wItem As String)
    Public Event ItemSearch(wDescripcion As String)
    Public _Form As iFormulario
    Public _ControlCargar As Control
    Public _ControlFocus As Control
    Public _Titulo As String
    Public _Tabla As String = ""
    Public _IDBusqueda As String = ""
    Public _CampoBuscar1 As String = ""
    Public _CampoBuscar2 As String = ""
    Public _CamposAdicionales As String = ""
    Public _Filtros As String = ""
    Public _Formato As Integer() = {16, 24, 32}
    Public _SizeIcon As TamañoIcono = TamañoIcono.Size16
    Private _Icono16 As String = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAACXBIWXMAAA7EAAAOxAGVKw4bAAABzElEQVQ4jZWRT0gUYRjGf5+7FDL9MwfcEIoywg6TiZCgYMzBoDwEwu6l41y81LWLVEh7CULIgyBO4EmclQLJQ1JaLISHhGQuA0tBQTDLDgTJkP2Rt0M7w+w6C/meXvie5/e+z/cqEaFVqbHSJDAOnAV+AJto+rQ4ZjnWpAGU5Q7ie5styZr+RhzTTAUoyz2P71X+6TR5fu+GGu6BYBeKy1+ZW3wXQcrimCP7AWMlH+gauNy99744lAEigQKkEsKFQknVIdcaAKqwcYkw2AaQ1bxEpiQA4I7jq5mFMsDLbFO6UYCRq8Y3oCNhJNk/yOeYWQBguBlwAqC7o/1PfVrqBidVDD3SDPgE8MqttsEZWtVWNW6/NAKO6kuEwdPax8+dIVd+aXAoLcL4w9fRdiv7r1DYWCMMRgF2V/O/D0M2YZabjz/IynqlDQBNP9Z4Bcu18L35JPD0xXO16/25TO37z8yzF1vH44dcb0FsoxQDlOVO4HuzsUDTtwmDvpQv2CPXa4ptlKG+nrLc2/jekwT9kdjGXWW5OjvBLaAH2AHeimOuNUQmvz5BGMwmzEWxjcmUyamVJQyKCfN9sY2p/zVHEU4BVTR9Smxj+iBmgL8w7a3hmRcHVwAAAABJRU5ErkJggg=="
    Private _Icono24 As String = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAACXBIWXMAAA7EAAAOxAGVKw4bAAADL0lEQVRIia2VX4hUdRTHP+fcO7Kstrn4LyGVwrS/UIRbPmzRw2rodV5yIaeBMIuioHrJwDCLTdwCWUhwjV6Cxkmoh5hGd4sEWx80S4pyqQ1L+iMsLOTmmDXO3fPr4c7o3dm5u1N5nu79wfn+O+f+rjjnaKb8TGGOqD7kzDYAtwHzRPVPZ3YaOCyq+yu54Nf6PpmJwM8URFQfc2Y9orrYmV1uEFWpvYvq385sH/BymE9faIoglS2mgH3AZkCasgpfAesquWB0WoJUtijO7C3g8ZrSllm+e/i+G126Y6l3XXurO1cqh+8d/Wn0wNCP7ROOOTE33zizzjCfLk1H0O3MDgAiqtJ5y0IOvdThWqrOgUmND+w8cebo8OgNVQJxZv1hPv10Q4JUtugB3wPLAVavXMjQ9o4Zs+nq/fLMkVMRCXAJuKMhgZ8pdInqJ87MeZ7K2LsBbZMVT3FQO5v96MHSpQnXVo2r108QsyayigSrltA2o/YrtWXNilL/wEitpashgajeGj0pa+9a4mh+g9h0//LF/QMjiKoANzckcGbXiCpgLJrb8i/0w6JrRaoYDpidFNH52sPo+EWBVpjqopErGftjMk4SwTCwHmDg5G882TkfmhzywS9+iRMPJ81gENgKyuDJs4yFd7IgSUpd9Q9+NwF41Rl8nDSDz0R1xJmtmFBkQ88xjr+6ekbwTXtPyblSWUUVZ/YX8M50X3Iv8GLtfdVNCzi04x7mJoB37/mWDz//OX60q5ILtiV9aJtF9W1npkB15QzP89h47zIevHsp189vdb+Xynz69VnZP3Sai2UjdhcNObO1YT5dnkLgZwpPAHtF1Y81iDNzNaIrFa2yM1zs6j4sqt2VXDAOdbdpKlt8CtgD1M/mfaADWJaQEMA4sAvoq+SCymXBMeXPiOqbzkxgkqLdYT79gp8ppER1vTNbB9wOtIvqBWf2Q1X1B5VccL6ONHLgZwrPAbtF1YvFgjN7HdgW5tPN/VcblPiPfPQs0EcUaLx2AtsrueA/g0MU0da6WAzoCfPpV/4PcJzgeSAHzCJakR1hPv3a1QCH6gxS2eJGou3pq+SCN64WOMA/OMB0trwS1UoAAAAASUVORK5CYII="
    Private _Icono32 As String = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAADRklEQVRYhcWWXUgUURTHfzc3lRFJwejBD6jNqK2o1JISSil8GTCoUKxsiyCKHpKiIHoJeikw6iHqqWIeKg2UlZqgKJG+VAixEoo+Vg3Kl7AvGi1tbw+7d521dmdcQc/LnDnn3vP/3/85u3OFlJKZNM+Mok+FgOY3lwNbgDLAC2QAFtAHdAAtlqF3O9URk22B5jfXAKeBckA4LH8KHLMM/cmUCWh+UwAngRNAiqtNYQsBDcBxy9BDSRGIgF8G9tjjZUvmUbvBS/GCbJkzBzH0A9kT/CoaHwVp7x1kQukmYIdl6H/sQbczcMoOviQvS944WiYWZY0fBCA3HbF8bhZ1pUV8sKD6TId80T+k2lQDfAIO2ws7KqD5zXXAQyKyV67KJVC/EkBtFBF/4hNAbL/US6BzQJWTwCbL0NtUwI0CDQp8aX62DNSvVCeyD+DEWDR3/cAy1n/+KZ+9+ywi8QagKLoxkQKRie8CEAJeXdQp0P49JQkUAOQXicjfc4fQONYGy9AfulFgm3I2rsilQHNYHceyBVSVFthbsZVwWx0JrFNOXUWhcifVAuXvqii0E1irHCcCXuUUezMSyuyUK1mYpnIxdZ0IZCpnbqbzKRPlcjwxsQy3BIbV4m8jyMz05BX4Pp6D8DfDFYF+IAfgeXBE5PnS7aeblAI9fX/ssT63BLqAEoCbj4PoPh8kqUDj46C9bqdbAgHgIEBzRz+X9vlI8pfItfb39hYE3BJ4ALwGFodCkuqz3dw+UjTpFtRceMnoWLQFr4D70aSLb8Eh4Lx631e5mPM7vOCyBSdaBjjX2qu2S2CzZei3XBHQ/OZq4C6QbY9XrsqjuX6F46Wg9mIvrV0D9tAVy9D32gNxCcQDV5bmSZF1FV5RW15IcR4yFcQYyJ6PiMZHQa7cfyNHRmMm/x5QZRn6L0cCTuBJ2FVgv2Xovycm/hlCB/Ax4CxQDcx3AfyW8J0wEG9BjAIuwHdaht6k+U0PoBO+FZdGyKQCvwj/yXQCLYD5v3vgfwm4BY9XSPObsy1DH00EFpeA5jdLCA9JUuBTMTUDLTMBbicwCORPN7idQBXQBvimExxih3Ae4TlYBOyeDvAYAhESs4A0y9CHpwMc4C8mQVN06kAeBwAAAABJRU5ErkJggg=="

    Public Enum TamañoIcono
        Size16 = 16
        Size24 = 24
        Size32 = 32
    End Enum


    <Category("### ButtonSearch ###"),
    Description("Titulo")>
    Public Property Titulo As String
        Get
            Return _Titulo
        End Get
        Set(value As String)
            _Titulo = value
        End Set
    End Property
    <Category("### ButtonSearch ###"),
    Description("Tabla de Busqueda")>
    Public Property TablaBusqueda As String
        Get
            Return _Tabla
        End Get
        Set(value As String)
            _Tabla = value
        End Set
    End Property
    <Category("### ButtonSearch ###"),
    Description("ID de Busqueda")>
    Public Property IDBusqueda As String
        Get
            Return _IDBusqueda
        End Get
        Set(value As String)
            _IDBusqueda = value
        End Set
    End Property
    <Category("### ButtonSearch ###"),
    Description("Campo a Buscar 1")>
    Public Property CampoBuscar1 As String
        Get
            Return _CampoBuscar1
        End Get
        Set(value As String)
            _CampoBuscar1 = value
        End Set
    End Property
    <Category("### ButtonSearch ###"),
    Description("Campo a Buscar 2")>
    Public Property CampoBuscar2 As String
        Get
            Return _CampoBuscar2
        End Get
        Set(value As String)
            _CampoBuscar2 = value
        End Set
    End Property
    <Category("### ButtonSearch ###"),
    Description("Campos Adicionales")>
    Public Property CamposAdicionales As String
        Get
            Return _CamposAdicionales
        End Get
        Set(value As String)
            _CamposAdicionales = value
        End Set
    End Property
    <Category("### ButtonSearch ###"),
    Description("Filtro")>
    Public Property Filtro As String
        Get
            Return _Filtros
        End Get
        Set(value As String)
            _Filtros = value
        End Set
    End Property
    <Category("### ButtonSearch ###"),
    Description("IconSize")>
    Public Property IconSize As TamañoIcono
        Get
            Return _SizeIcon
        End Get
        Set(value As TamañoIcono)
            _SizeIcon = value
            Select Case _SizeIcon
                Case TamañoIcono.Size16
                    Image = Base64ToImage(_Icono16)
                Case TamañoIcono.Size24
                    Image = Base64ToImage(_Icono24)
                Case TamañoIcono.Size32
                    Image = Base64ToImage(_Icono32)
            End Select
        End Set
    End Property
    <Category("### ButtonSearch ###"),
    Description("Control de Carga")>
    Public Property ControlCarga As Control
        Get
            Return _ControlCargar
        End Get
        Set(value As Control)
            _ControlCargar = value
        End Set
    End Property
    <Category("### ButtonSearch ###"),
    Description("Control Focus")>
    Public Property ControlFocus As Control
        Get
            Return _ControlFocus
        End Get
        Set(value As Control)
            _ControlFocus = value
        End Set
    End Property

    Public Sub Buscar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles MyBase.Click
        Dim wBusc = New SearchForm(_Titulo, _Tabla, _IDBusqueda, _CampoBuscar1, _CampoBuscar2, _CamposAdicionales, _Filtros)
        wBusc.ShowDialog()
        Try
            If wBusc.DialogResult = DialogResult.Yes Then
                _ControlCargar.Text = wBusc.ValorCarga
                _ControlCargar.Validate
                _ControlFocus.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub New()
        Size = New Size(123, 27)
        Font = New Font("Arial", 9.75, FontStyle.Regular)
        TextImageRelation = TextImageRelation.ImageBeforeText
        FlatStyle = FlatStyle.Flat
        AutoSize = False
        Image = Base64ToImage(_Icono16)
        _ControlCargar = ControlCarga
        'AddHandler Me.Click, AddressOf xSearchButton_CLick
    End Sub
    'Public Sub xSearchButton_CLick(Optional ByVal sender As Object = Nothing, Optional ByVal e As EventArgs = Nothing)

    'End Sub
    Private Function Base64ToImage(ByVal base64String As String) As Image
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As MemoryStream = New MemoryStream(imageBytes, 0, imageBytes.Length)
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim image As Image = Image.FromStream(ms, True)
        Return image
        Invalidate()
    End Function
End Class
