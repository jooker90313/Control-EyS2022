<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistrarEyN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarEyN))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnVerEyS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.btnSalida = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSalida = New System.Windows.Forms.Label()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTrabajadas = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Marcar Entrada o Salida"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(606, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(565, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnVerEyS)
        Me.Panel2.Location = New System.Drawing.Point(0, 357)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(647, 42)
        Me.Panel2.TabIndex = 1
        '
        'BtnVerEyS
        '
        Me.BtnVerEyS.Location = New System.Drawing.Point(510, 6)
        Me.BtnVerEyS.Name = "BtnVerEyS"
        Me.BtnVerEyS.Size = New System.Drawing.Size(120, 24)
        Me.BtnVerEyS.TabIndex = 0
        Me.BtnVerEyS.Text = "Mostrar marca "
        Me.BtnVerEyS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¡Bienvenido Empleado!"
        '
        'btnEntrada
        '
        Me.btnEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnEntrada.FlatAppearance.BorderSize = 0
        Me.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrada.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrada.ForeColor = System.Drawing.Color.White
        Me.btnEntrada.Location = New System.Drawing.Point(117, 208)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(126, 68)
        Me.btnEntrada.TabIndex = 3
        Me.btnEntrada.Text = "Marcar Entrada"
        Me.btnEntrada.UseVisualStyleBackColor = False
        '
        'btnSalida
        '
        Me.btnSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSalida.FlatAppearance.BorderSize = 0
        Me.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalida.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalida.ForeColor = System.Drawing.Color.White
        Me.btnSalida.Location = New System.Drawing.Point(395, 208)
        Me.btnSalida.Name = "btnSalida"
        Me.btnSalida.Size = New System.Drawing.Size(126, 68)
        Me.btnSalida.TabIndex = 4
        Me.btnSalida.Text = "Marcar Salida"
        Me.btnSalida.UseVisualStyleBackColor = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Ebrima", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Location = New System.Drawing.Point(170, 99)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 28)
        Me.lblFecha.TabIndex = 5
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Ebrima", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Black
        Me.lblHora.Location = New System.Drawing.Point(279, 127)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(0, 28)
        Me.lblHora.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblSalida
        '
        Me.lblSalida.AutoSize = True
        Me.lblSalida.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalida.ForeColor = System.Drawing.Color.Red
        Me.lblSalida.Location = New System.Drawing.Point(389, 294)
        Me.lblSalida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(149, 32)
        Me.lblSalida.TabIndex = 8
        Me.lblSalida.Text = "Hora Final"
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicio.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblInicio.Location = New System.Drawing.Point(100, 294)
        Me.lblInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(157, 32)
        Me.lblInicio.TabIndex = 7
        Me.lblInicio.Text = "Hora Inicio"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'lblTrabajadas
        '
        Me.lblTrabajadas.AutoSize = True
        Me.lblTrabajadas.BackColor = System.Drawing.SystemColors.Control
        Me.lblTrabajadas.Cursor = System.Windows.Forms.Cursors.No
        Me.lblTrabajadas.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrabajadas.Location = New System.Drawing.Point(490, 127)
        Me.lblTrabajadas.Name = "lblTrabajadas"
        Me.lblTrabajadas.Size = New System.Drawing.Size(0, 19)
        Me.lblTrabajadas.TabIndex = 9
        '
        'FrmRegistrarEyN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 399)
        Me.Controls.Add(Me.lblTrabajadas)
        Me.Controls.Add(Me.lblSalida)
        Me.Controls.Add(Me.lblInicio)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.btnSalida)
        Me.Controls.Add(Me.btnEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistrarEyN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistrarEyN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEntrada As Button
    Friend WithEvents btnSalida As Button
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSalida As Label
    Friend WithEvents lblInicio As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblTrabajadas As Label
    Friend WithEvents BtnVerEyS As Button
End Class
