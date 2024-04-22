<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class getDates
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.players1 = New System.Windows.Forms.Panel()
        Me.txt_players1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.players2 = New System.Windows.Forms.Panel()
        Me.time = New System.Windows.Forms.Panel()
        Me.cb_time = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_players2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.players1.SuspendLayout()
        Me.players2.SuspendLayout()
        Me.time.SuspendLayout()
        Me.SuspendLayout()
        '
        'players1
        '
        Me.players1.Controls.Add(Me.txt_players1)
        Me.players1.Controls.Add(Me.Label2)
        Me.players1.Controls.Add(Me.Button2)
        Me.players1.Location = New System.Drawing.Point(2, 12)
        Me.players1.Name = "players1"
        Me.players1.Size = New System.Drawing.Size(449, 150)
        Me.players1.TabIndex = 5
        '
        'txt_players1
        '
        Me.txt_players1.Location = New System.Drawing.Point(210, 24)
        Me.txt_players1.Multiline = True
        Me.txt_players1.Name = "txt_players1"
        Me.txt_players1.Size = New System.Drawing.Size(193, 29)
        Me.txt_players1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name Players1:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(91, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(273, 49)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "NEXT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'players2
        '
        Me.players2.Controls.Add(Me.time)
        Me.players2.Controls.Add(Me.txt_players2)
        Me.players2.Controls.Add(Me.Label3)
        Me.players2.Controls.Add(Me.Button3)
        Me.players2.Location = New System.Drawing.Point(2, 12)
        Me.players2.Name = "players2"
        Me.players2.Size = New System.Drawing.Size(449, 150)
        Me.players2.TabIndex = 7
        Me.players2.Visible = False
        '
        'time
        '
        Me.time.Controls.Add(Me.cb_time)
        Me.time.Controls.Add(Me.Button1)
        Me.time.Location = New System.Drawing.Point(0, 0)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(449, 150)
        Me.time.TabIndex = 7
        Me.time.Visible = False
        '
        'cb_time
        '
        Me.cb_time.FormattingEnabled = True
        Me.cb_time.Items.AddRange(New Object() {"3", "5", "10", "30", "60"})
        Me.cb_time.Location = New System.Drawing.Point(186, 36)
        Me.cb_time.Name = "cb_time"
        Me.cb_time.Size = New System.Drawing.Size(80, 21)
        Me.cb_time.TabIndex = 7
        Me.cb_time.Text = "Time"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(91, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(273, 49)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "PLAY"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_players2
        '
        Me.txt_players2.Location = New System.Drawing.Point(210, 24)
        Me.txt_players2.Multiline = True
        Me.txt_players2.Name = "txt_players2"
        Me.txt_players2.Size = New System.Drawing.Size(193, 29)
        Me.txt_players2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name Players2:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Maroon
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(91, 82)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(273, 49)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "NEXT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'getDates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 182)
        Me.Controls.Add(Me.players2)
        Me.Controls.Add(Me.players1)
        Me.Name = "getDates"
        Me.Text = "getDates"
        Me.players1.ResumeLayout(False)
        Me.players1.PerformLayout()
        Me.players2.ResumeLayout(False)
        Me.players2.PerformLayout()
        Me.time.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents players1 As Panel
    Friend WithEvents txt_players1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents players2 As Panel
    Friend WithEvents txt_players2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents time As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents cb_time As ComboBox
End Class
