Public Class getNewPiecePeon

    Public colorPiece As Boolean
    Public imagePiece As PictureBox
    Public coorXPiece As Integer
    Public coorYPiece As Integer

    Public Sub updateValuePiece(Image, isColor, ACoorX, ACoorY)
        imagePiece = Image
        colorPiece = isColor
        coorXPiece = ACoorX
        coorYPiece = ACoorY
    End Sub

End Class
