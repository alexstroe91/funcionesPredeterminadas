<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrincipal
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
        Me.mnuCadena = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNumeros = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFechas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadena, Me.mnuNumeros, Me.mnuFechas})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(312, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuCadena
        '
        Me.mnuCadena.Name = "mnuCadena"
        Me.mnuCadena.Size = New System.Drawing.Size(72, 20)
        Me.mnuCadena.Text = "&CADENAS"
        '
        'mnuNumeros
        '
        Me.mnuNumeros.Name = "mnuNumeros"
        Me.mnuNumeros.Size = New System.Drawing.Size(75, 20)
        Me.mnuNumeros.Text = "NUMEROS"
        '
        'mnuFechas
        '
        Me.mnuFechas.Name = "mnuFechas"
        Me.mnuFechas.Size = New System.Drawing.Size(62, 20)
        Me.mnuFechas.Text = "FECHAS"
        '
        'formPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 265)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formPrincipal"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuCadena As ToolStripMenuItem
    Friend WithEvents mnuNumeros As ToolStripMenuItem
    Friend WithEvents mnuFechas As ToolStripMenuItem
End Class
