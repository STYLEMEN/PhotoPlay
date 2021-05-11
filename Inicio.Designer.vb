<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.pictureboxOjo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureboxOjo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(109, 140)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(384, 23)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(109, 226)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(384, 23)
        Me.txtContraseña.TabIndex = 1
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(226, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CONTRASEÑA"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.usuario1
        Me.PictureBox1.Location = New System.Drawing.Point(221, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.btnEntrar.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.play1
        Me.btnEntrar.Location = New System.Drawing.Point(196, 260)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(226, 40)
        Me.btnEntrar.TabIndex = 5
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'pictureboxOjo
        '
        Me.pictureboxOjo.BackColor = System.Drawing.Color.Transparent
        Me.pictureboxOjo.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.ojocerrado
        Me.pictureboxOjo.InitialImage = Nothing
        Me.pictureboxOjo.Location = New System.Drawing.Point(499, 226)
        Me.pictureboxOjo.Name = "pictureboxOjo"
        Me.pictureboxOjo.Size = New System.Drawing.Size(23, 22)
        Me.pictureboxOjo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureboxOjo.TabIndex = 7
        Me.pictureboxOjo.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PhotoPlay.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(610, 308)
        Me.Controls.Add(Me.pictureboxOjo)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.Text = "AlmiPlay"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureboxOjo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents pictureboxOjo As PictureBox
End Class
