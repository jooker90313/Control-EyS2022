<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRDepartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRDepartamento))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.ckbActivo = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.gbDepartamento = New System.Windows.Forms.GroupBox()
        Me.DgvDepartamento = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDatos = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnReporte = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnGuardar.SuspendLayout()
        Me.gbDepartamento.SuspendLayout()
        CType(Me.DgvDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 42)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(591, 11)
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
        Me.PictureBox4.Location = New System.Drawing.Point(554, 11)
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
        Me.Label2.Location = New System.Drawing.Point(150, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Registro de Departamento"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 419)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(619, 43)
        Me.Panel2.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(226, 77)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(256, 22)
        Me.txtNombre.TabIndex = 18
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(133, 77)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(81, 23)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Nombre:"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Font = New System.Drawing.Font("Ebrima", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.Location = New System.Drawing.Point(143, 112)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(68, 23)
        Me.lblestado.TabIndex = 28
        Me.lblestado.Text = "Estado:"
        '
        'ckbActivo
        '
        Me.ckbActivo.AutoSize = True
        Me.ckbActivo.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbActivo.Location = New System.Drawing.Point(226, 109)
        Me.ckbActivo.Name = "ckbActivo"
        Me.ckbActivo.Size = New System.Drawing.Size(90, 23)
        Me.ckbActivo.TabIndex = 29
        Me.ckbActivo.Text = "ACTIVO"
        Me.ckbActivo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGuardar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuar, Me.btnEditar, Me.btnEliminar, Me.BtnReporte})
        Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 462)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "Guardar"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(37, 24)
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuar
        '
        Me.btnGuar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuar.Image = CType(resources.GetObject("btnGuar.Image"), System.Drawing.Image)
        Me.btnGuar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuar.Name = "btnGuar"
        Me.btnGuar.Size = New System.Drawing.Size(37, 24)
        Me.btnGuar.Text = "Guardar"
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(37, 24)
        Me.btnEditar.Text = "Editar"
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(37, 24)
        Me.btnEliminar.Text = "Eliminar"
        '
        'gbDepartamento
        '
        Me.gbDepartamento.Controls.Add(Me.DgvDepartamento)
        Me.gbDepartamento.Location = New System.Drawing.Point(41, 245)
        Me.gbDepartamento.Name = "gbDepartamento"
        Me.gbDepartamento.Size = New System.Drawing.Size(566, 169)
        Me.gbDepartamento.TabIndex = 31
        Me.gbDepartamento.TabStop = False
        Me.gbDepartamento.Text = "Registros Guardados: 0"
        '
        'DgvDepartamento
        '
        Me.DgvDepartamento.AllowUserToAddRows = False
        Me.DgvDepartamento.AllowUserToDeleteRows = False
        Me.DgvDepartamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDepartamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvDepartamento.Location = New System.Drawing.Point(3, 18)
        Me.DgvDepartamento.Name = "DgvDepartamento"
        Me.DgvDepartamento.ReadOnly = True
        Me.DgvDepartamento.RowHeadersWidth = 51
        Me.DgvDepartamento.RowTemplate.Height = 24
        Me.DgvDepartamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDepartamento.Size = New System.Drawing.Size(560, 148)
        Me.DgvDepartamento.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Escriba el Departamento:"
        '
        'txtDatos
        '
        Me.txtDatos.Location = New System.Drawing.Point(236, 209)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(234, 22)
        Me.txtDatos.TabIndex = 33
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(498, 183)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(86, 39)
        Me.btnBuscar.TabIndex = 34
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(515, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Buscar"
        '
        'BtnReporte
        '
        Me.BtnReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnReporte.Image = CType(resources.GetObject("BtnReporte.Image"), System.Drawing.Image)
        Me.BtnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(37, 24)
        Me.BtnReporte.Text = "Imprimir Reporte"
        '
        'FrmRDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 462)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbDepartamento)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.ckbActivo)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmRDepartamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRDepartamento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnGuardar.ResumeLayout(False)
        Me.btnGuardar.PerformLayout()
        Me.gbDepartamento.ResumeLayout(False)
        CType(Me.DgvDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblestado As Label
    Friend WithEvents ckbActivo As CheckBox
    Friend WithEvents btnGuardar As ToolStrip
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents btnGuar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents gbDepartamento As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDatos As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DgvDepartamento As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnReporte As ToolStripButton
End Class
