<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acceso))
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bIngresar = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.xPassword = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.xUsuario = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cLocal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WinDeco2 = New WinDeco.WinDeco()
        Me.panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bSalir
        '
        Me.bSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bSalir.BackColor = System.Drawing.Color.White
        Me.bSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.bSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.bSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSalir.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(192, 252)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(168, 36)
        Me.bSalir.TabIndex = 3
        Me.bSalir.Text = "Salir"
        Me.bSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bIngresar
        '
        Me.bIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bIngresar.BackColor = System.Drawing.Color.White
        Me.bIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.bIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.bIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.bIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bIngresar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bIngresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.bIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bIngresar.Location = New System.Drawing.Point(12, 252)
        Me.bIngresar.Name = "bIngresar"
        Me.bIngresar.Size = New System.Drawing.Size(168, 36)
        Me.bIngresar.TabIndex = 2
        Me.bIngresar.Text = "Ingresar"
        Me.bIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bIngresar.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.xPassword)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.xUsuario)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Location = New System.Drawing.Point(12, 135)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(348, 88)
        Me.panel1.TabIndex = 1
        '
        'xPassword
        '
        Me.xPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.xPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.xPassword.Location = New System.Drawing.Point(146, 47)
        Me.xPassword.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.xPassword.MaxLength = 18
        Me.xPassword.Name = "xPassword"
        Me.xPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.xPassword.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.xPassword.Size = New System.Drawing.Size(185, 27)
        Me.xPassword.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(8, 50)
        Me.label1.Margin = New System.Windows.Forms.Padding(6, 5, 3, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(98, 19)
        Me.label1.TabIndex = 214
        Me.label1.Text = "Contraseña"
        '
        'xUsuario
        '
        Me.xUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.xUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xUsuario.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.xUsuario.Location = New System.Drawing.Point(146, 12)
        Me.xUsuario.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.xUsuario.MaxLength = 3
        Me.xUsuario.Name = "xUsuario"
        Me.xUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.xUsuario.Size = New System.Drawing.Size(185, 27)
        Me.xUsuario.TabIndex = 0
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(8, 15)
        Me.label6.Margin = New System.Windows.Forms.Padding(6, 5, 3, 3)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(69, 19)
        Me.label6.TabIndex = 212
        Me.label6.Text = "Usuario"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cLocal)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(12, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(348, 67)
        Me.Panel2.TabIndex = 0
        '
        'cLocal
        '
        Me.cLocal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cLocal.BackColor = System.Drawing.Color.White
        Me.cLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cLocal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cLocal.FormattingEnabled = True
        Me.cLocal.Location = New System.Drawing.Point(8, 30)
        Me.cLocal.Margin = New System.Windows.Forms.Padding(4)
        Me.cLocal.Name = "cLocal"
        Me.cLocal.Size = New System.Drawing.Size(331, 26)
        Me.cLocal.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 5, 3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 212
        Me.Label4.Text = "Local"
        '
        'WinDeco2
        '
        Me.WinDeco2.AlturaFooter = 60
        Me.WinDeco2.AlturaTitulo = 50
        Me.WinDeco2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.WinDeco2.BordeVentana = 2
        Me.WinDeco2.ColorBordeVentana = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.WinDeco2.ColorPanelBanner = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.WinDeco2.Dock = System.Windows.Forms.DockStyle.Top
        Me.WinDeco2.FondoAplicacionA = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WinDeco2.FondoAplicacionB = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.WinDeco2.FondoColorA = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.WinDeco2.FondoColorB = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.WinDeco2.FooterColorA = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.WinDeco2.FooterColorB = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.WinDeco2.FooterSolido = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.WinDeco2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.WinDeco2.ImagenBanner = CType(resources.GetObject("WinDeco2.ImagenBanner"), System.Drawing.Image)
        Me.WinDeco2.Location = New System.Drawing.Point(0, 0)
        Me.WinDeco2.Margin = New System.Windows.Forms.Padding(2)
        Me.WinDeco2.MuestraBordeExterior = -1
        Me.WinDeco2.Name = "WinDeco2"
        Me.WinDeco2.SiempreVisible = False
        Me.WinDeco2.Size = New System.Drawing.Size(375, 50)
        Me.WinDeco2.TabIndex = 215
        Me.WinDeco2.TituloVentana = "Entregas de Pedidos"
        Me.WinDeco2.UbicacionTitulo = New System.Drawing.Point(4, 19)
        Me.WinDeco2.VerCerrar = True
        Me.WinDeco2.VerLogo = False
        Me.WinDeco2.VerMaximizar = False
        Me.WinDeco2.VerMinimizar = True
        Me.WinDeco2.VerTitulo = True
        Me.WinDeco2.Visible = False
        '
        'Acceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(375, 300)
        Me.Controls.Add(Me.WinDeco2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bIngresar)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1920, 1040)
        Me.Name = "Acceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents bSalir As Button
    Public WithEvents bIngresar As Button
    Private WithEvents panel1 As Panel
    Friend WithEvents xPassword As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents xUsuario As TextBox
    Friend WithEvents label6 As Label
    Private WithEvents Panel2 As Panel
    Friend WithEvents cLocal As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents WinDeco2 As WinDeco.WinDeco
End Class
