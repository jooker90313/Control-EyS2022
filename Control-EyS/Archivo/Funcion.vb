Imports System.Data.SqlClient

Public Class Funcion
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function validar(dts As Datos) As Boolean
        Try
            Me.conectado()
            cmd = New SqlCommand("")
        Catch ex As Exception

        End Try
    End Function
End Class
