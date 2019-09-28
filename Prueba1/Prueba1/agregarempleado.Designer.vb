<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarempleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.femaleRB = New System.Windows.Forms.RadioButton()
        Me.maleRB = New System.Windows.Forms.RadioButton()
        Me.trabajoCB = New System.Windows.Forms.ComboBox()
        Me.apellidoTB = New System.Windows.Forms.TextBox()
        Me.nombreTB = New System.Windows.Forms.TextBox()
        Me.codigoTB = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.salarioTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.telefonoTB = New System.Windows.Forms.TextBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(150, 266)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(160, 22)
        Me.NumericUpDown1.TabIndex = 39
        Me.NumericUpDown1.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(81, 218)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Genero:"
        '
        'femaleRB
        '
        Me.femaleRB.AutoSize = True
        Me.femaleRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femaleRB.Location = New System.Drawing.Point(282, 218)
        Me.femaleRB.Margin = New System.Windows.Forms.Padding(4)
        Me.femaleRB.Name = "femaleRB"
        Me.femaleRB.Size = New System.Drawing.Size(86, 20)
        Me.femaleRB.TabIndex = 36
        Me.femaleRB.TabStop = True
        Me.femaleRB.Text = "Femenino"
        Me.femaleRB.UseVisualStyleBackColor = True
        '
        'maleRB
        '
        Me.maleRB.AutoSize = True
        Me.maleRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maleRB.Location = New System.Drawing.Point(150, 218)
        Me.maleRB.Margin = New System.Windows.Forms.Padding(4)
        Me.maleRB.Name = "maleRB"
        Me.maleRB.Size = New System.Drawing.Size(87, 20)
        Me.maleRB.TabIndex = 35
        Me.maleRB.TabStop = True
        Me.maleRB.Text = "Masculino"
        Me.maleRB.UseVisualStyleBackColor = True
        '
        'trabajoCB
        '
        Me.trabajoCB.FormattingEnabled = True
        Me.trabajoCB.Items.AddRange(New Object() {"Panadero", "Mostrador"})
        Me.trabajoCB.Location = New System.Drawing.Point(148, 309)
        Me.trabajoCB.Margin = New System.Windows.Forms.Padding(4)
        Me.trabajoCB.Name = "trabajoCB"
        Me.trabajoCB.Size = New System.Drawing.Size(160, 24)
        Me.trabajoCB.TabIndex = 37
        '
        'apellidoTB
        '
        Me.apellidoTB.Location = New System.Drawing.Point(148, 172)
        Me.apellidoTB.Margin = New System.Windows.Forms.Padding(4)
        Me.apellidoTB.Name = "apellidoTB"
        Me.apellidoTB.Size = New System.Drawing.Size(285, 22)
        Me.apellidoTB.TabIndex = 33
        '
        'nombreTB
        '
        Me.nombreTB.Location = New System.Drawing.Point(148, 123)
        Me.nombreTB.Margin = New System.Windows.Forms.Padding(4)
        Me.nombreTB.Name = "nombreTB"
        Me.nombreTB.Size = New System.Drawing.Size(285, 22)
        Me.nombreTB.TabIndex = 32
        '
        'codigoTB
        '
        Me.codigoTB.Location = New System.Drawing.Point(148, 77)
        Me.codigoTB.Margin = New System.Windows.Forms.Padding(4)
        Me.codigoTB.Name = "codigoTB"
        Me.codigoTB.Size = New System.Drawing.Size(132, 22)
        Me.codigoTB.TabIndex = 31
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 496)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(84, 496)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 399)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "* Telefono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(70, 312)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "* Trabajo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(93, 266)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Edad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "* Primer apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "* Primer nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "* Codigo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(114, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "REGISTRO DE PERSONAL"
        '
        'salarioTB
        '
        Me.salarioTB.Location = New System.Drawing.Point(148, 353)
        Me.salarioTB.Name = "salarioTB"
        Me.salarioTB.Size = New System.Drawing.Size(100, 22)
        Me.salarioTB.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(75, 356)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "* Salario:"
        '
        'telefonoTB
        '
        Me.telefonoTB.Location = New System.Drawing.Point(145, 396)
        Me.telefonoTB.Margin = New System.Windows.Forms.Padding(4)
        Me.telefonoTB.Name = "telefonoTB"
        Me.telefonoTB.Size = New System.Drawing.Size(165, 22)
        Me.telefonoTB.TabIndex = 42
        '
        'agregarempleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(486, 580)
        Me.Controls.Add(Me.telefonoTB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.salarioTB)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.femaleRB)
        Me.Controls.Add(Me.maleRB)
        Me.Controls.Add(Me.trabajoCB)
        Me.Controls.Add(Me.apellidoTB)
        Me.Controls.Add(Me.nombreTB)
        Me.Controls.Add(Me.codigoTB)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "agregarempleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregarempleado"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents femaleRB As System.Windows.Forms.RadioButton
    Friend WithEvents maleRB As System.Windows.Forms.RadioButton
    Friend WithEvents trabajoCB As System.Windows.Forms.ComboBox
    Friend WithEvents apellidoTB As System.Windows.Forms.TextBox
    Friend WithEvents nombreTB As System.Windows.Forms.TextBox
    Friend WithEvents codigoTB As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents salarioTB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents telefonoTB As System.Windows.Forms.TextBox
End Class
