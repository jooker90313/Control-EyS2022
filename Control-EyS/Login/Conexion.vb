Imports System.Configuration
Imports System.Data.SqlClient

Module Conexion

    Public connection As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Sub Abrir()
        Try

            Dim connectionString As String
            connectionString = ConfigurationManager.ConnectionStrings.Item("BDQUICKIE").ConnectionString

            connection = New SqlConnection(connectionString)
            connection.Open()

        Catch ex As Exception
            MsgBox($"No se pudo conectar: {ex}")
        End Try
    End Sub

    Function UsuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Try

            Dim sql As String = $"select count(*) from Empleado e join Usuario u on e.idEmp = u.idEmp where numCedula ='{nombreUsuario}'"
            Dim command As New SqlCommand(sql, connection)

            Return command.ExecuteScalar() >= 1

        Catch ex As Exception

            MsgBox(ex.ToString)
            Return False

        End Try

    End Function

    Function GetIdEmpleado(ByVal nombreUsuario As String) As Integer

        Try

            Dim sql As String = $"select idEmp from Empleado where numCedula = '{nombreUsuario}'"

            Dim command As New SqlCommand(sql, connection)
            Return command.ExecuteScalar()

        Catch ex As Exception

            MsgBox(ex.ToString)
            Throw

        End Try

    End Function

    Function GetEsAdministrador(ByVal idEmpleado As Integer) As Boolean

        Try

            Dim sql As String = $"select isnull(administrador, 0) from Usuario where idEmp = '{idEmpleado}'"

            Dim command As New SqlCommand(sql, connection)
            Return command.ExecuteScalar()

        Catch ex As Exception

            MsgBox(ex.ToString)
            Throw

        End Try

    End Function

    Function valiUser(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select * from Empleado where numCedula ='" & nombreUsuario & "'", connection)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("numCedula")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("Select idEmp from Empleado where numCedula='" & nombreUsuario & "'", connection)
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

    Function Autenticar(ByVal IdEmpleado As Integer, ByVal passAdmin As String) As Boolean

        Try
            Dim sql As String = $"select count(*) from usuario where idEmp = {IdEmpleado} and clave = '{passAdmin}'"
            Dim command As New SqlCommand(sql, connection)

            Return command.ExecuteScalar()

        Catch ex As Exception

            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    Function valicionDepartamento(ByVal Departamento As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select * from Departamento where nombreDepartamento ='" & Departamento & "'", connection)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("nombreDepartamento")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function valicionCargo(ByVal cargo As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select * from Cargo where nombreCargo ='" & cargo & "'", connection)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("nombreCargo")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
End Module
