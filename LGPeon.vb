Imports System.ComponentModel
Imports System.Net.Mime.MediaTypeNames
Imports System.Threading
Public Class LGPeon

    Public Sub autoHignlight(Tablero,
                             coordenadas,
                             index,
                             isColor,
                             thatFunction,
                             Optional Image = Nothing,
                             Optional ACoorX = 0,
                             Optional ACoorY = 0)
        Dim Images As Coordenadas
        If Image IsNot Nothing Then
            Images = TryCast(Image.tag, Coordenadas)
        End If
        Dim array(4) As Integer
        array(0) = coordenadas.X - 1
        array(1) = coordenadas.Y - 1
        array(2) = coordenadas.X + 1

        Dim colorPiece As Boolean = True
        If isColor = False Then
            array(1) = coordenadas.Y + 1
            colorPiece = False
        End If

        Dim isValidate As Boolean = False

        For i = 1 To index
            If isColor = True Then
                array(3) = coordenadas.Y - i
            Else
                array(3) = coordenadas.Y + i
            End If
            If array(3) = 8 Or array(3) = -1 Then
                Exit For
            Else
                'Evalua el las capturas en diagonal de ambos lados;
                Dim isPiece = isImage(Tablero, array(0), array(1))
                If isPiece Then
                    Dim Img As PictureBox = getImage(Tablero, array(0), array(1))
                    Dim Coor As Coordenadas = TryCast(Img.Tag, Coordenadas)
                    If Coor.IsColor <> colorPiece Then
                        If isColor = selectTurn.turn Then
                            Select Case thatFunction
                                Case "Hignlight"
                                    Tablero(array(0), array(1)).BackColor = Color.FromArgb(250, 253, 254, 152)
                                Case "Clear"
                                    Tablero(array(0), array(1)).BackColor = If((array(0) + array(1)) Mod 2 = 0, Color.White, Color.Brown)
                                Case "Move"
                                    If array(0) = ACoorX And array(1) = ACoorY Then
                                        Tablero(ACoorX, ACoorY).Controls.Remove(Img)
                                        Dim removeTag As New Coordenadas(ACoorX, ACoorY, isColor, False, Coor.thisPiece, False, False)
                                        Img.Tag = removeTag

                                        Tablero(ACoorX, ACoorY).Controls.Add(Image)
                                        Dim newTag As New Coordenadas(ACoorX, ACoorY, isColor, False, Images.thisPiece, False)
                                        Image.Tag = newTag

                                        If ACoorY = 7 Or ACoorY = 0 Then
                                            getNPP.updateValuePiece(Image, isColor, ACoorX, ACoorY)
                                            choosePice.Show()
                                        End If

                                        globalInstancias.winer(Coor.thisPiece, Coor.IsColor)
                                        CP.updateValueCapturePassing(False)
                                        globalInstancias.recordCoor(ACoorX, ACoorY, isColor, 2, coordenadas.X)
                                        globalInstancias.PararSub(isColor)
                                        selectTurn.changeTurn(Not isColor)
                                        globalInstancias.recordMessage(2, "the peon")
                                        isValidate = True
                                    End If
                            End Select
                        End If
                    End If
                End If
                Dim isPiece1 = isImage(Tablero, array(2), array(1))
                If isPiece1 Then
                    Dim Img As PictureBox = getImage(Tablero, array(2), array(1))
                    Dim Coor1 As Coordenadas = TryCast(Img.Tag, Coordenadas)
                    If Coor1.IsColor <> colorPiece Then
                        If isColor = selectTurn.turn Then
                            Select Case thatFunction
                                Case "Hignlight"
                                    Tablero(array(2), array(1)).BackColor = Color.FromArgb(250, 253, 254, 152)
                                Case "Clear"
                                    Tablero(array(2), array(1)).BackColor = If((array(2) + array(1)) Mod 2 = 0, Color.White, Color.Brown)
                                Case "Move"
                                    If array(2) = ACoorX And array(1) = ACoorY Then
                                        Tablero(array(2), array(1)).Controls.Remove(Img)
                                        Dim removeTag As New Coordenadas(ACoorX, ACoorY, isColor, False, Coor1.thisPiece, False, False)
                                        Img.Tag = removeTag
                                        Tablero(ACoorX, ACoorY).Controls.Add(Image)
                                        Dim newTag As New Coordenadas(array(2), array(1), isColor, False, Images.thisPiece, False)
                                        Image.Tag = newTag

                                        If ACoorY = 7 Or ACoorY = 0 Then
                                            getNPP.updateValuePiece(Image, isColor, ACoorX, ACoorY)
                                            choosePice.Show()
                                        End If

                                        CP.updateValueCapturePassing(False)
                                        globalInstancias.recordCoor(ACoorX, ACoorY, isColor, 2, coordenadas.X)
                                        globalInstancias.PararSub(isColor)
                                        globalInstancias.winer(Coor1.thisPiece, Coor1.IsColor)
                                        selectTurn.changeTurn(Not isColor)
                                        globalInstancias.recordMessage(2, "the peon")
                                        isValidate = True
                                    End If
                            End Select
                        End If
                    End If
                End If

                'Evalua la captura al paso del peon por ambos lados;
                Dim isPiece3 = isImage(Tablero, array(2), coordenadas.Y)
                If isPiece3 Then
                    Dim Img As PictureBox = getImage(Tablero, array(2), coordenadas.Y)
                    Dim Coor As Coordenadas = TryCast(Img.Tag, Coordenadas)
                    If Coor.IsColor <> colorPiece Then
                        If isColor = selectTurn.turn Then
                            If Coor.capturePassingPosition = True Then
                                Select Case thatFunction
                                    Case "Hignlight"
                                        Tablero(array(2), array(1)).BackColor = Color.FromArgb(250, 253, 254, 152)
                                    Case "Clear"
                                        Tablero(array(2), array(1)).BackColor = If((array(2) + array(1)) Mod 2 = 0, Color.White, Color.Brown)
                                    Case "Move"
                                        If array(2) = ACoorX And array(1) = ACoorY Then
                                            Tablero(array(2), coordenadas.Y).Controls.Remove(Img)
                                            Dim removeTag As New Coordenadas(ACoorX, ACoorY, isColor, False, Coor.thisPiece, True, False)
                                            Img.Tag = removeTag
                                            Tablero(ACoorX, ACoorY).Controls.Add(Image)
                                            Dim newTag As New Coordenadas(array(2), array(1), isColor, False, Images.thisPiece, False)
                                            Image.Tag = newTag

                                            If ACoorY = 7 Or ACoorY = 0 Then
                                                getNPP.updateValuePiece(Image, isColor, ACoorX, ACoorY)
                                                choosePice.Show()
                                            End If

                                            CP.updateValueCapturePassing(False)
                                            globalInstancias.recordCoor(ACoorX, ACoorY, isColor, 2, coordenadas.X)
                                            globalInstancias.PararSub(isColor)
                                            selectTurn.changeTurn(Not isColor)
                                            globalInstancias.recordMessage(2, "the peon")
                                            isValidate = True
                                        End If
                                End Select
                            End If
                        End If
                    End If
                End If
                Dim isPiece4 = isImage(Tablero, array(0), coordenadas.Y)
                If isPiece4 Then
                    Dim Img As PictureBox = getImage(Tablero, array(0), coordenadas.Y)
                    Dim Coor As Coordenadas = TryCast(Img.Tag, Coordenadas)
                    If Coor.IsColor <> colorPiece Then
                        If isColor = selectTurn.turn Then
                            If Coor.capturePassingPosition = True Then
                                Select Case thatFunction
                                    Case "Hignlight"
                                        Tablero(array(0), array(1)).BackColor = Color.FromArgb(250, 253, 254, 152)
                                    Case "Clear"
                                        Tablero(array(0), array(1)).BackColor = If((array(0) + array(1)) Mod 2 = 0, Color.White, Color.Brown)
                                    Case "Move"
                                        If array(0) = ACoorX And array(1) = ACoorY Then
                                            Tablero(array(0), coordenadas.Y).Controls.Remove(Img)
                                            Dim removeTag As New Coordenadas(ACoorX, ACoorY, isColor, False, Coor.thisPiece, False, False)
                                            Img.Tag = removeTag
                                            Tablero(ACoorX, ACoorY).Controls.Add(Image)
                                            Dim newTag As New Coordenadas(array(0), array(1), isColor, False, Images.thisPiece, False)
                                            Image.Tag = newTag

                                            If ACoorY = 7 Or ACoorY = 0 Then
                                                getNPP.updateValuePiece(Image, isColor, ACoorX, ACoorY)
                                                choosePice.Show()
                                            End If

                                            CP.updateValueCapturePassing(False)
                                            globalInstancias.recordCoor(ACoorX, ACoorY, isColor, 2, coordenadas.X)
                                            globalInstancias.PararSub(isColor)
                                            selectTurn.changeTurn(Not isColor)
                                            globalInstancias.recordMessage(2, "the peon")
                                            isValidate = True
                                        End If
                                End Select
                            End If
                        End If
                    End If
                End If


                'Evalua el avanzar hacia delante;
                Dim isPiece2 = isImage(Tablero, coordenadas.X, array(3))
                If isPiece2 <> True Then
                    If isColor = selectTurn.turn Then
                        Select Case thatFunction
                            Case "Hignlight"
                                Tablero(coordenadas.X, array(3)).BackColor = Color.FromArgb(250, 253, 254, 152)
                            Case "Clear"
                                Tablero(coordenadas.X, array(3)).BackColor = If((coordenadas.X + array(3)) Mod 2 = 0, Color.White, Color.Brown)
                            Case "Move"
                                If coordenadas.X = ACoorX And array(3) = ACoorY Then

                                    CP.updateValueCapturePassing(False)
                                    Tablero(ACoorX, ACoorY).Controls.Add(Image)
                                    Dim newTag As New Coordenadas(ACoorX, ACoorY, isColor, False, Images.thisPiece, If((i = 2), True, False))
                                    Image.Tag = newTag


                                    If i = 2 Then
                                        CP.updateValueCapturePassing(True, Image)
                                    End If

                                    If ACoorY = 7 Or ACoorY = 0 Then
                                        getNPP.updateValuePiece(Image, isColor, ACoorX, ACoorY)
                                        choosePice.Show()
                                    End If

                                    globalInstancias.PararSub(isColor)
                                    globalInstancias.recordCoor(ACoorX, ACoorY, isColor, 3)
                                    selectTurn.changeTurn(Not isColor)
                                    globalInstancias.recordMessage(2, "the peon")
                                    isValidate = True
                                End If
                        End Select
                    End If
                Else
                    Exit For
                End If
            End If
        Next
    End Sub

    Public Sub clearResaltadoPeon(image As PictureBox, Tablero As Panel(,))
        Dim coordenadas As Coordenadas = TryCast(image.Tag, Coordenadas)
        Dim posicionInicial = coordenadas.startPosition

        If coordenadas.isLife = True Then
            If coordenadas.IsColor = True Then
                If posicionInicial = True Then
                    autoHignlight(Tablero, coordenadas, 2, True, "Clear")
                Else
                    autoHignlight(Tablero, coordenadas, 1, True, "Clear")
                End If
            Else
                If posicionInicial = True Then
                    autoHignlight(Tablero, coordenadas, 2, False, "Clear")
                Else
                    autoHignlight(Tablero, coordenadas, 1, False, "Clear")
                End If
            End If
        End If
    End Sub

    Public Sub moverPeon(image As PictureBox, Tablero As Panel(,))
        Dim coordenadas As Coordenadas = TryCast(image.Tag, Coordenadas)
        Dim posicionInicial = coordenadas.startPosition

        If coordenadas.isLife = True Then
            If coordenadas.IsColor = True Then
                If posicionInicial = True Then
                    autoHignlight(Tablero, coordenadas, 2, True, "Hignlight")
                Else
                    autoHignlight(Tablero, coordenadas, 1, True, "Hignlight")
                End If
            Else
                If posicionInicial = True Then
                    autoHignlight(Tablero, coordenadas, 2, False, "Hignlight")
                Else
                    autoHignlight(Tablero, coordenadas, 1, False, "Hignlight")
                End If
            End If
        End If

    End Sub

    Private Function isImage(tablero As Panel(,), CoorX As Integer, CoorY As Integer) As Boolean
        If CoorX <> 8 And CoorY <> -1 And CoorY <> 8 And CoorX <> -1 Then
            For Each control In tablero(CoorX, CoorY).Controls
                If TypeOf control Is PictureBox Then
                    Dim pictureBox As PictureBox = DirectCast(control, PictureBox)
                    If pictureBox.Image IsNot Nothing Then
                        Return True
                    End If
                End If
            Next
        End If
        Return False
    End Function

    Private Function getImage(tablero As Panel(,), fila As Integer, columna As Integer) As PictureBox
        Dim panelActual As Panel = tablero(fila, columna)

        If panelActual.Controls.Count > 0 Then
            Dim controlEnPanel As Control = panelActual.Controls(0)
            If TypeOf controlEnPanel Is PictureBox Then
                Dim pictureBox As PictureBox = DirectCast(controlEnPanel, PictureBox)

                Return pictureBox
            End If
        End If
        Return Nothing
    End Function

    Public Sub peonMove(image As PictureBox, CoorX As Integer, CoorY As Integer, tablero As Panel(,))
        Dim coordenadas As Coordenadas = TryCast(image.Tag, Coordenadas)
        Dim posicionInicial = coordenadas.startPosition

        If coordenadas.isLife = True Then
            If coordenadas.IsColor = True Then
                'Mueve el peon blanco dos o un panel hacia adelante;
                If posicionInicial = True Then
                    autoHignlight(tablero, coordenadas, 2, True, "Move", image, CoorX, CoorY)
                Else
                    autoHignlight(tablero, coordenadas, 1, True, "Move", image, CoorX, CoorY)
                End If
            Else
                If posicionInicial = True Then
                    autoHignlight(tablero, coordenadas, 2, False, "Move", image, CoorX, CoorY)
                Else
                    autoHignlight(tablero, coordenadas, 1, False, "Move", image, CoorX, CoorY)
                End If
            End If
        End If

    End Sub
End Class
