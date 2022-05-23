Public Class FrmREmple
    Dim depa As New BDQUICKIEDataSetTableAdapters.DepartamentoTableAdapter
    Dim carg As New BDQUICKIEDataSetTableAdapters.CargoTableAdapter
    Dim regEmpl As New BDQUICKIEDataSetTableAdapters.EmpleadoTableAdapter
    Dim admin As New BDQUICKIEDataSetTableAdapters.UsuarioTableAdapter
    Dim idEmp As Integer
    Dim tblemp As New BDQUICKIEDataSet.QEmpleadoDataTable
    Dim taEmp As New BDQUICKIEDataSetTableAdapters.QEmpleadoTableAdapter
    Dim dtEmp As New BDQUICKIEDataSet.QEmpleadoDataTable

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
        txtNombre.Text = ""
        txtApellido.Text = ""
        cbCargo.Text = ""
        cbDep.Text = ""
        txtEmail.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtCedula.Text = ""
        dtpFechaC.Text = ""
        btnGuar.Enabled = True
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
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
        Dim clave As String = txtClave.Text.Trim

        regEmpl.InsertarEmp(Cedula, nombre, apellido, telefono, email, direccion, idcarg, iddep, True, fechaC)
        Dim idEmpleado As Integer = regEmpl.GetUltimoIdEmpleado()

        If (cbAdmin.Checked) Then
            admin.InsertarUsuarioAdministrador(idEmpleado, clave)
        Else
            admin.InsertarUsuarioNoAdmistrador(idEmpleado)
        End If

        llenarGrid()

    End Sub


    Private Function ValidaDatosEmpleado() As Boolean

        If (String.IsNullOrEmpty(txtNombre.Text)) Then

            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()

            Return False

        End If

        Return True

    End Function

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

        regEmpl.ActualizarEmp(Cedula, nombre, apellido, telefono, email, direccion, True, idcarg, iddep, fechaC, idEmp)
        llenarGrid()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try

            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))

            If (resp = vbYes) Then

                regEmpl.EliminarEmp(idEmp)
                llenarGrid()
                btnNuevo.PerformClick()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub llenarGrid()
        taEmp.Fill(dtEmp)
        DgvEmpleado.DataSource = dtEmp
        DgvEmpleado.Refresh()
        gbEmpleado.Text = "Registros guardados: " & DgvEmpleado.Rows.Count.ToString

        DgvEmpleado.Columns.Item("idEmp").Visible = False
    End Sub

    Private Sub FrmREmple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCarg()
        llenarDep()
        llenarGrid()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim dato As String = txtDatos.Text & "%"
            DgvEmpleado.DataSource = taEmp.GetDataByNombre(dato)
            DgvEmpleado.Refresh()

            gbEmpleado.Text = "Registros encontrados: " & DgvEmpleado.Rows.Count.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        taEmp.Fill(tblemp)
        VerReporte(tblemp, "DsEmpleado", "C:\Users\Norman Romero\Downloads\Control-EyS2022\Control-EyS2022\Control-EyS\ReportesAdmin\RptEmpleado.rdlc")
    End Sub


    Private Sub DgvEmpleado_SelectionChanged(sender As Object, e As EventArgs) Handles DgvEmpleado.SelectionChanged

        Try
            If IsNothing(DgvEmpleado.CurrentRow) Then
                Exit Try
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

            btnGuar.Enabled = False
            btnEditar.Enabled = True
            btnEliminar.Enabled = True

        Catch ex As Exception

        End Try

    End Sub
End Class