Public Class FrmExportar
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub btnPdf_Paint(sender As Object, e As PaintEventArgs) Handles btnPdf.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnPdf.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnPdf.Region = New Region(buttonPath)
    End Sub

    Private Sub btnExcel_Paint(sender As Object, e As PaintEventArgs) Handles btnExcel.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnExcel.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnExcel.Region = New Region(buttonPath)
    End Sub

    Private Sub btnCerrarSesion2_Click(sender As Object, e As EventArgs) Handles btnLoginAdmin.Click
        FrmInicioAdmin.Show()
        Me.Hide()

    End Sub

    Private Sub btnCerrarSesion2_Paint(sender As Object, e As PaintEventArgs) Handles btnLoginAdmin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLoginAdmin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLoginAdmin.Region = New Region(buttonPath)
    End Sub

    Private Sub FrmExportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class