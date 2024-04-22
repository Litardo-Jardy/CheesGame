Public Class LGRey

    Dim Torre As LGTorrevb

    Public Sub autoHignLight(image As PictureBox, Tablero As Panel(,))
        Dim Coor As Coordenadas = TryCast(image.Tag, Coordenadas)

        If Coor.isLife Then
            If selectTurn.turn = Coor.IsColor Then

                'Evalua mover dos casillas hacia la derecha
                For i = 1 To 1
                    If Coor.IsColor = False Then
                        Dim isImage1 As Boolean = isImage(Tablero, 7, 0)
                        If isImage1 Then
                            Dim torreIsImage As PictureBox = getImage(Tablero, 7, 0)
                            Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                            If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                Dim isImageTwo = isImage(Tablero, Coor.X + 2, Coor.Y)
                                Dim isImageTree = isImage(Tablero, Coor.X + 1, Coor.Y)
                                Dim isImageFour = isImage(Tablero, Coor.X + 3, Coor.Y)

                                If isImageTwo = False And isImageTree = False And isImageFour = False Then
                                    Tablero(Coor.X + 2, Coor.Y).BackColor = Color.FromArgb(250, 253, 254, 152)
                                Else
                                End If
                            End If
                        End If
                    Else
                        Dim isImage1 As Boolean = isImage(Tablero, 7, 7)
                        If isImage1 Then
                            Dim torreIsImage As PictureBox = getImage(Tablero, 7, 7)
                            Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                            If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                Dim isImageTwo = isImage(Tablero, Coor.X + 2, Coor.Y)
                                Dim isImageTree = isImage(Tablero, Coor.X + 1, Coor.Y)
                                Dim isImageFour = isImage(Tablero, Coor.X + 3, Coor.Y)

                                If isImageTwo = False And isImageTree = False And isImageFour = False Then
                                    Tablero(Coor.X + 2, Coor.Y).BackColor = Color.FromArgb(250, 253, 254, 152)
                                Else
                                End If
                            End If
                        End If
                    End If
                Next

                'Evalua mover dos casillas hacia la izquierda
                For i = 1 To 1
                    If Coor.IsColor = False Then
                        Dim isImage1 As Boolean = isImage(Tablero, 0, 0)
                        If isImage1 Then
                            Dim torreIsImage As PictureBox = getImage(Tablero, 0, 0)
                            Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                            If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                Dim isImageTwo = isImage(Tablero, Coor.X - 2, Coor.Y)
                                Dim isImageTree = isImage(Tablero, Coor.X - 1, Coor.Y)

                                If isImageTwo = False And isImageTree = False Then
                                    Tablero(Coor.X - 2, Coor.Y).BackColor = Color.FromArgb(250, 253, 254, 152)
                                Else
                                End If
                            End If
                        End If
                    Else
                        Dim isImage1 As Boolean = isImage(Tablero, 0, 7)
                        If isImage1 Then
                            Dim torreIsImage As PictureBox = getImage(Tablero, 0, 7)
                            Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                            If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                Dim isImageTwo = isImage(Tablero, Coor.X - 2, Coor.Y)
                                Dim isImageTree = isImage(Tablero, Coor.X - 1, Coor.Y)

                                If isImageTwo = False And isImageTree = False Then
                                    Tablero(Coor.X - 2, Coor.Y).BackColor = Color.FromArgb(250, 253, 254, 152)
                                Else
                                End If
                            End If
                        End If
                    End If
                Next

                'Evalua X hacia la derecha - Recto
                For i = 1 To 1
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

                'Evalua X en  a la derecha - Diagonal
                For i = 1 To 1
                    If (Coor.X + i) < 8 And (Coor.X + i) > -1 And (Coor.Y + i) < 8 And (Coor.Y + i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X + i, Coor.Y + i)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X + i, Coor.Y + i)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X + i, Coor.Y + i).BackColor = Color.FromArgb(250, 253, 254, 152)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X + i, Coor.Y + i).BackColor = Color.FromArgb(250, 253, 254, 152)
                    End If
                Next

                'Evalua Y hacia arriba - Recto
                For i = 1 To 1
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

                'Evalua Y hacia arriba - Diagonal
                For i = 1 To 1
                    If (Coor.Y - i) < 8 And (Coor.Y - i) > -1 And (Coor.X + i) < 8 And (Coor.X + i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X + i, Coor.Y - i)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X + i, Coor.Y - i)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X + i, Coor.Y - i).BackColor = Color.FromArgb(250, 253, 254, 152)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X + i, Coor.Y - i).BackColor = Color.FromArgb(250, 253, 254, 152)
                    End If
                Next

                'Evalua X hacia la izquierda - Recto
                For i = 1 To 1
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

                'Evalua X a la izquierda - Diagonal
                For i = 1 To 1
                    If (Coor.X - i) < 8 And (Coor.X - i) > -1 And (Coor.Y + i) < 8 And (Coor.Y + i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X - i, Coor.Y + i)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X - i, Coor.Y + i)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X - i, Coor.Y + i).BackColor = Color.FromArgb(250, 253, 254, 152)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X - i, Coor.Y + i).BackColor = Color.FromArgb(250, 253, 254, 152)
                    End If
                Next

                'Evalua Y hacia abajo - Recto
                For i = 1 To 1
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

                'Evalua Y hacia abajo - Diagonal
                For i = 1 To 1
                    If (Coor.Y - i) < 8 And (Coor.Y - i) > -1 And (Coor.X - i) < 8 And (Coor.X - i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X - i, Coor.Y - i)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X - i, Coor.Y - i)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X - i, Coor.Y - i).BackColor = Color.FromArgb(250, 253, 254, 152)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X - i, Coor.Y - i).BackColor = Color.FromArgb(250, 253, 254, 152)
                    End If
                Next
            End If
        End If
    End Sub

    Public Sub clearHignLight(image As PictureBox, Tablero As Panel(,))
        Dim Coor As Coordenadas = TryCast(image.Tag, Coordenadas)

        If Coor.isLife Then
            If selectTurn.turn = Coor.IsColor Then

                'Evalua mover dos casillas hacia la derecha
                For i = 1 To 1
                    If Coor.IsColor = False Then
                        Dim isImage1 As Boolean = isImage(Tablero, 7, 0)
                        If isImage1 Then
                            Dim torreIsImage As PictureBox = getImage(Tablero, 7, 0)
                            Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                            If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                Dim isImageTwo = isImage(Tablero, Coor.X + 2, Coor.Y)
                                Dim isImageTree = isImage(Tablero, Coor.X + 1, Coor.Y)
                                Dim isImageFour = isImage(Tablero, Coor.X + 3, Coor.Y)

                                If isImageTwo = False And isImageTree = False And isImageFour = False Then
                                    Tablero(Coor.X + 2, Coor.Y).BackColor = If(((Coor.X + 2) + Coor.Y) Mod 2 = 0, Color.White, Color.Brown)
                                Else
                                End If
                            End If
                        End If
                    Else
                        Dim isImage1 As Boolean = isImage(Tablero, 7, 7)
                        If isImage1 Then
                            Dim torreIsImage As PictureBox = getImage(Tablero, 7, 7)
                            Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                            If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                Dim isImageTwo = isImage(Tablero, Coor.X + 2, Coor.Y)
                                Dim isImageTree = isImage(Tablero, Coor.X + 1, Coor.Y)
                                Dim isImageFour = isImage(Tablero, Coor.X + 3, Coor.Y)

                                If isImageTwo = False And isImageTree = False And isImageFour = False Then
                                    Tablero(Coor.X + 2, Coor.Y).BackColor = If(((Coor.X + 2) + Coor.Y) Mod 2 = 0, Color.White, Color.Brown)
                                Else
                                End If
                            End If
                        End If
                    End If
                Next

                'Evalua mover dos casillas hacia la izquierda
                For i = 1 To 1
                    If Coor.IsColor = False Then
                        Dim isImage1 As Boolean = isImage(Tablero, 0, 0)
                        If isImage1 Then
                            Dim torreIsImage As PictureBox = getImage(Tablero, 0, 0)
                            Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                            If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                Dim isImageTwo = isImage(Tablero, Coor.X - 2, Coor.Y)
                                Dim isImageTree = isImage(Tablero, Coor.X - 1, Coor.Y)

                                If isImageTwo = False And isImageTree = False Then
                                    Tablero(Coor.X - 2, Coor.Y).BackColor = If(((Coor.X - 2) + Coor.Y) Mod 2 = 0, Color.White, Color.Brown)
                                Else
                                End If
                            End If
                        End If
                    Else
                        Dim isImage1 As Boolean = isImage(Tablero, 0, 7)
                        If isImage1 Then
                            Dim torreIsImage As PictureBox = getImage(Tablero, 0, 7)
                            Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                            If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                Dim isImageTwo = isImage(Tablero, Coor.X - 2, Coor.Y)
                                Dim isImageTree = isImage(Tablero, Coor.X - 1, Coor.Y)

                                If isImageTwo = False And isImageTree = False Then
                                    Tablero(Coor.X - 2, Coor.Y).BackColor = If(((Coor.X - 2) + Coor.Y) Mod 2 = 0, Color.White, Color.Brown)
                                Else
                                End If
                            End If
                        End If
                    End If
                Next

                'Evalua X hacia la derecha - Recto
                For i = 1 To 1
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

                'Evalua X en  a la derecha - Diagonal
                For i = 1 To 1
                    If (Coor.X + i) < 8 And (Coor.X + i) > -1 And (Coor.Y + i) < 8 And (Coor.Y + i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X + i, Coor.Y + i)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X + i, Coor.Y + i)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X + i, Coor.Y + i).BackColor = If(((Coor.X + i) + (Coor.Y + i)) Mod 2 = 0, Color.White, Color.Brown)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X + i, Coor.Y + i).BackColor = If(((Coor.X + i) + (Coor.Y + i)) Mod 2 = 0, Color.White, Color.Brown)
                    End If
                Next

                'Evalua Y hacia arriba - Recto
                For i = 1 To 1
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

                'Evalua Y hacia arriba - Diagonal
                For i = 1 To 1
                    If (Coor.Y - i) < 8 And (Coor.Y - i) > -1 And (Coor.X + i) < 8 And (Coor.X + i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X + i, Coor.Y - i)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X + i, Coor.Y - i)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X + i, Coor.Y - i).BackColor = If(((Coor.X + i) + (Coor.Y - i)) Mod 2 = 0, Color.White, Color.Brown)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X + i, Coor.Y - i).BackColor = If(((Coor.X + i) + (Coor.Y - i)) Mod 2 = 0, Color.White, Color.Brown)
                    End If
                Next

                'Evalua X hacia la izquierda - Recto
                For i = 1 To 1
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

                'Evalua X a la izquierda - Diagonal
                For i = 1 To 1
                    If (Coor.X - i) < 8 And (Coor.X - i) > -1 And (Coor.Y + i) < 8 And (Coor.Y + i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X - i, Coor.Y + i)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X - i, Coor.Y + i)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X - i, Coor.Y + i).BackColor = If(((Coor.X - i) + (Coor.Y + i)) Mod 2 = 0, Color.White, Color.Brown)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X - i, Coor.Y + i).BackColor = If(((Coor.X - i) + (Coor.Y + i)) Mod 2 = 0, Color.White, Color.Brown)
                    End If
                Next

                'Evalua Y hacia abajo - Recto
                For i = 1 To 1
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

                'Evalua Y hacia abajo - Diagonal
                For i = 1 To 1
                    If (Coor.Y - i) < 8 And (Coor.Y - i) > -1 And (Coor.X - i) < 8 And (Coor.X - i) > -1 Then
                        Dim isImg = isImage(Tablero, Coor.X - i, Coor.Y - i)
                        If isImg Then
                            Dim Img As PictureBox = getImage(Tablero, Coor.X - i, Coor.Y - i)
                            Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                            If CoorImg.IsColor <> Coor.IsColor Then
                                Tablero(Coor.X - i, Coor.Y - i).BackColor = If(((Coor.X - i) + (Coor.Y - i)) Mod 2 = 0, Color.White, Color.Brown)
                            End If
                            Exit For
                        End If
                        Tablero(Coor.X - i, Coor.Y - i).BackColor = If(((Coor.X - i) + (Coor.Y - i)) Mod 2 = 0, Color.White, Color.Brown)
                    End If
                Next
            End If
        End If
    End Sub

    Public Sub reyMove(image As PictureBox, CoorX As Integer, CoorY As Integer, Tablero As Panel(,))

        If image IsNot Nothing Then
            Dim Coor As Coordenadas = TryCast(image.Tag, Coordenadas)

            If Coor.isLife Then
                If selectTurn.turn = Coor.IsColor Then
                    If CoorX < 8 Or CoorX > -1 Or CoorY < 8 Or CoorY > -1 Then

                        Dim isImg = isImage(Tablero, CoorX, CoorY)
                        Dim isValidMove As Boolean = False

                        'Evalua mover dos casillas hacia la izquierda
                        For i = 1 To 1
                            If Coor.IsColor = False Then
                                Dim isImage1 As Boolean = isImage(Tablero, 0, 0)
                                If isImage1 Then
                                    Dim torreIsImage As PictureBox = getImage(Tablero, 0, 0)
                                    Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                                    If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                        Dim isImageTwo = isImage(Tablero, Coor.X - 2, Coor.Y)
                                        Dim isImageTree = isImage(Tablero, Coor.X - 1, Coor.Y)

                                        If isImageTwo = False And isImageTree = False Then
                                            If Coor.X - 2 = CoorX And Coor.Y = CoorY Then

                                                'Mueve la torre
                                                Tablero(Coor.X - 1, Coor.Y).Controls.Add(torreIsImage)
                                                Dim newTag As New Coordenadas(Coor.X - 1, Coor.Y, tagTorreIsImage.IsColor, False, tagTorreIsImage.thisPiece, False)
                                                torreIsImage.Tag = newTag
                                                'Permitira mover el rey
                                                isValidMove = True
                                                Exit For
                                            End If
                                        End If
                                    End If
                                End If
                            Else
                                Dim isImage1 As Boolean = isImage(Tablero, 0, 7)
                                If isImage1 Then
                                    Dim torreIsImage As PictureBox = getImage(Tablero, 0, 7)
                                    Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                                    If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                        Dim isImageTwo = isImage(Tablero, Coor.X - 2, Coor.Y)
                                        Dim isImageTree = isImage(Tablero, Coor.X - 1, Coor.Y)

                                        If isImageTwo = False And isImageTree = False Then
                                            If Coor.X - 2 = CoorX And Coor.Y = CoorY Then

                                                'Mueve la torre
                                                Tablero(Coor.X - 1, Coor.Y).Controls.Add(torreIsImage)
                                                Dim newTag As New Coordenadas(Coor.X - 1, Coor.Y, tagTorreIsImage.IsColor, False, tagTorreIsImage.thisPiece, False)
                                                torreIsImage.Tag = newTag
                                                'Permitira mover el rey
                                                isValidMove = True
                                                Exit For
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Next

                        For i = 1 To 1
                            If Coor.IsColor = False Then
                                Dim isImage1 As Boolean = isImage(Tablero, 7, 0)
                                If isImage1 Then
                                    Dim torreIsImage As PictureBox = getImage(Tablero, 7, 0)
                                    Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                                    If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                        Dim isImageOne = isImage(Tablero, Coor.X + 3, Coor.Y)
                                        Dim isImageTwo = isImage(Tablero, Coor.X + 2, Coor.Y)
                                        Dim isImageTree = isImage(Tablero, Coor.X + 1, Coor.Y)

                                        If isImageOne = False And isImageTwo = False And isImageTree = False Then
                                            If Coor.X + 2 = CoorX And Coor.Y = CoorY Then

                                                'Mueve la torre
                                                Tablero(Coor.X + 1, Coor.Y).Controls.Add(torreIsImage)
                                                Dim newTag As New Coordenadas(Coor.X + 1, Coor.Y, tagTorreIsImage.IsColor, False, tagTorreIsImage.thisPiece, False)
                                                torreIsImage.Tag = newTag
                                                'Permitira mover el rey
                                                isValidMove = True
                                                Exit For
                                            End If
                                        End If
                                    End If
                                End If
                            Else
                                Dim isImage1 As Boolean = isImage(Tablero, 7, 7)
                                If isImage1 Then
                                    Dim torreIsImage As PictureBox = getImage(Tablero, 7, 7)
                                    Dim tagTorreIsImage As Coordenadas = TryCast(torreIsImage.Tag, Coordenadas)

                                    If tagTorreIsImage.startPosition = True And Coor.startPosition = True Then
                                        Dim isImageOne = isImage(Tablero, Coor.X + 3, Coor.Y)
                                        Dim isImageTwo = isImage(Tablero, Coor.X + 2, Coor.Y)
                                        Dim isImageTree = isImage(Tablero, Coor.X + 1, Coor.Y)

                                        If isImageOne = False And isImageTwo = False And isImageTree = False Then
                                            If Coor.X + 2 = CoorX And Coor.Y = CoorY Then

                                                'Mueve la torre
                                                Tablero(Coor.X + 1, Coor.Y).Controls.Add(torreIsImage)
                                                Dim newTag As New Coordenadas(Coor.X + 1, Coor.Y, tagTorreIsImage.IsColor, False, tagTorreIsImage.thisPiece, False)
                                                torreIsImage.Tag = newTag
                                                'Permitira mover el rey
                                                isValidMove = True
                                                Exit For
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Next

                        For i = 1 To 8

                            Dim oneCoorX = Coor.X + 1
                            Dim twoCoorX = Coor.X - 1

                            Dim oneCoorY = Coor.Y + 1
                            Dim twoCoorY = Coor.Y - 1

                            Dim treeCoorX = Coor.X + 2
                            Dim fourCoorX = Coor.X - 2

                            Dim array(4) As Integer
                            array(3) = 8
                            array(4) = 8
                            If i = 1 Then
                                array(1) = Coor.X
                                array(2) = oneCoorY
                            ElseIf i = 2 Then
                                array(1) = oneCoorX
                                array(2) = oneCoorY
                            ElseIf i = 3 Then
                                array(1) = oneCoorX
                                array(2) = Coor.Y
                            ElseIf i = 4 Then
                                array(1) = oneCoorX
                                array(2) = twoCoorY
                            ElseIf i = 5 Then
                                array(1) = Coor.X
                                array(2) = twoCoorY
                            ElseIf i = 6 Then
                                array(1) = twoCoorX
                                array(2) = twoCoorY
                            ElseIf i = 7 Then
                                array(1) = twoCoorX
                                array(2) = Coor.Y
                            ElseIf i = 8 Then
                                array(1) = twoCoorX
                                array(2) = oneCoorY
                            End If

                            If array(1) = CoorX And array(2) = CoorY Then

                                isValidMove = True
                                Exit For
                            End If

                        Next

                        If isValidMove Then
                            If isImg Then
                                Dim ImgEat = getImage(Tablero, CoorX, CoorY)
                                Dim Img As Coordenadas = TryCast(ImgEat.Tag, Coordenadas)

                                If Coor.IsColor <> Img.IsColor Then
                                    CP.updateValueCapturePassing(False)
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
                                    globalInstancias.recordMessage(2, "del rey")
                                End If
                            Else
                                CP.updateValueCapturePassing(False)
                                Tablero(CoorX, CoorY).Controls.Add(image)
                                Dim newTag As New Coordenadas(CoorX, CoorY, Coor.IsColor, False, Coor.thisPiece, False)
                                image.Tag = newTag

                                globalInstancias.PararSub(Coor.IsColor)
                                globalInstancias.recordCoor(CoorX, CoorY, Coor.IsColor, 3)
                                selectTurn.changeTurn(Not Coor.IsColor)
                                globalInstancias.recordMessage(2, "the rey")
                            End If
                        Else
                            globalInstancias.recordMessage(1, "The king's")
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
