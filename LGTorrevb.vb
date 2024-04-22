Imports System.Net.Mime.MediaTypeNames

Public Class LGTorrevb
    Public Sub clearHignLight(image As PictureBox, Tablero As Panel(,))
        If image IsNot Nothing Then
            Dim Coor As Coordenadas = TryCast(image.Tag, Coordenadas)

            If Coor.isLife Then
                If selectTurn.turn = Coor.IsColor Then
                    For i = 1 To 7
                        If (Coor.X + i) < 8 And (Coor.X + i) > -1 Then
                            Dim isImg = isImage(Tablero, Coor.X + i, Coor.Y)
                            If isImg Then
                                Dim Img As PictureBox = getImage(Tablero, Coor.X + i, Coor.Y)
                                Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                                If CoorImg.IsColor <> Coor.IsColor Then
                                    Tablero(Coor.X + i, Coor.Y).BackColor = If(((Coor.X + i) + Coor.Y) Mod 2 = 0, Color.White, Color.Brown)
                                End If
                                Exit For
                            End If
                            Tablero(Coor.X + i, Coor.Y).BackColor = If(((Coor.X + i) + Coor.Y) Mod 2 = 0, Color.White, Color.Brown)
                        End If
                    Next

                    For i = 1 To 7
                        If (Coor.Y + i) < 8 And (Coor.Y + i) > -1 Then
                            Dim isImg = isImage(Tablero, Coor.X, Coor.Y + i)
                            If isImg Then
                                Dim Img As PictureBox = getImage(Tablero, Coor.X, Coor.Y + i)
                                Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                                If CoorImg.IsColor <> Coor.IsColor Then
                                    Tablero(Coor.X, Coor.Y + i).BackColor = If((Coor.X + (Coor.Y + i)) Mod 2 = 0, Color.White, Color.Brown)
                                End If
                                Exit For
                            End If
                            Tablero(Coor.X, Coor.Y + i).BackColor = If((Coor.X + (Coor.Y + i)) Mod 2 = 0, Color.White, Color.Brown)
                        End If
                    Next

                    For i = 1 To 7
                        If (Coor.X - i) < 8 And (Coor.X - i) > -1 Then
                            Dim isImg = isImage(Tablero, Coor.X - i, Coor.Y)
                            If isImg Then
                                Dim Img As PictureBox = getImage(Tablero, Coor.X - i, Coor.Y)
                                Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                                If CoorImg.IsColor <> Coor.IsColor Then
                                    Tablero(Coor.X - i, Coor.Y).BackColor = If(((Coor.X - i) + Coor.Y) Mod 2 = 0, Color.White, Color.Brown)
                                End If
                                Exit For
                            End If
                            Tablero(Coor.X - i, Coor.Y).BackColor = If(((Coor.X - i) + Coor.Y) Mod 2 = 0, Color.White, Color.Brown)
                        End If
                    Next

                    For i = 1 To 7
                        If (Coor.Y - i) < 8 And (Coor.Y - i) > -1 Then
                            Dim isImg = isImage(Tablero, Coor.X, Coor.Y - i)
                            If isImg Then
                                Dim Img As PictureBox = getImage(Tablero, Coor.X, Coor.Y - i)
                                Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                                If CoorImg.IsColor <> Coor.IsColor Then
                                    Tablero(Coor.X, Coor.Y - i).BackColor = If((Coor.X + (Coor.Y - i)) Mod 2 = 0, Color.White, Color.Brown)
                                End If
                                Exit For
                            End If
                            Tablero(Coor.X, Coor.Y - i).BackColor = If((Coor.X + (Coor.Y - i)) Mod 2 = 0, Color.White, Color.Brown)
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Public Sub autoHignLight(image As PictureBox, Tablero As Panel(,))
        Dim Coor As Coordenadas = TryCast(image.Tag, Coordenadas)

        If Coor.isLife Then
            If selectTurn.turn = Coor.IsColor Then

                'Evalua X hacia la derecha
                For i = 1 To 7
                    If (Coor.X + i) < 8 And (Coor.X + i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X + i, Coor.Y)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X + i, Coor.Y)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X + i, Coor.Y).BackColor = Color.FromArgb(250, 253, 254, 152)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X + i, Coor.Y).BackColor = Color.FromArgb(250, 253, 254, 152)
                    End If
                Next

                'Evalua y hacia arriba
                For i = 1 To 7
                    If (Coor.Y + i) < 8 And (Coor.Y + i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X, Coor.Y + i)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X, Coor.Y + i)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X, Coor.Y + i).BackColor = Color.FromArgb(250, 253, 254, 152)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X, Coor.Y + i).BackColor = Color.FromArgb(250, 253, 254, 152)
                    End If
                Next

                'Evalua X hacia la izquierda
                For i = 1 To 7
                    If (Coor.X - i) < 8 And (Coor.X - i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X - i, Coor.Y)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X - i, Coor.Y)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X - i, Coor.Y).BackColor = Color.FromArgb(250, 253, 254, 152)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X - i, Coor.Y).BackColor = Color.FromArgb(250, 253, 254, 152)
                    End If
                Next

                'Evalua Y hacia abajo
                For i = 1 To 7
                    If (Coor.Y - i) < 8 And (Coor.Y - i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X, Coor.Y - i)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X, Coor.Y - i)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X, Coor.Y - i).BackColor = Color.FromArgb(250, 253, 254, 152)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X, Coor.Y - i).BackColor = Color.FromArgb(250, 253, 254, 152)
                    End If
                Next
            End If
        End If
    End Sub

    Public Sub torreMove(image As PictureBox, CoorX As Integer, CoorY As Integer, Tablero As Panel(,))

        If image IsNot Nothing Then
            Dim Coor As Coordenadas = TryCast(image.Tag, Coordenadas)

            If Coor.isLife Then
                If selectTurn.turn = Coor.IsColor Then
                    If CoorX < 8 Or CoorX > -1 Or CoorY < 8 Or CoorY > -1 Then

                        Dim isImg = isImage(Tablero, CoorX, CoorY)
                        Dim isValidMove As Boolean = False

                        'Evalua X a la derecha - Recto
                        For i = 1 To (CoorX - Coor.X)
                            If (Coor.X + i) < 8 And (Coor.X + i) > -1 Then
                                Dim isImg2 = isImage(Tablero, Coor.X + i, Coor.Y)

                                If isImg2 Then
                                    Dim Img As PictureBox = getImage(Tablero, Coor.X + i, Coor.Y)
                                    Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)

                                    If Coor.X + i = CoorX And Coor.Y = CoorY Then
                                        If CoorImg.IsColor <> Coor.IsColor Then
                                            isValidMove = True
                                            Exit For
                                        End If
                                    Else
                                        Exit For
                                    End If
                                    isValidMove = False
                                    Exit For
                                Else
                                    If Coor.X + i = CoorX And Coor.Y = CoorY Then
                                        isValidMove = True
                                        Exit For
                                    End If
                                End If
                            End If
                        Next

                        'Evalua Y hacia arriba - Recto
                        For i = 1 To (CoorY - Coor.Y)
                            If (Coor.Y + i) < 8 And (Coor.Y + i) > -1 Then
                                Dim isImg2 = isImage(Tablero, Coor.X, Coor.Y + i)

                                If isImg2 Then
                                    Dim Img As PictureBox = getImage(Tablero, Coor.X, Coor.Y + i)
                                    Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)

                                    If Coor.X = CoorX And Coor.Y + i = CoorY Then
                                        If CoorImg.IsColor <> Coor.IsColor Then
                                            isValidMove = True
                                            Exit For
                                        End If
                                    Else
                                        Exit For
                                    End If
                                    isValidMove = False
                                    Exit For
                                Else
                                    If Coor.X = CoorX And Coor.Y + i = CoorY Then
                                        isValidMove = True
                                        Exit For
                                    End If
                                End If
                            End If
                        Next

                        'Evalua X a la izquierda - Recto
                        For i = 1 To (Coor.X - CoorX)
                            If (Coor.X - i) < 8 And (Coor.X - i) > -1 Then
                                Dim isImg2 = isImage(Tablero, Coor.X - i, Coor.Y)

                                If isImg2 Then
                                    Dim Img As PictureBox = getImage(Tablero, Coor.X - i, Coor.Y)
                                    Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)

                                    If Coor.X - i = CoorX And Coor.Y = CoorY Then
                                        If CoorImg.IsColor <> Coor.IsColor Then
                                            isValidMove = True
                                            Exit For
                                        End If
                                    Else
                                        Exit For
                                    End If
                                    isValidMove = False
                                    Exit For
                                Else
                                    If Coor.X - i = CoorX And Coor.Y = CoorY Then
                                        isValidMove = True
                                        Exit For
                                    End If
                                End If
                            End If
                        Next

                        'Evalua Y hacia abajo - Recto
                        For i = 1 To (Coor.Y - CoorY)
                            If (Coor.Y - i) < 8 And (Coor.Y - i) > -1 Then
                                Dim isImg2 = isImage(Tablero, Coor.X, Coor.Y - i)

                                If isImg2 Then
                                    Dim Img As PictureBox = getImage(Tablero, Coor.X, Coor.Y - i)
                                    Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)

                                    If Coor.X = CoorX And Coor.Y - i = CoorY Then
                                        If CoorImg.IsColor <> Coor.IsColor Then
                                            isValidMove = True
                                            Exit For
                                        End If
                                    Else
                                        Exit For
                                    End If
                                    isValidMove = False
                                    Exit For
                                Else
                                    If Coor.X = CoorX And Coor.Y - i = CoorY Then
                                        isValidMove = True
                                        Exit For
                                    End If
                                End If
                            End If
                        Next

                        If isValidMove Then
                            If isImg Then
                                Dim ImgEat = getImage(Tablero, CoorX, CoorY)
                                Dim Img As Coordenadas = TryCast(ImgEat.Tag, Coordenadas)

                                If Coor.IsColor <> Img.IsColor Then
                                    Tablero(CoorX, CoorY).Controls.Remove(ImgEat)
                                    Dim removeTag As New Coordenadas(CoorX, CoorY, Img.IsColor, False, Img.thisPiece, False, False)
                                    ImgEat.Tag = removeTag

                                    Tablero(CoorX, CoorY).Controls.Add(image)
                                    Dim newTag As New Coordenadas(CoorX, CoorY, Coor.IsColor, False, Coor.thisPiece, False)
                                    image.Tag = newTag

                                    globalInstancias.PararSub(Coor.IsColor)
                                    globalInstancias.recordCoor(CoorX, CoorY, Coor.IsColor, 1)
                                    globalInstancias.winer(Img.thisPiece, Img.IsColor)
                                    selectTurn.changeTurn(Not Coor.IsColor)
                                    globalInstancias.recordMessage(2, "la torre")
                                    CP.updateValueCapturePassing(False)
                                End If
                            Else
                                Tablero(CoorX, CoorY).Controls.Add(image)
                                Dim newTag As New Coordenadas(CoorX, CoorY, Coor.IsColor, False, Coor.thisPiece, False)
                                image.Tag = newTag


                                globalInstancias.PararSub(Coor.IsColor)
                                globalInstancias.recordCoor(CoorX, CoorY, Coor.IsColor, 3)
                                selectTurn.changeTurn(Not Coor.IsColor)
                                globalInstancias.recordMessage(2, "the torre")
                                CP.updateValueCapturePassing(False)
                            End If
                        Else
                            globalInstancias.recordMessage(1, "The rook's")
                        End If

                    End If
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

End Class
