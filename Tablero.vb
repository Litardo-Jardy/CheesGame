
Imports System.Reflection
Imports System.Threading

Public Class Tablero

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    'Nombres de jugadores
    Public player1 As String
    Public player2 As String
    Public time As Integer

    'Valida para ver si se pueden tocar las piezas
    Public canTouch As Boolean

    'Cuenta regresiva
    Private tiempoRestante As Integer = time * 60
    Private tiempoRestanteblack As Integer = time * 60

    Public Sub Timer_Tick(sender As Object, e As EventArgs)
        If tiempoRestante > 0 Then
            tiempoRestante -= 1
            ActualizarLabelTiempo()
        Else
            Timer1.Stop()
            MsgBox("The winer was " & player1)
            inicializarTablero()
        End If
    End Sub

    Public Sub Timer_Tick1(sender As Object, e As EventArgs)
        If tiempoRestanteblack > 0 Then
            tiempoRestanteblack -= 1
            ActualizarLabelTiempo1()
        Else
            timer2.Stop()
            MsgBox("The winer was " & player2)
            inicializarTablero()
        End If
    End Sub

    Public Sub ActualizarLabelTiempo()
        Dim minutos As Integer = tiempoRestante \ 60
        Dim segundos As Integer = tiempoRestante Mod 60
        lblTimeWhite.Text = $"{minutos.ToString("00")}:{segundos.ToString("00")}"
    End Sub

    Private Sub ActualizarLabelTiempo1()
        Dim minutos As Integer = tiempoRestanteblack \ 60
        Dim segundos As Integer = tiempoRestanteblack Mod 60
        lblTimeBlack.Text = $"{minutos.ToString("00")}:{segundos.ToString("00")}"
    End Sub

    'Clases que contienen la logica de las piezas 
    Dim Peon As New LGPeon
    Dim Caballo As New LGCaballo
    Dim Torre As New LGTorrevb
    Dim Alfin As New LGAlfil
    Dim Rey As New LGRey
    Dim Dama As New LGDama

    'Funcion que devuelve la celda donde se a hecho click en el tablero;
    Private Function BuscarCoordenadasCelda(celda As Panel) As Point
        For i = 0 To 7
            For j = 0 To 7
                If tablero(i, j) Is celda Then
                    Return New Point(i, j)
                End If
            Next
        Next
        Return Point.Empty
    End Function

    'Piezas
    Public imgPeonWhite As New PictureBox()
    Public imgPeonWhite1 As New PictureBox()
    Public imgPeonWhite2 As New PictureBox()
    Public imgPeonWhite3 As New PictureBox()
    Public imgPeonWhite4 As New PictureBox()
    Public imgPeonWhite5 As New PictureBox()
    Public imgPeonWhite6 As New PictureBox()
    Public imgPeonWhite7 As New PictureBox()

    'Tablero
    Public tablero(7, 7) As Panel

    Public Sub inicializarTablero()
        pnl_tablero.Controls.Clear()
        Dim celdaAncho As Integer = 90
        Dim celdaAltura As Integer = 90

        For i = 0 To 7
            For j = 0 To 7
                tablero(i, j) = New Panel With {
                    .Size = New Size(celdaAncho, celdaAltura),
                    .Location = New Point(i * celdaAncho, j * celdaAltura),
                    .BorderStyle = BorderStyle.Fixed3D,
                    .BackColor = If((i + j) Mod 2 = 0, Color.White, Color.Brown)
                }
                AddHandler tablero(i, j).Click, AddressOf Tablero_Click
                pnl_tablero.Controls.Add(tablero(i, j))
            Next
        Next

        '----------------------------------- PIEZAS NEGRAS -------------------------------------
        '----------------------------------- Torres
        Dim imgTorreBlack As New PictureBox()
        imgTorreBlack.Image = My.Resources.GA_torre_black
        imgTorreBlack.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(0, 0).Controls.Add(imgTorreBlack)
        Dim coordenadasTorreNegros2 As New Coordenadas(0, 0, False, True, 2, False)
        imgTorreBlack.Tag = coordenadasTorreNegros2

        Dim imgTorreBlack2 As New PictureBox()
        imgTorreBlack2.Image = My.Resources.GA_torre_black
        imgTorreBlack2.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(7, 0).Controls.Add(imgTorreBlack2)
        Dim coordenadasTorreNegros1 As New Coordenadas(7, 0, False, True, 2, False)
        imgTorreBlack2.Tag = coordenadasTorreNegros1

        AddHandler imgTorreBlack.Click, AddressOf img_Click
        AddHandler imgTorreBlack2.Click, AddressOf img_Click

        AddHandler imgTorreBlack.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgTorreBlack2.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgTorreBlack.LostFocus, AddressOf img_LostFocus
        AddHandler imgTorreBlack2.LostFocus, AddressOf img_LostFocus

        '----------------------------------- Alfiles
        Dim imgAlfilBlack As New PictureBox()
        imgAlfilBlack.Image = My.Resources.GA_alfil_black
        imgAlfilBlack.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(2, 0).Controls.Add(imgAlfilBlack)
        Dim coordenadasAlfilNegros1 As New Coordenadas(2, 0, False, True, 3, False)
        imgAlfilBlack.Tag = coordenadasAlfilNegros1


        Dim imgAlfilBlack2 As New PictureBox()
        imgAlfilBlack2.Image = My.Resources.GA_alfil_black
        imgAlfilBlack2.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(5, 0).Controls.Add(imgAlfilBlack2)
        Dim coordenadasAlfilNegros2 As New Coordenadas(5, 0, False, True, 3, False)
        imgAlfilBlack2.Tag = coordenadasAlfilNegros2

        AddHandler imgAlfilBlack.Click, AddressOf img_Click
        AddHandler imgAlfilBlack2.Click, AddressOf img_Click

        AddHandler imgAlfilBlack.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgAlfilBlack2.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgAlfilBlack.LostFocus, AddressOf img_LostFocus
        AddHandler imgAlfilBlack2.LostFocus, AddressOf img_LostFocus

        '----------------------------------- Caballos
        Dim imgCaballoBlack As New PictureBox()
        imgCaballoBlack.Image = My.Resources.GA_caballo_black
        imgCaballoBlack.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(1, 0).Controls.Add(imgCaballoBlack)
        Dim coordenadasCbllB As New Coordenadas(1, 0, False, True, 4, False)
        imgCaballoBlack.Tag = coordenadasCbllB

        Dim imgCaballoBlack2 As New PictureBox()
        imgCaballoBlack2.Image = My.Resources.GA_caballo_black
        imgCaballoBlack2.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(6, 0).Controls.Add(imgCaballoBlack2)
        Dim coordenadasCbllB2 As New Coordenadas(6, 0, False, True, 4, False)
        imgCaballoBlack2.Tag = coordenadasCbllB2

        AddHandler imgCaballoBlack.Click, AddressOf img_Click
        AddHandler imgCaballoBlack2.Click, AddressOf img_Click
        AddHandler imgCaballoBlack.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgCaballoBlack2.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgCaballoBlack.LostFocus, AddressOf img_LostFocus
        AddHandler imgCaballoBlack2.LostFocus, AddressOf img_LostFocus

        '----------------------------------- Peones
        Dim imgPeonBlack As New PictureBox()
        imgPeonBlack.Image = My.Resources.GA_peon_black
        imgPeonBlack.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(0, 1).Controls.Add(imgPeonBlack)
        Dim coordenadasB As New Coordenadas(0, 1, False, True, 1, False)
        imgPeonBlack.Tag = coordenadasB

        Dim imgPeonBlack1 As New PictureBox()
        imgPeonBlack1.Image = My.Resources.GA_peon_black
        imgPeonBlack1.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(1, 1).Controls.Add(imgPeonBlack1)
        Dim coordenadasB1 As New Coordenadas(1, 1, False, True, 1, False)
        imgPeonBlack1.Tag = coordenadasB1

        Dim imgPeonBlack2 As New PictureBox()
        imgPeonBlack2.Image = My.Resources.GA_peon_black
        imgPeonBlack2.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(2, 1).Controls.Add(imgPeonBlack2)
        Dim coordenadasB2 As New Coordenadas(2, 1, False, True, 1, False)
        imgPeonBlack2.Tag = coordenadasB2

        Dim imgPeonBlack3 As New PictureBox()
        imgPeonBlack3.Image = My.Resources.GA_peon_black
        imgPeonBlack3.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(3, 1).Controls.Add(imgPeonBlack3)
        Dim coordenadasB3 As New Coordenadas(3, 1, False, True, 1, False)
        imgPeonBlack3.Tag = coordenadasB3

        Dim imgPeonBlack4 As New PictureBox()
        imgPeonBlack4.Image = My.Resources.GA_peon_black
        imgPeonBlack4.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(4, 1).Controls.Add(imgPeonBlack4)
        Dim coordenadasB4 As New Coordenadas(4, 1, False, True, 1, False)
        imgPeonBlack4.Tag = coordenadasB4

        Dim imgPeonBlack5 As New PictureBox()
        imgPeonBlack5.Image = My.Resources.GA_peon_black
        imgPeonBlack5.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(5, 1).Controls.Add(imgPeonBlack5)
        Dim coordenadasB5 As New Coordenadas(5, 1, False, True, 1, False)
        imgPeonBlack5.Tag = coordenadasB5

        Dim imgPeonBlack6 As New PictureBox()
        imgPeonBlack6.Image = My.Resources.GA_peon_black
        imgPeonBlack6.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(6, 1).Controls.Add(imgPeonBlack6)
        Dim coordenadasB6 As New Coordenadas(6, 1, False, True, 1, False)
        imgPeonBlack6.Tag = coordenadasB6

        Dim imgPeonBlack7 As New PictureBox()
        imgPeonBlack7.Image = My.Resources.GA_peon_black
        imgPeonBlack7.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(7, 1).Controls.Add(imgPeonBlack7)
        Dim coordenadasB7 As New Coordenadas(7, 1, False, True, 1, False)
        imgPeonBlack7.Tag = coordenadasB7

        AddHandler imgPeonBlack.Click, AddressOf img_Click
        AddHandler imgPeonBlack1.Click, AddressOf img_Click
        AddHandler imgPeonBlack2.Click, AddressOf img_Click
        AddHandler imgPeonBlack3.Click, AddressOf img_Click
        AddHandler imgPeonBlack4.Click, AddressOf img_Click
        AddHandler imgPeonBlack5.Click, AddressOf img_Click
        AddHandler imgPeonBlack6.Click, AddressOf img_Click
        AddHandler imgPeonBlack7.Click, AddressOf img_Click

        AddHandler imgPeonBlack.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonBlack1.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonBlack2.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonBlack3.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonBlack4.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonBlack5.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonBlack6.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonBlack7.DoubleClick, AddressOf img_DoubleClick

        AddHandler imgPeonBlack.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonBlack1.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonBlack2.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonBlack3.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonBlack4.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonBlack5.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonBlack6.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonBlack7.LostFocus, AddressOf img_LostFocus

        '----------------------------------- Rey
        Dim imgReyBlack As New PictureBox()
        imgReyBlack.Image = My.Resources.GA_rey_black
        imgReyBlack.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(3, 0).Controls.Add(imgReyBlack)
        Dim coordenadasRey = New Coordenadas(3, 0, False, True, 5, False)
        imgReyBlack.Tag = coordenadasRey

        AddHandler imgReyBlack.Click, AddressOf img_Click
        AddHandler imgReyBlack.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgReyBlack.LostFocus, AddressOf img_LostFocus

        '----------------------------------- Dama
        Dim imgDamaBlack As New PictureBox()
        imgDamaBlack.Image = My.Resources.GA_dama_black
        imgDamaBlack.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(4, 0).Controls.Add(imgDamaBlack)
        Dim coordenadasDama = New Coordenadas(4, 0, False, True, 6, False)
        imgDamaBlack.Tag = coordenadasDama

        AddHandler imgDamaBlack.Click, AddressOf img_Click
        AddHandler imgDamaBlack.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgDamaBlack.LostFocus, AddressOf img_LostFocus


        '----------------------------------- PIEZAS BLANCAS -------------------------------------
        '----------------------------------- Torres
        Dim imgTorreWhite As New PictureBox()
        imgTorreWhite.Image = My.Resources.GA_torre_white
        imgTorreWhite.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(0, 7).Controls.Add(imgTorreWhite)
        Dim coordenadasTorre1 = New Coordenadas(0, 7, True, True, 2, False)
        imgTorreWhite.Tag = coordenadasTorre1

        Dim imgTorreWhite2 As New PictureBox()
        imgTorreWhite2.Image = My.Resources.GA_torre_white
        imgTorreWhite2.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(7, 7).Controls.Add(imgTorreWhite2)
        Dim coordenadasTorre2 = New Coordenadas(7, 7, True, True, 2, False)
        imgTorreWhite2.Tag = coordenadasTorre2

        AddHandler imgTorreWhite.Click, AddressOf img_Click
        AddHandler imgTorreWhite2.Click, AddressOf img_Click

        AddHandler imgTorreWhite.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgTorreWhite2.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgTorreWhite.LostFocus, AddressOf img_LostFocus
        AddHandler imgTorreWhite2.LostFocus, AddressOf img_LostFocus

        '----------------------------------- Alfiles
        Dim imgAlfilWhite As New PictureBox()
        imgAlfilWhite.Image = My.Resources.GA_alfil_white
        imgAlfilWhite.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(2, 7).Controls.Add(imgAlfilWhite)
        Dim coordenadasAlfil = New Coordenadas(2, 7, True, True, 3, False)
        imgAlfilWhite.Tag = coordenadasAlfil

        Dim imgAlfilWhite2 As New PictureBox()
        imgAlfilWhite2.Image = My.Resources.GA_alfil_white
        imgAlfilWhite2.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(5, 7).Controls.Add(imgAlfilWhite2)
        Dim coordenadasAlfil1 = New Coordenadas(5, 7, True, True, 3, False)
        imgAlfilWhite2.Tag = coordenadasAlfil1

        AddHandler imgAlfilWhite.Click, AddressOf img_Click
        AddHandler imgAlfilWhite2.Click, AddressOf img_Click
        AddHandler imgAlfilWhite.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgAlfilWhite2.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgAlfilWhite.LostFocus, AddressOf img_LostFocus
        AddHandler imgAlfilWhite2.LostFocus, AddressOf img_LostFocus

        '----------------------------------- Caballos
        Dim imgCaballoWhite As New PictureBox()
        imgCaballoWhite.Image = My.Resources.GA_caballo_white
        imgCaballoWhite.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(1, 7).Controls.Add(imgCaballoWhite)
        Dim coordenadasCbll As New Coordenadas(1, 7, True, True, 4, False)
        imgCaballoWhite.Tag = coordenadasCbll

        Dim imgCaballoWhite2 As New PictureBox()
        imgCaballoWhite2.Image = My.Resources.GA_caballo_white
        imgCaballoWhite2.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(6, 7).Controls.Add(imgCaballoWhite2)
        Dim coordenadasCbll2 As New Coordenadas(6, 7, True, True, 4, False)
        imgCaballoWhite2.Tag = coordenadasCbll2

        AddHandler imgCaballoWhite.Click, AddressOf img_Click
        AddHandler imgCaballoWhite2.Click, AddressOf img_Click
        AddHandler imgCaballoWhite.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgCaballoWhite2.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgCaballoWhite.LostFocus, AddressOf img_LostFocus
        AddHandler imgCaballoWhite2.LostFocus, AddressOf img_LostFocus

        '----------------------------------- Peones
        imgPeonWhite.Image = My.Resources.GA_peon_white
        imgPeonWhite.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(0, 6).Controls.Add(imgPeonWhite)
        Dim coordenadas As New Coordenadas(0, 6, True, True, 1, False)
        imgPeonWhite.Tag = coordenadas

        imgPeonWhite1.Image = My.Resources.GA_peon_white
        imgPeonWhite1.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(1, 6).Controls.Add(imgPeonWhite1)
        Dim coordenadas1 As New Coordenadas(1, 6, True, True, 1, False)
        imgPeonWhite1.Tag = coordenadas1

        imgPeonWhite2.Image = My.Resources.GA_peon_white
        imgPeonWhite2.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(2, 6).Controls.Add(imgPeonWhite2)
        Dim coordenadas2 As New Coordenadas(2, 6, True, True, 1, False)
        imgPeonWhite2.Tag = coordenadas2

        imgPeonWhite3.Image = My.Resources.GA_peon_white
        imgPeonWhite3.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(3, 6).Controls.Add(imgPeonWhite3)
        Dim coordenadas3 As New Coordenadas(3, 6, True, True, 1, False)
        imgPeonWhite3.Tag = coordenadas3

        imgPeonWhite4.Image = My.Resources.GA_peon_white
        imgPeonWhite4.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(4, 6).Controls.Add(imgPeonWhite4)
        Dim coordenadas4 As New Coordenadas(4, 6, True, True, 1, False)
        imgPeonWhite4.Tag = coordenadas4

        imgPeonWhite5.Image = My.Resources.GA_peon_white
        imgPeonWhite5.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(5, 6).Controls.Add(imgPeonWhite5)
        Dim coordenadas5 As New Coordenadas(5, 6, True, True, 1, False)
        imgPeonWhite5.Tag = coordenadas5

        imgPeonWhite6.Image = My.Resources.GA_peon_white
        imgPeonWhite6.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(6, 6).Controls.Add(imgPeonWhite6)
        Dim coordenadas6 As New Coordenadas(6, 6, True, True, 1, False)
        imgPeonWhite6.Tag = coordenadas6

        imgPeonWhite7.Image = My.Resources.GA_peon_white
        imgPeonWhite7.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(7, 6).Controls.Add(imgPeonWhite7)
        Dim coordenadas7 As New Coordenadas(7, 6, True, True, 1, False)
        imgPeonWhite7.Tag = coordenadas7

        AddHandler imgPeonWhite.Click, AddressOf img_Click
        AddHandler imgPeonWhite1.Click, AddressOf img_Click
        AddHandler imgPeonWhite2.Click, AddressOf img_Click
        AddHandler imgPeonWhite3.Click, AddressOf img_Click
        AddHandler imgPeonWhite4.Click, AddressOf img_Click
        AddHandler imgPeonWhite5.Click, AddressOf img_Click
        AddHandler imgPeonWhite6.Click, AddressOf img_Click
        AddHandler imgPeonWhite7.Click, AddressOf img_Click

        AddHandler imgPeonWhite.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonWhite1.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonWhite2.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonWhite3.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonWhite4.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonWhite5.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonWhite6.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgPeonWhite7.DoubleClick, AddressOf img_DoubleClick

        AddHandler imgPeonWhite.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonWhite1.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonWhite2.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonWhite3.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonWhite4.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonWhite5.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonWhite6.LostFocus, AddressOf img_LostFocus
        AddHandler imgPeonWhite7.LostFocus, AddressOf img_LostFocus

        '----------------------------------- Rey
        Dim imgReyWhite As New PictureBox()
        imgReyWhite.Image = My.Resources.GA_rey_white
        imgReyWhite.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(3, 7).Controls.Add(imgReyWhite)
        Dim coordenadas8 = New Coordenadas(3, 7, True, True, 5, False)
        imgReyWhite.Tag = coordenadas8

        AddHandler imgReyWhite.Click, AddressOf img_Click
        AddHandler imgReyWhite.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgReyWhite.LostFocus, AddressOf img_LostFocus

        '----------------------------------- Dama
        Dim imgDamaWhite As New PictureBox()
        imgDamaWhite.Image = My.Resources.GA_dama_white
        imgDamaWhite.SizeMode = PictureBoxSizeMode.AutoSize
        tablero(4, 7).Controls.Add(imgDamaWhite)
        Dim coordenadas9 = New Coordenadas(4, 7, True, True, 6, False)
        imgDamaWhite.Tag = coordenadas9

        AddHandler imgDamaWhite.Click, AddressOf img_Click
        AddHandler imgDamaWhite.DoubleClick, AddressOf img_DoubleClick
        AddHandler imgDamaWhite.LostFocus, AddressOf img_LostFocus

        '------------------------------------ Seleccionado el turno
        selectTurn.changeTurn(True)
        recordMove.Controls.Clear()

        tiempoRestante = time * 60
        tiempoRestanteblack = time * 60

        ActualizarLabelTiempo()
        ActualizarLabelTiempo1()

        Timer1.Stop()
        timer2.Stop()

        globalInstancias.Index = 0
        globalInstancias.clearString()
        globalInstancias.recordMessage(3, "none")

        canTouch = False

    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub Tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarTablero()
        Timer1.Interval = 1000
        AddHandler Timer1.Tick, AddressOf Timer_Tick

        timer2.Interval = 1000
        AddHandler timer2.Tick, AddressOf Timer_Tick1

        Timer1.Stop()
        timer2.Stop()

        canTouch = False
    End Sub

    'Metodos click de los peones;
    Private Sub img_Click(sender As Object, e As EventArgs)

        If canTouch Then
            If setPieces.Image IsNot Nothing Then
                Dim currentCoords As Coordenadas = TryCast(DirectCast(sender, PictureBox).Tag, Coordenadas)
                Dim lastCoords As Coordenadas = TryCast(setPieces.Image.Tag, Coordenadas)

                If currentCoords.X <> lastCoords.X OrElse currentCoords.Y <> lastCoords.Y Then
                    Moves.execute(currentCoords.X, currentCoords.Y, tablero, DirectCast(sender, PictureBox))
                    setPieces.getPiece(currentCoords.thisPiece, DirectCast(sender, PictureBox))
                Else
                    setPieces.getPiece(currentCoords.thisPiece, DirectCast(sender, PictureBox))
                End If
            Else
                Dim currentCoords As Coordenadas = TryCast(DirectCast(sender, PictureBox).Tag, Coordenadas)
                setPieces.getPiece(currentCoords.thisPiece, DirectCast(sender, PictureBox))
            End If


            Dim currentCoords1 As Coordenadas = TryCast(DirectCast(sender, PictureBox).Tag, Coordenadas)
            Select Case currentCoords1.thisPiece
                Case 1
                    If currentCoords1.IsColor = selectTurn.turn Then
                        Peon.moverPeon(DirectCast(sender, PictureBox), tablero)
                    End If
                Case 2
                    If currentCoords1.IsColor = selectTurn.turn Then
                        Torre.autoHignLight(DirectCast(sender, PictureBox), tablero)
                    End If
                Case 3
                    If currentCoords1.IsColor = selectTurn.turn Then
                        Alfin.autoHignLight(DirectCast(sender, PictureBox), tablero)
                    End If
                Case 4
                    If currentCoords1.IsColor = selectTurn.turn Then
                        Caballo.autoHignLight(DirectCast(sender, PictureBox), tablero)
                    End If
                Case 5
                    If currentCoords1.IsColor = selectTurn.turn Then
                        Rey.autoHignLight(DirectCast(sender, PictureBox), tablero)
                    End If
                Case 6
                    If currentCoords1.IsColor = selectTurn.turn Then
                        Dama.autoHignLight(DirectCast(sender, PictureBox), tablero)
                    End If
                Case Else

            End Select
            DirectCast(sender, PictureBox).Focus()
        End If

    End Sub

    Private Sub img_DoubleClick(sender As Object, e As EventArgs)

        If canTouch Then
            Dim clickedImage As PictureBox = DirectCast(sender, PictureBox)
            If setPieces.Image IsNot Nothing Then
                Dim currentCoords As Coordenadas = TryCast(clickedImage.Tag, Coordenadas)
                Select Case currentCoords.thisPiece
                    Case 1
                        Peon.clearResaltadoPeon(DirectCast(sender, PictureBox), tablero)
                    Case 2
                        Torre.clearHignLight(DirectCast(sender, PictureBox), tablero)
                    Case 3
                        Alfin.clearHignLight(DirectCast(sender, PictureBox), tablero)
                    Case 4
                        Caballo.clearHignLight(DirectCast(sender, PictureBox), tablero)
                    Case 5
                        Rey.clearHignLight(DirectCast(sender, PictureBox), tablero)
                    Case 6
                        Dama.clearHignLight(DirectCast(sender, PictureBox), tablero)
                    Case Else

                End Select
            End If
        End If

    End Sub

    Private Sub img_LostFocus(sender As Object, e As EventArgs)

        If canTouch Then
            Dim clickedImage As PictureBox = DirectCast(sender, PictureBox)
            If setPieces.Image IsNot Nothing Then
                Dim currentCoords As Coordenadas = TryCast(clickedImage.Tag, Coordenadas)
                Select Case currentCoords.thisPiece
                    Case 1
                        Peon.clearResaltadoPeon(DirectCast(sender, PictureBox), tablero)
                    Case 2
                        Torre.clearHignLight(DirectCast(sender, PictureBox), tablero)
                    Case 3
                        Alfin.clearHignLight(DirectCast(sender, PictureBox), tablero)
                    Case 4
                        Caballo.clearHignLight(DirectCast(sender, PictureBox), tablero)
                    Case 5
                        Rey.clearHignLight(DirectCast(sender, PictureBox), tablero)
                    Case 6
                        Dama.clearHignLight(DirectCast(sender, PictureBox), tablero)
                    Case Else

                End Select
            End If
        End If

    End Sub

    'Se envia posicion del tablero
    Private Sub Tablero_Click(sender As Object, e As EventArgs)

        If canTouch Then
            Dim celdaClic As Panel = DirectCast(sender, Panel)
            Dim coordenadas As Point = BuscarCoordenadasCelda(celdaClic)
            DirectCast(sender, Panel).Focus()
            Moves.execute(coordenadas.X, coordenadas.Y, tablero)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button3.Click
        getDates.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("DRAW")
        inicializarTablero()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If selectTurn.turn Then
            MsgBox("The winer was " & player2)
        Else
            MsgBox("The winer was " & player1)
        End If

        inicializarTablero()
    End Sub
End Class
