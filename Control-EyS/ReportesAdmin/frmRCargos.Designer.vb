<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRCargos
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
        Me.gbSeleccion = New System.Windows.Forms.GroupBox()
        Me.gbRegistro = New System.Windows.Forms.GroupBox()
        Me.cmbCampo = New System.Windows.Forms.ComboBox()
        Me.txtMostrar = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.dgvCargo = New System.Windows.Forms.DataGridView()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.txtRango1 = New System.Windows.Forms.TextBox()
        Me.txtrango2 = New System.Windows.Forms.TextBox()
        Me.gbSeleccion.SuspendLayout()
        Me.gbRegistro.SuspendLayout()
        CType(Me.dgvCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSeleccion
        '
        Me.gbSeleccion.Controls.Add(Me.btnImprimir)
        Me.gbSeleccion.Controls.Add(Me.btnMostrar)
        Me.gbSeleccion.Controls.Add(Me.txtMostrar)
        Me.gbSeleccion.Controls.Add(Me.cmbCampo)
        Me.gbSeleccion.Location = New System.Drawing.Point(12, 8)
        Me.gbSeleccion.Name = "gbSeleccion"
        Me.gbSeleccion.Size = New System.Drawing.Size(988, 90)
        Me.gbSeleccion.TabIndex = 0
        Me.gbSeleccion.TabStop = False
        Me.gbSeleccion.Text = "Selecciones por que campo desea Buscar"
        '
        'gbRegistro
        '
        Me.gbRegistro.Controls.Add(Me.dgvCargo)
        Me.gbRegistro.Location = New System.Drawing.Point(12, 143)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(988, 519)
        Me.gbRegistro.TabIndex = 1
        Me.gbRegistro.TabStop = False
        Me.gbRegistro.Text = "Registro Encontrado:"
        '
        'cmbCampo
        '
        Me.cmbCampo.FormattingEnabled = True
        Me.cmbCampo.Items.AddRange(New Object() {"Cargo", "Descripcion"})
        Me.cmbCampo.Location = New System.Drawing.Point(17, 36)
        Me.cmbCampo.Name = "cmbCampo"
        Me.cmbCampo.Size = New System.Drawing.Size(249, 24)
        Me.cmbCampo.TabIndex = 0
        '
        'txtMostrar
        '
        Me.txtMostrar.Location = New System.Drawing.Point(297, 38)
        Me.txtMostrar.Name = "txtMostrar"
        Me.txtMostrar.Size = New System.Drawing.Size(533, 22)
        Me.txtMostrar.TabIndex = 1
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(855, 21)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(92, 29)
        Me.btnMostrar.TabIndex = 2
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'dgvCargo
        '
        Me.dgvCargo.AllowUserToAddRows = False
        Me.dgvCargo.AllowUserToDeleteRows = False
        Me.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCargo.Location = New System.Drawing.Point(3, 18)
        Me.dgvCargo.Name = "dgvCargo"
        Me.dgvCargo.ReadOnly = True
        Me.dgvCargo.RowHeadersWidth = 51
        Me.dgvCargo.RowTemplate.Height = 24
        Me.dgvCargo.Size = New System.Drawing.Size(982, 498)
        Me.dgvCargo.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(855, 56)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(92, 29)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Location = New System.Drawing.Point(29, 104)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(229, 22)
        Me.dtpFecha1.TabIndex = 2
        Me.dtpFecha1.Visible = False
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Location = New System.Drawing.Point(276, 104)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(229, 22)
        Me.dtpFecha2.TabIndex = 3
        Me.dtpFecha2.Visible = False
        '
        'txtRango1
        '
        Me.txtRango1.Location = New System.Drawing.Point(511, 104)
        Me.txtRango1.Name = "txtRango1"
        Me.txtRango1.Size = New System.Drawing.Size(176, 22)
        Me.txtRango1.TabIndex = 4
        Me.txtRango1.Visible = False
        '
        'txtrango2
        '
        Me.txtrango2.Location = New System.Drawing.Point(693, 104)
        Me.txtrango2.Name = "txtrango2"
        Me.txtrango2.Size = New System.Drawing.Size(168, 22)
        Me.txtrango2.TabIndex = 5
        Me.txtrango2.Visible = False
        '
        'frmRCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 661)
        Me.Controls.Add(Me.gbRegistro)
        Me.Controls.Add(Me.gbSeleccion)
        Me.Controls.Add(Me.txtrango2)
        Me.Controls.Add(Me.txtRango1)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Name = "frmRCargos"
        Me.Text = "Reporte Cargo"
        Me.gbSeleccion.ResumeLayout(False)
        Me.gbSeleccion.PerformLayout()
        Me.gbRegistro.ResumeLayout(False)
        CType(Me.dgvCargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbSeleccion As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents txtMostrar As TextBox
    Friend WithEvents cmbCampo As ComboBox
    Friend WithEvents gbRegistro As GroupBox
    Friend WithEvents dgvCargo As DataGridView
    Friend WithEvents dtpFecha1 As DateTimePicker
    Friend WithEvents dtpFecha2 As DateTimePicker
    Friend WithEvents txtRango1 As TextBox
    Friend WithEvents txtrango2 As TextBox
End Class
