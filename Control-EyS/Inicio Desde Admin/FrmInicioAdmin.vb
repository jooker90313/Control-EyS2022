Public Class FrmInicioAdmin
    Dim hEyS As New BDQUICKIEDataSetTableAdapters.Registro_de_asistenciaTableAdapter
    Dim tblhEyS As New BDQUICKIEDataSet.Registro_de_asistenciaDataTable
    Dim Emple As New BDQUICKIEDataSetTableAdapters.EmpleadoTableAdapter
    Dim tblEmple As New BDQUICKIEDataSet.EmpleadoDataTable
    Dim Depa As New BDQUICKIEDataSetTableAdapters.DepartamentoTableAdapter
    Dim tblDepa As New BDQUICKIEDataSet.DepartamentoDataTable
    Dim Cargo As New BDQUICKIEDataSetTableAdapters.CargoTableAdapter
    Dim tblCargo As New BDQUICKIEDataSet.CargoDataTable

    Dim taRegAsis As New BDQUICKIEDataSetTableAdapters.QRegistroAsistenciaTableAdapter
    Dim dtRegAsis As New BDQUICKIEDataSet.QRegistroAsistenciaDataTable


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
        Emple.Fill(tblEmple)
        VerReporte(tblEmple, "DsEmpleado", "C:\Users\Norman Romero\Pictures\Control-EyS2022\Control-EyS2022\Control-EyS\ReportesAdmin\Empleado.rdlc")
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Depa.Fill(tblDepa)
        VerReporte(tblDepa, "DsDepartamento", "C:\Users\Norman Romero\Pictures\Control-EyS2022\Control-EyS2022\Control-EyS\ReportesAdmin\Departamento.rdlc")
    End Sub

    Private Sub CargoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem1.Click
        Cargo.Fill(tblCargo)
        VerReporte(tblCargo, "DsCargo", "C:\Users\Norman Romero\Pictures\Control-EyS2022\Control-EyS2022\Control-EyS\ReportesAdmin\Cargo.rdlc")
    End Sub

    Private Sub HorasDeEntradaYSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorasDeEntradaYSalidaToolStripMenuItem.Click
        hEyS.FillBy(tblhEyS)
        VerReporte(tblhEyS, "DshEyS", "C:\Users\Norman Romero\Pictures\Control-EyS2022\Control-EyS2022\Control-EyS\ReportesAdmin\horaEyS.rdlc")

    End Sub

    Private Sub FrmInicioAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
    End Sub

    Sub llenarGrid()

        taRegAsis.Fill(dtRegAsis)
        DgvhEyS.DataSource = dtRegAsis
        DgvhEyS.Refresh()

    End Sub
End Class