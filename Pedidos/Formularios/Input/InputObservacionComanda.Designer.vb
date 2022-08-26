<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InputObservacionComanda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputObservacionComanda))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xObservacion = New System.Windows.Forms.TextBox()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 16)
        Me.Label8.TabIndex = 275
        Me.Label8.Text = "Observación comanda"
        '
        'xObservacion
        '
        Me.xObservacion.BackColor = System.Drawing.Color.White
        Me.xObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.xObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.xObservacion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.xObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.xObservacion.Location = New System.Drawing.Point(12, 31)
        Me.xObservacion.MaxLength = 18
        Me.xObservacion.Name = "xObservacion"
        Me.xObservacion.Size = New System.Drawing.Size(331, 21)
        Me.xObservacion.TabIndex = 0
        Me.xObservacion.TabStop = False
        '
        'bAceptar
        '
        Me.bAceptar.BackColor = System.Drawing.Color.White
        Me.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAceptar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAceptar.Image = Global.Entregas.My.Resources.Resources.ok
        Me.bAceptar.Location = New System.Drawing.Point(243, 58)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(100, 27)
        Me.bAceptar.TabIndex = 2
        Me.bAceptar.Text = "Aceptar (F1)"
        Me.bAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'bCancelar
        '
        Me.bCancelar.BackColor = System.Drawing.Color.White
        Me.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancelar.Image = Global.Entregas.My.Resources.Resources.cancel
        Me.bCancelar.Location = New System.Drawing.Point(123, 58)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(114, 27)
        Me.bCancelar.TabIndex = 1
        Me.bCancelar.Text = "Cancelar (F2)"
        Me.bCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCancelar.UseVisualStyleBackColor = False
        '
        'InputObservacionComanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 97)
        Me.Controls.Add(Me.xObservacion)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InputObservacionComanda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "InputObservacionComanda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents bAceptar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents xObservacion As TextBox
    Public WithEvents bCancelar As Button
End Class
