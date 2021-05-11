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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbFacil = New System.Windows.Forms.RadioButton()
        Me.rbMedio = New System.Windows.Forms.RadioButton()
        Me.rbDificil = New System.Windows.Forms.RadioButton()
        Me.groupboxNivel = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.rbEsp = New System.Windows.Forms.RadioButton()
        Me.rbIng = New System.Windows.Forms.RadioButton()
        Me.groupboxIdiomas = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picboxplay = New System.Windows.Forms.PictureBox()
        Me.reloj = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupboxNivel.SuspendLayout()
        Me.groupboxIdiomas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picboxplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(121, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(511, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECCIONA CATEGORÍA, IDIOMA Y NIVEL"
        '
        'rbFacil
        '
        Me.rbFacil.AutoSize = True
        Me.rbFacil.BackColor = System.Drawing.Color.Transparent
        Me.rbFacil.Checked = True
        Me.rbFacil.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbFacil.Location = New System.Drawing.Point(27, 36)
        Me.rbFacil.Name = "rbFacil"
        Me.rbFacil.Size = New System.Drawing.Size(64, 21)
        Me.rbFacil.TabIndex = 1
        Me.rbFacil.TabStop = True
        Me.rbFacil.Text = "FACIL"
        Me.rbFacil.UseVisualStyleBackColor = False
        '
        'rbMedio
        '
        Me.rbMedio.AutoSize = True
        Me.rbMedio.BackColor = System.Drawing.Color.Transparent
        Me.rbMedio.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbMedio.Location = New System.Drawing.Point(27, 63)
        Me.rbMedio.Name = "rbMedio"
        Me.rbMedio.Size = New System.Drawing.Size(70, 21)
        Me.rbMedio.TabIndex = 2
        Me.rbMedio.Text = "MEDIO"
        Me.rbMedio.UseVisualStyleBackColor = False
        '
        'rbDificil
        '
        Me.rbDificil.AutoSize = True
        Me.rbDificil.BackColor = System.Drawing.Color.Transparent
        Me.rbDificil.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbDificil.Location = New System.Drawing.Point(27, 90)
        Me.rbDificil.Name = "rbDificil"
        Me.rbDificil.Size = New System.Drawing.Size(74, 21)
        Me.rbDificil.TabIndex = 3
        Me.rbDificil.Text = "DIFICIL"
        Me.rbDificil.UseVisualStyleBackColor = False
        '
        'groupboxNivel
        '
        Me.groupboxNivel.BackColor = System.Drawing.Color.Transparent
        Me.groupboxNivel.Controls.Add(Me.rbDificil)
        Me.groupboxNivel.Controls.Add(Me.rbMedio)
        Me.groupboxNivel.Controls.Add(Me.rbFacil)
        Me.groupboxNivel.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.groupboxNivel.Location = New System.Drawing.Point(25, 83)
        Me.groupboxNivel.Name = "groupboxNivel"
        Me.groupboxNivel.Size = New System.Drawing.Size(123, 133)
        Me.groupboxNivel.TabIndex = 4
        Me.groupboxNivel.TabStop = False
        Me.groupboxNivel.Text = "NIVEL"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton4.Location = New System.Drawing.Point(27, 23)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(238, 21)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Formación y Orientación Laboral"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'rbEsp
        '
        Me.rbEsp.AutoSize = True
        Me.rbEsp.BackColor = System.Drawing.Color.Transparent
        Me.rbEsp.Checked = True
        Me.rbEsp.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbEsp.Location = New System.Drawing.Point(26, 80)
        Me.rbEsp.Name = "rbEsp"
        Me.rbEsp.Size = New System.Drawing.Size(51, 21)
        Me.rbEsp.TabIndex = 6
        Me.rbEsp.TabStop = True
        Me.rbEsp.Text = "ESP"
        Me.rbEsp.UseVisualStyleBackColor = False
        '
        'rbIng
        '
        Me.rbIng.AutoSize = True
        Me.rbIng.BackColor = System.Drawing.Color.Transparent
        Me.rbIng.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbIng.Location = New System.Drawing.Point(27, 44)
        Me.rbIng.Name = "rbIng"
        Me.rbIng.Size = New System.Drawing.Size(50, 21)
        Me.rbIng.TabIndex = 7
        Me.rbIng.Text = "ING"
        Me.rbIng.UseVisualStyleBackColor = False
        '
        'groupboxIdiomas
        '
        Me.groupboxIdiomas.BackColor = System.Drawing.Color.Transparent
        Me.groupboxIdiomas.Controls.Add(Me.rbIng)
        Me.groupboxIdiomas.Controls.Add(Me.rbEsp)
        Me.groupboxIdiomas.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.groupboxIdiomas.Location = New System.Drawing.Point(25, 250)
        Me.groupboxIdiomas.Name = "groupboxIdiomas"
        Me.groupboxIdiomas.Size = New System.Drawing.Size(123, 133)
        Me.groupboxIdiomas.TabIndex = 5
        Me.groupboxIdiomas.TabStop = False
        Me.groupboxIdiomas.Text = "IDIOMA"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton1.Location = New System.Drawing.Point(27, 198)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 21)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.Text = "Sistemas"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton2.Location = New System.Drawing.Point(318, 23)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(125, 21)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.Text = "Bases de Datos"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton3.Location = New System.Drawing.Point(318, 113)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(102, 21)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.Text = "Visual Basic"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton5.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton5.Location = New System.Drawing.Point(318, 198)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(56, 21)
        Me.RadioButton5.TabIndex = 9
        Me.RadioButton5.Text = "Java"
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton6.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton6.Location = New System.Drawing.Point(27, 113)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(155, 21)
        Me.RadioButton6.TabIndex = 10
        Me.RadioButton6.Text = "Lenguaje de Marcas"
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 245)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CATEGORÍA"
        '
        'picboxplay
        '
        Me.picboxplay.BackColor = System.Drawing.Color.Transparent
        Me.picboxplay.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.playrojo
        Me.picboxplay.Location = New System.Drawing.Point(292, 370)
        Me.picboxplay.Name = "picboxplay"
        Me.picboxplay.Size = New System.Drawing.Size(306, 89)
        Me.picboxplay.TabIndex = 12
        Me.picboxplay.TabStop = False
        '
        'reloj
        '
        Me.reloj.Interval = 400
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.atras
        Me.PictureBox1.Location = New System.Drawing.Point(25, 408)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 50)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.unnamed1
        Me.ClientSize = New System.Drawing.Size(783, 489)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picboxplay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupboxIdiomas)
        Me.Controls.Add(Me.groupboxNivel)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.Text = "MENU "
        Me.groupboxNivel.ResumeLayout(False)
        Me.groupboxNivel.PerformLayout()
        Me.groupboxIdiomas.ResumeLayout(False)
        Me.groupboxIdiomas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picboxplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rbFacil As RadioButton
    Friend WithEvents rbMedio As RadioButton
    Friend WithEvents rbDificil As RadioButton
    Friend WithEvents groupboxNivel As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents rbEsp As RadioButton
    Friend WithEvents rbIng As RadioButton
    Friend WithEvents groupboxIdiomas As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picboxplay As PictureBox
    Friend WithEvents reloj As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
