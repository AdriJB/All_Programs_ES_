<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SumaDe2NúmerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculoDeEdadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CicloDoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProyectosToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProyectosToolStripMenuItem
        '
        Me.ProyectosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumaDe2NúmerosToolStripMenuItem, Me.CalculoDeEdadToolStripMenuItem, Me.SelectCaseToolStripMenuItem, Me.CicloDoToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarAplicaciónToolStripMenuItem})
        Me.ProyectosToolStripMenuItem.Name = "ProyectosToolStripMenuItem"
        Me.ProyectosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ProyectosToolStripMenuItem.Text = "Proyectos"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'SumaDe2NúmerosToolStripMenuItem
        '
        Me.SumaDe2NúmerosToolStripMenuItem.Image = Global._2L1_Programas.My.Resources.Resources.Image_Documento
        Me.SumaDe2NúmerosToolStripMenuItem.Name = "SumaDe2NúmerosToolStripMenuItem"
        Me.SumaDe2NúmerosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SumaDe2NúmerosToolStripMenuItem.Text = "Suma de 2 números"
        '
        'CalculoDeEdadToolStripMenuItem
        '
        Me.CalculoDeEdadToolStripMenuItem.Image = Global._2L1_Programas.My.Resources.Resources.Image_Documento
        Me.CalculoDeEdadToolStripMenuItem.Name = "CalculoDeEdadToolStripMenuItem"
        Me.CalculoDeEdadToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalculoDeEdadToolStripMenuItem.Text = "Calculo de edad"
        '
        'SelectCaseToolStripMenuItem
        '
        Me.SelectCaseToolStripMenuItem.Image = Global._2L1_Programas.My.Resources.Resources.Image_Documento
        Me.SelectCaseToolStripMenuItem.Name = "SelectCaseToolStripMenuItem"
        Me.SelectCaseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectCaseToolStripMenuItem.Text = "Select Case"
        '
        'CicloDoToolStripMenuItem
        '
        Me.CicloDoToolStripMenuItem.Image = Global._2L1_Programas.My.Resources.Resources.Image_Documento
        Me.CicloDoToolStripMenuItem.Name = "CicloDoToolStripMenuItem"
        Me.CicloDoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CicloDoToolStripMenuItem.Text = "Ciclos For/Next"
        '
        'CerrarAplicaciónToolStripMenuItem
        '
        Me.CerrarAplicaciónToolStripMenuItem.Image = Global._2L1_Programas.My.Resources.Resources.SalirIcon
        Me.CerrarAplicaciónToolStripMenuItem.Name = "CerrarAplicaciónToolStripMenuItem"
        Me.CerrarAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarAplicaciónToolStripMenuItem.Text = "Cerrar Aplicación"
        '
        'Frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Frmmenu"
        Me.ShowIcon = False
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProyectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumaDe2NúmerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculoDeEdadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectCaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CicloDoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CerrarAplicaciónToolStripMenuItem As ToolStripMenuItem
End Class
