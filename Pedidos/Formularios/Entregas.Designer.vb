﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Entregas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entregas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gCabecera = New System.Windows.Forms.GroupBox()
        Me.xFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xLocal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gPedido = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.xNumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xDocumento = New System.Windows.Forms.TextBox()
        Me.xBarra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xTabla = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New Pedidos.TextAndImageColumn()
        Me.PrecioMostrar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalMostrar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sTablaPedido = New System.Windows.Forms.BindingSource(Me.components)
        Me.bEntregar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.WinDeco2 = New WinDeco.WinDeco()
        Me.lVersion = New System.Windows.Forms.Label()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.gBotonera = New System.Windows.Forms.GroupBox()
        Me.bPendiente = New System.Windows.Forms.Button()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gCabecera.SuspendLayout()
        Me.gPedido.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sTablaPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBotonera.SuspendLayout()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gCabecera
        '
        resources.ApplyResources(Me.gCabecera, "gCabecera")
        Me.gCabecera.BackColor = System.Drawing.Color.Transparent
        Me.gCabecera.Controls.Add(Me.xFecha)
        Me.gCabecera.Controls.Add(Me.Label1)
        Me.gCabecera.Controls.Add(Me.xLocal)
        Me.gCabecera.Controls.Add(Me.Label3)
        Me.gCabecera.Name = "gCabecera"
        Me.gCabecera.TabStop = False
        '
        'xFecha
        '
        Me.xFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.xFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.xFecha, "xFecha")
        Me.xFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.xFecha.Name = "xFecha"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'xLocal
        '
        resources.ApplyResources(Me.xLocal, "xLocal")
        Me.xLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.xLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xLocal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.xLocal.Name = "xLocal"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'gPedido
        '
        resources.ApplyResources(Me.gPedido, "gPedido")
        Me.gPedido.BackColor = System.Drawing.Color.Transparent
        Me.gPedido.Controls.Add(Me.Label4)
        Me.gPedido.Controls.Add(Me.xCliente)
        Me.gPedido.Controls.Add(Me.xNumero)
        Me.gPedido.Controls.Add(Me.Label2)
        Me.gPedido.Controls.Add(Me.xDocumento)
        Me.gPedido.Controls.Add(Me.xBarra)
        Me.gPedido.Controls.Add(Me.Label7)
        Me.gPedido.Name = "gPedido"
        Me.gPedido.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'xCliente
        '
        Me.xCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.xCliente, "xCliente")
        Me.xCliente.ForeColor = System.Drawing.Color.Black
        Me.xCliente.Name = "xCliente"
        '
        'xNumero
        '
        Me.xNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.xNumero, "xNumero")
        Me.xNumero.ForeColor = System.Drawing.Color.Black
        Me.xNumero.Name = "xNumero"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'xDocumento
        '
        Me.xDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.xDocumento, "xDocumento")
        Me.xDocumento.ForeColor = System.Drawing.Color.Black
        Me.xDocumento.Name = "xDocumento"
        '
        'xBarra
        '
        Me.xBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.xBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.xBarra, "xBarra")
        Me.xBarra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xBarra.Name = "xBarra"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Name = "Label7"
        '
        'xTabla
        '
        Me.xTabla.AllowUserToAddRows = False
        Me.xTabla.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.xTabla, "xTabla")
        Me.xTabla.AutoGenerateColumns = False
        Me.xTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.xTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.ArticuloDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioMostrar, Me.TotalMostrar})
        Me.xTabla.DataSource = Me.sTablaPedido
        Me.xTabla.Name = "xTabla"
        Me.xTabla.RowHeadersVisible = False
        Me.xTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        '
        'Eliminar
        '
        Me.Eliminar.DataPropertyName = "Eliminar"
        Me.Eliminar.FillWeight = 25.0!
        resources.ApplyResources(Me.Eliminar, "Eliminar")
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'ArticuloDataGridViewTextBoxColumn
        '
        Me.ArticuloDataGridViewTextBoxColumn.DataPropertyName = "Articulo"
        resources.ApplyResources(Me.ArticuloDataGridViewTextBoxColumn, "ArticuloDataGridViewTextBoxColumn")
        Me.ArticuloDataGridViewTextBoxColumn.Name = "ArticuloDataGridViewTextBoxColumn"
        Me.ArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        resources.ApplyResources(Me.DescripcionDataGridViewTextBoxColumn, "DescripcionDataGridViewTextBoxColumn")
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.CantidadDataGridViewTextBoxColumn, "CantidadDataGridViewTextBoxColumn")
        Me.CantidadDataGridViewTextBoxColumn.Image = Global.Pedidos.My.Resources.Resources.editGrid
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'PrecioMostrar
        '
        Me.PrecioMostrar.DataPropertyName = "PrecioMostrar"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PrecioMostrar.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.PrecioMostrar, "PrecioMostrar")
        Me.PrecioMostrar.Name = "PrecioMostrar"
        Me.PrecioMostrar.ReadOnly = True
        '
        'TotalMostrar
        '
        Me.TotalMostrar.DataPropertyName = "TotalMostrar"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TotalMostrar.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.TotalMostrar, "TotalMostrar")
        Me.TotalMostrar.Name = "TotalMostrar"
        Me.TotalMostrar.ReadOnly = True
        '
        'sTablaPedido
        '
        Me.sTablaPedido.DataSource = GetType(Pedidos.TablaPedido)
        '
        'bEntregar
        '
        Me.bEntregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.bEntregar, "bEntregar")
        Me.bEntregar.Image = Global.Pedidos.My.Resources.Resources.execute32
        Me.bEntregar.Name = "bEntregar"
        Me.bEntregar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        resources.ApplyResources(Me.bLimpiar, "bLimpiar")
        Me.bLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bLimpiar.Image = Global.Pedidos.My.Resources.Resources.clean24
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        resources.ApplyResources(Me.bCancelar, "bCancelar")
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.Image = Global.Pedidos.My.Resources.Resources.cancel24
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'WinDeco2
        '
        Me.WinDeco2.AlturaFooter = 60
        Me.WinDeco2.AlturaTitulo = 50
        Me.WinDeco2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WinDeco2.BordeVentana = 2
        Me.WinDeco2.ColorBordeVentana = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WinDeco2.ColorPanelBanner = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(Me.WinDeco2, "WinDeco2")
        Me.WinDeco2.FondoAplicacionA = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WinDeco2.FondoAplicacionB = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.WinDeco2.FondoColorA = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WinDeco2.FondoColorB = System.Drawing.Color.Black
        Me.WinDeco2.FooterColorA = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WinDeco2.FooterColorB = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.WinDeco2.FooterSolido = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.WinDeco2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.WinDeco2.ImagenBanner = CType(resources.GetObject("WinDeco2.ImagenBanner"), System.Drawing.Image)
        Me.WinDeco2.MuestraBordeExterior = -1
        Me.WinDeco2.Name = "WinDeco2"
        Me.WinDeco2.SiempreVisible = False
        Me.WinDeco2.TituloVentana = "ENTREGA DE PEDIDOS"
        Me.WinDeco2.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco2.VerCerrar = True
        Me.WinDeco2.VerLogo = False
        Me.WinDeco2.VerMaximizar = True
        Me.WinDeco2.VerMinimizar = True
        Me.WinDeco2.VerTitulo = True
        '
        'lVersion
        '
        resources.ApplyResources(Me.lVersion, "lVersion")
        Me.lVersion.BackColor = System.Drawing.Color.Transparent
        Me.lVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lVersion.Name = "lVersion"
        '
        'Tiempo
        '
        Me.Tiempo.Enabled = True
        Me.Tiempo.Interval = 1000
        '
        'gBotonera
        '
        resources.ApplyResources(Me.gBotonera, "gBotonera")
        Me.gBotonera.BackColor = System.Drawing.Color.Transparent
        Me.gBotonera.Controls.Add(Me.bPendiente)
        Me.gBotonera.Controls.Add(Me.bEntregar)
        Me.gBotonera.Controls.Add(Me.bLimpiar)
        Me.gBotonera.Name = "gBotonera"
        Me.gBotonera.TabStop = False
        '
        'bPendiente
        '
        Me.bPendiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.bPendiente, "bPendiente")
        Me.bPendiente.Image = Global.Pedidos.My.Resources.Resources.help32
        Me.bPendiente.Name = "bPendiente"
        Me.bPendiente.UseVisualStyleBackColor = False
        '
        'Imagen
        '
        resources.ApplyResources(Me.Imagen, "Imagen")
        Me.Imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Imagen.Name = "Imagen"
        Me.Imagen.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PrecioMostrar"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TotalMostrar"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
        resources.ApplyResources(Me.DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2")
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Entregas
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.gBotonera)
        Me.Controls.Add(Me.lVersion)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.gPedido)
        Me.Controls.Add(Me.gCabecera)
        Me.Controls.Add(Me.WinDeco2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Entregas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gCabecera.ResumeLayout(False)
        Me.gCabecera.PerformLayout()
        Me.gPedido.ResumeLayout(False)
        Me.gPedido.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sTablaPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBotonera.ResumeLayout(False)
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WinDeco2 As WinDeco.WinDeco
    Friend WithEvents gCabecera As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents xLocal As TextBox
    Friend WithEvents gPedido As GroupBox
    Friend WithEvents xDocumento As TextBox
    Friend WithEvents xBarra As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents xTabla As DataGridView
    Public WithEvents bLimpiar As Button
    Public WithEvents bCancelar As Button
    Public WithEvents bEntregar As Button
    Friend WithEvents sTablaPedido As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ElimnarDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Eliminar As DataGridViewImageColumn
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As TextAndImageColumn
    Friend WithEvents PrecioMostrar As DataGridViewTextBoxColumn
    Friend WithEvents TotalMostrar As DataGridViewTextBoxColumn
    Friend WithEvents lVersion As Label
    Friend WithEvents xFecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tiempo As Timer
    Friend WithEvents xNumero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents xCliente As TextBox
    Friend WithEvents gBotonera As GroupBox
    Public WithEvents bPendiente As Button
    Friend WithEvents Imagen As PictureBox
End Class
