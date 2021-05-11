Public Class Menu
    Dim formularioJuego As Juego
    Dim formularioInicio As Inicio
    Dim cambio As Boolean
    Dim idioma, dificultad, categoria As String

    Private Sub picboxplay_Click(sender As Object, e As EventArgs) Handles picboxplay.Click
        reloj.Stop()

        'Comprobar conexion con MongoDB
        'Si hay conexion entra en el juego y le pasamos los parametros seleccionados (idioma, dificultad, categoria)
        formularioJuego = New Juego

        Me.Hide()
        formularioJuego.Show()
        'Si no hay conexion return


    End Sub


    Private Sub reloj_Tick(sender As Object, e As EventArgs) Handles reloj.Tick
        If cambio Then
            picboxplay.BackgroundImage = My.Resources.playazul
            cambio = False
        Else
            picboxplay.BackgroundImage = My.Resources.playrojo
            cambio = True
        End If


    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambio = False
        reloj.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'PREGUNTAR ROBER COMO VOLVER ATRAS
        Me.Close()
    End Sub




    Private Sub rbFacil_CheckedChanged(sender As Object, e As EventArgs) Handles rbFacil.CheckedChanged
        dificultad = "facil"
    End Sub

    Private Sub rbMedio_CheckedChanged(sender As Object, e As EventArgs) Handles rbMedio.CheckedChanged
        dificultad = "medio"
    End Sub

    Private Sub rbDificil_CheckedChanged(sender As Object, e As EventArgs) Handles rbDificil.CheckedChanged
        dificultad = "dificil"
    End Sub

    Private Sub rbIng_CheckedChanged(sender As Object, e As EventArgs) Handles rbIng.CheckedChanged
        idioma = "ing"
    End Sub

    Private Sub rbEsp_CheckedChanged(sender As Object, e As EventArgs) Handles rbEsp.CheckedChanged
        idioma = "esp"
    End Sub
End Class