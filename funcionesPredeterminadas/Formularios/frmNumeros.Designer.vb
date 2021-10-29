<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumeros
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblValorHexadecimal = New System.Windows.Forms.Label()
        Me.lblValorOctal = New System.Windows.Forms.Label()
        Me.lblSignoDelNumero = New System.Windows.Forms.Label()
        Me.lblRaiz = New System.Windows.Forms.Label()
        Me.lblValorAbsoluto = New System.Windows.Forms.Label()
        Me.lblParteDecimal = New System.Windows.Forms.Label()
        Me.lblParteEntera = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.numNumeros = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblValorHexadecimal)
        Me.GroupBox1.Controls.Add(Me.lblValorOctal)
        Me.GroupBox1.Controls.Add(Me.lblSignoDelNumero)
        Me.GroupBox1.Controls.Add(Me.lblRaiz)
        Me.GroupBox1.Controls.Add(Me.lblValorAbsoluto)
        Me.GroupBox1.Controls.Add(Me.lblParteDecimal)
        Me.GroupBox1.Controls.Add(Me.lblParteEntera)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 296)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'lblValorHexadecimal
        '
        Me.lblValorHexadecimal.AutoSize = True
        Me.lblValorHexadecimal.ForeColor = System.Drawing.SystemColors.Window
        Me.lblValorHexadecimal.Location = New System.Drawing.Point(175, 262)
        Me.lblValorHexadecimal.Name = "lblValorHexadecimal"
        Me.lblValorHexadecimal.Size = New System.Drawing.Size(0, 13)
        Me.lblValorHexadecimal.TabIndex = 14
        '
        'lblValorOctal
        '
        Me.lblValorOctal.AutoSize = True
        Me.lblValorOctal.ForeColor = System.Drawing.SystemColors.Window
        Me.lblValorOctal.Location = New System.Drawing.Point(175, 222)
        Me.lblValorOctal.Name = "lblValorOctal"
        Me.lblValorOctal.Size = New System.Drawing.Size(0, 13)
        Me.lblValorOctal.TabIndex = 13
        '
        'lblSignoDelNumero
        '
        Me.lblSignoDelNumero.AutoSize = True
        Me.lblSignoDelNumero.ForeColor = System.Drawing.SystemColors.Window
        Me.lblSignoDelNumero.Location = New System.Drawing.Point(175, 182)
        Me.lblSignoDelNumero.Name = "lblSignoDelNumero"
        Me.lblSignoDelNumero.Size = New System.Drawing.Size(0, 13)
        Me.lblSignoDelNumero.TabIndex = 12
        '
        'lblRaiz
        '
        Me.lblRaiz.AutoSize = True
        Me.lblRaiz.ForeColor = System.Drawing.SystemColors.Window
        Me.lblRaiz.Location = New System.Drawing.Point(175, 141)
        Me.lblRaiz.Name = "lblRaiz"
        Me.lblRaiz.Size = New System.Drawing.Size(0, 13)
        Me.lblRaiz.TabIndex = 11
        '
        'lblValorAbsoluto
        '
        Me.lblValorAbsoluto.AutoSize = True
        Me.lblValorAbsoluto.ForeColor = System.Drawing.SystemColors.Window
        Me.lblValorAbsoluto.Location = New System.Drawing.Point(175, 98)
        Me.lblValorAbsoluto.Name = "lblValorAbsoluto"
        Me.lblValorAbsoluto.Size = New System.Drawing.Size(0, 13)
        Me.lblValorAbsoluto.TabIndex = 10
        '
        'lblParteDecimal
        '
        Me.lblParteDecimal.AutoSize = True
        Me.lblParteDecimal.ForeColor = System.Drawing.SystemColors.Window
        Me.lblParteDecimal.Location = New System.Drawing.Point(175, 58)
        Me.lblParteDecimal.Name = "lblParteDecimal"
        Me.lblParteDecimal.Size = New System.Drawing.Size(0, 13)
        Me.lblParteDecimal.TabIndex = 9
        '
        'lblParteEntera
        '
        Me.lblParteEntera.AutoSize = True
        Me.lblParteEntera.ForeColor = System.Drawing.SystemColors.Window
        Me.lblParteEntera.Location = New System.Drawing.Point(175, 16)
        Me.lblParteEntera.Name = "lblParteEntera"
        Me.lblParteEntera.Size = New System.Drawing.Size(0, 13)
        Me.lblParteEntera.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(6, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Valor Hexadecimal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(6, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Valor Octal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(6, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Signo del numero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(6, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Raiz Cuadrada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Valor Absoluto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Parte Decimal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Parte entera"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese un número"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(293, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(202, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(108, 12)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'numNumeros
        '
        Me.numNumeros.DecimalPlaces = 2
        Me.numNumeros.Location = New System.Drawing.Point(157, 58)
        Me.numNumeros.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numNumeros.Minimum = New Decimal(New Integer() {9999, 0, 0, -2147483648})
        Me.numNumeros.Name = "numNumeros"
        Me.numNumeros.Size = New System.Drawing.Size(120, 20)
        Me.numNumeros.TabIndex = 12
        '
        'frmNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 406)
        Me.Controls.Add(Me.numNumeros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "frmNumeros"
        Me.Text = "frmNumeros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblValorHexadecimal As Label
    Friend WithEvents lblValorOctal As Label
    Friend WithEvents lblSignoDelNumero As Label
    Friend WithEvents lblRaiz As Label
    Friend WithEvents lblValorAbsoluto As Label
    Friend WithEvents lblParteDecimal As Label
    Friend WithEvents lblParteEntera As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents numNumeros As NumericUpDown
End Class
