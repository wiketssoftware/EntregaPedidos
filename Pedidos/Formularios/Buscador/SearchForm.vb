Public Class SearchForm
    Dim _Tabla As String
    Dim _IDBusqueda As String
    Dim _CampoBusqueda1 As String
    Dim _CampoBusqueda2 As String
    Dim _CamposAdicionales As String
    Dim _Filtros As String
    Public Property ValorCarga As String

    Sub New(ByVal wTitulo As String, ByVal wTabla As String, ByVal wIDBusqueda As String,
            ByVal wCampoBusqueda1 As String, ByVal wCampoBusqueda2 As String, ByVal wCamposAdicionales As String, wFiltros As String)
        InitializeComponent()
        WinDeco1.Titulo.Text = wTitulo
        _Tabla = wTabla
        _IDBusqueda = wIDBusqueda
        _CampoBusqueda1 = wCampoBusqueda1
        _CampoBusqueda2 = wCampoBusqueda2
        _CamposAdicionales = wCamposAdicionales
        _Filtros = wFiltros
    End Sub
#Region "MenuCopiar"
    Private Sub bCopiar_Click(sender As Object, e As EventArgs) Handles bCopiar.Click
        If bCopiar.Tag IsNot Nothing Then
            Clipboard.SetText(bCopiar.Tag.ToString)
            mMenuTabla.Hide()
        End If
    End Sub
#End Region

    Private Sub xBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles xBuscar.KeyPress
        e.NextControl(bBuscar)
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click

        Dim wBuscar = SQL("SELECT " & _IDBusqueda & "," & _CampoBusqueda1 & If(_CampoBusqueda2 = "", "", " ," & _CampoBusqueda2) & " " & _CamposAdicionales & " FROM " & _Tabla & " WHERE " &
                          "(UPPER(" & _IDBusqueda & ") collate SQL_Latin1_General_Cp1251_CS_AS Like '%" & xBuscar.Text.Trim.ToUpper & "%' OR " &
                          "UPPER(" & _CampoBusqueda1 & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & xBuscar.Text.Trim.ToUpper & "%'  " &
                          If(_CampoBusqueda2 = "", ")", " OR UPPER(" & _CampoBusqueda2 & ") collate SQL_Latin1_General_Cp1251_CS_AS LIKE '%" & xBuscar.Text.Trim.ToUpper & "%') ") &
                           If(_Filtros = "", "", " AND " & _Filtros))

        If wBuscar.Rows.Count > 0 Then
            Cursor = Cursors.WaitCursor
            xTabla.Rows.Clear()
            xTabla.Columns.Clear()

            For Each wC As DataColumn In wBuscar.Columns
                xTabla.Columns.Add(wC.ColumnName, wC.ColumnName)
            Next

            For Each wColumn As DataGridViewColumn In xTabla.Columns
                wColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next

            For Each wR As DataRow In wBuscar.Rows
                xTabla.Rows.Add()
                For i = 0 To xTabla.Columns.Count - 1
                    xTabla.Item(i, xTabla.Rows.Count - 1).Value = wR.Item(i).ToString()
                Next
            Next
            Cursor = Cursors.Default
            xTabla.Focus()
        Else
            MsgError("No se encuentran registros para el texto ingresado")
            xBuscar.Clear()
            xBuscar.Focus()
            Exit Sub
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub bAceptar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bAceptar.Click, xTabla.DoubleClick
        If xTabla.Rows.Count > 0 Then
            ValorCarga = xTabla.CurrentRow.Cells.Item(0).Value.ToString
            DialogResult = DialogResult.Yes
        End If
    End Sub

    Private Sub bCancelar_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles bCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub
    Private Sub xTabla_KeyDown(sender As Object, e As KeyEventArgs) Handles xTabla.KeyDown
        If xTabla.Rows.Count = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            ValorCarga = xTabla.CurrentRow.Cells.Item(0).Value.ToString
            DialogResult = DialogResult.Yes
        End If
    End Sub

    Private Sub xTabla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles xTabla.CellDoubleClick
        If xTabla.Rows.Count = 0 Then Exit Sub
        ValorCarga = xTabla.CurrentRow.Cells.Item(0).Value.ToString
        DialogResult = DialogResult.Yes
    End Sub
End Class