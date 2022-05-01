<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSectCase
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
        Me.IblOpcion = New System.Windows.Forms.Label()
        Me.Iblmensaje = New System.Windows.Forms.Label()
        Me.Cmdmensaje = New System.Windows.Forms.Button()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.Txtopcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'IblOpcion
        '
        Me.IblOpcion.AutoSize = True
        Me.IblOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IblOpcion.Location = New System.Drawing.Point(12, 66)
        Me.IblOpcion.Name = "IblOpcion"
        Me.IblOpcion.Size = New System.Drawing.Size(443, 33)
        Me.IblOpcion.TabIndex = 0
        Me.IblOpcion.Text = "Opción a seleccionar (1 al 20):"
        '
        'Iblmensaje
        '
        Me.Iblmensaje.AutoSize = True
        Me.Iblmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iblmensaje.ForeColor = System.Drawing.Color.Red
        Me.Iblmensaje.Location = New System.Drawing.Point(125, 184)
        Me.Iblmensaje.Name = "Iblmensaje"
        Me.Iblmensaje.Size = New System.Drawing.Size(0, 33)
        Me.Iblmensaje.TabIndex = 1
        '
        'Cmdmensaje
        '
        Me.Cmdmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmdmensaje.Location = New System.Drawing.Point(45, 312)
        Me.Cmdmensaje.Name = "Cmdmensaje"
        Me.Cmdmensaje.Size = New System.Drawing.Size(252, 43)
        Me.Cmdmensaje.TabIndex = 2
        Me.Cmdmensaje.Text = "Escribe el mensaje"
        Me.Cmdmensaje.UseVisualStyleBackColor = True
        '
        'CmdSalir
        '
        Me.CmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalir.Location = New System.Drawing.Point(353, 312)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(234, 43)
        Me.CmdSalir.TabIndex = 3
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'Txtopcion
        '
        Me.Txtopcion.Location = New System.Drawing.Point(457, 75)
        Me.Txtopcion.Name = "Txtopcion"
        Me.Txtopcion.Size = New System.Drawing.Size(184, 20)
        Me.Txtopcion.TabIndex = 4
        '
        'FrmSectCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 395)
        Me.Controls.Add(Me.Txtopcion)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.Cmdmensaje)
        Me.Controls.Add(Me.Iblmensaje)
        Me.Controls.Add(Me.IblOpcion)
        Me.Name = "FrmSectCase"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IblOpcion As Label
    Friend WithEvents Iblmensaje As Label
    Friend WithEvents Cmdmensaje As Button
    Friend WithEvents CmdSalir As Button
    Friend WithEvents Txtopcion As TextBox
End Class
