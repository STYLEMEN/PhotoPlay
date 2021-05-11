Imports System.Data.OleDb



Module BD
    Dim conexion As OleDbConnection


    'Funcion para conectar con la base de datos MSQL
    Public Function conectar() As OleDbConnection ' As OleDbConnection -> devuelve la conexion
        Try
            'Coger la base de datos
            'CAMBIAR COSAS'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            conexion = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=192.168.6.212;Persist Security Info=False;")
            conexion.Open()
            Return conexion
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

End Module
