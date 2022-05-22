Public Class FrmRCargo
    Dim carg As New BDQUICKIEDataSetTableAdapters.CargoTableAdapter
    Dim depa As New BDQUICKIEDataSetTableAdapters.DepartamentoTableAdapter
    Dim idCar As Integer
    Dim estado As Boolean
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
        cbDepartamento.Text = ""
        txtDescripcion.Text = ""
        btnGuar.Enabled = True
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        txtNombre.Focus()
    End Sub

    Private Sub btnGuar_Click(sender As Object, e As EventArgs) Handles btnGuar.Click
        Dim nombre As String = txtNombre.Text.Trim
        Dim iddep As Integer = CInt(cbDepartamento.SelectedValue)
        Dim descripcion As String = txtDescripcion.Text.Trim
        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If
        carg.InsertarCargo(nombre, descripcion, iddep, True)
        llenarcargo()
    End Sub

    Sub llenarcargo()
        taCarg.Fill(dtCarg)
        DgvCargo.DataSource = dtCarg
        DgvCargo.Refresh()

        DgvCargo.Text = "Registros guardados: " & DgvCargo.Rows.Count.ToString
    End Sub

    Sub llenarDep()
        cbDepartamento.DataSource = depa.GetData
        cbDepartamento.DisplayMember = "nombreDepartamento"
        cbDepartamento.ValueMember = "idDepartamento"
        cbDepartamento.Refresh()
    End Sub

    Private Sub FrmRCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarcargo()
        llenarDep()

    End Sub
    Private Sub DgvCargo_DoubleClick(sender As Object, e As EventArgs) Handles DgvCargo.DoubleClick
        Try
            Dim fila As Integer = DgvCargo.CurrentRow.Index
            'idCar = DgvCargo.Item(0, fila).Value
            txtNombre.Text = DgvCargo.Item(0, fila).Value
            txtDescripcion.Text = DgvCargo.Item(1, fila).Value
            cbDepartamento.Text = DgvCargo.Item(2, fila).Value
            btnGuar.Enabled = False
            btnEditar.Enabled = True
            btnEliminar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim nombre As String = txtNombre.Text.Trim
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                carg.EliminarCargo(nombre)
                llenarcargo()
                btnNuevo.PerformClick()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim nombre As String = txtNombre.Text.Trim
        Dim iddep As Integer = CInt(cbDepartamento.SelectedValue)
        Dim descripcion As String = txtDescripcion.Text.Trim
        If (String.IsNullOrEmpty(txtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtNombre.Focus()
            Exit Sub
        End If
        'carg.ActualizarCargo(nombre, descripcion, True, iddep)
        llenarcargo()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim dato As String = txtDatos.Text & "%"
            DgvCargo.DataSource = taCarg.GetDataByNombre(dato)
            DgvCargo.Refresh()

            gbCargo.Text = "Registros encontrados: " & DgvCargo.Rows.Count.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        carg.Fill(tblCarg)
        VerReporte(tblCarg, "DsCargo", "C:\Users\Norman Romero\Pictures\Control-EyS2022\Control-EyS2022\Control-EyS\ReportesAdmin\Cargo.rdlc")
    End Sub
End Class