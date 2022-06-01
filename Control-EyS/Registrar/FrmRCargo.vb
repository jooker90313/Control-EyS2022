Public Class FrmRCargo
    Dim carg As New BDQUICKIEDataSetTableAdapters.CargoTableAdapter
    Dim idCar As Integer
    Dim tblCarg As New BDQUICKIEDataSet.CargoDataTable
    Dim taCarg As New BDQUICKIEDataSetTableAdapters.QCargoTableAdapter
    Dim dtCarg As New BDQUICKIEDataSet.QCargoDataTable

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmInicioAdmin.Show()
        Me.Hide()


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Text = ""
        ckbActivo.Checked = False
        txtDescripcion.Text = ""
        btnGuar.Enabled = True
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        txtNombre.Focus()
        MsgBox("Campos limpios!", MsgBoxStyle.Information, "INFORMACIÓN")
    End Sub

    Private Sub btnGuar_Click(sender As Object, e As EventArgs) Handles btnGuar.Click

        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If

        If (String.IsNullOrEmpty(txtDescripcion.Text)) Then
            MsgBox("No puede quedar vacío la Descripción", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If
        Dim nombre As String = txtNombre.Text.Trim
        Dim Estado As Boolean = ckbActivo.Checked
        Dim descripcion As String = txtDescripcion.Text.Trim
        Dim Duplicado As String = valicionCargo(txtNombre.Text)
        If Duplicado.Equals(txtNombre.Text) = True Then

            MsgBox("El Cargo ya existente", MsgBoxStyle.Critical, "ERROR")
            Return
        End If
        carg.InsertarCargo(nombre, descripcion, Estado)
        MsgBox("Datos guardados exitosamente!", MsgBoxStyle.Information, "INFORMACIÓN")
        llenarcargo()
        btnNuevo.PerformClick()

    End Sub

    Sub llenarcargo()
        taCarg.Fill(dtCarg)
        DgvCargo.DataSource = dtCarg
        DgvCargo.Refresh()
        DgvCargo.Text = "Registros guardados: " & DgvCargo.Rows.Count.ToString
        DgvCargo.Columns.Item("idCargo").Visible = False
        'DgvCargo.Columns.Item("Estado").Visible = False
    End Sub


    Private Sub FrmRCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarcargo()

    End Sub
    Private Sub DgvCargo_SelectionChanged(sender As Object, e As EventArgs) Handles DgvCargo.SelectionChanged
        Try
            If IsNothing(DgvCargo.CurrentRow) Then
                Exit Try
            End If

            Dim fila As Integer = DgvCargo.CurrentRow.Index

            txtNombre.Text = DgvCargo.Item(0, fila).Value
            txtDescripcion.Text = DgvCargo.Item(1, fila).Value
            idCar = DgvCargo.Item(2, fila).Value
            ckbActivo.Checked = DgvCargo.Item(3, fila).Value

            btnGuar.Enabled = False
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                carg.EliminarCargo(idCar)
                llenarcargo()
                btnNuevo.PerformClick()

            End If
        Catch ex As Exception
            MsgBox($"Error al Eliminar: {ex}")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el Nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If

        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío la Descripción", MsgBoxStyle.Critical, "ERROR")
            txtDescripcion.Focus()
            Exit Sub
        End If

        Dim nombre As String = txtNombre.Text.Trim
        Dim descripcion As String = txtDescripcion.Text.Trim
        Dim Estado As Boolean = ckbActivo.Checked

        carg.ActualizarCargo(nombre, descripcion, Estado, idCar)
        MsgBox("Datos Modificados exitosamente!", MsgBoxStyle.Information, "INFORMACIÓN")
        llenarcargo()
    End Sub



    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        taCarg.Fill(dtCarg)
        VerReporte(dtCarg, "DsCargos", "C:\Users\Norman Romero\source\repos\Control-EyS2022\Control-EyS\ReportesAdmin\RptCargos.rdlc")
    End Sub

    Private Sub txtDatos_TextChanged(sender As Object, e As EventArgs) Handles txtDatos.TextChanged
        Try
            Dim dato As String = txtDatos.Text & "%"
            DgvCargo.DataSource = taCarg.GetDataByNombre(dato)
            DgvCargo.Refresh()

            gbCargo.Text = "Registros encontrados: " & DgvCargo.Rows.Count.ToString
        Catch ex As Exception
            MsgBox($"Error al Buscar: {ex}")
        End Try
    End Sub
End Class