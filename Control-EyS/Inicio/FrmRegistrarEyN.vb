
Public Class FrmRegistrarEyN
    Dim regEmpl As New BDQUICKIEDataSetTableAdapters.EmpleadoTableAdapter
    Dim HoraEyS As New BDQUICKIEDataSetTableAdapters.Registro_de_asistenciaTableAdapter
    Dim Hora_Inicio As DateTime
    'Dim Hora_Final As DateTime
    Dim Tiempo As DateTime
    Dim Tiempo2 As DateTime

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
        lblFecha.Text = DateTime.Now.ToShortDateString
        Tiempo = Now.ToString("HH:mm:ss")
        lblHora.Text = Tiempo
    End Sub

    Private Sub BtnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click

        Dim UserName = FrmLogin.UserName

        Dim totalHoras As Double? = Nothing
        Dim horaEntrada As Date? = Now
        Dim horaSalida As Date? = Nothing
        Dim fecha As Date? = Now
        Dim idEmp As Integer = UserName

        HoraEyS.InsertarHoraEyS(totalHoras, horaEntrada, horaSalida, fecha, idEmp)
        idRegistro = HoraEyS.GetUltimoRegistro()

    End Sub

    Private Sub btnSalida_Click(sender As Object, e As EventArgs) Handles btnSalida.Click
        'Dim response
        'Dim entrada As DateTime = lblInicio.Text.Trim
        'Dim salida As DateTime = lblSalida.Text.Trim
        'Dim HorasT As Double = lblTrabajadas.Text.Trim
        'Dim fecha As DateTime = lblFecha.Text.Trim
        'Dim idEmp As Integer = txtIDC.Text.Trim
        'response = MsgBox("Desea marcar su entrada empleado Jorge? ", vbOKCancel, "Notificación")
        'If response = vbOK Then
        '    'btnEntrada.Enabled = True
        '    'btnSalida.Enabled = False
        '    Timer1.Stop()
        '    Tiempo2 = Now.ToString("HH:mm:ss")
        '    lblSalida.Text = Tiempo2



        '    FrmVerificacionEyS.Show()
        '    Me.Hide()
        '    HoraEyS.InsertarHoraEyS(HorasT, entrada, salida, fecha, idEmp)
        'End If

        Dim horaSalida As Date? = Now
        HoraEyS.UpdateRegistroEntrada(horaSalida, idRegistro)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        'Dim HoraTrabajadas As Double = Val(50)
        Dim Hora_Fin As DateTime = Now.ToString("HH:mm:ss")
        Dim diferencia As TimeSpan = Hora_Fin.Subtract(Hora_Inicio)
        Dim horas As Double = Math.Ceiling(diferencia.TotalHours)
        Dim valor As Double = diferencia.TotalHours


        lblTrabajadas.Text = "Horas Trabajadas:" & horas

    End Sub

End Class