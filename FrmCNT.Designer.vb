<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCNT
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
        Me.CmdDespliegue = New System.Windows.Forms.Button()
        Me.IblDespliegue = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmdDespliegue
        '
        Me.CmdDespliegue.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDespliegue.Location = New System.Drawing.Point(41, 46)
        Me.CmdDespliegue.Name = "CmdDespliegue"
        Me.CmdDespliegue.Size = New System.Drawing.Size(344, 54)
        Me.CmdDespliegue.TabIndex = 0
        Me.CmdDespliegue.Text = "Despliega Números"
        Me.CmdDespliegue.UseVisualStyleBackColor = True
        '
        'IblDespliegue
        '
        Me.IblDespliegue.AutoSize = True
        Me.IblDespliegue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IblDespliegue.ForeColor = System.Drawing.Color.Red
        Me.IblDespliegue.Location = New System.Drawing.Point(322, 150)
        Me.IblDespliegue.Name = "IblDespliegue"
        Me.IblDespliegue.Size = New System.Drawing.Size(0, 24)
        Me.IblDespliegue.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(391, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 54)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmCNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(704, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IblDespliegue)
        Me.Controls.Add(Me.CmdDespliegue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmCNT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "EJEMPLOS DE FOR/NEXT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdDespliegue As Button
    Friend WithEvents IblDespliegue As Label
    Friend WithEvents Button1 As Button
End Class
