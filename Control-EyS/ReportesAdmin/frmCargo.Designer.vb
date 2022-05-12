<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargo
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
        Me.DgvCargo = New System.Windows.Forms.DataGridView()
        CType(Me.DgvCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCargo
        '
        Me.DgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCargo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCargo.Location = New System.Drawing.Point(0, 0)
        Me.DgvCargo.Name = "DgvCargo"
        Me.DgvCargo.RowHeadersWidth = 51
        Me.DgvCargo.RowTemplate.Height = 24
        Me.DgvCargo.Size = New System.Drawing.Size(800, 450)
        Me.DgvCargo.TabIndex = 0
        '
        'frmCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 360)
        Me.Controls.Add(Me.DgvCargo)
        Me.Name = "frmCargo"
        Me.Text = "frmCargo"
        CType(Me.DgvCargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvCargo As DataGridView
End Class
