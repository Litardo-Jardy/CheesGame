Imports System.Runtime.InteropServices

Public Class capturePassign

    Public ImageCapture As PictureBox

    Public Sub updateValueCapturePassing(Optional value As Boolean = False, Optional Img As PictureBox = Nothing)

        If ImageCapture IsNot Nothing Then
            Dim ImgTag As Coordenadas = TryCast(ImageCapture.Tag, Coordenadas)
            Dim NewImgTag As New Coordenadas(ImgTag.X, ImgTag.Y, ImgTag.IsColor, False, ImgTag.thisPiece, value, True)
            ImageCapture.Tag = NewImgTag
        End If
        ImageCapture = Img
    End Sub


End Class
