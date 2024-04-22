Public Class LGCaballo
    Public Sub autoAutoHignLight(Tablero, CoorX, CoorY, iscolor, accion)

        If (CoorX < 8 And CoorX > -1) AndAlso (CoorY < 8 And CoorY > -1) Then
            Dim isImg = isImage(Tablero, CoorX, CoorY)

            For i = 1 To 1
                If isImg Then
                    Dim Img As PictureBox = getImage(Tablero, CoorX, CoorY)
                    Dim CoorImg As Coordenadas = TryCast(Img.Tag, Coordenadas)
                    If CoorImg.IsColor <> iscolor Then

                        Select Case accion
                            Case 1
                                Tablero(CoorX, CoorY).BackColor = Color.FromArgb(250, 253, 254, 152)
                            Case 2
                                Tablero(CoorX, CoorY).BackColor = If((CoorX + CoorY) Mod 2 = 0, Color.White, Color.Brown)
                        End Select

                        Exit For
                    End If
                Else
                    Select Case accion
                        Case 1
                            Tablero(CoorX, CoorY).BackColor = Color.FromArgb(250, 253, 254, 152)
                        Case 2
                            Tablero(CoorX, CoorY).BackColor = If((CoorX + CoorY) Mod 2 = 0, Color.White, Color.Brown)
                    End Select
                End If
            Next
        End If

    End Sub

    Public Sub autoHignLight(image As PictureBox, Tablero As Panel(,))
        Dim coordenadas As Coordenadas = TryCast(image.Tag, Coordenadas)

        If coordenadas.isLife Then
            If selectTurn.turn = coordenadas.IsColor Then

                Dim oneCoorX = coordenadas.X + 1
                Dim twoCoorX = coordenadas.X - 1

                Dim oneCoorY = coordenadas.Y + 2
                Dim twoCoorY = coordenadas.Y - 2

                Dim treeCoorX = coordenadas.X + 2
                Dim fourCoorX = coordenadas.X - 2

                Dim treeCoorY = coordenadas.Y + 1
                Dim fourCoorY = coordenadas.Y - 1

                'Valida hacia los lados

                'Derecha
                autoAutoHignLight(Tablero, treeCoorX, treeCoorY, coordenadas.IsColor, 1)
                autoAutoHignLight(Tablero, treeCoorX, fourCoorY, coordenadas.IsColor, 1)

                'Izquierda
                autoAutoHignLight(Tablero, fourCoorX, treeCoorY, coordenadas.IsColor, 1)
                autoAutoHignLight(Tablero, fourCoorX, fourCoorY, coordenadas.IsColor, 1)

                'Validar hacia arriba y abajo

                'Arriba
                autoAutoHignLight(Tablero, oneCoorX, oneCoorY, coordenadas.IsColor, 1)
                autoAutoHignLight(Tablero, twoCoorX, oneCoorY, coordenadas.IsColor, 1)

                'Abajo
                autoAutoHignLight(Tablero, oneCoorX, twoCoorY, coordenadas.IsColor, 1)
                autoAutoHignLight(Tablero, twoCoorX, twoCoorY, coordenadas.IsColor, 1)

            End If
        End If
    End Sub

    Public Sub clearHignLight(image As PictureBox, Tablero As Panel(,))
        Dim coordenadas As Coordenadas = TryCast(image.Tag, Coordenadas)

        If coordenadas.isLife Then
            If selectTurn.turn = coordenadas.IsColor Then

                Dim oneCoorX = coordenadas.X + 1
                Dim twoCoorX = coordenadas.X - 1

                Dim oneCoorY = coordenadas.Y + 2
                Dim twoCoorY = coordenadas.Y - 2

                Dim treeCoorX = coordenadas.X + 2
                Dim fourCoorX = coordenadas.X - 2

                Dim treeCoorY = coordenadas.Y + 1
                Dim fourCoorY = coordenadas.Y - 1

                'Valida hacia los lados

                'Derecha
                autoAutoHignLight(Tablero, treeCoorX, treeCoorY, coordenadas.IsColor, 2)
                autoAutoHignLight(Tablero, treeCoorX, fourCoorY, coordenadas.IsColor, 2)

                'Izquierda
                autoAutoHignLight(Tablero, fourCoorX, treeCoorY, coordenadas.IsColor, 2)
                autoAutoHignLight(Tablero, fourCoorX, fourCoorY, coordenadas.IsColor, 2)

                'Validar hacia arriba y abajo

                'Arriba
                autoAutoHignLight(Tablero, oneCoorX, oneCoorY, coordenadas.IsColor, 2)
                autoAutoHignLight(Tablero, twoCoorX, oneCoorY, coordenadas.IsColor, 2)

                'Abajo
                autoAutoHignLight(Tablero, oneCoorX, twoCoorY, coordenadas.IsColor, 2)
                autoAutoHignLight(Tablero, twoCoorX, twoCoorY, coordenadas.IsColor, 2)
            End If
        End If
    End Sub

    Public Sub caballoMove(image As PictureBox, CoorX As Integer, CoorY As Integer, Tablero As Panel(,))
        If image IsNot Nothing Then
            Dim Coor As Coordenadas = TryCast(image.Tag, Coordenadas)

            If Coor.isLife Then
                If selectTurn.turn = Coor.IsColor Then
                    If CoorX < 8 Or CoorX > -1 Or CoorY < 8 Or CoorY > -1 Then

                        Dim isImg = isImage(Tablero, CoorX, CoorY)
                        Dim isValidMove As Boolean = False

                        For i = 1 To 8
                            Dim oneCoorX = Coor.X + 1
                            Dim twoCoorX = Coor.X - 1

                            Dim oneCoorY = Coor.Y + 2
                            Dim twoCoorY = Coor.Y - 2

                            Dim treeCoorX = Coor.X + 2
                            Dim fourCoorX = Coor.X - 2

                            Dim treeCoorY = Coor.Y + 1
                            Dim fourCoorY = Coor.Y - 1

                            Dim Array(2) As Integer
                            If i = 1 Then
                                Array(1) = treeCoorX
                                Array(2) = treeCoorY
                            ElseIf i = 2 Then
                                Array(1) = treeCoorX
                                Array(2) = fourCoorY
                            ElseIf i = 3 Then
                                Array(1) = fourCoorX
                                Array(2) = treeCoorY
                            ElseIf i = 4 Then
                                Array(1) = fourCoorX
                                Array(2) = fourCoorY
                            ElseIf i = 5 Then
                                Array(1) = oneCoorX
                                Array(2) = oneCoorY
                            ElseIf i = 6 Then
                                Array(1) = twoCoorX
                                Array(2) = oneCoorY
                            ElseIf i = 7 Then
                                Array(1) = oneCoorX
                                Array(2) = twoCoorY
                            ElseIf i = 8 Then
                                Array(1) = twoCoorX
                                Array(2) = twoCoorY
                            End If

                            If Array(1) = CoorX And Array(2) = CoorY Then
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
                                    globalInstancias.recordMessage(2, "del caballo")
                                End If
                            Else
                                CP.updateValueCapturePassing(False)
                                Tablero(CoorX, CoorY).Controls.Add(image)
                                Dim newTag As New Coordenadas(CoorX, CoorY, Coor.IsColor, False, Coor.thisPiece, False)
                                image.Tag = newTag

                                globalInstancias.PararSub(Coor.IsColor)
                                globalInstancias.recordCoor(CoorX, CoorY, Coor.IsColor, 3)
                                selectTurn.changeTurn(Not Coor.IsColor)
                                globalInstancias.recordMessage(2, "del caballo")
                            End If
                        Else
                            globalInstancias.recordMessage(1, "The knight's")
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
