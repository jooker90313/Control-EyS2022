Public Class FrmLogin

    Public IdEmpleado As String

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try

            Dim user As String = txtId.Text

            If UsuarioRegistrado(user) Then

                IdEmpleado = GetIdEmpleado(user)
                Dim administrador As Boolean = GetEsAdministrador(IdEmpleado)

                If administrador Then
                    frmPass.ShowDialog()
                Else
                    Call TxId()
                End If

                Me.Hide()

            Else

                MsgBox("El Usuario: " + txtId.Text + "No se encuentra registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxId()

        FrmRegistrarEyN.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Abrir()
    End Sub
End Class
