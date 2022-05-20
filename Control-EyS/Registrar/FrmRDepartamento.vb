Public Class FrmRDepartamento
    Dim depa As New BDQUICKIEDataSetTableAdapters.DepartamentoTableAdapter
    Dim idDep As Integer
    Dim estado As Boolean
    Dim tblDepa As New BDQUICKIEDataSet.DepartamentoDataTable

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmInicioAdmin.Show()
        Me.Hide()


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Text = ""
        btnGuar.Enabled = True
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        txtNombre.Focus()
    End Sub

    Private Sub btnGuar_Click(sender As Object, e As EventArgs) Handles btnGuar.Click
        Dim nombre As String = txtNombre.Text.Trim
        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If
        depa.InsertarDepa(nombre, True)
        llenardepa()
    End Sub

    Sub llenardepa()
        DgvDepartamento.DataSource = depa.GetData
        DgvDepartamento.Refresh()
        gbDepartamento.Text = "Registros guardados: " & DgvDepartamento.Rows.Count.ToString
    End Sub

    Private Sub FrmRDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenardepa()
    End Sub

    Private Sub DgvDepartamento_DoubleClick(sender As Object, e As EventArgs) Handles DgvDepartamento.DoubleClick
        Try
            Dim fila As Integer = DgvDepartamento.CurrentRow.Index
            idDep = DgvDepartamento.Item(0, fila).Value
            txtNombre.Text = DgvDepartamento.Item(1, fila).Value
            estado = DgvDepartamento.Item(2, fila).Value
            btnGuar.Enabled = False
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim nombre As String = txtNombre.Text.Trim
        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If
        depa.ActualizarDepa(nombre, estado, idDep)

        llenardepa()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                depa.EliminarDepa(idDep)
                llenardepa()
                btnNuevo.PerformClick()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim dato As String = txtDatos.Text & "%"
            DgvDepartamento.DataSource = depa.BuscarPorNombre(dato)
            DgvDepartamento.Refresh()

            gbDepartamento.Text = "Registros encontrados: " & DgvDepartamento.Rows.Count.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        depa.Fill(tblDepa)
        VerReporte(tblDepa, "DsDepartamento", "C:\Users\Norman Romero\Pictures\Control-EyS2022\Control-EyS2022\Control-EyS\ReportesAdmin\Departamento.rdlc")
    End Sub
End Class