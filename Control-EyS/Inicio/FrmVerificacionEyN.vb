Public Class FrmVerificacionEyS
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        FrmLogin.Show()
        Me.Hide()


    End Sub

    Private Sub btnCerrarSesion_Paint(sender As Object, e As PaintEventArgs) Handles btnCerrarSesion.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnCerrarSesion.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnCerrarSesion.Region = New Region(buttonPath)
    End Sub
End Class