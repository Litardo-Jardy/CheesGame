Module globalInstancias

    Public Index As Integer = 0
    Private c As Integer = 0
    Dim joinCoor As String
    Public joinMessage As String
    Dim IMess As Integer

    Public setPieces As New pieceSelect
    Public Moves As New executeMove
    Public selectTurn As New Turn
    Public getNPP As New getNewPiecePeon
    Public CP As New capturePassign

    Public Sub winer(value, isColor)
        If value = 5 Then
            If isColor Then
                MsgBox("The winer was " & Tablero.player2)
            Else
                MsgBox("The winer was " & Tablero.player1)
            End If
            Tablero.inicializarTablero()
        End If
    End Sub

    Public Sub PararSub(isColor)
        If isColor Then
            'AddHandler Tablero.timer2.Tick, AddressOf Tablero.Timer_Tick1
            Tablero.Timer1.Stop()
            Tablero.timer2.Start()
        Else
            Tablero.timer2.Stop()
            Tablero.Timer1.Start()
            ' AddHandler Tablero.Timer1.Tick, AddressOf Tablero.Timer_Tick
        End If
    End Sub

    Public Sub recordCoor(coorX As Integer, coorY As Integer, isColor As Boolean, isEat As Integer, Optional colunmBefore As Integer = 8)

        Dim eat As String = ""
        Dim column As String = ""
        Dim coorX_S As String
        Dim coorY_S As String

        Select Case colunmBefore

            Case 0
                column = "a"
            Case 1
                column = "b"
            Case 2
                column = "c"
            Case 3
                column = "d"
            Case 4
                column = "e"
            Case 5
                column = "f"
            Case 6
                column = "g"
            Case 7
                column = "h"

        End Select

        Select Case coorX

            Case 0
                coorX_S = "a"
            Case 1
                coorX_S = "b"
            Case 2
                coorX_S = "c"
            Case 3
                coorX_S = "d"
            Case 4
                coorX_S = "e"
            Case 5
                coorX_S = "f"
            Case 6
                coorX_S = "g"
            Case 7
                coorX_S = "h"

        End Select

        Select Case coorY

            Case 0
                coorY_S = "8"
            Case 1
                coorY_S = "7"
            Case 2
                coorY_S = "6"
            Case 3
                coorY_S = "5"
            Case 4
                coorY_S = "4"
            Case 5
                coorY_S = "3"
            Case 6
                coorY_S = "2"
            Case 7
                coorY_S = "1"

        End Select

        Select Case isEat
            Case 1
                eat = "x"
            Case 2
                eat = column & "x"
        End Select

        c += 1
        Dim lblMoves As New Label
        lblMoves.Size = New Size(206, 333)
        lblMoves.AutoSize = True
        lblMoves.Dock = DockStyle.Left

        lblMoves.Font = New Font("Arial", 8, FontStyle.Bold)

        If isColor Then
            Index += 1
            joinCoor &= "  " & $"{Index}. {eat}{coorX_S}{coorY_S}"
            lblMoves.Text = joinCoor
        Else
            If Index Mod 3 = 0 Then
                joinCoor &= "  " & $" {eat}{coorX_S}{coorY_S}" & vbCrLf
                joinCoor &= "  " & vbCrLf
                lblMoves.Text = joinCoor
            Else
                joinCoor &= " " & $" {eat}{coorX_S}{coorY_S}"
                lblMoves.Text = joinCoor
            End If
        End If

        Tablero.recordMove.Controls.Clear()
        Tablero.recordMove.Controls.Add(lblMoves)
    End Sub

    Public Sub recordMessage(value, move)

        Select Case value
            Case 1
                joinMessage &= move & " move is invalid,  " & vbCrLf & If(selectTurn.turn, Tablero.player1, Tablero.player2) & " - " & If(selectTurn.turn, Tablero.lblTimeWhite.Text, Tablero.lblTimeBlack.Text) & vbCrLf & vbCrLf
            Case 2
                joinMessage &= "It's " & If(selectTurn.turn, Tablero.player1, Tablero.player2) & "'s turn" & vbCrLf & vbCrLf
            Case 3
                joinMessage = " "
        End Select

        Dim lblMessage As New Label
        lblMessage.AutoSize = True
        lblMessage.Size = New Size(206, 333)
        lblMessage.Dock = DockStyle.Bottom
        lblMessage.Font = New Font("Arial", 9, FontStyle.Bold)

        lblMessage.Text = joinMessage

        Tablero.recordMessage.Controls.Clear()
        Tablero.recordMessage.Controls.Add(lblMessage)
        IMess += 1
    End Sub

    Public Sub clearString()
        joinCoor = ""
    End Sub

    Public Sub clearStringMessages()
        joinMessage = ""
    End Sub

    Public Sub startingValues(p1, p2, time)
        Tablero.player1 = p1
        Tablero.player2 = p2
        Tablero.time = time

        Tablero.inicializarTablero()

        Tablero.Timer1.Start()
        Tablero.timer2.Stop()
        Tablero.canTouch = True
    End Sub


End Module
