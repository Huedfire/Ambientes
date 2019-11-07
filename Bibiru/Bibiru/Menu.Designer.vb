<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPrestamos = New System.Windows.Forms.Button()
        Me.btnLibros = New System.Windows.Forms.Button()
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.tagTitle = New System.Windows.Forms.Label()
        Me.pictureHelp = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(547, 292)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnPrestamos
        '
        Me.btnPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrestamos.Location = New System.Drawing.Point(586, 239)
        Me.btnPrestamos.Name = "btnPrestamos"
        Me.btnPrestamos.Size = New System.Drawing.Size(202, 55)
        Me.btnPrestamos.TabIndex = 3
        Me.btnPrestamos.Text = "Prestamos"
        Me.btnPrestamos.UseVisualStyleBackColor = True
        '
        'btnLibros
        '
        Me.btnLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibros.Location = New System.Drawing.Point(586, 117)
        Me.btnLibros.Name = "btnLibros"
        Me.btnLibros.Size = New System.Drawing.Size(202, 55)
        Me.btnLibros.TabIndex = 4
        Me.btnLibros.Text = "Libros"
        Me.btnLibros.UseVisualStyleBackColor = True
        '
        'btnAlumnos
        '
        Me.btnAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnos.Location = New System.Drawing.Point(586, 178)
        Me.btnAlumnos.Name = "btnAlumnos"
        Me.btnAlumnos.Size = New System.Drawing.Size(202, 55)
        Me.btnAlumnos.TabIndex = 5
        Me.btnAlumnos.Text = "Alumnos"
        Me.btnAlumnos.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(586, 354)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(202, 55)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'tagTitle
        '
        Me.tagTitle.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagTitle.Location = New System.Drawing.Point(12, 34)
        Me.tagTitle.Name = "tagTitle"
        Me.tagTitle.Size = New System.Drawing.Size(245, 34)
        Me.tagTitle.TabIndex = 7
        Me.tagTitle.Text = "Biblioteca Online"
        '
        'pictureHelp
        '
        Me.pictureHelp.Image = CType(resources.GetObject("pictureHelp.Image"), System.Drawing.Image)
        Me.pictureHelp.Location = New System.Drawing.Point(706, 12)
        Me.pictureHelp.Name = "pictureHelp"
        Me.pictureHelp.Size = New System.Drawing.Size(82, 72)
        Me.pictureHelp.TabIndex = 8
        Me.pictureHelp.TabStop = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pictureHelp)
        Me.Controls.Add(Me.tagTitle)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAlumnos)
        Me.Controls.Add(Me.btnLibros)
        Me.Controls.Add(Me.btnPrestamos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPrestamos As Button
    Friend WithEvents btnLibros As Button
    Friend WithEvents btnAlumnos As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents tagTitle As Label
    Friend WithEvents pictureHelp As PictureBox
End Class
