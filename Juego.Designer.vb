<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juego
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
        Me.picboxImagenes = New System.Windows.Forms.PictureBox()
        Me.txtResp1 = New System.Windows.Forms.TextBox()
        Me.txtResp2 = New System.Windows.Forms.TextBox()
        Me.txtResp3 = New System.Windows.Forms.TextBox()
        Me.txtResp4 = New System.Windows.Forms.TextBox()
        Me.txtPregunta = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt14 = New System.Windows.Forms.TextBox()
        Me.txt13 = New System.Windows.Forms.TextBox()
        Me.txt12 = New System.Windows.Forms.TextBox()
        Me.txt10 = New System.Windows.Forms.TextBox()
        Me.txt9 = New System.Windows.Forms.TextBox()
        Me.txt8 = New System.Windows.Forms.TextBox()
        Me.txt7 = New System.Windows.Forms.TextBox()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt11 = New System.Windows.Forms.TextBox()
        Me.txt120 = New System.Windows.Forms.TextBox()
        Me.txt19 = New System.Windows.Forms.TextBox()
        Me.txt18 = New System.Windows.Forms.TextBox()
        Me.txt17 = New System.Windows.Forms.TextBox()
        Me.txt16 = New System.Windows.Forms.TextBox()
        Me.txt15 = New System.Windows.Forms.TextBox()
        Me.barraProgreso = New System.Windows.Forms.ProgressBar()
        Me.relojImagen = New System.Windows.Forms.Timer(Me.components)
        Me.relojRespuesta = New System.Windows.Forms.Timer(Me.components)
        Me.btnUnaP = New System.Windows.Forms.Button()
        Me.btnDosP = New System.Windows.Forms.Button()
        Me.btnMasTiempo = New System.Windows.Forms.Button()
        Me.btnSaltoP = New System.Windows.Forms.Button()
        CType(Me.picboxImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picboxImagenes
        '
        Me.picboxImagenes.Location = New System.Drawing.Point(1, 13)
        Me.picboxImagenes.Name = "picboxImagenes"
        Me.picboxImagenes.Size = New System.Drawing.Size(799, 216)
        Me.picboxImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxImagenes.TabIndex = 0
        Me.picboxImagenes.TabStop = False
        '
        'txtResp1
        '
        Me.txtResp1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtResp1.Location = New System.Drawing.Point(12, 237)
        Me.txtResp1.Multiline = True
        Me.txtResp1.Name = "txtResp1"
        Me.txtResp1.ReadOnly = True
        Me.txtResp1.Size = New System.Drawing.Size(314, 58)
        Me.txtResp1.TabIndex = 1
        Me.txtResp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResp2
        '
        Me.txtResp2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtResp2.Location = New System.Drawing.Point(454, 237)
        Me.txtResp2.Multiline = True
        Me.txtResp2.Name = "txtResp2"
        Me.txtResp2.ReadOnly = True
        Me.txtResp2.Size = New System.Drawing.Size(334, 58)
        Me.txtResp2.TabIndex = 2
        Me.txtResp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResp3
        '
        Me.txtResp3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtResp3.Location = New System.Drawing.Point(12, 301)
        Me.txtResp3.Multiline = True
        Me.txtResp3.Name = "txtResp3"
        Me.txtResp3.ReadOnly = True
        Me.txtResp3.Size = New System.Drawing.Size(314, 58)
        Me.txtResp3.TabIndex = 3
        Me.txtResp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResp4
        '
        Me.txtResp4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtResp4.Location = New System.Drawing.Point(454, 301)
        Me.txtResp4.Multiline = True
        Me.txtResp4.Name = "txtResp4"
        Me.txtResp4.ReadOnly = True
        Me.txtResp4.Size = New System.Drawing.Size(334, 58)
        Me.txtResp4.TabIndex = 4
        Me.txtResp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPregunta
        '
        Me.txtPregunta.BackColor = System.Drawing.SystemColors.Window
        Me.txtPregunta.Location = New System.Drawing.Point(42, 52)
        Me.txtPregunta.Multiline = True
        Me.txtPregunta.Name = "txtPregunta"
        Me.txtPregunta.ReadOnly = True
        Me.txtPregunta.Size = New System.Drawing.Size(717, 142)
        Me.txtPregunta.TabIndex = 5
        Me.txtPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPregunta.Visible = False
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(1, 416)
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(35, 23)
        Me.txt1.TabIndex = 6
        Me.txt1.Text = "1"
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt14
        '
        Me.txt14.Location = New System.Drawing.Point(532, 416)
        Me.txt14.Name = "txt14"
        Me.txt14.ReadOnly = True
        Me.txt14.Size = New System.Drawing.Size(35, 23)
        Me.txt14.TabIndex = 7
        Me.txt14.Text = "14"
        Me.txt14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt13
        '
        Me.txt13.Location = New System.Drawing.Point(493, 416)
        Me.txt13.Name = "txt13"
        Me.txt13.ReadOnly = True
        Me.txt13.Size = New System.Drawing.Size(35, 23)
        Me.txt13.TabIndex = 8
        Me.txt13.Text = "13"
        Me.txt13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt12
        '
        Me.txt12.Location = New System.Drawing.Point(454, 416)
        Me.txt12.Name = "txt12"
        Me.txt12.ReadOnly = True
        Me.txt12.Size = New System.Drawing.Size(35, 23)
        Me.txt12.TabIndex = 9
        Me.txt12.Text = "12"
        Me.txt12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt10
        '
        Me.txt10.Location = New System.Drawing.Point(376, 416)
        Me.txt10.Name = "txt10"
        Me.txt10.ReadOnly = True
        Me.txt10.Size = New System.Drawing.Size(35, 23)
        Me.txt10.TabIndex = 10
        Me.txt10.Text = "10"
        Me.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt9
        '
        Me.txt9.Location = New System.Drawing.Point(333, 416)
        Me.txt9.Name = "txt9"
        Me.txt9.ReadOnly = True
        Me.txt9.Size = New System.Drawing.Size(35, 23)
        Me.txt9.TabIndex = 11
        Me.txt9.Text = "9"
        Me.txt9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt8
        '
        Me.txt8.Location = New System.Drawing.Point(291, 416)
        Me.txt8.Name = "txt8"
        Me.txt8.ReadOnly = True
        Me.txt8.Size = New System.Drawing.Size(35, 23)
        Me.txt8.TabIndex = 12
        Me.txt8.Text = "8"
        Me.txt8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt7
        '
        Me.txt7.Location = New System.Drawing.Point(249, 416)
        Me.txt7.Name = "txt7"
        Me.txt7.ReadOnly = True
        Me.txt7.Size = New System.Drawing.Size(35, 23)
        Me.txt7.TabIndex = 13
        Me.txt7.Text = "7"
        Me.txt7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt6
        '
        Me.txt6.Location = New System.Drawing.Point(207, 416)
        Me.txt6.Name = "txt6"
        Me.txt6.ReadOnly = True
        Me.txt6.Size = New System.Drawing.Size(35, 23)
        Me.txt6.TabIndex = 14
        Me.txt6.Text = "6"
        Me.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(165, 416)
        Me.txt5.Name = "txt5"
        Me.txt5.ReadOnly = True
        Me.txt5.Size = New System.Drawing.Size(35, 23)
        Me.txt5.TabIndex = 15
        Me.txt5.Text = "5"
        Me.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(123, 416)
        Me.txt4.Name = "txt4"
        Me.txt4.ReadOnly = True
        Me.txt4.Size = New System.Drawing.Size(35, 23)
        Me.txt4.TabIndex = 16
        Me.txt4.Text = "4"
        Me.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(81, 416)
        Me.txt3.Name = "txt3"
        Me.txt3.ReadOnly = True
        Me.txt3.Size = New System.Drawing.Size(35, 23)
        Me.txt3.TabIndex = 17
        Me.txt3.Text = "3"
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(41, 416)
        Me.txt2.Name = "txt2"
        Me.txt2.ReadOnly = True
        Me.txt2.Size = New System.Drawing.Size(35, 23)
        Me.txt2.TabIndex = 18
        Me.txt2.Text = "2"
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt11
        '
        Me.txt11.Location = New System.Drawing.Point(417, 416)
        Me.txt11.Name = "txt11"
        Me.txt11.ReadOnly = True
        Me.txt11.Size = New System.Drawing.Size(33, 23)
        Me.txt11.TabIndex = 19
        Me.txt11.Text = "11"
        Me.txt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt120
        '
        Me.txt120.Location = New System.Drawing.Point(767, 416)
        Me.txt120.Name = "txt120"
        Me.txt120.ReadOnly = True
        Me.txt120.Size = New System.Drawing.Size(33, 23)
        Me.txt120.TabIndex = 20
        Me.txt120.Text = "20"
        Me.txt120.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt19
        '
        Me.txt19.Location = New System.Drawing.Point(725, 416)
        Me.txt19.Name = "txt19"
        Me.txt19.ReadOnly = True
        Me.txt19.Size = New System.Drawing.Size(36, 23)
        Me.txt19.TabIndex = 21
        Me.txt19.Text = "19"
        Me.txt19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt18
        '
        Me.txt18.Location = New System.Drawing.Point(686, 416)
        Me.txt18.Name = "txt18"
        Me.txt18.ReadOnly = True
        Me.txt18.Size = New System.Drawing.Size(36, 23)
        Me.txt18.TabIndex = 22
        Me.txt18.Text = "18"
        Me.txt18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt17
        '
        Me.txt17.Location = New System.Drawing.Point(648, 416)
        Me.txt17.Name = "txt17"
        Me.txt17.ReadOnly = True
        Me.txt17.Size = New System.Drawing.Size(35, 23)
        Me.txt17.TabIndex = 23
        Me.txt17.Text = "17"
        Me.txt17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt16
        '
        Me.txt16.Location = New System.Drawing.Point(609, 416)
        Me.txt16.Name = "txt16"
        Me.txt16.ReadOnly = True
        Me.txt16.Size = New System.Drawing.Size(35, 23)
        Me.txt16.TabIndex = 24
        Me.txt16.Text = "16"
        Me.txt16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt15
        '
        Me.txt15.Location = New System.Drawing.Point(570, 416)
        Me.txt15.Name = "txt15"
        Me.txt15.ReadOnly = True
        Me.txt15.Size = New System.Drawing.Size(35, 23)
        Me.txt15.TabIndex = 25
        Me.txt15.Text = "15"
        Me.txt15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'barraProgreso
        '
        Me.barraProgreso.BackColor = System.Drawing.Color.Honeydew
        Me.barraProgreso.ForeColor = System.Drawing.Color.Lime
        Me.barraProgreso.Location = New System.Drawing.Point(12, 380)
        Me.barraProgreso.Maximum = 20
        Me.barraProgreso.Name = "barraProgreso"
        Me.barraProgreso.Size = New System.Drawing.Size(776, 26)
        Me.barraProgreso.TabIndex = 26
        '
        'relojImagen
        '
        Me.relojImagen.Interval = 1000
        '
        'relojRespuesta
        '
        Me.relojRespuesta.Interval = 1000
        '
        'btnUnaP
        '
        Me.btnUnaP.Location = New System.Drawing.Point(332, 237)
        Me.btnUnaP.Name = "btnUnaP"
        Me.btnUnaP.Size = New System.Drawing.Size(117, 24)
        Me.btnUnaP.TabIndex = 27
        Me.btnUnaP.Text = "Quitar Una"
        Me.btnUnaP.UseVisualStyleBackColor = True
        '
        'btnDosP
        '
        Me.btnDosP.Location = New System.Drawing.Point(331, 267)
        Me.btnDosP.Name = "btnDosP"
        Me.btnDosP.Size = New System.Drawing.Size(117, 24)
        Me.btnDosP.TabIndex = 28
        Me.btnDosP.Text = "Quitar Dos"
        Me.btnDosP.UseVisualStyleBackColor = True
        '
        'btnMasTiempo
        '
        Me.btnMasTiempo.Location = New System.Drawing.Point(331, 305)
        Me.btnMasTiempo.Name = "btnMasTiempo"
        Me.btnMasTiempo.Size = New System.Drawing.Size(117, 24)
        Me.btnMasTiempo.TabIndex = 29
        Me.btnMasTiempo.Text = "Mas Tiempo"
        Me.btnMasTiempo.UseVisualStyleBackColor = True
        '
        'btnSaltoP
        '
        Me.btnSaltoP.Location = New System.Drawing.Point(331, 335)
        Me.btnSaltoP.Name = "btnSaltoP"
        Me.btnSaltoP.Size = New System.Drawing.Size(117, 24)
        Me.btnSaltoP.TabIndex = 30
        Me.btnSaltoP.Text = "Saltar Pregunta"
        Me.btnSaltoP.UseVisualStyleBackColor = True
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSaltoP)
        Me.Controls.Add(Me.btnMasTiempo)
        Me.Controls.Add(Me.btnDosP)
        Me.Controls.Add(Me.btnUnaP)
        Me.Controls.Add(Me.barraProgreso)
        Me.Controls.Add(Me.txt15)
        Me.Controls.Add(Me.txt16)
        Me.Controls.Add(Me.txt17)
        Me.Controls.Add(Me.txt18)
        Me.Controls.Add(Me.txt19)
        Me.Controls.Add(Me.txt120)
        Me.Controls.Add(Me.txt11)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt6)
        Me.Controls.Add(Me.txt7)
        Me.Controls.Add(Me.txt8)
        Me.Controls.Add(Me.txt9)
        Me.Controls.Add(Me.txt10)
        Me.Controls.Add(Me.txt12)
        Me.Controls.Add(Me.txt13)
        Me.Controls.Add(Me.txt14)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txtPregunta)
        Me.Controls.Add(Me.txtResp4)
        Me.Controls.Add(Me.txtResp3)
        Me.Controls.Add(Me.txtResp2)
        Me.Controls.Add(Me.txtResp1)
        Me.Controls.Add(Me.picboxImagenes)
        Me.Name = "Juego"
        Me.Text = "Juego"
        CType(Me.picboxImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picboxImagenes As PictureBox
    Friend WithEvents txtResp1 As TextBox
    Friend WithEvents txtResp2 As TextBox
    Friend WithEvents txtResp3 As TextBox
    Friend WithEvents txtResp4 As TextBox
    Friend WithEvents txtPregunta As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt14 As TextBox
    Friend WithEvents txt13 As TextBox
    Friend WithEvents txt12 As TextBox
    Friend WithEvents txt10 As TextBox
    Friend WithEvents txt9 As TextBox
    Friend WithEvents txt8 As TextBox
    Friend WithEvents txt7 As TextBox
    Friend WithEvents txt6 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt11 As TextBox
    Friend WithEvents txt120 As TextBox
    Friend WithEvents txt19 As TextBox
    Friend WithEvents txt18 As TextBox
    Friend WithEvents txt17 As TextBox
    Friend WithEvents txt16 As TextBox
    Friend WithEvents txt15 As TextBox
    Friend WithEvents barraProgreso As ProgressBar
    Friend WithEvents relojImagen As Timer
    Friend WithEvents relojRespuesta As Timer
    Friend WithEvents btnUnaP As Button
    Friend WithEvents btnDosP As Button
    Friend WithEvents btnMasTiempo As Button
    Friend WithEvents btnSaltoP As Button
End Class
