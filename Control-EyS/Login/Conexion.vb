Imports System.Data.Sql
Imports System.Data.SqlClient


Module Conexion

    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Sub abrir()
        Try
            conexion = New SqlConnection("Data Source=localhost;Initial Catalog=BDQUICKIE;Integrated Security=True")
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Empleado where numCedula ='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    'Function Admin(ByVal nombreUsuario As String) As String
    '    Dim resultado As String = ""
    '    Try
    '        enunciado = New SqlCommand("Select * from Empleado where numCedula ='" & nombreUsuario & "'", conexion)
    '        respuesta = enunciado.ExecuteReader

    '        If respuesta.Read Then
    '            resultado = respuesta.Item("numCedula")
    '        End If
    '        respuesta.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    '    Return resultado
    'End Function

    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("Select idEmp from Empleado where numCedula='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("idEmp"))
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function Pass(ByVal passAdmin As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Empleado where telefono ='" & passAdmin & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

End Module
