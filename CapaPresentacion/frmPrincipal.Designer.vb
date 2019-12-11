<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.btnFuncion = New System.Windows.Forms.Button()
        Me.btnPelicula = New System.Windows.Forms.Button()
        Me.btnSala = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEntrada
        '
        Me.btnEntrada.BackColor = System.Drawing.Color.Lime
        Me.btnEntrada.Location = New System.Drawing.Point(583, 337)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(227, 83)
        Me.btnEntrada.TabIndex = 0
        Me.btnEntrada.Text = "ENTRADAS"
        Me.btnEntrada.UseVisualStyleBackColor = False
        '
        'btnFuncion
        '
        Me.btnFuncion.BackColor = System.Drawing.Color.Yellow
        Me.btnFuncion.Location = New System.Drawing.Point(214, 337)
        Me.btnFuncion.Name = "btnFuncion"
        Me.btnFuncion.Size = New System.Drawing.Size(227, 83)
        Me.btnFuncion.TabIndex = 1
        Me.btnFuncion.Text = "FUNCION"
        Me.btnFuncion.UseVisualStyleBackColor = False
        '
        'btnPelicula
        '
        Me.btnPelicula.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnPelicula.Location = New System.Drawing.Point(583, 165)
        Me.btnPelicula.Name = "btnPelicula"
        Me.btnPelicula.Size = New System.Drawing.Size(227, 83)
        Me.btnPelicula.TabIndex = 2
        Me.btnPelicula.Text = "PELICULAS"
        Me.btnPelicula.UseVisualStyleBackColor = False
        '
        'btnSala
        '
        Me.btnSala.BackColor = System.Drawing.Color.Coral
        Me.btnSala.Location = New System.Drawing.Point(214, 165)
        Me.btnSala.Name = "btnSala"
        Me.btnSala.Size = New System.Drawing.Size(227, 83)
        Me.btnSala.TabIndex = 3
        Me.btnSala.Text = "SALAS"
        Me.btnSala.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(864, 96)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "BIENVENIDOS AL CINE "
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 556)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSala)
        Me.Controls.Add(Me.btnPelicula)
        Me.Controls.Add(Me.btnFuncion)
        Me.Controls.Add(Me.btnEntrada)
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEntrada As System.Windows.Forms.Button
    Friend WithEvents btnFuncion As System.Windows.Forms.Button
    Friend WithEvents btnPelicula As System.Windows.Forms.Button
    Friend WithEvents btnSala As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
