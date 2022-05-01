<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmedad
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
        Me.Iblanio = New System.Windows.Forms.Label()
        Me.Iblmensaje = New System.Windows.Forms.Label()
        Me.IblRespuesta = New System.Windows.Forms.Label()
        Me.Txtanionac = New System.Windows.Forms.TextBox()
        Me.CmdVerificar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Iblanio
        '
        Me.Iblanio.AutoSize = True
        Me.Iblanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iblanio.Location = New System.Drawing.Point(12, 30)
        Me.Iblanio.Name = "Iblanio"
        Me.Iblanio.Size = New System.Drawing.Size(392, 33)
        Me.Iblanio.TabIndex = 0
        Me.Iblanio.Text = "Ingrese año de nacimiento:"
        '
        'Iblmensaje
        '
        Me.Iblmensaje.AutoSize = True
        Me.Iblmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iblmensaje.Location = New System.Drawing.Point(322, 144)
        Me.Iblmensaje.Name = "Iblmensaje"
        Me.Iblmensaje.Size = New System.Drawing.Size(0, 20)
        Me.Iblmensaje.TabIndex = 1
        Me.Iblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IblRespuesta
        '
        Me.IblRespuesta.AutoSize = True
        Me.IblRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IblRespuesta.Location = New System.Drawing.Point(323, 187)
        Me.IblRespuesta.Name = "IblRespuesta"
        Me.IblRespuesta.Size = New System.Drawing.Size(0, 20)
        Me.IblRespuesta.TabIndex = 2
        Me.IblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txtanionac
        '
        Me.Txtanionac.Location = New System.Drawing.Point(410, 39)
        Me.Txtanionac.Name = "Txtanionac"
        Me.Txtanionac.Size = New System.Drawing.Size(169, 20)
        Me.Txtanionac.TabIndex = 3
        '
        'CmdVerificar
        '
        Me.CmdVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdVerificar.Location = New System.Drawing.Point(108, 81)
        Me.CmdVerificar.Name = "CmdVerificar"
        Me.CmdVerificar.Size = New System.Drawing.Size(215, 30)
        Me.CmdVerificar.TabIndex = 4
        Me.CmdVerificar.Text = "Verificar"
        Me.CmdVerificar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(377, 81)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(202, 30)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Frmedad
        '
        Me.AcceptButton = Me.CmdVerificar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(689, 414)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.CmdVerificar)
        Me.Controls.Add(Me.Txtanionac)
        Me.Controls.Add(Me.IblRespuesta)
        Me.Controls.Add(Me.Iblmensaje)
        Me.Controls.Add(Me.Iblanio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frmedad"
        Me.Text = "CALCULO DE EDAD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Iblanio As Label
    Friend WithEvents Iblmensaje As Label
    Friend WithEvents IblRespuesta As Label
    Friend WithEvents Txtanionac As TextBox
    Friend WithEvents CmdVerificar As Button
    Friend WithEvents BtnSalir As Button
End Class
