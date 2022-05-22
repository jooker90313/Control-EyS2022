<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmREmple
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmREmple))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.BtnReporte = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDepartamrnto = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ckbActivo = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtDatos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbEmpleado = New System.Windows.Forms.GroupBox()
        Me.DgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.cbDep = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFechaC = New System.Windows.Forms.Label()
        Me.dtpFechaC = New System.Windows.Forms.DateTimePicker()
        Me.cbAdmin = New System.Windows.Forms.CheckBox()
        Me.lblContra = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnGuardar.SuspendLayout()
        Me.gbEmpleado.SuspendLayout()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 44)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(791, 12)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(769, 12)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(179, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Registro de Empleado"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGuardar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuar, Me.btnEditar, Me.btnEliminar, Me.BtnReporte})
        Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(30, 770)
        Me.btnGuardar.TabIndex = 31
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(27, 24)
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuar
        '
        Me.btnGuar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuar.Image = CType(resources.GetObject("btnGuar.Image"), System.Drawing.Image)
        Me.btnGuar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuar.Name = "btnGuar"
        Me.btnGuar.Size = New System.Drawing.Size(27, 24)
        Me.btnGuar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(27, 24)
        Me.btnEditar.Text = "Editar"
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(27, 24)
        Me.btnEliminar.Text = "Eliminar"
        '
        'BtnReporte
        '
        Me.BtnReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnReporte.Image = CType(resources.GetObject("BtnReporte.Image"), System.Drawing.Image)
        Me.BtnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(27, 24)
        Me.BtnReporte.Text = "Imprimir Reporte"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 732)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(817, 38)
        Me.Panel2.TabIndex = 32
        '
        'lblDepartamrnto
        '
        Me.lblDepartamrnto.AutoSize = True
        Me.lblDepartamrnto.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamrnto.Location = New System.Drawing.Point(60, 204)
        Me.lblDepartamrnto.Name = "lblDepartamrnto"
        Me.lblDepartamrnto.Size = New System.Drawing.Size(132, 23)
        Me.lblDepartamrnto.TabIndex = 57
        Me.lblDepartamrnto.Text = "Departamento:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(99, 86)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(88, 23)
        Me.lblNombre.TabIndex = 52
        Me.lblNombre.Text = "Nombres:"
        '
        'ckbActivo
        '
        Me.ckbActivo.AutoSize = True
        Me.ckbActivo.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbActivo.Location = New System.Drawing.Point(213, 383)
        Me.ckbActivo.Name = "ckbActivo"
        Me.ckbActivo.Size = New System.Drawing.Size(90, 23)
        Me.ckbActivo.TabIndex = 59
        Me.ckbActivo.Text = "ACTIVO"
        Me.ckbActivo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 23)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Cargo:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(213, 242)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(256, 22)
        Me.txtEmail.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 23)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Email:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(213, 281)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(256, 22)
        Me.txtTelefono.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(99, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 23)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Teléfeno:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(213, 322)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(256, 22)
        Me.txtDireccion.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(93, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 23)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Dirección:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(488, 396)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(92, 42)
        Me.btnBuscar.TabIndex = 72
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtDatos
        '
        Me.txtDatos.Location = New System.Drawing.Point(213, 418)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(234, 22)
        Me.txtDatos.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 20)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Escriba el Empleado:"
        '
        'gbEmpleado
        '
        Me.gbEmpleado.Controls.Add(Me.DgvEmpleado)
        Me.gbEmpleado.Location = New System.Drawing.Point(33, 453)
        Me.gbEmpleado.Name = "gbEmpleado"
        Me.gbEmpleado.Size = New System.Drawing.Size(774, 278)
        Me.gbEmpleado.TabIndex = 73
        Me.gbEmpleado.TabStop = False
        Me.gbEmpleado.Text = "Registro Guardado: 0"
        '
        'DgvEmpleado
        '
        Me.DgvEmpleado.AllowUserToAddRows = False
        Me.DgvEmpleado.AllowUserToDeleteRows = False
        Me.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvEmpleado.Location = New System.Drawing.Point(3, 18)
        Me.DgvEmpleado.Name = "DgvEmpleado"
        Me.DgvEmpleado.ReadOnly = True
        Me.DgvEmpleado.RowHeadersWidth = 51
        Me.DgvEmpleado.RowTemplate.Height = 24
        Me.DgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmpleado.Size = New System.Drawing.Size(768, 257)
        Me.DgvEmpleado.TabIndex = 0
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(213, 53)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(256, 22)
        Me.txtCedula.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(102, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 23)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Cédula:"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.Location = New System.Drawing.Point(108, 383)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(68, 23)
        Me.lblestado.TabIndex = 55
        Me.lblestado.Text = "Estado:"
        '
        'cbCargo
        '
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Location = New System.Drawing.Point(213, 163)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(256, 24)
        Me.cbCargo.TabIndex = 77
        '
        'cbDep
        '
        Me.cbDep.FormattingEnabled = True
        Me.cbDep.Location = New System.Drawing.Point(213, 203)
        Me.cbDep.Name = "cbDep"
        Me.cbDep.Size = New System.Drawing.Size(256, 24)
        Me.cbDep.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Apellidos"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(213, 88)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(256, 22)
        Me.txtNombre.TabIndex = 80
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(213, 125)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(256, 22)
        Me.txtApellido.TabIndex = 81
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(506, 441)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Buscar"
        '
        'lblFechaC
        '
        Me.lblFechaC.AutoSize = True
        Me.lblFechaC.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaC.Location = New System.Drawing.Point(42, 355)
        Me.lblFechaC.Name = "lblFechaC"
        Me.lblFechaC.Size = New System.Drawing.Size(165, 23)
        Me.lblFechaC.TabIndex = 83
        Me.lblFechaC.Text = "Fecha contratación:"
        '
        'dtpFechaC
        '
        Me.dtpFechaC.Location = New System.Drawing.Point(213, 357)
        Me.dtpFechaC.Name = "dtpFechaC"
        Me.dtpFechaC.Size = New System.Drawing.Size(256, 22)
        Me.dtpFechaC.TabIndex = 85
        '
        'cbAdmin
        '
        Me.cbAdmin.AutoSize = True
        Me.cbAdmin.Location = New System.Drawing.Point(580, 123)
        Me.cbAdmin.Name = "cbAdmin"
        Me.cbAdmin.Size = New System.Drawing.Size(117, 21)
        Me.cbAdmin.TabIndex = 86
        Me.cbAdmin.Text = "Administrador"
        Me.cbAdmin.UseVisualStyleBackColor = True
        '
        'lblContra
        '
        Me.lblContra.AutoSize = True
        Me.lblContra.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContra.Location = New System.Drawing.Point(505, 201)
        Me.lblContra.Name = "lblContra"
        Me.lblContra.Size = New System.Drawing.Size(104, 23)
        Me.lblContra.TabIndex = 87
        Me.lblContra.Text = "Contraseña:"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(615, 203)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(102, 22)
        Me.txtClave.TabIndex = 88
        '
        'FrmREmple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 770)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.lblContra)
        Me.Controls.Add(Me.cbAdmin)
        Me.Controls.Add(Me.dtpFechaC)
        Me.Controls.Add(Me.lblFechaC)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbDep)
        Me.Controls.Add(Me.cbCargo)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.gbEmpleado)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtDatos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ckbActivo)
        Me.Controls.Add(Me.lblDepartamrnto)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmREmple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmREmple"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnGuardar.ResumeLayout(False)
        Me.btnGuardar.PerformLayout()
        Me.gbEmpleado.ResumeLayout(False)
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As ToolStrip
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents btnGuar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDepartamrnto As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents ckbActivo As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtDatos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents gbEmpleado As GroupBox
    Friend WithEvents DgvEmpleado As DataGridView
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblestado As Label
    Friend WithEvents cbCargo As ComboBox
    Friend WithEvents cbDep As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnReporte As ToolStripButton
    Friend WithEvents lblFechaC As Label
    Friend WithEvents dtpFechaC As DateTimePicker
    Friend WithEvents cbAdmin As CheckBox
    Friend WithEvents lblContra As Label
    Friend WithEvents txtClave As TextBox
End Class
