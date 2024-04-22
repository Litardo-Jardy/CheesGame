<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class choosePice
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
        Me.Torre = New System.Windows.Forms.Panel()
        Me.Alfil = New System.Windows.Forms.Panel()
        Me.Caballo = New System.Windows.Forms.Panel()
        Me.Dama = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Torre
        '
        Me.Torre.Location = New System.Drawing.Point(12, 12)
        Me.Torre.Name = "Torre"
        Me.Torre.Size = New System.Drawing.Size(90, 90)
        Me.Torre.TabIndex = 0
        '
        'Alfil
        '
        Me.Alfil.Location = New System.Drawing.Point(153, 12)
        Me.Alfil.Name = "Alfil"
        Me.Alfil.Size = New System.Drawing.Size(90, 90)
        Me.Alfil.TabIndex = 1
        '
        'Caballo
        '
        Me.Caballo.Location = New System.Drawing.Point(292, 12)
        Me.Caballo.Name = "Caballo"
        Me.Caballo.Size = New System.Drawing.Size(90, 90)
        Me.Caballo.TabIndex = 2
        '
        'Dama
        '
        Me.Dama.Location = New System.Drawing.Point(427, 12)
        Me.Dama.Name = "Dama"
        Me.Dama.Size = New System.Drawing.Size(90, 90)
        Me.Dama.TabIndex = 3
        '
        'choosePice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 121)
        Me.Controls.Add(Me.Dama)
        Me.Controls.Add(Me.Caballo)
        Me.Controls.Add(Me.Alfil)
        Me.Controls.Add(Me.Torre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "choosePice"
        Me.ShowInTaskbar = False
        Me.Text = "choosePice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Torre As Panel
    Friend WithEvents Alfil As Panel
    Friend WithEvents Caballo As Panel
    Friend WithEvents Dama As Panel
End Class
