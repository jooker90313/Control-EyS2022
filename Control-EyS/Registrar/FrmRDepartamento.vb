Public Class FrmRDepartamento
    Dim depa As New BDQUICKIEDataSetTableAdapters.DepartamentoTableAdapter
    Dim idDepa As Integer
    Dim taDep As New BDQUICKIEDataSetTableAdapters.QDepartamentoTableAdapter
    Dim dtDep As New BDQUICKIEDataSet.QDepartamentoDataTable

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmInicioAdmin.Show()
        Me.Hide()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnGuar_Click(sender As Object, e As EventArgs) Handles btnGuar.Click
        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If
        Dim nombre As String = txtNombre.Text.Trim
        Dim Estado As Boolean = ckbActivo.Checked
        Dim Duplicado As String = valicionDepartamento(txtNombre.Text)
        If Duplicado.Equals(txtNombre.Text) = True Then

            MsgBox("Departamento ya existente", MsgBoxStyle.Critical, "ERROR")
            Return
        End If
        depa.InsertarDepa(nombre, Estado)
        llenardepa()
        MsgBox("Datos Guardados Correctamente", MsgBoxStyle.Information, "NOTIFICACION")

        limpiarCampos()
    End Sub

    Sub llenardepa()
        taDep.Fill(dtDep)
        DgvDepartamento.DataSource = dtDep
        DgvDepartamento.Refresh()
        gbDepartamento.Text = "Registros guardados: " & DgvDepartamento.Rows.Count.ToString

        DgvDepartamento.Columns.Item("idDepartamento").Visible = False
    End Sub

    Private Sub FrmRDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenardepa()
    End Sub

    Private Sub DgvDepartamento_SelectionChanged(sender As Object, e As EventArgs) Handles DgvDepartamento.SelectionChanged

        Try
            If IsNothing(DgvDepartamento.CurrentRow) Then
                Exit Try
            End If

            Dim fila As Integer = DgvDepartamento.CurrentRow.Index
            txtNombre.Text = DgvDepartamento.Item(0, fila).Value
            idDepa = DgvDepartamento.Item(1, fila).Value
            ckbActivo.Checked = DgvDepartamento.Item(2, fila).Value


            btnGuar.Enabled = False
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If

        Dim nombre As String = txtNombre.Text.Trim
        Dim Estado As Boolean = ckbActivo.Checked

        depa.ActualizarDepa(nombre, Estado, idDepa)
        MsgBox("Datos Editados Correctamente", MsgBoxStyle.Information, "NOTIFICACION")

        llenardepa()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                depa.EliminarDepa(idDepa)
                llenardepa()
                btnNuevo.PerformClick()

            End If
        Catch ex As Exception
            MsgBox($"Error al Eliminar: {ex}")
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        taDep.Fill(dtDep)
        VerReporte(dtDep, "DsDepartamentos", "C:\Users\Norman Romero\source\repos\Control-EyS2022\Control-EyS\ReportesAdmin\RptDepartamentos.rdlc")
    End Sub

    Private Sub txtDatos_TextChanged(sender As Object, e As EventArgs) Handles txtDatos.TextChanged
        Try
            Dim dato As String = txtDatos.Text & "%"
            DgvDepartamento.DataSource = taDep.GetDataByNombre(dato)
            DgvDepartamento.Refresh()

            gbDepartamento.Text = "Registros encontrados: " & DgvDepartamento.Rows.Count.ToString
        Catch ex As Exception
            MsgBox($"Error al Buscar: {ex}")
        End Try
    End Sub
    Private Sub limpiarCampos()
        txtNombre.Text = ""
        ckbActivo.Checked = False
        btnGuar.Enabled = True
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        txtNombre.Focus()
        MsgBox("Campos limpios!", MsgBoxStyle.Information, "INFORMACIÓN")

    End Sub
End Class