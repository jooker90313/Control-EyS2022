Imports System.IO

Public Class FrmREmple
    Dim depa As New BDQUICKIEDataSetTableAdapters.DepartamentoTableAdapter
    Dim carg As New BDQUICKIEDataSetTableAdapters.CargoTableAdapter
    Dim regEmpl As New BDQUICKIEDataSetTableAdapters.EmpleadoTableAdapter
    Dim admin As New BDQUICKIEDataSetTableAdapters.UsuarioTableAdapter
    Dim idEmp As Integer
    Dim tblemp As New BDQUICKIEDataSet.QEmpleadoDataTable
    Dim taEmp As New BDQUICKIEDataSetTableAdapters.QEmpleadoTableAdapter


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmInicioAdmin.Show()
        Me.Hide()

    End Sub


    Sub llenarCarg()
        cbCargo.DataSource = carg.GetData
        cbCargo.DisplayMember = "nombreCargo"
        cbCargo.ValueMember = "idCargo"
        cbCargo.Refresh()
    End Sub

    Sub llenarDep()
        cbDep.DataSource = depa.GetData
        cbDep.DisplayMember = "nombreDepartamento"
        cbDep.ValueMember = "idDepartamento"
        cbDep.Refresh()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnGuar_Click(sender As Object, e As EventArgs) Handles btnGuar.Click

        If (ValidaDatosEmpleado() = False) Then
            Return
        End If

        Dim Cedula As String = txtCedula.Text.Trim
        Dim nombre As String = txtNombre.Text.Trim
        Dim apellido As String = txtApellido.Text.Trim
        Dim idcarg As Integer = CInt(cbCargo.SelectedValue)
        Dim iddep As Integer = CInt(cbDep.SelectedValue)
        Dim telefono As String = txtTelefono.Text.Trim
        Dim email As String = txtEmail.Text.Trim
        Dim direccion As String = txtDireccion.Text.Trim
        Dim fechaC As String = dtpFechaC.Text.Trim
        Dim fechaNac As String = dtpFechaNac.Text.Trim
        Dim clave As String = txtClave.Text.Trim
        Dim Estado As Boolean = ckbActivo.Checked

        Dim Duplicado As String = valiUser(txtCedula.Text)
        If Duplicado.Equals(txtCedula.Text) = True Then

            MsgBox("Cedula ya existente", MsgBoxStyle.Critical, "ERROR")
            Return
        End If
        regEmpl.InsertarEmp(Cedula, nombre, apellido, telefono, email, direccion, idcarg, iddep, Estado, fechaC, fechaNac)
        Dim idEmpleado As Integer = regEmpl.GetUltimoIdEmpleado()

        If (cbAdmin.Checked) Then
            admin.InsertarUsuarioAdministrador(idEmpleado, clave)

        Else
            admin.InsertarUsuarioNoAdmistrador(idEmpleado)
        End If
        MsgBox("Datos Guardados Correctamente", MsgBoxStyle.Information, "NOTIFICACION")
        llenarGrid()
        limpiarCampos()



    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If (ValidaDatosEmpleado() = False) Then
            Exit Sub
        End If

        Dim Cedula As String = txtCedula.Text.Trim
        Dim nombre As String = txtNombre.Text.Trim
        Dim apellido As String = txtApellido.Text.Trim
        Dim idcarg As Integer = CInt(cbCargo.SelectedValue)
        Dim iddep As Integer = CInt(cbDep.SelectedValue)
        Dim telefono As String = txtTelefono.Text.Trim
        Dim email As String = txtEmail.Text.Trim
        Dim direccion As String = txtDireccion.Text.Trim
        Dim fechaC As String = dtpFechaC.Text.Trim
        Dim fechaNac As String = dtpFechaNac.Text.Trim
        Dim Estado As Boolean = ckbActivo.Checked
        Dim clave As String = txtClave.Text.Trim

        regEmpl.ActualizarEmp(Cedula, nombre, apellido, telefono, email, direccion, Estado, idcarg, iddep, fechaC, fechaNac, idEmp)

        If (cbAdmin.Checked) Then
            admin.ActualizaAdmin(clave, idEmp)
        Else
            admin.ActulizarNoAdmin(idEmp)
        End If

        MsgBox("Datos Editados Correctamente", MsgBoxStyle.Information, "NOTIFICACION")

        llenarGrid()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try

            Dim resp As VariantType
            resp = (MsgBox("¿Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))

            If (resp = vbYes) Then

                regEmpl.EliminarEmp(idEmp)
                llenarGrid()
                MsgBox("Datos Eliminados Correctamente", MsgBoxStyle.Information, "NOTIFICACION")
                btnNuevo.PerformClick()

            End If
        Catch ex As Exception
            MsgBox($"Error al Eliminar: {ex}")
        End Try
    End Sub

    Sub llenarGrid()
        taEmp.Fill(tblemp)
        DgvEmpleado.DataSource = tblemp
        DgvEmpleado.Refresh()
        gbEmpleado.Text = "Registros guardados: " & DgvEmpleado.Rows.Count.ToString

        DgvEmpleado.Columns.Item("idEmp").Visible = False
        DgvEmpleado.Columns.Item("Direccion").Visible = False
        DgvEmpleado.Columns.Item("fechaNacimiento").Visible = False
        DgvEmpleado.Columns.Item("estadoEmpleado").Visible = False
        DgvEmpleado.Columns.Item("clave").Visible = False

    End Sub
    Private Sub FrmREmple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCarg()
        llenarDep()
        llenarGrid()

    End Sub


    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click

        taEmp.Fill(tblemp)

        Dim directorioBase = AppDomain.CurrentDomain.BaseDirectory
        Dim directorioReporte = Path.Combine(directorioBase, "ReportesAdmin\RptEmpleado.rdlc")

        VerReporte(tblemp, "DsEmpleado", directorioReporte)

    End Sub


    Private Sub DgvEmpleado_SelectionChanged(sender As Object, e As EventArgs) Handles DgvEmpleado.SelectionChanged

        Try
            If IsNothing(DgvEmpleado.CurrentRow) Then
                Exit Sub
            End If

            Dim fila As Integer = DgvEmpleado.CurrentRow.Index

            txtCedula.Text = DgvEmpleado.Item(0, fila).Value
            txtNombre.Text = DgvEmpleado.Item(1, fila).Value
            txtApellido.Text = DgvEmpleado.Item(2, fila).Value
            txtTelefono.Text = DgvEmpleado.Item(3, fila).Value
            txtEmail.Text = DgvEmpleado.Item(4, fila).Value
            cbCargo.Text = DgvEmpleado.Item(5, fila).Value
            cbDep.Text = DgvEmpleado.Item(6, fila).Value
            dtpFechaC.Text = DgvEmpleado.Item(7, fila).Value
            idEmp = DgvEmpleado.Item(8, fila).Value
            txtDireccion.Text = DgvEmpleado.Item(9, fila).Value
            dtpFechaNac.Text = DgvEmpleado.Item(10, fila).Value
            ckbActivo.Checked = DgvEmpleado.Item(11, fila).Value
            cbAdmin.Checked = DgvEmpleado.Item(12, fila).Value

            If (IsDBNull(DgvEmpleado.Item(13, fila).Value)) Then
                txtClave.Text = ""
            Else
                txtClave.Text = DgvEmpleado.Item(13, fila).Value
            End If

            btnGuar.Enabled = False
            btnEditar.Enabled = True
            btnEliminar.Enabled = True

        Catch ex As Exception
            MsgBox($"Error de seleccion: {ex}")

        End Try

    End Sub

    Private Sub cbAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles cbAdmin.CheckedChanged
        If (cbAdmin.Checked) Then
            txtClave.Visible = True
            lblContra.Visible = True
        Else
            txtClave.Visible = False
            lblContra.Visible = False
        End If
    End Sub

    Private Function ValidaDatosEmpleado() As Boolean

        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el Nombre vacio", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Return False

        End If


        If (String.IsNullOrEmpty(txtApellido.Text)) Then
            MsgBox("No puede dejar el campo Apellido vacio", MsgBoxStyle.Critical, "ERROR")
            txtApellido.Focus()
            Return False

        End If


        If (String.IsNullOrEmpty(cbCargo.Text)) Then
            MsgBox("No puede dejar el campo Cargo vacio", MsgBoxStyle.Critical, "ADVERTENCIA")
            cbCargo.Focus()
            Return False

        End If

        If (String.IsNullOrEmpty(cbDep.Text)) Then
            MsgBox("No puede dejar el campo Departamento vacio", MsgBoxStyle.Critical, "ADVERTENCIA")
            cbDep.Focus()
            Return False

        End If

        If (String.IsNullOrEmpty(txtEmail.Text)) Then
            MsgBox("No puede dejar el campo Email vacio", MsgBoxStyle.Critical, "ADVERTENCIA")
            txtEmail.Focus()
            Return False

        End If

        If (String.IsNullOrEmpty(txtTelefono.Text)) Then
            MsgBox("No puede dejar el campo Teléfono vacio", MsgBoxStyle.Critical, "ADVERTENCIA")
            txtTelefono.Focus()
            Return False

        End If

        If (String.IsNullOrEmpty(txtDireccion.Text)) Then
            MsgBox("No puede dejar el campo Dirección vacio", MsgBoxStyle.Critical, "ADVERTENCIA")
            txtDireccion.Focus()
            Return False

        End If

        If (String.IsNullOrEmpty(txtCedula.Text)) Then
            MsgBox("No puede dejar el campo Cédula vacio", MsgBoxStyle.Critical, "ADVERTENCIA")
            txtCedula.Focus()
            Return False

        End If

        If (String.IsNullOrEmpty(dtpFechaC.Checked)) Then
            MsgBox("No puede dejar el campo Fecha Contratación vacio", MsgBoxStyle.Critical, "ADVERTENCIA")
            dtpFechaC.Focus()
            Return False

        End If
        Return True

    End Function

    Private Sub txtDatos_TextChanged(sender As Object, e As EventArgs) Handles txtDatos.TextChanged
        Try
            Dim dato As String = txtDatos.Text & "%"
            DgvEmpleado.DataSource = taEmp.BuscarEmpleado(dato)
            DgvEmpleado.Refresh()

            gbEmpleado.Text = "Registros encontrados: " & DgvEmpleado.Rows.Count.ToString
        Catch ex As Exception
            MsgBox($"Error al buscar: {ex}")
        End Try
    End Sub

    Private Sub limpiarCampos()
        txtNombre.Text = ""
        txtApellido.Text = ""
        cbCargo.Text = ""
        cbDep.Text = ""
        txtEmail.Text = ""
        cbAdmin.Checked = False
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtCedula.Text = ""
        dtpFechaC.Text = ""
        dtpFechaNac.Text = ""
        txtClave.Text = ""
        ckbActivo.Checked = False
        btnGuar.Enabled = True
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        MsgBox("Campos limpios", MsgBoxStyle.Information, "NOTIFICACION")
    End Sub
End Class