Public Class frmPass
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click

        Dim IdEmpleado As Integer = FrmLogin.IdEmpleado
        Dim passAdmin As String = txtPass.Text

        Dim autenticado = Autenticar(IdEmpleado, passAdmin)

        If autenticado Then
            LimpiarCampo()
            FrmInicioAdmin.Show()
            Me.Hide()

        Else

            MsgBox(" Contraseña incorrecta, intente de nuevo", MsgBoxStyle.Critical)
            LimpiarCampo()
        End If

    End Sub

    Private Sub LimpiarCampo()
        txtPass.Text = ""
    End Sub

End Class