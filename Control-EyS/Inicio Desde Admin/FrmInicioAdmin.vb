Public Class FrmInicioAdmin
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim response
        response = MsgBox("¿Desea cerrar sessión? ", vbOKCancel, "Notificacion")
        If response = vbOK Then
            FrmLogin.Show()
            Me.Hide()

        End If



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Dim response
        response = MsgBox("¿Desea cerrar sessión? ", vbOKCancel, "Notificacion")
        If response = vbOK Then
            FrmLogin.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblFe.Text = DateTime.Now.ToShortDateString

    End Sub
    Private Sub ExportarReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarReportesToolStripMenuItem.Click
        FrmExportar.Show()
        Me.Hide()

    End Sub


    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem.Click
        FrmRDepartamento.Show()
        Me.Hide()

    End Sub

    Private Sub CargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem.Click
        FrmRCargo.Show()
        Me.Hide()

    End Sub


    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        FrmREmple.Show()
        Me.Hide()
    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        frmEmpleado.Show()
        Me.Hide()
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        frmDepartamento.Show()
        Me.Hide()
    End Sub

    Private Sub CargoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem1.Click
        frmCargo.Show()
        Me.Hide()
    End Sub

    Private Sub HorasDeEntradaYSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorasDeEntradaYSalidaToolStripMenuItem.Click
        frmHoraEyS.Show()
        Me.Hide()
    End Sub

    Private Sub FrmInicioAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class