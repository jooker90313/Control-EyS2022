Public Class frmCargo
    Dim carg As New BDQUICKIEDataSetTableAdapters.CargoTableAdapter

    Sub MostrarGrid()
        DgvCargo.DataSource = carg.GetData
        DgvCargo.Refresh()
        DgvCargo.Text = "Registros guardados: " & DgvCargo.Rows.Count.ToString
    End Sub
    Private Sub frmCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarGrid()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmInicioAdmin.Show()
        Me.Hide()
    End Sub
End Class