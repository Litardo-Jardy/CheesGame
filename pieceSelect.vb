Public Class pieceSelect
    Public Piece As Integer
    Public Image As PictureBox
    Public Sub getPiece(namePiece As Integer, Img As PictureBox)
        Piece = namePiece
        Image = Img
    End Sub
    Public Function setPiece()
        Return Piece
    End Function

    Public Function setImage()
        Return Image
    End Function
End Class
