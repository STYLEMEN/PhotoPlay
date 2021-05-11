Public Class Inicio
    Dim existe, mostrar As Boolean
    Dim formularioMenu As Menu
    Private conexion As OleDb.OleDbConnection

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar = False
    End Sub

    Private Sub btnEntrar_Click_1(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If txtUsuario.Text.Equals("") Or txtContraseña.Text.Equals("") Then
            MessageBox.Show("Comprueba que los campos no estén vacios")
            Return
        End If

        formularioMenu = New Menu()
        Me.Hide()
        formularioMenu.Show()

        'Comprobar conexion con SQL
        conexion = conectar()
        If conexion Is Nothing Then
            Return
        End If

        'Comprobar que el usuario existe
        'Si existe comprobar la contraseña
        'Si no existe, crear usuario y contraseña nuevos
    End Sub

    Private Sub pictureboxOjo_Click_1(sender As Object, e As EventArgs) Handles pictureboxOjo.Click
        If Not mostrar Then
            mostrar = True
            txtContraseña.PasswordChar = ""
            pictureboxOjo.BackgroundImage = My.Resources.ojoabierto
        Else
            mostrar = False
            txtContraseña.PasswordChar = "*"
            pictureboxOjo.BackgroundImage = My.Resources.ojocerrado
        End If
    End Sub
End Class
