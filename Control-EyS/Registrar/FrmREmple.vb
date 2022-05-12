Public Class FrmREmple
    Dim emp As New BDQUICKIEDataSetTableAdapters.EmpleadoTableAdapter
    Dim idEmp As Integer
    Dim estado As Boolean
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCargo.Text = ""
        txtDepartamento.Text = ""
        txtEmail.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtCedula.Text = ""
        btnGuar.Enabled = True
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        txtNombre.Focus()
    End Sub

    Private Sub btnGuar_Click(sender As Object, e As EventArgs) Handles btnGuar.Click
        Dim Cedula As String = txtCedula.Text.Trim
        Dim nombre As String = txtNombre.Text.Trim
        Dim apellido As String = txtApellido.Text.Trim
        Dim telefono As String = txtTelefono.Text.Trim
        Dim email As String = txtEmail.Text.Trim
        Dim direccion As String = txtDireccion.Text.Trim


        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If
        emp.InsertarEmpleado(Cedula, nombre, apellido, telefono, email, direccion, True)
        llenaremp()
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim Cedula As String = txtCedula.Text.Trim
        Dim nombre As String = txtNombre.Text.Trim
        Dim apellido As String = txtApellido.Text.Trim
        Dim telefono As String = txtTelefono.Text.Trim
        Dim email As String = txtEmail.Text.Trim
        Dim direccion As String = txtDireccion.Text.Trim

        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If


        emp.ActualizarEmpleado(cedula, nombre, apellido, telefono, email, direccion)
        llenaremp()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Sub llenaremp()
        DgvEmpleado.DataSource = emp.GetData
        DgvEmpleado.Refresh()
        gbEmpleado.Text = "Registros guardados: " & DgvEmpleado.Rows.Count.ToString
    End Sub


End Class