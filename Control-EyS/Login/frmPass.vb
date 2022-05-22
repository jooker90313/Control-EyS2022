Public Class frmPass
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmLogin.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click

        Dim IdEmpleado As Integer = FrmLogin.IdEmpleado
        Dim passAdmin As String = txtPass.Text

        Dim autenticado = Autenticar(IdEmpleado, passAdmin)

        If autenticado Then

            FrmInicioAdmin.ShowDialog()
            Me.Hide()

        Else

            MsgBox("Contraseña incorrecta putoHacker", MsgBoxStyle.Critical)
        End If

    End Sub
End Class