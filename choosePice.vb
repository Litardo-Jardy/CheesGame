Public Class choosePice
    Private Sub choosePice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If getNPP.colorPiece Then
            Dim TorreBlack As New PictureBox()
            TorreBlack.Image = Image.FromFile("C:\Users\Jardy\Desktop\Piezas\GA_torre_white.png")
            TorreBlack.SizeMode = PictureBoxSizeMode.AutoSize
            Torre.Controls.Add(TorreBlack)
            AddHandler TorreBlack.Click, AddressOf Torre_Click

            Dim AlfilBlack As New PictureBox()
            AlfilBlack.Image = Image.FromFile("C:\Users\Jardy\Desktop\Piezas\GA_alfil_white.png")
            AlfilBlack.SizeMode = PictureBoxSizeMode.AutoSize
            Alfil.Controls.Add(AlfilBlack)
            AddHandler AlfilBlack.Click, AddressOf Alfil_Click

            Dim CaballoBlack As New PictureBox()
            CaballoBlack.Image = Image.FromFile("C:\Users\Jardy\Desktop\Piezas\GA_caballo_white.png")
            CaballoBlack.SizeMode = PictureBoxSizeMode.AutoSize
            Caballo.Controls.Add(CaballoBlack)
            AddHandler CaballoBlack.Click, AddressOf Caballo_Click

            Dim DamaBlack As New PictureBox()
            DamaBlack.Image = Image.FromFile("C:\Users\Jardy\Desktop\Piezas\GA_dama_white.png")
            DamaBlack.SizeMode = PictureBoxSizeMode.AutoSize
            Dama.Controls.Add(DamaBlack)
            AddHandler DamaBlack.Click, AddressOf Dama_Click
        Else
            Dim TorreBlack As New PictureBox()
            TorreBlack.Image = Image.FromFile("C:\Users\Jardy\Desktop\Piezas\GA_torre_black.png")
            TorreBlack.SizeMode = PictureBoxSizeMode.AutoSize
            Torre.Controls.Add(TorreBlack)
            AddHandler TorreBlack.Click, AddressOf Torre_Click

            Dim AlfilBlack As New PictureBox()
            AlfilBlack.Image = Image.FromFile("C:\Users\Jardy\Desktop\Piezas\GA_alfil_black.png")
            AlfilBlack.SizeMode = PictureBoxSizeMode.AutoSize
            Alfil.Controls.Add(AlfilBlack)
            AddHandler AlfilBlack.Click, AddressOf Alfil_Click

            Dim CaballoBlack As New PictureBox()
            CaballoBlack.Image = Image.FromFile("C:\Users\Jardy\Desktop\Piezas\GA_caballo_black.png")
            CaballoBlack.SizeMode = PictureBoxSizeMode.AutoSize
            Caballo.Controls.Add(CaballoBlack)
            AddHandler CaballoBlack.Click, AddressOf Caballo_Click

            Dim DamaBlack As New PictureBox()
            DamaBlack.Image = Image.FromFile("C:\Users\Jardy\Desktop\Piezas\GA_dama_black.png")
            DamaBlack.SizeMode = PictureBoxSizeMode.AutoSize
            Dama.Controls.Add(DamaBlack)
            AddHandler DamaBlack.Click, AddressOf Dama_Click
        End If

    End Sub

    Private Sub Torre_Click(sender As Object, e As EventArgs) Handles Torre.Click
        coronarPeon(getNPP.imagePiece, 1, getNPP.colorPiece, getNPP.coorXPiece, getNPP.coorYPiece)
        Me.Close()
    End Sub

    Private Sub Alfil_Click(sender As Object, e As EventArgs) Handles Alfil.Click
        coronarPeon(getNPP.imagePiece, 2, getNPP.colorPiece, getNPP.coorXPiece, getNPP.coorYPiece)
        Me.Close()
    End Sub

    Private Sub Caballo_Click(sender As Object, e As EventArgs) Handles Caballo.Click
        coronarPeon(getNPP.imagePiece, 3, getNPP.colorPiece, getNPP.coorXPiece, getNPP.coorYPiece)
        Me.Close()
    End Sub

    Private Sub Dama_Click(sender As Object, e As EventArgs) Handles Dama.Click
        coronarPeon(getNPP.imagePiece, 4, getNPP.colorPiece, getNPP.coorXPiece, getNPP.coorYPiece)
        Me.Close()
    End Sub

    Public Sub coronarPeon(Img, piece, isColor, AcoorX, AcoorY)
        Select Case piece
            Case 1
                If isColor Then
                    Img.Image = My.Resources.GA_torre_white

                    Dim newTag As New Coordenadas(AcoorX, AcoorY, isColor, False, 2, False)
                    Img.Tag = newTag
                Else
                    Img.Image = My.Resources.GA_torre_black

                    Dim newTag As New Coordenadas(AcoorX, AcoorY, isColor, False, 2, False)
                    Img.Tag = newTag
                End If
            Case 2
                If isColor Then
                    Img.Image = My.Resources.GA_alfil_white

                    Dim newTag As New Coordenadas(AcoorX, AcoorY, isColor, False, 3, False)
                    Img.Tag = newTag
                Else
                    Img.Image = My.Resources.GA_alfil_black
                    Dim newTag As New Coordenadas(AcoorX, AcoorY, isColor, False, 3, False)
                    Img.Tag = newTag
                End If
            Case 3
                If isColor Then
                    Img.Image = My.Resources.GA_caballo_white

                    Dim newTag As New Coordenadas(AcoorX, AcoorY, isColor, False, 4, False)
                    Img.Tag = newTag
                Else
                    Img.Image = My.Resources.GA_caballo_black

                    Dim newTag As New Coordenadas(AcoorX, AcoorY, isColor, False, 4, False)
                    Img.Tag = newTag
                End If
            Case 4
                If isColor Then
                    Img.Image = My.Resources.GA_dama_white

                    Dim newTag As New Coordenadas(AcoorX, AcoorY, isColor, False, 6, False)
                    Img.Tag = newTag
                Else
                    Img.Image = My.Resources.GA_dama_black

                    Dim newTag As New Coordenadas(AcoorX, AcoorY, isColor, False, 6, False)
                    Img.Tag = newTag
                End If
            Case Else
                MessageBox.Show("No se eligio ninguna pieza")
        End Select
    End Sub

End Class