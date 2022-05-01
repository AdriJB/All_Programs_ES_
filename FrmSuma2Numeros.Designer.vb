<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSuma2Numeros
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
        Me.IblNum1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNum1 = New System.Windows.Forms.TextBox()
        Me.TxtNum2 = New System.Windows.Forms.TextBox()
        Me.TxtSuma = New System.Windows.Forms.TextBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IblNum1
        '
        Me.IblNum1.AutoSize = True
        Me.IblNum1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IblNum1.Location = New System.Drawing.Point(173, 169)
        Me.IblNum1.Name = "IblNum1"
        Me.IblNum1.Size = New System.Drawing.Size(164, 40)
        Me.IblNum1.TabIndex = 0
        Me.IblNum1.Text = "Número 2:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Suma:"
        '
        'TxtNum1
        '
        Me.TxtNum1.Location = New System.Drawing.Point(343, 131)
        Me.TxtNum1.Name = "TxtNum1"
        Me.TxtNum1.Size = New System.Drawing.Size(175, 20)
        Me.TxtNum1.TabIndex = 3
        '
        'TxtNum2
        '
        Me.TxtNum2.Location = New System.Drawing.Point(343, 187)
        Me.TxtNum2.Name = "TxtNum2"
        Me.TxtNum2.Size = New System.Drawing.Size(175, 20)
        Me.TxtNum2.TabIndex = 4
        '
        'TxtSuma
        '
        Me.TxtSuma.Enabled = False
        Me.TxtSuma.Location = New System.Drawing.Point(343, 239)
        Me.TxtSuma.Name = "TxtSuma"
        Me.TxtSuma.Size = New System.Drawing.Size(175, 20)
        Me.TxtSuma.TabIndex = 5
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(177, 289)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(160, 39)
        Me.BtnCalcular.TabIndex = 6
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(343, 289)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(175, 39)
        Me.BtnLimpiar.TabIndex = 7
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(177, 334)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(341, 37)
        Me.BtnSalir.TabIndex = 8
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmSuma2Numeros
        '
        Me.AcceptButton = Me.BtnCalcular
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtSuma)
        Me.Controls.Add(Me.TxtNum2)
        Me.Controls.Add(Me.TxtNum1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IblNum1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSuma2Numeros"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "SUMA DE 2 NÚMEROS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IblNum1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNum1 As TextBox
    Friend WithEvents TxtNum2 As TextBox
    Friend WithEvents TxtSuma As TextBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
End Class
