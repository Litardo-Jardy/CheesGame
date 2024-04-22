Public Class Coordenadas
    Public Property X As Integer
    Public Property Y As Integer
    Public Property IsColor As Boolean
    Public Property startPosition As Boolean
    Public Property capturePassingPosition As Boolean
    Public Property isLife As Boolean

    Public thisPiece As Integer

    Public Sub New(x As Integer, y As Integer, isColor As Boolean, startPosition As Boolean, thisPiece As Integer, capturePassingPosition As Boolean, Optional isLife As Boolean = True)
        Me.X = x
        Me.Y = y
        Me.IsColor = isColor
        Me.startPosition = startPosition
        Me.capturePassingPosition = capturePassingPosition
        Me.isLife = isLife
        Me.thisPiece = thisPiece
    End Sub

End Class
