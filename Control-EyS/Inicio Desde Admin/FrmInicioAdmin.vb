Imports System.IO

Public Class FrmInicioAdmin
    Dim Emple As New BDQUICKIEDataSetTableAdapters.QEmpleadoTableAdapter
    Dim tblEmple As New BDQUICKIEDataSet.QEmpleadoDataTable
    Dim Depa As New BDQUICKIEDataSetTableAdapters.QDepartamentoTableAdapter
    Dim tblDepa As New BDQUICKIEDataSet.QDepartamentoDataTable
    Dim Cargo As New BDQUICKIEDataSetTableAdapters.QCargoTableAdapter
    Dim tblCargo As New BDQUICKIEDataSet.QCargoDataTable
    Dim taRegAsis As New BDQUICKIEDataSetTableAdapters.MAsistenciaTableAdapter
    Dim dtRegAsis As New BDQUICKIEDataSet.MAsistenciaDataTable


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
        'lblFe.Text = DateTime.Now.ToShortDateString

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
        Dim directorioBase = AppDomain.CurrentDomain.BaseDirectory
        Dim directorioReporte = Path.Combine(directorioBase, "ReportesAdmin\RptEmpleado.rdlc")

        VerReporte(tblEmple, "DsEmpleado", directorioReporte)

    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Depa.Fill(tblDepa)
        Dim directorioBase = AppDomain.CurrentDomain.BaseDirectory
        Dim directorioReporte = Path.Combine(directorioBase, "ReportesAdmin\RptDepartamentos.rdlc")

        VerReporte(tblDepa, "DsDepartamentos", directorioReporte)


    End Sub

    Private Sub CargoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem1.Click
        Cargo.Fill(tblCargo)
        Dim directorioBase = AppDomain.CurrentDomain.BaseDirectory
        Dim directorioReporte = Path.Combine(directorioBase, "ReportesAdmin\RptCargos.rdlc")

        VerReporte(tblCargo, "DsCargos", directorioReporte)




    End Sub
    Private Sub HorasDeEntradaYSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorasDeEntradaYSalidaToolStripMenuItem.Click

        Dim fecha As DateTime = DateTimePicker1.Value
        taRegAsis.Fill(dtRegAsis, fecha)
        VerReporte(dtRegAsis, "DsAsistencia", "C:\Users\Norman Romero\source\repos\Control-EyS2022\Control-EyS\ReportesAdmin\RptHoraEyS.rdlc")

        'TODO' Error al asignar como AppDomain

    End Sub

    Private Sub FrmInicioAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fecha As DateTime = Now

        LlenarGrid(fecha)
        DateTimePicker1.Value = fecha

    End Sub

    Sub LlenarGrid(ByVal fecha As DateTime)

        taRegAsis.Fill(dtRegAsis, fecha)
        DgvhEyS.DataSource = dtRegAsis

        DgvhEyS.Refresh()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        Dim fecha As DateTime = DateTimePicker1.Value
        LlenarGrid(fecha)

    End Sub
End Class