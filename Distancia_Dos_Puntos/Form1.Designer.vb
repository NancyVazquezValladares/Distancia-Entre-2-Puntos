<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPractica1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPractica1))
        Me.tbY2 = New System.Windows.Forms.TextBox()
        Me.tbX2 = New System.Windows.Forms.TextBox()
        Me.tbX1 = New System.Windows.Forms.TextBox()
        Me.tbY1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbDistamcia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbY2
        '
        Me.tbY2.Location = New System.Drawing.Point(43, 134)
        Me.tbY2.Name = "tbY2"
        Me.tbY2.Size = New System.Drawing.Size(78, 22)
        Me.tbY2.TabIndex = 3
        '
        'tbX2
        '
        Me.tbX2.Location = New System.Drawing.Point(377, 403)
        Me.tbX2.Name = "tbX2"
        Me.tbX2.Size = New System.Drawing.Size(92, 22)
        Me.tbX2.TabIndex = 4
        '
        'tbX1
        '
        Me.tbX1.Location = New System.Drawing.Point(226, 403)
        Me.tbX1.Name = "tbX1"
        Me.tbX1.Size = New System.Drawing.Size(91, 22)
        Me.tbX1.TabIndex = 5
        '
        'tbY1
        '
        Me.tbY1.Location = New System.Drawing.Point(43, 242)
        Me.tbY1.Name = "tbY1"
        Me.tbY1.Size = New System.Drawing.Size(78, 22)
        Me.tbY1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(205, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 35)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Distancia entre 2 Puntos"
        '
        'tbDistamcia
        '
        Me.tbDistamcia.Location = New System.Drawing.Point(269, 525)
        Me.tbDistamcia.Name = "tbDistamcia"
        Me.tbDistamcia.Size = New System.Drawing.Size(148, 22)
        Me.tbDistamcia.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(292, 486)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Distancia"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Distancia_Dos_Puntos.My.Resources.Resources.distancia_entre_dos_puntos_en_el_plano_1024x532zi
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(136, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(455, 305)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = Global.Distancia_Dos_Puntos.My.Resources.Resources.limpieza_de_datos
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(627, 109)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(69, 58)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.Distancia_Dos_Puntos.My.Resources.Resources.salida
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(627, 200)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 65)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(136, 511)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(102, 36)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular "
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'FrmPractica1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Distancia_Dos_Puntos.My.Resources.Resources.elegant_wallpaper_preview
        Me.ClientSize = New System.Drawing.Size(724, 583)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbDistamcia)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbY1)
        Me.Controls.Add(Me.tbX1)
        Me.Controls.Add(Me.tbX2)
        Me.Controls.Add(Me.tbY2)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPractica1"
        Me.Text = "Practica1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents tbY2 As TextBox
    Friend WithEvents tbX2 As TextBox
    Friend WithEvents tbX1 As TextBox
    Friend WithEvents tbY1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbDistamcia As TextBox
    Friend WithEvents Label3 As Label
End Class
