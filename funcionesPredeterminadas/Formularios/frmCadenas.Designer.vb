<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadenas
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
        Me.btnMuestra = New System.Windows.Forms.Button()
        Me.btnLimpia = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFrase = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSoloPrimeraMayus = New System.Windows.Forms.Label()
        Me.lblMinusculas = New System.Windows.Forms.Label()
        Me.lblMayusculas = New System.Windows.Forms.Label()
        Me.lblPosPrimeraA = New System.Windows.Forms.Label()
        Me.lblSegundoAlSextoCaracter = New System.Windows.Forms.Label()
        Me.lblUltimoCaracter = New System.Windows.Forms.Label()
        Me.lblPrimerCaracter = New System.Windows.Forms.Label()
        Me.lblLongitud = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMuestra
        '
        Me.btnMuestra.Location = New System.Drawing.Point(106, 12)
        Me.btnMuestra.Name = "btnMuestra"
        Me.btnMuestra.Size = New System.Drawing.Size(75, 23)
        Me.btnMuestra.TabIndex = 0
        Me.btnMuestra.Text = "MUESTRA"
        Me.btnMuestra.UseVisualStyleBackColor = True
        '
        'btnLimpia
        '
        Me.btnLimpia.Location = New System.Drawing.Point(200, 12)
        Me.btnLimpia.Name = "btnLimpia"
        Me.btnLimpia.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpia.TabIndex = 1
        Me.btnLimpia.Text = "LIMPIAR"
        Me.btnLimpia.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(291, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese una frase"
        '
        'txtFrase
        '
        Me.txtFrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrase.Location = New System.Drawing.Point(146, 53)
        Me.txtFrase.Name = "txtFrase"
        Me.txtFrase.Size = New System.Drawing.Size(307, 24)
        Me.txtFrase.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Controls.Add(Me.lblSoloPrimeraMayus)
        Me.GroupBox1.Controls.Add(Me.lblMinusculas)
        Me.GroupBox1.Controls.Add(Me.lblMayusculas)
        Me.GroupBox1.Controls.Add(Me.lblPosPrimeraA)
        Me.GroupBox1.Controls.Add(Me.lblSegundoAlSextoCaracter)
        Me.GroupBox1.Controls.Add(Me.lblUltimoCaracter)
        Me.GroupBox1.Controls.Add(Me.lblPrimerCaracter)
        Me.GroupBox1.Controls.Add(Me.lblLongitud)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 340)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lblSoloPrimeraMayus
        '
        Me.lblSoloPrimeraMayus.AutoSize = True
        Me.lblSoloPrimeraMayus.ForeColor = System.Drawing.SystemColors.Window
        Me.lblSoloPrimeraMayus.Location = New System.Drawing.Point(175, 308)
        Me.lblSoloPrimeraMayus.Name = "lblSoloPrimeraMayus"
        Me.lblSoloPrimeraMayus.Size = New System.Drawing.Size(0, 13)
        Me.lblSoloPrimeraMayus.TabIndex = 15
        '
        'lblMinusculas
        '
        Me.lblMinusculas.AutoSize = True
        Me.lblMinusculas.ForeColor = System.Drawing.SystemColors.Window
        Me.lblMinusculas.Location = New System.Drawing.Point(175, 262)
        Me.lblMinusculas.Name = "lblMinusculas"
        Me.lblMinusculas.Size = New System.Drawing.Size(0, 13)
        Me.lblMinusculas.TabIndex = 14
        '
        'lblMayusculas
        '
        Me.lblMayusculas.AutoSize = True
        Me.lblMayusculas.ForeColor = System.Drawing.SystemColors.Window
        Me.lblMayusculas.Location = New System.Drawing.Point(175, 222)
        Me.lblMayusculas.Name = "lblMayusculas"
        Me.lblMayusculas.Size = New System.Drawing.Size(0, 13)
        Me.lblMayusculas.TabIndex = 13
        '
        'lblPosPrimeraA
        '
        Me.lblPosPrimeraA.AutoSize = True
        Me.lblPosPrimeraA.ForeColor = System.Drawing.SystemColors.Window
        Me.lblPosPrimeraA.Location = New System.Drawing.Point(175, 182)
        Me.lblPosPrimeraA.Name = "lblPosPrimeraA"
        Me.lblPosPrimeraA.Size = New System.Drawing.Size(0, 13)
        Me.lblPosPrimeraA.TabIndex = 12
        '
        'lblSegundoAlSextoCaracter
        '
        Me.lblSegundoAlSextoCaracter.AutoSize = True
        Me.lblSegundoAlSextoCaracter.ForeColor = System.Drawing.SystemColors.Window
        Me.lblSegundoAlSextoCaracter.Location = New System.Drawing.Point(175, 141)
        Me.lblSegundoAlSextoCaracter.Name = "lblSegundoAlSextoCaracter"
        Me.lblSegundoAlSextoCaracter.Size = New System.Drawing.Size(0, 13)
        Me.lblSegundoAlSextoCaracter.TabIndex = 11
        '
        'lblUltimoCaracter
        '
        Me.lblUltimoCaracter.AutoSize = True
        Me.lblUltimoCaracter.ForeColor = System.Drawing.SystemColors.Window
        Me.lblUltimoCaracter.Location = New System.Drawing.Point(175, 98)
        Me.lblUltimoCaracter.Name = "lblUltimoCaracter"
        Me.lblUltimoCaracter.Size = New System.Drawing.Size(0, 13)
        Me.lblUltimoCaracter.TabIndex = 10
        '
        'lblPrimerCaracter
        '
        Me.lblPrimerCaracter.AutoSize = True
        Me.lblPrimerCaracter.ForeColor = System.Drawing.SystemColors.Window
        Me.lblPrimerCaracter.Location = New System.Drawing.Point(175, 58)
        Me.lblPrimerCaracter.Name = "lblPrimerCaracter"
        Me.lblPrimerCaracter.Size = New System.Drawing.Size(0, 13)
        Me.lblPrimerCaracter.TabIndex = 9
        '
        'lblLongitud
        '
        Me.lblLongitud.AutoSize = True
        Me.lblLongitud.ForeColor = System.Drawing.SystemColors.Window
        Me.lblLongitud.Location = New System.Drawing.Point(175, 16)
        Me.lblLongitud.Name = "lblLongitud"
        Me.lblLongitud.Size = New System.Drawing.Size(0, 13)
        Me.lblLongitud.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(6, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Solo la primera en Mayusculas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(6, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Minusculas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(6, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Mayusculas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(6, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Posicion de la 1ª letra A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(6, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Del 2º al 6º caracter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ultimo caracter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Primer caracter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Logitud de la frase"
        '
        'frmCadenas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFrase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpia)
        Me.Controls.Add(Me.btnMuestra)
        Me.Name = "frmCadenas"
        Me.Text = "frmCadenas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMuestra As Button
    Friend WithEvents btnLimpia As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFrase As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSoloPrimeraMayus As Label
    Friend WithEvents lblMinusculas As Label
    Friend WithEvents lblMayusculas As Label
    Friend WithEvents lblPosPrimeraA As Label
    Friend WithEvents lblSegundoAlSextoCaracter As Label
    Friend WithEvents lblUltimoCaracter As Label
    Friend WithEvents lblPrimerCaracter As Label
    Friend WithEvents lblLongitud As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
