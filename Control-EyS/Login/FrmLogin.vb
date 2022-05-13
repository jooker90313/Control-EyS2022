


Public Class FrmLogin
    Dim regEmpl As New BDQUICKIEDataSetTableAdapters.EmpleadoTableAdapter

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
        'Dim Id As String = CedulaRegistrado(txtId.Text)

        If CedulaRegistrado(txtId.Text) Then
            FrmRegistrarEyN.Show()

        Else txtId.Text = "admin"
            FrmInicioAdmin.Show()
            Me.Hide()


            'txtId.Text = Id

        End If
        'CedulaRegistrado(txtId.Text)
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()

    End Sub



End Class
