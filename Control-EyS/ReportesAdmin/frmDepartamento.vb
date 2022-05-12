Public Class frmDepartamento
    Dim depa As New BDQUICKIEDataSetTableAdapters.DepartamentoTableAdapter
    Sub MostrarDepa()
        DgvDepartamento.DataSource = depa.GetData
        DgvDepartamento.Refresh()
        gbDepartamento.Text = "Registros guardados: " & DgvDepartamento.Rows.Count.ToString
    End Sub
    Private Sub frmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDepa()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmInicioAdmin.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class