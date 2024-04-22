Imports System.Linq.Expressions

Public Class executeMove
    Dim Peon As New LGPeon
    Dim Torre As New LGTorrevb
    Dim Alfil As New LGAlfil
    Dim Caballo As New LGCaballo
    Dim Rey As New LGRey
    Dim Dama As New LGDama
    Public Sub execute(CoorX As Integer, CoorY As Integer, tablero As Panel(,), Optional Image As PictureBox = Nothing)
        Dim piece As Integer = setPieces.setPiece
        Select Case piece
            Case 1
                Peon.clearResaltadoPeon(setPieces.Image, tablero)
                Peon.peonMove(setPieces.Image, CoorX, CoorY, tablero)
            Case 2
                Torre.clearHignLight(setPieces.Image, tablero)
                Torre.torreMove(setPieces.Image, CoorX, CoorY, tablero)
            Case 3
                Alfil.clearHignLight(setPieces.Image, tablero)
                Alfil.alfilMove(setPieces.Image, CoorX, CoorY, tablero)
            Case 4
                Caballo.clearHignLight(setPieces.Image, tablero)
                Caballo.caballoMove(setPieces.Image, CoorX, CoorY, tablero)
            Case 5
                Rey.clearHignLight(setPieces.Image, tablero)
                Rey.reyMove(setPieces.Image, CoorX, CoorY, tablero)
            Case 6
                Dama.clearHignLight(setPieces.Image, tablero)
                Dama.damaMove(setPieces.Image, CoorX, CoorY, tablero)
            Case Else
                MessageBox.Show("No se a seleccionado una pieza")
        End Select
    End Sub
End Class
