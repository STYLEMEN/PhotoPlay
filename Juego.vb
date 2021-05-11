Public Class Juego
    Dim contadorImg As Integer = 0
    Dim contadorRsp As Integer = 20

    Private Sub txtResp1_Click(sender As Object, e As EventArgs) Handles txtResp1.Click
        txtResp1.BackColor = Color.Orange
        txtResp2.BackColor = Color.LightSteelBlue
        txtResp3.BackColor = Color.LightSteelBlue
        txtResp4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub txtResp2_Click(sender As Object, e As EventArgs) Handles txtResp2.Click
        txtResp1.BackColor = Color.LightSteelBlue
        txtResp2.BackColor = Color.Orange
        txtResp3.BackColor = Color.LightSteelBlue
        txtResp4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub txtResp3_Click(sender As Object, e As EventArgs) Handles txtResp3.Click
        txtResp1.BackColor = Color.LightSteelBlue
        txtResp2.BackColor = Color.LightSteelBlue
        txtResp3.BackColor = Color.Orange
        txtResp4.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub txtResp4_Click(sender As Object, e As EventArgs) Handles txtResp4.Click
        txtResp1.BackColor = Color.LightSteelBlue
        txtResp2.BackColor = Color.LightSteelBlue
        txtResp3.BackColor = Color.LightSteelBlue
        txtResp4.BackColor = Color.Orange
    End Sub

    Private Sub relojImagen_Tick(sender As Object, e As EventArgs) Handles relojImagen.Tick
        If contadorImg = 5 Then
            relojImagen.Stop()

            'Ocultar imagen (CARGAR IMG BLANCO DESDE LA CARPETA DEL JUEGO)
            picboxImagenes.Load("C:\Users\dam1-aneb\Desktop\blanco.jpg")

            'Mostrar pregunta
            txtPregunta.Visible = True
            barraProgreso.Value = contadorRsp

            relojRespuesta.Start()
        Else
            'Mostrar imagen cogida de la bbdd (ESTA IMG ES DE PRUEBA)
            picboxImagenes.Load("C:\Users\dam1-aneb\Desktop\fondoprincipal.jpg")

            contadorImg += 1
        End If

    End Sub

    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        relojImagen.Start()
    End Sub

    Private Sub relojRespuesta_Tick(sender As Object, e As EventArgs) Handles relojRespuesta.Tick
        If contadorRsp = 0 Then
            relojRespuesta.Stop()
        Else
            contadorRsp -= 1
            barraProgreso.Value = contadorRsp
        End If

        If contadorRsp > 7 And contadorRsp <= 16 Then
            barraProgreso.ForeColor = Color.Yellow
        ElseIf contadorRsp <= 7 Then
            barraProgreso.ForeColor = Color.Red
        Else
            barraProgreso.ForeColor = Color.Green
        End If

        If barraProgreso.Value = 0 Then
            relojRespuesta.Stop()
            'Comprobar respuesta correcta
            comprobarRespuesta()
        End If

    End Sub

    Private Sub comprobarRespuesta()
        If Not txtResp1.BackColor = Color.Orange And Not txtResp2.BackColor = Color.Orange And Not txtResp3.BackColor = Color.Orange And Not txtResp4.BackColor = Color.Orange Then
            'Mostrar respuesta correcta

            'Mostrar informacion 
        ElseIf txtResp1.BackColor = Color.Orange Then
            'Comprobar si la 1 es la correcta
        ElseIf txtResp2.BackColor = Color.Orange Then
            'Comprobar si la 2 es la correcta
        ElseIf txtResp3.BackColor = Color.Orange Then
            'Comprobar si la 3 es la correcta
        ElseIf txtResp4.BackColor = Color.Orange Then
            'Comprobar si la 4 es la correcta
        End If
    End Sub

    Private Sub btnUnaP_Click(sender As Object, e As EventArgs) Handles btnUnaP.Click
        'Quitar una de las preguntas que tengan false

        'Deshabilitar boton
        btnUnaP.Enabled = False
    End Sub

    Private Sub btnDosP_Click(sender As Object, e As EventArgs) Handles btnDosP.Click
        'Quitar dos de las preguntas que tengan false

        'Deshabilitar boton
        btnDosP.Enabled = False
    End Sub

    Private Sub btnMasTiempo_Click(sender As Object, e As EventArgs) Handles btnMasTiempo.Click
        'Sumar tiempo
        contadorRsp += 5
        'Deshabilitar boton
        btnMasTiempo.Enabled = False
    End Sub

    Private Sub btnSaltoP_Click(sender As Object, e As EventArgs) Handles btnSaltoP.Click
        'Saltar pregunta
        'Poner el numero de la pregunta verde
        'Desactivar boton
        btnSaltoP.Enabled = False
    End Sub
End Class