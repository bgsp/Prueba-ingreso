<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.catalogoPB = New System.Windows.Forms.PictureBox()
        Me.empleadosPB = New System.Windows.Forms.PictureBox()
        Me.registroPB = New System.Windows.Forms.PictureBox()
        Me.salirPB = New System.Windows.Forms.PictureBox()
        Me.proveedorPB = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerRegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbproductos = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvProd = New System.Windows.Forms.DataGridView()
        Me.gbProv = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvProv = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbListaprod = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.catalogoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empleadosPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.registroPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salirPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.proveedorPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.gbproductos.SuspendLayout()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProv.SuspendLayout()
        CType(Me.dgvProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbListaprod.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'catalogoPB
        '
        Me.catalogoPB.Image = CType(resources.GetObject("catalogoPB.Image"), System.Drawing.Image)
        Me.catalogoPB.Location = New System.Drawing.Point(30, 38)
        Me.catalogoPB.Name = "catalogoPB"
        Me.catalogoPB.Size = New System.Drawing.Size(110, 90)
        Me.catalogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.catalogoPB.TabIndex = 0
        Me.catalogoPB.TabStop = False
        '
        'empleadosPB
        '
        Me.empleadosPB.Image = CType(resources.GetObject("empleadosPB.Image"), System.Drawing.Image)
        Me.empleadosPB.Location = New System.Drawing.Point(30, 263)
        Me.empleadosPB.Name = "empleadosPB"
        Me.empleadosPB.Size = New System.Drawing.Size(110, 83)
        Me.empleadosPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.empleadosPB.TabIndex = 1
        Me.empleadosPB.TabStop = False
        '
        'registroPB
        '
        Me.registroPB.Image = CType(resources.GetObject("registroPB.Image"), System.Drawing.Image)
        Me.registroPB.Location = New System.Drawing.Point(30, 368)
        Me.registroPB.Name = "registroPB"
        Me.registroPB.Size = New System.Drawing.Size(110, 88)
        Me.registroPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.registroPB.TabIndex = 3
        Me.registroPB.TabStop = False
        '
        'salirPB
        '
        Me.salirPB.Image = CType(resources.GetObject("salirPB.Image"), System.Drawing.Image)
        Me.salirPB.Location = New System.Drawing.Point(32, 499)
        Me.salirPB.Name = "salirPB"
        Me.salirPB.Size = New System.Drawing.Size(97, 38)
        Me.salirPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.salirPB.TabIndex = 4
        Me.salirPB.TabStop = False
        '
        'proveedorPB
        '
        Me.proveedorPB.Image = CType(resources.GetObject("proveedorPB.Image"), System.Drawing.Image)
        Me.proveedorPB.Location = New System.Drawing.Point(29, 147)
        Me.proveedorPB.Name = "proveedorPB"
        Me.proveedorPB.Size = New System.Drawing.Size(111, 101)
        Me.proveedorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.proveedorPB.TabIndex = 2
        Me.proveedorPB.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PROVEEDORES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "EMPLEADOS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.CatalogoToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.RegistrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1025, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProductoToolStripMenuItem, Me.EliminarProductoToolStripMenuItem, Me.EditarProductoToolStripMenuItem})
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.CatalogoToolStripMenuItem.Text = "Productos"
        '
        'AgregarProductoToolStripMenuItem
        '
        Me.AgregarProductoToolStripMenuItem.Name = "AgregarProductoToolStripMenuItem"
        Me.AgregarProductoToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AgregarProductoToolStripMenuItem.Text = "Agregar producto"
        '
        'EliminarProductoToolStripMenuItem
        '
        Me.EliminarProductoToolStripMenuItem.Name = "EliminarProductoToolStripMenuItem"
        Me.EliminarProductoToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EliminarProductoToolStripMenuItem.Text = "Eliminar producto"
        '
        'EditarProductoToolStripMenuItem
        '
        Me.EditarProductoToolStripMenuItem.Name = "EditarProductoToolStripMenuItem"
        Me.EditarProductoToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EditarProductoToolStripMenuItem.Text = "Editar producto"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem1, Me.EditarToolStripMenuItem1, Me.EliminarToolStripMenuItem1})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'AgregarToolStripMenuItem1
        '
        Me.AgregarToolStripMenuItem1.Name = "AgregarToolStripMenuItem1"
        Me.AgregarToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.AgregarToolStripMenuItem1.Text = "Agregar"
        '
        'EditarToolStripMenuItem1
        '
        Me.EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
        Me.EditarToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem1.Text = "Editar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerRegistrosToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'VerRegistrosToolStripMenuItem
        '
        Me.VerRegistrosToolStripMenuItem.Name = "VerRegistrosToolStripMenuItem"
        Me.VerRegistrosToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.VerRegistrosToolStripMenuItem.Text = "Ventas"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 459)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "REGISTRO"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(6, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 34)
        Me.Panel1.TabIndex = 9
        '
        'gbproductos
        '
        Me.gbproductos.Controls.Add(Me.Button2)
        Me.gbproductos.Controls.Add(Me.Button1)
        Me.gbproductos.Controls.Add(Me.TextBox2)
        Me.gbproductos.Controls.Add(Me.Label6)
        Me.gbproductos.Controls.Add(Me.Label5)
        Me.gbproductos.Controls.Add(Me.TextBox1)
        Me.gbproductos.Controls.Add(Me.Label4)
        Me.gbproductos.Controls.Add(Me.dgvProd)
        Me.gbproductos.Controls.Add(Me.Panel1)
        Me.gbproductos.Location = New System.Drawing.Point(146, 30)
        Me.gbproductos.Name = "gbproductos"
        Me.gbproductos.Size = New System.Drawing.Size(631, 507)
        Me.gbproductos.TabIndex = 10
        Me.gbproductos.TabStop = False
        Me.gbproductos.Text = "Productos"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(263, 469)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Agregar a lista"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(310, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 20)
        Me.TextBox2.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(342, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ID producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(159, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Buscar producto por:"
        '
        'dgvProd
        '
        Me.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProd.Location = New System.Drawing.Point(6, 84)
        Me.dgvProd.Name = "dgvProd"
        Me.dgvProd.ReadOnly = True
        Me.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProd.Size = New System.Drawing.Size(619, 379)
        Me.dgvProd.TabIndex = 10
        '
        'gbProv
        '
        Me.gbProv.Controls.Add(Me.Button5)
        Me.gbProv.Controls.Add(Me.Button6)
        Me.gbProv.Controls.Add(Me.TextBox4)
        Me.gbProv.Controls.Add(Me.Label8)
        Me.gbProv.Controls.Add(Me.Label9)
        Me.gbProv.Controls.Add(Me.TextBox5)
        Me.gbProv.Controls.Add(Me.Label10)
        Me.gbProv.Controls.Add(Me.dgvProv)
        Me.gbProv.Controls.Add(Me.Panel2)
        Me.gbProv.Location = New System.Drawing.Point(140, 30)
        Me.gbProv.Name = "gbProv"
        Me.gbProv.Size = New System.Drawing.Size(867, 507)
        Me.gbProv.TabIndex = 17
        Me.gbProv.TabStop = False
        Me.gbProv.Text = "Proveedores"
        Me.gbProv.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(263, 469)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Agregar a lista"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(24, 469)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Actualizar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(310, 30)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(130, 20)
        Me.TextBox4.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(354, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "RUT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(203, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Nombre"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(159, 30)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(130, 20)
        Me.TextBox5.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Buscar proveedor por:"
        '
        'dgvProv
        '
        Me.dgvProv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProv.Location = New System.Drawing.Point(17, 84)
        Me.dgvProv.Name = "dgvProv"
        Me.dgvProv.ReadOnly = True
        Me.dgvProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProv.Size = New System.Drawing.Size(619, 328)
        Me.dgvProv.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(17, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(619, 34)
        Me.Panel2.TabIndex = 9
        '
        'gbListaprod
        '
        Me.gbListaprod.Controls.Add(Me.TextBox3)
        Me.gbListaprod.Controls.Add(Me.Label7)
        Me.gbListaprod.Controls.Add(Me.DataGridView2)
        Me.gbListaprod.Controls.Add(Me.Button4)
        Me.gbListaprod.Controls.Add(Me.Button3)
        Me.gbListaprod.Location = New System.Drawing.Point(783, 30)
        Me.gbListaprod.Name = "gbListaprod"
        Me.gbListaprod.Size = New System.Drawing.Size(230, 507)
        Me.gbListaprod.TabIndex = 11
        Me.gbListaprod.TabStop = False
        Me.gbListaprod.Text = "Lista de compra"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(86, 430)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(138, 20)
        Me.TextBox3.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 433)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "TOTAL:"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(218, 399)
        Me.DataGridView2.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(119, 461)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Finalizar compra"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(23, 461)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Eliminar de lista"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1025, 562)
        Me.Controls.Add(Me.gbProv)
        Me.Controls.Add(Me.gbListaprod)
        Me.Controls.Add(Me.gbproductos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.salirPB)
        Me.Controls.Add(Me.registroPB)
        Me.Controls.Add(Me.proveedorPB)
        Me.Controls.Add(Me.empleadosPB)
        Me.Controls.Add(Me.catalogoPB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.catalogoPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empleadosPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.registroPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salirPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.proveedorPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbproductos.ResumeLayout(False)
        Me.gbproductos.PerformLayout()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProv.ResumeLayout(False)
        Me.gbProv.PerformLayout()
        CType(Me.dgvProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbListaprod.ResumeLayout(False)
        Me.gbListaprod.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents catalogoPB As System.Windows.Forms.PictureBox
    Friend WithEvents empleadosPB As System.Windows.Forms.PictureBox
    Friend WithEvents registroPB As System.Windows.Forms.PictureBox
    Friend WithEvents salirPB As System.Windows.Forms.PictureBox
    Friend WithEvents proveedorPB As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerRegistrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbproductos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProd As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents gbListaprod As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents gbProv As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvProv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
