Public Class TextAndImageColumn
    Inherits DataGridViewTextBoxColumn

    Public Sub New()
        Me.CellTemplate = New TextAndImageCell()
    End Sub

    Public Overrides Function Clone() As Object
        Dim c As TextAndImageColumn = TryCast(MyBase.Clone(), TextAndImageColumn)
        c.ImageValue = Me.ImageValue
        c.ImageSize = Me.ImageSize
        Return c
    End Function

    Public Property Image As Image
        Get
            Return Me.ImageValue
        End Get
        Set(ByVal value As Image)
            'ex
            If value Is Nothing Then Return

            If Me.Image IsNot value Then
                Me.ImageValue = value
                Me.ImageSize = value.Size

                If Me.InheritedStyle IsNot Nothing Then
                    Dim inheritedPadding As Padding = Me.InheritedStyle.Padding
                    Me.DefaultCellStyle.Padding = New Padding(ImageSize.Width, inheritedPadding.Top, inheritedPadding.Right, inheritedPadding.Bottom)
                End If
            End If
        End Set
    End Property

    Private ReadOnly Property TextAndImageCellTemplate As TextAndImageCell
        Get
            Return TryCast(Me.CellTemplate, TextAndImageCell)
        End Get
    End Property

    Friend Property ImageSize As Size
    Friend Property ImageValue As Image

End Class

Public Class TextAndImageCell
    Inherits DataGridViewTextBoxCell

    Friend Property ImageSize As Size
    Friend Property ImageValue As Image

    Public Overrides Function Clone() As Object
        Dim c As TextAndImageCell = TryCast(MyBase.Clone(), TextAndImageCell)
        c.ImageValue = Me.ImageValue
        c.ImageSize = Me.ImageSize
        Return c
    End Function

    Public Property Image As Image
        Get

            If Me.OwningColumn Is Nothing OrElse Me.OwningTextAndImageColumn Is Nothing Then
                Return ImageValue
            ElseIf Me.ImageValue IsNot Nothing Then
                Return Me.ImageValue
            Else
                Return Me.OwningTextAndImageColumn.Image
            End If
        End Get
        Set(ByVal value As Image)
            'ex
            If value Is Nothing Then Return

            If Me.ImageValue IsNot value Then
                Me.ImageValue = value
                Me.ImageSize = value.Size
                Dim inheritedPadding As Padding = Me.InheritedStyle.Padding
                Me.Style.Padding = New Padding(ImageSize.Width, inheritedPadding.Top, inheritedPadding.Right, inheritedPadding.Bottom)
            End If
        End Set
    End Property

    Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

        If Me.Image IsNot Nothing Then
            Dim container As System.Drawing.Drawing2D.GraphicsContainer = graphics.BeginContainer()
            graphics.SetClip(cellBounds)
            graphics.DrawImageUnscaled(Me.Image, cellBounds.Location)
            graphics.EndContainer(container)
        End If
    End Sub

    Private ReadOnly Property OwningTextAndImageColumn As TextAndImageColumn
        Get
            Return TryCast(Me.OwningColumn, TextAndImageColumn)
        End Get
    End Property
End Class

