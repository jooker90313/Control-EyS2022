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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
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
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(593, 44)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(551, 12)
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
        Me.PictureBox4.Location = New System.Drawing.Point(500, 12)
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
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(696, 12)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(663, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGuardar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuar, Me.btnEditar, Me.btnEliminar})
        Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(30, 746)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 708)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(593, 38)
        Me.Panel2.TabIndex = 32
        '
        'lblDepartamrnto
        '
        Me.lblDepartamrnto.AutoSize = True
        Me.lblDepartamrnto.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamrnto.Location = New System.Drawing.Point(60, 199)
        Me.lblDepartamrnto.Name = "lblDepartamrnto"
        Me.lblDepartamrnto.Size = New System.Drawing.Size(132, 23)
        Me.lblDepartamrnto.TabIndex = 57
        Me.lblDepartamrnto.Text = "Departamento:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(99, 81)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(88, 23)
        Me.lblNombre.TabIndex = 52
        Me.lblNombre.Text = "Nombres:"
        '
        'ckbActivo
        '
        Me.ckbActivo.AutoSize = True
        Me.ckbActivo.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbActivo.Location = New System.Drawing.Point(213, 355)
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
        Me.Label3.Location = New System.Drawing.Point(113, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 23)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Cargo:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(213, 237)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(256, 22)
        Me.txtEmail.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 23)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Email:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(213, 276)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(256, 22)
        Me.txtTelefono.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(99, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 23)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Teléfeno:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(213, 317)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(256, 22)
        Me.txtDireccion.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(93, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 23)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Dirección:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(477, 384)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(89, 35)
        Me.btnBuscar.TabIndex = 72
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtDatos
        '
        Me.txtDatos.Location = New System.Drawing.Point(213, 390)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(234, 22)
        Me.txtDatos.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 20)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Escriba el Empleado:"
        '
        'gbEmpleado
        '
        Me.gbEmpleado.Controls.Add(Me.DgvEmpleado)
        Me.gbEmpleado.Location = New System.Drawing.Point(33, 425)
        Me.gbEmpleado.Name = "gbEmpleado"
        Me.gbEmpleado.Size = New System.Drawing.Size(547, 278)
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
        Me.DgvEmpleado.Size = New System.Drawing.Size(541, 257)
        Me.DgvEmpleado.TabIndex = 0
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(213, 48)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(256, 22)
        Me.txtCedula.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(102, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 23)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Cédula:"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.Location = New System.Drawing.Point(108, 355)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(68, 23)
        Me.lblestado.TabIndex = 55
        Me.lblestado.Text = "Estado:"
        '
        'cbCargo
        '
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Location = New System.Drawing.Point(213, 158)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(256, 24)
        Me.cbCargo.TabIndex = 77
        '
        'cbDep
        '
        Me.cbDep.FormattingEnabled = True
        Me.cbDep.Location = New System.Drawing.Point(213, 198)
        Me.cbDep.Name = "cbDep"
        Me.cbDep.Size = New System.Drawing.Size(256, 24)
        Me.cbDep.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Apellidos"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(213, 83)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(256, 22)
        Me.txtNombre.TabIndex = 80
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(213, 120)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(256, 22)
        Me.txtApellido.TabIndex = 81
        '
        'FrmREmple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 746)
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
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
End Class
