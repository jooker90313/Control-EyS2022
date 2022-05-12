Public Class FrmRegistrarEyN
    Private Sub BtnEntrada_Paint(sender As Object, e As PaintEventArgs) Handles btnEntrada.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnEntrada.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnEntrada.Region = New Region(buttonPath)
    End Sub

    Private Sub btnSalida_Paint(sender As Object, e As PaintEventArgs) Handles btnSalida.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnSalida.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnSalida.Region = New Region(buttonPath)
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()


    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        Dim response
        response = MsgBox("Desea marcar su entrada empleado Jorge? ", vbYesNo, "Notificacion")
        If response = vbYes Then
            FrmVerificacionEyS.Show()
            Me.Hide()

        Else
            DialogResult = vbNo
            Return

        End If
    End Sub

    Private Sub btnSalida_Click(sender As Object, e As EventArgs) Handles btnSalida.Click
        Dim response
        response = MsgBox("Desea marcar su salida empleado Jorge? ", vbYesNo, "Notificacion")
        If response = vbYes Then
            FrmVerificacionEyS.Show()
            Me.Hide()

        Else
            DialogResult = vbNo
            Return

        End If
    End Sub

    Private Sub FrmRegistrarEyN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class