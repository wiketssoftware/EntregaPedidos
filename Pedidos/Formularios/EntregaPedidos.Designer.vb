<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EntregaPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntregaPedidos))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gCabecera = New System.Windows.Forms.GroupBox()
        Me.xFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xLocal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gPedido = New System.Windows.Forms.GroupBox()
        Me.xLugar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xDetalle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xCliente = New System.Windows.Forms.TextBox()
        Me.xNumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xDocumento = New System.Windows.Forms.TextBox()
        Me.xBarra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xTabla = New System.Windows.Forms.DataGridView()
        Me.Smile = New System.Windows.Forms.DataGridViewImageColumn()
        Me.bEntregar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.WinDeco2 = New WinDeco.WinDeco()
        Me.lVersion = New System.Windows.Forms.Label()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.gBotonera = New System.Windows.Forms.GroupBox()
        Me.bPendiente = New System.Windows.Forms.Button()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.Ciclo = New System.Windows.Forms.Timer(Me.components)
        Me.bActualizar = New System.Windows.Forms.Button()
        Me.bLimpiar2 = New System.Windows.Forms.Button()
        Me.NombreLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entregado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sTablaEntregas = New System.Windows.Forms.BindingSource(Me.components)
        Me.bSacar = New System.Windows.Forms.Button()
        Me.gCabecera.SuspendLayout()
        Me.gPedido.SuspendLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBotonera.SuspendLayout()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sTablaEntregas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.xFecha.ReadOnly = True
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
        Me.xLocal.ReadOnly = True
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
        Me.gPedido.Controls.Add(Me.xLugar)
        Me.gPedido.Controls.Add(Me.Label6)
        Me.gPedido.Controls.Add(Me.Label5)
        Me.gPedido.Controls.Add(Me.xDetalle)
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
        'xLugar
        '
        Me.xLugar.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.xLugar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.xLugar, "xLugar")
        Me.xLugar.ForeColor = System.Drawing.Color.Black
        Me.xLugar.Name = "xLugar"
        Me.xLugar.UseWaitCursor = True
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'xDetalle
        '
        resources.ApplyResources(Me.xDetalle, "xDetalle")
        Me.xDetalle.BackColor = System.Drawing.Color.Yellow
        Me.xDetalle.Name = "xDetalle"
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
        Me.xTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreLocal, Me.FechaDataGridViewTextBoxColumn, Me.LocalDataGridViewTextBoxColumn, Me.TipoDocDataGridViewTextBoxColumn, Me.NumDocDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.Smile, Me.Entregado})
        Me.xTabla.DataSource = Me.sTablaEntregas
        Me.xTabla.Name = "xTabla"
        Me.xTabla.ReadOnly = True
        Me.xTabla.RowHeadersVisible = False
        Me.xTabla.RowTemplate.Height = 40
        Me.xTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        '
        'Smile
        '
        Me.Smile.DataPropertyName = "Smile"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle10.NullValue = CType(resources.GetObject("DataGridViewCellStyle10.NullValue"), Object)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Smile.DefaultCellStyle = DataGridViewCellStyle10
        Me.Smile.FillWeight = 50.0!
        resources.ApplyResources(Me.Smile, "Smile")
        Me.Smile.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Smile.Name = "Smile"
        Me.Smile.ReadOnly = True
        '
        'bEntregar
        '
        Me.bEntregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.bEntregar, "bEntregar")
        Me.bEntregar.Image = Global.Entregas.My.Resources.Resources.execute32
        Me.bEntregar.Name = "bEntregar"
        Me.bEntregar.UseVisualStyleBackColor = False
        '
        'bLimpiar
        '
        resources.ApplyResources(Me.bLimpiar, "bLimpiar")
        Me.bLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bLimpiar.Image = Global.Entregas.My.Resources.Resources.clean24
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        resources.ApplyResources(Me.bCancelar, "bCancelar")
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.Image = Global.Entregas.My.Resources.Resources.cancel24
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
        Me.gBotonera.Controls.Add(Me.bSacar)
        Me.gBotonera.Controls.Add(Me.bPendiente)
        Me.gBotonera.Controls.Add(Me.bEntregar)
        Me.gBotonera.Controls.Add(Me.bLimpiar)
        Me.gBotonera.Name = "gBotonera"
        Me.gBotonera.TabStop = False
        '
        'bPendiente
        '
        Me.bPendiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.bPendiente, "bPendiente")
        Me.bPendiente.Image = Global.Entregas.My.Resources.Resources.help32
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
        'Ciclo
        '
        Me.Ciclo.Enabled = True
        Me.Ciclo.Interval = 60000
        '
        'bActualizar
        '
        resources.ApplyResources(Me.bActualizar, "bActualizar")
        Me.bActualizar.BackColor = System.Drawing.Color.White
        Me.bActualizar.Image = Global.Entregas.My.Resources.Resources.refresh_update24
        Me.bActualizar.Name = "bActualizar"
        Me.bActualizar.UseVisualStyleBackColor = False
        '
        'bLimpiar2
        '
        resources.ApplyResources(Me.bLimpiar2, "bLimpiar2")
        Me.bLimpiar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bLimpiar2.Image = Global.Entregas.My.Resources.Resources.clean24
        Me.bLimpiar2.Name = "bLimpiar2"
        Me.bLimpiar2.UseVisualStyleBackColor = False
        '
        'NombreLocal
        '
        Me.NombreLocal.DataPropertyName = "NombreLocal"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.NombreLocal.DefaultCellStyle = DataGridViewCellStyle11
        Me.NombreLocal.FillWeight = 280.0!
        resources.ApplyResources(Me.NombreLocal, "NombreLocal")
        Me.NombreLocal.Name = "NombreLocal"
        Me.NombreLocal.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.FechaDataGridViewTextBoxColumn.FillWeight = 230.0!
        resources.ApplyResources(Me.FechaDataGridViewTextBoxColumn, "FechaDataGridViewTextBoxColumn")
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalDataGridViewTextBoxColumn
        '
        Me.LocalDataGridViewTextBoxColumn.DataPropertyName = "Local"
        resources.ApplyResources(Me.LocalDataGridViewTextBoxColumn, "LocalDataGridViewTextBoxColumn")
        Me.LocalDataGridViewTextBoxColumn.Name = "LocalDataGridViewTextBoxColumn"
        Me.LocalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDocDataGridViewTextBoxColumn
        '
        Me.TipoDocDataGridViewTextBoxColumn.DataPropertyName = "TipoDoc"
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoDocDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.TipoDocDataGridViewTextBoxColumn.FillWeight = 300.0!
        resources.ApplyResources(Me.TipoDocDataGridViewTextBoxColumn, "TipoDocDataGridViewTextBoxColumn")
        Me.TipoDocDataGridViewTextBoxColumn.Name = "TipoDocDataGridViewTextBoxColumn"
        Me.TipoDocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumDocDataGridViewTextBoxColumn
        '
        Me.NumDocDataGridViewTextBoxColumn.DataPropertyName = "NumDoc"
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumDocDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.NumDocDataGridViewTextBoxColumn.FillWeight = 120.0!
        resources.ApplyResources(Me.NumDocDataGridViewTextBoxColumn, "NumDocDataGridViewTextBoxColumn")
        Me.NumDocDataGridViewTextBoxColumn.Name = "NumDocDataGridViewTextBoxColumn"
        Me.NumDocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.ClienteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.ClienteDataGridViewTextBoxColumn.FillWeight = 400.0!
        resources.ApplyResources(Me.ClienteDataGridViewTextBoxColumn, "ClienteDataGridViewTextBoxColumn")
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tiempo"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn3.FillWeight = 150.0!
        resources.ApplyResources(Me.DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3")
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Entregado
        '
        Me.Entregado.DataPropertyName = "Entregado"
        resources.ApplyResources(Me.Entregado, "Entregado")
        Me.Entregado.Name = "Entregado"
        Me.Entregado.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PrecioMostrar"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn1.FillWeight = 200.0!
        resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TotalMostrar"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn2.FillWeight = 150.0!
        resources.ApplyResources(Me.DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2")
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'sTablaEntregas
        '
        Me.sTablaEntregas.DataSource = GetType(Entregas.TablaEntregas)
        '
        'bSacar
        '
        Me.bSacar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.bSacar, "bSacar")
        Me.bSacar.Image = Global.Entregas.My.Resources.Resources.delete24
        Me.bSacar.Name = "bSacar"
        Me.bSacar.UseVisualStyleBackColor = False
        '
        'EntregaPedidos
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bLimpiar2)
        Me.Controls.Add(Me.bActualizar)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.gBotonera)
        Me.Controls.Add(Me.lVersion)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.xTabla)
        Me.Controls.Add(Me.gPedido)
        Me.Controls.Add(Me.gCabecera)
        Me.Controls.Add(Me.WinDeco2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EntregaPedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gCabecera.ResumeLayout(False)
        Me.gCabecera.PerformLayout()
        Me.gPedido.ResumeLayout(False)
        Me.gPedido.PerformLayout()
        CType(Me.xTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBotonera.ResumeLayout(False)
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sTablaEntregas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents sTablaEntregas As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ElimnarDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As TextAndImageColumn
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
    Friend WithEvents Label5 As Label
    Friend WithEvents xDetalle As TextBox
    Friend WithEvents Ciclo As Timer
    Public WithEvents bActualizar As Button
    Public WithEvents bLimpiar2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents xLugar As TextBox
    Friend WithEvents NombreLocal As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumDocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Smile As DataGridViewImageColumn
    Friend WithEvents Entregado As DataGridViewTextBoxColumn
    Public WithEvents bSacar As Button
End Class
