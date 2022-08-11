Imports System.Drawing.Printing
Imports System.Runtime.InteropServices

Public Class PrinterEx
    <DllImport("winspool.drv", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function SetDefaultPrinter(ByVal Name As String) As Boolean
    End Function

    Public Shared MyPrinterSettings As PrinterSettings = New PrinterSettings()

    Public Shared Property Default_PrinterName As String
        Get
            Return MyPrinterSettings.PrinterName
        End Get
        Set(ByVal value As String)
            SetDefaultPrinter(value)
        End Set
    End Property
End Class
