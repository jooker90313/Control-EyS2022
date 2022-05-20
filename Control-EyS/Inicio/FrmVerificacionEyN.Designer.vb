<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVerificacionEyS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerificacionEyS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbRegistroMostrado = New System.Windows.Forms.GroupBox()
        Me.DgvVerificacionEmpleado = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.gbRegistroMostrado.SuspendLayout()
        CType(Me.DgvVerificacionEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1051, 45)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1005, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(953, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Verificación de Entrada y Salida"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnCerrarSesion)
        Me.Panel2.Location = New System.Drawing.Point(-1, 498)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1051, 45)
        Me.Panel2.TabIndex = 1
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.Silver
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.Location = New System.Drawing.Point(857, 3)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(176, 36)
        Me.btnCerrarSesion.TabIndex = 0
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "¡Bienvenido Empleado!"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Ebrima", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(65, 72)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(0, 28)
        Me.lblHora.TabIndex = 4
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Ebrima", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(720, 72)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(0, 28)
        Me.LblFecha.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'gbRegistroMostrado
        '
        Me.gbRegistroMostrado.Controls.Add(Me.DgvVerificacionEmpleado)
        Me.gbRegistroMostrado.Location = New System.Drawing.Point(12, 103)
        Me.gbRegistroMostrado.Name = "gbRegistroMostrado"
        Me.gbRegistroMostrado.Size = New System.Drawing.Size(1020, 381)
        Me.gbRegistroMostrado.TabIndex = 6
        Me.gbRegistroMostrado.TabStop = False
        Me.gbRegistroMostrado.Text = "Registro Mostrados:"
        '
        'DgvVerificacionEmpleado
        '
        Me.DgvVerificacionEmpleado.AllowUserToAddRows = False
        Me.DgvVerificacionEmpleado.AllowUserToDeleteRows = False
        Me.DgvVerificacionEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvVerificacionEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVerificacionEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvVerificacionEmpleado.Location = New System.Drawing.Point(3, 18)
        Me.DgvVerificacionEmpleado.Name = "DgvVerificacionEmpleado"
        Me.DgvVerificacionEmpleado.ReadOnly = True
        Me.DgvVerificacionEmpleado.RowHeadersWidth = 51
        Me.DgvVerificacionEmpleado.RowTemplate.Height = 24
        Me.DgvVerificacionEmpleado.Size = New System.Drawing.Size(1014, 360)
        Me.DgvVerificacionEmpleado.TabIndex = 0
        '
        'FrmVerificacionEyS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 543)
        Me.Controls.Add(Me.gbRegistroMostrado)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVerificacionEyS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.gbRegistroMostrado.ResumeLayout(False)
        CType(Me.DgvVerificacionEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents gbRegistroMostrado As GroupBox
    Friend WithEvents DgvVerificacionEmpleado As DataGridView
End Class
