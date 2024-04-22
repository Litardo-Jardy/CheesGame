<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tablero
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnl_tablero = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.recordMessage = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTimeWhite = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTimeBlack = New System.Windows.Forms.Label()
        Me.recordMove = New System.Windows.Forms.Panel()
        Me.lblMoves = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.recordMove.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_tablero
        '
        Me.pnl_tablero.Location = New System.Drawing.Point(413, 1)
        Me.pnl_tablero.Name = "pnl_tablero"
        Me.pnl_tablero.Size = New System.Drawing.Size(720, 720)
        Me.pnl_tablero.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("MS Gothic", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(51, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 70)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CHESS GAME"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.recordMessage)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblTimeWhite)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.pnl_tablero)
        Me.Panel1.Controls.Add(Me.lblTimeBlack)
        Me.Panel1.Controls.Add(Me.recordMove)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1372, 749)
        Me.Panel1.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("MT Extra", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label18.ForeColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(3, 719)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(386, 28)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "CREATED WITH <3 BY JARDY"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(51, 233)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(302, 277)
        Me.Panel3.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(1257, 576)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 36)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "RESING"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(1149, 576)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 36)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "TABLES"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'recordMessage
        '
        Me.recordMessage.AutoScroll = True
        Me.recordMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.recordMessage.Location = New System.Drawing.Point(1139, 433)
        Me.recordMessage.Name = "recordMessage"
        Me.recordMessage.Size = New System.Drawing.Size(226, 121)
        Me.recordMessage.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1082, 724)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 20)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "H"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(998, 724)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 16)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "G"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(908, 724)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 20)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "F"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(809, 724)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 20)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "E"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(719, 724)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 20)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "D"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(629, 724)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 20)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "C"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(535, 724)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "B"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(446, 724)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "A"
        '
        'lblTimeWhite
        '
        Me.lblTimeWhite.BackColor = System.Drawing.Color.Maroon
        Me.lblTimeWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimeWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeWhite.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTimeWhite.Location = New System.Drawing.Point(1149, 661)
        Me.lblTimeWhite.Name = "lblTimeWhite"
        Me.lblTimeWhite.Size = New System.Drawing.Size(116, 42)
        Me.lblTimeWhite.TabIndex = 16
        Me.lblTimeWhite.Text = "10:00"
        Me.lblTimeWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(388, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "8"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(388, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "7"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(388, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "6"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(388, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "5"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(388, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "4"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(388, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "3"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(388, 576)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "2"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 661)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "1"
        '
        'lblTimeBlack
        '
        Me.lblTimeBlack.BackColor = System.Drawing.Color.Maroon
        Me.lblTimeBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimeBlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeBlack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTimeBlack.Location = New System.Drawing.Point(1149, 20)
        Me.lblTimeBlack.Name = "lblTimeBlack"
        Me.lblTimeBlack.Size = New System.Drawing.Size(116, 40)
        Me.lblTimeBlack.TabIndex = 17
        Me.lblTimeBlack.Text = "10:00"
        Me.lblTimeBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'recordMove
        '
        Me.recordMove.AutoScroll = True
        Me.recordMove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.recordMove.Controls.Add(Me.lblMoves)
        Me.recordMove.Location = New System.Drawing.Point(1149, 85)
        Me.recordMove.Name = "recordMove"
        Me.recordMove.Size = New System.Drawing.Size(206, 333)
        Me.recordMove.TabIndex = 15
        '
        'lblMoves
        '
        Me.lblMoves.AutoSize = True
        Me.lblMoves.Location = New System.Drawing.Point(3, 0)
        Me.lblMoves.Name = "lblMoves"
        Me.lblMoves.Size = New System.Drawing.Size(0, 13)
        Me.lblMoves.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Maroon
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(93, 588)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(216, 49)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "START NEW GAME"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ChessGame2._0.My.Resources.Resources.LogoInicio3_0
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Tablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "Tablero"
        Me.Text = "Tablero"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.recordMove.ResumeLayout(False)
        Me.recordMove.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents pnl_tablero As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents recordMove As Panel
    Friend WithEvents lblTimeWhite As Label
    Friend WithEvents lblTimeBlack As Label
    Friend WithEvents timer2 As Timer
    Public WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents recordMessage As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents lblMoves As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
