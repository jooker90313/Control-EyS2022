Public Class frmEmpleado
    Dim regEmpl As New BDQUICKIEDataSetTableAdapters.EmpleadoTableAdapter

    Sub LlenaraGridEmpleado()
        DgvEmpleado.DataSource = regEmpl.GetData
        DgvEmpleado.Refresh()
        gbEmpleado.Text = "Registros guardados: " & DgvEmpleado.Rows.Count.ToString
    End Sub
    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaraGridEmpleado()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmInicioAdmin.Show()
        Me.Hide()
    End Sub
End Class