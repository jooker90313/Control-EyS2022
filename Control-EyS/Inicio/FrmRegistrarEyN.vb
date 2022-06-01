
Public Class FrmRegistrarEyN
    Dim regEmpl As New BDQUICKIEDataSetTableAdapters.EmpleadoTableAdapter
    Dim horaEyS As New BDQUICKIEDataSetTableAdapters.Registro_de_asistenciaTableAdapter
    Dim Tiempo As DateTime
    Dim Tiempo2 As DateTime
    Dim Hora_Inicio As DateTime
    Dim idRegistro As Integer

    Private Sub BtnEntrada_Paint(sender As Object, e As PaintEventArgs) Handles btnEntrada.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnEntrada.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnEntrada.Region = New Region(buttonPath)
    End Sub

    Private Sub BtnSalida_Paint(sender As Object, e As PaintEventArgs) Handles btnSalida.Paint
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
        'lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        'lblFecha.Text = DateTime.Now.ToLongDateString()
        lblFecha.Text = DateTime.Now.ToLongDateString()
        Tiempo = Now.ToString("HH:mm:ss")
        lblHora.Text = Tiempo
    End Sub

    Private Sub BtnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        btnEntrada.Enabled = False
        btnSalida.Enabled = True
        Hora_Inicio = Now.ToString("HH:mm:ss")
        lblInicio.Text = Hora_Inicio

        Dim UserName = FrmLogin.IdEmpleado
        Dim horaEntrada As Date? = Now
        Dim fecha As Date = Now
        Dim idEmp As Integer = UserName



        Dim registro = horaEyS.InsertEntrada(horaEntrada, fecha, idEmp)
        idRegistro = registro.First.idRegistro

    End Sub

    Private Sub BtnSalida_Click(sender As Object, e As EventArgs) Handles btnSalida.Click

        btnEntrada.Enabled = True
        btnSalida.Enabled = False
        Timer1.Stop()
        Tiempo2 = Now.ToString("HH:mm:ss")
        lblSalida.Text = Tiempo2



        Dim registrosEntradaSalida = horaEyS.GetRegistroEntradaSalida(idRegistro)
        If Not registrosEntradaSalida.Any() Then

            MsgBox("No se encontro registros de entrada y salida", MsgBoxStyle.Critical)
            Exit Sub

        End If

        Dim horaEntrada = registrosEntradaSalida.First.horaEntrada
        Dim horaSalida As Date = Now

        Dim diferenciaFecha = horaSalida - horaEntrada

        Dim horas As String = diferenciaFecha.Hours.ToString().PadLeft(2, "0")
        Dim minutos As String = diferenciaFecha.Minutes.ToString().PadLeft(2, "0")
        Dim segundos As String = diferenciaFecha.Seconds.ToString().PadLeft(2, "0")

        Dim totalHoras As String = $"{horas}:{minutos}:{segundos}"

        horaEyS.UpdateRegistroEntrada(totalHoras, horaSalida, idRegistro)
    End Sub

    Private Sub BtnVerEyS_Click(sender As Object, e As EventArgs) Handles BtnVerEyS.Click
        FrmVerificacionEyS.Show()
        Me.Hide()
    End Sub

    Private Sub FrmRegistrarEyN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class