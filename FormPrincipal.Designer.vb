<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.MenuIzq = New System.Windows.Forms.Panel()
        Me.BtnTbGanancias = New FontAwesome.Sharp.IconButton()
        Me.BtnTbEmpleados = New FontAwesome.Sharp.IconButton()
        Me.BtnTbDetFactura = New FontAwesome.Sharp.IconButton()
        Me.BtnTbFacturas = New FontAwesome.Sharp.IconButton()
        Me.BtnTbAbonos = New FontAwesome.Sharp.IconButton()
        Me.BtnTbProductos = New FontAwesome.Sharp.IconButton()
        Me.BtnTbProveedor = New FontAwesome.Sharp.IconButton()
        Me.BtnTbClientes = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.LibreriaDataSet = New Libreria.LibreriaDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuIzq.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuIzq
        '
        Me.MenuIzq.AutoScroll = True
        Me.MenuIzq.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.MenuIzq.Controls.Add(Me.BtnTbGanancias)
        Me.MenuIzq.Controls.Add(Me.BtnTbEmpleados)
        Me.MenuIzq.Controls.Add(Me.BtnTbDetFactura)
        Me.MenuIzq.Controls.Add(Me.BtnTbFacturas)
        Me.MenuIzq.Controls.Add(Me.BtnTbAbonos)
        Me.MenuIzq.Controls.Add(Me.BtnTbProductos)
        Me.MenuIzq.Controls.Add(Me.BtnTbProveedor)
        Me.MenuIzq.Controls.Add(Me.BtnTbClientes)
        Me.MenuIzq.Controls.Add(Me.PanelLogo)
        Me.MenuIzq.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuIzq.Location = New System.Drawing.Point(0, 0)
        Me.MenuIzq.Name = "MenuIzq"
        Me.MenuIzq.Size = New System.Drawing.Size(238, 561)
        Me.MenuIzq.TabIndex = 2
        '
        'BtnTbGanancias
        '
        Me.BtnTbGanancias.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTbGanancias.FlatAppearance.BorderSize = 0
        Me.BtnTbGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTbGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTbGanancias.ForeColor = System.Drawing.Color.White
        Me.BtnTbGanancias.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.BtnTbGanancias.IconColor = System.Drawing.Color.White
        Me.BtnTbGanancias.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTbGanancias.IconSize = 25
        Me.BtnTbGanancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbGanancias.Location = New System.Drawing.Point(0, 457)
        Me.BtnTbGanancias.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTbGanancias.Name = "BtnTbGanancias"
        Me.BtnTbGanancias.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnTbGanancias.Size = New System.Drawing.Size(238, 50)
        Me.BtnTbGanancias.TabIndex = 15
        Me.BtnTbGanancias.Text = "Ganancias"
        Me.BtnTbGanancias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbGanancias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTbGanancias.UseVisualStyleBackColor = True
        '
        'BtnTbEmpleados
        '
        Me.BtnTbEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTbEmpleados.FlatAppearance.BorderSize = 0
        Me.BtnTbEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTbEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTbEmpleados.ForeColor = System.Drawing.Color.White
        Me.BtnTbEmpleados.IconChar = FontAwesome.Sharp.IconChar.ThList
        Me.BtnTbEmpleados.IconColor = System.Drawing.Color.White
        Me.BtnTbEmpleados.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTbEmpleados.IconSize = 25
        Me.BtnTbEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbEmpleados.Location = New System.Drawing.Point(0, 407)
        Me.BtnTbEmpleados.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTbEmpleados.Name = "BtnTbEmpleados"
        Me.BtnTbEmpleados.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnTbEmpleados.Size = New System.Drawing.Size(238, 50)
        Me.BtnTbEmpleados.TabIndex = 14
        Me.BtnTbEmpleados.Text = "Empleados"
        Me.BtnTbEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTbEmpleados.UseVisualStyleBackColor = True
        '
        'BtnTbDetFactura
        '
        Me.BtnTbDetFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTbDetFactura.FlatAppearance.BorderSize = 0
        Me.BtnTbDetFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTbDetFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTbDetFactura.ForeColor = System.Drawing.Color.White
        Me.BtnTbDetFactura.IconChar = FontAwesome.Sharp.IconChar.Poll
        Me.BtnTbDetFactura.IconColor = System.Drawing.Color.White
        Me.BtnTbDetFactura.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTbDetFactura.IconSize = 25
        Me.BtnTbDetFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbDetFactura.Location = New System.Drawing.Point(0, 357)
        Me.BtnTbDetFactura.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTbDetFactura.Name = "BtnTbDetFactura"
        Me.BtnTbDetFactura.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnTbDetFactura.Size = New System.Drawing.Size(238, 50)
        Me.BtnTbDetFactura.TabIndex = 13
        Me.BtnTbDetFactura.Text = "Detalles de Factura"
        Me.BtnTbDetFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbDetFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTbDetFactura.UseVisualStyleBackColor = True
        '
        'BtnTbFacturas
        '
        Me.BtnTbFacturas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTbFacturas.FlatAppearance.BorderSize = 0
        Me.BtnTbFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTbFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTbFacturas.ForeColor = System.Drawing.Color.White
        Me.BtnTbFacturas.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar
        Me.BtnTbFacturas.IconColor = System.Drawing.Color.White
        Me.BtnTbFacturas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTbFacturas.IconSize = 25
        Me.BtnTbFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbFacturas.Location = New System.Drawing.Point(0, 307)
        Me.BtnTbFacturas.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTbFacturas.Name = "BtnTbFacturas"
        Me.BtnTbFacturas.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnTbFacturas.Size = New System.Drawing.Size(238, 50)
        Me.BtnTbFacturas.TabIndex = 12
        Me.BtnTbFacturas.Text = "Facturas"
        Me.BtnTbFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTbFacturas.UseVisualStyleBackColor = True
        '
        'BtnTbAbonos
        '
        Me.BtnTbAbonos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTbAbonos.FlatAppearance.BorderSize = 0
        Me.BtnTbAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTbAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTbAbonos.ForeColor = System.Drawing.Color.White
        Me.BtnTbAbonos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt
        Me.BtnTbAbonos.IconColor = System.Drawing.Color.White
        Me.BtnTbAbonos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTbAbonos.IconSize = 25
        Me.BtnTbAbonos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbAbonos.Location = New System.Drawing.Point(0, 257)
        Me.BtnTbAbonos.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTbAbonos.Name = "BtnTbAbonos"
        Me.BtnTbAbonos.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnTbAbonos.Size = New System.Drawing.Size(238, 50)
        Me.BtnTbAbonos.TabIndex = 11
        Me.BtnTbAbonos.Text = "Abonos"
        Me.BtnTbAbonos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbAbonos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTbAbonos.UseVisualStyleBackColor = True
        '
        'BtnTbProductos
        '
        Me.BtnTbProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTbProductos.FlatAppearance.BorderSize = 0
        Me.BtnTbProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTbProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTbProductos.ForeColor = System.Drawing.Color.White
        Me.BtnTbProductos.IconChar = FontAwesome.Sharp.IconChar.LayerGroup
        Me.BtnTbProductos.IconColor = System.Drawing.Color.White
        Me.BtnTbProductos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTbProductos.IconSize = 25
        Me.BtnTbProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbProductos.Location = New System.Drawing.Point(0, 207)
        Me.BtnTbProductos.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTbProductos.Name = "BtnTbProductos"
        Me.BtnTbProductos.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnTbProductos.Size = New System.Drawing.Size(238, 50)
        Me.BtnTbProductos.TabIndex = 10
        Me.BtnTbProductos.Text = "Productos"
        Me.BtnTbProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTbProductos.UseVisualStyleBackColor = True
        '
        'BtnTbProveedor
        '
        Me.BtnTbProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTbProveedor.FlatAppearance.BorderSize = 0
        Me.BtnTbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTbProveedor.ForeColor = System.Drawing.Color.White
        Me.BtnTbProveedor.IconChar = FontAwesome.Sharp.IconChar.Dolly
        Me.BtnTbProveedor.IconColor = System.Drawing.Color.White
        Me.BtnTbProveedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTbProveedor.IconSize = 25
        Me.BtnTbProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbProveedor.Location = New System.Drawing.Point(0, 157)
        Me.BtnTbProveedor.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTbProveedor.Name = "BtnTbProveedor"
        Me.BtnTbProveedor.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnTbProveedor.Size = New System.Drawing.Size(238, 50)
        Me.BtnTbProveedor.TabIndex = 9
        Me.BtnTbProveedor.Text = "Proveedores"
        Me.BtnTbProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTbProveedor.UseVisualStyleBackColor = True
        '
        'BtnTbClientes
        '
        Me.BtnTbClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTbClientes.FlatAppearance.BorderSize = 0
        Me.BtnTbClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTbClientes.ForeColor = System.Drawing.Color.White
        Me.BtnTbClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.BtnTbClientes.IconColor = System.Drawing.Color.White
        Me.BtnTbClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTbClientes.IconSize = 25
        Me.BtnTbClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbClientes.Location = New System.Drawing.Point(0, 107)
        Me.BtnTbClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTbClientes.Name = "BtnTbClientes"
        Me.BtnTbClientes.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnTbClientes.Size = New System.Drawing.Size(238, 50)
        Me.BtnTbClientes.TabIndex = 8
        Me.BtnTbClientes.Text = "Clientes"
        Me.BtnTbClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTbClientes.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(238, 107)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(238, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(896, 561)
        Me.PanelPrincipal.TabIndex = 4
        '
        'LibreriaDataSet
        '
        Me.LibreriaDataSet.DataSetName = "LibreriaDataSet"
        Me.LibreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.LibreriaDataSet
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1134, 561)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.MenuIzq)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuIzq.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuIzq As Panel
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents LibreriaDataSet As LibreriaDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnTbGanancias As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnTbEmpleados As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnTbDetFactura As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnTbFacturas As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnTbAbonos As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnTbProductos As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnTbProveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnTbClientes As FontAwesome.Sharp.IconButton
End Class
