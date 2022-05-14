Public Class FrmREmple
    Dim depa As New BDQUICKIEDataSetTableAdapters.DepartamentoTableAdapter
    Dim carg As New BDQUICKIEDataSetTableAdapters.CargoTableAdapter
    Dim regEmpl As New BDQUICKIEDataSetTableAdapters.EmpleadoTableAdapter
    Dim idEmp As Integer
    Dim estado As Boolean
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmInicioAdmin.Show()
        Me.Hide()

    End Sub


    Sub llenarCarg()
        cbCargo.DataSource = carg.GetData
        cbCargo.DisplayMember = "Nombre del Cargo"
        cbCargo.ValueMember = "idCargo"
        cbCargo.Refresh()
    End Sub

    Sub llenarDep()
        cbDep.DataSource = depa.GetData
        cbDep.DisplayMember = "Nombre Departamento"
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
        btnGuar.Enabled = True
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
    End Sub

    Private Sub btnGuar_Click(sender As Object, e As EventArgs) Handles btnGuar.Click
        Dim Cedula As String = txtCedula.Text.Trim
        Dim nombre As String = txtNombre.Text.Trim
        Dim apellido As String = txtApellido.Text.Trim
        Dim idcarg As Integer = CInt(cbCargo.SelectedValue)
        Dim iddep As Integer = CInt(cbDep.SelectedValue)
        Dim telefono As String = txtTelefono.Text.Trim
        Dim email As String = txtEmail.Text.Trim
        Dim direccion As String = txtDireccion.Text.Trim


        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If
        regEmpl.InsertarEmp(Cedula, nombre, apellido, telefono, email, direccion, idcarg, iddep, True)
        llenarGrid()
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim Cedula As String = txtCedula.Text.Trim
        Dim nombre As String = txtNombre.Text.Trim
        Dim apellido As String = txtApellido.Text.Trim
        Dim idcarg As Integer = CInt(cbCargo.SelectedValue)
        Dim iddep As Integer = CInt(cbDep.SelectedValue)
        Dim telefono As String = txtTelefono.Text.Trim
        Dim email As String = txtEmail.Text.Trim
        Dim direccion As String = txtDireccion.Text.Trim


        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If
        regEmpl.ActualizarEmp(Cedula, nombre, apellido, telefono, email, direccion, idcarg, iddep, estado, idEmp)
        llenarGrid()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                regEmpl.EliminarEmpl(idEmp)
                llenarGrid()
                btnNuevo.PerformClick()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub llenarGrid()
        DgvEmpleado.DataSource = regEmpl.GetData
        DgvEmpleado.Refresh()
        gbEmpleado.Text = "Registros guardados: " & DgvEmpleado.Rows.Count.ToString
    End Sub

    Private Sub FrmREmple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCarg()
        llenarDep()
        llenarGrid()

    End Sub

    Private Sub DgvEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmpleado.CellContentClick
        Try
            Dim fila As Integer = DgvEmpleado.CurrentRow.Index
            idEmp = DgvEmpleado.Item(0, fila).Value
            txtCedula.Text = DgvEmpleado.Item(1, fila).Value
            txtNombre.Text = DgvEmpleado.Item(2, fila).Value
            txtApellido.Text = DgvEmpleado.Item(3, fila).Value
            txtTelefono.Text = DgvEmpleado.Item(4, fila).Value
            txtEmail.Text = DgvEmpleado.Item(5, fila).Value
            txtDireccion.Text = DgvEmpleado.Item(6, fila).Value
            estado = DgvEmpleado.Item(7, fila).Value
            btnGuar.Enabled = False
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim dato As String = txtDatos.Text & "%"
            DgvEmpleado.DataSource = regEmpl.BuscarPorNombre(dato)
            DgvEmpleado.Refresh()

            gbEmpleado.Text = "Registros encontrados: " & DgvEmpleado.Rows.Count.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class